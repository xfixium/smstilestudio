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
    public partial class AssetMetaSpriteControl : AssetControl
    {
        // Fields
        private MetaSprite _metaSprite = null;
        private Palette _selectedPalette = null;
        private MetaSpriteFrame _frame = null;
        private Sprite _sprite = null;
        private List<Sprite> _spriteClipboard = new List<Sprite>();
        private List<int> _sprites = new List<int>();
        private int _frameIndex = 0;
        private List<byte> _tileCopy = new List<byte>();

        // Properties
        private bool HasData { get { return _metaSprite != null; } }
        private bool HasFrameData { get { return _metaSprite != null && _frame != null && _frame.Tileset != null; } }

        public AssetMetaSpriteControl()
        {
            InitializeComponent();

            cbTilesetCompression.ValueMember = "Value";
            cbTilesetCompression.DisplayMember = "Description";
            cbTilesetCompression.DataSource = App.GetCompressors(false);
            if (cbTilesetCompression.Items.Count > 0)
                cbTilesetCompression.SelectedIndex = 0;

            pnlMetaSpriteEdit.Image = new Bitmap(256, 224);
        }

        // Override key presses
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // Do action based on key
            if (tabMain.SelectedTab == tabSpriteEdit)
                HandleInput(keyData);
            
            // Process
            return base.ProcessDialogKey(keyData);
        }

        // Meta sprite list selection changed
        private void lstMetaSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            _sprite = null;
            if (!Updating)
            {
                _frameIndex = 0;
                _sprites.Clear();
            }
            lstMetaSprites.Refresh();
            LoadUI();
            Loading = false;
        }

        // Meta sprite button click
        private void btnMetaSprite_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Perform action based on which button was clicked
            // Previous frame
            if (HasFrameData && button == btnPreviousFrame)
            {
                if (_frameIndex - 1 > -1)
                    _frameIndex -= 1;
                else
                    _frameIndex = _metaSprite.Frames.Count - 1;

                Loading = true;
                pnlMetaSpriteEdit.ClearSelected();
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            // Next frame
            else if (HasFrameData && button == btnNextFrame)
            {
                if (_frameIndex + 1 < _metaSprite.Frames.Count)
                    _frameIndex += 1;
                else
                    _frameIndex = 0;

                Loading = true;
                pnlMetaSpriteEdit.ClearSelected();
                LoadUI();
                UpdateImages();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            // New Meta Sprite
            else if (button == btnNew)
            {
                MetaSprite metaSprite = (MetaSprite)App.Project.CreateAsset(GameAssetType.MetaSprite);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            // Duplicate Meta Sprite
            else if (HasData && button == btnDuplicate)
            {
                MetaSprite metaSprite = (MetaSprite)App.Project.DuplicateAsset(_metaSprite);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            // Mirror selected Meta Sprite
            else if (HasData && button == btnMirror)
            {
                if (_metaSprite.MetaSpriteType == MetaSpriteType.Tileset)
                {
                    MessageBox.Show("Tileset Meta Sprites can not be mirrored.");
                    return;
                }
                MetaSprite metaSprite = (MetaSprite)App.Project.DuplicateAsset(_metaSprite);
                metaSprite.Mirror(true, false);
                LoadData(metaSprite == null);
                if (metaSprite != null)
                    lstMetaSprites.SelectedItem = metaSprite;
            }
            // Remove selected Meta Sprite
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _metaSprite.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_metaSprite);
                    LoadData(true);
                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            // Import Meta Sprite graphics
            else if (HasData && button == btnImport)
            {
                mnuImport.Show(btnImport, new Point(0, btnImport.Height));
                return;
            }
            // Export selected Meta Sprite
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            // Display frame options menu
            else if (HasData && button == btnFrameOptions)
            {
                mnuFrameOptions.Show(btnFrameOptions, new Point(0, btnFrameOptions.Height));
                return;
            }
            // Move selected sprites up the sprite list
            else if (HasData && button == btnSelectionMoveUpList)
            {
                lstSprites.MoveSelectedItemsUp();
                _frame.Sprites.Clear();
                foreach (var item in lstSprites.Items)
                {
                    _frame.Sprites.Add(item as Sprite);
                }
                App.Project.UpdateAsset(_metaSprite);
                return;
            }
            // Move selected sprites down the sprite list
            else if (HasData && button == btnSelectionMoveDownList)
            {
                lstSprites.MoveSelectedItemsDown();
                _frame.Sprites.Clear();
                foreach (var item in lstSprites.Items)
                {
                    _frame.Sprites.Add(item as Sprite);
                }
                App.Project.UpdateAsset(_metaSprite);
                return;
            }
            // Copy selected sprites
            else if (HasData && button == btnSpriteCopy)
            {
                _spriteClipboard.AddRange(pnlMetaSpriteEdit.SelectedSprites.DeepClone());
                return;
            }
            // Paste selected sprites
            else if (HasData && button == btnSpritePaste)
            {
                _frame.Sprites.AddRange(_spriteClipboard.DeepClone());
                App.Project.UpdateAsset(_metaSprite);
                LoadUI();
                UpdateImages();
                return;
            }
            // Remove selected sprites
            else if (HasData && button == btnRemoveSelection)
            {
                if (MessageBox.Show("Are you sure you want to remove the selected sprite(s)?", "SMS Tile STudio", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                foreach (var sprite in pnlMetaSpriteEdit.SelectedSprites)
                    _frame.Sprites.Remove(sprite);

                pnlMetaSpriteEdit.ClearSelected();
                App.Project.UpdateAsset(_metaSprite);
                LoadUI();
                UpdateImages();
                return;
            }
            // Move selected sprites left a pixel
            else if (HasData && button == btnLeft)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).X--;

                SaveSelectedSprites();
            }
            // Move selected sprites up a pixel
            else if (HasData && button == btnUp)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).Y--;

                SaveSelectedSprites();
            }
            // Move selected sprites right a pixel
            else if (HasData && button == btnRight)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).X++;

                SaveSelectedSprites();
            }
            // Move selected sprites down a pixel
            else if (HasData && button == btnDown)
            {
                foreach (var sprite in lstSprites.SelectedItems)
                    (sprite as Sprite).Y++;

                SaveSelectedSprites();
            }
            // Display tileset options menu
            else if (HasData && button == btnTilesetOptions)
            {
                mnuTilesetOptions.Show(btnTilesetOptions, new Point(0, btnTilesetOptions.Height));
                return;
            }
            // Swap colors on selected tile
            else if (HasData && button == btnSwapSelectedPixel && HasFrameData)
            {
                if (pnlSelectedTile.SelectedColor == 255)
                {
                    MessageBox.Show("No swap color hs been selected. Select a color from the palette.");
                    return;
                }

                if (pnlSelectedTile.TargetColor == 255)
                {
                    MessageBox.Show("No target color hs been selected. Right click on a tile pixel to select the color to be swapped.");
                    return;
                }

                foreach (var frame in _metaSprite.Frames)
                {
                    frame.Tileset.SwapPixels(pnlSelectedTile.TargetColor, pnlSelectedTile.SelectedColor);
                }

                int tileId = pnlTilesetEdit.TileID;

                App.Project.UpdateAsset(_metaSprite);
                UpdateImages();
                pnlTilesetEdit.TileID = tileId;
                pnlTilesetEdit_TileSelectionChanged();
            }
        }

        // Meta sprite menu click
        private void mnuMetaSprite_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            // Import streamed graphics
            if (menuItem == mnuImportStreamed)
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

                List<Color> importColors = BitmapUtility.GetColors(image, 16);
                if (importColors.Count > 16)
                {
                    MessageBox.Show("The image has more than 16 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportMetaSpriteForm(BitmapUtility.Get32bitImage(image), _metaSprite, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstMetaSprites.Items[lstMetaSprites.SelectedIndex] = App.Project.GetAsset(_metaSprite.ID) as MetaSprite;
                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            // Import tileset graphics
            else if (menuItem == mnuImportTilesetSprite)
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

                List<Color> importColors = BitmapUtility.GetColors(image, 16);
                if (importColors.Count > 16)
                {
                    MessageBox.Show("The image has more than 16 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportSpriteSheetForm(BitmapUtility.Get32bitImage(image), _metaSprite, importColors, false))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstMetaSprites.Items[lstMetaSprites.SelectedIndex] = App.Project.GetAsset(_metaSprite.ID) as MetaSprite;
                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                    pnlMetaSpriteEdit.SelectedSprites.Clear();
                }
            }
            // Update tileset
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

                List<Color> importColors = BitmapUtility.GetColors(image, 16);
                if (importColors.Count > 16)
                {
                    MessageBox.Show("The image has more than 16 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportSpriteSheetForm(BitmapUtility.Get32bitImage(image), _metaSprite, importColors, true))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstMetaSprites.Items[lstMetaSprites.SelectedIndex] = App.Project.GetAsset(_metaSprite.ID) as MetaSprite;
                    lstMetaSprites_SelectedIndexChanged(this, EventArgs.Empty);
                    pnlMetaSpriteEdit.SelectedSprites.Clear();
                }
            }
            // Export tileset as image
            else if (menuItem == mnuTilesetExportImage && HasFrameData)
                ExportTileset(_metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles");
            // Export tileset as binay data
            else if (menuItem == mnuTilesetExportBinary && HasFrameData)
            {
                var minimum = (int)nudTileMinimum.Value;
                var fileName = _metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles";
                ExportData(_metaSprite.GetAllTilesetData(App.GetCompressor(_frame.Tileset.CompressionType, false), minimum), fileName);
            }
            // Export tilesets as multiple binary files
            else if (menuItem == mnuTilesetExportBinaries && HasFrameData)
            {
                var minimum = (int)nudTileMinimum.Value;
                var fileName = _metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles"; ;
                using (MetaSpriteSelectForm form = new MetaSpriteSelectForm())
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    if (form.BinaryMerge)
                    {
                        var bytes = new List<byte>();
                        foreach (var metaSprite in form.MetaSprites)
                            bytes.AddRange(metaSprite.GetAllTilesetData(App.GetCompressor(_frame.Tileset.CompressionType, false), minimum));

                        ExportData(bytes.ToArray(), fileName);
                    }
                    else
                    {
                        ExportBinaries(form.MetaSprites);
                    }
                }
            }
            //else if (menuItem == mnuTilesetExportHex)
            //    Clipboard.SetText(HasFrameData ? _frame.Tileset.GetDataString(true) : "");
            //else if (menuItem == mnuTilesetExportAssembly && HasFrameData)
            //    Clipboard.SetText(_frame.Tileset.GetDataString(true));
            // Export meta sprite as binary file
            else if (HasData && menuItem == mnuMetaSpriteExportBinary)
                ExportData(_metaSprite.GetMetaSpriteFrameData(false));
            //else if (menuItem == mnuMetaSpriteExportBinaryFramed)
            //    ExportData(_metaSprite.GetMetaSpriteData(true, true), _metaSprite.Name.ToLower().Replace(' ', '_') + "_sprites");
            //else if (menuItem == mnuMetaSpriteExportHex)
            //    Clipboard.SetText(_metaSprite.GetASMString(true));
            //else if (menuItem == mnuMetaSpriteExportAssembly)
            //    Clipboard.SetText(_metaSprite.GetASMString(false));
            // Export meta sprite as DevKit SMS binary file
            else if (HasData && menuItem == mnuMetaSpriteExportDKSMSBinary)
                ExportData(_metaSprite.GetMetaSpriteFrameData(true));
            // Export meta sprite as DevKit SMS C code
            else if (HasData && menuItem == mnuMetaSpriteExportDKSMSText)
                Clipboard.SetText(_metaSprite.GetDKSMSString());
            // Add a frame to the meta sprite
            else if (HasData && menuItem == mnuAddFrame)
            {
                // Create new frame, and select it
                _metaSprite.Frames.Add(new MetaSpriteFrame(_metaSprite.Tilesheet.DeepClone()));
                lstSprites.SelectedItems.Clear();
                pnlMetaSpriteEdit.ClearSelected();
                App.Project.UpdateAsset(_metaSprite);
                _frameIndex = _metaSprite.Frames.Count - 1;
                Loading = true;
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            // Move the selected frame to the left
            else if (HasData && menuItem == mnuMoveFrameLeft)
            {
                // Move current frame left
                if (!_metaSprite.MoveFrameLeft(_frame))
                    return;

                App.Project.UpdateAsset(_metaSprite);
                _frameIndex--;
                Loading = true;
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            // Move the selected frame to the right
            else if (HasData && menuItem == mnuMoveFrameRight)
            {
                // Move current frame right
                if (!_metaSprite.MoveFrameRight(_frame))
                    return;

                App.Project.UpdateAsset(_metaSprite);
                _frameIndex++;
                Loading = true;
                LoadUI();
                Loading = false;
                lblCurrentFrameValue.Text = _frameIndex + " / " + (_metaSprite.Frames.Count - 1);
            }
            // Delete the selected frame
            else if (HasFrameData && menuItem == mnuDeleteFrame)
            {
                if (MessageBox.Show("Are you sure you want to delete this frame?", "SMS Tile Studio", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                // Remove frame
                _metaSprite.Frames.Remove(_frame);
                UpdateMetaSprite();
            }
            // Remove selected tile
            else if (HasFrameData && menuItem == mnuRemoveTile)
            {
                int tileID = pnlTilesetEdit.TileID;
                pnlTilesetEdit.RemoveSelection();
                _frame.Tileset.Pixels = pnlTilesetEdit.Pixels.DeepClone();
                UpdateMetaSprite();
                UpdateImages();
                pnlSelectedTile.Clear();
            }
            // Add new tile to front of tileset
            else if (HasFrameData && menuItem == mnuAddTile)
            {
                _frame.Tileset.AddEmptyTile();
                UpdateMetaSprite();
                UpdateImages();
            }
            // Copy selected tile from tileset
            else if (HasFrameData && menuItem == mnuTilesetCopyTile)
            {
                if (pnlTilesetEdit.TileID < 0)
                    return;

                _tileCopy = _frame.Tileset.GetTilePixels(pnlTilesetEdit.TileID);
                UpdateMetaSprite();
                UpdateImages();
            }
            // Paste tile from tile copy at the selected tile id
            else if (HasFrameData && menuItem == mnuTilesetPasteTile)
            {
                if (_tileCopy == null || pnlTilesetEdit.TileID < 0)
                    return;

                _frame.Tileset.SetTilePixels(pnlTilesetEdit.TileID, _tileCopy);
                UpdateMetaSprite();
                UpdateImages();
            }
            // Deselects tile from tileset editor
            else if (HasFrameData && menuItem == mnuDeselectTile)
            {
                pnlTilesetEdit.ClearSelection();
                pnlSelectedTile.Clear();
            }
        }

        // Meta sprite name changed
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!HasData || Loading || lstMetaSprites.SelectedItem == null || e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            _metaSprite.Name = txtName.Text;
            UpdateMetaSprite();
        }

        // Meta sprite name changed
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstMetaSprites.SelectedItem == null)
                return;

            _metaSprite.Name = txtName.Text;
            UpdateMetaSprite();
        }

        // Meta sprite checkbox checked changed
        private void chkMetaSprite_CheckedChanged(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is CheckBox checkBox))
                return;

            // Toggle meta sprite type, streamed or tileset
            if (HasData && checkBox == chkMetaSpriteType)
            {
                _metaSprite.MetaSpriteType = chkMetaSpriteType.Checked ? MetaSpriteType.Tileset : MetaSpriteType.Streamed;
                UpdateMetaSprite();
            }
            // Toggle showing selected sprite rects
            else if (checkBox == chkSprites)
                pnlMetaSpriteEdit.ShowSprites = chkSprites.Checked;
            // Toggle showing the grid
            else if (checkBox == chkGrid)
            {
                pnlMetaSpriteEdit.UseGrid = chkGrid.Checked;
                pnlTiles.UseGrid = chkGrid.Checked;
            }
            // Toggle showing the sprite origin
            else if (checkBox == chkShowOrigin)
                pnlMetaSpriteEdit.ShowOrigin = chkShowOrigin.Checked;
            // Toggle showing the transparent color
            else if (checkBox == chkTransparent)
                pnlMetaSpriteEdit.ShowTransparent = chkTransparent.Checked;
            // Toggle snapping sprites to grid
            else if (checkBox == chkGridSnap)
                pnlMetaSpriteEdit.SnapToGrid = chkGridSnap.Checked;
            else if (checkBox == chkMetaSpriteInvertGrids)
            {
                pnlMetaSpriteEdit.InvertGridColor = chkMetaSpriteInvertGrids.Checked;
                pnlTilesetEdit.InvertGridColor= chkMetaSpriteInvertGrids.Checked;
            }
            // Toggle sprite type, normal or tall
            else if (HasData && checkBox == chkSpriteType)
            {
                _metaSprite.SpriteMode = chkSpriteType.Checked ? SpriteModeType.Normal : SpriteModeType.Tall;
                UpdateMetaSprite();
            }
            // Toggle tileset edit grid
            else if (checkBox == chkTilesetGrid)
                pnlTilesetEdit.UseGrid = chkTilesetGrid.Checked;
            // Toggle tileset edit tile ids
            else if (checkBox == chkTilesetShowTileIds)
                pnlTilesetEdit.Indexed = chkTilesetShowTileIds.Checked;
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
            else if (numeric == nudSpriteX && lstSprites.SelectedItem != null)
            {
                (lstSprites.SelectedItem as Sprite).X = (int)nudSpriteX.Value;
                App.Project.UpdateAsset(_metaSprite);
                UpdateImages();
                lstSprites_SelectedIndexChanged(this, EventArgs.Empty);
                return;
            }
            else if (numeric == nudSpriteY && lstSprites.SelectedItem != null)
            {
                (lstSprites.SelectedItem as Sprite).Y = (int)nudSpriteY.Value;
                App.Project.UpdateAsset(_metaSprite);
                UpdateImages();
                lstSprites_SelectedIndexChanged(this, EventArgs.Empty);
                return;
            }
            else if (numeric == nudSpriteTileID && lstSprites.SelectedItem != null)
            {
                (lstSprites.SelectedItem as Sprite).TileID = (int)nudSpriteTileID.Value;
                App.Project.UpdateAsset(_metaSprite);
                UpdateImages();
                lstSprites_SelectedIndexChanged(this, EventArgs.Empty);
                return;
            }
            UpdateMetaSprite();
        }

        // Meta sprite combobox selection changed
        private void cbMetaSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If combobox is sender
            if (!(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            //// Perform action based on control
            //if (comboBox == cbSpriteMode && HasData)
            //    _metaSprite.SpriteMode = (SpriteModeType)cbSpriteMode.SelectedItem;
            if (comboBox == cbSprPalette && HasData)
                _metaSprite.PaletteID = (cbSprPalette.SelectedItem as Palette).ID;
            else if (comboBox == cbTilesetCompression && HasFrameData)
            {
                foreach (var frame in _metaSprite.Frames)
                    frame.Tileset.CompressionType = (string)cbTilesetCompression.SelectedItem.GetType().GetProperty("value").GetValue(cbTilesetCompression.SelectedItem, null);
            }
            //else if (comboBox == cbSprPalette)
            //{
            //    var palette = comboBox.SelectedItem as Palette;
            //    pnlSprPalette.SetPalette((comboBox.SelectedItem as Palette).Colors);
            //    LoadUI();
            //    return;
            //}

            UpdateMetaSprite();
        }

        // Sprite list selected changed
        private void lstSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasData || lstSprites.SelectedItem == null)
                return;

            Loading = true;
            pnlMetaSpriteEdit.SelectedSprites = GetSelectedSprites();
            _sprite = (lstSprites.SelectedItem as Sprite);
            if (_sprite == null)
            {
                Loading = false;
                return;
            }
            nudSpriteX.Value = _sprite.X;
            nudSpriteY.Value = _sprite.Y;
            nudSpriteTileID.Value = _sprite.TileID;
            Loading = false;
        }

        // Sprite edit changed
        private void pnlMetaSpriteEdit_MetaSpriteChanged()
        {
            if (lstSprites.SelectedItem == null)
                return;
            Loading = true;
            lstSprites.ClearSelected();
            SetSelectedSprites(pnlMetaSpriteEdit.SelectedSprites);
            _sprite = (lstSprites.SelectedItem as Sprite);
            if (_sprite == null)
            {
                Loading = false;
                return;
            }
            nudSpriteX.Value = _sprite.X;
            nudSpriteY.Value = _sprite.Y;
            nudSpriteTileID.Value = _sprite.TileID;
            Loading = false;
        }


        // Collision list selected changed
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


        // Tile palette tile selection changed
        private void pnlTiles_TileSelectionChanged()
        {
            pnlMetaSpriteEdit.TileID = pnlTiles.TileID;
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

            if (_metaSprite.MetaSpriteType == MetaSpriteType.Tileset)
                _metaSprite.Tilesheet.SetTilePixels(pnlSelectedTile.SelectedTileID, pnlSelectedTile.Pixels);
            else
                _frame.Tileset.SetTilePixels(pnlSelectedTile.SelectedTileID, pnlSelectedTile.Pixels);

            pnlSelectedTile.Image = BitmapUtility.GetPixelTileImage(pnlSelectedTile.Pixels, pnlSelectedTile.Palette, pnlSelectedTile.ClientSize);
            App.Project.UpdateAsset(_metaSprite);
            UpdateImages();
        }

        // Sprite editor sprite added
        private void pnlMetaSpriteEdit_MetaSpriteAdded(int x, int y, int tileId)
        {
            if (!HasData || _frame == null)
                return;

            var sprite = new Sprite(tileId, x, y);
            _frame.Sprites.Add(sprite);
            App.Project.UpdateAsset(_metaSprite);
            lstSprites.Items.Clear();
            lstSprites.Items.AddRange(_frame.Sprites.ToArray());
            lstSprites.SelectedItem = sprite;
        }

        // Spreit editor remove sprite
        private void pnlMetaSpriteEdit_SpriteRemoved(Sprite sprite)
        {
            _frame.Sprites.Remove(sprite);
            App.Project.UpdateAsset(_metaSprite);
            lstSprites.Items.Remove(sprite);
        }

        // Sprite editor position changed
        private void pnlMetaSpriteEdit_PositionChanged()
        {
            lblPosition.Text = pnlMetaSpriteEdit.GetPositionInformation();
        }

        // Sprite editor mouse enter
        private void pnlMetaSpriteEdit_MouseEnter(object sender, EventArgs e)
        {
            pnlMetaSpriteEdit.Focus();
        }

        /// <summary>
        /// Sets selected sprites for editing
        /// </summary>
        private void SaveSelectedSprites()
        {
            _sprites.Clear();
            for (int i = 0; i < lstSprites.Items.Count; i++)
            {
                if (lstSprites.GetSelected(i))
                    _sprites.Add(i);
            }
            var sprites = GetSelectedSprites();
            Updating = true;
            App.Project.UpdateAsset(_metaSprite);
            lstSprites.Items.Clear();
            lstSprites.Items.AddRange(_frame.Sprites.ToArray());
            SetSelectedSprites(sprites);
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
        /// Sets selected sprites for editing
        /// </summary>
        private void SetSelectedSprites(List<Sprite> selected)
        {
            for (int i = 0; i < lstSprites.Items.Count; i++)
            {
                if (selected.Contains(lstSprites.Items[i] as Sprite))
                    lstSprites.SetSelected(i, true);
            }
        }

        /// <summary>
        /// Exports a tileset image
        /// </summary>
        private void ExportTileset(string filename)
        {
            if (!HasData || !HasFrameData)
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
                        if (_metaSprite.MetaSpriteType == MetaSpriteType.Tileset)
                            pnlTilesetEdit.Image.Save(dialog.FileName, ImageFormat.Png);
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
        public void ExportData(List<byte[]> data)
        {
            if (!HasData || data == null)
                return;

            int index = 0;
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Binary Data: " + _metaSprite.Name;
                dialog.Filter = "Binary File|*.bin";
                dialog.FileName = _metaSprite.Name.ToLower().Replace(' ', '_');
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                // Iterate through each frame and save meta sprite frame
                foreach (var frame in data)
                {
                    var filename = dialog.FileName.Insert(dialog.FileName.LastIndexOf('.'), "_" + index.ToString("D2"));
                    using (FileStream fs = new FileStream(filename, FileMode.Create))
                    {
                        using (BinaryWriter bw = new BinaryWriter(fs))
                        {
                            bw.Write(frame);
                        }
                    }
                    index++;
                }
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
                        var minimum = (int)nudTileMinimum.Value;
                        var filename = metaSprite.Name.ToLower().Replace(' ', '_') + "_tiles.bin";
                        try
                        {
                            var data = metaSprite.GetAllTilesetData(App.GetCompressor(_frame.Tileset.CompressionType, false), minimum);
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
            cbSprPalette.Items.AddRange(App.Project.GetPaletteArray());

            //cbSprPalette.Items.Clear();
            //foreach (var asset in App.Project.Palettes)
            //    cbSprPalette.Items.Add(asset);

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
            txtName.Text = _metaSprite == null ? string.Empty : _metaSprite.Name;
            cbSprPalette.SelectedItem = (Palette)App.Project.GetAsset(_metaSprite == null ? -2 : _metaSprite.PaletteID);
            pnlSprPalette.SetPalette(cbSprPalette.SelectedItem == null ? null : (cbSprPalette.SelectedItem as Palette).Colors);
            _selectedPalette = cbSprPalette.SelectedItem as Palette;
            lblEmpty.Text = _metaSprite == null ? "No Meta Sprite information" : _metaSprite.GetInfo(_frameIndex);
            chkSpriteType.Text = "Sprite Size: " + (_metaSprite == null ? "N/A" : _metaSprite.SpriteMode.GetDescription());
            chkSpriteType.Checked = _metaSprite == null ? true : _metaSprite.SpriteMode == SpriteModeType.Normal;
            chkMetaSpriteType.Text = "Sprite Type: " + (_metaSprite == null ? "N/A" : _metaSprite.MetaSpriteType.GetDescription());
            chkMetaSpriteType.Checked = _metaSprite == null ? true : _metaSprite.MetaSpriteType == MetaSpriteType.Tileset;
            pnlMetaSpriteEdit.LoadFrame(_frame, _selectedPalette, _metaSprite == null ? SpriteModeType.Normal : _metaSprite.SpriteMode);
            cbTilesetCompression.SelectedItem = !HasFrameData ? "None" : _frame.Tileset.CompressionType;
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
            pnlTilesetEdit.Image = BitmapUtility.GetTilesetImage(_frame.Tileset, _selectedPalette, 16);
            pnlTilesetEdit.SetTileset(_frame.Tileset, _selectedPalette.Colors);
            pnlTiles.Image = BitmapUtility.GetTilesetImage(_frame.Tileset, _selectedPalette, 6);
            pnlTiles.TileCount = _frame.Tileset.TileCount;
            lblEmpty.Text = _metaSprite.GetInfo(_frameIndex);
            pnlMetaSpriteEdit.TileID = pnlTiles.TileID;
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
            lblEmpty.Text = _metaSprite == null ? "No Meta Sprite information" : _metaSprite.GetInfo(_frameIndex);
            LoadUI();
            Loading = false;
        }

        public void HandleInput(Keys keyData)
        {
            if (ActiveControl is TextBox)
                return;

            // Do action based on key
            switch (keyData)
            {
                case Keys.S:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkSprites.Checked = !chkSprites.Checked;
                    break;
                case Keys.R:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkCollisions.Checked = !chkCollisions.Checked;
                    break;
                case Keys.O:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkShowOrigin.Checked = !chkShowOrigin.Checked;
                    break;
                case Keys.T:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkTransparent.Checked = !chkTransparent.Checked;
                    break;
                case Keys.G:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkGrid.Checked = !chkGrid.Checked;
                    break;
                case Keys.N:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        chkGridSnap.Checked = !chkGridSnap.Checked;
                    break;
                case Keys.Up:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        btnMetaSprite_Click(btnUp, EventArgs.Empty);
                    break;
                case Keys.Down:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        btnMetaSprite_Click(btnDown, EventArgs.Empty);
                    break;
                case Keys.Left:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        btnMetaSprite_Click(btnLeft, EventArgs.Empty);
                    break;
                case Keys.Right:
                    if (tabMain.SelectedTab == tabSpriteEdit)
                        btnMetaSprite_Click(btnRight, EventArgs.Empty);
                    break;
            }
        }
    }
}
