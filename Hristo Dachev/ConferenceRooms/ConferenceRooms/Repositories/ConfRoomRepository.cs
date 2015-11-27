using ConferenceRooms.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceRooms.Repositories
{
    class ConfRoomRepository
    {
        private Context context;
        public ConfRoomRepository()
        {
            context = new Context();
        }

        public List<ConfRoom> GetAll()
        {
            return context.ConferenceRooms.ToList();
        }
        public void Insert(ConfRoom newRoom)
        {
            context.ConferenceRooms.Add(newRoom);
            context.SaveChanges();
        }
        public void Update(ConfRoom newRoom)
        {
            context.Entry(newRoom).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(ConfRoom newRoom)
        {
            context.Entry(newRoom).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Save(ConfRoom newRoom)
        {
            if (newRoom.ID == 0)
            {
                Insert(newRoom);
            }
            else
            {
                Update(newRoom);
            }
        }
    }
}
