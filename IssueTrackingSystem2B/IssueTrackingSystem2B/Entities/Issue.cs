using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem2B.Entities
{
   public class Issue
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public int AssignedID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Estimate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public enum Issuestatus
        {
            Pending,
            Done
        }
    }
}
