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
    public class TilemapFrame
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Count { get { return Columns * Rows; } }                   // The number of tiles
        public int Columns { get; set; } = 0;                                 // The number of columns
        public int Rows { get; set; } = 0;                                    // The number of rows
        public Size Size { get { return new Size(Columns * 8, Rows * 8); } }  // The size of the tilemap in pixels
        public List<Tile> Tiles { get; set; } = new List<Tile>();             // Frame tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public TilemapFrame() { }
        public TilemapFrame(int cols, int rows, List<Tile> tiles) { Columns = cols; Rows = rows; Tiles = tiles.DeepClone(); }
    }
}
