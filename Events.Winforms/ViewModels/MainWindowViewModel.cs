﻿using Events.Dal;
using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Winforms.ViewModels
{
    public class MainWindowViewModel
    {
        public Dictionary<eEventType, string > EventTypeLabels
        {
            get
            {
                return new Dictionary<eEventType, string>
                {
                    {eEventType.eConference, "Konferencja" },
                    {eEventType.eMeeting, "Spotkanie" },
                };
            }
        }
        public List<EventRowViewModel> Events
        {
            get
            {
                return _eventsRepository.GetAll().Select(n =>
                new EventRowViewModel
                {
                    Id = n.Id,
                    Title = n.Title,
                    Location = n.Location,
                    When = n.When,
                    EventType=n.EventType.ToString()
                }).ToList();
            }
        }

        private IEventRepository _eventsRepository;
       

        public MainWindowViewModel()
        {
            _eventsRepository = new MemoryEventRepository();
        }
    }
}
