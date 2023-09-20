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

using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMSTileStudio.Data
{
    public static class Extensions
    {
        // Deep copy of object
        public static T DeepClone<T>(this T obj)
        {
            if (obj == null)
                return obj;

            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }

        // Converts strong typed asset list to base game asset list
        public static List<GameAsset> ToAssetList<T>(this List<T> list)
        {
            // omits validation, etc.
            return list.Cast<GameAsset>().ToList();
        }

        // Check string if numeric
        public static bool IsNumber<T>(this T obj, string number)
        {
            return int.TryParse(number, out _);
        }

        // Gets a value field and converts it to the base type
        public static object GetValue<T>(this T obj)
        {
            return obj.GetType().GetProperty("value").GetValue(obj, null);
        }
    }
}