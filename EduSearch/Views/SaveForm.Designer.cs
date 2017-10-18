namespace EduSearch.Views
{
    partial class SaveForm
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
            this.lblExit = new System.Windows.Forms.Label();
            this.savePanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.tbQueryID = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblQueryID = new EduSearch.Custom.CustomLabel();
            this.lblTitle = new EduSearch.Custom.CustomLabel();
            this.navPanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.AutoSize = true;
            this.navPanel.BackColor = System.Drawing.Color.Transparent;
            this.navPanel.Controls.Add(this.lblTitle);
            this.navPanel.Controls.Add(this.lblExit);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanel.MinimumSize = new System.Drawing.Size(267, 37);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(388, 38);
            this.navPanel.TabIndex = 1;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseDown);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(319, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblExit.Size = new System.Drawing.Size(69, 38);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseDown);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            this.lblExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblExit_MouseUp);
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.lblQueryID);
            this.savePanel.Controls.Add(this.btnSave);
            this.savePanel.Controls.Add(this.tbSaveLocation);
            this.savePanel.Controls.Add(this.tbQueryID);
            this.savePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePanel.Location = new System.Drawing.Point(0, 38);
            this.savePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(388, 223);
            this.savePanel.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(16, 165);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(356, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Result";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.BackColor = System.Drawing.Color.White;
            this.tbSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSaveLocation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaveLocation.ForeColor = System.Drawing.Color.Black;
            this.tbSaveLocation.Location = new System.Drawing.Point(16, 102);
            this.tbSaveLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.ReadOnly = true;
            this.tbSaveLocation.Size = new System.Drawing.Size(356, 29);
            this.tbSaveLocation.TabIndex = 5;
            this.tbSaveLocation.Text = "<save results location>";
            this.tbSaveLocation.Click += new System.EventHandler(this.tbSaveLocation_Click);
            // 
            // tbQueryID
            // 
            this.tbQueryID.BackColor = System.Drawing.Color.White;
            this.tbQueryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQueryID.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbQueryID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQueryID.ForeColor = System.Drawing.Color.Black;
            this.tbQueryID.Location = new System.Drawing.Point(157, 55);
            this.tbQueryID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQueryID.MaxLength = 5;
            this.tbQueryID.Name = "tbQueryID";
            this.tbQueryID.Size = new System.Drawing.Size(215, 29);
            this.tbQueryID.TabIndex = 4;
            this.tbQueryID.TextChanged += new System.EventHandler(this.tbQueryID_TextChanged);
            // 
            // lblQueryID
            // 
            this.lblQueryID.AutoSize = true;
            this.lblQueryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryID.Location = new System.Drawing.Point(12, 54);
            this.lblQueryID.Margin = new System.Windows.Forms.Padding(0);
            this.lblQueryID.Name = "lblQueryID";
            this.lblQueryID.Size = new System.Drawing.Size(119, 29);
            this.lblQueryID.TabIndex = 7;
            this.lblQueryID.Text = "Query ID :";
            this.lblQueryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Save Results";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.ControlBox = false;
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveForm";
            this.navPanel.ResumeLayout(false);
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private Custom.CustomLabel lblTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.TextBox tbQueryID;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Custom.CustomLabel lblQueryID;
    }
}