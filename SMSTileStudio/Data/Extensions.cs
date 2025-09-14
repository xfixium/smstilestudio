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
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
using System;

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

        public static string GetDescription(this Enum enumValue)
        {
            // Get the FieldInfo for the enum member
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());

            if (field != null)
            {
                // Get the Description attribute from the field
                DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

                // Return the description if it exists, otherwise return the name
                if (attribute != null)
                {
                    return attribute.Description;
                }
            }

            // Fallback to the enum's name if no attribute is found
            return enumValue.ToString();
        }

        public static void MoveSelectedItemsUp(this ListBox listBox)
        {
            // Check if any items are selected and not already at the top
            if (listBox.SelectedIndices.Count == 0 || listBox.SelectedIndices[0] == 0)
            {
                return;
            }

            // To prevent multiple UI updates from flickering, we can temporarily suspend drawing.
            // This is optional but good practice for smooth visuals.
            listBox.BeginUpdate();

            try
            {
                // Get the indices of the selected items in ascending order.
                // A copy is necessary because the SelectedIndices collection will change.
                int[] selectedIndices = listBox.SelectedIndices.Cast<int>().ToArray();

                // Iterate through the selected items from the top down.
                // This order is crucial to prevent indices from shifting incorrectly.
                foreach (int index in selectedIndices)
                {
                    // Move the item only if the one above it isn't also selected.
                    // This ensures that contiguous blocks of selected items move together.
                    if (!listBox.SelectedIndices.Contains(index - 1))
                    {
                        object itemToMove = listBox.Items[index];
                        listBox.Items.RemoveAt(index);
                        listBox.Items.Insert(index - 1, itemToMove);
                        listBox.SetSelected(index - 1, true);
                    }
                }
            }
            finally
            {
                // Always resume drawing, even if an error occurs.
                listBox.EndUpdate();
            }
        }

        public static void MoveSelectedItemsDown(this ListBox listBox)
        {
            // Check if any items are selected and not already at the bottom
            if (listBox.SelectedIndices.Count == 0 || listBox.SelectedIndices[listBox.SelectedIndices.Count - 1] == listBox.Items.Count - 1)
            {
                return;
            }

            listBox.BeginUpdate();
            try
            {
                // Get the indices of the selected items in descending order.
                // This is crucial for "move down" to avoid index issues.
                int[] selectedIndices = listBox.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToArray();

                // Iterate through the selected items from the bottom up.
                foreach (int index in selectedIndices)
                {
                    // Ensure the item below the current one is not also selected.
                    // This keeps contiguous blocks of selected items together.
                    if (!listBox.SelectedIndices.Contains(index + 1))
                    {
                        object itemToMove = listBox.Items[index];
                        listBox.Items.RemoveAt(index);
                        listBox.Items.Insert(index + 1, itemToMove);
                        listBox.SetSelected(index + 1, true);
                    }
                }
            }
            finally
            {
                listBox.EndUpdate();
            }
        }
    }
}