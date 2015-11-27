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
    public partial class FormAddEditUser : Form
    {
        private User user;
        public FormAddEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.FirstName = textBoxFirstName.Text;
            user.LastName = textBoxLastName.Text;
            user.IsAdministrator = checkBoxAdministrator.Checked;
        }

        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} - Issue tracking System" ,
            user.ID>0 ? "Edit User" : "Add User");
            textBoxUsername.Text = user.FirstName;
            textBoxPassword.Text = user.Password;
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
            checkBoxAdministrator.Checked = user.IsAdministrator;
        }
    }
}
