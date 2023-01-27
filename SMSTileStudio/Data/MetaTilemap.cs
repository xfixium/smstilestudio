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
    public class MetaTilemap : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Count { get { return Columns * Rows; } }                                 // The number of tiles
        public int Columns { get; set; } = 1;                                               // The number of columns
        public int Rows { get; set; } = 1;                                                  // The number of rows
        public int BgPaletteID { get; set; } = -3;                                          // The display BG palette
        public int SprPaletteID { get; set; } = -2;                                         // The display SPR palette
        public bool UseTileAttributes { get; set; } = true;                                 // If the tilemap tiles use attribute flags
        public Size Size { get { return new Size(Columns * 8, Rows * 8); } }                // The size of the tilemap in pixels
        public Tileset Tileset { get; set; } = null;                                        // The tileset for this tilemap
        public List<MetaTile> MetaTiles { get; set; } = new List<MetaTile>();               // Meta Tilemap tiles
        public MetaTileSizeType MetaTileSize { get; set; } = MetaTileSizeType.ThirtyTwo;    // Meta Tile size

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaTilemap() { GameAssetType = GameAssetType.Tilemap; }
        public MetaTilemap(int id) { ID = id; Name = "New Meta Tilemap " + id; GameAssetType = GameAssetType.Tilemap; }

        ///// <summary>
        ///// Sets the column and row size of all the tiles by the given amount
        ///// </summary>
        ///// <param name="amount">Amount to make meta tiles</param>
        //public void SetMetaTileSize(MetaTileSizeType metaSize)
        //{
        //    int size = 2;
        //    switch (metaSize)
        //    {
        //        case MetaTileSizeType.ThirtyTwo: size = 4; break;
        //        case MetaTileSizeType.SixtyFour: size = 8; break;
        //        case MetaTileSizeType.OneHundredTwentyEight: size = 16; break;
        //    }
        //    foreach (var tile in MetaTiles)
        //    {
        //        tile.Columns = size;
        //        tile.Rows = size;
        //    }
        //}

        /// <summary>
        /// Shifts all the meta tiles by the given amount
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
            foreach (var tile in MetaTiles)
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
            foreach (var tile in MetaTiles)
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
            MetaTiles.Clear();
            for (int i = 0; i < cols * rows; i++)
                MetaTiles.Add(new MetaTile(0));
        }
    }
}
