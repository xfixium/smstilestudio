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

namespace SMSTileStudio.Controls
{
    public partial class AssetEntityControl : AssetControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Entity _entity = null;

        /// <summary>
        /// Properties
        /// </summary>
        private bool HasData { get { return _entity != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public AssetEntityControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Entity selection changed
        /// </summary>
        private void lstEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loading = true;
            lstEntities.Refresh();
            LoadUI();
            Loading = false;
        }

        /// <summary>
        /// Dialog menu item click
        /// </summary>
        private void mnuEntity_Click(object sender, EventArgs e)
        {
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            //if (menuItem == mnuExportBinary)
            //{
            //    using (SaveFileDialog dialog = new SaveFileDialog())
            //    {
            //        dialog.Title = "Export Binary Data (" + _dialog.Name + ")";
            //        dialog.Filter = "Binary File|*.bin";
            //        dialog.FileName = _dialog.Name.ToLower().Replace(" ", "_") + "_text";
            //        if (dialog.ShowDialog() == DialogResult.OK)
            //        {
            //            using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
            //            {
            //                using (BinaryWriter bw = new BinaryWriter(fs))
            //                {
            //                    bw.Write(_dialog.GetDialogData(true));
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (menuItem == mnuExportHex)
            //    Clipboard.SetText(_dialog.GetASMString(true));
            //else if (menuItem == mnuExportAssembly)
            //    Clipboard.SetText(_dialog.GetASMString(false));
            //else if (menuItem == mnuReindexCharacters)
            //    pnlCharacters.Reindex();
            //else if (menuItem == mnuRemoveCharacters)
            //    pnlCharacters.RemoveSelected();
        }

        /// <summary>
        /// Tilemap button click
        /// </summary>
        private void btnEntity_Click(object sender, EventArgs e)
        {
            // If data not loaded, if button is not sender, return
            if (!(sender is Button button))
                return;

            // Perform action based on which button was clicked
            if (button == btnNew)
            {
                var entity = (Entity)App.Project.CreateAsset(GameAssetType.Entity);
                LoadData(entity == null);
                if (entity != null)
                    lstEntities.SelectedItem = entity;
            }
            else if (HasData && button == btnDuplicate)
            {
                var entity = (Entity)App.Project.DuplicateAsset(_entity);
                LoadData(entity == null);
                if (entity != null)
                    lstEntities.SelectedItem = entity;
            }
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _entity.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_entity);
                    LoadData(true);
                    lstEntities_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            else if (HasData && button == btnAddField)
            {
                _entity.Fields.Add(new EntityField(EntityFieldType.Byte, "Field " + _entity.Fields.Count, "0"));
                UpdateEntity();
                CreateFieldsUI();
            }
            else if (button.Name.ToLower().Contains("removefield"))
            {
                var index = Convert.ToInt32(button.Tag);
                if (MessageBox.Show("Are you sure you want to delete field: " + _entity.Fields[index].Name + "?", "Remove Field", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _entity.Fields.RemoveAt(index);
                    UpdateEntity();
                    CreateFieldsUI();
                }
            }
        }

        /// <summary>
        /// Dialog name changed
        /// </summary>
        private void txtEntity_TextChanged(object sender, EventArgs e)
        {
            if (!HasData || Loading || lstEntities.SelectedItem == null || !(sender is TextBox textbox))
                return;

            if (textbox == txtName)
                _entity.Name = txtName.Text;
            else if (textbox.Name.ToLower().Contains("fieldname"))
            {
                var index = Convert.ToInt32(textbox.Tag);
                _entity.Fields[index].Name = textbox.Text;
            }
            else if (textbox.Name.ToLower().Contains("fieldvalue"))
            {
                var index = Convert.ToInt32(textbox.Tag);
                _entity.Fields[index].Value = _entity.Fields[index].GetValue(textbox.Text);
                (tpnlFields.GetControlFromPosition(4, index) as TextBox).Text = _entity.Fields[index].Value;
            }
            else if (textbox == txtComments)
                _entity.Comments = txtComments.Text;

            UpdateEntity();
        }

        /// <summary>
        /// Numeric value changed
        /// </summary>
        private void nudEntity_ValueChanged(object sender, EventArgs e)
        {
            // If data not loaded, if numeric is not sender, return
            if (!HasData || Loading || !(sender is NumericUpDown nud))
                return;

            UpdateEntity();
        }

        /// <summary>
        /// Tilemap combobox selection changed
        /// </summary>
        private void cbEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If combobox is sender
            if (!HasData || Loading || !(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            // Perform action based on control
            if (comboBox.Name.ToLower().Contains("fieldtype"))
            {
                var index = Convert.ToInt32(comboBox.Tag);
                _entity.Fields[index].ValueType = (EntityFieldType)comboBox.SelectedItem;
                _entity.Fields[index].Value = _entity.Fields[index].GetValue(_entity.Fields[index].Value);
                (tpnlFields.GetControlFromPosition(4, index) as TextBox).Text = _entity.Fields[index].Value;
            }

            UpdateEntity();
        }

        /// <summary>
        /// Loads list of entity data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            Loading = true;
            var item = lstEntities.SelectedItem ?? lstEntities.SelectedItem.DeepClone();
            lstEntities.Items.Clear();
            foreach (var asset in App.Project.Entities.OrderBy(x => x.Name).ToArray())
                lstEntities.Items.Add(asset);

            if (loadDefault && lstEntities.Items.Count > 0)
                lstEntities.SelectedIndex = 0;
            else if (item != null && lstEntities.Items.Contains(item))
                lstEntities.SelectedItem = item;
            else
                LoadUI();

            Loading = false;
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            tpnlEntities.Visible = lstEntities.SelectedItem != null;
            _entity = lstEntities.SelectedItem == null ? null : (Entity)App.Project.GetAsset((lstEntities.SelectedItem as Entity).ID);
            txtName.Text = _entity == null ? string.Empty : _entity.Name;
            txtComments.Text = _entity == null ? string.Empty : _entity.Comments;
            lblInfo.Text = _entity == null ? "No Entity information" : _entity.GetInfo();
            CreateFieldsUI();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateFieldsUI()
        {
            if (_entity == null)
                return;

            tpnlFields.Controls.Clear();
            tpnlFields.RowStyles.Clear();
            tpnlFields.RowCount = _entity.Fields.Count;
            tpnlFields.SuspendLayout();
            int row = 0;
            foreach (var field in _entity.Fields)
            {
                var ctrls = GetFieldCOntrols(row, field);
                for (int i = 0; i < tpnlFields.ColumnCount; i++)
                {
                    tpnlFields.SetRow(ctrls[i], row);
                    tpnlFields.Controls.Add(ctrls[i], i, row);
                }

                row++;
            }
            tpnlFields.ResumeLayout();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private List<Control> GetFieldCOntrols(int index, EntityField field)
        {
            var ctrls = new List<Control>()
            {
                new ComboBox { Name = "fieldtype" + index, DropDownStyle = ComboBoxStyle.DropDownList, Tag = index },
                new Label() { Text = "Name:", TextAlign = System.Drawing.ContentAlignment.MiddleLeft },
                new TextBox { Name = "txtFieldName" + index, Text = field.Name, Tag = index, Dock = DockStyle.Fill },
                new Label() { Text = "Value: ", TextAlign = System.Drawing.ContentAlignment.MiddleLeft },
                new TextBox { Name = "nudFieldValue" + index, Text = field.GetValue(field.Value), Tag = index, Dock = DockStyle.Fill },
                new Button() { Name = "btnRemoveField" + index, Text = "Remove", Tag = index }
            };

            foreach (var ctrl in ctrls)
            {
                ctrl.Margin = Padding.Empty;
            }
            (ctrls[0] as ComboBox).Items.AddRange(new object[] { EntityFieldType.Byte, EntityFieldType.Word, EntityFieldType.Long, EntityFieldType.Text, EntityFieldType.Hex, EntityFieldType.Bytes });
            (ctrls[0] as ComboBox).SelectedItem = field.ValueType;
            (ctrls[0] as ComboBox).SelectedIndexChanged += cbEntity_SelectedIndexChanged;
            (ctrls[2] as TextBox).TextChanged += txtEntity_TextChanged;
            (ctrls[4] as TextBox).TextChanged += txtEntity_TextChanged;
            (ctrls[5] as Button).Click += btnEntity_Click;
            return ctrls;
        }

        /// <summary>
        /// Update entity data and UI
        /// </summary>
        private void UpdateEntity()
        {
            if (Loading)
                return;

            App.Project.UpdateAsset(_entity);
            Loading = true;
            lstEntities.SelectedItem = _entity;
            lstEntities.Refresh();
            lblInfo.Text = _entity == null ? "No Entity information" : _entity.GetInfo();
            Loading = false;
        }
    }
}
