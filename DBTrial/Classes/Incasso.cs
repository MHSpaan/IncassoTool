using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBTrial
{
    public class Incasso
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<IncassoMember> incassoMembers { get; set; }
        public DateTime IncassoDate { get; set; }

        public Incasso()
        {

        }
        public Incasso(string IncassoNumber, DateTime incassoDate) :this()
        {
            incassoMembers = new List<IncassoMember>();
            this.Number = int.Parse(IncassoNumber);
            this.IncassoDate = incassoDate;
        }
    }
}