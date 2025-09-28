namespace SMSTileStudio.Forms
{
    partial class ImportSpriteSheetForm
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
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.lblSpriteMode = new System.Windows.Forms.Label();
            this.cbSpriteMode = new System.Windows.Forms.ComboBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.cbSprPalette = new System.Windows.Forms.ComboBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.pnlSpriteSheet = new SMSTileStudio.Controls.ImageControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlPalette = new SMSTileStudio.Controls.PaletteSpriteControl();
            this.tpnlMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpImage.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 3;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tpnlMain.Controls.Add(this.grpOptions, 0, 0);
            this.tpnlMain.Controls.Add(this.grpImage, 1, 0);
            this.tpnlMain.Controls.Add(this.pnlButtons, 2, 2);
            this.tpnlMain.Controls.Add(this.pnlPalette, 1, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(10, 10);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.24529F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.75472F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(758, 537);
            this.tpnlMain.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.pnlSprPalette);
            this.grpOptions.Controls.Add(this.lblSpriteMode);
            this.grpOptions.Controls.Add(this.cbSpriteMode);
            this.grpOptions.Controls.Add(this.lblSprPalette);
            this.grpOptions.Controls.Add(this.cbSprPalette);
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOptions.Location = new System.Drawing.Point(3, 3);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(8);
            this.tpnlMain.SetRowSpan(this.grpOptions, 2);
            this.grpOptions.Size = new System.Drawing.Size(185, 504);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Meta Sprite Options";
            // 
            // pnlSprPalette
            // 
            this.pnlSprPalette.Location = new System.Drawing.Point(8, 112);
            this.pnlSprPalette.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSprPalette.TabIndex = 4;
            // 
            // lblSpriteMode
            // 
            this.lblSpriteMode.AutoSize = true;
            this.lblSpriteMode.Location = new System.Drawing.Point(8, 24);
            this.lblSpriteMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteMode.Name = "lblSpriteMode";
            this.lblSpriteMode.Size = new System.Drawing.Size(73, 13);
            this.lblSpriteMode.TabIndex = 0;
            this.lblSpriteMode.Text = "Sprite Mode:";
            this.lblSpriteMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteMode
            // 
            this.cbSpriteMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteMode.FormattingEnabled = true;
            this.cbSpriteMode.Location = new System.Drawing.Point(8, 44);
            this.cbSpriteMode.Name = "cbSpriteMode";
            this.cbSpriteMode.Size = new System.Drawing.Size(168, 21);
            this.cbSpriteMode.TabIndex = 1;
            this.cbSpriteMode.SelectedIndexChanged += new System.EventHandler(this.cbMetaSprite_SelectedIndexChanged);
            // 
            // lblSprPalette
            // 
            this.lblSprPalette.AutoSize = true;
            this.lblSprPalette.Location = new System.Drawing.Point(8, 68);
            this.lblSprPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSprPalette.Name = "lblSprPalette";
            this.lblSprPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSprPalette.TabIndex = 2;
            this.lblSprPalette.Text = "Sprite Palette:";
            this.lblSprPalette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSprPalette
            // 
            this.cbSprPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSprPalette.FormattingEnabled = true;
            this.cbSprPalette.Location = new System.Drawing.Point(8, 88);
            this.cbSprPalette.Name = "cbSprPalette";
            this.cbSprPalette.Size = new System.Drawing.Size(168, 21);
            this.cbSprPalette.TabIndex = 3;
            this.cbSprPalette.SelectedIndexChanged += new System.EventHandler(this.cbMetaSprite_SelectedIndexChanged);
            // 
            // grpImage
            // 
            this.tpnlMain.SetColumnSpan(this.grpImage, 2);
            this.grpImage.Controls.Add(this.pnlSpriteSheet);
            this.grpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImage.Location = new System.Drawing.Point(194, 3);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(8);
            this.grpImage.Size = new System.Drawing.Size(561, 398);
            this.grpImage.TabIndex = 1;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Image";
            // 
            // pnlSpriteSheet
            // 
            this.pnlSpriteSheet.Canvas = new System.Drawing.Size(8, 8);
            this.pnlSpriteSheet.Centered = true;
            this.pnlSpriteSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteSheet.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSpriteSheet.HatchForeColor = System.Drawing.Color.White;
            this.pnlSpriteSheet.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSpriteSheet.Image = null;
            this.pnlSpriteSheet.ImageAlpha = 1F;
            this.pnlSpriteSheet.ImageScale = 1;
            this.pnlSpriteSheet.Location = new System.Drawing.Point(8, 23);
            this.pnlSpriteSheet.MinimumScale = 1;
            this.pnlSpriteSheet.Name = "pnlSpriteSheet";
            this.pnlSpriteSheet.Size = new System.Drawing.Size(545, 367);
            this.pnlSpriteSheet.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSpriteSheet.TabIndex = 0;
            this.pnlSpriteSheet.UseCanvas = false;
            this.pnlSpriteSheet.UseHatch = true;
            this.pnlSpriteSheet.UseMouseWheelScaling = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(560, 510);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(198, 27);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(99, 2);
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
            this.btnOK.Location = new System.Drawing.Point(3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlPalette
            // 
            this.tpnlMain.SetColumnSpan(this.pnlPalette, 2);
            this.pnlPalette.Location = new System.Drawing.Point(195, 409);
            this.pnlPalette.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(559, 96);
            this.pnlPalette.TabIndex = 2;
            this.pnlPalette.ColorShifted += new SMSTileStudio.Controls.PaletteSpriteControl.ColorShiftedHandler(this.pnlPalette_ColorShifted);
            this.pnlPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteSpriteControl.SelectedColorChangedHandler(this.pnlPalette_SelectedColorChanged);
            // 
            // ImportSpriteSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 557);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportSpriteSheetForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Meta Sprite Tileset";
            this.tpnlMain.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpImage.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblSprPalette;
        private System.Windows.Forms.ComboBox cbSprPalette;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSpriteMode;
        private System.Windows.Forms.ComboBox cbSpriteMode;
        private Controls.PaletteSpriteControl pnlPalette;
        private Controls.PaletteControl pnlSprPalette;
        private Controls.ImageControl pnlSpriteSheet;
    }
}