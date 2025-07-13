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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class MetaTilemap : GameAsset
    {
        public MetatileSizeType MetatileSizeType { get; set; } = MetatileSizeType.SixteenBySixteen; // Meta Tile size
        public int Count { get { return Columns * Rows; } }                                         // The number of tiles
        public int Columns { get; set; } = 1;                                                       // The number of columns
        public int Rows { get; set; } = 1;                                                          // The number of rows
        public List<int> MetaTilemapIds { get; set; } = new List<int>();                            // Meta tilemap Metatile ids
        public List<MetaTile> MetaTiles { get; set; } = new List<MetaTile>();                       // Metatile tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTilemap() { }
        public MetaTilemap(MetatileSizeType type, Bitmap tilemapImage, Bitmap tilesetImage)
        {
            SetMetaTilemap(type, tilemapImage, tilesetImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="tilemapImage"></param>
        public void SetMetaTilemap(MetatileSizeType type, Bitmap tilemapImage, Bitmap tilesetImage)
        {
            // Get pixel size of a single meta tile, if smaller than the tilemap, return
            var metaTileSize = Project.GetMetaTileSize(type);
            if (tilemapImage.Width < metaTileSize.Width || tilemapImage.Height < metaTileSize.Height)
            {
                MessageBox.Show("Tilemap size must be equal to or larger than a single meta tile", "SMS Tile Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear meta tilemap data, set new meta tilemap values
            MetaTilemapIds.Clear();
            MetaTiles.Clear();
            MetatileSizeType = type;
            Columns = tilemapImage.Width / metaTileSize.Width;
            Rows = tilemapImage.Height / metaTileSize.Height;

            int index = 0;
            var imageData = new List<int[]>();
            var tilesetData = BitmapUtility.ConvertImageToTileBytesList(tilesetImage);
            Rectangle rect = new Rectangle(0, 0, metaTileSize.Width, metaTileSize.Height);

            // Iterate through tilemap image, tiled
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    // Set copy rectangle position
                    rect.X = col * metaTileSize.Width;
                    rect.Y = row * metaTileSize.Height;

                    // Copy a section of the image pixel data fast
                    var compare = BitmapUtility.GetPixels(tilemapImage, rect);

                    // If the compare is empty, skip over validation process
                    if (compare == null)
                        continue;

                    // Set match variable
                    bool match = false;

                    // Iterate through existing unique tiles for a match
                    for (int i = 0; i < imageData.Count; i++)
                    {
                        // If the compare is equal to the tile
                        if (BitmapUtility.CompareTiles(compare, imageData[i]).Item1 == true)
                        {
                            // Match is true
                            match = true;
                            MetaTilemapIds.Add(i);
                            continue;
                        }
                    }

                    // No match was found
                    if (match == false)
                    {
                        // Add tile to unique tile list
                        imageData.Add(compare);
                        // Add metatile
                        var metaTile = new MetaTile(index);
                        metaTile.Image = tilemapImage.Clone(rect, tilemapImage.PixelFormat);
                        var metaTileData = BitmapUtility.ConvertImageToTileBytesList(metaTile.Image);
                        metaTile.Tiles.AddRange(BitmapUtility.GetTilesFromTilesetData(metaTileData, tilesetData));
                        MetaTiles.Add(metaTile);
                        MetaTilemapIds.Add(index);
                        index++;
                    }
                }
            }
        }
    }
}