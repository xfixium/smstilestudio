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
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class MetaTilemap : GameAsset
    {
        public int Count { get { return Columns * Rows; } }                                         // The number of tiles
        public int Columns { get; set; } = 1;                                                       // The number of columns
        public int Rows { get; set; } = 1;                                                          // The number of rows
        public MetatileSizeType MetaTileSize { get; set; } = MetatileSizeType.SixteenBySixteen;     // Meta Tile size
        public List<MetaTile> Tiles { get; set; } = new List<MetaTile>();                           // Metatile tile ids

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTilemap() { }
        public MetaTilemap(MetatileSizeType type, int tilemapCols, int tilemapRows)
        {
            var size = GetSize(type, tilemapCols, tilemapRows);
            MetaTileSize = type;
            Columns = size.Width;
            Rows = size.Height;
            Tiles.Clear();
            for (int i = 0; i < Count; i++)
                Tiles.Add(new MetaTile());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        private Size GetSize(MetatileSizeType type, int cols, int rows)
        {
            switch (type)
            {
                case MetatileSizeType.EightBySixteen: return new Size(cols / 8, rows / 16);
                case MetatileSizeType.SixteenBySixteen: return new Size(cols / 16, rows / 16);
                case MetatileSizeType.ThirtyTwoByThirtyTwo: return new Size(cols / 32, rows / 32);
                default: return new Size(cols / 8, rows / 8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public void Resize(int cols, int rows)
        {
            var tiles = new List<MetaTile>();
            for (int i = 0; i < cols * rows; i++)
            {
                if (i < Tiles.Count)
                    tiles.Add(Tiles[i]);
                else
                    tiles.Add(new MetaTile(0));
            }
        }
    }
}