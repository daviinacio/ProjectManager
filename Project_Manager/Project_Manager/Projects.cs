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
    public partial class Projects : Form {
        int defaultOpct = 85;
        int opct = 0;

        bool canClose = true, isFixed = false;

        Color backColor = ColorTranslator.FromHtml("#202020");

        ImageList imageListSmall;
	    ImageList imageListLarge;

        List<ProjectItem> projects;

        public Projects() {
            InitializeComponent();
            projects = new List<ProjectItem>();
        }

        // Form methods

        private void Projects_Load(object sender, EventArgs e) {
            setOpacity(defaultOpct);
            project_lists.BackColor = backColor;
            menu.BackColor = backColor;
            TopMost = true;
            project_lists.LabelEdit = true;
            //project_lists.View = View.Details;

            project_lists.Columns.Add("Project", -2, HorizontalAlignment.Left);

            //project_lists.AllowColumnReorder = true;
            // Display check boxes.
            //project_lists.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //project_lists.FullRowSelect = true;
            // Display grid lines.
            //project_lists.GridLines = true;
            // Sort the items in the list in ascending order.
            project_lists.Sorting = SortOrder.Ascending;
            //fadeUp(20, 5);

            projects.Add(new ProjectItem("C:\\Users\\Davi\\Desktop\\PR0"));
            projects.Add(new ProjectItem("C:\\Users\\Davi\\Desktop\\PR1"));

            update();
        }

        private void update() {
            imageListSmall = new ImageList();
            imageListLarge = new ImageList();

            imageListLarge.ImageSize = new Size(96, 96);
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;

            remove_menu.Enabled = edit_menu.Enabled = false;

            //project_lists.Clear();

            //ProjectItem project = new ProjectItem("C:\\Users\\Davi\\Desktop");
            //MessageBox.Show("Nome: ");

            for (int i = 0; i < projects.Count; i++) {
                ProjectItem project = projects.ToArray()[i];

                //MessageBox.Show("Nome: " + project.getName());
                //MessageBox.Show("Icon: " + project.getIcon());

                ListViewItem list = new ListViewItem(project.getName(), i);
                //list.i
                list.Checked = true;
                list.SubItems.Add("Teste");
                project_lists.Items.Add(list);

                imageListSmall.Images.Add(Bitmap.FromFile(project.getIcon()));
                imageListLarge.Images.Add(Bitmap.FromFile(project.getIcon()));
            }

            project_lists.LargeImageList = imageListLarge;
            project_lists.SmallImageList = imageListSmall;
        }

        private void Projects_Deactivate(object sender, EventArgs e) {
            if (canClose && !isFixed) {
                fadeDown(20, 5);
                this.Close();
            }
        }

        // Menu methods

        private void add_menu_Click(object sender, EventArgs e) {
            MessageBox.Show("Add");
        }

        private void remove_menu_Click(object sender, EventArgs e) {
            if (project_lists.SelectedIndices.Count <= 0) { return; }
            int item = project_lists.SelectedIndices[0];

            MessageBox.Show("Remove " + projects.ToArray()[item].getName());
        }

        private void edit_menu_Click(object sender, EventArgs e) {
            if (project_lists.SelectedIndices.Count <= 0) { return; }
            int item = project_lists.SelectedIndices[0];

            MessageBox.Show("Edit " + projects.ToArray()[item].getName());
        }

        private void fix_menu_Click(object sender, EventArgs e) {
            isFixed = !isFixed;

            if (!isFixed) {
                fix_menu.BackColor = backColor;
                fix_menu.ForeColor = SystemColors.Window;
            } else {
                fix_menu.BackColor = BackColor;
                fix_menu.ForeColor = backColor;
            }
        }

        // ListView methods

        private void project_lists_SelectedIndexChanged(object sender, EventArgs e) {
            if (project_lists.SelectedIndices.Count <= 0) {
                remove_menu.Enabled = edit_menu.Enabled = false;
            } else {
                remove_menu.Enabled = edit_menu.Enabled = true;
            }
        }

        private void project_lists_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (project_lists.SelectedIndices.Count <= 0) { return; }
            int item = project_lists.SelectedIndices[0];

            MessageBox.Show("Open " +  projects.ToArray()[item].getName());
        }

        // Fade methods

        private void fadeUp(int delay, int increment) {
            while (opct < defaultOpct) {
                setOpacity(opct + increment);
                Thread.Sleep(delay);
            }
        }
        private void fadeDown(int delay, int decrement) {
            while(opct > 20) {
                setOpacity(opct - decrement);
                Thread.Sleep(delay);
            }
        }
        private void setOpacity(int opacity) {
            this.opct = opacity;
            updateOpacity();
        }
        private void updateOpacity(){
            this.Opacity = (double) opct / 100;
        }
        
    }
}
