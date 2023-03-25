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
    /// Tilemap object that holds the tile data, be aware that not all tilemaps have tile attribute data
    /// </summary>
    [Serializable]
    public class Tilemap : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int FrameCount { get { return Frames.Count; } }                      // The number of tilemap frames
        public int Count { get { return Columns * Rows; } }                         // The number of tiles
        public int Columns { get; set; } = 1;                                       // The number of columns
        public int Rows { get; set; } = 1;                                          // The number of rows
        public int BgPaletteID { get; set; } = -3;                                  // The display BG palette
        public int SprPaletteID { get; set; } = -2;                                 // The display SPR palette
        public bool UseTileAttributes { get; set; } = true;                         // If the tilemap tiles use attribute flags
        public BlockSizeType BlockSize { get; set; } = BlockSizeType.Sixteen;       // The size of a single block in pixels
        public Size Size { get { return new Size(Columns * 8, Rows * 8); } }        // The size of the tilemap in pixels
        public Tileset Tileset { get; set; } = null;                                // The tileset for this tilemap
        public List<byte> Blocks { get; set; } = new List<byte>();                  // Blocks
        public List<Tile> Tiles { get; set; } = new List<Tile>();                   // Tilemap tiles
        public List<Entity> Entities { get; set; } = new List<Entity>();            // Tilemap entities
        public List<Collision> Collisions { get; set; } = new List<Collision>();    // Tilemap collisions
        public List<TilemapFrame> Frames { get; set; } = new List<TilemapFrame>();  // Tilemap frames

        /// <summary>
        /// Constructors
        /// </summary>
        public Tilemap() { GameAssetType = GameAssetType.Tilemap; }
        public Tilemap(int id) { ID = id; Name = "New Tilemap " + id; GameAssetType = GameAssetType.Tilemap; }

        /// <summary>
        /// Updates the tilemap with the given tilemap
        /// </summary>
        /// <param name="tilemap">The tilemap to update with</param>
        public void Update(Tilemap tilemap)
        {
            Name = tilemap.Name;
            Length = tilemap.Length;
            ActualLength = tilemap.ActualLength;
            CompressionType = tilemap.CompressionType;
            Columns = tilemap.Columns;
            Rows = tilemap.Rows;
        }

        /// <summary>
        /// Shifts all the tiles by the given amount
        /// </summary>
        /// <param name="amount">Amount to shift</param>
        public void ShiftTiles(int amount)
        {
            ShiftTiles(amount, 0);
        }

        /// <summary>
        /// Shifts all the tiles by the given amount
        /// </summary>
        /// <param name="amount">Amount to shift</param>
        /// <param name="index">Shift tiles that are greater than or equal to the given index</param>
        public void ShiftTiles(int amount, int index)
        {
            foreach (Tile tile in Tiles)
                if (tile.TileID >= index)
                    tile.TileID += amount;
        }

        /// <summary>
        /// Replaces a given target id, with the source id
        /// </summary>
        /// <param name="sourceID">The new tile id</param>
        /// <param name="targetID">The tile id to replace</param>
        public void ReplaceTiles(int sourceID, int targetID)
        {
            foreach (Tile tile in Tiles)
                if (tile.TileID == targetID)
                    tile.TileID = sourceID;
        }

        /// <summary>
        /// Empties the tilemap tiles, and sets the tilemap dimensions
        /// </summary>
        /// <param name="cols">Number of tilemap columns</param>
        /// <param name="rows">Number of tilemap rows</param>
        public void SetEmpty(int cols, int rows)
        { 
            Columns = cols; 
            Rows = rows;
            Tiles.Clear();
            for (int i = 0; i < cols * rows; i++)
                Tiles.Add(new Tile(0));
        }

        /// <summary>
        /// Resets all tile attributes to default values
        /// </summary>
        public void ClearTileAttributes()
        {
            foreach (Tile tile in Tiles)
            {
                tile.FlipX = false;
                tile.FlipY = false;
                tile.Priority = false;
                tile.UseBGPalette = true;
                tile.Bits = 0;
            }
        }

        /// <summary>
        /// Resets all tile 0 - 7 valued bits
        /// </summary>
        public void ClearTileTypes()
        {
            foreach (Tile tile in Tiles)
                tile.Bits = 0;
        }

        /// <summary>
        /// Sets the given tile's 0 - 7 bit value
        /// </summary>
        /// <param name="targetID">The tile id to set</param>
        /// <param name="type">The type value</param>
        public void SetTileType(int targetID, byte type)
        {
            foreach (Tile tile in Tiles)
                if (tile.TileID == targetID)
                    tile.Bits = type;
        }

        /// <summary>
        /// Gets the tile id from the given bytes (9 bit value)
        /// </summary>
        /// <param name="byte1">The upper byte</param>
        /// <param name="byte2">The lower byte</param>
        /// <returns></returns>
        public static int GetTileID(byte byte1, byte byte2)
        {
            bool[] bits = new bool[9];
            bits[0] = (byte1 & (1 << 0)) != 0;
            bits[1] = (byte1 & (1 << 1)) != 0;
            bits[2] = (byte1 & (1 << 2)) != 0;
            bits[3] = (byte1 & (1 << 3)) != 0;
            bits[4] = (byte1 & (1 << 4)) != 0;
            bits[5] = (byte1 & (1 << 5)) != 0;
            bits[6] = (byte1 & (1 << 6)) != 0;
            bits[7] = (byte1 & (1 << 7)) != 0;
            bits[8] = (byte2 & (1 << 0)) != 0;
            int[] result = new int[1];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result[0];
        }

        /// <summary>
        /// Gets tile attribute flags (0 = false, 1 = true)
        /// </summary>
        /// <param name="byte1">The byte to retrieve flag bits from</param>
        /// <returns>A string representation of the tile data</returns>
        public static string GetTileFlags(byte byte1)
        {
            string flags = "";
            flags += (byte1 & (1 << 1)) != 0 ? "1" : "0"; // X flip
            flags += (byte1 & (1 << 2)) != 0 ? "1" : "0"; // Y flip
            flags += (byte1 & (1 << 3)) != 0 ? "1" : "0"; // Palette index
            flags += (byte1 & (1 << 4)) != 0 ? "1" : "0"; // Priority
            return flags == "0000" ? string.Empty : flags;
        }

        /// <summary>
        /// Gets two bytes whcih represent the tile attributes, and the tile id
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        private byte[] GetTileBytes(Tile tile)
        {
            int id = tile.TileID + Offset;
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
            bits[9] = tile.FlipX;
            bits[10] = tile.FlipY;
            bits[11] = !tile.UseBGPalette;
            bits[12] = tile.Priority;
            bits[13] = (tile.Bits & (1 << 5)) != 0;
            bits[14] = (tile.Bits & (1 << 6)) != 0;
            bits[15] = (tile.Bits & (1 << 7)) != 0;
            byte[] result = new byte[2];
            BitArray arr = new BitArray(bits);
            arr.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] GetUShortBytes(int value)
        {
            ushort convert = (ushort)value;
            var data = BitConverter.GetBytes(convert);
            return data;
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            int length = GetTilemapData(false, OrientationType.Horizontal).Length;
            var tilemapInfo = "ID: " + ID + " | Name: " + Name + " | Cols: " + Columns + " | Rows: " + Rows + " | Tile Count: " + Tiles.Count + " tiles | Length: " + length + " bytes";
            var tilesetInfo = Tileset == null ? "No Tileset information" : Tileset.GetInfo();
            return "Tilemap: " + tilemapInfo + " | Tileset: " + tilesetInfo;
        }

        /// <summary>
        /// Gets tilemap data in assembly or hex string
        /// </summary>
        /// <returns>Object data string</returns>
        public string GetDataString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Rows; row++)
            {
                string line = hex ? "" : UseTileAttributes ? ".dw " : ".db ";
                for (int col = 0; col < Columns; col++)
                {
                    byte b = (byte)Tiles[row * Columns + col].TileID;
                    byte[] bytes = GetTileBytes(Tiles[row * Columns + col]);
                    line += (hex ? "" : "$") + (UseTileAttributes ? bytes[1].ToString("X2") + (hex ? " " : "") + bytes[0].ToString("X2") : b.ToString("X2")) + " ";
                }
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets collision data in assembly or hex string
        /// </summary>
        /// <returns>Object data string</returns>
        public string GetCollisionDataString(bool hex)
        {
            if (Collisions == null)
                return "";

            // Iterate through collisions
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((hex ? "$" : ".db $") + ((byte)Collisions.Count).ToString("X2"));
            foreach (var collision in Collisions)
            {
                string line = (hex ? "" : ".db ");
                line += "$" + ((byte)collision.CollisionType).ToString("X2") + " ";
                byte[] bytes = GetUShortBytes(collision.Bounds.X);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Bounds.Y);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Bounds.Width);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Bounds.Height);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString().Trim();
        }

        /// <summary>
        /// Gets entity data in assembly or hex string
        /// </summary>
        /// <returns>Object data string</returns>
        public string GetEntityDataString(bool hex)
        {
            if (Entities == null)
                return "";

            // Iterate through collisions
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((hex ? "$" : ".db $") + ((byte)Entities.Count).ToString("X2"));
            foreach (var collision in Entities)
            {
                string line = (hex ? "" : ".db ");
                line += "$" + ((byte)collision.Id).ToString("X2") + " ";
                byte[] bytes = GetUShortBytes(collision.Collision.Bounds.X);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Collision.Bounds.Y);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Collision.Bounds.Width);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                bytes = GetUShortBytes(collision.Collision.Bounds.Height);
                line += "$" + bytes[0].ToString("X2") + " $" + bytes[1].ToString("X2") + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets tilemap data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetTilemapData(bool getRawData, OrientationType orientation)
        {
            List<byte> bytes = new List<byte>();
            switch (orientation)
            {
                case OrientationType.Horizontal:
                    foreach (Tile tile in Tiles)
                        bytes.AddRange(UseTileAttributes ? GetTileBytes(tile) : new byte[] { (byte)tile.TileID });
                    break;

                case OrientationType.ReverseHorizontal:
                    var tiles = Tiles.DeepClone();
                    tiles.Reverse();
                    foreach (Tile tile in tiles)
                        bytes.AddRange(UseTileAttributes ? GetTileBytes(tile) : new byte[] { (byte)tile.TileID });
                    break;

                case OrientationType.Vertical:
                    for (int col = 0; col < Columns; col++)
                        for (int row = 0; row < Rows; row++)
                            bytes.AddRange(UseTileAttributes ? GetTileBytes(Tiles[(Columns * row) + col]) : new byte[] { (byte)Tiles[(Columns * row) + col].TileID });
                    break;

                case OrientationType.ReverseVertical:
                    //for (int col = Columns - 1; col > -1; col--)
                    //    for (int row = Rows; row > -1; row--)
                    //        bytes.AddRange(UseTileAttributes ? GetTileBytes(Tiles[(Columns * row) + col]) : new byte[] { (byte)Tiles[(Columns * row) + col].TileID });
                    break;
            }
            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }

        /// <summary>
        /// Gets collision data
        /// </summary>
        /// <returns>An array of bytes</returns>
        public byte[] GetCollisionData()
        {
            List<byte> bytes = new List<byte>();
            if (Collisions == null)
                return bytes.ToArray();

            // Iterate through collisions
            bytes.Add((byte)Collisions.Count);
            foreach (var collision in Collisions)
            {
                bytes.Add((byte)collision.CollisionType);
                bytes.AddRange(GetUShortBytes(collision.Bounds.X));
                bytes.AddRange(GetUShortBytes(collision.Bounds.Y));
                bytes.AddRange(GetUShortBytes(collision.Bounds.Width));
                bytes.AddRange(GetUShortBytes(collision.Bounds.Height));
            }

            return bytes.ToArray();
        }

        /// <summary>
        /// Gets entity data
        /// </summary>
        /// <returns>An array of bytes</returns>
        public byte[] GetEntityData()
        {
            List<byte> bytes = new List<byte>();
            if (Entities == null)
                return bytes.ToArray();

            // Iterate through entities
            bytes.Add((byte)Entities.Count);
            foreach (var entity in Entities)
            {
                bytes.Add((byte)entity.Id);
                bytes.AddRange(GetUShortBytes(entity.Collision.Bounds.X));
                bytes.AddRange(GetUShortBytes(entity.Collision.Bounds.Y));
            }

            return bytes.ToArray();
        }
    }
}
