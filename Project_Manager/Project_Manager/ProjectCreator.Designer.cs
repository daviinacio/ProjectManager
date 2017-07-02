namespace Project_Manager {
    partial class ProjectCreator {
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
            this.label1 = new System.Windows.Forms.Label();
            this.create_label = new System.Windows.Forms.Label();
            this.cancel_label = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_panel.Controls.Add(this.create_label);
            this.back_panel.Controls.Add(this.cancel_label);
            this.back_panel.Controls.Add(this.label1);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(2, 2);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(529, 369);
            this.back_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create_label
            // 
            this.create_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_label.ForeColor = System.Drawing.Color.Gold;
            this.create_label.Location = new System.Drawing.Point(390, 330);
            this.create_label.Name = "create_label";
            this.create_label.Size = new System.Drawing.Size(59, 30);
            this.create_label.TabIndex = 8;
            this.create_label.Text = "Create";
            this.create_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_label.Click += new System.EventHandler(this.create_label_Click);
            // 
            // cancel_label
            // 
            this.cancel_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_label.Location = new System.Drawing.Point(455, 330);
            this.cancel_label.Name = "cancel_label";
            this.cancel_label.Size = new System.Drawing.Size(67, 30);
            this.cancel_label.TabIndex = 6;
            this.cancel_label.Text = "Cancel";
            this.cancel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel_label.Click += new System.EventHandler(this.cancel_label_Click);
            // 
            // ProjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(533, 373);
            this.Controls.Add(this.back_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProjectCreator";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectCreator";
            this.Load += new System.EventHandler(this.ProjectCreator_Load);
            this.back_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label create_label;
        private System.Windows.Forms.Label cancel_label;
    }
}