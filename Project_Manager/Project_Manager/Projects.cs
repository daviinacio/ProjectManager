using Project_Manager.Properties;
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
    public partial class Projects : Form {
        String projectsFile = Program.appdataFolder + "\\projects.txt";

        bool canClose = true, isFixed = false;

        ImageList imageListSmall;
	    ImageList imageListLarge;

        List<String> projects;

        public Projects() {
            InitializeComponent();
            projects = new List<String>();
        }

        // Form methods

        private void Projects_Load(object sender, EventArgs e) {
            project_lists.BackColor = Program.backColor;
            menu.BackColor = Program.backColor;
            BackColor = Program.borderColor;
            TopMost = Program.topMost;
            project_lists.LabelEdit = true;
            //project_lists.View = View.Details;

            project_lists.Columns.Add("Project", -2, HorizontalAlignment.Left);

            if (!File.Exists(projectsFile))
                File.Create(projectsFile);

            foreach (String pr in File.ReadLines(projectsFile)) {
                if (File.Exists(pr))
                    projects.Add(pr);
                else {
                    canClose = false;
                    if (PrMessageBox.Show("Project not founded", "Project: '" + Path.GetFileName(pr) + "'\nThis project will be removed") == PrMessageBox.R_Negative) { }
                }
            }

            saveProjectFile();

            //project_lists.AllowColumnReorder = true;
            // Display check boxes.
            //project_lists.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //project_lists.FullRowSelect = true;
            // Display grid lines.
            //project_lists.GridLines = true;
            // Sort the items in the list in ascending order.
            //project_lists.Sorting = SortOrder.Ascending;
            //fadeUp(20, 5);
            
            //projects.Add("C:\\Users\\Davi\\Documents\\GitHub\\BuyListManeger\\Android\\Buy List Manager.prini");
            //projects.Add("C:/Users/Davi/Documents/GitHub/BuyListManeger/Android/Buy List Manager.prini");
            //projects.Add("C:\\Users\\Davi\\Desktop\\PR0\\PR0.prini");
            //projects.Add("C:\\Users\\Davi\\Desktop\\PR1\\PR1.prini");

            update();
        }

        private void update() {
            imageListSmall = new ImageList();
            imageListLarge = new ImageList();

            imageListLarge.ImageSize = new Size(96, 96);
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;

            remove_menu.Enabled = edit_menu.Enabled = false;

            project_lists.Clear();

            //ProjectItem project = new ProjectItem("C:\\Users\\Davi\\Desktop");
            //MessageBox.Show("Nome: ");

            for (int i = 0; i < projects.Count; i++) {
                ProjectItem project = new ProjectItem(projects.ToArray()[i]);

                //MessageBox.Show("Nome: " + project.getName());
                //MessageBox.Show("Icon: " + project.getIcon());

                ListViewItem list = new ListViewItem(project.getName(), i);
                //list.i
                list.Checked = true;
                list.SubItems.Add("Teste");
                project_lists.Items.Add(list);

                if (File.Exists(project.getIcon())) {
                    imageListSmall.Images.Add(Bitmap.FromFile(project.getIcon()));
                    imageListLarge.Images.Add(Bitmap.FromFile(project.getIcon()));
                } else {
                    imageListSmall.Images.Add(Resources.null_icon);
                    imageListLarge.Images.Add(Resources.null_icon);
                }
            }

            project_lists.LargeImageList = imageListLarge;
            project_lists.SmallImageList = imageListSmall;
        }

        private void Projects_Activated(object sender, EventArgs e) {
            canClose = true;
            //fadeUp(20, 5, 85);
            setOpacity(86);
        }

        private void Projects_Deactivate(object sender, EventArgs e) {
            if (canClose && !isFixed) {
                fadeDown(10, 5);
                if (Program.projectStarter.Visible)
                    this.Hide();
                else
                    Application.Exit();
            }
        }

        // Menu methods

        private void add_menu_Click(object sender, EventArgs e) {
            canClose = false;
            ProjectAdder pr = new ProjectAdder();
            pr.ShowDialog();

            if (pr.fileName != "") {
                canClose = false;
                //MessageBox.Show(pr.fileName);
                if (!projects.Contains(pr.fileName)) {
                    projects.Add(pr.fileName);
                    canClose = true;
                } else
                    if (PrMessageBox.Show("Add error", "Esse arquivo já está no index.", null, "Ok") == PrMessageBox.R_Negative)
                        add_menu_Click(null, null);
            } //else MessageBox.Show("Nenhum arquivo selecionado");

            saveProjectFile();
            update();
        }

        private void remove_menu_Click(object sender, EventArgs e) {
            canClose = false;
            if (project_lists.SelectedIndices.Count <= 0) { return; }
            int item = project_lists.SelectedIndices[0];

            if (PrMessageBox.Show("Remove project", "This project will be removed", "Ok", "Cancel") == PrMessageBox.R_Positive) {
                projects.RemoveAt(item);
            }

            saveProjectFile();
            update();

            //MessageBox.Show("Remove " + projects.ToArray()[item]);
        }

        private void edit_menu_Click(object sender, EventArgs e) {
            canClose = false;
            if (project_lists.SelectedIndices.Count <= 0) { return; }
            int item = project_lists.SelectedIndices[0];

            new ProjectCreator(projects.ToArray()[item]).ShowDialog();

            update();
        }

        private void fix_menu_Click(object sender, EventArgs e) {
            isFixed = !isFixed;

            if (!isFixed) {
                fix_menu.BackColor = Program.backColor;
                fix_menu.ForeColor = SystemColors.Window;
            } else {
                fix_menu.BackColor = BackColor;
                fix_menu.ForeColor = Program.backColor;
            }
        }

        private void saveProjectFile() {
            File.WriteAllLines(projectsFile, projects);
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

            //Program.projectStarter = new ProjectStarter(projects.ToArray()[item]);
            Program.projectStarter = new ProjectStarter();
            Program.projectStarter.setProject(projects.ToArray()[item]);
            Program.projectStarter.Show();

            //Process.Start(projects.ToArray()[item]);

            //MessageBox.Show("Open " +  projects.ToArray()[item].getName());
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
