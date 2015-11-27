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
    public class WorklogsRepository
    {
        private IssueTrackingSystemContext dataBase;
        public WorklogsRepository()
        {
            dataBase = new IssueTrackingSystemContext();
        }
        public Worklog GetByID(int id)
        {
            return dataBase.Worklogs.Find(id);
        }
        public List<Worklog> GetAll()
        {
            return dataBase.Worklogs.ToList();
        }
        public List<Worklog> GetAll(Expression<Func<Worklog, bool>> filter)
        {
            return dataBase.Worklogs.Where(filter).ToList();
        }
        private void Insert(Worklog worklog)
        {
            dataBase.Worklogs.Add(worklog);
            dataBase.SaveChanges();
        }
        private void Update(Worklog worklog)
        {
            dataBase.Entry(worklog).State = EntityState.Modified;
            dataBase.SaveChanges();
        }
        public void Save(Worklog worklog)
        {
            if (worklog.ID == 0)
            {
                Insert(worklog);
            }
            else
            {
                Update(worklog);
            }
        }
        public void Delete(Worklog worklog)
        {
            dataBase.Entry(worklog).State = EntityState.Deleted;
            dataBase.SaveChanges();
        }

    }
}
