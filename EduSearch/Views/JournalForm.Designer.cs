namespace EduSearch.Views
{
    partial class JournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.navPanel = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.JournalContentPanel = new EduSearch.Custom.CustomPanel();
            this.lblBilbliographyContent = new System.Windows.Forms.Label();
            this.lblBilbliographyTitle = new System.Windows.Forms.Label();
            this.lblAuthorContent = new System.Windows.Forms.Label();
            this.lblAuthorTitle = new System.Windows.Forms.Label();
            this.lblAbstractContent = new System.Windows.Forms.Label();
            this.lblAbstractTitle = new System.Windows.Forms.Label();
            this.lblJournalTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.JournalContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.navPanel.Controls.Add(this.lblExit);
            this.navPanel.Location = new System.Drawing.Point(-1, -1);
            this.navPanel.Margin = new System.Windows.Forms.Padding(4);
            this.navPanel.MinimumSize = new System.Drawing.Size(0, 37);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(755, 38);
            this.navPanel.TabIndex = 1;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseDown);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(686, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblExit.Size = new System.Drawing.Size(69, 38);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseDown);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            this.lblExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseUp);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(252, 54);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(291, 36);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Journal Information";
            // 
            // JournalContentPanel
            // 
            this.JournalContentPanel.AutoScroll = true;
            this.JournalContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.JournalContentPanel.Controls.Add(this.lblJournalTitle);
            this.JournalContentPanel.Controls.Add(this.lblTitle);
            this.JournalContentPanel.Controls.Add(this.lblBilbliographyContent);
            this.JournalContentPanel.Controls.Add(this.lblBilbliographyTitle);
            this.JournalContentPanel.Controls.Add(this.lblAuthorContent);
            this.JournalContentPanel.Controls.Add(this.lblAuthorTitle);
            this.JournalContentPanel.Controls.Add(this.lblAbstractContent);
            this.JournalContentPanel.Controls.Add(this.lblAbstractTitle);
            this.JournalContentPanel.Location = new System.Drawing.Point(67, 107);
            this.JournalContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JournalContentPanel.Name = "JournalContentPanel";
            this.JournalContentPanel.Size = new System.Drawing.Size(686, 532);
            this.JournalContentPanel.TabIndex = 0;
            // 
            // lblBilbliographyContent
            // 
            this.lblBilbliographyContent.AutoSize = true;
            this.lblBilbliographyContent.BackColor = System.Drawing.Color.Transparent;
            this.lblBilbliographyContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilbliographyContent.Location = new System.Drawing.Point(3, 231);
            this.lblBilbliographyContent.MaximumSize = new System.Drawing.Size(648, 0);
            this.lblBilbliographyContent.Name = "lblBilbliographyContent";
            this.lblBilbliographyContent.Size = new System.Drawing.Size(246, 23);
            this.lblBilbliographyContent.TabIndex = 7;
            this.lblBilbliographyContent.Text = "Bilbliographic Content here";
            // 
            // lblBilbliographyTitle
            // 
            this.lblBilbliographyTitle.AutoSize = true;
            this.lblBilbliographyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBilbliographyTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilbliographyTitle.Location = new System.Drawing.Point(3, 194);
            this.lblBilbliographyTitle.Name = "lblBilbliographyTitle";
            this.lblBilbliographyTitle.Size = new System.Drawing.Size(308, 28);
            this.lblBilbliographyTitle.TabIndex = 6;
            this.lblBilbliographyTitle.Text = "Bilbliographic Information";
            // 
            // lblAuthorContent
            // 
            this.lblAuthorContent.AutoSize = true;
            this.lblAuthorContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorContent.Location = new System.Drawing.Point(3, 133);
            this.lblAuthorContent.MaximumSize = new System.Drawing.Size(648, 0);
            this.lblAuthorContent.Name = "lblAuthorContent";
            this.lblAuthorContent.Size = new System.Drawing.Size(138, 23);
            this.lblAuthorContent.TabIndex = 5;
            this.lblAuthorContent.Text = "Author(s) here";
            // 
            // lblAuthorTitle
            // 
            this.lblAuthorTitle.AutoSize = true;
            this.lblAuthorTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorTitle.Location = new System.Drawing.Point(3, 97);
            this.lblAuthorTitle.Name = "lblAuthorTitle";
            this.lblAuthorTitle.Size = new System.Drawing.Size(89, 28);
            this.lblAuthorTitle.TabIndex = 4;
            this.lblAuthorTitle.Text = "Author";
            // 
            // lblAbstractContent
            // 
            this.lblAbstractContent.AutoSize = true;
            this.lblAbstractContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAbstractContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstractContent.Location = new System.Drawing.Point(3, 332);
            this.lblAbstractContent.MaximumSize = new System.Drawing.Size(648, 0);
            this.lblAbstractContent.Name = "lblAbstractContent";
            this.lblAbstractContent.Size = new System.Drawing.Size(201, 23);
            this.lblAbstractContent.TabIndex = 3;
            this.lblAbstractContent.Text = "Abstract Content Here";
            // 
            // lblAbstractTitle
            // 
            this.lblAbstractTitle.AutoSize = true;
            this.lblAbstractTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAbstractTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstractTitle.Location = new System.Drawing.Point(3, 297);
            this.lblAbstractTitle.Name = "lblAbstractTitle";
            this.lblAbstractTitle.Size = new System.Drawing.Size(106, 28);
            this.lblAbstractTitle.TabIndex = 2;
            this.lblAbstractTitle.Text = "Abstract";
            // 
            // lblJournalTitle
            // 
            this.lblJournalTitle.AutoSize = true;
            this.lblJournalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblJournalTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJournalTitle.Location = new System.Drawing.Point(3, 46);
            this.lblJournalTitle.MaximumSize = new System.Drawing.Size(648, 0);
            this.lblJournalTitle.Name = "lblJournalTitle";
            this.lblJournalTitle.Size = new System.Drawing.Size(93, 23);
            this.lblJournalTitle.TabIndex = 9;
            this.lblJournalTitle.Text = "Title here";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 28);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // JournalContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 670);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.JournalContentPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JournalContentForm";
            this.Load += new System.EventHandler(this.JournalContentForm_Load);
            this.navPanel.ResumeLayout(false);
            this.JournalContentPanel.ResumeLayout(false);
            this.JournalContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.CustomPanel JournalContentPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblBilbliographyContent;
        private System.Windows.Forms.Label lblBilbliographyTitle;
        private System.Windows.Forms.Label lblAuthorContent;
        private System.Windows.Forms.Label lblAuthorTitle;
        private System.Windows.Forms.Label lblAbstractContent;
        private System.Windows.Forms.Label lblAbstractTitle;
        private System.Windows.Forms.Label lblJournalTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}