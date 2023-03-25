namespace SMSTileStudio.Forms
{
    partial class ImportTilesetForm
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
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.grpTileset = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlTilesetImport = new SMSTileStudio.Controls.PixelTileControl();
            this.pnlTilesetCurrent = new SMSTileStudio.Controls.PixelTileControl();
            this.lblCurrentTileCount = new System.Windows.Forms.Label();
            this.lblImportTileCount = new System.Windows.Forms.Label();
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
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tpnlMain.Controls.Add(this.grpOptions, 0, 0);
            this.tpnlMain.Controls.Add(this.grpImage, 1, 0);
            this.tpnlMain.Controls.Add(this.grpTileset, 2, 0);
            this.tpnlMain.Controls.Add(this.panel1, 2, 2);
            this.tpnlMain.Controls.Add(this.lblCurrentTileCount, 1, 1);
            this.tpnlMain.Controls.Add(this.lblImportTileCount, 2, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(10, 10);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(653, 451);
            this.tpnlMain.TabIndex = 1;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.pnlSPRPalette);
            this.grpOptions.Controls.Add(this.pnlBGPalette);
            this.grpOptions.Controls.Add(this.lblSPRPalette);
            this.grpOptions.Controls.Add(this.cbSPRPalette);
            this.grpOptions.Controls.Add(this.lblBGPalette);
            this.grpOptions.Controls.Add(this.cbBGPalette);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(8);
            this.tpnlMain.SetRowSpan(this.grpOptions, 2);
            this.grpOptions.Size = new System.Drawing.Size(185, 419);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Tileset Options";
            // 
            // pnlSPRPalette
            // 
            this.pnlSPRPalette.Location = new System.Drawing.Point(8, 156);
            this.pnlSPRPalette.Name = "pnlSPRPalette";
            this.pnlSPRPalette.ReadOnly = false;
            this.pnlSPRPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSPRPalette.TabIndex = 25;
            // 
            // pnlBGPalette
            // 
            this.pnlBGPalette.Location = new System.Drawing.Point(8, 68);
            this.pnlBGPalette.Name = "pnlBGPalette";
            this.pnlBGPalette.ReadOnly = false;
            this.pnlBGPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlBGPalette.TabIndex = 24;
            // 
            // lblSPRPalette
            // 
            this.lblSPRPalette.AutoSize = true;
            this.lblSPRPalette.Location = new System.Drawing.Point(8, 112);
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
            this.cbSPRPalette.Location = new System.Drawing.Point(8, 132);
            this.cbSPRPalette.Name = "cbSPRPalette";
            this.cbSPRPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSPRPalette.TabIndex = 23;
            // 
            // lblBGPalette
            // 
            this.lblBGPalette.AutoSize = true;
            this.lblBGPalette.Location = new System.Drawing.Point(8, 24);
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
            this.cbBGPalette.Location = new System.Drawing.Point(8, 44);
            this.cbBGPalette.Name = "cbBGPalette";
            this.cbBGPalette.Size = new System.Drawing.Size(168, 21);
            this.cbBGPalette.TabIndex = 21;
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.pnlTilesetCurrent);
            this.grpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImage.Location = new System.Drawing.Point(194, 3);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(8);
            this.grpImage.Size = new System.Drawing.Size(225, 393);
            this.grpImage.TabIndex = 1;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Current Tileset";
            // 
            // grpTileset
            // 
            this.grpTileset.Controls.Add(this.pnlTilesetImport);
            this.grpTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTileset.Location = new System.Drawing.Point(425, 3);
            this.grpTileset.Name = "grpTileset";
            this.grpTileset.Padding = new System.Windows.Forms.Padding(8);
            this.grpTileset.Size = new System.Drawing.Size(225, 393);
            this.grpTileset.TabIndex = 2;
            this.grpTileset.TabStop = false;
            this.grpTileset.Text = "Imported Tileset";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(422, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 26);
            this.panel1.TabIndex = 4;
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
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(36, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // pnlTilesetImport
            // 
            this.pnlTilesetImport.AutoScroll = true;
            this.pnlTilesetImport.AutoScrollMinSize = new System.Drawing.Size(576, 1035);
            this.pnlTilesetImport.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilesetImport.Centered = false;
            this.pnlTilesetImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetImport.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilesetImport.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilesetImport.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilesetImport.Image = null;
            this.pnlTilesetImport.ImageAlpha = 1F;
            this.pnlTilesetImport.ImageScale = 3;
            this.pnlTilesetImport.Indexed = false;
            this.pnlTilesetImport.Location = new System.Drawing.Point(8, 23);
            this.pnlTilesetImport.MinimumScale = 1;
            this.pnlTilesetImport.Name = "pnlTilesetImport";
            this.pnlTilesetImport.Size = new System.Drawing.Size(209, 362);
            this.pnlTilesetImport.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetImport.TabIndex = 0;
            this.pnlTilesetImport.UseCanvas = false;
            this.pnlTilesetImport.UseHatch = true;
            this.pnlTilesetImport.UseMouseWheelScaling = false;
            // 
            // pnlTilesetCurrent
            // 
            this.pnlTilesetCurrent.AutoScroll = true;
            this.pnlTilesetCurrent.AutoScrollMinSize = new System.Drawing.Size(576, 1035);
            this.pnlTilesetCurrent.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilesetCurrent.Centered = false;
            this.pnlTilesetCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetCurrent.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilesetCurrent.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilesetCurrent.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilesetCurrent.Image = null;
            this.pnlTilesetCurrent.ImageAlpha = 1F;
            this.pnlTilesetCurrent.ImageScale = 3;
            this.pnlTilesetCurrent.Indexed = false;
            this.pnlTilesetCurrent.Location = new System.Drawing.Point(8, 23);
            this.pnlTilesetCurrent.MinimumScale = 1;
            this.pnlTilesetCurrent.Name = "pnlTilesetCurrent";
            this.pnlTilesetCurrent.Size = new System.Drawing.Size(209, 362);
            this.pnlTilesetCurrent.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilesetCurrent.TabIndex = 1;
            this.pnlTilesetCurrent.UseCanvas = false;
            this.pnlTilesetCurrent.UseHatch = true;
            this.pnlTilesetCurrent.UseMouseWheelScaling = false;
            // 
            // lblCurrentTileCount
            // 
            this.lblCurrentTileCount.AutoSize = true;
            this.lblCurrentTileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentTileCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTileCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrentTileCount.Location = new System.Drawing.Point(194, 399);
            this.lblCurrentTileCount.Name = "lblCurrentTileCount";
            this.lblCurrentTileCount.Size = new System.Drawing.Size(225, 26);
            this.lblCurrentTileCount.TabIndex = 6;
            this.lblCurrentTileCount.Text = "Total Tile Count: 0";
            this.lblCurrentTileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImportTileCount
            // 
            this.lblImportTileCount.AutoSize = true;
            this.lblImportTileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImportTileCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportTileCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImportTileCount.Location = new System.Drawing.Point(425, 399);
            this.lblImportTileCount.Name = "lblImportTileCount";
            this.lblImportTileCount.Size = new System.Drawing.Size(225, 26);
            this.lblImportTileCount.TabIndex = 7;
            this.lblImportTileCount.Text = "Total Tile Count: 0";
            this.lblImportTileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportTilesetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportTilesetForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Tileset";
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
        private Controls.PaletteControl pnlSPRPalette;
        private Controls.PaletteControl pnlBGPalette;
        private System.Windows.Forms.Label lblSPRPalette;
        private System.Windows.Forms.ComboBox cbSPRPalette;
        private System.Windows.Forms.Label lblBGPalette;
        private System.Windows.Forms.ComboBox cbBGPalette;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.GroupBox grpTileset;
        private Controls.PixelTileControl pnlTilesetImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Controls.PixelTileControl pnlTilesetCurrent;
        private System.Windows.Forms.Label lblCurrentTileCount;
        private System.Windows.Forms.Label lblImportTileCount;
    }
}