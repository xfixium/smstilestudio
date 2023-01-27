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

namespace SMSTileStudio.Data
{
    [Serializable]
    public class Sprite
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get; set; } = 0;   // 9 bit tile index max value of 512
        public int X { get; set; } = 0;        // Horizontal offset of sprite
        public int Y { get; set; } = 0;        // Vertical offset of sprite

        /// <summary>
        /// Constructors
        /// </summary>
        public Sprite() { }
        public Sprite(int tileId, int x, int y) { TileID = tileId; X = x; Y = y; }

        /// <summary>
        /// To strng override
        /// </summary>
        public override string ToString()
        {
            return "TileID: " + TileID + ", X: " + X + ", Y: " + Y;
        }
    }
}
