using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem2B.Entities
{
   public class Worklog
    {
       public int ID { get; set; }
       public int UserId { get; set; }
       public int IssueId { get; set; }
       public double LoggedHours { get; set; }
       public DateTime DateLogged { get; set; }
    }
}
