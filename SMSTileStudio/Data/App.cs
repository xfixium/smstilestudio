// 
// SMS Tile Studio
// Copyright (C) 2026 xfixium | xfixium@yahoo.com
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
using System.IO;
using System.Linq;

namespace SMSTileStudio.Data
{
    public static class App
    {
        private static readonly Compressor NoCompressor = new Compressor();

        /// <summary>
        /// Properties
        /// </summary>
        public static Project Project { get; set; } = new Project();
        internal static List<Compressor> Compressors { get; } = new List<Compressor>() { NoCompressor };

        /// <summary>
        /// Reads all compression plugins from given path
        /// </summary>
        /// <param name="path">Directory where compression plugins exist</param>
        public static void GetCompressors(string path)
        {
            foreach (var filename in Directory.EnumerateFiles(path, "gfxcomp_*.dll"))
            {
                try
                {
                    var compressor = new Compressor(filename);
                    if (compressor.Capabilities == CompressorCapabilities.None)
                    {
                        compressor.Dispose();
                        continue;
                    }
                    Compressors.Add(compressor);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Gets compressors that are either tilemap or tile compressors
        /// </summary>
        /// <param name="tilemaps">If only getting compressors that compress tilemap data, else for tiles</param>
        /// <returns></returns>
        public static List<Compressor> GetCompressors(bool tilemaps)
        {
            if (tilemaps)
                return Compressors.Where(x => (x.Capabilities == (CompressorCapabilities.Tilemap | CompressorCapabilities.Tiles)) || x.Capabilities == CompressorCapabilities.Tilemap || x.Capabilities == CompressorCapabilities.None).ToList();
            else
                return Compressors.Where(x => (x.Capabilities == (CompressorCapabilities.Tilemap | CompressorCapabilities.Tiles)) || x.Capabilities == CompressorCapabilities.Tiles || x.Capabilities == CompressorCapabilities.None).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bypass"></param>
        /// <returns></returns>
        public static Compressor GetCompressor(string name, bool bypass)
        {
            return bypass || name.ToLower() == "none" ? null : Compressors.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}