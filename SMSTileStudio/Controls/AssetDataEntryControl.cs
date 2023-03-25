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
using System.Collections.Generic;
using SMSTileStudio.Data;

namespace SMSTileStudio.Controls
{
    public partial class AssetDataEntryControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private DataEntry _dataEntry = null;

        /// <summary>
        /// Properties
        /// </summary>
        public bool HasData { get { return _dataEntry != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetDataEntryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Data entry selection changed
        /// </summary>
        private void lstDataEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            lstDataEntries.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Save asset button click
        /// </summary>
        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            // If button is sender
            if (!(sender is Button button))
                return;

            // If the action requires a selected palette
            if (lstDataEntries.SelectedItem == null && button != btnNew && button != btnImport)
                return;

            DataEntry dataEntry = null;
            if (button == btnNew)
            {
                dataEntry = (DataEntry)App.Project.CreateAsset(GameAssetType.DataEntry);
                LoadData(dataEntry == null);
                if (dataEntry != null)
                    lstDataEntries.SelectedItem = dataEntry;
            }
            else if (HasData && button == btnDuplicate)
            {
                dataEntry = (DataEntry)App.Project.DuplicateAsset(_dataEntry);
                LoadData(dataEntry == null);
                if (dataEntry != null)
                    lstDataEntries.SelectedItem = dataEntry;
            }
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _dataEntry.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_dataEntry);
                    LoadData(true);
                    lstDataEntries_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (button == btnImport)
                ImportData();
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
        }

        /// <summary>
        /// Data entry menu item click
        /// </summary>
        private void mnuDataEntry_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            if (menuItem == mnuExportBinary)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data (" + _dataEntry.Name + ")";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _dataEntry.Name.ToLower().Replace(" ", "_");
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(_dataEntry.GetDataEntryData(true));
                            }
                        }
                    }
                }
            }
            else if (menuItem == mnuExportHex)
                Clipboard.SetText(_dataEntry.GetASMString(true));
            else if (menuItem == mnuExportAssembly)
                Clipboard.SetText(_dataEntry.GetASMString(false));
        }

        /// <summary>
        /// Data entry text changed
        /// </summary>
        private void txtDataEntry_TextChanged(object sender, EventArgs e)
        {
            if (!HasData || lstDataEntries.SelectedItem == null || !(sender is TextBox textbox))
                return;

            if (textbox == txtName)
                _dataEntry.Name = txtName.Text;
            else if (textbox == txtDataEntry)
                _dataEntry.Data = DataFromText();
            else if (textbox == txtComments)
                _dataEntry.Comments = txtComments.Text;

            UpdateDataEntry();
        }

        /// <summary>
        /// Use hex check changed
        /// </summary>
        private void chkDataEntryUseHex_CheckedChanged(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            List<byte> data = new List<byte>();
            string[] bytes = txtDataEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string b in bytes)
            {
                try
                {
                    data.Add(chkDataEntryUseHex.Checked ? Convert.ToByte(b) : Convert.ToByte(b, 16));
                }
                catch
                {
                    continue;
                }
            }

            StringBuilder text = new StringBuilder();
            foreach (byte b in data)
                text.Append((chkDataEntryUseHex.Checked ? b.ToString("X2") : b.ToString()) + " ");

            txtDataEntry.Text = text.ToString().TrimEnd();
        }

        /// <summary>
        /// Converts data entry text into data
        /// </summary>
        private List<byte> DataFromText()
        {
            List<byte> data = new List<byte>();
            try
            {
                string[] text = txtDataEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string b in text)
                    data.Add(chkDataEntryUseHex.Checked ? Convert.ToByte(b, 16) : Convert.ToByte(b));

                return data;
            }
            catch
            {
                MessageBox.Show("The data may be incorrectly formatted. Please make sure byte entries are separated by a space, and each byte does not exceed the maximum value of 255.");
                return data;
            }
        }

        /// <summary>
        /// Converts data entry data into text
        /// </summary>
        private string DataToText(List<byte> data)
        {
            if (data == null)
                return string.Empty;

            StringBuilder text = new StringBuilder();
            foreach (byte b in data)
                text.Append((chkDataEntryUseHex.Checked ? b.ToString("X2") : b.ToString()) + " ");

            return text.ToString().TrimEnd();
        }

        /// <summary>
        /// Imports data
        /// </summary>
        private void ImportData()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Import Data";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                List<byte> data = new List<byte>();
                data.AddRange(File.ReadAllBytes(ofd.FileName));
                DataToText(data);
            }
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;
            var item = lstDataEntries.SelectedItem ?? lstDataEntries.SelectedItem.DeepClone();
            lstDataEntries.Items.Clear();
            foreach (var asset in App.Project.DataEntries.Where(x => x.ID >= 0).OrderBy(x => x.Name).ToArray())
                lstDataEntries.Items.Add(asset);

            if (loadDefault && lstDataEntries.Items.Count > 0)
                lstDataEntries.SelectedIndex = 0;
            else if (item != null && lstDataEntries.Items.Contains(item))
                lstDataEntries.SelectedItem = item;
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Loads data to UI
        /// </summary>
        public void LoadUI()
        {
            tpnlDataEntry.Visible = lstDataEntries.SelectedItem != null;
            _dataEntry = lstDataEntries.SelectedItem == null ? null : (DataEntry)App.Project.GetAsset((lstDataEntries.SelectedItem as DataEntry).ID);
            txtName.Text = _dataEntry == null ? string.Empty : _dataEntry.Name;
            txtDataEntry.Text = _dataEntry == null ? string.Empty : DataToText(_dataEntry.Data);
            txtComments.Text = _dataEntry == null ? string.Empty : _dataEntry.Comments;
        }

        /// <summary>
        /// Update palette data and UI
        /// </summary>
        private void UpdateDataEntry()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_dataEntry);
            Loading = true;
            lstDataEntries.SelectedItem = _dataEntry;
            lstDataEntries.Refresh();
            lblInfo.Text = _dataEntry == null ? "No Data Entry information" : _dataEntry.GetInfo();
            OnAssetsChanged();
            Loading = false;
        }
    }
}
