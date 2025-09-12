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
    [Serializable]
    public class Entity : GameAsset
    {
        /// <summary>
        /// Properties
        /// </summary>
        public string Comments { get; set; } = "";
        public List<byte> Graphic { get; set; } = new List<byte>();
        public List<EntityField> Fields { get; set; } = new List<EntityField>();

        /// <summary>
        /// Constructors
        /// </summary>
        public Entity() { GameAssetType = GameAssetType.Entity; }
        public Entity(int id) { ID = id; Name = "New Entity " + id; GameAssetType = GameAssetType.Entity; }

        /// <summary>
        /// Gets object information string
        /// </summary>
        /// <returns>Object information string</returns>
        public string GetInfo()
        {
            var count = 0;
            foreach (var field in Fields)
            {
                switch (field.ValueType)
                {
                    case EntityFieldType.Byte: count++; break;
                    case EntityFieldType.Word: count += 2; break;
                    case EntityFieldType.Long: count += 4; break;
                    default: count += field.Value.Length; break;
                }
            }
            return "ID: " + ID + " | Name: " + Name + " | Fields: " + Fields.Count + " | " + count + " byte(s)";
        }

        /// <summary>
        /// Gets two bytes whcih represent the tile attributes, and the tile id
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        private byte[] GetWord(string value)
        {
            ushort word = Convert.ToUInt16(value);
            return BitConverter.GetBytes(word);
        }

        /// <summary>
        /// Gets two bytes whcih represent the tile attributes, and the tile id
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        private byte[] GetLong(string value)
        {
            uint l = Convert.ToUInt32(value);
            return BitConverter.GetBytes(l);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="getRawData"></param>
        /// <returns></returns>
        public byte[] GetEntityData(bool getRawData)
        {
            List<byte> data = new List<byte>();
            foreach (var field in Fields)
            {
                switch (field.ValueType)
                {
                    case EntityFieldType.Byte:
                        data.Add(Convert.ToByte(field.Value));
                        break;

                    case EntityFieldType.Word:
                        data.AddRange(GetWord(field.Value));
                        break;

                    case EntityFieldType.Long:
                        data.AddRange(GetLong(field.Value));
                        break;

                    case EntityFieldType.Ints:
                        var values = field.Value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var val in values)
                        {
                            data.AddRange(GetWord(val));
                        }
                        break;
                }
            }
            return getRawData ? data.ToArray() : GetExportData(data);
        }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class EntityField
    {
        public EntityFieldType ValueType { get; set; } = EntityFieldType.Text;
        public string Name { get; set; }
        public string Value { get; set; } = string.Empty;

        public EntityField() { }
        public EntityField(EntityFieldType type, string name, string value)
        {
            ValueType = type;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetValue(string value)
        {
            switch (ValueType)
            {
                case EntityFieldType.Byte:
                    byte b;
                    if (byte.TryParse(value, out b))
                        return b.ToString();
                    else
                        return "0";

                case EntityFieldType.Word:
                    ushort w;
                    if (ushort.TryParse(value, out w))
                        return w.ToString();
                    else
                        return "0";

                case EntityFieldType.Long:
                    uint l;
                    if (uint.TryParse(value, out l))
                        return l.ToString();
                    else
                        return "0";

                case EntityFieldType.Hex:
                    // todo: parse string
                    return value;

                case EntityFieldType.Bytes:
                    // todo: parse string
                    return value;

                case EntityFieldType.Ints:
                    // todo: parse string
                    return value;

                default :
                    return value;
            }
        }
    }
}
