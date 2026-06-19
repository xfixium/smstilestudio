namespace SMSTileStudio.Controls
{
    partial class AssetDialogControl
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpDialogList = new System.Windows.Forms.GroupBox();
            this.tpnlDialogs = new System.Windows.Forms.TableLayoutPanel();
            this.lstDialogs = new SMSTileStudio.Controls.ListBoxControl();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlDialogEdit = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDialogEdit = new System.Windows.Forms.TabPage();
            this.tpnlDialog = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDialogOptions = new System.Windows.Forms.Panel();
            this.pnlCharacters = new SMSTileStudio.Controls.CharacterControl();
            this.tpnlDialogOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCharacterMapOptions = new System.Windows.Forms.Button();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.btnDialogPaste = new System.Windows.Forms.Button();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.btnDialogCopy = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCharacterMap = new System.Windows.Forms.Label();
            this.nudColumn = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOffset = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.pnlTextEditor = new System.Windows.Forms.Panel();
            this.pnlSplitter = new System.Windows.Forms.Splitter();
            this.txtTextEditor = new System.Windows.Forms.TextBox();
            this.pnlDialogImage = new SMSTileStudio.Controls.SpriteImageControl();
            this.lblTextEditor = new System.Windows.Forms.Label();
            this.lblCreateDialog = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCharacterMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuReindexCharacters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRemoveCharacters = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpDialogList.SuspendLayout();
            this.tpnlDialogs.SuspendLayout();
            this.pnlDialogEdit.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDialogEdit.SuspendLayout();
            this.tpnlDialog.SuspendLayout();
            this.pnlDialogOptions.SuspendLayout();
            this.tpnlDialogOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.pnlTextEditor.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.mnuCharacterMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Controls.Add(this.grpDialogList, 0, 0);
            this.tpnlMain.Controls.Add(this.pnlDialogEdit, 1, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(764, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Dialog information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDialogList
            // 
            this.grpDialogList.Controls.Add(this.tpnlDialogs);
            this.grpDialogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDialogList.Location = new System.Drawing.Point(0, 0);
            this.grpDialogList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDialogList.Name = "grpDialogList";
            this.grpDialogList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDialogList.Size = new System.Drawing.Size(196, 479);
            this.grpDialogList.TabIndex = 0;
            this.grpDialogList.TabStop = false;
            this.grpDialogList.Text = "Dialogs";
            // 
            // tpnlDialogs
            // 
            this.tpnlDialogs.ColumnCount = 2;
            this.tpnlDialogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlDialogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlDialogs.Controls.Add(this.btnExport, 0, 4);
            this.tpnlDialogs.Controls.Add(this.lstDialogs, 0, 5);
            this.tpnlDialogs.Controls.Add(this.btnNew, 0, 0);
            this.tpnlDialogs.Controls.Add(this.btnImport, 0, 3);
            this.tpnlDialogs.Controls.Add(this.btnDuplicate, 0, 1);
            this.tpnlDialogs.Controls.Add(this.btnRemove, 0, 2);
            this.tpnlDialogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDialogs.Location = new System.Drawing.Point(12, 19);
            this.tpnlDialogs.Name = "tpnlDialogs";
            this.tpnlDialogs.RowCount = 6;
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialogs.Size = new System.Drawing.Size(172, 448);
            this.tpnlDialogs.TabIndex = 2;
            // 
            // lstDialogs
            // 
            this.tpnlDialogs.SetColumnSpan(this.lstDialogs, 2);
            this.lstDialogs.DisableHighlighting = false;
            this.lstDialogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDialogs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDialogs.FormattingEnabled = true;
            this.lstDialogs.HorizontalExtent = 162;
            this.lstDialogs.IntegralHeight = false;
            this.lstDialogs.ItemHeight = 15;
            this.lstDialogs.Location = new System.Drawing.Point(3, 123);
            this.lstDialogs.Name = "lstDialogs";
            this.lstDialogs.Size = new System.Drawing.Size(166, 322);
            this.lstDialogs.TabIndex = 1;
            this.lstDialogs.TextOffsetX = 2;
            this.lstDialogs.TextOffsetY = 0;
            this.lstDialogs.SelectedIndexChanged += new System.EventHandler(this.lstDialogs_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.tpnlDialogs.SetColumnSpan(this.btnExport, 2);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(2, 96);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 24);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnImport
            // 
            this.tpnlDialogs.SetColumnSpan(this.btnImport, 2);
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Location = new System.Drawing.Point(2, 72);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 24);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import Graphics";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnRemove
            // 
            this.tpnlDialogs.SetColumnSpan(this.btnRemove, 2);
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(2, 48);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Dialog";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDuplicate
            // 
            this.tpnlDialogs.SetColumnSpan(this.btnDuplicate, 2);
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicate.Location = new System.Drawing.Point(2, 24);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(168, 24);
            this.btnDuplicate.TabIndex = 1;
            this.btnDuplicate.Text = "Duplicate Dialog";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnNew
            // 
            this.tpnlDialogs.SetColumnSpan(this.btnNew, 2);
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(2, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Dialog";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // pnlDialogEdit
            // 
            this.pnlDialogEdit.Controls.Add(this.tabMain);
            this.pnlDialogEdit.Controls.Add(this.lblCreateDialog);
            this.pnlDialogEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialogEdit.Location = new System.Drawing.Point(199, 3);
            this.pnlDialogEdit.Name = "pnlDialogEdit";
            this.pnlDialogEdit.Size = new System.Drawing.Size(568, 473);
            this.pnlDialogEdit.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDialogEdit);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(568, 473);
            this.tabMain.TabIndex = 7;
            this.tabMain.Visible = false;
            // 
            // tabDialogEdit
            // 
            this.tabDialogEdit.BackColor = System.Drawing.SystemColors.Control;
            this.tabDialogEdit.Controls.Add(this.tpnlDialog);
            this.tabDialogEdit.Location = new System.Drawing.Point(4, 22);
            this.tabDialogEdit.Name = "tabDialogEdit";
            this.tabDialogEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogEdit.Size = new System.Drawing.Size(560, 447);
            this.tabDialogEdit.TabIndex = 0;
            this.tabDialogEdit.Text = "Dialog Edit";
            // 
            // tpnlDialog
            // 
            this.tpnlDialog.ColumnCount = 2;
            this.tpnlDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tpnlDialog.Controls.Add(this.pnlDialogOptions, 1, 0);
            this.tpnlDialog.Controls.Add(this.pnlTextEditor, 0, 0);
            this.tpnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDialog.Location = new System.Drawing.Point(3, 3);
            this.tpnlDialog.Name = "tpnlDialog";
            this.tpnlDialog.RowCount = 1;
            this.tpnlDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialog.Size = new System.Drawing.Size(554, 441);
            this.tpnlDialog.TabIndex = 0;
            // 
            // pnlDialogOptions
            // 
            this.pnlDialogOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDialogOptions.Controls.Add(this.pnlCharacters);
            this.pnlDialogOptions.Controls.Add(this.tpnlDialogOptions);
            this.pnlDialogOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialogOptions.Location = new System.Drawing.Point(364, 0);
            this.pnlDialogOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDialogOptions.Name = "pnlDialogOptions";
            this.pnlDialogOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlDialogOptions.Size = new System.Drawing.Size(190, 441);
            this.pnlDialogOptions.TabIndex = 4;
            // 
            // pnlCharacters
            // 
            this.pnlCharacters.AutoScroll = true;
            this.pnlCharacters.CharacterMap = null;
            this.pnlCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharacters.Location = new System.Drawing.Point(8, 196);
            this.pnlCharacters.Name = "pnlCharacters";
            this.pnlCharacters.Size = new System.Drawing.Size(182, 245);
            this.pnlCharacters.TabIndex = 4;
            this.pnlCharacters.CharacterMapChanged += new SMSTileStudio.Controls.CharacterControl.CharacterMapChangedHandler(this.pnlCharacters_CharacterMapChanged);
            // 
            // tpnlDialogOptions
            // 
            this.tpnlDialogOptions.ColumnCount = 2;
            this.tpnlDialogOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlDialogOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlDialogOptions.Controls.Add(this.btnCharacterMapOptions, 0, 8);
            this.tpnlDialogOptions.Controls.Add(this.nudDuration, 1, 3);
            this.tpnlDialogOptions.Controls.Add(this.btnDialogPaste, 1, 7);
            this.tpnlDialogOptions.Controls.Add(this.nudRow, 1, 5);
            this.tpnlDialogOptions.Controls.Add(this.btnDialogCopy, 0, 7);
            this.tpnlDialogOptions.Controls.Add(this.lblRow, 1, 4);
            this.tpnlDialogOptions.Controls.Add(this.lblCharacterMap, 0, 6);
            this.tpnlDialogOptions.Controls.Add(this.nudColumn, 0, 5);
            this.tpnlDialogOptions.Controls.Add(this.lblDuration, 1, 2);
            this.tpnlDialogOptions.Controls.Add(this.lblColumn, 0, 4);
            this.tpnlDialogOptions.Controls.Add(this.lblName, 0, 0);
            this.tpnlDialogOptions.Controls.Add(this.txtName, 0, 1);
            this.tpnlDialogOptions.Controls.Add(this.lblOffset, 0, 2);
            this.tpnlDialogOptions.Controls.Add(this.nudOffset, 0, 3);
            this.tpnlDialogOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlDialogOptions.Location = new System.Drawing.Point(8, 0);
            this.tpnlDialogOptions.Name = "tpnlDialogOptions";
            this.tpnlDialogOptions.RowCount = 10;
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlDialogOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialogOptions.Size = new System.Drawing.Size(182, 196);
            this.tpnlDialogOptions.TabIndex = 5;
            // 
            // btnCharacterMapOptions
            // 
            this.tpnlDialogOptions.SetColumnSpan(this.btnCharacterMapOptions, 2);
            this.btnCharacterMapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCharacterMapOptions.Location = new System.Drawing.Point(2, 170);
            this.btnCharacterMapOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCharacterMapOptions.Name = "btnCharacterMapOptions";
            this.btnCharacterMapOptions.Size = new System.Drawing.Size(178, 26);
            this.btnCharacterMapOptions.TabIndex = 49;
            this.btnCharacterMapOptions.Text = "Character Map Options";
            this.btnCharacterMapOptions.UseVisualStyleBackColor = true;
            this.btnCharacterMapOptions.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // nudDuration
            // 
            this.nudDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDuration.Location = new System.Drawing.Point(93, 62);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(2);
            this.nudDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(87, 22);
            this.nudDuration.TabIndex = 51;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // btnDialogPaste
            // 
            this.btnDialogPaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDialogPaste.Location = new System.Drawing.Point(93, 144);
            this.btnDialogPaste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDialogPaste.Name = "btnDialogPaste";
            this.btnDialogPaste.Size = new System.Drawing.Size(87, 26);
            this.btnDialogPaste.TabIndex = 44;
            this.btnDialogPaste.Text = "Paste";
            this.btnDialogPaste.UseVisualStyleBackColor = true;
            this.btnDialogPaste.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // nudRow
            // 
            this.nudRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRow.Location = new System.Drawing.Point(93, 104);
            this.nudRow.Margin = new System.Windows.Forms.Padding(2);
            this.nudRow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(87, 22);
            this.nudRow.TabIndex = 46;
            this.nudRow.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // btnDialogCopy
            // 
            this.btnDialogCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDialogCopy.Location = new System.Drawing.Point(2, 144);
            this.btnDialogCopy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDialogCopy.Name = "btnDialogCopy";
            this.btnDialogCopy.Size = new System.Drawing.Size(87, 26);
            this.btnDialogCopy.TabIndex = 43;
            this.btnDialogCopy.Text = "Copy";
            this.btnDialogCopy.UseVisualStyleBackColor = true;
            this.btnDialogCopy.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // lblRow
            // 
            this.lblRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.Location = new System.Drawing.Point(93, 86);
            this.lblRow.Margin = new System.Windows.Forms.Padding(2);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(87, 14);
            this.lblRow.TabIndex = 48;
            this.lblRow.Text = "Starting Row:";
            this.lblRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharacterMap
            // 
            this.tpnlDialogOptions.SetColumnSpan(this.lblCharacterMap, 2);
            this.lblCharacterMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharacterMap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterMap.Location = new System.Drawing.Point(2, 128);
            this.lblCharacterMap.Margin = new System.Windows.Forms.Padding(2);
            this.lblCharacterMap.Name = "lblCharacterMap";
            this.lblCharacterMap.Size = new System.Drawing.Size(178, 14);
            this.lblCharacterMap.TabIndex = 4;
            this.lblCharacterMap.Text = "Character Map:";
            this.lblCharacterMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudColumn
            // 
            this.nudColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudColumn.Location = new System.Drawing.Point(2, 104);
            this.nudColumn.Margin = new System.Windows.Forms.Padding(2);
            this.nudColumn.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColumn.Name = "nudColumn";
            this.nudColumn.Size = new System.Drawing.Size(87, 22);
            this.nudColumn.TabIndex = 45;
            this.nudColumn.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(91, 42);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(91, 18);
            this.lblDuration.TabIndex = 50;
            this.lblDuration.Text = "Frame Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumn
            // 
            this.lblColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColumn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(2, 86);
            this.lblColumn.Margin = new System.Windows.Forms.Padding(2);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(87, 14);
            this.lblColumn.TabIndex = 47;
            this.lblColumn.Text = "Starting Col:";
            this.lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.tpnlDialogOptions.SetColumnSpan(this.lblName, 2);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Dialog Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.tpnlDialogOptions.SetColumnSpan(this.txtName, 2);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(2, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtDialog_TextChanged);
            // 
            // lblOffset
            // 
            this.lblOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOffset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffset.Location = new System.Drawing.Point(2, 44);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(2);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(87, 14);
            this.lblOffset.TabIndex = 2;
            this.lblOffset.Text = "Tile ID Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOffset
            // 
            this.nudOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudOffset.Location = new System.Drawing.Point(2, 62);
            this.nudOffset.Margin = new System.Windows.Forms.Padding(2);
            this.nudOffset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(87, 22);
            this.nudOffset.TabIndex = 3;
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // pnlTextEditor
            // 
            this.pnlTextEditor.Controls.Add(this.pnlSplitter);
            this.pnlTextEditor.Controls.Add(this.txtTextEditor);
            this.pnlTextEditor.Controls.Add(this.pnlDialogImage);
            this.pnlTextEditor.Controls.Add(this.lblTextEditor);
            this.pnlTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlTextEditor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTextEditor.Name = "pnlTextEditor";
            this.pnlTextEditor.Size = new System.Drawing.Size(364, 441);
            this.pnlTextEditor.TabIndex = 5;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 170);
            this.pnlSplitter.MinExtra = 128;
            this.pnlSplitter.MinSize = 128;
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(364, 8);
            this.pnlSplitter.TabIndex = 4;
            this.pnlSplitter.TabStop = false;
            // 
            // txtTextEditor
            // 
            this.txtTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextEditor.Location = new System.Drawing.Point(0, 24);
            this.txtTextEditor.Multiline = true;
            this.txtTextEditor.Name = "txtTextEditor";
            this.txtTextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextEditor.Size = new System.Drawing.Size(364, 154);
            this.txtTextEditor.TabIndex = 6;
            this.txtTextEditor.TextChanged += new System.EventHandler(this.txtDialog_TextChanged);
            // 
            // pnlDialogImage
            // 
            this.pnlDialogImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlDialogImage.Centered = false;
            this.pnlDialogImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDialogImage.EditMode = SMSTileStudio.Data.SpriteModeType.Normal;
            this.pnlDialogImage.FrameIndex = -1;
            this.pnlDialogImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlDialogImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlDialogImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlDialogImage.Image = null;
            this.pnlDialogImage.ImageAlpha = 1F;
            this.pnlDialogImage.ImageScale = 1;
            this.pnlDialogImage.Location = new System.Drawing.Point(0, 178);
            this.pnlDialogImage.MinimumScale = 1;
            this.pnlDialogImage.Name = "pnlDialogImage";
            this.pnlDialogImage.Size = new System.Drawing.Size(364, 263);
            this.pnlDialogImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlDialogImage.TabIndex = 6;
            this.pnlDialogImage.UseCanvas = false;
            this.pnlDialogImage.UseHatch = true;
            this.pnlDialogImage.UseMouseWheelScaling = true;
            // 
            // lblTextEditor
            // 
            this.lblTextEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextEditor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextEditor.Location = new System.Drawing.Point(0, 0);
            this.lblTextEditor.Name = "lblTextEditor";
            this.lblTextEditor.Size = new System.Drawing.Size(364, 24);
            this.lblTextEditor.TabIndex = 7;
            this.lblTextEditor.Text = "Text Editor:";
            this.lblTextEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateDialog
            // 
            this.lblCreateDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateDialog.Location = new System.Drawing.Point(0, 0);
            this.lblCreateDialog.Name = "lblCreateDialog";
            this.lblCreateDialog.Size = new System.Drawing.Size(568, 473);
            this.lblCreateDialog.TabIndex = 6;
            this.lblCreateDialog.Text = "Create or select a dialog to edit";
            this.lblCreateDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuExport
            // 
            this.mnuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportBinary,
            this.mnuExportHex,
            this.mnuExportAssembly});
            this.mnuExport.Name = "mnuExportOptions";
            this.mnuExport.Size = new System.Drawing.Size(239, 70);
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuExportHex.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuExportAssembly.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuCharacterMap
            // 
            this.mnuCharacterMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReindexCharacters,
            this.mnuSeparator,
            this.mnuRemoveCharacters});
            this.mnuCharacterMap.Name = "mnuCharacterMapOptions";
            this.mnuCharacterMap.Size = new System.Drawing.Size(224, 54);
            // 
            // mnuReindexCharacters
            // 
            this.mnuReindexCharacters.Name = "mnuReindexCharacters";
            this.mnuReindexCharacters.Size = new System.Drawing.Size(223, 22);
            this.mnuReindexCharacters.Text = "Re-Index Tile IDs";
            this.mnuReindexCharacters.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuSeparator
            // 
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuRemoveCharacters
            // 
            this.mnuRemoveCharacters.Name = "mnuRemoveCharacters";
            this.mnuRemoveCharacters.Size = new System.Drawing.Size(223, 22);
            this.mnuRemoveCharacters.Text = "Remove Selected Characters";
            this.mnuRemoveCharacters.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // AssetDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetDialogControl";
            this.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.ResumeLayout(false);
            this.grpDialogList.ResumeLayout(false);
            this.tpnlDialogs.ResumeLayout(false);
            this.pnlDialogEdit.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabDialogEdit.ResumeLayout(false);
            this.tpnlDialog.ResumeLayout(false);
            this.pnlDialogOptions.ResumeLayout(false);
            this.tpnlDialogOptions.ResumeLayout(false);
            this.tpnlDialogOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.pnlTextEditor.ResumeLayout(false);
            this.pnlTextEditor.PerformLayout();
            this.mnuExport.ResumeLayout(false);
            this.mnuCharacterMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpDialogList;
        private ListBoxControl lstDialogs;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlDialogEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCreateDialog;
        private System.Windows.Forms.Label lblCharacterMap;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtTextEditor;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDialogEdit;
        private System.Windows.Forms.TableLayoutPanel tpnlDialog;
        private System.Windows.Forms.Panel pnlDialogOptions;
        private System.Windows.Forms.Panel pnlTextEditor;
        private System.Windows.Forms.Splitter pnlSplitter;
        private SpriteImageControl pnlDialogImage;
        private System.Windows.Forms.Label lblTextEditor;
        private System.Windows.Forms.Button btnImport;
        private CharacterControl pnlCharacters;
        private System.Windows.Forms.Button btnDialogPaste;
        private System.Windows.Forms.Button btnDialogCopy;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.NumericUpDown nudColumn;
        private System.Windows.Forms.Button btnCharacterMapOptions;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ContextMenuStrip mnuCharacterMap;
        private System.Windows.Forms.ToolStripMenuItem mnuReindexCharacters;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveCharacters;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAssembly;
        private System.Windows.Forms.TableLayoutPanel tpnlDialogOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlDialogs;
    }
}
