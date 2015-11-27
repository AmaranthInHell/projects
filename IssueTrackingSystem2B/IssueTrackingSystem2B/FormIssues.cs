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
using IssueTrackingSystem2B.Repositories;
using IssueTrackingSystem2B.Services;
using System.Data.Entity;

namespace IssueTrackingSystem2B
{
    public partial class FormIssues : Form
    {
        public FormIssues()
        {
            InitializeComponent();
            BindControls();
        }
        private void AdjustControlsVisibilitty()
        {
            toolStripButtonEdit.Enabled = bindingSourceIssues.Current != null;
            toolStripButtonDelete.Enabled = bindingSourceIssues.Current != null;
        }
        private void BindControls()
        {
            IssuesRepository issuesRepository = new IssuesRepository();
            bindingSourceIssues.Clear();
            bindingSourceIssues.DataSource = issuesRepository.GetAll();
            dataGridViewIssues.DataSource = bindingSourceIssues;

            AdjustControlsVisibilitty();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            FormAddEditIssue formAddIssue = new FormAddEditIssue(issue);
            if (formAddIssue.ShowDialog() == DialogResult.OK)
            {
                IssuesRepository issuesRepository = new IssuesRepository();
                issuesRepository.Save(issue);
                BindControls();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Issue issue = (Issue)bindingSourceIssues.Current;
            FormAddEditIssue formAddIssue = new FormAddEditIssue(issue);
            if (formAddIssue.ShowDialog() == DialogResult.OK)
            {
                IssuesRepository issuesRepository = new IssuesRepository();
                issuesRepository.Save(issue);
                BindControls();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Issue issue = (Issue)bindingSourceIssues.Current;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this issue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                IssuesRepository issuesRepository = new IssuesRepository();
                issuesRepository.Delete(issue);
                BindControls();
            }
        }
    }
}
