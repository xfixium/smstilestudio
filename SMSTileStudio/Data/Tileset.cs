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
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Tileset object that holds the raw pixel data making up a graphic, represented by 8 x 8 tiles.
    /// Note: When tileset pixel data is imported, it is represented by a whole byte in this object.
    /// The typical format of a single pixel for SMS is stored as 4bpp (Nibble 0BGR). Although 
    /// technically 3bpp, the first bit is not used. An 8 x 8 tile is stored in the ROM is 32 bytes in size
    /// Versus the 64 bytes it becomes when imported into this object.
    /// </summary>
    [Serializable]
    public class Tileset : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int TileCount { get { return Pixels.Count / 64; } }  // The number of 8 x 8 tiles the tileset has
        public int BitsPerPixel { get; set; } = 4;                  // Bits per pixel
        public bool Masked { get; set; } = false;                   // If the pixel data is offset by 2 times the value, except when the value is zero
        public List<byte> Pixels { get; set; } = new List<byte>();  // The raw pixel data, the byte value will be an index of 0 - 15 (16 colors)

        /// <summary>
        /// Constructors
        /// </summary>
        public Tileset() { }

        /// <summary>
        /// Updates the tileset with the given tileset
        /// </summary>
        /// <param name="tileset">The tileset to update with</param>
        public void Update(Tileset tileset)
        {
            Name = tileset.Name;
            Length = tileset.Length;
            ActualLength = tileset.ActualLength;
            CompressionType = tileset.CompressionType;
            Masked = tileset.Masked;
        }

        /// <summary>
        /// Gets a pixel color index (4bpp planar)
        /// </summary>
        /// <param name="bitPlanes">The bit planes to combine into a color index</param>
        /// <param name="bit">The bit we're combining</param>
        /// <returns>A single pixel color index</returns>
        public static byte GetPixel(byte[] bitPlanes, int bit)
        {
            bool[] bits = new bool[4];
            bits[0] = (bitPlanes[0] & (1 << bit)) != 0;
            bits[1] = (bitPlanes[1] & (1 << bit)) != 0;
            bits[2] = (bitPlanes[2] & (1 << bit)) != 0;
            bits[3] = (bitPlanes[3] & (1 << bit)) != 0;
            byte[] result = new byte[1];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0];
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            int length = GetTilesetData(false, 0, TileCount).Length;
            return "Tile Count: " + TileCount + " tiles | Length: " + length + " bytes";
        }

        /// <summary>
        /// Gets tileset data in assembly or hex string
        /// </summary>
        /// <param name="hex">If only getting raw hex values</param>
        /// <returns>Object assembly string</returns>
        public string GetDataString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            byte[] data = GetTilesetData(true, 0, TileCount);
            for (int i = 0; i < data.Length / 32; i++)
            {
                string line = hex ? "" : ".db ";
                for (int j = 0; j < 32; j++)
                    line += (hex ? "" : "$") + data[i * j + j].ToString("X2") + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Prefixes an empty tile to the tileset
        /// </summary>
        public void AddEmptyTile()
        {
            for (int i = 0; i < 64; i++)
                Pixels.Insert(0, 0);
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id. 
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <returns>A tile's worth of pixel data</returns>
        public List<byte> GetTilePixels(int tileID)
        {
            return Pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Sets a tile's worth of pixel data starting at the given tile id. 
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <returns>A tile's worth of pixel data</returns>
        public void SetTilePixels(int tileID, List<byte> pixels)
        {
            int index = 0;
            int count = tileID * 64 + 64;
            for (int i = tileID * 64; i < count; i++)
            {
                Pixels[i] = pixels[index];
                index++;
            }
        }

        /// <summary>
        /// Swaps out target color with selected color
        /// </summary>
        /// <param name="target">Color to swap</param>
        /// <param name="source">Replacement color</param>
        public void SwapPixels(byte target, byte source)
        {
            for (int i = 0; i < Pixels.Count; i++)
                if (Pixels[i] == target)
                    Pixels[i] = source;
        }

        /// <summary>
        /// Gets a tile's worth of pixel data starting at the given tile id
        /// </summary>
        /// <param name="tileID">The tile to get the pixel data of</param>
        /// <param name="pixels">The list of pixels to get the pixel data from</param>
        /// <returns>A tile's worth of pixel data</returns>
        public static List<byte> GetTilePixels(int tileID, List<byte> pixels)
        {
            return pixels.GetRange(tileID * 64, 64);
        }

        /// <summary>
        /// Gets the edit data in bytes
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetTilesetData(bool getRawData)
        {
            return GetTilesetData(getRawData, 0, TileCount);
        }

        /// <summary>
        /// Gets the edit data in bytes
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="minimumTileCount">The minimum tiles the tileset should have</param>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetTilesetData(bool getRawData, int minimumTileCount)
        {
            var tileset = new List<byte>(GetTilesetData(getRawData, 0, TileCount));
            tileset.AddRange(GetPadding(minimumTileCount));
            return tileset.ToArray();
        }

        /// <summary>
        /// Gets the edit data in bytes
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="start">Starting index to get data from</param>
        /// <param name="end">Ending index get data to</param>
        /// <returns>An array of edit byte data</returns>
        public byte[] GetTilesetData(bool getRawData, int start, int end)
        {
            List<byte> bytes = new List<byte>();
            List<byte> pixels = new List<byte>();

            pixels.AddRange(Pixels.ToArray());
            if (Masked)
            {
                for (int i = 0; i < pixels.Count; i++)
                    pixels[i] = pixels[i] == 0 ? (byte)1 : (byte)(pixels[i] * 2);
            }
            for (int i = 0; i < pixels.Count; i += 8)
            {
                List<bool[]> row = new List<bool[]>();
                for (int j = 0; j < 8; j++)
                    row.Add(GetPlaneBits(pixels[i + j]));

                for (int k = 0; k < 4; k++)
                {
                    int index = 7;
                    byte[] value = new byte[1];
                    bool[] bits = new bool[8];
                    for (int l = 0; l < 8; l++)
                    {
                        bits[l] = row[index][k];
                        index--;
                    }
                    BitArray arr = new BitArray(bits);
                    arr.CopyTo(value, 0);
                    bytes.Add(value[0]);
                }
            }

            var s = start * 32;
            var count = (end * 32) - s;
            var data = bytes.GetRange(s, count);
            return getRawData ? data.ToArray() : GetExportData(data);
        }

        /// <summary>
        /// Gets empty padding bytes
        /// </summary>
        /// <param name="minimumCount">The minimum tiles the tileset should have</param>
        public byte[] GetPadding(int minimumTileCount)
        {
            if (minimumTileCount <= 0 || minimumTileCount <= TileCount)
                return new byte[0];

            var tiles = new byte[(minimumTileCount - TileCount) * 32];
            Array.Clear(tiles, 0, tiles.Length);
            return tiles;
        }

        /// <summary>
        /// Gets bits of the given color index byte
        /// </summary>
        /// <param name="value">The color index value (0 - 15)</param>
        /// <returns>A bit array representing a color index value</returns>
        private static bool[] GetPlaneBits(byte value)
        {
            switch (value)
            {
                case 1: return new bool[] { true, false, false, false };
                case 2: return new bool[] { false, true, false, false };
                case 3: return new bool[] { true, true, false, false };
                case 4: return new bool[] { false, false, true, false };
                case 5: return new bool[] { true, false, true, false };
                case 6: return new bool[] { false, true, true, false };
                case 7: return new bool[] { true, true, true, false };
                case 8: return new bool[] { false, false, false, true };
                case 9: return new bool[] { true, false, false, true };
                case 10: return new bool[] { false, true, false, true };
                case 11: return new bool[] { true, true, false, true };
                case 12: return new bool[] { false, false, true, true };
                case 13: return new bool[] { true, false, true, true };
                case 14: return new bool[] { false, true, true, true };
                case 15: return new bool[] { true, true, true, true };
                default: return new bool[] { false, false, false, false };
            }
        }
    }
}