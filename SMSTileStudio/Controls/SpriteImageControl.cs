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
    public partial class SpriteImageControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileChangedHandler TileChanged;
        public delegate void TileChangedHandler();
        //public event PositionChangedHandler PositionChanged;
        //public delegate void PositionChangedHandler();
        private SpriteModeType _editMode = SpriteModeType.Normal;
        private int _antOffset = 0;
        private Timer _antsTimer = new Timer();
        private Rectangle _selection = Rectangle.Empty;
        private Point _selectOrigin = Point.Empty;
        private Point _brushOrigin = Point.Empty;
        private List<MetaSpriteFrame> _frames = new List<MetaSpriteFrame>();
        private int _frameIndex = -1;

        /// <summary>
        /// Properties
        /// </summary>
        public List<MetaSpriteFrame> Frames
        {
            get
            {
                List<MetaSpriteFrame> frames = new List<MetaSpriteFrame>();
                foreach (MetaSpriteFrame frame in _frames)
                    frames.Add(frame.DeepClone());
                return frames;
            }
        }
        public SpriteModeType EditMode { get { return _editMode; } set { _editMode = value; UpdateBackBuffer(); } }
        public int FrameIndex { get { return _frameIndex; } set { _frameIndex = value; UpdateBackBuffer(); } }

        /// <summary>
        /// Constructors
        /// </summary>
        public SpriteImageControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            _antsTimer.Interval = 100;
            _antsTimer.Tick += new EventHandler(Timer_Tick);
            _antsTimer.Start();
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
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {

        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null || _frames.Count <= 0)
                return;

            DrawSelection(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || _frames.Count <= 0)
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
            if (index >= _frames.Count)
                return;

            TileChanged?.Invoke();
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

            if (e.Button != MouseButtons.Left || (x == _selection.X && y == _selection.Y))
                return;

            _selection = GetRectangle(_selectOrigin, new Point(x, y));

            if (_selection.X >= _selectOrigin.X)
                _selection.Width += SnapSize.Width;

            if (_selection.Y >= _selectOrigin.Y)
                _selection.Height += SnapSize.Height;
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
            if (Image == null || _frames.Count <= 0)
                return;

            using (Pen pen = new Pen(Color.White, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 4, 4 };
                pen.DashOffset = _antOffset;
                Rectangle rect = _selection;
                rect.X += origin.X;
                rect.Y += origin.Y;
                gfx.DrawRectangle(Pens.Black, rect);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Creates a brush from a selection
        /// </summary>
        public void CreateFrame(Tileset tileset, Palette bgPalette, Palette sprPalette)
        {
            if (_selection == Rectangle.Empty)
                return;
        }

        /// <summary>
        /// Creates a tilemap from selection
        /// </summary>
        /// <returns></returns>
        public MetaSpriteFrame SelectionToFrame()
        {
            return null;
        }

        /// <summary>
        /// Clear tile selection
        /// </summary>
        public void ClearSelection()
        {
            _selection = Rectangle.Empty;
            _selectOrigin = Point.Empty;
            Invalidate();
        }
    }
}
