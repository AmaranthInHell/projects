using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.People
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, string department) : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
