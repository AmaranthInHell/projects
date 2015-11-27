using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem2B.Entities;

namespace IssueTrackingSystem2B
{
    public partial class FormAddEditIssue : Form
    {
        private Issue issue;
        public FormAddEditIssue(Issue issue)
        {
            InitializeComponent();
            this.issue = issue;
        }

        private void FormAddEditIssue_Load(object sender, EventArgs e)
        {
            
            this.Text = string.Format("{0} - Issue tracking System",
            issue.ID > 0 ? "Edit Issue" : "Add Issue");
            textBoxAuthorID.Text = issue.AuthorID.ToString();
            textBoxAssignedID.Text = issue.AssignedID.ToString();
            textBoxTitle.Text = issue.Title;
            textBoxDescription.Text = issue.Description;
            textBoxEstimate.Text = issue.Estimate.ToString();
            dateTimePickerDateCreated.MaxDate = issue.DateCreated;
            dateTimePickerDateModified.MaxDate = issue.DateModified;
            
            
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Issue.Issuestatus issueStatus = Issue.Issuestatus.Done;
            issue.AuthorID = int.Parse(textBoxAuthorID.Text);
            issue.AssignedID = int.Parse(textBoxAssignedID.Text);
            issue.Title = textBoxTitle.Text;
            issue.Description = textBoxDescription.Text;
            issue.Estimate = float.Parse(textBoxEstimate.Text);
            issue.DateCreated = dateTimePickerDateCreated.Value.Date;
            issue.DateModified = dateTimePickerDateModified.Value.Date;
            if (textBoxIssueStatus.Text == "Done")
            {
                issueStatus = Issue.Issuestatus.Done;  
            }
            else if (textBoxIssueStatus.Text == "Pending")
            {
                issueStatus = Issue.Issuestatus.Pending;
            }
          
        
        }
    }
}
