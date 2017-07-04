namespace Project_Manager {
    partial class ProjectAdder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.back_panel = new System.Windows.Forms.Panel();
            this.create_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.cancel_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.file_textBox = new System.Windows.Forms.TextBox();
            this.file_label = new System.Windows.Forms.Label();
            this.file_panel = new System.Windows.Forms.Panel();
            this.findFile_panel = new System.Windows.Forms.Panel();
            this.findFile_label = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.file_panel.SuspendLayout();
            this.findFile_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_panel.Controls.Add(this.create_label);
            this.back_panel.Controls.Add(this.add_label);
            this.back_panel.Controls.Add(this.cancel_label);
            this.back_panel.Controls.Add(this.file_panel);
            this.back_panel.Controls.Add(this.title_label);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_panel.Location = new System.Drawing.Point(2, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(406, 136);
            this.back_panel.TabIndex = 0;
            // 
            // create_label
            // 
            this.create_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_label.Location = new System.Drawing.Point(268, 94);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(59, 30);
            this.create_label.TabIndex = 5;
            this.create_label.Text = "Create";
            this.create_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_label.Click += new System.EventHandler(this.create_label_Click);
            // 
            // add_label
            // 
            this.add_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_label.Enabled = false;
            this.add_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_label.Location = new System.Drawing.Point(220, 94);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(42, 30);
            this.add_label.TabIndex = 4;
            this.add_label.Text = "Add";
            this.add_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_label.Click += new System.EventHandler(this.add_label_Click);
            // 
            // cancel_label
            // 
            this.cancel_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_label.Location = new System.Drawing.Point(333, 94);
            this.cancel_label.Name = "cancel_label";
            this.cancel_label.Size = new System.Drawing.Size(67, 30);
            this.cancel_label.TabIndex = 3;
            this.cancel_label.Text = "Cancel";
            this.cancel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel_label.Click += new System.EventHandler(this.cancel_label_Click);
            // 
            // title_label
            // 
            this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_label.Location = new System.Drawing.Point(0, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(406, 27);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Add project";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // file_textBox
            // 
            this.file_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file_textBox.Enabled = false;
            this.file_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_textBox.ForeColor = System.Drawing.Color.White;
            this.file_textBox.Location = new System.Drawing.Point(10, 21);
            this.file_textBox.Name = "file_textBox";
            this.file_textBox.Size = new System.Drawing.Size(295, 26);
            this.file_textBox.TabIndex = 1;
            this.file_textBox.TextChanged += new System.EventHandler(this.file_textBox_TextChanged);
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_label.Location = new System.Drawing.Point(3, 0);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(38, 16);
            this.file_label.TabIndex = 6;
            this.file_label.Text = "File:";
            // 
            // file_panel
            // 
            this.file_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_panel.BackColor = System.Drawing.Color.Transparent;
            this.file_panel.Controls.Add(this.findFile_panel);
            this.file_panel.Controls.Add(this.file_label);
            this.file_panel.Controls.Add(this.file_textBox);
            this.file_panel.Location = new System.Drawing.Point(6, 30);
            this.file_panel.Name = "file_panel";
            this.file_panel.Size = new System.Drawing.Size(394, 61);
            this.file_panel.TabIndex = 2;
            // 
            // findFile_panel
            // 
            this.findFile_panel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.findFile_panel.Controls.Add(this.findFile_label);
            this.findFile_panel.ForeColor = System.Drawing.Color.White;
            this.findFile_panel.Location = new System.Drawing.Point(311, 21);
            this.findFile_panel.Name = "findFile_panel";
            this.findFile_panel.Padding = new System.Windows.Forms.Padding(1);
            this.findFile_panel.Size = new System.Drawing.Size(80, 26);
            this.findFile_panel.TabIndex = 7;
            // 
            // findFile_label
            // 
            this.findFile_label.BackColor = System.Drawing.Color.DimGray;
            this.findFile_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findFile_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findFile_label.Location = new System.Drawing.Point(1, 1);
            this.findFile_label.Name = "findFile_label";
            this.findFile_label.Size = new System.Drawing.Size(78, 24);
            this.findFile_label.TabIndex = 8;
            this.findFile_label.Text = "Find";
            this.findFile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findFile_label.Click += new System.EventHandler(this.findFile_label_Click);
            // 
            // ProjectAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(410, 140);
            this.Controls.Add(this.back_panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectAdder";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectAdder";
            this.Activated += new System.EventHandler(this.ProjectAdder_Activated);
            this.Deactivate += new System.EventHandler(this.ProjectAdder_Deactivate);
            this.Load += new System.EventHandler(this.ProjectAdder_Load);
            this.back_panel.ResumeLayout(false);
            this.file_panel.ResumeLayout(false);
            this.file_panel.PerformLayout();
            this.findFile_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Label cancel_label;
        private System.Windows.Forms.Label create_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel file_panel;
        private System.Windows.Forms.Panel findFile_panel;
        private System.Windows.Forms.Label findFile_label;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.TextBox file_textBox;
    }
}