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
using System.Data.Entity;
using IssueTrackingSystem2B.Repositories;
using IssueTrackingSystem2B.Services;

namespace IssueTrackingSystem2B
{
    public partial class FormUsers : Form
    {
        private void FormUsers_Load(object sender, EventArgs e)
        {
            if (!AuthenticationService.LoggedUser.IsAdministrator)
            {
                toolStripButtonAdd.Enabled = false;
                toolStripButtonEdit.Enabled = false;
                toolStripButtonDelete.Enabled = false;
            }
        }
        public FormUsers()
        {
            InitializeComponent();
            BindControls();
        }
        private void AdjustControlsVisibilitty()
        {
            toolStripButtonEdit.Enabled = bindingSourceUsers.Current != null;
            toolStripButtonDelete.Enabled = bindingSourceUsers.Current != null;
        }

        private void BindControls()
        {
            UsersRepository usersRepository = new UsersRepository();
                bindingSourceUsers.Clear();
                bindingSourceUsers.DataSource = usersRepository.GetAll();
                dataGridViewUsers.DataSource = bindingSourceUsers;

                AdjustControlsVisibilitty();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            FormAddEditUser formAddUser = new FormAddEditUser(user);

            if (formAddUser.ShowDialog() == DialogResult.OK)
            {
                UsersRepository usersRepository = new UsersRepository();
                usersRepository.Save(user);

                BindControls();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {

            User user = (User)bindingSourceUsers.Current;
            FormAddEditUser formAddUser = new FormAddEditUser(user);

            if (formAddUser.ShowDialog() == DialogResult.OK)
            {
                UsersRepository usersRepository = new UsersRepository();
                usersRepository.Save(user);

                BindControls();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            User user = (User)bindingSourceUsers.Current;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", 
                "Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                UsersRepository usersRepository = new UsersRepository();
                usersRepository.Delete(user);
                BindControls();
            }
        }

        
    }
}
