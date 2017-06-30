namespace Project_Manager {
    partial class Projects {
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
            this.project_lists = new System.Windows.Forms.ListView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.fix_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // project_lists
            // 
            this.project_lists.BackColor = System.Drawing.Color.DimGray;
            this.project_lists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.project_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_lists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_lists.ForeColor = System.Drawing.SystemColors.Window;
            this.project_lists.Location = new System.Drawing.Point(2, 37);
            this.project_lists.Margin = new System.Windows.Forms.Padding(0);
            this.project_lists.Name = "project_lists";
            this.project_lists.Size = new System.Drawing.Size(912, 520);
            this.project_lists.TabIndex = 0;
            this.project_lists.UseCompatibleStateImageBehavior = false;
            this.project_lists.SelectedIndexChanged += new System.EventHandler(this.project_lists_SelectedIndexChanged);
            this.project_lists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.project_lists_MouseDoubleClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DimGray;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.remove_menu,
            this.edit_menu,
            this.fix_menu});
            this.menu.Location = new System.Drawing.Point(2, 2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 7, 0, 7);
            this.menu.Size = new System.Drawing.Size(912, 35);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // add_menu
            // 
            this.add_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(49, 21);
            this.add_menu.Text = "ADD";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // remove_menu
            // 
            this.remove_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.remove_menu.Name = "remove_menu";
            this.remove_menu.Size = new System.Drawing.Size(73, 21);
            this.remove_menu.Text = "REMOVE";
            this.remove_menu.Click += new System.EventHandler(this.remove_menu_Click);
            // 
            // edit_menu
            // 
            this.edit_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.Size = new System.Drawing.Size(49, 21);
            this.edit_menu.Text = "EDIT";
            this.edit_menu.Click += new System.EventHandler(this.edit_menu_Click);
            // 
            // fix_menu
            // 
            this.fix_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fix_menu.CheckOnClick = true;
            this.fix_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fix_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.fix_menu.Name = "fix_menu";
            this.fix_menu.Size = new System.Drawing.Size(40, 21);
            this.fix_menu.Text = "FIX";
            this.fix_menu.Click += new System.EventHandler(this.fix_menu_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(916, 559);
            this.Controls.Add(this.project_lists);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Projects";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Manager";
            this.Deactivate += new System.EventHandler(this.Projects_Deactivate);
            this.Load += new System.EventHandler(this.Projects_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView project_lists;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem remove_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_menu;
        private System.Windows.Forms.ToolStripMenuItem fix_menu;


    }
}

