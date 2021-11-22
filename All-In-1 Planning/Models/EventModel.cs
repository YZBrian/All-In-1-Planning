using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_In_1_Planning.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public EventModel(int id, DateTime dateTime, string description)
        {
            Id = id;
            DateTime = dateTime;
            Description = description;
        }
    }
}
