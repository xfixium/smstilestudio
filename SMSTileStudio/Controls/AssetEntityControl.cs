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
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
        private int SelectedFieldIndex { get; set; }

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
        /// Menu item click
        /// </summary>
        private void mnuEntity_Click(object sender, EventArgs e)
        {
            // If data not loaded, or not a menu item, return
            if (!HasData || !(sender is ToolStripMenuItem menuItem))
                return;

            // Export data as a binary file
            if (menuItem == mnuExportBinary)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Binary Data (" + _entity.Name + ")";
                    dialog.Filter = "Binary File|*.bin";
                    dialog.FileName = _entity.Name.ToLower().Replace(" ", "_") + "_data";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(_entity.GetEntityData(true));
                            }
                        }
                    }
                }
                return;
            }
            //else if (menuItem == mnuExportHex)
            //    Clipboard.SetText(_entity.GetASMString(true));
            // Export data as ASM text to clipboard
            //else if (menuItem == mnuExportAssembly)
            //    Clipboard.SetText(_entity.GetASMString(false));
            // Move selected field up list
            else if (menuItem == mnuMoveUp)
            {
                if (SelectedFieldIndex - 1 < 0)
                    return;

                var field = _entity.Fields[SelectedFieldIndex].DeepClone();
                _entity.Fields.RemoveAt(SelectedFieldIndex);
                _entity.Fields.Insert(SelectedFieldIndex - 1, field);
            }
            // Move selected field down list
            else if (menuItem == mnuMoveDown)
            {
                if (SelectedFieldIndex + 1 >= _entity.Fields.Count)
                    return;

                var field = _entity.Fields[SelectedFieldIndex].DeepClone();
                _entity.Fields.RemoveAt(SelectedFieldIndex);
                _entity.Fields.Insert(SelectedFieldIndex + 1, field);
            }
            // Insert new field
            else if (menuItem == mnuInsert)
            {
                _entity.Fields.Insert(SelectedFieldIndex + 1, new EntityField(EntityFieldType.Byte, "Field " + _entity.Fields.Count, "0"));
            }
            // Remove selected field
            else if (menuItem == mnuRemove)
            {
                _entity.Fields.RemoveAt(SelectedFieldIndex);
            }
            UpdateEntity();
            CreateFieldsUI();
        }

        /// <summary>
        /// Button click
        /// </summary>
        private void btnEntity_Click(object sender, EventArgs e)
        {
            // If data not loaded, or not a button, return
            if (!(sender is Button button))
                return;

            // Create new entity
            if (button == btnNew)
            {
                var entity = (Entity)App.Project.CreateAsset(GameAssetType.Entity);
                LoadData(entity == null);
                if (entity != null)
                    lstEntities.SelectedItem = entity;
            }
            // Duplicate selected entity
            else if (HasData && button == btnDuplicate)
            {
                var entity = (Entity)App.Project.DuplicateAsset(_entity);
                LoadData(entity == null);
                if (entity != null)
                    lstEntities.SelectedItem = entity;
            }
            // Remove selected entity
            else if (HasData && button == btnRemove)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _entity.Name + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    App.Project.RemoveAsset(_entity);
                    LoadData(true);
                    lstEntities_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
            // Add field to selected entity
            else if (HasData && button == btnAddField)
            {
                _entity.Fields.Add(new EntityField(EntityFieldType.Byte, "Field " + _entity.Fields.Count, "0"));
                UpdateEntity();
                CreateFieldsUI();
            }
            // Export entity as a binary file
            else if (HasData && button == btnExport)
            {
                mnuExport.Show(btnExport, new Point(0, btnExport.Height));
                return;
            }
            // Field ... button clicked, show options menu
            else if (button.Name.ToLower().Contains("fieldoptions"))
            {
                SelectedFieldIndex = Convert.ToInt32(button.Tag);
                mnuOptions.Show(button, new Point(0, button.Height));
            }
        }

        /// <summary>
        /// Dialog name changed
        /// </summary>
        private void txtEntity_TextChanged(object sender, EventArgs e)
        {
            // If data not loaded, or updating UI, or an entity has not been selected, or not a textbox, return
            if (!HasData || Loading || lstEntities.SelectedItem == null || !(sender is TextBox textbox))
                return;

            // If name textbox
            if (textbox == txtName)
                _entity.Name = txtName.Text;
            // If field name textbox
            else if (textbox.Name.ToLower().Contains("fieldname"))
            {
                var index = Convert.ToInt32(textbox.Tag);
                _entity.Fields[index].Name = textbox.Text;
            }
            // If field value textbox
            else if (textbox.Name.ToLower().Contains("fieldvalue"))
            {
                var index = Convert.ToInt32(textbox.Tag);
                _entity.Fields[index].Value = _entity.Fields[index].GetValue(textbox.Text);
                (tpnlFields.GetControlFromPosition(4, index) as TextBox).Text = _entity.Fields[index].Value;
            }
            // If entity comments textbox
            else if (textbox == txtComments)
                _entity.Comments = txtComments.Text;

            UpdateEntity();
        }

        /// <summary>
        /// Numeric value changed
        /// </summary>
        private void nudEntity_ValueChanged(object sender, EventArgs e)
        {
            // If data not loaded, or not a numeric, return
            if (!HasData || Loading || !(sender is NumericUpDown nud))
                return;

            UpdateEntity();
        }

        /// <summary>
        /// Combobox selection changed
        /// </summary>
        private void cbEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If data not loaded, or updating UI, or not a combobox, or an item in the combobox has not been selected, return
            if (!HasData || Loading || !(sender is ComboBox comboBox) || comboBox.SelectedItem == null)
                return;

            // If field type combobox
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
        /// Checkbox checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEntity_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Implement this
        }

        /// <summary>
        /// Loads entity data
        /// </summary>
        public void LoadData(bool loadDefault)
        {
            // Hide fields control, before updating UI
            tpnlFields.Hide();
            Loading = true;
            // Save currently selected entity
            var item = lstEntities.SelectedItem ?? lstEntities.SelectedItem.DeepClone();
            // Clear entity list
            lstEntities.Items.Clear();
            // Load entities into list
            foreach (var asset in App.Project.Entities.OrderBy(x => x.Name).ToArray())
                lstEntities.Items.Add(asset);

            // If default load, and there is at least 1 enetity, select it
            if (loadDefault && lstEntities.Items.Count > 0)
                lstEntities.SelectedIndex = 0;
            // If refreshing data, and the list contains the saved entity, select it
            else if (item != null && lstEntities.Items.Contains(item))
                lstEntities.SelectedItem = item;
            // Nothing selected, load UI as usual
            else
                LoadUI();

            // Show fields control, after updating UI
            Loading = false;
            tpnlFields.Show();
        }

        /// <summary>
        /// Load UI with selected data
        /// </summary>
        private void LoadUI()
        {
            // If an entity is selected, display editor
            tpnlEditor.Visible = lstEntities.SelectedItem != null;
            // Get selected entity, if one has been selected
            _entity = lstEntities.SelectedItem == null ? null : (Entity)App.Project.GetAsset((lstEntities.SelectedItem as Entity).ID);
            // Populate controls with data
            txtName.Text = _entity == null ? string.Empty : _entity.Name;
            txtComments.Text = _entity == null ? string.Empty : _entity.Comments;
            lblInfo.Text = _entity == null ? "No Entity information" : _entity.GetInfo();
            CreateFieldsUI();
        }

        /// <summary>
        /// Creates fields column controls
        /// </summary>
        private void CreateFieldsUI()
        {
            // If no entity selected, return
            if (_entity == null)
                return;

            // Set field controls with field data
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
        /// Gets a control collection that forms a field control
        /// </summary>
        private List<Control> GetFieldCOntrols(int index, EntityField field)
        {
            var ctrls = new List<Control>()
            {
                new ComboBox { Name = "fieldtype" + index, DropDownStyle = ComboBoxStyle.DropDownList, Tag = index },
                new Label() { Text = "Name:", TextAlign = ContentAlignment.MiddleLeft },
                new TextBox { Name = "txtFieldName" + index, Text = field.Name, Tag = index, Dock = DockStyle.Fill },
                new Label() { Text = "Value: ", TextAlign = ContentAlignment.MiddleLeft },
                new TextBox { Name = "nudFieldValue" + index, Text = field.GetValue(field.Value), Tag = index, Dock = DockStyle.Fill },
                new Button() { Name = "btnFieldOptions" + index, Text = "...", Tag = index }
            };

            foreach (var ctrl in ctrls)
            {
                ctrl.Margin = Padding.Empty;
            }
            (ctrls[0] as ComboBox).Items.AddRange(new object[] { EntityFieldType.Byte, EntityFieldType.Int, EntityFieldType.Long, EntityFieldType.Bytes, EntityFieldType.Ints, EntityFieldType.Longs, EntityFieldType.Text });
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
            // If just updating UI, return
            if (Loading)
                return;

            // Update the selected entity
            App.Project.UpdateAsset(_entity);
            // Update the UI without updating the entity data
            Loading = true;
            lstEntities.SelectedItem = _entity;
            lstEntities.Refresh();
            lblInfo.Text = _entity == null ? "No Entity information" : _entity.GetInfo();
            Loading = false;
        }
    }
}
