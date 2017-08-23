using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;
using RDI.Lince;
using RDI.NFe2.ORMAP;
using System.Collections;
using RDI.NFe2.SchemaXML;

namespace RDI.NFe.Visual
{
    public partial class FrmEditServico : Form
    {
        FrmInfNRec oFrm;
        public ServicoPendente oSrv;
        public FrmEditServico()
        {
            InitializeComponent();
        }

        private void btGrava_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditServico_Load(object sender, EventArgs e)
        {
            DoRefresh();
        }

        private void DoRefresh()
        {
            if (oSrv != null)
            {
                ClientEnvironment manager = null;
                try
                {
                    manager = Conexao.CreateManager(Program.ConAux);
                    oSrv = (ServicoPendente)ServicoPendenteDAL.Instance.Find(oSrv.keyString, manager);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.DisposeManager(manager);
                }

                txLote.Text = oSrv.numeroLote.ToString();
                txCodSit.Text = oSrv.codigoSituacao.ToString();
                txDatSit.Text = oSrv.dataSituacao.ToString();
                txRecNum.Text = oSrv.numeroRecibo;

                if (oSrv.xmlRecibo != String.Empty)
                {

                    System.Xml.XmlDocument xmlRec = new System.Xml.XmlDocument();
                    xmlRec.LoadXml(oSrv.xmlRecibo);
                    NFeUtils.PopulaTreeView(xmlRec, tvSPeRec, true);
                }
                else
                {
                    tvSPeRec.Nodes.Clear();
                    tvSPeRec.Nodes.Add("Problema ao carregar o arquivo.");
                }

                if (oSrv.xmlRetConsulta != String.Empty)
                {

                    System.Xml.XmlDocument xmlRec = new System.Xml.XmlDocument();
                    xmlRec.LoadXml(oSrv.xmlRetConsulta);
                    NFeUtils.PopulaTreeView(xmlRec, tvSPeCons, true);
                }
                else
                {
                    tvSPeRec.Nodes.Clear();
                    tvSPeRec.Nodes.Add("Problema ao carregar o arquivo.");
                }

                btAtualizarLote.Enabled = true;//(oSrv.codigoSituacao == TipoSituacaoServico.ProblemaNoEnvio);

                btnAbort.Enabled = oSrv.codigoSituacao == TipoSituacaoServico.Assinado
                                || oSrv.codigoSituacao == TipoSituacaoServico.Enviado
                                || oSrv.codigoSituacao == TipoSituacaoServico.Processado;

            }
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btAtualizarLote_Click(object sender, EventArgs e)
        {
            oFrm = new FrmInfNRec();
            oFrm.DoOnOkClick += new EventHandler(oFrm_DoOnOkClick);

            oFrm.ShowDialog();

            DoRefresh();
        }

        void oFrm_DoOnOkClick(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;
            try
            {
                //FrmInfNRec oFrm = (FrmInfNRec)((Button)sender).Parent;
                String nRec = oFrm.TextResposta.Text;


                if (String.IsNullOrEmpty(nRec))
                    throw new Exception("Informe o número do Recibo.");

                manager = Conexao.CreateManager(Program.ConAux);

                ServicoPendente oServicoPendente = (ServicoPendente)ServicoPendenteDAL.Instance.Find(oSrv.keyString, manager);
                Parametro oParam = Program.GetParametro(oServicoPendente.empresa, manager);

                //criar o recibo no disco
                RDI.NFe2.SchemaXML.NFe_v200.TRetEnviNFe oRetEnviNFe = new RDI.NFe2.SchemaXML.NFe_v200.TRetEnviNFe();
                oRetEnviNFe.tpAmb = oServicoPendente.tipoAmbiente;
                oRetEnviNFe.verAplic = "2.00";
                oRetEnviNFe.cUF = oServicoPendente.UF;
                oRetEnviNFe.cStat = "103";
                oRetEnviNFe.xMotivo = "Lote recebido com sucesso";
                oRetEnviNFe.dhRecbto = DateTime.Now;
                oRetEnviNFe.infRec = new RDI.NFe2.SchemaXML.NFe_v200.TRetEnviNFeInfRec();

                oRetEnviNFe.infRec.nRec = nRec;
                oRetEnviNFe.infRec.tMed = "1";
                XMLUtils.SalvaXML(oParam.pastaRecibo + oServicoPendente.numeroLote.ToString() + "-rec.xml", oRetEnviNFe, oServicoPendente.versao);

                oServicoPendente.xmlRecibo = XMLUtils.GetXML(oRetEnviNFe, oServicoPendente.versao);

                oServicoPendente.numeroRecibo = nRec;

                oServicoPendente.dataSituacao = DateTime.Now;
                oServicoPendente.codigoSituacao = TipoSituacaoServico.Enviado;
                //setar todas as notas desse servico como enviadas.

                NotaFiscalQry oNFeQry = new NotaFiscalQry();
                oNFeQry.empresa = oServicoPendente.empresa;
                oNFeQry.numeroLote = oServicoPendente.numeroLote.ToString();

                //somente as que foram assinadas e inseridas no lote.
                oNFeQry.codigoSituacao = TipoSituacaoNota.Assinada;// "0";

                ArrayList notasProcessadas = NotaFiscalDAL.Instance.GetInstances(oNFeQry, manager);
                foreach (NotaFiscal oNFeProc in notasProcessadas)
                {
                    oNFeProc.codigoSituacao = TipoSituacaoNota.Enviada;// 12; //Enviada
                    oNFeProc.descricaoSituacao = "Nota enviada";
                    oNFeProc.dataSituacao = oServicoPendente.dataSituacao;
                    oNFeProc.Save(manager);

                    Log oLog = new Log();
                    oLog.codigoSituacao = 13;
                    oLog.descricaoSituacao = "Nota Enviada";
                    oLog.nota = new NotaFiscal();
                    oLog.nota.chaveNota = oNFeProc.chaveNota;
                    oLog.data = DateTime.Now;
                    oLog.empresa = oServicoPendente.empresa;
                    oLog.Save(manager);
                }
                oServicoPendente.Save(manager);

                Log oLogSrv = new Log();
                oLogSrv.codigoSituacao = 998;
                oLogSrv.descricaoSituacao = "Recibo informado pelo usuario.";
                oLogSrv.nota = new NotaFiscal();
                oLogSrv.nota.chaveNota = String.Empty;
                oLogSrv.data = DateTime.Now;
                oLogSrv.empresa = oServicoPendente.empresa;
                oLogSrv.Save(manager);

                MessageBox.Show("Lote atualizado com sucesso.");
                oFrm.Close();
                oFrm.Dispose();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);

                ServicoPendente oServicoPendente = (ServicoPendente)ServicoPendenteDAL.Instance.Find(oSrv.keyString, manager);

                bool canAbort = oSrv.codigoSituacao == TipoSituacaoServico.Assinado
                                || oSrv.codigoSituacao == TipoSituacaoServico.Enviado
                                || oSrv.codigoSituacao == TipoSituacaoServico.Processado;

                if (!canAbort)
                    throw new Exception("Serviço não pode ser cancelado.");

                oServicoPendente.codigoSituacao = TipoSituacaoServico.EnvioCancelado;
                oServicoPendente.Save(manager);

                Log oLogSrv = new Log();
                oLogSrv.codigoSituacao = 998;
                oLogSrv.descricaoSituacao = "Envio foi cancelado.";
                oLogSrv.nota = new NotaFiscal();
                oLogSrv.nota.chaveNota = String.Empty;
                oLogSrv.data = DateTime.Now;
                oLogSrv.empresa = oServicoPendente.empresa;
                oLogSrv.Save(manager);

                MessageBox.Show("Lote atualizado com sucesso.");
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
    }
}