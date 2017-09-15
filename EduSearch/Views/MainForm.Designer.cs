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
            this.searchPanel = new EduSearch.Custom.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.leftPanel = new EduSearch.Custom.CustomPanel();
            this.lblLog = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.indexPanel = new EduSearch.Custom.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIndex = new EduSearch.Custom.CustomLabel();
            this.btnIndex = new System.Windows.Forms.Button();
            this.tbIndexLocation = new System.Windows.Forms.TextBox();
            this.tbCollection = new System.Windows.Forms.TextBox();
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.navPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.indexPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.AutoSize = true;
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.lblTitle);
            this.navPanel.Controls.Add(this.lblMinim);
            this.navPanel.Controls.Add(this.lblExit);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.MinimumSize = new System.Drawing.Size(200, 30);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(876, 31);
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
            this.lblMinim.Size = new System.Drawing.Size(51, 31);
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
            this.lblExit.Size = new System.Drawing.Size(52, 31);
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
            this.bodyPanel.Controls.Add(this.searchPanel);
            this.bodyPanel.Controls.Add(this.leftPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 31);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(876, 509);
            this.bodyPanel.TabIndex = 3;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.tbSearch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(287, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(589, 509);
            this.searchPanel.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(465, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(60, 49);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(408, 33);
            this.tbSearch.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.lblLog);
            this.leftPanel.Controls.Add(this.lbLog);
            this.leftPanel.Controls.Add(this.indexPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(287, 509);
            this.leftPanel.TabIndex = 4;
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(4, 231);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(195, 23);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "Log";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalExtent = 100;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(4, 257);
            this.lbLog.Name = "lbLog";
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(278, 247);
            this.lbLog.TabIndex = 4;
            this.lbLog.TabStop = false;
            // 
            // indexPanel
            // 
            this.indexPanel.Controls.Add(this.pictureBox1);
            this.indexPanel.Controls.Add(this.lblIndex);
            this.indexPanel.Controls.Add(this.btnIndex);
            this.indexPanel.Controls.Add(this.tbIndexLocation);
            this.indexPanel.Controls.Add(this.tbCollection);
            this.indexPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.indexPanel.Location = new System.Drawing.Point(0, 0);
            this.indexPanel.Name = "indexPanel";
            this.indexPanel.Size = new System.Drawing.Size(287, 228);
            this.indexPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(15, 6);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(256, 31);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIndex
            // 
            this.btnIndex.Enabled = false;
            this.btnIndex.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex.Location = new System.Drawing.Point(15, 112);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(256, 35);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Create Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // tbIndexLocation
            // 
            this.tbIndexLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndexLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbIndexLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexLocation.ForeColor = System.Drawing.Color.Black;
            this.tbIndexLocation.Location = new System.Drawing.Point(15, 72);
            this.tbIndexLocation.Name = "tbIndexLocation";
            this.tbIndexLocation.ReadOnly = true;
            this.tbIndexLocation.Size = new System.Drawing.Size(256, 19);
            this.tbIndexLocation.TabIndex = 1;
            this.tbIndexLocation.Text = "<index location>";
            this.tbIndexLocation.Click += new System.EventHandler(this.tbIndexLocation_Click);
            // 
            // tbCollection
            // 
            this.tbCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCollection.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCollection.ForeColor = System.Drawing.Color.Black;
            this.tbCollection.Location = new System.Drawing.Point(15, 42);
            this.tbCollection.Name = "tbCollection";
            this.tbCollection.ReadOnly = true;
            this.tbCollection.Size = new System.Drawing.Size(256, 19);
            this.tbCollection.TabIndex = 0;
            this.tbCollection.Text = "<collection>";
            this.tbCollection.Click += new System.EventHandler(this.tbCollection_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 27);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "EduSearch";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.indexPanel.ResumeLayout(false);
            this.indexPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lblMinim;
        private System.Windows.Forms.Label lblExit;
        private Custom.CustomPanel bodyPanel;
        private Custom.CustomPanel indexPanel;
        private System.Windows.Forms.TextBox tbIndexLocation;
        private System.Windows.Forms.TextBox tbCollection;
        private System.Windows.Forms.Button btnIndex;
        private Custom.CustomLabel lblIndex;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Custom.CustomLabel lblTitle;
        private Custom.CustomPanel leftPanel;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.CustomPanel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

