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
using System.Text;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Palette object that represents colors used by the tileset (Usually 32 colors total, 16 Background, 16 Sprite) 
    /// Some data may only have 8 colors, these are typically padded to 32 colors using black, or another palette for display
    /// </summary>
    [Serializable]
    public class Palette : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<Color> Colors { get; set; } = new List<Color>();           // Palette colors
        public static List<Color> Empty { get { return GetEmptyColors(); } }   // Empty colors

        /// <summary>
        /// Constructors
        /// </summary>
        public Palette() { GameAssetType = GameAssetType.Palette; }
        public Palette(List<Color> colors) { Colors = colors; GameAssetType = GameAssetType.Palette; }
        public Palette(int id) { ID = id; Name = "New Palette " + id; Length = 16; GameAssetType = GameAssetType.Palette; }
        public Palette(int id, string name, List<Color> colors) { ID = id; Name = name; Colors = colors; Length = 16; GameAssetType = GameAssetType.Palette; }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            return "ID: " + ID + " | Name: " + Name + " | Length: " + Length + " bytes";
        }

        /// <summary>
        /// Gets a palette of empty colors
        /// </summary>
        private static List<Color> GetEmptyColors()
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < 16; i++)
                colors.Add(Color.Black);
            return colors;
        }

        /// <summary>
        /// Updates the palette with the given palette
        /// </summary>
        /// <param name="palette">The palette to update with</param>
        public void Update(Palette palette)
        {
            Name = palette.Name;
            Length = palette.Length;
            ActualLength = palette.ActualLength;
            CompressionType = palette.CompressionType;
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        public static List<Color> GetColors(byte[] data)
        {
            List<Color> colors = new List<Color>();
            foreach (byte b in data)
                colors.Add(GetColor(b));
            return colors;
        }

        /// <summary>
        /// Gets a color from the given byte 00BBGGRR 2 bits per color channel (6 bit, first 2 bits are ignored)
        /// </summary>
        /// <param name="b">Color byte value</param>
        /// <returns>A .net color</returns>
        public static Color GetColor(byte b)
        {
            List<byte> rgb = new List<byte>();
            Dictionary<byte, byte> _colorValues = new Dictionary<byte, byte> { { 0, 0 }, { 1, 85 }, { 2, 170 }, { 3, 255 } };
            for (int i = 0; i < 6; i += 2)
            {
                byte[] channel = new byte[1];
                bool[] bits = new bool[2];
                bits[0] = (b & (1 << i)) != 0 ? true : false;
                bits[1] = (b & (1 << (i + 1))) != 0 ? true : false;
                BitArray arr = new BitArray(bits);
                arr.CopyTo(channel, 0);
                rgb.Add(channel[0]);
            }
            return Color.FromArgb(_colorValues[rgb[0]], _colorValues[rgb[1]], _colorValues[rgb[2]]);
        }

        /// <summary>
        /// Gets a 6 bit SMS color value from a .net color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetColor(Color color)
        {
            try
            {
                byte[] value = new byte[1];
                List<bool> bgr = new List<bool>();
                bgr.AddRange(GetColorBits(color.R));
                bgr.AddRange(GetColorBits(color.G));
                bgr.AddRange(GetColorBits(color.B));
                bgr.AddRange(new bool[] { false, false });
                BitArray arr = new BitArray(bgr.ToArray());
                arr.CopyTo(value, 0);
                return value[0];
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex, bool over)
        {
            StringBuilder sb = new StringBuilder();
            if (!hex)
                sb.Append(".db ");
            byte[] data = GetPaletteData(true);
            foreach (byte b in data)
                sb.Append((hex ? "" : "$") + b.ToString("X2") + " ");
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Gets palette data
        /// </summary>
        /// <param name="getRawData">If ignoring compression</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetPaletteData(bool getRawData)
        {
            List<byte> bytes = new List<byte>();
            foreach (Color color in Colors.GetRange(0, Colors.Count))
            {
                bytes.Add(GetColor(color));
            }
            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }

        /// <summary>
        /// Gets bits of a given to bit color channel
        /// </summary>
        /// <param name="value">The color channel byte value</param>
        /// <returns>A bit array representing a value of 0, 1, 2, or 3</returns>
        private static bool[] GetColorBits(byte value)
        {
            switch (value)
            {
                case 85: return new bool[] { true, false };
                case 170: return new bool[] { false, true };
                case 255: return new bool[] { true, true };
                default: return new bool[] { false, false };
            }
        }
    }
}
