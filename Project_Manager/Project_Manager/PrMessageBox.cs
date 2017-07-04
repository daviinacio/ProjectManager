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
    public partial class PrMessageBox : Form {
        // Return messageBox
        public static int R_Positive = 100, R_Negative = 101;
        public int request = 0;

        public PrMessageBox() {
            InitializeComponent();
        }

        private void PrMessageBox_Load(object sender, EventArgs e) {
            BackColor = positive_label.ForeColor = Program.borderColor;
            back_panel.BackColor = Program.backColor;
        }

        private void PrMessageBox_FormClosing(object sender, FormClosingEventArgs e) {
            fadeDown(10, 5);
        }

        private void PrMessageBox_Activated(object sender, EventArgs e) {
            setOpacity(75);
        }

        // Label click

        private void positive_label_Click(object sender, EventArgs e) {
            request = R_Positive;
            fadeDown(10, 5);
            this.Close();
        }

        private void negative_label_Click(object sender, EventArgs e) {
            request = R_Negative;
            fadeDown(10, 5);
            this.Close();
        }

        public void setTitle(String title) {
            title_label.Text = title;
        }
        public void setMessage(String message) {
            message_label.Text = message;
        }
        public void setPositive(String positive) {
            positive_label.Text = positive;
        }
        public void setNegative(String negative) {
            negative_label.Text = negative;
        }

        public static int Show(String title, String message, String positive, String negative) {
            PrMessageBox prmb = new PrMessageBox();
            prmb.setTitle(title);
            prmb.setMessage(message);

            if (positive != "" && positive != null) prmb.setPositive(positive);
            else prmb.positive_label.Visible = false;

            if (positive != "" && negative != null) prmb.setNegative(negative);
            else prmb.negative_label.Visible = false;

            prmb.ShowDialog();

            return prmb.request;
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
