namespace SMSTileStudio.Forms
{
    partial class ImportMetaSpriteForm
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
            this.lblFrameY = new System.Windows.Forms.Label();
            this.nudFrameX = new System.Windows.Forms.NumericUpDown();
            this.lblFrameX = new System.Windows.Forms.Label();
            this.nudFrameY = new System.Windows.Forms.NumericUpDown();
            this.btnAutoGenerateFrames = new System.Windows.Forms.Button();
            this.lblFrameHeight = new System.Windows.Forms.Label();
            this.nudFrameHeight = new System.Windows.Forms.NumericUpDown();
            this.lblFrameWidth = new System.Windows.Forms.Label();
            this.nudFrameWidth = new System.Windows.Forms.NumericUpDown();
            this.lblFramesPerRow = new System.Windows.Forms.Label();
            this.nudFramesPerRow = new System.Windows.Forms.NumericUpDown();
            this.lblFrameCount = new System.Windows.Forms.Label();
            this.nudFrameCount = new System.Windows.Forms.NumericUpDown();
            this.lblAutoFrameOptions = new System.Windows.Forms.Label();
            this.btnAddFrame = new System.Windows.Forms.Button();
            this.lblSpriteMode = new System.Windows.Forms.Label();
            this.cbSpriteMode = new System.Windows.Forms.ComboBox();
            this.lblSprPalette = new System.Windows.Forms.Label();
            this.cbSprPalette = new System.Windows.Forms.ComboBox();
            this.chkPaletteFromImage = new System.Windows.Forms.CheckBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSpriteCount = new System.Windows.Forms.Label();
            this.grpFrameOptions = new System.Windows.Forms.GroupBox();
            this.lblCurrentFrame = new System.Windows.Forms.Label();
            this.btnInsertFrame = new System.Windows.Forms.Button();
            this.btnSetFrame = new System.Windows.Forms.Button();
            this.btnRemoveFrame = new System.Windows.Forms.Button();
            this.btnMoveFrameUp = new System.Windows.Forms.Button();
            this.btnMoveFrameDown = new System.Windows.Forms.Button();
            this.lblFrameSize = new System.Windows.Forms.Label();
            this.btnClearAllFrames = new System.Windows.Forms.Button();
            this.chkAllowEmptySprites = new System.Windows.Forms.CheckBox();
            this.pnlSprPalette = new SMSTileStudio.Controls.PaletteControl();
            this.pnlMetaSpriteSelect = new SMSTileStudio.Controls.MetaSpriteSelectControl();
            this.pnlPalette = new SMSTileStudio.Controls.PaletteSpriteControl();
            this.lstFrames = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlCurrentFrame = new SMSTileStudio.Controls.ImageControl();
            this.tpnlMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesPerRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameCount)).BeginInit();
            this.grpImage.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpFrameOptions.SuspendLayout();
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
            this.tpnlMain.Controls.Add(this.lblSpriteCount, 0, 2);
            this.tpnlMain.Controls.Add(this.pnlPalette, 1, 1);
            this.tpnlMain.Controls.Add(this.grpFrameOptions, 2, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(10, 10);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 3;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.24529F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.75472F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(758, 537);
            this.tpnlMain.TabIndex = 1;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkAllowEmptySprites);
            this.grpOptions.Controls.Add(this.btnClearAllFrames);
            this.grpOptions.Controls.Add(this.lblFrameSize);
            this.grpOptions.Controls.Add(this.lblFrameY);
            this.grpOptions.Controls.Add(this.nudFrameX);
            this.grpOptions.Controls.Add(this.lblFrameX);
            this.grpOptions.Controls.Add(this.nudFrameY);
            this.grpOptions.Controls.Add(this.btnAutoGenerateFrames);
            this.grpOptions.Controls.Add(this.lblFrameHeight);
            this.grpOptions.Controls.Add(this.nudFrameHeight);
            this.grpOptions.Controls.Add(this.lblFrameWidth);
            this.grpOptions.Controls.Add(this.nudFrameWidth);
            this.grpOptions.Controls.Add(this.lblFramesPerRow);
            this.grpOptions.Controls.Add(this.nudFramesPerRow);
            this.grpOptions.Controls.Add(this.lblFrameCount);
            this.grpOptions.Controls.Add(this.nudFrameCount);
            this.grpOptions.Controls.Add(this.lblAutoFrameOptions);
            this.grpOptions.Controls.Add(this.lblSpriteMode);
            this.grpOptions.Controls.Add(this.cbSpriteMode);
            this.grpOptions.Controls.Add(this.pnlSprPalette);
            this.grpOptions.Controls.Add(this.lblSprPalette);
            this.grpOptions.Controls.Add(this.cbSprPalette);
            this.grpOptions.Controls.Add(this.chkPaletteFromImage);
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
            // lblFrameY
            // 
            this.lblFrameY.AutoSize = true;
            this.lblFrameY.Location = new System.Drawing.Point(8, 208);
            this.lblFrameY.Name = "lblFrameY";
            this.lblFrameY.Size = new System.Drawing.Size(49, 13);
            this.lblFrameY.TabIndex = 57;
            this.lblFrameY.Text = "Frame Y:";
            // 
            // nudFrameX
            // 
            this.nudFrameX.Location = new System.Drawing.Point(128, 179);
            this.nudFrameX.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameX.Name = "nudFrameX";
            this.nudFrameX.Size = new System.Drawing.Size(48, 22);
            this.nudFrameX.TabIndex = 56;
            this.nudFrameX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameX.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // lblFrameX
            // 
            this.lblFrameX.AutoSize = true;
            this.lblFrameX.Location = new System.Drawing.Point(8, 184);
            this.lblFrameX.Name = "lblFrameX";
            this.lblFrameX.Size = new System.Drawing.Size(50, 13);
            this.lblFrameX.TabIndex = 55;
            this.lblFrameX.Text = "Frame X:";
            // 
            // nudFrameY
            // 
            this.nudFrameY.Location = new System.Drawing.Point(128, 203);
            this.nudFrameY.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameY.Name = "nudFrameY";
            this.nudFrameY.Size = new System.Drawing.Size(48, 22);
            this.nudFrameY.TabIndex = 54;
            this.nudFrameY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameY.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // btnAutoGenerateFrames
            // 
            this.btnAutoGenerateFrames.Location = new System.Drawing.Point(8, 368);
            this.btnAutoGenerateFrames.Name = "btnAutoGenerateFrames";
            this.btnAutoGenerateFrames.Size = new System.Drawing.Size(168, 23);
            this.btnAutoGenerateFrames.TabIndex = 53;
            this.btnAutoGenerateFrames.Text = "Auto Generate Frames";
            this.btnAutoGenerateFrames.UseVisualStyleBackColor = true;
            // 
            // lblFrameHeight
            // 
            this.lblFrameHeight.AutoSize = true;
            this.lblFrameHeight.Location = new System.Drawing.Point(8, 256);
            this.lblFrameHeight.Name = "lblFrameHeight";
            this.lblFrameHeight.Size = new System.Drawing.Size(79, 13);
            this.lblFrameHeight.TabIndex = 52;
            this.lblFrameHeight.Text = "Frame Height:";
            // 
            // nudFrameHeight
            // 
            this.nudFrameHeight.Location = new System.Drawing.Point(128, 251);
            this.nudFrameHeight.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameHeight.Name = "nudFrameHeight";
            this.nudFrameHeight.Size = new System.Drawing.Size(48, 22);
            this.nudFrameHeight.TabIndex = 51;
            this.nudFrameHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameHeight.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // lblFrameWidth
            // 
            this.lblFrameWidth.AutoSize = true;
            this.lblFrameWidth.Location = new System.Drawing.Point(8, 232);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Size = new System.Drawing.Size(76, 13);
            this.lblFrameWidth.TabIndex = 50;
            this.lblFrameWidth.Text = "Frame Width:";
            // 
            // nudFrameWidth
            // 
            this.nudFrameWidth.Location = new System.Drawing.Point(128, 227);
            this.nudFrameWidth.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameWidth.Name = "nudFrameWidth";
            this.nudFrameWidth.Size = new System.Drawing.Size(48, 22);
            this.nudFrameWidth.TabIndex = 49;
            this.nudFrameWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameWidth.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // lblFramesPerRow
            // 
            this.lblFramesPerRow.AutoSize = true;
            this.lblFramesPerRow.Location = new System.Drawing.Point(8, 341);
            this.lblFramesPerRow.Name = "lblFramesPerRow";
            this.lblFramesPerRow.Size = new System.Drawing.Size(91, 13);
            this.lblFramesPerRow.TabIndex = 48;
            this.lblFramesPerRow.Text = "Frames Per Row:";
            // 
            // nudFramesPerRow
            // 
            this.nudFramesPerRow.Location = new System.Drawing.Point(128, 336);
            this.nudFramesPerRow.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFramesPerRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFramesPerRow.Name = "nudFramesPerRow";
            this.nudFramesPerRow.Size = new System.Drawing.Size(48, 22);
            this.nudFramesPerRow.TabIndex = 47;
            this.nudFramesPerRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFramesPerRow.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // lblFrameCount
            // 
            this.lblFrameCount.AutoSize = true;
            this.lblFrameCount.Location = new System.Drawing.Point(8, 317);
            this.lblFrameCount.Name = "lblFrameCount";
            this.lblFrameCount.Size = new System.Drawing.Size(104, 13);
            this.lblFrameCount.TabIndex = 46;
            this.lblFrameCount.Text = "Number of Frames:";
            // 
            // nudFrameCount
            // 
            this.nudFrameCount.Location = new System.Drawing.Point(128, 312);
            this.nudFrameCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameCount.Name = "nudFrameCount";
            this.nudFrameCount.Size = new System.Drawing.Size(48, 22);
            this.nudFrameCount.TabIndex = 45;
            this.nudFrameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameCount.ValueChanged += new System.EventHandler(this.nudMetaSprite_ValueChanged);
            // 
            // lblAutoFrameOptions
            // 
            this.lblAutoFrameOptions.AutoSize = true;
            this.lblAutoFrameOptions.Location = new System.Drawing.Point(8, 288);
            this.lblAutoFrameOptions.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutoFrameOptions.Name = "lblAutoFrameOptions";
            this.lblAutoFrameOptions.Size = new System.Drawing.Size(114, 13);
            this.lblAutoFrameOptions.TabIndex = 44;
            this.lblAutoFrameOptions.Text = "Auto Frame Options:";
            this.lblAutoFrameOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddFrame
            // 
            this.btnAddFrame.Location = new System.Drawing.Point(8, 216);
            this.btnAddFrame.Name = "btnAddFrame";
            this.btnAddFrame.Size = new System.Drawing.Size(88, 23);
            this.btnAddFrame.TabIndex = 41;
            this.btnAddFrame.Text = "Add";
            this.btnAddFrame.UseVisualStyleBackColor = true;
            this.btnAddFrame.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // lblSpriteMode
            // 
            this.lblSpriteMode.AutoSize = true;
            this.lblSpriteMode.Location = new System.Drawing.Point(8, 24);
            this.lblSpriteMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpriteMode.Name = "lblSpriteMode";
            this.lblSpriteMode.Size = new System.Drawing.Size(73, 13);
            this.lblSpriteMode.TabIndex = 35;
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
            this.cbSpriteMode.TabIndex = 36;
            this.cbSpriteMode.SelectedIndexChanged += new System.EventHandler(this.cbMetaSprite_SelectedIndexChanged);
            // 
            // lblSprPalette
            // 
            this.lblSprPalette.AutoSize = true;
            this.lblSprPalette.Location = new System.Drawing.Point(8, 68);
            this.lblSprPalette.Margin = new System.Windows.Forms.Padding(0);
            this.lblSprPalette.Name = "lblSprPalette";
            this.lblSprPalette.Size = new System.Drawing.Size(78, 13);
            this.lblSprPalette.TabIndex = 22;
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
            this.cbSprPalette.TabIndex = 23;
            this.cbSprPalette.SelectedIndexChanged += new System.EventHandler(this.cbMetaSprite_SelectedIndexChanged);
            // 
            // chkPaletteFromImage
            // 
            this.chkPaletteFromImage.AutoSize = true;
            this.chkPaletteFromImage.Location = new System.Drawing.Point(8, 448);
            this.chkPaletteFromImage.Name = "chkPaletteFromImage";
            this.chkPaletteFromImage.Size = new System.Drawing.Size(124, 17);
            this.chkPaletteFromImage.TabIndex = 16;
            this.chkPaletteFromImage.Text = "Palette From Image";
            this.chkPaletteFromImage.UseVisualStyleBackColor = true;
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.pnlMetaSpriteSelect);
            this.grpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImage.Location = new System.Drawing.Point(194, 3);
            this.grpImage.Name = "grpImage";
            this.grpImage.Padding = new System.Windows.Forms.Padding(8);
            this.grpImage.Size = new System.Drawing.Size(363, 398);
            this.grpImage.TabIndex = 1;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Frame Selection";
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
            // lblSpriteCount
            // 
            this.lblSpriteCount.AutoSize = true;
            this.tpnlMain.SetColumnSpan(this.lblSpriteCount, 2);
            this.lblSpriteCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpriteCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpriteCount.Location = new System.Drawing.Point(3, 510);
            this.lblSpriteCount.Name = "lblSpriteCount";
            this.lblSpriteCount.Size = new System.Drawing.Size(554, 27);
            this.lblSpriteCount.TabIndex = 5;
            this.lblSpriteCount.Text = "Frame Sprite Count: 0";
            this.lblSpriteCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFrameOptions
            // 
            this.grpFrameOptions.Controls.Add(this.btnMoveFrameDown);
            this.grpFrameOptions.Controls.Add(this.btnMoveFrameUp);
            this.grpFrameOptions.Controls.Add(this.btnRemoveFrame);
            this.grpFrameOptions.Controls.Add(this.btnSetFrame);
            this.grpFrameOptions.Controls.Add(this.btnInsertFrame);
            this.grpFrameOptions.Controls.Add(this.lstFrames);
            this.grpFrameOptions.Controls.Add(this.lblCurrentFrame);
            this.grpFrameOptions.Controls.Add(this.pnlCurrentFrame);
            this.grpFrameOptions.Controls.Add(this.btnAddFrame);
            this.grpFrameOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFrameOptions.Location = new System.Drawing.Point(563, 3);
            this.grpFrameOptions.Name = "grpFrameOptions";
            this.grpFrameOptions.Size = new System.Drawing.Size(192, 398);
            this.grpFrameOptions.TabIndex = 7;
            this.grpFrameOptions.TabStop = false;
            this.grpFrameOptions.Text = "Frame Options";
            // 
            // lblCurrentFrame
            // 
            this.lblCurrentFrame.AutoSize = true;
            this.lblCurrentFrame.Location = new System.Drawing.Point(12, 24);
            this.lblCurrentFrame.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentFrame.Name = "lblCurrentFrame";
            this.lblCurrentFrame.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentFrame.TabIndex = 38;
            this.lblCurrentFrame.Text = "Current Frame:";
            this.lblCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInsertFrame
            // 
            this.btnInsertFrame.Location = new System.Drawing.Point(96, 216);
            this.btnInsertFrame.Name = "btnInsertFrame";
            this.btnInsertFrame.Size = new System.Drawing.Size(88, 23);
            this.btnInsertFrame.TabIndex = 47;
            this.btnInsertFrame.Text = "Insert";
            this.btnInsertFrame.UseVisualStyleBackColor = true;
            this.btnInsertFrame.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // btnSetFrame
            // 
            this.btnSetFrame.Location = new System.Drawing.Point(8, 240);
            this.btnSetFrame.Name = "btnSetFrame";
            this.btnSetFrame.Size = new System.Drawing.Size(88, 23);
            this.btnSetFrame.TabIndex = 48;
            this.btnSetFrame.Text = "Set";
            this.btnSetFrame.UseVisualStyleBackColor = true;
            this.btnSetFrame.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // btnRemoveFrame
            // 
            this.btnRemoveFrame.Location = new System.Drawing.Point(96, 240);
            this.btnRemoveFrame.Name = "btnRemoveFrame";
            this.btnRemoveFrame.Size = new System.Drawing.Size(88, 23);
            this.btnRemoveFrame.TabIndex = 49;
            this.btnRemoveFrame.Text = "Remove";
            this.btnRemoveFrame.UseVisualStyleBackColor = true;
            this.btnRemoveFrame.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // btnMoveFrameUp
            // 
            this.btnMoveFrameUp.Location = new System.Drawing.Point(8, 264);
            this.btnMoveFrameUp.Name = "btnMoveFrameUp";
            this.btnMoveFrameUp.Size = new System.Drawing.Size(88, 23);
            this.btnMoveFrameUp.TabIndex = 50;
            this.btnMoveFrameUp.Text = "Move Up";
            this.btnMoveFrameUp.UseVisualStyleBackColor = true;
            this.btnMoveFrameUp.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // btnMoveFrameDown
            // 
            this.btnMoveFrameDown.Location = new System.Drawing.Point(96, 264);
            this.btnMoveFrameDown.Name = "btnMoveFrameDown";
            this.btnMoveFrameDown.Size = new System.Drawing.Size(88, 23);
            this.btnMoveFrameDown.TabIndex = 51;
            this.btnMoveFrameDown.Text = "Move Down";
            this.btnMoveFrameDown.UseVisualStyleBackColor = true;
            this.btnMoveFrameDown.Click += new System.EventHandler(this.btnMetaSprite_Click);
            // 
            // lblFrameSize
            // 
            this.lblFrameSize.AutoSize = true;
            this.lblFrameSize.Location = new System.Drawing.Point(8, 160);
            this.lblFrameSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblFrameSize.Name = "lblFrameSize";
            this.lblFrameSize.Size = new System.Drawing.Size(64, 13);
            this.lblFrameSize.TabIndex = 58;
            this.lblFrameSize.Text = "Frame Size:";
            this.lblFrameSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearAllFrames
            // 
            this.btnClearAllFrames.Location = new System.Drawing.Point(8, 392);
            this.btnClearAllFrames.Name = "btnClearAllFrames";
            this.btnClearAllFrames.Size = new System.Drawing.Size(168, 23);
            this.btnClearAllFrames.TabIndex = 59;
            this.btnClearAllFrames.Text = "Clear All Frames";
            this.btnClearAllFrames.UseVisualStyleBackColor = true;
            // 
            // chkAllowEmptySprites
            // 
            this.chkAllowEmptySprites.AutoSize = true;
            this.chkAllowEmptySprites.Location = new System.Drawing.Point(8, 424);
            this.chkAllowEmptySprites.Name = "chkAllowEmptySprites";
            this.chkAllowEmptySprites.Size = new System.Drawing.Size(127, 17);
            this.chkAllowEmptySprites.TabIndex = 60;
            this.chkAllowEmptySprites.Text = "Allow Empty Sprites";
            this.chkAllowEmptySprites.UseVisualStyleBackColor = true;
            // 
            // pnlSprPalette
            // 
            this.pnlSprPalette.Location = new System.Drawing.Point(8, 112);
            this.pnlSprPalette.Name = "pnlSprPalette";
            this.pnlSprPalette.ReadOnly = false;
            this.pnlSprPalette.Size = new System.Drawing.Size(168, 40);
            this.pnlSprPalette.TabIndex = 25;
            // 
            // pnlMetaSpriteSelect
            // 
            this.pnlMetaSpriteSelect.AutoScroll = true;
            this.pnlMetaSpriteSelect.AutoScrollMinSize = new System.Drawing.Size(347, 367);
            this.pnlMetaSpriteSelect.Canvas = new System.Drawing.Size(8, 8);
            this.pnlMetaSpriteSelect.Centered = true;
            this.pnlMetaSpriteSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaSpriteSelect.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlMetaSpriteSelect.HatchForeColor = System.Drawing.Color.White;
            this.pnlMetaSpriteSelect.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlMetaSpriteSelect.Image = null;
            this.pnlMetaSpriteSelect.ImageAlpha = 1F;
            this.pnlMetaSpriteSelect.ImageScale = 1;
            this.pnlMetaSpriteSelect.Location = new System.Drawing.Point(8, 23);
            this.pnlMetaSpriteSelect.MinimumScale = 1;
            this.pnlMetaSpriteSelect.Name = "pnlMetaSpriteSelect";
            this.pnlMetaSpriteSelect.Size = new System.Drawing.Size(347, 367);
            this.pnlMetaSpriteSelect.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlMetaSpriteSelect.SpriteModeType = SMSTileStudio.Data.SpriteModeType.Normal;
            this.pnlMetaSpriteSelect.TabIndex = 0;
            this.pnlMetaSpriteSelect.UseCanvas = false;
            this.pnlMetaSpriteSelect.UseHatch = true;
            this.pnlMetaSpriteSelect.UseMouseWheelScaling = true;
            // 
            // pnlPalette
            // 
            this.tpnlMain.SetColumnSpan(this.pnlPalette, 2);
            this.pnlPalette.Location = new System.Drawing.Point(194, 407);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(561, 100);
            this.pnlPalette.TabIndex = 6;
            this.pnlPalette.ColorShifted += new SMSTileStudio.Controls.PaletteSpriteControl.ColorShiftedHandler(this.pnlPalette_ColorShifted);
            this.pnlPalette.SelectedColorChanged += new SMSTileStudio.Controls.PaletteSpriteControl.SelectedColorChangedHandler(this.pnlPalette_SelectedColorChanged);
            // 
            // lstFrames
            // 
            this.lstFrames.DisableHighlighting = false;
            this.lstFrames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstFrames.FormattingEnabled = true;
            this.lstFrames.HorizontalExtent = 172;
            this.lstFrames.Location = new System.Drawing.Point(8, 296);
            this.lstFrames.Name = "lstFrames";
            this.lstFrames.Size = new System.Drawing.Size(176, 95);
            this.lstFrames.TabIndex = 46;
            this.lstFrames.TextOffsetX = 2;
            this.lstFrames.TextOffsetY = 0;
            this.lstFrames.SelectedIndexChanged += new System.EventHandler(this.lstFrames_SelectedIndexChanged);
            // 
            // pnlCurrentFrame
            // 
            this.pnlCurrentFrame.Canvas = new System.Drawing.Size(8, 8);
            this.pnlCurrentFrame.Centered = true;
            this.pnlCurrentFrame.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlCurrentFrame.HatchForeColor = System.Drawing.Color.White;
            this.pnlCurrentFrame.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlCurrentFrame.Image = null;
            this.pnlCurrentFrame.ImageAlpha = 1F;
            this.pnlCurrentFrame.ImageScale = 1;
            this.pnlCurrentFrame.Location = new System.Drawing.Point(13, 44);
            this.pnlCurrentFrame.MinimumScale = 1;
            this.pnlCurrentFrame.Name = "pnlCurrentFrame";
            this.pnlCurrentFrame.Size = new System.Drawing.Size(168, 168);
            this.pnlCurrentFrame.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlCurrentFrame.TabIndex = 39;
            this.pnlCurrentFrame.UseCanvas = false;
            this.pnlCurrentFrame.UseHatch = true;
            this.pnlCurrentFrame.UseMouseWheelScaling = true;
            // 
            // ImportMetaSpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 557);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportMetaSpriteForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Meta Sprite";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFramesPerRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameCount)).EndInit();
            this.grpImage.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.grpFrameOptions.ResumeLayout(false);
            this.grpFrameOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpOptions;
        private Controls.PaletteControl pnlSprPalette;
        private System.Windows.Forms.Label lblSprPalette;
        private System.Windows.Forms.ComboBox cbSprPalette;
        private System.Windows.Forms.CheckBox chkPaletteFromImage;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSpriteCount;
        private System.Windows.Forms.Label lblSpriteMode;
        private System.Windows.Forms.ComboBox cbSpriteMode;
        private Controls.PaletteSpriteControl pnlPalette;
        private Controls.MetaSpriteSelectControl pnlMetaSpriteSelect;
        private System.Windows.Forms.Button btnAddFrame;
        private System.Windows.Forms.Button btnAutoGenerateFrames;
        private System.Windows.Forms.Label lblFrameHeight;
        private System.Windows.Forms.NumericUpDown nudFrameHeight;
        private System.Windows.Forms.Label lblFrameWidth;
        private System.Windows.Forms.NumericUpDown nudFrameWidth;
        private System.Windows.Forms.Label lblFramesPerRow;
        private System.Windows.Forms.NumericUpDown nudFramesPerRow;
        private System.Windows.Forms.Label lblFrameCount;
        private System.Windows.Forms.NumericUpDown nudFrameCount;
        private System.Windows.Forms.Label lblAutoFrameOptions;
        private System.Windows.Forms.Label lblFrameY;
        private System.Windows.Forms.NumericUpDown nudFrameX;
        private System.Windows.Forms.Label lblFrameX;
        private System.Windows.Forms.NumericUpDown nudFrameY;
        private System.Windows.Forms.GroupBox grpFrameOptions;
        private System.Windows.Forms.Label lblCurrentFrame;
        private Controls.ImageControl pnlCurrentFrame;
        private System.Windows.Forms.Label lblFrameSize;
        private System.Windows.Forms.Button btnMoveFrameDown;
        private System.Windows.Forms.Button btnMoveFrameUp;
        private System.Windows.Forms.Button btnRemoveFrame;
        private System.Windows.Forms.Button btnSetFrame;
        private System.Windows.Forms.Button btnInsertFrame;
        private Controls.ListBoxControl lstFrames;
        private System.Windows.Forms.Button btnClearAllFrames;
        private System.Windows.Forms.CheckBox chkAllowEmptySprites;
    }
}