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

// Code base on: https://github.com/maxim-zhao/bmp2tile/blob/master/source/bmp2tile/ICompressor.cs
namespace SMSTileStudio.Data
{
    /// <summary>
    /// Interface for something that can convert tiles or tilemaps to bytes
    /// </summary>
    public interface ICompressor : IDisposable
    {
        string Extension { get; }
        string Name { get; }
        CompressorCapabilities Capabilities { get; }
    }

    internal interface ICompressorImpl : ICompressor
    {
        IEnumerable<byte> CompressTiles(byte[] pixels, int count, bool asChunky);
        IEnumerable<byte> CompressTilemap(byte[] tilemap, int columns, int rows);
    }

    [Flags]
    public enum CompressorCapabilities
    {
        None = 0,
        Tiles,
        Tilemap
    }
}