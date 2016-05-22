using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Model
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Projects { get; set; }
      
        public EventContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EventContext>());
        }
    }
}
