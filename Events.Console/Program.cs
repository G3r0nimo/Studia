using Events.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventRepository eRepo = new MemoryEventRepository();
            eRepo.Add(new Dal.Model.Event { Id=1, Title="ITAD",
                Location ="ATH",
                EventType =Dal.Model.eEventType.eConference,
                When = DateTime.Now,
                Paid=false
            });

            eRepo.Add(new Dal.Model.Event
            {
                Id = 2,
                Title = "DWO",
                Location = "ATH",
                EventType = Dal.Model.eEventType.eConference,
                When=DateTime.Now,
                Paid=false
                
            });

            foreach (var item in eRepo.GetAll())
            {
                System.Console.WriteLine("Id: {0} , Title: {1}, Location: {2}, EventType: {3}, Date: {4} , Paid: {5}", 
                    item.Id, item.Title, item.Location, item.EventType, item.When, item.Paid);
            }

            



            //app konsolowa dla banku
            //wyswietl, dodaj, edit, del
            //kolorowa :D
            //implementacja zapis do bazy entityframework


        }
    }
}
