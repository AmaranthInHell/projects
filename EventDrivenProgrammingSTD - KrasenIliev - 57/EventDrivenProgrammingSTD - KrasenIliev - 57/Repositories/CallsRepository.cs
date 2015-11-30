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
    public class CallsRepository
    {
        private EventDrivenProgrammingSTD___KrasenIliev___57.Context dataBase;
        public CallsRepository()
        {
            dataBase = new EventDrivenProgrammingSTD___KrasenIliev___57.Context();
        }
        
        public List<Call> GetAll()
        {
            return dataBase.Calls.ToList();
        }
       
        private void Insert(Call call)
        {
            dataBase.Calls.Add(call);
            dataBase.SaveChanges();
        }
        private void Update(Call call)
        {
            dataBase.Entry(call).State = EntityState.Modified;
            dataBase.SaveChanges();
        }
        public void Save(Call call)
        {
            if (call.ID == 0)
            {
                Insert(call);
            }
            else
            {
                Update(call);
            }
        }
        public void Delete(Call call)
        {
            dataBase.Entry(call).State = EntityState.Deleted;
            dataBase.SaveChanges();
        }
        public List<Call> GetAllCalls(int userID)
        {
            return dataBase.Calls.Where(c => c.UserID == userID).ToList();
        }
    }
}
