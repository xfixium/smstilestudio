// 
// SMS Tile Studio
// Copyright (C) 2026 xfixium | xfixium@yahoo.com
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
using System.Text;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class TileGrid : GameAsset
    {
        public TileGridSizeType TileSizeType { get; set; } = TileGridSizeType.SixteenBySixteen;     // Tile size type
        public Size TileSize { get; set; } = new Size(16, 16);                                      // Tile size of a grids cell
        public int Columns { get; set; } = 1;                                                       // The number of columns
        public int Rows { get; set; } = 1;                                                          // The number of rows
        public List<byte> Tiles { get; set; } = new List<byte>();                                   // Tile value

        /// <summary>
        /// Constructors
        /// </summary>
        public TileGrid() { }

        /// <param name="tileSize">The tile size type of the tile grid</param>
        /// <param name="name">Name of the tile grid</param>
        /// <param name="width">Tilemap width, in pixels</param>
        /// <param name="height">Tilemap height, in pixels</param>
        public TileGrid(TileGridSizeType tileSize, string name, int width, int height)
        {
            Name = name;
            TileSizeType = tileSize;
            TileSize = GetTileGridSize(tileSize);
            SetGridSize(width, height);
            Tiles.Clear();
            for (int i = 0; i < Columns * Rows; i++)
                Tiles.Add(0);
        }

        /// <summary>
        /// Returns the TileGridSizeType equivalent of the given size
        /// </summary>
        /// <param name="tileSize">The size, in pixels of a tile in a tile grid</param>
        /// <returns></returns>
        public static TileGridSizeType GetTileGridSizeType(Size tileSize)
        {
            if (tileSize == new Size(8, 8))
                return TileGridSizeType.EightByEight;
            else if (tileSize == new Size(8, 16))
                return TileGridSizeType.EightBySixteen;
            else if (tileSize == new Size(16, 16))
                return TileGridSizeType.SixteenBySixteen;
            else if (tileSize == new Size(32, 32))
                return TileGridSizeType.ThirtyTwoByThirtyTwo;
            else
                return TileGridSizeType.SixteenBySixteen;
        }

        /// <summary>
        /// Returns the size equivalent of the given TileGridSizeType
        /// </summary>
        /// <returns></returns>
        public static Size GetTileGridSize(TileGridSizeType tileSizeType)
        {
            switch (tileSizeType)
            {
                case TileGridSizeType.EightByEight: return new Size(8, 8);
                case TileGridSizeType.EightBySixteen: return new Size(8, 16);
                case TileGridSizeType.SixteenBySixteen: return new Size(16, 16);
                case TileGridSizeType.ThirtyTwoByThirtyTwo: return new Size(32, 32);
                default: return new Size(16, 16);
            }
        }

        /// <summary>
        /// Sets the TileSizeType based on tile size
        /// </summary>
        public void SetTileGridSizeTypeByTileSize()
        {
            TileSizeType = GetTileGridSizeType(TileSize);
        }

        /// <summary>
        /// Sets columns and rows tiled values based on tilemap size, in pixels
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void SetGridSize(int width, int height)
        {
            Columns = width / TileSize.Width == 0 ? 1 : width / TileSize.Width;
            Rows = height / TileSize.Height == 0 ? 1 : height / TileSize.Height;
        }

        /// <summary>
        /// Gets data string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetDataString(TextType type, bool oneDimensionalArray)
        {
            // Get byte array
            byte[] data = Tiles.DeepClone().ToArray();
            // Convert byte values to desired format
            List<string> converted = new List<string>();
            foreach (var b in data)
            {
                switch (type)
                {
                    case TextType.Asm: converted.Add("$" + b.ToString("X2")); break;
                    case TextType.Hex: converted.Add("0x" + b.ToString("X2")); break;
                    default: converted.Add(b.ToString()); break;
                }
            }
            // Build array
            StringBuilder sb = new StringBuilder();
            var name = Name.Replace(" ", "_").ToLower();
            if (type != TextType.Asm)
            {
                if (oneDimensionalArray)
                    sb.AppendLine($"const unsigned char {name} [{Columns * Rows}] =" + " {");
                else
                    sb.AppendLine($"const unsigned char {name} [{Rows}] [{Columns}] =" + " {");
            }
            for (int row = 0; row < Rows; row++)
            {
                string line = type == TextType.Asm ? ".db " : oneDimensionalArray ? "" : "{ ";
                for (int col = 0; col < Columns; col++)
                    line += converted[row * Columns + col] + (type != TextType.Asm ? ", " : " ");

                if (oneDimensionalArray)
                    sb.AppendLine(line.Trim());
                else
                    sb.AppendLine(line.Trim() + (type != TextType.Asm ? " }," : ""));
            }
            if (type != TextType.Asm)
                sb.AppendLine("};");

            return sb.ToString().Trim();
        }

        /// <summary>
        /// String override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}