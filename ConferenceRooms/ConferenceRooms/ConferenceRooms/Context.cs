using ConferenceRooms.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceRooms
{
    class Context : DbContext
    {
        public Context()
            : base("ConferenceRooms")
        { }
        public DbSet<ConfRoom> ConferenceRooms {get; set;}
        public DbSet<ConfEvent> ConferenceEvents { get; set; }

    }
}
