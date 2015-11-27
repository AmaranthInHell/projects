using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem2B.Entities;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;


namespace IssueTrackingSystem2B.Repositories
{
    public class IssuesRepository
    {
      private IssueTrackingSystemContext dataBase;
        public IssuesRepository()
        {
            dataBase = new IssueTrackingSystemContext();
        }
        public Issue GetByID(int id)
        {
            return dataBase.Issues.Find(id);
        }
        public List<Issue> GetAll()
        {
            return dataBase.Issues.ToList();
        }
        public List<Issue> GetAll(Expression<Func<Issue, bool>> filter)
        {
            return dataBase.Issues.Where(filter).ToList();
        }
        private void Insert(Issue issue)
        {
            dataBase.Issues.Add(issue);
            dataBase.SaveChanges();
        }
        private void Update(Issue issue)
        {
            dataBase.Entry(issue).State = EntityState.Modified;
            dataBase.SaveChanges();
        }
        public void Save(Issue issue)
        {
            if (issue.ID == 0)
            {
                Insert(issue);
            }
            else
            {
                Update(issue);
            }
        }
        public void Delete(Issue issue)
        {
            dataBase.Entry(issue).State = EntityState.Deleted;
            dataBase.SaveChanges();
        }
        //public User GetByUsernameAndPassword(string username, string password)
        //{
        //    return dataBase.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        //}
    }
}
