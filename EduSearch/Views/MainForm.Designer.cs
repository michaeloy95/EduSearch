namespace EduSearch.Views
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.lblMinim = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bodyPanel = new EduSearch.Custom.CustomPanel();
            this.indexPanel = new EduSearch.Custom.CustomPanel();
            this.btnIndex = new System.Windows.Forms.Button();
            this.statusPanel = new EduSearch.Custom.CustomPanel();
            this.lblIndexStatus = new EduSearch.Custom.CustomLabel();
            this.tbIndexLocation = new System.Windows.Forms.TextBox();
            this.tbCollection = new System.Windows.Forms.TextBox();
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.navPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.indexPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.AutoSize = true;
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.lblMinim);
            this.navPanel.Controls.Add(this.lblExit);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.MinimumSize = new System.Drawing.Size(200, 30);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(876, 30);
            this.navPanel.TabIndex = 0;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseDown);
            // 
            // lblMinim
            // 
            this.lblMinim.BackColor = System.Drawing.Color.Transparent;
            this.lblMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinim.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinim.ForeColor = System.Drawing.Color.Black;
            this.lblMinim.Location = new System.Drawing.Point(773, 0);
            this.lblMinim.Name = "lblMinim";
            this.lblMinim.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblMinim.Size = new System.Drawing.Size(51, 30);
            this.lblMinim.TabIndex = 2;
            this.lblMinim.Text = "_";
            this.lblMinim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinim.Click += new System.EventHandler(this.lblMinim_Click);
            this.lblMinim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMinim_MouseDown);
            this.lblMinim.MouseLeave += new System.EventHandler(this.lblMinim_MouseLeave);
            this.lblMinim.MouseHover += new System.EventHandler(this.lblMinim_MouseHover);
            this.lblMinim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblMinim_MouseUp);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(824, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblExit.Size = new System.Drawing.Size(52, 30);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseDown);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            this.lblExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseUp);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.Transparent;
            this.bodyPanel.Controls.Add(this.indexPanel);
            this.bodyPanel.Controls.Add(this.lblTitle);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 30);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(876, 510);
            this.bodyPanel.TabIndex = 3;
            // 
            // indexPanel
            // 
            this.indexPanel.Controls.Add(this.btnIndex);
            this.indexPanel.Controls.Add(this.statusPanel);
            this.indexPanel.Controls.Add(this.tbIndexLocation);
            this.indexPanel.Controls.Add(this.tbCollection);
            this.indexPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexPanel.Location = new System.Drawing.Point(0, 0);
            this.indexPanel.Name = "indexPanel";
            this.indexPanel.Size = new System.Drawing.Size(876, 106);
            this.indexPanel.TabIndex = 3;
            // 
            // btnIndex
            // 
            this.btnIndex.Enabled = false;
            this.btnIndex.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex.Location = new System.Drawing.Point(302, 66);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(275, 35);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Create Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.lblIndexStatus);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(876, 25);
            this.statusPanel.TabIndex = 2;
            // 
            // lblIndexStatus
            // 
            this.lblIndexStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndexStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexStatus.Location = new System.Drawing.Point(0, 0);
            this.lblIndexStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblIndexStatus.Name = "lblIndexStatus";
            this.lblIndexStatus.Size = new System.Drawing.Size(876, 25);
            this.lblIndexStatus.TabIndex = 0;
            this.lblIndexStatus.Text = "Determine collection and index location...";
            this.lblIndexStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIndexLocation
            // 
            this.tbIndexLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndexLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbIndexLocation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexLocation.Location = new System.Drawing.Point(459, 34);
            this.tbIndexLocation.Name = "tbIndexLocation";
            this.tbIndexLocation.ReadOnly = true;
            this.tbIndexLocation.Size = new System.Drawing.Size(396, 24);
            this.tbIndexLocation.TabIndex = 1;
            this.tbIndexLocation.Text = "<index location>";
            this.tbIndexLocation.Click += new System.EventHandler(this.tbIndexLocation_Click);
            // 
            // tbCollection
            // 
            this.tbCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCollection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCollection.Location = new System.Drawing.Point(24, 34);
            this.tbCollection.Name = "tbCollection";
            this.tbCollection.ReadOnly = true;
            this.tbCollection.Size = new System.Drawing.Size(396, 24);
            this.tbCollection.TabIndex = 0;
            this.tbCollection.Text = "<collection>";
            this.tbCollection.Click += new System.EventHandler(this.tbCollection_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(287, 180);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 103);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "EduSearch";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(876, 540);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.navPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.navPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.indexPanel.ResumeLayout(false);
            this.indexPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lblMinim;
        private System.Windows.Forms.Label lblExit;
        private Custom.CustomPanel bodyPanel;
        private Custom.CustomLabel lblTitle;
        private Custom.CustomPanel indexPanel;
        private Custom.CustomPanel statusPanel;
        private System.Windows.Forms.TextBox tbIndexLocation;
        private System.Windows.Forms.TextBox tbCollection;
        private System.Windows.Forms.Button btnIndex;
        private Custom.CustomLabel lblIndexStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

