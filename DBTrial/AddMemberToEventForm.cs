using DBTrial.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTrial
{
    public partial class AddMemberToEventForm : Form
    {
        MyDBContext db = new MyDBContext();
        HandyController hc = new HandyController();
        Event currentevent = new Event();
        BareMember currentmember = new BareMember();
        public AddMemberToEventForm(Event ev, BareMember member)
        {
            InitializeComponent();
            lblEvent.Text = ev.Name;
            lblMember.Text = member.fullName;
            currentevent = ev;
            currentmember = member;

        }

        private void btnCancelAddMemberToEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitAddMemberToEvent_Click(object sender, EventArgs e)
        {
            EventAmountReduction ear = hc.AddMember(txtAmount.Text, txtReduction.Text);
            ear.thisMember = db.bareMembers.ToList().Find(y=>y.Id == currentmember.Id);
            ear.ThisEvent = db.Events.ToList().Find(y => y.Id == currentevent.Id);
            db.eventAmountReductions.Add(ear);
            db.SaveChanges();
            this.Close();
        }
    }
}
