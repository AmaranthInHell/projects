using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem2B.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username  { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
