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

using System;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class MetaTile : Tile
    {
        public List<Tile> Tiles { get; set; } = new List<Tile>();  // Meta tile tiles

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTile() { }
        public MetaTile(int tileID) { TileID = tileID; }
        public MetaTile(int tileID, FlipType flipType)
        {
            TileID = tileID;
            switch (flipType)
            {
                case FlipType.Horizontal: FlipX = true; break;
                case FlipType.Vertical: FlipY = true; break;
                case FlipType.Both: FlipX = true; FlipY = true; break;
                default: break;
            }
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public override string ToString()
        {
            string palette = UseBGPalette ? "Background" : "Sprite";
            return "ID: " + TileID.ToString() + " | HFlip: " + FlipX + " | VFlip: " + FlipY + " | Priority: " + Priority + " | Palette: " + palette + " | Bits: " + Bits;
        }
    }
}
