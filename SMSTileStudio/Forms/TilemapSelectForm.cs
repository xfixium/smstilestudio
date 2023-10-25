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
        public bool ImageMerge { get { return chkImageMerge.Checked; } }
        public int ImageMergeColumnCount { get { return (int)nudImageMerge.Value; } }

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="showImageMergeOption">If showing the image merge option</param>
        public TilemapSelectForm(bool showImageMergeOption)
        {
            InitializeComponent();
            LoadData();

            if (!showImageMergeOption)
                tpnlMain.RowStyles[2].Height = 0;
        }

        /// <summary>
        /// Apply filter button click
        /// </summary>
        private void btnFilterByName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSelectedTilemaps.Items.Count; i++)
            {
                if (lstSelectedTilemaps.GetItemChecked(i) == true)
                    continue;

                lstSelectedTilemaps.SetItemChecked(i, lstSelectedTilemaps.Items[i].ToString().Contains(txtFilter.Text));
            }
            UpdateInfo();
        }

        /// <summary>
        /// Apply filter button click
        /// </summary>
        private void btnFilterByTag_Click(object sender, EventArgs e)
        {
            var tag = cbTags.SelectedItem.ToString();
            for (int i = 0; i < lstSelectedTilemaps.Items.Count; i++)
            {
                if (lstSelectedTilemaps.GetItemChecked(i) == true)
                    continue;

                lstSelectedTilemaps.SetItemChecked(i, (lstSelectedTilemaps.Items[i] as Tilemap).Tags.Contains(tag));
            }
            UpdateInfo();
        }

        /// <summary>
        /// Selected tilemap changed
        /// </summary>
        private void lstSelectedTilemaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
            if (lstSelectedTilemaps.SelectedItem == null)
                return;

            var tilemap = lstSelectedTilemaps.SelectedItem as Tilemap;
            var bgPalette = App.Project.GetAsset(tilemap.BgPaletteID) as Palette;
            var sprPalette = App.Project.GetAsset(tilemap.SprPaletteID) as Palette;
            pnlTilemap.Image = BitmapUtility.GetTileImage(tilemap.Tileset, tilemap, bgPalette, sprPalette);
            pnlTileset.Image = BitmapUtility.GetTilesetImage(tilemap.Tileset, bgPalette, 16);
        }

        /// <summary>
        /// List item check changed
        /// </summary>
        private void lstSelectedTilemaps_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => UpdateInfo()));
        }

        /// <summary>
        /// Check/Uncheck All check changed
        /// </summary>
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSelectedTilemaps.Items.Count; i++)
            {
                lstSelectedTilemaps.SetItemChecked(i, chkAll.Checked);
            }
            UpdateInfo();
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
        /// Update information on how many have been selected
        /// </summary>
        private void UpdateInfo()
        {
            lblSelectedTilemaps.Text = "Selected Tilemaps: " + lstSelectedTilemaps.CheckedItems.Count;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        private void LoadData()
        {
            lstSelectedTilemaps.Items.Clear();
            lstSelectedTilemaps.Items.AddRange(App.Project.Tilemaps.Where(x => x.ID >= 0).OrderBy(x => x.Name).ToArray());
            var tags = new List<string>();
            foreach (var tilemap in App.Project.Tilemaps)
                foreach (var tag in tilemap.Tags)
                    if (!tags.Contains(tag))
                        tags.Add(tag);

            cbTags.Items.AddRange(tags.OrderBy(x => x).ToArray());
        }
    }
}
