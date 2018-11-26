using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBTrial
{
    public class OldDonor
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string preFix { get; set; }
        public string surName { get; set; }
        public string Initials { get; set; }
        public DateTime leaveDate { get; set; }

        public string fullName
        {
            get { return $"{firstName} {preFix} {surName}"; }
        }
    }
}