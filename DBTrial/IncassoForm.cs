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
    public partial class IncassoForm : Form
    {
        MyDBContext db = new MyDBContext();
        HandyController hc = new HandyController();
        IncassoMembersController imc = new IncassoMembersController();
        MainForm mainForm = new MainForm();

        public IncassoForm()
        {
            InitializeComponent();
            IncassosGrid.DataSource = db.Incassos.Select(x => new { x.Number, x.IncassoDate, x.incassoMembers.Count }).ToList();
            IncassosGrid.Columns[0].HeaderText = "Number";
            IncassosGrid.Columns[1].HeaderText = "Date";
            IncassosGrid.Columns[2].HeaderText = "Amount of Members";
            IncassosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = new FormStartPosition();
        }

        private ToolStripMenuItem Export = new ToolStripMenuItem("Export");
        private ToolStripMenuItem Details = new ToolStripMenuItem("Details");
        private ToolStripMenuItem Delete = new ToolStripMenuItem("Delete");
        private ContextMenuStrip strip;

        private void IncassosGrid_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {


            Details.Click -= Details_Click;
            Export.Click -= Export_Click;
            Delete.Click -= Delete_Click;

            Details.Click += Details_Click;
            Export.Click += Export_Click;
            Delete.Click += Delete_Click;


            strip = new ContextMenuStrip();
            strip.Items.Add(Export);
            strip.Items.Add(Details);
            strip.Items.Add(Delete);
            e.ContextMenuStrip = strip;

        }

        private DataGridViewCellEventArgs HoverCell;
        private DataGridViewCellCollection y;
        private int IncassoNumber;
        private int IncassoId;
        private void IncassosGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            HoverCell = e;
            if (HoverCell.RowIndex >= 0)
            {
                y = IncassosGrid.Rows[HoverCell.RowIndex].Cells;

                IncassoNumber = (int)y[0].Value;
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            var incassoid = hc.FindIncassoId(IncassoNumber);
            imc.ConvertToExcel(incassoid);
        }

        private void Details_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            IncassoId = hc.FindIncassoId(IncassoNumber);
            hc.DeleteIncasso(IncassoId);
            IncassosGrid.DataSource = db.Incassos.Select(x => new { x.Number, x.IncassoDate, x.incassoMembers.Count }).ToList();
        }



    }
}
