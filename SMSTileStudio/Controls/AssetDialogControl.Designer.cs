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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetDialogControl));
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpDialogList = new System.Windows.Forms.GroupBox();
            this.lstDialogs = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
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
            this.pnlSpriteOptions = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.btnCharacterMapOptions = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudColumn = new System.Windows.Forms.NumericUpDown();
            this.btnDialogPaste = new System.Windows.Forms.Button();
            this.btnDialogCopy = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblCharacterMap = new System.Windows.Forms.Label();
            this.pnlTextEditor = new System.Windows.Forms.Panel();
            this.pnlSplitter = new System.Windows.Forms.Splitter();
            this.txtTextEditor = new System.Windows.Forms.TextBox();
            this.pnlDialogImage = new SMSTileStudio.Controls.SpriteImageControl();
            this.lblTextEditor = new System.Windows.Forms.Label();
            this.tabTilesetEdit = new System.Windows.Forms.TabPage();
            this.tpnlTileset = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilesetOptions = new System.Windows.Forms.Panel();
            this.btnPasteTileset = new System.Windows.Forms.Button();
            this.btnCopyTileset = new System.Windows.Forms.Button();
            this.btnDeselectTile = new System.Windows.Forms.Button();
            this.btnRemoveTile = new System.Windows.Forms.Button();
            this.chkTilesetGrid = new System.Windows.Forms.CheckBox();
            this.btnAddTile = new System.Windows.Forms.Button();
            this.chkTilesetIndexes = new System.Windows.Forms.CheckBox();
            this.pnlSPRPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlSelectedTile = new SMSTileStudio.Controls.TileControl();
            this.btnSwapSelectedPixel = new System.Windows.Forms.Button();
            this.lblSelectedTile = new System.Windows.Forms.Label();
            this.lblTilesetCompression = new System.Windows.Forms.Label();
            this.cbTilesetCompression = new System.Windows.Forms.ComboBox();
            this.lblSPRPalette = new System.Windows.Forms.Label();
            this.cbSPRPalette = new System.Windows.Forms.ComboBox();
            this.lblBGPalette = new System.Windows.Forms.Label();
            this.cbBGPalette = new System.Windows.Forms.ComboBox();
            this.pnlTilesetEditor = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
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
            this.pnlButtons.SuspendLayout();
            this.pnlDialogEdit.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDialogEdit.SuspendLayout();
            this.tpnlDialog.SuspendLayout();
            this.pnlDialogOptions.SuspendLayout();
            this.pnlSpriteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.pnlTextEditor.SuspendLayout();
            this.tabTilesetEdit.SuspendLayout();
            this.tpnlTileset.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            this.pnlTilesetEditor.SuspendLayout();
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
            this.tpnlMain.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 557);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(884, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No dialog information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDialogList
            // 
            this.grpDialogList.Controls.Add(this.lstDialogs);
            this.grpDialogList.Controls.Add(this.pnlButtons);
            this.grpDialogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDialogList.Location = new System.Drawing.Point(0, 0);
            this.grpDialogList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDialogList.Name = "grpDialogList";
            this.grpDialogList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDialogList.Size = new System.Drawing.Size(196, 557);
            this.grpDialogList.TabIndex = 0;
            this.grpDialogList.TabStop = false;
            this.grpDialogList.Text = "Dialogs";
            // 
            // lstDialogs
            // 
            this.lstDialogs.DisableHighlighting = false;
            this.lstDialogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDialogs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDialogs.FormattingEnabled = true;
            this.lstDialogs.HorizontalExtent = 168;
            this.lstDialogs.IntegralHeight = false;
            this.lstDialogs.ItemHeight = 15;
            this.lstDialogs.Location = new System.Drawing.Point(12, 136);
            this.lstDialogs.Name = "lstDialogs";
            this.lstDialogs.Size = new System.Drawing.Size(172, 409);
            this.lstDialogs.TabIndex = 1;
            this.lstDialogs.TextOffsetX = 2;
            this.lstDialogs.TextOffsetY = 0;
            this.lstDialogs.SelectedIndexChanged += new System.EventHandler(this.lstDialogs_SelectedIndexChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExport);
            this.pnlButtons.Controls.Add(this.btnImport);
            this.pnlButtons.Controls.Add(this.btnRemove);
            this.pnlButtons.Controls.Add(this.btnDuplicate);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(172, 117);
            this.pnlButtons.TabIndex = 0;
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
            this.btnExport.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 69);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import Graphics";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(0, 46);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Dialog";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 23);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 1;
            this.btnDuplicate.Text = "Duplicate Dialog";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
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
            this.pnlDialogEdit.Size = new System.Drawing.Size(688, 551);
            this.pnlDialogEdit.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDialogEdit);
            this.tabMain.Controls.Add(this.tabTilesetEdit);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(688, 551);
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
            this.tabDialogEdit.Size = new System.Drawing.Size(680, 525);
            this.tabDialogEdit.TabIndex = 0;
            this.tabDialogEdit.Text = "Dialog Edit";
            // 
            // tpnlDialog
            // 
            this.tpnlDialog.ColumnCount = 2;
            this.tpnlDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlDialog.Controls.Add(this.pnlDialogOptions, 1, 0);
            this.tpnlDialog.Controls.Add(this.pnlTextEditor, 0, 0);
            this.tpnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlDialog.Location = new System.Drawing.Point(3, 3);
            this.tpnlDialog.Name = "tpnlDialog";
            this.tpnlDialog.RowCount = 1;
            this.tpnlDialog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlDialog.Size = new System.Drawing.Size(674, 519);
            this.tpnlDialog.TabIndex = 0;
            // 
            // pnlDialogOptions
            // 
            this.pnlDialogOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDialogOptions.Controls.Add(this.pnlCharacters);
            this.pnlDialogOptions.Controls.Add(this.pnlSpriteOptions);
            this.pnlDialogOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialogOptions.Location = new System.Drawing.Point(494, 0);
            this.pnlDialogOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDialogOptions.Name = "pnlDialogOptions";
            this.pnlDialogOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlDialogOptions.Size = new System.Drawing.Size(180, 519);
            this.pnlDialogOptions.TabIndex = 4;
            // 
            // pnlCharacters
            // 
            this.pnlCharacters.AutoScroll = true;
            this.pnlCharacters.CharacterMap = null;
            this.pnlCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCharacters.Location = new System.Drawing.Point(8, 200);
            this.pnlCharacters.Name = "pnlCharacters";
            this.pnlCharacters.Size = new System.Drawing.Size(172, 319);
            this.pnlCharacters.TabIndex = 4;
            this.pnlCharacters.CharacterMapChanged += new SMSTileStudio.Controls.CharacterControl.CharacterMapChangedHandler(this.pnlCharacters_CharacterMapChanged);
            // 
            // pnlSpriteOptions
            // 
            this.pnlSpriteOptions.Controls.Add(this.lblDuration);
            this.pnlSpriteOptions.Controls.Add(this.nudDuration);
            this.pnlSpriteOptions.Controls.Add(this.btnCharacterMapOptions);
            this.pnlSpriteOptions.Controls.Add(this.lblRow);
            this.pnlSpriteOptions.Controls.Add(this.lblColumn);
            this.pnlSpriteOptions.Controls.Add(this.nudRow);
            this.pnlSpriteOptions.Controls.Add(this.nudColumn);
            this.pnlSpriteOptions.Controls.Add(this.btnDialogPaste);
            this.pnlSpriteOptions.Controls.Add(this.btnDialogCopy);
            this.pnlSpriteOptions.Controls.Add(this.lblName);
            this.pnlSpriteOptions.Controls.Add(this.lblOffset);
            this.pnlSpriteOptions.Controls.Add(this.txtName);
            this.pnlSpriteOptions.Controls.Add(this.nudOffset);
            this.pnlSpriteOptions.Controls.Add(this.lblCharacterMap);
            this.pnlSpriteOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpriteOptions.Location = new System.Drawing.Point(8, 0);
            this.pnlSpriteOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlSpriteOptions.Name = "pnlSpriteOptions";
            this.pnlSpriteOptions.Size = new System.Drawing.Size(172, 200);
            this.pnlSpriteOptions.TabIndex = 3;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(86, 40);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(90, 13);
            this.lblDuration.TabIndex = 50;
            this.lblDuration.Text = "Frame Duration:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(88, 56);
            this.nudDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(80, 22);
            this.nudDuration.TabIndex = 51;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // btnCharacterMapOptions
            // 
            this.btnCharacterMapOptions.Location = new System.Drawing.Point(0, 168);
            this.btnCharacterMapOptions.Name = "btnCharacterMapOptions";
            this.btnCharacterMapOptions.Size = new System.Drawing.Size(168, 23);
            this.btnCharacterMapOptions.TabIndex = 49;
            this.btnCharacterMapOptions.Text = "Character Map Options";
            this.btnCharacterMapOptions.UseVisualStyleBackColor = true;
            this.btnCharacterMapOptions.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(88, 80);
            this.lblRow.Margin = new System.Windows.Forms.Padding(0);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(77, 13);
            this.lblRow.TabIndex = 48;
            this.lblRow.Text = "Starting Row:";
            this.lblRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(0, 80);
            this.lblColumn.Margin = new System.Windows.Forms.Padding(0);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(71, 13);
            this.lblColumn.TabIndex = 47;
            this.lblColumn.Text = "Starting Col:";
            this.lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(88, 96);
            this.nudRow.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(80, 22);
            this.nudRow.TabIndex = 46;
            this.nudRow.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // nudColumn
            // 
            this.nudColumn.Location = new System.Drawing.Point(0, 96);
            this.nudColumn.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColumn.Name = "nudColumn";
            this.nudColumn.Size = new System.Drawing.Size(80, 22);
            this.nudColumn.TabIndex = 45;
            this.nudColumn.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // btnDialogPaste
            // 
            this.btnDialogPaste.Location = new System.Drawing.Point(84, 144);
            this.btnDialogPaste.Name = "btnDialogPaste";
            this.btnDialogPaste.Size = new System.Drawing.Size(84, 23);
            this.btnDialogPaste.TabIndex = 44;
            this.btnDialogPaste.Text = "Paste";
            this.btnDialogPaste.UseVisualStyleBackColor = true;
            this.btnDialogPaste.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDialogCopy
            // 
            this.btnDialogCopy.Location = new System.Drawing.Point(0, 144);
            this.btnDialogCopy.Name = "btnDialogCopy";
            this.btnDialogCopy.Size = new System.Drawing.Size(84, 23);
            this.btnDialogCopy.TabIndex = 43;
            this.btnDialogCopy.Text = "Copy";
            this.btnDialogCopy.UseVisualStyleBackColor = true;
            this.btnDialogCopy.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Dialog Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(0, 40);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(77, 13);
            this.lblOffset.TabIndex = 2;
            this.lblOffset.Text = "Tile ID Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 16);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtDialog_TextChanged);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(0, 56);
            this.nudOffset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(80, 22);
            this.nudOffset.TabIndex = 3;
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudDialog_ValueChanged);
            // 
            // lblCharacterMap
            // 
            this.lblCharacterMap.AutoSize = true;
            this.lblCharacterMap.Location = new System.Drawing.Point(0, 128);
            this.lblCharacterMap.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharacterMap.Name = "lblCharacterMap";
            this.lblCharacterMap.Size = new System.Drawing.Size(85, 13);
            this.lblCharacterMap.TabIndex = 4;
            this.lblCharacterMap.Text = "Character Map:";
            this.lblCharacterMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlTextEditor.Size = new System.Drawing.Size(494, 519);
            this.pnlTextEditor.TabIndex = 5;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 248);
            this.pnlSplitter.MinExtra = 128;
            this.pnlSplitter.MinSize = 128;
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(494, 8);
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
            this.txtTextEditor.Size = new System.Drawing.Size(494, 232);
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
            this.pnlDialogImage.Location = new System.Drawing.Point(0, 256);
            this.pnlDialogImage.MinimumScale = 1;
            this.pnlDialogImage.Name = "pnlDialogImage";
            this.pnlDialogImage.Size = new System.Drawing.Size(494, 263);
            this.pnlDialogImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlDialogImage.TabIndex = 6;
            this.pnlDialogImage.UseCanvas = false;
            this.pnlDialogImage.UseHatch = true;
            this.pnlDialogImage.UseMouseWheelScaling = true;
            // 
            // lblTextEditor
            // 
            this.lblTextEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextEditor.Location = new System.Drawing.Point(0, 0);
            this.lblTextEditor.Name = "lblTextEditor";
            this.lblTextEditor.Size = new System.Drawing.Size(494, 24);
            this.lblTextEditor.TabIndex = 7;
            this.lblTextEditor.Text = "Text Editor";
            this.lblTextEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTilesetEdit
            // 
            this.tabTilesetEdit.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilesetEdit.Controls.Add(this.tpnlTileset);
            this.tabTilesetEdit.Location = new System.Drawing.Point(4, 22);
            this.tabTilesetEdit.Name = "tabTilesetEdit";
            this.tabTilesetEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesetEdit.Size = new System.Drawing.Size(680, 525);
            this.tabTilesetEdit.TabIndex = 1;
            this.tabTilesetEdit.Text = "Tileset Edit";
            // 
            // tpnlTileset
            // 
            this.tpnlTileset.ColumnCount = 2;
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlTileset.Controls.Add(this.pnlTilesetOptions, 1, 0);
            this.tpnlTileset.Controls.Add(this.pnlTilesetEditor, 0, 0);
            this.tpnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileset.Location = new System.Drawing.Point(3, 3);
            this.tpnlTileset.Name = "tpnlTileset";
            this.tpnlTileset.RowCount = 1;
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.Size = new System.Drawing.Size(674, 519);
            this.tpnlTileset.TabIndex = 0;
            // 
            // pnlTilesetOptions
            // 
            this.pnlTilesetOptions.Controls.Add(this.btnPasteTileset);
            this.pnlTilesetOptions.Controls.Add(this.btnCopyTileset);
            this.pnlTilesetOptions.Controls.Add(this.btnDeselectTile);
            this.pnlTilesetOptions.Controls.Add(this.btnRemoveTile);
            this.pnlTilesetOptions.Controls.Add(this.chkTilesetGrid);
            this.pnlTilesetOptions.Controls.Add(this.btnAddTile);
            this.pnlTilesetOptions.Controls.Add(this.chkTilesetIndexes);
            this.pnlTilesetOptions.Controls.Add(this.pnlSPRPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlBGPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.btnSwapSelectedPixel);
            this.pnlTilesetOptions.Controls.Add(this.lblSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.cbTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.lblSPRPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbSPRPalette);
            this.pnlTilesetOptions.Controls.Add(this.lblBGPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbBGPalette);
            this.pnlTilesetOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetOptions.Location = new System.Drawing.Point(494, 0);
            this.pnlTilesetOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilesetOptions.Name = "pnlTilesetOptions";
            this.pnlTilesetOptions.Size = new System.Drawing.Size(180, 519);
            this.pnlTilesetOptions.TabIndex = 3;
            // 
            // btnPasteTileset
            // 
            this.btnPasteTileset.Location = new System.Drawing.Point(92, 72);
            this.btnPasteTileset.Name = "btnPasteTileset";
            this.btnPasteTileset.Size = new System.Drawing.Size(84, 23);
            this.btnPasteTileset.TabIndex = 42;
            this.btnPasteTileset.Text = "Paste";
            this.btnPasteTileset.UseVisualStyleBackColor = true;
            this.btnPasteTileset.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnCopyTileset
            // 
            this.btnCopyTileset.Location = new System.Drawing.Point(8, 72);
            this.btnCopyTileset.Name = "btnCopyTileset";
            this.btnCopyTileset.Size = new System.Drawing.Size(84, 23);
            this.btnCopyTileset.TabIndex = 41;
            this.btnCopyTileset.Text = "Copy";
            this.btnCopyTileset.UseVisualStyleBackColor = true;
            this.btnCopyTileset.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDeselectTile
            // 
            this.btnDeselectTile.Location = new System.Drawing.Point(8, 48);
            this.btnDeselectTile.Name = "btnDeselectTile";
            this.btnDeselectTile.Size = new System.Drawing.Size(168, 23);
            this.btnDeselectTile.TabIndex = 40;
            this.btnDeselectTile.Text = "Deselect Tile";
            this.btnDeselectTile.UseVisualStyleBackColor = true;
            this.btnDeselectTile.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnRemoveTile
            // 
            this.btnRemoveTile.Location = new System.Drawing.Point(8, 24);
            this.btnRemoveTile.Name = "btnRemoveTile";
            this.btnRemoveTile.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveTile.TabIndex = 39;
            this.btnRemoveTile.Text = "Remove Selected Tile";
            this.btnRemoveTile.UseVisualStyleBackColor = true;
            this.btnRemoveTile.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // chkTilesetGrid
            // 
            this.chkTilesetGrid.AutoSize = true;
            this.chkTilesetGrid.Checked = true;
            this.chkTilesetGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetGrid.Location = new System.Drawing.Point(10, 96);
            this.chkTilesetGrid.Name = "chkTilesetGrid";
            this.chkTilesetGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetGrid.TabIndex = 31;
            this.chkTilesetGrid.Text = "Grid";
            this.chkTilesetGrid.UseVisualStyleBackColor = true;
            // 
            // btnAddTile
            // 
            this.btnAddTile.Location = new System.Drawing.Point(8, 0);
            this.btnAddTile.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTile.Name = "btnAddTile";
            this.btnAddTile.Size = new System.Drawing.Size(168, 23);
            this.btnAddTile.TabIndex = 38;
            this.btnAddTile.Text = "Add Empty Tile";
            this.btnAddTile.UseVisualStyleBackColor = true;
            this.btnAddTile.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // chkTilesetIndexes
            // 
            this.chkTilesetIndexes.AutoSize = true;
            this.chkTilesetIndexes.Location = new System.Drawing.Point(58, 96);
            this.chkTilesetIndexes.Name = "chkTilesetIndexes";
            this.chkTilesetIndexes.Size = new System.Drawing.Size(97, 17);
            this.chkTilesetIndexes.TabIndex = 32;
            this.chkTilesetIndexes.Text = "Show Indexes";
            this.chkTilesetIndexes.UseVisualStyleBackColor = true;
            // 
            // pnlSPRPalette
            // 
            this.pnlSPRPalette.Location = new System.Drawing.Point(8, 240);
            this.pnlSPRPalette.Name = "pnlSPRPalette";
            this.pnlSPRPalette.ReadOnly = false;
            this.pnlSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSPRPalette.TabIndex = 37;
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 160);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 36;
            // 
            // pnlSelectedTile
            // 
            this.pnlSelectedTile.AutoScroll = true;
            this.pnlSelectedTile.AutoScrollMinSize = new System.Drawing.Size(144, 144);
            this.pnlSelectedTile.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSelectedTile.Centered = false;
            this.pnlSelectedTile.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSelectedTile.HatchForeColor = System.Drawing.Color.White;
            this.pnlSelectedTile.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSelectedTile.Image = null;
            this.pnlSelectedTile.ImageAlpha = 1F;
            this.pnlSelectedTile.ImageScale = 1;
            this.pnlSelectedTile.Location = new System.Drawing.Point(20, 336);
            this.pnlSelectedTile.MinimumScale = 1;
            this.pnlSelectedTile.Name = "pnlSelectedTile";
            this.pnlSelectedTile.Palette = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pnlSelectedTile.Palette")));
            this.pnlSelectedTile.Pixels = ((System.Collections.Generic.List<byte>)(resources.GetObject("pnlSelectedTile.Pixels")));
            this.pnlSelectedTile.SelectedColor = ((byte)(255));
            this.pnlSelectedTile.SelectedTileID = 0;
            this.pnlSelectedTile.Size = new System.Drawing.Size(144, 144);
            this.pnlSelectedTile.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSelectedTile.TabIndex = 34;
            this.pnlSelectedTile.TargetColor = ((byte)(255));
            this.pnlSelectedTile.UseCanvas = false;
            this.pnlSelectedTile.UseHatch = true;
            this.pnlSelectedTile.UseMouseWheelScaling = false;
            // 
            // btnSwapSelectedPixel
            // 
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(8, 484);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(168, 23);
            this.btnSwapSelectedPixel.TabIndex = 35;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            this.btnSwapSelectedPixel.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // lblSelectedTile
            // 
            this.lblSelectedTile.AutoSize = true;
            this.lblSelectedTile.Location = new System.Drawing.Point(8, 320);
            this.lblSelectedTile.Name = "lblSelectedTile";
            this.lblSelectedTile.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedTile.TabIndex = 33;
            this.lblSelectedTile.Text = "Selected Tile:";
            // 
            // lblTilesetCompression
            // 
            this.lblTilesetCompression.AutoSize = true;
            this.lblTilesetCompression.Location = new System.Drawing.Point(8, 280);
            this.lblTilesetCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetCompression.Name = "lblTilesetCompression";
            this.lblTilesetCompression.Size = new System.Drawing.Size(77, 13);
            this.lblTilesetCompression.TabIndex = 29;
            this.lblTilesetCompression.Text = "Compression:";
            this.lblTilesetCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilesetCompression
            // 
            this.cbTilesetCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetCompression.FormattingEnabled = true;
            this.cbTilesetCompression.Location = new System.Drawing.Point(8, 296);
            this.cbTilesetCompression.Name = "cbTilesetCompression";
            this.cbTilesetCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilesetCompression.TabIndex = 30;
            // 
            // lblSPRPalette
            // 
            this.lblSPRPalette.AutoSize = true;
            this.lblSPRPalette.Location = new System.Drawing.Point(8, 200);
            this.lblSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSPRPalette.Name = "lblSPRPalette";
            this.lblSPRPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSPRPalette.TabIndex = 27;
            this.lblSPRPalette.Text = "Sprite Palette:";
            this.lblSPRPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSPRPalette
            // 
            this.cbSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPRPalette.FormattingEnabled = true;
            this.cbSPRPalette.Location = new System.Drawing.Point(8, 216);
            this.cbSPRPalette.Name = "cbSPRPalette";
            this.cbSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSPRPalette.TabIndex = 28;
            // 
            // lblBGPalette
            // 
            this.lblBGPalette.AutoSize = true;
            this.lblBGPalette.Location = new System.Drawing.Point(8, 120);
            this.lblBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblBGPalette.Name = "lblBGPalette";
            this.lblBGPalette.Size = new System.Drawing.Size(110, 13);
            this.lblBGPalette.TabIndex = 25;
            this.lblBGPalette.Text = "Background Palette:";
            this.lblBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBGPalette
            // 
            this.cbBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBGPalette.FormattingEnabled = true;
            this.cbBGPalette.Location = new System.Drawing.Point(8, 136);
            this.cbBGPalette.Name = "cbBGPalette";
            this.cbBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbBGPalette.TabIndex = 26;
            // 
            // pnlTilesetEditor
            // 
            this.pnlTilesetEditor.Controls.Add(this.pnlTilesetEdit);
            this.pnlTilesetEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlTilesetEditor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilesetEditor.Name = "pnlTilesetEditor";
            this.pnlTilesetEditor.Size = new System.Drawing.Size(494, 519);
            this.pnlTilesetEditor.TabIndex = 2;
            // 
            // pnlTilesetEdit
            // 
            this.pnlTilesetEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilesetEdit.Centered = true;
            this.pnlTilesetEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilesetEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilesetEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilesetEdit.Image = null;
            this.pnlTilesetEdit.ImageAlpha = 1F;
            this.pnlTilesetEdit.ImageScale = 1;
            this.pnlTilesetEdit.Indexed = false;
            this.pnlTilesetEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlTilesetEdit.MinimumScale = 1;
            this.pnlTilesetEdit.Name = "pnlTilesetEdit";
            this.pnlTilesetEdit.Size = new System.Drawing.Size(494, 519);
            this.pnlTilesetEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetEdit.TabIndex = 2;
            this.pnlTilesetEdit.UseCanvas = false;
            this.pnlTilesetEdit.UseGrid = true;
            this.pnlTilesetEdit.UseHatch = true;
            this.pnlTilesetEdit.UseMouseWheelScaling = true;
            // 
            // lblCreateDialog
            // 
            this.lblCreateDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateDialog.Location = new System.Drawing.Point(0, 0);
            this.lblCreateDialog.Name = "lblCreateDialog";
            this.lblCreateDialog.Size = new System.Drawing.Size(688, 551);
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
            this.mnuExport.Size = new System.Drawing.Size(240, 70);
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuExportHex.Click += new System.EventHandler(this.mnuDialog_Click);
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(239, 22);
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
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.ResumeLayout(false);
            this.grpDialogList.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlDialogEdit.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabDialogEdit.ResumeLayout(false);
            this.tpnlDialog.ResumeLayout(false);
            this.pnlDialogOptions.ResumeLayout(false);
            this.pnlSpriteOptions.ResumeLayout(false);
            this.pnlSpriteOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.pnlTextEditor.ResumeLayout(false);
            this.pnlTextEditor.PerformLayout();
            this.tabTilesetEdit.ResumeLayout(false);
            this.tpnlTileset.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            this.pnlTilesetEditor.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.mnuCharacterMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpDialogList;
        private ListBoxControl lstDialogs;
        private System.Windows.Forms.Panel pnlButtons;
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
        private System.Windows.Forms.Panel pnlSpriteOptions;
        private System.Windows.Forms.Panel pnlTextEditor;
        private System.Windows.Forms.Splitter pnlSplitter;
        private SpriteImageControl pnlDialogImage;
        private System.Windows.Forms.Label lblTextEditor;
        private System.Windows.Forms.TabPage tabTilesetEdit;
        private System.Windows.Forms.TableLayoutPanel tpnlTileset;
        private System.Windows.Forms.Panel pnlTilesetOptions;
        private System.Windows.Forms.Panel pnlTilesetEditor;
        private TilesetImageControl pnlTilesetEdit;
        private System.Windows.Forms.Button btnPasteTileset;
        private System.Windows.Forms.Button btnCopyTileset;
        private System.Windows.Forms.Button btnDeselectTile;
        private System.Windows.Forms.Button btnRemoveTile;
        private System.Windows.Forms.CheckBox chkTilesetGrid;
        private System.Windows.Forms.Button btnAddTile;
        private System.Windows.Forms.CheckBox chkTilesetIndexes;
        private PaletteControl pnlSPRPalette;
        private PaletteControl pnlBGPalette;
        private TileControl pnlSelectedTile;
        private System.Windows.Forms.Button btnSwapSelectedPixel;
        private System.Windows.Forms.Label lblSelectedTile;
        private System.Windows.Forms.Label lblTilesetCompression;
        private System.Windows.Forms.ComboBox cbTilesetCompression;
        private System.Windows.Forms.Label lblSPRPalette;
        private System.Windows.Forms.ComboBox cbSPRPalette;
        private System.Windows.Forms.Label lblBGPalette;
        private System.Windows.Forms.ComboBox cbBGPalette;
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
    }
}
