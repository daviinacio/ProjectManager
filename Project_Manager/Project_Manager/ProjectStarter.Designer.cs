namespace Project_Manager {
    partial class ProjectStarter {
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
            this.list_panel = new System.Windows.Forms.Panel();
            this.files_listView = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diretory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeOut_progressBar = new System.Windows.Forms.ProgressBar();
            this.name_label = new System.Windows.Forms.Label();
            this.icon_pictureBox = new System.Windows.Forms.PictureBox();
            this.openPath_button = new System.Windows.Forms.LinkLabel();
            this.start_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.Controls.Add(this.list_panel);
            this.back_panel.Controls.Add(this.timeOut_progressBar);
            this.back_panel.Controls.Add(this.name_label);
            this.back_panel.Controls.Add(this.icon_pictureBox);
            this.back_panel.Controls.Add(this.openPath_button);
            this.back_panel.Controls.Add(this.start_button);
            this.back_panel.Controls.Add(this.title_label);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(2, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(400, 480);
            this.back_panel.TabIndex = 0;
            this.back_panel.MouseEnter += new System.EventHandler(this.back_panel_MouseEnter);
            // 
            // list_panel
            // 
            this.list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_panel.Controls.Add(this.files_listView);
            this.list_panel.Location = new System.Drawing.Point(15, 159);
            this.list_panel.Name = "list_panel";
            this.list_panel.Padding = new System.Windows.Forms.Padding(1);
            this.list_panel.Size = new System.Drawing.Size(370, 253);
            this.list_panel.TabIndex = 8;
            // 
            // files_listView
            // 
            this.files_listView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.files_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.files_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.diretory});
            this.files_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_listView.ForeColor = System.Drawing.Color.White;
            this.files_listView.Location = new System.Drawing.Point(1, 1);
            this.files_listView.Name = "files_listView";
            this.files_listView.Size = new System.Drawing.Size(368, 251);
            this.files_listView.TabIndex = 6;
            this.files_listView.UseCompatibleStateImageBehavior = false;
            this.files_listView.View = System.Windows.Forms.View.Details;
            // 
            // file
            // 
            this.file.Text = "Arquivo";
            this.file.Width = 120;
            // 
            // diretory
            // 
            this.diretory.Text = "Diretorio";
            this.diretory.Width = 247;
            // 
            // timeOut_progressBar
            // 
            this.timeOut_progressBar.Location = new System.Drawing.Point(15, 427);
            this.timeOut_progressBar.Name = "timeOut_progressBar";
            this.timeOut_progressBar.Size = new System.Drawing.Size(258, 39);
            this.timeOut_progressBar.TabIndex = 7;
            this.timeOut_progressBar.Value = 50;
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(126, 36);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(259, 100);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Project name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_pictureBox
            // 
            this.icon_pictureBox.ErrorImage = global::Project_Manager.Properties.Resources.null_icon;
            this.icon_pictureBox.Image = global::Project_Manager.Properties.Resources.null_icon;
            this.icon_pictureBox.InitialImage = global::Project_Manager.Properties.Resources.null_icon;
            this.icon_pictureBox.Location = new System.Drawing.Point(15, 36);
            this.icon_pictureBox.Name = "icon_pictureBox";
            this.icon_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.icon_pictureBox.TabIndex = 4;
            this.icon_pictureBox.TabStop = false;
            // 
            // openPath_button
            // 
            this.openPath_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openPath_button.AutoSize = true;
            this.openPath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPath_button.Location = new System.Drawing.Point(22, 442);
            this.openPath_button.Name = "openPath_button";
            this.openPath_button.Size = new System.Drawing.Size(167, 18);
            this.openPath_button.TabIndex = 3;
            this.openPath_button.TabStop = true;
            this.openPath_button.Text = "Abrir diretorio do projeto";
            // 
            // start_button
            // 
            this.start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(279, 427);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(106, 39);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(3, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(394, 33);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Project Starter";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(404, 484);
            this.Controls.Add(this.back_panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectStarter";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectStarter";
            this.Activated += new System.EventHandler(this.ProjectStarter_Activated);
            this.Deactivate += new System.EventHandler(this.ProjectStarter_Deactivate);
            this.Load += new System.EventHandler(this.ProjectStarter_Load);
            this.back_panel.ResumeLayout(false);
            this.back_panel.PerformLayout();
            this.list_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.LinkLabel openPath_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox icon_pictureBox;
        private System.Windows.Forms.ListView files_listView;
        private System.Windows.Forms.ProgressBar timeOut_progressBar;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader diretory;
    }
}