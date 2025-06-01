namespace SMSTileStudio.Controls
{
    partial class AssetDataEntryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.tpnlDataEntry = new System.Windows.Forms.TableLayoutPanel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtDataEntry = new System.Windows.Forms.TextBox();
            this.pnlDataEntryOptions = new System.Windows.Forms.Panel();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.txtOrderByField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPopulateTableData = new System.Windows.Forms.Button();
            this.lblOrderByField = new System.Windows.Forms.Label();
            this.lstSelectedEntities = new System.Windows.Forms.CheckedListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDataEntryComments = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkDataEntryUseHex = new System.Windows.Forms.CheckBox();
            this.lblCreatePalette = new System.Windows.Forms.Label();
            this.grpDataEntryList = new System.Windows.Forms.GroupBox();
            this.lstDataEntries = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlDataEntryButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            this.tpnlDataEntry.SuspendLayout();
            this.grpData.SuspendLayout();
            this.pnlDataEntryOptions.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.grpDataEntryList.SuspendLayout();
            this.pnlDataEntryButtons.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Controls.Add(this.pnlDataEntry, 1, 0);
            this.tpnlMain.Controls.Add(this.grpDataEntryList, 0, 0);
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.TabIndex = 12;
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.Controls.Add(this.tpnlDataEntry);
            this.pnlDataEntry.Controls.Add(this.lblCreatePalette);
            this.pnlDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntry.Location = new System.Drawing.Point(196, 0);
            this.pnlDataEntry.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(694, 557);
            this.pnlDataEntry.TabIndex = 14;
            // 
            // tpnlDataEntry
            // 
            this.tpnlDataEntry.ColumnCount = 2;
            this.tpnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlDataEntry.Controls.Add(this.grpData, 0, 0);
            this.tpnlDataEntry.Controls.Add(this.pnlDataEntryOptions, 1, 0);
            this.tpnlDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDataEntry.Location = new System.Drawing.Point(0, 0);
            this.tpnlDataEntry.Name = "tpnlDataEntry";
            this.tpnlDataEntry.RowCount = 1;
            this.tpnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntry.Size = new System.Drawing.Size(694, 557);
            this.tpnlDataEntry.TabIndex = 13;
            this.tpnlDataEntry.Visible = false;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtDataEntry);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(6, 0);
            this.grpData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.grpData.Name = "grpData";
            this.grpData.Padding = new System.Windows.Forms.Padding(12, 8, 12, 12);
            this.grpData.Size = new System.Drawing.Size(502, 557);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Space Separated Byte Values";
            // 
            // txtDataEntry
            // 
            this.txtDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataEntry.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntry.Location = new System.Drawing.Point(12, 23);
            this.txtDataEntry.Multiline = true;
            this.txtDataEntry.Name = "txtDataEntry";
            this.txtDataEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataEntry.Size = new System.Drawing.Size(478, 522);
            this.txtDataEntry.TabIndex = 0;
            this.txtDataEntry.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // pnlDataEntryOptions
            // 
            this.pnlDataEntryOptions.Controls.Add(this.txtComments);
            this.pnlDataEntryOptions.Controls.Add(this.pnlOptions);
            this.pnlDataEntryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntryOptions.Location = new System.Drawing.Point(514, 0);
            this.pnlDataEntryOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataEntryOptions.Name = "pnlDataEntryOptions";
            this.pnlDataEntryOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlDataEntryOptions.Size = new System.Drawing.Size(180, 557);
            this.pnlDataEntryOptions.TabIndex = 2;
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(8, 320);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(172, 237);
            this.txtComments.TabIndex = 11;
            this.txtComments.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.txtOrderByField);
            this.pnlOptions.Controls.Add(this.label1);
            this.pnlOptions.Controls.Add(this.btnPopulateTableData);
            this.pnlOptions.Controls.Add(this.lblOrderByField);
            this.pnlOptions.Controls.Add(this.lstSelectedEntities);
            this.pnlOptions.Controls.Add(this.lblName);
            this.pnlOptions.Controls.Add(this.lblDataEntryComments);
            this.pnlOptions.Controls.Add(this.txtName);
            this.pnlOptions.Controls.Add(this.chkDataEntryUseHex);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(8, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(172, 320);
            this.pnlOptions.TabIndex = 12;
            // 
            // txtOrderByField
            // 
            this.txtOrderByField.Location = new System.Drawing.Point(0, 254);
            this.txtOrderByField.MaxLength = 50;
            this.txtOrderByField.Name = "txtOrderByField";
            this.txtOrderByField.Size = new System.Drawing.Size(168, 22);
            this.txtOrderByField.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Table From Entity Data:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPopulateTableData
            // 
            this.btnPopulateTableData.Location = new System.Drawing.Point(0, 278);
            this.btnPopulateTableData.Name = "btnPopulateTableData";
            this.btnPopulateTableData.Size = new System.Drawing.Size(168, 23);
            this.btnPopulateTableData.TabIndex = 18;
            this.btnPopulateTableData.Text = "Populate Table Data";
            this.btnPopulateTableData.UseVisualStyleBackColor = true;
            this.btnPopulateTableData.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // lblOrderByField
            // 
            this.lblOrderByField.AutoSize = true;
            this.lblOrderByField.Location = new System.Drawing.Point(-2, 238);
            this.lblOrderByField.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderByField.Name = "lblOrderByField";
            this.lblOrderByField.Size = new System.Drawing.Size(83, 13);
            this.lblOrderByField.TabIndex = 13;
            this.lblOrderByField.Text = "Order By Field:";
            this.lblOrderByField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstSelectedEntities
            // 
            this.lstSelectedEntities.CheckOnClick = true;
            this.lstSelectedEntities.FormattingEnabled = true;
            this.lstSelectedEntities.Location = new System.Drawing.Point(0, 78);
            this.lstSelectedEntities.Name = "lstSelectedEntities";
            this.lstSelectedEntities.Size = new System.Drawing.Size(168, 157);
            this.lstSelectedEntities.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Data Entry Name:";
            // 
            // lblDataEntryComments
            // 
            this.lblDataEntryComments.AutoSize = true;
            this.lblDataEntryComments.Location = new System.Drawing.Point(0, 303);
            this.lblDataEntryComments.Name = "lblDataEntryComments";
            this.lblDataEntryComments.Size = new System.Drawing.Size(64, 13);
            this.lblDataEntryComments.TabIndex = 10;
            this.lblDataEntryComments.Text = "Comments:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 16);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // chkDataEntryUseHex
            // 
            this.chkDataEntryUseHex.AutoSize = true;
            this.chkDataEntryUseHex.Checked = true;
            this.chkDataEntryUseHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataEntryUseHex.Location = new System.Drawing.Point(0, 40);
            this.chkDataEntryUseHex.Name = "chkDataEntryUseHex";
            this.chkDataEntryUseHex.Size = new System.Drawing.Size(103, 17);
            this.chkDataEntryUseHex.TabIndex = 6;
            this.chkDataEntryUseHex.Text = "Use Hex Values";
            this.chkDataEntryUseHex.UseVisualStyleBackColor = true;
            this.chkDataEntryUseHex.CheckedChanged += new System.EventHandler(this.chkDataEntryUseHex_CheckedChanged);
            // 
            // lblCreatePalette
            // 
            this.lblCreatePalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatePalette.Location = new System.Drawing.Point(0, 0);
            this.lblCreatePalette.Name = "lblCreatePalette";
            this.lblCreatePalette.Size = new System.Drawing.Size(694, 557);
            this.lblCreatePalette.TabIndex = 7;
            this.lblCreatePalette.Text = "Create or select a data entry to edit";
            this.lblCreatePalette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDataEntryList
            // 
            this.grpDataEntryList.Controls.Add(this.lstDataEntries);
            this.grpDataEntryList.Controls.Add(this.pnlDataEntryButtons);
            this.grpDataEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataEntryList.Location = new System.Drawing.Point(0, 0);
            this.grpDataEntryList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDataEntryList.Name = "grpDataEntryList";
            this.grpDataEntryList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDataEntryList.Size = new System.Drawing.Size(196, 557);
            this.grpDataEntryList.TabIndex = 0;
            this.grpDataEntryList.TabStop = false;
            this.grpDataEntryList.Text = "Data Entries";
            // 
            // lstDataEntries
            // 
            this.lstDataEntries.DisableHighlighting = false;
            this.lstDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDataEntries.FormattingEnabled = true;
            this.lstDataEntries.HorizontalExtent = 168;
            this.lstDataEntries.IntegralHeight = false;
            this.lstDataEntries.ItemHeight = 15;
            this.lstDataEntries.Location = new System.Drawing.Point(12, 135);
            this.lstDataEntries.Name = "lstDataEntries";
            this.lstDataEntries.Size = new System.Drawing.Size(172, 410);
            this.lstDataEntries.TabIndex = 1;
            this.lstDataEntries.TextOffsetX = 2;
            this.lstDataEntries.TextOffsetY = 0;
            this.lstDataEntries.SelectedIndexChanged += new System.EventHandler(this.lstDataEntries_SelectedIndexChanged);
            // 
            // pnlDataEntryButtons
            // 
            this.pnlDataEntryButtons.Controls.Add(this.btnExport);
            this.pnlDataEntryButtons.Controls.Add(this.btnImport);
            this.pnlDataEntryButtons.Controls.Add(this.btnRemove);
            this.pnlDataEntryButtons.Controls.Add(this.btnDuplicate);
            this.pnlDataEntryButtons.Controls.Add(this.btnNew);
            this.pnlDataEntryButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataEntryButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlDataEntryButtons.Name = "pnlDataEntryButtons";
            this.pnlDataEntryButtons.Size = new System.Drawing.Size(172, 116);
            this.pnlDataEntryButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 92);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 69);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(0, 46);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Data Entry";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 23);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 3;
            this.btnDuplicate.Text = "Duplicate Data Entry";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Data Entry";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 557);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(884, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Data Entry information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuExport
            // 
            this.mnuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportBinary,
            this.mnuExportHex,
            this.mnuExportAssembly});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(239, 70);
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuDataEntry_Click);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuExportHex.Click += new System.EventHandler(this.mnuDataEntry_Click);
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuExportAssembly.Click += new System.EventHandler(this.mnuDataEntry_Click);
            // 
            // AssetDataEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetDataEntryControl";
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.ResumeLayout(false);
            this.pnlDataEntry.ResumeLayout(false);
            this.tpnlDataEntry.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.pnlDataEntryOptions.ResumeLayout(false);
            this.pnlDataEntryOptions.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.grpDataEntryList.ResumeLayout(false);
            this.pnlDataEntryButtons.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.TextBox txtDataEntry;
        private System.Windows.Forms.GroupBox grpDataEntryList;
        private System.Windows.Forms.Panel pnlDataEntryButtons;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDataEntryOptions;
        private System.Windows.Forms.Label lblDataEntryComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkDataEntryUseHex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private ListBoxControl lstDataEntries;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAssembly;
        private System.Windows.Forms.TableLayoutPanel tpnlDataEntry;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Label lblCreatePalette;
        private System.Windows.Forms.CheckedListBox lstSelectedEntities;
        private System.Windows.Forms.Label lblOrderByField;
        private System.Windows.Forms.Button btnPopulateTableData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderByField;
    }
}
