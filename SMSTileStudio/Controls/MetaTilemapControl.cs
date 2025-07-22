// 
// SMS Tile Studio
// Copyright (C) 2022 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using SMSTileStudio.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMSTileStudio.Controls
{
    public partial class MetaTilemapControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event PositionChangedHandler PositionChanged;
        public delegate void PositionChangedHandler();

        private bool _useGrid = true;
        private bool _invertGridColor;
        private bool _showIds = false;
        private int _antOffset = 0;
        private Timer _scrollTimer = new Timer();
        private Timer _antsTimer = new Timer();
        private Rectangle _selection = Rectangle.Empty;
        private Point _selectOrigin = Point.Empty;
        private Point _scrollCapture = Point.Empty;

        /// <summary>
        /// Properties
        /// </summary>
        public Bitmap TilemapImage { get; set; }
        public Rectangle Selection { get { return _selection; } }
        public List<int> MetaTilemapIds { get; set; }
        public Size MetaTileSize { get; set; } = Size.Empty;
        public Size MetaTilemapSize { get; set; } = Size.Empty;
        public string MetaTilemapProperties { get; set; } = "N/A";
        public Point Position { get; private set; }
        public bool ShowIds { get { return _showIds; } set { _showIds = value; Invalidate(); } }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool InvertGridColor { get { return _invertGridColor; } set { _invertGridColor = value; UpdateBackBuffer(); } }
        public TileEditType EditMode { get; set; }

        public MetaTilemapControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();

            _scrollTimer.Interval = 1;
            _scrollTimer.Tick += new EventHandler(scrollTimer_Tick);
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawMetaTileIds(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null)
                return;

            DrawGrid(gfx, origin);
            DrawSelection(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            Size snap = SnapSize;
            int x = (e.Location.X - rect.X) / ImageScale / snap.Width * snap.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / snap.Height * snap.Height;

            // Set default scroll position and start the auto scroll timer
            _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
            _scrollTimer.Start();
            _selectOrigin = new Point(x, y);
            _selection = new Rectangle(new Point(x, y), snap);

            UpdateBackBuffer();
        }

        /// <summary>
        /// On mouse move
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Point origin = GetOrigin();

            if (Image == null)
                return;

            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            // Set selection if snap position changed
            int x = (e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height;
            if (x != Position.X || y != Position.Y)
            {
                Position = new Point(x, y);
                PositionChanged?.Invoke();
            }

            if (e.Button != MouseButtons.Left || (x == _selection.X && y == _selection.Y))
                return;

            _selection = GetRectangle(_selectOrigin, new Point(x, y));

            if (_selection.X >= _selectOrigin.X)
                _selection.Width += SnapSize.Width;

            if (_selection.Y >= _selectOrigin.Y)
                _selection.Height += SnapSize.Height;

            PositionChanged?.Invoke();
        }

        /// <summary>
        /// On mouse up
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _scrollTimer.Stop();
        }

        /// <summary>
        /// Gets a rectangle from two points
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns>Rectangle</returns>
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        /// <summary>
        /// Draw grid cells
        /// </summary>
        private void DrawSelection(Graphics gfx, Point origin)
        {
            if (Image == null || _selection == Rectangle.Empty)
                return;

            using (Pen pen = new Pen(Color.White, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 4, 4 };
                pen.DashOffset = _antOffset;
                Rectangle rect = _selection;
                rect.X += origin.X;
                rect.Y += origin.Y;
                rect.Width -= 1;
                rect.Height -= 1;
                gfx.DrawRectangle(Pens.Black, rect);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Draw grid cells
        /// </summary>
        private void DrawGrid(Graphics gfx, Point origin)
        {
            if (!UseGrid || Image == null)
                return;

            int cols = (int)Math.Floor(Image.Width / (double)(SnapSize.Width));
            int rows = (int)Math.Floor(Image.Height / (double)(SnapSize.Height));
            Rectangle cell = new Rectangle(0, 0, SnapSize.Width, SnapSize.Height);
            using (Pen gridPen = new Pen(Color.FromArgb(80, _invertGridColor ? Color.White : Color.Black)))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        cell.X = (col * SnapSize.Width) + origin.X;
                        cell.Y = (row * SnapSize.Height) + origin.Y;
                        gfx.DrawRectangle(gridPen, cell);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        private void DrawMetaTileIds(Graphics gfx, Point origin)
        {
            if (Image == null || MetaTilemapIds == null || MetaTilemapIds.Count <= 0 || ShowIds == false)
            {
                return;
            }

            int index = 0;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < MetaTilemapSize.Height; row++)
            {
                for (int col = 0; col < MetaTilemapSize.Width; col++)
                {
                    if (index >= MetaTilemapIds.Count)
                        break;

                    var value = MetaTilemapIds[index].ToString();
                    Point point = new Point((col * (MetaTileSize.Width)  * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * (MetaTileSize.Height) * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                    RectangleF rect = new RectangleF(point.X, point.Y, MetaTileSize.Width * ImageScale, MetaTileSize.Height * ImageScale);
                    BitmapUtility.DrawTextOutline(gfx, value, font, Brushes.Black, rect, format);
                    gfx.DrawString(value, font, Brushes.White, rect, format);
                    index++;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateTilemap()
        {
            if (Image == null || BackgroundImage == null)
                return;

            int cols = BackgroundImage.Width / MetaTileSize.Width;
            int rows = BackgroundImage.Height / MetaTileSize.Height;
            Rectangle dest = new Rectangle(0, 0, MetaTileSize.Width + 1, MetaTileSize.Height + 1);
            using (var gfx = Graphics.FromImage(Image))
            {
                using (var pen = new Pen(_invertGridColor ? Color.White : Color.Black))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            // Set destination rectangle position
                            dest.X = col * dest.Width;
                            dest.Y = row * dest.Height;
                            gfx.DrawRectangle(pen, dest);
                        }
                    }
                }
            }
            UpdateBackBuffer();
        }

        /// <summary>
        /// Marching ants timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            _antOffset++;

            if (_antOffset % 8 == 0)
                _antOffset = 0;

            if (_selection != Rectangle.Empty)
                UpdateBackBuffer();
        }

        /// <summary>
        /// Scroll timer tick
        /// </summary>
        private void scrollTimer_Tick(object sender, EventArgs e)
        {
            // If the left mouse button is not being pressed, return
            if (Control.MouseButtons != MouseButtons.Left)
                return;

            // Get the mouse position, set scroll speed
            Point p = PointToClient(Cursor.Position);
            int speed = 6 * ImageScale;

            // If the selection hits the edge of the client area, increment scroll
            if (p.X > ClientSize.Width)
                _scrollCapture = new Point(_scrollCapture.X + speed, _scrollCapture.Y);
            if (p.X < 0)
                _scrollCapture = new Point(_scrollCapture.X - speed, _scrollCapture.Y);
            if (p.Y > ClientSize.Height)
                _scrollCapture = new Point(_scrollCapture.X, _scrollCapture.Y + speed);
            if (p.Y < 0)
                _scrollCapture = new Point(_scrollCapture.X, _scrollCapture.Y - speed);

            // Set autoscroll position, update rendering
            AutoScrollPosition = _scrollCapture;
            OnMouseMove(new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="metaTileSize"></param>
        public void SetMetaTiles(List<int> metaTilemapIds, Bitmap image, Size metaTileSize)
        {
            if (image.Width < metaTileSize.Width || image.Height < metaTileSize.Height)
            {
                MessageBox.Show("Tilemap size must be equal to or larger than a single meta tile", "SMS Tile Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SnapSize = metaTileSize;
            ImageScale = metaTileSize.Width == 32 ? 1 : metaTileSize.Width == 16 ? 1 : 2;
            MinimumScale = 1;
            int cols = image.Width / metaTileSize.Width;
            int rows = image.Height / metaTileSize.Height;
            var tilemap = new Bitmap(image.Width, image.Height, image.PixelFormat);
            Rectangle src = new Rectangle(0, 0, metaTileSize.Width, metaTileSize.Height);
            Rectangle dest = new Rectangle(0, 0, metaTileSize.Width, metaTileSize.Height);
            MetaTileSize = metaTileSize;
            MetaTilemapSize = new Size(cols, rows);
            MetaTilemapIds = metaTilemapIds.DeepClone();
            BackgroundImage = image.DeepClone();
            Image = tilemap;
            using (var gfx = Graphics.FromImage(Image))
            {
                using (var pen = new Pen(_invertGridColor ? Color.White : Color.Black))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            // Set copy rectangle position
                            src.X = col * src.Width;
                            src.Y = row * src.Height;
                            // Set destination rectangle position
                            dest.X = col * dest.Width;
                            dest.Y = row * dest.Height;
                            gfx.DrawRectangle(pen, dest);
                            using (var tile = image.Clone(src, image.PixelFormat))
                            {
                                gfx.DrawImageUnscaled(tile, new Point(dest.X, dest.Y));
                            }
                        }
                    }
                }
            }

            MetaTilemapProperties = $"Cols: {cols} | Rows: {rows} | Bytes: {cols * rows}";
            UpdateBackBuffer();
        }

        /// <summary>
        /// Clear tile selection
        /// </summary>
        public void ClearSelection()
        {
            _selection = Rectangle.Empty;
            _selectOrigin = Point.Empty;
            UpdateBackBuffer();
            Invalidate();
        }

        /// <summary>
        /// Clears control
        /// </summary>
        public void Clear()
        {
            Image = null;
            BackgroundImage = null;
            MetaTilemapIds?.Clear();
            MetaTilemapIds = null;
            MetaTileSize = Size.Empty;
            MetaTilemapSize = Size.Empty;
            MetaTilemapProperties = "N/A";
            _selection = Rectangle.Empty;
            UpdateBackBuffer();
        }
    }
}
