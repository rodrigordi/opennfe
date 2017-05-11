using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RDI
{
    public partial class timexRefresh : UserControl
    {
        public event EventHandler DoOnTick;
        public DataGridView grid;

        public timexRefresh()
        {
            InitializeComponent();
        }

        private void chkRefresh_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (!String.IsNullOrEmpty(mtxDelay.Text))
            {
                try
                {
                    tmrRefresh.Interval = Int32.Parse(mtxDelay.Text);
                    tmrRefresh.Enabled = chkRefresh.Checked;
                    mtxDelay.Enabled = !chkRefresh.Checked;
                }
                catch
                {
                    error = true;
                }
            }
            else
            {
                error = true;
            }

            if (error)
            {
                if (chkRefresh.Checked)
                {
                    chkRefresh.Checked = false;
                    tmrRefresh.Enabled = false;
                    mtxDelay.Enabled = true;
                }
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if(DoOnTick != null)
            {
                DoOnTick(sender, e);
            }

            if (grid != null && grid.Rows.Count > 0)
            {
                grid.CurrentCell = grid.Rows[grid.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[0];
            }
        }
    }
}
