using EduSearch.Models;
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
    public partial class JournalForm : Form
    {
        /// <summary>
        /// Current form theme
        /// </summary>
        private Themes.Theme CurrentTheme;

        /// <summary>
        /// Current document
        /// </summary>
        private Journal CurrentDocument;

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
        /// JournalContentForm default constructor
        /// </summary>
        public JournalForm(Themes.Theme CurrentTheme, Journal CurrentDocument)
        {
            InitializeComponent();

            this.CurrentDocument = CurrentDocument;
            ApplyTheme(CurrentTheme);

            AllocateDocuments(this.CurrentDocument);
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
        }

        /// <summary>
        /// Initialise location of content's components
        /// </summary>
        private void AllocateDocuments(Journal CurrentDocument)
        {
            this.lblTitle.Location = new Point(3, 6);
            this.lblJournalTitle.Location = new Point(this.lblTitle.Location.X, this.lblTitle.Location.Y + 30);
            this.lblJournalTitle.Text = CurrentDocument.Title;

            this.lblAuthorTitle.Location = new Point(this.lblJournalTitle.Location.X, this.lblJournalTitle.Location.Y +51);
            this.lblAuthorContent.Location = new Point(this.lblAuthorTitle.Location.X, this.lblAuthorTitle.Location.Y + 30);
            this.lblAuthorContent.Text = CurrentDocument.Author;

            this.lblBilbliographyTitle.Location = new Point(this.lblAuthorContent.Location.X, this.lblAuthorContent.Location.Y + 51);
            this.lblBilbliographyContent.Location = new Point(this.lblBilbliographyTitle.Location.X, this.lblBilbliographyTitle.Location.Y + 30);
            this.lblBilbliographyContent.Text = CurrentDocument.Bibliography;

            this.lblAbstractTitle.Location = new Point(this.lblBilbliographyContent.Location.X, this.lblBilbliographyContent.Location.Y + 51);
            this.lblAbstractContent.Location = new Point(this.lblAbstractTitle.Location.X, this.lblAbstractTitle.Location.Y + 30);
            this.lblAbstractContent.Text = CurrentDocument.Abstract;
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
            this.lblExit.BackColor = CurrentTheme.TEXT_BACKCLICK_COLOR;
        }

        /// <summary>
        /// Hover exit button
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            this.lblExit.BackColor = CurrentTheme.TEXT_BACKHOVER_COLOR_R;
        }

        /// <summary>
        /// Leave exit button
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            this.lblExit.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Up exit button
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void lblExit_MouseUp(object sender, MouseEventArgs e)
        {
            this.lblExit.BackColor = CurrentTheme.TEXT_BACKHOVER_COLOR_R;
        }
        #endregion

        private void JournalContentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
