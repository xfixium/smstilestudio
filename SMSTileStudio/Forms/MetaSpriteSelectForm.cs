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

using SMSTileStudio.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SMSTileStudio.Forms
{
    public partial class MetaSpriteSelectForm : Form
    {
        public List<MetaSprite> MetaSprites { get { return lstSelectedMetaSprites.CheckedItems.Cast<MetaSprite>().ToList(); } }
        public bool BinaryMerge { get { return chkBinaryMerge.Checked; } }

        public MetaSpriteSelectForm()
        {
            InitializeComponent();
            pnlMetaSprite.Image = new Bitmap(pnlMetaSprite.ClientSize.Width, pnlMetaSprite.ClientSize.Height);
            pnlMetaSprite.ShowSprites = false;
            pnlMetaSprite.UseGrid = false;
            pnlMetaSprite.ShowOrigin = false;
            pnlMetaSprite.ShowTransparent = true;
            LoadData();
        }

        /// <summary>
        /// Apply filter button click
        /// </summary>
        private void btnFilterByName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSelectedMetaSprites.Items.Count; i++)
            {
                if (lstSelectedMetaSprites.GetItemChecked(i) == true)
                    continue;

                lstSelectedMetaSprites.SetItemChecked(i, lstSelectedMetaSprites.Items[i].ToString().Contains(txtFilter.Text));
            }
            UpdateInfo();
        }

        /// <summary>
        /// Selected tilemap changed
        /// </summary>
        private void lstSelectedMetaSprites_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
            if (lstSelectedMetaSprites.SelectedItem == null)
                return;

            var metaSprite = lstSelectedMetaSprites.SelectedItem as MetaSprite;
            var sprPalette = App.Project.GetAsset(metaSprite.PaletteID) as Palette;
            if (metaSprite.Frames == null || metaSprite.Frames.Count == 0)
            {
                pnlMetaSprite.Clear();
                return;
            }

            pnlMetaSprite.Palette = sprPalette;
            pnlMetaSprite.LoadFrame(metaSprite.Frames[0], metaSprite == null ? SpriteModeType.Normal : metaSprite.SpriteMode);
            pnlTileset.Image = BitmapUtility.GetTilesetImage(metaSprite.GetTileset(), sprPalette, 16);
        }

        /// <summary>
        /// List item check changed
        /// </summary>
        private void lstSelectedMetaSprites_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => UpdateInfo()));
        }

        /// <summary>
        /// Check/Uncheck All check changed
        /// </summary>
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSelectedMetaSprites.Items.Count; i++)
            {
                lstSelectedMetaSprites.SetItemChecked(i, chkAll.Checked);
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
            lblSelectedTilemaps.Text = "Selected Meta Sprites: " + lstSelectedMetaSprites.CheckedItems.Count;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        private void LoadData()
        {
            lstSelectedMetaSprites.Items.Clear();
            lstSelectedMetaSprites.Items.AddRange(App.Project.MetaSprites.Where(x => x.ID >= 0).OrderBy(x => x.Name).ToArray());
        }
    }
}
