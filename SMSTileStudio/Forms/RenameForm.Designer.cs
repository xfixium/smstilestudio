namespace SMSTileStudio.Forms
{
    partial class RenameForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblContains = new System.Windows.Forms.Label();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.tpnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(82, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlMain.Controls.Add(this.txtReplace, 0, 3);
            this.tpnlMain.Controls.Add(this.lblReplace, 0, 2);
            this.tpnlMain.Controls.Add(this.pnlButtons, 1, 4);
            this.tpnlMain.Controls.Add(this.lblContains, 0, 0);
            this.tpnlMain.Controls.Add(this.txtContains, 0, 1);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(8, 8);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 6;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Size = new System.Drawing.Size(320, 129);
            this.tpnlMain.TabIndex = 13;
            // 
            // txtReplace
            // 
            this.tpnlMain.SetColumnSpan(this.txtReplace, 2);
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplace.Location = new System.Drawing.Point(3, 81);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(314, 22);
            this.txtReplace.TabIndex = 4;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.tpnlMain.SetColumnSpan(this.lblReplace, 2);
            this.lblReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReplace.Location = new System.Drawing.Point(3, 52);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(314, 26);
            this.lblReplace.TabIndex = 3;
            this.lblReplace.TabStop = true;
            this.lblReplace.Text = "Replace with:";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(160, 104);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(160, 26);
            this.pnlButtons.TabIndex = 0;
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.tpnlMain.SetColumnSpan(this.lblContains, 2);
            this.lblContains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContains.Location = new System.Drawing.Point(3, 0);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(314, 26);
            this.lblContains.TabIndex = 1;
            this.lblContains.TabStop = true;
            this.lblContains.Text = "Name contains:";
            this.lblContains.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContains
            // 
            this.tpnlMain.SetColumnSpan(this.txtContains, 2);
            this.txtContains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContains.Location = new System.Drawing.Point(3, 29);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(314, 22);
            this.txtContains.TabIndex = 2;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 145);
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bulk Rename";
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblContains;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblReplace;
    }
}