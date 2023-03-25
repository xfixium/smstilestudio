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
using System.Collections.Generic;
using SMSTileStudio.Data;
using SMSTileStudio.Forms;

namespace SMSTileStudio.Controls
{
    public partial class AssetDialogControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Dialog _dialog = null;
        private List<CharacterSet> _characterSetCopy= null;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _dialog != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetDialogControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dialog selection changed
        /// </summary>
        private void lstDialogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            lstDialogs.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Dialog menu item click
        /// </summary>
        private void mnuDialog_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuExportBinary)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data (" + _dialog.Name + ")";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _dialog.Name.ToLower().Replace(" ", "_") + "_text";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(_dialog.GetDialogData(true));
                            }
                        }
                    }
                }
            }
            else if (menuItem == mnuExportHex)
                Clipboard.SetText(_dialog.GetASMString(true));
            else if (menuItem == mnuExportAssembly)
                Clipboard.SetText(_dialog.GetASMString(false));
            else if (menuItem == mnuReindexCharacters)
                pnlCharacters.Reindex();
            else if (menuItem == mnuRemoveCharacters)
                pnlCharacters.RemoveSelected();
        }

        /// <summary>
        /// Tilemap button click
        /// </summary>
        private void btnDialog_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Perform action based on which button was clicked
            if (button == btnNew)
            {
                Dialog dialog = (Dialog)App.Project.CreateAsset(GameAssetType.Dialog);
                LoadData(dialog == null);
                if (dialog != null)
                    lstDialogs.SelectedItem = dialog;
            }
            else if (HasData && button == btnDuplicate)
            {
                Dialog dialog = (Dialog)App.Project.DuplicateAsset(_dialog);
                LoadData(dialog == null);
                if (dialog != null)
                    lstDialogs.SelectedItem = dialog;
            }
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _dialog.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_dialog);
                    LoadData(true);
                    lstDialogs_SelectedIndexChanged(this, EventArgs.Empty);
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
                if (importColors.Count > 32)
                {
                    MessageBox.Show("The image has more than 32 colors, reduce the image colors and try again.");
                    return;
                }

                using (var form = new ImportGraphicsForm(image, _dialog.Name, _dialog.BgPaletteID, _dialog.SprPaletteID, importColors))
                {
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    lstDialogs_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
            }
            else if (HasData && button == btnDialogCopy)
            {
                _characterSetCopy = _dialog.CharacterMap.DeepClone();
            }
            else if (HasData && button == btnDialogPaste)
            {
                _dialog.CharacterMap = _characterSetCopy.DeepClone();
                UpdateDialog();
            }
            else if (HasData && button == btnCharacterMapOptions)
            {
                mnuCharacterMap.Show(btnCharacterMapOptions, new Point(0, btnCharacterMapOptions.Height));
            }
        }

        /// <summary>
        /// Dialog name changed
        /// </summary>
        private void txtDialog_TextChanged(object sender, EventArgs e)
        {
            if (!HasData || lstDialogs.SelectedItem == null || !(sender is TextBox textbox))
                return;

            if (textbox == txtName)
                _dialog.Name = txtName.Text;
            else if (textbox == txtTextEditor)
                _dialog.Text = txtTextEditor.Text;

            UpdateDialog();
        }

        /// <summary>
        /// Numeric value changed
        /// </summary>
        private void nudDialog_ValueChanged(object sender, EventArgs e)
        {
            // If data not loaded, if numeric is not sender, return
            if (!HasData || Loading || !(sender is NumericUpDown nud))
                return;

            // Update tilemap
            if (nud == nudOffset)
                _dialog.Offset = (int)nudOffset.Value;
            else if (nud == nudColumn)
                _dialog.Column = (int)nudColumn.Value;
            else if (nud == nudRow)
                _dialog.Row = (int)nudRow.Value;
            else if (nud == nudDuration)
                _dialog.Duration = (byte)nudDuration.Value;

            UpdateDialog();
        }

        /// <summary>
        /// Loads list of dialog data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;
            var item = lstDialogs.SelectedItem ?? lstDialogs.SelectedItem.DeepClone();
            lstDialogs.Items.Clear();
            foreach (var asset in App.Project.Dialogs.OrderBy(x => x.Name).ToArray())
                lstDialogs.Items.Add(asset);

            if (loadDefault && lstDialogs.Items.Count > 0)
                lstDialogs.SelectedIndex = 0;
            else if (item != null && lstDialogs.Items.Contains(item))
                lstDialogs.SelectedItem = item;
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            tabMain.Visible = lstDialogs.SelectedItem != null;
            _dialog = lstDialogs.SelectedItem == null ? null : (Dialog)App.Project.GetAsset((lstDialogs.SelectedItem as Dialog).ID);
            txtName.Text = _dialog == null ? string.Empty : _dialog.Name;
            txtTextEditor.Text = _dialog == null ? string.Empty : _dialog.Text;
            nudOffset.Value = _dialog == null ? 0 : _dialog.Offset;
            nudColumn.Value = _dialog == null ? 0 : _dialog.Column;
            nudRow.Value = _dialog == null ? 0 : _dialog.Row;
            nudDuration.Value = _dialog == null ? 0 : _dialog.Duration;
            lblInfo.Text = _dialog == null ? "No Dialog information" : _dialog.GetInfo();
            if (_dialog != null)
                pnlCharacters.LoadData(_dialog.CharacterMap);
        }

        /// <summary>
        /// Update tilemap data and UI
        /// </summary>
        private void UpdateDialog()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_dialog);
            Loading = true;
            lstDialogs.SelectedItem = _dialog;
            lstDialogs.Refresh();
            lblInfo.Text = _dialog == null ? "No Dialog information" : _dialog.GetInfo();
            Loading = false;
        }

        /// <summary>
        /// Character map changed
        /// </summary>
        /// <param name="characterMap"></param>
        private void pnlCharacters_CharacterMapChanged(List<CharacterSet> characterMap)
        {
            if (!HasData || lstDialogs.SelectedItem == null)
                return;

            _dialog.CharacterMap = characterMap;
            UpdateDialog();
        }
    }
}
