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
using System.Linq;
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
        public int TileMinimum { get; set; } = 0;                                         // Minimum amount of tiles, for padding
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
            byte[] data = GetMetaSpriteData(true, true);
            foreach (byte b in data)
                sb.Append((hex ? "" : "$") + b.ToString("X2") + " ");
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Gets an c array string for DevKit SMS
        /// </summary>
        /// <returns></returns>
        public string GetDKSMSString(bool streaming)
        {
            var offset = 0;
            var name = Name.ToLower().Replace(" ", "_");
            var durations = new StringBuilder();
            durations.AppendLine("// " + name);
            durations.Append("const unsigned char " + name + "_durations[] = { ");
            var sprites = new StringBuilder();
            var frames = new StringBuilder();
            frames.Append("const unsigned char *" + name + "_frames[] = { ");
            for (int i = 0; i < Frames.Count; i++)
            {
                durations.Append(Frames[i].Duration + ", ");
                sprites.Append("const unsigned char " + name + "_" + i.ToString("D2") + "[] = { ");
                foreach (var s in Frames[i].Sprites)
                    sprites.Append(s.X + ", " + s.Y + ", " + (s.TileID + offset + Offset) + ", ");
                sprites.Append("METASPRITE_END };" + Environment.NewLine);
                frames.Append(name + "_" + i.ToString("D2") + ", ");
                if (!streaming)
                    offset += Frames[i].Tileset.TileCount;
            }
            durations.Append(" };");
            frames.Append(" };");
            var di = durations.ToString().Trim().LastIndexOf(", ");
            var fi = frames.ToString().Trim().LastIndexOf(", ");
            return (Frames.Count > 1 ? durations.ToString().Trim().Remove(di, 2) + Environment.NewLine : "") + sprites.ToString().Trim() + (Frames.Count > 1 ? Environment.NewLine + frames.ToString().Trim().Remove(fi, 2) : "");
        }

        /// <summary>
        /// Gets an c array string for DevKit SMS
        /// </summary>
        /// <returns></returns>
        public string GetDKSMSString(List<Sprite> sprites)
        {
            var name = Name.ToLower().Replace(" ", "_");
            var text = new StringBuilder();
            var frames = new StringBuilder();
            frames.Append("const unsigned char *" + name + "_frames[] = { ");
            for (var i = 0; i < sprites.Count; i++)
            {
                text.Append("const unsigned char " + name + "_" + i.ToString("D2") + "[] = { ");
                text.Append(sprites[i].X + ", " + sprites[i].Y + ", " + (sprites[i].TileID + Offset) + ", ");
                text.Append("METASPRITE_END };" + Environment.NewLine);
                frames.Append(name + "_" + i.ToString("D2") + ", ");
            }
            frames.Append(" };");
            var fi = frames.ToString().Trim().LastIndexOf(", ");
            return text.ToString().Trim() + Environment.NewLine + frames.ToString().Trim().Remove(fi, 2);
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo(int frameIndex)
        {
            var frame = frameIndex >= Frames.Count || frameIndex < 0 ? null : Frames[frameIndex];
            int length = GetMetaSpriteData(false, true).Length;
            var metaSpriteInfo = "ID: " + ID + " | Name: " + Name + " | Length: " + length + " | Sprite Mode: " + SpriteMode.ToString();
            var spriteInfo = frame == null ? "No Sprite information" : " | Sprite Count: " + frame.Sprites.Count;
            var tilesetInfo = frame == null ? "No Tileset information" : frame.Tileset.GetInfo();
            return "Meta Sprite: " + metaSpriteInfo + spriteInfo + " | Tileset: " + tilesetInfo;
        }

        // Mirrors the sprite in the given directions
        public void Mirror(bool flipX, bool flipY)
        {
            foreach (var f in Frames)
            {
                f.Tileset.Pixels = BitmapUtility.GetMirroredPixels(f.Tileset.Pixels, flipX, flipY);
                var lx = f.Sprites.Min(x => x.X);
                var hx = f.Sprites.Max(x => x.X);
                foreach (var s in f.Sprites)
                {
                    s.X -= (s.X * 2);
                    s.X += hx + lx;
                }
            }
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
        /// Gets all meta sprite pixel data as a tileset
        /// </summary>
        /// <returns>A tileset from combined fraames</returns>
        public Tileset GetTileset()
        {
            List<byte> bytes = new List<byte>();
            foreach (var frame in Frames)
                if (frame.Tileset != null)
                    bytes.AddRange(frame.Tileset.Pixels);

            return new Tileset { Pixels = bytes };
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
        /// <param name="framed">If tile index base starts at zero, or accumulative from last frame tileset</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetMetaSpriteData(bool getRawData, bool framed)
        {
            List<byte> header = new List<byte>();
            List<byte> bytes = new List<byte>();
            var headerSize = Frames.Count * 2;
            var pixels = 0;
            //var tiles = 0;

            // Data Structure:
            // 0 = Frame count
            // 1 - ?? Header, data start location for each frame (2 bytes each)
            // Frame Data:
            // 0 = Frame tileset data start location (2 bytes)
            // 1 = Frame sprite config (1 byte)
            // 2 = Frame duration time (1 byte)
            // 3 = Frame sprite count (1 byte)
            // Frame Sprite Data:
            // 0 = Sprite X position (1 byte)
            // 1 = Sprite Y position (1 byte)
            // 2 = Sprite tile id (1 byte)
            // 3 = Reserved
            bytes.Add((byte)Frames.Count);
            foreach (var frame in Frames)
            {
                header.AddRange(GetShort((ushort)(bytes.Count + headerSize)));
                bytes.AddRange(GetShort((ushort)(pixels / 2)));
                bytes.Add((byte)frame.SpriteConfig);
                bytes.Add((byte)frame.Duration);
                //bytes.Add((byte)frame.Sprites.Count);
                //foreach (var sprite in frame.Sprites)
                //{
                //    bytes.Add((byte)sprite.X);
                //    bytes.Add((byte)sprite.Y);
                //    bytes.Add((byte)(sprite.TileID + (framed ? 0 : tiles) + Offset));
                //    bytes.Add(0);
                //}
                //tiles = frame.Tileset.TileCount;
                pixels += frame.Tileset.GetTilesetData(true, TileMinimum).Length;
            }

            bytes.InsertRange(1, header);
            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }
    }
}
