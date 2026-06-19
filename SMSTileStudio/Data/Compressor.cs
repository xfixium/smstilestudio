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
using System.Linq;
using System.Runtime.InteropServices;

// Code based on: https://github.com/maxim-zhao/bmp2tile/blob/master/source/bmp2tile/CompressionDllWrapper.cs
namespace SMSTileStudio.Data
{
    public class Compressor : ICompressorImpl
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        private static extern bool FreeLibrary(IntPtr hModule);

        private readonly IntPtr _hModule;

        // BMP2Tile exported function signatures
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int SaveTilesDelegate(byte[] source, uint numTiles, byte[] dest, uint destLen);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int SaveTilemapDelegate(byte[] source, uint width, uint height, byte[] dest, uint destLen);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr GetStringDelegate();

        private readonly SaveTilesDelegate _saveTiles;
        private readonly SaveTilemapDelegate _saveTilemap;

        public Compressor()
        {
            Name = "None";
            Capabilities = CompressorCapabilities.None;
        }

        public Compressor(string filename)
        {
            _hModule = LoadLibrary(filename);
            if (_hModule == IntPtr.Zero)
            {
                throw new Exception($"Failed to load {filename}. Maybe the MSVC runtime is missing?");
            }

            Name = Marshal.PtrToStringAnsi(GetFunction<GetStringDelegate>("getName")());
            Extension = Marshal.PtrToStringAnsi(GetFunction<GetStringDelegate>("getExt")());

            _saveTiles = GetFunction<SaveTilesDelegate>("compressTiles");
            _saveTilemap = GetFunction<SaveTilemapDelegate>("compressTilemap");

            Capabilities = CompressorCapabilities.None;

            if (_saveTilemap != null)
            {
                Capabilities |= CompressorCapabilities.Tilemap;
            }
            if (_saveTiles != null)
            {
                Capabilities |= CompressorCapabilities.Tiles;
            }
        }

        public string Extension { get; }

        public string Name { get; }

        public CompressorCapabilities Capabilities { get; }

        public IEnumerable<byte> CompressTiles(byte[] pixels, int count, bool asChunky)
        {
            if (_saveTiles == null)
            {
                throw new Exception($"{Name} compressor does not support tiles");
            }
            return Compress(dest => _saveTiles(pixels, (uint)count, dest, (uint)dest.Length));
        }

        public IEnumerable<byte> CompressTilemap(byte[] tilemap, int columns, int rows)
        {
            if (_saveTilemap == null)
            {
                throw new Exception($"{Name} compressor does not support tilemaps");
            }

            return Compress(dest => _saveTilemap(tilemap, (uint)columns, (uint)rows, dest, (uint)dest.Length));
        }

        private static IEnumerable<byte> Compress(Func<byte[], int> compressor)
        {
            // Then we make a buffer to compress into... we try bigger sizes if it doesn't seem big enough
            for (var bufferSize = 16 * 1024; bufferSize <= 1024 * 1024; bufferSize *= 2)
            {
                var dest = new byte[bufferSize];
                var result = compressor(dest);
                if (result < 0)
                {
                    // Failure
                    break;
                }
                if (result > 0)
                {
                    // Success - result is the byte length
                    return dest.Take(result);
                }
                // Else we need a bigger buffer...
            }
            throw new Exception("Failure compressing tiles");
        }

        private T GetFunction<T>(string functionName) where T : Delegate
        {
            var functionPointer = GetProcAddress(_hModule, functionName);
            return functionPointer == IntPtr.Zero
                ? null
                : Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
        }

        private void ReleaseUnmanagedResources()
        {
            if (_hModule != IntPtr.Zero)
            {
                FreeLibrary(_hModule);
            }
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~Compressor()
        {
            ReleaseUnmanagedResources();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}