namespace Project_Manager {
    partial class PrMessageBox {
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
            this.message_label = new System.Windows.Forms.Label();
            this.positive_label = new System.Windows.Forms.Label();
            this.negative_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.back_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_panel.Controls.Add(this.message_label);
            this.back_panel.Controls.Add(this.positive_label);
            this.back_panel.Controls.Add(this.negative_label);
            this.back_panel.Controls.Add(this.title_label);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(2, 2);
            this.back_panel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(410, 116);
            this.back_panel.TabIndex = 0;
            // 
            // message_label
            // 
            this.message_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.Location = new System.Drawing.Point(14, 39);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(383, 36);
            this.message_label.TabIndex = 6;
            this.message_label.Text = "Message";
            // 
            // positive_label
            // 
            this.positive_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.positive_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.positive_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positive_label.Location = new System.Drawing.Point(237, 75);
            this.positive_label.Name = "positive_label";
            this.positive_label.Size = new System.Drawing.Size(77, 30);
            this.positive_label.TabIndex = 9;
            this.positive_label.Text = "Positive";
            this.positive_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.positive_label.Click += new System.EventHandler(this.positive_label_Click);
            // 
            // negative_label
            // 
            this.negative_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.negative_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.negative_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negative_label.Location = new System.Drawing.Point(320, 75);
            this.negative_label.Name = "negative_label";
            this.negative_label.Size = new System.Drawing.Size(77, 30);
            this.negative_label.TabIndex = 8;
            this.negative_label.Text = "Negative";
            this.negative_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.negative_label.Click += new System.EventHandler(this.negative_label_Click);
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_label.Location = new System.Drawing.Point(3, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(404, 30);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Add project";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(414, 120);
            this.Controls.Add(this.back_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PrMessageBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrMessageBox";
            this.Activated += new System.EventHandler(this.PrMessageBox_Activated);
            this.Load += new System.EventHandler(this.PrMessageBox_Load);
            this.back_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label positive_label;
        private System.Windows.Forms.Label negative_label;
        private System.Windows.Forms.Label title_label;

    }
}