using DBTrial.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTrial
{
    public partial class MembersDetailsForm : Form
    {
        MyDBContext db = new MyDBContext();
        HandyController hc = new HandyController();
        BareMembersController bmc = new BareMembersController();
        int Id = 0;

        public MembersDetailsForm(int id)
        {
            InitializeComponent();
            Id = id;
            var member = db.bareMembers.Where(x => x.Id == id).Select(x => new
            {
                x.Initials,
                x.firstName,
                x.preFix,
                x.surName,
                x.Gender,
                x.Address,
                x.Postcode,
                x.City,
                x.mobilePhoneNumber,
                x.emailAddress,
                x.dateOfBirth,
                x.studentNumber,
                x.accountNumber,
                x.joinDate,
                x.Events


            }).ToList();
            DataTable dt = hc.CreateDataTable(member);
            DataTable transposed = hc.Transpose(dt);
            DetailsGrid.DataSource = transposed.DefaultView;
            

        }

        private void btnDeleteMemberDetails_Click(object sender, EventArgs e)
        {
            hc.DeleteMember(Id);
            MembersForm mf = new MembersForm();
            this.Hide();
            mf.Show();
        }

        private void btnBackDetailsMember_Click(object sender, EventArgs e)
        {
            MembersForm mf = new MembersForm();
            this.Hide();
            mf.Show();
        }
    }
}
