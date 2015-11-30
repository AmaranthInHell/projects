using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDrivenProgrammingSTD___KrasenIliev___57.Entities;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data;

namespace EventDrivenProgrammingSTD___KrasenIliev___57.Repositories
{
    public class UsersRepository
    {
        private EventDrivenProgrammingSTD___KrasenIliev___57.Context dataBase;
        public UsersRepository()
        {
            dataBase = new EventDrivenProgrammingSTD___KrasenIliev___57.Context();
        }
        public User GetByID(int id)
        {
            return dataBase.Users.Find(id);
        }
        public List<User> GetAll()
        {
            return dataBase.Users.ToList();
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
    

    
    }
}
