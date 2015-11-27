namespace IssueTrackingSystem2B
{
    partial class FormWorklogs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorklogs));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewWorklogs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggedHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLogged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceWorklogs = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorklogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorklogs)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(33, 22);
            this.toolStripButtonAdd.Text = "Add";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(31, 22);
            this.toolStripButtonEdit.Text = "Edit";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // dataGridViewWorklogs
            // 
            this.dataGridViewWorklogs.AllowUserToAddRows = false;
            this.dataGridViewWorklogs.AllowUserToDeleteRows = false;
            this.dataGridViewWorklogs.AutoGenerateColumns = false;
            this.dataGridViewWorklogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorklogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserID,
            this.IssueID,
            this.LoggedHours,
            this.DateLogged});
            this.dataGridViewWorklogs.DataSource = this.bindingSourceWorklogs;
            this.dataGridViewWorklogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWorklogs.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewWorklogs.Name = "dataGridViewWorklogs";
            this.dataGridViewWorklogs.ReadOnly = true;
            this.dataGridViewWorklogs.Size = new System.Drawing.Size(523, 281);
            this.dataGridViewWorklogs.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserId";
            this.UserID.HeaderText = "User Id";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "IssueId";
            this.IssueID.HeaderText = "Issue Id";
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            // 
            // LoggedHours
            // 
            this.LoggedHours.DataPropertyName = "LoggedHours";
            this.LoggedHours.HeaderText = "Logged Hours";
            this.LoggedHours.Name = "LoggedHours";
            this.LoggedHours.ReadOnly = true;
            // 
            // DateLogged
            // 
            this.DateLogged.DataPropertyName = "DateLogged";
            this.DateLogged.HeaderText = "Date Logged";
            this.DateLogged.Name = "DateLogged";
            this.DateLogged.ReadOnly = true;
            // 
            // FormWorklogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 306);
            this.Controls.Add(this.dataGridViewWorklogs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormWorklogs";
            this.Text = "Worklogs - Issue Tracking System";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorklogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorklogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridViewWorklogs;
        private System.Windows.Forms.BindingSource bindingSourceWorklogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoggedHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLogged;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}