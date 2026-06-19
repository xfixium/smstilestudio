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
            this.tpnlDataEntryOptions = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEntityData = new System.Windows.Forms.Label();
            this.chkDataEntryUseHex = new System.Windows.Forms.CheckBox();
            this.txtOrderByField = new System.Windows.Forms.TextBox();
            this.lstSelectedEntities = new System.Windows.Forms.CheckedListBox();
            this.lblOrderByField = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPopulateTableData = new System.Windows.Forms.Button();
            this.lblDataEntryComments = new System.Windows.Forms.Label();
            this.lblCreatePalette = new System.Windows.Forms.Label();
            this.grpDataEntryList = new System.Windows.Forms.GroupBox();
            this.tpnlDataEntries = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstDataEntries = new SMSTileStudio.Controls.ListBoxControl();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            this.tpnlDataEntry.SuspendLayout();
            this.grpData.SuspendLayout();
            this.tpnlDataEntryOptions.SuspendLayout();
            this.grpDataEntryList.SuspendLayout();
            this.tpnlDataEntries.SuspendLayout();
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
            this.tpnlMain.Size = new System.Drawing.Size(770, 505);
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
            this.pnlDataEntry.Size = new System.Drawing.Size(574, 479);
            this.pnlDataEntry.TabIndex = 14;
            // 
            // tpnlDataEntry
            // 
            this.tpnlDataEntry.ColumnCount = 2;
            this.tpnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlDataEntry.Controls.Add(this.grpData, 0, 0);
            this.tpnlDataEntry.Controls.Add(this.tpnlDataEntryOptions, 1, 0);
            this.tpnlDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDataEntry.Location = new System.Drawing.Point(0, 0);
            this.tpnlDataEntry.Name = "tpnlDataEntry";
            this.tpnlDataEntry.RowCount = 1;
            this.tpnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntry.Size = new System.Drawing.Size(574, 479);
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
            this.grpData.Size = new System.Drawing.Size(382, 479);
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
            this.txtDataEntry.Size = new System.Drawing.Size(358, 444);
            this.txtDataEntry.TabIndex = 0;
            this.txtDataEntry.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // tpnlDataEntryOptions
            // 
            this.tpnlDataEntryOptions.ColumnCount = 1;
            this.tpnlDataEntryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntryOptions.Controls.Add(this.txtName, 0, 1);
            this.tpnlDataEntryOptions.Controls.Add(this.lblEntityData, 0, 3);
            this.tpnlDataEntryOptions.Controls.Add(this.chkDataEntryUseHex, 0, 2);
            this.tpnlDataEntryOptions.Controls.Add(this.txtOrderByField, 0, 6);
            this.tpnlDataEntryOptions.Controls.Add(this.lstSelectedEntities, 0, 4);
            this.tpnlDataEntryOptions.Controls.Add(this.lblOrderByField, 0, 5);
            this.tpnlDataEntryOptions.Controls.Add(this.txtComments, 0, 9);
            this.tpnlDataEntryOptions.Controls.Add(this.lblName, 0, 0);
            this.tpnlDataEntryOptions.Controls.Add(this.btnPopulateTableData, 0, 7);
            this.tpnlDataEntryOptions.Controls.Add(this.lblDataEntryComments, 0, 8);
            this.tpnlDataEntryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDataEntryOptions.Location = new System.Drawing.Point(397, 3);
            this.tpnlDataEntryOptions.Name = "tpnlDataEntryOptions";
            this.tpnlDataEntryOptions.RowCount = 10;
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDataEntryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntryOptions.Size = new System.Drawing.Size(174, 473);
            this.tpnlDataEntryOptions.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(2, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // lblEntityData
            // 
            this.lblEntityData.AutoSize = true;
            this.lblEntityData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityData.Location = new System.Drawing.Point(2, 62);
            this.lblEntityData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblEntityData.Name = "lblEntityData";
            this.lblEntityData.Size = new System.Drawing.Size(170, 16);
            this.lblEntityData.TabIndex = 19;
            this.lblEntityData.Text = "Table From Entity Data:";
            this.lblEntityData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDataEntryUseHex
            // 
            this.chkDataEntryUseHex.AutoSize = true;
            this.chkDataEntryUseHex.Checked = true;
            this.chkDataEntryUseHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataEntryUseHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDataEntryUseHex.Location = new System.Drawing.Point(2, 46);
            this.chkDataEntryUseHex.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.chkDataEntryUseHex.Name = "chkDataEntryUseHex";
            this.chkDataEntryUseHex.Size = new System.Drawing.Size(170, 16);
            this.chkDataEntryUseHex.TabIndex = 6;
            this.chkDataEntryUseHex.Text = "Use Hex Values";
            this.chkDataEntryUseHex.UseVisualStyleBackColor = true;
            this.chkDataEntryUseHex.CheckedChanged += new System.EventHandler(this.chkDataEntryUseHex_CheckedChanged);
            // 
            // txtOrderByField
            // 
            this.txtOrderByField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrderByField.Location = new System.Drawing.Point(2, 263);
            this.txtOrderByField.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderByField.MaxLength = 50;
            this.txtOrderByField.Name = "txtOrderByField";
            this.txtOrderByField.Size = new System.Drawing.Size(170, 22);
            this.txtOrderByField.TabIndex = 20;
            // 
            // lstSelectedEntities
            // 
            this.lstSelectedEntities.CheckOnClick = true;
            this.lstSelectedEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedEntities.FormattingEnabled = true;
            this.lstSelectedEntities.Location = new System.Drawing.Point(2, 82);
            this.lstSelectedEntities.Margin = new System.Windows.Forms.Padding(2);
            this.lstSelectedEntities.Name = "lstSelectedEntities";
            this.lstSelectedEntities.Size = new System.Drawing.Size(170, 159);
            this.lstSelectedEntities.TabIndex = 12;
            // 
            // lblOrderByField
            // 
            this.lblOrderByField.AutoSize = true;
            this.lblOrderByField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderByField.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderByField.Location = new System.Drawing.Point(2, 243);
            this.lblOrderByField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblOrderByField.Name = "lblOrderByField";
            this.lblOrderByField.Size = new System.Drawing.Size(170, 16);
            this.lblOrderByField.TabIndex = 13;
            this.lblOrderByField.Text = "Order By Field:";
            this.lblOrderByField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(2, 331);
            this.txtComments.Margin = new System.Windows.Forms.Padding(2);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(170, 140);
            this.txtComments.TabIndex = 11;
            this.txtComments.TextChanged += new System.EventHandler(this.txtDataEntry_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 14);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Data Entry Name:";
            // 
            // btnPopulateTableData
            // 
            this.btnPopulateTableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPopulateTableData.Location = new System.Drawing.Point(2, 287);
            this.btnPopulateTableData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnPopulateTableData.Name = "btnPopulateTableData";
            this.btnPopulateTableData.Size = new System.Drawing.Size(170, 24);
            this.btnPopulateTableData.TabIndex = 18;
            this.btnPopulateTableData.Text = "Populate Table Data";
            this.btnPopulateTableData.UseVisualStyleBackColor = true;
            this.btnPopulateTableData.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // lblDataEntryComments
            // 
            this.lblDataEntryComments.AutoSize = true;
            this.lblDataEntryComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataEntryComments.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntryComments.Location = new System.Drawing.Point(2, 313);
            this.lblDataEntryComments.Margin = new System.Windows.Forms.Padding(2);
            this.lblDataEntryComments.Name = "lblDataEntryComments";
            this.lblDataEntryComments.Size = new System.Drawing.Size(170, 14);
            this.lblDataEntryComments.TabIndex = 10;
            this.lblDataEntryComments.Text = "Comments:";
            // 
            // lblCreatePalette
            // 
            this.lblCreatePalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatePalette.Location = new System.Drawing.Point(0, 0);
            this.lblCreatePalette.Name = "lblCreatePalette";
            this.lblCreatePalette.Size = new System.Drawing.Size(574, 479);
            this.lblCreatePalette.TabIndex = 7;
            this.lblCreatePalette.Text = "Create or select a data entry to edit";
            this.lblCreatePalette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDataEntryList
            // 
            this.grpDataEntryList.Controls.Add(this.tpnlDataEntries);
            this.grpDataEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataEntryList.Location = new System.Drawing.Point(0, 0);
            this.grpDataEntryList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDataEntryList.Name = "grpDataEntryList";
            this.grpDataEntryList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDataEntryList.Size = new System.Drawing.Size(196, 479);
            this.grpDataEntryList.TabIndex = 0;
            this.grpDataEntryList.TabStop = false;
            this.grpDataEntryList.Text = "Data Entries";
            // 
            // tpnlDataEntries
            // 
            this.tpnlDataEntries.ColumnCount = 1;
            this.tpnlDataEntries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntries.Controls.Add(this.btnExport, 0, 4);
            this.tpnlDataEntries.Controls.Add(this.lstDataEntries, 0, 5);
            this.tpnlDataEntries.Controls.Add(this.btnNew, 0, 0);
            this.tpnlDataEntries.Controls.Add(this.btnImport, 0, 3);
            this.tpnlDataEntries.Controls.Add(this.btnDuplicate, 0, 1);
            this.tpnlDataEntries.Controls.Add(this.btnRemove, 0, 2);
            this.tpnlDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDataEntries.Location = new System.Drawing.Point(12, 19);
            this.tpnlDataEntries.Name = "tpnlDataEntries";
            this.tpnlDataEntries.RowCount = 6;
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDataEntries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDataEntries.Size = new System.Drawing.Size(172, 448);
            this.tpnlDataEntries.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(2, 96);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 24);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // lstDataEntries
            // 
            this.lstDataEntries.DisableHighlighting = false;
            this.lstDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDataEntries.FormattingEnabled = true;
            this.lstDataEntries.HorizontalExtent = 162;
            this.lstDataEntries.IntegralHeight = false;
            this.lstDataEntries.ItemHeight = 15;
            this.lstDataEntries.Location = new System.Drawing.Point(3, 123);
            this.lstDataEntries.Name = "lstDataEntries";
            this.lstDataEntries.Size = new System.Drawing.Size(166, 322);
            this.lstDataEntries.TabIndex = 1;
            this.lstDataEntries.TextOffsetX = 2;
            this.lstDataEntries.TextOffsetY = 0;
            this.lstDataEntries.SelectedIndexChanged += new System.EventHandler(this.lstDataEntries_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(2, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Data Entry";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Location = new System.Drawing.Point(2, 72);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 24);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Data";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicate.Location = new System.Drawing.Point(2, 24);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(168, 24);
            this.btnDuplicate.TabIndex = 3;
            this.btnDuplicate.Text = "Duplicate Data Entry";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(2, 48);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Data Entry";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(764, 26);
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
            this.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.ResumeLayout(false);
            this.pnlDataEntry.ResumeLayout(false);
            this.tpnlDataEntry.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.tpnlDataEntryOptions.ResumeLayout(false);
            this.tpnlDataEntryOptions.PerformLayout();
            this.grpDataEntryList.ResumeLayout(false);
            this.tpnlDataEntries.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.TextBox txtDataEntry;
        private System.Windows.Forms.GroupBox grpDataEntryList;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDataEntryComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkDataEntryUseHex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private ListBoxControl lstDataEntries;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblInfo;
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
        private System.Windows.Forms.Label lblEntityData;
        private System.Windows.Forms.TextBox txtOrderByField;
        private System.Windows.Forms.TableLayoutPanel tpnlDataEntryOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlDataEntries;
    }
}
