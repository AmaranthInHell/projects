using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProgrammingSTD___KrasenIliev___57.Entities
{
    public class Call
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Number { get; set; }
        public bool InRoaming { get; set; }
        public string RoamingZone { get; set; }
        public double Duration { get; set; }
        public DateTime Date { get; set; }

    }
}
