using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBTrial
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EventAmountReduction> eventAmounts { get; set; }
        public decimal Cost { get; set; }
        
        public Event()
        {
            eventAmounts = new List<EventAmountReduction>();
        }
    }
}