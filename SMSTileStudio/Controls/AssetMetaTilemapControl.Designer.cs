namespace SMSTileStudio.Controls
{
    partial class AssetMetaTilemapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetMetaTilemapControl));
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpImageList = new System.Windows.Forms.GroupBox();
            this.lstTilemaps = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlPaletteButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlPalettes = new System.Windows.Forms.Panel();
            this.lblTilesetExportRange = new System.Windows.Forms.Label();
            this.nudTilesetExportEnd = new System.Windows.Forms.NumericUpDown();
            this.nudTilesetExportStart = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetRangeTo = new System.Windows.Forms.Label();
            this.rbBgPalette = new System.Windows.Forms.RadioButton();
            this.rbSprPalette = new System.Windows.Forms.RadioButton();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTilemap = new System.Windows.Forms.TabPage();
            this.tpnlTilemap = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilemapOptions = new System.Windows.Forms.Panel();
            this.pnlTiles = new SMSTileStudio.Controls.TilesControl();
            this.pnlPaletteOptions = new System.Windows.Forms.Panel();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.chkAttributes = new System.Windows.Forms.CheckBox();
            this.chkTilemapGrid = new System.Windows.Forms.CheckBox();
            this.btnSelectionOptions = new System.Windows.Forms.Button();
            this.btnOptimizeTilemap = new System.Windows.Forms.Button();
            this.btnReplaceTiles = new System.Windows.Forms.Button();
            this.lblHighlighterCountValue = new System.Windows.Forms.Label();
            this.chkHighlighter = new System.Windows.Forms.CheckBox();
            this.lblSelectedTileIDValue = new System.Windows.Forms.Label();
            this.lblSelectedTileID = new System.Windows.Forms.Label();
            this.lblTilemapCompression = new System.Windows.Forms.Label();
            this.cbTilemapCompression = new System.Windows.Forms.ComboBox();
            this.chkUseAttributes = new System.Windows.Forms.CheckBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTilemap = new System.Windows.Forms.Panel();
            this.pnlTilemapEdit = new SMSTileStudio.Controls.TilemapControl();
            this.pnlTilemapToolbar = new System.Windows.Forms.Panel();
            this.nudBits = new System.Windows.Forms.NumericUpDown();
            this.rbBits = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbPalette = new System.Windows.Forms.RadioButton();
            this.rbPriority = new System.Windows.Forms.RadioButton();
            this.rbFlipY = new System.Windows.Forms.RadioButton();
            this.rbFlipX = new System.Windows.Forms.RadioButton();
            this.rbBrush = new System.Windows.Forms.RadioButton();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.tpnlTileset = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilesetOptions = new System.Windows.Forms.Panel();
            this.btnPasteTileset = new System.Windows.Forms.Button();
            this.btnCopyTileset = new System.Windows.Forms.Button();
            this.btnDeselectTile = new System.Windows.Forms.Button();
            this.btnRemoveTile = new System.Windows.Forms.Button();
            this.chkTilesetGrid = new System.Windows.Forms.CheckBox();
            this.btnAddTile = new System.Windows.Forms.Button();
            this.chkTilesetIndexes = new System.Windows.Forms.CheckBox();
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlSelectedTile = new SMSTileStudio.Controls.TileControl();
            this.btnSwapSelectedPixel = new System.Windows.Forms.Button();
            this.lblSelectedTile = new System.Windows.Forms.Label();
            this.lblTilesetCompression = new System.Windows.Forms.Label();
            this.cbTilesetCompression = new System.Windows.Forms.ComboBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.cbSprPalette = new System.Windows.Forms.ComboBox();
            this.lblBgPalette = new System.Windows.Forms.Label();
            this.cbBgPalette = new System.Windows.Forms.ComboBox();
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
            this.lblCreateTilemap = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBgPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPaletteExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaletteExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaletteExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaletteExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetBypassCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetUseMaskColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilesetExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapBypassCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapVerticalOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapReverseVerticalOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetaTilemapExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetaTilemapExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetaTilemapExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapFromSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuImportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpImageList.SuspendLayout();
            this.pnlPaletteButtons.SuspendLayout();
            this.pnlPalettes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.tpnlTilemap.SuspendLayout();
            this.pnlTilemapOptions.SuspendLayout();
            this.pnlPaletteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.pnlTilemap.SuspendLayout();
            this.pnlTilemapToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBits)).BeginInit();
            this.tabTileset.SuspendLayout();
            this.tpnlTileset.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            this.pnlTileset.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.mnuSelectOptions.SuspendLayout();
            this.mnuImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Controls.Add(this.grpImageList, 0, 0);
            this.tpnlMain.Controls.Add(this.pnlMain, 1, 0);
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.TabIndex = 3;
            // 
            // grpImageList
            // 
            this.grpImageList.Controls.Add(this.lstTilemaps);
            this.grpImageList.Controls.Add(this.pnlPaletteButtons);
            this.grpImageList.Controls.Add(this.lblPosition);
            this.grpImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImageList.Location = new System.Drawing.Point(0, 0);
            this.grpImageList.Margin = new System.Windows.Forms.Padding(0);
            this.grpImageList.Name = "grpImageList";
            this.grpImageList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpImageList.Size = new System.Drawing.Size(196, 557);
            this.grpImageList.TabIndex = 0;
            this.grpImageList.TabStop = false;
            this.grpImageList.Text = "Meta Tilemaps";
            // 
            // lstTilemaps
            // 
            this.lstTilemaps.DisableHighlighting = false;
            this.lstTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilemaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilemaps.FormattingEnabled = true;
            this.lstTilemaps.HorizontalExtent = 168;
            this.lstTilemaps.IntegralHeight = false;
            this.lstTilemaps.Location = new System.Drawing.Point(12, 208);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(172, 320);
            this.lstTilemaps.TabIndex = 1;
            this.lstTilemaps.TextOffsetX = 2;
            this.lstTilemaps.TextOffsetY = 0;
            this.lstTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstTilemaps_SelectedIndexChanged);
            // 
            // pnlPaletteButtons
            // 
            this.pnlPaletteButtons.Controls.Add(this.btnExport);
            this.pnlPaletteButtons.Controls.Add(this.btnImport);
            this.pnlPaletteButtons.Controls.Add(this.btnRemove);
            this.pnlPaletteButtons.Controls.Add(this.btnDuplicate);
            this.pnlPaletteButtons.Controls.Add(this.btnNew);
            this.pnlPaletteButtons.Controls.Add(this.pnlPalettes);
            this.pnlPaletteButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaletteButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlPaletteButtons.Name = "pnlPaletteButtons";
            this.pnlPaletteButtons.Size = new System.Drawing.Size(172, 189);
            this.pnlPaletteButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 164);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 141);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Options";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(0, 118);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Meta Tilemap";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 95);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 7;
            this.btnDuplicate.Text = "Duplicate Meta Tilemap";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 72);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Meta Tilemap";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.Controls.Add(this.lblTilesetExportRange);
            this.pnlPalettes.Controls.Add(this.nudTilesetExportEnd);
            this.pnlPalettes.Controls.Add(this.nudTilesetExportStart);
            this.pnlPalettes.Controls.Add(this.lblTilesetRangeTo);
            this.pnlPalettes.Controls.Add(this.rbBgPalette);
            this.pnlPalettes.Controls.Add(this.rbSprPalette);
            this.pnlPalettes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPalettes.Location = new System.Drawing.Point(0, 0);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(172, 72);
            this.pnlPalettes.TabIndex = 11;
            // 
            // lblTilesetExportRange
            // 
            this.lblTilesetExportRange.AutoSize = true;
            this.lblTilesetExportRange.Location = new System.Drawing.Point(4, 28);
            this.lblTilesetExportRange.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetExportRange.Name = "lblTilesetExportRange";
            this.lblTilesetExportRange.Size = new System.Drawing.Size(115, 13);
            this.lblTilesetExportRange.TabIndex = 27;
            this.lblTilesetExportRange.Text = "Tileset Export Range:";
            this.lblTilesetExportRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTilesetExportEnd
            // 
            this.nudTilesetExportEnd.Location = new System.Drawing.Point(96, 46);
            this.nudTilesetExportEnd.Maximum = new decimal(new int[] {
            447,
            0,
            0,
            0});
            this.nudTilesetExportEnd.Name = "nudTilesetExportEnd";
            this.nudTilesetExportEnd.Size = new System.Drawing.Size(72, 22);
            this.nudTilesetExportEnd.TabIndex = 26;
            this.nudTilesetExportEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTilesetExportStart
            // 
            this.nudTilesetExportStart.Location = new System.Drawing.Point(4, 46);
            this.nudTilesetExportStart.Maximum = new decimal(new int[] {
            447,
            0,
            0,
            0});
            this.nudTilesetExportStart.Name = "nudTilesetExportStart";
            this.nudTilesetExportStart.Size = new System.Drawing.Size(68, 22);
            this.nudTilesetExportStart.TabIndex = 25;
            // 
            // lblTilesetRangeTo
            // 
            this.lblTilesetRangeTo.AutoSize = true;
            this.lblTilesetRangeTo.Location = new System.Drawing.Point(75, 51);
            this.lblTilesetRangeTo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetRangeTo.Name = "lblTilesetRangeTo";
            this.lblTilesetRangeTo.Size = new System.Drawing.Size(18, 13);
            this.lblTilesetRangeTo.TabIndex = 24;
            this.lblTilesetRangeTo.Text = "to";
            this.lblTilesetRangeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbBgPalette
            // 
            this.rbBgPalette.AutoSize = true;
            this.rbBgPalette.Checked = true;
            this.rbBgPalette.Location = new System.Drawing.Point(4, 6);
            this.rbBgPalette.Name = "rbBgPalette";
            this.rbBgPalette.Size = new System.Drawing.Size(77, 17);
            this.rbBgPalette.TabIndex = 9;
            this.rbBgPalette.TabStop = true;
            this.rbBgPalette.Text = "BG Palette";
            this.rbBgPalette.UseVisualStyleBackColor = true;
            this.rbBgPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbSprPalette
            // 
            this.rbSprPalette.AutoSize = true;
            this.rbSprPalette.Location = new System.Drawing.Point(84, 6);
            this.rbSprPalette.Name = "rbSprPalette";
            this.rbSprPalette.Size = new System.Drawing.Size(82, 17);
            this.rbSprPalette.TabIndex = 10;
            this.rbSprPalette.Text = "SPR Palette";
            this.rbSprPalette.UseVisualStyleBackColor = true;
            this.rbSprPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPosition.Location = new System.Drawing.Point(12, 528);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(172, 17);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblCreateTilemap);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(199, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(688, 551);
            this.pnlMain.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTilemap);
            this.tabMain.Controls.Add(this.tabTileset);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(688, 551);
            this.tabMain.TabIndex = 0;
            this.tabMain.Visible = false;
            // 
            // tabTilemap
            // 
            this.tabTilemap.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemap.Controls.Add(this.tpnlTilemap);
            this.tabTilemap.Location = new System.Drawing.Point(4, 22);
            this.tabTilemap.Name = "tabTilemap";
            this.tabTilemap.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemap.Size = new System.Drawing.Size(680, 525);
            this.tabTilemap.TabIndex = 0;
            this.tabTilemap.Text = "Tilemap";
            // 
            // tpnlTilemap
            // 
            this.tpnlTilemap.ColumnCount = 2;
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlTilemap.Controls.Add(this.pnlTilemapOptions, 1, 0);
            this.tpnlTilemap.Controls.Add(this.pnlTilemap, 0, 0);
            this.tpnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemap.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilemap.Name = "tpnlTilemap";
            this.tpnlTilemap.RowCount = 1;
            this.tpnlTilemap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.Size = new System.Drawing.Size(674, 519);
            this.tpnlTilemap.TabIndex = 0;
            // 
            // pnlTilemapOptions
            // 
            this.pnlTilemapOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTilemapOptions.Controls.Add(this.pnlTiles);
            this.pnlTilemapOptions.Controls.Add(this.pnlPaletteOptions);
            this.pnlTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemapOptions.Location = new System.Drawing.Point(494, 0);
            this.pnlTilemapOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemapOptions.Name = "pnlTilemapOptions";
            this.pnlTilemapOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlTilemapOptions.Size = new System.Drawing.Size(180, 519);
            this.pnlTilemapOptions.TabIndex = 4;
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(465, 678);
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = false;
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTiles.HatchForeColor = System.Drawing.Color.White;
            this.pnlTiles.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTiles.Image = null;
            this.pnlTiles.ImageAlpha = 1F;
            this.pnlTiles.ImageScale = 3;
            this.pnlTiles.Indexed = false;
            this.pnlTiles.Location = new System.Drawing.Point(8, 276);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(172, 243);
            this.pnlTiles.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTiles.TabIndex = 21;
            this.pnlTiles.TileCount = 0;
            this.pnlTiles.TileID = 0;
            this.pnlTiles.UseCanvas = false;
            this.pnlTiles.UseGrid = true;
            this.pnlTiles.UseHatch = true;
            this.pnlTiles.UseMouseWheelScaling = false;
            this.pnlTiles.UseOffset = true;
            this.pnlTiles.TileSelectionChanged += new SMSTileStudio.Controls.TilesControl.TileSelectionHandler(this.pnlTiles_TileSelectionChanged);
            // 
            // pnlPaletteOptions
            // 
            this.pnlPaletteOptions.Controls.Add(this.lblRows);
            this.pnlPaletteOptions.Controls.Add(this.lblColumns);
            this.pnlPaletteOptions.Controls.Add(this.nudRows);
            this.pnlPaletteOptions.Controls.Add(this.nudColumns);
            this.pnlPaletteOptions.Controls.Add(this.chkAttributes);
            this.pnlPaletteOptions.Controls.Add(this.chkTilemapGrid);
            this.pnlPaletteOptions.Controls.Add(this.btnSelectionOptions);
            this.pnlPaletteOptions.Controls.Add(this.btnOptimizeTilemap);
            this.pnlPaletteOptions.Controls.Add(this.btnReplaceTiles);
            this.pnlPaletteOptions.Controls.Add(this.lblHighlighterCountValue);
            this.pnlPaletteOptions.Controls.Add(this.chkHighlighter);
            this.pnlPaletteOptions.Controls.Add(this.lblSelectedTileIDValue);
            this.pnlPaletteOptions.Controls.Add(this.lblSelectedTileID);
            this.pnlPaletteOptions.Controls.Add(this.lblTilemapCompression);
            this.pnlPaletteOptions.Controls.Add(this.cbTilemapCompression);
            this.pnlPaletteOptions.Controls.Add(this.chkUseAttributes);
            this.pnlPaletteOptions.Controls.Add(this.nudOffset);
            this.pnlPaletteOptions.Controls.Add(this.lblOffset);
            this.pnlPaletteOptions.Controls.Add(this.txtName);
            this.pnlPaletteOptions.Controls.Add(this.lblName);
            this.pnlPaletteOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaletteOptions.Location = new System.Drawing.Point(8, 0);
            this.pnlPaletteOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlPaletteOptions.Name = "pnlPaletteOptions";
            this.pnlPaletteOptions.Size = new System.Drawing.Size(172, 276);
            this.pnlPaletteOptions.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(120, 176);
            this.lblRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(38, 13);
            this.lblRows.TabIndex = 26;
            this.lblRows.Text = "Rows:";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(57, 176);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(55, 13);
            this.lblColumns.TabIndex = 25;
            this.lblColumns.Text = "Columns:";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(120, 192);
            this.nudRows.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(48, 22);
            this.nudRows.TabIndex = 24;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(60, 192);
            this.nudColumns.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(48, 22);
            this.nudColumns.TabIndex = 23;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // chkAttributes
            // 
            this.chkAttributes.AutoSize = true;
            this.chkAttributes.Location = new System.Drawing.Point(56, 72);
            this.chkAttributes.Name = "chkAttributes";
            this.chkAttributes.Size = new System.Drawing.Size(109, 17);
            this.chkAttributes.TabIndex = 13;
            this.chkAttributes.Text = "Show Attributes";
            this.chkAttributes.UseVisualStyleBackColor = true;
            this.chkAttributes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkTilemapGrid
            // 
            this.chkTilemapGrid.AutoSize = true;
            this.chkTilemapGrid.Checked = true;
            this.chkTilemapGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilemapGrid.Location = new System.Drawing.Point(2, 72);
            this.chkTilemapGrid.Name = "chkTilemapGrid";
            this.chkTilemapGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilemapGrid.TabIndex = 12;
            this.chkTilemapGrid.Text = "Grid";
            this.chkTilemapGrid.UseVisualStyleBackColor = true;
            this.chkTilemapGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // btnSelectionOptions
            // 
            this.btnSelectionOptions.Location = new System.Drawing.Point(0, 46);
            this.btnSelectionOptions.Name = "btnSelectionOptions";
            this.btnSelectionOptions.Size = new System.Drawing.Size(168, 23);
            this.btnSelectionOptions.TabIndex = 22;
            this.btnSelectionOptions.Text = "Selection Options";
            this.btnSelectionOptions.UseVisualStyleBackColor = true;
            this.btnSelectionOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnOptimizeTilemap
            // 
            this.btnOptimizeTilemap.Location = new System.Drawing.Point(0, 23);
            this.btnOptimizeTilemap.Name = "btnOptimizeTilemap";
            this.btnOptimizeTilemap.Size = new System.Drawing.Size(168, 23);
            this.btnOptimizeTilemap.TabIndex = 21;
            this.btnOptimizeTilemap.Text = "Optimize Meta Tilemap";
            this.btnOptimizeTilemap.UseVisualStyleBackColor = true;
            this.btnOptimizeTilemap.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnReplaceTiles
            // 
            this.btnReplaceTiles.Location = new System.Drawing.Point(0, 0);
            this.btnReplaceTiles.Name = "btnReplaceTiles";
            this.btnReplaceTiles.Size = new System.Drawing.Size(168, 23);
            this.btnReplaceTiles.TabIndex = 20;
            this.btnReplaceTiles.Text = "Replace Tiles";
            this.btnReplaceTiles.UseVisualStyleBackColor = true;
            this.btnReplaceTiles.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblHighlighterCountValue
            // 
            this.lblHighlighterCountValue.AutoSize = true;
            this.lblHighlighterCountValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlighterCountValue.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblHighlighterCountValue.Location = new System.Drawing.Point(112, 256);
            this.lblHighlighterCountValue.Name = "lblHighlighterCountValue";
            this.lblHighlighterCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblHighlighterCountValue.TabIndex = 19;
            this.lblHighlighterCountValue.Text = "0";
            // 
            // chkHighlighter
            // 
            this.chkHighlighter.AutoSize = true;
            this.chkHighlighter.Location = new System.Drawing.Point(0, 255);
            this.chkHighlighter.Name = "chkHighlighter";
            this.chkHighlighter.Size = new System.Drawing.Size(113, 17);
            this.chkHighlighter.TabIndex = 18;
            this.chkHighlighter.Text = "Highlight Count:";
            this.chkHighlighter.UseVisualStyleBackColor = true;
            this.chkHighlighter.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // lblSelectedTileIDValue
            // 
            this.lblSelectedTileIDValue.AutoSize = true;
            this.lblSelectedTileIDValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTileIDValue.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSelectedTileIDValue.Location = new System.Drawing.Point(88, 238);
            this.lblSelectedTileIDValue.Name = "lblSelectedTileIDValue";
            this.lblSelectedTileIDValue.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedTileIDValue.TabIndex = 16;
            this.lblSelectedTileIDValue.Text = "0";
            // 
            // lblSelectedTileID
            // 
            this.lblSelectedTileID.AutoSize = true;
            this.lblSelectedTileID.Location = new System.Drawing.Point(0, 239);
            this.lblSelectedTileID.Name = "lblSelectedTileID";
            this.lblSelectedTileID.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedTileID.TabIndex = 15;
            this.lblSelectedTileID.Text = "Selected Tile ID:";
            // 
            // lblTilemapCompression
            // 
            this.lblTilemapCompression.AutoSize = true;
            this.lblTilemapCompression.Location = new System.Drawing.Point(0, 136);
            this.lblTilemapCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilemapCompression.Name = "lblTilemapCompression";
            this.lblTilemapCompression.Size = new System.Drawing.Size(77, 13);
            this.lblTilemapCompression.TabIndex = 6;
            this.lblTilemapCompression.Text = "Compression:";
            this.lblTilemapCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilemapCompression
            // 
            this.cbTilemapCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapCompression.FormattingEnabled = true;
            this.cbTilemapCompression.Location = new System.Drawing.Point(0, 152);
            this.cbTilemapCompression.Name = "cbTilemapCompression";
            this.cbTilemapCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapCompression.TabIndex = 8;
            this.cbTilemapCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // chkUseAttributes
            // 
            this.chkUseAttributes.AutoSize = true;
            this.chkUseAttributes.Location = new System.Drawing.Point(0, 216);
            this.chkUseAttributes.Margin = new System.Windows.Forms.Padding(0);
            this.chkUseAttributes.Name = "chkUseAttributes";
            this.chkUseAttributes.Size = new System.Drawing.Size(120, 17);
            this.chkUseAttributes.TabIndex = 14;
            this.chkUseAttributes.Text = "Use Tile Attributes";
            this.chkUseAttributes.UseVisualStyleBackColor = true;
            this.chkUseAttributes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(0, 192);
            this.nudOffset.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(48, 22);
            this.nudOffset.TabIndex = 9;
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(0, 176);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(42, 13);
            this.lblOffset.TabIndex = 7;
            this.lblOffset.Text = "Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 112);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 96);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Meta Tilemap Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.Controls.Add(this.pnlTilemapEdit);
            this.pnlTilemap.Controls.Add(this.pnlTilemapToolbar);
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(494, 519);
            this.pnlTilemap.TabIndex = 5;
            // 
            // pnlTilemapEdit
            // 
            this.pnlTilemapEdit.AutoScroll = true;
            this.pnlTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(494, 487);
            this.pnlTilemapEdit.BitsValue = ((byte)(0));
            this.pnlTilemapEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemapEdit.Centered = true;
            this.pnlTilemapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemapEdit.EditMode = SMSTileStudio.Data.TileEditType.TileID;
            this.pnlTilemapEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemapEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemapEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemapEdit.Highlight = false;
            this.pnlTilemapEdit.Image = null;
            this.pnlTilemapEdit.ImageAlpha = 1F;
            this.pnlTilemapEdit.ImageScale = 1;
            this.pnlTilemapEdit.Indexed = false;
            this.pnlTilemapEdit.Location = new System.Drawing.Point(0, 32);
            this.pnlTilemapEdit.MinimumScale = 1;
            this.pnlTilemapEdit.Name = "pnlTilemapEdit";
            this.pnlTilemapEdit.Offset = 0;
            this.pnlTilemapEdit.Size = new System.Drawing.Size(494, 487);
            this.pnlTilemapEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemapEdit.TabIndex = 4;
            this.pnlTilemapEdit.TileID = -1;
            this.pnlTilemapEdit.UseCanvas = false;
            this.pnlTilemapEdit.UseGrid = true;
            this.pnlTilemapEdit.UseHatch = true;
            this.pnlTilemapEdit.UseMouseWheelScaling = true;
            this.pnlTilemapEdit.UseOffset = false;
            this.pnlTilemapEdit.TileChanged += new SMSTileStudio.Controls.TilemapControl.TileChangedHandler(this.pnlTilemapEdit_TileChanged);
            this.pnlTilemapEdit.PositionChanged += new SMSTileStudio.Controls.TilemapControl.PositionChangedHandler(this.pnlTilemapEdit_PositionChanged);
            // 
            // pnlTilemapToolbar
            // 
            this.pnlTilemapToolbar.Controls.Add(this.nudBits);
            this.pnlTilemapToolbar.Controls.Add(this.rbBits);
            this.pnlTilemapToolbar.Controls.Add(this.rbSelect);
            this.pnlTilemapToolbar.Controls.Add(this.rbPalette);
            this.pnlTilemapToolbar.Controls.Add(this.rbPriority);
            this.pnlTilemapToolbar.Controls.Add(this.rbFlipY);
            this.pnlTilemapToolbar.Controls.Add(this.rbFlipX);
            this.pnlTilemapToolbar.Controls.Add(this.rbBrush);
            this.pnlTilemapToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemapToolbar.Name = "pnlTilemapToolbar";
            this.pnlTilemapToolbar.Size = new System.Drawing.Size(494, 32);
            this.pnlTilemapToolbar.TabIndex = 3;
            // 
            // nudBits
            // 
            this.nudBits.Location = new System.Drawing.Point(400, 5);
            this.nudBits.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudBits.Name = "nudBits";
            this.nudBits.Size = new System.Drawing.Size(40, 22);
            this.nudBits.TabIndex = 7;
            this.nudBits.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // rbBits
            // 
            this.rbBits.AutoSize = true;
            this.rbBits.Location = new System.Drawing.Point(352, 8);
            this.rbBits.Name = "rbBits";
            this.rbBits.Size = new System.Drawing.Size(43, 17);
            this.rbBits.TabIndex = 6;
            this.rbBits.Text = "Bits";
            this.rbBits.UseVisualStyleBackColor = true;
            this.rbBits.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(56, 8);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(55, 17);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            this.rbSelect.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbPalette
            // 
            this.rbPalette.AutoSize = true;
            this.rbPalette.Location = new System.Drawing.Point(288, 8);
            this.rbPalette.Name = "rbPalette";
            this.rbPalette.Size = new System.Drawing.Size(60, 17);
            this.rbPalette.TabIndex = 5;
            this.rbPalette.Text = "Palette";
            this.rbPalette.UseVisualStyleBackColor = true;
            this.rbPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbPriority
            // 
            this.rbPriority.AutoSize = true;
            this.rbPriority.Location = new System.Drawing.Point(224, 8);
            this.rbPriority.Name = "rbPriority";
            this.rbPriority.Size = new System.Drawing.Size(61, 17);
            this.rbPriority.TabIndex = 4;
            this.rbPriority.Text = "Priority";
            this.rbPriority.UseVisualStyleBackColor = true;
            this.rbPriority.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbFlipY
            // 
            this.rbFlipY.AutoSize = true;
            this.rbFlipY.Location = new System.Drawing.Point(168, 8);
            this.rbFlipY.Name = "rbFlipY";
            this.rbFlipY.Size = new System.Drawing.Size(54, 17);
            this.rbFlipY.TabIndex = 3;
            this.rbFlipY.Text = "V Flip";
            this.rbFlipY.UseVisualStyleBackColor = true;
            this.rbFlipY.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbFlipX
            // 
            this.rbFlipX.AutoSize = true;
            this.rbFlipX.Location = new System.Drawing.Point(112, 8);
            this.rbFlipX.Name = "rbFlipX";
            this.rbFlipX.Size = new System.Drawing.Size(55, 17);
            this.rbFlipX.TabIndex = 2;
            this.rbFlipX.Text = "H Flip";
            this.rbFlipX.UseVisualStyleBackColor = true;
            this.rbFlipX.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbBrush
            // 
            this.rbBrush.AutoSize = true;
            this.rbBrush.Checked = true;
            this.rbBrush.Location = new System.Drawing.Point(0, 8);
            this.rbBrush.Name = "rbBrush";
            this.rbBrush.Size = new System.Drawing.Size(54, 17);
            this.rbBrush.TabIndex = 0;
            this.rbBrush.TabStop = true;
            this.rbBrush.Text = "Brush";
            this.rbBrush.UseVisualStyleBackColor = true;
            this.rbBrush.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // tabTileset
            // 
            this.tabTileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileset.Controls.Add(this.tpnlTileset);
            this.tabTileset.Location = new System.Drawing.Point(4, 22);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(680, 525);
            this.tabTileset.TabIndex = 1;
            this.tabTileset.Text = "Tileset";
            // 
            // tpnlTileset
            // 
            this.tpnlTileset.ColumnCount = 2;
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlTileset.Controls.Add(this.pnlTilesetOptions, 1, 0);
            this.tpnlTileset.Controls.Add(this.pnlTileset, 0, 0);
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
            this.pnlTilesetOptions.Controls.Add(this.pnlSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlBGPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.btnSwapSelectedPixel);
            this.pnlTilesetOptions.Controls.Add(this.lblSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.cbTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.lblSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.lblBgPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbBgPalette);
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
            this.btnPasteTileset.TabIndex = 24;
            this.btnPasteTileset.Text = "Paste";
            this.btnPasteTileset.UseVisualStyleBackColor = true;
            this.btnPasteTileset.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnCopyTileset
            // 
            this.btnCopyTileset.Location = new System.Drawing.Point(8, 72);
            this.btnCopyTileset.Name = "btnCopyTileset";
            this.btnCopyTileset.Size = new System.Drawing.Size(84, 23);
            this.btnCopyTileset.TabIndex = 23;
            this.btnCopyTileset.Text = "Copy";
            this.btnCopyTileset.UseVisualStyleBackColor = true;
            this.btnCopyTileset.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnDeselectTile
            // 
            this.btnDeselectTile.Location = new System.Drawing.Point(8, 48);
            this.btnDeselectTile.Name = "btnDeselectTile";
            this.btnDeselectTile.Size = new System.Drawing.Size(168, 23);
            this.btnDeselectTile.TabIndex = 22;
            this.btnDeselectTile.Text = "Deselect Tile";
            this.btnDeselectTile.UseVisualStyleBackColor = true;
            this.btnDeselectTile.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnRemoveTile
            // 
            this.btnRemoveTile.Location = new System.Drawing.Point(8, 24);
            this.btnRemoveTile.Name = "btnRemoveTile";
            this.btnRemoveTile.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveTile.TabIndex = 21;
            this.btnRemoveTile.Text = "Remove Selected Tile";
            this.btnRemoveTile.UseVisualStyleBackColor = true;
            this.btnRemoveTile.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // chkTilesetGrid
            // 
            this.chkTilesetGrid.AutoSize = true;
            this.chkTilesetGrid.Checked = true;
            this.chkTilesetGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetGrid.Location = new System.Drawing.Point(10, 98);
            this.chkTilesetGrid.Name = "chkTilesetGrid";
            this.chkTilesetGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetGrid.TabIndex = 10;
            this.chkTilesetGrid.Text = "Grid";
            this.chkTilesetGrid.UseVisualStyleBackColor = true;
            this.chkTilesetGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // btnAddTile
            // 
            this.btnAddTile.Location = new System.Drawing.Point(8, 0);
            this.btnAddTile.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTile.Name = "btnAddTile";
            this.btnAddTile.Size = new System.Drawing.Size(168, 23);
            this.btnAddTile.TabIndex = 20;
            this.btnAddTile.Text = "Add Empty Tile";
            this.btnAddTile.UseVisualStyleBackColor = true;
            this.btnAddTile.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // chkTilesetIndexes
            // 
            this.chkTilesetIndexes.AutoSize = true;
            this.chkTilesetIndexes.Location = new System.Drawing.Point(64, 98);
            this.chkTilesetIndexes.Name = "chkTilesetIndexes";
            this.chkTilesetIndexes.Size = new System.Drawing.Size(97, 17);
            this.chkTilesetIndexes.TabIndex = 11;
            this.chkTilesetIndexes.Text = "Show Indexes";
            this.chkTilesetIndexes.UseVisualStyleBackColor = true;
            this.chkTilesetIndexes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // pnlSprPalette
            // 
            this.pnlSprPalette.Location = new System.Drawing.Point(8, 240);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSprPalette.TabIndex = 19;
            this.pnlSprPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlSPRPalette_SelectedColorChanged);
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 160);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 18;
            this.pnlBGPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlBGPalette_SelectedColorChanged);
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
            this.pnlSelectedTile.TabIndex = 13;
            this.pnlSelectedTile.TargetColor = ((byte)(255));
            this.pnlSelectedTile.UseCanvas = false;
            this.pnlSelectedTile.UseHatch = true;
            this.pnlSelectedTile.UseMouseWheelScaling = false;
            this.pnlSelectedTile.PixelChanged += new SMSTileStudio.Controls.TileControl.PixelChangedHandler(this.pnlSelectedTile_PixelChanged);
            // 
            // btnSwapSelectedPixel
            // 
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(8, 484);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(168, 23);
            this.btnSwapSelectedPixel.TabIndex = 17;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            this.btnSwapSelectedPixel.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblSelectedTile
            // 
            this.lblSelectedTile.AutoSize = true;
            this.lblSelectedTile.Location = new System.Drawing.Point(8, 320);
            this.lblSelectedTile.Name = "lblSelectedTile";
            this.lblSelectedTile.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedTile.TabIndex = 12;
            this.lblSelectedTile.Text = "Selected Tile:";
            // 
            // lblTilesetCompression
            // 
            this.lblTilesetCompression.AutoSize = true;
            this.lblTilesetCompression.Location = new System.Drawing.Point(8, 280);
            this.lblTilesetCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetCompression.Name = "lblTilesetCompression";
            this.lblTilesetCompression.Size = new System.Drawing.Size(77, 13);
            this.lblTilesetCompression.TabIndex = 8;
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
            this.cbTilesetCompression.TabIndex = 9;
            this.cbTilesetCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblSprPalette
            // 
            this.lblSprPalette.AutoSize = true;
            this.lblSprPalette.Location = new System.Drawing.Point(8, 200);
            this.lblSprPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSprPalette.Name = "lblSprPalette";
            this.lblSprPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSprPalette.TabIndex = 6;
            this.lblSprPalette.Text = "Sprite Palette:";
            this.lblSprPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSprPalette
            // 
            this.cbSprPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSprPalette.FormattingEnabled = true;
            this.cbSprPalette.Location = new System.Drawing.Point(8, 216);
            this.cbSprPalette.Name = "cbSprPalette";
            this.cbSprPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSprPalette.TabIndex = 7;
            this.cbSprPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblBgPalette
            // 
            this.lblBgPalette.AutoSize = true;
            this.lblBgPalette.Location = new System.Drawing.Point(8, 120);
            this.lblBgPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblBgPalette.Name = "lblBgPalette";
            this.lblBgPalette.Size = new System.Drawing.Size(110, 13);
            this.lblBgPalette.TabIndex = 4;
            this.lblBgPalette.Text = "Background Palette:";
            this.lblBgPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBgPalette
            // 
            this.cbBgPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBgPalette.FormattingEnabled = true;
            this.cbBgPalette.Location = new System.Drawing.Point(8, 136);
            this.cbBgPalette.Name = "cbBgPalette";
            this.cbBgPalette.Size = new System.Drawing.Size(168, 21);
            this.cbBgPalette.TabIndex = 5;
            this.cbBgPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // pnlTileset
            // 
            this.pnlTileset.Controls.Add(this.pnlTilesetEdit);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(0, 0);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(494, 519);
            this.pnlTileset.TabIndex = 2;
            // 
            // pnlTilesetEdit
            // 
            this.pnlTilesetEdit.AutoScroll = true;
            this.pnlTilesetEdit.AutoScrollMinSize = new System.Drawing.Size(494, 519);
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
            this.pnlTilesetEdit.TabIndex = 1;
            this.pnlTilesetEdit.UseCanvas = false;
            this.pnlTilesetEdit.UseGrid = true;
            this.pnlTilesetEdit.UseHatch = true;
            this.pnlTilesetEdit.UseMouseWheelScaling = true;
            this.pnlTilesetEdit.TileSelectionChanged += new SMSTileStudio.Controls.TilesetImageControl.TileSelectionHandler(this.pnlTilesetEdit_TileSelectionChanged);
            // 
            // lblCreateTilemap
            // 
            this.lblCreateTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateTilemap.Location = new System.Drawing.Point(0, 0);
            this.lblCreateTilemap.Name = "lblCreateTilemap";
            this.lblCreateTilemap.Size = new System.Drawing.Size(688, 551);
            this.lblCreateTilemap.TabIndex = 1;
            this.lblCreateTilemap.Text = "Create or select a meta tilemap to edit";
            this.lblCreateTilemap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 557);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(884, 26);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "No Tilemap information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuExport
            // 
            this.mnuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportPalette,
            this.mnuExportTileset,
            this.mnuExportTilemap,
            this.mnuMetaTilemapExportBinary});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(184, 92);
            // 
            // mnuExportPalette
            // 
            this.mnuExportPalette.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportBgPalette,
            this.mnuSeparator1,
            this.mnuPaletteExportImage,
            this.mnuPaletteExportBinary,
            this.mnuPaletteExportHex,
            this.mnuPaletteExportAssembly});
            this.mnuExportPalette.Name = "mnuExportPalette";
            this.mnuExportPalette.Size = new System.Drawing.Size(183, 22);
            this.mnuExportPalette.Text = "Export Palette";
            // 
            // mnuExportBgPalette
            // 
            this.mnuExportBgPalette.Checked = true;
            this.mnuExportBgPalette.CheckOnClick = true;
            this.mnuExportBgPalette.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuExportBgPalette.Name = "mnuExportBgPalette";
            this.mnuExportBgPalette.Size = new System.Drawing.Size(239, 22);
            this.mnuExportBgPalette.Text = "Background Palette";
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuPaletteExportImage
            // 
            this.mnuPaletteExportImage.Name = "mnuPaletteExportImage";
            this.mnuPaletteExportImage.Size = new System.Drawing.Size(239, 22);
            this.mnuPaletteExportImage.Text = "Export as Image";
            // 
            // mnuPaletteExportBinary
            // 
            this.mnuPaletteExportBinary.Name = "mnuPaletteExportBinary";
            this.mnuPaletteExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuPaletteExportBinary.Text = "Export as Binary";
            // 
            // mnuPaletteExportHex
            // 
            this.mnuPaletteExportHex.Name = "mnuPaletteExportHex";
            this.mnuPaletteExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuPaletteExportHex.Text = "Export as Hex (Clipboard)";
            // 
            // mnuPaletteExportAssembly
            // 
            this.mnuPaletteExportAssembly.Name = "mnuPaletteExportAssembly";
            this.mnuPaletteExportAssembly.Size = new System.Drawing.Size(239, 22);
            this.mnuPaletteExportAssembly.Text = "Export as Assembly (Clipboard)";
            // 
            // mnuExportTileset
            // 
            this.mnuExportTileset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTilesetBypassCompression,
            this.mnuTilesetUseMaskColor,
            this.mnuSeparator2,
            this.mnuTilesetExportImage,
            this.mnuTilesetExportBinary,
            this.mnuTilesetExportHex,
            this.mnuTilesetExportAssembly});
            this.mnuExportTileset.Name = "mnuExportTileset";
            this.mnuExportTileset.Size = new System.Drawing.Size(183, 22);
            this.mnuExportTileset.Text = "Export Tileset";
            // 
            // mnuTilesetBypassCompression
            // 
            this.mnuTilesetBypassCompression.CheckOnClick = true;
            this.mnuTilesetBypassCompression.Name = "mnuTilesetBypassCompression";
            this.mnuTilesetBypassCompression.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetBypassCompression.Text = "Bypass Compression";
            // 
            // mnuTilesetUseMaskColor
            // 
            this.mnuTilesetUseMaskColor.CheckOnClick = true;
            this.mnuTilesetUseMaskColor.Name = "mnuTilesetUseMaskColor";
            this.mnuTilesetUseMaskColor.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetUseMaskColor.Text = "Use Custom Mask Color for Image";
            // 
            // mnuSeparator2
            // 
            this.mnuSeparator2.Name = "mnuSeparator2";
            this.mnuSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // mnuTilesetExportImage
            // 
            this.mnuTilesetExportImage.Name = "mnuTilesetExportImage";
            this.mnuTilesetExportImage.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportImage.Text = "Export as Image";
            this.mnuTilesetExportImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetExportBinary
            // 
            this.mnuTilesetExportBinary.Name = "mnuTilesetExportBinary";
            this.mnuTilesetExportBinary.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportBinary.Text = "Export as Binary";
            this.mnuTilesetExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetExportHex
            // 
            this.mnuTilesetExportHex.Name = "mnuTilesetExportHex";
            this.mnuTilesetExportHex.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuTilesetExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetExportAssembly
            // 
            this.mnuTilesetExportAssembly.Name = "mnuTilesetExportAssembly";
            this.mnuTilesetExportAssembly.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuTilesetExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportTilemap
            // 
            this.mnuExportTilemap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTilemapBypassCompression,
            this.mnuTilemapVerticalOrientation,
            this.mnuTilemapReverseVerticalOrientation,
            this.mnuSeparator3,
            this.mnuTilemapExportImage,
            this.mnuTilemapExportBinary,
            this.mnuTilemapExportHex,
            this.mnuTilemapExportAssembly});
            this.mnuExportTilemap.Name = "mnuExportTilemap";
            this.mnuExportTilemap.Size = new System.Drawing.Size(183, 22);
            this.mnuExportTilemap.Text = "Export Tilemap";
            // 
            // mnuTilemapBypassCompression
            // 
            this.mnuTilemapBypassCompression.CheckOnClick = true;
            this.mnuTilemapBypassCompression.Name = "mnuTilemapBypassCompression";
            this.mnuTilemapBypassCompression.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapBypassCompression.Text = "Bypass Compression";
            // 
            // mnuTilemapVerticalOrientation
            // 
            this.mnuTilemapVerticalOrientation.CheckOnClick = true;
            this.mnuTilemapVerticalOrientation.Name = "mnuTilemapVerticalOrientation";
            this.mnuTilemapVerticalOrientation.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapVerticalOrientation.Text = "Vertical Orientation";
            this.mnuTilemapVerticalOrientation.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // mnuTilemapReverseVerticalOrientation
            // 
            this.mnuTilemapReverseVerticalOrientation.CheckOnClick = true;
            this.mnuTilemapReverseVerticalOrientation.Name = "mnuTilemapReverseVerticalOrientation";
            this.mnuTilemapReverseVerticalOrientation.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapReverseVerticalOrientation.Text = "Reverse Vertical Orientation";
            this.mnuTilemapReverseVerticalOrientation.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // mnuSeparator3
            // 
            this.mnuSeparator3.Name = "mnuSeparator3";
            this.mnuSeparator3.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuTilemapExportImage
            // 
            this.mnuTilemapExportImage.Name = "mnuTilemapExportImage";
            this.mnuTilemapExportImage.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapExportImage.Text = "Export as Image";
            this.mnuTilemapExportImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportBinary
            // 
            this.mnuTilemapExportBinary.Name = "mnuTilemapExportBinary";
            this.mnuTilemapExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapExportBinary.Text = "Export as Binary";
            this.mnuTilemapExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportHex
            // 
            this.mnuTilemapExportHex.Name = "mnuTilemapExportHex";
            this.mnuTilemapExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuTilemapExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportAssembly
            // 
            this.mnuTilemapExportAssembly.Name = "mnuTilemapExportAssembly";
            this.mnuTilemapExportAssembly.Size = new System.Drawing.Size(239, 22);
            this.mnuTilemapExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuTilemapExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMetaTilemapExportBinary
            // 
            this.mnuMetaTilemapExportBinary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsBinaryToolStripMenuItem,
            this.mnuMetaTilemapExportHex,
            this.mnuMetaTilemapExportAssembly});
            this.mnuMetaTilemapExportBinary.Name = "mnuMetaTilemapExportBinary";
            this.mnuMetaTilemapExportBinary.Size = new System.Drawing.Size(183, 22);
            this.mnuMetaTilemapExportBinary.Text = "Export Meta Tilemap";
            // 
            // exportAsBinaryToolStripMenuItem
            // 
            this.exportAsBinaryToolStripMenuItem.Name = "exportAsBinaryToolStripMenuItem";
            this.exportAsBinaryToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exportAsBinaryToolStripMenuItem.Text = "Export as Binary";
            this.exportAsBinaryToolStripMenuItem.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMetaTilemapExportHex
            // 
            this.mnuMetaTilemapExportHex.Name = "mnuMetaTilemapExportHex";
            this.mnuMetaTilemapExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuMetaTilemapExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuMetaTilemapExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMetaTilemapExportAssembly
            // 
            this.mnuMetaTilemapExportAssembly.Name = "mnuMetaTilemapExportAssembly";
            this.mnuMetaTilemapExportAssembly.Size = new System.Drawing.Size(239, 22);
            this.mnuMetaTilemapExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuMetaTilemapExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSelectOptions
            // 
            this.mnuSelectOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateBrush,
            this.mnuClearBrush,
            this.mnuSeparator4,
            this.mnuTilemapFromSelection});
            this.mnuSelectOptions.Name = "mnuSelectOptions";
            this.mnuSelectOptions.Size = new System.Drawing.Size(199, 76);
            // 
            // mnuCreateBrush
            // 
            this.mnuCreateBrush.Name = "mnuCreateBrush";
            this.mnuCreateBrush.Size = new System.Drawing.Size(198, 22);
            this.mnuCreateBrush.Text = "Brush From Selection";
            this.mnuCreateBrush.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuClearBrush
            // 
            this.mnuClearBrush.Name = "mnuClearBrush";
            this.mnuClearBrush.Size = new System.Drawing.Size(198, 22);
            this.mnuClearBrush.Text = "Clear Brush";
            this.mnuClearBrush.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSeparator4
            // 
            this.mnuSeparator4.Name = "mnuSeparator4";
            this.mnuSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuTilemapFromSelection
            // 
            this.mnuTilemapFromSelection.Name = "mnuTilemapFromSelection";
            this.mnuTilemapFromSelection.Size = new System.Drawing.Size(198, 22);
            this.mnuTilemapFromSelection.Text = "Tilemap From Selection";
            this.mnuTilemapFromSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuImport
            // 
            this.mnuImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportTilemap,
            this.mnuUpdateTileset});
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(156, 48);
            // 
            // mnuImportTilemap
            // 
            this.mnuImportTilemap.Name = "mnuImportTilemap";
            this.mnuImportTilemap.Size = new System.Drawing.Size(155, 22);
            this.mnuImportTilemap.Text = "Import Tilemap";
            this.mnuImportTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUpdateTileset
            // 
            this.mnuUpdateTileset.Name = "mnuUpdateTileset";
            this.mnuUpdateTileset.Size = new System.Drawing.Size(155, 22);
            this.mnuUpdateTileset.Text = "Update Tileset";
            this.mnuUpdateTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // AssetMetaTilemapControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetMetaTilemapControl";
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.ResumeLayout(false);
            this.grpImageList.ResumeLayout(false);
            this.pnlPaletteButtons.ResumeLayout(false);
            this.pnlPalettes.ResumeLayout(false);
            this.pnlPalettes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabTilemap.ResumeLayout(false);
            this.tpnlTilemap.ResumeLayout(false);
            this.pnlTilemapOptions.ResumeLayout(false);
            this.pnlPaletteOptions.ResumeLayout(false);
            this.pnlPaletteOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.pnlTilemap.ResumeLayout(false);
            this.pnlTilemapToolbar.ResumeLayout(false);
            this.pnlTilemapToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBits)).EndInit();
            this.tabTileset.ResumeLayout(false);
            this.tpnlTileset.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            this.pnlTileset.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.mnuSelectOptions.ResumeLayout(false);
            this.mnuImport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpImageList;
        private ListBoxControl lstTilemaps;
        private System.Windows.Forms.Panel pnlPaletteButtons;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTilemap;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemap;
        private System.Windows.Forms.TabPage tabTileset;
        private System.Windows.Forms.Panel pnlTilemapOptions;
        private System.Windows.Forms.Panel pnlPaletteOptions;
        private System.Windows.Forms.Label lblHighlighterCountValue;
        private System.Windows.Forms.CheckBox chkHighlighter;
        private System.Windows.Forms.Label lblSelectedTileIDValue;
        private System.Windows.Forms.Label lblSelectedTileID;
        private System.Windows.Forms.Label lblTilemapCompression;
        private System.Windows.Forms.ComboBox cbTilemapCompression;
        private System.Windows.Forms.CheckBox chkUseAttributes;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlTilemap;
        private System.Windows.Forms.Panel pnlTilemapToolbar;
        private System.Windows.Forms.CheckBox chkTilemapGrid;
        private System.Windows.Forms.CheckBox chkAttributes;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbPalette;
        private System.Windows.Forms.RadioButton rbPriority;
        private System.Windows.Forms.RadioButton rbFlipY;
        private System.Windows.Forms.RadioButton rbFlipX;
        private System.Windows.Forms.RadioButton rbBrush;
        private System.Windows.Forms.TableLayoutPanel tpnlTileset;
        private System.Windows.Forms.Panel pnlTileset;
        private System.Windows.Forms.CheckBox chkTilesetGrid;
        private System.Windows.Forms.CheckBox chkTilesetIndexes;
        private System.Windows.Forms.Panel pnlTilesetOptions;
        private PaletteControl pnlSprPalette;
        private PaletteControl pnlBGPalette;
        private TileControl pnlSelectedTile;
        private System.Windows.Forms.Button btnSwapSelectedPixel;
        private System.Windows.Forms.Label lblSelectedTile;
        private System.Windows.Forms.Label lblTilesetCompression;
        private System.Windows.Forms.ComboBox cbTilesetCompression;
        private System.Windows.Forms.Label lblSprPalette;
        private System.Windows.Forms.ComboBox cbSprPalette;
        private System.Windows.Forms.Label lblBgPalette;
        private System.Windows.Forms.ComboBox cbBgPalette;
        private System.Windows.Forms.Button btnDeselectTile;
        private System.Windows.Forms.Button btnRemoveTile;
        private System.Windows.Forms.Button btnAddTile;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnSelectionOptions;
        private System.Windows.Forms.Button btnOptimizeTilemap;
        private System.Windows.Forms.Button btnReplaceTiles;
        private System.Windows.Forms.Button btnExport;
        private TilemapControl pnlTilemapEdit;
        private TilesetImageControl pnlTilesetEdit;
        private System.Windows.Forms.Label lblCreateTilemap;
        private System.Windows.Forms.Panel pnlPalettes;
        private System.Windows.Forms.RadioButton rbBgPalette;
        private System.Windows.Forms.RadioButton rbSprPalette;
        private System.Windows.Forms.NumericUpDown nudBits;
        private System.Windows.Forms.RadioButton rbBits;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetUseMaskColor;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportImage;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapVerticalOrientation;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetBypassCompression;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapBypassCompression;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ContextMenuStrip mnuSelectOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateBrush;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapFromSelection;
        private System.Windows.Forms.ToolStripMenuItem mnuClearBrush;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator4;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ToolStripMenuItem mnuExportPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportImage;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBgPalette;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.Button btnCopyTileset;
        private System.Windows.Forms.Button btnPasteTileset;
        private System.Windows.Forms.ContextMenuStrip mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuImportTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTileset;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private SMSTileStudio.Controls.TilesControl pnlTiles;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapReverseVerticalOrientation;
        private System.Windows.Forms.NumericUpDown nudTilesetExportEnd;
        private System.Windows.Forms.NumericUpDown nudTilesetExportStart;
        private System.Windows.Forms.Label lblTilesetRangeTo;
        private System.Windows.Forms.Label lblTilesetExportRange;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportImage;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapExportBinary;
        private System.Windows.Forms.ToolStripMenuItem exportAsBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapExportAssembly;
    }
}
