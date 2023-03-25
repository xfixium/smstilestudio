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
    public partial class TilemapControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileChangedHandler TileChanged;
        public delegate void TileChangedHandler();
        public event CollisionsChangedHandler CollisionsChanged;
        public delegate void CollisionsChangedHandler();
        public event EntitiesChangedHandler EntitiesChanged;
        public delegate void EntitiesChangedHandler();
        public event PositionChangedHandler PositionChanged;
        public delegate void PositionChangedHandler();

        private TileEditType _editMode = TileEditType.TileID;
        private Timer _scrollTimer = new Timer();
        private Point _scrollCapture = Point.Empty;
        private bool _useGrid = true;
        private bool _indexed = false;
        private bool _highlight = false;
        private bool _useOffset = false;
        private int _columns = 0;
        private int _rows = 0;
        private int _tileID = -1;
        private int _antOffset = 0;
        private Timer _antsTimer = new Timer();
        private List<Tile> _tiles = new List<Tile>();
        private List<Collision> _collisions = new List<Collision>();
        private List<Entity> _entities = new List<Entity>();
        private Tilemap _brush = null;
        private Rectangle _selection = Rectangle.Empty;
        private Point _selectOrigin = Point.Empty;
        private Rectangle _collisionBounds = Rectangle.Empty;
        private Point _collisionOrigin = Point.Empty;
        private Rectangle _entityBounds = Rectangle.Empty;
        private Point _entityOrigin = Point.Empty;
        private Point _brushOrigin = Point.Empty;
        private Bitmap _brushBitmap = null;
        private Collision _selectedCollision = null;
        private Entity _selectedEntity = null;

        /// <summary>
        /// Properties
        /// </summary>
        public List<Tile> Tiles
        {
            get
            {
                List<Tile> tiles = new List<Tile>();
                foreach (var tile in _tiles)
                    tiles.Add(tile.DeepClone());
                return tiles;
            }
        }
        public List<Collision> Collisions
        {
            get
            {
                List<Collision> collisions = new List<Collision>();
                foreach (var rect in _collisions)
                    collisions.Add(rect.DeepClone());
                return collisions;
            }
        }
        public List<Entity> Entities
        {
            get
            {
                List<Entity> entities = new List<Entity>();
                foreach (var entity in _entities)
                    entities.Add(entity.DeepClone());
                return entities;
            }
        }
        public TileEditType EditMode { get { return _editMode; } set { _editMode = value; UpdateBackBuffer(); } }
        public Point Position { get; private set; }
        public Collision SelectedCollision { set { _selectedCollision = value; UpdateBackBuffer(); } }
        public Entity SelectedEntity { set { _selectedEntity = value; UpdateBackBuffer(); } }
        public string PositionText { get { return GetPositionText(); } }
        public int TileID { get { return _tileID; } set { _tileID = value; UpdateBackBuffer(); } }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool Highlight { get { return _highlight; } set { _highlight = value; UpdateBackBuffer(); } }
        public int Offset { get; set; } = 0;
        public bool UseOffset { get { return _useOffset; } set { _useOffset = value; Invalidate(); } }
        public int HighlightCount { get; private set; } = 0;
        public byte BitsValue { get; set; } = 0;
        public bool Indexed
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                MinimumScale = _indexed ? 3 : 1;
                ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                ImageAlpha = _indexed ? 0.5F : 1F;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public TilemapControl()
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
        /// Marching ants timer tick
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            _antOffset++;

            if (_antOffset % 8 == 0)
                _antOffset = 0;

            if (EditMode == TileEditType.Selection && _selection != Rectangle.Empty)
                UpdateBackBuffer();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawAttributeValue(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null || _tiles.Count <= 0)
                return;

            DrawGrid(gfx, origin);
            DrawHighlights(gfx, origin);
            DrawSelection(gfx, origin);
            DrawCollisions(gfx, origin);
            DrawEntities(gfx, origin);
            DrawBrush(gfx, origin);
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || _tiles.Count <= 0 || TileID < 0)
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

            switch (_editMode)
            {
                case TileEditType.Selection:
                    // Set default scroll position and start the auto scroll timer
                    _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
                    _scrollTimer.Start();
                    _selectOrigin = new Point(x, y);
                    _selection = new Rectangle(new Point(x, y), SnapSize);
                    break;
                case TileEditType.Collisions:
                    // Set default scroll position and start the auto scroll timer
                    _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
                    _scrollTimer.Start();
                    _collisionOrigin = new Point(x, y);
                    _collisionBounds = new Rectangle(new Point(x, y), SnapSize);
                    break;
                case TileEditType.Entities:
                    // Set default scroll position and start the auto scroll timer
                    _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
                    _scrollTimer.Start();
                    _entityOrigin = new Point(x, y);
                    _entityBounds = new Rectangle(new Point(x, y), SnapSize);
                    break;
                case TileEditType.XFlip: _tiles[index].FlipX = !_tiles[index].FlipX; break;
                case TileEditType.YFlip: _tiles[index].FlipY = !_tiles[index].FlipY; break;
                case TileEditType.Priority: _tiles[index].Priority = !_tiles[index].Priority; break;
                case TileEditType.PaletteIndex: _tiles[index].UseBGPalette = !_tiles[index].UseBGPalette; break;
                case TileEditType.Bits: _tiles[index].Bits = BitsValue; break;
                default: if (_brush != null) { PaintBrush(col, row);  } else { _tiles[index].TileID = TileID; }  break;
            }

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
            if (x != Position.X || y != Position.Y)
            {
                Position = new Point(x, y);
                PositionChanged?.Invoke();
            }

            switch (EditMode)
            {
                case TileEditType.Selection:
                    if (e.Button != MouseButtons.Left || (x == _selection.X && y == _selection.Y))
                        return;

                    _selection = GetRectangle(_selectOrigin, new Point(x, y));

                    if (_selection.X >= _selectOrigin.X)
                        _selection.Width += SnapSize.Width;

                    if (_selection.Y >= _selectOrigin.Y)
                        _selection.Height += SnapSize.Height;

                    break;

                case TileEditType.Collisions:
                    if (e.Button != MouseButtons.Left || (x == _collisionBounds.X && y == _collisionBounds.Y))
                        return;

                    _collisionBounds = GetRectangle(_collisionOrigin, new Point(x, y));

                    if (_collisionBounds.X >= _collisionOrigin.X)
                        _collisionBounds.Width += SnapSize.Width;

                    if (_collisionBounds.Y >= _collisionOrigin.Y)
                        _collisionBounds.Height += SnapSize.Height;

                    UpdateBackBuffer();
                    break;

                case TileEditType.Entities:
                    if (e.Button != MouseButtons.Left || (x == _entityBounds.X && y == _entityBounds.Y))
                        return;

                    _entityBounds = GetRectangle(_entityOrigin, new Point(x, y));

                    if (_entityBounds.X >= _entityOrigin.X)
                        _entityBounds.Width += SnapSize.Width;

                    if (_entityBounds.Y >= _entityOrigin.Y)
                        _entityBounds.Height += SnapSize.Height;

                    UpdateBackBuffer();
                    break;

                case TileEditType.TileID:
                    if (x == _brushOrigin.X && y == _brushOrigin.Y)
                        return;

                    _brushOrigin = new Point(x, y);
                    UpdateBackBuffer();
                    break;
            }
        }

        /// <summary>
        /// On mouse up
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _scrollTimer.Stop();

            switch (EditMode)
            {
                case TileEditType.Collisions:
                    if (!InBounds(e.Location))
                        return;

                    var collision = new Collision(0, _collisionBounds);
                    _collisions.Add(collision);
                    ClearCollision();
                    _selectedCollision = collision;
                    CollisionsChanged?.Invoke();
                    UpdateBackBuffer();
                    break;

                case TileEditType.Entities:
                    if (!InBounds(e.Location))
                        return;

                    var entity = new Entity(0, "New Entity", new Collision(0, _entityBounds));
                    _entities.Add(entity);
                    ClearEntity();
                    _selectedEntity = entity;
                    EntitiesChanged?.Invoke();
                    UpdateBackBuffer();
                    break;
            }
        }

        /// <summary>
        /// On scroll
        /// </summary>
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);

            // Update scroll capture
            _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
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
        /// Draw grid cells
        /// </summary>
        private void DrawGrid(Graphics gfx, Point origin)
        {
            if (!UseGrid || Image == null || _tiles.Count <= 0)
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
        private void DrawBrush(Graphics gfx, Point origin)
        {
            if (EditMode != TileEditType.TileID || _brush == null || _brushBitmap == null)
                return;

            gfx.DrawImage(_brushBitmap, new Point(_brushOrigin.X + origin.X, _brushOrigin.Y + origin.Y));
        }

        /// <summary>
        /// Draws tile indexes
        /// </summary>
        private void DrawAttributeValue(Graphics gfx, Point origin)
        {
            if (!Indexed || Image == null || _tiles.Count <= 0)
                return;

            int index = 0;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    if (index < _tiles.Count && _tiles[index] != null)
                    {
                        Point point = new Point((col * SnapSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                        string value = string.Empty;
                        switch (_editMode)
                        {
                            case TileEditType.XFlip: value = _tiles[index].FlipX ? "1" : "0"; break;
                            case TileEditType.YFlip: value = _tiles[index].FlipY ? "1" : "0"; break;
                            case TileEditType.Priority: value = _tiles[index].Priority ? "1" : "0"; break;
                            case TileEditType.PaletteIndex: value = _tiles[index].UseBGPalette ? "BG" : "SPR"; break;
                            case TileEditType.Bits: value = _tiles[index].Bits.ToString(); break;
                            default: value = (_tiles[index].TileID + (_useOffset ? 0 : Offset)).ToString(); break;
                        }
                        BitmapUtility.DrawTextOutline(gfx, value, font, Brushes.Black, rect, format);
                        gfx.DrawString(value, font, Brushes.White, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Draw highlighter on selected index
        /// </summary>
        private void DrawHighlights(Graphics gfx, Point origin)
        {
            HighlightCount = 0;
            if (!_highlight || Image == null || _tiles.Count <= 0)
                return;

            int index = 0;
            int count = 0;
            Rectangle cell = new Rectangle(0, 0, SnapSize.Width, SnapSize.Height);
            using (Brush highlighter = new SolidBrush(Color.FromArgb(128, Color.Yellow)))
            {
                for (int row = 0; row < _rows; row++)
                {
                    for (int col = 0; col < _columns; col++)
                    {
                        if (_tiles[index].TileID == TileID)
                        {
                            cell.X = (col * SnapSize.Width) + origin.X;
                            cell.Y = (row * SnapSize.Height) + origin.Y;
                            gfx.FillRectangle(highlighter, cell);
                            count++;
                        }

                        index++;
                    }
                }
            }
            HighlightCount = count;
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
            if (_editMode != TileEditType.Selection || Image == null || _tiles.Count <= 0)
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
        /// Draws all collision bounds
        /// </summary>
        private void DrawCollisions(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.Collisions || Image == null)
                return;

            foreach (var collision in _collisions)
                DrawCollision(gfx, collision.Bounds, origin, false);

            DrawCollision(gfx, _collisionBounds, origin, false);
            if (_selectedCollision != null)
                DrawCollision(gfx, _selectedCollision.Bounds, origin, true);
        }

        /// <summary>
        /// Draws a single collision
        /// </summary>
        void DrawCollision(Graphics gfx, Rectangle rect, Point origin, bool selected)
        {
            var src = rect;
            src.X += origin.X;
            src.Y += origin.Y;
            gfx.DrawRectangle(Pens.Black, src);
            src.Inflate(-1, -1);
            gfx.DrawRectangle(selected ? Pens.White : Pens.Red, src);
            src.Inflate(-1, -1);
            gfx.DrawRectangle(Pens.Black, src);
        }

        /// <summary>
        /// Draws all collision rectangles
        /// </summary>
        private void DrawEntities(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.Entities || Image == null)
                return;

            foreach (var entity in _entities)
                DrawEntity(gfx, entity.Collision.Bounds, origin, entity.Name, false);

            DrawEntity(gfx, _entityBounds, origin, "", false);
            if (_selectedEntity != null)
                DrawEntity(gfx, _selectedEntity.Collision.Bounds, origin, _selectedEntity.Name, true);
        }


        /// <summary>
        /// Draws entity
        /// </summary>
        void DrawEntity(Graphics gfx, Rectangle rect, Point origin, string name, bool selected)
        {
            var src = rect;
            src.X += origin.X;
            src.Y += origin.Y;
            gfx.DrawRectangle(Pens.Black, src);
            src.Inflate(-1, -1);
            gfx.DrawRectangle(selected ? Pens.White : Pens.Lime, src);
            src.Inflate(-1, -1);
            gfx.DrawRectangle(Pens.Black, src);

            Font font = new Font(Font.Name, 8, FontStyle.Regular);
            RectangleF textRect = new RectangleF(src.X, src.Y - 16, 0, 0);
            textRect.Size = gfx.MeasureString(name, font);
            textRect.X = src.X - ((textRect.Width / 2) - (src.Width / 2));
            BitmapUtility.DrawTextOutline(gfx, name, font, Brushes.Black, textRect);
            gfx.DrawString(name, font, selected ? Brushes.White : Brushes.Lime, textRect);
        }

        /// <summary>
        /// Creates a brush from a selection
        /// </summary>
        public void CreateBrush(Tileset tileset, Palette bgPalette, Palette sprPalette)
        {
            if (_selection == Rectangle.Empty)
                return;

            _brush = SelectionToTilemap();
            _brushBitmap = BitmapUtility.GetSpriteImage(tileset, _brush, bgPalette, sprPalette);
        }

        /// <summary>
        /// Paints brush to tilemap
        /// </summary>
        public void PaintBrush(int x, int y)
        {
            if (_brush == null || _brush.Tiles.Count <= 0)
                return;

            var offset = (y * _columns) + x;
            var index = 0;
            for (int row = 0; row < _brush.Rows; row++)
            {
                for (int col = 0; col < _brush.Columns; col++)
                {
                    int target = (row * _columns) + col;
                    if (target + offset < _tiles.Count && index < _brush.Tiles.Count)
                        _tiles[target + offset] = _brush.Tiles[index].DeepClone();

                    index++;
                }
            }

            TileChanged?.Invoke();
            UpdateBackBuffer();
        }

        /// <summary>
        /// Creates a tilemap from selection
        /// </summary>
        /// <returns></returns>
        public Tilemap SelectionToTilemap()
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return null;

            var tilemap = new Tilemap();
            var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            tilemap.Columns = _selection.Width / SnapSize.Width;
            tilemap.Rows = _selection.Height / SnapSize.Height;
            for (int row = 0; row < tilemap.Rows; row++)
            {
                for (int col = 0; col < tilemap.Columns; col++)
                {
                    tilemap.Tiles.Add(_tiles[((row * _columns) + offset) + col].DeepClone());
                }
            }

            return tilemap;
        }

        /// <summary>
        /// Sets priority for the current selection
        /// </summary>
        /// <returns></returns>
        public void SetPriorityForSelection(bool priority)
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return;

            var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            var cols = _selection.Width / SnapSize.Width;
            var rows = _selection.Height / SnapSize.Height;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    _tiles[((row * _columns) + offset) + col].Priority = priority;
                }
            }
        }

        /// <summary>
        /// Sets palette index for the current selection
        /// </summary>
        /// <returns></returns>
        public void SetPaletteForSelection(bool palette)
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return;

            var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            var cols = _selection.Width / SnapSize.Width;
            var rows = _selection.Height / SnapSize.Height;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    _tiles[((row * _columns) + offset) + col].UseBGPalette = palette;
                }
            }
        }

        /// <summary>
        /// Gets position text
        /// </summary>
        /// <returns></returns>
        private string GetPositionText()
        {
            return "X: " + (Position.X + 8) + " | " + (Position.X + 8) / 8 + " Y: " + (Position.Y + 8) + " | " + (Position.Y + 8) / 8;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        private bool InBounds(Point location)
        {
            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(location) == false)
                return false;

            return true;
        }

        /// <summary>
        /// Clear tile selection
        /// </summary>
        public void ClearBrush()
        {
            if (_brush != null)
                _brush.Tiles.Clear();

            _brushBitmap = null;
            _brush = null;
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

        /// <summary>
        /// Clear collision selection
        /// </summary>
        public void ClearCollision()
        {
            _collisionBounds = Rectangle.Empty;
            _collisionOrigin = Point.Empty;
            _selectedCollision = null;
            Invalidate();
        }

        /// <summary>
        /// Clear entity selection
        /// </summary>
        public void ClearEntity()
        {
            _entityBounds = Rectangle.Empty;
            _entityOrigin = Point.Empty;
            _selectedEntity = null;
            Invalidate();
        }

        /// <summary>
        /// Sets the tile map data
        /// </summary>
        /// <param name="tilemap">The tile map data to set</param>
        public void SetTilemap(Tilemap tilemap)
        {
            _columns = tilemap.Columns;
            _rows = tilemap.Rows;
            _tiles = tilemap.Tiles.DeepClone();
            _collisions = tilemap.Collisions.DeepClone();
            _entities = tilemap.Entities.DeepClone();
            Offset = tilemap.Offset;
            ClearSelection();
            ClearCollision();
            ClearEntity();
            UpdateBackBuffer();
        }

        /// <summary>
        /// Clears editor data
        /// </summary>
        public void Clear()
        {
            _columns = 0;
            _rows = 0;
            _tiles.Clear();
            _collisions.Clear();
            _entities.Clear();
            Offset = 0;
            this.Image = null;
            ClearSelection();
            ClearCollision();
            ClearEntity();
            UpdateBackBuffer();
        }
    }
}
