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
    public partial class AddEditEvent : Form
    {
        private ConfEvent myEvent;
        private ConfRoom room;
        public AddEditEvent(ConfEvent myEvent, ConfRoom room)
        {
            InitializeComponent();
            this.myEvent = myEvent;
            this.room = room;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            myEvent.RoomID = room.ID;
            myEvent.Name = txtTitle.Text;
            myEvent.StartDate = dateStartEvent.Value;
            myEvent.EndDate = dateEndEvent.Value;
            myEvent.Attendees = Int32.Parse(txtAttandees.Text);

        }

        private void AddEditRoom_Load(object sender, EventArgs e)
        {
            txtTitle.Text = myEvent.Name;
            dateStartEvent.Value = myEvent.StartDate;
            dateEndEvent.Value = myEvent.EndDate;
            txtAttandees.Text = myEvent.Attendees.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
