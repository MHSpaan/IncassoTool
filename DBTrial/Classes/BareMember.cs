using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBTrial
{
    public enum GenderEnum
    {
        M,
        F
    }
    public class BareMember
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string preFix { get; set; }
        public string surName { get; set; }
        public string Initials { get; set; }
        public GenderEnum Gender { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string phoneNumber { get; set; }
        public string mobilePhoneNumber { get; set; }
        public string emailAddress { get; set; }
        [DataType(DataType.Date)]
        public DateTime? dateOfBirth { get; set; }
        public string studentNumber { get; set; }
        public string accountNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime? joinDate { get; set; }
        public List<EventAmountReduction> Events { get; set; }
        public int nrEvents { get; set; }
        public decimal Amount { get; set; }
        public string fullName
        {
            get { return $"{firstName} {preFix} {surName}"; }
        }

        public BareMember()
        {
            Events = new List<EventAmountReduction>();
        }

    }
}