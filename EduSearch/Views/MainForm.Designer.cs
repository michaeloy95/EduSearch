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
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.lblMinim = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bodyPanel = new EduSearch.Custom.CustomPanel();
            this.searchPanel = new EduSearch.Custom.CustomPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPage = new EduSearch.Custom.CustomLabel();
            this.lblSearchTime = new EduSearch.Custom.CustomLabel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.resultPanel = new EduSearch.Custom.CustomPanel();
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
            this.navPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanel.MinimumSize = new System.Drawing.Size(267, 37);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1168, 38);
            this.navPanel.TabIndex = 0;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "EduSearch";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinim
            // 
            this.lblMinim.BackColor = System.Drawing.Color.Transparent;
            this.lblMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinim.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinim.ForeColor = System.Drawing.Color.Black;
            this.lblMinim.Location = new System.Drawing.Point(1031, 0);
            this.lblMinim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinim.Name = "lblMinim";
            this.lblMinim.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblMinim.Size = new System.Drawing.Size(68, 38);
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
            this.lblExit.Location = new System.Drawing.Point(1099, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblExit.Size = new System.Drawing.Size(69, 38);
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
            this.bodyPanel.Location = new System.Drawing.Point(0, 38);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1168, 627);
            this.bodyPanel.TabIndex = 3;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.btnSave);
            this.searchPanel.Controls.Add(this.lblPage);
            this.searchPanel.Controls.Add(this.lblSearchTime);
            this.searchPanel.Controls.Add(this.btnNextPage);
            this.searchPanel.Controls.Add(this.btnPrevPage);
            this.searchPanel.Controls.Add(this.resultPanel);
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.tbSearch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(383, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(785, 627);
            this.searchPanel.TabIndex = 5;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 114);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(365, 592);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(50, 20);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "1/100";
            this.lblPage.Visible = false;
            // 
            // lblSearchTime
            // 
            this.lblSearchTime.AutoSize = true;
            this.lblSearchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTime.Location = new System.Drawing.Point(76, 108);
            this.lblSearchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTime.Name = "lblSearchTime";
            this.lblSearchTime.Size = new System.Drawing.Size(254, 20);
            this.lblSearchTime.TabIndex = 10;
            this.lblSearchTime.Text = "100 results found (0.07 seconds)";
            this.lblSearchTime.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(652, 588);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(100, 28);
            this.btnNextPage.TabIndex = 9;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Visible = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(40, 588);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(100, 28);
            this.btnPrevPage.TabIndex = 8;
            this.btnPrevPage.Text = "Previous";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Visible = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.Location = new System.Drawing.Point(40, 144);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(711, 437);
            this.resultPanel.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(620, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 46);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(80, 60);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(544, 42);
            this.tbSearch.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.lblLog);
            this.leftPanel.Controls.Add(this.lbLog);
            this.leftPanel.Controls.Add(this.indexPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(383, 627);
            this.leftPanel.TabIndex = 4;
            // 
            // lblLog
            // 
            this.lblLog.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(5, 284);
            this.lblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(260, 28);
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
            this.lbLog.ItemHeight = 17;
            this.lbLog.Location = new System.Drawing.Point(5, 316);
            this.lbLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLog.Name = "lbLog";
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(371, 289);
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
            this.indexPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.indexPanel.Name = "indexPanel";
            this.indexPanel.Size = new System.Drawing.Size(383, 281);
            this.indexPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(137, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(20, 7);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(341, 38);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIndex
            // 
            this.btnIndex.Enabled = false;
            this.btnIndex.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex.Location = new System.Drawing.Point(20, 138);
            this.btnIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(341, 43);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Create Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // tbIndexLocation
            // 
            this.tbIndexLocation.BackColor = System.Drawing.Color.White;
            this.tbIndexLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndexLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbIndexLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexLocation.ForeColor = System.Drawing.Color.Black;
            this.tbIndexLocation.Location = new System.Drawing.Point(20, 89);
            this.tbIndexLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIndexLocation.Name = "tbIndexLocation";
            this.tbIndexLocation.ReadOnly = true;
            this.tbIndexLocation.Size = new System.Drawing.Size(341, 23);
            this.tbIndexLocation.TabIndex = 1;
            this.tbIndexLocation.Text = "<index location>";
            this.tbIndexLocation.Click += new System.EventHandler(this.tbIndexLocation_Click);
            // 
            // tbCollection
            // 
            this.tbCollection.BackColor = System.Drawing.Color.White;
            this.tbCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCollection.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCollection.ForeColor = System.Drawing.Color.Black;
            this.tbCollection.Location = new System.Drawing.Point(20, 52);
            this.tbCollection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCollection.Name = "tbCollection";
            this.tbCollection.ReadOnly = true;
            this.tbCollection.Size = new System.Drawing.Size(341, 23);
            this.tbCollection.TabIndex = 0;
            this.tbCollection.Text = "<collection>";
            this.tbCollection.Click += new System.EventHandler(this.tbCollection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1168, 665);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.navPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Custom.CustomLabel lblPage;
        private Custom.CustomLabel lblSearchTime;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private Custom.CustomPanel resultPanel;
        private System.Windows.Forms.Button btnSave;
    }
}

