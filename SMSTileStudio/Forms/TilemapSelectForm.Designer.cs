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
            this.btnFilterByTag = new System.Windows.Forms.Button();
            this.lblFilterByTag = new System.Windows.Forms.Label();
            this.lblImageMerge = new System.Windows.Forms.Label();
            this.pnlTileset = new SMSTileStudio.Controls.ImageControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstSelectedTilemaps = new System.Windows.Forms.CheckedListBox();
            this.pnlTilemap = new SMSTileStudio.Controls.ImageControl();
            this.pnlChecked = new System.Windows.Forms.Panel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.lblSelectedTilemaps = new System.Windows.Forms.Label();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilterByName = new System.Windows.Forms.Button();
            this.chkImageMerge = new System.Windows.Forms.CheckBox();
            this.nudImageMerge = new System.Windows.Forms.NumericUpDown();
            this.cbTags = new System.Windows.Forms.ComboBox();
            this.tpnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlChecked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageMerge)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 4;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tpnlMain.Controls.Add(this.btnFilterByTag, 3, 1);
            this.tpnlMain.Controls.Add(this.lblFilterByTag, 0, 1);
            this.tpnlMain.Controls.Add(this.lblImageMerge, 1, 2);
            this.tpnlMain.Controls.Add(this.pnlTileset, 2, 4);
            this.tpnlMain.Controls.Add(this.pnlButtons, 2, 5);
            this.tpnlMain.Controls.Add(this.lstSelectedTilemaps, 0, 3);
            this.tpnlMain.Controls.Add(this.pnlTilemap, 2, 3);
            this.tpnlMain.Controls.Add(this.pnlChecked, 0, 5);
            this.tpnlMain.Controls.Add(this.lblFilterByName, 0, 0);
            this.tpnlMain.Controls.Add(this.txtFilter, 1, 0);
            this.tpnlMain.Controls.Add(this.btnFilterByName, 3, 0);
            this.tpnlMain.Controls.Add(this.chkImageMerge, 0, 2);
            this.tpnlMain.Controls.Add(this.nudImageMerge, 2, 2);
            this.tpnlMain.Controls.Add(this.cbTags, 1, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 6;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(608, 425);
            this.tpnlMain.TabIndex = 0;
            // 
            // btnFilterByTag
            // 
            this.btnFilterByTag.Location = new System.Drawing.Point(444, 26);
            this.btnFilterByTag.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterByTag.Name = "btnFilterByTag";
            this.btnFilterByTag.Size = new System.Drawing.Size(164, 26);
            this.btnFilterByTag.TabIndex = 26;
            this.btnFilterByTag.Text = "Apply Tag Filter";
            this.btnFilterByTag.UseVisualStyleBackColor = true;
            this.btnFilterByTag.Click += new System.EventHandler(this.btnFilterByTag_Click);
            // 
            // lblFilterByTag
            // 
            this.lblFilterByTag.AutoSize = true;
            this.lblFilterByTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilterByTag.Location = new System.Drawing.Point(3, 29);
            this.lblFilterByTag.Margin = new System.Windows.Forms.Padding(3);
            this.lblFilterByTag.Name = "lblFilterByTag";
            this.lblFilterByTag.Size = new System.Drawing.Size(194, 20);
            this.lblFilterByTag.TabIndex = 24;
            this.lblFilterByTag.Text = "Filter by Tag:";
            this.lblFilterByTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImageMerge
            // 
            this.lblImageMerge.AutoSize = true;
            this.lblImageMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImageMerge.Location = new System.Drawing.Point(200, 52);
            this.lblImageMerge.Margin = new System.Windows.Forms.Padding(0);
            this.lblImageMerge.Name = "lblImageMerge";
            this.lblImageMerge.Size = new System.Drawing.Size(81, 26);
            this.lblImageMerge.TabIndex = 22;
            this.lblImageMerge.Text = "Columns:";
            this.lblImageMerge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(324, 153);
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
            this.pnlTileset.Location = new System.Drawing.Point(284, 242);
            this.pnlTileset.Margin = new System.Windows.Forms.Padding(3, 4, 0, 3);
            this.pnlTileset.MinimumScale = 1;
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(324, 153);
            this.pnlTileset.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTileset.TabIndex = 16;
            this.pnlTileset.UseCanvas = false;
            this.pnlTileset.UseHatch = true;
            this.pnlTileset.UseMouseWheelScaling = true;
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
            // lstSelectedTilemaps
            // 
            this.tpnlMain.SetColumnSpan(this.lstSelectedTilemaps, 2);
            this.lstSelectedTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedTilemaps.FormattingEnabled = true;
            this.lstSelectedTilemaps.Location = new System.Drawing.Point(0, 81);
            this.lstSelectedTilemaps.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lstSelectedTilemaps.Name = "lstSelectedTilemaps";
            this.tpnlMain.SetRowSpan(this.lstSelectedTilemaps, 2);
            this.lstSelectedTilemaps.Size = new System.Drawing.Size(281, 317);
            this.lstSelectedTilemaps.TabIndex = 13;
            this.lstSelectedTilemaps.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSelectedTilemaps_ItemCheck);
            this.lstSelectedTilemaps.SelectedIndexChanged += new System.EventHandler(this.lstSelectedTilemaps_SelectedIndexChanged);
            // 
            // pnlTilemap
            // 
            this.pnlTilemap.AutoScroll = true;
            this.pnlTilemap.AutoScrollMinSize = new System.Drawing.Size(324, 157);
            this.pnlTilemap.Canvas = new System.Drawing.Size(8, 8);
            this.pnlTilemap.Centered = true;
            this.tpnlMain.SetColumnSpan(this.pnlTilemap, 2);
            this.pnlTilemap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemap.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlTilemap.HatchForeColor = System.Drawing.Color.White;
            this.pnlTilemap.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlTilemap.Image = null;
            this.pnlTilemap.ImageAlpha = 1F;
            this.pnlTilemap.ImageScale = 1;
            this.pnlTilemap.Location = new System.Drawing.Point(284, 81);
            this.pnlTilemap.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.pnlTilemap.MinimumScale = 1;
            this.pnlTilemap.Name = "pnlTilemap";
            this.pnlTilemap.Size = new System.Drawing.Size(324, 157);
            this.pnlTilemap.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlTilemap.TabIndex = 15;
            this.pnlTilemap.UseCanvas = false;
            this.pnlTilemap.UseHatch = true;
            this.pnlTilemap.UseMouseWheelScaling = true;
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
            this.chkAll.Size = new System.Drawing.Size(127, 17);
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
            this.lblSelectedTilemaps.Size = new System.Drawing.Size(110, 13);
            this.lblSelectedTilemaps.TabIndex = 18;
            this.lblSelectedTilemaps.Text = "Selected Tilemaps: 0";
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
            this.txtFilter.Size = new System.Drawing.Size(238, 22);
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
            // chkImageMerge
            // 
            this.chkImageMerge.AutoSize = true;
            this.chkImageMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkImageMerge.Location = new System.Drawing.Point(4, 57);
            this.chkImageMerge.Margin = new System.Windows.Forms.Padding(4, 5, 3, 3);
            this.chkImageMerge.Name = "chkImageMerge";
            this.chkImageMerge.Size = new System.Drawing.Size(193, 18);
            this.chkImageMerge.TabIndex = 21;
            this.chkImageMerge.Text = "Merge into one image";
            this.chkImageMerge.UseVisualStyleBackColor = true;
            // 
            // nudImageMerge
            // 
            this.nudImageMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudImageMerge.Location = new System.Drawing.Point(284, 55);
            this.nudImageMerge.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudImageMerge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudImageMerge.Name = "nudImageMerge";
            this.nudImageMerge.Size = new System.Drawing.Size(157, 22);
            this.nudImageMerge.TabIndex = 23;
            this.nudImageMerge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTags
            // 
            this.tpnlMain.SetColumnSpan(this.cbTags, 2);
            this.cbTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTags.FormattingEnabled = true;
            this.cbTags.Location = new System.Drawing.Point(200, 29);
            this.cbTags.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.cbTags.Name = "cbTags";
            this.cbTags.Size = new System.Drawing.Size(244, 21);
            this.cbTags.TabIndex = 25;
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
            this.pnlChecked.ResumeLayout(false);
            this.pnlChecked.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageMerge)).EndInit();
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
        private System.Windows.Forms.Panel pnlChecked;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label lblSelectedTilemaps;
        private System.Windows.Forms.Label lblFilterByName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblImageMerge;
        private System.Windows.Forms.Button btnFilterByName;
        private System.Windows.Forms.CheckBox chkImageMerge;
        private System.Windows.Forms.NumericUpDown nudImageMerge;
        private System.Windows.Forms.Button btnFilterByTag;
        private System.Windows.Forms.Label lblFilterByTag;
        private System.Windows.Forms.ComboBox cbTags;
    }
}