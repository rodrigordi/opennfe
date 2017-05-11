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
    public partial class FrmServicos : Form
    {
        private ArrayList ListaParam;
        public FrmServicos()
        {
            InitializeComponent();
            wucRefresh.DoOnTick += new EventHandler(wucRefresh_DoOnTick);
            wucRefresh.grid = dgvFilaDeServicos;
        }

        void wucRefresh_DoOnTick(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            cbSituacao.DataSource = NFeUtils.Listar(typeof(TipoSituacaoServico));
            cbSituacao.DisplayMember = "Value";
            cbSituacao.ValueMember = "Key";
            cbSituacao.Show();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
        private void Refresh(object sender, EventArgs e)
        {
            ServicoPendenteQry oSrvQry = new ServicoPendenteQry();
            oSrvQry.empresa = Program.empresaSelecionada; //multi-empresa

            
            if (tbLote.Text != String.Empty)
                oSrvQry.numeroLote = tbLote.Text;

            //todo : revisar
            if (cbSituacao.SelectedIndex > 0)
                oSrvQry.codigoSituacao = cbSituacao.SelectedValue.ToString();


            if (tbRecibo.Text != String.Empty)
                oSrvQry.numeroRecibo = tbRecibo.Text;

            oSrvQry.dataInicial = dtpDataInicial.Value.Date;
            oSrvQry.dataFinal = dtpDataFinal.Value.Date;
            oSrvQry.FilterByDate = true;


            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);

                ListaParam = ServicoPendenteDAL.Instance.GetInstances(oSrvQry, manager);

                dgvFilaDeServicos.AutoGenerateColumns = false;
                dgvFilaDeServicos.DataSource = ListaParam;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
            oSrvQry = null;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            int indice;

            if (dgvFilaDeServicos.SelectedRows.Count > 0)
            {
                indice = dgvFilaDeServicos.SelectedRows[0].Index;//o activated atualiza o grid e o index fica null
                if (MessageBox.Show("Deseja realmente excluir o serviço pendente ?", "Exclusão de serviço.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClientEnvironment manager = null;
                    try
                    {
                        manager = Conexao.CreateManager(Program.ConAux);

                        ServicoPendente oSrv = (ServicoPendente)ListaParam[indice];
                        oSrv = (ServicoPendente)ServicoPendenteDAL.Instance.Find(oSrv.keyString, manager);
                        oSrv.codigoSituacao = TipoSituacaoServico.Excluido;

                        //buscar no banco as notas aprovadas desse ServicoPendente
                        NotaFiscalQry oNFeQry = new NotaFiscalQry();
                        oNFeQry.empresa = oSrv.empresa;
                        oNFeQry.numeroLote = oSrv.numeroLote.ToString();

                        ArrayList notas = NotaFiscalDAL.Instance.GetInstances(oNFeQry, manager);
                        foreach (NotaFiscal oNFe in notas)
                        {
                            oNFe.codigoSituacao = TipoSituacaoNota.SerivcoExcluido;// 99;
                            oNFe.descricaoSituacao = "Serviço excluido";
                            oNFe.Save(manager);
                        }

                        oSrv.Save(manager);
                        MessageBox.Show("Serviço excluido com sucesso.", "Exclusão de serviço.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        Conexao.DisposeManager(manager);

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um serviço para ser excluido.", "Exclusão de serviço.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Refresh(sender, e);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvFilaDeServicos.SelectedRows.Count > 0)
            {
                FrmEditServico frmEditSrv = new FrmEditServico();
                frmEditSrv.oSrv = new ServicoPendente();
                frmEditSrv.oSrv = (ServicoPendente)ListaParam[dgvFilaDeServicos.SelectedRows[0].Index];
                frmEditSrv.MdiParent = this.MdiParent;
                frmEditSrv.Show();
            }
            else
            {
                MessageBox.Show("Selecione um registro para ser visualizado.", "Visualização de registro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }

        private void dgvFilaDeServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(4))
            {
                //MessageBox.Show(((ServicoPendente)dgvFilaDeServicos.Rows[e.RowIndex].DataBoundItem).xmlRecibo);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((ServicoPendente)dgvFilaDeServicos.Rows[e.RowIndex].DataBoundItem).xmlRecibo);
                    oFrmXML.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.ColumnIndex.Equals(5))
            {
                //MessageBox.Show(((ServicoPendente)dgvFilaDeServicos.Rows[e.RowIndex].DataBoundItem).xmlRecibo);
                try
                {
                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(
                        ((ServicoPendente)dgvFilaDeServicos.Rows[e.RowIndex].DataBoundItem).xmlRetConsulta);
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

        private void dgvFilaDeServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}