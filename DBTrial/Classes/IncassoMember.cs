using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBTrial
{
    
    public class IncassoMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Land { get; set; }
        public string Rekeningnummer { get; set; }
        public DateTime? Inschrijfdatum { get; set; }
        public string Kenmerk { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime? Incassodatum { get; set; }
        public string Incassosoort { get; set; }
        public string Omschrijving { get; set; }
        public Incasso incasso { get; set; }
        
        public IncassoMember()
        {
            this.Incassosoort = "Terugkerend";
        }

        public IncassoMember(BareMember member, string IncassoNumber, DateTime IncassoDate) : this()
        {
            this.Name = member.Initials.Trim() + " " + member.surName.Trim();
            this.Adres = member.Address;
            this.Postcode = member.Postcode;
            this.Plaats = member.City;
            this.Land = "Nederland";
            this.Rekeningnummer = member.accountNumber.Trim();
            this.Inschrijfdatum = member.joinDate;
            if (member.studentNumber.ToString() !="")
            {
                var first = member.studentNumber.First();
            switch (first)
                {
                    case 'R':
                        this.Kenmerk = member.studentNumber.Remove(0, 3).Trim();
                        break;
                    case 'H':
                        var x = member.studentNumber;
                        var y = x.Remove(0, 2);
                        var z = y.Trim();
                        this.Kenmerk = z;
                        break;
                    case 'G':
                        this.Kenmerk = member.studentNumber.Remove(0, 1).Trim();
                        break;
                    default:
                        this.Kenmerk = member.studentNumber.Trim();
                        break;
                }
            }
            this.Omschrijving = $"Incasso/collection {IncassoNumber} 2018-2019";
            this.Incassodatum = IncassoDate;
        }

        MyDBContext db = new MyDBContext();

        public void AddEventAmounts(int id)
        {
            List<EventAmountReduction> ear = db.eventAmountReductions.Include("thisMember").Include( "thisEvent").Where(x => x.thisMember.Id == id).ToList();
            foreach (var Event in ear)
            {
                this.Bedrag += Event.Amount*Event.ThisEvent.Cost - Event.Reduction;
            }
        }

    }
}