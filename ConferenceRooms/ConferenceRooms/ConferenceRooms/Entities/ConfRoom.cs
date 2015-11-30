using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceRooms.Entities
{
    public class ConfRoom
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public string Address { get; set; }
        public int Capacity { get; set; }

    }
}
