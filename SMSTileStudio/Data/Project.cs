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
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace SMSTileStudio.Data
{
    [Serializable]
    public class Project
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int Indexer = 0;
        public Version Version = null;
        public List<MetaSprite> MetaSprites { get; private set; } = new List<MetaSprite>();
        public List<Palette> Palettes { get; private set; } = new List<Palette>();
        public List<Tilemap> Tilemaps { get; private set; } = new List<Tilemap>();
        public List<Dialog> Dialogs { get; private set; } = new List<Dialog>();
        public List<DataEntry> DataEntries { get; private set; } = new List<DataEntry>();
        public List<Entity> Entities { get; private set; } = new List<Entity>();

        /// <summary>
        /// Constructors
        /// </summary>
        public Project() { SetDefaultPalettes(); }

        // Default project palettes
        public void SetDefaultPalettes()
        {
            Palettes.AddRange(GetDefaultPalettes());
        }

        /// <summary>
        /// Creates a game asset
        /// </summary>
        /// <param name="type">Type of game asset to create</param>
        /// <returns></returns>
        public GameAsset CreateAsset(GameAssetType type)
        {
            switch (type)
            {
                case GameAssetType.Palette: Palettes.Add(new Palette(Indexer++)); return Palettes.FirstOrDefault(x => x.ID == Indexer - 1);
                case GameAssetType.Tilemap: Tilemaps.Add(new Tilemap(Indexer++)); return Tilemaps.FirstOrDefault(x => x.ID == Indexer - 1);
                case GameAssetType.MetaSprite: MetaSprites.Add(new MetaSprite(Indexer++)); return MetaSprites.FirstOrDefault(x => x.ID == Indexer - 1);
                case GameAssetType.Dialog: Dialogs.Add(new Dialog(Indexer++)); return Dialogs.FirstOrDefault(x => x.ID == Indexer - 1);
                case GameAssetType.DataEntry: DataEntries.Add(new DataEntry(Indexer++)); return DataEntries.FirstOrDefault(x => x.ID == Indexer - 1);
                case GameAssetType.Entity: Entities.Add(new Entity(Indexer++)); return Entities.FirstOrDefault(x => x.ID == Indexer - 1);
                default: return null;
            }
        }

        /// <summary>
        /// Gets game asset by id
        /// </summary>
        /// <returns>Asset</returns>
        public GameAsset GetAsset(int id)
        {
            foreach (var asset in Palettes)
                if (asset.ID == id)
                    return asset;

            foreach (var asset in Tilemaps)
                if (asset.ID == id)
                    return asset;

            foreach (var asset in MetaSprites)
                if (asset.ID == id)
                    return asset;

            foreach (var asset in Dialogs)
                if (asset.ID == id)
                    return asset;

            foreach (var asset in DataEntries)
                if (asset.ID == id)
                    return asset;

            foreach (var asset in Entities)
                if (asset.ID == id)
                    return asset;

            return null;
        }

        /// <summary>
        /// Gets a duplicate of the given asset
        /// </summary>
        /// <returns>Duplicate of given asset</returns>
        public GameAsset DuplicateAsset(GameAsset asset)
        {
            if (asset == null)
                return null;

            switch (asset.GameAssetType)
            {
                case GameAssetType.Palette:
                    var palette = Palettes.FirstOrDefault(x => x.ID == asset.ID);
                    if (palette == null)
                        return null;

                    palette = palette.DeepClone();
                    palette.ID = Indexer++;
                    Palettes.Add(palette);
                    return palette;

                case GameAssetType.Tilemap:
                    var tilemap = Tilemaps.FirstOrDefault(x => x.ID == asset.ID);
                    if (tilemap == null)
                        return null;

                    tilemap = tilemap.DeepClone();
                    tilemap.ID = Indexer++;
                    Tilemaps.Add(tilemap);
                    return tilemap;

                case GameAssetType.MetaSprite:
                    var metaSprite = MetaSprites.FirstOrDefault(x => x.ID == asset.ID);
                    if (metaSprite == null)
                        return null;

                    metaSprite = metaSprite.DeepClone();
                    metaSprite.ID = Indexer++;
                    MetaSprites.Add(metaSprite);
                    return metaSprite;

                case GameAssetType.Dialog:
                    var dialog = Dialogs.FirstOrDefault(x => x.ID == asset.ID);
                    if (dialog == null)
                        return null;

                    dialog = dialog.DeepClone();
                    dialog.ID = Indexer++;
                    Dialogs.Add(dialog);
                    return dialog;

                case GameAssetType.DataEntry:
                    var dataEntry = DataEntries.FirstOrDefault(x => x.ID == asset.ID);
                    if (dataEntry == null)
                        return null;

                    dataEntry = dataEntry.DeepClone();
                    dataEntry.ID = Indexer++;
                    DataEntries.Add(dataEntry);
                    return dataEntry;

                case GameAssetType.Entity:
                    var entity = Entities.FirstOrDefault(x => x.ID == asset.ID);
                    if (entity == null)
                        return null;

                    entity = entity.DeepClone();
                    entity.ID = Indexer++;
                    Entities.Add(entity);
                    return entity;

                default: return null;
            }
        }

        /// <summary>
        /// Updates given asset
        /// </summary>
        public void UpdateAsset(GameAsset asset)
        {
            if (asset == null)
                return;

            var index = -1;
            switch (asset.GameAssetType)
            {
                case GameAssetType.Palette:
                    index = Palettes.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    Palettes[index] = asset as Palette;
                    break;

                case GameAssetType.Tilemap:
                    index = Tilemaps.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    Tilemaps[index] = asset as Tilemap;
                    break;

                case GameAssetType.MetaSprite:
                    index = MetaSprites.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    MetaSprites[index] = asset as MetaSprite;
                    break;

                case GameAssetType.Dialog:
                    index = Dialogs.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    Dialogs[index] = asset as Dialog;
                    break;

                case GameAssetType.DataEntry:
                    index = DataEntries.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    DataEntries[index] = asset as DataEntry;
                    break;

                case GameAssetType.Entity:
                    index = Entities.FindIndex(x => x.ID == asset.ID);
                    if (index <= -1)
                        return;

                    Entities[index] = asset as Entity;
                    break;
            }
        }

        /// <summary>
        /// Removes the given asset
        /// </summary>
        public void RemoveAsset(GameAsset asset)
        {
            if (asset == null)
                return;

            switch (asset.GameAssetType)
            {
                case GameAssetType.Palette: Palettes.Remove(Palettes.FirstOrDefault(x => x.ID == asset.ID)); break;
                case GameAssetType.Tilemap: Tilemaps.Remove(Tilemaps.FirstOrDefault(x => x.ID == asset.ID)); break;
                case GameAssetType.MetaSprite: MetaSprites.Remove(MetaSprites.FirstOrDefault(x => x.ID == asset.ID)); break;
                case GameAssetType.Dialog: Dialogs.Remove(Dialogs.FirstOrDefault(x => x.ID == asset.ID)); break;
                case GameAssetType.DataEntry: DataEntries.Remove(DataEntries.FirstOrDefault(x => x.ID == asset.ID)); break;
                case GameAssetType.Entity: Entities.Remove(Entities.FirstOrDefault(x => x.ID == asset.ID)); break;
            }
        }

        /// <summary>
        /// Gets a sorted palette list
        /// </summary>
        public Palette[] GetPaletteArray()
        {
            var palettes = new List<Palette>();
            foreach (var palette in Palettes.OrderBy(x => x.Name))
            {
                if (palette.ID < 0)
                    continue;

                palettes.Add(palette);
            }
            if (Palettes.Any(x => x.ID == -4))
                palettes.Insert(0, Palettes.Find(x => x.ID == -4));
            if (Palettes.Any(x => x.ID == -2))
                palettes.Insert(0, Palettes.Find(x => x.ID == -2));
            if (Palettes.Any(x => x.ID == -3))
                palettes.Insert(0, Palettes.Find(x => x.ID == -3));
            return palettes.ToArray();
        }

        /// <summary>
        /// Gets colors from byte data
        /// </summary>
        private static List<Palette> GetDefaultPalettes()
        {
            List<Color> bgDefaultColors = new List<Color>
            {
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 255, 255, 255),
                Color.FromArgb(255, 255, 85, 255),
                Color.FromArgb(255, 255, 170, 255),
                Color.FromArgb(255, 255, 255, 0),
                Color.FromArgb(255, 255, 170, 0),
                Color.FromArgb(255, 0, 0, 0),
                Color.FromArgb(255, 255, 255, 170),
                Color.FromArgb(255, 170, 85, 0),
                Color.FromArgb(255, 255, 170, 0),
                Color.FromArgb(255, 85, 0, 0),
                Color.FromArgb(255, 85, 255, 255),
                Color.FromArgb(255, 0, 170, 255),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 170, 0),
                Color.FromArgb(255, 0, 255, 255)
            };

            List<Color> sprDefaultColors = new List<Color>
            {
                Color.FromArgb(255, 13, 230, 223),
                Color.FromArgb(255, 255, 255, 255),
                Color.FromArgb(255, 85, 85, 0),
                Color.FromArgb(255, 255, 170, 0),
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 170, 0, 0),
                Color.FromArgb(255, 0, 0, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 0, 255, 255),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 255, 255, 0),
                Color.FromArgb(255, 0, 170, 0),
                Color.FromArgb(255, 170, 170, 255),
                Color.FromArgb(255, 170, 85, 255),
                Color.FromArgb(255, 85, 0, 0),
                Color.FromArgb(255, 170, 170, 0)
            };

            List<Color> sgColors = new List<Color>
            {
                Color.FromArgb(255, 0, 0, 0),
                Color.FromArgb(255, 0, 0, 0),
                Color.FromArgb(255, 0, 170, 0),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 85),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 85, 0, 0),
                Color.FromArgb(255, 0, 255, 255),
                Color.FromArgb(255, 170, 0, 0),
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 85, 85, 0),
                Color.FromArgb(255, 255, 255, 0),
                Color.FromArgb(255, 0, 85, 0),
                Color.FromArgb(255, 255, 0, 255),
                Color.FromArgb(255, 85, 85, 85),
                Color.FromArgb(255, 255, 255, 255)
            };

            List<Palette> defaultPalettes = new List<Palette>
            {
                new Palette(-3, "BG Default", bgDefaultColors),
                new Palette(-2, "SPR Default", sprDefaultColors),
                new Palette(-4, "SG Default", sgColors)
            };
            return defaultPalettes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MetaTileSizeType GetMetatileSizeType(Size tileSize)
        {
            if (tileSize == new Size(8, 16))
                return MetaTileSizeType.EightBySixteen;
            else if (tileSize == new Size(16, 16))
                return MetaTileSizeType.SixteenBySixteen;
            else if (tileSize == new Size(32, 32))
                return MetaTileSizeType.ThirtyTwoByThirtyTwo;
            else
                return MetaTileSizeType.SixteenBySixteen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Size GetMetaTileSize(MetaTileSizeType tileSizeType)
        {
            switch (tileSizeType)
            {
                case MetaTileSizeType.EightBySixteen: return new Size(8, 16);
                case MetaTileSizeType.SixteenBySixteen: return new Size(16, 16);
                case MetaTileSizeType.ThirtyTwoByThirtyTwo: return new Size(32, 32);
                default: return new Size(16, 16);
            }
        }
    }
}
