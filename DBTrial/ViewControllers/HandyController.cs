using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTrial.ViewControllers
{
    class HandyController
    {
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

        public IEnumerable Search(MyDBContext db,string searchstring)
        {
            var dt = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName
            }).Where(x => x.firstName.Contains(searchstring) || x.surName.Contains(searchstring)).ToList();
            return dt;
        }


    }
}
