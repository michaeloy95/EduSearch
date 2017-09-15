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
        /// Search Engine object
        /// </summary>
        private static SearchEngine searchEngine;

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
            //main form
            this.BackColor = Themes.FlatBlue.BACKGROUND_PRIMARY_COLOR;

            //navigation panel
            this.navPanel.BackColor = Themes.FlatBlue.BACKGROUND_NAVIGATION_COLOR;
            this.lblExit.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            this.lblMinim.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            this.lblTitle.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;

            //left panel
            this.leftPanel.BackColor = Themes.FlatBlue.BACKGROUND_SECONDARY_COLOR;
            this.lblLog.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;

            //index panel
            this.indexPanel.BackColor = Themes.FlatBlue.BACKGROUND_SECONDARY_COLOR;
            this.lblIndex.ForeColor = Themes.FlatBlue.TEXT_SECONDARY_COLOR;
            this.tbCollection.ForeColor = Themes.FlatBlue.TEXT_TEXTBOX_COLOR;
            this.tbIndexLocation.ForeColor = Themes.FlatBlue.TEXT_TEXTBOX_COLOR;
        }

        /// <summary>
        /// Prepare controls and show splash
        /// </summary>
        private void StartUpApp()
        {
            // Hide all controls
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }

            //Create Title label
            Custom.CustomLabel lblSplashTitle = new Custom.CustomLabel();
            lblSplashTitle.Font = new Font("Forte", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(byte.MinValue)));
            lblSplashTitle.ForeColor = Themes.FlatBlue.TEXT_PRIMARY_COLOR;
            lblSplashTitle.Location = new Point(287, 220);
            lblSplashTitle.Size = new Size(303, 103);
            lblSplashTitle.Text = "EduSearch";
            lblSplashTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSplashTitle.Visible = true;
            this.Controls.Add(lblSplashTitle);

            //Show splash
            Common.Animation.RaiseUpAnimation(ref lblSplashTitle, 15, 30);
            Common.Animation.LabelFadeInOutAnimation(ref lblSplashTitle, 15, 2000);

            //Show all controls
            foreach (Control c in this.Controls)
            {
                Control c_pointer = c;
                Common.Animation.ShowControlAfterAnimation(ref c_pointer, 15, 5000);
            }

            //Hide all controls in Search
            this.searchPanel.Visible = false;

            folderBrowserDialog.SelectedPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        #region Navigation Panel Settings
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
        #endregion

        /// <summary>
        /// Insert message to log
        /// </summary>
        /// <param name="message">Message</param>
        private void AddLog(string message)
        {
            const int H_MAX_CHARS = 50;
            while (message.Length > H_MAX_CHARS)
            {
                int cutIndex = message.Substring(byte.MinValue, H_MAX_CHARS).LastIndexOfAny(new char[] { ' ' });

                lbLog.Items.Add(message.Substring(byte.MinValue, cutIndex).Trim());
                message = message.Substring(cutIndex, message.Length - cutIndex);
            }
            this.lbLog.Items.Add(message.Trim());
        }

        /// <summary>
        /// Lookup for collection location
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbCollection_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbCollection.Text = folderBrowserDialog.SelectedPath;
                CollectionLocation = folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(CollectionLocation) && !String.IsNullOrEmpty(IndexLocation))
                {
                    btnIndex.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Lookup for index location
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbIndexLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbIndexLocation.Text = folderBrowserDialog.SelectedPath;
                IndexLocation = folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(CollectionLocation) && !String.IsNullOrEmpty(IndexLocation))
                {
                    btnIndex.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Begin indexing
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnIndex_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            searchEngine = new SearchEngine();

            this.AddLog("Allocating documents...");
            startTime = DateTime.Now;
            List<Document> foundDocuments = RecursivelyGenerateDocuments(CollectionLocation);
            this.AddLog($"Documents successfully allocated in {(DateTime.Now.Subtract(startTime)).Milliseconds / 1000.0} seconds.");
            
            this.AddLog("Creating index.");
            searchEngine.CreateIndex(IndexLocation + @"\myIndex");

            this.AddLog("Start indexing...");
            startTime = DateTime.Now;
            foreach (Document document in foundDocuments)
            {
                searchEngine.IndexText(document.Id, SearchEngine.IndexFieldName.Id);
                searchEngine.IndexText(document.Title, SearchEngine.IndexFieldName.Title);
                searchEngine.IndexText(document.Author, SearchEngine.IndexFieldName.Author);
                searchEngine.IndexText(document.Bibliography, SearchEngine.IndexFieldName.Bibliography);
                searchEngine.IndexText(document.Abstract, SearchEngine.IndexFieldName.Abstract);

                this.AddLog("");
                this.AddLog("> " + document.Id);
                this.AddLog("> " + document.Title);
                this.AddLog("> " + document.Author);
                this.AddLog("> " + document.Bibliography);
                this.AddLog("> " + document.Abstract);
            }
            this.AddLog($"All documents have been indexed in {(DateTime.Now.Subtract(startTime)).Milliseconds / 1000.0} seconds.");

            searchPanel.Visible = true;
        }

        /// <summary>
        /// Recursively iterate files and directories from the root
        /// </summary>
        /// <param name="path">Path to root directory</param>
        /// <returns>List of structured documents</returns>
        private List<Document> RecursivelyGenerateDocuments(string path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            List<Document> documents = new List<Document>();

            try
            {
                files = root.GetFiles("*.txt");
            }
            catch (UnauthorizedAccessException e)
            {
                this.AddLog(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                this.AddLog(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    string name = fi.FullName;
                    documents.Add(ExtractDocument(name));
                }
                
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    string name = dirInfo.FullName;
                    documents.AddRange(this.RecursivelyGenerateDocuments(name));
                }
            }

            return documents;
        }

        /// <summary>
        /// Extract the text into structured document
        /// </summary>
        /// <param name="path">Path to text</param>
        /// <returns>Document object</returns>
        private Document ExtractDocument(string path)
        {
            Document document = new Document();
            System.IO.StreamReader reader = new System.IO.StreamReader(path);

            try
            {
                using (reader)
                {
                    string line;
                    bool author = false, bibli = false, content = false;

                    document.Id = reader.ReadLine().Split()[1];
                    while ((line = reader.ReadLine()) != null)
                    {
                        switch (line)
                        {
                            case ".T":
                                break;
                            case ".A":
                                author = true;
                                break;
                            case ".B":
                                bibli = true;
                                break;
                            case ".W":
                                content = true;
                                break;
                            default:
                                if (content)
                                {
                                    document.Abstract += line + " ";
                                }
                                else if (bibli)
                                {
                                    document.Bibliography += line + " ";
                                }
                                else if (author)
                                {
                                    document.Author += line + " ";
                                }
                                else
                                {
                                    document.Title += line + " ";
                                }
                                break;
                        }
                    }
                }
                if (document.Abstract.Contains(document.Title))
                {
                    // BUG: Abstract not removing title
                    int index = document.Abstract.IndexOf(document.Title);
                    document.Abstract.Remove(index, document.Title.Length);
                }
            }
            catch (Exception e)
            {
                this.AddLog(e.Message);
            }

            return document;
        }
    }
}
