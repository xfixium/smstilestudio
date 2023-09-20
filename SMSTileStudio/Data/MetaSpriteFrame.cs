﻿// 
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
using System.Drawing;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class MetaSpriteFrame
    {
        /// <summary>
        /// Properties
        /// </summary>
        public Tileset Tileset { get; set; } = null;                              // Tileset for the frame
        public Rectangle Bounds { get; set; }                                     // Frame dimensions
        public int Duration { get; set; } = 10;                                   // Duration of frame
        public int SpriteConfig { get; set; } = 0;                                // Frame sprite configuration
        public List<Rectangle> Collisions { get; set; } = new List<Rectangle>();  // A list of collision rectangles
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();           // List of Sprites

        /// <summary>
        /// Constructors
        /// </summary>
        public MetaSpriteFrame() { }
        public MetaSpriteFrame(Rectangle bounds, Tileset tileset) { Bounds = bounds; Tileset = tileset; }

        public override string ToString()
        {
            return "Frame: " + Bounds.X + ", " + Bounds.Y + ", " + Bounds.Width + ", " + Bounds.Height;
        }
    }
}