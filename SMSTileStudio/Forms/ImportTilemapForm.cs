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
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Forms
{
    public partial class ImportTilemapForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Tilemap _tilemap = null;
        private Bitmap _image = null;
        private Palette _bgPalette = null;
        private Palette _sprPalette = null;
        private List<Color> _importColors = new List<Color>();
        private bool _initalizing = true;
        private FlipType _flipType = FlipType.None;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">The image to convert to a tilemap</param>
        /// <param name="tilemap">The tilemap to apply data to</param>
        /// <param name="importColors"></param>
        public ImportTilemapForm(Bitmap image, Tilemap tilemap, List<Color> importColors)
        {
            InitializeComponent();

            Text = "Import Graphics for " + tilemap.Name;
            _tilemap = tilemap.DeepClone();
            _image = image;
            _bgPalette = (Palette)App.Project.GetAsset(tilemap.BgPaletteID);
            _sprPalette = (Palette)App.Project.GetAsset(tilemap.SprPaletteID);
            _importColors = importColors;
            LoadData();
            LoadUI();
            GetTiles();
            _initalizing = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image"></param>
        /// <param name="assetName"></param>*
        /// <param name="bgPaletteID"></param>
        /// <param name="sprPaletteID"></param>
        /// <param name="importColors"></param>
        public ImportTilemapForm(Bitmap image, string assetName, int bgPaletteID, int sprPaletteID, List<Color> importColors)
        {
            InitializeComponent();

            Text = "Import Graphics for " + assetName;
            _tilemap = new Tilemap();
            _image = image;
            _bgPalette = (Palette)App.Project.GetAsset(bgPaletteID);
            _sprPalette = (Palette)App.Project.GetAsset(sprPaletteID);
            _importColors = importColors;
            LoadData();
            LoadUI();
            GetTiles();
            _initalizing = false;
        }

        /// <summary>
        /// Tilemap button click
        /// </summary>
        private void btnTilemap_Click(object sender, EventArgs e)
        {
            if (!(sender is Button button))
                return;

            if (button == btnSetAllBGPalette || button == btnSetAllSPRPalette)
                pnlTileset.SetPaletteAll(button == btnSetAllBGPalette);
        }

        /// <summary>
        /// Tilemap sselection changed
        /// </summary>
        private void cbTilemap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            if (comboBox == cbBGPalette)
            {
                _bgPalette = cbBGPalette.SelectedItem as Palette;
                SetPalettes();
            }
            else if (comboBox == cbSPRPalette)
            {
                _sprPalette = cbSPRPalette.SelectedItem as Palette;
                SetPalettes();
            }
            else if (comboBox == cbFlipOptions && cbFlipOptions.SelectedItem != null)
            {
                _flipType = (FlipType)cbFlipOptions.SelectedItem.GetType().GetProperty("value").GetValue(cbFlipOptions.SelectedItem, null);
                if (!_initalizing)
                    GetTiles();
            }
        }

        /// <summary>
        /// Tilemap check changed
        /// </summary>
        private void chkTilemap_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox checkBox))
                return;

            if (checkBox == chkShowIndexes)
            {
                pnlTileset.Indexed = chkShowIndexes.Checked;
                pnlImage.Indexed = chkShowIndexes.Checked;
            }
            else if (checkBox == chkAllowDuplicates)
            {
                if (!_initalizing)
                    GetTiles();
            }
            else if (checkBox == chkIgnoreEmpty)
            {
                if (!_initalizing)
                    GetTiles();
            }
        }

        /// <summary>
        /// Palette selected color changed
        /// </summary>
        private void pnlPalettes_SelectedColorChanged()
        {
            pnlTileset.UpdateTiles(pnlPalettes.BGImport, pnlPalettes.SPRImport, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
            UpdateImage();
        }

        /// <summary>
        /// Palette color shifted
        /// </summary>
        private void pnlPalettes_ColorShifted()
        {
            pnlTileset.UpdateTiles(pnlPalettes.BGImport, pnlPalettes.SPRImport, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
            UpdateImage();
        }

        /// <summary>
        /// Image selected tile index changed
        /// </summary>
        private void pnlImage_SelectedIndexChanged()
        {
            pnlTileset.SetSelectedIndex(pnlImage.SelectedIndex);
        }

        /// <summary>
        /// Tileset selected tile index changed
        /// </summary>
        private void pnlTileset_SelectedIndexChanged()
        {
            UpdateImage();
            pnlImage.SelectedIndex = pnlTileset.SelectedIndex;
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            var pixelTiles = pnlTileset.GetPixelTiles(false);
            _tilemap.Columns = _image.Width / 8;
            _tilemap.Rows = _image.Height / 8;

            foreach (Tile tile in _tilemap.Tiles)
                for (int i = 0; i < pixelTiles.Count; i++)
                    if (tile.TileID == i)
                        tile.UseBGPalette = pixelTiles[i].UseBGPalette;

            _tilemap.BgPaletteID = _bgPalette.ID;
            _tilemap.SprPaletteID = _sprPalette.ID;
            _tilemap.Tileset = new Tileset();
            _tilemap.Tileset.Pixels = BitmapUtility.PixelTilesToSMSTiles(pixelTiles, _bgPalette.Colors, _sprPalette.Colors);
            App.Project.UpdateAsset(_tilemap.DeepClone());
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
        /// Sets the palettes to the imported colors, tries to match them initially
        /// </summary>
        private void SetPalettes()
        {
            pnlBGPalette.SetPalette(_bgPalette.Colors);
            pnlSPRPalette.SetPalette(_sprPalette.Colors);
            pnlPalettes.SetPalette(_importColors, _bgPalette.Colors, _sprPalette.Colors);
            pnlTileset.UpdateTiles(pnlPalettes.BGImport, pnlPalettes.SPRImport, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
            UpdateImage();
        }

        /// <summary>
        /// Sets tilesets and related controls
        /// </summary>
        private void GetTiles()
        {
            try
            {
                pnlTileset.Clear();
                List<PixelTile> pixelTiles = BitmapUtility.GetPixelTiles(_image, _importColors[0], chkAllowDuplicates.Checked, chkIgnoreEmpty.Checked, _flipType);
                _tilemap.Columns = _image.Width / 8;
                _tilemap.Rows = _image.Height / 8;
                _tilemap.Tiles = BitmapUtility.GetTilesFromImage(pixelTiles, _image, 0, _flipType);
                pnlImage.SetTiles(_tilemap.Tiles, _tilemap.Columns, _tilemap.Rows);
                pnlTileset.SetPixelTiles(pixelTiles);
                SetPalettes();
                lblTileCount.Text = "Tile Count: " + pnlTileset.TileCount;
                UpdateImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue importing the image. Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Update image
        /// </summary>
        private void UpdateImage()
        {
            var pixelTiles = pnlTileset.GetPixelTiles(false);
            var tileset = new Tileset();
            tileset.Pixels = BitmapUtility.PixelTilesToSMSTiles(pixelTiles, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
            var tilemap = new Tilemap();
            tilemap = _tilemap.DeepClone();

            foreach (Tile tile in tilemap.Tiles)
                for (int i = 0; i < pixelTiles.Count; i++)
                    if (tile.TileID == i)
                        tile.UseBGPalette = pixelTiles[i].UseBGPalette;

            pnlImage.SetTiles(tilemap.Tiles, tilemap.Columns, tilemap.Rows);
            pnlImage.Image = BitmapUtility.GetTileImage(tileset, tilemap, pnlPalettes.BGPalette, pnlPalettes.SPRPalette);
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
            cbBGPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes.OrderBy(x => x.Name).ToArray())
                cbBGPalette.Items.Add(asset);

            cbSPRPalette.Items.Clear();
            foreach (var asset in App.Project.Palettes.OrderBy(x => x.Name).ToArray())
                cbSPRPalette.Items.Add(asset);

            cbFlipOptions.Items.Clear();
            cbFlipOptions.ValueMember = "Value";
            cbFlipOptions.DisplayMember = "Description";
            cbFlipOptions.DataSource = EnumMethods.GetEnumCollection(typeof(FlipType));
            if (cbFlipOptions.Items.Count > 0)
                cbFlipOptions.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadUI()
        {
            cbBGPalette.SelectedItem = ItemByID(_bgPalette.ID, cbBGPalette);
            cbSPRPalette.SelectedItem = ItemByID(_sprPalette.ID, cbSPRPalette);
        }
    }
}
