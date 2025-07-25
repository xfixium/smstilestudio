﻿// 
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
    public partial class TilemapControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event TileChangedHandler TileChanged;
        public delegate void TileChangedHandler();
        //public event EntitiesChangedHandler EntitiesChanged;
        //public delegate void EntitiesChangedHandler();
        public event PositionChangedHandler PositionChanged;
        public delegate void PositionChangedHandler();

        private TileEditType _editMode = TileEditType.TileID;
        private Timer _scrollTimer = new Timer();
        private Point _scrollCapture = Point.Empty;
        private bool _useGrid = true;
        private bool _useAreaGrid = false;
        private bool _indexed = false;
        private bool _highlight = false;
        private bool _invertGridColor = false;
        private bool _useOffset = false;
        private bool _showIndexes = false;
        private int _columns = 0;
        private int _rows = 0;
        private int _tileID = -1;
        private int _antOffset = 0;
        private Timer _antsTimer = new Timer();
        private List<Tile> _tiles = new List<Tile>();
        private List<Entity> _entities = new List<Entity>();
        private List<MetaTile> _metatiles = new List<MetaTile>();
        private TileGrid _tileGrid = null;
        private Tilemap _brush = null;
        private Rectangle _selection = Rectangle.Empty;
        private Point _selectOrigin = Point.Empty;
        private Rectangle _entityBounds = Rectangle.Empty;
        private Point _entityOrigin = Point.Empty;
        private Point _brushOrigin = Point.Empty;
        private Bitmap _brushBitmap = null;
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
        public List<MetaTile> Metatiles
        {
            get
            {
                List<MetaTile> blocks = new List<MetaTile>();
                foreach (var block in _metatiles)
                    blocks.Add(block.DeepClone());
                return blocks;
            }
        }
        public List<int> GridTiles
        {
            get
            {
                List<int> blocks = new List<int>();
                if (_tileGrid != null && _tileGrid.Tiles != null)
                    foreach (var block in _tileGrid.Tiles)
                        blocks.Add(block);

                return blocks;
            }
        }
        public TileGrid TileGrid
        {
            get {  return _tileGrid; }
            set 
            {
                _tileGrid = value;
                if (value != null) 
                    BlockSize = value.TileSize;

                UpdateBackBuffer();
            }
        }
        public TileEditType EditMode
        {
            get { return _editMode; }
            set
            {
                _editMode = value;
                if (value != TileEditType.TileID && value != TileEditType.Selection)
                {
                    MinimumScale = 1;
                    //ImageAlpha = 0.5F;
                }
                else
                {
                    MinimumScale = _indexed ? 3 : 1;
                    ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                    //ImageAlpha = _indexed ? 0.5F : 1F;
                }
                UpdateBackBuffer();
            }
        }
        public Point Position { get; private set; }
        public Entity SelectedEntity { set { _selectedEntity = value; UpdateBackBuffer(); } }
        public string PositionText { get { return GetPositionText(); } }
        public string TileText { get { return GetTileText(); } }
        public string SelectionText { get { return GetSelectionText(); } }
        public int TileID { get { return _tileID; } set { _tileID = value; UpdateBackBuffer(); } }
        public bool UseGrid { get { return _useGrid; } set { _useGrid = value; UpdateBackBuffer(); } }
        public bool UseAreaGrid { get { return _useAreaGrid; } set { _useAreaGrid = value; UpdateBackBuffer(); } }
        public bool Highlight { get { return _highlight; } set { _highlight = value; UpdateBackBuffer(); } }
        public int Offset { get; set; } = 0;
        public bool UseOffset { get { return _useOffset; } set { _useOffset = value; Invalidate(); } }
        public bool InvertGridColor { get { return _invertGridColor; } set { _invertGridColor = value; UpdateBackBuffer(); } }
        public int HighlightCount { get; private set; } = 0;
        public byte TypeValue { get; set; } = 0;
        public Size AreaGridSize { get; set; } = new Size(32, 24);
        public Size BlockSize { get; set; } = new Size(16, 16);
        public byte BlockValue { get; set; } = 0;
        public bool ShowIndexes { get { return _showIndexes; } set { _showIndexes = value; UpdateBackBuffer(); } }
        public bool Indexed
        {
            get { return _indexed; }
            set
            {
                _indexed = value;
                MinimumScale = _indexed ? 3 : 1;
                ImageScale = _indexed && ImageScale < 3 ? 3 : ImageScale;
                //ImageAlpha = _indexed ? 0.5F : 1F;
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
            else if (_highlight)
                UpdateBackBuffer();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawAttributeValue(e.Graphics, GetOrigin());
            DrawTileGridValues(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On after draw on backbuffer
        /// </summary>
        protected override void OnAfterDrawOnBackbuffer(ref Graphics gfx, ref Point origin)
        {
            if (Image == null || _tiles.Count <= 0)
                return;

            DrawGrid(gfx, origin);
            DrawAreaGrid(gfx, origin);
            DrawHighlights(gfx, origin);
            DrawSelection(gfx, origin);
            DrawEntities(gfx, origin);
            DrawBrush(gfx, origin);
            DrawMetatiles(gfx, origin);
            DrawTileGrid(gfx, origin);
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

            Size snap = SnapSize;
            var count = _tiles.Count;
            if (_editMode == TileEditType.TileGrid && _tileGrid != null && _tileGrid.Tiles != null)
            {
                snap = _tileGrid.TileSize;
                count = _tileGrid.Tiles.Count;
            }
            int x = (e.Location.X - rect.X) / ImageScale / snap.Width * snap.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / snap.Height * snap.Height;
            Rectangle selection = new Rectangle(new Point(x, y), snap);
            int cols = Image.Width / snap.Width;
            int col = selection.X / snap.Width;
            int row = selection.Y / snap.Height;
            int index = (row * cols) + col;
            if (index >= count)
                return;

            switch (_editMode)
            {
                case TileEditType.Selection:
                    // Set default scroll position and start the auto scroll timer
                    _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
                    _scrollTimer.Start();
                    _selectOrigin = new Point(x, y);
                    _selection = new Rectangle(new Point(x, y), snap);
                    break;
                case TileEditType.Entities:
                    // Set default scroll position and start the auto scroll timer
                    _scrollCapture = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
                    _scrollTimer.Start();
                    _entityOrigin = new Point(x, y);
                    _entityBounds = new Rectangle(new Point(x, y), snap);
                    break;
                case TileEditType.XFlip: _tiles[index].FlipX = !_tiles[index].FlipX; break;
                case TileEditType.YFlip: _tiles[index].FlipY = !_tiles[index].FlipY; break;
                case TileEditType.Priority: _tiles[index].Priority = !_tiles[index].Priority; break;
                case TileEditType.PaletteIndex: _tiles[index].UseBGPalette = !_tiles[index].UseBGPalette; break;
                case TileEditType.Bits: _tiles[index].Bits = TypeValue; break;
                //case TileEditType.Metatiles: if (_metatiles != null) { _metatiles[index]. = BlockValue; BlockChanged?.Invoke(); } break;
                case TileEditType.TileGrid: 
                    if (_tileGrid != null && _tileGrid.Tiles != null) 
                    { 
                        _tileGrid.Tiles[index] = BlockValue; 
                    }
                    TileChanged?.Invoke();
                    Invalidate(); 
                    return;
                default: if (_brush != null) { PaintBrush(col, row); } else { _tiles[index].TileID = TileID; } break;
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

                    PositionChanged?.Invoke();
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

            //switch (EditMode)
            //{
            //    case TileEditType.Entities:
            //        if (!InBounds(e.Location))
            //            return;

            //        var entity = new Entity(0, "New Entity", _entityBounds);
            //        _entities.Add(entity);
            //        ClearEntity();
            //        _selectedEntity = entity;
            //        EntitiesChanged?.Invoke();
            //        UpdateBackBuffer();
            //        break;
            //}
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
            if (!UseGrid || Image == null || _tiles.Count <= 0 || EditMode == TileEditType.TileGrid)
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
        /// Draw area grid cells
        /// </summary>
        private void DrawAreaGrid(Graphics gfx, Point origin)
        {
            if (!UseAreaGrid || Image == null || _tiles.Count <= 0 || EditMode == TileEditType.TileGrid)
                return;

            int cols = (int)Math.Ceiling(Image.Width / (double)(AreaGridSize.Width * 8));
            int rows = (int)Math.Ceiling(Image.Height / (double)(AreaGridSize.Height * 8));
            Rectangle cell = new Rectangle(0, 0, AreaGridSize.Width * 8 - 1, AreaGridSize.Height * 8 - 1);
            using (Pen gridPen = new Pen(Color.FromArgb(255, _invertGridColor ? Color.White : Color.Black)))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        cell.X = (col * (AreaGridSize.Width * 8)) + origin.X;
                        cell.Y = (row * (AreaGridSize.Height * 8)) + origin.Y;
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
        /// Draws tile attributes
        /// </summary>
        private void DrawAttributeValue(Graphics gfx, Point origin)
        {
            if (Image == null || _tiles.Count <= 0 || EditMode == TileEditType.TileGrid ||
                (!Indexed && EditMode == TileEditType.TileID) ||
                (!Indexed && EditMode == TileEditType.Selection))
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
                            case TileEditType.XFlip: value = _tiles[index].FlipX ? "H" : ""; break;
                            case TileEditType.YFlip: value = _tiles[index].FlipY ? "V" : ""; break;
                            case TileEditType.Priority: value = _tiles[index].Priority ? "P" : ""; break;
                            case TileEditType.PaletteIndex: value = _tiles[index].UseBGPalette ? "BG" : "SPR"; break;
                            case TileEditType.Bits: value = _tiles[index].Bits.ToString(); break;
                            default:
                                value = ShowIndexes ? index.ToString() : (_tiles[index].TileID + (_useOffset ? 0 : Offset)).ToString();
                            break;
                        }
                        if (value != "")
                        {
                            BitmapUtility.DrawTextOutline(gfx, value, font, Brushes.Black, rect, format);
                            gfx.DrawString(value, font, ShowIndexes ? Brushes.Cyan : Brushes.White, rect, format);
                        }
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// Draws block values
        /// </summary>
        private void DrawMetatileValues(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.Metatiles || Image == null || _tiles.Count <= 0 || _metatiles.Count <= 0)
                return;

            int index = 0;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            int cols = (int)Math.Ceiling(Image.Width / (double)(BlockSize.Width));
            int rows = (int)Math.Ceiling(Image.Height / (double)(BlockSize.Height));
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (index < _metatiles.Count && _metatiles[index] != null)
                    {
                        Point point = new Point((col * BlockSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * BlockSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (BlockSize.Width + 1) * ImageScale, (BlockSize.Height + 1) * ImageScale);
                        string value = (_metatiles[index].TileID).ToString();
                        BitmapUtility.DrawTextOutline(gfx, value, font, Brushes.Black, rect, format);
                        gfx.DrawString(value, font, Brushes.White, rect, format);
                    }
                    index++;
                }
            }
        }

        /// <summary>
        /// raws block gri
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        private void DrawMetatiles(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.Metatiles || Image == null || _tiles.Count <= 0 || _metatiles.Count <= 0)
                return;

            int cols = (int)Math.Ceiling(Image.Width / (double)(BlockSize.Width));
            int rows = (int)Math.Ceiling(Image.Height / (double)(BlockSize.Height));
            Rectangle cell = new Rectangle(0, 0, BlockSize.Width, BlockSize.Height);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    gfx.DrawRectangle(Pens.White, col * BlockSize.Width + origin.X, row * BlockSize.Height + origin.Y, BlockSize.Width, BlockSize.Height);
                }
            }
        }

        /// <summary>
        /// raws block gri
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        private void DrawTileGrid(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.TileGrid || Image == null || _tileGrid == null)
                return;

            for (int row = 0; row < _tileGrid.Rows; row++)
            {
                for (int col = 0; col < _tileGrid.Columns; col++)
                {
                    gfx.DrawRectangle(Pens.White, col * BlockSize.Width + origin.X, row * BlockSize.Height + origin.Y, BlockSize.Width, BlockSize.Height);
                }
            }
        }

        /// <summary>
        /// Draws block values
        /// </summary>
        private void DrawTileGridValues(Graphics gfx, Point origin)
        {
            if (EditMode != TileEditType.TileGrid || Image == null || _tileGrid == null || _tileGrid.Tiles == null || _tileGrid.Tiles.Count <= 0)
                return;

            int index = 0;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            for (int row = 0; row < _tileGrid.Rows; row++)
            {
                for (int col = 0; col < _tileGrid.Columns; col++)
                {
                    if (index < _tileGrid.Tiles.Count)
                    {
                        Point point = new Point((col * BlockSize.Width * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * BlockSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                        RectangleF rect = new RectangleF(point.X, point.Y, (BlockSize.Width + 1) * ImageScale, (BlockSize.Height + 1) * ImageScale);
                        string value = (_tileGrid.Tiles[index]).ToString();
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
            using (Pen pen = new Pen(Color.White, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                pen.DashPattern = new float[2] { 4, 4 };
                pen.DashOffset = _antOffset;
                for (int row = 0; row < _rows; row++)
                {
                    for (int col = 0; col < _columns; col++)
                    {
                        if (_tiles[index].TileID == TileID)
                        {
                            cell.X = (col * SnapSize.Width) + origin.X;
                            cell.Y = (row * SnapSize.Height) + origin.Y;
                            gfx.DrawRectangle(Pens.Blue, cell);
                            gfx.DrawRectangle(pen, cell);
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
                rect.Width -= 1;
                rect.Height -= 1;
                gfx.DrawRectangle(Pens.Black, rect);
                gfx.DrawRectangle(pen, rect);
            }
        }

        /// <summary>
        /// Draws all collision rectangles
        /// </summary>
        private void DrawEntities(Graphics gfx, Point origin)
        {
            if (_editMode != TileEditType.Entities || Image == null)
                return;

            //foreach (var entity in _entities)
            //    DrawEntity(gfx, entity.Bounds, origin, entity.Name, false);

            //DrawEntity(gfx, _entityBounds, origin, "", false);
            //if (_selectedEntity != null)
            //    DrawEntity(gfx, _selectedEntity.Bounds, origin, _selectedEntity.Name, true);
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
        /// Draws entity
        /// </summary>
        void DrawMergeTiles(Graphics gfx, Rectangle rect, Point origin, string name, bool selected)
        {

        }

        /// <summary>
        /// Creates a brush from a selection
        /// </summary>
        public void CreateBrush(Tileset tileset, Palette bgPalette, Palette sprPalette)
        {
            if (_selection == Rectangle.Empty)
                return;

            _brush = SelectionToTilemap();
            _brushBitmap = BitmapUtility.GetTileImage(tileset, _brush, bgPalette, sprPalette);
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
        /// Creates a tile id text from selection
        /// </summary>
        /// <returns></returns>
        public string SelectionToIdsDecimal(bool reversed)
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return null;

            var selection = "";
            var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            if (reversed)
            {
                var cols = (_selection.Width / SnapSize.Width) - 1;
                for (int row = 0; row < _selection.Height / SnapSize.Height; row++)
                {
                    for (int col = cols; col > -1; col--)
                    {
                        selection += _tiles[(row * _columns) + offset + col].TileID + Offset + ", ";
                    }
                }
            }
            else
            {
                for (int row = 0; row < _selection.Height / SnapSize.Height; row++)
                {
                    for (int col = 0; col < _selection.Width / SnapSize.Width; col++)
                    {
                        selection += _tiles[(row * _columns) + offset + col].TileID + Offset + ", ";
                    }
                }
            }
            return selection.TrimEnd(new[] { ',', ' ' });
        }

        /// <summary>
        /// Creates a tilemap from selection
        /// </summary>
        /// <returns></returns>
        public List<byte> SelectionToArea()
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return null;

            var area = new List<byte>();
            //var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            var cols = (_selection.X / SnapSize.Width) + (_selection.Width / SnapSize.Width);
            var rows = (_selection.Y / SnapSize.Height) + (_selection.Height / SnapSize.Height);
            for (int row = _selection.Y / SnapSize.Height; row < rows; row++)
            {
                for (int col = _selection.X / SnapSize.Width; col < cols; col++)
                {
                    var val1 = ((row * _columns) + col) * 2;
                    //var val2 = val1 + 1;
                    area.AddRange(Tilemap.GetUShortBytes(val1));
                    //area.AddRange(Tilemap.GetUShortBytes(val2));
                }
            }
            return area;
        }

        /// <summary>
        /// Creates a tilemap from selection
        /// </summary>
        /// <returns></returns>
        public string SelectionToIndexesDecimal(bool reversed)
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return null;

            var selected = "";
            //var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            var cols = (_selection.X / SnapSize.Width) + (_selection.Width / SnapSize.Width);
            var rows = (_selection.Y / SnapSize.Height) + (_selection.Height / SnapSize.Height);
            if (reversed)
            {
                for (int row = rows; row > (_selection.Y / SnapSize.Height); row--)
                {
                    for (int col = cols; col > (_selection.X / SnapSize.Width); col--)
                    {
                        selected += (((row - 1) * _columns) + (col - 1)).ToString() + ", ";
                    }
                }
            }
            else
            {
                for (int row = _selection.Y / SnapSize.Height; row < rows; row++)
                {
                    for (int col = _selection.X / SnapSize.Width; col < cols; col++)
                    {
                        selected += ((row * _columns) + col).ToString() + ", ";
                    }
                }
            }
            return selected.TrimEnd(new[] { ',', ' ' });
        }

        /// <summary>
        /// Sets a tile id for the current selection
        /// </summary>
        public void SetTileIdForSelection(int tileId)
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
                    _tiles[((row * _columns) + offset) + col].TileID = tileId;
                }
            }
        }

        /// <summary>
        /// Sets priority for the current selection
        /// </summary>
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
        /// Sets tile type for the current selection
        /// </summary>
        public void SetTileTypeForSelection(byte type)
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
                    _tiles[((row * _columns) + offset) + col].Bits = type;
                }
            }
        }

        /// <summary>
        /// Sets the horizontal mirror for the current selection
        /// </summary>
        public void MirrorXForSelection()
        {
            if (_selection == Rectangle.Empty || EditMode != TileEditType.Selection)
                return;

            var copy = SelectionToTilemap();
            var offset = ((_selection.Y / SnapSize.Height) * _columns) + (_selection.X / SnapSize.Width);
            var cols = _selection.Width / SnapSize.Width;
            var rows = _selection.Height / SnapSize.Height;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var src = (row * cols) + (cols - 1 - col);
                    var target = (row * _columns) + offset + col;
                    _tiles[target] = copy.Tiles[src];
                    _tiles[target].FlipX = !_tiles[target].FlipX;
                }
            }
        }

        /// <summary>
        /// Sets the vertical mirror for the current selection
        /// </summary>
        public void MirrorYForSelection(bool flip)
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
                    _tiles[((row * _columns) + offset) + col].FlipY = flip;
                }
            }
        }

        /// <summary>
        /// Gets position text
        /// </summary>
        /// <returns></returns>
        private string GetPositionText()
        {
            var col = Position.X / 8;
            var row = Position.Y / 8;
            var cols = Image.Width / 8;
            return "X: " + Position.X + " | Tile X: " + col + " | Y: " + Position.Y + " | Tile Y: " + row + " | Index: "  + ((row * cols) + col);
        }

        /// <summary>
        /// Gets tile text
        /// </summary>
        /// <returns></returns>
        private string GetTileText()
        {
            if (_tiles == null || _tiles.Count <= 0 || Position.IsEmpty)
                return "N/A";

            int cols = Image.Width / SnapSize.Width;
            int col = Position.X / SnapSize.Width;
            int row = Position.Y / SnapSize.Height;
            int index = (row * cols) + col;
            if (index < _tiles.Count)
            {
                var tile = _tiles[index];
                return tile.TileID + " | H Flip: " + (tile.FlipX ? "Yes" : "No") + " | V Flip: " + (tile.FlipY ? "Yes" : "No") + " | Priority: " + (tile.Priority ? "Yes" : "No") + " | Palette: " + (tile.UseBGPalette ? "BG" : "SPR") + " | Type: " + tile.Bits;
            }
            return "N/A";
        }

        /// <summary>
        /// Gets selection text
        /// </summary>
        /// <returns></returns>
        private string GetSelectionText()
        {
            if (_selection == Rectangle.Empty)
                return "N/A";

            var col = _selection.X / 8;
            var row = _selection.Y / 8;
            var cols = _selection.Width / 8;
            var rows = _selection.Height / 8;
            return "Tile X: " + col + " | Tile Y: " + row + " | Columns: " + cols + " | Rows: " + rows;
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
            UpdateBackBuffer();
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
        public void SetTilemap(Tilemap tilemap, bool clear = true)
        {
            _tiles.Clear();
            _metatiles.Clear();
            //if (_tileGrid != null )
            //{
            //    _tileGrid.Tiles.Clear();
            //    _tileGrid = null;
            //    _tileGrid = tileGrid;
            //}
            _columns = tilemap.Columns;
            _rows = tilemap.Rows;
            _tiles = tilemap.Tiles.DeepClone();
            _entities = tilemap.Entities.DeepClone();
            //_metatiles = tilemap.Metatiles.DeepClone();
            Offset = tilemap.Offset;
            if (clear)
            {
                ClearSelection();
                ClearEntity();
            }
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
            _entities.Clear();
            if (_tileGrid != null && _tileGrid.Tiles != null)
            {
                _tileGrid.Tiles.Clear();
            }
            _tileGrid = null;
            Offset = 0;
            this.Image = null;
            ClearSelection();
            ClearEntity();
            UpdateBackBuffer();
        }
    }
}
