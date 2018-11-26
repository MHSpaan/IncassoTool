using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DBTrial.Controllers
{
    public class IncassoMembersController
    {
        private MyDBContext db = new MyDBContext();



        public void Convert(string IncassoNumber, DateTime incassoDate)
        {
            var members = db.bareMembers.Include("Events").ToList();
            List<Incasso> currentincassos = new List<Incasso>();
            currentincassos = db.Incassos.Include("incassoMembers").ToList();
            Incasso incasso = new Incasso(IncassoNumber, incassoDate);
            foreach (var member in members.Where(m => m.Events.Count() > 0))
            {
                IncassoMember im = new IncassoMember(member, IncassoNumber, incassoDate);
                db.incassoMembers.Add(im);
                im.AddEventAmounts(member.Id);
                incasso.incassoMembers.Add(im);
            }

            db.SaveChanges();

            if (currentincassos.Exists(ci => ci.Number.ToString() == IncassoNumber))
            {
                var existingincasso = currentincassos.Find(ci => ci.Number.ToString() == IncassoNumber);
                existingincasso.incassoMembers.Clear();
                db.Incassos.Remove(existingincasso);
                db.SaveChanges();
            }
            db.Incassos.Add(incasso);
            db.SaveChanges();
        }


        public void ConvertToExcel(int incassoid)
        {
            Incasso incasso = db.Incassos.Where(i => i.Id == incassoid).Include("IncassoMembers").FirstOrDefault();
            var direct = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
            var filepath = direct + "\\Incassos";
            Directory.CreateDirectory(direct  + "\\Incassos");
            string _Path = filepath + "\\Incasso"+incasso.Number+".csv";
            if(!File.Exists(_Path))
            {
                using (File.Create(_Path))
                {

                }
            }
            using (StreamWriter sw = new StreamWriter(_Path))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Naam Tegenrekening").Append("\t");
                sb.Append("Straat Tegenrekening").Append("\t");
                sb.Append("Postcode Tegenrekening").Append("\t");
                sb.Append("Woonplaats Tegenrekening").Append("\t");
                sb.Append("Land Tegenrekening").Append("\t");
                sb.Append("IBAN Tegenrekening").Append("\t");
                sb.Append("Ondertekeningsdatum Mandaat").Append("\t");
                sb.Append("Mandaat Id").Append("\t");
                sb.Append("Bedrag").Append("\t");
                sb.Append("Incassodatum").Append("\t");
                sb.Append("Soort Incasso").Append("\t");
                sb.Append("Omschrijving").Append("\t");
                sw.WriteLine(sb);
                foreach (var incassomember in incasso.incassoMembers)
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append(incassomember.Name).Append("\t");
                    sb2.Append(incassomember.Adres).Append("\t");
                    sb2.Append(incassomember.Postcode).Append("\t");
                    sb2.Append(incassomember.Plaats).Append("\t");
                    sb2.Append(incassomember.Land).Append("\t");
                    sb2.Append(incassomember.Rekeningnummer).Append("\t");
                    if (incassomember.Inschrijfdatum != null)
                    {
                        sb2.Append(incassomember.Inschrijfdatum.Value.ToShortDateString()).Append("\t");
                    }
                    else
                        sb2.Append("\t");
                    sb2.Append(incassomember.Kenmerk).Append("\t");
                    sb2.Append(incassomember.Bedrag).Append("\t");
                    sb2.Append(incassomember.Incassodatum.Value.ToShortDateString()).Append("\t");
                    sb2.Append(incassomember.Incassosoort).Append("\t");
                    sb2.Append(incassomember.Omschrijving).Append("\t");

                    sw.WriteLine(sb2);



                }
            }

        }
    }
}
