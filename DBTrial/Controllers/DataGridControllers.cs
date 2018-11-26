using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTrial.Controllers
{
    class DataGridControllers
    {
        MyDBContext db = new MyDBContext();
        public DataGridView UpdateMemberTable(DataGridView MemberGrid)
        {
            MemberGrid.DataSource = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName,
                x.nrEvents,
                x.Amount

            }).ToList();
            MemberGrid.Columns[0].HeaderText = "First Name";
            MemberGrid.Columns[1].HeaderText = "Sur Name";
            MemberGrid.Columns[2].HeaderText = "Number of Events";
            MemberGrid.Columns[3].HeaderText = "Amount (€)";

            MemberGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MemberGrid.BorderStyle = BorderStyle.None;
            return MemberGrid;
        }
    }
}
