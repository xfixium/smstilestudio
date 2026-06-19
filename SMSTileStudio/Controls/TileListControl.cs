// 
// SMS Tile Studio
// Copyright (C) 2026 xfixium | xfixium@yahoo.com
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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SMSTileStudio.Controls
{
    public partial class TileListControl : ImageControl
    {
        public event SelectedTileChangedHandler SelectedTileChanged;
        public delegate void SelectedTileChangedHandler();
        private List<KeyValuePair<int, int>> _tiles = new List<KeyValuePair<int, int>>();
        private int _selectedIndex = 0;

        public int TileID { get { return _selectedIndex >= _tiles.Count ? 0 : _tiles[_selectedIndex].Key; } }

        public TileListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawTileInformation(e.Graphics, GetOrigin());
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

            Size item = new Size(Image.Width, SnapSize.Height);
            int x = (e.Location.X - rect.X) / ImageScale;
            int y = (e.Location.Y - rect.Y) / ImageScale;
            Rectangle selection = new Rectangle(new Point(x, y), item);
            int index = selection.Y / item.Height;
            if (index < 0 || index >= _tiles.Count)
                return;

            _selectedIndex = index;
            SelectedTileChanged?.Invoke();
            Invalidate();
        }

        /// <summary>
        /// Draws tile information
        /// </summary>
        private void DrawTileInformation(Graphics gfx, Point origin)
        {
            if (_tiles.Count <= 0)
                return;

            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Near;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            var row = 0;
            foreach (var tile in _tiles)
            {
                var text = "ID " + tile.Key + ": " + tile.Value;
                Point point = new Point((10 * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                RectangleF rect = new RectangleF(point.X + 4, point.Y + 1, (SnapSize.Width + 1) * ImageScale, (SnapSize.Height + 1) * ImageScale);
                if (row == _selectedIndex)
                {
                    var selection = new Rectangle((int)rect.X - 4, (int)rect.Y, (int)rect.Width, (int)rect.Height - 4);
                    gfx.FillRectangle(SystemBrushes.Highlight, selection);
                    gfx.DrawString(text, font, Brushes.White, rect, format);
                }
                else
                    gfx.DrawString(text, font, Brushes.Black, rect, format);

                row++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tiles"></param>
        /// <param name="tileset"></param>
        public void SetTiles(List<Tile> tiles, Bitmap tileset)
        {
            var count = tileset.Width / 8;
            UpdateTiles(tiles, count, true);
            ImageScale = 3;
            SnapSize = new Size(46, 10);
            Image = new Bitmap(SnapSize.Width, count * SnapSize.Height);
            using (var gfx = Graphics.FromImage(Image))
            {
                for (int j = 0; j < count; j++)
                {
                    using (var bitmap = tileset.Clone(new Rectangle(_tiles[j].Key * 8, 0, 8, 8), Image.PixelFormat))
                    {
                        gfx.DrawImageUnscaled(bitmap, 1, j * SnapSize.Height + 1);
                    }
                }
            }
            UpdateBackBuffer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tiles"></param>
        /// <param name="count"></param>
        /// <param name="resetIndex"></param>
        public void UpdateTiles(List<Tile> tiles, int count, bool resetIndex)
        {
            var id = TileID;
            _tiles.Clear();
            for (int i = 0; i < count; i++)
            {
                _tiles.Add(new KeyValuePair<int, int>(i, tiles.Where(x => x.TileID == i).ToList().Count));
            }
            _tiles = _tiles.OrderBy(x => x.Value).ThenBy(x => x.Key).ToList();
            if (resetIndex || _selectedIndex >= _tiles.Count)
            {
                _selectedIndex = 0;
                SelectedTileChanged?.Invoke();
            }
            else
            {
                var val = _tiles.FindIndex(x => x.Key == id);
                _selectedIndex = val == -1 ? 0 : val;
                var point = new Point(0, _selectedIndex * SnapSize.Height * ImageScale);
                if (!GetViewport().Contains(point))
                {
                    AutoScrollPosition = new Point(AutoScrollPosition.X, point.Y);
                }
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            _selectedIndex = 0;
            _tiles.Clear();
            this.Image = null;
            UpdateBackBuffer();
        }
    }
}
