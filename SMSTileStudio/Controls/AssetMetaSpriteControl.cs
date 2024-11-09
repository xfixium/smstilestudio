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
using System.Text;

namespace SMSTileStudio.Controls
{
    public partial class AssetMetaSpriteControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MetaSprite _metaSprite = null;
        private Palette _selectedPalette = null;
        private MetaSpriteFrame _frame = null;
        private Sprite _sprite = null;
        private List<int> _sprites = new List<int>();
        private int _frameIndex = 0;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _metaSprite != null; } }
        private bool HasFrameData { get { return _metaSprite != null && _frame != null && _frame.Tileset != null; } }

        public AssetMetaSpriteControl()
        {
            InitializeComponent();

            cbTilesetCompression.ValueMember = "Value";
            cbTilesetCompression.DisplayMember = "Description";
            cbTilesetCompression.DataSource = EnumMethods.GetEnumCollection(typeof(CompressionType));
            if (cbTilesetCompression.Items.Count > 0)
                cbTilesetCompression.SelectedIndex = 0;

            //cbSpriteMode.ValueMember = "Value";
            cbSpriteMode.DisplayMember = "Description";
            cbSpriteMode.DataSource = Enum.GetValues(typeof(SpriteModeType));
            if (cbSpriteMode.Items.Count > 0)
                cbSpriteMode.SelectedIndex = 0;

            pnlMetaSpriteEdit.Image = new Bitmap(256, 224);
        }

        /// <summary>
        /// Meta Ssprite selection changed
        /// </summary>
        private void lstMetaSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            _frameIndex = 0;
            _sprite = null;
            if (!Updating)
                _sprites.Clear();
            lstMetaSprites.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Tilemap button click
        /// </summary>
        private void btnMetaSprite_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Perform action based on which button was clicked
            if (HasFrameData && button == btnPreviousFrame)
            {
                if (_frameIndex - 1 > -1)
                    _frameIndex -= 1;
                else
                    _frameIndex = _metaSprite.Frames.Count - 1;

                Loading = true;
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            else if (HasFrameData && button == btnNextFrame)
            {
                if (_frameIndex + 1 < _metaSprite.Frames.Count)
                    _frameIndex += 1;
                else
                    _frameIndex = 0;

                Loading = true;
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            else if (button == btnNew)
            {
                MetaSprite metaSprite = (MetaSprite)App.Project.CreateAsset(GameAssetType.MetaSprite);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            else if (HasData && button == btnDuplicate)
            {
                MetaSprite metaSprite = (MetaSprite)App.Project.DuplicateAsset(_metaSprite);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            else if (HasData && button == btnMirror)
            {
                MetaSprite metaSprite = (MetaSprite)App.Project.DuplicateAsset(_metaSprite);
                metaSprite.Mirror(true, false);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _metaSprite.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_metaSprite);
                    LoadData(true);
                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (HasData && button == btnImport)
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
                if (importColors.Count > 16)
                {
                    MessageBox.Show("The image has more than 16 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportMetaSpriteForm(image, _metaSprite, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            else if (HasFrameData && button == btnSpriteConfigAll)
            {
                foreach (var frame in _metaSprite.Frames)
                    frame.SpriteConfig = (int)nudSpriteConfig.Value;
            }
            else if (HasFrameData && button == btnDurationAll)
            {
                foreach (var frame in _metaSprite.Frames)
                    frame.Duration = (int)nudDuration.Value;
            }
            else if (HasData && button.Name == btnAddTile.Name)
            {
                if (_frame == null || _frame.Tileset == null)
                    return;

                _frame.Tileset.AddEmptyTile();
                UpdateMetaSprite();
            }
            else if (HasData && button == btnRemoveTile)
            {
                pnlTilesetEdit.RemoveSelection();
                UpdateMetaSprite();
                pnlSelectedTile.Clear();
            }
            else if (HasData && button == btnDeselectTile)
            {
                pnlTilesetEdit.ClearSelection();
                pnlSelectedTile.Clear();
            }
            else if (HasData && button == btnSwapSelectedPixel && HasFrameData)
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

                _frame.Tileset.SwapPixels(pnlSelectedTile.TargetColor, pnlSelectedTile.SelectedColor);
                UpdateMetaSprite();
                pnlTilesetEdit_TileSelectionChanged();
            }
            else if (HasData && button == btnLeft)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).X--;

                SetSelectedSprites();
            }
            else if (HasData && button == btnUp)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).Y--;

                SetSelectedSprites();
            }
            else if (HasData && button == btnRight)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).X++;

                SetSelectedSprites();
            }
            else if (HasData && button == btnDown)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).Y++;

                SetSelectedSprites();
            }
        }

        /// <summary>
        /// Export menu item click
        /// </summary>
        private void mnuMetaSprite_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuTilesetExportImage && HasFrameData)
                ExportTileset(_metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles");
            else if (menuItem == mnuTilesetExportBinary && HasFrameData)
            {
                var minimum = (int)nudTileMinimum.Value;
                var fileName = _metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles" + (mnuTilesetSingleFrame.Checked ? "_" + _frameIndex.ToString("D2") : "");
                ExportData(mnuTilesetSingleFrame.Checked ? _frame.Tileset.GetTilesetData(true, minimum) : _metaSprite.GetAllTilesetData(true, minimum), fileName);
            }
            else if (menuItem == mnuTilesetExportBinaries && HasFrameData)
            {
                var fileName = _metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles" + (mnuTilesetSingleFrame.Checked ? "_" + _frameIndex.ToString("D2") : "");
                using (MetaSpriteSelectForm form = new MetaSpriteSelectForm())
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    if (form.BinaryMerge)
                    {
                        var bytes = new List<byte>();
                        foreach (var metaSprite in form.MetaSprites)
                            bytes.AddRange(metaSprite.GetAllTilesetData(true));

                        ExportData(bytes.ToArray(), fileName);
                    }
                    else
                    {
                        ExportBinaries(form.MetaSprites);
                    }
                }
            }
            else if (menuItem == mnuTilesetExportHex)
                Clipboard.SetText(HasFrameData ? _frame.Tileset.GetDataString(true) : "");
            else if (menuItem == mnuTilesetExportAssembly && HasFrameData)
                Clipboard.SetText(_frame.Tileset.GetDataString(true));
            else if (menuItem == mnuMetaSpriteExportBinary)
                ExportData(_metaSprite.GetMetaSpriteData(true, false), _metaSprite.Name.ToLower().Replace(' ', '_') + "_sprites");
            else if (menuItem == mnuMetaSpriteExportBinaryFramed)
                ExportData(_metaSprite.GetMetaSpriteData(true, true), _metaSprite.Name.ToLower().Replace(' ', '_') + "_sprites");
            else if (menuItem == mnuMetaSpriteExportHex)
                Clipboard.SetText(_metaSprite.GetASMString(true));
            else if (menuItem == mnuMetaSpriteExportAssembly)
                Clipboard.SetText(_metaSprite.GetASMString(false));
            else if (menuItem == mnuMetaSpriteExportDKSMSText)
                Clipboard.SetText(_metaSprite.GetDKSMSString(mnuMetaSpriteStreaming.Checked));
            else if (menuItem == mnuExportSelectionDevKitSMS)
                Clipboard.SetText(_metaSprite.GetDKSMSString(GetSelectedSprites()));
        }

        /// <summary>
        /// Meta Sprite name changed
        /// </summary>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!HasData || Loading || lstMetaSprites.SelectedItem == null || e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            _metaSprite.Name = txtName.Text;
            UpdateMetaSprite();
        }

        /// <summary>
        /// Meta Sprite name changed
        /// </summary>
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstMetaSprites.SelectedItem == null)
                return;

            _metaSprite.Name = txtName.Text;
            UpdateMetaSprite();
        }

        /// <summary>
        /// 
        /// </summary>
        private void rbMetaSprite_CheckedChanged(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is RadioButton radio))
                return;
        }

        /// <summary>
        /// 
        /// </summary>
        private void chkMetaSprite_CheckedChanged(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is CheckBox checkBox))
                return;

            // Perform action based on control
            if (checkBox == chkTilesetIndexes)
                pnlTilesetEdit.Indexed = chkTilesetIndexes.Checked;
            else if (checkBox == chkSprites)
                pnlMetaSpriteEdit.ShowSprites = chkSprites.Checked;
            else if (checkBox == chkGrid)
                pnlMetaSpriteEdit.UseGrid = chkGrid.Checked;
            else if (checkBox == chkShowOrigin)
                pnlMetaSpriteEdit.ShowOrigin = chkShowOrigin.Checked;
            else if (checkBox == chkTransparent)
                pnlMetaSpriteEdit.ShowTransparent = chkTransparent.Checked;
            else if (checkBox == chkGridSnap)
                pnlMetaSpriteEdit.ShowOrigin = chkShowOrigin.Checked;
            else if (checkBox == chkTilesetGrid)
                pnlTilesetEdit.UseGrid = chkTilesetGrid.Checked;
        }

        /// <summary>
        /// Meta sprite numeric value changed
        /// </summary>
        private void nudMetaSprite_ValueChanged(object sender, EventArgs e)
        {
            // If data not loaded, if numeric is not sender, return
            if (!(sender is NumericUpDown numeric) || Loading)
                return;

            if (numeric == nudOffset)
                _metaSprite.Offset = (int)nudOffset.Value;
            else if (numeric == nudTileMinimum)
                _metaSprite.TileMinimum = (int)nudTileMinimum.Value;
            else if (numeric == nudDuration && _frame != null)
                _frame.Duration = (int)nudDuration.Value;
            else if (numeric == nudSpriteConfig && _frame != null)
                _frame.SpriteConfig = (int)nudSpriteConfig.Value;
            else if (numeric == nudSpriteX && lstSprites.SelectedItem != null)
                (lstSprites.SelectedItem as Sprite).X = (int)nudSpriteX.Value;
            else if (numeric == nudSpriteY && lstSprites.SelectedItem != null)
                (lstSprites.SelectedItem as Sprite).Y = (int)nudSpriteY.Value;

            UpdateMetaSprite();
        }

        /// <summary>
        /// Tilemap combobox selection changed
        /// </summary>
        private void cbMetaSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If combobox is sender
            if (!(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            // Perform action based on control
            if (comboBox == cbSpriteMode && HasData)
                _metaSprite.SpriteMode = (SpriteModeType)cbSpriteMode.SelectedItem;
            else if (comboBox == cbSprPalette && HasData)
                _metaSprite.PaletteID = (cbSprPalette.SelectedItem as Palette).ID;
            else if (comboBox == cbTilesetCompression && HasFrameData)
                _frame.Tileset.CompressionType = (CompressionType)cbTilesetCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilesetCompression.SelectedItem, null);

            UpdateMetaSprite();
        }

        /// <summary>
        /// 
        /// </summary>
        private void lstSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || lstSprites.SelectedItem == null)
                return;

            Loading = true;
            pnlMetaSpriteEdit.SelectedSprites = GetSelectedSprites();
            _sprite = (lstSprites.SelectedItem as Sprite);
            nudSpriteX.Value = _sprite.X;
            nudSpriteY.Value = _sprite.Y;
            Loading = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void lstCollisions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            Loading = false;
        }

        // Tileset edit tile selection changed
        private void pnlTilesetEdit_TileSelectionChanged()
        {
            if (!HasData || pnlTilesetEdit.TileID < 0)
                return;

            pnlSelectedTile.TargetColor = 255;
            pnlSelectedTile.SelectedTileID = pnlTilesetEdit.TileID;
            pnlSelectedTile.Palette = _selectedPalette.DeepClone().Colors;
            pnlSelectedTile.Pixels = HasFrameData ? _frame.Tileset.GetTilePixels(pnlTilesetEdit.TileID) : null;
            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);
        }

        // Selected palette color changed
        private void pnlSprPalette_SelectedColorChanged()
        {
            pnlSelectedTile.SelectedColor = (byte)pnlSprPalette.SelectedIndex;
        }

        // Selected tile pixel changed
        private void pnlSelectedTile_PixelChanged()
        {
            if (!HasData)
                return;

            _frame.Tileset.SetTilePixels(pnlSelectedTile.SelectedTileID, pnlSelectedTile.Pixels);
            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);
            UpdateImages();
            UpdateMetaSprite();
        }

        /// <summary>
        /// Sets selected sprites for editing
        /// </summary>
        private void SetSelectedSprites()
        {
            _sprites.Clear();
            for (int i = 0; i < lstSprites.Items.Count; i++)
            {
                if (lstSprites.GetSelected(i))
                    _sprites.Add(i);
            }
            Updating = true;
            UpdateMetaSprite();
            Updating = false;
        }

        /// <summary>
        /// Sets selected sprites for editing
        /// </summary>
        private List<Sprite> GetSelectedSprites()
        {
            var sprites  = new List<Sprite>();
            for (int i = 0; i < lstSprites.Items.Count; i++)
            {
                if (lstSprites.GetSelected(i))
                    sprites.Add(lstSprites.Items[i] as Sprite);
            }
            return sprites;
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        private void ExportTileset(string filename)
        {
            if (!HasData || HasFrameData)
                return;

            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Tileset Image: " + _metaSprite.Name;
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = filename;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Palette palette = (Palette)App.Project.GetAsset(_selectedPalette.ID);
                        if (mnuTilesetSingleFrame.Checked)
                        {
                            using (Bitmap image = BitmapUtility.GetTilesetImage(_frame.Tileset, palette, 16))
                            {
                                image.Save(dialog.FileName, ImageFormat.Png);
                            }
                        }
                        else
                        {
                            using (var image = _metaSprite.GetTilesetImageStrip(palette))
                            {
                                image.Save(dialog.FileName, ImageFormat.Png);
                            }
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
        /// Exports binary data
        /// </summary>
        public void ExportData(byte[] data, string filename)
        {
            if (!HasData || data == null)
                return;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Binary Data: " + _metaSprite.Name;
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
        private void ExportBinaries(List<MetaSprite> metaSprites)
        {
            if (!HasData)
                return;

            var failed = new StringBuilder();
            try
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    foreach (var metaSprite in metaSprites)
                    {
                        var filename = metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles.bin";
                        try
                        {
                            var data = metaSprite.GetAllTilesetData(true);
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
        /// Loads list data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;

            LoadList(loadDefault);

            Loading = false;
        }

        private void LoadList(bool loadDefault)
        {
            Loading = true;

            var item = lstMetaSprites.SelectedItem ?? lstMetaSprites.SelectedItem.DeepClone();
            lstMetaSprites.Items.Clear();
            foreach (var asset in App.Project.MetaSprites.OrderBy(x => x.Name).ToArray())
                lstMetaSprites.Items.Add(asset);

            cbSprPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes)
                cbSprPalette.Items.Add(asset);

            if (loadDefault && lstMetaSprites.Items.Count > 0)
                lstMetaSprites.SelectedIndex = 0;
            else if (item != null && lstMetaSprites.Items.Contains(item))
                lstMetaSprites.SelectedItem = item;
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            tabMain.Visible = lstMetaSprites.SelectedItem != null;
            _metaSprite = lstMetaSprites.SelectedItem == null ? null : lstMetaSprites.SelectedItem as MetaSprite;
            _frame = _metaSprite == null || _metaSprite.Frames.Count <= 0 ? null : _metaSprite.Frames[_frameIndex];
            nudTileMinimum.Value = _metaSprite == null ? 0 : _metaSprite.TileMinimum;
            nudOffset.Value = _metaSprite == null ? 0 : _metaSprite.Offset;
            nudDuration.Value = _frame == null ? 0 : _frame.Duration;
            nudSpriteConfig.Value = _frame == null ? 0 : _frame.SpriteConfig;
            //pnlMetaSpriteEdit.SpriteMode = _metaSprite == null ? SpriteModeType.Normal : _metaSprite.SpriteMode;
            txtName.Text = _metaSprite == null ? string.Empty : _metaSprite.Name;
            cbSprPalette.SelectedItem = (Palette)App.Project.GetAsset(_metaSprite == null ? -2 : _metaSprite.PaletteID);
            pnlSprPalette.SetPalette(cbSprPalette.SelectedItem == null ? null : (cbSprPalette.SelectedItem as Palette).Colors);
            _selectedPalette = cbSprPalette.SelectedItem as Palette;
            lblInfo.Text = _metaSprite == null ? "No Meta Sprite information" : _metaSprite.GetInfo(_frameIndex);
            pnlMetaSpriteEdit.Palette = _selectedPalette;
            pnlMetaSpriteEdit.LoadFrame(_frame, _metaSprite == null ? SpriteModeType.Normal : _metaSprite.SpriteMode);
            cbTilesetCompression.SelectedItem = !HasFrameData ? CompressionType.None : _frame.Tileset.CompressionType;
            cbSpriteMode.SelectedItem = _metaSprite == null ? SpriteModeType.Normal : _metaSprite.SpriteMode;
            lblCurrentFrameValue.Text = _metaSprite == null || _metaSprite.Frames.Count <= 0 ? "0 / 0" : _frameIndex + " / " + (_metaSprite.Frames.Count - 1);

            lstSprites.Items.Clear();
            lstCollisions.Items.Clear();
            if (!HasFrameData)
                return;

            foreach (var sprite in _frame.Sprites)
                lstSprites.Items.Add(sprite);

            foreach (var collision in _frame.Collisions)
                lstCollisions.Items.Add(collision);

            if (lstSprites.Items.Count > 0 && _sprites.Count > 0)
            {
                foreach (var sprite in _sprites)
                {
                    try
                    {
                        lstSprites.SetSelected(sprite, true);
                    }
                    catch { }
                }
            }
            else if (lstSprites.Items.Count > 0)
                lstSprites.SelectedIndex = 0;

            if (lstCollisions.Items.Count > 0)
                lstCollisions.SelectedIndex = 0;

            UpdateImages();
        }

        private void UpdateImages()
        {
            if (_metaSprite == null || _frame == null || _frame.Tileset == null || _frame.Tileset.Pixels == null || _selectedPalette == null)
            {
                pnlTilesetEdit.Clear();
                return;
            }

            var sprPalette = cbSprPalette.SelectedItem as Palette;
            //pnlTilemapEdit.Image = BitmapUtility.GetSpriteImage(_tilemap.Tileset, _tilemap, bgPalette, sprPalette);
            //pnlTilemapEdit.SetTilemap(_tilemap);
            pnlTilesetEdit.Image = BitmapUtility.GetTilesetImage(_frame.Tileset, _selectedPalette, 16);
            pnlTilesetEdit.SetTileset(_frame.Tileset, _selectedPalette.Colors);
            //pnlTiles.Image = BitmapUtility.GetTilesetImage(_frame.Tileset, _selectedPalette, 6);
            //pnlTiles.Offset = _tilemap.Offset;
            //pnlTiles.TileCount = _tilemap.Tileset.TileCount;
            lblInfo.Text = _metaSprite.GetInfo(_frameIndex);
        }

        /// <summary>
        /// Update tilemap data and UI
        /// </summary>
        private void UpdateMetaSprite()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_metaSprite);
            Loading = true;
            LoadList(false);
            lblInfo.Text = _metaSprite == null ? "No Meta Sprite information" : _metaSprite.GetInfo(_frameIndex);
            LoadUI();
            Loading = false;
        }
    }
}
