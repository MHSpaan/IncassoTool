using DBTrial.Classes;
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
    public partial class MainForm : Form
    {
        BareMembersController bmc = new BareMembersController();
        EventsController ec = new EventsController();
        HandyController hc = new HandyController();
        public MainForm()
        {
            InitializeComponent();

        }

        private void ImportMembers_Click(object sender, EventArgs e)
        {
            bmc.openImportMember();
        }

        private void ImportEvent_Click(object sender, EventArgs e)
        {
            hideinactive();
            MultipleOutput mo = ec.openImportEvent();
            toeventcreationform(this,mo);
        }

        public void toeventcreationform(Form thisform, MultipleOutput mo)
        {
            EventCreationForm ecf = new EventCreationForm(mo);
            ecf.MdiParent = thisform;
            ecf.Show();
        }

        public void toeventdetailsform(Form thisform, int id)
        {
            EventDetailsForm edf = new EventDetailsForm(id);
            edf.Show();
            edf.MdiParent = thisform;
        }

        public void toeventsform(Form thisform)
        {
            EventsForm ef = new EventsForm();
            ef.MdiParent = thisform;
            ef.Show();
        }

        public void toexportform(Form thisform)
        {
            ExportForm ef = new ExportForm();
            ef.MdiParent = thisform;
            ef.Show();
        }

        public void toincassoform(Form thisform)
        {
            IncassoForm IF = new IncassoForm();
            IF.MdiParent = thisform;
            IF.Show();
        }

        public void tomembersdetailsform(Form thisform,int id)
        {
            MembersDetailsForm mdf = new MembersDetailsForm(id);
            mdf.MdiParent = thisform;
            mdf.Show();
        }

        public void tomembersform(Form thisform)
        {
            MembersForm mf = new MembersForm();
            mf.MdiParent = this;
            mf.Show();
        }

        public void hideinactive()
        {
            foreach (var child in this.MdiChildren)
            {
                child.Hide();
            }

        }

        private void ShowMembers_Click(object sender, EventArgs e)
        {
            hideinactive();
            tomembersform(this);
        }

        private void ShowEvents_Click(object sender, EventArgs e)
        {
            hideinactive();
            toeventsform(this);
        }

        private void ShowIncassos_Click(object sender, EventArgs e)
        {
            hideinactive();
            toincassoform(this);
        }


    }
}
