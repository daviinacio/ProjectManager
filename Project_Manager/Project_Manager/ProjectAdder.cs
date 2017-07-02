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
            BackColor = add_label.ForeColor = create_label.ForeColor = Program.borderColor;
            back_panel.BackColor = Program.backColor;

            file_textBox.BackColor = findFile_button.BackColor = Program.backColor;
            file_textBox.ForeColor = findFile_button.ForeColor = Program.foreColor;

            openFileDialog.DefaultExt = DefaultExt;
            openFileDialog.Filter = Filter;
        }

        private void ProjectAdder_Activated(object sender, EventArgs e) {
            setOpacity(80);
        }

        private void ProjectAdder_Deactivate(object sender, EventArgs e) {
            //fadeDown(10, 5);
            //this.Close();
        }

        // Button click
        private void findFile_button_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
            file_textBox.Text = openFileDialog.FileName;
        }

        // Label click
        private void add_label_Click(object sender, EventArgs e) {
            fileName = file_textBox.Text;
            fadeDown(10, 5);
            this.Close();
        }

        private void create_label_Click(object sender, EventArgs e) {
            ProjectCreator prct = new ProjectCreator();

            prct.ShowDialog();

            //file_textBox.Text = prct.fileName;
        }

        private void cancel_label_Click(object sender, EventArgs e) {
            fadeDown(10, 5);
            this.Close();
        }

        private void file_textBox_TextChanged(object sender, EventArgs e) {
            add_label.Enabled = file_textBox.Text.Length > 0;
        }

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
    }
}
