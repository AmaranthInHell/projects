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

namespace EventDrivenProgrammingSTD___KrasenIliev___57
{
    public partial class FormAddEditUser : Form
    {
        private User user;
        public FormAddEditUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} - EventDrivenProgrammingDataBase",
            user.ID > 0 ? "Edit User" : "Add User");
            textBoxUsername.Text = user.FirstName;
            textBoxPassword.Text = user.Password;
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.FirstName = textBoxFirstName.Text;
            user.LastName = textBoxLastName.Text;
        }
    }
}
