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
        public String fileName = null;
        private ProjectItem project;

        public ProjectCreator() {
            InitializeComponent();
        }

        public ProjectCreator(String fileName) {
            InitializeComponent();
            this.fileName = fileName;
            this.project = new ProjectItem(fileName);
        }

        private void ProjectCreator_Load(object sender, EventArgs e) {
            BackColor = create_label.ForeColor = icon_tableLayoutPanel.BackColor =
                list_panel.BackColor = columns_gamb_tableLayoutPanel.BackColor = name_panel.BackColor =
                file_control_tableLayoutPanel.BackColor = Program.borderColor;

            back_panel.BackColor = icon_pictureBox.BackColor = choose_icon_label.BackColor =
                file_column_gamb_label.BackColor = diretory_column_gamb_label.BackColor =
                files_listView.BackColor = name_textBox.BackColor = name_panel2.BackColor =
                add_file_label.BackColor = edit_file_label.BackColor = remove_file_label.BackColor = Program.backColor;

            icon_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (fileName != null) {
                title_label.Text = "Edit project";
                create_label.Text = "Edit";
                name_textBox.Text = project.getName();
                if (File.Exists(project.getIcon()))
                    icon_pictureBox.Image = Bitmap.FromFile(project.getIcon());
                else
                    icon_pictureBox.Image = Resources.null_icon;
            }
        }

        private void create_label_Click(object sender, EventArgs e) {
            fadeDown(10, 5);
            this.Close();
        }

        private void cancel_label_Click(object sender, EventArgs e) {
            fileName = null;
            fadeDown(10, 5);
            this.Close();
        }

        private void ProjectCreator_Activated(object sender, EventArgs e) {
            setOpacity(90);
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
            PrMessageBox.Show("", "Add file", null, "Ok");
        }

        private void edit_file_label_Click(object sender, EventArgs e) {
            PrMessageBox.Show("", "Edit file", null, "Ok");
        }

        private void remove_file_label_Click(object sender, EventArgs e) {
            PrMessageBox.Show("", "Remove file", null, "Ok");
        }

        private void choose_icon_label_Click(object sender, EventArgs e) {
            PrMessageBox.Show("", "Choose icon", null, "Ok");
        }
    }
}
