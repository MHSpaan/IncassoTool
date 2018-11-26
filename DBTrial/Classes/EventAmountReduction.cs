using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTrial
{
    public class EventAmountReduction
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public decimal Reduction { get; set; }
        public BareMember thisMember { get; set; }
        public Event ThisEvent { get; set; }
    }

}
