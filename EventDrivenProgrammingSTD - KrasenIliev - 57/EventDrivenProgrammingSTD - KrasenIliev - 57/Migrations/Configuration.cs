using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace EventDrivenProgrammingSTD___KrasenIliev___57.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EventDrivenProgrammingSTD___KrasenIliev___57.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(EventDrivenProgrammingSTD___KrasenIliev___57.Context context)
        {
        }
    }
}
