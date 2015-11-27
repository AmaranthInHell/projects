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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
             
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AuthenticationService.AuthenticateUser(textBoxUsername.Text, textBoxPassword.Text);

            if (AuthenticationService.LoggedUser != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Log In Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
