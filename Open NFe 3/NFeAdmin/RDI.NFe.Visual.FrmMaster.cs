using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using RDI.NFe2.Business;
using RDI.Lince;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using RDI.NFe2.ORMAP;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Xml;
using RDI.NFe2.SchemaXML;
using System.Linq;
using RDI.OpenSigner;

namespace RDI.NFe.Visual
{
    public partial class FrmMaster : Form
    {
        private List<CustomForm> Janelas;

        public FrmMaster()
        {
            InitializeComponent();
            Janelas = new List<CustomForm>();

            //carregar o combobox com as empresas
            tsddbEmpresas.DropDownItems.Clear();
            foreach (var item in Program.empresasHabilitadas.Where(e => e.habilitada)) //somente habilitadas
            {
                tsddbEmpresas.DropDown.Items.Add(item.cnpj, null, AlterarEmpresa);
            }

            //setar primeira empresa como selecionada
            tsddbEmpresas.Text = "Empresa : " + Program.empresaSelecionada;
        }

        private void AlterarEmpresa(object sender, EventArgs e)
        {
            //alterar empresa selecionada
            var itemSelecionado = (ToolStripItem)sender;
            Program.empresaSelecionada = itemSelecionado.Text;
            //atualizar empresa selecionada
            tsddbEmpresas.Text = "Empresa : " + Program.empresaSelecionada;
            //atualizar barra
            VerificaCertificado();

            //atualizar janelas bloqueadas
            var jn = Janelas.Where(j => j.blockChange).ToList();
            foreach (var item in jn)
            {
                var typ = item.Frm.GetType();
                item.Frm.Close();
                CheckCanCreate(typ, true);
            }

        }


        private void CheckCanCreate(Type TypeFrm, bool blockChange)
        {
            Boolean Create = true;
            Form oNewForm = null;

            foreach (Form oForm in this.MdiChildren)
            {
                if (oForm.Name == TypeFrm.Name)
                {
                    Create = false;
                    oNewForm = oForm;
                    break;
                }
            }

            if (Create)
            {
                oNewForm = (Form)Activator.CreateInstance(TypeFrm);
                oNewForm.MdiParent = this;
                oNewForm.Disposed += new EventHandler(oNewForm_Disposed);

                CustomForm item = new CustomForm();
                item.Frm = oNewForm;
                item.blockChange = blockChange;


                item.Item = janelasToolStripMenuItem.DropDownItems.Add(oNewForm.Text, null,
                    delegate
                    {
                        CheckCanCreate(oNewForm.GetType(), blockChange);
                    }
                    );


                Janelas.Add(item);


                oNewForm.Show();
            }

            oNewForm.BringToFront();

            oNewForm.FormClosed += new FormClosedEventHandler(oNewForm_FormClosed);

        }

        void oNewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            VerificaCertificado();
        }

        void oNewForm_Disposed(object sender, EventArgs e)
        {
            foreach (CustomForm item in Janelas)
            {
                if (item.Frm == ((Form)sender))
                {
                    janelasToolStripMenuItem.DropDownItems.Remove(item.Item);
                    Janelas.Remove(item);
                    break;
                }
            }
        }


        private void FrmMaster_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmSplash fSp = new FrmSplash();
            fSp.Show();
            fSp.Update();
            Thread.Sleep(3000);
            fSp.Close();
            this.Visible = true;
            this.Text = "RDI - Open NFe 3.10";

            VerificaCertificado();

