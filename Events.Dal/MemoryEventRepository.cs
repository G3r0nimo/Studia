using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Dal.Model;

namespace Events.Dal
{
    public class MemoryEventRepository : IEventRepository 
    {
        private List<Event> _events;
        public MemoryEventRepository()
        {
            _events = new List<Event>
            {
                new Event {Id=1, Title="IDAD", Location="ATH", When=DateTime.Now },
                new Event {Id=2, Title="DWO", Location="ATH", When=DateTime.Now },
                new Event {Id=3, Title="Zajecia", Location="ATH", When=DateTime.Now }
            };
        }

        public void Add(Event e)
        {
            _events.Add(e);

        }

        public void Delete(int Id)
        {
            var eToDelete = _events.Find(n => n.Id == Id);
            _events.Remove(eToDelete);
        }

        public IQueryable<Event> GetAll()
        {
            return _events.AsQueryable();
        }

        public Event GetById(int Id)
        {
           return  _events.Find(n=>n.Id== Id);
        }

        public void Update(Model.Event e)
        {
           var eToUpdate= _events.Find(n=>n.Id ==e.Id);
            eToUpdate.Title = e.Title;
            eToUpdate.Location = e.Location;
            eToUpdate.When = e.When;
            eToUpdate.EventType = e.EventType;
        }
    }
}
