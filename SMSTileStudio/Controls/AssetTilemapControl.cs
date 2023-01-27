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
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using SMSTileStudio.Data;
using SMSTileStudio.Forms;

namespace SMSTileStudio.Controls
{
    public partial class AssetTilemapControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Tilemap _tilemap = null;
        private Palette _selectedPalette = null;
        private Tileset _copy = null;
        private int _frame = 0;

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
        }

        /// <summary>
        /// Tilemap selection changed
        /// </summary>
        private void lstTilemaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            lstTilemaps.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Tilemap menu item click
        /// </summary>
        private void mnuTilemap_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuImportTilemap)
            {
                string path = string.Empty;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PNG Image File|*.png";
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    path = ofd.FileName;
                }

                Bitmap image;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    image = (Bitmap)Image.FromStream(fs);
                }

                if (image == null)
                {
                    MessageBox.Show("There was an issue getting the image data.");
                    return;
                }

                List<Color> importColors = BitmapUtility.GetColors(image);
                if (importColors == null || importColors.Count > 32)
                {
                    MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportGraphicsForm(image, _tilemap, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstTilemaps_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (menuItem == mnuUpdateTileset)
            {
                string path = string.Empty;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PNG Image File|*.png";
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    path = ofd.FileName;
                }

                Bitmap image;
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    image = (Bitmap)Image.FromStream(fs);
                }

                if (image == null)
                {
                    MessageBox.Show("There was an issue getting the image data.");
                    return;
                }

                List<Color> importColors = BitmapUtility.GetColors(image);
                if (importColors.Count > 32)
                {
                    MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportGraphicsForm(image, _tilemap.Name, _tilemap.BgPaletteID, _tilemap.SprPaletteID, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstTilemaps_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (menuItem == mnuTilesetExportImage)
                ExportTileset(_tilemap.Name.ToLower().Replace(' ', '_') + "_tiles");
            else if (menuItem == mnuTilesetExportBinary)
                ExportData(_tilemap.Tileset.GetTilesetData(mnuTilesetBypassCompression.Checked, (int)nudTilesetExportStart.Value, (int)nudTilesetExportEnd.Value), _tilemap.Name.ToLower().Replace(' ', '_') + "_tiles");
            else if (menuItem == mnuTilesetExportHex)
                Clipboard.SetText(_tilemap.Tileset.GetASMString(true));
            else if (menuItem == mnuTilesetExportAssembly)
                Clipboard.SetText(_tilemap.Tileset.GetASMString(false));
            else if (menuItem == mnuTilemapExportImage)
                ExportTilemap(_tilemap.Name.ToLower().Replace(' ', '_') + "_map");
            else if (menuItem == mnuTilemapExportBinary)
                ExportData(_tilemap.GetTilemapData(mnuTilemapBypassCompression.Checked, GetTilemapExportOrientation()), _tilemap.Name.ToLower().Replace(' ', '_') + "_map");
            else if (menuItem == mnuTilemapExportHex)
                Clipboard.SetText(_tilemap.GetASMString(true));
            else if (menuItem == mnuTilemapExportAssembly)
                Clipboard.SetText(_tilemap.GetASMString(false));
            else if (menuItem == mnuCreateBrush && _tilemap.Tileset != null)
            {
                var bgPalette = cbBgPalette.SelectedItem as Palette;
                var sprPalette = cbSprPalette.SelectedItem as Palette;
                pnlTilemapEdit.CreateBrush(_tilemap.Tileset, bgPalette, sprPalette);
            }
            else if (menuItem == mnuClearBrush && _tilemap.Tileset != null)
            {
                pnlTilemapEdit.ClearBrush();
            }
            else if (menuItem == mnuTilemapFromSelection && _tilemap.Tileset != null)
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
        }

        /// <summary>
        /// Tilemap button click
        /// </summary>
        private void btnTilemap_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Perform action based on which button was clicked
            if (button == btnNew)
            {
                Tilemap tilemap = (Tilemap)App.Project.CreateAsset(GameAssetType.Tilemap);
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;
            }
            else if (HasData && button == btnDuplicate)
            {
                Tilemap tilemap = (Tilemap)App.Project.DuplicateAsset(_tilemap);
                LoadData(tilemap == null);
                if (tilemap != null)
                    lstTilemaps.SelectedItem = tilemap;
            }
            else if (HasData && button == btnRemove)
            {
                App.Project.RemoveAsset(_tilemap);
                LoadData(true);
                lstTilemaps_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else if (HasData && button == btnImport)
            {
                mnuImport.Show(btnImport, new Point(0, btnImport.Height));
                return;
            }
            else if (HasData && button == btnExport && _tilemap.Tileset != null)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            else if (HasData && button == btnReplaceTiles && _tilemap != null && _tilemap.Tileset != null)
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
            else if (HasData && button == btnOptimizeTilemap)
            {
                // todo: optimize method 
            }
            else if (HasData && button == btnSelectionOptions && _tilemap.Tileset != null)
            {
                mnuSelectOptions.Show(btnSelectionOptions, new Point(0, btnSelectionOptions.Height));
                return;
            }
            else if (HasData && button.Name == btnAddTile.Name)
            {
                if (_tilemap == null || _tilemap.Tileset == null)
                    return;

                _tilemap.Tileset.AddEmptyTile();
                _tilemap.ShiftTiles(1);
                UpdateTilemap();
                UpdateImages();
            }
            else if (HasData && button == btnRemoveTile && _tilemap.Tileset != null)
            {
                int tileID = pnlTilesetEdit.TileID;
                pnlTilesetEdit.RemoveSelection();
                _tilemap.ShiftTiles(-1, tileID);
                UpdateTilemap();
                UpdateImages();
                pnlSelectedTile.Clear();
            }
            else if (HasData && button == btnDeselectTile)
            {
                pnlTilesetEdit.DeselectSelection();
                pnlSelectedTile.Clear();
            }
            else if (HasData && button == btnCopyTileset)
            {
                _copy = _tilemap.Tileset.DeepClone();
            }
            else if (HasData && button == btnPasteTileset)
            {
                _tilemap.Tileset = _copy.DeepClone();
                UpdateTilemap();
                UpdateImages();
            }
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
        }

        /// <summary>
        /// Tilemap name changed
        /// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstTilemaps.SelectedItem == null)
                return;

            _tilemap.Name = txtName.Text;
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
            else if (nud == nudColumns)
                _tilemap.Columns = (int)nudColumns.Value;
            else if (nud == nudRows)
                _tilemap.Rows = (int)nudRows.Value;
            else if (nud == nudBits)
                pnlTilemapEdit.BitsValue = (byte)nudBits.Value;

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
            if (comboBox.Name == cbTilemapCompression.Name)
                _tilemap.CompressionType = (CompressionType)cbTilemapCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilemapCompression.SelectedItem, null);
            else if (comboBox.Name == cbTilesetCompression.Name)
                _tilemap.Tileset.CompressionType = (CompressionType)cbTilesetCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilesetCompression.SelectedItem, null);
            else if (comboBox.Name == cbBgPalette.Name)
            {
                var palette = comboBox.SelectedItem as Palette;
                _tilemap.BgPaletteID = palette.ID;
                pnlBGPalette.SetPalette((comboBox.SelectedItem as Palette).Colors);
            }
            else if (comboBox.Name == cbSprPalette.Name)
            {
                var palette = comboBox.SelectedItem as Palette;
                _tilemap.SprPaletteID = palette.ID;
                pnlSprPalette.SetPalette((comboBox.SelectedItem as Palette).Colors);
            }

            UpdateTilemap();
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
            if (radio.Name == rbBrush.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.TileID;
            }
            else if (radio.Name == rbSelect.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.Selection;
            }
            else if (radio.Name == rbFlipX.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.XFlip;
            }
            else if (radio.Name == rbFlipY.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.YFlip;
            }
            else if (radio.Name == rbPriority.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.Priority;
            }
            else if (radio.Name == rbPalette.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.PaletteIndex;
            }
            else if (radio.Name == rbBits.Name)
            {
                pnlTilemapEdit.EditMode = TileEditType.Bits;
            }
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
            if (checkBox.Name == chkAttributes.Name)
            {
                pnlTiles.Indexed = chkAttributes.Checked;
                pnlTilemapEdit.Indexed = chkAttributes.Checked;
            }
            else if (checkBox.Name == chkTilesetIndexes.Name)
            {
                pnlTilesetEdit.Indexed = chkTilesetIndexes.Checked;
            }
            else if (checkBox.Name == chkHighlighter.Name)
            {
                pnlTilemapEdit.Highlight = chkHighlighter.Checked;
                lblHighlighterCountValue.Text = pnlTilemapEdit.HighlightCount.ToString();
            }
            else if (checkBox.Name == chkTilemapGrid.Name)
            {
                pnlTilemapEdit.UseGrid = chkTilemapGrid.Checked;
                pnlTiles.UseGrid = chkTilemapGrid.Checked;
            }
            else if (checkBox.Name == chkTilesetGrid.Name)
            {
                pnlTilesetEdit.UseGrid = chkTilesetGrid.Checked;
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

            _tilemap.Tiles = pnlTilemapEdit.Tiles;
            UpdateTilemap();
            var bgPalette = cbBgPalette.SelectedItem as Palette;
            var sprPalette = cbSprPalette.SelectedItem as Palette;
            pnlTilemapEdit.Image = BitmapUtility.GetSpriteImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
        }

        /// <summary>
        /// Tilemap cursor position changed
        /// </summary>
        private void pnlTilemapEdit_PositionChanged()
        {
            lblPosition.Text = "Position: " + pnlTilemapEdit.PositionText;
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
        }

        /// <summary>
        /// 
        /// </summary>
        private void pnlBGPalette_SelectedColorChanged()
        {
            pnlSelectedTile.SelectedColor = (byte)pnlBGPalette.SelectedIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        private void pnlSPRPalette_SelectedColorChanged()
        {
            pnlSelectedTile.SelectedColor = (byte)pnlSprPalette.SelectedIndex;
        }

        /// <summary>
        /// Updates graphics for UI elements
        /// </summary>
        private void UpdateImages()
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
            pnlTilemapEdit.Image = BitmapUtility.GetSpriteImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
            pnlTilemapEdit.SetTilemap(_tilemap);
            pnlTilesetEdit.Image = BitmapUtility.GetTilesetImage(_tilemap.Tileset, _selectedPalette, 16);
            pnlTilesetEdit.SetTileset(_tilemap.Tileset, _selectedPalette.Colors);
            pnlTiles.Image = BitmapUtility.GetTilesetImage(_tilemap.Tileset, _selectedPalette, 6);
            pnlTiles.Offset = _tilemap.Offset;
            pnlTiles.TileCount = _tilemap.Tileset.TileCount;
            pnlTilemapEdit.TileID = pnlTiles.TileID;
            lblInfo.Text = _tilemap.GetInfo();
        }

        /// <summary>
        /// Gets the selected tilemap export orientation
        /// </summary>
        /// <returns>Selected orientation</returns>
        private OrientationType GetTilemapExportOrientation()
        {
            if (mnuTilemapVerticalOrientation.Checked)
                return OrientationType.Vertical;
            else if (mnuTilemapReverseVerticalOrientation.Checked)
                return OrientationType.ReverseVertical;
            else
                return OrientationType.Horizontal;
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
        /// Exports a yilemap image
        /// </summary>
        private void ExportTilemap(string filename)
        {
            if (!HasData || _tilemap == null || pnlTilemapEdit.Image == null)
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
        /// Exports binary data
        /// </summary>
        public void ExportData(byte[] data, string filename)
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
        /// Loads list of palette data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;
            var item = lstTilemaps.SelectedItem ?? lstTilemaps.SelectedItem.DeepClone();
            lstTilemaps.Items.Clear();
            foreach (var asset in App.Project.Tilemaps.OrderBy(x => x.Name).ToArray())
                lstTilemaps.Items.Add(asset);

            cbBgPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes)
                cbBgPalette.Items.Add(asset);

            cbSprPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes)
                cbSprPalette.Items.Add(asset);

            if (loadDefault && lstTilemaps.Items.Count > 0)
                lstTilemaps.SelectedIndex = 0;
            else if (item != null && lstTilemaps.Items.Contains(item))
                lstTilemaps.SelectedItem = item;
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
            txtName.Text = _tilemap == null ? string.Empty : _tilemap.Name;
            cbTilemapCompression.SelectedItem = _tilemap == null ? CompressionType.None : _tilemap.CompressionType;
            nudOffset.Value = _tilemap == null ? 0 : _tilemap.Offset;
            nudTilesetExportStart.Value = 0;
            nudTilesetExportEnd.Maximum = _tilemap == null || _tilemap.Tileset == null ? 448 : _tilemap.Tileset.TileCount;
            nudTilesetExportEnd.Value = nudTilesetExportEnd.Maximum;
            nudTilesetExportStart.Maximum = nudTilesetExportEnd.Maximum;
            nudColumns.Value = _tilemap == null ? 1 : _tilemap.Columns;
            nudRows.Value = _tilemap == null ? 1 : _tilemap.Rows;
            chkUseAttributes.Checked = _tilemap == null ? true : _tilemap.UseTileAttributes;
            cbBgPalette.SelectedItem = (Palette)App.Project.GetAsset(_tilemap == null ? -3 : _tilemap.BgPaletteID);
            pnlBGPalette.SetPalette(cbBgPalette.SelectedItem == null ? null : (cbBgPalette.SelectedItem as Palette).Colors);
            cbSprPalette.SelectedItem = (Palette)App.Project.GetAsset(_tilemap == null ? -2 : _tilemap.SprPaletteID);
            pnlSprPalette.SetPalette(cbSprPalette.SelectedItem == null ? null : (cbSprPalette.SelectedItem as Palette).Colors);
            _selectedPalette = rbBgPalette.Checked ? cbBgPalette.SelectedItem as Palette : cbSprPalette.SelectedItem as Palette;
            lblInfo.Text = _tilemap == null ? "No Tilemap information" : _tilemap.GetInfo();
            UpdateImages();
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
            lstTilemaps.SelectedItem = _tilemap;
            lstTilemaps.Refresh();
            pnlTiles_TileSelectionChanged();
            lblInfo.Text = _tilemap == null ? "No Tilemap information" : _tilemap.GetInfo();
            Loading = false;
        }

        private void pnlSelectedTile_PixelChanged()
        {
            if (!HasData || _tilemap.Tileset == null)
                return;

            _tilemap.Tileset.SetTilePixels(pnlSelectedTile.SelectedTileID, pnlSelectedTile.Pixels);
            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);
            UpdateImages();
            UpdateTilemap();
        }
    }
}
