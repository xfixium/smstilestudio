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
            this.tpnlPalettes = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstPalettes = new SMSTileStudio.Controls.ListBoxControl();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlGameGearLegend = new System.Windows.Forms.Panel();
            this.pnlGameGearOuterBorder = new System.Windows.Forms.Panel();
            this.pnlGameGearInnerBorder = new System.Windows.Forms.Panel();
            this.pnlGameGear = new System.Windows.Forms.Panel();
            this.lblGameGearColors = new System.Windows.Forms.Label();
            this.pnlPaletteEdit = new System.Windows.Forms.Panel();
            this.tpnlPalette = new System.Windows.Forms.TableLayoutPanel();
            this.tpnlOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lstPaletteReferences = new SMSTileStudio.Controls.ListBoxControl();
            this.lblPaletteReferences = new System.Windows.Forms.Label();
            this.lblPaletteName = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPaletteLength = new System.Windows.Forms.Label();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.cbSwatch = new System.Windows.Forms.ComboBox();
            this.pnlPalette = new SMSTileStudio.Controls.PaletteControl();
            this.lblColorSwatch = new System.Windows.Forms.Label();
            this.pnlSwatch = new SMSTileStudio.Controls.ImageControl();
            this.btnColorApply = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.tpnlColor = new System.Windows.Forms.TableLayoutPanel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.cbRed = new System.Windows.Forms.ComboBox();
            this.cbGreen = new System.Windows.Forms.ComboBox();
            this.cbBlue = new System.Windows.Forms.ComboBox();
            this.lblCreatePalette = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlMain.SuspendLayout();
            this.grpPaletteList.SuspendLayout();
            this.tpnlPalettes.SuspendLayout();
            this.pnlGameGearLegend.SuspendLayout();
            this.pnlGameGearOuterBorder.SuspendLayout();
            this.pnlGameGearInnerBorder.SuspendLayout();
            this.pnlPaletteEdit.SuspendLayout();
            this.tpnlPalette.SuspendLayout();
            this.tpnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.tpnlColor.SuspendLayout();
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
            this.tpnlMain.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 479);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(764, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Palette information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPaletteList
            // 
            this.grpPaletteList.Controls.Add(this.tpnlPalettes);
            this.grpPaletteList.Controls.Add(this.pnlGameGearLegend);
            this.grpPaletteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaletteList.Location = new System.Drawing.Point(0, 0);
            this.grpPaletteList.Margin = new System.Windows.Forms.Padding(0);
            this.grpPaletteList.Name = "grpPaletteList";
            this.grpPaletteList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpPaletteList.Size = new System.Drawing.Size(196, 479);
            this.grpPaletteList.TabIndex = 0;
            this.grpPaletteList.TabStop = false;
            this.grpPaletteList.Text = "Palettes";
            // 
            // tpnlPalettes
            // 
            this.tpnlPalettes.ColumnCount = 1;
            this.tpnlPalettes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalettes.Controls.Add(this.btnExport, 0, 4);
            this.tpnlPalettes.Controls.Add(this.lstPalettes, 0, 5);
            this.tpnlPalettes.Controls.Add(this.btnNew, 0, 0);
            this.tpnlPalettes.Controls.Add(this.btnImport, 0, 1);
            this.tpnlPalettes.Controls.Add(this.btnDuplicate, 0, 2);
            this.tpnlPalettes.Controls.Add(this.btnRemove, 0, 3);
            this.tpnlPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlPalettes.Location = new System.Drawing.Point(12, 19);
            this.tpnlPalettes.Name = "tpnlPalettes";
            this.tpnlPalettes.RowCount = 6;
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlPalettes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalettes.Size = new System.Drawing.Size(172, 429);
            this.tpnlPalettes.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(2, 96);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 24);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // lstPalettes
            // 
            this.lstPalettes.DisableHighlighting = false;
            this.lstPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalettes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPalettes.FormattingEnabled = true;
            this.lstPalettes.HorizontalExtent = 162;
            this.lstPalettes.IntegralHeight = false;
            this.lstPalettes.ItemHeight = 15;
            this.lstPalettes.Location = new System.Drawing.Point(3, 123);
            this.lstPalettes.Name = "lstPalettes";
            this.lstPalettes.Size = new System.Drawing.Size(166, 303);
            this.lstPalettes.TabIndex = 1;
            this.lstPalettes.TextOffsetX = 2;
            this.lstPalettes.TextOffsetY = 0;
            this.lstPalettes.SelectedIndexChanged += new System.EventHandler(this.lstPalettes_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(2, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Palette";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImport.Location = new System.Drawing.Point(2, 24);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(168, 24);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Palette";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicate.Location = new System.Drawing.Point(2, 48);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(168, 24);
            this.btnDuplicate.TabIndex = 1;
            this.btnDuplicate.Text = "Duplicate Palette";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(2, 72);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Palette";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // pnlGameGearLegend
            // 
            this.pnlGameGearLegend.Controls.Add(this.pnlGameGearOuterBorder);
            this.pnlGameGearLegend.Controls.Add(this.lblGameGearColors);
            this.pnlGameGearLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGameGearLegend.Location = new System.Drawing.Point(12, 448);
            this.pnlGameGearLegend.Name = "pnlGameGearLegend";
            this.pnlGameGearLegend.Size = new System.Drawing.Size(172, 19);
            this.pnlGameGearLegend.TabIndex = 2;
            // 
            // pnlGameGearOuterBorder
            // 
            this.pnlGameGearOuterBorder.BackColor = System.Drawing.Color.Black;
            this.pnlGameGearOuterBorder.Controls.Add(this.pnlGameGearInnerBorder);
            this.pnlGameGearOuterBorder.Location = new System.Drawing.Point(4, 3);
            this.pnlGameGearOuterBorder.Name = "pnlGameGearOuterBorder";
            this.pnlGameGearOuterBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGameGearOuterBorder.Size = new System.Drawing.Size(16, 16);
            this.pnlGameGearOuterBorder.TabIndex = 1;
            // 
            // pnlGameGearInnerBorder
            // 
            this.pnlGameGearInnerBorder.BackColor = System.Drawing.Color.White;
            this.pnlGameGearInnerBorder.Controls.Add(this.pnlGameGear);
            this.pnlGameGearInnerBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameGearInnerBorder.Location = new System.Drawing.Point(1, 1);
            this.pnlGameGearInnerBorder.Name = "pnlGameGearInnerBorder";
            this.pnlGameGearInnerBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlGameGearInnerBorder.Size = new System.Drawing.Size(14, 14);
            this.pnlGameGearInnerBorder.TabIndex = 2;
            // 
            // pnlGameGear
            // 
            this.pnlGameGear.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlGameGear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameGear.Location = new System.Drawing.Point(1, 1);
            this.pnlGameGear.Name = "pnlGameGear";
            this.pnlGameGear.Size = new System.Drawing.Size(12, 12);
            this.pnlGameGear.TabIndex = 3;
            // 
            // lblGameGearColors
            // 
            this.lblGameGearColors.AutoSize = true;
            this.lblGameGearColors.Location = new System.Drawing.Point(24, 5);
            this.lblGameGearColors.Name = "lblGameGearColors";
            this.lblGameGearColors.Size = new System.Drawing.Size(146, 13);
            this.lblGameGearColors.TabIndex = 0;
            this.lblGameGearColors.Text = "Contains Game Gear colors";
            // 
            // pnlPaletteEdit
            // 
            this.pnlPaletteEdit.Controls.Add(this.tpnlPalette);
            this.pnlPaletteEdit.Controls.Add(this.lblCreatePalette);
            this.pnlPaletteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteEdit.Location = new System.Drawing.Point(199, 3);
            this.pnlPaletteEdit.Name = "pnlPaletteEdit";
            this.pnlPaletteEdit.Size = new System.Drawing.Size(568, 473);
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
            this.tpnlPalette.Controls.Add(this.tpnlOptions, 6, 0);
            this.tpnlPalette.Controls.Add(this.lblSelectColor, 2, 0);
            this.tpnlPalette.Controls.Add(this.cbSwatch, 3, 3);
            this.tpnlPalette.Controls.Add(this.pnlPalette, 2, 1);
            this.tpnlPalette.Controls.Add(this.lblColorSwatch, 2, 3);
            this.tpnlPalette.Controls.Add(this.pnlSwatch, 1, 4);
            this.tpnlPalette.Controls.Add(this.btnColorApply, 4, 2);
            this.tpnlPalette.Controls.Add(this.btnShiftLeft, 1, 1);
            this.tpnlPalette.Controls.Add(this.btnShiftRight, 4, 1);
            this.tpnlPalette.Controls.Add(this.tpnlColor, 2, 2);
            this.tpnlPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlPalette.Location = new System.Drawing.Point(0, 0);
            this.tpnlPalette.Name = "tpnlPalette";
            this.tpnlPalette.RowCount = 6;
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 315F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlPalette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlPalette.Size = new System.Drawing.Size(568, 473);
            this.tpnlPalette.TabIndex = 0;
            this.tpnlPalette.Visible = false;
            // 
            // tpnlOptions
            // 
            this.tpnlOptions.ColumnCount = 1;
            this.tpnlOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlOptions.Controls.Add(this.lstPaletteReferences, 0, 5);
            this.tpnlOptions.Controls.Add(this.lblPaletteReferences, 0, 4);
            this.tpnlOptions.Controls.Add(this.lblPaletteName, 0, 0);
            this.tpnlOptions.Controls.Add(this.nudLength, 0, 3);
            this.tpnlOptions.Controls.Add(this.txtName, 0, 1);
            this.tpnlOptions.Controls.Add(this.lblPaletteLength, 0, 2);
            this.tpnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlOptions.Location = new System.Drawing.Point(391, 3);
            this.tpnlOptions.Name = "tpnlOptions";
            this.tpnlOptions.RowCount = 6;
            this.tpnlPalette.SetRowSpan(this.tpnlOptions, 6);
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tpnlOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlOptions.Size = new System.Drawing.Size(174, 467);
            this.tpnlOptions.TabIndex = 10;
            // 
            // lstPaletteReferences
            // 
            this.lstPaletteReferences.DisableHighlighting = false;
            this.lstPaletteReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPaletteReferences.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPaletteReferences.FormattingEnabled = true;
            this.lstPaletteReferences.HorizontalExtent = 164;
            this.lstPaletteReferences.HorizontalScrollbar = true;
            this.lstPaletteReferences.IntegralHeight = false;
            this.lstPaletteReferences.Location = new System.Drawing.Point(3, 105);
            this.lstPaletteReferences.Name = "lstPaletteReferences";
            this.lstPaletteReferences.Size = new System.Drawing.Size(168, 359);
            this.lstPaletteReferences.TabIndex = 1;
            this.lstPaletteReferences.TextOffsetX = 2;
            this.lstPaletteReferences.TextOffsetY = 0;
            // 
            // lblPaletteReferences
            // 
            this.lblPaletteReferences.AutoSize = true;
            this.lblPaletteReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaletteReferences.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaletteReferences.Location = new System.Drawing.Point(2, 86);
            this.lblPaletteReferences.Margin = new System.Windows.Forms.Padding(2);
            this.lblPaletteReferences.Name = "lblPaletteReferences";
            this.lblPaletteReferences.Size = new System.Drawing.Size(170, 14);
            this.lblPaletteReferences.TabIndex = 4;
            this.lblPaletteReferences.Text = "Assets Using This Palette:";
            this.lblPaletteReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaletteName
            // 
            this.lblPaletteName.AutoSize = true;
            this.lblPaletteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaletteName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaletteName.Location = new System.Drawing.Point(2, 2);
            this.lblPaletteName.Margin = new System.Windows.Forms.Padding(2);
            this.lblPaletteName.Name = "lblPaletteName";
            this.lblPaletteName.Size = new System.Drawing.Size(170, 14);
            this.lblPaletteName.TabIndex = 0;
            this.lblPaletteName.Text = "Palette Name:";
            this.lblPaletteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudLength
            // 
            this.nudLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLength.Location = new System.Drawing.Point(2, 62);
            this.nudLength.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudLength.Size = new System.Drawing.Size(170, 22);
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
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(2, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblPaletteLength
            // 
            this.lblPaletteLength.AutoSize = true;
            this.lblPaletteLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaletteLength.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaletteLength.Location = new System.Drawing.Point(2, 44);
            this.lblPaletteLength.Margin = new System.Windows.Forms.Padding(2);
            this.lblPaletteLength.Name = "lblPaletteLength";
            this.lblPaletteLength.Size = new System.Drawing.Size(170, 14);
            this.lblPaletteLength.TabIndex = 2;
            this.lblPaletteLength.Text = "Output Length:";
            this.lblPaletteLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.AutoSize = true;
            this.tpnlPalette.SetColumnSpan(this.lblSelectColor, 2);
            this.lblSelectColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectColor.Location = new System.Drawing.Point(54, 0);
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
            this.cbSwatch.Location = new System.Drawing.Point(185, 132);
            this.cbSwatch.Name = "cbSwatch";
            this.cbSwatch.Size = new System.Drawing.Size(146, 21);
            this.cbSwatch.TabIndex = 3;
            this.cbSwatch.SelectedIndexChanged += new System.EventHandler(this.cbSwatch_SelectedIndexChanged);
            // 
            // pnlPalette
            // 
            this.tpnlPalette.SetColumnSpan(this.pnlPalette, 2);
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPalette.Location = new System.Drawing.Point(58, 29);
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
            this.lblColorSwatch.Location = new System.Drawing.Point(54, 129);
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
            this.pnlSwatch.Location = new System.Drawing.Point(-143, 159);
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
            // btnColorApply
            // 
            this.btnColorApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColorApply.Location = new System.Drawing.Point(334, 103);
            this.btnColorApply.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnColorApply.Name = "btnColorApply";
            this.btnColorApply.Size = new System.Drawing.Size(54, 26);
            this.btnColorApply.TabIndex = 9;
            this.btnColorApply.Text = "Apply";
            this.btnColorApply.UseVisualStyleBackColor = true;
            this.btnColorApply.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShiftLeft.Location = new System.Drawing.Point(29, 29);
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
            this.btnShiftRight.Location = new System.Drawing.Point(337, 29);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(22, 70);
            this.btnShiftRight.TabIndex = 7;
            this.btnShiftRight.Text = ">";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // tpnlColor
            // 
            this.tpnlColor.ColumnCount = 6;
            this.tpnlPalette.SetColumnSpan(this.tpnlColor, 2);
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tpnlColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlColor.Controls.Add(this.lblBlue, 4, 0);
            this.tpnlColor.Controls.Add(this.lblGreen, 2, 0);
            this.tpnlColor.Controls.Add(this.lblRed, 0, 0);
            this.tpnlColor.Controls.Add(this.cbRed, 1, 0);
            this.tpnlColor.Controls.Add(this.cbGreen, 3, 0);
            this.tpnlColor.Controls.Add(this.cbBlue, 5, 0);
            this.tpnlColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlColor.Location = new System.Drawing.Point(54, 102);
            this.tpnlColor.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlColor.Name = "tpnlColor";
            this.tpnlColor.RowCount = 1;
            this.tpnlColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlColor.Size = new System.Drawing.Size(280, 27);
            this.tpnlColor.TabIndex = 8;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue.Location = new System.Drawing.Point(188, 0);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(40, 27);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Text = "Blue:";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen.Location = new System.Drawing.Point(90, 0);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(48, 27);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green:";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed.Location = new System.Drawing.Point(0, 0);
            this.lblRed.Margin = new System.Windows.Forms.Padding(0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(40, 27);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red:";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRed
            // 
            this.cbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRed.FormattingEnabled = true;
            this.cbRed.Items.AddRange(new object[] {
            "0",
            "17",
            "34",
            "51",
            "68",
            "85",
            "102",
            "119",
            "136",
            "153",
            "170",
            "187",
            "204",
            "221",
            "238",
            "255"});
            this.cbRed.Location = new System.Drawing.Point(43, 3);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(44, 21);
            this.cbRed.TabIndex = 1;
            // 
            // cbGreen
            // 
            this.cbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGreen.FormattingEnabled = true;
            this.cbGreen.Items.AddRange(new object[] {
            "0",
            "17",
            "34",
            "51",
            "68",
            "85",
            "102",
            "119",
            "136",
            "153",
            "170",
            "187",
            "204",
            "221",
            "238",
            "255"});
            this.cbGreen.Location = new System.Drawing.Point(141, 3);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(44, 21);
            this.cbGreen.TabIndex = 3;
            // 
            // cbBlue
            // 
            this.cbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlue.FormattingEnabled = true;
            this.cbBlue.Items.AddRange(new object[] {
            "0",
            "17",
            "34",
            "51",
            "68",
            "85",
            "102",
            "119",
            "136",
            "153",
            "170",
            "187",
            "204",
            "221",
            "238",
            "255"});
            this.cbBlue.Location = new System.Drawing.Point(231, 3);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(46, 21);
            this.cbBlue.TabIndex = 5;
            // 
            // lblCreatePalette
            // 
            this.lblCreatePalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreatePalette.Location = new System.Drawing.Point(0, 0);
            this.lblCreatePalette.Name = "lblCreatePalette";
            this.lblCreatePalette.Size = new System.Drawing.Size(568, 473);
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
            this.mnuExport.Size = new System.Drawing.Size(239, 92);
            // 
            // mnuExportImage
            // 
            this.mnuExportImage.Name = "mnuExportImage";
            this.mnuExportImage.Size = new System.Drawing.Size(238, 22);
            this.mnuExportImage.Text = "Export as Image";
            this.mnuExportImage.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            this.mnuExportHex.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            this.mnuExportAssembly.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // AssetPaletteControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetPaletteControl";
            this.Size = new System.Drawing.Size(770, 505);
            this.tpnlMain.ResumeLayout(false);
            this.grpPaletteList.ResumeLayout(false);
            this.tpnlPalettes.ResumeLayout(false);
            this.pnlGameGearLegend.ResumeLayout(false);
            this.pnlGameGearLegend.PerformLayout();
            this.pnlGameGearOuterBorder.ResumeLayout(false);
            this.pnlGameGearInnerBorder.ResumeLayout(false);
            this.pnlPaletteEdit.ResumeLayout(false);
            this.tpnlPalette.ResumeLayout(false);
            this.tpnlPalette.PerformLayout();
            this.tpnlOptions.ResumeLayout(false);
            this.tpnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.tpnlColor.ResumeLayout(false);
            this.tpnlColor.PerformLayout();
            this.mnuExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.GroupBox grpPaletteList;
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
        private ListBoxControl lstPaletteReferences;
        private System.Windows.Forms.Button btnImport;
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
        private System.Windows.Forms.Panel pnlGameGearLegend;
        private System.Windows.Forms.Panel pnlGameGearOuterBorder;
        private System.Windows.Forms.Panel pnlGameGearInnerBorder;
        private System.Windows.Forms.Panel pnlGameGear;
        private System.Windows.Forms.Label lblGameGearColors;
        private System.Windows.Forms.TableLayoutPanel tpnlColor;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.ComboBox cbRed;
        private System.Windows.Forms.ComboBox cbGreen;
        private System.Windows.Forms.ComboBox cbBlue;
        private System.Windows.Forms.Button btnColorApply;
        private System.Windows.Forms.TableLayoutPanel tpnlOptions;
        private System.Windows.Forms.TableLayoutPanel tpnlPalettes;
    }
}
