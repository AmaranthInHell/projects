
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDrivenProgrammingSTD___KrasenIliev___57.Entities;

namespace EventDrivenProgrammingSTD___KrasenIliev___57
{
   
        class Context : DbContext
        {
            public Context()
                : base("EventDrivenProgrammingSTD___KrasenIliev___57")
            { }
            public DbSet<User> Users { get; set; }
            public DbSet<Call> Calls { get; set; }

        }
    
}
