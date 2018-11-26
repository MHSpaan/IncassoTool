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
    public partial class EventsForm : Form
    {
        MyDBContext db = new MyDBContext();
        HandyController hc = new HandyController();
        MainForm mainForm = new MainForm();
        public EventsForm()
        {
            InitializeComponent();
            EventGrid.DataSource = db.Events.Select(x => new { x.Name, x.Cost, x.eventAmounts.Count }).ToList();
            EventGrid.Columns[0].HeaderText = "Name";
            EventGrid.Columns[1].HeaderText = "Cost (€)";
            EventGrid.Columns[2].HeaderText = "Amount of Members";
            EventGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = new FormStartPosition();
        }



        private ToolStripMenuItem Details = new ToolStripMenuItem("Details");
        private ToolStripMenuItem Delete = new ToolStripMenuItem("Delete");
        private ContextMenuStrip strip;

        private void EventGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
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
        private string eventname;
        private int eventId;
        private void EventGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = EventGrid.Rows[HoverCell.RowIndex].Cells;
                eventname = y[1].Value.ToString();
                eventname = y[0].Value.ToString();
            }
        }


        private void Details_Click(object sender, EventArgs e)
        {
            eventId = hc.FindEventId(eventname);
            Hide();
            mainForm.toeventdetailsform(this.MdiParent, eventId);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            eventId = hc.FindEventId(eventname);
            hc.DeleteEvent(eventId);
            EventGrid.DataSource = db.Events.Select(x => new { x.Name, x.Cost, x.eventAmounts.Count }).ToList();

        }

        private void btnExportEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.toexportform(this.MdiParent);
        }
    }

}
