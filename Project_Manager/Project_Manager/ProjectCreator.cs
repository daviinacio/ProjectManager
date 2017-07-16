using Project_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager {
    public partial class ProjectCreator : Form {
        //public String fileName = null;
        private ProjectItem project;
        private static bool NEW_MODE = true, EDIT_MODE = false;
        private bool Mode;

        public ProjectCreator() {
            InitializeComponent();
        }

        public ProjectCreator(String fileName) {
            InitializeComponent();
            this.project = new ProjectItem(fileName);
        }

        private void ProjectCreator_Load(object sender, EventArgs e) {
            TopMost = Program.topMost;

            BackColor = create_label.ForeColor = icon_tableLayoutPanel.BackColor =
                list_panel.BackColor = columns_gamb_tableLayoutPanel.BackColor = name_panel.BackColor =
                file_control_tableLayoutPanel.BackColor = Program.borderColor;

            back_panel.BackColor = icon_pictureBox.BackColor = choose_icon_label.BackColor =
                file_column_gamb_label.BackColor = diretory_column_gamb_label.BackColor =
                files_listView.BackColor = name_textBox.BackColor = name_panel2.BackColor =
                add_file_label.BackColor = edit_file_label.BackColor = remove_file_label.BackColor = Program.backColor;

            icon_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            project_saveFileDialog.DefaultExt = ".prini";
            project_saveFileDialog.Filter = "Project loader file|*.prini";

            icon_openFileDialog.DefaultExt = ".png";
            icon_openFileDialog.Filter = "Image file|*.png;*.jpeg;*.jpg;*.bmp|PNG file|*.png|JPEG file|*.jpeg|JPG file|*.jpg|BMP file|*.bmp";

            Mode = project == null ? NEW_MODE : EDIT_MODE;

            files_listView.FullRowSelect = true;

            if (Mode == EDIT_MODE) {
                title_label.Text = "Edit project";
                create_label.Text = "Edit";
                name_textBox.Text = project.getName();
                icon_diretory_label.Text = project.getIcon();
                if (File.Exists(project.getIcon()))
                    icon_pictureBox.Image = Bitmap.FromFile(project.getIcon());
                else
                    icon_pictureBox.Image = Resources.null_icon;
            } else if(Mode == NEW_MODE){
                icon_pictureBox.Image = Resources.null_icon;
                project = new ProjectItem();
            }

            updateFiles();
        }

        private void create_label_Click(object sender, EventArgs e) {
            if (Mode == NEW_MODE) {
                while(true){
                    project_saveFileDialog.ShowDialog();
                    if (project_saveFileDialog.FileName != "") {
                        PrMessageBox.Show("", project_saveFileDialog.FileName);
                        project.create(project_saveFileDialog.FileName);
                        break;
                    } else
                        if (PrMessageBox.Show("Create error", "Salve o arquivo do projeto", "Ok", "Cancelar") == PrMessageBox.R_Negative) {
                            //cancel_label_Click(null, null);
                            return;
                        }
                }
            } else if (Mode == EDIT_MODE) {

            }

            project.setName(name_textBox.Text);
            project.setIcon(icon_diretory_label.Text);
            project.saveFiles();

            fadeDown(10, 5);
            this.Close();
        }

        private void cancel_label_Click(object sender, EventArgs e) {
            project = null;
            fadeDown(10, 5);
            this.Close();
        }

        private void ProjectCreator_Activated(object sender, EventArgs e) {
            setOpacity(90);
        }

        // Methods

        private void updateFiles() {
            if (project != null) {
                files_listView.Items.Clear();
                //listView1.Clear();

                for (int i = 0; i < project.getFilesCount(); i++) {
                    FileInfo file = new FileInfo(project.getFile(i));

                    ListViewItem list = new ListViewItem(file.Name, i);

                    //PrMessageBox.Show("File name", project.getFile(i));

                    list.Checked = true;

                    if (!file.Exists) {
                        list.Checked = false;
                        list.BackColor = Color.OrangeRed;
                        list.ForeColor = Color.White;
                    }

                    list.SubItems.Add(file.DirectoryName);
                    files_listView.Items.Add(list);

                    //PrMessageBox.Show("Teste", files_listView.Items[i].Text);

                    //imageListSmall.Images.Add(Bitmap.FromFile(project.getIcon()));
                    //imageListLarge.Images.Add(Bitmap.FromFile(project.getIcon()));
                }
            } else
                MessageBox.Show("Null");
        }

        // Getter

        public ProjectItem getProject() {
            return this.project;
        }

        // Fade methods

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

        private void add_file_label_Click(object sender, EventArgs e) {
            //PrMessageBox.Show("", "Add file", null, "Ok");
            //if(project != null)
            files_openFileDialog.ShowDialog();

            if (files_openFileDialog.FileName == "") return;

            project.addFile(files_openFileDialog.FileName);
            updateFiles();
        }

        private void edit_file_label_Click(object sender, EventArgs e) {
            PrMessageBox.Show("", "Edit file", null, "Ok");
            project.saveFiles();
            updateFiles();
        }

        private void remove_file_label_Click(object sender, EventArgs e) {
            //PrMessageBox.Show("", "Remove file", null, "Ok");
            if (files_listView.SelectedIndices.Count <= 0) { return; }
            int item = files_listView.SelectedIndices[0];
            project.removeFile(item);
            updateFiles();
        }

        private void choose_icon_label_Click(object sender, EventArgs e) {
            icon_openFileDialog.ShowDialog();
            if (icon_openFileDialog.FileName != "") {
                icon_diretory_label.Text = icon_openFileDialog.FileName;
                icon_pictureBox.Image = Bitmap.FromFile(icon_openFileDialog.FileName);
            }
        }
    }
}
