using System;
using ConferenceRooms.Repositories;
using ConferenceRooms.Entities;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            ConfRoomRepository roomRepo = new ConfRoomRepository();
            bsRooms.DataSource = roomRepo.GetAll();
            confList.DataSource = bsRooms;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfRoomRepository roomRepo = new ConfRoomRepository();
            bsRooms.DataSource = roomRepo.GetAll();
            confList.DataSource = bsRooms;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ConfRoom newRoom = new ConfRoom();
            AddEditRoom roomForm = new AddEditRoom(newRoom);
            if (roomForm.ShowDialog() == DialogResult.OK)
            {
                ConfRoomRepository repo = new ConfRoomRepository();
                repo.Save(newRoom);
                RefreshList();
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            ConfRoom room = (ConfRoom)bsRooms.Current;
            AddEditRoom roomForm = new AddEditRoom(room);

            if (roomForm.ShowDialog() == DialogResult.OK)
            {
                ConfRoomRepository repo = new ConfRoomRepository();
                repo.Save(room);
                RefreshList();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            ConfRoom room= (ConfRoom)bsRooms.Current;
            DialogResult result = MessageBox.Show("Really master?", " ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ConfRoomRepository repo = new ConfRoomRepository();
                repo.Delete(room);
                RefreshList();
            }
        }

        private void btnListEvents_Click(object sender, EventArgs e)
        {
            ConfRoom room = (ConfRoom)bsRooms.Current;
            EventsView myEvents = new EventsView(room);
            myEvents.Show();
        }
    }
}
