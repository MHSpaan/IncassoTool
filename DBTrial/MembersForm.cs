using DBTrial.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTrial
{
    

    public partial class MembersForm : Form
    {

        MyDBContext db = new MyDBContext();
        BareMembersController bmc = new BareMembersController();
        HandyController hc = new HandyController();
        MainForm mainform = new MainForm();
        DataGridControllers dgc = new DataGridControllers();

        public static MembersForm mf;
        public static MembersDetailsForm df;

        public MembersForm()
        {
            InitializeComponent();
            hc.UpdateAmount();
            dgc.UpdateMemberTable(MemberGrid);
            this.StartPosition = new FormStartPosition();

        }

        private ToolStripMenuItem Details = new ToolStripMenuItem("Details");
        private ToolStripMenuItem Delete = new ToolStripMenuItem("Delete");

        private ContextMenuStrip strip;

        private void MemberGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {


            Details.Click -= Details_Click;
            Delete.Click -= Delete_Click;

            Details.Click += Details_Click;
            Delete.Click += Delete_Click;


            strip = new ContextMenuStrip();
            strip.Items.Add(Details);
            strip.Items.Add(Delete);
            e.ContextMenuStrip = strip;

        }

        private DataGridViewCellEventArgs HoverCell;
        private DataGridViewCellCollection y;
        private string firstname;
        private string surname;
        private int memberid;
        private void MemberGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = MemberGrid.Rows[HoverCell.RowIndex].Cells;

                firstname = y[0].Value.ToString();
                surname = y[1].Value.ToString();
            }
        }


        private void Details_Click(object sender, EventArgs e)
        {
            memberid = hc.FindMemberId(firstname, surname);
            MembersDetailsForm df = new MembersDetailsForm(memberid);
            this.Hide();
            df.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            memberid = hc.FindMemberId(firstname, surname);
            hc.DeleteMember(memberid);
            dgc.UpdateMemberTable(MemberGrid);

        }

        private void MemberGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var dt = hc.sortColumns(db, HoverCell.ColumnIndex);
            MemberGrid.DataSource = dt;

        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            var dt = hc.Search(txtSearchMembers.Text);
            MemberGrid.DataSource = dt;
        }

        private void txtSearchMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt = hc.Search(txtSearchMembers.Text);
                MemberGrid.DataSource = dt;
            }
        }

        private void btnFilterInEvent_Click(object sender, EventArgs e)
        {
            var dt = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName,
                x.nrEvents,
                x.Amount
            }).Where(x => x.nrEvents > 0).ToList();
            MemberGrid.DataSource= dt;
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            dgc.UpdateMemberTable(MemberGrid);
        }
    }
}
