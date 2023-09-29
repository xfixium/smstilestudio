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
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Forms
{
    public partial class TilemapSelectForm : Form
    {
        public List<Tilemap> Tilemaps { get { return lstSelectedTilemaps.CheckedItems.Cast<Tilemap>().ToList(); } }
        public TilemapSelectForm()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// Selected tilemap changed
        /// </summary>
        private void lstSelectedTilemaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedTilemaps.Text = "Selected Tilemaps: " + lstSelectedTilemaps.CheckedItems.Count;
            if (lstSelectedTilemaps.SelectedItem == null)
                return;

            var tilemap = lstSelectedTilemaps.SelectedItem as Tilemap;
            var bgPalette = App.Project.GetAsset(tilemap.BgPaletteID) as Palette;
            var sprPalette = App.Project.GetAsset(tilemap.SprPaletteID) as Palette;
            pnlTilemap.Image = BitmapUtility.GetTileImage(tilemap.Tileset, tilemap, bgPalette, sprPalette);
            pnlTileset.Image = BitmapUtility.GetTilesetImage(tilemap.Tileset, bgPalette, 16);
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
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
        /// Loads data to UI
        /// </summary>
        private void LoadData()
        {
            lstSelectedTilemaps.Items.Clear();
            lstSelectedTilemaps.Items.AddRange(App.Project.Tilemaps.Where(x => x.ID >= 0).OrderBy(x => x.Name).ToArray());
        }
    }
}
