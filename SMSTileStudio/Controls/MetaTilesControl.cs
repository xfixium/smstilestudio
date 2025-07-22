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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SMSTileStudio.Controls
{
    public partial class MetaTilesControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        public event MetaTileChangedHandler MetaTileChanged;
        public delegate void MetaTileChangedHandler();
        private int _tabSize = 0;
        private bool _showHexValues = false;
        private bool _invertGridColor;
        private TileEditType _editMode = TileEditType.TileID;

        /// <summary>
        /// Properties
        /// </summary>
        public List<MetaTile> MetaTiles { get; set; }
        public string MetaTileProperties { get; set; } = "N/A";
        public bool ApplyEditsToAllMetaTiles { get; set; } = true;
        public bool ShowHexValues { get { return _showHexValues; } set { _showHexValues = value; Invalidate(); } }
        public bool InvertGridColor { get { return _invertGridColor; } set { _invertGridColor = value; UpdateTiles(); } }
        public byte TypeValue { get; set; } = 0;
        public TileEditType EditMode { get { return _editMode; } set { _editMode = value; Invalidate(); } }

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTilesControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On draw after on paint
        /// </summary>
        protected override void OnDrawAfterOnPaint(ref PaintEventArgs e)
        {
            DrawAttributes(e.Graphics, GetOrigin());
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            if (Image == null || MetaTiles.Count <= 0)
                return;

            if (e.Button != MouseButtons.Left)
                return;

            Point origin = GetOrigin();
            Rectangle rect = new Rectangle(origin.X * ImageScale + AutoScrollPosition.X, origin.Y * ImageScale + AutoScrollPosition.Y, Image.Width * ImageScale, Image.Height * ImageScale);
            if (rect.Contains(e.Location) == false)
                return;

            Size metaTile = new Size(Image.Width, SnapSize.Height);
            int x = (e.Location.X - rect.X) / ImageScale;
            int y = (e.Location.Y - rect.Y) / ImageScale;
            Rectangle selection = new Rectangle(new Point(x, y), metaTile);
            int row = selection.Y / metaTile.Height;
            int index = row;
            if (index >= MetaTiles.Count)
                return;

            var tileIndex = -1;
            var tiles = MetaTiles[index].Tiles;
            var rects = GetTileRects(index, origin);
            for (int i = 0; i < rects.Count; i++)
            {
                if (rects[i].Contains(e.Location))
                {
                    tileIndex = i;
                    break;
                }
            }

            if (tileIndex < 0)
                return;

            switch (EditMode)
            {
                case TileEditType.Priority:
                    if (ApplyEditsToAllMetaTiles)
                        ApplyValueToAllByTileId(tiles[tileIndex].TileID, !tiles[tileIndex].Priority);
                    else
                        tiles[tileIndex].Priority = !tiles[tileIndex].Priority;

                    MetaTileChanged?.Invoke();
                    break;
                case TileEditType.PaletteIndex: 
                    if (ApplyEditsToAllMetaTiles)
                        ApplyValueToAllByTileId(tiles[tileIndex].TileID, !tiles[tileIndex].UseBGPalette);
                    else
                        tiles[tileIndex].UseBGPalette = !tiles[tileIndex].UseBGPalette;

                    MetaTileChanged?.Invoke();
                    break;
                case TileEditType.Bits: 
                    if (ApplyEditsToAllMetaTiles)
                        ApplyValueToAllByTileId(tiles[tileIndex].TileID, TypeValue);
                    else
                        tiles[tileIndex].Bits = TypeValue;

                    MetaTileChanged?.Invoke();
                    break;
            }

            Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tileId"></param>
        /// <param name="value"></param>
        private void ApplyValueToAllByTileId(int tileId, object value)
        {
            foreach (var metaTile in MetaTiles)
            {
                foreach (var tile in metaTile.Tiles)
                {
                    if (tile.TileID == tileId)
                    {
                        switch (EditMode)
                        {
                            case TileEditType.Priority: tile.Priority = (bool)value; break;
                            case TileEditType.PaletteIndex: tile.UseBGPalette = (bool)value; break;
                            case TileEditType.Bits: tile.Bits = (byte)value; break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        private void DrawAttributes(Graphics gfx, Point origin)
        {
            if (Image == null || MetaTiles == null || MetaTiles.Count <= 0)
                return;

            int index = 0;
            Font font = new Font(Font.Name, 5 + ImageScale, FontStyle.Regular);
            Font smallFont = new Font(Font.Name, 5 + ImageScale - 2, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.NoWrap | StringFormatFlags.NoClip;
            foreach (var metaTile in MetaTiles)
            {
                Font drawFont = font;
                int tileIndex = 0;
                string value = "";
                var rects = GetTileRects(index, origin);
                foreach (var tile in rects)
                {
                    if (tileIndex >= MetaTiles[index].Tiles.Count)
                        continue;

                    switch (EditMode)
                    {
                        case TileEditType.Priority: value = MetaTiles[index].Tiles[tileIndex].Priority ? "1" : "0"; break;
                        case TileEditType.PaletteIndex: value = MetaTiles[index].Tiles[tileIndex].UseBGPalette ? "BG" : "SPR"; break;
                        case TileEditType.Bits: value = MetaTiles[index].Tiles[tileIndex].Bits.ToString(); break;
                        case TileEditType.TileValue:
                            int id = MetaTiles[index].Tiles[tileIndex].GetTileValue();
                            value = _showHexValues ? string.Format("${0:X4}", id) : id.ToString();
                            drawFont = _showHexValues ? smallFont : font;
                            break;
                        default:
                            int id2 = MetaTiles[index].Tiles[tileIndex].TileID;
                            value = _showHexValues ? string.Format("${0:X2}", id2) : id2.ToString();
                            break;
                    }
                    BitmapUtility.DrawTextOutline(gfx, value, drawFont, Brushes.Black, tile, format);
                    gfx.DrawString(value, drawFont, Brushes.White, tile, format);
                    tileIndex++;
                }
                value = index.ToString();
                Point point = new Point((origin.X * ImageScale) + AutoScrollPosition.X, (index * SnapSize.Height * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                RectangleF rect = new RectangleF(point.X, point.Y, _tabSize * ImageScale, _tabSize * ImageScale);
                BitmapUtility.DrawTextOutline(gfx, value, font, Brushes.Black, rect, format);
                gfx.DrawString(value, font, Brushes.White, rect, format);
                index++;
            }
        }

        /// <summary>
        /// Gets tile sections for meta tile
        /// </summary>
        /// <param name="index"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        private List<RectangleF> GetTileRects(int index, Point origin)
        {
            var rects = new List<RectangleF>();
            var offsetX = _tabSize * ImageScale;
            var offsetY = index * SnapSize.Height * ImageScale;
            for (int row = 0; row < SnapSize.Height / 8; row++)
            {
                for (int col = 0; col < SnapSize.Width / 8; col++) 
                {
                    Point point = new Point((col * 8 * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * 8 * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                    rects.Add(new RectangleF(point.X + offsetX, point.Y + offsetY, 8 * ImageScale, 8 * ImageScale));
                }
            }
            return rects;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateTiles()
        {
            if (Image == null || MetaTiles == null || MetaTiles.Count <= 0)
                return;

            var point = Point.Empty;
            point.X = _tabSize;
            using (var gfx = Graphics.FromImage(Image))
            {
                using (var pen = new Pen(_invertGridColor ? Color.White : Color.Black))
                {
                    foreach (var metaTile in MetaTiles)
                    {
                        gfx.DrawRectangle(pen, new Rectangle(point, SnapSize));
                        point.Y += SnapSize.Height;
                    }
                }
            }
            UpdateBackBuffer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="metaTiles"></param>
        /// <param name="metaTileSize"></param>
        public void SetMetaTiles(List<MetaTile> metaTiles, Size metaTileSize)
        {
            _tabSize = metaTileSize.Width == 32 ? 8 : metaTileSize.Width == 16 ? 8 : 8;
            ImageScale = metaTileSize.Width == 32 ? 3 : metaTileSize.Width == 16 ? 4 : 5;
            MetaTiles = metaTiles.DeepClone();
            SnapSize = metaTileSize;
            var metaTileByteCount = (SnapSize.Width / 8) * (SnapSize.Height / 8) * 2;
            Image = new Bitmap(SnapSize.Width + _tabSize + 2, metaTiles.Count * SnapSize.Height);
            MetaTileProperties = $"Count: {MetaTiles.Count} | Bytes: {MetaTiles.Count * metaTileByteCount}";
            var point = Point.Empty;
            using (var gfx = Graphics.FromImage(Image))
            {
                using (var pen = new Pen(_invertGridColor ? Color.White : Color.Black))
                {
                    foreach (var metaTile in MetaTiles)
                    {
                        using (var bitmap = BitmapUtility.PixelsToBitmap(metaTile.Image, metaTileSize.Width, metaTileSize.Height))
                        {
                            point.X = 0;
                            gfx.FillRectangle(Brushes.White, new Rectangle(point.X, point.Y, _tabSize, _tabSize));
                            point.X = _tabSize + 1;
                            gfx.DrawImageUnscaled(bitmap, point);
                            point.X = _tabSize;
                            gfx.DrawRectangle(pen, new Rectangle(point, metaTileSize));
                            point.Y += SnapSize.Height;
                        }
                    }
                }
            }
            UpdateBackBuffer();
        }

        /// <summary>
        /// Clears control
        /// </summary>
        public void Clear()
        {
            Image = null;
            MetaTiles?.Clear();
            MetaTiles = null;
            MetaTileProperties = "N/A";
            UpdateBackBuffer();
        }
    }
}