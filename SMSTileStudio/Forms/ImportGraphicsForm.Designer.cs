namespace SMSTileStudio.Forms
{
    partial class ImportGraphicsForm
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
            this.pnlSPRPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlBGPalette = new SMSTileStudio.Controls.PaletteControl();
            this.lblSPRPalette = new System.Windows.Forms.Label();
            this.cbSPRPalette = new System.Windows.Forms.ComboBox();
            this.lblBGPalette = new System.Windows.Forms.Label();
            this.cbBGPalette = new System.Windows.Forms.ComboBox();
            this.chkPalettesFromImage = new System.Windows.Forms.CheckBox();
            this.lblFlippingOptions = new System.Windows.Forms.Label();
            this.cbFlipOptions = new System.Windows.Forms.ComboBox();
            this.btnSetAllSPRPalette = new System.Windows.Forms.Button();
            this.btnSetAllBGPalette = new System.Windows.Forms.Button();
            this.chkShowIndexes = new System.Windows.Forms.CheckBox();
            this.chkAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.chkIgnoreEmpty = new System.Windows.Forms.CheckBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.pnlImage = new SMSTileStudio.Controls.TilemapImageControl();
            this.grpTileset = new System.Windows.Forms.GroupBox();
            this.pnlTileset = new SMSTileStudio.Controls.PixelTileControl();
            this.pnlPalettes = new SMSTileStudio.Controls.PaletteTilemapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTileCount = new System.Windows.Forms.Label();
            this.tpnlMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpImage.SuspendLayout();
            this.grpTileset.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tpnlMain.Controls.Add(this.panel1, 2, 2);
            this.tpnlMain.Controls.Add(this.lblTileCount, 0, 2);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(10, 10);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.00679F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.99321F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(757, 596);
            this.tpnlMain.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.pnlSPRPalette);
            this.grpOptions.Controls.Add(this.pnlBGPalette);
            this.grpOptions.Controls.Add(this.lblSPRPalette);
            this.grpOptions.Controls.Add(this.cbSPRPalette);
            this.grpOptions.Controls.Add(this.lblBGPalette);
            this.grpOptions.Controls.Add(this.cbBGPalette);
            this.grpOptions.Controls.Add(this.chkPalettesFromImage);
            this.grpOptions.Controls.Add(this.lblFlippingOptions);
            this.grpOptions.Controls.Add(this.cbFlipOptions);
            this.grpOptions.Controls.Add(this.btnSetAllSPRPalette);
            this.grpOptions.Controls.Add(this.btnSetAllBGPalette);
            this.grpOptions.Controls.Add(this.chkShowIndexes);
            this.grpOptions.Controls.Add(this.chkAllowDuplicates);
            this.grpOptions.Controls.Add(this.chkIgnoreEmpty);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(8);
            this.tpnlMain.SetRowSpan(this.grpOptions, 2);
            this.grpOptions.Size = new System.Drawing.Size(185, 563);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Tilemap Options";
            // 
            // pnlSPRPalette
            // 
            this.pnlSPRPalette.Location = new System.Drawing.Point(8, 200);
            this.pnlSPRPalette.Name = "pnlSPRPalette";
            this.pnlSPRPalette.ReadOnly = false;
            this.pnlSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSPRPalette.TabIndex = 25;
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 112);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 24;
            // 
            // lblSPRPalette
            // 
            this.lblSPRPalette.AutoSize = true;
            this.lblSPRPalette.Location = new System.Drawing.Point(8, 156);
            this.lblSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSPRPalette.Name = "lblSPRPalette";
            this.lblSPRPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSPRPalette.TabIndex = 22;
            this.lblSPRPalette.Text = "Sprite Palette:";
            this.lblSPRPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSPRPalette
            // 
            this.cbSPRPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSPRPalette.FormattingEnabled = true;
            this.cbSPRPalette.Location = new System.Drawing.Point(8, 176);
            this.cbSPRPalette.Name = "cbSPRPalette";
            this.cbSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSPRPalette.TabIndex = 23;
            this.cbSPRPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // lblBGPalette
            // 
            this.lblBGPalette.AutoSize = true;
            this.lblBGPalette.Location = new System.Drawing.Point(8, 68);
            this.lblBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblBGPalette.Name = "lblBGPalette";
            this.lblBGPalette.Size = new System.Drawing.Size(110, 13);
            this.lblBGPalette.TabIndex = 20;
            this.lblBGPalette.Text = "Background Palette:";
            this.lblBGPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBGPalette
            // 
            this.cbBGPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBGPalette.FormattingEnabled = true;
            this.cbBGPalette.Location = new System.Drawing.Point(8, 88);
            this.cbBGPalette.Name = "cbBGPalette";
            this.cbBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbBGPalette.TabIndex = 21;
            this.cbBGPalette.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // chkPalettesFromImage
            // 
            this.chkPalettesFromImage.AutoSize = true;
            this.chkPalettesFromImage.Location = new System.Drawing.Point(8, 368);
            this.chkPalettesFromImage.Name = "chkPalettesFromImage";
            this.chkPalettesFromImage.Size = new System.Drawing.Size(129, 17);
            this.chkPalettesFromImage.TabIndex = 16;
            this.chkPalettesFromImage.Text = "Palettes From Image";
            this.chkPalettesFromImage.UseVisualStyleBackColor = true;
            // 
            // lblFlippingOptions
            // 
            this.lblFlippingOptions.AutoSize = true;
            this.lblFlippingOptions.Location = new System.Drawing.Point(8, 248);
            this.lblFlippingOptions.Name = "lblFlippingOptions";
            this.lblFlippingOptions.Size = new System.Drawing.Size(98, 13);
            this.lblFlippingOptions.TabIndex = 11;
            this.lblFlippingOptions.Text = "Flipping Options:";
            // 
            // cbFlipOptions
            // 
            this.cbFlipOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlipOptions.FormattingEnabled = true;
            this.cbFlipOptions.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.cbFlipOptions.Location = new System.Drawing.Point(8, 268);
            this.cbFlipOptions.Name = "cbFlipOptions";
            this.cbFlipOptions.Size = new System.Drawing.Size(168, 21);
            this.cbFlipOptions.TabIndex = 12;
            this.cbFlipOptions.SelectedIndexChanged += new System.EventHandler(this.cbTilemap_SelectedIndexChanged);
            // 
            // btnSetAllSPRPalette
            // 
            this.btnSetAllSPRPalette.Location = new System.Drawing.Point(8, 40);
            this.btnSetAllSPRPalette.Name = "btnSetAllSPRPalette";
            this.btnSetAllSPRPalette.Size = new System.Drawing.Size(168, 23);
            this.btnSetAllSPRPalette.TabIndex = 10;
            this.btnSetAllSPRPalette.Text = "Set All Tiles To SPR Palette";
            this.btnSetAllSPRPalette.UseVisualStyleBackColor = true;
            this.btnSetAllSPRPalette.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // btnSetAllBGPalette
            // 
            this.btnSetAllBGPalette.Location = new System.Drawing.Point(8, 16);
            this.btnSetAllBGPalette.Name = "btnSetAllBGPalette";
            this.btnSetAllBGPalette.Size = new System.Drawing.Size(168, 23);
            this.btnSetAllBGPalette.TabIndex = 9;
            this.btnSetAllBGPalette.Text = "Set All Tiles To BG Palette";
            this.btnSetAllBGPalette.UseVisualStyleBackColor = true;
            this.btnSetAllBGPalette.Click += new System.EventHandler(this.btnTilemap_Click);
            // 
            // chkShowIndexes
            // 
            this.chkShowIndexes.AutoSize = true;
            this.chkShowIndexes.Location = new System.Drawing.Point(8, 344);
            this.chkShowIndexes.Name = "chkShowIndexes";
            this.chkShowIndexes.Size = new System.Drawing.Size(135, 17);
            this.chkShowIndexes.TabIndex = 15;
            this.chkShowIndexes.Text = "Show Palette Indexes";
            this.chkShowIndexes.UseVisualStyleBackColor = true;
            this.chkShowIndexes.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkAllowDuplicates
            // 
            this.chkAllowDuplicates.AutoSize = true;
            this.chkAllowDuplicates.Location = new System.Drawing.Point(8, 320);
            this.chkAllowDuplicates.Name = "chkAllowDuplicates";
            this.chkAllowDuplicates.Size = new System.Drawing.Size(133, 17);
            this.chkAllowDuplicates.TabIndex = 14;
            this.chkAllowDuplicates.Text = "Allow Duplicate Tiles";
            this.chkAllowDuplicates.UseVisualStyleBackColor = true;
            this.chkAllowDuplicates.CheckedChanged += new System.EventHandler(this.chkTilemap_CheckedChanged);
            // 
            // chkIgnoreEmpty
            // 
            this.chkIgnoreEmpty.AutoSize = true;
            this.chkIgnoreEmpty.Location = new System.Drawing.Point(8, 296);
            this.chkIgnoreEmpty.Name = "chkIgnoreEmpty";
            this.chkIgnoreEmpty.Size = new System.Drawing.Size(120, 17);
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
            this.grpImage.Size = new System.Drawing.Size(329, 358);
            this.grpImage.TabIndex = 1;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Original Image";
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.AutoScrollMinSize = new System.Drawing.Size(313, 327);
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
            this.pnlImage.Size = new System.Drawing.Size(313, 327);
            this.pnlImage.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlImage.TabIndex = 0;
            this.pnlImage.UseCanvas = false;
            this.pnlImage.UseHatch = true;
            this.pnlImage.UseMouseWheelScaling = true;
            this.pnlImage.SelectedIndexChanged += new SMSTileStudio.Controls.TilemapImageControl.SelectedIndexChangedHandler(this.pnlImage_SelectedIndexChanged);
            // 
            // grpTileset
            // 
            this.grpTileset.Controls.Add(this.pnlTileset);
            this.grpTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTileset.Location = new System.Drawing.Point(529, 3);
            this.grpTileset.Name = "grpTileset";
            this.grpTileset.Padding = new System.Windows.Forms.Padding(8);
            this.grpTileset.Size = new System.Drawing.Size(225, 358);
            this.grpTileset.TabIndex = 2;
            this.grpTileset.TabStop = false;
            this.grpTileset.Text = "Tileset";
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(576, 930);
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
            this.pnlTileset.Size = new System.Drawing.Size(209, 327);
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
            this.pnlPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalettes.Location = new System.Drawing.Point(194, 367);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(560, 199);
            this.pnlPalettes.TabIndex = 3;
            this.pnlPalettes.ColorShifted += new SMSTileStudio.Controls.PaletteTilemapControl.ColorShiftedHandler(this.pnlPalettes_ColorShifted);
            this.pnlPalettes.SelectedColorChanged += new SMSTileStudio.Controls.PaletteTilemapControl.SelectedColorChangedHandler(this.pnlPalettes_SelectedColorChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(526, 569);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 27);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(132, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(36, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTileCount
            // 
            this.lblTileCount.AutoSize = true;
            this.tpnlMain.SetColumnSpan(this.lblTileCount, 2);
            this.lblTileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTileCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTileCount.Location = new System.Drawing.Point(3, 569);
            this.lblTileCount.Name = "lblTileCount";
            this.lblTileCount.Size = new System.Drawing.Size(520, 27);
            this.lblTileCount.TabIndex = 5;
            this.lblTileCount.Text = "Total Tile Count: 0";
            this.lblTileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportGraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 616);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportGraphicsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Graphics";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpImage.ResumeLayout(false);
            this.grpTileset.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Controls.TilemapImageControl pnlImage;
        private Controls.PixelTileControl pnlTileset;
        private System.Windows.Forms.CheckBox chkPalettesFromImage;
        private Controls.PaletteControl pnlSPRPalette;
        private Controls.PaletteControl pnlBGPalette;
        private System.Windows.Forms.Label lblSPRPalette;
        private System.Windows.Forms.ComboBox cbSPRPalette;
        private System.Windows.Forms.Label lblBGPalette;
        private System.Windows.Forms.ComboBox cbBGPalette;
        private System.Windows.Forms.Label lblTileCount;
    }
}