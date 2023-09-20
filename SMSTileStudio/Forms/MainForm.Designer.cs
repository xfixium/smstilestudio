namespace SMSTileStudio.Forms
{
    partial class MainForm
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPalettes = new System.Windows.Forms.TabPage();
            this.pnlPalettes = new SMSTileStudio.Controls.AssetPaletteControl();
            this.tabTilemap = new System.Windows.Forms.TabPage();
            this.pnlTilemaps = new SMSTileStudio.Controls.AssetTilemapControl();
            this.tabMetaSprites = new System.Windows.Forms.TabPage();
            this.pnlMetaSprites = new SMSTileStudio.Controls.AssetMetaSpriteControl();
            this.tabDialogs = new System.Windows.Forms.TabPage();
            this.pnlDialogs = new SMSTileStudio.Controls.AssetDialogControl();
            this.tabDataEntry = new System.Windows.Forms.TabPage();
            this.pnlDataEntries = new SMSTileStudio.Controls.AssetDataEntryControl();
            this.tabEntities = new System.Windows.Forms.TabPage();
            this.pnlEntities = new SMSTileStudio.Controls.AssetEntityControl();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tabPalettes.SuspendLayout();
            this.tabTilemap.SuspendLayout();
            this.tabMetaSprites.SuspendLayout();
            this.tabDialogs.SuspendLayout();
            this.tabDataEntry.SuspendLayout();
            this.tabEntities.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPalettes);
            this.tabMain.Controls.Add(this.tabTilemap);
            this.tabMain.Controls.Add(this.tabMetaSprites);
            this.tabMain.Controls.Add(this.tabDialogs);
            this.tabMain.Controls.Add(this.tabDataEntry);
            this.tabMain.Controls.Add(this.tabEntities);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 537);
            this.tabMain.TabIndex = 1;
            // 
            // tabPalettes
            // 
            this.tabPalettes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPalettes.Controls.Add(this.pnlPalettes);
            this.tabPalettes.Location = new System.Drawing.Point(4, 22);
            this.tabPalettes.Name = "tabPalettes";
            this.tabPalettes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPalettes.Size = new System.Drawing.Size(776, 511);
            this.tabPalettes.TabIndex = 1;
            this.tabPalettes.Text = "Palettes";
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalettes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPalettes.Loading = true;
            this.pnlPalettes.Location = new System.Drawing.Point(3, 3);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(770, 505);
            this.pnlPalettes.TabIndex = 0;
            this.pnlPalettes.AssetsChanged += new SMSTileStudio.Controls.AssetControl.AssetsChangedHandler(this.pnlPalette_AssetsChanged);
            // 
            // tabTilemap
            // 
            this.tabTilemap.BackColor = System.Drawing.SystemColors.Control;
            this.tabTilemap.Controls.Add(this.pnlTilemaps);
            this.tabTilemap.Location = new System.Drawing.Point(4, 22);
            this.tabTilemap.Name = "tabTilemap";
            this.tabTilemap.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilemap.Size = new System.Drawing.Size(776, 511);
            this.tabTilemap.TabIndex = 2;
            this.tabTilemap.Text = "Tilemaps";
            // 
            // pnlTilemaps
            // 
            this.pnlTilemaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilemaps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTilemaps.Loading = true;
            this.pnlTilemaps.Location = new System.Drawing.Point(3, 3);
            this.pnlTilemaps.Name = "pnlTilemaps";
            this.pnlTilemaps.Size = new System.Drawing.Size(770, 505);
            this.pnlTilemaps.TabIndex = 1;
            // 
            // tabMetaSprites
            // 
            this.tabMetaSprites.BackColor = System.Drawing.SystemColors.Control;
            this.tabMetaSprites.Controls.Add(this.pnlMetaSprites);
            this.tabMetaSprites.Location = new System.Drawing.Point(4, 22);
            this.tabMetaSprites.Name = "tabMetaSprites";
            this.tabMetaSprites.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetaSprites.Size = new System.Drawing.Size(776, 511);
            this.tabMetaSprites.TabIndex = 4;
            this.tabMetaSprites.Text = "Meta Sprites";
            // 
            // pnlMetaSprites
            // 
            this.pnlMetaSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetaSprites.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMetaSprites.Loading = true;
            this.pnlMetaSprites.Location = new System.Drawing.Point(3, 3);
            this.pnlMetaSprites.Name = "pnlMetaSprites";
            this.pnlMetaSprites.Size = new System.Drawing.Size(770, 505);
            this.pnlMetaSprites.TabIndex = 0;
            // 
            // tabDialogs
            // 
            this.tabDialogs.BackColor = System.Drawing.SystemColors.Control;
            this.tabDialogs.Controls.Add(this.pnlDialogs);
            this.tabDialogs.Location = new System.Drawing.Point(4, 22);
            this.tabDialogs.Name = "tabDialogs";
            this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogs.Size = new System.Drawing.Size(776, 511);
            this.tabDialogs.TabIndex = 5;
            this.tabDialogs.Text = "Dialogs";
            // 
            // pnlDialogs
            // 
            this.pnlDialogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDialogs.Loading = true;
            this.pnlDialogs.Location = new System.Drawing.Point(3, 3);
            this.pnlDialogs.Name = "pnlDialogs";
            this.pnlDialogs.Size = new System.Drawing.Size(770, 505);
            this.pnlDialogs.TabIndex = 0;
            // 
            // tabDataEntry
            // 
            this.tabDataEntry.BackColor = System.Drawing.SystemColors.Control;
            this.tabDataEntry.Controls.Add(this.pnlDataEntries);
            this.tabDataEntry.Location = new System.Drawing.Point(4, 22);
            this.tabDataEntry.Name = "tabDataEntry";
            this.tabDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataEntry.Size = new System.Drawing.Size(776, 511);
            this.tabDataEntry.TabIndex = 6;
            this.tabDataEntry.Text = "Data Entry";
            // 
            // pnlDataEntries
            // 
            this.pnlDataEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataEntries.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataEntries.Loading = true;
            this.pnlDataEntries.Location = new System.Drawing.Point(3, 3);
            this.pnlDataEntries.Name = "pnlDataEntries";
            this.pnlDataEntries.Size = new System.Drawing.Size(770, 505);
            this.pnlDataEntries.TabIndex = 0;
            // 
            // tabEntities
            // 
            this.tabEntities.BackColor = System.Drawing.SystemColors.Control;
            this.tabEntities.Controls.Add(this.pnlEntities);
            this.tabEntities.Location = new System.Drawing.Point(4, 22);
            this.tabEntities.Name = "tabEntities";
            this.tabEntities.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntities.Size = new System.Drawing.Size(776, 511);
            this.tabEntities.TabIndex = 7;
            this.tabEntities.Text = "Entities";
            // 
            // pnlEntities
            // 
            this.pnlEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntities.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEntities.Loading = true;
            this.pnlEntities.Location = new System.Drawing.Point(3, 3);
            this.pnlEntities.Name = "pnlEntities";
            this.pnlEntities.Size = new System.Drawing.Size(770, 505);
            this.pnlEntities.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(784, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenProject,
            this.mnuSave,
            this.mnuSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpenProject
            // 
            this.mnuOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpenProject.Name = "mnuOpenProject";
            this.mnuOpenProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenProject.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenProject.Text = "&Open Project";
            this.mnuOpenProject.Click += new System.EventHandler(this.mnuOpenProject_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(186, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(186, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Tile Studio";
            this.tabMain.ResumeLayout(false);
            this.tabPalettes.ResumeLayout(false);
            this.tabTilemap.ResumeLayout(false);
            this.tabMetaSprites.ResumeLayout(false);
            this.tabDialogs.ResumeLayout(false);
            this.tabDataEntry.ResumeLayout(false);
            this.tabEntities.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPalettes;
        private System.Windows.Forms.TabPage tabTilemap;
        private System.Windows.Forms.TabPage tabMetaSprites;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private Controls.AssetPaletteControl pnlPalettes;
        private Controls.AssetTilemapControl pnlTilemaps;
        private Controls.AssetMetaSpriteControl pnlMetaSprites;
        private System.Windows.Forms.TabPage tabDialogs;
        private Controls.AssetDialogControl pnlDialogs;
        private System.Windows.Forms.TabPage tabDataEntry;
        private Controls.AssetDataEntryControl pnlDataEntries;
        private System.Windows.Forms.TabPage tabEntities;
        private Controls.AssetEntityControl pnlEntities;
    }
}

