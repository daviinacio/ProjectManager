using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager {
    public partial class ProjectAdder : Form {
        public static String DefaultExt = ".prini";
        public static String Filter = "Project loader file (*.prini)|*.prini;*.prIni;";
        public String fileName = "";


        public ProjectAdder() {
            InitializeComponent();
        }

        private void ProjectAdder_Load(object sender, EventArgs e) {
            TopMost = Program.topMost;
            BackColor = add_label.ForeColor = create_label.ForeColor = findFile_panel.BackColor = Program.borderColor;
            back_panel.BackColor = Program.backColor;

            file_textBox.BackColor = findFile_label.BackColor = Program.backColor;
            file_textBox.ForeColor = findFile_label.ForeColor = Program.foreColor;

            openFileDialog.DefaultExt = DefaultExt;
            openFileDialog.Filter = Filter;

            update();
        }

        private void ProjectAdder_Activated(object sender, EventArgs e) {
            setOpacity(80);
        }

        private void ProjectAdder_Deactivate(object sender, EventArgs e) {
            //fadeDown(10, 5);
            //this.Close();
        }

        // Label click
        private void findFile_label_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
            file_textBox.Text = openFileDialog.FileName;
        }

        private void add_label_Click(object sender, EventArgs e) {
            fileName = file_textBox.Text;
            fadeDown(10, 5);
            this.Close();
        }

        private void create_label_Click(object sender, EventArgs e) {
            ProjectCreator prct = new ProjectCreator();

            prct.ShowDialog();

            if(prct.getProject() != null)
                file_textBox.Text = prct.getProject().getProjectFile();
        }

        private void cancel_label_Click(object sender, EventArgs e) {
            fadeDown(10, 5);
            this.Close();
        }

        private void file_textBox_TextChanged(object sender, EventArgs e) {
            add_label.Enabled = file_textBox.Text.Length > 0;
            update();
        }

        private void update() {
            add_label.ForeColor = add_label.Enabled ? Program.borderColor : Program.backColor;
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
    }
}
