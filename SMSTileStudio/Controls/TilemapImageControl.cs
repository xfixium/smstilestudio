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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class TilemapImageControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event SelectedIndexChangedHandler SelectedIndexChanged;
        public delegate void SelectedIndexChangedHandler();
        private bool _indexed = false;
        private int _columns = 0;
        private int _rows = 0;
        private int _antOffset = 0;
        private Timer _antsTimer = new Timer();
        private List<Tile> _tiles = new List<Tile>();
        private int _selectedIndex = -1;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Tile> Tiles
        {
            get
            {
                List<Tile> tiles = new List<Tile>();
                foreach (Tile tile in _tiles)
                    tiles.Add(tile.DeepClone());
                return tiles;
            }
        }
        public int SelectedIndex { get { return _selectedIndex; } set { _selectedIndex = value; UpdateBackBuffer(); } }
        public bool Indexed
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                MinimumScale = _indexed ? 3 : 1;
                ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public TilemapImageControl()
        {
            InitializeComponent();
            if (DesignMode)
                return;

            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null)
                return;

            DrawSelections(gfx, origin);
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
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

            if (_selectedIndex > -1)
                UpdateBackBuffer();
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || _tiles.Count <= 0)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            int x = (e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height;
            Rectangle selection = new Rectangle(new Point(x, y), SnapSize);
            int cols = Image.Width / SnapSize.Width;
            int col = selection.X / SnapSize.Width;
            int row = selection.Y / SnapSize.Height;
            int index = (row * cols) + col;
            if (index >= _tiles.Count)
                return;

            _selectedIndex = _tiles[index].TileID;
            SelectedIndexChanged?.Invoke();
            UpdateBackBuffer();
        }

        /// <summary>
        /// Draws the selected tiles rectangles
        /// </summary>
        private void DrawSelections(Graphics gfx, Point origin)
        {
            if (Image == null || _tiles.Count <= 0 || _selectedIndex <= -1)
                return;

            int index = 0;
            Rectangle cell = new Rectangle(0, 0, SnapSize.Width, SnapSize.Height);
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    if (_tiles[index].TileID == _selectedIndex)
                    {
                        cell.X = (col * SnapSize.Width) + origin.X;
                        cell.Y = (row * SnapSize.Height) + origin.Y;
                        using (Pen pen = new Pen(Color.White, 1))
                        {
                            pen.DashStyle = DashStyle.Dash;
                            pen.DashPattern = new float[2] { 4, 4 };
                            pen.DashOffset = _antOffset;
                            Rectangle rect = cell;
                            gfx.DrawRectangle(Pens.Black, rect);
                            gfx.DrawRectangle(pen, rect);
                        }
                    }

                    index++;
                }
            }
        }

        /// <summary>
        /// Draws palette indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (!Indexed || _tiles == null || _tiles.Count <= 0)
                return;

            int index = 0;
            Size gridSize = GetTransformedSnap(Canvas);
            int cols = gridSize.Width;
            int rows = gridSize.Height;
            Font font = new Font("Segoe UI", 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (index < _tiles.Count)
                    {
                        var palette = _tiles[index].UseBGPalette ? "BG" : "SPR";
                        Point point = new Point((col * SnapSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                        BitmapUtility.DrawTextOutline(gfx, palette, font, Brushes.Black, rect, format);
                        gfx.DrawString(palette, font, Brushes.White, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Sets selected tiles
        /// </summary>
        /// <param name="tiles"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public void SetTiles(List<Tile> tiles, int cols, int rows)
        {
            _tiles = tiles.DeepClone();
            _columns = cols;
            _rows = rows;
            _selectedIndex = -1;
            UpdateBackBuffer();
        }
    }
}
