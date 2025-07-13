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
            this.btnTilemapOptions = new System.Windows.Forms.Button();
            this.btnTilemapRemove = new System.Windows.Forms.Button();
            this.btnTilemapDuplicate = new System.Windows.Forms.Button();
            this.btnTilemapNew = new System.Windows.Forms.Button();
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
            this.mnuSetSelectionTileId = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetSelectionPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnsetSelectionPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetSelectionPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnsetSelectionPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetTileType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMirrorX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMirrorY = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapFromSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectionToTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCropTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportSelectedIds = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSelectionToImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSelectionToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAsSGBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportSelectionDecimalToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSelectionDecimalReversedToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSelectedIndexes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAreaToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportSelectedIndexesToDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSelectedIndexesToDecimalReversed = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.pnlTilemapToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTilemapBrush = new System.Windows.Forms.RadioButton();
            this.rbTilemapSelect = new System.Windows.Forms.RadioButton();
            this.rbTilemapFlipX = new System.Windows.Forms.RadioButton();
            this.rbTilemapFlipY = new System.Windows.Forms.RadioButton();
            this.rbTilemapPriority = new System.Windows.Forms.RadioButton();
            this.rbTilemapPalette = new System.Windows.Forms.RadioButton();
            this.rbTilemapTileType = new System.Windows.Forms.RadioButton();
            this.chkTilemapGrid = new System.Windows.Forms.CheckBox();
            this.chkTilemapAreaGrid = new System.Windows.Forms.CheckBox();
            this.chkTilemapInvertGrids = new System.Windows.Forms.CheckBox();
            this.chkTilemapShowTileAs = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbTilemapShowIndexes = new System.Windows.Forms.RadioButton();
            this.rbTilemapShowIds = new System.Windows.Forms.RadioButton();
            this.lblSelection = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudAreaGridRows = new System.Windows.Forms.NumericUpDown();
            this.nudAreaGridCols = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.btnSelectionOptions = new System.Windows.Forms.Button();
            this.lblTilemapCompression = new System.Windows.Forms.Label();
            this.cbTilemapCompression = new System.Windows.Forms.ComboBox();
            this.chkUseAttributes = new System.Windows.Forms.CheckBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabTileGrids = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lstTileGrids = new SMSTileStudio.Controls.ListBoxControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTileGridTileSize = new System.Windows.Forms.Label();
            this.cbTileGridTileSize = new System.Windows.Forms.ComboBox();
            this.lblTileGridRows = new System.Windows.Forms.Label();
            this.lblTileGridColumns = new System.Windows.Forms.Label();
            this.nudTileGridRows = new System.Windows.Forms.NumericUpDown();
            this.nudTileGridColumns = new System.Windows.Forms.NumericUpDown();
            this.nudTileGridValue = new System.Windows.Forms.NumericUpDown();
            this.lblTileGridValue = new System.Windows.Forms.Label();
            this.btnTileGridOptions = new System.Windows.Forms.Button();
            this.txtTileGridName = new System.Windows.Forms.TextBox();
            this.lblTileGridName = new System.Windows.Forms.Label();
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
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTilesetSelect = new System.Windows.Forms.RadioButton();
            this.rbTilesetSwap = new System.Windows.Forms.RadioButton();
            this.rbTilesetType = new System.Windows.Forms.RadioButton();
            this.chkTilesetGrid = new System.Windows.Forms.CheckBox();
            this.chkTilesetShowTileIds = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTilesetOptions = new System.Windows.Forms.TabPage();
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
            this.tabTags = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lstTags = new SMSTileStudio.Controls.ListBoxControl();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnBulkAddTag = new System.Windows.Forms.Button();
            this.btnAddExistingTag = new System.Windows.Forms.Button();
            this.cbExistingTags = new System.Windows.Forms.ComboBox();
            this.lblExistingTag = new System.Windows.Forms.Label();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.lblTagName = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.tabMetaTilemap = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnlMetaTilemapEdit = new SMSTileStudio.Controls.MetaTilemapControl();
            this.pnlMetaTilemapInfo = new System.Windows.Forms.Panel();
            this.lblMetaTileProperties = new System.Windows.Forms.Label();
            this.lblMetaTilemapProperties = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMetaTileOptions = new System.Windows.Forms.Panel();
            this.pnlMetaTilesEdit = new SMSTileStudio.Controls.MetaTilesControl();
            this.pnlMetaTileTools = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMetaTileIds = new System.Windows.Forms.RadioButton();
            this.rbMetaTilePriority = new System.Windows.Forms.RadioButton();
            this.rbMetaTilePalette = new System.Windows.Forms.RadioButton();
            this.rbMetaTileType = new System.Windows.Forms.RadioButton();
            this.pnlMetaTilePaletteOptions = new System.Windows.Forms.Panel();
            this.lblMetaTileSize = new System.Windows.Forms.Label();
            this.cbMetaTileSize = new System.Windows.Forms.ComboBox();
            this.btnMetaTileOptions = new System.Windows.Forms.Button();
            this.mnuMetaTileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGenerateMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAllMetaData = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMetaTileApplyEditsByTileId = new System.Windows.Forms.CheckBox();
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
            this.mnuTilesetExportImages = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportBinaries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapBypassCompression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapVerticalOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportImages = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportImagesFromAreaGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportBinaries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinariesFromAreaGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportSGBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapExportDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuImportTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetCopyTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilesetPasteTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeselectTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveByRange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeperator20 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPasteTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBulkPasteTileset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuReplaceTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptimizeTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTilemapBulkRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTilemapsFromAreaGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.mnuTileGridOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuNewTileGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuplicateTileGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTileGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportTileGrid = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel8.SuspendLayout();
            this.tabProperties.SuspendLayout();
            this.tabTilemapTiles.SuspendLayout();
            this.pnlTilemapOptions.SuspendLayout();
            this.tabTileOptions.SuspendLayout();
            this.tabTilePalette.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabTileList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlPaletteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.tabTileGrids.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridValue)).BeginInit();
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
            this.pnlTileset.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTilesetOptions.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            this.tabTags.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabMetaTilemap.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnlMetaTilemapInfo.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMetaTileOptions.SuspendLayout();
            this.pnlMetaTileTools.SuspendLayout();
            this.pnlMetaTilePaletteOptions.SuspendLayout();
            this.mnuMetaTileOptions.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.mnuImport.SuspendLayout();
            this.mnuTilesetOptions.SuspendLayout();
            this.mnuTilemapOptions.SuspendLayout();
            this.mnuTileGridOptions.SuspendLayout();
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
            this.lstTilemaps.Location = new System.Drawing.Point(12, 230);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(172, 315);
            this.lstTilemaps.TabIndex = 1;
            this.lstTilemaps.TextOffsetX = 2;
            this.lstTilemaps.TextOffsetY = 0;
            this.lstTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstTilemaps_SelectedIndexChanged);
            // 
            // pnlPaletteButtons
            // 
            this.pnlPaletteButtons.Controls.Add(this.btnExport);
            this.pnlPaletteButtons.Controls.Add(this.btnImport);
            this.pnlPaletteButtons.Controls.Add(this.btnTilemapOptions);
            this.pnlPaletteButtons.Controls.Add(this.btnTilemapRemove);
            this.pnlPaletteButtons.Controls.Add(this.btnTilemapDuplicate);
            this.pnlPaletteButtons.Controls.Add(this.btnTilemapNew);
            this.pnlPaletteButtons.Controls.Add(this.pnlPalettes);
            this.pnlPaletteButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaletteButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlPaletteButtons.Name = "pnlPaletteButtons";
            this.pnlPaletteButtons.Size = new System.Drawing.Size(172, 211);
            this.pnlPaletteButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 187);
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
            this.btnImport.Location = new System.Drawing.Point(0, 164);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Options";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnTilemapOptions
            // 
            this.btnTilemapOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapOptions.Location = new System.Drawing.Point(0, 141);
            this.btnTilemapOptions.Name = "btnTilemapOptions";
            this.btnTilemapOptions.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapOptions.TabIndex = 20;
            this.btnTilemapOptions.Text = "Tilemap Options";
            this.btnTilemapOptions.UseVisualStyleBackColor = true;
            this.btnTilemapOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnTilemapRemove
            // 
            this.btnTilemapRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapRemove.Location = new System.Drawing.Point(0, 118);
            this.btnTilemapRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapRemove.Name = "btnTilemapRemove";
            this.btnTilemapRemove.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapRemove.TabIndex = 23;
            this.btnTilemapRemove.Text = "Remove Tilemap";
            this.btnTilemapRemove.UseVisualStyleBackColor = true;
            this.btnTilemapRemove.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnTilemapDuplicate
            // 
            this.btnTilemapDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapDuplicate.Location = new System.Drawing.Point(0, 95);
            this.btnTilemapDuplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapDuplicate.Name = "btnTilemapDuplicate";
            this.btnTilemapDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapDuplicate.TabIndex = 22;
            this.btnTilemapDuplicate.Text = "Duplicate Tilemap";
            this.btnTilemapDuplicate.UseVisualStyleBackColor = true;
            this.btnTilemapDuplicate.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnTilemapNew
            // 
            this.btnTilemapNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTilemapNew.Location = new System.Drawing.Point(0, 72);
            this.btnTilemapNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnTilemapNew.Name = "btnTilemapNew";
            this.btnTilemapNew.Size = new System.Drawing.Size(172, 23);
            this.btnTilemapNew.TabIndex = 21;
            this.btnTilemapNew.Text = "New Tilemap";
            this.btnTilemapNew.UseVisualStyleBackColor = true;
            this.btnTilemapNew.Click += new System.EventHandler(this.btnTilemap_Click);
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
            this.pnlPalettes.Size = new System.Drawing.Size(172, 72);
            this.pnlPalettes.TabIndex = 11;
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.lblTileType.Location = new System.Drawing.Point(3, 5);
            this.lblTileType.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(83, 13);
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
            this.lblTilesetExportRange.Size = new System.Drawing.Size(134, 13);
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
            this.tabMain.Controls.Add(this.tabMetaTilemap);
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
            this.pnlTilemap.Controls.Add(this.lblSelection);
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(475, 525);
            this.pnlTilemap.TabIndex = 5;
            // 
            // pnlTilemapEdit
            // 
            this.pnlTilemapEdit.AreaGridSize = new System.Drawing.Size(32, 24);
            this.pnlTilemapEdit.AutoScroll = true;
            this.pnlTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(475, 426);
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
            this.pnlTilemapEdit.InvertGridColor = false;
            this.pnlTilemapEdit.Location = new System.Drawing.Point(0, 48);
            this.pnlTilemapEdit.MinimumScale = 1;
            this.pnlTilemapEdit.Name = "pnlTilemapEdit";
            this.pnlTilemapEdit.Offset = 0;
            this.pnlTilemapEdit.ShowIndexes = false;
            this.pnlTilemapEdit.Size = new System.Drawing.Size(475, 426);
            this.pnlTilemapEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemapEdit.TabIndex = 4;
            this.pnlTilemapEdit.TileGrid = null;
            this.pnlTilemapEdit.TileID = -1;
            this.pnlTilemapEdit.TypeValue = ((byte)(0));
            this.pnlTilemapEdit.UseAreaGrid = false;
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
            this.mnuSetSelectionTileId,
            this.mnuSetSelectionPriority,
            this.mnuUnsetSelectionPriority,
            this.mnuSetSelectionPalette,
            this.mnuUnsetSelectionPalette,
            this.mnuSetTileType,
            this.mnuMirrorX,
            this.mnuMirrorY,
            this.toolStripMenuItem1,
            this.mnuTilemapFromSelection,
            this.mnuSelectionToTilemap,
            this.mnuCropTilemap,
            this.toolStripMenuItem5,
            this.mnuExportSelectedIds,
            this.mnuExportSelectedIndexes});
            this.mnuSelectOptions.Name = "mnuSelectOptions";
            this.mnuSelectOptions.Size = new System.Drawing.Size(200, 374);
            // 
            // mnuCreateBrush
            // 
            this.mnuCreateBrush.Name = "mnuCreateBrush";
            this.mnuCreateBrush.Size = new System.Drawing.Size(199, 22);
            this.mnuCreateBrush.Text = "Brush From Selection";
            this.mnuCreateBrush.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuClearSelection
            // 
            this.mnuClearSelection.Name = "mnuClearSelection";
            this.mnuClearSelection.Size = new System.Drawing.Size(199, 22);
            this.mnuClearSelection.Text = "Clear Selection";
            this.mnuClearSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuClearBrush
            // 
            this.mnuClearBrush.Name = "mnuClearBrush";
            this.mnuClearBrush.Size = new System.Drawing.Size(199, 22);
            this.mnuClearBrush.Text = "Clear Brush";
            this.mnuClearBrush.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSeparator4
            // 
            this.mnuSeparator4.Name = "mnuSeparator4";
            this.mnuSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuSetSelectionTileId
            // 
            this.mnuSetSelectionTileId.Name = "mnuSetSelectionTileId";
            this.mnuSetSelectionTileId.Size = new System.Drawing.Size(199, 22);
            this.mnuSetSelectionTileId.Text = "Set Tile Id";
            this.mnuSetSelectionTileId.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSetSelectionPriority
            // 
            this.mnuSetSelectionPriority.Name = "mnuSetSelectionPriority";
            this.mnuSetSelectionPriority.Size = new System.Drawing.Size(199, 22);
            this.mnuSetSelectionPriority.Text = "Set Priority";
            this.mnuSetSelectionPriority.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUnsetSelectionPriority
            // 
            this.mnuUnsetSelectionPriority.Name = "mnuUnsetSelectionPriority";
            this.mnuUnsetSelectionPriority.Size = new System.Drawing.Size(199, 22);
            this.mnuUnsetSelectionPriority.Text = "Unset Priority";
            this.mnuUnsetSelectionPriority.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSetSelectionPalette
            // 
            this.mnuSetSelectionPalette.Name = "mnuSetSelectionPalette";
            this.mnuSetSelectionPalette.Size = new System.Drawing.Size(199, 22);
            this.mnuSetSelectionPalette.Text = "Set BG Palette";
            this.mnuSetSelectionPalette.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUnsetSelectionPalette
            // 
            this.mnuUnsetSelectionPalette.Name = "mnuUnsetSelectionPalette";
            this.mnuUnsetSelectionPalette.Size = new System.Drawing.Size(199, 22);
            this.mnuUnsetSelectionPalette.Text = "Set SPR Palette";
            this.mnuUnsetSelectionPalette.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSetTileType
            // 
            this.mnuSetTileType.Name = "mnuSetTileType";
            this.mnuSetTileType.Size = new System.Drawing.Size(199, 22);
            this.mnuSetTileType.Text = "Set Tile Type";
            this.mnuSetTileType.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMirrorX
            // 
            this.mnuMirrorX.Name = "mnuMirrorX";
            this.mnuMirrorX.Size = new System.Drawing.Size(199, 22);
            this.mnuMirrorX.Text = "Mirror Horizontal";
            this.mnuMirrorX.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMirrorY
            // 
            this.mnuMirrorY.Name = "mnuMirrorY";
            this.mnuMirrorY.Size = new System.Drawing.Size(199, 22);
            this.mnuMirrorY.Text = "Mirror Vertical";
            this.mnuMirrorY.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuTilemapFromSelection
            // 
            this.mnuTilemapFromSelection.Name = "mnuTilemapFromSelection";
            this.mnuTilemapFromSelection.Size = new System.Drawing.Size(199, 22);
            this.mnuTilemapFromSelection.Text = "Tilemap From Selection";
            this.mnuTilemapFromSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSelectionToTilemap
            // 
            this.mnuSelectionToTilemap.Name = "mnuSelectionToTilemap";
            this.mnuSelectionToTilemap.Size = new System.Drawing.Size(199, 22);
            this.mnuSelectionToTilemap.Text = "Selection To Tilemap";
            this.mnuSelectionToTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuCropTilemap
            // 
            this.mnuCropTilemap.Name = "mnuCropTilemap";
            this.mnuCropTilemap.Size = new System.Drawing.Size(199, 22);
            this.mnuCropTilemap.Text = "Crop Tilemap";
            this.mnuCropTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuExportSelectedIds
            // 
            this.mnuExportSelectedIds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportSelectionToImage,
            this.mnuExportSelectionToBinary,
            this.mnuExportAsSGBinary,
            this.toolStripMenuItem7,
            this.mnuExportSelectionDecimalToClipboard,
            this.mnuExportSelectionDecimalReversedToClipboard});
            this.mnuExportSelectedIds.Name = "mnuExportSelectedIds";
            this.mnuExportSelectedIds.Size = new System.Drawing.Size(199, 22);
            this.mnuExportSelectedIds.Text = "Export Selected Ids";
            // 
            // mnuExportSelectionToImage
            // 
            this.mnuExportSelectionToImage.Name = "mnuExportSelectionToImage";
            this.mnuExportSelectionToImage.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectionToImage.Text = "Export As Image";
            this.mnuExportSelectionToImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportSelectionToBinary
            // 
            this.mnuExportSelectionToBinary.Name = "mnuExportSelectionToBinary";
            this.mnuExportSelectionToBinary.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectionToBinary.Text = "Export As Binary";
            this.mnuExportSelectionToBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportAsSGBinary
            // 
            this.mnuExportAsSGBinary.Name = "mnuExportAsSGBinary";
            this.mnuExportAsSGBinary.Size = new System.Drawing.Size(282, 22);
            this.mnuExportAsSGBinary.Text = "Export As SG Binary";
            this.mnuExportAsSGBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(279, 6);
            // 
            // mnuExportSelectionDecimalToClipboard
            // 
            this.mnuExportSelectionDecimalToClipboard.Name = "mnuExportSelectionDecimalToClipboard";
            this.mnuExportSelectionDecimalToClipboard.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectionDecimalToClipboard.Text = "Export As Decimal (Clipboard)";
            this.mnuExportSelectionDecimalToClipboard.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportSelectionDecimalReversedToClipboard
            // 
            this.mnuExportSelectionDecimalReversedToClipboard.Name = "mnuExportSelectionDecimalReversedToClipboard";
            this.mnuExportSelectionDecimalReversedToClipboard.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectionDecimalReversedToClipboard.Text = "Export As Decimal Reversed (Clipboard)";
            this.mnuExportSelectionDecimalReversedToClipboard.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportSelectedIndexes
            // 
            this.mnuExportSelectedIndexes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportAreaToBinary,
            this.toolStripMenuItem6,
            this.mnuExportSelectedIndexesToDecimal,
            this.mnuExportSelectedIndexesToDecimalReversed});
            this.mnuExportSelectedIndexes.Name = "mnuExportSelectedIndexes";
            this.mnuExportSelectedIndexes.Size = new System.Drawing.Size(199, 22);
            this.mnuExportSelectedIndexes.Text = "Export Selected Indexes";
            // 
            // mnuExportAreaToBinary
            // 
            this.mnuExportAreaToBinary.Name = "mnuExportAreaToBinary";
            this.mnuExportAreaToBinary.Size = new System.Drawing.Size(282, 22);
            this.mnuExportAreaToBinary.Text = "Export As Binary";
            this.mnuExportAreaToBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(279, 6);
            // 
            // mnuExportSelectedIndexesToDecimal
            // 
            this.mnuExportSelectedIndexesToDecimal.Name = "mnuExportSelectedIndexesToDecimal";
            this.mnuExportSelectedIndexesToDecimal.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectedIndexesToDecimal.Text = "Export As Decimal (Clipboard)";
            this.mnuExportSelectedIndexesToDecimal.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportSelectedIndexesToDecimalReversed
            // 
            this.mnuExportSelectedIndexesToDecimalReversed.Name = "mnuExportSelectedIndexesToDecimalReversed";
            this.mnuExportSelectedIndexesToDecimalReversed.Size = new System.Drawing.Size(282, 22);
            this.mnuExportSelectedIndexesToDecimalReversed.Text = "Export As Decimal Reversed (Clipboard)";
            this.mnuExportSelectedIndexesToDecimalReversed.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblPosition);
            this.panel7.Controls.Add(this.lblTile);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 474);
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
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapBrush);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapSelect);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapFlipX);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapFlipY);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapPriority);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapPalette);
            this.pnlTilemapToolbar.Controls.Add(this.rbTilemapTileType);
            this.pnlTilemapToolbar.Controls.Add(this.chkTilemapGrid);
            this.pnlTilemapToolbar.Controls.Add(this.chkTilemapAreaGrid);
            this.pnlTilemapToolbar.Controls.Add(this.chkTilemapInvertGrids);
            this.pnlTilemapToolbar.Controls.Add(this.chkTilemapShowTileAs);
            this.pnlTilemapToolbar.Controls.Add(this.panel8);
            this.pnlTilemapToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTilemapToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemapToolbar.Name = "pnlTilemapToolbar";
            this.pnlTilemapToolbar.Size = new System.Drawing.Size(475, 48);
            this.pnlTilemapToolbar.TabIndex = 30;
            // 
            // rbTilemapBrush
            // 
            this.rbTilemapBrush.AutoSize = true;
            this.rbTilemapBrush.Checked = true;
            this.rbTilemapBrush.Location = new System.Drawing.Point(3, 3);
            this.rbTilemapBrush.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapBrush.Name = "rbTilemapBrush";
            this.rbTilemapBrush.Size = new System.Drawing.Size(55, 17);
            this.rbTilemapBrush.TabIndex = 0;
            this.rbTilemapBrush.TabStop = true;
            this.rbTilemapBrush.Text = "Brush";
            this.tipMain.SetToolTip(this.rbTilemapBrush, "Brush (B)");
            this.rbTilemapBrush.UseVisualStyleBackColor = true;
            this.rbTilemapBrush.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapSelect
            // 
            this.rbTilemapSelect.AutoSize = true;
            this.rbTilemapSelect.Location = new System.Drawing.Point(61, 3);
            this.rbTilemapSelect.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapSelect.Name = "rbTilemapSelect";
            this.rbTilemapSelect.Size = new System.Drawing.Size(55, 17);
            this.rbTilemapSelect.TabIndex = 1;
            this.rbTilemapSelect.Text = "Select";
            this.tipMain.SetToolTip(this.rbTilemapSelect, "Select (S)");
            this.rbTilemapSelect.UseVisualStyleBackColor = true;
            this.rbTilemapSelect.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapFlipX
            // 
            this.rbTilemapFlipX.AutoSize = true;
            this.rbTilemapFlipX.Location = new System.Drawing.Point(119, 3);
            this.rbTilemapFlipX.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapFlipX.Name = "rbTilemapFlipX";
            this.rbTilemapFlipX.Size = new System.Drawing.Size(55, 17);
            this.rbTilemapFlipX.TabIndex = 2;
            this.rbTilemapFlipX.Text = "H Flip";
            this.tipMain.SetToolTip(this.rbTilemapFlipX, "Horizontal Flip (H)");
            this.rbTilemapFlipX.UseVisualStyleBackColor = true;
            this.rbTilemapFlipX.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapFlipY
            // 
            this.rbTilemapFlipY.AutoSize = true;
            this.rbTilemapFlipY.Location = new System.Drawing.Point(177, 3);
            this.rbTilemapFlipY.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapFlipY.Name = "rbTilemapFlipY";
            this.rbTilemapFlipY.Size = new System.Drawing.Size(54, 17);
            this.rbTilemapFlipY.TabIndex = 3;
            this.rbTilemapFlipY.Text = "V Flip";
            this.tipMain.SetToolTip(this.rbTilemapFlipY, "Vertical Flip (V)");
            this.rbTilemapFlipY.UseVisualStyleBackColor = true;
            this.rbTilemapFlipY.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapPriority
            // 
            this.rbTilemapPriority.AutoSize = true;
            this.rbTilemapPriority.Location = new System.Drawing.Point(234, 3);
            this.rbTilemapPriority.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapPriority.Name = "rbTilemapPriority";
            this.rbTilemapPriority.Size = new System.Drawing.Size(61, 17);
            this.rbTilemapPriority.TabIndex = 4;
            this.rbTilemapPriority.Text = "Priority";
            this.tipMain.SetToolTip(this.rbTilemapPriority, "Priority (P)");
            this.rbTilemapPriority.UseVisualStyleBackColor = true;
            this.rbTilemapPriority.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapPalette
            // 
            this.rbTilemapPalette.AutoSize = true;
            this.rbTilemapPalette.Location = new System.Drawing.Point(298, 3);
            this.rbTilemapPalette.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapPalette.Name = "rbTilemapPalette";
            this.rbTilemapPalette.Size = new System.Drawing.Size(60, 17);
            this.rbTilemapPalette.TabIndex = 5;
            this.rbTilemapPalette.Text = "Palette";
            this.tipMain.SetToolTip(this.rbTilemapPalette, "Palette (L)");
            this.rbTilemapPalette.UseVisualStyleBackColor = true;
            this.rbTilemapPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapTileType
            // 
            this.rbTilemapTileType.AutoSize = true;
            this.rbTilemapTileType.Location = new System.Drawing.Point(361, 3);
            this.rbTilemapTileType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapTileType.Name = "rbTilemapTileType";
            this.rbTilemapTileType.Size = new System.Drawing.Size(47, 17);
            this.rbTilemapTileType.TabIndex = 31;
            this.rbTilemapTileType.Text = "Type";
            this.tipMain.SetToolTip(this.rbTilemapTileType, "Type Bits (T)");
            this.rbTilemapTileType.UseVisualStyleBackColor = true;
            this.rbTilemapTileType.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
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
            // chkTilemapAreaGrid
            // 
            this.chkTilemapAreaGrid.AutoSize = true;
            this.chkTilemapAreaGrid.Location = new System.Drawing.Point(3, 27);
            this.chkTilemapAreaGrid.Name = "chkTilemapAreaGrid";
            this.chkTilemapAreaGrid.Size = new System.Drawing.Size(74, 17);
            this.chkTilemapAreaGrid.TabIndex = 32;
            this.chkTilemapAreaGrid.Text = "Area Grid";
            this.tipMain.SetToolTip(this.chkTilemapAreaGrid, "Toggle Area Grid (A)");
            this.chkTilemapAreaGrid.UseVisualStyleBackColor = true;
            this.chkTilemapAreaGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkTilemapInvertGrids
            // 
            this.chkTilemapInvertGrids.AutoSize = true;
            this.chkTilemapInvertGrids.Location = new System.Drawing.Point(83, 27);
            this.chkTilemapInvertGrids.Name = "chkTilemapInvertGrids";
            this.chkTilemapInvertGrids.Size = new System.Drawing.Size(85, 17);
            this.chkTilemapInvertGrids.TabIndex = 33;
            this.chkTilemapInvertGrids.Text = "Invert Grids";
            this.tipMain.SetToolTip(this.chkTilemapInvertGrids, "Toggle Grid Color (C)");
            this.chkTilemapInvertGrids.UseVisualStyleBackColor = true;
            this.chkTilemapInvertGrids.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkTilemapShowTileAs
            // 
            this.chkTilemapShowTileAs.AutoSize = true;
            this.chkTilemapShowTileAs.Location = new System.Drawing.Point(174, 28);
            this.chkTilemapShowTileAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkTilemapShowTileAs.Name = "chkTilemapShowTileAs";
            this.chkTilemapShowTileAs.Size = new System.Drawing.Size(78, 17);
            this.chkTilemapShowTileAs.TabIndex = 13;
            this.chkTilemapShowTileAs.Text = "Show Tile:";
            this.tipMain.SetToolTip(this.chkTilemapShowTileAs, "Show Tile (I)");
            this.chkTilemapShowTileAs.UseVisualStyleBackColor = true;
            this.chkTilemapShowTileAs.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rbTilemapShowIndexes);
            this.panel8.Controls.Add(this.rbTilemapShowIds);
            this.panel8.Location = new System.Drawing.Point(255, 24);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(104, 24);
            this.panel8.TabIndex = 34;
            // 
            // rbTilemapShowIndexes
            // 
            this.rbTilemapShowIndexes.AutoSize = true;
            this.rbTilemapShowIndexes.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbTilemapShowIndexes.Location = new System.Drawing.Point(40, 0);
            this.rbTilemapShowIndexes.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapShowIndexes.Name = "rbTilemapShowIndexes";
            this.rbTilemapShowIndexes.Size = new System.Drawing.Size(64, 24);
            this.rbTilemapShowIndexes.TabIndex = 36;
            this.rbTilemapShowIndexes.Text = "Indexes";
            this.rbTilemapShowIndexes.UseVisualStyleBackColor = true;
            this.rbTilemapShowIndexes.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbTilemapShowIds
            // 
            this.rbTilemapShowIds.AutoSize = true;
            this.rbTilemapShowIds.Checked = true;
            this.rbTilemapShowIds.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbTilemapShowIds.Location = new System.Drawing.Point(0, 0);
            this.rbTilemapShowIds.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbTilemapShowIds.Name = "rbTilemapShowIds";
            this.rbTilemapShowIds.Size = new System.Drawing.Size(40, 24);
            this.rbTilemapShowIds.TabIndex = 37;
            this.rbTilemapShowIds.TabStop = true;
            this.rbTilemapShowIds.Text = "Ids";
            this.rbTilemapShowIds.UseVisualStyleBackColor = true;
            this.rbTilemapShowIds.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSelection.Location = new System.Drawing.Point(0, 508);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(475, 17);
            this.lblSelection.TabIndex = 32;
            this.lblSelection.Text = "Selection: N/A";
            this.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.tabTilemapTiles);
            this.tabProperties.Controls.Add(this.tabTileGrids);
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
            this.tabTileOptions.Location = new System.Drawing.Point(8, 214);
            this.tabTileOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tabTileOptions.Name = "tabTileOptions";
            this.tabTileOptions.SelectedIndex = 0;
            this.tabTileOptions.Size = new System.Drawing.Size(170, 273);
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
            this.tabTilePalette.Size = new System.Drawing.Size(162, 247);
            this.tabTilePalette.TabIndex = 0;
            this.tabTilePalette.Text = "Tile Palette";
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(435, 570);
            this.pnlTiles.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTiles.Centered = false;
            this.pnlTiles.ClearTileId = true;
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
            this.pnlTiles.Size = new System.Drawing.Size(162, 207);
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
            this.tabTileList.Size = new System.Drawing.Size(162, 247);
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
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Merge Tiles:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pnlPaletteOptions
            // 
            this.pnlPaletteOptions.Controls.Add(this.label2);
            this.pnlPaletteOptions.Controls.Add(this.label4);
            this.pnlPaletteOptions.Controls.Add(this.lblRows);
            this.pnlPaletteOptions.Controls.Add(this.label3);
            this.pnlPaletteOptions.Controls.Add(this.lblColumns);
            this.pnlPaletteOptions.Controls.Add(this.nudAreaGridRows);
            this.pnlPaletteOptions.Controls.Add(this.nudAreaGridCols);
            this.pnlPaletteOptions.Controls.Add(this.nudRows);
            this.pnlPaletteOptions.Controls.Add(this.nudColumns);
            this.pnlPaletteOptions.Controls.Add(this.btnSelectionOptions);
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
            this.pnlPaletteOptions.Size = new System.Drawing.Size(170, 214);
            this.pnlPaletteOptions.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Area Grid:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cols:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(120, 108);
            this.lblRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(38, 13);
            this.lblRows.TabIndex = 26;
            this.lblRows.Text = "Rows:";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rows:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(57, 108);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(55, 13);
            this.lblColumns.TabIndex = 25;
            this.lblColumns.Text = "Columns:";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAreaGridRows
            // 
            this.nudAreaGridRows.Location = new System.Drawing.Point(126, 187);
            this.nudAreaGridRows.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAreaGridRows.Name = "nudAreaGridRows";
            this.nudAreaGridRows.Size = new System.Drawing.Size(40, 22);
            this.nudAreaGridRows.TabIndex = 34;
            this.nudAreaGridRows.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudAreaGridRows.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudAreaGridCols
            // 
            this.nudAreaGridCols.Location = new System.Drawing.Point(36, 187);
            this.nudAreaGridCols.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAreaGridCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAreaGridCols.Name = "nudAreaGridCols";
            this.nudAreaGridCols.Size = new System.Drawing.Size(40, 22);
            this.nudAreaGridCols.TabIndex = 33;
            this.nudAreaGridCols.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudAreaGridCols.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(120, 124);
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
            this.nudColumns.Location = new System.Drawing.Point(60, 124);
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
            this.btnSelectionOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectionOptions.Location = new System.Drawing.Point(0, 0);
            this.btnSelectionOptions.Name = "btnSelectionOptions";
            this.btnSelectionOptions.Size = new System.Drawing.Size(170, 23);
            this.btnSelectionOptions.TabIndex = 22;
            this.btnSelectionOptions.Text = "Selection Options";
            this.btnSelectionOptions.UseVisualStyleBackColor = true;
            this.btnSelectionOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTilemapCompression
            // 
            this.lblTilemapCompression.AutoSize = true;
            this.lblTilemapCompression.Location = new System.Drawing.Point(0, 67);
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
            this.cbTilemapCompression.Location = new System.Drawing.Point(0, 84);
            this.cbTilemapCompression.Name = "cbTilemapCompression";
            this.cbTilemapCompression.Size = new System.Drawing.Size(168, 21);
            this.cbTilemapCompression.TabIndex = 8;
            this.cbTilemapCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // chkUseAttributes
            // 
            this.chkUseAttributes.AutoSize = true;
            this.chkUseAttributes.Location = new System.Drawing.Point(0, 150);
            this.chkUseAttributes.Margin = new System.Windows.Forms.Padding(0);
            this.chkUseAttributes.Name = "chkUseAttributes";
            this.chkUseAttributes.Size = new System.Drawing.Size(119, 17);
            this.chkUseAttributes.TabIndex = 14;
            this.chkUseAttributes.Text = "Use Tile Attributes";
            this.chkUseAttributes.UseVisualStyleBackColor = true;
            this.chkUseAttributes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(0, 124);
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
            this.lblOffset.Location = new System.Drawing.Point(0, 108);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(0);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(42, 13);
            this.lblOffset.TabIndex = 7;
            this.lblOffset.Text = "Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 42);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tilemap Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTileGrids
            // 
            this.tabTileGrids.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileGrids.Controls.Add(this.panel6);
            this.tabTileGrids.Location = new System.Drawing.Point(4, 22);
            this.tabTileGrids.Name = "tabTileGrids";
            this.tabTileGrids.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileGrids.Size = new System.Drawing.Size(184, 493);
            this.tabTileGrids.TabIndex = 3;
            this.tabTileGrids.Text = "Tile Grids";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lstTileGrids);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(178, 487);
            this.panel6.TabIndex = 23;
            // 
            // lstTileGrids
            // 
            this.lstTileGrids.DisableHighlighting = false;
            this.lstTileGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTileGrids.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTileGrids.FormattingEnabled = true;
            this.lstTileGrids.HorizontalExtent = 166;
            this.lstTileGrids.IntegralHeight = false;
            this.lstTileGrids.Location = new System.Drawing.Point(8, 200);
            this.lstTileGrids.Name = "lstTileGrids";
            this.lstTileGrids.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTileGrids.Size = new System.Drawing.Size(170, 287);
            this.lstTileGrids.TabIndex = 32;
            this.lstTileGrids.TextOffsetX = 2;
            this.lstTileGrids.TextOffsetY = 0;
            this.lstTileGrids.SelectedIndexChanged += new System.EventHandler(this.lstTileGrids_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTileGridTileSize);
            this.panel5.Controls.Add(this.cbTileGridTileSize);
            this.panel5.Controls.Add(this.lblTileGridRows);
            this.panel5.Controls.Add(this.lblTileGridColumns);
            this.panel5.Controls.Add(this.nudTileGridRows);
            this.panel5.Controls.Add(this.nudTileGridColumns);
            this.panel5.Controls.Add(this.nudTileGridValue);
            this.panel5.Controls.Add(this.lblTileGridValue);
            this.panel5.Controls.Add(this.btnTileGridOptions);
            this.panel5.Controls.Add(this.txtTileGridName);
            this.panel5.Controls.Add(this.lblTileGridName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 200);
            this.panel5.TabIndex = 0;
            // 
            // lblTileGridTileSize
            // 
            this.lblTileGridTileSize.AutoSize = true;
            this.lblTileGridTileSize.Location = new System.Drawing.Point(1, 68);
            this.lblTileGridTileSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileGridTileSize.Name = "lblTileGridTileSize";
            this.lblTileGridTileSize.Size = new System.Drawing.Size(50, 13);
            this.lblTileGridTileSize.TabIndex = 42;
            this.lblTileGridTileSize.Text = "Tile Size:";
            this.lblTileGridTileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTileGridTileSize
            // 
            this.cbTileGridTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTileGridTileSize.FormattingEnabled = true;
            this.cbTileGridTileSize.Location = new System.Drawing.Point(0, 86);
            this.cbTileGridTileSize.Name = "cbTileGridTileSize";
            this.cbTileGridTileSize.Size = new System.Drawing.Size(168, 21);
            this.cbTileGridTileSize.TabIndex = 43;
            this.cbTileGridTileSize.SelectedIndexChanged += new System.EventHandler(this.cbTileGridTileSize_SelectedIndexChanged);
            // 
            // lblTileGridRows
            // 
            this.lblTileGridRows.AutoSize = true;
            this.lblTileGridRows.Location = new System.Drawing.Point(88, 110);
            this.lblTileGridRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileGridRows.Name = "lblTileGridRows";
            this.lblTileGridRows.Size = new System.Drawing.Size(38, 13);
            this.lblTileGridRows.TabIndex = 41;
            this.lblTileGridRows.Text = "Rows:";
            this.lblTileGridRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTileGridColumns
            // 
            this.lblTileGridColumns.AutoSize = true;
            this.lblTileGridColumns.Location = new System.Drawing.Point(0, 110);
            this.lblTileGridColumns.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileGridColumns.Name = "lblTileGridColumns";
            this.lblTileGridColumns.Size = new System.Drawing.Size(55, 13);
            this.lblTileGridColumns.TabIndex = 40;
            this.lblTileGridColumns.Text = "Columns:";
            this.lblTileGridColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTileGridRows
            // 
            this.nudTileGridRows.Location = new System.Drawing.Point(88, 128);
            this.nudTileGridRows.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudTileGridRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileGridRows.Name = "nudTileGridRows";
            this.nudTileGridRows.Size = new System.Drawing.Size(80, 22);
            this.nudTileGridRows.TabIndex = 39;
            this.nudTileGridRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTileGridColumns
            // 
            this.nudTileGridColumns.Location = new System.Drawing.Point(0, 128);
            this.nudTileGridColumns.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudTileGridColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTileGridColumns.Name = "nudTileGridColumns";
            this.nudTileGridColumns.Size = new System.Drawing.Size(80, 22);
            this.nudTileGridColumns.TabIndex = 38;
            this.nudTileGridColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTileGridValue
            // 
            this.nudTileGridValue.Location = new System.Drawing.Point(1, 171);
            this.nudTileGridValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTileGridValue.Name = "nudTileGridValue";
            this.nudTileGridValue.Size = new System.Drawing.Size(167, 22);
            this.nudTileGridValue.TabIndex = 37;
            this.nudTileGridValue.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblTileGridValue
            // 
            this.lblTileGridValue.AutoSize = true;
            this.lblTileGridValue.Location = new System.Drawing.Point(1, 153);
            this.lblTileGridValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileGridValue.Name = "lblTileGridValue";
            this.lblTileGridValue.Size = new System.Drawing.Size(38, 13);
            this.lblTileGridValue.TabIndex = 36;
            this.lblTileGridValue.Text = "Value:";
            this.lblTileGridValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTileGridOptions
            // 
            this.btnTileGridOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTileGridOptions.Location = new System.Drawing.Point(0, 0);
            this.btnTileGridOptions.Name = "btnTileGridOptions";
            this.btnTileGridOptions.Size = new System.Drawing.Size(170, 23);
            this.btnTileGridOptions.TabIndex = 35;
            this.btnTileGridOptions.Text = "Tile Grid Options";
            this.btnTileGridOptions.UseVisualStyleBackColor = true;
            this.btnTileGridOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // txtTileGridName
            // 
            this.txtTileGridName.Location = new System.Drawing.Point(1, 43);
            this.txtTileGridName.MaxLength = 50;
            this.txtTileGridName.Name = "txtTileGridName";
            this.txtTileGridName.Size = new System.Drawing.Size(168, 22);
            this.txtTileGridName.TabIndex = 34;
            // 
            // lblTileGridName
            // 
            this.lblTileGridName.AutoSize = true;
            this.lblTileGridName.Location = new System.Drawing.Point(0, 25);
            this.lblTileGridName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTileGridName.Name = "lblTileGridName";
            this.lblTileGridName.Size = new System.Drawing.Size(84, 13);
            this.lblTileGridName.TabIndex = 33;
            this.lblTileGridName.Text = "Tile Grid Name:";
            this.lblTileGridName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lstEntities.Location = new System.Drawing.Point(8, 140);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(170, 347);
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
            this.panel3.Size = new System.Drawing.Size(170, 140);
            this.panel3.TabIndex = 3;
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(0, 41);
            this.txtEntityName.MaxLength = 50;
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(168, 22);
            this.txtEntityName.TabIndex = 42;
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
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
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
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tpnlTileset.Controls.Add(this.pnlTileset, 0, 0);
            this.tpnlTileset.Controls.Add(this.tabControl1, 1, 0);
            this.tpnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileset.Location = new System.Drawing.Point(3, 3);
            this.tpnlTileset.Name = "tpnlTileset";
            this.tpnlTileset.RowCount = 1;
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTileset.Size = new System.Drawing.Size(673, 525);
            this.tpnlTileset.TabIndex = 0;
            // 
            // pnlTileset
            // 
            this.pnlTileset.Controls.Add(this.pnlTilesetEdit);
            this.pnlTileset.Controls.Add(this.flowLayoutPanel1);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(0, 0);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(476, 525);
            this.pnlTileset.TabIndex = 4;
            // 
            // pnlTilesetEdit
            // 
            this.pnlTilesetEdit.AutoScroll = true;
            this.pnlTilesetEdit.AutoScrollMinSize = new System.Drawing.Size(476, 501);
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
            this.pnlTilesetEdit.Size = new System.Drawing.Size(476, 501);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 24);
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
            this.rbTilesetType.Size = new System.Drawing.Size(47, 17);
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
            this.chkTilesetGrid.Location = new System.Drawing.Point(173, 4);
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
            this.chkTilesetShowTileIds.Location = new System.Drawing.Point(227, 4);
            this.chkTilesetShowTileIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkTilesetShowTileIds.Name = "chkTilesetShowTileIds";
            this.chkTilesetShowTileIds.Size = new System.Drawing.Size(93, 17);
            this.chkTilesetShowTileIds.TabIndex = 11;
            this.chkTilesetShowTileIds.Text = "Show Tile Ids";
            this.tipMain.SetToolTip(this.chkTilesetShowTileIds, "Show Tile Ids (I)");
            this.chkTilesetShowTileIds.UseVisualStyleBackColor = true;
            this.chkTilesetShowTileIds.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTilesetOptions);
            this.tabControl1.Controls.Add(this.tabTags);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(479, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(191, 519);
            this.tabControl1.TabIndex = 5;
            // 
            // tabTilesetOptions
            // 
            this.tabTilesetOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilesetOptions.Controls.Add(this.pnlTilesetOptions);
            this.tabTilesetOptions.Location = new System.Drawing.Point(4, 22);
            this.tabTilesetOptions.Name = "tabTilesetOptions";
            this.tabTilesetOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesetOptions.Size = new System.Drawing.Size(183, 493);
            this.tabTilesetOptions.TabIndex = 0;
            this.tabTilesetOptions.Text = "Tiles";
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
            this.pnlTilesetOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlTilesetOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilesetOptions.Name = "pnlTilesetOptions";
            this.pnlTilesetOptions.Size = new System.Drawing.Size(177, 487);
            this.pnlTilesetOptions.TabIndex = 4;
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
            this.rbBgPalette.Size = new System.Drawing.Size(78, 17);
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
            this.lblSelectedTile.Size = new System.Drawing.Size(73, 13);
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
            this.lblBgPalette.Size = new System.Drawing.Size(111, 13);
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
            // tabTags
            // 
            this.tabTags.BackColor = System.Drawing.SystemColors.Control;
            this.tabTags.Controls.Add(this.panel9);
            this.tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(183, 493);
            this.tabTags.TabIndex = 1;
            this.tabTags.Text = "Tags";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lstTags);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel9.Size = new System.Drawing.Size(177, 487);
            this.panel9.TabIndex = 1;
            // 
            // lstTags
            // 
            this.lstTags.DisableHighlighting = false;
            this.lstTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTags.FormattingEnabled = true;
            this.lstTags.HorizontalExtent = 165;
            this.lstTags.IntegralHeight = false;
            this.lstTags.Location = new System.Drawing.Point(8, 178);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(169, 309);
            this.lstTags.TabIndex = 5;
            this.lstTags.TextOffsetX = 2;
            this.lstTags.TextOffsetY = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnBulkAddTag);
            this.panel10.Controls.Add(this.btnAddExistingTag);
            this.panel10.Controls.Add(this.cbExistingTags);
            this.panel10.Controls.Add(this.lblExistingTag);
            this.panel10.Controls.Add(this.btnRemoveTag);
            this.panel10.Controls.Add(this.lblTagName);
            this.panel10.Controls.Add(this.txtTagName);
            this.panel10.Controls.Add(this.btnAddTag);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(8, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(169, 178);
            this.panel10.TabIndex = 0;
            // 
            // btnBulkAddTag
            // 
            this.btnBulkAddTag.Location = new System.Drawing.Point(0, 87);
            this.btnBulkAddTag.Name = "btnBulkAddTag";
            this.btnBulkAddTag.Size = new System.Drawing.Size(168, 23);
            this.btnBulkAddTag.TabIndex = 25;
            this.btnBulkAddTag.Text = "Bulk Add New Tag";
            this.btnBulkAddTag.UseVisualStyleBackColor = true;
            this.btnBulkAddTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnAddExistingTag
            // 
            this.btnAddExistingTag.Location = new System.Drawing.Point(0, 152);
            this.btnAddExistingTag.Name = "btnAddExistingTag";
            this.btnAddExistingTag.Size = new System.Drawing.Size(168, 23);
            this.btnAddExistingTag.TabIndex = 24;
            this.btnAddExistingTag.Text = "Add Existing Tag";
            this.btnAddExistingTag.UseVisualStyleBackColor = true;
            this.btnAddExistingTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // cbExistingTags
            // 
            this.cbExistingTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExistingTags.FormattingEnabled = true;
            this.cbExistingTags.Location = new System.Drawing.Point(0, 128);
            this.cbExistingTags.Name = "cbExistingTags";
            this.cbExistingTags.Size = new System.Drawing.Size(168, 21);
            this.cbExistingTags.TabIndex = 23;
            // 
            // lblExistingTag
            // 
            this.lblExistingTag.AutoSize = true;
            this.lblExistingTag.Location = new System.Drawing.Point(0, 112);
            this.lblExistingTag.Name = "lblExistingTag";
            this.lblExistingTag.Size = new System.Drawing.Size(70, 13);
            this.lblExistingTag.TabIndex = 22;
            this.lblExistingTag.Text = "Existing Tag:";
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveTag.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(169, 23);
            this.btnRemoveTag.TabIndex = 21;
            this.btnRemoveTag.Text = "Remove Tag";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Location = new System.Drawing.Point(0, 24);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(85, 13);
            this.lblTagName.TabIndex = 5;
            this.lblTagName.Text = "New Tag Name:";
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(0, 40);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(168, 22);
            this.txtTagName.TabIndex = 4;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(0, 64);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(168, 23);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add New Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // tabMetaTilemap
            // 
            this.tabMetaTilemap.Controls.Add(this.tableLayoutPanel1);
            this.tabMetaTilemap.Location = new System.Drawing.Point(4, 22);
            this.tabMetaTilemap.Name = "tabMetaTilemap";
            this.tabMetaTilemap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetaTilemap.Size = new System.Drawing.Size(679, 531);
            this.tabMetaTilemap.TabIndex = 2;
            this.tabMetaTilemap.Text = "Meta Tilemap";
            this.tabMetaTilemap.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 525);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pnlMetaTilemapEdit);
            this.panel11.Controls.Add(this.pnlMetaTilemapInfo);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(475, 525);
            this.panel11.TabIndex = 5;
            // 
            // pnlMetaTilemapEdit
            // 
            this.pnlMetaTilemapEdit.AutoScroll = true;
            this.pnlMetaTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(1374, 1413);
            this.pnlMetaTilemapEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaTilemapEdit.Centered = true;
            this.pnlMetaTilemapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTilemapEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaTilemapEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaTilemapEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaTilemapEdit.Image = null;
            this.pnlMetaTilemapEdit.ImageAlpha = 1F;
            this.pnlMetaTilemapEdit.ImageScale = 3;
            this.pnlMetaTilemapEdit.InvertGridColor = false;
            this.pnlMetaTilemapEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlMetaTilemapEdit.MetaTilemapIds = null;
            this.pnlMetaTilemapEdit.MetaTilemapProperties = "N/A";
            this.pnlMetaTilemapEdit.MetaTilemapSize = new System.Drawing.Size(0, 0);
            this.pnlMetaTilemapEdit.MetaTileSize = new System.Drawing.Size(0, 0);
            this.pnlMetaTilemapEdit.MinimumScale = 3;
            this.pnlMetaTilemapEdit.Name = "pnlMetaTilemapEdit";
            this.pnlMetaTilemapEdit.Size = new System.Drawing.Size(475, 488);
            this.pnlMetaTilemapEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaTilemapEdit.TabIndex = 33;
            this.pnlMetaTilemapEdit.TilemapImage = null;
            this.pnlMetaTilemapEdit.UseCanvas = false;
            this.pnlMetaTilemapEdit.UseHatch = true;
            this.pnlMetaTilemapEdit.UseMouseWheelScaling = true;
            // 
            // pnlMetaTilemapInfo
            // 
            this.pnlMetaTilemapInfo.Controls.Add(this.lblMetaTileProperties);
            this.pnlMetaTilemapInfo.Controls.Add(this.lblMetaTilemapProperties);
            this.pnlMetaTilemapInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMetaTilemapInfo.Location = new System.Drawing.Point(0, 488);
            this.pnlMetaTilemapInfo.Name = "pnlMetaTilemapInfo";
            this.pnlMetaTilemapInfo.Size = new System.Drawing.Size(475, 37);
            this.pnlMetaTilemapInfo.TabIndex = 31;
            // 
            // lblMetaTileProperties
            // 
            this.lblMetaTileProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMetaTileProperties.Location = new System.Drawing.Point(0, 3);
            this.lblMetaTileProperties.Name = "lblMetaTileProperties";
            this.lblMetaTileProperties.Size = new System.Drawing.Size(475, 17);
            this.lblMetaTileProperties.TabIndex = 6;
            this.lblMetaTileProperties.Text = "Meta Tile Properties: N/A";
            this.lblMetaTileProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMetaTilemapProperties
            // 
            this.lblMetaTilemapProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMetaTilemapProperties.Location = new System.Drawing.Point(0, 20);
            this.lblMetaTilemapProperties.Name = "lblMetaTilemapProperties";
            this.lblMetaTilemapProperties.Size = new System.Drawing.Size(475, 17);
            this.lblMetaTilemapProperties.TabIndex = 4;
            this.lblMetaTilemapProperties.Text = "Meta Tilemap Properties: N/A";
            this.lblMetaTilemapProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(478, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(192, 519);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.pnlMetaTileOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(184, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meta Tiles";
            // 
            // pnlMetaTileOptions
            // 
            this.pnlMetaTileOptions.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMetaTileOptions.Controls.Add(this.pnlMetaTilesEdit);
            this.pnlMetaTileOptions.Controls.Add(this.pnlMetaTileTools);
            this.pnlMetaTileOptions.Controls.Add(this.pnlMetaTilePaletteOptions);
            this.pnlMetaTileOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTileOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlMetaTileOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMetaTileOptions.Name = "pnlMetaTileOptions";
            this.pnlMetaTileOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlMetaTileOptions.Size = new System.Drawing.Size(178, 487);
            this.pnlMetaTileOptions.TabIndex = 4;
            // 
            // pnlMetaTilesEdit
            // 
            this.pnlMetaTilesEdit.ApplyEditsToAllMetaTiles = true;
            this.pnlMetaTilesEdit.AutoScroll = true;
            this.pnlMetaTilesEdit.AutoScrollMinSize = new System.Drawing.Size(459, 1020);
            this.pnlMetaTilesEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaTilesEdit.Centered = true;
            this.pnlMetaTilesEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTilesEdit.EditMode = SMSTileStudio.Data.TileEditType.TileID;
            this.pnlMetaTilesEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaTilesEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaTilesEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaTilesEdit.Image = null;
            this.pnlMetaTilesEdit.ImageAlpha = 1F;
            this.pnlMetaTilesEdit.ImageScale = 3;
            this.pnlMetaTilesEdit.InvertGridColor = false;
            this.pnlMetaTilesEdit.Location = new System.Drawing.Point(8, 130);
            this.pnlMetaTilesEdit.MetaTileProperties = "N/A";
            this.pnlMetaTilesEdit.MetaTiles = null;
            this.pnlMetaTilesEdit.MinimumScale = 1;
            this.pnlMetaTilesEdit.Name = "pnlMetaTilesEdit";
            this.pnlMetaTilesEdit.Size = new System.Drawing.Size(170, 357);
            this.pnlMetaTilesEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaTilesEdit.TabIndex = 22;
            this.pnlMetaTilesEdit.TypeValue = ((byte)(0));
            this.pnlMetaTilesEdit.UseCanvas = false;
            this.pnlMetaTilesEdit.UseHatch = true;
            this.pnlMetaTilesEdit.UseMouseWheelScaling = false;
            this.pnlMetaTilesEdit.MetaTileChanged += new SMSTileStudio.Controls.MetaTilesControl.MetaTileChangedHandler(this.pnlMetaTilesEdit_MetaTileChanged);
            // 
            // pnlMetaTileTools
            // 
            this.pnlMetaTileTools.AutoSize = true;
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTileIds);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTilePriority);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTilePalette);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTileType);
            this.pnlMetaTileTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetaTileTools.Location = new System.Drawing.Point(8, 84);
            this.pnlMetaTileTools.Name = "pnlMetaTileTools";
            this.pnlMetaTileTools.Size = new System.Drawing.Size(170, 46);
            this.pnlMetaTileTools.TabIndex = 31;
            // 
            // rbMetaTileIds
            // 
            this.rbMetaTileIds.AutoSize = true;
            this.rbMetaTileIds.Checked = true;
            this.rbMetaTileIds.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbMetaTileIds.Location = new System.Drawing.Point(3, 3);
            this.rbMetaTileIds.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTileIds.Name = "rbMetaTileIds";
            this.rbMetaTileIds.Size = new System.Drawing.Size(40, 17);
            this.rbMetaTileIds.TabIndex = 38;
            this.rbMetaTileIds.TabStop = true;
            this.rbMetaTileIds.Text = "Ids";
            this.rbMetaTileIds.UseVisualStyleBackColor = true;
            this.rbMetaTileIds.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbMetaTilePriority
            // 
            this.rbMetaTilePriority.AutoSize = true;
            this.rbMetaTilePriority.Location = new System.Drawing.Point(46, 3);
            this.rbMetaTilePriority.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTilePriority.Name = "rbMetaTilePriority";
            this.rbMetaTilePriority.Size = new System.Drawing.Size(61, 17);
            this.rbMetaTilePriority.TabIndex = 4;
            this.rbMetaTilePriority.Text = "Priority";
            this.rbMetaTilePriority.UseVisualStyleBackColor = true;
            this.rbMetaTilePriority.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbMetaTilePalette
            // 
            this.rbMetaTilePalette.AutoSize = true;
            this.rbMetaTilePalette.Location = new System.Drawing.Point(110, 3);
            this.rbMetaTilePalette.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTilePalette.Name = "rbMetaTilePalette";
            this.rbMetaTilePalette.Size = new System.Drawing.Size(60, 17);
            this.rbMetaTilePalette.TabIndex = 5;
            this.rbMetaTilePalette.Text = "Palette";
            this.rbMetaTilePalette.UseVisualStyleBackColor = true;
            this.rbMetaTilePalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbMetaTileType
            // 
            this.rbMetaTileType.AutoSize = true;
            this.rbMetaTileType.Location = new System.Drawing.Point(3, 26);
            this.rbMetaTileType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTileType.Name = "rbMetaTileType";
            this.rbMetaTileType.Size = new System.Drawing.Size(47, 17);
            this.rbMetaTileType.TabIndex = 31;
            this.rbMetaTileType.Text = "Type";
            this.rbMetaTileType.UseVisualStyleBackColor = true;
            this.rbMetaTileType.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // pnlMetaTilePaletteOptions
            // 
            this.pnlMetaTilePaletteOptions.Controls.Add(this.lblMetaTileSize);
            this.pnlMetaTilePaletteOptions.Controls.Add(this.cbMetaTileSize);
            this.pnlMetaTilePaletteOptions.Controls.Add(this.btnMetaTileOptions);
            this.pnlMetaTilePaletteOptions.Controls.Add(this.chkMetaTileApplyEditsByTileId);
            this.pnlMetaTilePaletteOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetaTilePaletteOptions.Location = new System.Drawing.Point(8, 0);
            this.pnlMetaTilePaletteOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlMetaTilePaletteOptions.Name = "pnlMetaTilePaletteOptions";
            this.pnlMetaTilePaletteOptions.Size = new System.Drawing.Size(170, 84);
            this.pnlMetaTilePaletteOptions.TabIndex = 3;
            // 
            // lblMetaTileSize
            // 
            this.lblMetaTileSize.AutoSize = true;
            this.lblMetaTileSize.Location = new System.Drawing.Point(1, 26);
            this.lblMetaTileSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblMetaTileSize.Name = "lblMetaTileSize";
            this.lblMetaTileSize.Size = new System.Drawing.Size(79, 13);
            this.lblMetaTileSize.TabIndex = 44;
            this.lblMetaTileSize.Text = "Meta Tile Size:";
            this.lblMetaTileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMetaTileSize
            // 
            this.cbMetaTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetaTileSize.FormattingEnabled = true;
            this.cbMetaTileSize.Location = new System.Drawing.Point(1, 42);
            this.cbMetaTileSize.Name = "cbMetaTileSize";
            this.cbMetaTileSize.Size = new System.Drawing.Size(168, 21);
            this.cbMetaTileSize.TabIndex = 45;
            // 
            // btnMetaTileOptions
            // 
            this.btnMetaTileOptions.ContextMenuStrip = this.mnuMetaTileOptions;
            this.btnMetaTileOptions.Location = new System.Drawing.Point(0, 0);
            this.btnMetaTileOptions.Name = "btnMetaTileOptions";
            this.btnMetaTileOptions.Size = new System.Drawing.Size(168, 23);
            this.btnMetaTileOptions.TabIndex = 22;
            this.btnMetaTileOptions.Text = "Meta Tile Options";
            this.btnMetaTileOptions.UseVisualStyleBackColor = true;
            this.btnMetaTileOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // mnuMetaTileOptions
            // 
            this.mnuMetaTileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateMetaTilemap,
            this.mnuClearMetaTilemap,
            this.toolStripMenuItem8,
            this.mnuExportMetaTilemap,
            this.mnuExportMetaTiles,
            this.mnuExportAllMetaData});
            this.mnuMetaTileOptions.Name = "mnuMetaTileOptions";
            this.mnuMetaTileOptions.Size = new System.Drawing.Size(198, 120);
            // 
            // mnuGenerateMetaTilemap
            // 
            this.mnuGenerateMetaTilemap.Name = "mnuGenerateMetaTilemap";
            this.mnuGenerateMetaTilemap.Size = new System.Drawing.Size(197, 22);
            this.mnuGenerateMetaTilemap.Text = "Generate Meta Tilemap";
            this.mnuGenerateMetaTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuClearMetaTilemap
            // 
            this.mnuClearMetaTilemap.Name = "mnuClearMetaTilemap";
            this.mnuClearMetaTilemap.Size = new System.Drawing.Size(197, 22);
            this.mnuClearMetaTilemap.Text = "Clear Meta Tilemap";
            this.mnuClearMetaTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuExportMetaTilemap
            // 
            this.mnuExportMetaTilemap.Name = "mnuExportMetaTilemap";
            this.mnuExportMetaTilemap.Size = new System.Drawing.Size(197, 22);
            this.mnuExportMetaTilemap.Text = "Export Meta Tilemap";
            this.mnuExportMetaTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportMetaTiles
            // 
            this.mnuExportMetaTiles.Name = "mnuExportMetaTiles";
            this.mnuExportMetaTiles.Size = new System.Drawing.Size(197, 22);
            this.mnuExportMetaTiles.Text = "Export Meta Tiles";
            this.mnuExportMetaTiles.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportAllMetaData
            // 
            this.mnuExportAllMetaData.Name = "mnuExportAllMetaData";
            this.mnuExportAllMetaData.Size = new System.Drawing.Size(197, 22);
            this.mnuExportAllMetaData.Text = "Export All Meta Data";
            this.mnuExportAllMetaData.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // chkMetaTileApplyEditsByTileId
            // 
            this.chkMetaTileApplyEditsByTileId.AutoSize = true;
            this.chkMetaTileApplyEditsByTileId.Checked = true;
            this.chkMetaTileApplyEditsByTileId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaTileApplyEditsByTileId.Location = new System.Drawing.Point(0, 66);
            this.chkMetaTileApplyEditsByTileId.Name = "chkMetaTileApplyEditsByTileId";
            this.chkMetaTileApplyEditsByTileId.Size = new System.Drawing.Size(131, 17);
            this.chkMetaTileApplyEditsByTileId.TabIndex = 39;
            this.chkMetaTileApplyEditsByTileId.Text = "Apply edits by Tile Id";
            this.chkMetaTileApplyEditsByTileId.UseVisualStyleBackColor = true;
            this.chkMetaTileApplyEditsByTileId.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
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
            this.mnuExportTilemap});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(154, 98);
            // 
            // mnuExportAll
            // 
            this.mnuExportAll.Name = "mnuExportAll";
            this.mnuExportAll.Size = new System.Drawing.Size(153, 22);
            this.mnuExportAll.Text = "Export All";
            this.mnuExportAll.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
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
            this.mnuExportPalette.Size = new System.Drawing.Size(153, 22);
            this.mnuExportPalette.Text = "Export Palette";
            // 
            // mnuExportBgPalette
            // 
            this.mnuExportBgPalette.Checked = true;
            this.mnuExportBgPalette.CheckOnClick = true;
            this.mnuExportBgPalette.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuExportBgPalette.Name = "mnuExportBgPalette";
            this.mnuExportBgPalette.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBgPalette.Text = "Background Palette";
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuPaletteExportImage
            // 
            this.mnuPaletteExportImage.Name = "mnuPaletteExportImage";
            this.mnuPaletteExportImage.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportImage.Text = "Export as Image";
            // 
            // mnuPaletteExportBinary
            // 
            this.mnuPaletteExportBinary.Name = "mnuPaletteExportBinary";
            this.mnuPaletteExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportBinary.Text = "Export as Binary";
            // 
            // mnuPaletteExportHex
            // 
            this.mnuPaletteExportHex.Name = "mnuPaletteExportHex";
            this.mnuPaletteExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportHex.Text = "Export as Hex (Clipboard)";
            // 
            // mnuPaletteExportAssembly
            // 
            this.mnuPaletteExportAssembly.Name = "mnuPaletteExportAssembly";
            this.mnuPaletteExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportAssembly.Text = "Export as Assembly (Clipboard)";
            // 
            // mnuExportTileset
            // 
            this.mnuExportTileset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTilesetBypassCompression,
            this.mnuTilesetUseMaskColor,
            this.mnuSeparator2,
            this.mnuTilesetExportImage,
            this.mnuTilesetExportImages,
            this.mnuTilesetExportBinary,
            this.mnuTilesetExportBinaries,
            this.mnuTilesetExportHex,
            this.mnuTilesetExportAssembly});
            this.mnuExportTileset.Name = "mnuExportTileset";
            this.mnuExportTileset.Size = new System.Drawing.Size(153, 22);
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
            // mnuTilesetExportImages
            // 
            this.mnuTilesetExportImages.Name = "mnuTilesetExportImages";
            this.mnuTilesetExportImages.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportImages.Text = "Export as Images";
            this.mnuTilesetExportImages.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetExportBinary
            // 
            this.mnuTilesetExportBinary.Name = "mnuTilesetExportBinary";
            this.mnuTilesetExportBinary.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportBinary.Text = "Export as Binary";
            this.mnuTilesetExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetExportBinaries
            // 
            this.mnuTilesetExportBinaries.Name = "mnuTilesetExportBinaries";
            this.mnuTilesetExportBinaries.Size = new System.Drawing.Size(255, 22);
            this.mnuTilesetExportBinaries.Text = "Export as Binaries";
            this.mnuTilesetExportBinaries.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            this.mnuSeparator3,
            this.mnuTilemapExportImage,
            this.mnuTilemapExportImages,
            this.mnuExportImagesFromAreaGrid,
            this.mnuTilemapExportBinary,
            this.mnuTilemapExportBinaries,
            this.mnuExportBinariesFromAreaGrid,
            this.mnuExportSGBinary,
            this.mnuTilemapExportHex,
            this.mnuTilemapExportAssembly,
            this.mnuTilemapExportDecimal});
            this.mnuExportTilemap.Name = "mnuExportTilemap";
            this.mnuExportTilemap.Size = new System.Drawing.Size(153, 22);
            this.mnuExportTilemap.Text = "Export Tilemap";
            // 
            // mnuTilemapBypassCompression
            // 
            this.mnuTilemapBypassCompression.CheckOnClick = true;
            this.mnuTilemapBypassCompression.Name = "mnuTilemapBypassCompression";
            this.mnuTilemapBypassCompression.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapBypassCompression.Text = "Bypass Compression";
            // 
            // mnuTilemapVerticalOrientation
            // 
            this.mnuTilemapVerticalOrientation.CheckOnClick = true;
            this.mnuTilemapVerticalOrientation.Name = "mnuTilemapVerticalOrientation";
            this.mnuTilemapVerticalOrientation.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapVerticalOrientation.Text = "Vertical Orientation";
            this.mnuTilemapVerticalOrientation.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // mnuSeparator3
            // 
            this.mnuSeparator3.Name = "mnuSeparator3";
            this.mnuSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuTilemapExportImage
            // 
            this.mnuTilemapExportImage.Name = "mnuTilemapExportImage";
            this.mnuTilemapExportImage.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportImage.Text = "Export as Image";
            this.mnuTilemapExportImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportImages
            // 
            this.mnuTilemapExportImages.Name = "mnuTilemapExportImages";
            this.mnuTilemapExportImages.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportImages.Text = "Export as Images";
            this.mnuTilemapExportImages.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportImagesFromAreaGrid
            // 
            this.mnuExportImagesFromAreaGrid.Name = "mnuExportImagesFromAreaGrid";
            this.mnuExportImagesFromAreaGrid.Size = new System.Drawing.Size(238, 22);
            this.mnuExportImagesFromAreaGrid.Text = "Export Images from Area Grid";
            this.mnuExportImagesFromAreaGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportBinary
            // 
            this.mnuTilemapExportBinary.Name = "mnuTilemapExportBinary";
            this.mnuTilemapExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportBinary.Text = "Export as Binary";
            this.mnuTilemapExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportBinaries
            // 
            this.mnuTilemapExportBinaries.Name = "mnuTilemapExportBinaries";
            this.mnuTilemapExportBinaries.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportBinaries.Text = "Export as Binaries";
            this.mnuTilemapExportBinaries.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportBinariesFromAreaGrid
            // 
            this.mnuExportBinariesFromAreaGrid.Name = "mnuExportBinariesFromAreaGrid";
            this.mnuExportBinariesFromAreaGrid.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinariesFromAreaGrid.Text = "Export Binaries from Area Grid";
            this.mnuExportBinariesFromAreaGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportSGBinary
            // 
            this.mnuExportSGBinary.Name = "mnuExportSGBinary";
            this.mnuExportSGBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportSGBinary.Text = "Export as SG Binary";
            this.mnuExportSGBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportHex
            // 
            this.mnuTilemapExportHex.Name = "mnuTilemapExportHex";
            this.mnuTilemapExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuTilemapExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportAssembly
            // 
            this.mnuTilemapExportAssembly.Name = "mnuTilemapExportAssembly";
            this.mnuTilemapExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuTilemapExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapExportDecimal
            // 
            this.mnuTilemapExportDecimal.Name = "mnuTilemapExportDecimal";
            this.mnuTilemapExportDecimal.Size = new System.Drawing.Size(238, 22);
            this.mnuTilemapExportDecimal.Text = "Export as Decimal (Clipboard)";
            this.mnuTilemapExportDecimal.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuImport
            // 
            this.mnuImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportTilemap,
            this.mnuUpdateTileset});
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(157, 48);
            // 
            // mnuImportTilemap
            // 
            this.mnuImportTilemap.Name = "mnuImportTilemap";
            this.mnuImportTilemap.Size = new System.Drawing.Size(156, 22);
            this.mnuImportTilemap.Text = "Import Tilemap";
            this.mnuImportTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuUpdateTileset
            // 
            this.mnuUpdateTileset.Name = "mnuUpdateTileset";
            this.mnuUpdateTileset.Size = new System.Drawing.Size(156, 22);
            this.mnuUpdateTileset.Text = "Update Tileset";
            this.mnuUpdateTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetOptions
            // 
            this.mnuTilesetOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.mnuAddTile,
            this.mnuTilesetCopyTile,
            this.mnuTilesetPasteTile,
            this.mnuDeselectTile,
            this.mnuRemoveTile,
            this.mnuRemoveByRange,
            this.mnuSeperator20,
            this.mnuCopyTileset,
            this.mnuPasteTileset,
            this.mnuBulkPasteTileset});
            this.mnuTilesetOptions.Name = "mnuTileOptions";
            this.mnuTilesetOptions.Size = new System.Drawing.Size(206, 214);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
            // 
            // mnuAddTile
            // 
            this.mnuAddTile.Name = "mnuAddTile";
            this.mnuAddTile.Size = new System.Drawing.Size(205, 22);
            this.mnuAddTile.Text = "Add Empty Tile";
            this.mnuAddTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetCopyTile
            // 
            this.mnuTilesetCopyTile.Name = "mnuTilesetCopyTile";
            this.mnuTilesetCopyTile.Size = new System.Drawing.Size(205, 22);
            this.mnuTilesetCopyTile.Text = "Copy Tile";
            this.mnuTilesetCopyTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilesetPasteTile
            // 
            this.mnuTilesetPasteTile.Name = "mnuTilesetPasteTile";
            this.mnuTilesetPasteTile.Size = new System.Drawing.Size(205, 22);
            this.mnuTilesetPasteTile.Text = "Paste Tile";
            this.mnuTilesetPasteTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuDeselectTile
            // 
            this.mnuDeselectTile.Name = "mnuDeselectTile";
            this.mnuDeselectTile.Size = new System.Drawing.Size(205, 22);
            this.mnuDeselectTile.Text = "Deselect Tile";
            this.mnuDeselectTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuRemoveTile
            // 
            this.mnuRemoveTile.Name = "mnuRemoveTile";
            this.mnuRemoveTile.ShortcutKeyDisplayString = "Del";
            this.mnuRemoveTile.Size = new System.Drawing.Size(205, 22);
            this.mnuRemoveTile.Text = "Remove Tile";
            this.mnuRemoveTile.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuRemoveByRange
            // 
            this.mnuRemoveByRange.Name = "mnuRemoveByRange";
            this.mnuRemoveByRange.Size = new System.Drawing.Size(205, 22);
            this.mnuRemoveByRange.Text = "Remove By Export Range";
            this.mnuRemoveByRange.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuSeperator20
            // 
            this.mnuSeperator20.Name = "mnuSeperator20";
            this.mnuSeperator20.Size = new System.Drawing.Size(202, 6);
            // 
            // mnuCopyTileset
            // 
            this.mnuCopyTileset.Name = "mnuCopyTileset";
            this.mnuCopyTileset.Size = new System.Drawing.Size(205, 22);
            this.mnuCopyTileset.Text = "Copy Tileset";
            this.mnuCopyTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuPasteTileset
            // 
            this.mnuPasteTileset.Name = "mnuPasteTileset";
            this.mnuPasteTileset.Size = new System.Drawing.Size(205, 22);
            this.mnuPasteTileset.Text = "Paste Tileset";
            this.mnuPasteTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuBulkPasteTileset
            // 
            this.mnuBulkPasteTileset.Name = "mnuBulkPasteTileset";
            this.mnuBulkPasteTileset.Size = new System.Drawing.Size(205, 22);
            this.mnuBulkPasteTileset.Text = "Bulk Paste Tileset";
            this.mnuBulkPasteTileset.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapOptions
            // 
            this.mnuTilemapOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReplaceTiles,
            this.mnuOptimizeTilemap,
            this.toolStripMenuItem4,
            this.mnuTilemapBulkRename,
            this.mnuTilemapsFromAreaGrid});
            this.mnuTilemapOptions.Name = "mnuTilemapOptions";
            this.mnuTilemapOptions.Size = new System.Drawing.Size(204, 98);
            // 
            // mnuReplaceTiles
            // 
            this.mnuReplaceTiles.Name = "mnuReplaceTiles";
            this.mnuReplaceTiles.Size = new System.Drawing.Size(203, 22);
            this.mnuReplaceTiles.Text = "Replace Tiles";
            this.mnuReplaceTiles.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuOptimizeTilemap
            // 
            this.mnuOptimizeTilemap.Name = "mnuOptimizeTilemap";
            this.mnuOptimizeTilemap.Size = new System.Drawing.Size(203, 22);
            this.mnuOptimizeTilemap.Text = "Optimize Tilemap";
            this.mnuOptimizeTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 6);
            // 
            // mnuTilemapBulkRename
            // 
            this.mnuTilemapBulkRename.Name = "mnuTilemapBulkRename";
            this.mnuTilemapBulkRename.Size = new System.Drawing.Size(203, 22);
            this.mnuTilemapBulkRename.Text = "Bulk Rename Tilemaps";
            this.mnuTilemapBulkRename.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTilemapsFromAreaGrid
            // 
            this.mnuTilemapsFromAreaGrid.Name = "mnuTilemapsFromAreaGrid";
            this.mnuTilemapsFromAreaGrid.Size = new System.Drawing.Size(203, 22);
            this.mnuTilemapsFromAreaGrid.Text = "Tilemaps from Area Grid";
            this.mnuTilemapsFromAreaGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTileGridOptions
            // 
            this.mnuTileGridOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewTileGrid,
            this.mnuDuplicateTileGrid,
            this.mnuRemoveTileGrid,
            this.mnuExportTileGrid});
            this.mnuTileGridOptions.Name = "mnuMetaTilemapOptions";
            this.mnuTileGridOptions.Size = new System.Drawing.Size(172, 92);
            // 
            // mnuNewTileGrid
            // 
            this.mnuNewTileGrid.Name = "mnuNewTileGrid";
            this.mnuNewTileGrid.Size = new System.Drawing.Size(171, 22);
            this.mnuNewTileGrid.Text = "New Tile Grid";
            this.mnuNewTileGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuDuplicateTileGrid
            // 
            this.mnuDuplicateTileGrid.Name = "mnuDuplicateTileGrid";
            this.mnuDuplicateTileGrid.Size = new System.Drawing.Size(171, 22);
            this.mnuDuplicateTileGrid.Text = "Duplicate Tile Grid";
            this.mnuDuplicateTileGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuRemoveTileGrid
            // 
            this.mnuRemoveTileGrid.Name = "mnuRemoveTileGrid";
            this.mnuRemoveTileGrid.Size = new System.Drawing.Size(171, 22);
            this.mnuRemoveTileGrid.Text = "Remove Tile Grid";
            this.mnuRemoveTileGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportTileGrid
            // 
            this.mnuExportTileGrid.Name = "mnuExportTileGrid";
            this.mnuExportTileGrid.Size = new System.Drawing.Size(171, 22);
            this.mnuExportTileGrid.Text = "Export Tile Grid";
            this.mnuExportTileGrid.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.tabTileGrids.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridValue)).EndInit();
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
            this.pnlTileset.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            this.tabTags.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabMetaTilemap.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnlMetaTilemapInfo.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMetaTileOptions.ResumeLayout(false);
            this.pnlMetaTileOptions.PerformLayout();
            this.pnlMetaTileTools.ResumeLayout(false);
            this.pnlMetaTileTools.PerformLayout();
            this.pnlMetaTilePaletteOptions.ResumeLayout(false);
            this.pnlMetaTilePaletteOptions.PerformLayout();
            this.mnuMetaTileOptions.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.mnuImport.ResumeLayout(false);
            this.mnuTilesetOptions.ResumeLayout(false);
            this.mnuTilemapOptions.ResumeLayout(false);
            this.mnuTileGridOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpImageList;
        private ListBoxControl lstTilemaps;
        private System.Windows.Forms.Panel pnlPaletteButtons;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlMain;
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
        private System.Windows.Forms.CheckBox chkTilemapShowTileAs;
        private System.Windows.Forms.TableLayoutPanel tpnlTileset;
        private System.Windows.Forms.CheckBox chkTilesetGrid;
        private System.Windows.Forms.CheckBox chkTilesetShowTileIds;
        private System.Windows.Forms.Button btnSelectionOptions;
        private System.Windows.Forms.Button btnExport;
        private TilemapControl pnlTilemapEdit;
        private TilesetImageControl pnlTilesetEdit;
        private System.Windows.Forms.Label lblCreateTilemap;
        private System.Windows.Forms.Panel pnlPalettes;
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
        private System.Windows.Forms.RadioButton rbTilemapSelect;
        private System.Windows.Forms.RadioButton rbTilemapPalette;
        private System.Windows.Forms.RadioButton rbTilemapPriority;
        private System.Windows.Forms.RadioButton rbTilemapFlipY;
        private System.Windows.Forms.RadioButton rbTilemapFlipX;
        private System.Windows.Forms.RadioButton rbTilemapBrush;
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
        private System.Windows.Forms.FlowLayoutPanel pnlTilemapToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuSetTileType;
        private System.Windows.Forms.TabPage tabTileGrids;
        private System.Windows.Forms.TabControl tabTileOptions;
        private System.Windows.Forms.TabPage tabTilePalette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabTileList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbTilesetType;
        private System.Windows.Forms.NumericUpDown nudTileType;
        private System.Windows.Forms.RadioButton rbTilemapTileType;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Panel pnlTileset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mnuClearSelection;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.ToolStripMenuItem mnuCropTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveByRange;
        private System.Windows.Forms.ToolTip tipMain;
        private System.Windows.Forms.ToolStripMenuItem mnuBulkPasteTileset;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportImages;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportBinaries;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportImages;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetExportBinaries;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapBulkRename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAreaGridRows;
        private System.Windows.Forms.NumericUpDown nudAreaGridCols;
        private System.Windows.Forms.CheckBox chkTilemapAreaGrid;
        private ListBoxControl lstTileGrids;
        private System.Windows.Forms.Button btnTileGridOptions;
        private System.Windows.Forms.TextBox txtTileGridName;
        private System.Windows.Forms.Label lblTileGridName;
        private System.Windows.Forms.ContextMenuStrip mnuTileGridOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTileGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuDuplicateTileGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTileGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapsFromAreaGrid;
        private System.Windows.Forms.Button btnTilemapRemove;
        private System.Windows.Forms.Button btnTilemapDuplicate;
        private System.Windows.Forms.Button btnTilemapNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTilemapInvertGrids;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuExportImagesFromAreaGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinariesFromAreaGrid;
        private System.Windows.Forms.TabPage tabMetaTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTileGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTilesetOptions;
        private System.Windows.Forms.Panel pnlTilesetOptions;
        private System.Windows.Forms.Button btnTilesetOptions;
        private PaletteControl pnlSprPalette;
        private PaletteControl pnlBGPalette;
        private TileControl pnlSelectedTile;
        private System.Windows.Forms.RadioButton rbBgPalette;
        private System.Windows.Forms.Button btnSwapSelectedPixel;
        private System.Windows.Forms.RadioButton rbSprPalette;
        private System.Windows.Forms.Label lblSelectedTile;
        private System.Windows.Forms.Label lblTilesetCompression;
        private System.Windows.Forms.ComboBox cbTilesetCompression;
        private System.Windows.Forms.Label lblSprPalette;
        private System.Windows.Forms.ComboBox cbSprPalette;
        private System.Windows.Forms.Label lblBgPalette;
        private System.Windows.Forms.ComboBox cbBgPalette;
        private System.Windows.Forms.TabPage tabTags;
        private System.Windows.Forms.Panel panel9;
        private ListBoxControl lstTags;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddExistingTag;
        private System.Windows.Forms.ComboBox cbExistingTags;
        private System.Windows.Forms.Label lblExistingTag;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnBulkAddTag;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetCopyTile;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetPasteTile;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectionToTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuMirrorX;
        private System.Windows.Forms.ToolStripMenuItem mnuMirrorY;
        private System.Windows.Forms.Label lblTileGridTileSize;
        private System.Windows.Forms.ComboBox cbTileGridTileSize;
        private System.Windows.Forms.Label lblTileGridRows;
        private System.Windows.Forms.Label lblTileGridColumns;
        private System.Windows.Forms.NumericUpDown nudTileGridRows;
        private System.Windows.Forms.NumericUpDown nudTileGridColumns;
        private System.Windows.Forms.NumericUpDown nudTileGridValue;
        private System.Windows.Forms.Label lblTileGridValue;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectedIndexes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rbTilemapShowIndexes;
        private System.Windows.Forms.RadioButton rbTilemapShowIds;
        private System.Windows.Forms.ToolStripMenuItem mnuTilemapExportDecimal;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAreaToBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectedIndexesToDecimal;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectedIds;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectionToImage;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectionToBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectionDecimalToClipboard;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectionDecimalReversedToClipboard;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSelectedIndexesToDecimalReversed;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuSetSelectionTileId;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ToolStripMenuItem mnuExportSGBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAsSGBinary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlMetaTilemapInfo;
        private System.Windows.Forms.Label lblMetaTilemapProperties;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlMetaTileOptions;
        private System.Windows.Forms.Panel pnlMetaTilePaletteOptions;
        private System.Windows.Forms.Button btnMetaTileOptions;
        private System.Windows.Forms.Label lblMetaTileSize;
        private System.Windows.Forms.ComboBox cbMetaTileSize;
        private MetaTilemapControl pnlMetaTilemapEdit;
        private MetaTilesControl pnlMetaTilesEdit;
        private System.Windows.Forms.ContextMenuStrip mnuMetaTileOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateMetaTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuClearMetaTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetaTilemap;
        private System.Windows.Forms.Label lblMetaTileProperties;
        private System.Windows.Forms.FlowLayoutPanel pnlMetaTileTools;
        private System.Windows.Forms.RadioButton rbMetaTilePriority;
        private System.Windows.Forms.RadioButton rbMetaTilePalette;
        private System.Windows.Forms.RadioButton rbMetaTileType;
        private System.Windows.Forms.RadioButton rbMetaTileIds;
        private System.Windows.Forms.CheckBox chkMetaTileApplyEditsByTileId;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetaTiles;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAllMetaData;
    }
}
