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
using System.ComponentModel;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum GameAssetType : int
    {
        [Description("Palette")]
        Palette = 0,
        [Description("Tilemap")]
        Tilemap = 1,
        [Description("Meta Sprite")]
        MetaSprite = 2,
        [Description("Dialog")]
        Dialog = 3,
        [Description("Data Entry")]
        DataEntry = 4,
        [Description("Meta Tilemap")]
        MetaTilemap = 5
    }

    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum CompressionType : int
    {
        [Description("None")]
        None = 0,
        [Description("PS RLE Planar 4")]
        PSRLEPlanar4 = 1,
        [Description("PS RLE Linear")]
        PSRLELinear = 2,
        [Description("PS RLE Planar 2")]
        PSRLEPlanar2 = 3,
        [Description("Sonic 1")]
        Sonic1 = 4
    }

    /// <summary>
    /// Describes the swatch types
    /// </summary>
    public enum SwatchType
    {
        [Description("Aseprite")]
        Aseprite = 0,
        [Description("Sequential")]
        Sequential = 1,
        [Description("Six Colors")]
        SixColors = 2
    }

    /// <summary>
    /// Describes the flip direction types
    /// </summary>
    public enum FlipType
    {
        [Description("None")]
        None = 0,
        [Description("Horizontal")]
        Horizontal = 1,
        [Description("Vertical")]
        Vertical = 2,
        [Description("Both")]
        Both = 3
    }

    /// <summary>
    /// Describes sprite mode types
    /// </summary>
    public enum SpriteModeType
    {
        [Description("Normal (8 x 8)")]
        Normal = 0,
        [Description("Tall (8 x 16)")]
        Tall = 1
    }

    /// <summary>
    /// Describes the swatch types
    /// </summary>
    public enum PaletteModeType
    {
        [Description("Tilemap")]
        Tilemap = 0,
        [Description("Sprite")]
        Sprite = 1
    }

    /// <summary>
    /// Describes tile attribute edit type
    /// </summary>
    public enum TileEditType
    {
        [Description("Tile ID")]
        TileID = 0,
        [Description("Horizontal Flip")]
        XFlip = 1,
        [Description("Vertical Flip")]
        YFlip = 2,
        [Description("Priority")]
        Priority = 3,
        [Description("Palette Index")]
        PaletteIndex = 4,
        [Description("Tile Select")]
        Selection = 5,
        [Description("Unused Bits")]
        Bits = 6
    }

    /// <summary>
    /// Describes meta sprite edit type
    /// </summary>
    public enum MetaSpriteEditType
    {
        [Description("Sprites")]
        Sprites = 0,
        [Description("Rects")]
        Rects = 1
    }

    /// <summary>
    /// Compression type enumeration
    /// </summary>
    public enum MetaTileSizeType : int
    {
        [Description("16 x 16")]
        Sixteen = 0,
        [Description("32 x 32")]
        ThirtyTwo = 1,
        [Description("64 x 64")]
        SixtyFour = 2,
        [Description("128 x 128")]
        OneHundredTwentyEight = 3
    }

    /// <summary>
    /// Describes tilemap data orientation types
    /// </summary>
    public enum OrientationType
    {
        [Description("Horizontal")]
        Horizontal = 0,
        [Description("Reverse Horizontal")]
        ReverseHorizontal = 1,
        [Description("Vertical")]
        Vertical = 2,
        [Description("Reverse Vertical")]
        ReverseVertical = 3
    }

    /// <summary>
    /// Describes bits per pixel types
    /// </summary>
    public enum BppType
    {
        one = 0,
        Two = 1,
        Three = 2,
        Four = 3
    }

    /// <summary>
    /// Gets a list of enumeration values, using the description as the display member
    /// </summary>
    public static class EnumMethods
    {
        /// <summary>
        /// Gets an enumerations decription attribute
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static string GetDescription(object enumType)
        {
            Type type = enumType.GetType();
            int value = (int)enumType;
            string name = Enum.GetName(type, value);
            if (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false).Length <= 0)
                return "";
            return (type.GetMember(name).First().GetCustomAttributes(typeof(DescriptionAttribute), false)[0] as DescriptionAttribute).Description;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="valueSorted"></param>
        /// <returns></returns>
        public static List<dynamic> GetEnumCollection(Type enumType, bool valueSorted = true)
        {
            if (valueSorted)
            {
                return Enum.GetValues(enumType)
                        .Cast<Enum>()
                        .Select(value => new
                        {
                            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                            value
                        })
                        .OrderBy(item => item.value)
                        .ToList<dynamic>();
            }
            else
            {
                return Enum.GetValues(enumType)
                        .Cast<Enum>()
                        .Select(value => new
                        {
                            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                            value
                        })
                        .OrderBy(item => item.Description)
                        .ToList<dynamic>();
            }
        }

        public static object GetValue(object item)
        {
            return item.GetType().GetProperty("value").GetValue(item, null);
        }
    }
}