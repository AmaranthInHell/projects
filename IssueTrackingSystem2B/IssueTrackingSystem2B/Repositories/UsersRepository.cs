using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem2B.Entities;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;


namespace IssueTrackingSystem2B.Repositories
{
    public class UsersRepository
    {
        private IssueTrackingSystemContext dataBase;
            public UsersRepository()
            {
                dataBase = new IssueTrackingSystemContext();
            }
        public User GetByID(int id)
        {
            return dataBase.Users.Find(id);
        }
        public List<User> GetAll()
        {
            return dataBase.Users.ToList();
        }
        public List<User> GetAll(Expression<Func<User, bool>> filter)
        {
            return dataBase.Users.Where(filter).ToList();
        }
        private void Insert(User user)
        {
            dataBase.Users.Add(user);
            dataBase.SaveChanges();
        }
        private void Update(User user)
        {
            dataBase.Entry(user).State = EntityState.Modified;
            dataBase.SaveChanges();
        }
        public void Save(User user)
        {
            if (user.ID == 0)
            {
                Insert(user);
            }
            else
            {
                Update(user);
            }
        }
        public void Delete(User user)
        {
            dataBase.Entry(user).State = EntityState.Deleted;
            dataBase.SaveChanges();
        }
        public User GetByUsernameAndPassword(string username, string password)
        {
            return dataBase.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

    }
}
