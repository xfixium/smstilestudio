namespace SMSTileStudio.Controls
{
    partial class CharacterItemControl
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
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.nudTileID = new System.Windows.Forms.NumericUpDown();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkSelected = new System.Windows.Forms.CheckBox();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudTileID)).BeginInit();
            this.tpnlMain.SuspendLayout();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCharacter
            // 
            this.txtCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCharacter.Location = new System.Drawing.Point(23, 5);
            this.txtCharacter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txtCharacter.MaxLength = 1;
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(22, 22);
            this.txtCharacter.TabIndex = 0;
            this.txtCharacter.Text = "A";
            this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
            // 
            // nudTileID
            // 
            this.nudTileID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTileID.Location = new System.Drawing.Point(51, 5);
            this.nudTileID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.nudTileID.Maximum = new decimal(new int[] {
            253,
            0,
            0,
            0});
            this.nudTileID.Name = "nudTileID";
            this.nudTileID.Size = new System.Drawing.Size(183, 22);
            this.nudTileID.TabIndex = 2;
            this.nudTileID.ValueChanged += new System.EventHandler(this.nudIndex_ValueChanged);
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 4;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpnlMain.Controls.Add(this.nudTileID, 2, 0);
            this.tpnlMain.Controls.Add(this.txtCharacter, 1, 0);
            this.tpnlMain.Controls.Add(this.btnOptions, 3, 0);
            this.tpnlMain.Controls.Add(this.chkSelected, 0, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 1;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Size = new System.Drawing.Size(269, 32);
            this.tpnlMain.TabIndex = 3;
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptions.Location = new System.Drawing.Point(240, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(26, 26);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "...";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnCharacterMap_Click);
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSelected.Location = new System.Drawing.Point(3, 3);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(14, 26);
            this.chkSelected.TabIndex = 6;
            this.chkSelected.Text = "checkBox1";
            this.chkSelected.UseVisualStyleBackColor = true;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoveUp,
            this.mnuMoveDown,
            this.mnuSeparator1,
            this.mnuInsert,
            this.mnuRemove});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(185, 98);
            // 
            // mnuMoveUp
            // 
            this.mnuMoveUp.Name = "mnuMoveUp";
            this.mnuMoveUp.Size = new System.Drawing.Size(184, 22);
            this.mnuMoveUp.Text = "Move Up List";
            this.mnuMoveUp.Click += new System.EventHandler(this.mnuCharacterMap_Click);
            // 
            // mnuMoveDown
            // 
            this.mnuMoveDown.Name = "mnuMoveDown";
            this.mnuMoveDown.Size = new System.Drawing.Size(184, 22);
            this.mnuMoveDown.Text = "Move Down List";
            this.mnuMoveDown.Click += new System.EventHandler(this.mnuCharacterMap_Click);
            // 
            // mnuSeparator1
            // 
            this.mnuSeparator1.Name = "mnuSeparator1";
            this.mnuSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.Size = new System.Drawing.Size(184, 22);
            this.mnuInsert.Text = "Insert New Character";
            this.mnuInsert.Click += new System.EventHandler(this.mnuCharacterMap_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(184, 22);
            this.mnuRemove.Text = "Remove Character";
            this.mnuRemove.Click += new System.EventHandler(this.mnuCharacterMap_Click);
            // 
            // CharacterItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CharacterItemControl";
            this.Size = new System.Drawing.Size(269, 32);
            ((System.ComponentModel.ISupportInitialize)(this.nudTileID)).EndInit();
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.NumericUpDown nudTileID;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.CheckBox chkSelected;
    }
}
