using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_In_1_Planning.Models
{
    public class EventListModel
    {
        public List<EventModel> Events { get; set; }

        public EventListModel(List<EventModel> events)
        {
            Events = events;
        }
    }
}
