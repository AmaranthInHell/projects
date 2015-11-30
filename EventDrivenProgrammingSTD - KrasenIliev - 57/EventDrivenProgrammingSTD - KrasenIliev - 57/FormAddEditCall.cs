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
    public partial class FormAddEditCall : Form
    {
        private Call call;
        private User user;
        public FormAddEditCall(Call call, User user)
        {
            InitializeComponent();
            this.call = call;
            this.user = user;
        }

        private void FormAddEditCall_Load(object sender, EventArgs e)
        {
            textBoxNumber.Text = call.Number.ToString();
            checkBoxInRoaming.Checked = call.InRoaming;
            textBoxRoamingZone.Text = call.RoamingZone;
            textBoxDuration.Text = call.Duration.ToString();
            dateTimePickerDate.Value = call.Date;
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            call.UserID = user.ID;
            call.Number = int.Parse(textBoxNumber.Text);
            call.InRoaming = checkBoxInRoaming.Checked;
            call.RoamingZone = textBoxRoamingZone.Text;
            call.Duration = double.Parse(textBoxDuration.Text);
            call.Date = dateTimePickerDate.Value;
        }


    }
}
