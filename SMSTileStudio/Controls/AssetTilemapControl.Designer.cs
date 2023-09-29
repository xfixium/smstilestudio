namespace SMSTileStudio.Controls
{
    partial class AssetTilemapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetTilemapControl));
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
            this.lblTileType = new System.Windows.Forms.Label();
            this.lblTilesetExportRange = new System.Windows.Forms.Label();
            this.nudTileType = new System.Windows.Forms.NumericUpDown();
            this.nudTilesetExportEnd = new System.Windows.Forms.NumericUpDown();
            this.nudTilesetExportStart = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetRangeTo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTilemap = new System.Windows.Forms.TabPage();
            this.tpnlTilemap = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilemap = new System.Windows.Forms.Panel();
            this.pnlTilemapEdit = new SMSTileStudio.Controls.TilemapControl();
            this.mnuSelectOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCreateBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSetSelectionPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnsetSelectionPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetSelectionPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnsetSelectionPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetTileType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapFromSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCropTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.pnlTilemapToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.rbBrush = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbFlipX = new System.Windows.Forms.RadioButton();
            this.rbFlipY = new System.Windows.Forms.RadioButton();
            this.rbPriority = new System.Windows.Forms.RadioButton();
            this.rbPalette = new System.Windows.Forms.RadioButton();
            this.rbTileType = new System.Windows.Forms.RadioButton();
            this.chkTilemapGrid = new System.Windows.Forms.CheckBox();
            this.chkShowTileIds = new System.Windows.Forms.CheckBox();
            this.tabProperties = new System.Windows.Forms.TabControl();
            this.tabTilemapTiles = new System.Windows.Forms.TabPage();
            this.pnlTilemapOptions = new System.Windows.Forms.Panel();
            this.tabTileOptions = new System.Windows.Forms.TabControl();
            this.tabTilePalette = new System.Windows.Forms.TabPage();
            this.pnlTiles = new SMSTileStudio.Controls.TilesControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedTileID = new System.Windows.Forms.Label();
            this.lblSelectedTileIDValue = new System.Windows.Forms.Label();
            this.chkHighlighter = new System.Windows.Forms.CheckBox();
            this.lblHighlighterCountValue = new System.Windows.Forms.Label();
            this.tabTileList = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlPaletteOptions = new System.Windows.Forms.Panel();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.btnSelectionOptions = new System.Windows.Forms.Button();
            this.btnTilemapOptions = new System.Windows.Forms.Button();
            this.lblTilemapCompression = new System.Windows.Forms.Label();
            this.cbTilemapCompression = new System.Windows.Forms.ComboBox();
            this.chkUseAttributes = new System.Windows.Forms.CheckBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabMetatiles = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tilesControl1 = new SMSTileStudio.Controls.TilesControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBlockSize = new System.Windows.Forms.Label();
            this.cbBlockSize = new System.Windows.Forms.ComboBox();
            this.tabEntities = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstEntities = new SMSTileStudio.Controls.ListBoxControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudEntityId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEntityHeight = new System.Windows.Forms.Label();
            this.nudEntityY = new System.Windows.Forms.NumericUpDown();
            this.nudEntityHeight = new System.Windows.Forms.NumericUpDown();
            this.lblEntityWidth = new System.Windows.Forms.Label();
            this.lblEntityY = new System.Windows.Forms.Label();
            this.nudEntityWidth = new System.Windows.Forms.NumericUpDown();
            this.nudEntityX = new System.Windows.Forms.NumericUpDown();
            this.lblEntityX = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.tpnlTileset = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTilesetOptions = new System.Windows.Forms.Panel();
            this.btnTilesetOptions = new System.Windows.Forms.Button();
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlSelectedTile = new SMSTileStudio.Controls.TileControl();
            this.rbBgPalette = new System.Windows.Forms.RadioButton();
            this.btnSwapSelectedPixel = new System.Windows.Forms.Button();
            this.rbSprPalette = new System.Windows.Forms.RadioButton();
            this.lblSelectedTile = new System.Windows.Forms.Label();
            this.lblTilesetCompression = new System.Windows.Forms.Label();
            this.cbTilesetCompression = new System.Windows.Forms.ComboBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.cbSprPalette = new System.Windows.Forms.ComboBox();
            this.lblBgPalette = new System.Windows.Forms.Label();
            this.cbBgPalette = new System.Windows.Forms.ComboBox();
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTilesetSelect = new System.Windows.Forms.RadioButton();
            this.rbTilesetSwap = new System.Windows.Forms.RadioButton();
            this.rbTilesetType = new System.Windows.Forms.RadioButton();
            this.chkTilesetGrid = new System.Windows.Forms.CheckBox();
            this.chkTilesetShowTileIds = new System.Windows.Forms.CheckBox();
            this.lblCreateTilemap = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.mnuExportMetatiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetatilesBypassCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMetatilesExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetatilesExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetatilesExportAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetatileMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportEntities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntitiesExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntitiesExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntitiesExportAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuImportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeselectTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveByRange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeperator20 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPasteTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuReplaceTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptimizeTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.mnuBulkPasteTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpImageList.SuspendLayout();
            this.pnlPaletteButtons.SuspendLayout();
            this.pnlPalettes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.tpnlTilemap.SuspendLayout();
            this.pnlTilemap.SuspendLayout();
            this.mnuSelectOptions.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlTilemapToolbar.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabTilemapTiles.SuspendLayout();
            this.pnlTilemapOptions.SuspendLayout();
            this.tabTileOptions.SuspendLayout();
            this.tabTilePalette.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabTileList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlPaletteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.tabMetatiles.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabEntities.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityX)).BeginInit();
            this.tabTileset.SuspendLayout();
            this.tpnlTileset.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            this.pnlTileset.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.mnuImport.SuspendLayout();
            this.mnuTilesetOptions.SuspendLayout();
            this.mnuTilemapOptions.SuspendLayout();
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
            this.grpImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImageList.Location = new System.Drawing.Point(0, 0);
            this.grpImageList.Margin = new System.Windows.Forms.Padding(0);
            this.grpImageList.Name = "grpImageList";
            this.grpImageList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpImageList.Size = new System.Drawing.Size(196, 557);
            this.grpImageList.TabIndex = 0;
            this.grpImageList.TabStop = false;
            this.grpImageList.Text = "Tilemaps";
            // 
            // lstTilemaps
            // 
            this.lstTilemaps.DisableHighlighting = false;
            this.lstTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilemaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilemaps.FormattingEnabled = true;
            this.lstTilemaps.HorizontalExtent = 168;
            this.lstTilemaps.IntegralHeight = false;
            this.lstTilemaps.Location = new System.Drawing.Point(12, 203);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(172, 342);
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
            this.pnlPaletteButtons.Size = new System.Drawing.Size(172, 184);
            this.pnlPaletteButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 160);
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
            this.btnImport.Location = new System.Drawing.Point(0, 137);
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
            this.btnRemove.Location = new System.Drawing.Point(0, 114);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Tilemap";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 91);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 7;
            this.btnDuplicate.Text = "Duplicate Tilemap";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 68);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Tilemap";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.Controls.Add(this.lblTileType);
            this.pnlPalettes.Controls.Add(this.lblTilesetExportRange);
            this.pnlPalettes.Controls.Add(this.nudTileType);
            this.pnlPalettes.Controls.Add(this.nudTilesetExportEnd);
            this.pnlPalettes.Controls.Add(this.nudTilesetExportStart);
            this.pnlPalettes.Controls.Add(this.lblTilesetRangeTo);
            this.pnlPalettes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPalettes.Location = new System.Drawing.Point(0, 0);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(172, 68);
            this.pnlPalettes.TabIndex = 11;
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.lblTileType.Location = new System.Drawing.Point(3, 5);
            this.lblTileType.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(85, 13);
            this.lblTileType.TabIndex = 30;
            this.lblTileType.Text = "Tile Type Value:";
            this.lblTileType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTilesetExportRange
            // 
            this.lblTilesetExportRange.AutoSize = true;
            this.lblTilesetExportRange.Location = new System.Drawing.Point(4, 26);
            this.lblTilesetExportRange.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetExportRange.Name = "lblTilesetExportRange";
            this.lblTilesetExportRange.Size = new System.Drawing.Size(136, 13);
            this.lblTilesetExportRange.TabIndex = 27;
            this.lblTilesetExportRange.Text = "Tileset Tile Export Range:";
            this.lblTilesetExportRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTileType
            // 
            this.nudTileType.Location = new System.Drawing.Point(96, 0);
            this.nudTileType.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudTileType.Name = "nudTileType";
            this.nudTileType.Size = new System.Drawing.Size(72, 22);
            this.nudTileType.TabIndex = 29;
            this.nudTileType.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudTilesetExportEnd
            // 
            this.nudTilesetExportEnd.Location = new System.Drawing.Point(96, 44);
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
            this.nudTilesetExportStart.Location = new System.Drawing.Point(4, 44);
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
            this.lblTilesetRangeTo.Location = new System.Drawing.Point(75, 49);
            this.lblTilesetRangeTo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetRangeTo.Name = "lblTilesetRangeTo";
            this.lblTilesetRangeTo.Size = new System.Drawing.Size(18, 13);
            this.lblTilesetRangeTo.TabIndex = 24;
            this.lblTilesetRangeTo.Text = "to";
            this.lblTilesetRangeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblCreateTilemap);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(687, 557);
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
            this.tabMain.Size = new System.Drawing.Size(687, 557);
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
            this.tabTilemap.Size = new System.Drawing.Size(679, 531);
            this.tabTilemap.TabIndex = 0;
            this.tabTilemap.Text = "Tilemap";
            // 
            // tpnlTilemap
            // 
            this.tpnlTilemap.ColumnCount = 2;
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tpnlTilemap.Controls.Add(this.pnlTilemap, 0, 0);
            this.tpnlTilemap.Controls.Add(this.tabProperties, 1, 0);
            this.tpnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemap.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilemap.Name = "tpnlTilemap";
            this.tpnlTilemap.RowCount = 1;
            this.tpnlTilemap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.Size = new System.Drawing.Size(673, 525);
            this.tpnlTilemap.TabIndex = 0;
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.Controls.Add(this.pnlTilemapEdit);
            this.pnlTilemap.Controls.Add(this.panel7);
            this.pnlTilemap.Controls.Add(this.pnlTilemapToolbar);
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(475, 525);
            this.pnlTilemap.TabIndex = 5;
            // 
            // pnlTilemapEdit
            // 
            this.pnlTilemapEdit.AutoScroll = true;
            this.pnlTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(475, 443);
            this.pnlTilemapEdit.BlockSize = new System.Drawing.Size(16, 16);
            this.pnlTilemapEdit.BlockValue = ((byte)(0));
            this.pnlTilemapEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemapEdit.Centered = true;
            this.pnlTilemapEdit.ContextMenuStrip = this.mnuSelectOptions;
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
            this.pnlTilemapEdit.Location = new System.Drawing.Point(0, 48);
            this.pnlTilemapEdit.MinimumScale = 1;
            this.pnlTilemapEdit.Name = "pnlTilemapEdit";
            this.pnlTilemapEdit.Offset = 0;
            this.pnlTilemapEdit.Size = new System.Drawing.Size(475, 443);
            this.pnlTilemapEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemapEdit.TabIndex = 4;
            this.pnlTilemapEdit.TileID = -1;
            this.pnlTilemapEdit.TypeValue = ((byte)(0));
            this.pnlTilemapEdit.UseCanvas = false;
            this.pnlTilemapEdit.UseGrid = true;
            this.pnlTilemapEdit.UseHatch = true;
            this.pnlTilemapEdit.UseMouseWheelScaling = true;
            this.pnlTilemapEdit.UseOffset = false;
            this.pnlTilemapEdit.TileChanged += new SMSTileStudio.Controls.TilemapControl.TileChangedHandler(this.pnlTilemapEdit_TileChanged);
            this.pnlTilemapEdit.EntitiesChanged += new SMSTileStudio.Controls.TilemapControl.EntitiesChangedHandler(this.pnlTilemapEdit_EntitiesChanged);
            this.pnlTilemapEdit.PositionChanged += new SMSTileStudio.Controls.TilemapControl.PositionChangedHandler(this.pnlTilemapEdit_PositionChanged);
            // 
            // mnuSelectOptions
            // 
            this.mnuSelectOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateBrush,
            this.mnuClearSelection,
            this.mnuClearBrush,
            this.mnuSeparator4,
            this.mnuSetSelectionPriority,
            this.mnuUnsetSelectionPriority,
            this.mnuSetSelectionPalette,
            this.mnuUnsetSelectionPalette,
            this.mnuSetTileType,
            this.toolStripMenuItem1,
            this.mnuTilemapFromSelection,
            this.mnuCropTilemap});
            this.mnuSelectOptions.Name = "mnuSelectOptions";
            this.mnuSelectOptions.Size = new System.Drawing.Size(199, 236);
            // 
            // mnuCreateBrush
            // 
            this.mnuCreateBrush.Name = "mnuCreateBrush";
            this.mnuCreateBrush.Size = new System.Drawing.Size(198, 22);
            this.mnuCreateBrush.Text = "Brush From Selection";
            this.mnuCreateBrush.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuClearSelection
            // 
            this.mnuClearSelection.Name = "mnuClearSelection";
            this.mnuClearSelection.Size = new System.Drawing.Size(198, 22);
            this.mnuClearSelection.Text = "Clear Selection";
            this.mnuClearSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            // mnuSetSelectionPriority
            // 
            this.mnuSetSelectionPriority.Name = "mnuSetSelectionPriority";
            this.mnuSetSelectionPriority.Size = new System.Drawing.Size(198, 22);
            this.mnuSetSelectionPriority.Text = "Set Priority";
            this.mnuSetSelectionPriority.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUnsetSelectionPriority
            // 
            this.mnuUnsetSelectionPriority.Name = "mnuUnsetSelectionPriority";
            this.mnuUnsetSelectionPriority.Size = new System.Drawing.Size(198, 22);
            this.mnuUnsetSelectionPriority.Text = "Unset Priority";
            this.mnuUnsetSelectionPriority.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSetSelectionPalette
            // 
            this.mnuSetSelectionPalette.Name = "mnuSetSelectionPalette";
            this.mnuSetSelectionPalette.Size = new System.Drawing.Size(198, 22);
            this.mnuSetSelectionPalette.Text = "Set BG Palette";
            this.mnuSetSelectionPalette.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUnsetSelectionPalette
            // 
            this.mnuUnsetSelectionPalette.Name = "mnuUnsetSelectionPalette";
            this.mnuUnsetSelectionPalette.Size = new System.Drawing.Size(198, 22);
            this.mnuUnsetSelectionPalette.Text = "Set SPR Palette";
            this.mnuUnsetSelectionPalette.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSetTileType
            // 
            this.mnuSetTileType.Name = "mnuSetTileType";
            this.mnuSetTileType.Size = new System.Drawing.Size(198, 22);
            this.mnuSetTileType.Text = "Set Tile Type";
            this.mnuSetTileType.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuTilemapFromSelection
            // 
            this.mnuTilemapFromSelection.Name = "mnuTilemapFromSelection";
            this.mnuTilemapFromSelection.Size = new System.Drawing.Size(198, 22);
            this.mnuTilemapFromSelection.Text = "Tilemap From Selection";
            this.mnuTilemapFromSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuCropTilemap
            // 
            this.mnuCropTilemap.Name = "mnuCropTilemap";
            this.mnuCropTilemap.Size = new System.Drawing.Size(198, 22);
            this.mnuCropTilemap.Text = "Crop Tilemap";
            this.mnuCropTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblPosition);
            this.panel7.Controls.Add(this.lblTile);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 491);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(475, 34);
            this.panel7.TabIndex = 31;
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPosition.Location = new System.Drawing.Point(0, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(475, 17);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position: N/A";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTile
            // 
            this.lblTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTile.Location = new System.Drawing.Point(0, 17);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(475, 17);
            this.lblTile.TabIndex = 5;
            this.lblTile.Text = "Tile: N/A";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTilemapToolbar
            // 
            this.pnlTilemapToolbar.AutoSize = true;
            this.pnlTilemapToolbar.Controls.Add(this.rbBrush);
            this.pnlTilemapToolbar.Controls.Add(this.rbSelect);
            this.pnlTilemapToolbar.Controls.Add(this.rbFlipX);
            this.pnlTilemapToolbar.Controls.Add(this.rbFlipY);
            this.pnlTilemapToolbar.Controls.Add(this.rbPriority);
            this.pnlTilemapToolbar.Controls.Add(this.rbPalette);
            this.pnlTilemapToolbar.Controls.Add(this.rbTileType);
            this.pnlTilemapToolbar.Controls.Add(this.chkTilemapGrid);
            this.pnlTilemapToolbar.Controls.Add(this.chkShowTileIds);
            this.pnlTilemapToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemapToolbar.Name = "pnlTilemapToolbar";
            this.pnlTilemapToolbar.Size = new System.Drawing.Size(475, 48);
            this.pnlTilemapToolbar.TabIndex = 30;
            // 
            // rbBrush
            // 
            this.rbBrush.AutoSize = true;
            this.rbBrush.Checked = true;
            this.rbBrush.Location = new System.Drawing.Point(3, 3);
            this.rbBrush.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbBrush.Name = "rbBrush";
            this.rbBrush.Size = new System.Drawing.Size(54, 17);
            this.rbBrush.TabIndex = 0;
            this.rbBrush.TabStop = true;
            this.rbBrush.Text = "Brush";
            this.tipMain.SetToolTip(this.rbBrush, "Brush (B)");
            this.rbBrush.UseVisualStyleBackColor = true;
            this.rbBrush.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(60, 3);
            this.rbSelect.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(55, 17);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.Text = "Select";
            this.tipMain.SetToolTip(this.rbSelect, "Select (S)");
            this.rbSelect.UseVisualStyleBackColor = true;
            this.rbSelect.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbFlipX
            // 
            this.rbFlipX.AutoSize = true;
            this.rbFlipX.Location = new System.Drawing.Point(118, 3);
            this.rbFlipX.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbFlipX.Name = "rbFlipX";
            this.rbFlipX.Size = new System.Drawing.Size(55, 17);
            this.rbFlipX.TabIndex = 2;
            this.rbFlipX.Text = "H Flip";
            this.tipMain.SetToolTip(this.rbFlipX, "Horizontal Flip (H)");
            this.rbFlipX.UseVisualStyleBackColor = true;
            this.rbFlipX.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbFlipY
            // 
            this.rbFlipY.AutoSize = true;
            this.rbFlipY.Location = new System.Drawing.Point(176, 3);
            this.rbFlipY.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbFlipY.Name = "rbFlipY";
            this.rbFlipY.Size = new System.Drawing.Size(54, 17);
            this.rbFlipY.TabIndex = 3;
            this.rbFlipY.Text = "V Flip";
            this.tipMain.SetToolTip(this.rbFlipY, "Vertical Flip (V)");
            this.rbFlipY.UseVisualStyleBackColor = true;
            this.rbFlipY.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbPriority
            // 
            this.rbPriority.AutoSize = true;
            this.rbPriority.Location = new System.Drawing.Point(233, 3);
            this.rbPriority.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbPriority.Name = "rbPriority";
            this.rbPriority.Size = new System.Drawing.Size(61, 17);
            this.rbPriority.TabIndex = 4;
            this.rbPriority.Text = "Priority";
            this.tipMain.SetToolTip(this.rbPriority, "Priority (P)");
            this.rbPriority.UseVisualStyleBackColor = true;
            this.rbPriority.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbPalette
            // 
            this.rbPalette.AutoSize = true;
            this.rbPalette.Location = new System.Drawing.Point(297, 3);
            this.rbPalette.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbPalette.Name = "rbPalette";
            this.rbPalette.Size = new System.Drawing.Size(60, 17);
            this.rbPalette.TabIndex = 5;
            this.rbPalette.Text = "Palette";
            this.tipMain.SetToolTip(this.rbPalette, "Palette (L)");
            this.rbPalette.UseVisualStyleBackColor = true;
            this.rbPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTileType
            // 
            this.rbTileType.AutoSize = true;
            this.rbTileType.Location = new System.Drawing.Point(360, 3);
            this.rbTileType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTileType.Name = "rbTileType";
            this.rbTileType.Size = new System.Drawing.Size(48, 17);
            this.rbTileType.TabIndex = 31;
            this.rbTileType.Text = "Type";
            this.tipMain.SetToolTip(this.rbTileType, "Type Bits (T)");
            this.rbTileType.UseVisualStyleBackColor = true;
            this.rbTileType.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // chkTilemapGrid
            // 
            this.chkTilemapGrid.AutoSize = true;
            this.chkTilemapGrid.Checked = true;
            this.chkTilemapGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilemapGrid.Location = new System.Drawing.Point(411, 4);
            this.chkTilemapGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkTilemapGrid.Name = "chkTilemapGrid";
            this.chkTilemapGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilemapGrid.TabIndex = 12;
            this.chkTilemapGrid.Text = "Grid";
            this.tipMain.SetToolTip(this.chkTilemapGrid, "Toggle Grid (G)");
            this.chkTilemapGrid.UseVisualStyleBackColor = true;
            this.chkTilemapGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkShowTileIds
            // 
            this.chkShowTileIds.AutoSize = true;
            this.chkShowTileIds.Location = new System.Drawing.Point(3, 28);
            this.chkShowTileIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkShowTileIds.Name = "chkShowTileIds";
            this.chkShowTileIds.Size = new System.Drawing.Size(94, 17);
            this.chkShowTileIds.TabIndex = 13;
            this.chkShowTileIds.Text = "Show Tile Ids";
            this.tipMain.SetToolTip(this.chkShowTileIds, "Show Tile Ids (I)");
            this.chkShowTileIds.UseVisualStyleBackColor = true;
            this.chkShowTileIds.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.tabTilemapTiles);
            this.tabProperties.Controls.Add(this.tabMetatiles);
            this.tabProperties.Controls.Add(this.tabEntities);
            this.tabProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProperties.Location = new System.Drawing.Point(478, 3);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.SelectedIndex = 0;
            this.tabProperties.Size = new System.Drawing.Size(192, 519);
            this.tabProperties.TabIndex = 6;
            this.tabProperties.SelectedIndexChanged += new System.EventHandler(this.tabTilemap_SelectedIndexChanged);
            // 
            // tabTilemapTiles
            // 
            this.tabTilemapTiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemapTiles.Controls.Add(this.pnlTilemapOptions);
            this.tabTilemapTiles.Location = new System.Drawing.Point(4, 22);
            this.tabTilemapTiles.Name = "tabTilemapTiles";
            this.tabTilemapTiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemapTiles.Size = new System.Drawing.Size(184, 493);
            this.tabTilemapTiles.TabIndex = 0;
            this.tabTilemapTiles.Text = "Tiles";
            // 
            // pnlTilemapOptions
            // 
            this.pnlTilemapOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTilemapOptions.Controls.Add(this.tabTileOptions);
            this.pnlTilemapOptions.Controls.Add(this.pnlPaletteOptions);
            this.pnlTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemapOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlTilemapOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemapOptions.Name = "pnlTilemapOptions";
            this.pnlTilemapOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlTilemapOptions.Size = new System.Drawing.Size(178, 487);
            this.pnlTilemapOptions.TabIndex = 4;
            // 
            // tabTileOptions
            // 
            this.tabTileOptions.Controls.Add(this.tabTilePalette);
            this.tabTileOptions.Controls.Add(this.tabTileList);
            this.tabTileOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTileOptions.Location = new System.Drawing.Point(8, 192);
            this.tabTileOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tabTileOptions.Name = "tabTileOptions";
            this.tabTileOptions.SelectedIndex = 0;
            this.tabTileOptions.Size = new System.Drawing.Size(170, 295);
            this.tabTileOptions.TabIndex = 22;
            // 
            // tabTilePalette
            // 
            this.tabTilePalette.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilePalette.Controls.Add(this.pnlTiles);
            this.tabTilePalette.Controls.Add(this.panel1);
            this.tabTilePalette.Location = new System.Drawing.Point(4, 22);
            this.tabTilePalette.Margin = new System.Windows.Forms.Padding(0);
            this.tabTilePalette.Name = "tabTilePalette";
            this.tabTilePalette.Size = new System.Drawing.Size(162, 269);
            this.tabTilePalette.TabIndex = 0;
            this.tabTilePalette.Text = "Tile Palette";
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(435, 636);
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
            this.pnlTiles.Location = new System.Drawing.Point(0, 40);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(162, 229);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSelectedTileID);
            this.panel1.Controls.Add(this.lblSelectedTileIDValue);
            this.panel1.Controls.Add(this.chkHighlighter);
            this.panel1.Controls.Add(this.lblHighlighterCountValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 40);
            this.panel1.TabIndex = 22;
            // 
            // lblSelectedTileID
            // 
            this.lblSelectedTileID.AutoSize = true;
            this.lblSelectedTileID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTileID.Location = new System.Drawing.Point(1, 3);
            this.lblSelectedTileID.Name = "lblSelectedTileID";
            this.lblSelectedTileID.Size = new System.Drawing.Size(88, 13);
            this.lblSelectedTileID.TabIndex = 15;
            this.lblSelectedTileID.Text = "Selected Tile ID:";
            // 
            // lblSelectedTileIDValue
            // 
            this.lblSelectedTileIDValue.AutoSize = true;
            this.lblSelectedTileIDValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTileIDValue.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSelectedTileIDValue.Location = new System.Drawing.Point(91, 3);
            this.lblSelectedTileIDValue.Name = "lblSelectedTileIDValue";
            this.lblSelectedTileIDValue.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedTileIDValue.TabIndex = 16;
            this.lblSelectedTileIDValue.Text = "0";
            // 
            // chkHighlighter
            // 
            this.chkHighlighter.AutoSize = true;
            this.chkHighlighter.Location = new System.Drawing.Point(3, 21);
            this.chkHighlighter.Name = "chkHighlighter";
            this.chkHighlighter.Size = new System.Drawing.Size(113, 17);
            this.chkHighlighter.TabIndex = 18;
            this.chkHighlighter.Text = "Highlight Count:";
            this.chkHighlighter.UseVisualStyleBackColor = true;
            this.chkHighlighter.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // lblHighlighterCountValue
            // 
            this.lblHighlighterCountValue.AutoSize = true;
            this.lblHighlighterCountValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighlighterCountValue.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblHighlighterCountValue.Location = new System.Drawing.Point(115, 22);
            this.lblHighlighterCountValue.Name = "lblHighlighterCountValue";
            this.lblHighlighterCountValue.Size = new System.Drawing.Size(13, 13);
            this.lblHighlighterCountValue.TabIndex = 19;
            this.lblHighlighterCountValue.Text = "0";
            // 
            // tabTileList
            // 
            this.tabTileList.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileList.Controls.Add(this.panel4);
            this.tabTileList.Location = new System.Drawing.Point(4, 22);
            this.tabTileList.Name = "tabTileList";
            this.tabTileList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileList.Size = new System.Drawing.Size(162, 269);
            this.tabTileList.TabIndex = 1;
            this.tabTileList.Text = "Tile List";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 21);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(86, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Merge Tiles:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pnlPaletteOptions
            // 
            this.pnlPaletteOptions.Controls.Add(this.lblRows);
            this.pnlPaletteOptions.Controls.Add(this.lblColumns);
            this.pnlPaletteOptions.Controls.Add(this.nudRows);
            this.pnlPaletteOptions.Controls.Add(this.nudColumns);
            this.pnlPaletteOptions.Controls.Add(this.btnSelectionOptions);
            this.pnlPaletteOptions.Controls.Add(this.btnTilemapOptions);
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
            this.pnlPaletteOptions.Size = new System.Drawing.Size(170, 192);
            this.pnlPaletteOptions.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(120, 130);
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
            this.lblColumns.Location = new System.Drawing.Point(57, 130);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(55, 13);
            this.lblColumns.TabIndex = 25;
            this.lblColumns.Text = "Columns:";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(120, 146);
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
            this.nudColumns.Location = new System.Drawing.Point(60, 146);
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
            // btnSelectionOptions
            // 
            this.btnSelectionOptions.Location = new System.Drawing.Point(0, 24);
            this.btnSelectionOptions.Name = "btnSelectionOptions";
            this.btnSelectionOptions.Size = new System.Drawing.Size(168, 23);
            this.btnSelectionOptions.TabIndex = 22;
            this.btnSelectionOptions.Text = "Selection Options";
            this.btnSelectionOptions.UseVisualStyleBackColor = true;
            this.btnSelectionOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnTilemapOptions
            // 
            this.btnTilemapOptions.Location = new System.Drawing.Point(0, 0);
            this.btnTilemapOptions.Name = "btnTilemapOptions";
            this.btnTilemapOptions.Size = new System.Drawing.Size(168, 23);
            this.btnTilemapOptions.TabIndex = 20;
            this.btnTilemapOptions.Text = "Tilemap Options";
            this.btnTilemapOptions.UseVisualStyleBackColor = true;
            this.btnTilemapOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTilemapCompression
            // 
            this.lblTilemapCompression.AutoSize = true;
            this.lblTilemapCompression.Location = new System.Drawing.Point(0, 90);
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
            this.cbTilemapCompression.Location = new System.Drawing.Point(0, 106);
            this.cbTilemapCompression.Name = "cbTilemapCompression";
            this.cbTilemapCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapCompression.TabIndex = 8;
            this.cbTilemapCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // chkUseAttributes
            // 
            this.chkUseAttributes.AutoSize = true;
            this.chkUseAttributes.Location = new System.Drawing.Point(0, 172);
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
            this.nudOffset.Location = new System.Drawing.Point(0, 146);
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
            this.lblOffset.Location = new System.Drawing.Point(0, 130);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(42, 13);
            this.lblOffset.TabIndex = 7;
            this.lblOffset.Text = "Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 66);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 50);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tilemap Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMetatiles
            // 
            this.tabMetatiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabMetatiles.Controls.Add(this.panel6);
            this.tabMetatiles.Location = new System.Drawing.Point(4, 22);
            this.tabMetatiles.Name = "tabMetatiles";
            this.tabMetatiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetatiles.Size = new System.Drawing.Size(184, 493);
            this.tabMetatiles.TabIndex = 3;
            this.tabMetatiles.Text = "Metatiles";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tilesControl1);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(178, 487);
            this.panel6.TabIndex = 23;
            // 
            // tilesControl1
            // 
            this.tilesControl1.AllowSelection = true;
            this.tilesControl1.AutoScroll = true;
            this.tilesControl1.AutoScrollMinSize = new System.Drawing.Size(459, 1128);
            this.tilesControl1.Canvas = new System.Drawing.Size(8, 8);
            this.tilesControl1.Centered = false;
            this.tilesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesControl1.HatchBackColor = System.Drawing.Color.DarkGray;
            this.tilesControl1.HatchForeColor = System.Drawing.Color.White;
            this.tilesControl1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.tilesControl1.Image = null;
            this.tilesControl1.ImageAlpha = 1F;
            this.tilesControl1.ImageScale = 3;
            this.tilesControl1.Indexed = false;
            this.tilesControl1.Location = new System.Drawing.Point(8, 88);
            this.tilesControl1.MinimumScale = 1;
            this.tilesControl1.Name = "tilesControl1";
            this.tilesControl1.Offset = 0;
            this.tilesControl1.Size = new System.Drawing.Size(170, 399);
            this.tilesControl1.SnapSize = new System.Drawing.Size(8, 8);
            this.tilesControl1.TabIndex = 22;
            this.tilesControl1.TileCount = 0;
            this.tilesControl1.TileID = 0;
            this.tilesControl1.UseCanvas = false;
            this.tilesControl1.UseGrid = true;
            this.tilesControl1.UseHatch = true;
            this.tilesControl1.UseMouseWheelScaling = false;
            this.tilesControl1.UseOffset = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox2);
            this.panel5.Controls.Add(this.numericUpDown1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblBlockSize);
            this.panel5.Controls.Add(this.cbBlockSize);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 88);
            this.panel5.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Use Metatile value";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Metatile Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlockSize
            // 
            this.lblBlockSize.AutoSize = true;
            this.lblBlockSize.Location = new System.Drawing.Point(0, 3);
            this.lblBlockSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblBlockSize.Name = "lblBlockSize";
            this.lblBlockSize.Size = new System.Drawing.Size(75, 13);
            this.lblBlockSize.TabIndex = 28;
            this.lblBlockSize.Text = "Metatile Size:";
            this.lblBlockSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBlockSize
            // 
            this.cbBlockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlockSize.FormattingEnabled = true;
            this.cbBlockSize.Location = new System.Drawing.Point(0, 19);
            this.cbBlockSize.Name = "cbBlockSize";
            this.cbBlockSize.Size = new System.Drawing.Size(168, 21);
            this.cbBlockSize.TabIndex = 28;
            this.cbBlockSize.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // tabEntities
            // 
            this.tabEntities.BackColor = System.Drawing.SystemColors.Control;
            this.tabEntities.Controls.Add(this.panel2);
            this.tabEntities.Location = new System.Drawing.Point(4, 22);
            this.tabEntities.Name = "tabEntities";
            this.tabEntities.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntities.Size = new System.Drawing.Size(184, 493);
            this.tabEntities.TabIndex = 2;
            this.tabEntities.Text = "Entities";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lstEntities);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(178, 487);
            this.panel2.TabIndex = 6;
            // 
            // lstEntities
            // 
            this.lstEntities.DisableHighlighting = false;
            this.lstEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.HorizontalExtent = 166;
            this.lstEntities.IntegralHeight = false;
            this.lstEntities.Location = new System.Drawing.Point(8, 144);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(170, 343);
            this.lstEntities.TabIndex = 4;
            this.lstEntities.TextOffsetX = 2;
            this.lstEntities.TextOffsetY = 0;
            this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEntityName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nudEntityId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblEntityHeight);
            this.panel3.Controls.Add(this.nudEntityY);
            this.panel3.Controls.Add(this.nudEntityHeight);
            this.panel3.Controls.Add(this.lblEntityWidth);
            this.panel3.Controls.Add(this.lblEntityY);
            this.panel3.Controls.Add(this.nudEntityWidth);
            this.panel3.Controls.Add(this.nudEntityX);
            this.panel3.Controls.Add(this.lblEntityX);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 144);
            this.panel3.TabIndex = 3;
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(0, 40);
            this.txtEntityName.MaxLength = 50;
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(168, 22);
            this.txtEntityName.TabIndex = 42;
            this.txtEntityName.TextChanged += new System.EventHandler(this.txtEntityName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Entity Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEntityId
            // 
            this.nudEntityId.Location = new System.Drawing.Point(40, 65);
            this.nudEntityId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEntityId.Name = "nudEntityId";
            this.nudEntityId.Size = new System.Drawing.Size(120, 22);
            this.nudEntityId.TabIndex = 40;
            this.nudEntityId.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Id:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntityHeight
            // 
            this.lblEntityHeight.AutoSize = true;
            this.lblEntityHeight.Location = new System.Drawing.Point(91, 118);
            this.lblEntityHeight.Margin = new System.Windows.Forms.Padding(0);
            this.lblEntityHeight.Name = "lblEntityHeight";
            this.lblEntityHeight.Size = new System.Drawing.Size(18, 13);
            this.lblEntityHeight.TabIndex = 30;
            this.lblEntityHeight.Text = "H:";
            this.lblEntityHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEntityY
            // 
            this.nudEntityY.Location = new System.Drawing.Point(112, 89);
            this.nudEntityY.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityY.Name = "nudEntityY";
            this.nudEntityY.Size = new System.Drawing.Size(48, 22);
            this.nudEntityY.TabIndex = 35;
            this.nudEntityY.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudEntityHeight
            // 
            this.nudEntityHeight.Location = new System.Drawing.Point(112, 113);
            this.nudEntityHeight.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntityHeight.Name = "nudEntityHeight";
            this.nudEntityHeight.Size = new System.Drawing.Size(48, 22);
            this.nudEntityHeight.TabIndex = 31;
            this.nudEntityHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEntityHeight.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblEntityWidth
            // 
            this.lblEntityWidth.AutoSize = true;
            this.lblEntityWidth.Location = new System.Drawing.Point(2, 118);
            this.lblEntityWidth.Margin = new System.Windows.Forms.Padding(0);
            this.lblEntityWidth.Name = "lblEntityWidth";
            this.lblEntityWidth.Size = new System.Drawing.Size(21, 13);
            this.lblEntityWidth.TabIndex = 28;
            this.lblEntityWidth.Text = "W:";
            this.lblEntityWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntityY
            // 
            this.lblEntityY.AutoSize = true;
            this.lblEntityY.Location = new System.Drawing.Point(91, 92);
            this.lblEntityY.Margin = new System.Windows.Forms.Padding(0);
            this.lblEntityY.Name = "lblEntityY";
            this.lblEntityY.Size = new System.Drawing.Size(15, 13);
            this.lblEntityY.TabIndex = 34;
            this.lblEntityY.Text = "Y:";
            this.lblEntityY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEntityWidth
            // 
            this.nudEntityWidth.Location = new System.Drawing.Point(40, 113);
            this.nudEntityWidth.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntityWidth.Name = "nudEntityWidth";
            this.nudEntityWidth.Size = new System.Drawing.Size(48, 22);
            this.nudEntityWidth.TabIndex = 29;
            this.nudEntityWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEntityWidth.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudEntityX
            // 
            this.nudEntityX.Location = new System.Drawing.Point(40, 89);
            this.nudEntityX.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityX.Name = "nudEntityX";
            this.nudEntityX.Size = new System.Drawing.Size(48, 22);
            this.nudEntityX.TabIndex = 33;
            this.nudEntityX.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblEntityX
            // 
            this.lblEntityX.AutoSize = true;
            this.lblEntityX.Location = new System.Drawing.Point(2, 92);
            this.lblEntityX.Margin = new System.Windows.Forms.Padding(0);
            this.lblEntityX.Name = "lblEntityX";
            this.lblEntityX.Size = new System.Drawing.Size(16, 13);
            this.lblEntityX.TabIndex = 32;
            this.lblEntityX.Text = "X:";
            this.lblEntityX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove Entity";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabTileset
            // 
            this.tabTileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileset.Controls.Add(this.tpnlTileset);
            this.tabTileset.Location = new System.Drawing.Point(4, 22);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(679, 531);
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
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTileset.Size = new System.Drawing.Size(673, 525);
            this.tpnlTileset.TabIndex = 0;
            // 
            // pnlTilesetOptions
            // 
            this.pnlTilesetOptions.Controls.Add(this.btnTilesetOptions);
            this.pnlTilesetOptions.Controls.Add(this.pnlSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlBGPalette);
            this.pnlTilesetOptions.Controls.Add(this.pnlSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.rbBgPalette);
            this.pnlTilesetOptions.Controls.Add(this.btnSwapSelectedPixel);
            this.pnlTilesetOptions.Controls.Add(this.rbSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.lblSelectedTile);
            this.pnlTilesetOptions.Controls.Add(this.lblTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.cbTilesetCompression);
            this.pnlTilesetOptions.Controls.Add(this.lblSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbSprPalette);
            this.pnlTilesetOptions.Controls.Add(this.lblBgPalette);
            this.pnlTilesetOptions.Controls.Add(this.cbBgPalette);
            this.pnlTilesetOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetOptions.Location = new System.Drawing.Point(493, 0);
            this.pnlTilesetOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilesetOptions.Name = "pnlTilesetOptions";
            this.pnlTilesetOptions.Size = new System.Drawing.Size(180, 525);
            this.pnlTilesetOptions.TabIndex = 3;
            // 
            // btnTilesetOptions
            // 
            this.btnTilesetOptions.Location = new System.Drawing.Point(8, 0);
            this.btnTilesetOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilesetOptions.Name = "btnTilesetOptions";
            this.btnTilesetOptions.Size = new System.Drawing.Size(168, 23);
            this.btnTilesetOptions.TabIndex = 20;
            this.btnTilesetOptions.Text = "Tileset Options";
            this.btnTilesetOptions.UseVisualStyleBackColor = true;
            this.btnTilesetOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // pnlSprPalette
            // 
            this.pnlSprPalette.Location = new System.Drawing.Point(8, 168);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSprPalette.TabIndex = 19;
            this.pnlSprPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlSPRPalette_SelectedColorChanged);
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 88);
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
            this.pnlSelectedTile.Location = new System.Drawing.Point(20, 264);
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
            // rbBgPalette
            // 
            this.rbBgPalette.AutoSize = true;
            this.rbBgPalette.Checked = true;
            this.rbBgPalette.Location = new System.Drawing.Point(10, 26);
            this.rbBgPalette.Name = "rbBgPalette";
            this.rbBgPalette.Size = new System.Drawing.Size(77, 17);
            this.rbBgPalette.TabIndex = 9;
            this.rbBgPalette.TabStop = true;
            this.rbBgPalette.Text = "BG Palette";
            this.rbBgPalette.UseVisualStyleBackColor = true;
            this.rbBgPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // btnSwapSelectedPixel
            // 
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(8, 412);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(168, 23);
            this.btnSwapSelectedPixel.TabIndex = 17;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            this.btnSwapSelectedPixel.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // rbSprPalette
            // 
            this.rbSprPalette.AutoSize = true;
            this.rbSprPalette.Location = new System.Drawing.Point(90, 26);
            this.rbSprPalette.Name = "rbSprPalette";
            this.rbSprPalette.Size = new System.Drawing.Size(82, 17);
            this.rbSprPalette.TabIndex = 10;
            this.rbSprPalette.Text = "SPR Palette";
            this.rbSprPalette.UseVisualStyleBackColor = true;
            this.rbSprPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // lblSelectedTile
            // 
            this.lblSelectedTile.AutoSize = true;
            this.lblSelectedTile.Location = new System.Drawing.Point(8, 248);
            this.lblSelectedTile.Name = "lblSelectedTile";
            this.lblSelectedTile.Size = new System.Drawing.Size(74, 13);
            this.lblSelectedTile.TabIndex = 12;
            this.lblSelectedTile.Text = "Selected Tile:";
            // 
            // lblTilesetCompression
            // 
            this.lblTilesetCompression.AutoSize = true;
            this.lblTilesetCompression.Location = new System.Drawing.Point(8, 208);
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
            this.cbTilesetCompression.Location = new System.Drawing.Point(8, 224);
            this.cbTilesetCompression.Name = "cbTilesetCompression";
            this.cbTilesetCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilesetCompression.TabIndex = 9;
            this.cbTilesetCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblSprPalette
            // 
            this.lblSprPalette.AutoSize = true;
            this.lblSprPalette.Location = new System.Drawing.Point(8, 128);
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
            this.cbSprPalette.Location = new System.Drawing.Point(8, 144);
            this.cbSprPalette.Name = "cbSprPalette";
            this.cbSprPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSprPalette.TabIndex = 7;
            this.cbSprPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblBgPalette
            // 
            this.lblBgPalette.AutoSize = true;
            this.lblBgPalette.Location = new System.Drawing.Point(8, 48);
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
            this.cbBgPalette.Location = new System.Drawing.Point(8, 64);
            this.cbBgPalette.Name = "cbBgPalette";
            this.cbBgPalette.Size = new System.Drawing.Size(168, 21);
            this.cbBgPalette.TabIndex = 5;
            this.cbBgPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // pnlTileset
            // 
            this.pnlTileset.Controls.Add(this.pnlTilesetEdit);
            this.pnlTileset.Controls.Add(this.flowLayoutPanel1);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(0, 0);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(493, 525);
            this.pnlTileset.TabIndex = 4;
            // 
            // pnlTilesetEdit
            // 
            this.pnlTilesetEdit.AutoScroll = true;
            this.pnlTilesetEdit.AutoScrollMinSize = new System.Drawing.Size(493, 501);
            this.pnlTilesetEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilesetEdit.Centered = true;
            this.pnlTilesetEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetEdit.EditMode = SMSTileStudio.Data.TilesetEditType.Select;
            this.pnlTilesetEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilesetEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilesetEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilesetEdit.Image = null;
            this.pnlTilesetEdit.ImageAlpha = 1F;
            this.pnlTilesetEdit.ImageScale = 1;
            this.pnlTilesetEdit.Indexed = false;
            this.pnlTilesetEdit.Location = new System.Drawing.Point(0, 24);
            this.pnlTilesetEdit.MinimumScale = 1;
            this.pnlTilesetEdit.Name = "pnlTilesetEdit";
            this.pnlTilesetEdit.Size = new System.Drawing.Size(493, 501);
            this.pnlTilesetEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetEdit.TabIndex = 1;
            this.pnlTilesetEdit.TypeValue = 0;
            this.pnlTilesetEdit.UseCanvas = false;
            this.pnlTilesetEdit.UseGrid = true;
            this.pnlTilesetEdit.UseHatch = true;
            this.pnlTilesetEdit.UseMouseWheelScaling = true;
            this.pnlTilesetEdit.TileSelectionChanged += new SMSTileStudio.Controls.TilesetImageControl.TileSelectionHandler(this.pnlTilesetEdit_TileSelectionChanged);
            this.pnlTilesetEdit.TilesChanged += new SMSTileStudio.Controls.TilesetImageControl.TilesChangedHandler(this.pnlTilesetEdit_TilesChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbTilesetSelect);
            this.flowLayoutPanel1.Controls.Add(this.rbTilesetSwap);
            this.flowLayoutPanel1.Controls.Add(this.rbTilesetType);
            this.flowLayoutPanel1.Controls.Add(this.chkTilesetGrid);
            this.flowLayoutPanel1.Controls.Add(this.chkTilesetShowTileIds);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rbTilesetSelect
            // 
            this.rbTilesetSelect.AutoSize = true;
            this.rbTilesetSelect.Checked = true;
            this.rbTilesetSelect.Location = new System.Drawing.Point(3, 3);
            this.rbTilesetSelect.Name = "rbTilesetSelect";
            this.rbTilesetSelect.Size = new System.Drawing.Size(55, 17);
            this.rbTilesetSelect.TabIndex = 11;
            this.rbTilesetSelect.TabStop = true;
            this.rbTilesetSelect.Text = "Select";
            this.tipMain.SetToolTip(this.rbTilesetSelect, "Select (S)");
            this.rbTilesetSelect.UseVisualStyleBackColor = true;
            this.rbTilesetSelect.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilesetSwap
            // 
            this.rbTilesetSwap.AutoSize = true;
            this.rbTilesetSwap.Location = new System.Drawing.Point(64, 3);
            this.rbTilesetSwap.Name = "rbTilesetSwap";
            this.rbTilesetSwap.Size = new System.Drawing.Size(53, 17);
            this.rbTilesetSwap.TabIndex = 10;
            this.rbTilesetSwap.Text = "Swap";
            this.tipMain.SetToolTip(this.rbTilesetSwap, "Swap (W)");
            this.rbTilesetSwap.UseVisualStyleBackColor = true;
            this.rbTilesetSwap.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilesetType
            // 
            this.rbTilesetType.AutoSize = true;
            this.rbTilesetType.Location = new System.Drawing.Point(123, 3);
            this.rbTilesetType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilesetType.Name = "rbTilesetType";
            this.rbTilesetType.Size = new System.Drawing.Size(48, 17);
            this.rbTilesetType.TabIndex = 28;
            this.rbTilesetType.Text = "Type";
            this.rbTilesetType.UseVisualStyleBackColor = true;
            this.rbTilesetType.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // chkTilesetGrid
            // 
            this.chkTilesetGrid.AutoSize = true;
            this.chkTilesetGrid.Checked = true;
            this.chkTilesetGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetGrid.Location = new System.Drawing.Point(174, 4);
            this.chkTilesetGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkTilesetGrid.Name = "chkTilesetGrid";
            this.chkTilesetGrid.Size = new System.Drawing.Size(48, 17);
            this.chkTilesetGrid.TabIndex = 10;
            this.chkTilesetGrid.Text = "Grid";
            this.tipMain.SetToolTip(this.chkTilesetGrid, "Toggle Grid (G)");
            this.chkTilesetGrid.UseVisualStyleBackColor = true;
            this.chkTilesetGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkTilesetShowTileIds
            // 
            this.chkTilesetShowTileIds.AutoSize = true;
            this.chkTilesetShowTileIds.Location = new System.Drawing.Point(228, 4);
            this.chkTilesetShowTileIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkTilesetShowTileIds.Name = "chkTilesetShowTileIds";
            this.chkTilesetShowTileIds.Size = new System.Drawing.Size(94, 17);
            this.chkTilesetShowTileIds.TabIndex = 11;
            this.chkTilesetShowTileIds.Text = "Show Tile Ids";
            this.tipMain.SetToolTip(this.chkTilesetShowTileIds, "Show Tile Ids (I)");
            this.chkTilesetShowTileIds.UseVisualStyleBackColor = true;
            this.chkTilesetShowTileIds.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // lblCreateTilemap
            // 
            this.lblCreateTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateTilemap.Location = new System.Drawing.Point(0, 0);
            this.lblCreateTilemap.Name = "lblCreateTilemap";
            this.lblCreateTilemap.Size = new System.Drawing.Size(687, 557);
            this.lblCreateTilemap.TabIndex = 1;
            this.lblCreateTilemap.Text = "Create or select a tilemap to edit";
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
            this.mnuExportAll,
            this.toolStripMenuItem2,
            this.mnuExportPalette,
            this.mnuExportTileset,
            this.mnuExportTilemap,
            this.mnuExportMetatiles,
            this.mnuExportEntities});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(160, 142);
            // 
            // mnuExportAll
            // 
            this.mnuExportAll.Name = "mnuExportAll";
            this.mnuExportAll.Size = new System.Drawing.Size(159, 22);
            this.mnuExportAll.Text = "Export All";
            this.mnuExportAll.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
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
            this.mnuExportPalette.Size = new System.Drawing.Size(159, 22);
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
            this.mnuExportTileset.Size = new System.Drawing.Size(159, 22);
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
            this.mnuExportTilemap.Size = new System.Drawing.Size(159, 22);
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
            // mnuExportMetatiles
            // 
            this.mnuExportMetatiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMetatilesBypassCompression,
            this.mnuSeparator5,
            this.mnuMetatilesExportBinary,
            this.mnuMetatilesExportHex,
            this.mnuMetatilesExportAsm,
            this.mnuMetatileMap});
            this.mnuExportMetatiles.Name = "mnuExportMetatiles";
            this.mnuExportMetatiles.Size = new System.Drawing.Size(159, 22);
            this.mnuExportMetatiles.Text = "Export Metatiles";
            // 
            // mnuMetatilesBypassCompression
            // 
            this.mnuMetatilesBypassCompression.CheckOnClick = true;
            this.mnuMetatilesBypassCompression.Name = "mnuMetatilesBypassCompression";
            this.mnuMetatilesBypassCompression.Size = new System.Drawing.Size(239, 22);
            this.mnuMetatilesBypassCompression.Text = "Bypass Compression";
            // 
            // mnuSeparator5
            // 
            this.mnuSeparator5.Name = "mnuSeparator5";
            this.mnuSeparator5.Size = new System.Drawing.Size(236, 6);
            // 
            // mnuMetatilesExportBinary
            // 
            this.mnuMetatilesExportBinary.Name = "mnuMetatilesExportBinary";
            this.mnuMetatilesExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuMetatilesExportBinary.Text = "Export as Binary";
            // 
            // mnuMetatilesExportHex
            // 
            this.mnuMetatilesExportHex.Name = "mnuMetatilesExportHex";
            this.mnuMetatilesExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuMetatilesExportHex.Text = "Export as Hex (Clipboard)";
            // 
            // mnuMetatilesExportAsm
            // 
            this.mnuMetatilesExportAsm.Name = "mnuMetatilesExportAsm";
            this.mnuMetatilesExportAsm.Size = new System.Drawing.Size(239, 22);
            this.mnuMetatilesExportAsm.Text = "Export as Assembly (Clipboard)";
            // 
            // mnuMetatileMap
            // 
            this.mnuMetatileMap.Name = "mnuMetatileMap";
            this.mnuMetatileMap.Size = new System.Drawing.Size(239, 22);
            this.mnuMetatileMap.Text = "Export Metatile Map";
            // 
            // mnuExportEntities
            // 
            this.mnuExportEntities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEntitiesExportBinary,
            this.mnuEntitiesExportHex,
            this.mnuEntitiesExportAsm});
            this.mnuExportEntities.Name = "mnuExportEntities";
            this.mnuExportEntities.Size = new System.Drawing.Size(159, 22);
            this.mnuExportEntities.Text = "Export Entities";
            // 
            // mnuEntitiesExportBinary
            // 
            this.mnuEntitiesExportBinary.Name = "mnuEntitiesExportBinary";
            this.mnuEntitiesExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuEntitiesExportBinary.Text = "Export as Binary";
            this.mnuEntitiesExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuEntitiesExportHex
            // 
            this.mnuEntitiesExportHex.Name = "mnuEntitiesExportHex";
            this.mnuEntitiesExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuEntitiesExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuEntitiesExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuEntitiesExportAsm
            // 
            this.mnuEntitiesExportAsm.Name = "mnuEntitiesExportAsm";
            this.mnuEntitiesExportAsm.Size = new System.Drawing.Size(239, 22);
            this.mnuEntitiesExportAsm.Text = "Export as Assembly (Clipboard)";
            this.mnuEntitiesExportAsm.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            // mnuTilesetOptions
            // 
            this.mnuTilesetOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.mnuAddTile,
            this.mnuDeselectTile,
            this.mnuRemoveTile,
            this.mnuRemoveByRange,
            this.mnuSeperator20,
            this.mnuCopyTileset,
            this.mnuPasteTileset,
            this.mnuBulkPasteTileset});
            this.mnuTilesetOptions.Name = "mnuTileOptions";
            this.mnuTilesetOptions.Size = new System.Drawing.Size(207, 192);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuAddTile
            // 
            this.mnuAddTile.Name = "mnuAddTile";
            this.mnuAddTile.Size = new System.Drawing.Size(206, 22);
            this.mnuAddTile.Text = "Add Empty Tile";
            this.mnuAddTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuDeselectTile
            // 
            this.mnuDeselectTile.Name = "mnuDeselectTile";
            this.mnuDeselectTile.Size = new System.Drawing.Size(206, 22);
            this.mnuDeselectTile.Text = "Deselect Tile";
            this.mnuDeselectTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuRemoveTile
            // 
            this.mnuRemoveTile.Name = "mnuRemoveTile";
            this.mnuRemoveTile.ShortcutKeyDisplayString = "Del";
            this.mnuRemoveTile.Size = new System.Drawing.Size(206, 22);
            this.mnuRemoveTile.Text = "Remove Tile";
            this.mnuRemoveTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuRemoveByRange
            // 
            this.mnuRemoveByRange.Name = "mnuRemoveByRange";
            this.mnuRemoveByRange.Size = new System.Drawing.Size(206, 22);
            this.mnuRemoveByRange.Text = "Remove By Export Range";
            this.mnuRemoveByRange.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSeperator20
            // 
            this.mnuSeperator20.Name = "mnuSeperator20";
            this.mnuSeperator20.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuCopyTileset
            // 
            this.mnuCopyTileset.Name = "mnuCopyTileset";
            this.mnuCopyTileset.Size = new System.Drawing.Size(206, 22);
            this.mnuCopyTileset.Text = "Copy Tileset";
            this.mnuCopyTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuPasteTileset
            // 
            this.mnuPasteTileset.Name = "mnuPasteTileset";
            this.mnuPasteTileset.Size = new System.Drawing.Size(206, 22);
            this.mnuPasteTileset.Text = "Paste Tileset";
            this.mnuPasteTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapOptions
            // 
            this.mnuTilemapOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReplaceTiles,
            this.mnuOptimizeTilemap});
            this.mnuTilemapOptions.Name = "mnuTilemapOptions";
            this.mnuTilemapOptions.Size = new System.Drawing.Size(168, 48);
            // 
            // mnuReplaceTiles
            // 
            this.mnuReplaceTiles.Name = "mnuReplaceTiles";
            this.mnuReplaceTiles.Size = new System.Drawing.Size(167, 22);
            this.mnuReplaceTiles.Text = "Replace Tiles";
            this.mnuReplaceTiles.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuOptimizeTilemap
            // 
            this.mnuOptimizeTilemap.Name = "mnuOptimizeTilemap";
            this.mnuOptimizeTilemap.Size = new System.Drawing.Size(167, 22);
            this.mnuOptimizeTilemap.Text = "Optimize Tilemap";
            this.mnuOptimizeTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuBulkPasteTileset
            // 
            this.mnuBulkPasteTileset.Name = "mnuBulkPasteTileset";
            this.mnuBulkPasteTileset.Size = new System.Drawing.Size(206, 22);
            this.mnuBulkPasteTileset.Text = "Bulk Paste Tileset";
            this.mnuBulkPasteTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // AssetTilemapControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetTilemapControl";
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.ResumeLayout(false);
            this.grpImageList.ResumeLayout(false);
            this.pnlPaletteButtons.ResumeLayout(false);
            this.pnlPalettes.ResumeLayout(false);
            this.pnlPalettes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabTilemap.ResumeLayout(false);
            this.tpnlTilemap.ResumeLayout(false);
            this.pnlTilemap.ResumeLayout(false);
            this.pnlTilemap.PerformLayout();
            this.mnuSelectOptions.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlTilemapToolbar.ResumeLayout(false);
            this.pnlTilemapToolbar.PerformLayout();
            this.tabProperties.ResumeLayout(false);
            this.tabTilemapTiles.ResumeLayout(false);
            this.pnlTilemapOptions.ResumeLayout(false);
            this.tabTileOptions.ResumeLayout(false);
            this.tabTilePalette.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTileList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlPaletteOptions.ResumeLayout(false);
            this.pnlPaletteOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.tabMetatiles.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabEntities.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityX)).EndInit();
            this.tabTileset.ResumeLayout(false);
            this.tpnlTileset.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            this.pnlTileset.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mnuExport.ResumeLayout(false);
            this.mnuImport.ResumeLayout(false);
            this.mnuTilesetOptions.ResumeLayout(false);
            this.mnuTilemapOptions.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkTilemapGrid;
        private System.Windows.Forms.CheckBox chkShowTileIds;
        private System.Windows.Forms.TableLayoutPanel tpnlTileset;
        private System.Windows.Forms.CheckBox chkTilesetGrid;
        private System.Windows.Forms.CheckBox chkTilesetShowTileIds;
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
        private System.Windows.Forms.Button btnTilesetOptions;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnSelectionOptions;
        private System.Windows.Forms.Button btnExport;
        private TilemapControl pnlTilemapEdit;
        private TilesetImageControl pnlTilesetEdit;
        private System.Windows.Forms.Label lblCreateTilemap;
        private System.Windows.Forms.Panel pnlPalettes;
        private System.Windows.Forms.RadioButton rbBgPalette;
        private System.Windows.Forms.RadioButton rbSprPalette;
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
        private System.Windows.Forms.ToolStripMenuItem mnuExportPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportImage;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuPaletteExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBgPalette;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
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
        private System.Windows.Forms.ToolStripMenuItem mnuSetSelectionPriority;
        private System.Windows.Forms.ToolStripMenuItem mnuUnsetSelectionPriority;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSetSelectionPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuUnsetSelectionPalette;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbPalette;
        private System.Windows.Forms.RadioButton rbPriority;
        private System.Windows.Forms.RadioButton rbFlipY;
        private System.Windows.Forms.RadioButton rbFlipX;
        private System.Windows.Forms.RadioButton rbBrush;
        private System.Windows.Forms.RadioButton rbTilesetSwap;
        private System.Windows.Forms.TabControl tabProperties;
        private System.Windows.Forms.TabPage tabTilemapTiles;
        private System.Windows.Forms.TabPage tabEntities;
        private System.Windows.Forms.Panel panel2;
        private ListBoxControl lstEntities;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudEntityId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuExportEntities;
        private System.Windows.Forms.ToolStripMenuItem mnuEntitiesExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuEntitiesExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuEntitiesExportAsm;
        private System.Windows.Forms.NumericUpDown nudEntityY;
        private System.Windows.Forms.Label lblEntityY;
        private System.Windows.Forms.NumericUpDown nudEntityX;
        private System.Windows.Forms.Label lblEntityX;
        private System.Windows.Forms.Label lblEntityHeight;
        private System.Windows.Forms.NumericUpDown nudEntityHeight;
        private System.Windows.Forms.Label lblEntityWidth;
        private System.Windows.Forms.NumericUpDown nudEntityWidth;
        private System.Windows.Forms.ContextMenuStrip mnuTilesetOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTile;
        private System.Windows.Forms.ToolStripMenuItem mnuDeselectTile;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTile;
        private System.Windows.Forms.ToolStripSeparator mnuSeperator20;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuPasteTileset;
        private System.Windows.Forms.RadioButton rbTilesetSelect;
        private System.Windows.Forms.Button btnTilemapOptions;
        private System.Windows.Forms.ContextMenuStrip mnuTilemapOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuReplaceTiles;
        private System.Windows.Forms.ToolStripMenuItem mnuOptimizeTilemap;
        private System.Windows.Forms.ComboBox cbBlockSize;
        private System.Windows.Forms.FlowLayoutPanel pnlTilemapToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTileType;
        private System.Windows.Forms.TabPage tabMetatiles;
        private System.Windows.Forms.TabControl tabTileOptions;
        private System.Windows.Forms.TabPage tabTilePalette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabTileList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBlockSize;
        private TilesControl tilesControl1;
        private System.Windows.Forms.RadioButton rbTilesetType;
        private System.Windows.Forms.NumericUpDown nudTileType;
        private System.Windows.Forms.RadioButton rbTileType;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Panel pnlTileset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mnuClearSelection;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetatiles;
        private System.Windows.Forms.ToolStripMenuItem mnuMetatilesBypassCompression;
        private System.Windows.Forms.ToolStripMenuItem mnuMetatilesExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuMetatilesExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuMetatilesExportAsm;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.ToolStripMenuItem mnuMetatileMap;
        private System.Windows.Forms.ToolStripMenuItem mnuCropTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveByRange;
        private System.Windows.Forms.ToolTip tipMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBulkPasteTileset;
    }
}
