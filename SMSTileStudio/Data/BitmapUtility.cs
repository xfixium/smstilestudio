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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SMSTileStudio.Data
{
    /// <summary>
    /// Utility that deals with .net bitmap data
    /// </summary>
    public class BitmapUtility
    {
        /// <summary>
        /// Gets a blank image of palette colors
        /// </summary>
        /// <param name="blockSize">Size of each color block, in pixels</param>
        /// <param name="count">Number of desired colors to display, independent of the colors given</param>
        /// <returns>An image of the palette</returns>
        public static Bitmap GetPaletteImage(Size blockSize, int count)
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < count; i++)
                colors.Add(Color.Black);
            return GetPaletteImage(colors, blockSize, count);
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <param name="palette">The given color palette to generate an image of</param>
        /// <param name="blockSize">Size of each color block, in pixels</param>
        /// <param name="count">Number of desired colors to display, independent of the colors given</param>
        /// <returns>An image of the palette</returns>
        public static Bitmap GetPaletteImage(Palette palette, Size blockSize, int count)
        {
            return GetPaletteImage(palette.Colors, blockSize, count);
        }

        /// <summary>
        /// Gets an image of palette colors
        /// </summary>
        /// <param name="colors">The given colors to generate an image of</param>
        /// <param name="blockSize">Size of each color block, in pixels</param>
        /// <param name="count">Number of desired colors to display, independent of the colors given</param>
        /// <returns>An image of the palette</returns>
        public static Bitmap GetPaletteImage(List<Color> colors, Size blockSize, int count)
        {
            int xOffset = 4;
            int yOffset = 0;
            int width = blockSize.Width;
            int height = blockSize.Height;
            Bitmap bmp = new Bitmap((blockSize.Width * 16) + (xOffset * 17), count > 16 ? (blockSize.Height * 2) + 5 : blockSize.Height + 2);
            if (colors.Count < count)
                for (int i = colors.Count - 1; i < 16; i++)
                    colors.Add(Color.Black);

            bmp.SetResolution(72, 72);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    int index = 0;
                    foreach (Color color in colors)
                    {
                        if (index == 16)
                        {
                            xOffset = 4;
                            yOffset = blockSize.Height + 3;
                        }
                        brush.Color = color;
                        gfx.FillRectangle(Brushes.Black, xOffset + 1, yOffset + 2, width, height);
                        gfx.FillRectangle(Brushes.White, xOffset + 2, yOffset + 3, width - 2, height - 2);
                        gfx.FillRectangle(brush, xOffset + 3, yOffset + 4, width - 4, height - 4);
                        xOffset += width + 4;
                        index++;
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets an image of the tileset using custom amount of columns
        /// </summary>
        /// <param name="tileset">Tileset data</param>
        /// <param name="palette">Tileset color palette</param>
        /// <param name="columns">The width of the image, in tiled columns</param>
        /// <returns>An image of the tileset</returns>
        public static Bitmap GetTilesetImage(Tileset tileset, Palette palette, int columns, bool transparent = false)
        {
            return GetTilesetImage(tileset.Pixels, 255, palette.Colors, columns, transparent);
        }

        /// <summary>
        /// Gets an image of the tileset using a single row of tiles
        /// </summary
        /// <param name="alpha">Amount of transparency</param>
        /// <param name="tileset">Tileset data</param>
        /// <param name="palette">Tileset color palette</param>
        /// <returns>An image of the tileset</returns>
        public static Bitmap GetTilesetImage(byte alpha, Tileset tileset, Palette palette, bool transparent = false)
        {
            return GetTilesetImage(alpha, tileset, palette, 1, transparent);
        }

        /// <summary>
        /// Gets the given tileset data as a compiled bitmap image
        /// </summary>
        /// <param name="alpha">Amount of transparency</param>
        /// <param name="pixels">The tileset pixel data</param>
        /// <param name="colors">Tileset color palette</param>
        /// <param name="rows">The height of the image, in tiled rows</param>
        /// <returns>A bitmap image of the tileset data</returns>
        public static Bitmap GetTilesetImage(byte alpha, List<byte> pixels, List<Color> colors, int rows, bool transparent = false)
        {
            Tileset tileset = new Tileset();
            tileset.Pixels = pixels;
            Palette palette = new Palette();
            palette.Colors = colors;
            return GetTilesetImage(alpha, tileset, palette, rows, transparent);
        }

        /// <summary>
        /// Gets the given tileset data as a compiled bitmap image
        /// </summary>
        /// <param name="alpha">Amount of transparency</param>
        /// <param name="tileset">Tileset data</param>
        /// <param name="palette">Tileset color palette</param>
        /// <param name="rows">The height of the image, in tiled rows</param>
        /// <returns>A bitmap image of the tileset data</returns>
        public static Bitmap GetTilesetImage(byte alpha, Tileset tileset, Palette palette, int rows, bool transparent = false)
        {
            int tileID = 0;
            int pixel = 0;
            int tileSize = 8;
            int cols = (int)Math.Ceiling((tileset.TileCount) / Convert.ToDouble(rows));
            Bitmap bmp = new Bitmap(cols * tileSize, rows * tileSize);
            List<byte> pixels = new List<byte>(tileset.Pixels.ToArray());

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            for (int y = 0; y < tileSize; y++)
                            {
                                for (int x = 0; x < tileSize; x++)
                                {
                                    if (pixel >= pixels.Count)
                                        break;

                                    if (pixels[pixel] < palette.Colors.Count)
                                    {
                                        brush.Color = transparent && pixels[pixel] == 0 ? Color.Transparent :  Color.FromArgb(alpha, palette.Colors[pixels[pixel]]);
                                        gfx.FillRectangle(brush, (col * tileSize) + x, (row * tileSize) + y, 1, 1);
                                    }
                                    pixel++;
                                }
                            }
                            if (tileID >= pixels.Count / 64)
                                break;

                            tileID++;
                        }
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets the given tileset data as a compiled bitmap image
        /// </summary>
        /// <param name="pixels">The tileset pixel data</param>
        /// <param name="alpha">Amount of transparency</param>
        /// <param name="palette">Tileset color palette</param>
        /// <param name="columns">The width of the image, in tiled columns</param>
        /// <param name="offset">The number of tiles to prefix to the image</param>
        /// <returns>A bitmap image of the tileset data</returns>
        public static Bitmap GetTilesetImage(List<byte> pixels, byte alpha, List<Color> palette, int columns, bool transparent = false)
        {
            List<byte> copy = new List<byte>(pixels.ToArray());
            int tileID = 0;
            int pixel = 0;
            int tileSize = 8;
            int count = copy.Count / 64;
            int rows = (int)Math.Ceiling(count / Convert.ToDouble(columns));
            Bitmap bmp = new Bitmap(columns * tileSize, rows * tileSize);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(Color.Empty))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < columns; col++)
                        {
                            for (int y = 0; y < tileSize; y++)
                            {
                                for (int x = 0; x < tileSize; x++)
                                {
                                    if (pixel >= copy.Count)
                                        break;
                                    if (copy[pixel] < palette.Count)
                                    {
                                        brush.Color = transparent && pixels[pixel] == 0 ? Color.Transparent : Color.FromArgb(alpha, palette[copy[pixel]]);
                                        gfx.FillRectangle(brush, (col * tileSize) + x, (row * tileSize) + y, 1, 1);
                                    }
                                    pixel++;
                                }
                            }
                            if (tileID >= copy.Count / 64)
                                break;

                            tileID++;
                        }
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Gets an image based on given tiles
        /// <param name="pixelTiles"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static Bitmap GetPixelTilesImage(List<PixelTile> pixelTiles, int columns)
        {
            int tileSize = 8;
            int width = columns * tileSize;
            int height = (int)Math.Ceiling(pixelTiles.Count / Convert.ToDouble(columns)) * tileSize;
            int cols = width / tileSize;
            int rows = height / tileSize;
            int index = 0;
            Bitmap image = new Bitmap(width, height);
            using (Graphics gfx = Graphics.FromImage(image))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (index >= pixelTiles.Count)
                            break;

                        using (Bitmap temp = PixelsToBitmap(pixelTiles[index].Pixels.ToArray(), tileSize, tileSize))
                        {
                            gfx.DrawImageUnscaled(temp, col * tileSize, row * tileSize);
                        }
                        index++;
                    }
                }
                return image;
            }
        }

        /// <summary>
        /// Gets an image of the sprite
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from</param>
        /// <param name="tilemap">The tilemap for the layout of the tiles</param>
        /// <param name="bgColors">The background palette colors to use</param>
        /// <param name="sprColors">The sprite palette colors to use</param>
        /// <returns>An image of the sprite</returns>
        public static Bitmap GetTileImage(Tileset tileset, Tilemap tilemap, List<Color> bgColors, List<Color> sprColors)
        {
            return GetTileImage(tileset, tilemap, new Palette(bgColors), new Palette(sprColors));
        }

        /// <summary>
        /// Gets an image of the sprite
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from</param>
        /// <param name="tilemap">The tilemap for the layout of the tiles</param>
        /// <param name="bgPalette">The background palette colors to use</param>
        /// <param name="sprPalette">The sprite palette colors to use</param>
        /// <returns>An image of the sprite</returns>
        public static Bitmap GetTileImage(Tileset tileset, Tilemap tilemap, Palette bgPalette, Palette sprPalette)
        {
            return GetTileImage(tileset, tilemap, bgPalette, sprPalette, 8);
        }

        /// <summary>
        /// Gets an image of the sprite
        /// </summary>
        /// <param name="tileset">The tileset to draw tiles from</param>
        /// <param name="tilemap">The tilemap for the layout of the tiles</param>
        /// <param name="bgPalette">The background palette colors to use</param>
        /// <param name="sprPalette">The sprite palette colors to use</param>
        /// <param name="tileSize">Pixel tile size, squared</param>
        /// <returns>An image of the sprite</returns>
        public static Bitmap GetTileImage(Tileset tileset, Tilemap tilemap, Palette bgPalette, Palette sprPalette, int tileSize)
        {
            int width = tilemap.Columns * tileSize;
            int height = tilemap.Rows * tileSize;
            int[] tiles = new int[width * height];
            List<Tile> tileList = tilemap.Tiles;
            List<byte> pixels = tileset.Pixels.DeepClone();

            for (int row = 0; row < tilemap.Rows; row++)
            {
                for (int col = 0; col < tilemap.Columns; col++)
                {
                    int index = (tilemap.Columns * row) + col;
                    if (index >= tileList.Count)
                        break;

                    int tileID = tileList[index].TileID;
                    Rectangle src = new Rectangle(tileID * tileSize, 0, tileSize, tileSize);
                    if (tileID * 64 >= pixels.Count)
                        break;

                    var flipX = tileList[index].FlipX;
                    var flipY = tileList[index].FlipY;
                    int[] tile = GetTilePixels(pixels.GetRange(tileID * 64, 64), tileList[index].UseBGPalette ? bgPalette.Colors : sprPalette.Colors, flipX, flipY);
                    for (int y = 0; y < src.Height; y++)
                        for (int x = 0; x < src.Width; x++)
                            tiles[(y * width + (row * width * tileSize)) + ((col * tileSize) + x)] = tile[(y * src.Width) + x];
                }
            }
            return PixelsToBitmap(tiles, width, height);
        }

        /// <summary>
        /// Get a tile's pixels, with the given palette and flip type
        /// </summary>
        /// <param name="tileset">A collection of 8 x 8 pixels</param>
        /// <param name="flipX">If the tile is flipped horizontally</param>
        /// <param name="flipY">If the tile is flipped vertically</param>
        /// <returns></returns>
        public static List<byte> GetMirroredPixels(List<byte> tileset, bool flipX, bool flipY)
        {
            List<byte> bytes = new List<byte>();
            var count = tileset.Count / 64;
            for (int i = 0; i < count; i++)
            {
                var pixels = tileset.GetRange(i * 64, 64).ToArray();
                if (flipX && flipY)
                    bytes.AddRange(FlipTile(pixels, FlipType.Both));
                else if (flipX)
                    bytes.AddRange(FlipTile(pixels, FlipType.Horizontal));
                else if (flipY)
                    bytes.AddRange(FlipTile(pixels, FlipType.Vertical));
            }
            return bytes;
        }

        /// <summary>
        /// Get a tile's pixels, with the given palette and flip type
        /// </summary>
        /// <param name="tilePixels">A collection of 8 x 8 pixels</param>
        /// <param name="colors">The color palette to use for the tile</param>
        /// <param name="flipX">If the tile is flipped horizontally</param>
        /// <param name="flipY">If the tile is flipped vertically</param>
        /// <returns></returns>
        private static int[] GetTilePixels(List<byte> tilePixels, List<Color> colors, bool flipX, bool flipY)
        {
            int[] pixels = new int[64];
            for (int i = 0; i < tilePixels.Count; i++)
            {
                pixels[i] = tilePixels[i] > 15 ? colors[0].ToArgb() : colors[tilePixels[i]].ToArgb();
            }

            if (flipX && flipY)
                pixels = FlipTile(pixels, FlipType.Both);
            else if (flipX)
                pixels = FlipTile(pixels, FlipType.Horizontal);
            else if (flipY)
                pixels = FlipTile(pixels, FlipType.Vertical);

            return pixels;
        }

        /// <summary>
        /// Gets an image strip of the sprite, using all of the given tilemaps
        /// </summary>
        /// <param name="tilemaps">The tilemaps for the layout of the tiles</param>
        /// <param name="tilesets">The tilesets to draw tiles from</param>
        /// <param name="bgPalette">The background palette colors to use</param>
        /// <param name="sprPalette">The sprite palette colors to use</param>
        /// <returns>An image of the sprite with all of the tilemaps laid out linear</returns>
        public static Bitmap GetSpriteImageStrip(List<Tilemap> tilemaps, List<Tileset> tilesets, Palette bgPalette, Palette sprPalette)
        {
            int cols = 0;
            int rows = 0;
            foreach (Tilemap tilemap in tilemaps)
            {
                cols += tilemap.Columns;
                if (tilemap.Rows > rows)
                    rows = tilemap.Rows;
            }
            int index = 0;
            Bitmap image = new Bitmap(cols * 8, rows * 8);
            using (Graphics gfx = Graphics.FromImage(image))
            {
                foreach (Tilemap tilemap in tilemaps)
                {
                    var tileset = tilemap.Tileset;
                    if (tileset == null)
                        continue;
                    using (Bitmap temp = GetTileImage(tileset, tilemap, bgPalette, sprPalette))
                    {
                        gfx.DrawImageUnscaled(temp, new Point(index, image.Height - temp.Height));
                        index += temp.Width;
                    }
                }
            }
            return image;
        }

        /// <summary>
        /// Gets a pixel tile image
        /// </summary>
        /// <param name="pixels">Pixels to draw</param>
        /// <param name="colors">Palette colors to use</param>
        /// <param name="size">The size of the image</param>
        /// <returns></returns>
        public static Bitmap GetPixelTileImage(List<byte> pixels, List<Color> colors, Size size)
        {
            int index = 0;
            Size grid = new Size(size.Width / 8, size.Height / 8);
            int cols = (int)Math.Floor(size.Width / (double)(grid.Width));
            int rows = (int)Math.Floor(size.Height / (double)(grid.Height));
            Rectangle cell = new Rectangle(0, 0, grid.Width, grid.Height);
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (pixels[index] > colors.Count - 1)
                            continue;

                        using (SolidBrush brush = new SolidBrush(colors[pixels[index]]))
                        {
                            cell.X = col * grid.Width;
                            cell.Y = row * grid.Height;
                            gfx.FillRectangle(brush, cell);
                        }
                        index++;
                    }
                }
            }
            return bmp;
        }

        /// <summary>
        /// Cuts up an image into 8 x 8 tile pixel arrays of 32 bit color data, with various options
        /// </summary>
        /// <param name="image">The source image to get unique pixel tile data from</param>
        /// <param name="backColor">The transparent color that</param>
        /// <param name="allowDuplicates">If allowing tiles that are the same, not optimizing</param>
        /// <param name="ignoreEmpty">If not including tiles that are comprised only of the transparent color</param>
        /// <param name="flipCheck">Comparison type</param>
        /// <returns>A list of pixel data, tiled, in 32 bit format</returns>
        public static List<PixelTile> GetPixelTiles(Bitmap image, Color backColor, bool allowDuplicates, bool ignoreEmpty, FlipType flipCheck)
        {
            List<PixelTile> pixelTiles = new List<PixelTile>();
            int cols = image.Width / 8;
            int rows = image.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    bool match = false;
                    PixelTile pixelTile = new PixelTile(GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8)));
                    for (int j = 0; j < pixelTiles.Count; j++)
                    {
                        if (CompareTiles(pixelTile.Pixels.ToArray(), pixelTiles[j].Pixels.ToArray(), flipCheck).Item1)
                        {
                            match = true;
                            break;
                        }
                    }

                    if (match && !allowDuplicates)
                        continue;

                    if (ignoreEmpty && IsEmptyTile(pixelTile.Pixels.ToArray(), backColor.ToArgb()))
                        continue;

                    pixelTiles.Add(pixelTile);
                }
            }
            return pixelTiles;
        }

        /// <summary>
        /// Takes the given image data, and partitions it into tiled image data, keep in linear format
        /// </summary>
        /// <param name="image">The source image to get pixel data from</param>
        /// <param name="rect">Section of the image data to get pixel data from</param>
        /// <returns>A list of pixel data, formated in tiled sections, in linear 32 bit format</returns>
        public static List<int> GetPixelTilesLinear(Bitmap image, Rectangle rect)
        {
            List<int[]> tiles = new List<int[]>();
            int cols = rect.Width / 8;
            int rows = rect.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    tiles.Add(GetPixels(image, new Rectangle(col * 8 + rect.X, row * 8 + rect.Y, 8, 8)));
                }
            }
            List<int> data = new List<int>();
            foreach (int[] tile in tiles)
            {
                foreach (int pixel in tile)
                {
                    data.Add(pixel);
                }
            }
            return data;
        }

        /// <summary>
        /// Creates tiles from the given 32 bit pixel tiles. Compares optimized pixel tiles, against image data
        /// </summary>
        /// <param name="pixelTiles">A list of 8 x 8 tiles, in 32 bit color format</param>
        /// <param name="image">The 32 bit image to match against the given 32 bit pixel tiles</param>
        /// <param name="offset">The tile index offset, if any</param>
        /// <param name="flipCheck">Comparison type</param>
        /// <returns>A list of tiles</returns>
        public static List<Tile> GetTilesFromImage(List<PixelTile> pixelTiles, Bitmap image, int offset, FlipType flipCheck)
        {
            List<Tile> tiles = new List<Tile>();
            int cols = image.Width / 8;
            int rows = image.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int index = 0;
                    int[] pixelTile = GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8));
                    FlipType flipType = FlipType.None;
                    foreach (PixelTile tile in pixelTiles)
                    {
                        var result = CompareTiles(pixelTile, tile.Pixels.ToArray(), flipCheck);
                        if (result.Item1)
                        {
                            flipType = result.Item2;
                            break;
                        }

                        index++;
                    }

                    tiles.Add(new Tile(index >= pixelTiles.Count ? 0 : index + offset, flipType));
                }
            }
            return tiles;
        }

        /// <summary>
        /// Gets a list of sprites based on the given image, and sprite mode
        /// </summary>
        /// <param name="image"></param>
        /// <param name="type"></param>
        /// <param name="emptyColor"></param>
        /// <returns></returns>
        public static List<Sprite> GetSpritesFromBitmap(Bitmap image, SpriteModeType type, Color emptyColor, bool ignoreEmpty)
        {
            List<Sprite> sprites = new List<Sprite>();
            var cols = image.Width / 8;
            var rows = image.Height / (type == SpriteModeType.Normal ? 8 : 16);
            var index = 0;
            switch (type)
            {
                case SpriteModeType.Normal:
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            PixelTile pixelTile = new PixelTile(GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8)));
                            if (ignoreEmpty || (!ignoreEmpty && !IsEmptyTile(pixelTile.Pixels.ToArray(), emptyColor.ToArgb())))
                            {
                                sprites.Add(new Sprite(index, col * 8, row * 8));
                                index++;
                            }
                        }
                    }
                    break;

                case SpriteModeType.Tall:
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            PixelTile pixelTile = new PixelTile(GetPixels(image, new Rectangle(col * 8, row * 16, 8, 16)));
                            if (ignoreEmpty || (!ignoreEmpty && !IsEmptyTile(pixelTile.Pixels.ToArray(), emptyColor.ToArgb())))
                            {
                                sprites.Add(new Sprite(index, col * 8, row * 16));
                                index += 2;
                            }
                        }
                    }
                    break;
            }

            return sprites;
        }

        /// <summary>
        /// Gets a list of sprites based on the given image, and sprite mode
        /// </summary>
        /// <param name="image"></param>
        /// <param name="type"></param>
        /// <param name="emptyColor"></param>
        /// <param name="sprPalette"></param>
        /// <returns></returns>
        public static Tileset GetTilesetFromSprites(Bitmap image, SpriteModeType type, Color emptyColor, List<Color>sprPalette, bool ignoreEmpty)
        {
            Tileset tileset = new Tileset();
            List<PixelTile> pixelTiles = new List<PixelTile>();
            var cols = image.Width / 8;
            var rows = image.Height / (type == SpriteModeType.Normal ? 8 : 16);
            var index = 0;
            switch (type)
            {
                case SpriteModeType.Normal:
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            PixelTile pixelTile = new PixelTile(GetPixels(image, new Rectangle(col * 8, row * 8, 8, 8)));
                            if (ignoreEmpty || (!ignoreEmpty && !IsEmptyTile(pixelTile.Pixels.ToArray(), emptyColor.ToArgb())))
                                pixelTiles.Add(pixelTile);

                            index++;
                        }

                    }
                    break;

                case SpriteModeType.Tall:
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            PixelTile pixelTile = new PixelTile(GetPixels(image, new Rectangle(col * 8, row * 16, 8, 16)));
                            if (ignoreEmpty || (!ignoreEmpty && !IsEmptyTile(pixelTile.Pixels.ToArray(), emptyColor.ToArgb())))
                                pixelTiles.Add(pixelTile);

                            index++;
                        }

                    }
                    break;
            }

            tileset.Pixels = PixelTilesToSMSTiles(pixelTiles, sprPalette, sprPalette);
            return tileset;
        }

        /// <summary>
        /// Converts tiled 32 bit image pixel data to SMS tile pixel data
        /// </summary>
        /// <param name="pixelTiles">The pixel tile data</param>
        /// <param name="bgPalette">The palette colors</param>
        /// <returns></returns>
        public static List<byte> PixelTilesToSMSTiles(List<PixelTile> pixelTiles, List<Color> bgPalette, List<Color> sprPalette)
        {
            List<byte[]> tiles = new List<byte[]>();
            List<byte> pixels = new List<byte>();
            foreach (PixelTile pixelTile in pixelTiles)
                foreach (int pixel in pixelTile.Pixels)
                    pixels.Add(pixelTile.UseBGPalette ? (byte)bgPalette.FindIndex(c => c.ToArgb() == pixel) : (byte)sprPalette.FindIndex(c => c.ToArgb() == pixel));

            return pixels;
        }

        /// <summary>
        /// Compares tile pixels to given empty color
        /// </summary>
        /// <param name="tile">The tile pixel data to check</param>
        /// <returns>If the tile is empty</returns>
        public static bool IsEmptyTile(int[] tile, int emptyColor)
        {
            for (int i = 0; i < tile.Length; i++)
                if (tile[i] != emptyColor)
                    return false;

            return true;
        }

        /// <summary>
        /// Compares 32 bit integers of two tiles, returns whether they match or not
        /// </summary>
        /// <param name="tile1">The source tile to compare</param>
        /// <param name="tile2">The target tile to compare</param>
        /// <returns></returns>
        public static Tuple<bool, FlipType> CompareTiles(int[] tile1, int[] tile2)
        {
            return CompareTiles(tile1, tile2, FlipType.None);
        }

        /// <summary>
        /// Compares 32 bit integers of two tiles, returns whether they match or not, with flipping
        /// </summary>
        /// <param name="tile1">The source tile to compare</param>
        /// <param name="tile2">The target tile to compare</param>
        /// <param name="flipCheck">Check if a match when flipped as well</param>
        /// <returns>If the tiles match, also any flip matching</returns>
        public static Tuple<bool, FlipType> CompareTiles(int[] tile1, int[] tile2, FlipType flipCheck)
        {
            switch (flipCheck)
            {
                case FlipType.Vertical:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Vertical), tile2).Item1)
                        return Tuple.Create(true, FlipType.Vertical);

                    break;

                case FlipType.Horizontal:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Horizontal), tile2).Item1)
                        return Tuple.Create(true, FlipType.Horizontal);

                    break;

                case FlipType.Both:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Horizontal), tile2).Item1)
                        return Tuple.Create(true, FlipType.Horizontal);

                    if (CompareTiles(FlipTile(tile1, FlipType.Vertical), tile2).Item1)
                        return Tuple.Create(true, FlipType.Vertical);

                    if (CompareTiles(FlipTile(tile1, FlipType.Both), tile2).Item1)
                        return Tuple.Create(true, FlipType.Both);

                    break;

                default:
                    var match = Tuple.Create(true, FlipType.None);
                    for (int i = 0; i < tile1.Length; i++)
                        if (tile1[i] != tile2[i])
                            return Tuple.Create(false, FlipType.None);

                    return match;
            }

            return Tuple.Create(false, FlipType.None);
        }

        /// <summary>
        /// Compares 8 bit integers of two tiles, returns whether they match or not
        /// </summary>
        /// <param name="tile1">The source tile to compare</param>
        /// <param name="tile2">The target tile to compare</param>
        /// <returns></returns>
        public static Tuple<bool, FlipType> CompareTiles(byte[] tile1, byte[] tile2)
        {
            return CompareTiles(tile1, tile2, FlipType.None);
        }

        /// <summary>
        /// Compares 8 bit integers of two tiles, returns whether they match or not, with flipping
        /// </summary>
        /// <param name="tile1">The source tile to compare</param>
        /// <param name="tile2">The target tile to compare</param>
        /// <param name="flipCheck">Check if a match when flipped as well</param>
        /// <returns>If the tiles match, also any flip matching</returns>
        public static Tuple<bool, FlipType> CompareTiles(byte[] tile1, byte[] tile2, FlipType flipCheck)
        {
            switch (flipCheck)
            {
                case FlipType.Vertical:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Vertical), tile2).Item1)
                        return Tuple.Create(true, FlipType.Vertical);

                    break;

                case FlipType.Horizontal:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Horizontal), tile2).Item1)
                        return Tuple.Create(true, FlipType.Horizontal);

                    break;

                case FlipType.Both:
                    if (CompareTiles(tile1, tile2, FlipType.None).Item1)
                        return Tuple.Create(true, FlipType.None);

                    if (CompareTiles(FlipTile(tile1, FlipType.Horizontal), tile2).Item1)
                        return Tuple.Create(true, FlipType.Horizontal);

                    if (CompareTiles(FlipTile(tile1, FlipType.Vertical), tile2).Item1)
                        return Tuple.Create(true, FlipType.Vertical);

                    if (CompareTiles(FlipTile(tile1, FlipType.Both), tile2).Item1)
                        return Tuple.Create(true, FlipType.Both);

                    break;

                default:
                    for (int i = 0; i < tile1.Length; i++)
                        if (tile1[i] != tile2[i])
                            return Tuple.Create(false, FlipType.None);

                    return Tuple.Create(true, FlipType.None);
            }

            return Tuple.Create(false, FlipType.None);
        }

        /// <summary>
        /// Flips a tile in the desired direction
        /// </summary>
        /// <param name="tile">The tile to flip</param>
        /// <param name="type">The flip direction</param>
        /// <returns>Flipped tile</returns>
        private static int[] FlipTile(int[] tile, FlipType type)
        {
            int index = 0;
            int[] flipped = new int[tile.Length];
            switch (type)
            {
                case FlipType.Horizontal:
                    for (int row = 0; row < 8; row++)
                    {
                        for (int col = 7; col >= 0; col--)
                        {
                            flipped[index] = tile[(row * 8) + col];
                            index++;
                        }
                    }
                    break;
                case FlipType.Vertical:
                    for (int row = 7; row >= 0; row--)
                    {
                        for (int col = 0; col < 8; col++)
                        {
                            flipped[index] = tile[(row * 8) + col];
                            index++;
                        }
                    }
                    break;
                default:
                    flipped = tile.DeepClone();
                    flipped = FlipTile(flipped, FlipType.Vertical);
                    flipped = FlipTile(flipped, FlipType.Horizontal);
                    break;
            }
            return flipped;
        }

        /// <summary>
        /// Flips a tile in the desired direction
        /// </summary>
        /// <param name="tile">The tile to flip</param>
        /// <param name="type">The flip direction</param>
        /// <returns>Flipped tile</returns>
        public static byte[] FlipTile(byte[] tile, FlipType type)
        {
            int index = 0;
            byte[] flipped = new byte[tile.Length];
            switch (type)
            {
                case FlipType.Horizontal:
                    for (int row = 0; row < 8; row++)
                    {
                        for (int col = 7; col >= 0; col--)
                        {
                            flipped[index] = tile[(row * 8) + col];
                            index++;
                        }
                    }
                    break;
                case FlipType.Vertical:
                    for (int row = 7; row >= 0; row--)
                    {
                        for (int col = 0; col < 8; col++)
                        {
                            flipped[index] = tile[(row * 8) + col];
                            index++;
                        }
                    }
                    break;
                default:
                    flipped = tile.DeepClone();
                    flipped = FlipTile(flipped, FlipType.Vertical);
                    flipped = FlipTile(flipped, FlipType.Horizontal);
                    break;
            }
            return flipped;
        }

        /// <summary>
        /// Gets the raw pixel data from a bitmap
        /// </summary>
        /// <param name="image">Bitmap to get raw pixel data from</param>
        /// <param name="rect">Region to get pixels from</param>
        /// <returns>32 bit pixel data</returns>
        public static int[] GetPixels(Bitmap image, Rectangle rect)
        {
            Color[] palette = null;
            int bytes = GetByteCount(image.PixelFormat);
            if (bytes == 0)
                return null;

            if (bytes == 1)
                palette = image.Palette.Entries;

            int[] pixels = new int[rect.Width * rect.Height];
            BitmapData data = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);
            unsafe
            {
                int offset = data.Stride - data.Width * bytes;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = new byte[4];
                        if (bytes == 1)
                        {
                            int index = imgPtr[0];
                            Color color = palette[index];
                            pixel[0] = 255;
                            pixel[1] = color.R;
                            pixel[2] = color.G;
                            pixel[3] = color.B;
                        }
                        else
                        {
                            pixel[0] = imgPtr[0];
                            pixel[1] = imgPtr[1];
                            pixel[2] = imgPtr[2];
                            pixel[3] = bytes == 3 ? (byte)255 : imgPtr[3];
                        }

                        pixels[(y * rect.Width) + x] = BitConverter.ToInt32(pixel, 0);
                        imgPtr += bytes;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return pixels;
        }

        /// <summary>
        /// Converts 32 bit pixel data to a bitmap (32bppArgb)
        /// </summary>
        /// <param name="pixels">The pixels to create a bitmap from</param>
        /// <param name="width">The width of the output bitmap</param>
        /// <param name="height">The height of the output bitmap</param>
        /// <returns>A bitmap</returns>
        public static Bitmap PixelsToBitmap(int[] pixels, int width, int height)
        {
            Bitmap image = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                int offset = data.Stride - data.Width * 4;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = BitConverter.GetBytes(pixels[(y * width) + x]);
                        imgPtr[0] = pixel[0];
                        imgPtr[1] = pixel[1];
                        imgPtr[2] = pixel[2];
                        imgPtr[3] = pixel[3];
                        imgPtr += 4;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return image;
        }

        /// <summary>
        /// Gets a list of unique colors from the given image
        /// </summary>
        /// <param name="image">The image to get the colors from</param>
        /// <returns>A list of unique colors</returns>
        public static List<Color> GetColors(Bitmap image)
        {
            List<Color> palette = new List<Color>();
            int bytes = GetByteCount(image.PixelFormat);
            if (bytes == 0)
                return null;

            if (bytes == 1)
                return new List<Color>(image.Palette.Entries);

            BitmapData data = image.LockBits(new Rectangle(Point.Empty, image.Size), ImageLockMode.ReadOnly, image.PixelFormat);
            unsafe
            {
                int offset = data.Stride - data.Width * bytes;
                byte* imgPtr = (byte*)(void*)(data.Scan0);
                for (int y = 0; y < data.Height; ++y)
                {
                    for (int x = 0; x < data.Width; ++x)
                    {
                        byte[] pixel = new byte[4];
                        pixel[0] = imgPtr[0];
                        pixel[1] = imgPtr[1];
                        pixel[2] = imgPtr[2];
                        pixel[3] = bytes == 3 ? (byte)255 : imgPtr[3];

                        Color color = Color.FromArgb(BitConverter.ToInt32(pixel, 0));
                        if (!palette.Contains(color))
                            palette.Add(color);

                        imgPtr += bytes;
                    }
                    imgPtr += offset;
                }
            }
            image.UnlockBits(data);
            return palette;
        }

        /// <summary>
        /// Checks that the given list of colors are valid SMS colors
        /// </summary>
        /// <param name="colors">List of colors to check</param>
        /// <returns>If valid list of colors</returns>
        public static bool CheckForSMSColors(List<Color> colors)
        {
            List<byte> validBytes = new List<byte>() { 0, 17, 34, 51, 68, 85, 102, 119, 136, 153, 170, 187, 204, 221, 238, 255  };
            foreach (Color color in colors)
                if (!validBytes.Contains(color.R) || !validBytes.Contains(color.G) || !validBytes.Contains(color.B))
                    return false;

            return true;
        }

        /// <summary>
        /// Checks that the given list of colors contains game gear color
        /// </summary>
        /// <param name="colors">List of colors to check</param>
        /// <returns>If color list contains a game gear color</returns>
        public static bool CheckForGameGearColors(List<Color> colors)
        {
            List<byte> validBytes = new List<byte>() { 17, 34, 51, 68, 102, 119, 136, 153, 187, 204, 221, 238 };
            foreach (Color color in colors)
                if (validBytes.Contains(color.R) || validBytes.Contains(color.G) || validBytes.Contains(color.B))
                    return true;

            return false;
        }

        /// <summary>
        /// Gets the number of bytes per color, of the given image
        /// </summary>
        /// <param name="format">The image pixel format</param>
        /// <returns>Number of bytes for the given image pixel format</returns>
        private static int GetByteCount(PixelFormat format)
        {
            switch (format)
            {
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                case PixelFormat.Format32bppRgb: return 4;
                case PixelFormat.Format24bppRgb: return 3;
                case PixelFormat.Format8bppIndexed: return 1;
                case PixelFormat.Format4bppIndexed: return 1;
                default: return 0;
            }
        }

        // Gets a 32 bit image from given image
        public static Bitmap Get32bitImage(Bitmap image)
        {
            // If bpp is not indexed, retun image
            if (GetByteCount(image.PixelFormat) > 1)
            {
                return image;
            }
            // Indexed image
            var bp = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            using (Graphics gr = Graphics.FromImage(bp))
                gr.DrawImage(image, new Rectangle(0, 0, bp.Width, bp.Height));
            return bp;
        }

        /// <summary>
        /// Draws a text outline
        /// </summary>
        /// <param name="gfx">Graphics handle</param>
        /// <param name="text">The text to render</param>
        /// <param name="font">The font</param>
        /// <param name="color">The brush color of the outline</param>
        /// <param name="rect">Bounding rectangle</param>
        /// <param name="format">Text renderer format</param>
        public static void DrawTextOutline(Graphics gfx, string text, Font font, Brush color, RectangleF rect, StringFormat format)
        {
            RectangleF left = new RectangleF(rect.X - 1, rect.Y, rect.Width, rect.Height);
            RectangleF right = new RectangleF(rect.X + 1, rect.Y, rect.Width, rect.Height);
            RectangleF top = new RectangleF(rect.X, rect.Y - 1, rect.Width, rect.Height);
            RectangleF bottom = new RectangleF(rect.X, rect.Y + 1, rect.Width, rect.Height);
            gfx.DrawString(text, font, color, left, format);
            gfx.DrawString(text, font, color, right, format);
            gfx.DrawString(text, font, color, top, format);
            gfx.DrawString(text, font, color, bottom, format);
        }

        public static void DrawTextOutline(Graphics gfx, string text, Font font, Brush color, RectangleF rect)
        {
            RectangleF left = new RectangleF(rect.X - 1, rect.Y, rect.Width, rect.Height);
            RectangleF right = new RectangleF(rect.X + 1, rect.Y, rect.Width, rect.Height);
            RectangleF top = new RectangleF(rect.X, rect.Y - 1, rect.Width, rect.Height);
            RectangleF bottom = new RectangleF(rect.X, rect.Y + 1, rect.Width, rect.Height);
            gfx.DrawString(text, font, color, left);
            gfx.DrawString(text, font, color, right);
            gfx.DrawString(text, font, color, top);
            gfx.DrawString(text, font, color, bottom);
        }

        public static List<Tile> GetTilesFromTilesetData(List<int[]> metaTileData, List<int[]> tilesetData)
        {
            var tiles = new List<Tile>();
            for (int i = 0; i < metaTileData.Count; i++)
            {
                var index = 0;
                for (int j = 0; j < tilesetData.Count; j++)
                {
                    if (CompareTiles(metaTileData[i], tilesetData[j]).Item1)
                    {
                        tiles.Add(new Tile(index));
                        break;
                    }
                    index++;
                }
                if (index >= tilesetData.Count)
                {
                    index = 0;
                    var flip = FlipTile(metaTileData[i], FlipType.Horizontal);
                    for (int j = 0; j < tilesetData.Count; j++)
                    {
                        if (CompareTiles(flip, tilesetData[j]).Item1)
                        {
                            tiles.Add(new Tile { TileID = index, FlipX = true });
                            break;
                        }
                        index++;
                    }
                }
                if (index >= tilesetData.Count)
                {
                    index = 0;
                    var flip = FlipTile(metaTileData[i], FlipType.Vertical);
                    for (int j = 0; j < tilesetData.Count; j++)
                    {
                        if (CompareTiles(flip, tilesetData[j]).Item1)
                        {
                            tiles.Add(new Tile { TileID = index, FlipY = true });
                            break;
                        }
                        index++;
                    }
                }
                if (index >= tilesetData.Count)
                {
                    index = 0;
                    var flip = FlipTile(metaTileData[i], FlipType.Both);
                    for (int j = 0; j < tilesetData.Count; j++)
                    {
                        if (CompareTiles(flip, tilesetData[j]).Item1)
                        {
                            tiles.Add(new Tile { TileID = index, FlipX = true, FlipY = true });
                            break;
                        }
                        index++;
                    }
                }
            }
            return tiles;
        }

        public static List<int[]> ConvertImageToTileBytesList(Bitmap tileset)
        {
            var list = new List<int[]>();
            var cols = tileset.Width / 8;
            var rows = tileset.Height / 8;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    list.Add(GetPixels(tileset, new Rectangle(col * 8, row * 8, 8, 8)));
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetMetaTileImage(List<MetaTile> metaTiles, Size metaTileSize, bool gsLibFormat)
        {
            if (metaTiles == null)
                return null;

            var width = metaTiles.Count < 16 ? metaTileSize.Width * metaTiles.Count : metaTileSize.Width * 16;
            var cols = width / metaTileSize.Width;
            int rows = (int)Math.Ceiling(metaTiles.Count / Convert.ToDouble(cols));
            var image = new Bitmap(width, rows * metaTileSize.Height);
            var index = 0;
            using (var gfx = Graphics.FromImage(image))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (index >= metaTiles.Count)
                            break;

                        var point = new Point(col * metaTileSize.Width, row * metaTileSize.Height);
                        using (var bitmap = BitmapUtility.PixelsToBitmap(metaTiles[index].Image, metaTileSize.Width, metaTileSize.Height))
                        {
                            gfx.DrawImageUnscaled(bitmap, new Rectangle(point, metaTileSize));
                        }
                        index++;
                    }
                }
            }
            return image;
        }
    }
}
