using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSearch.Views
{
    public partial class SaveForm : Form
    {
        /// <summary>
        /// System name constant
        /// </summary>
        private const string SYSTEM_NAME = "N9574280_N9541951_N8477621_IRGroup";

        /// <summary>
        /// Path to save results
        /// </summary>
        private string SaveLocation;

        /// <summary>
        /// Current result documents
        /// </summary>
        private List<Models.Journal> CurrentResultDocs;

        /// <summary>
        /// Current form theme
        /// </summary>
        private Themes.Theme CurrentTheme;

        /// <summary>
        /// Gives shadow of the form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /// <summary>
        /// SaveForm default constructor
        /// </summary>
        public SaveForm(Themes.Theme CurrentTheme, List<Models.Journal> CurrentResultDocs)
        {
            InitializeComponent();
            ApplyTheme(CurrentTheme);
            this.CurrentResultDocs = CurrentResultDocs;
        }

        /// <summary>
        /// Apply the control's style specified in Themes.Theme
        /// </summary>
        private void ApplyTheme(Themes.Theme theme)
        {
            //select theme
            this.CurrentTheme = theme;

            //navigation panel
            this.navPanel.BackColor = this.CurrentTheme.BACKGROUND_NAVIGATION_COLOR;
            this.lblExit.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
            this.lblTitle.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;

            //save panel
            this.savePanel.BackColor = this.CurrentTheme.BACKGROUND_SECONDARY_COLOR;
            this.lblQueryID.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
        }

        #region Navigation Panel Settings
        /// <summary>
        /// Move Main Form on Mouse Down
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Mouse event arguments</param>
        private void NavPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.Navigation.ReleaseCapture();
                Common.Navigation.SendMessage(Handle, Common.Navigation.WM_NCLBUTTONDOWN, Common.Navigation.HT_CAPTION, byte.MinValue);
            }
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hover exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            this.lblExit.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR_R;
        }

        /// <summary>
        /// Down exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblExit.BackColor = this.CurrentTheme.TEXT_BACKCLICK_COLOR_R;
        }

        /// <summary>
        /// Leave exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            this.lblExit.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Up exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblExit.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR_R;
        }
        #endregion

        /// <summary>
        /// Check Query ID
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbQueryID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQueryID.Text) && !string.IsNullOrEmpty(this.SaveLocation))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        /// <summary>
        /// Select save location
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbSaveLocation_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "result.txt";
            this.saveFileDialog.Filter = "Text File | *.txt";
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSaveLocation.Text = this.saveFileDialog.FileName;
                this.SaveLocation = this.saveFileDialog.FileName;
            }

            if (!string.IsNullOrEmpty(tbQueryID.Text) && !string.IsNullOrEmpty(this.SaveLocation))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        /// <summary>
        /// Save results
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(SaveLocation, true);

            try
            {
                using (writer)
                {
                    int rank = 1;
                    foreach (Models.Journal document in CurrentResultDocs)
                    {
                        writer.WriteLine(tbQueryID.Text + "\t" +
                            "Q0" + "\t" +
                            document.Id + "\t" +
                            rank.ToString() + "\t" +
                            document.Score + "\t" +
                            SYSTEM_NAME);
                        rank++;
                    }
                }

                MessageBox.Show("Results saved");
                ((MainForm)this.Owner).AddLog("Results saved.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
