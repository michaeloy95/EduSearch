using EduSearch.Custom;
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
        private string CollectionLocation;

        /// <summary>
        /// Path to index
        /// </summary>
        private string IndexLocation;

        /// <summary>
        /// Search Engine object
        /// </summary>
        private SearchEngine SearchEngine;

        /// <summary>
        /// Current result page
        /// </summary>
        private int CurrentResultPage;

        /// <summary>
        /// Maximum documents retrieved per page
        /// </summary>
        private const int MaxResultPerPage = 10;

        /// <summary>
        /// Current result documents
        /// </summary>
        private List<Journal> CurrentResultDocs;

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
        /// MainForm default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ApplyTheme(new Themes.Chrome());
            StartUpApp();
        }

        /// <summary>
        /// Apply the control's style specified in Themes.Theme
        /// </summary>
        public void ApplyTheme(Themes.Theme theme)
        {
            //select theme
            this.CurrentTheme = theme;

            //main form
            this.BackColor = this.CurrentTheme.BACKGROUND_PRIMARY_COLOR;

            //navigation panel
            this.navPanel.BackColor = this.CurrentTheme.BACKGROUND_NAVIGATION_COLOR;
            this.lblExit.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
            this.lblMinim.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
            this.lblTitle.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;

            //left panel
            this.leftPanel.BackColor = this.CurrentTheme.BACKGROUND_SECONDARY_COLOR;
            this.lblLog.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;

            //index panel
            this.indexPanel.BackColor = this.CurrentTheme.BACKGROUND_SECONDARY_COLOR;
            this.lblIndex.ForeColor = this.CurrentTheme.TEXT_SECONDARY_COLOR;
            this.tbCollection.ForeColor = this.CurrentTheme.TEXT_TEXTBOX_COLOR;
            this.tbIndexLocation.ForeColor = this.CurrentTheme.TEXT_TEXTBOX_COLOR;

            //search panel
            this.searchPanel.BackColor = this.CurrentTheme.BACKGROUND_PRIMARY_COLOR;
            this.cbPreprocess.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;

            //result panel
            this.lblSearchTime.ForeColor = this.CurrentTheme.TEXT_SECONDARY_COLOR;
            this.lblPage.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
            foreach (Control control in resultPanel.Controls)
            {
                if (typeof(Label) == control.GetType())
                {
                    control.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
                }
                else if (typeof(CustomLabel) == control.GetType())
                {
                    control.ForeColor = this.CurrentTheme.TEXT_SECONDARY_COLOR;
                }
            }
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
            lblSplashTitle.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
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

            this.pbLoading.Visible = false;

            this.folderBrowserDialog.SelectedPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.CurrentResultDocs = new List<Journal>();
            this.CurrentResultPage = 1;
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
            this.lblMinim.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR;
        }

        /// <summary>
        /// Down minimise button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void lblMinim_MouseDown(object sender, MouseEventArgs e)
        {
            this.lblMinim.BackColor = this.CurrentTheme.TEXT_BACKCLICK_COLOR;
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
            this.lblMinim.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR;
        }

        /// <summary>
        /// Hover settings button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void pbSettings_MouseHover(object sender, EventArgs e)
        {
            this.pbSettings.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR;
        }

        /// <summary>
        /// Down settings button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void pbSettings_MouseDown(object sender, MouseEventArgs e)
        {
            this.pbSettings.BackColor = this.CurrentTheme.TEXT_BACKCLICK_COLOR;
        }

        /// <summary>
        /// Leave settings button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbSettings.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Up settings button
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        private void pbSettings_MouseUp(object sender, MouseEventArgs e)
        {
            this.pbSettings.BackColor = this.CurrentTheme.TEXT_BACKHOVER_COLOR;
        }
        #endregion

        /// <summary>
        /// Insert message to log
        /// </summary>
        /// <param name="message">Message</param>
        public void AddLog(string message)
        {
            const int H_MAX_CHARS = 50;
            while (message.Length > H_MAX_CHARS)
            {
                int cutIndex = message.Substring(byte.MinValue, H_MAX_CHARS).LastIndexOfAny(new char[] { ' ' });

                this.lbLog.Items.Add(message.Substring(byte.MinValue, cutIndex).Trim());
                message = message.Substring(cutIndex, message.Length - cutIndex);
            }
            this.lbLog.Items.Add(message.Trim());
        }
        
        /// <summary>
        /// Clear Log
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.lbLog.Items.Clear();
        }

        /// <summary>
        /// Lookup for collection location
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbCollection_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbCollection.Text = this.folderBrowserDialog.SelectedPath;
                this.CollectionLocation = this.folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(this.CollectionLocation) && !String.IsNullOrEmpty(this.IndexLocation))
                {
                    this.btnIndex.Enabled = true;
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
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbIndexLocation.Text = this.folderBrowserDialog.SelectedPath;
                this.IndexLocation = this.folderBrowserDialog.SelectedPath;

                if (!String.IsNullOrEmpty(this.CollectionLocation) && !String.IsNullOrEmpty(this.IndexLocation))
                {
                    this.btnIndex.Enabled = true;
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
            this.searchPanel.Visible = false;
            this.btnPrevPage.Visible = false;
            this.btnNextPage.Visible = false;
            this.lblPage.Visible = false;
            this.lblSearchTime.Visible = false;
            this.btnSave.Visible = false;

            this.resultPanel.Controls.Clear();

            DateTime startTime;
            this.SearchEngine = new SearchEngine();

            this.lblIndexStatus.Visible = false;
            this.pbLoading.Visible = true;

            this.AddLog("Allocating documents...");
            startTime = DateTime.Now;

            List<Journal> foundDocuments = RecursivelyGenerateDocuments(this.CollectionLocation);

            this.AddLog($"Documents successfully allocated ({(DateTime.Now.Subtract(startTime)).Milliseconds / 1000.0} seconds).");
            
            this.SearchEngine.CreateIndex(this.IndexLocation);

            this.AddLog("Start indexing...");
            startTime = DateTime.Now;

            foreach (Journal document in foundDocuments)
            {            
                this.SearchEngine.IndexText(document);
            }

            double indexingTime = (DateTime.Now.Subtract(startTime)).Milliseconds / 1000.0;
            this.AddLog($"All documents have been indexed ({indexingTime} seconds).");


            this.SearchEngine.CleanUpIndexer();
            this.searchPanel.Visible = true;

            this.pbLoading.Visible = false;
            this.lblIndexStatus.Text = $"Indexing done ({indexingTime} seconds).";
            this.lblIndexStatus.ForeColor = Color.DarkGreen;
            this.lblIndexStatus.Visible = true;

            this.tbSearch.Text = string.Empty;
            this.tbSearch.Focus();
        }

        /// <summary>
        /// Recursively iterate files and directories from the root
        /// </summary>
        /// <param name="path">Path to root directory</param>
        /// <returns>List of structured documents</returns>
        private List<Journal> RecursivelyGenerateDocuments(string path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            List<Journal> documents = new List<Journal>();

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
                    documents.Add(this.ExtractDocument(name));
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
        private Journal ExtractDocument(string path)
        {
            Journal document = new Journal();
            System.IO.StreamReader reader = new System.IO.StreamReader(path);

            try
            {
                using (reader)
                {
                    string line;
                    bool author = false, bibli = false, content = false;

                    //Take document ID
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
                if (document.Abstract.Contains(document.Title) && !string.IsNullOrEmpty(document.Title))
                {
                    document.Abstract = (document.Abstract.Replace(document.Title, ""));
                }
                document.Trim();
            }
            catch (Exception e)
            {
                this.AddLog(e.Message);
            }

            return document;
        }

        /// <summary>
        /// Begin searching
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tbSearch.Text))
            {
                string query = this.tbSearch.Text;
                if (this.cbPreprocess.Checked)
                {
                    query = this.SearchEngine.PreProcessQuery(query);
                    this.AddLog($"Processed query result: {query}");
                }

                this.SearchEngine.CreateSearcher();
                this.SearchEngine.CreateParser(SearchEngine.IndexFieldName.Abstract);

                this.CurrentResultDocs = new List<Journal>();

                try
                {
                    DateTime startTime = DateTime.Now;
                    this.CurrentResultDocs = this.SearchEngine.SearchIndex(query);
                    double searchTime = (DateTime.Now.Subtract(startTime)).Milliseconds / 1000.0;

                    this.AddLog($"Search is done. {this.CurrentResultDocs.Count} documents found ({searchTime} seconds).");
                    this.lblSearchTime.Text = $"{this.CurrentResultDocs.Count} documents found ({searchTime} seconds)";
                    
                    this.CurrentResultPage = 1;
                    this.DisplayResults();

                    this.lblPage.Text = $"{CurrentResultPage}/{(this.CurrentResultDocs.Count / MaxResultPerPage) + Math.Sign(this.CurrentResultDocs.Count % MaxResultPerPage)}";

                    this.btnPrevPage.Enabled = false;
                    this.btnNextPage.Enabled = (CurrentResultDocs.Count <= MaxResultPerPage) ? false : true;
                }
                catch (Exception ex)
                {
                    this.AddLog(ex.ToString());
                }

                this.btnPrevPage.Visible = true;
                this.btnNextPage.Visible = true;
                this.lblPage.Visible = true;
                this.lblSearchTime.Visible = true;
                this.btnSave.Visible = true;

                this.SearchEngine.CleanUpSearcher();
            }
        }

        /// <summary>
        /// Search results
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, e);
            }
        }

        /// <summary>
        /// Draw the results list
        /// </summary>
        /// <param name="docs">Documents as search results</param>
        private void DisplayResults()
        {
            this.resultPanel.Controls.Clear();

            const int X_POS_TITLE = 15;
            const int X_POS_OTHER = 20;
            const int Y_POS_TITLE = 5;
            const int Y_POS_DESC = 33;
            const int Y_POST_ABSTRACT = 48;
            const int Y_NEXT_RESULT = 90;

            const int MAX_TITLE = 65;
            const int MAX_DESC = 75;
            const int MAX_ABSTRACT = 170;

            int rank_pos = 0;
            for (int i = ((this.CurrentResultPage - 1) * MaxResultPerPage); i < Math.Min(this.CurrentResultPage * MaxResultPerPage, this.CurrentResultDocs.Count); i++)
            {
                Journal document = CurrentResultDocs[i];

                // display title
                Label lblTitle = new Label();
                lblTitle.AutoSize = false;
                lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTitle.Location = new System.Drawing.Point(X_POS_TITLE, Y_POS_TITLE + (rank_pos * Y_NEXT_RESULT));
                lblTitle.Size = new Size(490, 25);
                lblTitle.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
                lblTitle.Cursor = Cursors.Hand;
                lblTitle.Text = (i+1).ToString() + ". " + char.ToUpper(document.Title[0]).ToString() + document.Title.Substring(1);
                lblTitle.Text = (lblTitle.Text.Length >= MAX_TITLE) ? lblTitle.Text.Substring(byte.MinValue, MAX_TITLE).Trim() + "..." : lblTitle.Text;

                // display description
                Label lblDesc = new Label();
                lblDesc.AutoSize = true;
                lblDesc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDesc.ForeColor = this.CurrentTheme.TEXT_PRIMARY_COLOR;
                lblDesc.Location = new System.Drawing.Point(X_POS_OTHER, Y_POS_DESC + (rank_pos * Y_NEXT_RESULT));
                lblDesc.Text = $"Document ID {document.Id}, by {document.Author}";
                lblDesc.Text = (lblDesc.Text.Length >= MAX_DESC) ? lblDesc.Text.Substring(byte.MinValue, MAX_DESC).Trim() + "..." : lblDesc.Text.Trim();

                // display abstract
                CustomLabel lblAbstract = new CustomLabel();
                lblAbstract.AutoSize = false;
                lblAbstract.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblAbstract.ForeColor = this.CurrentTheme.TEXT_SECONDARY_COLOR;
                lblAbstract.Location = new System.Drawing.Point(X_POS_OTHER, Y_POST_ABSTRACT + (rank_pos * Y_NEXT_RESULT));
                lblAbstract.Size = new Size(490, 40);
                lblAbstract.Text = char.ToUpper(document.Abstract[0]).ToString() + document.Abstract.Substring(1);
                lblAbstract.Text = (lblAbstract.Text.Length >= MAX_ABSTRACT) ? lblAbstract.Text.Substring(byte.MinValue, MAX_ABSTRACT).Trim() + "..." : lblAbstract.Text.Trim();

                // add all of them to panel
                this.resultPanel.Controls.Add(lblTitle);
                this.resultPanel.Controls.Add(lblDesc);
                this.resultPanel.Controls.Add(lblAbstract);

                // add underline animation on hover
                lblTitle.MouseEnter += (o, e) =>
                {
                    lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                };

                lblTitle.MouseLeave += (o, e) =>
                {
                    lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                };

                // add navigation on button click
                lblTitle.Click += (o, e) =>
                {
                    JournalForm jcf = new JournalForm(CurrentTheme, document);
                    jcf.Show();
                };

                rank_pos++;
            }
        }

        /// <summary>
        /// Go to previous result page
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            this.CurrentResultPage--;
            this.DisplayResults();

            this.lblPage.Text = $"{CurrentResultPage}/{(this.CurrentResultDocs.Count / MaxResultPerPage) + Math.Sign(this.CurrentResultDocs.Count % MaxResultPerPage)}";

            if (this.CurrentResultPage == 1)
            {
                this.btnPrevPage.Enabled = false;
            }
            this.btnNextPage.Enabled = true;
        }

        /// <summary>
        /// Go to next result page
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.CurrentResultPage++;
            this.DisplayResults();

            this.lblPage.Text = $"{CurrentResultPage}/{(this.CurrentResultDocs.Count / MaxResultPerPage) + Math.Sign(this.CurrentResultDocs.Count % MaxResultPerPage)}";

            if (this.CurrentResultDocs.Count <= (this.CurrentResultPage * MaxResultPerPage))
            {
                this.btnNextPage.Enabled = false;
            }
            this.btnPrevPage.Enabled = true;
        }

        /// <summary>
        /// Open SaveForm
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm saveForm = new SaveForm(CurrentTheme, CurrentResultDocs);
            saveForm.ShowDialog(this);
        }
        
        /// <summary>
        /// Add loading animation
        /// </summary>
        private void AddLoadingTest()
        {
            CustomPanel panel = new CustomPanel();
            panel.Size = new Size(this.Width, this.Height);
            panel.BackColor = Color.FromArgb(150, Color.Black);
            panel.BringToFront();

            PictureBox pb = new PictureBox();
            pb.BackColor = Color.Transparent;
            pb.Image = EduSearch.Properties.Resources.loading;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(200, 200);
            pb.Location = new Point(this.Width / 2 - pb.Width / 2, this.Height / 2 - pb.Height / 2);

            panel.Controls.Add(pb);
            this.Controls.Add(panel);
        }

        /// <summary>
        /// Show SettingsForm
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event arguments</param>
        private void pbSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this.CurrentTheme);
            sf.Show();
        }
    }
}
