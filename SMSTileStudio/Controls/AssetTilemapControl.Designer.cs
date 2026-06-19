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
            this.tpnlTilemaps = new System.Windows.Forms.TableLayoutPanel();
            this.btnTilemapUpdate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstTilemaps = new SMSTileStudio.Controls.ListBoxControl();
            this.nudTilesetExportEnd = new System.Windows.Forms.NumericUpDown();
            this.lblTilesetExportRange = new System.Windows.Forms.Label();
            this.btnTilemapOptions = new System.Windows.Forms.Button();
            this.lblTilesetRangeTo = new System.Windows.Forms.Label();
            this.btnTilemapRemove = new System.Windows.Forms.Button();
            this.nudTilesetExportStart = new System.Windows.Forms.NumericUpDown();
            this.btnTilemapDuplicate = new System.Windows.Forms.Button();
            this.lblTileType = new System.Windows.Forms.Label();
            this.btnTilemapImport = new System.Windows.Forms.Button();
            this.nudTileType = new System.Windows.Forms.NumericUpDown();
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
            this.tpnlTilemapInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
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
            this.tabTilemapOptions = new System.Windows.Forms.TabControl();
            this.tabTilemapTiles = new System.Windows.Forms.TabPage();
            this.tpnlTilemapOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tabTileOptions = new System.Windows.Forms.TabControl();
            this.tabTilePalette = new System.Windows.Forms.TabPage();
            this.pnlTiles = new SMSTileStudio.Controls.TilesControl();
            this.tabTileList = new System.Windows.Forms.TabPage();
            this.pnlTileList = new SMSTileStudio.Controls.TileListControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlSelectedTileID = new System.Windows.Forms.Panel();
            this.lblSelectedTileID = new System.Windows.Forms.Label();
            this.lblSelectedTileIDValue = new System.Windows.Forms.Label();
            this.nudAreaGridRows = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectionOptions = new System.Windows.Forms.Button();
            this.nudAreaGridCols = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTilemapCompression = new System.Windows.Forms.Label();
            this.chkUseAttributes = new System.Windows.Forms.CheckBox();
            this.cbTilemapCompression = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOffset = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.tabTileGrids = new System.Windows.Forms.TabPage();
            this.tpnlTileGridOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lblTileGridRows = new System.Windows.Forms.Label();
            this.lblTileGridColumns = new System.Windows.Forms.Label();
            this.lblTileGridBytes = new System.Windows.Forms.Label();
            this.lstTileGrids = new SMSTileStudio.Controls.ListBoxControl();
            this.nudTileGridValue = new System.Windows.Forms.NumericUpDown();
            this.lblTileGridValue = new System.Windows.Forms.Label();
            this.cbTileGridTileSize = new System.Windows.Forms.ComboBox();
            this.lblTileGridTileSize = new System.Windows.Forms.Label();
            this.btnTileGridOptions = new System.Windows.Forms.Button();
            this.lblTileGridName = new System.Windows.Forms.Label();
            this.txtTileGridName = new System.Windows.Forms.TextBox();
            this.tabEntities = new System.Windows.Forms.TabPage();
            this.tpnlEntityOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lstEntities = new SMSTileStudio.Controls.ListBoxControl();
            this.nudEntityHeight = new System.Windows.Forms.NumericUpDown();
            this.lblEntityHeight = new System.Windows.Forms.Label();
            this.nudEntityId = new System.Windows.Forms.NumericUpDown();
            this.nudEntityY = new System.Windows.Forms.NumericUpDown();
            this.nudEntityWidth = new System.Windows.Forms.NumericUpDown();
            this.lblEntityWidth = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEntityY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEntityX = new System.Windows.Forms.Label();
            this.nudEntityX = new System.Windows.Forms.NumericUpDown();
            this.lblEntityProperties = new System.Windows.Forms.Label();
            this.tabTileset = new System.Windows.Forms.TabPage();
            this.tpnlTileset = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
            this.flpnlTilesetTools = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTilesetSelect = new System.Windows.Forms.RadioButton();
            this.rbTilesetSwap = new System.Windows.Forms.RadioButton();
            this.rbTilesetType = new System.Windows.Forms.RadioButton();
            this.chkTilesetGrid = new System.Windows.Forms.CheckBox();
            this.chkTilesetShowTileIds = new System.Windows.Forms.CheckBox();
            this.tabTiles = new System.Windows.Forms.TabControl();
            this.tabTilesetOptions = new System.Windows.Forms.TabPage();
            this.tpnlTilesetOptions = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelectedTile = new SMSTileStudio.Controls.TileControl();
            this.btnTilesetOptions = new System.Windows.Forms.Button();
            this.btnSwapSelectedPixel = new System.Windows.Forms.Button();
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.lblTilesetCompression = new System.Windows.Forms.Label();
            this.lblSelectedTile = new System.Windows.Forms.Label();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.cbTilesetCompression = new System.Windows.Forms.ComboBox();
            this.rbBgPalette = new System.Windows.Forms.RadioButton();
            this.cbSprPalette = new System.Windows.Forms.ComboBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.rbSprPalette = new System.Windows.Forms.RadioButton();
            this.lblBgPalette = new System.Windows.Forms.Label();
            this.cbBgPalette = new System.Windows.Forms.ComboBox();
            this.tabTags = new System.Windows.Forms.TabPage();
            this.tpnlTagOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lstTags = new SMSTileStudio.Controls.ListBoxControl();
            this.btnAddExistingTag = new System.Windows.Forms.Button();
            this.btnBulkAddTag = new System.Windows.Forms.Button();
            this.cbExistingTags = new System.Windows.Forms.ComboBox();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.lblExistingTag = new System.Windows.Forms.Label();
            this.lblTagName = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.tabMetaTilemap = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnlMetaTilemapEdit = new SMSTileStudio.Controls.MetaTilemapControl();
            this.mnuMetaTilemapOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMetaTilemapTilemapFromSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetaTilemapSelectionToTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetaTilemapClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMetaTilemapProperties = new System.Windows.Forms.Label();
            this.lblMetaTileProperties = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMetaTilemapBrush = new System.Windows.Forms.RadioButton();
            this.rbMetaTilemapSelect = new System.Windows.Forms.RadioButton();
            this.chkMetaTilemapShowGrid = new System.Windows.Forms.CheckBox();
            this.chkMetaTilemapShowIds = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMetaTilesEdit = new SMSTileStudio.Controls.MetaTilesControl();
            this.chkMetaTilesShowHexValues = new System.Windows.Forms.CheckBox();
            this.pnlMetaTileTools = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMetaTileIds = new System.Windows.Forms.RadioButton();
            this.rbMetaTileValue = new System.Windows.Forms.RadioButton();
            this.rbMetaTilePriority = new System.Windows.Forms.RadioButton();
            this.rbMetaTilePalette = new System.Windows.Forms.RadioButton();
            this.rbMetaTileType = new System.Windows.Forms.RadioButton();
            this.chkMetaTileApplyEditsByTileId = new System.Windows.Forms.CheckBox();
            this.cbMetaTileSize = new System.Windows.Forms.ComboBox();
            this.lblMetaTileSize = new System.Windows.Forms.Label();
            this.btnMetaTileOptions = new System.Windows.Forms.Button();
            this.mnuMetaTileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGenerateMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGSLibExportFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTilemap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTilemapBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTilesBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportMetaTilesImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAllMetaData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAllMetaDataBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreateTilemap = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportPalette = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuTilesetOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuTilesetUpdate = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuTileGridExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTileGridExportUseOneDeminsionalArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileGridExportDecimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileGridExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileGridExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlipX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlipY = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpImageList.SuspendLayout();
            this.tpnlTilemaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileType)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.tpnlTilemap.SuspendLayout();
            this.pnlTilemap.SuspendLayout();
            this.mnuSelectOptions.SuspendLayout();
            this.tpnlTilemapInfo.SuspendLayout();
            this.pnlTilemapToolbar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabTilemapOptions.SuspendLayout();
            this.tabTilemapTiles.SuspendLayout();
            this.tpnlTilemapOptions.SuspendLayout();
            this.tabTileOptions.SuspendLayout();
            this.tabTilePalette.SuspendLayout();
            this.tabTileList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSelectedTileID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridCols)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.tabTileGrids.SuspendLayout();
            this.tpnlTileGridOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridValue)).BeginInit();
            this.tabEntities.SuspendLayout();
            this.tpnlEntityOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityX)).BeginInit();
            this.tabTileset.SuspendLayout();
            this.tpnlTileset.SuspendLayout();
            this.pnlTileset.SuspendLayout();
            this.flpnlTilesetTools.SuspendLayout();
            this.tabTiles.SuspendLayout();
            this.tabTilesetOptions.SuspendLayout();
            this.tpnlTilesetOptions.SuspendLayout();
            this.tabTags.SuspendLayout();
            this.tpnlTagOptions.SuspendLayout();
            this.tabMetaTilemap.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.mnuMetaTilemapOptions.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlMetaTileTools.SuspendLayout();
            this.mnuMetaTileOptions.SuspendLayout();
            this.mnuExport.SuspendLayout();
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
            this.tpnlMain.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.TabIndex = 3;
            // 
            // grpImageList
            // 
            this.grpImageList.Controls.Add(this.tpnlTilemaps);
            this.grpImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImageList.Location = new System.Drawing.Point(0, 0);
            this.grpImageList.Margin = new System.Windows.Forms.Padding(0);
            this.grpImageList.Name = "grpImageList";
            this.grpImageList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpImageList.Size = new System.Drawing.Size(196, 479);
            this.grpImageList.TabIndex = 0;
            this.grpImageList.TabStop = false;
            this.grpImageList.Text = "Tilemaps";
            // 
            // tpnlTilemaps
            // 
            this.tpnlTilemaps.ColumnCount = 3;
            this.tpnlTilemaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.4898F));
            this.tpnlTilemaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5102F));
            this.tpnlTilemaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tpnlTilemaps.Controls.Add(this.btnTilemapUpdate, 0, 4);
            this.tpnlTilemaps.Controls.Add(this.btnExport, 0, 8);
            this.tpnlTilemaps.Controls.Add(this.lstTilemaps, 0, 9);
            this.tpnlTilemaps.Controls.Add(this.nudTilesetExportEnd, 2, 2);
            this.tpnlTilemaps.Controls.Add(this.lblTilesetExportRange, 0, 1);
            this.tpnlTilemaps.Controls.Add(this.btnTilemapOptions, 0, 7);
            this.tpnlTilemaps.Controls.Add(this.lblTilesetRangeTo, 1, 2);
            this.tpnlTilemaps.Controls.Add(this.btnTilemapRemove, 0, 6);
            this.tpnlTilemaps.Controls.Add(this.nudTilesetExportStart, 0, 2);
            this.tpnlTilemaps.Controls.Add(this.btnTilemapDuplicate, 0, 5);
            this.tpnlTilemaps.Controls.Add(this.lblTileType, 0, 0);
            this.tpnlTilemaps.Controls.Add(this.btnTilemapImport, 0, 3);
            this.tpnlTilemaps.Controls.Add(this.nudTileType, 2, 0);
            this.tpnlTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemaps.Location = new System.Drawing.Point(12, 19);
            this.tpnlTilemaps.Name = "tpnlTilemaps";
            this.tpnlTilemaps.RowCount = 10;
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemaps.Size = new System.Drawing.Size(172, 448);
            this.tpnlTilemaps.TabIndex = 2;
            // 
            // btnTilemapUpdate
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnTilemapUpdate, 3);
            this.btnTilemapUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilemapUpdate.Location = new System.Drawing.Point(2, 92);
            this.btnTilemapUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTilemapUpdate.Name = "btnTilemapUpdate";
            this.btnTilemapUpdate.Size = new System.Drawing.Size(168, 24);
            this.btnTilemapUpdate.TabIndex = 31;
            this.btnTilemapUpdate.Text = "Update Tilemap";
            this.btnTilemapUpdate.UseVisualStyleBackColor = true;
            this.btnTilemapUpdate.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnExport
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnExport, 3);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(2, 188);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 24);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lstTilemaps
            // 
            this.tpnlTilemaps.SetColumnSpan(this.lstTilemaps, 3);
            this.lstTilemaps.DisableHighlighting = false;
            this.lstTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilemaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilemaps.FormattingEnabled = true;
            this.lstTilemaps.HorizontalExtent = 162;
            this.lstTilemaps.IntegralHeight = false;
            this.lstTilemaps.Location = new System.Drawing.Point(3, 215);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(166, 230);
            this.lstTilemaps.TabIndex = 1;
            this.lstTilemaps.TextOffsetX = 2;
            this.lstTilemaps.TextOffsetY = 0;
            this.lstTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstTilemaps_SelectedIndexChanged);
            // 
            // nudTilesetExportEnd
            // 
            this.nudTilesetExportEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTilesetExportEnd.Location = new System.Drawing.Point(100, 44);
            this.nudTilesetExportEnd.Margin = new System.Windows.Forms.Padding(2);
            this.nudTilesetExportEnd.Maximum = new decimal(new int[] {
            447,
            0,
            0,
            0});
            this.nudTilesetExportEnd.Name = "nudTilesetExportEnd";
            this.nudTilesetExportEnd.Size = new System.Drawing.Size(70, 22);
            this.nudTilesetExportEnd.TabIndex = 26;
            this.nudTilesetExportEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTilesetExportRange
            // 
            this.lblTilesetExportRange.AutoSize = true;
            this.tpnlTilemaps.SetColumnSpan(this.lblTilesetExportRange, 3);
            this.lblTilesetExportRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesetExportRange.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilesetExportRange.Location = new System.Drawing.Point(2, 26);
            this.lblTilesetExportRange.Margin = new System.Windows.Forms.Padding(2);
            this.lblTilesetExportRange.Name = "lblTilesetExportRange";
            this.lblTilesetExportRange.Size = new System.Drawing.Size(168, 14);
            this.lblTilesetExportRange.TabIndex = 27;
            this.lblTilesetExportRange.Text = "Tileset Tile Export Range:";
            this.lblTilesetExportRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTilemapOptions
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnTilemapOptions, 3);
            this.btnTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilemapOptions.Location = new System.Drawing.Point(2, 164);
            this.btnTilemapOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTilemapOptions.Name = "btnTilemapOptions";
            this.btnTilemapOptions.Size = new System.Drawing.Size(168, 24);
            this.btnTilemapOptions.TabIndex = 20;
            this.btnTilemapOptions.Text = "Tilemap Options";
            this.btnTilemapOptions.UseVisualStyleBackColor = true;
            this.btnTilemapOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTilesetRangeTo
            // 
            this.lblTilesetRangeTo.AutoSize = true;
            this.lblTilesetRangeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesetRangeTo.Location = new System.Drawing.Point(75, 44);
            this.lblTilesetRangeTo.Margin = new System.Windows.Forms.Padding(2);
            this.lblTilesetRangeTo.Name = "lblTilesetRangeTo";
            this.lblTilesetRangeTo.Size = new System.Drawing.Size(21, 22);
            this.lblTilesetRangeTo.TabIndex = 24;
            this.lblTilesetRangeTo.Text = "to";
            this.lblTilesetRangeTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTilemapRemove
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnTilemapRemove, 3);
            this.btnTilemapRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilemapRemove.Location = new System.Drawing.Point(2, 140);
            this.btnTilemapRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTilemapRemove.Name = "btnTilemapRemove";
            this.btnTilemapRemove.Size = new System.Drawing.Size(168, 24);
            this.btnTilemapRemove.TabIndex = 23;
            this.btnTilemapRemove.Text = "Remove Tilemap";
            this.btnTilemapRemove.UseVisualStyleBackColor = true;
            this.btnTilemapRemove.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // nudTilesetExportStart
            // 
            this.nudTilesetExportStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTilesetExportStart.Location = new System.Drawing.Point(2, 44);
            this.nudTilesetExportStart.Margin = new System.Windows.Forms.Padding(2);
            this.nudTilesetExportStart.Maximum = new decimal(new int[] {
            447,
            0,
            0,
            0});
            this.nudTilesetExportStart.Name = "nudTilesetExportStart";
            this.nudTilesetExportStart.Size = new System.Drawing.Size(69, 22);
            this.nudTilesetExportStart.TabIndex = 25;
            // 
            // btnTilemapDuplicate
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnTilemapDuplicate, 3);
            this.btnTilemapDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilemapDuplicate.Location = new System.Drawing.Point(2, 116);
            this.btnTilemapDuplicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTilemapDuplicate.Name = "btnTilemapDuplicate";
            this.btnTilemapDuplicate.Size = new System.Drawing.Size(168, 24);
            this.btnTilemapDuplicate.TabIndex = 22;
            this.btnTilemapDuplicate.Text = "Duplicate Tilemap";
            this.btnTilemapDuplicate.UseVisualStyleBackColor = true;
            this.btnTilemapDuplicate.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTileType
            // 
            this.lblTileType.AutoSize = true;
            this.tpnlTilemaps.SetColumnSpan(this.lblTileType, 2);
            this.lblTileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileType.Location = new System.Drawing.Point(2, 2);
            this.lblTileType.Margin = new System.Windows.Forms.Padding(2);
            this.lblTileType.Name = "lblTileType";
            this.lblTileType.Size = new System.Drawing.Size(94, 20);
            this.lblTileType.TabIndex = 30;
            this.lblTileType.Text = "Tile Type Value:";
            this.lblTileType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTilemapImport
            // 
            this.tpnlTilemaps.SetColumnSpan(this.btnTilemapImport, 3);
            this.btnTilemapImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilemapImport.Location = new System.Drawing.Point(2, 68);
            this.btnTilemapImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTilemapImport.Name = "btnTilemapImport";
            this.btnTilemapImport.Size = new System.Drawing.Size(168, 24);
            this.btnTilemapImport.TabIndex = 21;
            this.btnTilemapImport.Text = "Import New Tilemap";
            this.btnTilemapImport.UseVisualStyleBackColor = true;
            this.btnTilemapImport.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // nudTileType
            // 
            this.nudTileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTileType.Location = new System.Drawing.Point(100, 2);
            this.nudTileType.Margin = new System.Windows.Forms.Padding(2);
            this.nudTileType.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudTileType.Name = "nudTileType";
            this.nudTileType.Size = new System.Drawing.Size(70, 22);
            this.nudTileType.TabIndex = 29;
            this.nudTileType.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.lblCreateTilemap);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(567, 479);
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
            this.tabMain.Size = new System.Drawing.Size(567, 479);
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
            this.tabTilemap.Size = new System.Drawing.Size(559, 453);
            this.tabTilemap.TabIndex = 0;
            this.tabTilemap.Text = "Tilemap";
            // 
            // tpnlTilemap
            // 
            this.tpnlTilemap.ColumnCount = 2;
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tpnlTilemap.Controls.Add(this.pnlTilemap, 0, 0);
            this.tpnlTilemap.Controls.Add(this.tabTilemapOptions, 1, 0);
            this.tpnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemap.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilemap.Name = "tpnlTilemap";
            this.tpnlTilemap.RowCount = 1;
            this.tpnlTilemap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemap.Size = new System.Drawing.Size(553, 447);
            this.tpnlTilemap.TabIndex = 0;
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.Controls.Add(this.pnlTilemapEdit);
            this.pnlTilemap.Controls.Add(this.tpnlTilemapInfo);
            this.pnlTilemap.Controls.Add(this.pnlTilemapToolbar);
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.Location = new System.Drawing.Point(0, 0);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(355, 447);
            this.pnlTilemap.TabIndex = 5;
            // 
            // pnlTilemapEdit
            // 
            this.pnlTilemapEdit.AreaGridSize = new System.Drawing.Size(32, 24);
            this.pnlTilemapEdit.AutoScroll = true;
            this.pnlTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(355, 319);
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
            this.pnlTilemapEdit.Location = new System.Drawing.Point(0, 71);
            this.pnlTilemapEdit.MinimumScale = 1;
            this.pnlTilemapEdit.Name = "pnlTilemapEdit";
            this.pnlTilemapEdit.Offset = 0;
            this.pnlTilemapEdit.ShowIndexes = false;
            this.pnlTilemapEdit.Size = new System.Drawing.Size(355, 319);
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
            this.mnuFlipX,
            this.mnuFlipY,
            this.toolStripMenuItem1,
            this.mnuTilemapFromSelection,
            this.mnuSelectionToTilemap,
            this.mnuCropTilemap,
            this.toolStripMenuItem5,
            this.mnuExportSelectedIds,
            this.mnuExportSelectedIndexes});
            this.mnuSelectOptions.Name = "mnuSelectOptions";
            this.mnuSelectOptions.Size = new System.Drawing.Size(200, 440);
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
            this.mnuExportAsSGBinary.Enabled = false;
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
            // tpnlTilemapInfo
            // 
            this.tpnlTilemapInfo.ColumnCount = 1;
            this.tpnlTilemapInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilemapInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilemapInfo.Controls.Add(this.lblPosition, 0, 0);
            this.tpnlTilemapInfo.Controls.Add(this.lblTile, 0, 1);
            this.tpnlTilemapInfo.Controls.Add(this.lblSelection, 0, 2);
            this.tpnlTilemapInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpnlTilemapInfo.Location = new System.Drawing.Point(0, 390);
            this.tpnlTilemapInfo.Name = "tpnlTilemapInfo";
            this.tpnlTilemapInfo.RowCount = 3;
            this.tpnlTilemapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapInfo.Size = new System.Drawing.Size(355, 57);
            this.tpnlTilemapInfo.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(2, 2);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(351, 14);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position: N/A";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTile
            // 
            this.lblTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTile.Location = new System.Drawing.Point(2, 20);
            this.lblTile.Margin = new System.Windows.Forms.Padding(2);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(351, 14);
            this.lblTile.TabIndex = 5;
            this.lblTile.Text = "Tile: N/A";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelection
            // 
            this.lblSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelection.Location = new System.Drawing.Point(2, 38);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(2);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(351, 17);
            this.lblSelection.TabIndex = 32;
            this.lblSelection.Text = "Selection: N/A";
            this.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlTilemapToolbar.Size = new System.Drawing.Size(355, 71);
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
            this.rbTilemapPalette.Location = new System.Drawing.Point(3, 26);
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
            this.rbTilemapTileType.Location = new System.Drawing.Point(66, 26);
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
            this.chkTilemapGrid.Location = new System.Drawing.Point(116, 27);
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
            this.chkTilemapAreaGrid.Location = new System.Drawing.Point(170, 26);
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
            this.chkTilemapInvertGrids.Location = new System.Drawing.Point(250, 26);
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
            this.chkTilemapShowTileAs.Location = new System.Drawing.Point(3, 51);
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
            this.panel8.Location = new System.Drawing.Point(84, 47);
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
            // tabTilemapOptions
            // 
            this.tabTilemapOptions.Controls.Add(this.tabTilemapTiles);
            this.tabTilemapOptions.Controls.Add(this.tabTileGrids);
            this.tabTilemapOptions.Controls.Add(this.tabEntities);
            this.tabTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTilemapOptions.Location = new System.Drawing.Point(358, 3);
            this.tabTilemapOptions.Name = "tabTilemapOptions";
            this.tabTilemapOptions.SelectedIndex = 0;
            this.tabTilemapOptions.Size = new System.Drawing.Size(192, 441);
            this.tabTilemapOptions.TabIndex = 6;
            this.tabTilemapOptions.SelectedIndexChanged += new System.EventHandler(this.tabTilemap_SelectedIndexChanged);
            // 
            // tabTilemapTiles
            // 
            this.tabTilemapTiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemapTiles.Controls.Add(this.tpnlTilemapOptions);
            this.tabTilemapTiles.Location = new System.Drawing.Point(4, 22);
            this.tabTilemapTiles.Name = "tabTilemapTiles";
            this.tabTilemapTiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemapTiles.Size = new System.Drawing.Size(184, 415);
            this.tabTilemapTiles.TabIndex = 0;
            this.tabTilemapTiles.Text = "Tiles";
            // 
            // tpnlTilemapOptions
            // 
            this.tpnlTilemapOptions.ColumnCount = 4;
            this.tpnlTilemapOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlTilemapOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlTilemapOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlTilemapOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlTilemapOptions.Controls.Add(this.tabTileOptions, 0, 11);
            this.tpnlTilemapOptions.Controls.Add(this.pnlSelectedTileID, 0, 10);
            this.tpnlTilemapOptions.Controls.Add(this.nudAreaGridRows, 3, 9);
            this.tpnlTilemapOptions.Controls.Add(this.label3, 2, 9);
            this.tpnlTilemapOptions.Controls.Add(this.label4, 0, 9);
            this.tpnlTilemapOptions.Controls.Add(this.btnSelectionOptions, 0, 0);
            this.tpnlTilemapOptions.Controls.Add(this.nudAreaGridCols, 1, 9);
            this.tpnlTilemapOptions.Controls.Add(this.lblName, 0, 1);
            this.tpnlTilemapOptions.Controls.Add(this.txtName, 0, 2);
            this.tpnlTilemapOptions.Controls.Add(this.lblTilemapCompression, 0, 3);
            this.tpnlTilemapOptions.Controls.Add(this.chkUseAttributes, 0, 7);
            this.tpnlTilemapOptions.Controls.Add(this.cbTilemapCompression, 0, 4);
            this.tpnlTilemapOptions.Controls.Add(this.label2, 0, 8);
            this.tpnlTilemapOptions.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tpnlTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemapOptions.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilemapOptions.Name = "tpnlTilemapOptions";
            this.tpnlTilemapOptions.RowCount = 12;
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapOptions.Size = new System.Drawing.Size(178, 409);
            this.tpnlTilemapOptions.TabIndex = 5;
            // 
            // tabTileOptions
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.tabTileOptions, 4);
            this.tabTileOptions.Controls.Add(this.tabTilePalette);
            this.tabTileOptions.Controls.Add(this.tabTileList);
            this.tabTileOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTileOptions.Location = new System.Drawing.Point(2, 236);
            this.tabTileOptions.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.tabTileOptions.Name = "tabTileOptions";
            this.tabTileOptions.SelectedIndex = 0;
            this.tabTileOptions.Size = new System.Drawing.Size(174, 171);
            this.tabTileOptions.TabIndex = 22;
            this.tabTileOptions.SelectedIndexChanged += new System.EventHandler(this.tabTileOptions_SelectedIndexChanged);
            // 
            // tabTilePalette
            // 
            this.tabTilePalette.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilePalette.Controls.Add(this.pnlTiles);
            this.tabTilePalette.Location = new System.Drawing.Point(4, 22);
            this.tabTilePalette.Margin = new System.Windows.Forms.Padding(0);
            this.tabTilePalette.Name = "tabTilePalette";
            this.tabTilePalette.Size = new System.Drawing.Size(166, 145);
            this.tabTilePalette.TabIndex = 0;
            this.tabTilePalette.Text = "Tile Palette";
            // 
            // pnlTiles
            // 
            this.pnlTiles.AllowSelection = true;
            this.pnlTiles.AutoScroll = true;
            this.pnlTiles.AutoScrollMinSize = new System.Drawing.Size(447, 384);
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
            this.pnlTiles.InvertGridColor = false;
            this.pnlTiles.Location = new System.Drawing.Point(0, 0);
            this.pnlTiles.MinimumScale = 1;
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Offset = 0;
            this.pnlTiles.Size = new System.Drawing.Size(166, 145);
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
            // tabTileList
            // 
            this.tabTileList.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileList.Controls.Add(this.pnlTileList);
            this.tabTileList.Controls.Add(this.panel4);
            this.tabTileList.Location = new System.Drawing.Point(4, 22);
            this.tabTileList.Name = "tabTileList";
            this.tabTileList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileList.Size = new System.Drawing.Size(166, 145);
            this.tabTileList.TabIndex = 1;
            this.tabTileList.Text = "Tile Counts";
            // 
            // pnlTileList
            // 
            this.pnlTileList.AutoScroll = true;
            this.pnlTileList.AutoScrollMinSize = new System.Drawing.Size(160, 118);
            this.pnlTileList.BackColor = System.Drawing.Color.White;
            this.pnlTileList.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileList.Centered = false;
            this.pnlTileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileList.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileList.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileList.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileList.Image = null;
            this.pnlTileList.ImageAlpha = 1F;
            this.pnlTileList.ImageScale = 1;
            this.pnlTileList.Location = new System.Drawing.Point(3, 24);
            this.pnlTileList.MinimumScale = 1;
            this.pnlTileList.Name = "pnlTileList";
            this.pnlTileList.Size = new System.Drawing.Size(160, 118);
            this.pnlTileList.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileList.TabIndex = 1;
            this.pnlTileList.UseCanvas = false;
            this.pnlTileList.UseHatch = false;
            this.pnlTileList.UseMouseWheelScaling = false;
            this.pnlTileList.SelectedTileChanged += new SMSTileStudio.Controls.TileListControl.SelectedTileChangedHandler(this.pnlTileList_SelectedTileChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 21);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
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
            // pnlSelectedTileID
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.pnlSelectedTileID, 4);
            this.pnlSelectedTileID.Controls.Add(this.lblSelectedTileID);
            this.pnlSelectedTileID.Controls.Add(this.lblSelectedTileIDValue);
            this.pnlSelectedTileID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedTileID.Location = new System.Drawing.Point(0, 214);
            this.pnlSelectedTileID.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectedTileID.Name = "pnlSelectedTileID";
            this.pnlSelectedTileID.Size = new System.Drawing.Size(178, 18);
            this.pnlSelectedTileID.TabIndex = 22;
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
            // nudAreaGridRows
            // 
            this.nudAreaGridRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAreaGridRows.Location = new System.Drawing.Point(134, 192);
            this.nudAreaGridRows.Margin = new System.Windows.Forms.Padding(2);
            this.nudAreaGridRows.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAreaGridRows.Name = "nudAreaGridRows";
            this.nudAreaGridRows.Size = new System.Drawing.Size(42, 22);
            this.nudAreaGridRows.TabIndex = 34;
            this.nudAreaGridRows.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudAreaGridRows.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(90, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rows:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cols:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectionOptions
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.btnSelectionOptions, 4);
            this.btnSelectionOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectionOptions.Location = new System.Drawing.Point(2, 2);
            this.btnSelectionOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnSelectionOptions.Name = "btnSelectionOptions";
            this.btnSelectionOptions.Size = new System.Drawing.Size(174, 24);
            this.btnSelectionOptions.TabIndex = 22;
            this.btnSelectionOptions.Text = "Selection Options";
            this.btnSelectionOptions.UseVisualStyleBackColor = true;
            this.btnSelectionOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // nudAreaGridCols
            // 
            this.nudAreaGridCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAreaGridCols.Location = new System.Drawing.Point(46, 192);
            this.nudAreaGridCols.Margin = new System.Windows.Forms.Padding(2);
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
            // lblName
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.lblName, 4);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tilemap Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.txtName, 4);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(2, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblTilemapCompression
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.lblTilemapCompression, 4);
            this.lblTilemapCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilemapCompression.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilemapCompression.Location = new System.Drawing.Point(2, 70);
            this.lblTilemapCompression.Margin = new System.Windows.Forms.Padding(2);
            this.lblTilemapCompression.Name = "lblTilemapCompression";
            this.lblTilemapCompression.Size = new System.Drawing.Size(174, 14);
            this.lblTilemapCompression.TabIndex = 6;
            this.lblTilemapCompression.Text = "Compression:";
            this.lblTilemapCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUseAttributes
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.chkUseAttributes, 4);
            this.chkUseAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseAttributes.Location = new System.Drawing.Point(2, 156);
            this.chkUseAttributes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.chkUseAttributes.Name = "chkUseAttributes";
            this.chkUseAttributes.Size = new System.Drawing.Size(174, 16);
            this.chkUseAttributes.TabIndex = 14;
            this.chkUseAttributes.Text = "Use Tile Attributes";
            this.chkUseAttributes.UseVisualStyleBackColor = true;
            this.chkUseAttributes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // cbTilemapCompression
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.cbTilemapCompression, 4);
            this.cbTilemapCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilemapCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilemapCompression.FormattingEnabled = true;
            this.cbTilemapCompression.Location = new System.Drawing.Point(2, 88);
            this.cbTilemapCompression.Margin = new System.Windows.Forms.Padding(2);
            this.cbTilemapCompression.Name = "cbTilemapCompression";
            this.cbTilemapCompression.Size = new System.Drawing.Size(174, 21);
            this.cbTilemapCompression.TabIndex = 8;
            this.cbTilemapCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // label2
            // 
            this.tpnlTilemapOptions.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Area Grid:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tpnlTilemapOptions.SetColumnSpan(this.tableLayoutPanel3, 4);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblOffset, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblColumns, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.nudOffset, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudColumns, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudRows, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblRows, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tpnlTilemapOptions.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(178, 42);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // lblOffset
            // 
            this.lblOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOffset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffset.Location = new System.Drawing.Point(2, 2);
            this.lblOffset.Margin = new System.Windows.Forms.Padding(2);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(57, 14);
            this.lblOffset.TabIndex = 7;
            this.lblOffset.Text = "Offset:";
            this.lblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColumns
            // 
            this.lblColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColumns.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(61, 2);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(57, 14);
            this.lblColumns.TabIndex = 25;
            this.lblColumns.Text = "Columns:";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudOffset
            // 
            this.nudOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudOffset.Location = new System.Drawing.Point(2, 20);
            this.nudOffset.Margin = new System.Windows.Forms.Padding(2);
            this.nudOffset.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(57, 22);
            this.nudOffset.TabIndex = 9;
            this.nudOffset.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudColumns
            // 
            this.nudColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudColumns.Location = new System.Drawing.Point(63, 20);
            this.nudColumns.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudColumns.Size = new System.Drawing.Size(55, 22);
            this.nudColumns.TabIndex = 23;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudRows
            // 
            this.nudRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRows.Location = new System.Drawing.Point(122, 20);
            this.nudRows.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudRows.Size = new System.Drawing.Size(54, 22);
            this.nudRows.TabIndex = 24;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblRows
            // 
            this.lblRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(122, 2);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(54, 14);
            this.lblRows.TabIndex = 26;
            this.lblRows.Text = "Rows:";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTileGrids
            // 
            this.tabTileGrids.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileGrids.Controls.Add(this.tpnlTileGridOptions);
            this.tabTileGrids.Location = new System.Drawing.Point(4, 22);
            this.tabTileGrids.Name = "tabTileGrids";
            this.tabTileGrids.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileGrids.Size = new System.Drawing.Size(184, 415);
            this.tabTileGrids.TabIndex = 3;
            this.tabTileGrids.Text = "Tile Grids";
            // 
            // tpnlTileGridOptions
            // 
            this.tpnlTileGridOptions.ColumnCount = 2;
            this.tpnlTileGridOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlTileGridOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridRows, 1, 7);
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridColumns, 0, 7);
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridBytes, 0, 8);
            this.tpnlTileGridOptions.Controls.Add(this.lstTileGrids, 0, 9);
            this.tpnlTileGridOptions.Controls.Add(this.nudTileGridValue, 0, 6);
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridValue, 0, 5);
            this.tpnlTileGridOptions.Controls.Add(this.cbTileGridTileSize, 0, 4);
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridTileSize, 0, 3);
            this.tpnlTileGridOptions.Controls.Add(this.btnTileGridOptions, 0, 0);
            this.tpnlTileGridOptions.Controls.Add(this.lblTileGridName, 0, 1);
            this.tpnlTileGridOptions.Controls.Add(this.txtTileGridName, 0, 2);
            this.tpnlTileGridOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileGridOptions.Location = new System.Drawing.Point(3, 3);
            this.tpnlTileGridOptions.Name = "tpnlTileGridOptions";
            this.tpnlTileGridOptions.RowCount = 10;
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTileGridOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileGridOptions.Size = new System.Drawing.Size(178, 409);
            this.tpnlTileGridOptions.TabIndex = 24;
            // 
            // lblTileGridRows
            // 
            this.lblTileGridRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridRows.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridRows.Location = new System.Drawing.Point(91, 155);
            this.lblTileGridRows.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblTileGridRows.Name = "lblTileGridRows";
            this.lblTileGridRows.Size = new System.Drawing.Size(85, 13);
            this.lblTileGridRows.TabIndex = 46;
            this.lblTileGridRows.Text = "Rows: N/A";
            this.lblTileGridRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTileGridColumns
            // 
            this.lblTileGridColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridColumns.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridColumns.Location = new System.Drawing.Point(2, 155);
            this.lblTileGridColumns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblTileGridColumns.Name = "lblTileGridColumns";
            this.lblTileGridColumns.Size = new System.Drawing.Size(85, 13);
            this.lblTileGridColumns.TabIndex = 45;
            this.lblTileGridColumns.Text = "Columns: N/A";
            this.lblTileGridColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTileGridBytes
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.lblTileGridBytes, 2);
            this.lblTileGridBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridBytes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridBytes.Location = new System.Drawing.Point(2, 173);
            this.lblTileGridBytes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblTileGridBytes.Name = "lblTileGridBytes";
            this.lblTileGridBytes.Size = new System.Drawing.Size(174, 13);
            this.lblTileGridBytes.TabIndex = 44;
            this.lblTileGridBytes.Text = "Total Bytes: N/A";
            this.lblTileGridBytes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstTileGrids
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.lstTileGrids, 2);
            this.lstTileGrids.DisableHighlighting = false;
            this.lstTileGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTileGrids.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTileGrids.FormattingEnabled = true;
            this.lstTileGrids.HorizontalExtent = 170;
            this.lstTileGrids.IntegralHeight = false;
            this.lstTileGrids.Location = new System.Drawing.Point(2, 192);
            this.lstTileGrids.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lstTileGrids.Name = "lstTileGrids";
            this.lstTileGrids.Size = new System.Drawing.Size(174, 215);
            this.lstTileGrids.TabIndex = 32;
            this.lstTileGrids.TextOffsetX = 2;
            this.lstTileGrids.TextOffsetY = 0;
            this.lstTileGrids.SelectedIndexChanged += new System.EventHandler(this.lstTileGrids_SelectedIndexChanged);
            // 
            // nudTileGridValue
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.nudTileGridValue, 2);
            this.nudTileGridValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTileGridValue.Location = new System.Drawing.Point(2, 130);
            this.nudTileGridValue.Margin = new System.Windows.Forms.Padding(2);
            this.nudTileGridValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTileGridValue.Name = "nudTileGridValue";
            this.nudTileGridValue.Size = new System.Drawing.Size(174, 22);
            this.nudTileGridValue.TabIndex = 37;
            this.nudTileGridValue.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblTileGridValue
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.lblTileGridValue, 2);
            this.lblTileGridValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridValue.Location = new System.Drawing.Point(2, 112);
            this.lblTileGridValue.Margin = new System.Windows.Forms.Padding(2);
            this.lblTileGridValue.Name = "lblTileGridValue";
            this.lblTileGridValue.Size = new System.Drawing.Size(174, 14);
            this.lblTileGridValue.TabIndex = 36;
            this.lblTileGridValue.Text = "Value:";
            this.lblTileGridValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTileGridTileSize
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.cbTileGridTileSize, 2);
            this.cbTileGridTileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTileGridTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTileGridTileSize.FormattingEnabled = true;
            this.cbTileGridTileSize.Location = new System.Drawing.Point(2, 88);
            this.cbTileGridTileSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbTileGridTileSize.Name = "cbTileGridTileSize";
            this.cbTileGridTileSize.Size = new System.Drawing.Size(174, 21);
            this.cbTileGridTileSize.TabIndex = 43;
            this.cbTileGridTileSize.SelectedIndexChanged += new System.EventHandler(this.cbTileGridTileSize_SelectedIndexChanged);
            // 
            // lblTileGridTileSize
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.lblTileGridTileSize, 2);
            this.lblTileGridTileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridTileSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridTileSize.Location = new System.Drawing.Point(2, 70);
            this.lblTileGridTileSize.Margin = new System.Windows.Forms.Padding(2);
            this.lblTileGridTileSize.Name = "lblTileGridTileSize";
            this.lblTileGridTileSize.Size = new System.Drawing.Size(174, 14);
            this.lblTileGridTileSize.TabIndex = 42;
            this.lblTileGridTileSize.Text = "Tile Size:";
            this.lblTileGridTileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTileGridOptions
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.btnTileGridOptions, 2);
            this.btnTileGridOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTileGridOptions.Location = new System.Drawing.Point(2, 2);
            this.btnTileGridOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnTileGridOptions.Name = "btnTileGridOptions";
            this.btnTileGridOptions.Size = new System.Drawing.Size(174, 24);
            this.btnTileGridOptions.TabIndex = 35;
            this.btnTileGridOptions.Text = "Tile Grid Options";
            this.btnTileGridOptions.UseVisualStyleBackColor = true;
            this.btnTileGridOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblTileGridName
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.lblTileGridName, 2);
            this.lblTileGridName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileGridName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileGridName.Location = new System.Drawing.Point(2, 28);
            this.lblTileGridName.Margin = new System.Windows.Forms.Padding(2);
            this.lblTileGridName.Name = "lblTileGridName";
            this.lblTileGridName.Size = new System.Drawing.Size(174, 14);
            this.lblTileGridName.TabIndex = 33;
            this.lblTileGridName.Text = "Tile Grid Name:";
            this.lblTileGridName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTileGridName
            // 
            this.tpnlTileGridOptions.SetColumnSpan(this.txtTileGridName, 2);
            this.txtTileGridName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTileGridName.Location = new System.Drawing.Point(2, 46);
            this.txtTileGridName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTileGridName.MaxLength = 50;
            this.txtTileGridName.Name = "txtTileGridName";
            this.txtTileGridName.Size = new System.Drawing.Size(174, 22);
            this.txtTileGridName.TabIndex = 34;
            this.txtTileGridName.TextChanged += new System.EventHandler(this.txtTileGridName_TextChanged);
            // 
            // tabEntities
            // 
            this.tabEntities.BackColor = System.Drawing.SystemColors.Control;
            this.tabEntities.Controls.Add(this.tpnlEntityOptions);
            this.tabEntities.Location = new System.Drawing.Point(4, 22);
            this.tabEntities.Name = "tabEntities";
            this.tabEntities.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntities.Size = new System.Drawing.Size(184, 415);
            this.tabEntities.TabIndex = 2;
            this.tabEntities.Text = "Entities";
            // 
            // tpnlEntityOptions
            // 
            this.tpnlEntityOptions.ColumnCount = 4;
            this.tpnlEntityOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpnlEntityOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tpnlEntityOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpnlEntityOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tpnlEntityOptions.Controls.Add(this.lstEntities, 0, 7);
            this.tpnlEntityOptions.Controls.Add(this.nudEntityHeight, 3, 6);
            this.tpnlEntityOptions.Controls.Add(this.lblEntityHeight, 2, 6);
            this.tpnlEntityOptions.Controls.Add(this.nudEntityId, 1, 4);
            this.tpnlEntityOptions.Controls.Add(this.nudEntityY, 3, 5);
            this.tpnlEntityOptions.Controls.Add(this.nudEntityWidth, 1, 6);
            this.tpnlEntityOptions.Controls.Add(this.lblEntityWidth, 0, 6);
            this.tpnlEntityOptions.Controls.Add(this.txtEntityName, 0, 2);
            this.tpnlEntityOptions.Controls.Add(this.label6, 0, 4);
            this.tpnlEntityOptions.Controls.Add(this.button1, 0, 0);
            this.tpnlEntityOptions.Controls.Add(this.lblEntityY, 2, 5);
            this.tpnlEntityOptions.Controls.Add(this.label7, 0, 1);
            this.tpnlEntityOptions.Controls.Add(this.lblEntityX, 0, 5);
            this.tpnlEntityOptions.Controls.Add(this.nudEntityX, 1, 5);
            this.tpnlEntityOptions.Controls.Add(this.lblEntityProperties, 0, 3);
            this.tpnlEntityOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlEntityOptions.Location = new System.Drawing.Point(3, 3);
            this.tpnlEntityOptions.Name = "tpnlEntityOptions";
            this.tpnlEntityOptions.RowCount = 8;
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlEntityOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntityOptions.Size = new System.Drawing.Size(178, 409);
            this.tpnlEntityOptions.TabIndex = 7;
            this.tpnlEntityOptions.Visible = false;
            // 
            // lstEntities
            // 
            this.tpnlEntityOptions.SetColumnSpan(this.lstEntities, 4);
            this.lstEntities.DisableHighlighting = false;
            this.lstEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.HorizontalExtent = 168;
            this.lstEntities.IntegralHeight = false;
            this.lstEntities.Location = new System.Drawing.Point(3, 161);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(172, 245);
            this.lstEntities.TabIndex = 4;
            this.lstEntities.TextOffsetX = 2;
            this.lstEntities.TextOffsetY = 0;
            this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
            // 
            // nudEntityHeight
            // 
            this.nudEntityHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEntityHeight.Location = new System.Drawing.Point(116, 136);
            this.nudEntityHeight.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudEntityHeight.Size = new System.Drawing.Size(60, 22);
            this.nudEntityHeight.TabIndex = 31;
            this.nudEntityHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEntityHeight.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblEntityHeight
            // 
            this.lblEntityHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityHeight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityHeight.Location = new System.Drawing.Point(90, 136);
            this.lblEntityHeight.Margin = new System.Windows.Forms.Padding(2);
            this.lblEntityHeight.Name = "lblEntityHeight";
            this.lblEntityHeight.Size = new System.Drawing.Size(22, 20);
            this.lblEntityHeight.TabIndex = 30;
            this.lblEntityHeight.Text = "H:";
            this.lblEntityHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEntityId
            // 
            this.nudEntityId.Location = new System.Drawing.Point(28, 88);
            this.nudEntityId.Margin = new System.Windows.Forms.Padding(2);
            this.nudEntityId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEntityId.Name = "nudEntityId";
            this.nudEntityId.Size = new System.Drawing.Size(58, 22);
            this.nudEntityId.TabIndex = 40;
            this.nudEntityId.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudEntityY
            // 
            this.nudEntityY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEntityY.Location = new System.Drawing.Point(116, 112);
            this.nudEntityY.Margin = new System.Windows.Forms.Padding(2);
            this.nudEntityY.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityY.Name = "nudEntityY";
            this.nudEntityY.Size = new System.Drawing.Size(60, 22);
            this.nudEntityY.TabIndex = 35;
            this.nudEntityY.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // nudEntityWidth
            // 
            this.nudEntityWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEntityWidth.Location = new System.Drawing.Point(28, 136);
            this.nudEntityWidth.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudEntityWidth.Size = new System.Drawing.Size(58, 22);
            this.nudEntityWidth.TabIndex = 29;
            this.nudEntityWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEntityWidth.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblEntityWidth
            // 
            this.lblEntityWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityWidth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityWidth.Location = new System.Drawing.Point(2, 136);
            this.lblEntityWidth.Margin = new System.Windows.Forms.Padding(2);
            this.lblEntityWidth.Name = "lblEntityWidth";
            this.lblEntityWidth.Size = new System.Drawing.Size(22, 20);
            this.lblEntityWidth.TabIndex = 28;
            this.lblEntityWidth.Text = "W:";
            this.lblEntityWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEntityName
            // 
            this.tpnlEntityOptions.SetColumnSpan(this.txtEntityName, 4);
            this.txtEntityName.Location = new System.Drawing.Point(2, 46);
            this.txtEntityName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntityName.MaxLength = 50;
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(168, 22);
            this.txtEntityName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Id:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.tpnlEntityOptions.SetColumnSpan(this.button1, 4);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Remove Entity";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEntityY
            // 
            this.lblEntityY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityY.Location = new System.Drawing.Point(90, 112);
            this.lblEntityY.Margin = new System.Windows.Forms.Padding(2);
            this.lblEntityY.Name = "lblEntityY";
            this.lblEntityY.Size = new System.Drawing.Size(22, 20);
            this.lblEntityY.TabIndex = 34;
            this.lblEntityY.Text = "Y:";
            this.lblEntityY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.tpnlEntityOptions.SetColumnSpan(this.label7, 4);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "Entity Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntityX
            // 
            this.lblEntityX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityX.Location = new System.Drawing.Point(2, 112);
            this.lblEntityX.Margin = new System.Windows.Forms.Padding(2);
            this.lblEntityX.Name = "lblEntityX";
            this.lblEntityX.Size = new System.Drawing.Size(22, 20);
            this.lblEntityX.TabIndex = 32;
            this.lblEntityX.Text = "X:";
            this.lblEntityX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEntityX
            // 
            this.nudEntityX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEntityX.Location = new System.Drawing.Point(28, 112);
            this.nudEntityX.Margin = new System.Windows.Forms.Padding(2);
            this.nudEntityX.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEntityX.Name = "nudEntityX";
            this.nudEntityX.Size = new System.Drawing.Size(58, 22);
            this.nudEntityX.TabIndex = 33;
            this.nudEntityX.ValueChanged += new System.EventHandler(this.nudTilemap_ValueChanged);
            // 
            // lblEntityProperties
            // 
            this.tpnlEntityOptions.SetColumnSpan(this.lblEntityProperties, 4);
            this.lblEntityProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityProperties.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityProperties.Location = new System.Drawing.Point(2, 70);
            this.lblEntityProperties.Margin = new System.Windows.Forms.Padding(2);
            this.lblEntityProperties.Name = "lblEntityProperties";
            this.lblEntityProperties.Size = new System.Drawing.Size(174, 14);
            this.lblEntityProperties.TabIndex = 43;
            this.lblEntityProperties.Text = "Entity Properties:";
            // 
            // tabTileset
            // 
            this.tabTileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabTileset.Controls.Add(this.tpnlTileset);
            this.tabTileset.Location = new System.Drawing.Point(4, 22);
            this.tabTileset.Name = "tabTileset";
            this.tabTileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileset.Size = new System.Drawing.Size(559, 453);
            this.tabTileset.TabIndex = 1;
            this.tabTileset.Text = "Tileset";
            // 
            // tpnlTileset
            // 
            this.tpnlTileset.ColumnCount = 2;
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tpnlTileset.Controls.Add(this.pnlTileset, 0, 0);
            this.tpnlTileset.Controls.Add(this.tabTiles, 1, 0);
            this.tpnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileset.Location = new System.Drawing.Point(3, 3);
            this.tpnlTileset.Name = "tpnlTileset";
            this.tpnlTileset.RowCount = 1;
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTileset.Size = new System.Drawing.Size(553, 447);
            this.tpnlTileset.TabIndex = 0;
            // 
            // pnlTileset
            // 
            this.pnlTileset.Controls.Add(this.pnlTilesetEdit);
            this.pnlTileset.Controls.Add(this.flpnlTilesetTools);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(0, 0);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(356, 447);
            this.pnlTileset.TabIndex = 4;
            // 
            // pnlTilesetEdit
            // 
            this.pnlTilesetEdit.AutoScroll = true;
            this.pnlTilesetEdit.AutoScrollMinSize = new System.Drawing.Size(356, 423);
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
            this.pnlTilesetEdit.InvertGridColor = false;
            this.pnlTilesetEdit.Location = new System.Drawing.Point(0, 24);
            this.pnlTilesetEdit.MinimumScale = 1;
            this.pnlTilesetEdit.Name = "pnlTilesetEdit";
            this.pnlTilesetEdit.Size = new System.Drawing.Size(356, 423);
            this.pnlTilesetEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetEdit.TabIndex = 1;
            this.pnlTilesetEdit.TileID = -1;
            this.pnlTilesetEdit.TypeValue = 0;
            this.pnlTilesetEdit.UseCanvas = false;
            this.pnlTilesetEdit.UseGrid = true;
            this.pnlTilesetEdit.UseHatch = true;
            this.pnlTilesetEdit.UseMouseWheelScaling = true;
            this.pnlTilesetEdit.TileSelectionChanged += new SMSTileStudio.Controls.TilesetImageControl.TileSelectionHandler(this.pnlTilesetEdit_TileSelectionChanged);
            this.pnlTilesetEdit.TilesChanged += new SMSTileStudio.Controls.TilesetImageControl.TilesChangedHandler(this.pnlTilesetEdit_TilesChanged);
            // 
            // flpnlTilesetTools
            // 
            this.flpnlTilesetTools.Controls.Add(this.rbTilesetSelect);
            this.flpnlTilesetTools.Controls.Add(this.rbTilesetSwap);
            this.flpnlTilesetTools.Controls.Add(this.rbTilesetType);
            this.flpnlTilesetTools.Controls.Add(this.chkTilesetGrid);
            this.flpnlTilesetTools.Controls.Add(this.chkTilesetShowTileIds);
            this.flpnlTilesetTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpnlTilesetTools.Location = new System.Drawing.Point(0, 0);
            this.flpnlTilesetTools.Name = "flpnlTilesetTools";
            this.flpnlTilesetTools.Size = new System.Drawing.Size(356, 24);
            this.flpnlTilesetTools.TabIndex = 0;
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
            // tabTiles
            // 
            this.tabTiles.Controls.Add(this.tabTilesetOptions);
            this.tabTiles.Controls.Add(this.tabTags);
            this.tabTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTiles.Location = new System.Drawing.Point(359, 3);
            this.tabTiles.Name = "tabTiles";
            this.tabTiles.SelectedIndex = 0;
            this.tabTiles.Size = new System.Drawing.Size(191, 441);
            this.tabTiles.TabIndex = 5;
            // 
            // tabTilesetOptions
            // 
            this.tabTilesetOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilesetOptions.Controls.Add(this.tpnlTilesetOptions);
            this.tabTilesetOptions.Location = new System.Drawing.Point(4, 22);
            this.tabTilesetOptions.Name = "tabTilesetOptions";
            this.tabTilesetOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesetOptions.Size = new System.Drawing.Size(183, 415);
            this.tabTilesetOptions.TabIndex = 0;
            this.tabTilesetOptions.Text = "Tiles";
            // 
            // tpnlTilesetOptions
            // 
            this.tpnlTilesetOptions.ColumnCount = 2;
            this.tpnlTilesetOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlTilesetOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlTilesetOptions.Controls.Add(this.pnlSelectedTile, 0, 11);
            this.tpnlTilesetOptions.Controls.Add(this.btnTilesetOptions, 0, 0);
            this.tpnlTilesetOptions.Controls.Add(this.btnSwapSelectedPixel, 0, 12);
            this.tpnlTilesetOptions.Controls.Add(this.pnlSprPalette, 0, 9);
            this.tpnlTilesetOptions.Controls.Add(this.lblTilesetCompression, 0, 1);
            this.tpnlTilesetOptions.Controls.Add(this.lblSelectedTile, 0, 10);
            this.tpnlTilesetOptions.Controls.Add(this.pnlBGPalette, 0, 6);
            this.tpnlTilesetOptions.Controls.Add(this.cbTilesetCompression, 0, 2);
            this.tpnlTilesetOptions.Controls.Add(this.rbBgPalette, 0, 3);
            this.tpnlTilesetOptions.Controls.Add(this.cbSprPalette, 0, 8);
            this.tpnlTilesetOptions.Controls.Add(this.lblSprPalette, 0, 7);
            this.tpnlTilesetOptions.Controls.Add(this.rbSprPalette, 1, 3);
            this.tpnlTilesetOptions.Controls.Add(this.lblBgPalette, 0, 4);
            this.tpnlTilesetOptions.Controls.Add(this.cbBgPalette, 0, 5);
            this.tpnlTilesetOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilesetOptions.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilesetOptions.Name = "tpnlTilesetOptions";
            this.tpnlTilesetOptions.RowCount = 14;
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesetOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesetOptions.Size = new System.Drawing.Size(177, 409);
            this.tpnlTilesetOptions.TabIndex = 21;
            // 
            // pnlSelectedTile
            // 
            this.pnlSelectedTile.AutoScroll = true;
            this.pnlSelectedTile.AutoScrollMinSize = new System.Drawing.Size(144, 144);
            this.pnlSelectedTile.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSelectedTile.Centered = false;
            this.tpnlTilesetOptions.SetColumnSpan(this.pnlSelectedTile, 2);
            this.pnlSelectedTile.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSelectedTile.HatchForeColor = System.Drawing.Color.White;
            this.pnlSelectedTile.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSelectedTile.Image = null;
            this.pnlSelectedTile.ImageAlpha = 1F;
            this.pnlSelectedTile.ImageScale = 1;
            this.pnlSelectedTile.Location = new System.Drawing.Point(16, 270);
            this.pnlSelectedTile.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
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
            // btnTilesetOptions
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.btnTilesetOptions, 2);
            this.btnTilesetOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTilesetOptions.Location = new System.Drawing.Point(2, 2);
            this.btnTilesetOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnTilesetOptions.Name = "btnTilesetOptions";
            this.btnTilesetOptions.Size = new System.Drawing.Size(173, 24);
            this.btnTilesetOptions.TabIndex = 20;
            this.btnTilesetOptions.Text = "Tileset Options";
            this.btnTilesetOptions.UseVisualStyleBackColor = true;
            this.btnTilesetOptions.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnSwapSelectedPixel
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.btnSwapSelectedPixel, 2);
            this.btnSwapSelectedPixel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(2, 420);
            this.btnSwapSelectedPixel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(173, 24);
            this.btnSwapSelectedPixel.TabIndex = 17;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            this.btnSwapSelectedPixel.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // pnlSprPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.pnlSprPalette, 2);
            this.pnlSprPalette.Location = new System.Drawing.Point(2, 214);
            this.pnlSprPalette.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSprPalette.TabIndex = 19;
            this.pnlSprPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlSPRPalette_SelectedColorChanged);
            // 
            // lblTilesetCompression
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.lblTilesetCompression, 2);
            this.lblTilesetCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesetCompression.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilesetCompression.Location = new System.Drawing.Point(2, 28);
            this.lblTilesetCompression.Margin = new System.Windows.Forms.Padding(2);
            this.lblTilesetCompression.Name = "lblTilesetCompression";
            this.lblTilesetCompression.Size = new System.Drawing.Size(173, 14);
            this.lblTilesetCompression.TabIndex = 8;
            this.lblTilesetCompression.Text = "Compression:";
            this.lblTilesetCompression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedTile
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.lblSelectedTile, 2);
            this.lblSelectedTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedTile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTile.Location = new System.Drawing.Point(2, 256);
            this.lblSelectedTile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblSelectedTile.Name = "lblSelectedTile";
            this.lblSelectedTile.Size = new System.Drawing.Size(173, 12);
            this.lblSelectedTile.TabIndex = 12;
            this.lblSelectedTile.Text = "Selected Tile:";
            this.lblSelectedTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBGPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.pnlBGPalette, 2);
            this.pnlBGPalette.Location = new System.Drawing.Point(2, 130);
            this.pnlBGPalette.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 18;
            this.pnlBGPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteControl.SelectedColorChangedHandler(this.pnlBGPalette_SelectedColorChanged);
            // 
            // cbTilesetCompression
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.cbTilesetCompression, 2);
            this.cbTilesetCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilesetCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetCompression.FormattingEnabled = true;
            this.cbTilesetCompression.Location = new System.Drawing.Point(2, 46);
            this.cbTilesetCompression.Margin = new System.Windows.Forms.Padding(2);
            this.cbTilesetCompression.Name = "cbTilesetCompression";
            this.cbTilesetCompression.Size = new System.Drawing.Size(173, 21);
            this.cbTilesetCompression.TabIndex = 9;
            this.cbTilesetCompression.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // rbBgPalette
            // 
            this.rbBgPalette.AutoSize = true;
            this.rbBgPalette.Checked = true;
            this.rbBgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbBgPalette.Location = new System.Drawing.Point(2, 70);
            this.rbBgPalette.Margin = new System.Windows.Forms.Padding(2);
            this.rbBgPalette.Name = "rbBgPalette";
            this.rbBgPalette.Size = new System.Drawing.Size(84, 16);
            this.rbBgPalette.TabIndex = 9;
            this.rbBgPalette.TabStop = true;
            this.rbBgPalette.Text = "BG Palette";
            this.rbBgPalette.UseVisualStyleBackColor = true;
            this.rbBgPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // cbSprPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.cbSprPalette, 2);
            this.cbSprPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSprPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSprPalette.FormattingEnabled = true;
            this.cbSprPalette.Location = new System.Drawing.Point(2, 190);
            this.cbSprPalette.Margin = new System.Windows.Forms.Padding(2);
            this.cbSprPalette.Name = "cbSprPalette";
            this.cbSprPalette.Size = new System.Drawing.Size(173, 21);
            this.cbSprPalette.TabIndex = 7;
            this.cbSprPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblSprPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.lblSprPalette, 2);
            this.lblSprPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSprPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprPalette.Location = new System.Drawing.Point(2, 172);
            this.lblSprPalette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblSprPalette.Name = "lblSprPalette";
            this.lblSprPalette.Size = new System.Drawing.Size(173, 14);
            this.lblSprPalette.TabIndex = 6;
            this.lblSprPalette.Text = "Sprite Palette:";
            this.lblSprPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbSprPalette
            // 
            this.rbSprPalette.AutoSize = true;
            this.rbSprPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSprPalette.Location = new System.Drawing.Point(90, 70);
            this.rbSprPalette.Margin = new System.Windows.Forms.Padding(2);
            this.rbSprPalette.Name = "rbSprPalette";
            this.rbSprPalette.Size = new System.Drawing.Size(85, 16);
            this.rbSprPalette.TabIndex = 10;
            this.rbSprPalette.Text = "SPR Palette";
            this.rbSprPalette.UseVisualStyleBackColor = true;
            this.rbSprPalette.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // lblBgPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.lblBgPalette, 2);
            this.lblBgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBgPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBgPalette.Location = new System.Drawing.Point(2, 88);
            this.lblBgPalette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblBgPalette.Name = "lblBgPalette";
            this.lblBgPalette.Size = new System.Drawing.Size(173, 14);
            this.lblBgPalette.TabIndex = 4;
            this.lblBgPalette.Text = "Background Palette:";
            this.lblBgPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBgPalette
            // 
            this.tpnlTilesetOptions.SetColumnSpan(this.cbBgPalette, 2);
            this.cbBgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBgPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBgPalette.FormattingEnabled = true;
            this.cbBgPalette.Location = new System.Drawing.Point(2, 106);
            this.cbBgPalette.Margin = new System.Windows.Forms.Padding(2);
            this.cbBgPalette.Name = "cbBgPalette";
            this.cbBgPalette.Size = new System.Drawing.Size(173, 21);
            this.cbBgPalette.TabIndex = 5;
            this.cbBgPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // tabTags
            // 
            this.tabTags.BackColor = System.Drawing.SystemColors.Control;
            this.tabTags.Controls.Add(this.tpnlTagOptions);
            this.tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(183, 415);
            this.tabTags.TabIndex = 1;
            this.tabTags.Text = "Tags";
            // 
            // tpnlTagOptions
            // 
            this.tpnlTagOptions.ColumnCount = 1;
            this.tpnlTagOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTagOptions.Controls.Add(this.lstTags, 0, 8);
            this.tpnlTagOptions.Controls.Add(this.btnAddExistingTag, 0, 7);
            this.tpnlTagOptions.Controls.Add(this.btnBulkAddTag, 0, 1);
            this.tpnlTagOptions.Controls.Add(this.cbExistingTags, 0, 6);
            this.tpnlTagOptions.Controls.Add(this.btnRemoveTag, 0, 2);
            this.tpnlTagOptions.Controls.Add(this.lblExistingTag, 0, 5);
            this.tpnlTagOptions.Controls.Add(this.lblTagName, 0, 3);
            this.tpnlTagOptions.Controls.Add(this.txtTagName, 0, 4);
            this.tpnlTagOptions.Controls.Add(this.btnAddTag, 0, 0);
            this.tpnlTagOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTagOptions.Location = new System.Drawing.Point(3, 3);
            this.tpnlTagOptions.Name = "tpnlTagOptions";
            this.tpnlTagOptions.RowCount = 9;
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTagOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTagOptions.Size = new System.Drawing.Size(177, 409);
            this.tpnlTagOptions.TabIndex = 2;
            // 
            // lstTags
            // 
            this.lstTags.DisableHighlighting = false;
            this.lstTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTags.FormattingEnabled = true;
            this.lstTags.HorizontalExtent = 167;
            this.lstTags.IntegralHeight = false;
            this.lstTags.Location = new System.Drawing.Point(3, 191);
            this.lstTags.Name = "lstTags";
            this.lstTags.Size = new System.Drawing.Size(171, 215);
            this.lstTags.TabIndex = 5;
            this.lstTags.TextOffsetX = 2;
            this.lstTags.TextOffsetY = 0;
            // 
            // btnAddExistingTag
            // 
            this.btnAddExistingTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddExistingTag.Location = new System.Drawing.Point(2, 164);
            this.btnAddExistingTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnAddExistingTag.Name = "btnAddExistingTag";
            this.btnAddExistingTag.Size = new System.Drawing.Size(173, 24);
            this.btnAddExistingTag.TabIndex = 24;
            this.btnAddExistingTag.Text = "Add Existing Tag";
            this.btnAddExistingTag.UseVisualStyleBackColor = true;
            this.btnAddExistingTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnBulkAddTag
            // 
            this.btnBulkAddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBulkAddTag.Location = new System.Drawing.Point(2, 28);
            this.btnBulkAddTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnBulkAddTag.Name = "btnBulkAddTag";
            this.btnBulkAddTag.Size = new System.Drawing.Size(173, 24);
            this.btnBulkAddTag.TabIndex = 25;
            this.btnBulkAddTag.Text = "Bulk Add New Tag";
            this.btnBulkAddTag.UseVisualStyleBackColor = true;
            this.btnBulkAddTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // cbExistingTags
            // 
            this.cbExistingTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbExistingTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExistingTags.FormattingEnabled = true;
            this.cbExistingTags.Location = new System.Drawing.Point(2, 140);
            this.cbExistingTags.Margin = new System.Windows.Forms.Padding(2);
            this.cbExistingTags.Name = "cbExistingTags";
            this.cbExistingTags.Size = new System.Drawing.Size(173, 21);
            this.cbExistingTags.TabIndex = 23;
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveTag.Location = new System.Drawing.Point(2, 54);
            this.btnRemoveTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(173, 24);
            this.btnRemoveTag.TabIndex = 21;
            this.btnRemoveTag.Text = "Remove Tag";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // lblExistingTag
            // 
            this.lblExistingTag.AutoSize = true;
            this.lblExistingTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExistingTag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingTag.Location = new System.Drawing.Point(2, 122);
            this.lblExistingTag.Margin = new System.Windows.Forms.Padding(2);
            this.lblExistingTag.Name = "lblExistingTag";
            this.lblExistingTag.Size = new System.Drawing.Size(173, 14);
            this.lblExistingTag.TabIndex = 22;
            this.lblExistingTag.Text = "Existing Tag:";
            this.lblExistingTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTagName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagName.Location = new System.Drawing.Point(2, 80);
            this.lblTagName.Margin = new System.Windows.Forms.Padding(2);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(173, 14);
            this.lblTagName.TabIndex = 5;
            this.lblTagName.Text = "Tag Name:";
            this.lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTagName
            // 
            this.txtTagName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTagName.Location = new System.Drawing.Point(2, 98);
            this.txtTagName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(173, 22);
            this.txtTagName.TabIndex = 4;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTag.Location = new System.Drawing.Point(2, 2);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(173, 24);
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
            this.tabMetaTilemap.Size = new System.Drawing.Size(559, 453);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 447);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.pnlMetaTilemapEdit);
            this.panel11.Controls.Add(this.tableLayoutPanel4);
            this.panel11.Controls.Add(this.flowLayoutPanel2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(355, 447);
            this.panel11.TabIndex = 5;
            // 
            // pnlMetaTilemapEdit
            // 
            this.pnlMetaTilemapEdit.AutoScroll = true;
            this.pnlMetaTilemapEdit.AutoScrollMinSize = new System.Drawing.Size(355, 387);
            this.pnlMetaTilemapEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaTilemapEdit.Centered = true;
            this.pnlMetaTilemapEdit.ContextMenuStrip = this.mnuMetaTilemapOptions;
            this.pnlMetaTilemapEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTilemapEdit.EditMode = SMSTileStudio.Data.TileEditType.TileID;
            this.pnlMetaTilemapEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaTilemapEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaTilemapEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaTilemapEdit.Image = null;
            this.pnlMetaTilemapEdit.ImageAlpha = 1F;
            this.pnlMetaTilemapEdit.ImageScale = 1;
            this.pnlMetaTilemapEdit.InvertGridColor = false;
            this.pnlMetaTilemapEdit.Location = new System.Drawing.Point(0, 24);
            this.pnlMetaTilemapEdit.MetaTilemapIds = null;
            this.pnlMetaTilemapEdit.MetaTilemapProperties = "N/A";
            this.pnlMetaTilemapEdit.MetaTilemapSize = new System.Drawing.Size(0, 0);
            this.pnlMetaTilemapEdit.MetaTileSize = new System.Drawing.Size(0, 0);
            this.pnlMetaTilemapEdit.MinimumScale = 3;
            this.pnlMetaTilemapEdit.Name = "pnlMetaTilemapEdit";
            this.pnlMetaTilemapEdit.ShowIds = false;
            this.pnlMetaTilemapEdit.Size = new System.Drawing.Size(355, 387);
            this.pnlMetaTilemapEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaTilemapEdit.TabIndex = 33;
            this.pnlMetaTilemapEdit.TilemapImage = null;
            this.pnlMetaTilemapEdit.UseCanvas = false;
            this.pnlMetaTilemapEdit.UseGrid = true;
            this.pnlMetaTilemapEdit.UseHatch = true;
            this.pnlMetaTilemapEdit.UseMouseWheelScaling = true;
            // 
            // mnuMetaTilemapOptions
            // 
            this.mnuMetaTilemapOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMetaTilemapTilemapFromSelection,
            this.mnuMetaTilemapSelectionToTilemap,
            this.mnuMetaTilemapClearSelection});
            this.mnuMetaTilemapOptions.Name = "mnuMetaTilemapOptions";
            this.mnuMetaTilemapOptions.Size = new System.Drawing.Size(200, 70);
            // 
            // mnuMetaTilemapTilemapFromSelection
            // 
            this.mnuMetaTilemapTilemapFromSelection.Name = "mnuMetaTilemapTilemapFromSelection";
            this.mnuMetaTilemapTilemapFromSelection.Size = new System.Drawing.Size(199, 22);
            this.mnuMetaTilemapTilemapFromSelection.Text = "Tilemap From Selection";
            this.mnuMetaTilemapTilemapFromSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMetaTilemapSelectionToTilemap
            // 
            this.mnuMetaTilemapSelectionToTilemap.Name = "mnuMetaTilemapSelectionToTilemap";
            this.mnuMetaTilemapSelectionToTilemap.Size = new System.Drawing.Size(199, 22);
            this.mnuMetaTilemapSelectionToTilemap.Text = "Selection To Tilemap";
            this.mnuMetaTilemapSelectionToTilemap.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuMetaTilemapClearSelection
            // 
            this.mnuMetaTilemapClearSelection.Name = "mnuMetaTilemapClearSelection";
            this.mnuMetaTilemapClearSelection.Size = new System.Drawing.Size(199, 22);
            this.mnuMetaTilemapClearSelection.Text = "Clear Selection";
            this.mnuMetaTilemapClearSelection.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblMetaTilemapProperties, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblMetaTileProperties, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 411);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(355, 36);
            this.tableLayoutPanel4.TabIndex = 35;
            // 
            // lblMetaTilemapProperties
            // 
            this.lblMetaTilemapProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetaTilemapProperties.Location = new System.Drawing.Point(2, 20);
            this.lblMetaTilemapProperties.Margin = new System.Windows.Forms.Padding(2);
            this.lblMetaTilemapProperties.Name = "lblMetaTilemapProperties";
            this.lblMetaTilemapProperties.Size = new System.Drawing.Size(351, 14);
            this.lblMetaTilemapProperties.TabIndex = 4;
            this.lblMetaTilemapProperties.Text = "Meta Tilemap Properties: N/A";
            this.lblMetaTilemapProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMetaTileProperties
            // 
            this.lblMetaTileProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetaTileProperties.Location = new System.Drawing.Point(2, 2);
            this.lblMetaTileProperties.Margin = new System.Windows.Forms.Padding(2);
            this.lblMetaTileProperties.Name = "lblMetaTileProperties";
            this.lblMetaTileProperties.Size = new System.Drawing.Size(351, 14);
            this.lblMetaTileProperties.TabIndex = 6;
            this.lblMetaTileProperties.Text = "Meta Tile Properties: N/A";
            this.lblMetaTileProperties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.rbMetaTilemapBrush);
            this.flowLayoutPanel2.Controls.Add(this.rbMetaTilemapSelect);
            this.flowLayoutPanel2.Controls.Add(this.chkMetaTilemapShowGrid);
            this.flowLayoutPanel2.Controls.Add(this.chkMetaTilemapShowIds);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(355, 24);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // rbMetaTilemapBrush
            // 
            this.rbMetaTilemapBrush.AutoSize = true;
            this.rbMetaTilemapBrush.Enabled = false;
            this.rbMetaTilemapBrush.Location = new System.Drawing.Point(3, 3);
            this.rbMetaTilemapBrush.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTilemapBrush.Name = "rbMetaTilemapBrush";
            this.rbMetaTilemapBrush.Size = new System.Drawing.Size(55, 17);
            this.rbMetaTilemapBrush.TabIndex = 0;
            this.rbMetaTilemapBrush.Text = "Brush";
            this.tipMain.SetToolTip(this.rbMetaTilemapBrush, "Brush (B)");
            this.rbMetaTilemapBrush.UseVisualStyleBackColor = true;
            this.rbMetaTilemapBrush.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbMetaTilemapSelect
            // 
            this.rbMetaTilemapSelect.AutoSize = true;
            this.rbMetaTilemapSelect.Checked = true;
            this.rbMetaTilemapSelect.Location = new System.Drawing.Point(61, 3);
            this.rbMetaTilemapSelect.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTilemapSelect.Name = "rbMetaTilemapSelect";
            this.rbMetaTilemapSelect.Size = new System.Drawing.Size(55, 17);
            this.rbMetaTilemapSelect.TabIndex = 1;
            this.rbMetaTilemapSelect.TabStop = true;
            this.rbMetaTilemapSelect.Text = "Select";
            this.tipMain.SetToolTip(this.rbMetaTilemapSelect, "Select (S)");
            this.rbMetaTilemapSelect.UseVisualStyleBackColor = true;
            this.rbMetaTilemapSelect.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // chkMetaTilemapShowGrid
            // 
            this.chkMetaTilemapShowGrid.AutoSize = true;
            this.chkMetaTilemapShowGrid.Checked = true;
            this.chkMetaTilemapShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaTilemapShowGrid.Location = new System.Drawing.Point(119, 4);
            this.chkMetaTilemapShowGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkMetaTilemapShowGrid.Name = "chkMetaTilemapShowGrid";
            this.chkMetaTilemapShowGrid.Size = new System.Drawing.Size(48, 17);
            this.chkMetaTilemapShowGrid.TabIndex = 12;
            this.chkMetaTilemapShowGrid.Text = "Grid";
            this.tipMain.SetToolTip(this.chkMetaTilemapShowGrid, "Toggle Grid (G)");
            this.chkMetaTilemapShowGrid.UseVisualStyleBackColor = true;
            this.chkMetaTilemapShowGrid.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkMetaTilemapShowIds
            // 
            this.chkMetaTilemapShowIds.AutoSize = true;
            this.chkMetaTilemapShowIds.Location = new System.Drawing.Point(173, 4);
            this.chkMetaTilemapShowIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.chkMetaTilemapShowIds.Name = "chkMetaTilemapShowIds";
            this.chkMetaTilemapShowIds.Size = new System.Drawing.Size(122, 17);
            this.chkMetaTilemapShowIds.TabIndex = 13;
            this.chkMetaTilemapShowIds.Text = "Show Meta Tile Ids";
            this.tipMain.SetToolTip(this.chkMetaTilemapShowIds, "Toggle Meta Tile Ids (I)");
            this.chkMetaTilemapShowIds.UseVisualStyleBackColor = true;
            this.chkMetaTilemapShowIds.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(358, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(192, 441);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(184, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meta Tiles";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlMetaTilesEdit, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.chkMetaTilesShowHexValues, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pnlMetaTileTools, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.chkMetaTileApplyEditsByTileId, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbMetaTileSize, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMetaTileSize, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMetaTileOptions, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(178, 409);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pnlMetaTilesEdit
            // 
            this.pnlMetaTilesEdit.ApplyEditsToAllMetaTiles = true;
            this.pnlMetaTilesEdit.AutoScroll = true;
            this.pnlMetaTilesEdit.AutoScrollMinSize = new System.Drawing.Size(471, 612);
            this.pnlMetaTilesEdit.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaTilesEdit.Centered = true;
            this.tableLayoutPanel2.SetColumnSpan(this.pnlMetaTilesEdit, 2);
            this.pnlMetaTilesEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTilesEdit.EditMode = SMSTileStudio.Data.TileEditType.TileID;
            this.pnlMetaTilesEdit.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaTilesEdit.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaTilesEdit.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaTilesEdit.Image = null;
            this.pnlMetaTilesEdit.ImageAlpha = 1F;
            this.pnlMetaTilesEdit.ImageScale = 3;
            this.pnlMetaTilesEdit.InvertGridColor = false;
            this.pnlMetaTilesEdit.Location = new System.Drawing.Point(2, 186);
            this.pnlMetaTilesEdit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMetaTilesEdit.MetaTileProperties = "N/A";
            this.pnlMetaTilesEdit.MetaTiles = null;
            this.pnlMetaTilesEdit.MinimumScale = 1;
            this.pnlMetaTilesEdit.Name = "pnlMetaTilesEdit";
            this.pnlMetaTilesEdit.ShowHexValues = false;
            this.pnlMetaTilesEdit.Size = new System.Drawing.Size(174, 221);
            this.pnlMetaTilesEdit.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaTilesEdit.TabIndex = 22;
            this.pnlMetaTilesEdit.TypeValue = ((byte)(0));
            this.pnlMetaTilesEdit.UseCanvas = false;
            this.pnlMetaTilesEdit.UseHatch = true;
            this.pnlMetaTilesEdit.UseMouseWheelScaling = false;
            this.pnlMetaTilesEdit.MetaTileChanged += new SMSTileStudio.Controls.MetaTilesControl.MetaTileChangedHandler(this.pnlMetaTilesEdit_MetaTileChanged);
            // 
            // chkMetaTilesShowHexValues
            // 
            this.chkMetaTilesShowHexValues.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chkMetaTilesShowHexValues, 2);
            this.chkMetaTilesShowHexValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMetaTilesShowHexValues.Location = new System.Drawing.Point(2, 94);
            this.chkMetaTilesShowHexValues.Margin = new System.Windows.Forms.Padding(2);
            this.chkMetaTilesShowHexValues.Name = "chkMetaTilesShowHexValues";
            this.chkMetaTilesShowHexValues.Size = new System.Drawing.Size(174, 20);
            this.chkMetaTilesShowHexValues.TabIndex = 39;
            this.chkMetaTilesShowHexValues.Text = "Show Hex for Ids / Values";
            this.chkMetaTilesShowHexValues.UseVisualStyleBackColor = true;
            this.chkMetaTilesShowHexValues.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // pnlMetaTileTools
            // 
            this.pnlMetaTileTools.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.pnlMetaTileTools, 2);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTileIds);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTileValue);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTilePriority);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTilePalette);
            this.pnlMetaTileTools.Controls.Add(this.rbMetaTileType);
            this.pnlMetaTileTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaTileTools.Location = new System.Drawing.Point(2, 136);
            this.pnlMetaTileTools.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMetaTileTools.Name = "pnlMetaTileTools";
            this.pnlMetaTileTools.Size = new System.Drawing.Size(174, 46);
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
            // rbMetaTileValue
            // 
            this.rbMetaTileValue.AutoSize = true;
            this.rbMetaTileValue.Location = new System.Drawing.Point(46, 3);
            this.rbMetaTileValue.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTileValue.Name = "rbMetaTileValue";
            this.rbMetaTileValue.Size = new System.Drawing.Size(58, 17);
            this.rbMetaTileValue.TabIndex = 39;
            this.rbMetaTileValue.Text = "Values";
            this.rbMetaTileValue.UseVisualStyleBackColor = true;
            this.rbMetaTileValue.Visible = false;
            this.rbMetaTileValue.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // rbMetaTilePriority
            // 
            this.rbMetaTilePriority.AutoSize = true;
            this.rbMetaTilePriority.Location = new System.Drawing.Point(107, 3);
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
            this.rbMetaTilePalette.Location = new System.Drawing.Point(3, 26);
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
            this.rbMetaTileType.Location = new System.Drawing.Point(66, 26);
            this.rbMetaTileType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.rbMetaTileType.Name = "rbMetaTileType";
            this.rbMetaTileType.Size = new System.Drawing.Size(47, 17);
            this.rbMetaTileType.TabIndex = 31;
            this.rbMetaTileType.Text = "Type";
            this.rbMetaTileType.UseVisualStyleBackColor = true;
            this.rbMetaTileType.CheckedChanged += new System.EventHandler(this.rbTilemap_CheckedChanged);
            // 
            // chkMetaTileApplyEditsByTileId
            // 
            this.chkMetaTileApplyEditsByTileId.AutoSize = true;
            this.chkMetaTileApplyEditsByTileId.Checked = true;
            this.chkMetaTileApplyEditsByTileId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.chkMetaTileApplyEditsByTileId, 2);
            this.chkMetaTileApplyEditsByTileId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMetaTileApplyEditsByTileId.Location = new System.Drawing.Point(2, 70);
            this.chkMetaTileApplyEditsByTileId.Margin = new System.Windows.Forms.Padding(2);
            this.chkMetaTileApplyEditsByTileId.Name = "chkMetaTileApplyEditsByTileId";
            this.chkMetaTileApplyEditsByTileId.Size = new System.Drawing.Size(174, 20);
            this.chkMetaTileApplyEditsByTileId.TabIndex = 39;
            this.chkMetaTileApplyEditsByTileId.Text = "Apply edits by Tile Id";
            this.chkMetaTileApplyEditsByTileId.UseVisualStyleBackColor = true;
            this.chkMetaTileApplyEditsByTileId.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // cbMetaTileSize
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cbMetaTileSize, 2);
            this.cbMetaTileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMetaTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetaTileSize.FormattingEnabled = true;
            this.cbMetaTileSize.Location = new System.Drawing.Point(2, 46);
            this.cbMetaTileSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbMetaTileSize.Name = "cbMetaTileSize";
            this.cbMetaTileSize.Size = new System.Drawing.Size(174, 21);
            this.cbMetaTileSize.TabIndex = 45;
            // 
            // lblMetaTileSize
            // 
            this.lblMetaTileSize.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMetaTileSize, 2);
            this.lblMetaTileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMetaTileSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaTileSize.Location = new System.Drawing.Point(2, 28);
            this.lblMetaTileSize.Margin = new System.Windows.Forms.Padding(2);
            this.lblMetaTileSize.Name = "lblMetaTileSize";
            this.lblMetaTileSize.Size = new System.Drawing.Size(174, 14);
            this.lblMetaTileSize.TabIndex = 44;
            this.lblMetaTileSize.Text = "Meta Tile Size:";
            this.lblMetaTileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMetaTileOptions
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnMetaTileOptions, 2);
            this.btnMetaTileOptions.ContextMenuStrip = this.mnuMetaTileOptions;
            this.btnMetaTileOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMetaTileOptions.Location = new System.Drawing.Point(2, 2);
            this.btnMetaTileOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnMetaTileOptions.Name = "btnMetaTileOptions";
            this.btnMetaTileOptions.Size = new System.Drawing.Size(174, 24);
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
            this.mnuGSLibExportFormat,
            this.mnuExportMetaTilemap,
            this.mnuExportMetaTiles,
            this.mnuExportAllMetaData});
            this.mnuMetaTileOptions.Name = "mnuMetaTileOptions";
            this.mnuMetaTileOptions.Size = new System.Drawing.Size(198, 142);
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
            // mnuGSLibExportFormat
            // 
            this.mnuGSLibExportFormat.Checked = true;
            this.mnuGSLibExportFormat.CheckOnClick = true;
            this.mnuGSLibExportFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuGSLibExportFormat.Name = "mnuGSLibExportFormat";
            this.mnuGSLibExportFormat.Size = new System.Drawing.Size(197, 22);
            this.mnuGSLibExportFormat.Text = "GSLib Export Format";
            // 
            // mnuExportMetaTilemap
            // 
            this.mnuExportMetaTilemap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportMetaTilemapBinary});
            this.mnuExportMetaTilemap.Name = "mnuExportMetaTilemap";
            this.mnuExportMetaTilemap.Size = new System.Drawing.Size(197, 22);
            this.mnuExportMetaTilemap.Text = "Export Meta Tilemap";
            // 
            // mnuExportMetaTilemapBinary
            // 
            this.mnuExportMetaTilemapBinary.Name = "mnuExportMetaTilemapBinary";
            this.mnuExportMetaTilemapBinary.Size = new System.Drawing.Size(157, 22);
            this.mnuExportMetaTilemapBinary.Text = "Export as Binary";
            this.mnuExportMetaTilemapBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportMetaTiles
            // 
            this.mnuExportMetaTiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportMetaTilesBinary,
            this.mnuExportMetaTilesImage});
            this.mnuExportMetaTiles.Name = "mnuExportMetaTiles";
            this.mnuExportMetaTiles.Size = new System.Drawing.Size(197, 22);
            this.mnuExportMetaTiles.Text = "Export Meta Tiles";
            // 
            // mnuExportMetaTilesBinary
            // 
            this.mnuExportMetaTilesBinary.Name = "mnuExportMetaTilesBinary";
            this.mnuExportMetaTilesBinary.Size = new System.Drawing.Size(157, 22);
            this.mnuExportMetaTilesBinary.Text = "Export as Binary";
            this.mnuExportMetaTilesBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportMetaTilesImage
            // 
            this.mnuExportMetaTilesImage.Name = "mnuExportMetaTilesImage";
            this.mnuExportMetaTilesImage.Size = new System.Drawing.Size(157, 22);
            this.mnuExportMetaTilesImage.Text = "Export as Image";
            this.mnuExportMetaTilesImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuExportAllMetaData
            // 
            this.mnuExportAllMetaData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportAllMetaDataBinary});
            this.mnuExportAllMetaData.Name = "mnuExportAllMetaData";
            this.mnuExportAllMetaData.Size = new System.Drawing.Size(197, 22);
            this.mnuExportAllMetaData.Text = "Export All Meta Data";
            // 
            // mnuExportAllMetaDataBinary
            // 
            this.mnuExportAllMetaDataBinary.Name = "mnuExportAllMetaDataBinary";
            this.mnuExportAllMetaDataBinary.Size = new System.Drawing.Size(157, 22);
            this.mnuExportAllMetaDataBinary.Text = "Export as Binary";
            this.mnuExportAllMetaDataBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // label5
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 14);
            this.label5.TabIndex = 46;
            this.label5.Text = "Meta Tile Edit Tools:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateTilemap
            // 
            this.lblCreateTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateTilemap.Location = new System.Drawing.Point(0, 0);
            this.lblCreateTilemap.Name = "lblCreateTilemap";
            this.lblCreateTilemap.Size = new System.Drawing.Size(567, 479);
            this.lblCreateTilemap.TabIndex = 1;
            this.lblCreateTilemap.Text = "Create or select a tilemap to edit";
            this.lblCreateTilemap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(764, 26);
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
            this.mnuPaletteExportImage,
            this.mnuPaletteExportBinary,
            this.mnuPaletteExportHex,
            this.mnuPaletteExportAssembly});
            this.mnuExportPalette.Name = "mnuExportPalette";
            this.mnuExportPalette.Size = new System.Drawing.Size(153, 22);
            this.mnuExportPalette.Text = "Export Palette";
            // 
            // mnuPaletteExportImage
            // 
            this.mnuPaletteExportImage.Name = "mnuPaletteExportImage";
            this.mnuPaletteExportImage.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportImage.Text = "Export as Image";
            this.mnuPaletteExportImage.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuPaletteExportBinary
            // 
            this.mnuPaletteExportBinary.Name = "mnuPaletteExportBinary";
            this.mnuPaletteExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportBinary.Text = "Export as Binary";
            this.mnuPaletteExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuPaletteExportHex
            // 
            this.mnuPaletteExportHex.Name = "mnuPaletteExportHex";
            this.mnuPaletteExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuPaletteExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuPaletteExportAssembly
            // 
            this.mnuPaletteExportAssembly.Name = "mnuPaletteExportAssembly";
            this.mnuPaletteExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuPaletteExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuPaletteExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            this.mnuExportSGBinary.Enabled = false;
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
            // mnuTilesetOptions
            // 
            this.mnuTilesetOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTilesetUpdate,
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
            this.mnuTilesetOptions.Size = new System.Drawing.Size(206, 236);
            // 
            // mnuTilesetUpdate
            // 
            this.mnuTilesetUpdate.Enabled = false;
            this.mnuTilesetUpdate.Name = "mnuTilesetUpdate";
            this.mnuTilesetUpdate.Size = new System.Drawing.Size(205, 22);
            this.mnuTilesetUpdate.Text = "Update Tileset";
            this.mnuTilesetUpdate.Click += new System.EventHandler(this.mnuTilemap_Click);
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
            this.mnuExportTileGrid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTileGridExportBinary,
            this.toolStripMenuItem9,
            this.mnuTileGridExportUseOneDeminsionalArray,
            this.mnuTileGridExportDecimal,
            this.mnuTileGridExportHex,
            this.mnuTileGridExportAssembly});
            this.mnuExportTileGrid.Name = "mnuExportTileGrid";
            this.mnuExportTileGrid.Size = new System.Drawing.Size(171, 22);
            this.mnuExportTileGrid.Text = "Export Tile Grid";
            // 
            // mnuTileGridExportBinary
            // 
            this.mnuTileGridExportBinary.Name = "mnuTileGridExportBinary";
            this.mnuTileGridExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuTileGridExportBinary.Text = "Export as Binary";
            this.mnuTileGridExportBinary.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuTileGridExportUseOneDeminsionalArray
            // 
            this.mnuTileGridExportUseOneDeminsionalArray.Checked = true;
            this.mnuTileGridExportUseOneDeminsionalArray.CheckOnClick = true;
            this.mnuTileGridExportUseOneDeminsionalArray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuTileGridExportUseOneDeminsionalArray.Name = "mnuTileGridExportUseOneDeminsionalArray";
            this.mnuTileGridExportUseOneDeminsionalArray.Size = new System.Drawing.Size(238, 22);
            this.mnuTileGridExportUseOneDeminsionalArray.Text = "Use One Dimensional Array";
            // 
            // mnuTileGridExportDecimal
            // 
            this.mnuTileGridExportDecimal.Name = "mnuTileGridExportDecimal";
            this.mnuTileGridExportDecimal.Size = new System.Drawing.Size(238, 22);
            this.mnuTileGridExportDecimal.Text = "Export as Decimal (Clipboard)";
            this.mnuTileGridExportDecimal.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTileGridExportHex
            // 
            this.mnuTileGridExportHex.Name = "mnuTileGridExportHex";
            this.mnuTileGridExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuTileGridExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuTileGridExportHex.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuTileGridExportAssembly
            // 
            this.mnuTileGridExportAssembly.Name = "mnuTileGridExportAssembly";
            this.mnuTileGridExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuTileGridExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuTileGridExportAssembly.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuFlipX
            // 
            this.mnuFlipX.Name = "mnuFlipX";
            this.mnuFlipX.Size = new System.Drawing.Size(199, 22);
            this.mnuFlipX.Text = "Flip Horizontal";
            this.mnuFlipX.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // mnuFlipY
            // 
            this.mnuFlipY.Name = "mnuFlipY";
            this.mnuFlipY.Size = new System.Drawing.Size(199, 22);
            this.mnuFlipY.Text = "Flip Vertical";
            this.mnuFlipY.Click += new System.EventHandler(this.mnuTilemap_Click);
            // 
            // AssetTilemapControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetTilemapControl";
            this.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.ResumeLayout(false);
            this.grpImageList.ResumeLayout(false);
            this.tpnlTilemaps.ResumeLayout(false);
            this.tpnlTilemaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTilesetExportStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileType)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabTilemap.ResumeLayout(false);
            this.tpnlTilemap.ResumeLayout(false);
            this.pnlTilemap.ResumeLayout(false);
            this.pnlTilemap.PerformLayout();
            this.mnuSelectOptions.ResumeLayout(false);
            this.tpnlTilemapInfo.ResumeLayout(false);
            this.pnlTilemapToolbar.ResumeLayout(false);
            this.pnlTilemapToolbar.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabTilemapOptions.ResumeLayout(false);
            this.tabTilemapTiles.ResumeLayout(false);
            this.tpnlTilemapOptions.ResumeLayout(false);
            this.tpnlTilemapOptions.PerformLayout();
            this.tabTileOptions.ResumeLayout(false);
            this.tabTilePalette.ResumeLayout(false);
            this.tabTileList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlSelectedTileID.ResumeLayout(false);
            this.pnlSelectedTileID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaGridCols)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.tabTileGrids.ResumeLayout(false);
            this.tpnlTileGridOptions.ResumeLayout(false);
            this.tpnlTileGridOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileGridValue)).EndInit();
            this.tabEntities.ResumeLayout(false);
            this.tpnlEntityOptions.ResumeLayout(false);
            this.tpnlEntityOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntityX)).EndInit();
            this.tabTileset.ResumeLayout(false);
            this.tpnlTileset.ResumeLayout(false);
            this.pnlTileset.ResumeLayout(false);
            this.flpnlTilesetTools.ResumeLayout(false);
            this.flpnlTilesetTools.PerformLayout();
            this.tabTiles.ResumeLayout(false);
            this.tabTilesetOptions.ResumeLayout(false);
            this.tpnlTilesetOptions.ResumeLayout(false);
            this.tpnlTilesetOptions.PerformLayout();
            this.tabTags.ResumeLayout(false);
            this.tpnlTagOptions.ResumeLayout(false);
            this.tpnlTagOptions.PerformLayout();
            this.tabMetaTilemap.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.mnuMetaTilemapOptions.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlMetaTileTools.ResumeLayout(false);
            this.pnlMetaTileTools.PerformLayout();
            this.mnuMetaTileOptions.ResumeLayout(false);
            this.mnuExport.ResumeLayout(false);
            this.mnuTilesetOptions.ResumeLayout(false);
            this.mnuTilemapOptions.ResumeLayout(false);
            this.mnuTileGridOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpImageList;
        private ListBoxControl lstTilemaps;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTilemap;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemap;
        private System.Windows.Forms.TabPage tabTileset;
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
        private System.Windows.Forms.TabControl tabTilemapOptions;
        private System.Windows.Forms.TabPage tabTilemapTiles;
        private System.Windows.Forms.TabPage tabEntities;
        private ListBoxControl lstEntities;
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
        private System.Windows.Forms.Panel pnlSelectedTileID;
        private System.Windows.Forms.TabPage tabTileList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbTilesetType;
        private System.Windows.Forms.NumericUpDown nudTileType;
        private System.Windows.Forms.RadioButton rbTilemapTileType;
        private System.Windows.Forms.Label lblTileType;
        private System.Windows.Forms.Panel pnlTileset;
        private System.Windows.Forms.FlowLayoutPanel flpnlTilesetTools;
        private System.Windows.Forms.ToolStripMenuItem mnuClearSelection;
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
        private System.Windows.Forms.Button btnTilemapImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTilemapInvertGrids;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuExportImagesFromAreaGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinariesFromAreaGrid;
        private System.Windows.Forms.TabPage tabMetaTilemap;
        private System.Windows.Forms.ToolStripMenuItem mnuExportTileGrid;
        private System.Windows.Forms.TabControl tabTiles;
        private System.Windows.Forms.TabPage tabTilesetOptions;
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
        private ListBoxControl lstTags;
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
        private System.Windows.Forms.Label lblMetaTilemapProperties;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.ToolStripMenuItem mnuGSLibExportFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetaTilemapBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetaTilesBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportMetaTilesImage;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAllMetaDataBinary;
        private System.Windows.Forms.CheckBox chkMetaTilesShowHexValues;
        private System.Windows.Forms.RadioButton rbMetaTileValue;
        private System.Windows.Forms.ContextMenuStrip mnuMetaTilemapOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapTilemapFromSelection;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapClearSelection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbMetaTilemapBrush;
        private System.Windows.Forms.RadioButton rbMetaTilemapSelect;
        private System.Windows.Forms.CheckBox chkMetaTilemapShowGrid;
        private System.Windows.Forms.CheckBox chkMetaTilemapShowIds;
        private System.Windows.Forms.ToolStripMenuItem mnuMetaTilemapSelectionToTilemap;
        private System.Windows.Forms.TableLayoutPanel tpnlTilesetOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemapOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tpnlTileGridOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlEntityOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemapInfo;
        private System.Windows.Forms.Label lblEntityProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tpnlTagOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemaps;
        private System.Windows.Forms.Label lblTileGridBytes;
        private System.Windows.Forms.Label lblTileGridRows;
        private System.Windows.Forms.Label lblTileGridColumns;
        private TileListControl pnlTileList;
        private System.Windows.Forms.ToolStripMenuItem mnuTileGridExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuTileGridExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuTileGridExportAssembly;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem mnuTileGridExportDecimal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileGridExportUseOneDeminsionalArray;
        private System.Windows.Forms.Button btnTilemapUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuTilesetUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuFlipX;
        private System.Windows.Forms.ToolStripMenuItem mnuFlipY;
    }
}
