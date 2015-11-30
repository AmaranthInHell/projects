using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDrivenProgrammingSTD___KrasenIliev___57.Repositories;
using EventDrivenProgrammingSTD___KrasenIliev___57.Entities;

namespace EventDrivenProgrammingSTD___KrasenIliev___57
{
    public partial class FormCalls : Form
    {
        private User user;
        public FormCalls(User user)
        {
            InitializeComponent();
            this.user = user;
            BindControls();
        }
        private void BindControls()
        {
            CallsRepository callsRepository = new CallsRepository();
            bindingSourceCalls.Clear();
            bindingSourceCalls.DataSource = callsRepository.GetAllCalls(user.ID);
            dataGridViewCalls.DataSource = bindingSourceCalls;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Call call = new Call();
            FormAddEditCall formAddCall = new FormAddEditCall(call, user);
            if (formAddCall.ShowDialog() == DialogResult.OK)
            {
                
                    CallsRepository callsRepository = new CallsRepository();
                    callsRepository.Save(call);
                    BindControls(); 
                
            }

        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            Call call = (Call)bindingSourceCalls.Current;
            FormAddEditCall editCallForm = new FormAddEditCall(call, user);
            if (editCallForm.ShowDialog() == DialogResult.OK)
            {

                CallsRepository callsRepository = new CallsRepository();
                callsRepository.Save(call);
                BindControls();

            }

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            Call call = (Call)bindingSourceCalls.Current;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this number?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                CallsRepository callsRepository = new CallsRepository();
                callsRepository.Delete(call);
                BindControls();
            }
        }
    }
}
