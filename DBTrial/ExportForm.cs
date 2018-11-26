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
    public partial class ExportForm : Form
    {
        IncassoMembersController emc = new IncassoMembersController();
        MainForm mainForm = new MainForm();

        public ExportForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = new FormStartPosition();
        }

        private void btnExportFormBackToEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.toeventsform(this.MdiParent);
        }

        private void btnExportForm_Click(object sender, EventArgs e)
        {
            emc.Convert(txtExportFormIncassoNumber.Text, cldrExportFormIncassoDate.SelectionStart.Date);
            mainForm.toincassoform(this.MdiParent);
        }
    }
}
