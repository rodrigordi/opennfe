using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;
using System.Collections;
using RDI.Lince;
using RDI.NFe2.ORMAP;

namespace RDI.NFe.Visual
{
    public partial class FrmNotaInutilizada : Form
    {
        private ArrayList ListaParam;

        public FrmNotaInutilizada()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmNotaInutilizada_Load(object sender, EventArgs e)
        {

        }

        private void FrmNotaInutilizada_Activated(object sender, EventArgs e)
        {

        }

        private void Refresh(object sender, EventArgs e)
        {
            NotaInutilizadaQry oNFQry = new NotaInutilizadaQry();
            oNFQry.empresa = Program.empresaSelecionada;
            if (tbNumero.Text != String.Empty)
                oNFQry.numeroNota = tbNumero.Text;
            oNFQry.dataInicial = dtpDataInicial.Value.Date;
            oNFQry.dataFinal = dtpDataFinal.Value.Date;
            oNFQry.FilterByDate = true;


            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux); 

                ListaParam = NotaInutilizadaDAL.Instance.GetInstances(oNFQry, manager);

                dgvNotaInutilizada.AutoGenerateColumns = false;
                dgvNotaInutilizada.DataSource = ListaParam;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }

            oNFQry = null;

        }


        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void btInutilizar_Click(object sender, EventArgs e)
        {
            FrmInutilizaNota oFrmInut = new FrmInutilizaNota();
            oFrmInut.MdiParent = this.MdiParent;
            oFrmInut.Show();
        }

        private void dgvNotaInutilizada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(3))
            {
                //MessageBox.Show(((NotaInutilizada)dgvNotaInutilizada.Rows[e.RowIndex].DataBoundItem).XMLPedido);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((NotaInutilizada)dgvNotaInutilizada.Rows[e.RowIndex].DataBoundItem).XMLPedido);
                    oFrmXML.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ColumnIndex.Equals(4))
            {
                //MessageBox.Show(((NotaInutilizada)dgvNotaInutilizada.Rows[e.RowIndex].DataBoundItem).XMLResposta);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((NotaInutilizada)dgvNotaInutilizada.Rows[e.RowIndex].DataBoundItem).XMLResposta);
                    oFrmXML.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}