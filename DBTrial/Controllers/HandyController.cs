using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBTrial.Controllers
{
    class HandyController
    {
        MyDBContext db = new MyDBContext();

        public IEnumerable sortColumns(MyDBContext db, int column)
        {
            var dt = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName
            }).ToList();
            if (column == 0)
            {
                var firstname = dt.OrderBy(x => x.firstName).ToList();
                return firstname;
            }
            else if (column == 1)
            {
                var surname = dt.OrderBy(x => x.surName).ToList();
                return surname;
            }
            else
            {
                return dt;
            }

        }

        public IEnumerable Search(string searchstring)
        {
            var dt = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName
            }).Where(x => x.firstName.Contains(searchstring) || x.surName.Contains(searchstring)).ToList();
            return dt;
        }

        public IEnumerable Search(string searchstring, List<EventAmountReduction> ear)
        {
            var eventmembers = ear.Select(x => x.thisMember).ToList().Select(x => new { x.firstName, x.surName }).ToList(); ;
            var dt = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName
            }).Where(x => x.firstName.Contains(searchstring) || x.surName.Contains(searchstring)).ToList().Except(eventmembers).ToList();
            return dt;
        }

        public DataTable Transpose(DataTable dt)
        {
            DataTable dtNew = new DataTable();

            //adding columns    
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                dtNew.Columns.Add(i.ToString());
            }


            //Adding Row Data
            for (int k = 1; k < dt.Columns.Count; k++)
            {
                DataRow r = dtNew.NewRow();
                r[0] = dt.Columns[k].ToString();
                for (int j = 1; j <= dt.Rows.Count; j++)
                    r[j] = dt.Rows[j - 1][k];
                dtNew.Rows.Add(r);
            }

            return dtNew;
        }

        public DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        public int FindMemberId(string firstName, string surName)
        {
            var id = db.bareMembers.Where(x => x.firstName.Equals(firstName) && x.surName.Equals(surName)).Select(x => x.Id).FirstOrDefault();
            return id;
        }

        public void DeleteMember(int id)
        {
            var removemember = db.bareMembers.Where(x => x.Id == id).FirstOrDefault();
            EventAmountReduction ear = db.eventAmountReductions.ToList().Find(x => x.thisMember.Id == id);
            db.bareMembers.Remove(removemember);
            db.SaveChanges();
        }

        public int FindEventId(string eventname)
        {
            var id = db.Events.Where(x => x.Name.Equals(eventname)).Select(x => x.Id).FirstOrDefault();
            return id;
        }

        public void DeleteEvent(int id)
        {
            var removeEvent = db.Events.Where(x => x.Id == id).FirstOrDefault();
            List<EventAmountReduction> eventears = db.eventAmountReductions.Include("thisMember").Include("thisEvent").ToList().Where(x => x.ThisEvent.Id == id).ToList();
            foreach (var ear in eventears)
            {
                db.eventAmountReductions.Remove(ear);

            }
            db.Events.Remove(removeEvent);
            db.SaveChanges();
        }

        public int FindIncassoId(int incassoNumber)
        {
            var id = db.Incassos.Where(x => x.Number.Equals(incassoNumber)).Select(x => x.Id).FirstOrDefault();
            return id;
        }

        public void DeleteIncasso(int id)
        {
            var removeIncasso = db.Incassos.Include("IncassoMembers").Where(x => x.Id == id).FirstOrDefault();
            List<IncassoMember> Im = removeIncasso.incassoMembers.ToList();
            foreach (var member in Im)
            {
                db.incassoMembers.Remove(member);

            }
            db.Incassos.Remove(removeIncasso);
            db.SaveChanges();
        }

        public EventAmountReduction AddMember(string amount, string reduction)
        {
            EventAmountReduction ear = new EventAmountReduction();
            if (int.TryParse(amount, out int num))
            {
                ear.Amount = num;
            }
            if (decimal.TryParse(reduction, out decimal num2))
            {

                ear.Reduction = num2;
            }
            return ear;
        }

        public void UpdateAmount()
        {
            
            foreach (var member in db.bareMembers.Include("Events"))
            {
                decimal amount = 0;
                if (member.Events.Count() != 0)
                {
                    amount = 0;
                    var ears = db.eventAmountReductions.Include("thisEvent").Include("thisMember").ToList().Where(x => x.thisMember.Id == member.Id).ToList();
                    

                    foreach (var ear in ears)
                    {
                        amount += ear.Amount * ear.ThisEvent.Cost - ear.Reduction;
                    }
                }
                member.nrEvents = member.Events.Count();
                member.Amount = amount;
                
            }
            db.SaveChanges();
        }
    }
}
