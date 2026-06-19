namespace SMSTileStudio.Controls
{
    partial class AssetEntityControl
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
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlEditor = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.tpnlFields = new System.Windows.Forms.TableLayoutPanel();
            this.tpnlEntityOptions = new System.Windows.Forms.TableLayoutPanel();
            this.chkUseHex = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblDataEntryComments = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstEntities = new SMSTileStudio.Controls.ListBoxControl();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpEntities = new System.Windows.Forms.GroupBox();
            this.tpnlEntities = new System.Windows.Forms.TableLayoutPanel();
            this.lblCreateEntity = new System.Windows.Forms.Label();
            this.pnlEntity = new System.Windows.Forms.Panel();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlEditor.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.tpnlEntityOptions.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.grpEntities.SuspendLayout();
            this.tpnlEntities.SuspendLayout();
            this.pnlEntity.SuspendLayout();
            this.tpnlMain.SuspendLayout();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // tpnlEditor
            // 
            this.tpnlEditor.ColumnCount = 2;
            this.tpnlEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tpnlEditor.Controls.Add(this.pnlEditor, 0, 0);
            this.tpnlEditor.Controls.Add(this.tpnlEntityOptions, 1, 0);
            this.tpnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlEditor.Location = new System.Drawing.Point(0, 0);
            this.tpnlEditor.Name = "tpnlEditor";
            this.tpnlEditor.RowCount = 1;
            this.tpnlEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEditor.Size = new System.Drawing.Size(574, 479);
            this.tpnlEditor.TabIndex = 13;
            this.tpnlEditor.Visible = false;
            // 
            // pnlEditor
            // 
            this.pnlEditor.AutoScroll = true;
            this.pnlEditor.Controls.Add(this.tpnlFields);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pnlEditor.Size = new System.Drawing.Size(414, 479);
            this.pnlEditor.TabIndex = 3;
            // 
            // tpnlFields
            // 
            this.tpnlFields.AutoSize = true;
            this.tpnlFields.ColumnCount = 6;
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlFields.Location = new System.Drawing.Point(8, 8);
            this.tpnlFields.Name = "tpnlFields";
            this.tpnlFields.RowCount = 1;
            this.tpnlFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 557F));
            this.tpnlFields.Size = new System.Drawing.Size(389, 557);
            this.tpnlFields.TabIndex = 4;
            // 
            // tpnlEntityOptions
            // 
            this.tpnlEntityOptions.ColumnCount = 1;
            this.tpnlEntityOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntityOptions.Controls.Add(this.chkUseHex, 0, 3);
            this.tpnlEntityOptions.Controls.Add(this.txtComments, 0, 5);
            this.tpnlEntityOptions.Controls.Add(this.lblDataEntryComments, 0, 4);
            this.tpnlEntityOptions.Controls.Add(this.lblName, 0, 1);
            this.tpnlEntityOptions.Controls.Add(this.txtName, 0, 2);
            this.tpnlEntityOptions.Controls.Add(this.btnAddField, 0, 0);
            this.tpnlEntityOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlEntityOptions.Location = new System.Drawing.Point(417, 3);
            this.tpnlEntityOptions.Name = "tpnlEntityOptions";
            this.tpnlEntityOptions.RowCount = 6;
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntityOptions.Size = new System.Drawing.Size(154, 473);
            this.tpnlEntityOptions.TabIndex = 4;
            // 
            // chkUseHex
            // 
            this.chkUseHex.AutoSize = true;
            this.chkUseHex.Checked = true;
            this.chkUseHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseHex.Location = new System.Drawing.Point(2, 70);
            this.chkUseHex.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.chkUseHex.Name = "chkUseHex";
            this.chkUseHex.Size = new System.Drawing.Size(150, 16);
            this.chkUseHex.TabIndex = 12;
            this.chkUseHex.Text = "Use Hex Values";
            this.chkUseHex.UseVisualStyleBackColor = true;
            this.chkUseHex.CheckedChanged += new System.EventHandler(this.chkEntity_CheckedChanged);
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(3, 107);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(148, 363);
            this.txtComments.TabIndex = 11;
            this.txtComments.TextChanged += new System.EventHandler(this.txtEntity_TextChanged);
            // 
            // lblDataEntryComments
            // 
            this.lblDataEntryComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataEntryComments.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntryComments.Location = new System.Drawing.Point(2, 88);
            this.lblDataEntryComments.Margin = new System.Windows.Forms.Padding(2);
            this.lblDataEntryComments.Name = "lblDataEntryComments";
            this.lblDataEntryComments.Size = new System.Drawing.Size(150, 14);
            this.lblDataEntryComments.TabIndex = 10;
            this.lblDataEntryComments.Text = "Comments:";
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 14);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Entity Name:";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(2, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtEntity_TextChanged);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(2, 0);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(150, 24);
            this.btnAddField.TabIndex = 2;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnEntity_Click);
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
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(764, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Entity information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImport
            // 
            this.tpnlEntities.SetColumnSpan(this.btnImport, 2);
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Location = new System.Drawing.Point(2, 72);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 24);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import Entities";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnRemove
            // 
            this.tpnlEntities.SetColumnSpan(this.btnRemove, 2);
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(2, 48);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Entity";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnDuplicate
            // 
            this.tpnlEntities.SetColumnSpan(this.btnDuplicate, 2);
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicate.Location = new System.Drawing.Point(2, 24);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(168, 24);
            this.btnDuplicate.TabIndex = 3;
            this.btnDuplicate.Text = "Duplicate Entity";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnNew
            // 
            this.tpnlEntities.SetColumnSpan(this.btnNew, 2);
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(2, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Entity";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // lstEntities
            // 
            this.tpnlEntities.SetColumnSpan(this.lstEntities, 2);
            this.lstEntities.DisableHighlighting = false;
            this.lstEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.HorizontalExtent = 162;
            this.lstEntities.IntegralHeight = false;
            this.lstEntities.ItemHeight = 15;
            this.lstEntities.Location = new System.Drawing.Point(3, 123);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(166, 322);
            this.lstEntities.TabIndex = 1;
            this.lstEntities.TextOffsetX = 2;
            this.lstEntities.TextOffsetY = 0;
            this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.tpnlEntities.SetColumnSpan(this.btnExport, 2);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(2, 96);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 24);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // grpEntities
            // 
            this.grpEntities.Controls.Add(this.tpnlEntities);
            this.grpEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEntities.Location = new System.Drawing.Point(0, 0);
            this.grpEntities.Margin = new System.Windows.Forms.Padding(0);
            this.grpEntities.Name = "grpEntities";
            this.grpEntities.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpEntities.Size = new System.Drawing.Size(196, 479);
            this.grpEntities.TabIndex = 0;
            this.grpEntities.TabStop = false;
            this.grpEntities.Text = "Entities";
            // 
            // tpnlEntities
            // 
            this.tpnlEntities.ColumnCount = 1;
            this.tpnlEntities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntities.Controls.Add(this.btnExport, 0, 4);
            this.tpnlEntities.Controls.Add(this.lstEntities, 0, 5);
            this.tpnlEntities.Controls.Add(this.btnImport, 0, 3);
            this.tpnlEntities.Controls.Add(this.btnNew, 0, 0);
            this.tpnlEntities.Controls.Add(this.btnDuplicate, 0, 1);
            this.tpnlEntities.Controls.Add(this.btnRemove, 0, 2);
            this.tpnlEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlEntities.Location = new System.Drawing.Point(12, 19);
            this.tpnlEntities.Name = "tpnlEntities";
            this.tpnlEntities.RowCount = 6;
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlEntities.Size = new System.Drawing.Size(172, 448);
            this.tpnlEntities.TabIndex = 2;
            // 
            // lblCreateEntity
            // 
            this.lblCreateEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateEntity.Location = new System.Drawing.Point(0, 0);
            this.lblCreateEntity.Name = "lblCreateEntity";
            this.lblCreateEntity.Size = new System.Drawing.Size(574, 479);
            this.lblCreateEntity.TabIndex = 7;
            this.lblCreateEntity.Text = "Create or select an Entity to edit";
            this.lblCreateEntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEntity
            // 
            this.pnlEntity.Controls.Add(this.tpnlEditor);
            this.pnlEntity.Controls.Add(this.lblCreateEntity);
            this.pnlEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntity.Location = new System.Drawing.Point(196, 0);
            this.pnlEntity.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEntity.Name = "pnlEntity";
            this.pnlEntity.Size = new System.Drawing.Size(574, 479);
            this.pnlEntity.TabIndex = 14;
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Controls.Add(this.pnlEntity, 1, 0);
            this.tpnlMain.Controls.Add(this.grpEntities, 0, 0);
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.TabIndex = 13;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoveUp,
            this.mnuMoveDown,
            this.mnuSeparator1,
            this.mnuInsert,
            this.mnuRemove});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(160, 98);
            // 
            // mnuMoveUp
            // 
            this.mnuMoveUp.Name = "mnuMoveUp";
            this.mnuMoveUp.Size = new System.Drawing.Size(159, 22);
            this.mnuMoveUp.Text = "Move Up List";
            this.mnuMoveUp.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // mnuMoveDown
            // 
            this.mnuMoveDown.Name = "mnuMoveDown";
            this.mnuMoveDown.Size = new System.Drawing.Size(159, 22);
            this.mnuMoveDown.Text = "Move Down List";
            this.mnuMoveDown.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(159, 22);
            this.mnuInsert.Text = "Insert New Field";
            this.mnuInsert.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(159, 22);
            this.mnuRemove.Text = "Remove Field";
            this.mnuRemove.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // AssetEntityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetEntityControl";
            this.Size = new System.Drawing.Size(770, 505);
            this.tpnlEditor.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.tpnlEntityOptions.ResumeLayout(false);
            this.tpnlEntityOptions.PerformLayout();
            this.mnuExport.ResumeLayout(false);
            this.grpEntities.ResumeLayout(false);
            this.tpnlEntities.ResumeLayout(false);
            this.pnlEntity.ResumeLayout(false);
            this.tpnlMain.ResumeLayout(false);
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinary;
        private System.Windows.Forms.TableLayoutPanel tpnlEditor;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDataEntryComments;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportHex;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Panel pnlEntity;
        private System.Windows.Forms.Label lblCreateEntity;
        private System.Windows.Forms.GroupBox grpEntities;
        private ListBoxControl lstEntities;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.TableLayoutPanel tpnlFields;
        private System.Windows.Forms.TableLayoutPanel tpnlEntities;
        private System.Windows.Forms.TableLayoutPanel tpnlEntityOptions;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.CheckBox chkUseHex;
    }
}
