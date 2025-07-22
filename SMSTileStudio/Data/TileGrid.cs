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
    [Serializable]
    public class TileGrid : GameAsset
    {
        public MetaTileSizeType TileSizeType { get; set; } = MetaTileSizeType.SixteenBySixteen;     // Tile size type
        public Size TileSize { get; set; } = new Size(16, 16);                                      // Tile size of a grids cell
        public int Columns { get; set; } = 1;                                                       // The number of columns
        public int Rows { get; set; } = 1;                                                          // The number of rows
        public List<byte> Tiles { get; set; } = new List<byte>();                                   // Tile value

        /// <summary>
        /// Constructors
        /// </summary>
        public TileGrid() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tileSize"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public TileGrid(Size tileSize, int cols, int rows)
        {
            TileSize = tileSize;
            TileSizeType = Project.GetMetatileSizeType(tileSize);
            Columns = cols;
            Rows = rows;
            Tiles.Clear();
            for (int i = 0; i < Columns * Rows; i++)
                Tiles.Add(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tileSize"></param>
        /// <param name="name"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        public TileGrid(MetaTileSizeType tileSize, string name, int cols, int rows)
        {
            Name = name;
            TileSizeType = tileSize;
            TileSize = Project.GetMetaTileSize(tileSize);
            Columns = cols;
            Rows = rows;
            Tiles.Clear();
            for (int i = 0; i < Columns * Rows; i++)
                Tiles.Add(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + " [" + Columns + ", " + Rows + ", " + Tiles.Count + "]";
        }
    }
}