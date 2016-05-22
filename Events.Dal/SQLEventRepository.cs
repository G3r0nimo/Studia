using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Dal.Model;
using System.Data.Entity;

namespace Events.Dal
{

    class SQLEventRepository : IEventRepository
    {



        public static string ConnectionString
        {
            get
            {
                return @"Data Source=(LocalDB)\v12.0;AttachDbFilename=|DataDirectory|App_Data\Events.mdf;Integrated Security=True";
            }
        }
        public List<Event> _events;




        public void Add(Event e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Event> GetAll()
        {
            throw new NotImplementedException();
        }

        public Event GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Event e)
        {
            throw new NotImplementedException();
        }
    }
}

