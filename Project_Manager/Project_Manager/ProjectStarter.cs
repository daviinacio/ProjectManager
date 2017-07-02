using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager {
    public partial class ProjectStarter : Form {
        private ProjectItem project;
        private bool autoStart = true;

        private System.Windows.Forms.Timer backTast;

        public ProjectStarter() {
            InitializeComponent();
        }

        public ProjectStarter(String project) {
            InitializeComponent();
            setProject(project);
        }

        private void ProjectStarter_Load(object sender, EventArgs e) {
            setOpacity(90);
            //TopMost = true;

            BackColor = openPath_button.LinkColor = list_panel.BackColor = Program.borderColor;
            back_panel.BackColor = start_button.BackColor = files_listView.BackColor = Program.backColor;
            openPath_button.ActiveLinkColor = Color.White;

            //icon_pictureBox.ImageSize = new Size(96, 96);
            icon_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            //MessageBox.Show(project.getFile());

            //files_listView.Columns.Add("Arquivo", -2, HorizontalAlignment.Left);
            //files_listView.Columns.Add("Diretorio", -2, HorizontalAlignment.Right);

            //files_listView.AllowColumnReorder = true;
            // Display check boxes.
            files_listView.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            files_listView.FullRowSelect = true;
            // Display grid lines.
            //files_listView.GridLines = true;
            // Sort the items in the list in ascending order.
            //files_listView.Sorting = SortOrder.Ascending;

            // Load project information
            if (project != null) {
                name_label.Text = project.getName();
                icon_pictureBox.Image = Bitmap.FromFile(project.getIcon());
                //String[] files = { "C:\\Users\\File 1", "C:\\File 2"};

                //MessageBox.Show(project.getFilesCount() + "");

                for (int i = 0; i < project.getFilesCount(); i++) {
                    FileInfo file = new FileInfo(project.getFile(i));

                    ListViewItem list = new ListViewItem(file.Name, i);
                    //list.i
                    list.Checked = true;
                    list.SubItems.Add(file.DirectoryName);
                    files_listView.Items.Add(list);

                    //imageListSmall.Images.Add(Bitmap.FromFile(project.getIcon()));
                    //imageListLarge.Images.Add(Bitmap.FromFile(project.getIcon()));
                }
            } else
                MessageBox.Show("Null");

            timeOut_progressBar.Maximum = 300;
            timeOut_progressBar.Minimum = 0;
            timeOut_progressBar.Value = timeOut_progressBar.Minimum;

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 10;
            this.backTast.Start();
        }

        private void ProjectStarter_Activated(object sender, EventArgs e) {
            //fadeUp(10, 5, 90);
            setOpacity(90);
        }

        private void ProjectStarter_Deactivate(object sender, EventArgs e) {
            //return;
            fadeDown(20, 5);
            if (Program.projects.Visible)
                this.Hide();
            else
                Application.Exit();
            //Application.Exit();
        }

        private void backTasking(object sender, EventArgs e) {
            if (autoStart) {
                timeOut_progressBar.Visible = true;
                openPath_button.Visible = false;

                if (timeOut_progressBar.Value < timeOut_progressBar.Maximum -1) {
                    timeOut_progressBar.Value += 1;
                } else
                if(timeOut_progressBar.Value == timeOut_progressBar.Maximum -1) {
                    timeOut_progressBar.Value += 1;
                    start_button_Click(null, null);
                }
            } else {
                timeOut_progressBar.Visible = false;
                openPath_button.Visible = true;
            }
        }

        private void files_listView_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void files_listView_MouseDoubleClick(object sender, MouseEventArgs e) {

        }

        private void start_button_Click(object sender, EventArgs e) {
            for (int i = 0; i < project.getFilesCount(); i++)
                if (files_listView.Items.Find("", false)[i].Checked)
                    try { Process.Start(project.getFile(i)); } 
                    catch (System.ComponentModel.Win32Exception) { }
        }

        private void openPath_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(project.getPath());
        }

        public void ExecuteAsAdmin(string fileName) {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        public void setProject(String project) {
            this.project = new ProjectItem(project);
            //MessageBox.Show(project);
        }

        // On finalize open Application.Exit();

        // Fade methods

        //int defaultOpct = 85;
        int opct = 0;

        private void fadeUp(int delay, int increment, int value) {
            while (opct < value) {
                opct += increment;
                updateOpacity();
                Thread.Sleep(delay);
            }
        }
        private void fadeDown(int delay, int decrement) {
            while (opct > 20) {
                setOpacity(opct - decrement);
                Thread.Sleep(delay);
            }
        }
        private void setOpacity(int opacity) {
            this.opct = opacity;
            updateOpacity();
        }
        private void updateOpacity() {
            this.Opacity = (double)opct / 100;
        }

        private void back_panel_MouseEnter(object sender, EventArgs e) {
            autoStart = false;
        }
    }
}
