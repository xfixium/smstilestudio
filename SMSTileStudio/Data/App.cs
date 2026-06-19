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
