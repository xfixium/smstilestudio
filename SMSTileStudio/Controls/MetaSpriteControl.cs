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
    public partial class MetaSpriteControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event MetaSpriteChangedHandler MetaSpriteChanged;
        public delegate void MetaSpriteChangedHandler();
        private MetaSpriteEditType _editMode = MetaSpriteEditType.Sprites;
        private SpriteModeType _spriteMode = SpriteModeType.Normal;
        private bool _useGrid = true;
        private bool _showSprites = true;
        private bool _showCollisions = true;
        private bool _showOrigin = true;
        private bool _showTransparent = true;
        private bool _snapToGrid = true;
        private int _antOffset = 0;
        private Point _offset = new Point(128, 112);
        private Point _position = Point.Empty;
        private Timer _antsTimer = new Timer();
        private MetaSpriteFrame _frame = null;
        private List<Sprite> _selectedSprites = new List<Sprite>();
        private Palette _palette = null;
        private Rectangle _selectedCollision = Rectangle.Empty;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Sprite> SelectedSprites { get { return _selectedSprites; } set { _selectedSprites = value; UpdateBackBuffer(); } }
        public Palette Palette { set { _palette = value; UpdateBackBuffer(); } }
        public MetaSpriteEditType EditMode { get { return _editMode; } set { _editMode = value; UpdateBackBuffer(); } }
        public SpriteModeType SpriteMode { get { return _spriteMode; } set { _spriteMode = value; UpdateBackBuffer(); } }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool ShowSprites { get { return _showSprites; } set { _showSprites = value; UpdateBackBuffer(); } }
        public bool ShowCollisions { get { return _showCollisions; } set { _showCollisions = value; UpdateBackBuffer(); } }
        public bool ShowOrigin { get { return _showOrigin; } set { _showOrigin = value; UpdateBackBuffer(); } }
        public bool SnapToGrid { get { return _snapToGrid; } set { _snapToGrid = value; } }
        public bool ShowTransparent { get { return _showTransparent; } set { _showTransparent = value; UpdateBackBuffer(); } }
        public bool CtrlHeld { get; set; } = false;

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaSpriteControl()
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

            UpdateBackBuffer();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            //DrawAttributeValue(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null)
                return;

            DrawRects(gfx, origin);
            DrawGrid(gfx, origin);
            DrawOrigin(gfx, origin);
            DrawSprites(gfx, origin);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.ControlKey || e.KeyData == Keys.Control || e.KeyData == (Keys.ControlKey | Keys.Control))
            {
                CtrlHeld = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            CtrlHeld = false;
            base.OnKeyUp(e);
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
            Rectangle area = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (area.Contains(e.Location) == false)
                return;

            int x = ((e.Location.X - area.X) / ImageScale / SnapSize.Width * SnapSize.Width) - _offset.X;
            int y = ((e.Location.Y - area.Y) / ImageScale / SnapSize.Height * SnapSize.Height) - _offset.Y;
            int width = 8;
            int height = _spriteMode == SpriteModeType.Normal ? 8 : 16;
            _position = new Point(x, y);
            switch (_editMode)
            {
                case MetaSpriteEditType.Sprites:
                    var selected = new List<Sprite>();
                    // Check if clicked an already selected sprite, return
                    foreach (var sprite in _selectedSprites)
                    {
                        if (new Rectangle(sprite.X, sprite.Y, width, height).Contains(new Point(x, y)))
                        {
                            return;
                        }
                    }
                    // Get selected sprite
                    foreach (var sprite in _frame.Sprites)
                    {
                        if (new Rectangle(sprite.X, sprite.Y, width, height).Contains(new Point(x, y)))
                        {
                            if (CtrlHeld)
                            {
                                _selectedSprites.Add(sprite);
                            }
                            selected.Add(sprite);
                            break;
                        }
                    }
                    if (selected.Count <= 0)
                        return;
                    else if (!CtrlHeld)
                        _selectedSprites = selected;
                    break;

                case MetaSpriteEditType.Rects:
                    foreach (var collision in _frame.Collisions)
                    {
                        if (collision.Contains(new Point(x, y)))
                        {
                            _selectedCollision = collision;
                            break;
                        }
                    }
                    break;
            }

            MetaSpriteChanged?.Invoke();
            UpdateBackBuffer();
        }

        /// <summary>
        /// On mouse move
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            // Set selection if snap position changed
            int x = ((e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width) - _offset.X;
            int y = ((e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height) - _offset.Y;

            switch (_editMode)
            {
                case MetaSpriteEditType.Sprites:
                    // Move selection of sprites
                    foreach (var sprite in _selectedSprites)
                    {
                        sprite.X += x - _position.X;
                        sprite.Y += y - _position.Y;
                    }
                    // Update position
                    _position = new Point(x, y);
                    break;
                //case MetaSpriteEditType.Rects:
                //    if (_selectedCollision != null && (x != _selectedCollision.X || y != _selectedCollision.Y))
                //    {
                //        _selectedCollision.X = x;
                //        _selectedCollision.Y = y;
                //    }
                //break;
            }

            // Force redraw
            UpdateBackBuffer();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            MetaSpriteChanged?.Invoke();
            UpdateBackBuffer();
            base.OnMouseUp(e);
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
            using (Pen gridPen = new Pen(Color.FromArgb(80, Color.Black)))
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
        /// Draw grid cells
        /// </summary>
        private void DrawOrigin(Graphics gfx, Point origin)
        {
            if (!ShowOrigin || Image == null)
                return;

            gfx.DrawLine(Pens.Red, new Point(_offset.X + origin.X, origin.Y), new Point(_offset.X + origin.X, Image.Height + origin.Y));
            gfx.DrawLine(Pens.Red, new Point(origin.X, _offset.Y + origin.Y), new Point(Image.Width + origin.X, _offset.Y + origin.Y));
        }

        /// <summary>
        /// Draws meta sprite sprites
        /// </summary>
        private void DrawSprites(Graphics gfx, Point origin)
        {
            if (EditMode != MetaSpriteEditType.Sprites || Image == null || _frame == null)
                return;

            var height = SpriteMode == SpriteModeType.Normal ? 8 : 16;
            if (_frame != null)
            {
                using (var img = BitmapUtility.GetTilesetImage(255, _frame.Tileset, _palette, _showTransparent))
                {
                    foreach (var sprite in _frame.Sprites)
                    {
                        if (SpriteMode == SpriteModeType.Normal)
                        {
                            var rect = new Rectangle(sprite.TileID * 8, 0, 8, 8);
                            using (var tile = img.Clone(rect, img.PixelFormat))
                            {
                                gfx.DrawImageUnscaled(tile, sprite.X + origin.X + _offset.X, sprite.Y + origin.Y + _offset.Y);
                            }
                        }
                        else
                        {
                            using (var tile1 = img.Clone(new Rectangle(sprite.TileID * 8, 0, 8, 8), img.PixelFormat))
                            {
                                using (var tile2 = img.Clone(new Rectangle(sprite.TileID * 8 + 8, 0, 8, 8), img.PixelFormat))
                                {
                                    gfx.DrawImageUnscaled(tile1, sprite.X + origin.X + _offset.X, sprite.Y + origin.Y + _offset.Y);
                                    gfx.DrawImageUnscaled(tile2, sprite.X + origin.X + _offset.X, sprite.Y + origin.Y + 8 + _offset.Y);
                                }
                            }
                        }
                    }
                }
            }

            if (_showSprites)
            {
                using (Pen pen = new Pen(Color.White, 1))
                {
                    pen.DashStyle = DashStyle.Dash;
                    pen.DashPattern = new float[2] { 4, 4 };
                    pen.DashOffset = _antOffset;
                    foreach (var sprite in _selectedSprites)
                    {
                        var rect = new Rectangle(sprite.X + origin.X + _offset.X, sprite.Y + origin.Y + _offset.Y, 8, height);
                        gfx.DrawRectangle(Pens.Black, rect);
                        gfx.DrawRectangle(pen, rect);
                    }
                }
            }
        }

        /// <summary>
        /// Draws meta sprite collision rects
        /// </summary>
        private void DrawRects(Graphics gfx, Point origin)
        {
            if (EditMode != MetaSpriteEditType.Rects || Image == null || _frame == null || _selectedCollision == null || !_showCollisions)
                return;

            var rect = new Rectangle(_selectedCollision.X + origin.X, _selectedCollision.Y + origin.Y, _selectedCollision.Width, _selectedCollision.Height);
            gfx.DrawRectangle(Pens.Black, rect);
            rect.Inflate(-1, -1);
            gfx.DrawRectangle(Pens.Red, rect);
            rect.Inflate(-1, -1);
            gfx.DrawRectangle(Pens.Black, rect);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        public void LoadFrame(MetaSpriteFrame frame, SpriteModeType spriteMode)
        {
            _spriteMode = spriteMode;
            _frame = frame;
            UpdateBackBuffer();
        }

        /// <summary>
        /// Clears editor data
        /// </summary>
        public void Clear()
        {
            if (_frame != null)
            {
                _frame.Collisions.Clear();
                _frame.Sprites.Clear();
            }
            _frame = null;
            _selectedSprites.Clear();
            _selectedCollision = Rectangle.Empty;
            this.Image.Dispose();
            this.Image = new Bitmap(256, 224);
            UpdateBackBuffer();
        }
    }
}
