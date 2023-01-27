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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class AssetPaletteControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Palette _palette;
        private Point _lastPosition = Point.Empty;

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _palette != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetPaletteControl()
        {
            InitializeComponent();

            // Load compression combo boxes
            cbSwatch.ValueMember = "Value";
            cbSwatch.DisplayMember = "Description";
            cbSwatch.DataSource = EnumMethods.GetEnumCollection(typeof(SwatchType));
            if (cbSwatch.Items.Count > 0)
                cbSwatch.SelectedIndex = 0;
        }

        /// <summary>
        /// Selected palette changed
        /// </summary>
        private void lstPalettes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            lstPalettes.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Button click
        /// </summary>
        private void btnPalette_Click(object sender, EventArgs e)
        {
            // If button is sender
            if (!(sender is Button button))
                return;

            // If the action requires a selected palette
            if (lstPalettes.SelectedItem == null && button != btnNew && button != btnImport)
                return;

            // Perform action based on which button was clicked
            Palette palette = null;
            if (button == btnNew)
            {
                palette = (Palette)App.Project.CreateAsset(GameAssetType.Palette);
                LoadData(palette == null);
                if (palette != null)
                    lstPalettes.SelectedItem = palette;
            }
            else if (HasData && button == btnDuplicate)
            {
                palette = (Palette)App.Project.DuplicateAsset(_palette);
                LoadData(palette == null);
                if (palette != null)
                    lstPalettes.SelectedItem = palette;
            }
            else if (HasData && button == btnRemove)
            {
                App.Project.RemoveAsset(_palette);
                LoadData(true);
                lstPalettes_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else if (button == btnImport)
            {
                if (!HasData)
                    return;

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

                if (!BitmapUtility.CheckForSMSColors(importColors))
                {
                    MessageBox.Show("The image has unsupported colors in it. Make sure only SMS colors are used in the image.");
                    return;
                }

                var palettes = GetPalettes(importColors);
                if (palettes.Count <= 0)
                    return;

                _palette.Colors = palettes[0].DeepClone();
                if (palettes.Count > 1)
                {
                    palettes.RemoveAt(0);
                    foreach (var p in palettes)
                    {
                        palette = (Palette)App.Project.CreateAsset(GameAssetType.Palette);
                        palette.Colors = p;
                        App.Project.UpdateAsset(palette);
                    }
                }
            }
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            else if (button == btnShiftLeft && pnlPalette.SelectedIndex != -1 && pnlPalette.SelectedIndex > 0)
            {
                int source = pnlPalette.SelectedIndex;
                Color sourceColor = _palette.Colors[source];
                Color targetColor = _palette.Colors[source - 1];
                _palette.Colors[source] = targetColor;
                _palette.Colors[source - 1] = sourceColor;
                App.Project.UpdateAsset(_palette);
                pnlPalette.SetPalette(_palette.Colors);
                pnlPalette.SelectColor(source - 1);
                return;
            }
            else if (button == btnShiftRight && pnlPalette.SelectedIndex != -1 && pnlPalette.SelectedIndex < 15)
            {
                int source = pnlPalette.SelectedIndex;
                Color sourceColor = _palette.Colors[source];
                Color targetColor = _palette.Colors[source + 1];
                _palette.Colors[source] = targetColor;
                _palette.Colors[source + 1] = sourceColor;
                App.Project.UpdateAsset(_palette);
                pnlPalette.SetPalette(_palette.Colors);
                pnlPalette.SelectColor(source + 1);
                return;
            }
            else
                return;

            // Refresh palette list, select palette
            LoadData(palette == null);
            if (palette != null)
                lstPalettes.SelectedItem = palette;
        }

        /// <summary>
        /// Export menu item click
        /// </summary>
        private void mnuExport_Click(object sender, EventArgs e)
        {
            if (_palette == null || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuExportImage)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Palette Image (" + _palette.Name + ")";
                    dialog.Filter = "PNG Image File|*.png";
                    dialog.FileName = _palette.Name.ToLower().Replace(" ", "_") + "_pal";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var image = BitmapUtility.GetPaletteImage(_palette, new Size(16, 16), (int)nudLength.Value))
                        {
                            if (image != null)
                                image.Save(dialog.FileName, ImageFormat.Png);
                        }
                    }
                }
            }
            if (menuItem == mnuExportBinary)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data (" + _palette.Name + ")";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _palette.Name.ToLower().Replace(" ", "_") + "_pal";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(_palette.GetPaletteData(true));
                            }
                        }
                    }
                }
            }
            else if (menuItem == mnuExportHex)
                Clipboard.SetText(_palette.GetASMString(true, true));
            else if (menuItem == mnuExportAssembly)
                Clipboard.SetText(_palette.GetASMString(false, true));
        }

        /// <summary>
        /// Swatch selection changed
        /// </summary>
        private void cbSwatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSwatch.SelectedItem == null)
                return;

            // Get selected swatch, load graphic resource
            var type = (SwatchType)cbSwatch.SelectedItem.GetType().GetProperty("value").GetValue(cbSwatch.SelectedItem, null);
            switch (type)
            {
                case SwatchType.Aseprite: pnlSwatch.Image = Properties.Resources.swatch_aseprite; break;
                case SwatchType.Sequential: pnlSwatch.Image = Properties.Resources.swatch_consecutive; break;
                case SwatchType.SixColors: pnlSwatch.Image = Properties.Resources.swatch_six; break;
            }
            pnlSwatch.Width = pnlSwatch.Image.Width;
            pnlSwatch.Height = pnlSwatch.Image.Height;
        }

        /// <summary>
        /// Color swatch mouse move
        /// </summary>
        private void pnlSwatch_MouseMove(object sender, MouseEventArgs e)
        {
            // If ready to update, set color tooltip, update position
            if (e.Location != _lastPosition)
            {
                Color color = (sender as ImageControl).GetColorUnderMouse();
                bool showColor = color.ToArgb() != SystemColors.Control.ToArgb();
                ttMain.SetToolTip(pnlSwatch, showColor ? GetColorString(color) : "");
                _lastPosition = e.Location;
            }
        }

        /// <summary>
        /// Palette color picker click
        /// </summary>
        private void pnlSwatch_Click(object sender, EventArgs e)
        {
            if (lstPalettes.SelectedItem == null)
                return;

            // Get the color underneath color, apply it to a palette color, if one is selected
            Color color = (sender as ImageControl).GetColorUnderMouse();
            color = color.A < 255 || color.ToArgb() == SystemColors.Control.ToArgb() ? Color.White : color;
            if (pnlPalette.SelectedIndex != -1)
            {
                _palette.Colors[pnlPalette.SelectedIndex] = color;
                pnlPalette.SetPalette(_palette.Colors);
                UpdatePalette();
            }
        }

        /// <summary>
        /// Name changed
        /// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (lstPalettes.SelectedItem == null)
                return;

            // Update palette name
            _palette.Name = txtName.Text;
            UpdatePalette();
        }

        /// <summary>
        /// Palette length changed
        /// </summary>
        private void nudLength_ValueChanged(object sender, EventArgs e)
        {
            if (lstPalettes.SelectedItem == null)
                return;

            // Update the number of colors on output
            _palette.Length = (int)nudLength.Value;
            UpdatePalette();
        }

        /// <summary>
        /// Divides a list into valid palettes
        /// </summary>
        /// <param name="colors">The colors being organized into 16 color palettes</param>
        /// <returns>Returns color palettes</returns>
        public List<List<Color>> GetPalettes(List<Color> colors)
        {
            var lists = new List<List<Color>>();
            for (int i = 0; i < colors.Count; i += 16)
            {
                var list = colors.GetRange(i, Math.Min(16, colors.Count - i));
                if (list.Count < 16)
                    for (int j = list.Count; j < 16; j++)
                        list.Add(Color.Black);

                lists.Add(list);
            }
            return lists;
        }

        /// <summary>
        /// Gets color tooltip
        /// </summary>
        /// <param name="col">The color to get string of</param>
        /// <returns>A color string</returns>
        private string GetColorString(Color col)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RGB: " + col.R + ", " + col.G + ", " + col.B);
            sb.AppendLine("RGB Hex: $" + col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2"));
            sb.AppendLine("SMS Hex: $" + Palette.GetColor(col).ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// Loads list of palette data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;
            var item = lstPalettes.SelectedItem ?? lstPalettes.SelectedItem.DeepClone();
            lstPalettes.Items.Clear();
            foreach (var asset in App.Project.Palettes.Where(x => x.ID >= 0).OrderBy(x => x.Name).ToArray())
                lstPalettes.Items.Add(asset);

            if (loadDefault && lstPalettes.Items.Count > 0)
                lstPalettes.SelectedIndex = 0;
            else if (item != null && lstPalettes.Items.Contains(item))
                lstPalettes.SelectedItem = item;
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            // Load UI with selected palette
            tpnlPalette.Visible = lstPalettes.SelectedItem != null;
            pnlOptions.Visible = lstPalettes.SelectedItem != null;
            _palette = lstPalettes.SelectedItem == null ? null : lstPalettes.SelectedItem as Palette;
            txtName.Text = _palette == null ? string.Empty : _palette.Name;
            pnlPalette.SetPalette(_palette == null ? Palette.Empty : _palette.Colors);
            nudLength.Value = _palette == null ? 16 : _palette.Length;
            lblInfo.Text = _palette == null ? "No Palette information" : _palette.GetInfo();
            lstPaletteReferences.Items.Clear();
            if (App.Project == null || lstPalettes.SelectedItem == null)
                return;

            var paletteID = (lstPalettes.SelectedItem as Palette).ID;
            foreach (var tilemap in App.Project.Tilemaps)
            {
                if (tilemap.BgPaletteID == paletteID)
                    lstPaletteReferences.Items.Add(tilemap.Name + " (BG)");

                if (tilemap.SprPaletteID == paletteID)
                    lstPaletteReferences.Items.Add(tilemap.Name + " (SPR)");
            }

            foreach (var metaSprite in App.Project.MetaSprites)
            {
                if (metaSprite.PaletteID == paletteID)
                    lstPaletteReferences.Items.Add(metaSprite.Name);
            }
        }

        /// <summary>
        /// Update palette data and UI
        /// </summary>
        private void UpdatePalette()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_palette);
            Loading = true;
            lstPalettes.SelectedItem = _palette;
            lstPalettes.Refresh();
            lblInfo.Text = _palette == null ? "No Palette information" : _palette.GetInfo();
            OnAssetsChanged();
            Loading = false;
        }
    }
}
