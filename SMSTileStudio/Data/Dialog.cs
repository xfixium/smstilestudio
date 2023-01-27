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
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class Dialog : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        private const string defaultCharacters = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}";
        public string Text { get; set; } = string.Empty;                                  // Dialog text
        public bool UseTileAttributes { get; set; } = false;                              // If using tile attributes
        public int BgPaletteID { get; set; } = -3;                                        // The display BG palette
        public int SprPaletteID { get; set; } = -2;                                       // The display SPR palette
        public int Column { get; set; } = 0;                                              // Starting horizontal position
        public int Row { get; set; } = 0;                                                 // Starting vertical position
        public int Duration { get; set; } = 0;                                            // Duration to wait till next character
        public Tileset Tileset { get; set; } = null;                                      // The tileset for this dialog
        public List<CharacterSet> CharacterMap { get; set; } = new List<CharacterSet>();  // Character map for text

        /// <summary>
        /// Constructors
        /// </summary>
        public Dialog() { GameAssetType = GameAssetType.Dialog; }
        public Dialog(int id) { ID = id; Name = "New Dialog " + id; GameAssetType = GameAssetType.Dialog; SetDefaultCharacterMap(); }

        private void SetDefaultCharacterMap()
        {
            if (CharacterMap.Count > 0)
                return;

            CharacterMap = new List<CharacterSet>();
            for (int i = 0; i < defaultCharacters.Length; i++)
                CharacterMap.Add(new CharacterSet(defaultCharacters[i], (byte)i));
        }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            return "ID: " + ID + " | Name: " + Name + " | Length: " + Length + " bytes";
        }

        /// <summary>
        /// Gets assembly string
        /// </summary>
        /// <returns>Object assembly string</returns>
        public string GetASMString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < CharacterMap.Count; i++)
            {
                string line = hex ? "" : ".db ";
                line += (hex ? "" : "$") + (CharacterMap[i].Character == '\r' ? "255" : CharacterMap[i].TileID.ToString("X2")) + " ";
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets tilemap data
        /// </summary>
        /// <param name="getRawData">If ignoring compression and data length limitation</param>
        /// <returns>An array of bytes</returns>
        public byte[] GetDialogData(bool getRawData)
        {
            List<byte> bytes = new List<byte>();
            foreach (var c in Text)
            {
                if (c == '\n')
                    continue;

                if (c == '\r')
                {
                    bytes.Add(255);
                    continue;
                }
                var charSet = CharacterMap.FirstOrDefault(x => x.Character == c);
                bytes.Add(charSet == null ? (byte)Offset : (byte)(charSet.TileID + Offset));
            }
            return getRawData ? bytes.ToArray() : GetExportData(bytes);
        }
    }

    /// <summary>
    /// Character set for a character map
    /// </summary>
    [Serializable]
    public class CharacterSet
    {
        /// <summary>
        /// Properties
        /// </summary>
        public char Character { get; set; } = ' ';
        public byte TileID { get; set; } = 0;

        /// <summary>
        /// Constructors
        /// </summary>
        public CharacterSet() { }
        public CharacterSet(char character, byte tileID) { Character = character; TileID = tileID; }
    }
}
