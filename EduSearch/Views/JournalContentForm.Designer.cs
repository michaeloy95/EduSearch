namespace EduSearch.Views
{
    partial class JournalContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalContentForm));
            this.JournalContentPanel = new EduSearch.Custom.CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.lblMinim = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblJournalTitle = new System.Windows.Forms.Label();
            this.lblAbstractTitle = new System.Windows.Forms.Label();
            this.lblAbstractContent = new System.Windows.Forms.Label();
            this.lblAuthorContent = new System.Windows.Forms.Label();
            this.lblAuthorTitle = new System.Windows.Forms.Label();
            this.lblBilbliographyContent = new System.Windows.Forms.Label();
            this.lblBilbliographyTitle = new System.Windows.Forms.Label();
            this.JournalContentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JournalContentPanel
            // 
            this.JournalContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.JournalContentPanel.Controls.Add(this.lblBilbliographyContent);
            this.JournalContentPanel.Controls.Add(this.lblBilbliographyTitle);
            this.JournalContentPanel.Controls.Add(this.lblAuthorContent);
            this.JournalContentPanel.Controls.Add(this.lblAuthorTitle);
            this.JournalContentPanel.Controls.Add(this.lblAbstractContent);
            this.JournalContentPanel.Controls.Add(this.lblAbstractTitle);
            this.JournalContentPanel.Location = new System.Drawing.Point(134, 107);
            this.JournalContentPanel.Name = "JournalContentPanel";
            this.JournalContentPanel.Size = new System.Drawing.Size(620, 562);
            this.JournalContentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblMinim);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 38);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(14, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 33);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Content";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinim
            // 
            this.lblMinim.BackColor = System.Drawing.Color.Transparent;
            this.lblMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinim.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinim.ForeColor = System.Drawing.Color.Black;
            this.lblMinim.Location = new System.Drawing.Point(618, 0);
            this.lblMinim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinim.Name = "lblMinim";
            this.lblMinim.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblMinim.Size = new System.Drawing.Size(68, 38);
            this.lblMinim.TabIndex = 4;
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
            // lblJournalTitle
            // 
            this.lblJournalTitle.AutoSize = true;
            this.lblJournalTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblJournalTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJournalTitle.Location = new System.Drawing.Point(341, 54);
            this.lblJournalTitle.Name = "lblJournalTitle";
            this.lblJournalTitle.Size = new System.Drawing.Size(188, 36);
            this.lblJournalTitle.TabIndex = 0;
            this.lblJournalTitle.Text = "Journal Title";
            // 
            // lblAbstractTitle
            // 
            this.lblAbstractTitle.AutoSize = true;
            this.lblAbstractTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAbstractTitle.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstractTitle.Location = new System.Drawing.Point(3, 205);
            this.lblAbstractTitle.Name = "lblAbstractTitle";
            this.lblAbstractTitle.Size = new System.Drawing.Size(106, 28);
            this.lblAbstractTitle.TabIndex = 2;
            this.lblAbstractTitle.Text = "Abstract";
            // 
            // lblAbstractContent
            // 
            this.lblAbstractContent.AutoSize = true;
            this.lblAbstractContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAbstractContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstractContent.Location = new System.Drawing.Point(3, 241);
            this.lblAbstractContent.Name = "lblAbstractContent";
            this.lblAbstractContent.Size = new System.Drawing.Size(201, 23);
            this.lblAbstractContent.TabIndex = 3;
            this.lblAbstractContent.Text = "Abstract Content Here";
            // 
            // lblAuthorContent
            // 
            this.lblAuthorContent.AutoSize = true;
            this.lblAuthorContent.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthorContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorContent.Location = new System.Drawing.Point(3, 42);
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
            this.lblAuthorTitle.Location = new System.Drawing.Point(3, 6);
            this.lblAuthorTitle.Name = "lblAuthorTitle";
            this.lblAuthorTitle.Size = new System.Drawing.Size(89, 28);
            this.lblAuthorTitle.TabIndex = 4;
            this.lblAuthorTitle.Text = "Author";
            // 
            // lblBilbliographyContent
            // 
            this.lblBilbliographyContent.AutoSize = true;
            this.lblBilbliographyContent.BackColor = System.Drawing.Color.Transparent;
            this.lblBilbliographyContent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilbliographyContent.Location = new System.Drawing.Point(3, 140);
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
            this.lblBilbliographyTitle.Location = new System.Drawing.Point(3, 104);
            this.lblBilbliographyTitle.Name = "lblBilbliographyTitle";
            this.lblBilbliographyTitle.Size = new System.Drawing.Size(308, 28);
            this.lblBilbliographyTitle.TabIndex = 6;
            this.lblBilbliographyTitle.Text = "Bilbliographic Information";
            // 
            // JournalContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 670);
            this.Controls.Add(this.lblJournalTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JournalContentPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalContentForm";
            this.Load += new System.EventHandler(this.JournalContentForm_Load);
            this.JournalContentPanel.ResumeLayout(false);
            this.JournalContentPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.CustomPanel JournalContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinim;
        private System.Windows.Forms.Label lblExit;
        private Custom.CustomLabel lblTitle;
        private System.Windows.Forms.Label lblJournalTitle;
        private System.Windows.Forms.Label lblBilbliographyContent;
        private System.Windows.Forms.Label lblBilbliographyTitle;
        private System.Windows.Forms.Label lblAuthorContent;
        private System.Windows.Forms.Label lblAuthorTitle;
        private System.Windows.Forms.Label lblAbstractContent;
        private System.Windows.Forms.Label lblAbstractTitle;
    }
}