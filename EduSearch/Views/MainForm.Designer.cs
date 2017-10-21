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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navPanel = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.lblMinim = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bodyPanel = new EduSearch.Custom.CustomPanel();
            this.searchPanel = new EduSearch.Custom.CustomPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPreprocess = new System.Windows.Forms.CheckBox();
            this.lblPage = new EduSearch.Custom.CustomLabel();
            this.lblSearchTime = new EduSearch.Custom.CustomLabel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.resultPanel = new EduSearch.Custom.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.leftPanel = new EduSearch.Custom.CustomPanel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.indexPanel = new EduSearch.Custom.CustomPanel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblIndexStatus = new System.Windows.Forms.Label();
            this.lblIndex = new EduSearch.Custom.CustomLabel();
            this.btnIndex = new System.Windows.Forms.Button();
            this.tbIndexLocation = new System.Windows.Forms.TextBox();
            this.tbCollection = new System.Windows.Forms.TextBox();
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.indexPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.AutoSize = true;
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.pbSettings);
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
            // pbSettings
            // 
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSettings.Image = global::EduSearch.Properties.Resources.settings;
            this.pbSettings.InitialImage = global::EduSearch.Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(713, 0);
            this.pbSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Padding = new System.Windows.Forms.Padding(18, 5, 18, 5);
            this.pbSettings.Size = new System.Drawing.Size(60, 31);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 15;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            this.pbSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSettings_MouseDown);
            this.pbSettings.MouseLeave += new System.EventHandler(this.pbSettings_MouseLeave);
            this.pbSettings.MouseHover += new System.EventHandler(this.pbSettings_MouseHover);
            this.pbSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSettings_MouseUp);
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
            this.searchPanel.Controls.Add(this.btnSave);
            this.searchPanel.Controls.Add(this.cbPreprocess);
            this.searchPanel.Controls.Add(this.lblPage);
            this.searchPanel.Controls.Add(this.lblSearchTime);
            this.searchPanel.Controls.Add(this.btnNextPage);
            this.searchPanel.Controls.Add(this.btnPrevPage);
            this.searchPanel.Controls.Add(this.resultPanel);
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.tbSearch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(287, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(589, 509);
            this.searchPanel.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(465, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Results";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPreprocess
            // 
            this.cbPreprocess.AutoSize = true;
            this.cbPreprocess.Checked = true;
            this.cbPreprocess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPreprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPreprocess.Location = new System.Drawing.Point(56, 53);
            this.cbPreprocess.Name = "cbPreprocess";
            this.cbPreprocess.Size = new System.Drawing.Size(149, 20);
            this.cbPreprocess.TabIndex = 13;
            this.cbPreprocess.Text = "Preprocess Query";
            this.cbPreprocess.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(122, 482);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(40, 16);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "1/100";
            this.lblPage.Visible = false;
            // 
            // lblSearchTime
            // 
            this.lblSearchTime.AutoSize = true;
            this.lblSearchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTime.Location = new System.Drawing.Point(34, 96);
            this.lblSearchTime.Name = "lblSearchTime";
            this.lblSearchTime.Size = new System.Drawing.Size(197, 16);
            this.lblSearchTime.TabIndex = 10;
            this.lblSearchTime.Text = "100 results found (0.07 seconds)";
            this.lblSearchTime.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(179, 478);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 9;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Visible = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(30, 478);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevPage.TabIndex = 8;
            this.btnPrevPage.Text = "Previous";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Visible = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.AutoScroll = true;
            this.resultPanel.Location = new System.Drawing.Point(30, 117);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(533, 355);
            this.resultPanel.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::EduSearch.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(491, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(55, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(436, 40);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnClearLog);
            this.leftPanel.Controls.Add(this.lblLog);
            this.leftPanel.Controls.Add(this.lbLog);
            this.leftPanel.Controls.Add(this.indexPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(287, 509);
            this.leftPanel.TabIndex = 4;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(209, 232);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 14;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
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
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalExtent = 100;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(4, 257);
            this.lbLog.Name = "lbLog";
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(278, 249);
            this.lbLog.TabIndex = 4;
            this.lbLog.TabStop = false;
            // 
            // indexPanel
            // 
            this.indexPanel.Controls.Add(this.pbLoading);
            this.indexPanel.Controls.Add(this.lblIndexStatus);
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
            // pbLoading
            // 
            this.pbLoading.Image = global::EduSearch.Properties.Resources.loading;
            this.pbLoading.InitialImage = global::EduSearch.Properties.Resources.loading;
            this.pbLoading.Location = new System.Drawing.Point(102, 151);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(76, 72);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 14;
            this.pbLoading.TabStop = false;
            this.pbLoading.WaitOnLoad = true;
            // 
            // lblIndexStatus
            // 
            this.lblIndexStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexStatus.ForeColor = System.Drawing.Color.Red;
            this.lblIndexStatus.Location = new System.Drawing.Point(20, 158);
            this.lblIndexStatus.Name = "lblIndexStatus";
            this.lblIndexStatus.Size = new System.Drawing.Size(251, 23);
            this.lblIndexStatus.TabIndex = 13;
            this.lblIndexStatus.Text = "Indexing required.";
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
            this.tbIndexLocation.BackColor = System.Drawing.Color.White;
            this.tbIndexLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIndexLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbIndexLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexLocation.ForeColor = System.Drawing.Color.Black;
            this.tbIndexLocation.Location = new System.Drawing.Point(15, 72);
            this.tbIndexLocation.Margin = new System.Windows.Forms.Padding(0);
            this.tbIndexLocation.Name = "tbIndexLocation";
            this.tbIndexLocation.ReadOnly = true;
            this.tbIndexLocation.Size = new System.Drawing.Size(256, 26);
            this.tbIndexLocation.TabIndex = 1;
            this.tbIndexLocation.Text = "Enter index location";
            this.tbIndexLocation.Click += new System.EventHandler(this.tbIndexLocation_Click);
            // 
            // tbCollection
            // 
            this.tbCollection.BackColor = System.Drawing.Color.White;
            this.tbCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbCollection.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCollection.ForeColor = System.Drawing.Color.Black;
            this.tbCollection.Location = new System.Drawing.Point(15, 40);
            this.tbCollection.Margin = new System.Windows.Forms.Padding(0);
            this.tbCollection.Name = "tbCollection";
            this.tbCollection.ReadOnly = true;
            this.tbCollection.Size = new System.Drawing.Size(256, 26);
            this.tbCollection.TabIndex = 0;
            this.tbCollection.Text = "Enter source collection";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.indexPanel.ResumeLayout(false);
            this.indexPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
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
        private Custom.CustomPanel searchPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private Custom.CustomLabel lblPage;
        private Custom.CustomLabel lblSearchTime;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private Custom.CustomPanel resultPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIndexStatus;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.CheckBox cbPreprocess;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.PictureBox pbSettings;
    }
}

