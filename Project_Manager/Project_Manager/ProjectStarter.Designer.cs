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
            this.start_panel = new System.Windows.Forms.Panel();
            this.start_label = new System.Windows.Forms.Label();
            this.timeOut_label = new System.Windows.Forms.Label();
            this.columns_gamb_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.file_column_gamb_label = new System.Windows.Forms.Label();
            this.diretory_column_gamb_label = new System.Windows.Forms.Label();
            this.list_panel = new System.Windows.Forms.Panel();
            this.files_listView = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diretory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_label = new System.Windows.Forms.Label();
            this.icon_pictureBox = new System.Windows.Forms.PictureBox();
            this.openPath_button = new System.Windows.Forms.LinkLabel();
            this.title_label = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.start_panel.SuspendLayout();
            this.columns_gamb_tableLayoutPanel.SuspendLayout();
            this.list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.Controls.Add(this.start_panel);
            this.back_panel.Controls.Add(this.timeOut_label);
            this.back_panel.Controls.Add(this.columns_gamb_tableLayoutPanel);
            this.back_panel.Controls.Add(this.list_panel);
            this.back_panel.Controls.Add(this.name_label);
            this.back_panel.Controls.Add(this.icon_pictureBox);
            this.back_panel.Controls.Add(this.openPath_button);
            this.back_panel.Controls.Add(this.title_label);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(2, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(400, 480);
            this.back_panel.TabIndex = 0;
            this.back_panel.MouseEnter += new System.EventHandler(this.back_panel_MouseEnter);
            // 
            // start_panel
            // 
            this.start_panel.Controls.Add(this.start_label);
            this.start_panel.Location = new System.Drawing.Point(279, 427);
            this.start_panel.Name = "start_panel";
            this.start_panel.Padding = new System.Windows.Forms.Padding(2);
            this.start_panel.Size = new System.Drawing.Size(105, 35);
            this.start_panel.TabIndex = 10;
            // 
            // start_label
            // 
            this.start_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_label.Location = new System.Drawing.Point(2, 2);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(101, 31);
            this.start_label.TabIndex = 0;
            this.start_label.Text = "Start";
            this.start_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_label.Click += new System.EventHandler(this.start_label_Click);
            // 
            // timeOut_label
            // 
            this.timeOut_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOut_label.Location = new System.Drawing.Point(19, 427);
            this.timeOut_label.Name = "timeOut_label";
            this.timeOut_label.Size = new System.Drawing.Size(254, 35);
            this.timeOut_label.TabIndex = 9;
            this.timeOut_label.Text = "3s para abrir...";
            this.timeOut_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columns_gamb_tableLayoutPanel
            // 
            this.columns_gamb_tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.columns_gamb_tableLayoutPanel.ColumnCount = 2;
            this.columns_gamb_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columns_gamb_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columns_gamb_tableLayoutPanel.Controls.Add(this.file_column_gamb_label, 0, 0);
            this.columns_gamb_tableLayoutPanel.Controls.Add(this.diretory_column_gamb_label, 1, 0);
            this.columns_gamb_tableLayoutPanel.Location = new System.Drawing.Point(15, 159);
            this.columns_gamb_tableLayoutPanel.Name = "columns_gamb_tableLayoutPanel";
            this.columns_gamb_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.columns_gamb_tableLayoutPanel.RowCount = 1;
            this.columns_gamb_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columns_gamb_tableLayoutPanel.Size = new System.Drawing.Size(370, 25);
            this.columns_gamb_tableLayoutPanel.TabIndex = 0;
            // 
            // file_column_gamb_label
            // 
            this.file_column_gamb_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.file_column_gamb_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file_column_gamb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_column_gamb_label.Location = new System.Drawing.Point(1, 1);
            this.file_column_gamb_label.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.file_column_gamb_label.Name = "file_column_gamb_label";
            this.file_column_gamb_label.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.file_column_gamb_label.Size = new System.Drawing.Size(183, 23);
            this.file_column_gamb_label.TabIndex = 0;
            this.file_column_gamb_label.Text = "Arquivo";
            this.file_column_gamb_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diretory_column_gamb_label
            // 
            this.diretory_column_gamb_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.diretory_column_gamb_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diretory_column_gamb_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretory_column_gamb_label.Location = new System.Drawing.Point(185, 1);
            this.diretory_column_gamb_label.Margin = new System.Windows.Forms.Padding(0);
            this.diretory_column_gamb_label.Name = "diretory_column_gamb_label";
            this.diretory_column_gamb_label.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.diretory_column_gamb_label.Size = new System.Drawing.Size(184, 23);
            this.diretory_column_gamb_label.TabIndex = 1;
            this.diretory_column_gamb_label.Text = "Diretorio";
            this.diretory_column_gamb_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.files_listView.SelectedIndexChanged += new System.EventHandler(this.files_listView_SelectedIndexChanged);
            this.files_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.files_listView_MouseDoubleClick);
            // 
            // file
            // 
            this.file.Text = "Arquivo";
            this.file.Width = 184;
            // 
            // diretory
            // 
            this.diretory.Text = "Diretorio";
            this.diretory.Width = 184;
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
            this.openPath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPath_button.LinkColor = System.Drawing.Color.White;
            this.openPath_button.Location = new System.Drawing.Point(22, 442);
            this.openPath_button.Name = "openPath_button";
            this.openPath_button.Size = new System.Drawing.Size(178, 20);
            this.openPath_button.TabIndex = 3;
            this.openPath_button.TabStop = true;
            this.openPath_button.Text = "Abrir diretorio do projeto";
            this.openPath_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openPath_button_LinkClicked);
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
            this.start_panel.ResumeLayout(false);
            this.columns_gamb_tableLayoutPanel.ResumeLayout(false);
            this.list_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.LinkLabel openPath_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox icon_pictureBox;
        private System.Windows.Forms.ListView files_listView;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader diretory;
        private System.Windows.Forms.TableLayoutPanel columns_gamb_tableLayoutPanel;
        private System.Windows.Forms.Label file_column_gamb_label;
        private System.Windows.Forms.Label diretory_column_gamb_label;
        private System.Windows.Forms.Label timeOut_label;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.Label start_label;
    }
}