using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssueTrackingSystem2B.Services;

namespace IssueTrackingSystem2B
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonUsers_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.MdiParent = this;
            formUsers.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //if (!AuthenticationService.LoggedUser.IsAdministrator)
            //{
            //    toolStripButtonUsers.Visible = false;
            //}

        }

        private void toolStripButtonWorklogs_Click(object sender, EventArgs e)
        {
            FormWorklogs formWorklogs = new FormWorklogs();
            formWorklogs.MdiParent = this;
            formWorklogs.Show();
        }

        private void toolStripButtonIssues_Click(object sender, EventArgs e)
        {
            FormIssues formIssues = new FormIssues();
            formIssues.MdiParent = this;
            formIssues.Show();
        }
    }
}
