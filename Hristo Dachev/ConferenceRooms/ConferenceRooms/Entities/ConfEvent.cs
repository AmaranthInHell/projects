using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceRooms.Entities
{
    public class ConfEvent
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate { get; set; }
        public int Attendees { get; set; }
    }
}
