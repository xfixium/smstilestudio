namespace SMSTileStudio.Forms
{
    partial class TilemapSelectForm
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstSelectedTilemaps = new System.Windows.Forms.CheckedListBox();
            this.pnlTileset = new SMSTileStudio.Controls.ImageControl();
            this.pnlTilemap = new SMSTileStudio.Controls.ImageControl();
            this.lblSelectedTilemaps = new System.Windows.Forms.Label();
            this.tpnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.Controls.Add(this.pnlTileset, 1, 1);
            this.tpnlMain.Controls.Add(this.pnlButtons, 1, 2);
            this.tpnlMain.Controls.Add(this.lstSelectedTilemaps, 0, 0);
            this.tpnlMain.Controls.Add(this.pnlTilemap, 1, 0);
            this.tpnlMain.Controls.Add(this.lblSelectedTilemaps, 0, 2);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(608, 425);
            this.tpnlMain.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(304, 398);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(304, 27);
            this.pnlButtons.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(210, 3);
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
            this.btnOK.Location = new System.Drawing.Point(114, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstSelectedTilemaps
            // 
            this.lstSelectedTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedTilemaps.FormattingEnabled = true;
            this.lstSelectedTilemaps.Location = new System.Drawing.Point(0, 0);
            this.lstSelectedTilemaps.Margin = new System.Windows.Forms.Padding(0);
            this.lstSelectedTilemaps.Name = "lstSelectedTilemaps";
            this.tpnlMain.SetRowSpan(this.lstSelectedTilemaps, 2);
            this.lstSelectedTilemaps.Size = new System.Drawing.Size(304, 398);
            this.lstSelectedTilemaps.TabIndex = 13;
            this.lstSelectedTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstSelectedTilemaps_SelectedIndexChanged);
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(301, 192);
            this.pnlTileset.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileset.Centered = true;
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileset.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileset.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageAlpha = 1F;
            this.pnlTileset.ImageScale = 1;
            this.pnlTileset.Location = new System.Drawing.Point(307, 203);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(3, 4, 0, 3);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(301, 192);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 16;
            this.pnlTileset.UseCanvas = false;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = true;
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.AutoScroll = true;
            this.pnlTilemap.AutoScrollMinSize = new System.Drawing.Size(301, 199);
            this.pnlTilemap.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemap.Centered = true;
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemap.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemap.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemap.Image = null;
            this.pnlTilemap.ImageAlpha = 1F;
            this.pnlTilemap.ImageScale = 1;
            this.pnlTilemap.Location = new System.Drawing.Point(307, 0);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlTilemap.MinimumScale = 1;
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(301, 199);
            this.pnlTilemap.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemap.TabIndex = 15;
            this.pnlTilemap.UseCanvas = false;
            this.pnlTilemap.UseHatch = true;
            this.pnlTilemap.UseMouseWheelScaling = true;
            // 
            // lblSelectedTilemaps
            // 
            this.lblSelectedTilemaps.AutoSize = true;
            this.lblSelectedTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedTilemaps.Location = new System.Drawing.Point(3, 398);
            this.lblSelectedTilemaps.Name = "lblSelectedTilemaps";
            this.lblSelectedTilemaps.Size = new System.Drawing.Size(298, 27);
            this.lblSelectedTilemaps.TabIndex = 17;
            this.lblSelectedTilemaps.Text = "Selected Tilemaps: 0";
            this.lblSelectedTilemaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TilemapSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TilemapSelectForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Tilemaps";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.CheckedListBox lstSelectedTilemaps;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Controls.ImageControl pnlTilemap;
        private Controls.ImageControl pnlTileset;
        private System.Windows.Forms.Label lblSelectedTilemaps;
    }
}