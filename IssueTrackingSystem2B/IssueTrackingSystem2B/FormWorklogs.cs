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
    public partial class FormWorklogs : Form
    {
        public FormWorklogs()
        {
            InitializeComponent();
            BindControls();
        }
        private void AdjustControlsVisibilitty()
        {
            toolStripButtonEdit.Enabled = bindingSourceWorklogs.Current != null;
            toolStripButtonDelete.Enabled = bindingSourceWorklogs.Current != null;
        }
        private void BindControls()
        {
            WorklogsRepository worklogsRepository = new WorklogsRepository();
            bindingSourceWorklogs.Clear();
            bindingSourceWorklogs.DataSource = worklogsRepository.GetAll();
            dataGridViewWorklogs.DataSource = bindingSourceWorklogs;

            
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Worklog worklog = new Worklog();
            FormAddEditWorklogs formAddWorklog = new FormAddEditWorklogs(worklog);

            if (formAddWorklog.ShowDialog() == DialogResult.OK)
            {
                WorklogsRepository worklogsRepository = new WorklogsRepository();
                worklogsRepository.Save(worklog);

                BindControls();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Worklog worklog = (Worklog)bindingSourceWorklogs.Current;
            FormAddEditWorklogs formAddWorklog = new FormAddEditWorklogs(worklog);

            if (formAddWorklog.ShowDialog() == DialogResult.OK)
            {
                WorklogsRepository worklogsRepository = new WorklogsRepository();
                worklogsRepository.Save(worklog);

                BindControls();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Worklog worklog = (Worklog)bindingSourceWorklogs.Current;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                WorklogsRepository worklogsRepository = new WorklogsRepository();
                worklogsRepository.Delete(worklog);
                BindControls();
            }
        }
    }
}
