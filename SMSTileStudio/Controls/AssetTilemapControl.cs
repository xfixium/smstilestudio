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

using SMSTileStudio.Data;
using SMSTileStudio.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSTileStudio.Controls
{
    public partial class AssetTilemapControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Tilemap _tilemap = null;
        private TileGrid _selectedTileGrid = null;
        private Palette _selectedPalette = null;
        private Tileset _copy = null;
        private List<byte> _tileCopy = new List<byte>();
        private TileEditType _editType = TileEditType.TileID;
        //private int _frame = 0;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _tilemap != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetTilemapControl()
        {
            InitializeComponent();

            cbTilemapCompression.ValueMember = "Value";
            cbTilemapCompression.DisplayMember = "Description";
            cbTilemapCompression.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType));
            if (cbTilemapCompression.Items.Count > 0)
                cbTilemapCompression.SelectedIndex = 0;

            cbTilesetCompression.ValueMember = "Value";
            cbTilesetCompression.DisplayMember = "Description";
            cbTilesetCompression.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType));
            if (cbTilesetCompression.Items.Count > 0)
                cbTilesetCompression.SelectedIndex = 0;

            cbTileGridTileSize.ValueMember = "Value";
            cbTileGridTileSize.DisplayMember = "Description";
            cbTileGridTileSize.DataSource = EnumMethods.GetEnumCollection(typeof(MetaTileSizeType));
            if (cbTileGridTileSize.Items.Count > 1)
                cbTileGridTileSize.SelectedIndex = 1;

            cbMetaTileSize.ValueMember = "Value";
            cbMetaTileSize.DisplayMember = "Description";
            cbMetaTileSize.DataSource = EnumMethods.GetEnumCollection(typeof(MetaTileSizeType));
            if (cbMetaTileSize.Items.Count > 1)
                cbMetaTileSize.SelectedIndex = 1;
        }

        /// <summary>
        /// Tilemap selection changed
        /// </summary>
        private void lstTilemaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Updating)
                return;

            Loading = true;
            lstTilemaps.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Tile grid tile size changed
        /// </summary>
        private void cbTileGridTileSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || Updating || _tilemap == null || cbTileGridTileSize.SelectedItem == null)
                return;

            var sizeType = (MetaTileSizeType)cbTileGridTileSize.SelectedItem.GetType().GetProperty("value").GetValue(cbTileGridTileSize.SelectedItem, null);
            var metaTileSize = Project.GetMetaTileSize(sizeType);
            nudTileGridColumns.Value = _tilemap.Size.Width / metaTileSize.Width == 0 ? 1 : _tilemap.Size.Width / metaTileSize.Width;
            nudTileGridRows.Value = _tilemap.Size.Height / metaTileSize.Height == 0 ? 1 : _tilemap.Size.Height / metaTileSize.Height;
        }

        /// <summary>
        /// Tile grid list
        /// </summary>
        private void lstTileGrids_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || Updating)
                return;

            lstTileGrids.Refresh();
            _selectedTileGrid = lstTileGrids.SelectedItem == null ? null : lstTileGrids.SelectedItem as TileGrid;
            if (lstTileGrids.SelectedItem != null)
            {
                txtTileGridName.Text = _selectedTileGrid.Name;
                cbTileGridTileSize.SelectedValue = _selectedTileGrid.TileSizeType;
                nudTileGridColumns.Value = _selectedTileGrid.Columns;
                nudTileGridRows.Value = _selectedTileGrid.Rows;
                pnlTilemapEdit.TileGrid = _selectedTileGrid.DeepClone();
            }
            else
            {
                txtTileGridName.Text = "";
                var sizeType = (MetaTileSizeType)cbTileGridTileSize.SelectedItem.GetType().GetProperty("value").GetValue(cbTileGridTileSize.SelectedItem, null);
                var metaTileSize = Project.GetMetaTileSize(sizeType);
                nudTileGridColumns.Value = _tilemap.Size.Width / metaTileSize.Width == 0 ? 1 : _tilemap.Size.Width / metaTileSize.Width;
                nudTileGridRows.Value = _tilemap.Size.Height / metaTileSize.Height == 0 ? 1 : _tilemap.Size.Height / metaTileSize.Height;
                pnlTilemapEdit.TileGrid = null;
            }
        }

        /// <summary>
        /// Tilemap name changed
        /// </summary>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!HasData || Loading || lstTilemaps.SelectedItem == null || e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            _tilemap.Name = txtName.Text;
            UpdateTilemap();
        }

        /// <summary>
        /// Tilemap name changed
        /// </summary>
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstTilemaps.SelectedItem == null)
                return;

            _tilemap.Name = txtName.Text;
            UpdateTilemap();
        }

        /// <summary>
        /// Menu item click
        /// </summary>
        private void mnuTilemap_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem menuItem))
                return;

            // Tilemap Methods //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Import tilemap
            if (menuItem == mnuImportTilemap)
            {
                // Get path from open file dialog
                string path = string.Empty;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PNG Image File|*.png";
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    path = ofd.FileName;
                }

                // Get image data, close stream so other applications can access it
                Bitmap image;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    image = (Bitmap)Image.FromStream(fs);
                }

                // If no image data, return
                if (image == null)
                {
                    MessageBox.Show("There was an issue getting the image data.");
                    return;
                }

                // Get a list of colors from the image, if more than the BG and SPR palettes combined, return
                List<Color> importColors = BitmapUtility.GetColors(image);
                if (importColors == null || importColors.Count > 32)
                {
                    MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                    return;
                }

                // Open tilemap form
                using (var form = new ImportTilemapForm(BitmapUtility.Get32bitImage(image), _tilemap, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstTilemaps_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            // Update tilemap tileset only
            else if (HasData && menuItem == mnuUpdateTileset)
            {
                // Get path from open file dialog
                string path = string.Empty;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PNG Image File|*.png";
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    path = ofd.FileName;
                }

                // Get image data, close stream so other applications can access it
                Bitmap image;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    image = (Bitmap)Image.FromStream(fs);
                }

                // If no image data, return
                if (image == null)
                {
                    MessageBox.Show("There was an issue getting the image data.");
                    return;
                }

                // Get a list of colors from the image, if more than the BG and SPR palettes combined, return
                List<Color> importColors = BitmapUtility.GetColors(image);
                if (importColors.Count > 32)
                {
                    MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                    return;
                }

                // Open tileset form
                using (var form = new ImportTilesetForm(image, _tilemap, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstTilemaps_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            // Export selected palette as image
            else if (HasData && menuItem == mnuPaletteExportImage && _selectedPalette != null)
                ExportPalette(_selectedPalette.Name.ToLower().Replace(' ', '_') + "_pal");
            // Export selected palette as binary file
            else if (HasData && menuItem == mnuPaletteExportBinary && _selectedPalette != null)
                ExportPalette(_selectedPalette.Name.ToLower().Replace(' ', '_') + "_pal");
            // Export selected palette as hex to clipboard
            else if (HasData && menuItem == mnuPaletteExportHex && _selectedPalette != null)
                Clipboard.SetText(_selectedPalette.GetASMString(true, true));
            // Export selected palette as asm to clipboard
            else if (HasData && menuItem == mnuPaletteExportAssembly && _selectedPalette != null)
                Clipboard.SetText(_selectedPalette.GetASMString(false, true));
            // Export tileset as image
            else if (HasData && menuItem == mnuTilesetExportImage)
                ExportTileset(_tilemap.Name.ToLower().Replace(' ', '_') + "_tiles");
            // Export selected tilesets as images
            else if (HasData && menuItem == mnuTilesetExportImages)
                ExportTilesets();
            // Export tileset as binary file
            else if (HasData && menuItem == mnuTilesetExportBinary)
                ExportBinary(_tilemap.Tileset.GetTilesetData(mnuTilesetBypassCompression.Checked, (int)nudTilesetExportStart.Value, (int)nudTilesetExportEnd.Value), _tilemap.Name.ToLower().Replace(' ', '_') + "_tiles");
            // Export selected tilesets as binary files
            else if (HasData && menuItem == mnuTilesetExportBinaries)
                ExportBinaries(false);
            // Export tileset as hexadecimal to clipboard
            else if (HasData && menuItem == mnuTilesetExportHex)
                Clipboard.SetText(_tilemap.Tileset.GetDataString(true));
            // Export tileset as assembly to clipboard
            else if (HasData && menuItem == mnuTilesetExportAssembly)
                Clipboard.SetText(_tilemap.Tileset.GetDataString(false));
            // Export tilemap as image
            else if (HasData && menuItem == mnuTilemapExportImage)
                ExportTilemap(_tilemap.Name.ToLower().Replace(' ', '_') + "_map");
            // Export selected tilemaps as images
            else if (HasData && menuItem == mnuTilemapExportImages)
                ExportTilemaps();
            // Export tilemap as binary file
            else if (HasData && menuItem == mnuTilemapExportBinary)
                ExportBinary(_tilemap.GetTilemapData(mnuTilemapBypassCompression.Checked, GetTilemapExportOrientation()), _tilemap.Name.ToLower().Replace(' ', '_') + "_map");
            // Export tilemap as binary file
            else if (HasData && menuItem == mnuExportSGBinary)
                ExportSGData();
            // Export selected tilemaps as binary files
            // Export selected tilemaps as binary files
            else if (HasData && menuItem == mnuTilemapExportBinaries)
                ExportBinaries(true);
            // Export tilemap as hexadecimal to clipboard
            else if (HasData && menuItem == mnuTilemapExportHex)
                Clipboard.SetText(_tilemap.GetDataString(TextType.Hex));
            // Export tilemap as assembly to clipboard
            else if (HasData && menuItem == mnuTilemapExportAssembly)
                Clipboard.SetText(_tilemap.GetDataString(TextType.Asm));
            // Export tilemap as decimal to clipboard
            else if (HasData && menuItem == mnuTilemapExportDecimal)
                Clipboard.SetText(_tilemap.GetDataString(TextType.Decimal));
            // Replace/swap tiles of tilemap
            else if (HasData && menuItem == mnuReplaceTiles && _tilemap.Tileset != null)
            {
                using (ReplaceForm form = new ReplaceForm(BitmapUtility.GetTilesetImage(_tilemap.Tileset, _selectedPalette, 16), _tilemap.Tileset.TileCount))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _tilemap.ReplaceTiles(form.SourceTileID, form.TargetTileID);
                        UpdateTilemap();
                        UpdateImages();
                    }
                }
            }
            // Rename tilemaps in bulk
            else if (HasData && menuItem == mnuTilemapBulkRename)
            {
                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.Tilemaps.Count <= 0)
                            return;

                        using (var dialog = new RenameForm())
                        {
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                foreach (var tilemap in form.Tilemaps)
                                {
                                    tilemap.Name = tilemap.Name.Replace(dialog.Match, dialog.Replace);
                                    App.Project.UpdateAsset(tilemap);
                                }
                            }
                        }
                    }
                }
            }
            // Create tilemaps from area grid
            else if (HasData && menuItem == mnuTilemapsFromAreaGrid && _tilemap.Tileset != null)
            {
                var rects = _tilemap.GetAreas();
                foreach (var area in rects)
                {
                    var areaMap = _tilemap.AreaToTilemap(area);
                    if (areaMap == null)
                        return;

                    var tilemap = (Tilemap)App.Project.CreateAsset(GameAssetType.Tilemap);
                    areaMap.ID = tilemap.ID;
                    tilemap.Tileset = _tilemap.Tileset.DeepClone();
                    tilemap.BgPaletteID = _tilemap.BgPaletteID;
                    tilemap.SprPaletteID = _tilemap.SprPaletteID;
                    tilemap.AreaGridSize = _tilemap.AreaGridSize;
                    tilemap.Tags = _tilemap.Tags.DeepClone();
                    tilemap.Offset = _tilemap.Offset;
                    tilemap.ID = areaMap.ID;
                    tilemap.Tiles = areaMap.Tiles.DeepClone();
                    tilemap.Columns = areaMap.Columns;
                    tilemap.Rows = areaMap.Rows;
                    App.Project.UpdateAsset(tilemap);
                }
                LoadData(false);
            }
            // Create brush from selection
            else if (HasData && menuItem == mnuCreateBrush && _tilemap.Tileset != null)
            {
                var bgPalette = cbBgPalette.SelectedItem as Palette;
                var sprPalette = cbSprPalette.SelectedItem as Palette;
                pnlTilemapEdit.CreateBrush(_tilemap.Tileset, bgPalette, sprPalette);
            }
            // Clear brush
            else if (HasData && menuItem == mnuClearBrush && _tilemap.Tileset != null)
            {
                pnlTilemapEdit.ClearBrush();
            }
            // Clear selection
            else if (HasData && menuItem == mnuClearSelection && _tilemap.Tileset != null)
            {
                pnlTilemapEdit.ClearSelection();
            }
            else if (HasData && menuItem == mnuSetSelectionTileId && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetTileIdForSelection(pnlTiles.TileID);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
                UpdateImages(false);
            }
            // Set priority of selected tiles
            else if (HasData && menuItem == mnuSetSelectionPriority && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetPriorityForSelection(true);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
            }
            // Unset priority of selected tiles
            else if (HasData && menuItem == mnuUnsetSelectionPriority && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetPriorityForSelection(false);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
            }
            // Set to BG pallette of selected tiles
            else if (HasData && menuItem == mnuSetSelectionPalette && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetPaletteForSelection(true);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
                UpdateImages(false);
            }
            // Set to SPR palette of selected tiles
            else if (HasData && menuItem == mnuUnsetSelectionPalette && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetPaletteForSelection(false);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
                UpdateImages(false);
            }
            // Set tile type of selected tiles
            else if (HasData && menuItem == mnuSetTileType && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.SetTileTypeForSelection((byte)nudTileType.Value);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
            }
            // Set horizontal mirror of selected tiles
            else if (HasData && menuItem == mnuMirrorX && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.MirrorXForSelection();
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
                UpdateImages(false);
            }
            // Set vertical mirror of selected tiles
            else if (HasData && menuItem == mnuMirrorY && _tilemap.Tileset != null)
            {
                if (pnlTilemapEdit.Tiles == null || pnlTilemapEdit.Tiles.Count <= 0)
                    return;

                pnlTilemapEdit.MirrorYForSelection(true);
                _tilemap.Tiles = pnlTilemapEdit.Tiles.DeepClone();
                UpdateTilemap();
                UpdateImages(false);
            }
            // Create tilemap from selection
            else if (HasData && menuItem == mnuTilemapFromSelection && _tilemap.Tileset != null)
            {
                Tilemap subMap = pnlTilemapEdit.SelectionToTilemap();
                if (subMap == null)
                    return;

                Tilemap tilemap = (Tilemap)App.Project.CreateAsset(GameAssetType.Tilemap);
                subMap.ID = tilemap.ID;
                tilemap = _tilemap.DeepClone();
                tilemap.ID = subMap.ID;
                tilemap.Tiles = subMap.Tiles.DeepClone();
                tilemap.Columns = subMap.Columns;
                tilemap.Rows = subMap.Rows;
                App.Project.UpdateAsset(tilemap);
                UpdateTilemap();
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;
            }
            // Copy selection to existing tilemap
            else if (HasData && _tilemap.Tileset != null && menuItem == mnuSelectionToTilemap)
            {
                Tilemap subMap = pnlTilemapEdit.SelectionToTilemap();
                if (subMap == null)
                    return;

                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.Tilemaps.Count <= 0)
                            return;

                        foreach (var tilemap in form.Tilemaps)
                        {
                            tilemap.Tiles = subMap.Tiles.DeepClone();
                            tilemap.Columns = subMap.Columns;
                            tilemap.Rows = subMap.Rows;
                            tilemap.Tileset = _tilemap.Tileset.DeepClone();
                            tilemap.MetaTilemap = _tilemap.MetaTilemap.DeepClone();
                            App.Project.UpdateAsset(tilemap);
                        }
                    }
                }
            }
            else if (HasData && _tilemap.MetaTilemap != null && menuItem == mnuMetaTilemapSelectionToTilemap)
            {
                Tilemap subMap = _tilemap.AreaToTilemap(pnlMetaTilemapEdit.Selection);
                if (subMap == null)
                    return;

                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.Tilemaps.Count <= 0)
                            return;

                        foreach (var tilemap in form.Tilemaps)
                        {
                            tilemap.Tiles = subMap.Tiles.DeepClone();
                            tilemap.Columns = subMap.Columns;
                            tilemap.Rows = subMap.Rows;
                            tilemap.Tileset = _tilemap.Tileset.DeepClone();
                            tilemap.MetaTilemap = _tilemap.MetaTilemap.DeepClone();
                            App.Project.UpdateAsset(tilemap);
                        }
                    }
                }
            }
            // Crop tilemap from selection
            else if (HasData && menuItem == mnuCropTilemap && _tilemap.Tileset != null)
            {
                Tilemap subMap = pnlTilemapEdit.SelectionToTilemap();
                if (subMap == null)
                    return;

                _tilemap.Tiles = subMap.Tiles.DeepClone();
                _tilemap.Columns = subMap.Columns;
                _tilemap.Rows = subMap.Rows;
                UpdateTilemap();
                UpdateImages();
            }
            // Export selection to clipboard
            else if (HasData && menuItem == mnuExportSelectionDecimalToClipboard)
            {
                Clipboard.SetText(pnlTilemapEdit.SelectionToIdsDecimal(false));
            }
            // Export selection to clipboard reversed
            else if (HasData && menuItem == mnuExportSelectionDecimalReversedToClipboard)
            {
                Clipboard.SetText(pnlTilemapEdit.SelectionToIdsDecimal(true));
            }
            // Export selection area to binary file
            else if (HasData && menuItem == mnuExportAreaToBinary)
            {
                pnlTilemapEdit.SelectionToArea().ToArray();
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data: Selection Area";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = "";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(pnlTilemapEdit.SelectionToArea().ToArray());
                            }
                        }
                    }
                }
            }
            // Export selection area to clipboard
            else if (HasData && menuItem == mnuExportSelectedIndexesToDecimal)
            {
                Clipboard.SetText(pnlTilemapEdit.SelectionToIndexesDecimal(false));
            }
            // Export selection area to clipboard reversed
            else if (HasData && menuItem == mnuExportSelectedIndexesToDecimalReversed)
            {
                Clipboard.SetText(pnlTilemapEdit.SelectionToIndexesDecimal(true));
            }
            // Create new tile grid
            else if (HasData && menuItem == mnuNewTileGrid && cbTileGridTileSize.SelectedItem != null)
            {
                var tileSizeType = (MetaTileSizeType)cbTileGridTileSize.SelectedItem.GetType().GetProperty("value").GetValue(cbTileGridTileSize.SelectedItem);
                TileGrid tileGrid = new TileGrid(tileSizeType, txtTileGridName.Text, (ushort)nudTileGridColumns.Value, (ushort)nudTileGridRows.Value);
                _tilemap.TileGrids.Add(tileGrid);
                UpdateTilemap();
                LoadUI();
            }
            // Export tile grid as binary file
            else if (HasData && menuItem == mnuExportTileGrid && lstTileGrids.SelectedItem != null)
            {
                var tileGrid = lstTileGrids.SelectedItem as TileGrid;
                ExportBinary(tileGrid.Tiles.ToArray(), tileGrid.Name.ToLower().Replace(" ", "_"));
            }
            else if (HasData && menuItem == mnuRemoveTileGrid && lstTileGrids.SelectedItem != null)
            {
                _tilemap.TileGrids.RemoveAt(lstTileGrids.SelectedIndex);
                UpdateTilemap();
                LoadUI();
            }
            // Tileset Methods //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Remove tile
            else if (HasData && menuItem == mnuRemoveTile && _tilemap.Tileset != null)
            {
                int tileID = pnlTilesetEdit.TileID;
                pnlTilesetEdit.RemoveSelection();
                _tilemap.ShiftTiles(-1, tileID);
                _tilemap.Tileset.Pixels = pnlTilesetEdit.Pixels.DeepClone();
                UpdateTilemap();
                UpdateImages();
                pnlSelectedTile.Clear();
            }
            // Remove tiles by range
            else if (HasData && menuItem == mnuRemoveByRange && _tilemap.Tileset != null)
            {
                var start = (int)nudTilesetExportStart.Value;
                var count = (int)nudTilesetExportEnd.Value - start;
                pnlTilesetEdit.RemoveRange(start, count);

                //_tilemap.ShiftTiles(-count, start);
                _tilemap.Tileset.Pixels = pnlTilesetEdit.Pixels.DeepClone();

                UpdateTilemap();
                UpdateImages();
                pnlSelectedTile.Clear();
            }
            // Add new tile to front of tileset
            else if (HasData && menuItem == mnuAddTile && _tilemap.Tileset != null)
            {
                _tilemap.Tileset.AddEmptyTile();
                _tilemap.ShiftTiles(1);
                UpdateTilemap();
                UpdateImages();
            }
            // Copy selected tile from tileset
            else if (HasData && menuItem == mnuTilesetCopyTile && _tilemap.Tileset != null)
            {
                if (pnlTilesetEdit.TileID < 0)
                    return;

                _tileCopy = _tilemap.Tileset.GetTilePixels(pnlTilesetEdit.TileID);
                UpdateTilemap();
                UpdateImages();
            }
            // Paste tile from tile copy at the selected tile id
            else if (HasData && menuItem == mnuTilesetPasteTile && _tilemap.Tileset != null)
            {
                if (_tileCopy == null || pnlTilesetEdit.TileID < 0)
                    return;

                _tilemap.Tileset.SetTilePixels(pnlTilesetEdit.TileID, _tileCopy);
                UpdateTilemap();
                UpdateImages();
            }
            // Deselects tile from tileset editor
            else if (HasData && menuItem == mnuDeselectTile)
            {
                pnlTilesetEdit.ClearSelection();
                pnlSelectedTile.Clear();
            }
            // Copies the tilemap's entire tileset
            else if (HasData && menuItem == mnuCopyTileset)
            {
                _copy = _tilemap.Tileset.DeepClone();
            }
            // Pastes a copied tileset to the selected tilemap
            else if (HasData && menuItem == mnuPasteTileset)
            {
                if (MessageBox.Show("Do you want to auto match Tilemap to pasted Tileset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _tilemap.MatchTiles(_copy.Pixels.DeepClone());
                    _tilemap.Tileset = _copy.DeepClone();
                }
                else
                    _tilemap.Tileset = _copy.DeepClone();

                UpdateTilemap();
                UpdateImages();
            }
            // Pastes a copied tileset to the selected tilemaps
            else if (HasData && menuItem == mnuBulkPasteTileset)
            {
                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.Tilemaps.Count <= 0)
                            return;

                        if (MessageBox.Show("Do you want to auto match Tilemap" + (form.Tilemaps.Count > 1 ? "s" : "") + " to pasted Tileset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            foreach (var tilemap in form.Tilemaps)
                            {
                                tilemap.MatchTiles(_tilemap.Tileset.Pixels.DeepClone());
                                tilemap.Tileset = _tilemap.Tileset.DeepClone();
                                App.Project.UpdateAsset(tilemap);
                            }
                        }
                        else
                        {
                            foreach (var tilemap in form.Tilemaps)
                            {
                                tilemap.Tileset = _tilemap.Tileset.DeepClone();
                                App.Project.UpdateAsset(tilemap);
                            }
                        }
                    }
                }
            }
            // Meta Tilemap methods /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Generate Meta Tiles based on tile map
            else if (HasData && menuItem == mnuGenerateMetaTilemap)
            {
                var type = (MetaTileSizeType)cbMetaTileSize.SelectedValue;
                _tilemap.MetaTilemap = new MetaTilemap(type, pnlTilemapEdit.Image, pnlTilesetEdit.Image);
                App.Project.UpdateAsset(_tilemap);
                UpdateMetaTilemap();
                if (_tilemap.MetaTilemap != null && _tilemap.MetaTilemap.MetaTiles != null && _tilemap.MetaTilemap.MetaTiles.Count > 256)
                {
                    MessageBox.Show("The number of Meta Tiles exceeds 256 Meta Tiles. Try reducing the amount of Meta Tile patterns for the selected size, or select a bigger Meta Tile size.");
                }
            }
            else if (HasData && menuItem == mnuClearMetaTilemap)
            {
                pnlMetaTilesEdit.Clear();
                pnlMetaTilemapEdit.Clear();
                _tilemap.ClearMetaTilemap();
                App.Project.UpdateAsset(_tilemap);
            }
            else if (HasData && menuItem == mnuExportMetaTilemapBinary)
            {
                var data = _tilemap.GetMetaTilemapData(mnuGSLibExportFormat.Checked);
                if (data == null)
                {
                    MessageBox.Show("There is no Meta Tilemap data to export.");
                    return;
                }
                ExportBinary(data, _tilemap.Name.ToLower().Replace(' ', '_') + "_meta_tilemap");
            }
            else if (HasData && menuItem == mnuExportMetaTilesBinary)
            {
                var data = _tilemap.GetMetaTileData(mnuGSLibExportFormat.Checked);
                if (data == null)
                {
                    MessageBox.Show("There is no Meta Tile data to export.");
                    return;
                }
                ExportBinary(data, _tilemap.Name.ToLower().Replace(' ', '_') + "_meta_tiles");
            }
            else if (HasData && menuItem == mnuExportMetaTilesImage)
            {
                ExportMetaTilesImage(_tilemap.Name.ToLower().Replace(' ', '_') + "_meta_tiles");
            }
            else if (HasData && menuItem == mnuExportAllMetaDataBinary)
            {
                mnuTilemap_Click(mnuExportMetaTilemapBinary, EventArgs.Empty);
                mnuTilemap_Click(mnuExportMetaTilesBinary, EventArgs.Empty);
            }
            // Create tilemap from meta tilemap selection
            else if (HasData && menuItem == mnuMetaTilemapTilemapFromSelection && _tilemap.MetaTilemap != null)
            {
                Tilemap subMap = _tilemap.AreaToTilemap(pnlMetaTilemapEdit.Selection);
                if (subMap == null)
                    return;

                Tilemap tilemap = (Tilemap)App.Project.CreateAsset(GameAssetType.Tilemap);
                subMap.ID = tilemap.ID;
                tilemap = _tilemap.DeepClone();
                tilemap.ID = subMap.ID;
                tilemap.Tiles = subMap.Tiles.DeepClone();
                tilemap.Columns = subMap.Columns;
                tilemap.Rows = subMap.Rows;
                tilemap.MetaTilemap = subMap.MetaTilemap.DeepClone();
                App.Project.UpdateAsset(tilemap);
                UpdateTilemap();
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;

                return;
            }
            // Clears meta tilemap selection
            else if (HasData && menuItem == mnuMetaTilemapClearSelection)
            {
                pnlMetaTilemapEdit.ClearSelection();
            }
        }

        private void UpdateMetaTilemap()
        {
            if (!HasData || _tilemap.MetaTilemap == null || _tilemap.MetaTilemap.MetaTiles == null || _tilemap.MetaTilemap.MetaTiles.Count <= 0)
                return;

            cbMetaTileSize.SelectedValue = _tilemap.MetaTilemap.MetaTileSizeType;
            var type = _tilemap.MetaTilemap.MetaTileSizeType;
            pnlMetaTilesEdit.SetMetaTiles(_tilemap.MetaTilemap.MetaTiles, Project.GetMetaTileSize(type));
            pnlMetaTilemapEdit.SetMetaTiles(_tilemap.MetaTilemap.MetaTilemapIds, pnlTilemapEdit.Image, Project.GetMetaTileSize(type));
            lblMetaTileProperties.Text = "Meta Tile Properties: " + pnlMetaTilesEdit.MetaTileProperties;
            lblMetaTilemapProperties.Text = "Meta Tilemap Propertes: " + pnlMetaTilemapEdit.MetaTilemapProperties;
        }

        /// <summary>
        /// Button click
        /// </summary>
        private void btnTilemap_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Tilemap //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // New tilemap
            if (button == btnTilemapNew)
            {
                Tilemap tilemap = (Tilemap)App.Project.CreateAsset(GameAssetType.Tilemap);
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;
            }
            // Duplicate tilemap
            else if (HasData && button == btnTilemapDuplicate)
            {
                Tilemap tilemap = (Tilemap)App.Project.DuplicateAsset(_tilemap);
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;
            }
            // Remove tilemap
            else if (HasData && button == btnTilemapRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _tilemap.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var index = lstTilemaps.SelectedIndex - 1;
                    App.Project.RemoveAsset(_tilemap);
                    LoadData(true);
                    if (index >= 0)
                        lstTilemaps.SelectedIndex = index;
                }
            }
            // Tilemap options
            else if (button == btnTilemapOptions)
            {
                mnuTilemapOptions.Show(btnTilemapOptions, new Point(0, btnTilemapOptions.Height));
                return;
            }
            // Import tilemap
            else if (HasData && button == btnImport)
            {
                mnuImport.Show(btnImport, new Point(0, btnImport.Height));
                return;
            }
            // Export tilemap
            else if (HasData && button == btnExport && _tilemap.Tileset != null)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            // Selection options
            else if (HasData && button == btnSelectionOptions && _tilemap.Tileset != null)
            {
                mnuSelectOptions.Show(btnSelectionOptions, new Point(0, btnSelectionOptions.Height));
                return;
            }
            // Tile grid options
            else if (HasData && button == btnTileGridOptions && _tilemap.Tileset != null)
            {
                mnuTileGridOptions.Show(btnTileGridOptions, new Point(0, btnTileGridOptions.Height));
                return;
            }
            // Tileset options
            else if (HasData && button == btnTilesetOptions && _tilemap.Tileset != null)
            {
                mnuTilesetOptions.Show(btnTilesetOptions, new Point(0, btnTilesetOptions.Height));
                return;
            }
            // Tileset //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Tile pixel swap
            else if (HasData && button == btnSwapSelectedPixel && _tilemap.Tileset != null)
            {
                if (pnlSelectedTile.SelectedColor == 255)
                {
                    MessageBox.Show("No swap color hs been selected. Select a color from the palette.");
                    return;
                }

                if (pnlSelectedTile.TargetColor == 255)
                {
                    MessageBox.Show("No target color hs been selected. Click on a tile pixel to select the color to be swapped.");
                    return;
                }

                _tilemap.Tileset.SwapPixels(pnlSelectedTile.TargetColor, pnlSelectedTile.SelectedColor);
                UpdateTilemap();
                UpdateImages();
                pnlTilesetEdit_TileSelectionChanged();
            }
            // Remove tag
            else if (HasData && button == btnRemoveTag)
            {
                if (lstTags.SelectedItem == null)
                    return;

                _tilemap.Tags.Remove(lstTags.SelectedItem.ToString());
                lstTags.Items.Remove(lstTags.SelectedItem);
                UpdateTilemap();
                return;
            }
            // Add tag
            else if (HasData && button == btnAddTag)
            {
                var tag = txtTagName.Text;
                if (string.IsNullOrEmpty(txtTagName.Text) || string.IsNullOrWhiteSpace(txtTagName.Text) || _tilemap.Tags.Contains(tag))
                    return;

                _tilemap.Tags.Add(tag);
                lstTags.Items.Add(tag);
                if (!cbExistingTags.Items.Contains(tag))
                    cbExistingTags.Items.Add(tag);

                UpdateTilemap();
                return;
            }
            // Add tag in bulk
            else if (HasData && button == btnBulkAddTag)
            {
                var tag = txtTagName.Text;
                if (string.IsNullOrEmpty(txtTagName.Text) || string.IsNullOrWhiteSpace(txtTagName.Text))
                    return;

                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.Tilemaps.Count <= 0)
                            return;

                        foreach (var tilemap in form.Tilemaps)
                        {
                            if (tilemap.Tags.Contains(tag))
                                continue;

                            tilemap.Tags.Add(tag);
                            App.Project.UpdateAsset(tilemap);
                        }
                        LoadUI();
                    }
                }

                return;
            }
            // Add existing tag
            else if (HasData && button == btnAddExistingTag)
            {
                if (cbExistingTags.SelectedItem == null)
                    return;

                var tag = cbExistingTags.SelectedItem.ToString();
                if (_tilemap.Tags.Contains(tag))
                    return;

                _tilemap.Tags.Add(tag);
                lstTags.Items.Add(tag);
                UpdateTilemap();
                return;
            }
            // Meta Tilemap options
            else if (button == btnMetaTileOptions)
            {
                mnuMetaTileOptions.Show(btnMetaTileOptions, new Point(0, btnMetaTileOptions.Height));
                return;
            }
        }

        /// <summary>
        /// Entity name changed
        /// </summary>
        private void txtEntityName_TextChanged(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstTilemaps.SelectedItem == null || lstEntities.SelectedItem == null)
                return;

            (lstEntities.SelectedItem as Entity).Name = txtEntityName.Text;
            UpdateTilemap();
        }

        /// <summary>
        /// Tilemap numeric changed
        /// </summary>
        private void nudTilemap_ValueChanged(object sender, EventArgs e)
        {
            // If data not loaded, if numeric is not sender, return
            if (!HasData || Loading || !(sender is NumericUpDown nud))
                return;

            // Update tilemap
            if (nud == nudOffset)
                _tilemap.Offset = (int)nudOffset.Value;
            else if (nud == nudAreaGridCols || nud == nudAreaGridRows)
            {
                _tilemap.AreaGridSize = new Size((int)nudAreaGridCols.Value, (int)nudAreaGridRows.Value);
                pnlTilemapEdit.AreaGridSize = _tilemap.AreaGridSize;
            }
            else if (nud == nudColumns || nud == nudRows)
                _tilemap.Resize((int)nudColumns.Value, (int)nudRows.Value);
            else if (nud == nudTileType)
            {
                pnlTilemapEdit.TypeValue = (byte)nudTileType.Value;
                pnlTilesetEdit.TypeValue =(byte)nudTileType.Value;
                pnlMetaTilesEdit.TypeValue =(byte)nudTileType.Value;
                pnlTilesetEdit.ClearSelection();
            }
            //else if (nud == nudEntityId && lstEntities.SelectedItem != null)
            //    (lstEntities.SelectedItem as Entity).Id = (byte)nudEntityId.Value;
            //else if ((nud == nudEntityX || nud == nudEntityY || nud == nudEntityWidth || nud == nudEntityHeight) && lstEntities.SelectedItem != null)
            //    (lstEntities.SelectedItem as Entity).Bounds = new Rectangle((ushort)nudEntityX.Value, (ushort)nudEntityY.Value, (ushort)nudEntityWidth.Value, (ushort)nudEntityHeight.Value);
            else if (nud == nudTileGridValue)
            {
                pnlTilemapEdit.BlockValue = (byte)nudTileGridValue.Value;
                return;
            }
            UpdateTilemap();
        }

        /// <summary>
        /// Tilemap combobox selection changed
        /// </summary>
        private void cbTilemap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If combobox is sender
            if (!HasData || !(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            // Perform action based on control
            if (comboBox == cbTilemapCompression)
                _tilemap.CompressionType = (CompressionType)cbTilemapCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilemapCompression.SelectedItem, null);
            else if (comboBox == cbTilesetCompression)
                _tilemap.Tileset.CompressionType = (CompressionType)cbTilesetCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilesetCompression.SelectedItem, null);
            else if (comboBox == cbBgPalette)
            {
                var palette = comboBox.SelectedItem as Palette;
                _tilemap.BgPaletteID = palette.ID;
                pnlBGPalette.SetPalette((comboBox.SelectedItem as Palette).Colors);
                LoadUI();
                return;
            }
            else if (comboBox == cbSprPalette)
            {
                var palette = comboBox.SelectedItem as Palette;
                _tilemap.SprPaletteID = palette.ID;
                pnlSprPalette.SetPalette((comboBox.SelectedItem as Palette).Colors);
                UpdateTilemap();
                LoadUI();
                return;
            }

            UpdateTilemap();
        }

        /// <summary>
        /// Tab page selected index changed
        /// </summary>
        private void tabTilemap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If radio is not sender, return
            if (!(sender is TabControl tab))
                return;

            var page = tab.SelectedTab;
            if (page == tabEntities)
            {
                pnlTilemapEdit.EditMode = TileEditType.Entities;
            }
            else if (page == tabTileGrids)
            {
                pnlTilemapEdit.EditMode = TileEditType.TileGrid;
            }
            else
            {
                pnlTilemapEdit.EditMode = _editType;
            }
        }

        /// <summary>
        /// Tilemap radio button check changed
        /// </summary>
        private void rbTilemap_CheckedChanged(object sender, EventArgs e)
        {
            // If radio is not sender, return
            if (!(sender is RadioButton radio))
                return;

            // Perform action based on control
            if (radio == rbBgPalette || radio == rbSprPalette)
            {
                try
                {
                    _selectedPalette = rbBgPalette.Checked ? cbBgPalette.SelectedItem as Palette : cbSprPalette.SelectedItem as Palette;
                    UpdateImages();
                }
                catch
                {

                }
            }
            else if (radio == rbTilemapBrush)
            {
                pnlTilemapEdit.EditMode = TileEditType.TileID;
            }
            else if (radio == rbTilemapSelect)
            {
                pnlTilemapEdit.EditMode = TileEditType.Selection;
            }
            else if (radio == rbTilemapFlipX)
            {
                pnlTilemapEdit.EditMode = TileEditType.XFlip;
            }
            else if (radio == rbTilemapFlipY)
            {
                pnlTilemapEdit.EditMode = TileEditType.YFlip;
            }
            else if (radio == rbTilemapPriority)
            {
                pnlTilemapEdit.EditMode = TileEditType.Priority;
            }
            else if (radio == rbTilemapPalette)
            {
                pnlTilemapEdit.EditMode = TileEditType.PaletteIndex;
            }
            else if (radio == rbTilemapTileType)
            {
                pnlTilemapEdit.EditMode = TileEditType.Bits;
            }
            else if (radio == rbTilesetSelect)
            {
                pnlTilesetEdit.ClearSelection();
                pnlTilesetEdit.EditMode = TilesetEditType.Select;
            }
            else if (radio == rbTilesetSwap)
            {
                pnlTilesetEdit.ClearSelection();
                pnlTilesetEdit.EditMode = TilesetEditType.Swap;
            }
            else if (radio == rbTilesetType)
            {
                pnlTilesetEdit.ClearSelection();
                pnlTilesetEdit.EditMode = TilesetEditType.Type;
            }
            else if (radio == rbTilemapShowIds)
            {
                pnlTilemapEdit.ShowIndexes = !rbTilemapShowIds.Checked;
            }
            else if (radio == rbTilemapShowIndexes)
            {
                pnlTilemapEdit.ShowIndexes = rbTilemapShowIndexes.Checked;
            }
            else if (radio == rbMetaTileIds)
            {
                pnlMetaTilesEdit.EditMode = TileEditType.TileID;
            }
            else if (radio == rbMetaTileValue)
            {
                pnlMetaTilesEdit.EditMode = TileEditType.TileValue;
            }
            else if (radio == rbMetaTilePriority)
            {
                pnlMetaTilesEdit.EditMode = TileEditType.Priority;
            }
            else if (radio == rbMetaTilePalette)
            {
                pnlMetaTilesEdit.EditMode = TileEditType.PaletteIndex;
            }
            else if (radio == rbMetaTileType)
            {
                pnlMetaTilesEdit.EditMode = TileEditType.Bits;
            }
            _editType = pnlTilemapEdit.EditMode;
        }

        /// <summary>
        /// Tilemap combobox check changed
        /// </summary>
        private void chkTilemap_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is not sender
            if (!(sender is CheckBox checkBox))
                return;

            // Perform action based on control
            if (checkBox == chkTilemapInvertGrids)
            {
                pnlTilemapEdit.InvertGridColor = chkTilemapInvertGrids.Checked;
            }
            else if (checkBox == chkTilemapShowTileAs)
            {
                pnlTiles.Indexed = chkTilemapShowTileAs.Checked;
                pnlTilemapEdit.Indexed = chkTilemapShowTileAs.Checked;
            }
            else if (checkBox == chkTilesetShowTileIds)
            {
                pnlTilesetEdit.Indexed = chkTilesetShowTileIds.Checked;
            }
            else if (checkBox == chkHighlighter)
            {
                pnlTilemapEdit.Highlight = chkHighlighter.Checked;
                lblHighlighterCountValue.Text = pnlTilemapEdit.HighlightCount.ToString();
            }
            else if (checkBox == chkTilemapGrid)
            {
                pnlTilemapEdit.UseGrid = chkTilemapGrid.Checked;
                pnlTiles.UseGrid = chkTilemapGrid.Checked;
                pnlMetaTilemapEdit.UseGrid = chkTilemapGrid.Checked;
            }
            else if (checkBox == chkTilemapAreaGrid)
            {
                pnlTilemapEdit.UseAreaGrid = chkTilemapAreaGrid.Checked;
            }
            else if (checkBox == chkTilesetGrid)
            {
                pnlTilesetEdit.UseGrid = chkTilesetGrid.Checked;
            }
            else if (checkBox == chkMetaTileApplyEditsByTileId)
            {
                pnlMetaTilesEdit.ApplyEditsToAllMetaTiles = chkMetaTileApplyEditsByTileId.Checked;
            }
            else if (checkBox == chkMetaTilesShowHexValues)
            {
                pnlMetaTilesEdit.ShowHexValues = chkMetaTilesShowHexValues.Checked;
            }
            else if (checkBox == chkMetaTilemapShowGrid)
            {
                pnlMetaTilemapEdit.UseGrid = chkMetaTilemapShowGrid.Checked;
            }
            else if (checkBox == chkMetaTilemapInvertGrid)
            {
                pnlMetaTilemapEdit.InvertGridColor = chkMetaTilemapInvertGrid.Checked;
                pnlMetaTilesEdit.InvertGridColor = chkMetaTilemapInvertGrid.Checked;
            }
            else if (checkBox == chkMetaTilemapShowIds)
            {
                pnlMetaTilemapEdit.ShowIds = chkMetaTilemapShowIds.Checked;
            }
        }

        /// <summary>
        /// Tile selection changed
        /// </summary>
        private void pnlTiles_TileSelectionChanged()
        {
            if (_tilemap == null || _tilemap.Tiles == null || _tilemap.Tileset == null || _tilemap.Tileset.Pixels == null)
                return;

            pnlTilemapEdit.TileID = pnlTiles.TileID;
            lblSelectedTileIDValue.Text = pnlTiles.TileID.ToString();
            lblHighlighterCountValue.Text = pnlTilemapEdit.HighlightCount.ToString();
        }

        /// <summary>
        /// Tilemap tile changed
        /// </summary>
        private void pnlTilemapEdit_TileChanged()
        {
            if (_tilemap == null || _tilemap.Tiles == null || _tilemap.Tileset == null || _tilemap.Tileset.Pixels == null)
                return;

            if (pnlTilemapEdit.EditMode == TileEditType.TileGrid)
            {
                if (!HasData || lstTileGrids.SelectedItem == null)
                    return;

                _tilemap.TileGrids[lstTileGrids.SelectedIndex] = pnlTilemapEdit.TileGrid.DeepClone();
                lstTileGrids.Items[lstTileGrids.SelectedIndex] = pnlTilemapEdit.TileGrid.DeepClone();
                App.Project.UpdateAsset(_tilemap);
            }
            else
            {
                _tilemap.Tiles = pnlTilemapEdit.Tiles;
                UpdateTilemap();
                var bgPalette = cbBgPalette.SelectedItem as Palette;
                var sprPalette = cbSprPalette.SelectedItem as Palette;
                pnlTilemapEdit.Image = BitmapUtility.GetTileImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
            }
        }

        ///// <summary>
        ///// Block value changed
        ///// </summary>
        //private void pnlTilemapEdit_MetatileChanged()
        //{
        //    if (_tilemap == null || _selectedMetaTilemap == null || _tilemap.Tiles == null || _tilemap.Tileset == null || _tilemap.Tileset.Pixels == null)
        //        return;

        //    _selectedMetaTilemap.Tiles = pnlTilemapEdit.Metatiles;
        //    UpdateTilemap();
        //    //var bgPalette = cbBgPalette.SelectedItem as Palette;
        //    //var sprPalette = cbSprPalette.SelectedItem as Palette;
        //    //pnlTilemapEdit.Image = BitmapUtility.GetSpriteImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
        //}

        /// <summary>
        /// Entities changed
        /// </summary>
        private void pnlTilemapEdit_EntitiesChanged()
        {
            if (_tilemap == null || _tilemap.Entities == null)
                return;

            _tilemap.Entities = pnlTilemapEdit.Entities;
            lstEntities.Items.Clear();
            foreach (var entity in _tilemap.Entities)
                lstEntities.Items.Add(entity);

            UpdateTilemap();
        }

        /// <summary>
        /// Entity selection changed
        /// </summary>
        private void lstEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || lstEntities.SelectedItem == null)
                return;

            Loading = true;
            var entity = (lstEntities.SelectedItem as Entity);
            pnlTilemapEdit.SelectedEntity = entity;
            txtEntityName.Text = entity.Name;
            //nudEntityId.Value = entity.Id;
            //nudEntityX.Value = entity.Bounds.X;
            //nudEntityY.Value = entity.Bounds.Y;
            //nudEntityWidth.Value = entity.Bounds.Width;
            //nudEntityHeight.Value = entity.Bounds.Height;
            pnlTilemapEdit.SelectedEntity = entity;
            Loading = false;
        }

        /// <summary>
        /// Tilemap cursor position changed
        /// </summary>
        private void pnlTilemapEdit_PositionChanged()
        {
            lblPosition.Text = "Position: " + pnlTilemapEdit.PositionText;
            lblTile.Text = "Tile: " + pnlTilemapEdit.TileText;
            lblSelection.Text = "Selection: " + pnlTilemapEdit.SelectionText;
        }

        /// <summary>
        /// 
        /// </summary>
        private void pnlTilesetEdit_TilesChanged()
        {
            if (!HasData || _tilemap.Tileset == null)
                return;

            _tilemap.Tileset.Pixels = pnlTilesetEdit.Pixels;
            UpdateTilemap();
            UpdateImages();
        }

        /// <summary>
        /// Tileset edit tile selection changed
        /// </summary>
        private void pnlTilesetEdit_TileSelectionChanged()
        {
            if (!HasData || pnlTilesetEdit.TileID < 0)
                return;

            pnlSelectedTile.TargetColor = 255;
            pnlSelectedTile.SelectedTileID = pnlTilesetEdit.TileID;
            pnlSelectedTile.Palette = _selectedPalette.DeepClone().Colors;
            pnlSelectedTile.Pixels = _tilemap.Tileset.GetTilePixels(pnlTilesetEdit.TileID);
            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);

            if (rbTilesetType.Checked && _tilemap.Tileset != null && pnlTilesetEdit.TileID > -1)
            {
                _tilemap.SetTileType(pnlTilesetEdit.TileID, (byte)nudTileType.Value);
                UpdateTilemap();
                UpdateImages();
            }
        }

        /// <summary>
        /// Selected tile pixel changed
        /// </summary>
        private void pnlSelectedTile_PixelChanged()
        {
            if (!HasData || _tilemap.Tileset == null)
                return;

            _tilemap.Tileset.SetTilePixels(pnlSelectedTile.SelectedTileID, pnlSelectedTile.Pixels);
            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);
            UpdateImages();
            UpdateTilemap();
        }

        /// <summary>
        /// Meta tile tile value changed
        /// </summary>
        private void pnlMetaTilesEdit_MetaTileChanged()
        {
            if (!HasData || _tilemap.Tileset == null)
                return;

            _tilemap.MetaTilemap.MetaTiles = pnlMetaTilesEdit.MetaTiles.DeepClone();
            App.Project.UpdateAsset(_tilemap);
        }

        /// <summary>
        /// Background palette selcted color changed
        /// </summary>
        private void pnlBGPalette_SelectedColorChanged()
        {
            pnlSelectedTile.SelectedColor = (byte)pnlBGPalette.SelectedIndex;
        }

        /// <summary>
        /// Sprite palette selected color changed
        /// </summary>
        private void pnlSPRPalette_SelectedColorChanged()
        {
            pnlSelectedTile.SelectedColor = (byte)pnlSprPalette.SelectedIndex;
        }

        #region Exports

        private void ExportPaletteImage(string filename)
        {
            if (!HasData || _selectedPalette == null)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Palette Image (" + _selectedPalette.Name + ")";
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var image = BitmapUtility.GetPaletteImage(_selectedPalette, new Size(16, 16), 16))
                        {
                            if (image != null)
                                image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        private void ExportPalette(string filename)
        {
            if (!HasData || _selectedPalette == null)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data (" + _selectedPalette.Name + ")";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(_selectedPalette.GetPaletteData(true, BitmapUtility.CheckForGameGearColors(_selectedPalette.Colors)));
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the binary file. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        private void ExportTileset(string filename)
        {
            if (!HasData || _tilemap.Tileset == null)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Tileset Image: " + _tilemap.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        bool useCustomColor = mnuTilesetUseMaskColor.Checked;
                        Palette palette = (Palette)App.Project.GetAsset(_selectedPalette.ID);
                        if (useCustomColor)
                        {
                            if (palette.Colors.Count > 0)
                                palette.Colors[0] = Color.Lime;
                        }
                        using (Bitmap image = BitmapUtility.GetTilesetImage(_tilemap.Tileset, palette, 16))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports selected tilemap tilesets to images
        /// </summary>
        private void ExportTilesets()
        {
            if (!HasData)
                return;

            var failed = new StringBuilder();
            try
            {
                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() != DialogResult.OK || form.Tilemaps.Count <= 0)
                        return;

                    using (var dialog = new FolderBrowserDialog())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            foreach (var tilemap in form.Tilemaps)
                            {
                                var filename = tilemap.Name.ToLower().Replace(' ', '_') + "_map.png";
                                try
                                {
                                    var palette = rbBgPalette.Checked ? App.Project.Palettes.Find(x => x.ID == tilemap.BgPaletteID) : App.Project.Palettes.Find(x => x.ID == tilemap.SprPaletteID);
                                    var image = BitmapUtility.GetTilesetImage(tilemap.Tileset, palette, 16);
                                    image.Save(dialog.SelectedPath + "\\" + filename, ImageFormat.Png);
                                }
                                catch
                                {
                                    failed.AppendLine(filename);
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            if (failed.ToString() != "")
            {
                failed.Insert(0, "The following files have failed to export: " + Environment.NewLine);
                failed.AppendLine("A file with the same name may be in use in another application.");
                MessageBox.Show(failed.ToString());
            }
        }

        /// <summary>
        /// Exports a tilemap image
        /// </summary>
        private void ExportTilemap(string filename)
        {
            if (!HasData || _tilemap == null || pnlTilemapEdit.Image == null)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Tilemap Image: " + _tilemap.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pnlTilemapEdit.Image.Save(dialog.FileName, ImageFormat.Png);
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports a meta tileset image
        /// </summary>
        private void ExportMetaTilesImage(string filename)
        {
            if (!HasData || _tilemap == null || _tilemap.MetaTilemap == null || _tilemap.MetaTilemap.MetaTiles == null)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Meta Tiles Image: " + _tilemap.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var image = BitmapUtility.GetMetaTileImage(_tilemap.MetaTilemap.MetaTiles, _tilemap.MetaTilemap.MetaTileSize, mnuGSLibExportFormat.Checked))
                        {
                            image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an issue exporting the image. A file with the same name may be in use in another application.");
            }
        }

        /// <summary>
        /// Exports selected tilemaps to images
        /// </summary>
        private void ExportTilemaps()
        {
            if (!HasData)
                return;

            var failed = new StringBuilder();
            try
            {
                using (var form = new TilemapSelectForm(true))
                {
                    if (form.ShowDialog() != DialogResult.OK || form.Tilemaps.Count <= 0)
                        return;

                    if (form.ImageMerge)
                    {
                        using (var dialog = new SaveFileDialog())
                        {
                            dialog.Title = "Export Merged Tilemap Image";
                            dialog.Filter = "PNG Image File|*.png";
                            if (dialog.ShowDialog() != DialogResult.OK)
                                return;

                            var strips = new List<Size>();
                            var cols = form.ImageMergeColumnCount;
                            var rows = form.Tilemaps.Count / cols;
                            for (int row = 0; row < rows; row++)
                            {
                                // todo: validate range for row, as a row could have less tilemaps than the column count
                                var strip = form.Tilemaps.GetRange(row * cols, cols);
                                strips.Add(new Size(strip.Sum(t => t.Size.Width), strip.Max(t => t.Size.Height)));
                            }
                            var x = 0;
                            var y = 0;
                            using (var image = new Bitmap(strips.Max(t => t.Width), strips.Sum(t => t.Height)))
                            {
                                using (var gfx = Graphics.FromImage(image))
                                {
                                    for (int row = 0; row < rows; row++)
                                    {
                                        x = 0;
                                        y += row - 1 < 0 ? 0 : strips[row - 1].Height;
                                        var tilemaps = form.Tilemaps.GetRange(row * cols, cols);
                                        foreach (var tilemap in tilemaps)
                                        {
                                            var bgPalette = App.Project.Palettes.Find(t => t.ID == tilemap.BgPaletteID);
                                            var sprPalette = App.Project.Palettes.Find(t => t.ID == tilemap.SprPaletteID);
                                            using (var subImage = BitmapUtility.GetTileImage(tilemap.Tileset, tilemap, bgPalette, sprPalette))
                                            {
                                                gfx.DrawImage(subImage, new Rectangle(x, y, subImage.Width, subImage.Height));
                                                x += subImage.Width;
                                            }
                                        }
                                    }
                                }
                                image.Save(dialog.FileName, ImageFormat.Png);
                            }
                        }
                    }
                    else
                    {
                        using (var dialog = new FolderBrowserDialog())
                        {
                            if (dialog.ShowDialog() != DialogResult.OK)
                                return;

                            foreach (var tilemap in form.Tilemaps)
                            {
                                var filename = tilemap.Name.ToLower().Replace(' ', '_') + "_map.png";
                                try
                                {
                                    var bgPalette = App.Project.Palettes.Find(x => x.ID == tilemap.BgPaletteID);
                                    var sprPalette = App.Project.Palettes.Find(x => x.ID == tilemap.SprPaletteID);
                                    using (var image = BitmapUtility.GetTileImage(tilemap.Tileset, tilemap, bgPalette, sprPalette))
                                    {
                                        image.Save(dialog.SelectedPath + "\\" + filename, ImageFormat.Png);
                                    }
                                }
                                catch
                                {
                                    failed.AppendLine(filename);
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            if (failed.ToString() != "")
            {
                failed.Insert(0, "The following files have failed to export: " + Environment.NewLine);
                failed.AppendLine("A file with the same name may be in use in another application.");
                MessageBox.Show(failed.ToString());
            }
        }

        /// <summary>
        /// Exports binary data
        /// </summary>
        public void ExportBinary(byte[] data, string filename)
        {
            if (!HasData || _tilemap.Tileset == null || data == null)
                return;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Binary Data: " + _tilemap.Name;
                dialog.Filter = "Binary File|*.bin";
                dialog.FileName = filename;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        using (BinaryWriter bw = new BinaryWriter(fs))
                        {
                            bw.Write(data);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Exports a tilemap binaries
        /// </summary>
        private void ExportBinaries(bool tilemaps)
        {
            if (!HasData)
                return;

            var failed = new StringBuilder();
            try
            {
                using (var form = new TilemapSelectForm(false))
                {
                    if (form.ShowDialog() != DialogResult.OK || form.Tilemaps.Count <= 0)
                        return;

                    using (var dialog = new FolderBrowserDialog())
                    {
                        if (dialog.ShowDialog() != DialogResult.OK)
                            return;

                        foreach (var tilemap in form.Tilemaps)
                        {
                            if (tilemaps)
                            {
                                var filename = tilemap.Name.ToLower().Replace(' ', '_') + "_map.bin";
                                try
                                {
                                    var data = tilemap.GetTilemapData(!tilemap.UsesCompression, GetTilemapExportOrientation());
                                    using (FileStream fs = new FileStream(dialog.SelectedPath + "\\" + filename, FileMode.Create))
                                    {
                                        using (BinaryWriter bw = new BinaryWriter(fs))
                                        {
                                            bw.Write(data);
                                        }
                                    }
                                }
                                catch
                                {
                                    failed.AppendLine(filename);
                                    continue;
                                }
                            }
                            else
                            {
                                var filename = tilemap.Name.ToLower().Replace(' ', '_') + "_tiles.bin";
                                try
                                {
                                    var data = tilemap.Tileset.GetTilesetData(!tilemap.Tileset.UsesCompression);
                                    using (FileStream fs = new FileStream(dialog.SelectedPath + "\\" + filename, FileMode.Create))
                                    {
                                        using (BinaryWriter bw = new BinaryWriter(fs))
                                        {
                                            bw.Write(data);
                                        }
                                    }
                                }
                                catch
                                {
                                    failed.AppendLine(filename);
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

            if (failed.ToString() != "")
            {
                failed.Insert(0, "The following files have failed to export: " + Environment.NewLine);
                failed.AppendLine("A file with the same name may be in use in another application.");
                MessageBox.Show(failed.ToString());
            }
        }

        /// <summary>
        /// Exports SG formatted bitmap and color table data
        /// </summary>
        private void ExportSGData()
        {
            try
            {
                if (!HasData || _tilemap.Tileset == null)
                    return;

                // Get tile and color map data
                var data = _tilemap.GetSGTileData();
                // Save tiles
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export SG Tile Binary Data: " + _tilemap.Name;
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _tilemap.Name.ToLower().Replace(' ', '_') + "_tiles.bin"; ;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(data.Item1);
                            }
                        }
                    }
                }
                // Save color map
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export SG Color Map Binary Data: " + _tilemap.Name;
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _tilemap.Name.ToLower().Replace(' ', '_') + "_color_map.bin"; ;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(data.Item2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        #endregion

        #region UI

        /// <summary>
        /// Loads list of palette data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;

            cbBgPalette.Items.Clear();
            cbBgPalette.Items.AddRange(App.Project.GetPaletteArray());

            cbSprPalette.Items.Clear();
            cbSprPalette.Items.AddRange(App.Project.GetPaletteArray());

            LoadList(loadDefault);
            Loading = false;
        }

        private void LoadList(bool loadDefault)
        {
            Loading = true;

            var item = lstTilemaps.SelectedItem ?? lstTilemaps.SelectedItem.DeepClone();
            lstTilemaps.Items.Clear();
            foreach (var asset in App.Project.Tilemaps.OrderBy(x => x.Name).ToArray())
                lstTilemaps.Items.Add(asset);

            if (loadDefault && lstTilemaps.Items.Count > 0)
                lstTilemaps.SelectedIndex = 0;
            else if (item != null && ItemByID((item as GameAsset).ID, lstTilemaps) != null)
                lstTilemaps.SelectedItem = ItemByID((item as GameAsset).ID, lstTilemaps);
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            tabMain.Visible = lstTilemaps.SelectedItem != null;
            _tilemap = lstTilemaps.SelectedItem == null ? null : (Tilemap)App.Project.GetAsset((lstTilemaps.SelectedItem as Tilemap).ID);

            var bgPalette = (Palette)App.Project.GetAsset(_tilemap == null ? -3 : _tilemap.BgPaletteID);
            var sprPalette = (Palette)App.Project.GetAsset(_tilemap == null ? -2 : _tilemap.SprPaletteID);

            if (_tilemap == null)
                return;

            if (bgPalette == null)
            {
                bgPalette = (Palette)App.Project.GetAsset(-3);
                _tilemap.BgPaletteID = -3;
                App.Project.UpdateAsset(_tilemap);
            }

            if (sprPalette == null)
            {
                sprPalette = (Palette)App.Project.GetAsset(-2);
                _tilemap.SprPaletteID = -2;
                App.Project.UpdateAsset(_tilemap);
            }

            cbBgPalette.SelectedItem = bgPalette;
            pnlBGPalette.SetPalette(bgPalette.Colors);
            cbSprPalette.SelectedItem = sprPalette;
            pnlSprPalette.SetPalette(sprPalette.Colors);

            _selectedPalette = rbBgPalette.Checked ? cbBgPalette.SelectedItem as Palette : cbSprPalette.SelectedItem as Palette;
            txtName.Text = _tilemap == null ? string.Empty : _tilemap.Name;
            cbTilemapCompression.SelectedValue = _tilemap == null ? CompressionType.None : _tilemap.CompressionType;
            nudOffset.Value = _tilemap == null ? 0 : _tilemap.Offset;
            nudTilesetExportStart.Value = 0;
            nudTilesetExportEnd.Maximum = _tilemap == null || _tilemap.Tileset == null ? 448 : _tilemap.Tileset.TileCount;
            nudTilesetExportEnd.Value = nudTilesetExportEnd.Maximum;
            nudTilesetExportStart.Maximum = nudTilesetExportEnd.Maximum;
            nudColumns.Value = _tilemap == null ? 1 : _tilemap.Columns;
            nudRows.Value = _tilemap == null ? 1 : _tilemap.Rows;
            nudAreaGridCols.Value = _tilemap == null ? 1 : _tilemap.AreaGridSize.Width;
            nudAreaGridRows.Value = _tilemap == null ? 1 : _tilemap.AreaGridSize.Height;
            chkUseAttributes.Checked = _tilemap == null ? true : _tilemap.UseTileAttributes;
            lblInfo.Text = _tilemap == null ? "No Tilemap information" : _tilemap.GetInfo();
            lblMetaTilemapProperties.Text = "Meta Tilemap Properties: N/A";
            lblMetaTileProperties.Text = "Meta Tile Properties: N/A";

            lstEntities.Items.Clear();

            if (_tilemap == null)
            {
                UpdateImages();
                pnlMetaTilesEdit.Clear();
                pnlMetaTilemapEdit.Clear();
                UpdateMetaTilemap();
                return;
            }

            lstTileGrids.Items.Clear();

            foreach (var tileGrid in _tilemap.TileGrids)
                lstTileGrids.Items.Add(tileGrid);

            if (lstTileGrids.Items.Count > 0)
                lstTileGrids.SelectedIndex = 0;

            lstTileGrids_SelectedIndexChanged(this, EventArgs.Empty);

            foreach (var sprite in _tilemap.Entities)
                lstEntities.Items.Add(sprite);

            if (lstEntities.Items.Count > 0)
                lstEntities.SelectedIndex = 0;

            if (lstEntities.SelectedItem != null)
            {
                var entity = lstEntities.SelectedItem as Entity;
                //nudEntityId.Value = entity.Id;
                //nudEntityX.Value = entity.Bounds.X;
                //nudEntityY.Value = entity.Bounds.Y;
                //nudEntityWidth.Value = entity.Bounds.Width;
                //nudEntityHeight.Value = entity.Bounds.Height;
            }

            var item = cbExistingTags.SelectedItem;
            var tags = new List<string>();
            cbExistingTags.Items.Clear();
            foreach (var tilemap in App.Project.Tilemaps)
                foreach (var tag in tilemap.Tags)
                    if (!tags.Contains(tag))
                        tags.Add(tag);

            cbExistingTags.Items.AddRange(tags.OrderBy(x => x).ToArray());
            cbExistingTags.SelectedItem = item;

            lstTags.Items.Clear();
            lstTags.Items.AddRange(_tilemap.Tags.ToArray());
            UpdateImages();
            pnlMetaTilesEdit.Clear();
            pnlMetaTilemapEdit.Clear();
            UpdateMetaTilemap();
        }

        /// <summary>
        /// Updates graphics for UI elements
        /// </summary>
        private void UpdateImages(bool clear = true)
        {
            if (_tilemap == null || _tilemap.Tiles == null || _tilemap.Tileset == null || _tilemap.Tileset.Pixels == null)
            {
                pnlTilemapEdit.Clear();
                pnlTilesetEdit.Clear();
                pnlTiles.Clear();
                return;
            }

            var bgPalette = cbBgPalette.SelectedItem as Palette;
            var sprPalette = cbSprPalette.SelectedItem as Palette;
            pnlTilemapEdit.Image = BitmapUtility.GetTileImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
            pnlTilemapEdit.SetTilemap(_tilemap, clear);
            pnlTilemapEdit.AreaGridSize = _tilemap.AreaGridSize;
            pnlTilesetEdit.Image = BitmapUtility.GetTilesetImage(_tilemap.Tileset, _selectedPalette, 16);
            pnlTilesetEdit.SetTileset(_tilemap.Tileset, _selectedPalette.Colors, clear);
            pnlTiles.ClearTileId = clear;
            pnlTiles.Image = BitmapUtility.GetTilesetImage(_tilemap.Tileset, _selectedPalette, 6);
            pnlTiles.Offset = _tilemap.Offset;
            pnlTiles.TileCount = _tilemap.Tileset.TileCount;
            pnlTilemapEdit.TileID = pnlTiles.TileID;
            lblInfo.Text = _tilemap.GetInfo();
        }


        /// <summary>
        /// Update tilemap data and UI
        /// </summary>
        private void UpdateTilemap()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_tilemap);
            Loading = true;
            Updating = true;
            LoadList(false);
            pnlTiles_TileSelectionChanged();
            lblInfo.Text = _tilemap == null ? "No Tilemap information" : _tilemap.GetInfo();
            Loading = false;
            Updating = false;
        }

        #endregion

        #region Misc.

        /// <summary>
        /// Gets the selected tilemap export orientation
        /// </summary>
        /// <returns>Selected orientation</returns>
        private OrientationType GetTilemapExportOrientation()
        {
            if (mnuTilemapVerticalOrientation.Checked)
                return OrientationType.Vertical;
            else
                return OrientationType.Horizontal;
        }

        /// <summary>
        /// Handles hot key input
        /// </summary>
        /// <param name="keyData"></param>
        public void HandleInput(Keys keyData)
        {
            if (ActiveControl is TextBox)
                return;

            // Do action based on key
            switch (keyData)
            {
                case Keys.A:
                    if (tabMain.SelectedTab == tabTilemap)
                        chkTilemapAreaGrid.Checked = !chkTilemapAreaGrid.Checked;
                    break;
                case Keys.B:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapBrush.Checked = true;
                    break;
                case Keys.C:
                    if (tabMain.SelectedTab == tabTilemap)
                        chkTilemapInvertGrids.Checked = !chkTilemapInvertGrids.Checked;
                    break;
                case Keys.S:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapSelect.Checked = true;
                    else if (tabMain.SelectedTab == tabTileset)
                        rbTilesetSelect.Checked = true;
                    break;
                case Keys.H:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapFlipX.Checked = true;
                    break;
                case Keys.V:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapFlipY.Checked = true;
                    break;
                case Keys.P:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapPriority.Checked = true;
                    break;
                case Keys.L:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapPalette.Checked = true;
                    break;
                case Keys.T:
                    if (tabMain.SelectedTab == tabTilemap)
                        rbTilemapTileType.Checked = true;
                    else if (tabMain.SelectedTab == tabTileset)
                        rbTilesetType.Checked = true;
                    break;
                case Keys.W:
                    if (tabMain.SelectedTab == tabTileset)
                        rbTilesetSwap.Checked = true;
                    break;
                case Keys.G:
                    if (tabMain.SelectedTab == tabTilemap)
                        chkTilemapGrid.Checked = !chkTilemapGrid.Checked;
                    else if (tabMain.SelectedTab == tabTileset)
                        chkTilesetGrid.Checked = !chkTilesetGrid.Checked;
                    break;
                case Keys.I:
                    if (tabMain.SelectedTab == tabTilemap)
                        chkTilemapShowTileAs.Checked = !chkTilemapShowTileAs.Checked;
                    else if (tabMain.SelectedTab == tabTileset)
                        chkTilesetShowTileIds.Checked = !chkTilesetShowTileIds.Checked;
                    break;
                case Keys.Delete:
                    if (tabMain.SelectedTab == tabTileset && pnlTilesetEdit.TileID > -1)
                        mnuTilemap_Click(mnuRemoveTile, EventArgs.Empty);
                    else if (tabMain.SelectedTab == tabTilemap)
                        btnTilemap_Click(btnTilemapRemove, EventArgs.Empty);
                    break;
            }
        }

        #endregion
    }
}