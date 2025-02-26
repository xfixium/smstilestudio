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
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;

using SMSTileStudio.Data;

namespace SMSTileStudio.Forms
{
    public partial class ImportMetaSpriteForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Tilemap _tilemap = new Tilemap();
        private MetaSprite _sprite = null;
        private Bitmap _image = null;
        private Palette _sprPalette = null;
        private List<PixelTile> _originalPixelTiles = new List<PixelTile>();
        private List<PixelTile> _pixelTiles = new List<PixelTile>();
        private List<Color> _importColors = new List<Color>();
        private int _frameIndex = -1;
        //private bool _initalizing = true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sprite"></param>
        /// <param name="importColors"></param>
        public ImportMetaSpriteForm(Bitmap image, MetaSprite sprite, List<Color> importColors)
        {
            InitializeComponent();

            Text = "Import Graphics for " + sprite.Name;
            _sprite = sprite.DeepClone();
            _sprite.Frames.Clear();
            _image = image;
            _sprPalette = (Palette)App.Project.GetAsset(sprite.PaletteID);
            _importColors = importColors;
            //_initalizing = true;
            LoadData();
            LoadUI();
            GetTiles();
            //_initalizing = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void nudMetaSprite_ValueChanged(object sender, EventArgs e)
        {
            if (!(sender is NumericUpDown numeric) || _sprite == null)
                return;
        }

        /// <summary>
        /// Sprite button click
        /// </summary>
        private void btnMetaSprite_Click(object sender, EventArgs e)
        {
            if (!(sender is Button button) || _sprite == null)
                return;

            if (button == btnAddFrame)
            {
                _sprite.Frames.Add(new MetaSpriteFrame(pnlMetaSpriteSelect.Selection, GetSpriteFrameTileset()));
                _frameIndex = _sprite.Frames.Count - 1;
            }
            else if (button == btnInsertFrame)
                _sprite.Frames.Insert(_frameIndex, new MetaSpriteFrame(pnlMetaSpriteSelect.Selection, GetSpriteFrameTileset()));
            else if (button == btnSetFrame && _frameIndex > -1)
                _sprite.Frames[_frameIndex] = new MetaSpriteFrame(pnlMetaSpriteSelect.Selection, GetSpriteFrameTileset());
            else if (button == btnRemoveFrame && _frameIndex > -1)
            {
                _sprite.Frames.RemoveAt(_frameIndex);
                _frameIndex--;
            }
            else if (button == btnMoveFrameUp && _frameIndex > -1)
            {
                int oldindex = _frameIndex;
                int newIndex = _frameIndex - 1;
                var item = _sprite.Frames[oldindex].DeepClone();
                _sprite.Frames.RemoveAt(oldindex);
                _sprite.Frames.Insert(newIndex, item);
                _frameIndex = newIndex;
            }
            else if (button == btnMoveFrameDown && _frameIndex > -1)
            {
                int oldindex = _frameIndex;
                int newIndex = _frameIndex + 1;
                var item = _sprite.Frames[oldindex].DeepClone();
                _sprite.Frames.RemoveAt(oldindex);
                _sprite.Frames.Insert(newIndex, item);
                _frameIndex = newIndex;
            }

            pnlMetaSpriteSelect.ClearSelection();
            LoadUI();
            UpdateImage();
        }

        /// <summary>
        /// Sprite sselection changed
        /// </summary>
        private void cbMetaSprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            if (comboBox == cbSprPalette)
            {
                _sprPalette = cbSprPalette.SelectedItem as Palette;
                _sprite.PaletteID = _sprPalette.ID;
                SetPalettes();
            }
            else if (comboBox == cbSpriteMode && _sprite != null)
            {
                _sprite.Frames.Clear();
                _sprite.SpriteMode = (SpriteModeType)cbSpriteMode.SelectedItem.GetValue();
                pnlMetaSpriteSelect.SpriteModeType = (SpriteModeType)cbSpriteMode.SelectedItem.GetValue();
                _frameIndex = -1;
                LoadUI();
                UpdateImage();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void lstFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            _frameIndex = lstFrames.SelectedIndex;
            UpdateImage();
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            App.Project.UpdateAsset(_sprite.DeepClone());
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cancel button click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        private void pnlPalette_ColorShifted()
        {
            UpdateTiles(pnlPalette.SPRImport, pnlPalette.SPRPalette);
            UpdateImage();
        }

        /// <summary>
        /// 
        /// </summary>
        private void pnlPalette_SelectedColorChanged()
        {
            UpdateTiles(pnlPalette.SPRImport, pnlPalette.SPRPalette);
            UpdateImage();
        }

        /// <summary>
        /// Sets tilesets and related controls
        /// </summary>
        private void GetTiles()
        {
            try
            {
                _originalPixelTiles = BitmapUtility.GetPixelTiles(_image, pnlPalette.SPRPalette[0], true, false, FlipType.None);
                _pixelTiles = _originalPixelTiles.DeepClone();
                _tilemap.Columns = _image.Width / 8;
                _tilemap.Rows = _image.Height / 8;
                _tilemap.Tiles = BitmapUtility.GetTilesFromImage(_originalPixelTiles, _image, 0, FlipType.None);
                SetPalettes();
                UpdateImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue importing the image. Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Sets the palettes to the imported colors, tries to match them initially
        /// </summary>
        private void SetPalettes()
        {
            pnlSprPalette.SetPalette(_sprPalette.Colors);
            pnlPalette.SetPalette(_importColors, _sprPalette.Colors);
            UpdateImage();
        }

        /// <summary>
        /// Update tiles with palette changes
        /// </summary>
        /// <param name="sprImport"></param>
        /// <param name="sprPalette"></param>
        public void UpdateTiles(List<Color> sprImport, List<Color> sprPalette)
        {
            List<PixelTile> temp = new List<PixelTile>(_originalPixelTiles.DeepClone());
            foreach (PixelTile pixelTile in temp)
            {
                for (int j = 0; j < pixelTile.Pixels.Count; j++)
                {
                    bool match = false;
                    for (int i = 0; i < sprImport.Count; i++)
                    {
                        if (pixelTile.Pixels[j] == sprImport[i].ToArgb())
                        {
                            pixelTile.Pixels[j] = sprPalette[i].ToArgb();
                            match = true;
                            break;
                        }
                    }
                    if (!match)
                        pixelTile.Pixels[j] = sprPalette[0].ToArgb();
                }
            }

            _pixelTiles = temp;
        }

        /// <summary>
        /// Update image
        /// </summary>
        private void UpdateImage()
        {
            var tileset = new Tileset();
            tileset.Pixels = BitmapUtility.PixelTilesToSMSTiles(_pixelTiles, pnlPalette.SPRPalette, pnlPalette.SPRPalette);
            pnlMetaSpriteSelect.Image = BitmapUtility.GetTileImage(tileset, _tilemap, pnlPalette.SPRPalette, pnlPalette.SPRPalette);
            if (lstFrames.SelectedItem != null)
            {
                var bounds = (lstFrames.SelectedItem as MetaSpriteFrame).Bounds;
                pnlCurrentFrame.Image = pnlMetaSpriteSelect.Image.Clone(bounds, pnlMetaSpriteSelect.Image.PixelFormat);
                var sprites = BitmapUtility.GetSpritesFromBitmap(pnlCurrentFrame.Image, GetSpriteModeType(), pnlPalette.SPRPalette[0], chkAllowEmptySprites.Checked);
                pnlMetaSpriteSelect.SetSprites(sprites, bounds.Location);
                _sprite.Frames[_frameIndex].Sprites = sprites;
                lblSpriteCount.Text = "Frame Sprite Count: " + sprites.Count + " | Total Sprite Count: " + GetSpriteCount();
                lblCurrentFrame.Text = _sprite == null || _sprite.Frames.Count <= 0 ? "No Frames" : "Frame " + (_frameIndex < 0 ? "0" : (_frameIndex + 1) + " of " + _sprite.Frames.Count);
            }
            else
                pnlCurrentFrame.Image = null;
        }

        /// <summary>
        /// Gets the tileset for the selected sprite frame
        /// </summary>
        /// <returns></returns>
        private Tileset GetSpriteFrameTileset()
        {
            var bounds = pnlMetaSpriteSelect.Selection;
            using (var image = pnlMetaSpriteSelect.Image.Clone(bounds, pnlMetaSpriteSelect.Image.PixelFormat))
            {
                return BitmapUtility.GetTilesetFromSprites(image, GetSpriteModeType(), pnlPalette.SPRPalette[0], pnlPalette.SPRPalette, chkAllowEmptySprites.Checked);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private SpriteModeType GetSpriteModeType()
        {
            return cbSpriteMode.SelectedItem == null ? SpriteModeType.Normal : (SpriteModeType)cbSpriteMode.SelectedItem.GetValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetSpriteCount()
        {
            if (_sprite == null)
                return 0;

            var total = 0;
            foreach (var frame in _sprite.Frames)
                total += frame.Sprites.Count;

            return total;
        }

        /// <summary>
        /// Get game asset item based on given id, for the given combobox
        /// </summary>
        /// <param name="id">The id to search for</param>
        /// <param name="ctrl">The combobox to search</param>
        /// <returns>A game asset, if found, null if not</returns>
        public object ItemByID(int id, ComboBox ctrl)
        {
            foreach (object item in ctrl.Items)
                if ((item as GameAsset).ID == id)
                    return item as GameAsset;

            return null;
        }

        /// <summary>
        /// Loads list data
        /// </summary>
        private void LoadData()
        {
            cbSprPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes.OrderBy(x => x.Name).ToArray())
                cbSprPalette.Items.Add(asset);

            cbSpriteMode.Items.Clear();
            cbSpriteMode.ValueMember = "Value";
            cbSpriteMode.DisplayMember = "Description";
            cbSpriteMode.DataSource = EnumMethods.GetEnumCollection(typeof(SpriteModeType));
            if (cbSpriteMode.Items.Count > 0)
                cbSpriteMode.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadUI()
        {
            cbSprPalette.SelectedItem = ItemByID(_sprPalette.ID, cbSprPalette);
            lblCurrentFrame.Text = _sprite == null || _sprite.Frames.Count <= 0 ? "No Frames" : "Frame " + (_frameIndex < 0 ? "0" : _frameIndex + " of " + _sprite.Frames.Count);
            lstFrames.Items.Clear();
            if (_sprite == null)
                return;

            var index = 0;
            foreach (var frame in _sprite.Frames)
            {
                lstFrames.Items.Add(frame);
                index++;
            }

            if (_frameIndex > -1 && _frameIndex < lstFrames.Items.Count)
                lstFrames.SelectedIndex = _frameIndex;
        }
    }
}
