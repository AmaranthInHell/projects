using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackingSystem2B.Entities
{
   public class Comment
    {
        public int ID { get; set; }
        public int IssueId { get; set; }
        public int UserID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
    }
}
