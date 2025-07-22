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
using System.Collections;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tile object that holds the tile id and tile attributes
    /// </summary>
    [Serializable]
    public class Tile
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileID { get; set; }                     // 9 bit tile index max value of 512
        public bool UseBGPalette { get; set; } = true;      // If using the background palette or sprite palette
        public bool Priority { get; set; } = false;         // If drawn in front of sprite or behind
        public bool FlipX { get; set; } = false;            // If flipped horizontally
        public bool FlipY { get; set; } = false;            // If flipped vertically
        public byte Bits { get; set; } = 0;                 // Unused bits value
        public string Flags { get; set; } = "";             // Quality of life string, used to display the flags on a tile
        public FlipType FlipType
        {
            get
            {
                if (FlipX && FlipY)
                    return FlipType.Both;
                else if (FlipX && !FlipY)
                    return FlipType.Horizontal;
                else if (FlipY && !FlipX)
                    return FlipType.Vertical;
                else
                    return FlipType.None;
            }
            set
            {
                switch (value)
                {
                    case FlipType.Horizontal: FlipX = true; FlipY = false; break;
                    case FlipType.Vertical: FlipX = false; FlipY = true; break;
                    case FlipType.Both: FlipX = true; FlipY = true; break;
                    default: FlipX = false; FlipY = false; break;
                }
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public Tile() { }
        public Tile(int tileID) { TileID = tileID; }
        public Tile(int tileID, FlipType flipType)
        {
            TileID = tileID;
            FlipType = flipType;
        }

        /// <summary>
        /// Gets the short value output for the given tile
        /// </summary>
        /// <param name="tile"></param>
        /// <param name="offset"></param>
        public ushort GetTileValue(int offset = 0)
        {
            var bytes = GetTileBytes(offset);
            return BitConverter.ToUInt16(bytes, 0);
        }

        /// <summary>
        /// Gets two bytes which represent the tile attributes, and the tile id
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        public byte[] GetTileBytes(int offset = 0)
        {
            int id = TileID + offset;
            bool[] bits = new bool[16];
            bits[0] = (id & (1 << 0)) != 0;
            bits[1] = (id & (1 << 1)) != 0;
            bits[2] = (id & (1 << 2)) != 0;
            bits[3] = (id & (1 << 3)) != 0;
            bits[4] = (id & (1 << 4)) != 0;
            bits[5] = (id & (1 << 5)) != 0;
            bits[6] = (id & (1 << 6)) != 0;
            bits[7] = (id & (1 << 7)) != 0;
            bits[8] = (id & (1 << 8)) != 0;
            bits[9] = FlipX;
            bits[10] = FlipY;
            bits[11] = !UseBGPalette;
            bits[12] = Priority;
            bits[13] = (Bits & (1 << 0)) != 0;
            bits[14] = (Bits & (1 << 1)) != 0;
            bits[15] = (Bits & (1 << 2)) != 0;
            byte[] result = new byte[2];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result;
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
