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
using RDI.NFe2.SchemaXML;

namespace RDI.NFe.Visual
{
    public partial class FrmNotaFiscal : Form
    {
        private ArrayList ListaParam;

        public FrmNotaFiscal()
        {
            InitializeComponent();
            wucRefresh.DoOnTick += new EventHandler(wucRefresh_DoOnTick);
            wucRefresh.grid = dgvNotaFiscal;
        }

        void wucRefresh_DoOnTick(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmNotaFiscal_Load(object sender, EventArgs e)
        {
            cbSituacao.DataSource = NFeUtils.Listar(typeof(TipoSituacaoNota));
            cbSituacao.DisplayMember = "Value";
            cbSituacao.ValueMember = "Key";
            cbSituacao.Show();
        }

        private void FrmNotaFiscal_Activated(object sender, EventArgs e)
        {

        }

        private void Refresh(object sender, EventArgs e)
        {
            NotaFiscalQry oNFQry = new NotaFiscalQry();
            oNFQry.empresa = Program.empresaSelecionada;
            if (tbchave.Text != String.Empty)
                oNFQry.chaveNota = tbchave.Text;
            if (tbLote.Text != String.Empty)
                oNFQry.numeroLote = tbLote.Text;

            if (cbSituacao.SelectedIndex > 0)
                oNFQry.codigoSituacao = (TipoSituacaoNota)int.Parse(cbSituacao.SelectedValue.ToString());

            oNFQry.dataInicial = dtpDataInicial.Value.Date;
            oNFQry.dataFinal = dtpDataFinal.Value.Date;
            oNFQry.FilterByDate = true;

            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);

                ListaParam = NotaFiscalDAL.Instance.GetInstances(oNFQry, manager);

                dgvNotaFiscal.AutoGenerateColumns = false;
                dgvNotaFiscal.DataSource = ListaParam;

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

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvNotaFiscal.SelectedRows.Count > 0)
            {
                FrmEditNota frmEditNFe = new FrmEditNota();

                frmEditNFe.oNFe = (NotaFiscal)ListaParam[dgvNotaFiscal.SelectedRows[0].Index];

                //frmEditNFe.oNFe.xmlProcessoFinal = dgvNotaFiscal.SelectedRows[0].Cells[6].Value.ToString();
                //frmEditNFe.oSrv.empresa = Program.oParam.empresa;
                frmEditNFe.MdiParent = this.MdiParent;
                frmEditNFe.Show();
            }
            else
            {
                MessageBox.Show("Selecione um registro para ser visualizado.", "Visualização de registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void dgvNotaFiscal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(5))
            {
                //MessageBox.Show(((NotaFiscal)dgvNotaFiscal.Rows[e.RowIndex].DataBoundItem).xmlNota);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((NotaFiscal)dgvNotaFiscal.Rows[e.RowIndex].DataBoundItem).xmlNota);
                    oFrmXML.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (e.ColumnIndex.Equals(6))
            {
                //MessageBox.Show(((NotaFiscal)dgvNotaFiscal.Rows[e.RowIndex].DataBoundItem).xmlProcessoFinal);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((NotaFiscal)dgvNotaFiscal.Rows[e.RowIndex].DataBoundItem).xmlProcesso);
                    oFrmXML.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dgvNotaFiscal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}