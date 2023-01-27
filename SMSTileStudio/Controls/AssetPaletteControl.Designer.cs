namespace SMSTileStudio.Controls
{
    partial class AssetPaletteControl
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
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpPaletteList = new System.Windows.Forms.GroupBox();
            this.lstPalettes = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlPaletteEdit = new System.Windows.Forms.Panel();
            this.tpnlPalette = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lstPaletteReferences = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlReferences = new System.Windows.Forms.Panel();
            this.lblPaletteName = new System.Windows.Forms.Label();
            this.lblPaletteReferences = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPaletteLength = new System.Windows.Forms.Label();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.cbSwatch = new System.Windows.Forms.ComboBox();
            this.pnlPalette = new SMSTileStudio.Controls.PaletteControl();
            this.lblColorSwatch = new System.Windows.Forms.Label();
            this.pnlSwatch = new SMSTileStudio.Controls.ImageControl();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.lblCreatePalette = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpPaletteList.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlPaletteEdit.SuspendLayout();
            this.tpnlPalette.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlReferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.mnuExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Controls.Add(this.grpPaletteList, 0, 0);
            this.tpnlMain.Controls.Add(this.pnlPaletteEdit, 1, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 557);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(884, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Palette information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPaletteList
            // 
            this.grpPaletteList.Controls.Add(this.lstPalettes);
            this.grpPaletteList.Controls.Add(this.pnlButtons);
            this.grpPaletteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaletteList.Location = new System.Drawing.Point(0, 0);
            this.grpPaletteList.Margin = new System.Windows.Forms.Padding(0);
            this.grpPaletteList.Name = "grpPaletteList";
            this.grpPaletteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpPaletteList.Size = new System.Drawing.Size(196, 557);
            this.grpPaletteList.TabIndex = 0;
            this.grpPaletteList.TabStop = false;
            this.grpPaletteList.Text = "Palettes";
            // 
            // lstPalettes
            // 
            this.lstPalettes.DisableHighlighting = false;
            this.lstPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalettes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPalettes.FormattingEnabled = true;
            this.lstPalettes.HorizontalExtent = 168;
            this.lstPalettes.IntegralHeight = false;
            this.lstPalettes.ItemHeight = 15;
            this.lstPalettes.Location = new System.Drawing.Point(12, 136);
            this.lstPalettes.Name = "lstPalettes";
            this.lstPalettes.Size = new System.Drawing.Size(172, 409);
            this.lstPalettes.TabIndex = 1;
            this.lstPalettes.TextOffsetX = 2;
            this.lstPalettes.TextOffsetY = 0;
            this.lstPalettes.SelectedIndexChanged += new System.EventHandler(this.lstPalettes_SelectedIndexChanged);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExport);
            this.pnlButtons.Controls.Add(this.btnImport);
            this.pnlButtons.Controls.Add(this.btnRemove);
            this.pnlButtons.Controls.Add(this.btnDuplicate);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(172, 117);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 92);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 69);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Palette";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(0, 46);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Palette";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 23);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 1;
            this.btnDuplicate.Text = "Duplicate Palette";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Palette";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // pnlPaletteEdit
            // 
            this.pnlPaletteEdit.Controls.Add(this.tpnlPalette);
            this.pnlPaletteEdit.Controls.Add(this.lblCreatePalette);
            this.pnlPaletteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteEdit.Location = new System.Drawing.Point(199, 3);
            this.pnlPaletteEdit.Name = "pnlPaletteEdit";
            this.pnlPaletteEdit.Size = new System.Drawing.Size(688, 551);
            this.pnlPaletteEdit.TabIndex = 1;
            // 
            // tpnlPalette
            // 
            this.tpnlPalette.ColumnCount = 7;
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlPalette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlPalette.Controls.Add(this.pnlOptions, 6, 0);
            this.tpnlPalette.Controls.Add(this.lblSelectColor, 2, 0);
            this.tpnlPalette.Controls.Add(this.cbSwatch, 3, 2);
            this.tpnlPalette.Controls.Add(this.pnlPalette, 2, 1);
            this.tpnlPalette.Controls.Add(this.lblColorSwatch, 2, 2);
            this.tpnlPalette.Controls.Add(this.pnlSwatch, 1, 3);
            this.tpnlPalette.Controls.Add(this.btnShiftLeft, 1, 1);
            this.tpnlPalette.Controls.Add(this.btnShiftRight, 4, 1);
            this.tpnlPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlPalette.Location = new System.Drawing.Point(0, 0);
            this.tpnlPalette.Name = "tpnlPalette";
            this.tpnlPalette.RowCount = 5;
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalette.Size = new System.Drawing.Size(688, 551);
            this.tpnlPalette.TabIndex = 0;
            this.tpnlPalette.Visible = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lstPaletteReferences);
            this.pnlOptions.Controls.Add(this.pnlReferences);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(508, 6);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tpnlPalette.SetRowSpan(this.pnlOptions, 5);
            this.pnlOptions.Size = new System.Drawing.Size(180, 545);
            this.pnlOptions.TabIndex = 5;
            this.pnlOptions.Visible = false;
            // 
            // lstPaletteReferences
            // 
            this.lstPaletteReferences.DisableHighlighting = false;
            this.lstPaletteReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPaletteReferences.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPaletteReferences.FormattingEnabled = true;
            this.lstPaletteReferences.HorizontalExtent = 168;
            this.lstPaletteReferences.HorizontalScrollbar = true;
            this.lstPaletteReferences.IntegralHeight = false;
            this.lstPaletteReferences.Location = new System.Drawing.Point(8, 96);
            this.lstPaletteReferences.Name = "lstPaletteReferences";
            this.lstPaletteReferences.Size = new System.Drawing.Size(172, 449);
            this.lstPaletteReferences.TabIndex = 1;
            this.lstPaletteReferences.TextOffsetX = 2;
            this.lstPaletteReferences.TextOffsetY = 0;
            // 
            // pnlReferences
            // 
            this.pnlReferences.Controls.Add(this.lblPaletteName);
            this.pnlReferences.Controls.Add(this.lblPaletteReferences);
            this.pnlReferences.Controls.Add(this.nudLength);
            this.pnlReferences.Controls.Add(this.txtName);
            this.pnlReferences.Controls.Add(this.lblPaletteLength);
            this.pnlReferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReferences.Location = new System.Drawing.Point(8, 0);
            this.pnlReferences.Name = "pnlReferences";
            this.pnlReferences.Size = new System.Drawing.Size(172, 96);
            this.pnlReferences.TabIndex = 0;
            // 
            // lblPaletteName
            // 
            this.lblPaletteName.AutoSize = true;
            this.lblPaletteName.Location = new System.Drawing.Point(0, 0);
            this.lblPaletteName.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteName.Name = "lblPaletteName";
            this.lblPaletteName.Size = new System.Drawing.Size(77, 13);
            this.lblPaletteName.TabIndex = 0;
            this.lblPaletteName.Text = "Palette Name:";
            this.lblPaletteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaletteReferences
            // 
            this.lblPaletteReferences.AutoSize = true;
            this.lblPaletteReferences.Location = new System.Drawing.Point(0, 80);
            this.lblPaletteReferences.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteReferences.Name = "lblPaletteReferences";
            this.lblPaletteReferences.Size = new System.Drawing.Size(137, 13);
            this.lblPaletteReferences.TabIndex = 4;
            this.lblPaletteReferences.Text = "Assets Using This Palette:";
            this.lblPaletteReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(0, 56);
            this.nudLength.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(168, 22);
            this.nudLength.TabIndex = 3;
            this.nudLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLength.ValueChanged += new System.EventHandler(this.nudLength_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 16);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPaletteLength
            // 
            this.lblPaletteLength.AutoSize = true;
            this.lblPaletteLength.Location = new System.Drawing.Point(0, 40);
            this.lblPaletteLength.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaletteLength.Name = "lblPaletteLength";
            this.lblPaletteLength.Size = new System.Drawing.Size(87, 13);
            this.lblPaletteLength.TabIndex = 2;
            this.lblPaletteLength.Text = "Output Length:";
            this.lblPaletteLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.AutoSize = true;
            this.tpnlPalette.SetColumnSpan(this.lblSelectColor, 2);
            this.lblSelectColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectColor.Location = new System.Drawing.Point(114, 0);
            this.lblSelectColor.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelectColor.Name = "lblSelectColor";
            this.lblSelectColor.Size = new System.Drawing.Size(280, 26);
            this.lblSelectColor.TabIndex = 0;
            this.lblSelectColor.Text = "Select Color To Edit:";
            this.lblSelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSwatch
            // 
            this.cbSwatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSwatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwatch.FormattingEnabled = true;
            this.cbSwatch.Location = new System.Drawing.Point(245, 105);
            this.cbSwatch.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbSwatch.Name = "cbSwatch";
            this.cbSwatch.Size = new System.Drawing.Size(139, 21);
            this.cbSwatch.TabIndex = 3;
            this.cbSwatch.SelectedIndexChanged += new System.EventHandler(this.cbSwatch_SelectedIndexChanged);
            // 
            // pnlPalette
            // 
            this.tpnlPalette.SetColumnSpan(this.pnlPalette, 2);
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPalette.Location = new System.Drawing.Point(118, 29);
            this.pnlPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.ReadOnly = false;
            this.pnlPalette.Size = new System.Drawing.Size(272, 70);
            this.pnlPalette.TabIndex = 1;
            // 
            // lblColorSwatch
            // 
            this.lblColorSwatch.AutoSize = true;
            this.lblColorSwatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColorSwatch.Location = new System.Drawing.Point(114, 102);
            this.lblColorSwatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblColorSwatch.Name = "lblColorSwatch";
            this.lblColorSwatch.Size = new System.Drawing.Size(128, 27);
            this.lblColorSwatch.TabIndex = 2;
            this.lblColorSwatch.Text = "Color Swatch:";
            this.lblColorSwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSwatch
            // 
            this.pnlSwatch.Canvas = new System.Drawing.Size(292, 292);
            this.pnlSwatch.Centered = true;
            this.tpnlPalette.SetColumnSpan(this.pnlSwatch, 4);
            this.pnlSwatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSwatch.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlSwatch.HatchForeColor = System.Drawing.Color.White;
            this.pnlSwatch.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlSwatch.Image = global::SMSTileStudio.Properties.Resources.swatch_aseprite;
            this.pnlSwatch.ImageAlpha = 1F;
            this.pnlSwatch.ImageScale = 1;
            this.pnlSwatch.Location = new System.Drawing.Point(-83, 132);
            this.pnlSwatch.MinimumScale = 1;
            this.pnlSwatch.Name = "pnlSwatch";
            this.pnlSwatch.Size = new System.Drawing.Size(674, 309);
            this.pnlSwatch.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlSwatch.TabIndex = 4;
            this.pnlSwatch.UseCanvas = false;
            this.pnlSwatch.UseHatch = false;
            this.pnlSwatch.UseMouseWheelScaling = false;
            this.pnlSwatch.Click += new System.EventHandler(this.pnlSwatch_Click);
            this.pnlSwatch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSwatch_MouseMove);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShiftLeft.Location = new System.Drawing.Point(89, 29);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(22, 70);
            this.btnShiftLeft.TabIndex = 6;
            this.btnShiftLeft.Text = "<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShiftRight.Location = new System.Drawing.Point(397, 29);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(22, 70);
            this.btnShiftRight.TabIndex = 7;
            this.btnShiftRight.Text = ">";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // lblCreatePalette
            // 
            this.lblCreatePalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatePalette.Location = new System.Drawing.Point(0, 0);
            this.lblCreatePalette.Name = "lblCreatePalette";
            this.lblCreatePalette.Size = new System.Drawing.Size(688, 551);
            this.lblCreatePalette.TabIndex = 6;
            this.lblCreatePalette.Text = "Create or select a palette to edit";
            this.lblCreatePalette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuExport
            // 
            this.mnuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportImage,
            this.mnuExportBinary,
            this.mnuExportHex,
            this.mnuExportAssembly});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(240, 92);
            // 
            // mnuExportImage
            // 
            this.mnuExportImage.Name = "mnuExportImage";
            this.mnuExportImage.Size = new System.Drawing.Size(239, 22);
            this.mnuExportImage.Text = "Export as Image";
            this.mnuExportImage.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(239, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(239, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuExportHex.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(239, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuExportAssembly.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // AssetPaletteControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetPaletteControl";
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.ResumeLayout(false);
            this.grpPaletteList.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlPaletteEdit.ResumeLayout(false);
            this.tpnlPalette.ResumeLayout(false);
            this.tpnlPalette.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlReferences.ResumeLayout(false);
            this.pnlReferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.mnuExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpPaletteList;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRemove;
        private ListBoxControl lstPalettes;
        private System.Windows.Forms.Panel pnlPaletteEdit;
        private PaletteControl pnlPalette;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblColorSwatch;
        private System.Windows.Forms.Label lblSelectColor;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.ComboBox cbSwatch;
        private System.Windows.Forms.TableLayoutPanel tpnlPalette;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlOptions;
        private ListBoxControl lstPaletteReferences;
        private System.Windows.Forms.Panel pnlReferences;
        private System.Windows.Forms.Label lblPaletteName;
        private System.Windows.Forms.Label lblPaletteReferences;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPaletteLength;
        private ImageControl pnlSwatch;
        private System.Windows.Forms.Label lblCreatePalette;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportImage;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuExportHex;
        private System.Windows.Forms.ToolStripMenuItem mnuExportAssembly;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Label lblInfo;
    }
}
