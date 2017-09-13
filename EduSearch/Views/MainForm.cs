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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Path to collection
        /// </summary>
        private static string CollectionLocation;

        /// <summary>
        /// Path to index
        /// </summary>
        private static string IndexLocation;

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
        /// MainForm default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ApplyTheme();
            StartUpApp();
        }

        /// <summary>
        /// Apply the control's style specified in Themes.Theme
        /// </summary>
        private void ApplyTheme()
        {
            this.BackColor = Themes.FlatBlue.BACKGROUND_PRIMARY_COLOR;
            this.navPanel.BackColor = Themes.FlatBlue.BACKGROUND_SECONDARY_COLOR;
            this.statusPanel.BackColor = Themes.FlatBlue.BACKGROUND_SECONDARY_COLOR;
            this.indexPanel.BackColor = Themes.FlatBlue.BACKGROUND_SECONDARY_COLOR;
            this.lblExit.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            this.lblMinim.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            this.lblTitle.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            this.lblIndexStatus.ForeColor = Themes.FlatBlue.TEXT_SECONDARY_COLOR;
        }

        private void StartUpApp()
        {
            indexPanel.Visible = false;
            foreach (Control c in indexPanel.Controls)
            {
                c.Visible = false;
            }
            Common.Animation.RaiseUpAnimation(ref lblTitle, 15, 30);
            Common.Animation.LabelFadeInOutAnimation(ref lblTitle, 15, 2000);
            Common.Animation.PanelShowAfterAnimation(ref indexPanel, 15, 5000);

            folderBrowserDialog.SelectedPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Move Main Form on Mouse Down
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">mouse event arguments</param>
        private void NavPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.Navigation.ReleaseCapture();
                Common.Navigation.SendMessage(Handle, Common.Navigation.WM_NCLBUTTONDOWN, Common.Navigation.HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Hover exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            this.lblExit.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR_R;
        }
        
        /// <summary>
        /// Down exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblExit.BackColor = Themes.FlatBlue.TEXT_BACKCLICK_COLOR_R;
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
            this.lblExit.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR_R;
        }

        /// <summary>
        /// Minimise application
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Hover minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseHover(object sender, EventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR;
        }

        /// <summary>
        /// Down minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKCLICK_COLOR;
        }

        /// <summary>
        /// Leave minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseLeave(object sender, EventArgs e)
        {
            this.lblMinim.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Up minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR;
        }

        /// <summary>
        /// Lookup for collection location
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void tbCollection_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbCollection.Text = folderBrowserDialog.SelectedPath;
                CollectionLocation = folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(CollectionLocation) || !String.IsNullOrEmpty(IndexLocation))
                {
                    btnIndex.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Lookup for index location
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void tbIndexLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbIndexLocation.Text = folderBrowserDialog.SelectedPath;
                IndexLocation = folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(CollectionLocation) || !String.IsNullOrEmpty(IndexLocation))
                {
                    btnIndex.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Begin indexing
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void btnIndex_Click(object sender, EventArgs e)
        {

        }
    }
}
