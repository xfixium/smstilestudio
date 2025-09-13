namespace SMSTileStudio.Forms
{
    partial class MetaSpriteSelectForm
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
            this.lstSelectedMetaSprites = new System.Windows.Forms.CheckedListBox();
            this.pnlChecked = new System.Windows.Forms.Panel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.lblSelectedTilemaps = new System.Windows.Forms.Label();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterByName = new System.Windows.Forms.Button();
            this.chkBinaryMerge = new System.Windows.Forms.CheckBox();
            this.pnlTileset = new SMSTileStudio.Controls.ImageControl();
            this.pnlMetaSprite = new SMSTileStudio.Controls.MetaSpriteControl();
            this.tpnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlChecked.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 4;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpnlMain.Controls.Add(this.pnlMetaSprite, 2, 2);
            this.tpnlMain.Controls.Add(this.pnlTileset, 2, 3);
            this.tpnlMain.Controls.Add(this.pnlButtons, 2, 4);
            this.tpnlMain.Controls.Add(this.lstSelectedMetaSprites, 0, 2);
            this.tpnlMain.Controls.Add(this.pnlChecked, 0, 4);
            this.tpnlMain.Controls.Add(this.lblFilterByName, 0, 0);
            this.tpnlMain.Controls.Add(this.txtFilter, 1, 0);
            this.tpnlMain.Controls.Add(this.btnFilterByName, 3, 0);
            this.tpnlMain.Controls.Add(this.chkBinaryMerge, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 5;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(608, 425);
            this.tpnlMain.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.tpnlMain.SetColumnSpan(this.pnlButtons, 2);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(281, 398);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(327, 27);
            this.pnlButtons.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(233, 3);
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
            this.btnOK.Location = new System.Drawing.Point(137, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstSelectedMetaSprites
            // 
            this.tpnlMain.SetColumnSpan(this.lstSelectedMetaSprites, 2);
            this.lstSelectedMetaSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedMetaSprites.FormattingEnabled = true;
            this.lstSelectedMetaSprites.Location = new System.Drawing.Point(0, 55);
            this.lstSelectedMetaSprites.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lstSelectedMetaSprites.Name = "lstSelectedMetaSprites";
            this.tpnlMain.SetRowSpan(this.lstSelectedMetaSprites, 2);
            this.lstSelectedMetaSprites.Size = new System.Drawing.Size(281, 343);
            this.lstSelectedMetaSprites.TabIndex = 13;
            this.lstSelectedMetaSprites.SelectedIndexChanged += new System.EventHandler(this.lstSelectedMetaSprites_SelectedIndexChanged);
            // 
            // pnlChecked
            // 
            this.tpnlMain.SetColumnSpan(this.pnlChecked, 2);
            this.pnlChecked.Controls.Add(this.chkAll);
            this.pnlChecked.Controls.Add(this.lblSelectedTilemaps);
            this.pnlChecked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChecked.Location = new System.Drawing.Point(0, 398);
            this.pnlChecked.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChecked.Name = "pnlChecked";
            this.pnlChecked.Size = new System.Drawing.Size(281, 27);
            this.pnlChecked.TabIndex = 17;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(5, 6);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(126, 17);
            this.chkAll.TabIndex = 19;
            this.chkAll.Text = "Check / Uncheck All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // lblSelectedTilemaps
            // 
            this.lblSelectedTilemaps.AutoSize = true;
            this.lblSelectedTilemaps.Location = new System.Drawing.Point(144, 7);
            this.lblSelectedTilemaps.Name = "lblSelectedTilemaps";
            this.lblSelectedTilemaps.Size = new System.Drawing.Size(123, 13);
            this.lblSelectedTilemaps.TabIndex = 18;
            this.lblSelectedTilemaps.Text = "Selected Meta Sprites: 0";
            this.lblSelectedTilemaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterByName
            // 
            this.lblFilterByName.AutoSize = true;
            this.lblFilterByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilterByName.Location = new System.Drawing.Point(3, 3);
            this.lblFilterByName.Margin = new System.Windows.Forms.Padding(3);
            this.lblFilterByName.Name = "lblFilterByName";
            this.lblFilterByName.Size = new System.Drawing.Size(194, 20);
            this.lblFilterByName.TabIndex = 18;
            this.lblFilterByName.Text = "Filter by Name (Contains):";
            this.lblFilterByName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilter
            // 
            this.tpnlMain.SetColumnSpan(this.txtFilter, 2);
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(203, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(238, 20);
            this.txtFilter.TabIndex = 19;
            // 
            // btnFilterByName
            // 
            this.btnFilterByName.Location = new System.Drawing.Point(444, 0);
            this.btnFilterByName.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterByName.Name = "btnFilterByName";
            this.btnFilterByName.Size = new System.Drawing.Size(164, 26);
            this.btnFilterByName.TabIndex = 20;
            this.btnFilterByName.Text = "Apply Name Filter";
            this.btnFilterByName.UseVisualStyleBackColor = true;
            this.btnFilterByName.Click += new System.EventHandler(this.btnFilterByName_Click);
            // 
            // chkBinaryMerge
            // 
            this.chkBinaryMerge.AutoSize = true;
            this.chkBinaryMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBinaryMerge.Location = new System.Drawing.Point(4, 31);
            this.chkBinaryMerge.Margin = new System.Windows.Forms.Padding(4, 5, 3, 3);
            this.chkBinaryMerge.Name = "chkBinaryMerge";
            this.chkBinaryMerge.Size = new System.Drawing.Size(193, 18);
            this.chkBinaryMerge.TabIndex = 21;
            this.chkBinaryMerge.Text = "Merge into one binary";
            this.chkBinaryMerge.UseVisualStyleBackColor = true;
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(324, 166);
            this.pnlTileset.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTileset.Centered = true;
            this.tpnlMain.SetColumnSpan(this.pnlTileset, 2);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTileset.HatchForeColor = System.Drawing.Color.White;
            this.pnlTileset.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageAlpha = 1F;
            this.pnlTileset.ImageScale = 1;
            this.pnlTileset.Location = new System.Drawing.Point(284, 229);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(3, 4, 0, 3);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(324, 166);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 16;
            this.pnlTileset.UseCanvas = false;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = true;
            // 
            // pnlMetaSprite
            // 
            this.pnlMetaSprite.AutoScroll = true;
            this.pnlMetaSprite.AutoScrollMinSize = new System.Drawing.Size(321, 167);
            this.pnlMetaSprite.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaSprite.Centered = true;
            this.tpnlMain.SetColumnSpan(this.pnlMetaSprite, 2);
            this.pnlMetaSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaSprite.EditMode = SMSTileStudio.Data.MetaSpriteEditType.Sprites;
            this.pnlMetaSprite.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaSprite.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaSprite.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaSprite.Image = null;
            this.pnlMetaSprite.ImageAlpha = 1F;
            this.pnlMetaSprite.ImageScale = 1;
            this.pnlMetaSprite.Location = new System.Drawing.Point(284, 55);
            this.pnlMetaSprite.MinimumScale = 1;
            this.pnlMetaSprite.Name = "pnlMetaSprite";
            this.pnlMetaSprite.ShowCollisions = true;
            this.pnlMetaSprite.ShowOrigin = true;
            this.pnlMetaSprite.ShowSprites = true;
            this.pnlMetaSprite.ShowTransparent = true;
            this.pnlMetaSprite.Size = new System.Drawing.Size(321, 167);
            this.pnlMetaSprite.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaSprite.SpriteMode = SMSTileStudio.Data.SpriteModeType.Normal;
            this.pnlMetaSprite.TabIndex = 22;
            this.pnlMetaSprite.UseCanvas = false;
            this.pnlMetaSprite.UseGrid = true;
            this.pnlMetaSprite.UseHatch = true;
            this.pnlMetaSprite.UseMouseWheelScaling = true;
            // 
            // MetaSpriteSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetaSpriteSelectForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Meta Sprites";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlChecked.ResumeLayout(false);
            this.pnlChecked.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private Controls.ImageControl pnlTileset;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckedListBox lstSelectedMetaSprites;
        private System.Windows.Forms.Panel pnlChecked;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label lblSelectedTilemaps;
        private System.Windows.Forms.Label lblFilterByName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilterByName;
        private System.Windows.Forms.CheckBox chkBinaryMerge;
        private Controls.MetaSpriteControl pnlMetaSprite;
    }
}