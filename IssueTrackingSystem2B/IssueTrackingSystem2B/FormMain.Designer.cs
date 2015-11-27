namespace IssueTrackingSystem2B
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIssues = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWorklogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUsers,
            this.toolStripButtonIssues,
            this.toolStripButtonWorklogs});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(784, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsers.Image")));
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonUsers.Text = "&Users";
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonUsers_Click);
            // 
            // toolStripButtonIssues
            // 
            this.toolStripButtonIssues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIssues.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIssues.Image")));
            this.toolStripButtonIssues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIssues.Name = "toolStripButtonIssues";
            this.toolStripButtonIssues.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonIssues.Text = "&Issues";
            this.toolStripButtonIssues.Click += new System.EventHandler(this.toolStripButtonIssues_Click);
            // 
            // toolStripButtonWorklogs
            // 
            this.toolStripButtonWorklogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonWorklogs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWorklogs.Image")));
            this.toolStripButtonWorklogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWorklogs.Name = "toolStripButtonWorklogs";
            this.toolStripButtonWorklogs.Size = new System.Drawing.Size(61, 22);
            this.toolStripButtonWorklogs.Text = "Worklogs";
            this.toolStripButtonWorklogs.Click += new System.EventHandler(this.toolStripButtonWorklogs_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStripMain);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Main - Issue Tracking System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonIssues;
        private System.Windows.Forms.ToolStripButton toolStripButtonWorklogs;
    }
}