            tmxMaster.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void automaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ServicoInstalado)
            {
                CheckCanCreate(typeof(FrmMonitorServico), false);
            }
            else
            {
                CheckCanCreate(typeof(FrmMonitor), false);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmMonitor), false);
        }

        private void certificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmCertificados), true);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmCertificados), true);
        }


        private void webServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmWebService), true);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmSobre), false);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmSobre), false);
        }

        private void pastasDeArquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmDiretorios), true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmDiretorios), true);
        }

        private void proxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmProxy), true);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmProxy), true);
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmLotes), true);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmLotes), true);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmWebService), true);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmServicos), false);
        }

        private void serviçosPendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmServicos), false);
        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmNotaFiscal), false);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmNotaFiscal), false);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //consulta status do servidor
            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                FuncaoAutomacao oFuncao = new FuncaoAutomacao(Program.empresaSelecionada, manager, Program.enviarInformacoesSobreErros);
                tsbStatusWebsrv.Checked = oFuncao.ConsultaStatus();
                oFuncao = null;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
        }



        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmLog), false);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FrmMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair ?", "Sair do RDI - Open NFe 3.10", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
        }

        private void logToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmLog), false);
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void notasInutilizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCanCreate(typeof(FrmNotaInutilizada), false);

        }



        private void FrmMaster_Shown(object sender, EventArgs e)
        {


        }

        private void tmxMaster_Tick(object sender, EventArgs e)
        {
            VerificaCertificado();
        }

        private void VerificaCertificado()
        {
            //consulta status do servidor
            ClientEnvironment manager = null;
            Parametro oParam = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                if (String.IsNullOrEmpty(oParam.certificado))
                {
                    lbsValidadeCertificado.Text = "Certificado : Nenhum certificado selecionado.";
                }
                else
                {
                    //verificar validade do certificado
                    var oCertificado = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);

                    lbsValidadeCertificado.Text = "Certificado : " + oCertificado.GetNameInfo(X509NameType.SimpleName, false);

                    if (oCertificado.Verify())
                        lbsValidadeCertificado.Text += " | Cadeia : OK";
                    else
                        lbsValidadeCertificado.Text += " | Cadeia : Erro";

                    lbsValidadeCertificado.Text += " | Válido até : " + oCertificado.GetExpirationDateString();
                }

                lbsValidadeCertificado.Text += " | Ambiente : " + (oParam.tipoAmbiente == TAmb.Homologacao ? "Homologação" : "Produção");

                //criar arquivo HeartBeat
                //verificar se FuncaoAutomação esta rodando
                if (!Program.empresasHabilitadas.First(em => em.cnpj == Program.empresaSelecionada).AutomacaoHabilitada && !Program.ServicoHabilitado)
                {
                    foreach (var item in Program.empresasHabilitadas.Where(e => e.habilitada)) //somente habilitadas
                    {
                        NFeUtils.GeraHeartBeat(false, item.cnpj);
                    }
                }

                //exibir se envio de erros esta habilitado
                AtualizarLabelEnviarErros();

            }
            catch
            {
                //silent
            }
            finally
            {
                oParam = null;
                Conexao.DisposeManager(manager);
            }
        }

        private void AtualizarLabelEnviarErros()
        {
            if (Program.enviarInformacoesSobreErros)
                envioErrosStripStatusLabel.Text = "Envio de erros : habilitado.";
            else
                envioErrosStripStatusLabel.Text = "Envio de erros : desabilitado.";
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        FrmInfNRec oFrmChave;

        private void calculaDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oFrmChave = new FrmInfNRec();
            oFrmChave.LabelPergunta.Text = "Informe a chave de acesso sem o DV";
            oFrmChave.Text = "Calcula DV";

            oFrmChave.DoOnOkClick += new EventHandler(oFrmChaveDV_DoOnOkClick);
            oFrmChave.ShowDialog();
        }


        void oFrmChaveDV_DoOnOkClick(object sender, EventArgs e)
        {
            MessageBox.Show(ConverteNFe.DvBase11(oFrmChave.TextResposta.Text));
        }

        private void cartacorrecaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void consultarNFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oFrmChave = new FrmInfNRec();
            oFrmChave.LabelPergunta.Text = "Informe a chave de acesso";
            oFrmChave.Text = "Consulta Situação NFe";

            oFrmChave.DoOnOkClick += new EventHandler(oFrmChave_DoOnOkClick);
            oFrmChave.ShowDialog();
        }

        void oFrmChave_DoOnOkClick(object sender, EventArgs e)
        {
            //consulta status do servidor
            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                FuncaoAutomacao oFuncao = new FuncaoAutomacao(Program.empresaSelecionada, manager, Program.enviarInformacoesSobreErros);

                if (!oFuncao.ConsultaProcNFe(oFrmChave.TextResposta.Text))
                {
                    throw new Exception("Erro não mapeado. Verificar o LOG do sistema.");
                }
                else
                {
                    //arquivo de retorno estara em oParam.pastaRecibo + ChaveNFe + "-sit.xml",
                    ITRetConsSitNFe oRetConsSitNFe =
                    (ITRetConsSitNFe)XMLUtils.CarregaXML_HD(Program.GetParametro(Program.empresaSelecionada, manager).pastaRecibo + oFrmChave.TextResposta.Text + "-sit.xml",
                    oFuncao.oParam.versao,
                    "TRetConsSitNFe");

                    oFrmChave.Close();
                    oFrmChave.Dispose();

                    FrmVisualizaXML oFrmXML = new FrmVisualizaXML(XMLUtils.GetXML(oRetConsSitNFe, oFuncao.oParam.versao));
                    oFrmXML.ShowDialog();

                    oRetConsSitNFe = null;
                    oFuncao = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
        }

        private void envioErrosStripStatusLabel_Click(object sender, EventArgs e)
        {
            //alterar o envio de erros
            bool sucesso = false;
            try
            {
                //alterar a configuração
                Program.enviarInformacoesSobreErros = !Program.enviarInformacoesSobreErros;



                //gerar novamente o arquivo de configuracao
                System.IO.File.Move(".\\conexao", ".\\conexaotmp");

                //Salvar arquivo conexao junto ao .exe do NFeAdmin
                string[] lines = new string[4];
                lines[0] = Program.ConAux;
                lines[1] = Program.cEmp;
                lines[2] = (Program.gravarLogEmArquivo ? "1" : "0");
                lines[3] = (Program.enviarInformacoesSobreErros ? "1" : "0");

                System.IO.File.WriteAllLines(".\\conexao", lines);
                sucesso = true;

            }
            catch
            {
                sucesso = false;
            }


            try
            {
                if (!sucesso)
                {
                    System.IO.File.Move(".\\conexaotmp", ".\\conexao");
                }
                else
                {
                    System.IO.File.Delete(".\\conexaotmp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao manipular o arquivo conexao : " + ex.Message);
            }

            AtualizarLabelEnviarErros();


        }

        private void enviarNFeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfNRec oFrmNovaNota = new FrmInfNRec();
            oFrmNovaNota.Text = "Geração de NFe";
            oFrmNovaNota.LabelPergunta.Text = "Copie e cole somente a Tag infNFe";
            oFrmNovaNota.TextResposta.Multiline = true;
            oFrmNovaNota.TextResposta.Height *= 3;


            oFrmNovaNota.DoOnOkClick += new EventHandler(oFrmNovaNota_DoOnOkClick);
            oFrmNovaNota.ShowDialog();

        }

        void oFrmNovaNota_DoOnOkClick(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;
            try
            {
                var frm = ((FrmInfNRec)((Button)sender).Parent);
                manager = Conexao.CreateManager(Program.ConAux);
                var oParam = Program.GetParametro(Program.empresaSelecionada, manager);
                var xml = "<NFe xmlns=\"http://www.portalfiscal.inf.br/nfe\">" + frm.TextResposta.Text + "</NFe>";
                var oNFe = (ITNFe)XMLUtils.CarregaXML_STR(xml, oParam.versao, "TNFe");

                var fileName = oParam.pastaEntrada + oNFe.infNFe.Id + ".xml";

                XMLUtils.SalvaXML(fileName, oNFe, oParam.versao);

                MessageBox.Show("Arquivo gerado com sucesso na caixa de entrada. " + fileName);

                frm.Close();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                {
                    msg += "inner : " + ex.InnerException.Message;
                }
                MessageBox.Show(msg);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }


        }

    }
}
