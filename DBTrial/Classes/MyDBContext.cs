using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBTrial
{
    public class MyDBContext:DbContext
    {
        public DbSet<BareMember> bareMembers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Incasso> Incassos { get; set; }
        public DbSet<IncassoMember> incassoMembers { get; set; }
        public DbSet<OldDonor> oldDonors { get; set; }
        public DbSet<OldMember> oldMembers { get; set; }
        public DbSet<EventAmountReduction> eventAmountReductions { get; set; }
    }

}
