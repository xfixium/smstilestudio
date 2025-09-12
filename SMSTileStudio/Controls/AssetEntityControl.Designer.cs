namespace SMSTileStudio.Controls
{
    partial class AssetEntityControl
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
            this.mnuExportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnlEntities = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDataEntryOptions = new System.Windows.Forms.Panel();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnTilemapOptions = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.pnlEntityGraphic = new SMSTileStudio.Controls.ImageControl();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDataEntryComments = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpnlFields = new System.Windows.Forms.TableLayoutPanel();
            this.mnuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportHex = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstEntities = new SMSTileStudio.Controls.ListBoxControl();
            this.pnlDataEntryButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpDataEntryList = new System.Windows.Forms.GroupBox();
            this.lblCreateEntity = new System.Windows.Forms.Label();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tpnlEntities.SuspendLayout();
            this.pnlDataEntryOptions.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuExport.SuspendLayout();
            this.pnlDataEntryButtons.SuspendLayout();
            this.grpDataEntryList.SuspendLayout();
            this.pnlDataEntry.SuspendLayout();
            this.tpnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuExportAssembly
            // 
            this.mnuExportAssembly.Name = "mnuExportAssembly";
            this.mnuExportAssembly.Size = new System.Drawing.Size(238, 22);
            this.mnuExportAssembly.Text = "Export as Assembly (Clipboard)";
            // 
            // mnuExportBinary
            // 
            this.mnuExportBinary.Name = "mnuExportBinary";
            this.mnuExportBinary.Size = new System.Drawing.Size(238, 22);
            this.mnuExportBinary.Text = "Export as Binary";
            this.mnuExportBinary.Click += new System.EventHandler(this.mnuEntity_Click);
            // 
            // tpnlEntities
            // 
            this.tpnlEntities.ColumnCount = 2;
            this.tpnlEntities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tpnlEntities.Controls.Add(this.pnlDataEntryOptions, 1, 0);
            this.tpnlEntities.Controls.Add(this.panel1, 0, 0);
            this.tpnlEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlEntities.Location = new System.Drawing.Point(0, 0);
            this.tpnlEntities.Name = "tpnlEntities";
            this.tpnlEntities.RowCount = 1;
            this.tpnlEntities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlEntities.Size = new System.Drawing.Size(694, 557);
            this.tpnlEntities.TabIndex = 13;
            this.tpnlEntities.Visible = false;
            // 
            // pnlDataEntryOptions
            // 
            this.pnlDataEntryOptions.Controls.Add(this.txtComments);
            this.pnlDataEntryOptions.Controls.Add(this.pnlOptions);
            this.pnlDataEntryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntryOptions.Location = new System.Drawing.Point(534, 0);
            this.pnlDataEntryOptions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataEntryOptions.Name = "pnlDataEntryOptions";
            this.pnlDataEntryOptions.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnlDataEntryOptions.Size = new System.Drawing.Size(160, 557);
            this.pnlDataEntryOptions.TabIndex = 2;
            // 
            // txtComments
            // 
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(4, 200);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(156, 357);
            this.txtComments.TabIndex = 11;
            this.txtComments.TextChanged += new System.EventHandler(this.txtEntity_TextChanged);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnTilemapOptions);
            this.pnlOptions.Controls.Add(this.label33);
            this.pnlOptions.Controls.Add(this.pnlEntityGraphic);
            this.pnlOptions.Controls.Add(this.lblName);
            this.pnlOptions.Controls.Add(this.lblDataEntryComments);
            this.pnlOptions.Controls.Add(this.txtName);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(4, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(156, 200);
            this.pnlOptions.TabIndex = 12;
            // 
            // btnTilemapOptions
            // 
            this.btnTilemapOptions.Location = new System.Drawing.Point(0, 158);
            this.btnTilemapOptions.Name = "btnTilemapOptions";
            this.btnTilemapOptions.Size = new System.Drawing.Size(152, 23);
            this.btnTilemapOptions.TabIndex = 21;
            this.btnTilemapOptions.Text = "Set Entity Graphic";
            this.btnTilemapOptions.UseVisualStyleBackColor = true;
            this.btnTilemapOptions.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(0, 40);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Entity Graphic:";
            // 
            // pnlEntityGraphic
            // 
            this.pnlEntityGraphic.Canvas = new System.Drawing.Size(8, 8);
            this.pnlEntityGraphic.Centered = false;
            this.pnlEntityGraphic.HatchBackColor = System.Drawing.Color.DarkGray;
            this.pnlEntityGraphic.HatchForeColor = System.Drawing.Color.White;
            this.pnlEntityGraphic.HatchStyle = System.Drawing.Drawing2D.HatchStyle.OutlinedDiamond;
            this.pnlEntityGraphic.Image = null;
            this.pnlEntityGraphic.ImageAlpha = 1F;
            this.pnlEntityGraphic.ImageScale = 1;
            this.pnlEntityGraphic.Location = new System.Drawing.Point(32, 58);
            this.pnlEntityGraphic.MinimumScale = 1;
            this.pnlEntityGraphic.Name = "pnlEntityGraphic";
            this.pnlEntityGraphic.Size = new System.Drawing.Size(96, 96);
            this.pnlEntityGraphic.SnapSize = new System.Drawing.Size(8, 8);
            this.pnlEntityGraphic.TabIndex = 11;
            this.pnlEntityGraphic.UseCanvas = false;
            this.pnlEntityGraphic.UseHatch = true;
            this.pnlEntityGraphic.UseMouseWheelScaling = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Entity Name:";
            // 
            // lblDataEntryComments
            // 
            this.lblDataEntryComments.AutoSize = true;
            this.lblDataEntryComments.Location = new System.Drawing.Point(0, 182);
            this.lblDataEntryComments.Name = "lblDataEntryComments";
            this.lblDataEntryComments.Size = new System.Drawing.Size(64, 13);
            this.lblDataEntryComments.TabIndex = 10;
            this.lblDataEntryComments.Text = "Comments:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 16);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtEntity_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tpnlFields);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel1.Size = new System.Drawing.Size(534, 557);
            this.panel1.TabIndex = 3;
            // 
            // tpnlFields
            // 
            this.tpnlFields.AutoSize = true;
            this.tpnlFields.ColumnCount = 6;
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlFields.Location = new System.Drawing.Point(8, 8);
            this.tpnlFields.Name = "tpnlFields";
            this.tpnlFields.RowCount = 1;
            this.tpnlFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 557F));
            this.tpnlFields.Size = new System.Drawing.Size(509, 557);
            this.tpnlFields.TabIndex = 4;
            // 
            // mnuExport
            // 
            this.mnuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportBinary,
            this.mnuExportHex,
            this.mnuExportAssembly});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(239, 92);
            // 
            // mnuExportHex
            // 
            this.mnuExportHex.Name = "mnuExportHex";
            this.mnuExportHex.Size = new System.Drawing.Size(238, 22);
            this.mnuExportHex.Text = "Export as Hex (Clipboard)";
            // 
            // lblInfo
            // 
            this.tpnlMain.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 557);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(884, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "No Entity information";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Location = new System.Drawing.Point(0, 92);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(172, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import Entities";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddField.Location = new System.Drawing.Point(0, 69);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(172, 23);
            this.btnAddField.TabIndex = 2;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(0, 46);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(172, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Entity";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 23);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(172, 23);
            this.btnDuplicate.TabIndex = 3;
            this.btnDuplicate.Text = "Duplicate Entity";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Entity";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // lstEntities
            // 
            this.lstEntities.DisableHighlighting = false;
            this.lstEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.HorizontalExtent = 168;
            this.lstEntities.IntegralHeight = false;
            this.lstEntities.ItemHeight = 15;
            this.lstEntities.Location = new System.Drawing.Point(12, 159);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(172, 386);
            this.lstEntities.TabIndex = 1;
            this.lstEntities.TextOffsetX = 2;
            this.lstEntities.TextOffsetY = 0;
            this.lstEntities.SelectedIndexChanged += new System.EventHandler(this.lstEntities_SelectedIndexChanged);
            // 
            // pnlDataEntryButtons
            // 
            this.pnlDataEntryButtons.Controls.Add(this.btnExport);
            this.pnlDataEntryButtons.Controls.Add(this.btnImport);
            this.pnlDataEntryButtons.Controls.Add(this.btnAddField);
            this.pnlDataEntryButtons.Controls.Add(this.btnRemove);
            this.pnlDataEntryButtons.Controls.Add(this.btnDuplicate);
            this.pnlDataEntryButtons.Controls.Add(this.btnNew);
            this.pnlDataEntryButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataEntryButtons.Location = new System.Drawing.Point(12, 19);
            this.pnlDataEntryButtons.Name = "pnlDataEntryButtons";
            this.pnlDataEntryButtons.Size = new System.Drawing.Size(172, 140);
            this.pnlDataEntryButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.Location = new System.Drawing.Point(0, 115);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Options";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // grpDataEntryList
            // 
            this.grpDataEntryList.Controls.Add(this.lstEntities);
            this.grpDataEntryList.Controls.Add(this.pnlDataEntryButtons);
            this.grpDataEntryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataEntryList.Location = new System.Drawing.Point(0, 0);
            this.grpDataEntryList.Margin = new System.Windows.Forms.Padding(0);
            this.grpDataEntryList.Name = "grpDataEntryList";
            this.grpDataEntryList.Padding = new System.Windows.Forms.Padding(12, 4, 12, 12);
            this.grpDataEntryList.Size = new System.Drawing.Size(196, 557);
            this.grpDataEntryList.TabIndex = 0;
            this.grpDataEntryList.TabStop = false;
            this.grpDataEntryList.Text = "Entities";
            // 
            // lblCreateEntity
            // 
            this.lblCreateEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateEntity.Location = new System.Drawing.Point(0, 0);
            this.lblCreateEntity.Name = "lblCreateEntity";
            this.lblCreateEntity.Size = new System.Drawing.Size(694, 557);
            this.lblCreateEntity.TabIndex = 7;
            this.lblCreateEntity.Text = "Create or select an Entity to edit";
            this.lblCreateEntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.Controls.Add(this.tpnlEntities);
            this.pnlDataEntry.Controls.Add(this.lblCreateEntity);
            this.pnlDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntry.Location = new System.Drawing.Point(196, 0);
            this.pnlDataEntry.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(694, 557);
            this.pnlDataEntry.TabIndex = 14;
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Controls.Add(this.pnlDataEntry, 1, 0);
            this.tpnlMain.Controls.Add(this.grpDataEntryList, 0, 0);
            this.tpnlMain.Controls.Add(this.lblInfo, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.Size = new System.Drawing.Size(890, 583);
            this.tpnlMain.TabIndex = 13;
            // 
            // AssetEntityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssetEntityControl";
            this.Size = new System.Drawing.Size(890, 583);
            this.tpnlEntities.ResumeLayout(false);
            this.pnlDataEntryOptions.ResumeLayout(false);
            this.pnlDataEntryOptions.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuExport.ResumeLayout(false);
            this.pnlDataEntryButtons.ResumeLayout(false);
            this.grpDataEntryList.ResumeLayout(false);
            this.pnlDataEntry.ResumeLayout(false);
            this.tpnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuExportAssembly;
        private System.Windows.Forms.ToolStripMenuItem mnuExportBinary;
        private System.Windows.Forms.TableLayoutPanel tpnlEntities;
        private System.Windows.Forms.Panel pnlDataEntryOptions;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDataEntryComments;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportHex;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Label lblCreateEntity;
        private System.Windows.Forms.GroupBox grpDataEntryList;
        private ListBoxControl lstEntities;
        private System.Windows.Forms.Panel pnlDataEntryButtons;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnNew;
        private ImageControl pnlEntityGraphic;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnTilemapOptions;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tpnlFields;
    }
}
