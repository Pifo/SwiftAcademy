namespace MovieStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMainForm = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDvd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRent = new System.Windows.Forms.ToolStripButton();
            this.toolStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMainForm
            // 
            this.toolStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUser,
            this.toolStripButtonDvd,
            this.toolStripButtonRent});
            this.toolStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainForm.Name = "toolStripMainForm";
            this.toolStripMainForm.Size = new System.Drawing.Size(501, 25);
            this.toolStripMainForm.TabIndex = 0;
            this.toolStripMainForm.Text = "toolStripMain";
            // 
            // toolStripButtonUser
            // 
            this.toolStripButtonUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUser.Image = global::MovieStore.Properties.Resources.Misc_User_icon;
            this.toolStripButtonUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUser.Name = "toolStripButtonUser";
            this.toolStripButtonUser.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUser.Text = "Customers";
            this.toolStripButtonUser.Click += new System.EventHandler(this.toolStripButtonUser_Click);
            // 
            // toolStripButtonDvd
            // 
            this.toolStripButtonDvd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDvd.Image = global::MovieStore.Properties.Resources.HD_DVD_icon;
            this.toolStripButtonDvd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDvd.Name = "toolStripButtonDvd";
            this.toolStripButtonDvd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDvd.Text = "DVDs";
            this.toolStripButtonDvd.Click += new System.EventHandler(this.toolStripButtonDvd_Click);
            // 
            // toolStripButtonRent
            // 
            this.toolStripButtonRent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRent.Image = global::MovieStore.Properties.Resources.Folder_TV_Disney_icon;
            this.toolStripButtonRent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRent.Name = "toolStripButtonRent";
            this.toolStripButtonRent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRent.Text = "Rentals";
            this.toolStripButtonRent.Click += new System.EventHandler(this.toolStripButtonRent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 367);
            this.Controls.Add(this.toolStripMainForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStripMainForm.ResumeLayout(false);
            this.toolStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMainForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonDvd;
        private System.Windows.Forms.ToolStripButton toolStripButtonRent;
    }
}