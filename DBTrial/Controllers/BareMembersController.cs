using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DBTrial;

namespace DBTrial.Controllers
{
    public class BareMembersController
    {
        private MyDBContext db = new MyDBContext();

        public void openImportMember()
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "C:\\Users\\Matthijs\\Downloads",
                Filter = "CSV Files (*.csv)|*.csv"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (myStream = ofd.OpenFile())
                {
                    int addcounter = ImportMember(myStream);
                }
                using (myStream = ofd.OpenFile())
                {
                    int removecounter = RemoveMembers(myStream);
                }
            }
        }


        public int ImportMember(Stream stream)
        {
            var addcounter = 0;
            

            using (StreamReader sr = new StreamReader(stream))
            {
                var tmp = db.bareMembers;
                string[] x;
                while (sr.EndOfStream == false)
                {
                    x = sr.ReadLineAsync().Result.Split('\t');

                    DateTime datevalue;
                    if (x.Count() == 22)
                    {
                        if (x[4] == "M" || x[4] == "F")
                        {
                            var alreadymemberchecker = tmp.ToList().Find(y => y.accountNumber == x[17] && y.emailAddress == x[10] && y.mobilePhoneNumber == x[9]);
                            if (alreadymemberchecker == null)
                            {

                                BareMember newmember = new BareMember
                                {
                                    firstName = x[3],
                                    preFix = x[1],
                                    surName = x[0],
                                    Initials = x[2],
                                    Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), x[4]),
                                    Address = x[5],
                                    Postcode = x[6],
                                    City = x[7],
                                    phoneNumber = x[8],
                                    mobilePhoneNumber = x[9],
                                    emailAddress = x[10],
                                    studentNumber = x[13],
                                    accountNumber = x[17],
                                };
                                if(!DateTime.TryParse(x[11],out datevalue))
                                {

                                    newmember.dateOfBirth = new DateTime(1990,01,01);
                                }
                                else
                                {
                                    newmember.dateOfBirth = DateTime.Parse(x[11]);
                                }
                                if (!DateTime.TryParse(x[18], out datevalue))
                                {

                                    newmember.joinDate = new DateTime(2008,01,01);
                                }
                                else
                                {
                                    newmember.joinDate = DateTime.Parse(x[18]);
                                }


                                db.bareMembers.Add(newmember);
                                addcounter++;
                            }
                            //Courses.Add(x[15]);

                        }


                    }

                }
                db.bareMembers.OrderBy(y => y.surName);
                db.SaveChanges();
                return addcounter;
            }

        }

        public int RemoveMembers(Stream stream)
        {
            using (StreamReader sr = new StreamReader(stream))
            {
                int removecounter = 0;
                var tmp = db.bareMembers.ToList();
                var totalfile = sr.ReadToEnd().Split('\t');
                foreach (var member in tmp)
                {
                    var isnolongermember = totalfile.Any(p => p == member.accountNumber);
                    if (!isnolongermember)
                    {
                        OldMember removedmember = new OldMember
                        {
                            firstName = member.firstName,
                            preFix = member.preFix,
                            surName = member.surName,
                            Initials = member.Initials,
                            leaveDate = DateTime.Now.Date
                        };
                        db.oldMembers.Add(removedmember);
                        db.bareMembers.Remove(member);
                        removecounter++;
                    }
                }
                db.SaveChanges();
                return removecounter;
            }
        }


    }
}


