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
using System.Drawing;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class Collision
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        private Rectangle _bounds = Rectangle.Empty;
        public int CollisionType { get; set; } = 0;
        public Rectangle Bounds { get { return _bounds; } set { _bounds = value; } }
        public int X { get { return Bounds.X; } set { _bounds.X = value; } }
        public int Y { get { return Bounds.Y; } set { _bounds.Y = value; } }
        public int Width { get { return Bounds.Width; } set { _bounds.Width = value; } }
        public int Height { get { return Bounds.Height; } set { _bounds.Height = value; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public Collision() { }
        public Collision(int type, Rectangle bounds) { CollisionType = type; Bounds = bounds; }

        /// <summary>
        /// Overrides
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, W: {2}, H: {3}", X, Y, Width, Height);
        }
    }
}