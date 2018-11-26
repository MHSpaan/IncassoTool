using DBTrial.Classes;
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
    public partial class EventCreationForm : Form
    {
        HandyController hc = new HandyController();
        MyDBContext db = new MyDBContext();
        List<EventAmountReduction> EventMembers = new List<EventAmountReduction>();
        Event currentevent = new Event();
        BareMember currentmember = new BareMember();
        MainForm mainForm = new MainForm();

        public EventCreationForm(MultipleOutput mo)
        {
            currentevent = mo.newEvent;
            InitializeComponent();
            //add text
            var eventname = mo.newEvent.Name + Environment.NewLine + mo.newEvent.Cost;
            lblEventAdded.Text = eventname;

            // Fill grids with added and not added members
            DataTable dt = new DataTable();
            dt.Columns.Add("First Name");
            dt.Columns.Add("Sur Name");
            foreach (var item in mo.notAdded)
            {
                int charlocation = item.IndexOf(",", StringComparison.Ordinal);
                dt.Rows.Add(item.Substring(0, charlocation), item.Substring(charlocation + 1, (item.Length - charlocation - 1)));
            }
            EventParticipantsNotAdded.DataSource = dt;
            EventParticipantsNotAdded.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var neweventmembers = mo.newEvent.eventAmounts.ToList().Select(x => x.thisMember).Select(x => new { x.firstName, x.surName }).ToList();
            EventParticipantsAdded.DataSource = neweventmembers;
            EventParticipantsAdded.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Fill last grid with Members database
            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == currentevent.Id).ToList();
            EventMemberList.DataSource = hc.Search("", EventMembers);

            EventMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = new FormStartPosition();

        }

        private void btnEventsFromEventCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.toeventsform(this.MdiParent);
        }


        private ToolStripMenuItem AddMemberToEvent = new ToolStripMenuItem("Add to event");
        private ToolStripMenuItem DeleteMemberFromEvent = new ToolStripMenuItem("Delete from event");
        private ContextMenuStrip strip;

        private void EventMemberList_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
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
        private void EventMemberList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = EventMemberList.Rows[HoverCell.RowIndex].Cells;

                firstname = y[0].Value.ToString();
                surname = y[1].Value.ToString();
            }
        }

        private void AddMemberToEvent_Click(object sender, EventArgs e)
        {

            var memberid = hc.FindMemberId(firstname, surname);
            currentevent = db.Events.Include("eventAmounts").ToList().Find(ce => ce.Id == currentevent.Id);
            currentmember = db.bareMembers.Include("Events").ToList().Find(cm => cm.Id == memberid);
            AddMemberToEventForm amtef = new AddMemberToEventForm(currentevent,currentmember);
            amtef.ShowDialog();

            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == currentevent.Id).ToList();
            EventParticipantsAdded.DataSource = EventMembers.Select(x => x.thisMember).ToList().Select(y => new { y.firstName, y.surName }).ToList();
            EventMemberList.DataSource = hc.Search("", EventMembers);
        }


        private void EventParticipantsAdded_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DeleteMemberFromEvent.Click -= DeleteMemberFromEvent_Click;
            DeleteMemberFromEvent.Click += DeleteMemberFromEvent_Click;


            strip = new ContextMenuStrip();
            strip.Items.Add(DeleteMemberFromEvent);
            e.ContextMenuStrip = strip;
        }

        private void EventParticipantsAdded_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = EventParticipantsAdded.Rows[HoverCell.RowIndex].Cells;

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
            EventParticipantsAdded.DataSource = db.Events.Include("eventAmounts").ToList().Find(epc => epc.Id == currentevent.Id).eventAmounts.Select(x => x.thisMember).ToList().Select(x => new
            {
                x.firstName,
                x.surName
            }).ToList();
            EventMembers = db.eventAmountReductions.Include("thisMember").Where(x => x.ThisEvent.Id == editevent.Id).ToList();
            EventMemberList.DataSource = hc.Search(txtEventSearchMembers.Text, EventMembers);
        }

        private void btnEventMemberSearch_Click(object sender, EventArgs e)
        {
            var dt = hc.Search(txtEventSearchMembers.Text, EventMembers);
            EventMemberList.DataSource = dt;
        }

        private void txtEventSearchMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt = hc.Search(txtEventSearchMembers.Text, EventMembers);
                EventMemberList.DataSource = dt;
            }
        }

    }
}
