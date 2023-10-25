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
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Inherited game object id
    /// </summary>
    [Serializable]
    public class GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public CompressionType CompressionType { get; set; } = CompressionType.None;            // Compression used for this asset, if any
        public GameAssetType GameAssetType { get; set; }                                        // Game asset type
        public bool UsesCompression { get { return CompressionType != CompressionType.None; } } // If the game asset uses compression
        public int ID { get; set; } = -1;                                                       // Unique ID or byte position in ROM data
        public string Name { get; set; } = "";                                                  // The name of the asset
        public int Length { get; set; } = 0;                                                    // The size, in bytes (Compressed or otherwise)
        public int ActualLength { get; set; } = 0;                                              // The size, in bytes Without compression
        public int Offset { get; set; } = 0;                                                    // Generic asset offset
        public bool Disable { get; set; } = false;                                              // Disable asset write

        /// <summary>
        /// Constructors
        /// </summary>
        public GameAsset() { }
        public GameAsset(int id, string name) { ID = id; Name = name; }

        /// <summary>
        /// Makes sure the given bytes (For export) are either truncated by the original asset length, 
        /// padded if not enough bytes, or overridden if the length is bigger than the original asset length
        /// Also handles compression of exported bytes
        /// </summary>
        /// <param name="bytes">The bytes to export</param>
        /// <returns>A finalized array of bytes</returns>
        public byte[] GetExportData(List<byte> bytes)
        {
            if (CompressionType != CompressionType.None)
            {
                //byte[] compressed = Compression.Compress(CompressionType, bytes.ToArray());
                //bytes.Clear();
                //bytes.AddRange(compressed);
            }

            return bytes.ToArray();
        }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>The name of the game asset</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}