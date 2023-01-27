namespace SMSTileStudio.Controls
{
    partial class AssetTilesetControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetTilesetControl));
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
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.pnlTilesetEdit = new SMSTileStudio.Controls.TilesetImageControl();
            this.tpnlTileset.SuspendLayout();
            this.pnlTilesetOptions.SuspendLayout();
            this.pnlTileset.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlTileset
            // 
            this.tpnlTileset.ColumnCount = 2;
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlTileset.Controls.Add(this.pnlTilesetOptions, 1, 0);
            this.tpnlTileset.Controls.Add(this.pnlTileset, 0, 0);
            this.tpnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileset.Location = new System.Drawing.Point(0, 0);
            this.tpnlTileset.Name = "tpnlTileset";
            this.tpnlTileset.RowCount = 1;
            this.tpnlTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileset.Size = new System.Drawing.Size(674, 519);
            this.tpnlTileset.TabIndex = 1;
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
            this.btnPasteTileset.TabIndex = 24;
            this.btnPasteTileset.Text = "Paste";
            this.btnPasteTileset.UseVisualStyleBackColor = true;
            // 
            // btnCopyTileset
            // 
            this.btnCopyTileset.Location = new System.Drawing.Point(8, 72);
            this.btnCopyTileset.Name = "btnCopyTileset";
            this.btnCopyTileset.Size = new System.Drawing.Size(84, 23);
            this.btnCopyTileset.TabIndex = 23;
            this.btnCopyTileset.Text = "Copy";
            this.btnCopyTileset.UseVisualStyleBackColor = true;
            // 
            // btnDeselectTile
            // 
            this.btnDeselectTile.Location = new System.Drawing.Point(8, 48);
            this.btnDeselectTile.Name = "btnDeselectTile";
            this.btnDeselectTile.Size = new System.Drawing.Size(168, 23);
            this.btnDeselectTile.TabIndex = 22;
            this.btnDeselectTile.Text = "Deselect Tile";
            this.btnDeselectTile.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTile
            // 
            this.btnRemoveTile.Location = new System.Drawing.Point(8, 24);
            this.btnRemoveTile.Name = "btnRemoveTile";
            this.btnRemoveTile.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveTile.TabIndex = 21;
            this.btnRemoveTile.Text = "Remove Selected Tile";
            this.btnRemoveTile.UseVisualStyleBackColor = true;
            // 
            // chkTilesetGrid
            // 
            this.chkTilesetGrid.AutoSize = true;
            this.chkTilesetGrid.Checked = true;
            this.chkTilesetGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTilesetGrid.Location = new System.Drawing.Point(10, 96);
            this.chkTilesetGrid.Name = "chkTilesetGrid";
            this.chkTilesetGrid.Size = new System.Drawing.Size(45, 17);
            this.chkTilesetGrid.TabIndex = 10;
            this.chkTilesetGrid.Text = "Grid";
            this.chkTilesetGrid.UseVisualStyleBackColor = true;
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
            // 
            // chkTilesetIndexes
            // 
            this.chkTilesetIndexes.AutoSize = true;
            this.chkTilesetIndexes.Location = new System.Drawing.Point(58, 96);
            this.chkTilesetIndexes.Name = "chkTilesetIndexes";
            this.chkTilesetIndexes.Size = new System.Drawing.Size(93, 17);
            this.chkTilesetIndexes.TabIndex = 11;
            this.chkTilesetIndexes.Text = "Show Indexes";
            this.chkTilesetIndexes.UseVisualStyleBackColor = true;
            // 
            // pnlSPRPalette
            // 
            this.pnlSPRPalette.Location = new System.Drawing.Point(8, 240);
            this.pnlSPRPalette.Name = "pnlSPRPalette";
            this.pnlSPRPalette.ReadOnly = false;
            this.pnlSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSPRPalette.TabIndex = 19;
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 160);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 18;
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
            // 
            // btnSwapSelectedPixel
            // 
            this.btnSwapSelectedPixel.Location = new System.Drawing.Point(8, 484);
            this.btnSwapSelectedPixel.Name = "btnSwapSelectedPixel";
            this.btnSwapSelectedPixel.Size = new System.Drawing.Size(168, 23);
            this.btnSwapSelectedPixel.TabIndex = 17;
            this.btnSwapSelectedPixel.Text = "Swap Selected Pixel";
            this.btnSwapSelectedPixel.UseVisualStyleBackColor = true;
            // 
            // lblSelectedTile
            // 
            this.lblSelectedTile.AutoSize = true;
            this.lblSelectedTile.Location = new System.Drawing.Point(8, 320);
            this.lblSelectedTile.Name = "lblSelectedTile";
            this.lblSelectedTile.Size = new System.Drawing.Size(72, 13);
            this.lblSelectedTile.TabIndex = 12;
            this.lblSelectedTile.Text = "Selected Tile:";
            // 
            // lblTilesetCompression
            // 
            this.lblTilesetCompression.AutoSize = true;
            this.lblTilesetCompression.Location = new System.Drawing.Point(8, 280);
            this.lblTilesetCompression.Margin = new System.Windows.Forms.Padding(0);
            this.lblTilesetCompression.Name = "lblTilesetCompression";
            this.lblTilesetCompression.Size = new System.Drawing.Size(70, 13);
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
            // 
            // lblSPRPalette
            // 
            this.lblSPRPalette.AutoSize = true;
            this.lblSPRPalette.Location = new System.Drawing.Point(8, 200);
            this.lblSPRPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSPRPalette.Name = "lblSPRPalette";
            this.lblSPRPalette.Size = new System.Drawing.Size(73, 13);
            this.lblSPRPalette.TabIndex = 6;
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
            this.cbSPRPalette.TabIndex = 7;
            // 
            // lblBGPalette
            // 
            this.lblBGPalette.AutoSize = true;
            this.lblBGPalette.Location = new System.Drawing.Point(8, 120);
            this.lblBGPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblBGPalette.Name = "lblBGPalette";
            this.lblBGPalette.Size = new System.Drawing.Size(104, 13);
            this.lblBGPalette.TabIndex = 4;
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
            this.cbBGPalette.TabIndex = 5;
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
            // 
            // TilesetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlTileset);
            this.Name = "TilesetControl";
            this.Size = new System.Drawing.Size(674, 519);
            this.tpnlTileset.ResumeLayout(false);
            this.pnlTilesetOptions.ResumeLayout(false);
            this.pnlTilesetOptions.PerformLayout();
            this.pnlTileset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlTileset;
        private System.Windows.Forms.Panel pnlTilesetOptions;
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
        private System.Windows.Forms.Panel pnlTileset;
        private TilesetImageControl pnlTilesetEdit;
    }
}
