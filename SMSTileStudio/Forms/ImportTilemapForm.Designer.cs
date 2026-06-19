namespace SMSTileStudio.Forms
{
    partial class ImportTilemapForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.cbSPRPalette = new System.Windows.Forms.ComboBox();
            this.lblBgPalette = new System.Windows.Forms.Label();
            this.cbBGPalette = new System.Windows.Forms.ComboBox();
            this.lblFlippingOptions = new System.Windows.Forms.Label();
            this.cbFlipOptions = new System.Windows.Forms.ComboBox();
            this.btnSetAllSPRPalette = new System.Windows.Forms.Button();
            this.btnSetAllBGPalette = new System.Windows.Forms.Button();
            this.chkShowIndexes = new System.Windows.Forms.CheckBox();
            this.chkAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpTileset = new System.Windows.Forms.GroupBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTileCount = new System.Windows.Forms.Label();
            this.tpnlTilemapOptions = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlImage = new SMSTileStudio.Controls.TilemapImageControl();
            this.pnlTileset = new SMSTileStudio.Controls.PixelTileControl();
            this.pnlPalettes = new SMSTileStudio.Controls.PaletteTilemapControl();
            this.tpnlMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpImage.SuspendLayout();
            this.grpTileset.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tpnlTilemapOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 3;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tpnlMain.Controls.Add(this.grpOptions, 0, 0);
            this.tpnlMain.Controls.Add(this.grpImage, 1, 0);
            this.tpnlMain.Controls.Add(this.grpTileset, 2, 0);
            this.tpnlMain.Controls.Add(this.pnlPalettes, 1, 1);
            this.tpnlMain.Controls.Add(this.pnlButtons, 2, 2);
            this.tpnlMain.Controls.Add(this.lblTileCount, 0, 2);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(10, 10);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(757, 596);
            this.tpnlMain.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.tpnlTilemapOptions);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(8);
            this.tpnlMain.SetRowSpan(this.grpOptions, 2);
            this.grpOptions.Size = new System.Drawing.Size(185, 564);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Tilemap Options";
            // 
            // lblSprPalette
            // 
            this.lblSprPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSprPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprPalette.Location = new System.Drawing.Point(2, 136);
            this.lblSprPalette.Margin = new System.Windows.Forms.Padding(2);
            this.lblSprPalette.Name = "lblSprPalette";
            this.lblSprPalette.Size = new System.Drawing.Size(165, 14);
            this.lblSprPalette.TabIndex = 22;
            this.lblSprPalette.Text = "Sprite Palette:";
            this.lblSprPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSPRPalette
            // 
            this.cbSPRPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPRPalette.FormattingEnabled = true;
            this.cbSPRPalette.Location = new System.Drawing.Point(2, 154);
            this.cbSPRPalette.Margin = new System.Windows.Forms.Padding(2);
            this.cbSPRPalette.Name = "cbSPRPalette";
            this.cbSPRPalette.Size = new System.Drawing.Size(165, 21);
            this.cbSPRPalette.TabIndex = 23;
            this.cbSPRPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblBgPalette
            // 
            this.lblBgPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBgPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBgPalette.Location = new System.Drawing.Point(2, 50);
            this.lblBgPalette.Margin = new System.Windows.Forms.Padding(2);
            this.lblBgPalette.Name = "lblBgPalette";
            this.lblBgPalette.Size = new System.Drawing.Size(165, 14);
            this.lblBgPalette.TabIndex = 20;
            this.lblBgPalette.Text = "Background Palette:";
            this.lblBgPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBGPalette
            // 
            this.cbBGPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBGPalette.FormattingEnabled = true;
            this.cbBGPalette.Location = new System.Drawing.Point(2, 68);
            this.cbBGPalette.Margin = new System.Windows.Forms.Padding(2);
            this.cbBGPalette.Name = "cbBGPalette";
            this.cbBGPalette.Size = new System.Drawing.Size(165, 21);
            this.cbBGPalette.TabIndex = 21;
            this.cbBGPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblFlippingOptions
            // 
            this.lblFlippingOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlippingOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlippingOptions.Location = new System.Drawing.Point(2, 222);
            this.lblFlippingOptions.Margin = new System.Windows.Forms.Padding(2);
            this.lblFlippingOptions.Name = "lblFlippingOptions";
            this.lblFlippingOptions.Size = new System.Drawing.Size(165, 14);
            this.lblFlippingOptions.TabIndex = 11;
            this.lblFlippingOptions.Text = "Flipping Options:";
            // 
            // cbFlipOptions
            // 
            this.cbFlipOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFlipOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlipOptions.FormattingEnabled = true;
            this.cbFlipOptions.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.cbFlipOptions.Location = new System.Drawing.Point(2, 240);
            this.cbFlipOptions.Margin = new System.Windows.Forms.Padding(2);
            this.cbFlipOptions.Name = "cbFlipOptions";
            this.cbFlipOptions.Size = new System.Drawing.Size(165, 21);
            this.cbFlipOptions.TabIndex = 12;
            this.cbFlipOptions.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // btnSetAllSPRPalette
            // 
            this.btnSetAllSPRPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetAllSPRPalette.Location = new System.Drawing.Point(2, 24);
            this.btnSetAllSPRPalette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSetAllSPRPalette.Name = "btnSetAllSPRPalette";
            this.btnSetAllSPRPalette.Size = new System.Drawing.Size(165, 24);
            this.btnSetAllSPRPalette.TabIndex = 10;
            this.btnSetAllSPRPalette.Text = "Set All Tiles To SPR Palette";
            this.btnSetAllSPRPalette.UseVisualStyleBackColor = true;
            this.btnSetAllSPRPalette.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnSetAllBGPalette
            // 
            this.btnSetAllBGPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetAllBGPalette.Location = new System.Drawing.Point(2, 0);
            this.btnSetAllBGPalette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSetAllBGPalette.Name = "btnSetAllBGPalette";
            this.btnSetAllBGPalette.Size = new System.Drawing.Size(165, 24);
            this.btnSetAllBGPalette.TabIndex = 9;
            this.btnSetAllBGPalette.Text = "Set All Tiles To BG Palette";
            this.btnSetAllBGPalette.UseVisualStyleBackColor = true;
            this.btnSetAllBGPalette.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // chkShowIndexes
            // 
            this.chkShowIndexes.AutoSize = true;
            this.chkShowIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkShowIndexes.Location = new System.Drawing.Point(2, 312);
            this.chkShowIndexes.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowIndexes.Name = "chkShowIndexes";
            this.chkShowIndexes.Size = new System.Drawing.Size(165, 20);
            this.chkShowIndexes.TabIndex = 15;
            this.chkShowIndexes.Text = "Show Palette Indexes";
            this.chkShowIndexes.UseVisualStyleBackColor = true;
            this.chkShowIndexes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkAllowDuplicates
            // 
            this.chkAllowDuplicates.AutoSize = true;
            this.chkAllowDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAllowDuplicates.Location = new System.Drawing.Point(2, 288);
            this.chkAllowDuplicates.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllowDuplicates.Name = "chkAllowDuplicates";
            this.chkAllowDuplicates.Size = new System.Drawing.Size(165, 20);
            this.chkAllowDuplicates.TabIndex = 14;
            this.chkAllowDuplicates.Text = "Allow Duplicate Tiles";
            this.chkAllowDuplicates.UseVisualStyleBackColor = true;
            this.chkAllowDuplicates.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkIgnoreEmpty
            // 
            this.chkIgnoreEmpty.AutoSize = true;
            this.chkIgnoreEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIgnoreEmpty.Location = new System.Drawing.Point(2, 264);
            this.chkIgnoreEmpty.Margin = new System.Windows.Forms.Padding(2);
            this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
            this.chkIgnoreEmpty.Size = new System.Drawing.Size(165, 20);
            this.chkIgnoreEmpty.TabIndex = 13;
            this.chkIgnoreEmpty.Text = "Ignore Empty Tiles";
            this.chkIgnoreEmpty.UseVisualStyleBackColor = true;
            this.chkIgnoreEmpty.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.pnlImage);
            this.grpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImage.Location = new System.Drawing.Point(194, 3);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(8);
            this.grpImage.Size = new System.Drawing.Size(329, 359);
            this.grpImage.TabIndex = 1;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Original Image";
            // 
            // grpTileset
            // 
            this.grpTileset.Controls.Add(this.pnlTileset);
            this.grpTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTileset.Location = new System.Drawing.Point(529, 3);
            this.grpTileset.Name = "grpTileset";
            this.grpTileset.Padding = new System.Windows.Forms.Padding(8);
            this.grpTileset.Size = new System.Drawing.Size(225, 359);
            this.grpTileset.TabIndex = 2;
            this.grpTileset.TabStop = false;
            this.grpTileset.Text = "Tileset";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOk);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(526, 570);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(231, 26);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(132, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(36, 1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTileCount
            // 
            this.lblTileCount.AutoSize = true;
            this.tpnlMain.SetColumnSpan(this.lblTileCount, 2);
            this.lblTileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTileCount.Location = new System.Drawing.Point(3, 570);
            this.lblTileCount.Name = "lblTileCount";
            this.lblTileCount.Size = new System.Drawing.Size(520, 26);
            this.lblTileCount.TabIndex = 5;
            this.lblTileCount.Text = "Total Tile Count: 0";
            this.lblTileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpnlTilemapOptions
            // 
            this.tpnlTilemapOptions.ColumnCount = 1;
            this.tpnlTilemapOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapOptions.Controls.Add(this.btnSetAllBGPalette, 0, 0);
            this.tpnlTilemapOptions.Controls.Add(this.pnlSprPalette, 0, 7);
            this.tpnlTilemapOptions.Controls.Add(this.btnSetAllSPRPalette, 0, 1);
            this.tpnlTilemapOptions.Controls.Add(this.pnlBGPalette, 0, 4);
            this.tpnlTilemapOptions.Controls.Add(this.lblBgPalette, 0, 2);
            this.tpnlTilemapOptions.Controls.Add(this.cbSPRPalette, 0, 6);
            this.tpnlTilemapOptions.Controls.Add(this.chkShowIndexes, 0, 12);
            this.tpnlTilemapOptions.Controls.Add(this.cbFlipOptions, 0, 9);
            this.tpnlTilemapOptions.Controls.Add(this.chkAllowDuplicates, 0, 11);
            this.tpnlTilemapOptions.Controls.Add(this.lblFlippingOptions, 0, 8);
            this.tpnlTilemapOptions.Controls.Add(this.chkIgnoreEmpty, 0, 10);
            this.tpnlTilemapOptions.Controls.Add(this.lblSprPalette, 0, 5);
            this.tpnlTilemapOptions.Controls.Add(this.cbBGPalette, 0, 3);
            this.tpnlTilemapOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilemapOptions.Location = new System.Drawing.Point(8, 23);
            this.tpnlTilemapOptions.Name = "tpnlTilemapOptions";
            this.tpnlTilemapOptions.RowCount = 14;
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilemapOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilemapOptions.Size = new System.Drawing.Size(169, 533);
            this.tpnlTilemapOptions.TabIndex = 26;
            // 
            // pnlSprPalette
            // 
            this.pnlSprPalette.Location = new System.Drawing.Point(4, 178);
            this.pnlSprPalette.Margin = new System.Windows.Forms.Padding(4, 2, 5, 2);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(160, 40);
            this.pnlSprPalette.TabIndex = 25;
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(4, 92);
            this.pnlBGPalette.Margin = new System.Windows.Forms.Padding(4, 2, 5, 2);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(160, 40);
            this.pnlBGPalette.TabIndex = 24;
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.AutoScrollMinSize = new System.Drawing.Size(313, 328);
            this.pnlImage.Canvas = new System.Drawing.Size(8, 8);
            this.pnlImage.Centered = true;
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlImage.HatchForeColor = System.Drawing.Color.White;
            this.pnlImage.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlImage.Image = null;
            this.pnlImage.ImageAlpha = 1F;
            this.pnlImage.ImageScale = 1;
            this.pnlImage.Indexed = false;
            this.pnlImage.Location = new System.Drawing.Point(8, 23);
            this.pnlImage.MinimumScale = 1;
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.SelectedIndex = -1;
            this.pnlImage.Size = new System.Drawing.Size(313, 328);
            this.pnlImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlImage.TabIndex = 0;
            this.pnlImage.UseCanvas = false;
            this.pnlImage.UseHatch = true;
            this.pnlImage.UseMouseWheelScaling = true;
            this.pnlImage.SelectedIndexChanged += new SMSTileStudio.Controls.TilemapImageControl.SelectedIndexChangedHandler(this.pnlImage_SelectedIndexChanged);
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(576, 933);
            this.pnlTileset.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileset.Centered = false;
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileset.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileset.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageAlpha = 1F;
            this.pnlTileset.ImageScale = 3;
            this.pnlTileset.Indexed = false;
            this.pnlTileset.Location = new System.Drawing.Point(8, 23);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(209, 328);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 0;
            this.pnlTileset.UseCanvas = false;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = false;
            this.pnlTileset.SelectedIndexChanged += new SMSTileStudio.Controls.PixelTileControl.SelectedIndexChangedHandler(this.pnlTileset_SelectedIndexChanged);
            // 
            // pnlPalettes
            // 
            this.tpnlMain.SetColumnSpan(this.pnlPalettes, 2);
            this.pnlPalettes.Location = new System.Drawing.Point(194, 368);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(560, 199);
            this.pnlPalettes.TabIndex = 3;
            this.pnlPalettes.ColorShifted += new SMSTileStudio.Controls.PaletteTilemapControl.ColorShiftedHandler(this.pnlPalettes_ColorShifted);
            this.pnlPalettes.SelectedColorChanged += new SMSTileStudio.Controls.PaletteTilemapControl.SelectedColorChangedHandler(this.pnlPalettes_SelectedColorChanged);
            // 
            // ImportTilemapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 616);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ImportTilemapForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Graphics";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpImage.ResumeLayout(false);
            this.grpTileset.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.tpnlTilemapOptions.ResumeLayout(false);
            this.tpnlTilemapOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblFlippingOptions;
        private System.Windows.Forms.ComboBox cbFlipOptions;
        private System.Windows.Forms.Button btnSetAllSPRPalette;
        private System.Windows.Forms.Button btnSetAllBGPalette;
        private System.Windows.Forms.CheckBox chkShowIndexes;
        private System.Windows.Forms.CheckBox chkAllowDuplicates;
        private System.Windows.Forms.CheckBox chkIgnoreEmpty;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.GroupBox grpTileset;
        private Controls.PaletteTilemapControl pnlPalettes;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private Controls.TilemapImageControl pnlImage;
        private Controls.PixelTileControl pnlTileset;
        private Controls.PaletteControl pnlSprPalette;
        private Controls.PaletteControl pnlBGPalette;
        private System.Windows.Forms.Label lblSprPalette;
        private System.Windows.Forms.ComboBox cbSPRPalette;
        private System.Windows.Forms.Label lblBgPalette;
        private System.Windows.Forms.ComboBox cbBGPalette;
        private System.Windows.Forms.Label lblTileCount;
        private System.Windows.Forms.TableLayoutPanel tpnlTilemapOptions;
    }
}