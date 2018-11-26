using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTrial.ViewControllers
{
    class DatagridController
    {
        public DataGridView SetColumnNamesMember(DataGridView grid)
        {

            grid.Columns[0].HeaderText = "First Name";
            grid.Columns[1].HeaderText = "Sur Name";
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            return grid;
        }

    }
}
