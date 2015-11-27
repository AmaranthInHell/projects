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
    public partial class FormAddEditWorklogs : Form
    {
        private Worklog worklog;
        public FormAddEditWorklogs(Worklog worklog)
        {
            InitializeComponent();
            this.worklog = worklog;
        }
    }
}
