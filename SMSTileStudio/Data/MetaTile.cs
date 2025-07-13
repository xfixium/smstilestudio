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

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class MetaTile
    {
        public int TileID { get; set; }                            // Metatile tile id
        public Bitmap Image { get; set; }                          // Metatile graphic
        public List<Tile> Tiles { get; set; } = new List<Tile>();  // Metatile tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTile() { }
        public MetaTile(int id) { TileID = id; }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string ToString()
        {
            return "ID: " + TileID.ToString();
        }
    }
}
