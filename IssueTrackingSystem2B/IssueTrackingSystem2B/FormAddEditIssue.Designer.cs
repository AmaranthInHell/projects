namespace IssueTrackingSystem2B
{
    partial class FormAddEditIssue
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerDateModified = new System.Windows.Forms.DateTimePicker();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.labelAssignedID = new System.Windows.Forms.Label();
            this.textBoxAssignedID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEstimate = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateCreated = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEstimate = new System.Windows.Forms.Label();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.labelDateModified = new System.Windows.Forms.Label();
            this.labelIssueStatus = new System.Windows.Forms.Label();
            this.textBoxIssueStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(255, 261);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(123, 37);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(65, 261);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 37);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerDateModified
            // 
            this.dateTimePickerDateModified.Location = new System.Drawing.Point(178, 184);
            this.dateTimePickerDateModified.Name = "dateTimePickerDateModified";
            this.dateTimePickerDateModified.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateModified.TabIndex = 2;
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(62, 28);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(49, 13);
            this.labelAuthorID.TabIndex = 3;
            this.labelAuthorID.Text = "AuthorID";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(178, 28);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthorID.TabIndex = 4;
            // 
            // labelAssignedID
            // 
            this.labelAssignedID.AutoSize = true;
            this.labelAssignedID.Location = new System.Drawing.Point(62, 54);
            this.labelAssignedID.Name = "labelAssignedID";
            this.labelAssignedID.Size = new System.Drawing.Size(61, 13);
            this.labelAssignedID.TabIndex = 5;
            this.labelAssignedID.Text = "AssignedID";
            // 
            // textBoxAssignedID
            // 
            this.textBoxAssignedID.Location = new System.Drawing.Point(178, 54);
            this.textBoxAssignedID.Name = "textBoxAssignedID";
            this.textBoxAssignedID.Size = new System.Drawing.Size(200, 20);
            this.textBoxAssignedID.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(178, 80);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(178, 106);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 8;
            // 
            // textBoxEstimate
            // 
            this.textBoxEstimate.Location = new System.Drawing.Point(178, 132);
            this.textBoxEstimate.Name = "textBoxEstimate";
            this.textBoxEstimate.Size = new System.Drawing.Size(200, 20);
            this.textBoxEstimate.TabIndex = 9;
            // 
            // dateTimePickerDateCreated
            // 
            this.dateTimePickerDateCreated.Location = new System.Drawing.Point(178, 158);
            this.dateTimePickerDateCreated.Name = "dateTimePickerDateCreated";
            this.dateTimePickerDateCreated.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateCreated.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(62, 80);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(62, 106);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // labelEstimate
            // 
            this.labelEstimate.AutoSize = true;
            this.labelEstimate.Location = new System.Drawing.Point(62, 132);
            this.labelEstimate.Name = "labelEstimate";
            this.labelEstimate.Size = new System.Drawing.Size(47, 13);
            this.labelEstimate.TabIndex = 13;
            this.labelEstimate.Text = "Estimate";
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Location = new System.Drawing.Point(62, 158);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(70, 13);
            this.labelDateCreated.TabIndex = 14;
            this.labelDateCreated.Text = "Date Created";
            // 
            // labelDateModified
            // 
            this.labelDateModified.AutoSize = true;
            this.labelDateModified.Location = new System.Drawing.Point(62, 184);
            this.labelDateModified.Name = "labelDateModified";
            this.labelDateModified.Size = new System.Drawing.Size(73, 13);
            this.labelDateModified.TabIndex = 15;
            this.labelDateModified.Text = "Date Modified";
            // 
            // labelIssueStatus
            // 
            this.labelIssueStatus.AutoSize = true;
            this.labelIssueStatus.Location = new System.Drawing.Point(62, 210);
            this.labelIssueStatus.Name = "labelIssueStatus";
            this.labelIssueStatus.Size = new System.Drawing.Size(63, 13);
            this.labelIssueStatus.TabIndex = 16;
            this.labelIssueStatus.Text = "Issue status";
            // 
            // textBoxIssueStatus
            // 
            this.textBoxIssueStatus.Location = new System.Drawing.Point(178, 210);
            this.textBoxIssueStatus.Name = "textBoxIssueStatus";
            this.textBoxIssueStatus.Size = new System.Drawing.Size(200, 20);
            this.textBoxIssueStatus.TabIndex = 17;
            // 
            // FormAddEditIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 335);
            this.Controls.Add(this.textBoxIssueStatus);
            this.Controls.Add(this.labelIssueStatus);
            this.Controls.Add(this.labelDateModified);
            this.Controls.Add(this.labelDateCreated);
            this.Controls.Add(this.labelEstimate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dateTimePickerDateCreated);
            this.Controls.Add(this.textBoxEstimate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAssignedID);
            this.Controls.Add(this.labelAssignedID);
            this.Controls.Add(this.textBoxAuthorID);
            this.Controls.Add(this.labelAuthorID);
            this.Controls.Add(this.dateTimePickerDateModified);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormAddEditIssue";
            this.Text = "FormAddEditIssue";
            this.Load += new System.EventHandler(this.FormAddEditIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateModified;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.Label labelAssignedID;
        private System.Windows.Forms.TextBox textBoxAssignedID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxEstimate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreated;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEstimate;
        private System.Windows.Forms.Label labelDateCreated;
        private System.Windows.Forms.Label labelDateModified;
        private System.Windows.Forms.Label labelIssueStatus;
        private System.Windows.Forms.TextBox textBoxIssueStatus;
    }
}