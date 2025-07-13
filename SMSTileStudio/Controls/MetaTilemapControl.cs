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
    public partial class MetaTilemapControl : ImageControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private bool _invertGridColor;

        /// <summary>
        /// Properties
        /// </summary>
        public Bitmap TilemapImage { get; set; }
        public List<int> MetaTilemapIds { get; set; }
        public Size MetaTileSize { get; set; } = Size.Empty;
        public Size MetaTilemapSize { get; set; } = Size.Empty;
        public string MetaTilemapProperties { get; set; } = "N/A";
        public bool InvertGridColor { get { return _invertGridColor; } set { _invertGridColor = value; UpdateTilemap(); } }

        public MetaTilemapControl()
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
        /// 
        /// </summary>
        /// <param name="gfx"></param>
        /// <param name="origin"></param>
        private void DrawAttributes(Graphics gfx, Point origin)
        {
            if (Image == null || MetaTilemapIds == null || MetaTilemapIds.Count <= 0)
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
                    Point point = new Point((col * (MetaTileSize.Width + 1)  * ImageScale) + (origin.X * ImageScale) + AutoScrollPosition.X, (row * (MetaTileSize.Height + 1) * ImageScale) + (origin.Y * ImageScale) + AutoScrollPosition.Y);
                    RectangleF rect = new RectangleF(point.X, point.Y, MetaTileSize.Width * ImageScale + (1 * ImageScale), MetaTileSize.Height * ImageScale + (1 * ImageScale));
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

            ImageScale = metaTileSize.Width == 32 ? 1 : metaTileSize.Width == 16 ? 2 : 3;
            MinimumScale = metaTileSize.Width == 32 ? 1 : metaTileSize.Width == 16 ? 2 : 3;
            int cols = image.Width / metaTileSize.Width;
            int rows = image.Height / metaTileSize.Height;
            var tilemap = new Bitmap(image.Width + (cols), image.Height + (rows), image.PixelFormat);
            Rectangle src = new Rectangle(0, 0, metaTileSize.Width, metaTileSize.Height);
            Rectangle dest = new Rectangle(0, 0, metaTileSize.Width + 1, metaTileSize.Height + 1);
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
                                gfx.DrawImageUnscaled(tile, new Point(dest.X + 1, dest.Y + 1));
                            }
                        }
                    }
                }
            }

            MetaTilemapProperties = $"Cols: {cols} | Rows: {rows} | Bytes: {cols * rows}";
            UpdateBackBuffer();
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
            UpdateBackBuffer();
        }
    }
}
