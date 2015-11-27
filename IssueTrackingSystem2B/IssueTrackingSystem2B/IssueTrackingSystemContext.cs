using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IssueTrackingSystem2B.Entities;

namespace IssueTrackingSystem2B
{
    public class IssueTrackingSystemContext : DbContext
    {
        public IssueTrackingSystemContext() : base("IssueTrackingSystem2B")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Worklog> Worklogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
