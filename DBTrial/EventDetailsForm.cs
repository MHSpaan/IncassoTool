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
    public partial class EventDetailsForm : Form
    {
        MyDBContext db = new MyDBContext();
        HandyController hc = new HandyController();
        List<EventAmountReduction> EventMembers = new List<EventAmountReduction>();
        Event currentevent = new Event();
        BareMember currentmember = new BareMember();
        MainForm mainForm = new MainForm();

        public EventDetailsForm(int id)
        {
            currentevent = db.Events.Include("eventAmounts").ToList().Find(x => x.Id == id);
            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == id).ToList();
            InitializeComponent();
            EventDetailsParticipantsGrid.DataSource = EventMembers.Select(x => x.thisMember).ToList().Select(y => new { y.firstName, y.surName }).ToList();
            EventDetailsMembersGrid.DataSource = hc.Search("", EventMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = new FormStartPosition();
        }

        private void btnBackToEventsFromEventDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.toeventsform(this.MdiParent);
        }

        private ToolStripMenuItem AddMemberToEvent = new ToolStripMenuItem("Add to event");
        private ToolStripMenuItem DeleteMemberFromEvent = new ToolStripMenuItem("Delete from event");
        private ContextMenuStrip strip;

        private void EventDetailsMembersGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            AddMemberToEvent.Click -= AddMemberToEvent_Click;
            AddMemberToEvent.Click += AddMemberToEvent_Click;


            strip = new ContextMenuStrip();
            strip.Items.Add(AddMemberToEvent);
            e.ContextMenuStrip = strip;

        }

        private DataGridViewCellEventArgs HoverCell;
        private DataGridViewCellCollection y;
        private string firstname;
        private string surname;
        private void EventDetailsMembersGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = EventDetailsMembersGrid.Rows[HoverCell.RowIndex].Cells;

                firstname = y[0].Value.ToString();
                surname = y[1].Value.ToString();
            }
        }


        private void AddMemberToEvent_Click(object sender, EventArgs e)
        {

            var memberid = hc.FindMemberId(firstname, surname);
            currentevent = db.Events.Include("eventAmounts").ToList().Find(ce => ce.Id == currentevent.Id);
            currentmember = db.bareMembers.Include("Events").ToList().Find(cm => cm.Id == memberid);
            AddMemberToEventForm amtef = new AddMemberToEventForm(currentevent, currentmember);
            amtef.ShowDialog();

            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == currentevent.Id).ToList();
            EventDetailsParticipantsGrid.DataSource = EventMembers.Select(x => x.thisMember).ToList().Select(y => new { y.firstName, y.surName }).ToList();
            EventDetailsMembersGrid.DataSource = hc.Search("", EventMembers);
        }


        private void EventDetailsParticipantsGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DeleteMemberFromEvent.Click -= DeleteMemberFromEvent_Click;
            DeleteMemberFromEvent.Click += DeleteMemberFromEvent_Click;


            strip = new ContextMenuStrip();
            strip.Items.Add(DeleteMemberFromEvent);
            e.ContextMenuStrip = strip;
        }
        private void EventDetailsParticipantsGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = EventDetailsParticipantsGrid.Rows[HoverCell.RowIndex].Cells;

                firstname = y[0].Value.ToString();
                surname = y[1].Value.ToString();
            }
        }

        private void DeleteMemberFromEvent_Click(object sender, EventArgs e)
        {
            var memberid = hc.FindMemberId(firstname, surname);
            Event editevent = db.Events.Include("eventAmounts").ToList().Find(ee => ee.Id == currentevent.Id);
            EventAmountReduction ear = db.eventAmountReductions.Include("thisMember").ToList().Find(x => x.ThisEvent.Id == editevent.Id && x.thisMember.Id == memberid);
            db.eventAmountReductions.Remove(ear);
            db.SaveChanges();
            EventDetailsParticipantsGrid.DataSource = db.Events.Include("eventAmounts").ToList().Find(epc => epc.Id == currentevent.Id).eventAmounts.Select(x => x.thisMember).ToList().Select(x => new
            {
                x.firstName,
                x.surName
            }).ToList();
            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == editevent.Id).ToList();
            EventDetailsMembersGrid.DataSource = hc.Search(txtSearchMembersEventDetails.Text, EventMembers);
        }

        private void txtSearchMembersEventDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt = hc.Search(txtSearchMembersEventDetails.Text, EventMembers);
                EventDetailsMembersGrid.DataSource = dt;
            }
        }

        private void btnSearchMembersEventDetails_Click(object sender, EventArgs e)
        {
            var dt = hc.Search(txtSearchMembersEventDetails.Text, EventMembers);
            EventDetailsMembersGrid.DataSource = dt;
        }


    }
}
