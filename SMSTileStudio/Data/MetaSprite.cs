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
    [Serializable]
    public class MetaSprite : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int PaletteID { get; set; } = -2;                                          // The display SPR palette
        public Point Origin { get; set; } = Point.Empty;                                  // The starting origin of the meta sprite
        public SpriteModeType SpriteMode { get; set; } = SpriteModeType.Normal;           // Sprite mode, 8 x 8 or 8 x 16
        public bool UseCollisions { get; set; } = false;                                  // If exporting collision data
        public List<MetaSpriteFrame> Frames { get; set; } = new List<MetaSpriteFrame>();  // Frames of animation

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaSprite() { GameAssetType = GameAssetType.MetaSprite; }
        public MetaSprite(int id) { ID = id; Name = "New Meta Sprite " + id; GameAssetType = GameAssetType.MetaSprite; }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            if (!hex)
                sb.Append(".db ");
            byte[] data = GetMetaSpriteData(true);
            foreach (byte b in data)
                sb.Append((hex ? "" : "$") + b.ToString("X2") + " ");
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo(int frameIndex)
        {
            var frame = frameIndex >= Frames.Count || frameIndex < 0 ? null : Frames[frameIndex];
            int length = GetMetaSpriteData(false).Length;
            var metaSpriteInfo = "ID: " + ID + " | Name: " + Name + " | Length: " + length + " | Sprite Mode: " + SpriteMode.ToString();
            var spriteInfo = frame == null ? "No Sprite information" : " | Sprite Count: " + frame.Sprites.Count;
            var tilesetInfo = frame == null ? "No Tileset information" : frame.Tileset.GetInfo();
            return "Meta Sprite: " + metaSpriteInfo + spriteInfo + " | Tileset: " + tilesetInfo;
        }

        /// <summary>
        /// Gets meta sprite data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetAllTilesetData(bool getRawData)
        {
            List<byte> bytes = new List<byte>();
            foreach (var frame in Frames)
                if (frame.Tileset != null)
                    bytes.AddRange(frame.Tileset.GetTilesetData(true));

            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }

        /// <summary>
        /// Gets meta sprite data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <param name="minimumTileCount">The minimum tiles the tileset should have</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetAllTilesetData(bool getRawData, int minimumTileCount)
        {
            List<byte> bytes = new List<byte>();
            foreach (var frame in Frames)
                if (frame.Tileset != null)
                    bytes.AddRange(frame.Tileset.GetTilesetData(true, minimumTileCount));

            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }

        /// <summary>
        /// Gets all meta sprite tilesets in one image
        /// </summary>
        /// <param name="palette"></param>
        /// <returns></returns>
        public Bitmap GetTilesetImageStrip(Palette palette)
        {
            var x = 0;
            var width = 0;
            List<byte> bytes = new List<byte>();
            foreach (var frame in Frames)
                if (frame.Tileset != null)
                    width += frame.Tileset.TileCount * 8;

            var img = new Bitmap(width, 8);
            using (var gfx = Graphics.FromImage(img))
            {
                foreach (var frame in Frames)
                {
                    if (frame.Tileset != null)
                    {
                        using (var tiles = BitmapUtility.GetTilesetImage(255, frame.Tileset, palette))
                        {
                            gfx.DrawImageUnscaled(tiles, x, 0);
                            x += frame.Tileset.TileCount * 8;
                        }
                    }
                } 
            }

            return img;
        }

        /// <summary>
        /// Returns byte array of given unsigned short
        /// </summary>
        /// <param name="val">The short value to convert into a byte array</param>
        /// <returns></returns>
        private byte[] GetShort(ushort val)
        {
            bool[] bits = new bool[16];
            bits[0] = (val & (1 << 0)) != 0;
            bits[1] = (val & (1 << 1)) != 0;
            bits[2] = (val & (1 << 2)) != 0;
            bits[3] = (val & (1 << 3)) != 0;
            bits[4] = (val & (1 << 4)) != 0;
            bits[5] = (val & (1 << 5)) != 0;
            bits[6] = (val & (1 << 6)) != 0;
            bits[7] = (val & (1 << 7)) != 0;
            bits[8] = (val & (1 << 8)) != 0;
            bits[9] = (val & (1 << 9)) != 0;
            bits[10] = (val & (1 << 10)) != 0;
            bits[11] = (val & (1 << 11)) != 0;
            bits[12] = (val & (1 << 12)) != 0;
            bits[13] = (val & (1 << 13)) != 0;
            bits[14] = (val & (1 << 14)) != 0;
            bits[15] = (val & (1 << 15)) != 0;
            byte[] result = new byte[2];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Gets meta sprite data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetMetaSpriteData(bool getRawData)
        {
            List<byte> header = new List<byte>();
            List<byte> bytes = new List<byte>();
            var headerSize = Frames.Count * 2;
            var tiles = 0;

            //bytes.AddRange(BitConverter.GetBytes((ushort)Offset));
            bytes.Add((byte)Frames.Count);
            foreach (var frame in Frames)
            {
                header.AddRange(GetShort((ushort)(bytes.Count + headerSize)));
                bytes.AddRange(GetShort((ushort)(tiles)));
                bytes.AddRange(GetShort((ushort)(frame.Tileset.Pixels.Count / 2)));
                bytes.Add((byte)frame.Duration);
                bytes.Add((byte)frame.Sprites.Count);
                //bytes.Add((byte)frame.Collisions.Count);
                foreach (var sprite in frame.Sprites)
                {
                    bytes.Add((byte)sprite.X);
                    bytes.Add((byte)sprite.Y);
                    bytes.AddRange(GetShort((ushort)sprite.TileID));
                }
                tiles += frame.Tileset.Pixels.Count / 2;
            }

            bytes.InsertRange(1, header);
            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }
    }
}
