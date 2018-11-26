using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBTrial.Classes;
using DBTrial.Controllers;

namespace DBTrial
{

    public partial class Form1 : Form
    {
        public MyDBContext db = new MyDBContext();
        MainForm mf = new MainForm();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnOpenFileMembers_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "C:\\Users\\Matthijs\\Downloads",
                Filter = "CSV Files (*.csv)|*.csv"
            };

            BareMembersController bmc = new BareMembersController();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                    using (myStream = ofd.OpenFile())
                    {
                        int addcounter = bmc.ImportMember(myStream);
                    }
                    using (myStream = ofd.OpenFile())
                    {
                        int removecounter = bmc.RemoveMembers(myStream);
                    }
                


            }
        }

        private void btnMemberData_Click(object sender, EventArgs e)
        {
            //mf.tomembersform();
            
        }

        private void btnImportEvent_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            MultipleOutput mo = new MultipleOutput();
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "C:\\Users\\Matthijs\\Downloads",
                Filter = "CSV Files (*.csv)|*.csv"
            };

            EventsController ec = new EventsController();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                using (myStream = ofd.OpenFile())
                {
                    mo = ec.ImportEvent(myStream);
                }
                EventCreationForm ecf = new EventCreationForm(mo);
                this.Hide();
                ecf.Show();
            }

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventsForm EF = new EventsForm();
            this.Hide();
            EF.Show();
        }

        private void btnToIncassoForm_Click(object sender, EventArgs e)
        {
            IncassoForm IF = new IncassoForm();
            this.Hide();
            IF.Show();
        }
    }
}
