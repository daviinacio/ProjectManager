using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Manager {
    public partial class ProjectCreator : Form {
        public String fileName = "";

        public ProjectCreator() {
            InitializeComponent();
        }

        private void ProjectCreator_Load(object sender, EventArgs e) {
            BackColor = create_label.ForeColor = Program.borderColor;
            back_panel.BackColor = Program.backColor;
        }

        private void create_label_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancel_label_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
