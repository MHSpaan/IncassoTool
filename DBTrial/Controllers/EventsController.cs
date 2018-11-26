using DBTrial.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace DBTrial.Controllers
{
    public class EventsController
    {
        private MyDBContext db = new MyDBContext();

        public MultipleOutput openImportEvent()
        {
            Stream myStream = null;
            MultipleOutput mo = new MultipleOutput();
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "C:\\Users\\Matthijs\\Downloads",
                Filter = "CSV Files (*.csv)|*.csv"
            };

            EventsController ec = new EventsController();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                using (myStream = ofd.OpenFile())
                {
                    mo = ImportEvent(myStream);
                }
            }
            return mo;

        }

        public MultipleOutput ImportEvent(Stream stream)
        {
            var counter = 0;

            List<string> notadded = new List<string>();
            Event newevent = new Event();
            List<Event> currentevents = new List<Event>();
            currentevents = db.Events.ToList();

            using (StreamReader sr = new StreamReader(stream))
            {

                string[] x;
                var addcounter = 0;
                var notaddedcounter = 0;
                while (sr.EndOfStream == false)
                {
                    x = sr.ReadLineAsync().Result.Split(';');
                    counter++;
                    if (counter == 2)
                    {
                        newevent.Cost = decimal.Parse(x[1]);
                        newevent.Name = x[0];
                        if (currentevents.Exists(e => e.Name == x[0]))
                        {
                            var existingevent = currentevents.Find(y => y.Name == x[0]);
                            var eventears = db.eventAmountReductions.Include("thisMember").Include("thisEvent").Where(z => z.ThisEvent.Id == existingevent.Id).ToList();
                            foreach (var ear in eventears)
                            {

                                db.eventAmountReductions.Remove(ear);

                            }
                            db.Events.Remove(existingevent);
                            db.SaveChanges();
                        }
                    }
                    if (counter > 3)
                    {
                        var memberfinder = db.bareMembers.ToList().Find(y => y.firstName.ToLower() == x[0].ToLower() && y.surName.ToLower() == x[1].ToLower());
                        if (memberfinder != null)
                        {
                            EventAmountReduction ear = new EventAmountReduction();

                            if (int.TryParse(x[2], out int num))
                            {
                                ear.Amount = num;
                            }
                            if (decimal.TryParse(x[3], out decimal num2))
                            {

                                ear.Reduction = num2;
                            }
                            ear.thisMember = memberfinder;
                            db.eventAmountReductions.Add(ear);
                            newevent.eventAmounts.Add(ear);
                            addcounter++;
                            db.SaveChanges();
                        }
                        else
                        {
                            notaddedcounter++;
                            notadded.Add($"{x[0]},{x[1]}");
                        }

                    }

                }
                db.Events.Add(newevent);
                db.SaveChanges();
                StringBuilder sb = new StringBuilder();
                foreach (var member in notadded)
                {
                    sb.Append(member + " ");
                }

            }
            MultipleOutput mo = new MultipleOutput();
            mo.newEvent = newevent;
            mo.notAdded = notadded;
            return mo;
        }
    }
}
