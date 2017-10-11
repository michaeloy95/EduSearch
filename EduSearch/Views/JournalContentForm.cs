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
    public partial class JournalContentForm : Form
    {
        public JournalContentForm()
        {
            InitializeComponent();
            ApplyTheme();
            InitialContentComponentsLocation();
        }
        /// <summary>
        /// Apply the control's style specified in Themes.Theme
        /// </summary>
        private void ApplyTheme()
        {
            //navigation panel
        }
        /// <summary>
        /// Initialize location of content's components
        /// </summary>
        private void InitialContentComponentsLocation()
        {
            lblAuthorTitle.Location = new Point(3, 6);
            lblAuthorContent.Location = new Point(lblAuthorTitle.Location.X, lblAuthorTitle.Location.Y + 30);

            lblBilbliographyTitle.Location = new Point(lblAuthorContent.Location.X, lblAuthorContent.Location.Y + 51);
            lblBilbliographyContent.Location = new Point(lblBilbliographyTitle.Location.X, lblBilbliographyTitle.Location.Y + 30);

            lblAbstractTitle.Location = new Point(lblBilbliographyContent.Location.X, lblBilbliographyContent.Location.Y + 51);
            lblAbstractContent.Location = new Point(lblAbstractTitle.Location.X, lblAbstractTitle.Location.Y + 30);
        }
        /// <summary>
        /// Load journal content form
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void JournalContentForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Click minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Click exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        /// <summary>
        /// Down exit button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblExit_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKCLICK_COLOR;
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
        /// Down minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKCLICK_COLOR;
        }
        /// <summary>
        /// Hover minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseHover(object sender, EventArgs e)
        {
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR_R;
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
            this.lblMinim.BackColor = Themes.FlatBlue.TEXT_BACKHOVER_COLOR_R;
        }
    }
}
