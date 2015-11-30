using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDrivenProgrammingSTD___KrasenIliev___57.Entities;
using EventDrivenProgrammingSTD___KrasenIliev___57.Repositories;
using System.Data.Entity;




namespace EventDrivenProgrammingSTD___KrasenIliev___57
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            BindControls();
        }
        private void BindControls()
        {
            UsersRepository usersRepository = new UsersRepository();
            bindingSourceUsers.Clear();
            bindingSourceUsers.DataSource = usersRepository.GetAll();
            dataGridViewUsers.DataSource = bindingSourceUsers;
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

        private void buttonCalls_Click(object sender, EventArgs e)
        {
            User user = (User)bindingSourceUsers.Current;
            FormCalls call = new FormCalls(user);
            call.Show();
        }

    }
}
