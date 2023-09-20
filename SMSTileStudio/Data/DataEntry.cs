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
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class DataEntry : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<byte> Data { get; set; } = new List<byte>();    // Data to write
        public string Comments { get; set; } = string.Empty;        // Comments for the data entry

        /// <summary>
        /// Constructors
        /// </summary>
        public DataEntry() { GameAssetType = GameAssetType.DataEntry; }
        public DataEntry(int id) { ID = id; Name = "New Data Entry " + id; GameAssetType = GameAssetType.DataEntry; }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            return "ID: " + ID + " | Name: " + Name + " | " + Data.Count + " byte(s)";
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Data.Count; i++)
            {
                string line = hex ? "" : ".db ";
                line += (hex ? "" : "$") + Data[i].ToString("X2") + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets tilemap data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetDataEntryData(bool getRawData)
        {
            return getRawData ? Data.ToArray() : GetExportData(Data);
        }
    }
}
