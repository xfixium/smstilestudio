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

using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class PixelTileControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event SelectedIndexChangedHandler SelectedIndexChanged;
        public delegate void SelectedIndexChangedHandler();
        private bool _indexed = false;
        private List<PixelTile> _original = new List<PixelTile>();
        private List<PixelTile> _pixelTiles = new List<PixelTile>();
        private List<Color> _bgImport;
        private List<Color> _sprImport;
        private List<Color> _bgPalette;
        private List<Color> _sprPalette;
        private int _selectedIndex = -1;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _pixelTiles != null && _pixelTiles.Count > 0; } }
        public int TileCount { get { return _pixelTiles != null ? _pixelTiles.Count : 0; } }
        public int SelectedIndex { get { return _selectedIndex; } }
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
        public PixelTileControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawIndexes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
            _selectedIndex = -1;

            if (Canvas == null || !HasData || e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Canvas.Width * ImageScale, Canvas.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            int x = (e.Location.X - rect.X) / ImageScale / SnapSize.Width * SnapSize.Width;
            int y = (e.Location.Y - rect.Y) / ImageScale / SnapSize.Height * SnapSize.Height;
            int cols = GetTransformedSnap(Canvas).Width;
            int col = GetTransformedSnap(new Size(x, y)).Width;
            int row = GetTransformedSnap(new Size(x, y)).Height;
            int index = (row * cols) + col;
            if (index >= _pixelTiles.Count)
                return;

            _selectedIndex = index;
            _original[index].UseBGPalette = !_pixelTiles[index].UseBGPalette;
            UpdateTiles();
            SelectedIndexChanged?.Invoke();
        }

        /// <summary>
        /// Draws palette indexes
        /// </summary>
        private void DrawIndexes(Graphics gfx, Point origin)
        {
            if (!Indexed || !HasData)
                return;

            List<PixelTile> selected = GetPixelTiles(false);
            int index = 0;
            int count = selected.Count;
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
                    if (index < count)
                    {
                        string palette = selected[index].UseBGPalette ? "BG" : "SPR";
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
        /// Gets set of pixel tiles by tileset id
        /// </summary>
        /// <param name="tilesetID">The tileset tiles to get</param>
        /// <returns>List of pixel tiles that belong to the given tileset id</returns>
        public List<PixelTile> GetPixelTiles(bool original)
        {
            return original ? _original : _pixelTiles;
        }

        public void SetPixelTiles(List<PixelTile> pixelTiles)
        {
            _original = pixelTiles.DeepClone();
            _pixelTiles = pixelTiles.DeepClone();
        }

        /// <summary>
        /// Clears all pixel tiles
        /// </summary>
        public void Clear()
        {
            _pixelTiles.Clear();
            _original.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="useBackgroundPalette"></param>
        public void SetSelectedIndex(int index)
        {
            if (_pixelTiles == null || index >= _pixelTiles.Count)
                return;

            _selectedIndex = index;
            _original[index].UseBGPalette = !_pixelTiles[index].UseBGPalette;
            UpdateTiles();
            SelectedIndexChanged?.Invoke();
        }

        /// <summary>
        /// Set palette index
        /// </summary>
        /// <param name="useBackgroundPalette"></param>
        public void SetPaletteAll(bool useBackgroundPalette)
        {
            foreach (PixelTile pixelTile in _original)
                pixelTile.UseBGPalette = useBackgroundPalette;

            UpdateTiles();
        }

        /// <summary>
        /// Internal update
        /// </summary>
        private void UpdateTiles()
        {
            UpdateTiles(_bgImport, _sprImport, _bgPalette, _sprPalette);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sprImport"></param>
        /// <param name="sprPalette"></param>
        public void UpdateTiles(List<Color> sprImport, List<Color> sprPalette)
        {
            UpdateTiles(sprImport, sprImport, sprPalette, sprPalette);
        }

        /// <summary>
        /// Updates pixel tiles
        /// </summary>
        /// <param name="bgImport">Imported palette for background palette</param>
        /// <param name="sprImport">Imported palette for sprite palette</param>
        /// <param name="bgPalette">Background palette</param>
        /// <param name="sprPalette">Sprite palette</param>
        public void UpdateTiles(List<Color> bgImport, List<Color> sprImport, List<Color> bgPalette, List<Color> sprPalette)
        {
            if (GetPixelTiles(false).Count <= 0)
                return;

            if (_original.Count <= 0)
                _original = new List<PixelTile>(_pixelTiles.DeepClone());

            _bgImport = bgImport;
            _bgPalette = bgPalette;
            _sprImport = sprImport;
            _sprPalette = sprPalette;

            List<PixelTile> temp = new List<PixelTile>(_original.DeepClone());
            foreach (PixelTile pixelTile in temp)
            {
                for (int j = 0; j < pixelTile.Pixels.Count; j++)
                {
                    bool match = false;
                    for (int i = 0; i < (pixelTile.UseBGPalette ? bgImport : sprImport).Count; i++)
                    {
                        if (pixelTile.Pixels[j] == (pixelTile.UseBGPalette ? bgImport[i] : sprImport[i]).ToArgb())
                        {
                            pixelTile.Pixels[j] = (pixelTile.UseBGPalette ? bgPalette[i] : sprPalette[i]).ToArgb();
                            match = true;
                            break;
                        }
                    }
                    if (!match)
                        pixelTile.Pixels[j] = (pixelTile.UseBGPalette ? bgPalette[0] : sprPalette[0]).ToArgb();
                }
            }

            _pixelTiles = temp;
            Image = BitmapUtility.GetPixelTilesImage(GetPixelTiles(false), 8);
        }
    }
}
