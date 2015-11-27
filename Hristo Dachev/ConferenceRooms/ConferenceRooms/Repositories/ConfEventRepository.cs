using ConferenceRooms.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceRooms.Repositories
{
    class ConfEventRepository
    {
        private Context context;
        public ConfEventRepository()
        {
            context = new Context();
        }

        public List<ConfEvent> GetAll()
        {
            return context.ConferenceEvents.ToList();
        }
        public void Insert(ConfEvent newEvent)
        {
            context.ConferenceEvents.Add(newEvent);
            context.SaveChanges();
        }
        public void Update(ConfEvent newEvent)
        {
            context.Entry(newEvent).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(ConfEvent newEvent)
        {
            context.Entry(newEvent).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Save(ConfEvent newEvent)
        {
            if (newEvent.ID == 0)
            {
                Insert(newEvent);
            }
            else
            {
                Update(newEvent);
            }
        }

        public List<ConfEvent> GetAllByRoom(int roomID)
        {
            return context.ConferenceEvents.Where(p => p.RoomID == roomID).ToList();
        }
    }
}
