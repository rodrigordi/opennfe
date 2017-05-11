using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RDI.NFe2.Business;
using RDI.Lince;
using RDI.NFe2.ORMAP;

namespace RDI.NFe.Visual
{
    public partial class FrmLog : Form
    {
        ArrayList ListaParam;
        public FrmLog()
        {
            InitializeComponent();
            wucRefresh.DoOnTick += new EventHandler(wucRefresh_DoOnTick);
            wucRefresh.grid = dgvLog;
        }

        void wucRefresh_DoOnTick(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void FrmLog_Activated(object sender, EventArgs e)
        {
        }

        private void Refresh(object sender, EventArgs e)
        {
            LogQRY oLogQry = new LogQRY();
            oLogQry.empresa = Program.empresaSelecionada; //multi-empresa
            if (tbchave.Text != String.Empty)
                oLogQry.chaveNota = tbchave.Text;
            oLogQry.dataInicial = dtpDataInicial.Value.Date;
            oLogQry.dataFinal = dtpDataFinal.Value.Date;
            oLogQry.FilterByDate = true;

            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);

                ListaParam = LogDAL.Instance.GetInstances(oLogQry, manager);

                dgvLog.AutoGenerateColumns = false;
                dgvLog.DataSource = ListaParam;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
            oLogQry = null;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Refresh(sender,e);
        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}