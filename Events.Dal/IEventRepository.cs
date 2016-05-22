using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal
{
    public interface IEventRepository
    {
        void Add(Event e);
        void Update(Event e);
        void Delete(int Id);
        Event GetById (int Id);
        IQueryable<Event> GetAll();
    }
}
