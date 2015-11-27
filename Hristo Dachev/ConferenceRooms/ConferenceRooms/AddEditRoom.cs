using ConferenceRooms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceRooms
{
    public partial class AddEditRoom : Form
    {
        private ConfRoom room;
        public AddEditRoom(ConfRoom room)
        {
            InitializeComponent();
            this.room = room;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            room.Name = txtName.Text;
            room.Address = txtAddress.Text;
            room.Capacity = Int32.Parse(txtCapacity.Text);
        }

        private void AddEditRoom_Load(object sender, EventArgs e)
        {
            txtName.Text = room.Name;
            txtAddress.Text = room.Address;
            txtCapacity.Text = room.Capacity.ToString();
        }
    }
}
