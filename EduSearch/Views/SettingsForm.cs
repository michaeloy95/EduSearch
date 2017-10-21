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
    public partial class SettingsForm : Form
    {
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
        public SettingsForm(Themes.Theme CurrentTheme)
        {
            InitializeComponent();
            ApplyTheme(CurrentTheme);

            if (this.CurrentTheme.GetType() == typeof(Themes.Chrome))
            {
                this.cbTheme.SelectedIndex = 0;
            }
            else if (this.CurrentTheme.GetType() == typeof(Themes.FlatBlue))
            {
                this.cbTheme.SelectedIndex = 1;
            }
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

            //setting panel
            this.settingPanel.BackColor = this.CurrentTheme.BACKGROUND_SECONDARY_COLOR;
            this.lblTheme.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
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
        /// Dispose form
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Update Theme
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTheme.SelectedIndex == 0)
            {
                this.ApplyTheme(new Themes.Chrome());
            }
            else if (cbTheme.SelectedIndex == 1)
            {
                this.ApplyTheme(new Themes.FlatBlue());
            }

            MainForm mf = Application.OpenForms["MainForm"] as MainForm;
            mf.ApplyTheme(this.CurrentTheme);
        }

        /// <summary>
        /// Dispose form
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void lblExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
