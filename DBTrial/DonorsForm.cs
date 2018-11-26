using DBTrial.ViewControllers;
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
    public partial class DonorsForm : Form
    {
        MyDBContext db = new MyDBContext();
        public DonorsForm()
        {
            InitializeComponent();
            DonorGrid.DataSource = db.bareMembers.Select(x => new
            {
                x.firstName,
                x.surName,
                x.preFix,
                x.Gender,
                x.Address,
                x.Postcode,
                x.City,
                x.mobilePhoneNumber,
                x.emailAddress,
                x.dateOfBirth,
                x.studentNumber,
                x.accountNumber,
                x.joinDate


            }).ToList();
            DatagridController dt = new DatagridController();
            dt.SetColumnNamesMember(DonorGrid);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            btn.HeaderText = "Remove Member";
            btn.Text = "Remove";
            btn.Name = "btnRemoveMember";
            btn.UseColumnTextForButtonValue = true;

            DonorGrid.Columns.Add(btn);

        }

        private void btnMemberView_Click(object sender, EventArgs e)
        {
            MembersForm mf = new MembersForm();
            this.Hide();
            mf.Show();
        }

        private void btnIndexFromDonor_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnMemberView_Click_1(object sender, EventArgs e)
        {

        }
    }
}
