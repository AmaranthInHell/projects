using ConferenceRooms.Repositories;
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
    
    public partial class EventsView : Form
    {
        private ConfRoom room;
        public EventsView(ConfRoom room)
        {
            InitializeComponent();
            this.room = room;
        }
        private void RefreshList()
        {
            ConfEventRepository eventRepo = new ConfEventRepository();
            bsEvents.DataSource = eventRepo.GetAllByRoom(room.ID);
            eventList.DataSource = bsEvents;
        }
        private void EventsView_Load(object sender, EventArgs e)
        {
            ConfEventRepository repo = new ConfEventRepository();
            bsEvents.DataSource = repo.GetAllByRoom(room.ID);
            eventList.DataSource = bsEvents;
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            ConfEvent newEvent = new ConfEvent();
            AddEditEvent eventForm = new AddEditEvent(newEvent, room);
            if (eventForm.ShowDialog() == DialogResult.OK)
            {
                if (newEvent.Attendees > room.Capacity)
                {
                    MessageBox.Show("Attendees more than Room Capacity, you know! Can't add this!");
                }else{
                ConfEventRepository repo = new ConfEventRepository();
                repo.Save(newEvent);
                RefreshList();
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ConfEvent newEvent = (ConfEvent)bsEvents.Current;
            AddEditEvent eventForm = new AddEditEvent(newEvent, room);
            if (eventForm.ShowDialog() == DialogResult.OK)
            {
                if (newEvent.Attendees > room.Capacity)
                {
                    MessageBox.Show("Attendees more than Room Capacity, you know! Can't add this!");
                }
                else
                {
                    ConfEventRepository repo = new ConfEventRepository();
                    repo.Save(newEvent);
                    RefreshList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConfEvent thisEvent = (ConfEvent)bsEvents.Current;
            DialogResult result = MessageBox.Show("Really master?", " ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ConfEventRepository repo = new ConfEventRepository();
                repo.Delete(thisEvent);
                RefreshList();
            }
        }
    }
}
