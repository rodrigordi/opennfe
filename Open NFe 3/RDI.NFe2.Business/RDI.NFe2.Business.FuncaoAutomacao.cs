//funcao automacao original
using System;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using RDI.Lince;
using System.Xml;
using RDI.NFe2.ORMAP;
using RDI.NFe2.MMCustom;
using System.Linq;
using RDI.NFe2.SchemaXML;
using System.ServiceModel;
using RDI.OpenSigner;

namespace RDI.NFe2.Business
{
    public class FuncaoAutomacao
    {
        int tempoEspera
        {
            get { return oParam.tempoEspera; }
        }
        Boolean connectionOk;
        DateTime dataUltimaConexao;
        DateTime dataUltimaConsulta;
        DateTime dataUltimaCriacaoEnvelope;
        Int32 nTentativas;
        bool _enviarErros;
        string _empresa;
        ClientEnvironment _globalManager;
        ArrayList ListaDeNotas;
        ArrayList ListaDePedidosInutilizacao;
        ArrayList ListaDePedidosCartaDeCorrecao;
        ArrayList ListaDePedidosEventoCancelamento;
        ArrayList ListaDePedidosIntegracao;

        public ClientEnvironment manager
        {
            get { return _globalManager; }
            set { _globalManager = value; }
        }

        //evitar várias consultas ao banco.
        private Parametro _param;
        public Parametro oParam
        {
            get
            {
                if (_param == null)
                {
                    ParametroQRY col = new ParametroQRY();
                    col.empresa = _empresa;
                    _param = (Parametro)ParametroDAL.Instance.GetInstances(col, manager)[0];
                }
                return _param;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oGlobalManager">deverá receber uma conexao já aberta e quem o chamou deverá fecha-la</param>
        public FuncaoAutomacao(string empresa, ClientEnvironment oGlobalManager, bool enviarErros)
        {
            _enviarErros = enviarErros;
            _empresa = empresa;
            manager = oGlobalManager;
            if (manager == null || manager.connection == null || manager.connection.State == System.Data.ConnectionState.Closed)
                throw new Exception("A conexão não esta aberta");


            //verificar se o certificado existe
            X509Certificate2 certificadox509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);

            if (certificadox509 == null || certificadox509.Subject != oParam.certificado)
                throw new Exception("Certificado não encontrado");


            connectionOk = ConsultaStatus();
            dataUltimaConexao = DateTime.Now;
            nTentativas = 0;
        }

        public void UpdateManager(ClientEnvironment oGlobalManager)
        {
            Conexao.DisposeManager(manager);

            manager = oGlobalManager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="filtro"></param>
        private void MontaLista(ref ArrayList lista, String filtro)
        {
            DirectoryInfo dir = null;
            lista = new ArrayList();
            if (!Directory.Exists(oParam.pastaEntrada))
            {
                dir = Directory.CreateDirectory(oParam.pastaEntrada);
            }
            else
            {
                dir = new DirectoryInfo(oParam.pastaEntrada);
            }

            if (dir != null)
            {
                foreach (FileInfo fileName in dir.GetFiles(filtro))
                    lista.Add(fileName.Name);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private long GetFileSize(string FileName)
        {
            FileInfo info = new FileInfo(FileName);

            if (!info.Exists)
                return -1;
            else
                return info.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="canLog"></param>
        /// <param name="FileName"></param>
        public void DoOnLoop(Boolean canLog, String FileName)
        {
            int delay = 180;

            if (connectionOk)
            {
                DoStep(canLog, FileName);
            }
            else
            {
                if (DateTime.Now.Subtract(dataUltimaConexao).TotalSeconds > delay)
                {
                    dataUltimaConexao = DateTime.Now;
                    connectionOk = ConsultaStatus();

                    if (connectionOk)
                        nTentativas = 0;
                    else
                        nTentativas++;

                    CriaLog(996, "Tentativa " + nTentativas.ToString() + ". A conexão com a SEFAZ esta indisponível. Nova consulta em " + delay.ToString() + " segundos.");
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="canLog"></param>
        /// <param name="FileName"></param>
        private void DoStep(Boolean canLog, String FileName)
        {
            try
            {
                #region-------------------------------Monta lote------------------------------------//
                MontaLista(ref ListaDeNotas, "NFe??????" + _empresa + "*.xml");//filtrar pela empresa

                if ((((DateTime.Now.Minute * 60 + DateTime.Now.Second) % oParam.tempoParaLote == 0) ||
                       (ListaDeNotas.Count >= oParam.qtdeNotasPorLotes)) && (ListaDeNotas.Count != 0))
                {
                    if (ListaDeNotas.Count > oParam.qtdeNotasPorLotes)
                        CriaEnvelope(oParam.qtdeNotasPorLotes);
                    else
                        CriaEnvelope(ListaDeNotas.Count);

                }
                #endregion-------------------------------Monta lote------------------------------------//

                #region -------------------------------Inutiliza notas------------------------------------//
                MontaLista(ref ListaDePedidosInutilizacao, "pedInutNFe??????" + _empresa + "*.xml");//filtrar pela empresa

                if (ListaDePedidosInutilizacao.Count > 0)
                {
                    foreach (String origem in ListaDePedidosInutilizacao)
                    {
                        ITInutNFe oInut = null;
                        try
                        {

                            try
                            {
                                MMCustom.MMUtils.ConfirmaRecebimentoPedidoInutilizacaoNFe(origem);
                            }
                            catch { }

                            oInut = (ITInutNFe)XMLUtils.CarregaXML_HD(oParam.pastaEntrada + origem, oParam.versao, "TInutNFe");

                            String cStat = String.Empty;
                            String xMotivo = String.Empty;
                            String nProt = String.Empty;

                            InutilizaNumeracao(oInut, ref cStat, ref xMotivo, oParam.versao);

                            if (cStat == String.Empty && xMotivo == String.Empty) //recebeu resposta da sefaz
                                throw new Exception("Não foi possível executar Inutilização. Consulte o LOG do sistema.");

                            if (cStat == "102")
                            {
                                //atualizar registro

                                ITRetInutNFe oRetInut = (ITRetInutNFe)
                                    XMLUtils.CarregaXML_HD(oParam.pastaRecibo + oInut.infInut.Id + "-inu.xml", oParam.versao, "TRetInutNFe");

                                oInut = (ITInutNFe)XMLUtils.CarregaXML_HD(oParam.pastaRecibo + oInut.infInut.Id + "-ped-inu.xml", oParam.versao, "TInutNFe");

                                nProt = oRetInut.infInut.nProt;

                                Int32 notaInicial = Int32.Parse(oInut.infInut.nNFIni);
                                Int32 notaFinal = Int32.Parse(oInut.infInut.nNFFin);

                                while (notaInicial <= notaFinal)
                                {
                                    NotaInutilizada oNota = new NotaInutilizada();
                                    oNota.numeroNota = notaInicial.ToString();

                                    //setar a serie da nota
                                    oNota.serieNota = oInut.infInut.serie;
                                    oNota.data = DateTime.Today;
                                    oNota.empresa = oParam.empresa;

                                    oNota.XMLResposta = XMLUtils.GetXML(oRetInut, oParam.versao);
                                    oNota.XMLPedido = XMLUtils.GetXML(oInut, oParam.versao);

                                    oNota.Save(manager);

                                    notaInicial++;
                                }
                            }

                            try
                            {
                                MMCustom.MMUtils.ProcessaResultadoPedidoInutilizacaoNFe(origem, cStat, xMotivo, nProt);
                            }
                            catch { }

                        }
                        catch (Exception exInutilizacao)
                        {
                            try
                            {
                                MMCustom.MMUtils.ErroProcessandoPedidoInutilizacaoNFe(origem, exInutilizacao);
                            }
                            catch { }
                        }
                        finally
                        {
                            //apagar o arquivo
                            if (File.Exists(oParam.pastaEntrada + origem))
                            {
                                File.Delete(oParam.pastaEntrada + origem);
                            }
                        }
                    }
                }
                #endregion-------------------------------Inutiliza notas------------------------------------//

                #region --------------------------envia carta de correção--------------------------

                MontaLista(ref ListaDePedidosCartaDeCorrecao, "CCe_??????" + _empresa + "*.xml"); //arquivo do tipo Evento Carta de correção
                if (ListaDePedidosCartaDeCorrecao.Count > 0)
                {
                    foreach (String origem in ListaDePedidosCartaDeCorrecao)
                    {
                        string xmlEvento = string.Empty;
                        string xmlRetorno = string.Empty;
                        TipoSituacaoEvento situacao = TipoSituacaoEvento.NaoExecutadoErro;
                        int numeroNovoLote = 0;
                        ITEvento oEvento = null;
                        NotaFiscal oNotaFiscal = null;
                        NotaFiscalQry oNotaFiscalQry = null;
                        string nomeArquivoAssinado = string.Empty;


                        try
                        {

                            try
                            {
                                MMCustom.MMUtils.ConfirmaRecebimentoPedidoCartaCorrecao(origem);
                            }
                            catch { }

                            #region Pegar o ultimo lote criado.
                            EventoQry oTbEventoQry = new EventoQry();
                            oTbEventoQry.empresa = oParam.empresa;
                            numeroNovoLote = EventoDAL.Instance.GetMax(oTbEventoQry, manager);
                            #endregion

                            oNotaFiscalQry = new NotaFiscalQry();

                            #region verificar se é possivel ler o arquivo e apagar arquivo de origem
                            try
                            {
                                using (StreamReader SR = File.OpenText(oParam.pastaEntrada + origem))
                                {
                                    xmlEvento = SR.ReadToEnd();
                                    SR.Close();
                                }
                                GC.Collect();

                                //apaga arquivo sem assinatura : origem
                                if (File.Exists(oParam.pastaEntrada + origem))
                                    File.Delete(oParam.pastaEntrada + origem);
                            }
                            catch (Exception ex)
                            {
                                situacao = TipoSituacaoEvento.NaoExecutadoErro;
                                throw new Exception("Não foi possível abrir o arquivo : " + oParam.pastaEntrada + origem + " > " + ex.Message);
                            }
                            #endregion

                            #region verificar serializacao antes de assinar jogar na classe de NFe
                            try
                            {
                                oEvento = (ITEvento)XMLUtils.CarregaXML_STR(xmlEvento, oParam.versao, "TEvento");

                                oNotaFiscalQry.empresa = oParam.empresa;// oEvento.infEvento.Item;
                                oNotaFiscalQry.chaveNota = "NFe" + oEvento.infEvento.chNFe;
                                nomeArquivoAssinado = oParam.pastaRecibo + oEvento.infEvento.Id + "-ev.xml";

                                XMLUtils.SalvaXML(nomeArquivoAssinado, oEvento, oParam.versao);
                                oEvento = null;
                            }
                            catch (Exception ex)
                            {
                                situacao = TipoSituacaoEvento.ErroDesearilizacao;
                                throw new Exception("Não foi possivel Deserializar a nota no Objeto TEvento. - " + ex.Message);
                            }
                            #endregion

                            ArrayList notas = NotaFiscalDAL.Instance.GetInstances(oNotaFiscalQry, manager);
                            if (notas.Count == 0)
                                throw new Exception("Nota fiscal não localizada.");

                            bool tentativaLocalizada = false;
                            for (int i = 0; i < notas.Count; i++)
                            {
                                oNotaFiscal = (NotaFiscal)notas[i];
                                if (oNotaFiscal.codigoSituacao == TipoSituacaoNota.Aprovada || oNotaFiscal.codigoSituacao == TipoSituacaoNota.Impressa)//nota aprovada
                                {
                                    tentativaLocalizada = true;
                                    break;
                                }
                            }
                            if (!tentativaLocalizada)
                                throw new Exception("NFe localizada, mas não esta aprovada.");

                            //assinar evento.
                            X509Certificate2 certificadoX509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);
                            var retornoAssinatura = NFeUtils.AssinaXML(nomeArquivoAssinado, "infEvento", certificadoX509, oParam.versao);
                            certificadoX509 = null;

                            //apaga arquivo sem assinatura : -ev.xml
                            if (File.Exists(nomeArquivoAssinado))
                                File.Delete(nomeArquivoAssinado);
                            nomeArquivoAssinado = nomeArquivoAssinado.Substring(0, nomeArquivoAssinado.Length - 7) + "-ass-env.xml";

                            //avaliar retorno da assinatura
                            if (retornoAssinatura.codigoRetorno != TRetornoAssinatura.Assinada)
                            {
                                throw new Exception("Não foi possível assinar o arquivo : ERRO" + retornoAssinatura.codigoRetorno.ToString());
                            }

                            //arquivo esta assinado
                            //carregar o xml assinado
                            oEvento = (ITEvento)XMLUtils.CarregaXML_HD(nomeArquivoAssinado, oParam.versao, "TEvento");
                            xmlEvento = XMLUtils.GetXML(oEvento, oParam.versao);

                            RecepcaoEvento(oEvento, numeroNovoLote, ref xmlRetorno, oParam.versao);

                            if (string.IsNullOrEmpty(xmlRetorno)) //recebeu resposta da sefaz
                                throw new Exception("Não foi possível executar RecepcaoEvento-CCe. Consulte o LOG do sistema.");

                            ITRetEnvEvento oRetEnvEvento = (ITRetEnvEvento)XMLUtils.CarregaXML_STR(xmlRetorno, oParam.versao, "TRetEnvEvento");

                            if (oRetEnvEvento.cStat == "128")
                            {

                                //Recebido pelo Sistema de Registro de Eventos, com vinculação do 
                                //    evento na NF-e, o Evento será armazenado no repositório do Sistema de Registro de Eventos 
                                //    com a vinculação do Evento à respectiva NF-e (cStat=135);

                                //Recebido pelo Sistema de Registro de Eventos – vinculação do 
                                //    evento à respectiva NF-e prejudicada – o Evento será armazenado no repositório do Sistema 
                                //    de Registro de Eventos, a vinculação do evento à respectiva NF-e fica prejudicada face a 
                                //    inexistência da NF-e no momento do recebimento do Evento (cStat=136);

                                if (oRetEnvEvento.retEvento != null &&
                                    oRetEnvEvento.retEvento[0] != null &&
                                    oRetEnvEvento.retEvento[0].infEvento != null &&
                                    (oRetEnvEvento.retEvento[0].infEvento.cStat == "135" || oRetEnvEvento.retEvento[0].infEvento.cStat == "136"))
                                {
                                    if (oRetEnvEvento.retEvento[0].infEvento.cStat == "135")
                                        situacao = TipoSituacaoEvento.FinalizadoAprovado135;
                                    else
                                        situacao = TipoSituacaoEvento.FinalizadoAprovado136;

                                    //gerar o arquivo de processo

                                    //gerar evento
                                    var oProcEvento = (ITProcEvento)XMLUtils.XMLFactory(oParam.versao, "TProcEvento");
                                    oProcEvento.evento = oEvento;
                                    oProcEvento.retEvento = oRetEnvEvento.retEvento[0];
                                    oProcEvento.versao = "1.00";
                                    //salvar arquivo na caixa de saida

                                    XMLUtils.SalvaXML(oParam.pastaSaida + oEvento.infEvento.Id + "_v1.00-procCCe.xml", oProcEvento, oParam.versao);
                                }
                                else
                                {
                                    situacao = TipoSituacaoEvento.FinalizadoComRejeicaoRegras;
                                }
                            }
                            else
                            {
                                situacao = TipoSituacaoEvento.FinalizadoComRejeicaoLote;
                            }

                            try
                            {
                                MMCustom.MMUtils.ProcessaResultadoPedidoCartaCorrecao(origem, oRetEnvEvento.cStat, oRetEnvEvento.xMotivo);
                            }
                            catch { }

                        }
                        catch (Exception exCartaCorrecao)
                        {
                            try
                            {
                                MMCustom.MMUtils.ErroProcessandoPedidoCartaCorrecao(origem, exCartaCorrecao);
                            }
                            catch { }

                            CriaLog((sbyte)situacao, "Processamento Carta de Correção", exCartaCorrecao);
                        }

                        //registrar o evento no banco
                        try
                        {
                            //apagar o arquivo
                            if (File.Exists(oParam.pastaEntrada + origem))
                            {
                                File.Delete(oParam.pastaEntrada + origem);
                            }

                            if (numeroNovoLote != 0 && oNotaFiscal != null)
                            {
                                //registrar 
                                //criar registro do TEvento
                                Evento oTbEvento = new Evento();
                                oTbEvento.XMLPedido = xmlEvento;
                                oTbEvento.XMLResposta = xmlRetorno;
                                oTbEvento.codigoSituacao = situacao;
                                oTbEvento.tpEvento = TEventoInfEventoTpEvento.CartaCorrecao;

                                oTbEvento.id = numeroNovoLote;
                                oTbEvento.empresa = oNotaFiscal.empresa;
                                oTbEvento.chaveNota = oNotaFiscal.chaveNota;
                                oTbEvento.numeroLote = oNotaFiscal.numeroLote;
                                oTbEvento.Save(manager);

                                //gerar arquivo para danfe.exe
                                if (oEvento != null && oNotaFiscal != null)
                                {
                                    #region imprimir evento
                                    if (oTbEvento.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado135 ||
                                        oTbEvento.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado136)
                                    {

                                        //tratar envio de xml para destinatário.
                                        string sufixo = "_v1.00-procCCe.xml";
                                        String nomeArquivo = oEvento.infEvento.Id + sufixo;

                                        ITNFe oNFeXML = (ITNFe)XMLUtils.CarregaXML_STR(oNotaFiscal.xmlNota, oParam.versao, "TNFe");

                                        //salvar TXT com dados complementares
                                        if (File.Exists(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt")))
                                            File.Delete(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt"));

                                        //gerar arquivo TXT com o email do destinatário
                                        using (StreamWriter oSW = File.CreateText(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt")))
                                        {
                                            //dados destinatarios
                                            oSW.WriteLine(oNFeXML.infNFe.dest.xNome);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xLgr + ", " + oNFeXML.infNFe.dest.enderDest.nro);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xBairro);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.CEP);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xMun);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.fone);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.UF);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.IE);

                                            //dados emitente
                                            oSW.WriteLine(oNFeXML.infNFe.emit.xNome);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xLgr + ", " + oNFeXML.infNFe.emit.enderEmit.nro);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xBairro);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.CEP);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xMun);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.fone);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.UF);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.IE);

                                            oSW.WriteLine(oNFeXML.infNFe.ide.nNF);
                                            oSW.WriteLine(oNFeXML.infNFe.ide.serie);
                                            oSW.WriteLine(oNFeXML.infNFe.ide.dEmi);

                                            oSW.Close();
                                        }
                                        GC.Collect();

                                        oNFeXML = null;

                                        NFeUtils.GeraArquivoProcEventoNFe(oTbEvento, oParam.pastaImpressao + nomeArquivo, oNotaFiscal.versao);
                                    }
                                    #endregion
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            CriaLog(999, "Falha ao registrar evento Carta de Correção", ex);
                        }
                    }
                }

                #endregion ------------------------------------------------------------------------

                #region --------------------------envia evento cancelamento--------------------------

                MontaLista(ref ListaDePedidosEventoCancelamento, "evtCanc_??????" + _empresa + "*.xml"); //arquivo do tipo Evento Cancelamento
                if (ListaDePedidosEventoCancelamento.Count > 0)
                {
                    foreach (String origem in ListaDePedidosEventoCancelamento)
                    {
                        string xmlEvento = string.Empty;
                        string xmlRetorno = string.Empty;
                        TipoSituacaoEvento situacao = TipoSituacaoEvento.NaoExecutadoErro;
                        int numeroNovoLote = 0;
                        ITEvento oEvento = null;
                        NotaFiscal oNotaFiscal = null;
                        NotaFiscalQry oNotaFiscalQry = null;
                        string nomeArquivoAssinado = string.Empty;


                        try
                        {

                            try
                            {
                                MMCustom.MMUtils.ConfirmaRecebimentoPedidoEventoCancelamento(origem);
                            }
                            catch { }

                            #region Pegar o ultimo lote criado.
                            EventoQry oTbEventoQry = new EventoQry();
                            oTbEventoQry.empresa = oParam.empresa;
                            numeroNovoLote = EventoDAL.Instance.GetMax(oTbEventoQry, manager);
                            #endregion

                            oNotaFiscalQry = new NotaFiscalQry();

                            #region verificar se é possivel ler o arquivo e apagar arquivo de origem
                            try
                            {
                                using (StreamReader SR = File.OpenText(oParam.pastaEntrada + origem))
                                {
                                    xmlEvento = SR.ReadToEnd();
                                    SR.Close();
                                }
                                GC.Collect();

                                //apaga arquivo sem assinatura : origem
                                if (File.Exists(oParam.pastaEntrada + origem))
                                    File.Delete(oParam.pastaEntrada + origem);
                            }
                            catch (Exception ex)
                            {
                                situacao = TipoSituacaoEvento.NaoExecutadoErro;
                                throw new Exception("Não foi possível abrir o arquivo : " + oParam.pastaEntrada + origem + " > " + ex.Message);
                            }
                            #endregion

                            #region verificar serializacao antes de assinar jogar na classe de NFe
                            try
                            {
                                oEvento = (ITEvento)XMLUtils.CarregaXML_STR(xmlEvento, oParam.versao, "TEvento");

                                oNotaFiscalQry.empresa = oParam.empresa;
                                oNotaFiscalQry.chaveNota = "NFe" + oEvento.infEvento.chNFe;
                                nomeArquivoAssinado = oParam.pastaRecibo + oEvento.infEvento.Id + "-ev.xml";

                                XMLUtils.SalvaXML(nomeArquivoAssinado, oEvento, oParam.versao);
                                oEvento = null;
                            }
                            catch (Exception ex)
                            {
                                situacao = TipoSituacaoEvento.ErroDesearilizacao;
                                throw new Exception("Não foi possivel Deserializar a nota no Objeto TEvento. - " + ex.Message);
                            }
                            #endregion

                            ArrayList notas = NotaFiscalDAL.Instance.GetInstances(oNotaFiscalQry, manager);
                            if (notas.Count == 0)
                                throw new Exception("Nota fiscal não localizada.");

                            bool tentativaLocalizada = false;
                            for (int i = 0; i < notas.Count; i++)
                            {
                                oNotaFiscal = (NotaFiscal)notas[i];
                                if (oNotaFiscal.codigoSituacao == TipoSituacaoNota.Aprovada || oNotaFiscal.codigoSituacao == TipoSituacaoNota.Impressa)//nota aprovada
                                {
                                    tentativaLocalizada = true;
                                    break;
                                }
                            }
                            if (!tentativaLocalizada)
                                throw new Exception("NFe localizada, mas não esta aprovada.");


                            //assinar evento.
                            X509Certificate2 certificadoX509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);
                            var retornoAssinatura = NFeUtils.AssinaXML(nomeArquivoAssinado, "infEvento", certificadoX509, oParam.versao);
                            certificadoX509 = null;

                            //apaga arquivo sem assinatura : -ev.xml
                            if (File.Exists(nomeArquivoAssinado))
                                File.Delete(nomeArquivoAssinado);
                            nomeArquivoAssinado = nomeArquivoAssinado.Substring(0, nomeArquivoAssinado.Length - 7) + "-ass-env.xml";

                            //avaliar retorno da assinatura
                            if (retornoAssinatura.codigoRetorno != TRetornoAssinatura.Assinada)
                            {
                                throw new Exception("Não foi possível assinar o arquivo : ERRO" + retornoAssinatura.codigoRetorno.ToString());
                            }

                            //arquivo esta assinado
                            //carregar o xml assinado
                            oEvento = (ITEvento)XMLUtils.CarregaXML_HD(nomeArquivoAssinado, oParam.versao, "TEvento");
                            xmlEvento = XMLUtils.GetXML(oEvento, oParam.versao);

                            RecepcaoEvento(oEvento, numeroNovoLote, ref xmlRetorno, oParam.versao);

                            if (string.IsNullOrEmpty(xmlRetorno)) //recebeu resposta da sefaz
                                throw new Exception("Não foi possível executar RecepcaoEvento-Cancelamento. Consulte o LOG do sistema.");

                            ITRetEnvEvento oRetEnvEvento = (ITRetEnvEvento)XMLUtils.CarregaXML_STR(xmlRetorno, oParam.versao, "TRetEnvEvento");

                            if (oRetEnvEvento.cStat == "128")
                            {

                                //Recebido pelo Sistema de Registro de Eventos, com vinculação do 
                                //    evento na NF-e, o Evento será armazenado no repositório do Sistema de Registro de Eventos 
                                //    com a vinculação do Evento à respectiva NF-e (cStat=135);

                                //Recebido pelo Sistema de Registro de Eventos – vinculação do 
                                //    evento à respectiva NF-e prejudicada – o Evento será armazenado no repositório do Sistema 
                                //    de Registro de Eventos, a vinculação do evento à respectiva NF-e fica prejudicada face a 
                                //    inexistência da NF-e no momento do recebimento do Evento (cStat=136);

                                if (oRetEnvEvento.retEvento != null &&
                                    oRetEnvEvento.retEvento[0] != null &&
                                    oRetEnvEvento.retEvento[0].infEvento != null &&
                                    (oRetEnvEvento.retEvento[0].infEvento.cStat == "135"
                                    || oRetEnvEvento.retEvento[0].infEvento.cStat == "136"
                                    || oRetEnvEvento.retEvento[0].infEvento.cStat == "155"))
                                {
                                    if (oRetEnvEvento.retEvento[0].infEvento.cStat == "135")
                                        situacao = TipoSituacaoEvento.FinalizadoAprovado135;
                                    else if (oRetEnvEvento.retEvento[0].infEvento.cStat == "136")
                                        situacao = TipoSituacaoEvento.FinalizadoAprovado136;
                                    else if (oRetEnvEvento.retEvento[0].infEvento.cStat == "155")
                                        situacao = TipoSituacaoEvento.FinalizadoAprovado155;

                                    //gerar o arquivo de processo

                                    //atualizar registro NFe
                                    oNotaFiscal.codigoSituacao = TipoSituacaoNota.Cancelada;// 16;
                                    oNotaFiscal.descricaoSituacao = "Nota Cancelada";
                                    //TODO : REVER
                                    oNotaFiscal.cStat = "101";
                                    //TODO : REVER
                                    oNotaFiscal.xMotivo = "CANCELAMENTO NFE HOMOLOGADO";
                                    oNotaFiscal.nProtCancelamento = oRetEnvEvento.retEvento[0].infEvento.nProt;

                                    oNotaFiscal.Save(manager);

                                    //gerar evento
                                    var oProcEvento = (ITProcEvento)XMLUtils.XMLFactory(oParam.versao, "TProcEvento");
                                    oProcEvento.evento = oEvento;
                                    oProcEvento.retEvento = oRetEnvEvento.retEvento[0];
                                    oProcEvento.versao = "1.00";
                                    //salvar arquivo na caixa de saida

                                    XMLUtils.SalvaXML(oParam.pastaSaida + oEvento.infEvento.Id + "_v1.00-procEventoCancNFe.xml", oProcEvento, oParam.versao);

                                    //integracao - aprovado
                                    NFeUtils.GeraRetornoCancelamentoNFe(oNotaFiscal.chaveNota, oRetEnvEvento.retEvento[0].infEvento.cStat, oRetEnvEvento.retEvento[0].infEvento.xMotivo, oParam.pastaSaida);

                                }
                                else
                                {
                                    situacao = TipoSituacaoEvento.FinalizadoComRejeicaoRegras;

                                    if (oRetEnvEvento.retEvento != null && oRetEnvEvento.retEvento[0] != null && oRetEnvEvento.retEvento[0].infEvento != null)
                                        //integracao - rejeitado pelo pedidos
                                        NFeUtils.GeraRetornoCancelamentoNFe(oNotaFiscal.chaveNota, oRetEnvEvento.retEvento[0].infEvento.cStat, oRetEnvEvento.retEvento[0].infEvento.xMotivo, oParam.pastaSaida);
                                    else
                                        //integracao pelo lote
                                        NFeUtils.GeraRetornoCancelamentoNFe(oNotaFiscal.chaveNota, oRetEnvEvento.cStat, oRetEnvEvento.xMotivo, oParam.pastaSaida);
                                }
                            }
                            else
                            {
                                situacao = TipoSituacaoEvento.FinalizadoComRejeicaoLote;

                                //integracao - rejeicao do lote
                                NFeUtils.GeraRetornoCancelamentoNFe(oNotaFiscal.chaveNota, oRetEnvEvento.cStat, oRetEnvEvento.xMotivo, oParam.pastaSaida);
                            }

                            try
                            {
                                //31032016 : alteração para enviar a chave de acesso da NFe
                                if (oRetEnvEvento.retEvento != null && oRetEnvEvento.retEvento[0] != null && oRetEnvEvento.retEvento[0].infEvento != null)
                                    //integracao - rejeitado pelo pedidos
                                    MMCustom.MMUtils.ProcessaResultadoPedidoEventoCancelamento(oNotaFiscal.chaveNota, oRetEnvEvento.retEvento[0].infEvento.cStat, oRetEnvEvento.retEvento[0].infEvento.xMotivo, oRetEnvEvento.retEvento[0].infEvento.nProt); //incluido o nProt
                                else
                                    //integracao pelo lote
                                    MMCustom.MMUtils.ProcessaResultadoPedidoEventoCancelamento(oNotaFiscal.chaveNota, oRetEnvEvento.cStat, oRetEnvEvento.xMotivo, string.Empty);
                            }
                            catch { }

                        }
                        catch (Exception exEventoCancelamento)
                        {
                            //integracao - rejeicao do lote
                            NFeUtils.GeraRetornoCancelamentoNFe(null, "0", "Falha no cancelamento - " + exEventoCancelamento.Message, oParam.pastaSaida, origem);

                            try
                            {
                                MMCustom.MMUtils.ErroProcessandoPedidoEventoCancelamento(origem, exEventoCancelamento);
                            }
                            catch { }

                            CriaLog((sbyte)situacao, "Processamento Cancelamento", exEventoCancelamento);
                        }

                        //registrar o evento no banco
                        try
                        {
                            //apagar o arquivo
                            if (File.Exists(oParam.pastaEntrada + origem))
                            {
                                File.Delete(oParam.pastaEntrada + origem);
                            }

                            if (numeroNovoLote != 0 && oNotaFiscal != null)
                            {
                                //registrar 
                                //criar registro do TEvento
                                Evento oTbEvento = new Evento();
                                oTbEvento.XMLPedido = xmlEvento;
                                oTbEvento.XMLResposta = xmlRetorno;
                                oTbEvento.codigoSituacao = situacao;
                                oTbEvento.tpEvento = TEventoInfEventoTpEvento.Cancelamento;

                                oTbEvento.id = numeroNovoLote;
                                oTbEvento.empresa = oNotaFiscal.empresa;
                                oTbEvento.chaveNota = oNotaFiscal.chaveNota;
                                oTbEvento.numeroLote = oNotaFiscal.numeroLote;
                                oTbEvento.Save(manager);

                                //gerar arquivo para danfe.exe
                                if (oEvento != null && oNotaFiscal != null)
                                {
                                    #region imprimir evento
                                    if (oTbEvento.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado135 ||
                                        oTbEvento.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado136 ||
                                        oTbEvento.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado155)
                                    {
                                        //tratar envio de xml para destinatário.
                                        string sufixo = "_v1.00-procEventoCancNFe.xml";
                                        String nomeArquivo = oEvento.infEvento.Id + sufixo;

                                        ITNFe oNFeXML = (ITNFe)
                                            XMLUtils.CarregaXML_STR(oNotaFiscal.xmlNota, oNotaFiscal.versao, "TNFe");

                                        //salvar TXT com dados complementares
                                        if (File.Exists(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt")))
                                            File.Delete(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt"));

                                        //gerar arquivo TXT com o email do destinatário
                                        using (StreamWriter oSW = File.CreateText(oParam.pastaImpressao + nomeArquivo.Replace(".xml", ".txt")))
                                        {
                                            //dados destinatarios
                                            oSW.WriteLine(oNFeXML.infNFe.dest.xNome);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xLgr + ", " + oNFeXML.infNFe.dest.enderDest.nro);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xBairro);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.CEP);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.xMun);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.fone);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.enderDest.UF);
                                            oSW.WriteLine(oNFeXML.infNFe.dest.IE);

                                            //dados emitente
                                            oSW.WriteLine(oNFeXML.infNFe.emit.xNome);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xLgr + ", " + oNFeXML.infNFe.emit.enderEmit.nro);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xBairro);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.CEP);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.xMun);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.fone);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.enderEmit.UF);
                                            oSW.WriteLine(oNFeXML.infNFe.emit.IE);

                                            oSW.WriteLine(oNFeXML.infNFe.ide.nNF);
                                            oSW.WriteLine(oNFeXML.infNFe.ide.serie);

                                            oSW.Close();
                                        }
                                        GC.Collect();

                                        oNFeXML = null;

                                        NFeUtils.GeraArquivoProcEventoNFe(oTbEvento, oParam.pastaImpressao + nomeArquivo, oNotaFiscal.versao);
                                    }
                                    #endregion
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            CriaLog(999, "Falha ao registrar evento Cancelamento", ex);
                        }
                    }

                }

                #endregion ------------------------------------------------------------------------

                if (DateTime.Now.Subtract(dataUltimaConsulta).TotalSeconds > tempoEspera || dataUltimaCriacaoEnvelope > dataUltimaConsulta)
                {
                    dataUltimaConsulta = DateTime.Now;

                    #region Funções que consultam tabela de servicos

                    #region-------------------------------Envia lote------------------------------------//
                    //if ((DateTime.Now.Minute * 60 + DateTime.Now.Second) % 12 == 0)
                    {
                        //buscar os servicos pendentes
                        ServicoPendenteQry oSrvQry = new ServicoPendenteQry();
                        oSrvQry.codigoSituacao = ((sbyte)TipoSituacaoServico.Assinado).ToString();
                        oSrvQry.empresa = oParam.empresa;

                        ArrayList servicos = ServicoPendenteDAL.Instance.GetInstances(oSrvQry, manager);
                        foreach (ServicoPendente oServicoPendente in servicos)
                        {
                            EnviaEnvelope(oServicoPendente);
                        }

                    }//if envio de lotes
                    #endregion-------------------------------Envia lote------------------------------------//

                    #region-----------------------------ConsultaEnvelopes-------------------------------//
                    //if ((DateTime.Now.Minute * 60 + DateTime.Now.Second) % 13 == 0)
                    {
                        //buscar os servicos pendentes
                        ServicoPendenteQry oSrvQry = new ServicoPendenteQry();
                        oSrvQry.codigoSituacao = ((sbyte)TipoSituacaoServico.Enviado).ToString();
                        oSrvQry.empresa = oParam.empresa;

                        ArrayList servicos = ServicoPendenteDAL.Instance.GetInstances(oSrvQry, manager);
                        foreach (ServicoPendente oServicoPendente in servicos)
                        {
                            if (DateTime.Now.Subtract(oServicoPendente.dataSituacao).TotalSeconds > 15) //aguardar pelo menos 15 segundos
                            {
                                ConsultaEnvelope(oServicoPendente);
                            }
                        }

                    }//if consulta envelope
                    #endregion----------------------------ConsultaEnvelopes--------------------------------//

                    #region-------------------------------ImprimeDANFe----------------------------------//
                    //if ((DateTime.Now.Minute * 60 + DateTime.Now.Second) % 15 == 0)
                    {
                        ServicoPendenteQry oSrvQry = new ServicoPendenteQry();
                        oSrvQry.codigoSituacao = ((sbyte)TipoSituacaoServico.Processado).ToString();
                        oSrvQry.empresa = oParam.empresa;

                        ArrayList servicos = ServicoPendenteDAL.Instance.GetInstances(oSrvQry, manager);
                        foreach (ServicoPendente oServicoPendente in servicos)
                        {
                            FinalizaServicos(oServicoPendente);
                        }


                    }//if imprime nota
                    #endregion-------------------------------ImprimeDANFe----------------------------------//

                    #region-------------------------------ReimpressaoDANFe----------------------------------//
                    MontaLista(ref ListaDePedidosIntegracao, "integracao*.xml"); //arquivo do tipo Integracao
                    if (ListaDePedidosIntegracao.Count > 0)
                    {
                        foreach (String origem in ListaDePedidosIntegracao)
                        {
                            string xmlIntegracao = string.Empty;

                            SchemaXML.TIntegracao oIntegracao;

                            NotaFiscal oNotaFiscal = null;
                            NotaFiscalQry oNotaFiscalQry = null;

                            try
                            {
                                oNotaFiscalQry = new NotaFiscalQry();

                                #region verificar se é possivel ler o arquivo e apagar arquivo de origem
                                try
                                {
                                    using (StreamReader SR = File.OpenText(oParam.pastaEntrada + origem))
                                    {
                                        xmlIntegracao = SR.ReadToEnd();
                                        SR.Close();
                                    }
                                    GC.Collect();

                                    //apaga arquivo sem assinatura : origem
                                    if (File.Exists(oParam.pastaEntrada + origem))
                                        File.Delete(oParam.pastaEntrada + origem);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception("Não foi possível abrir o arquivo : " + oParam.pastaEntrada + origem + " > " + ex.Message);
                                }
                                #endregion

                                #region verificar serializacao
                                try
                                {
                                    oIntegracao = (SchemaXML.TIntegracao)XMLUtils.CarregaXML_STR(xmlIntegracao, VersaoXML.Integracao, "TIntegracao");

                                    oNotaFiscalQry.empresa = oParam.empresa;
                                    oNotaFiscalQry.chaveNota = "NFe" + ((SchemaXML.TImpressao)oIntegracao.item).chNFe;

                                    oIntegracao = null;
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception("Não foi possivel Deserializar a nota no Objeto TEvento. - " + ex.Message);
                                }
                                #endregion

                                ArrayList notas = NotaFiscalDAL.Instance.GetInstances(oNotaFiscalQry, manager);
                                if (notas.Count == 0)
                                    throw new Exception("Nota fiscal não localizada.");

                                oNotaFiscal = (NotaFiscal)notas[0];

                                if (oNotaFiscal.codigoSituacao != TipoSituacaoNota.Aprovada// 13
                                    && oNotaFiscal.codigoSituacao != TipoSituacaoNota.Impressa// 15
                                    )//nota nao aprovada
                                    throw new Exception("NFe localizada, mas não esta aprovada.");

                                NFeUtils.ImprimeDANFe(oNotaFiscal, oParam, manager);
                                CriaLog(4, "Arquivo enviado para Pasta de Impressão com sucesso!", oNotaFiscal.chaveNota);

                            }
                            catch (Exception exIntegracao)
                            {
                                CriaLog(995, "Processamento de Integração", exIntegracao);
                            }
                            finally
                            {
                                //apagar o arquivo
                                if (File.Exists(oParam.pastaEntrada + origem))
                                {
                                    File.Delete(oParam.pastaEntrada + origem);
                                }
                            }
                        }

                    }
                    #endregion------------------------------ReimpressaoDANFe---------------------------------//

                    #endregion
                }

            }
            catch (Exception ex)
            {
                CriaLog(999, "Função automação (Geral)", ex);
            }
        }

        /// <summary>
        /// versao 2.0 - ok
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="mensagem"></param>
        /// <param name="chave"></param>
        public void CriaLog(int codigo, string mensagem, string chaveNFe = "")
        {
            try
            {
                Log oLog = new Log();

                oLog.codigoSituacao = codigo;
                //depois de alterado o tamanho no banco.
                //será varchar max
                //if (situacao.Length < 255)
                oLog.descricaoSituacao = mensagem;
                //else
                //    oLog.descricaoSituacao = situacao.Substring(0, 255);

                oLog.nota = new NotaFiscal();
                oLog.nota.chaveNota = chaveNFe;
                oLog.data = DateTime.Now;
                oLog.empresa = oParam.empresa;
                oLog.Save(manager);
            }
            catch
            {
            }
        }

        public void CriaLog(int codigo, string origem, Exception ex, string chaveNFe = "")
        {
            string situacao = ex.Message;
            if (ex.InnerException != null)
            {
                situacao += " InnerException: " + ex.InnerException.Message;
            }


            if (_enviarErros)
            {
                try
                {
                    //Inicializar uma thread que irá fazer o envio do erro para nossa base de dados
                    System.Threading.ParameterizedThreadStart opThEnviarErro = new System.Threading.ParameterizedThreadStart(ReportarErro);
                    var thEnviarErro = new System.Threading.Thread(opThEnviarErro);
                    var err = new Erro();
                    err.codigo = codigo;
                    err.Excecao = ex;
                    err.Origem = origem;
                    err.chaveNFe = chaveNFe;

                    thEnviarErro.Start(err);

                }
                catch
                {

                }
            }

            CriaLog(codigo, origem + " : " + situacao, chaveNFe);
        }

        /// <summary>
        /// Em Desenvolvimento
        /// </summary>
        /// <param name="pasta"></param>
        /// <param name="arquivo"></param>
        public static void Imprimir(string pasta, string arquivo)
        {
            try
            {
                //irá fazer o envio do erro para nossa base de dados
                BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
                String baseAddress = "http://rdibrserver.cloudapp.net:888/nfeservice.svc";
                EndpointAddress remoteAddress = new EndpointAddress(baseAddress);
                using (var proxy = new RDI.NFe2.Business.SOA.InfeserviceClient(basicHttpBinding, remoteAddress))
                {
                    //byte[] pdf = null;
                    //var ret = proxy.ImprimirNFe(arquivo, pasta, ref pdf);
                }
            }
            catch //(Exception ex)
            {

            }
        }

        private void ReportarErro(object param)
        {
            try
            {
                //irá fazer o envio do erro para nossa base de dados
                var err = (Erro)param;
                BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
                String baseAddress = "http://rdibrserver.cloudapp.net:888/nfeservice.svc";
                EndpointAddress remoteAddress = new EndpointAddress(baseAddress);
                using (var proxy = new RDI.NFe2.Business.SOA.InfeserviceClient(basicHttpBinding, remoteAddress))
                {
                    var msg = "C: " + err.codigo;
                    msg += " O: " + err.Origem;

                    if (err.Excecao != null)
                    {
                        msg += " E1: " + err.Excecao.Message;

                        if (err.Excecao.InnerException != null)
                        {
                            msg += " E2: " + err.Excecao.InnerException.Message;
                        }
                    }

                    if (!String.IsNullOrEmpty(err.chaveNFe))
                        msg += " N: " + err.chaveNFe;

                    proxy.ReportError(msg);
                }
            }
            catch //(Exception ex)
            {

            }
        }

        class Erro
        {
            public int codigo { get; set; }
            public string Origem { get; set; }
            public Exception Excecao { get; set; }
            public string chaveNFe { get; set; }
        }


        private void AssinaNota(string NFeStr, ref TipoSituacaoNota CodigoDoResultado, ref string DescricaoDoResultado)
        {
            string erros;

            try
            {
                X509Certificate2 certificadoX509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);
                var retornoAssinatura = NFeUtils.AssinaXML(oParam.pastaEntrada + NFeStr, "infNFe", certificadoX509, oParam.versao);

                switch (retornoAssinatura.codigoRetorno)
                {
                    case TRetornoAssinatura.Assinada:
                        CodigoDoResultado = TipoSituacaoNota.Assinada;
                        break;
                    case TRetornoAssinatura.RefURiNaoExiste:
                        CodigoDoResultado = TipoSituacaoNota.RefURiNaoExiste;
                        break;
                    case TRetornoAssinatura.RefURiNaoUnica:
                        CodigoDoResultado = TipoSituacaoNota.RefURiNaoUnica;
                        break;
                    case TRetornoAssinatura.ErroAoAssinarDocumento:
                        CodigoDoResultado = TipoSituacaoNota.ErroAoAssinarDocumento;
                        break;
                    case TRetornoAssinatura.XMLMalFormado:
                        CodigoDoResultado = TipoSituacaoNota.XMLMalFormado;
                        break;
                    case TRetornoAssinatura.ProblemaAoAcessarCertificado:
                        CodigoDoResultado = TipoSituacaoNota.ProblemaAoAcessarCertificado;
                        break;
                    case TRetornoAssinatura.ArquivoNaoEncontrado:
                        CodigoDoResultado = TipoSituacaoNota.ArquivoNaoEncontrado;
                        break;
                    default:
                        break;
                }

                certificadoX509 = null;

                //so validar nota assinada
                if (CodigoDoResultado == TipoSituacaoNota.Assinada)
                {
                    erros = NFeUtils.ValidacaoXML(oParam.pastaEntrada + "ass" + NFeStr,
                                                  oParam.pastaXSD + "nfe_v" + oParam.versaoDados + ".xsd");

                    if (erros == "NotFound")
                    {
                        CodigoDoResultado = TipoSituacaoNota.ArquivoValidacaoNaoEncontrado;// 10;
                        DescricaoDoResultado = "Arquivo não encontrado - Validação";
                    }
                    else if (erros != System.String.Empty)      //problema : xml nao validado.
                    {
                        CodigoDoResultado = TipoSituacaoNota.XMLInvalido;// 8;
                        DescricaoDoResultado = erros;
                        //Renomear o arquivo para ERRO+NFE
                        if (File.Exists(oParam.pastaEntrada + "ERRO8_" + NFeStr))
                            File.Delete(oParam.pastaEntrada + "ERRO8_" + NFeStr);
                        File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO8_" + NFeStr);
                        File.Delete(oParam.pastaEntrada + "ass" + NFeStr);
                    }
                    else if (File.Exists(oParam.pastaEntrada + "ass" + NFeStr))//ESTA TUDO OK 
                    {
                        DescricaoDoResultado = "Nota Assinada";

                        File.Delete(oParam.pastaEntrada + NFeStr);
                    }
                }
                else if (CodigoDoResultado == TipoSituacaoNota.ProblemaAoAcessarCertificado)
                {
                    DescricaoDoResultado = "Problema ao acessar certificado - " + retornoAssinatura.mensagem;
                    //Avisar para o Usuario Avancado que existe um problema no certiificado
                    if (File.Exists(oParam.pastaEntrada + "ERRO1_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO1_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO1_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.ProblemaNoCertificado)
                {
                    DescricaoDoResultado = "Problemas no certificado - " + retornoAssinatura.mensagem;
                    //Avisar para o Usuario Avancado que existe um problema no certiificado
                    if (File.Exists(oParam.pastaEntrada + "ERRO2_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO2_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO2_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.XMLMalFormado)
                {
                    DescricaoDoResultado = "XML mal formado - " + retornoAssinatura.mensagem;
                    //Renomear o arquivo para ERRO+NFE
                    if (File.Exists(oParam.pastaEntrada + "ERRO3_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO3_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO3_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.RefURiNaoExiste)
                {
                    DescricaoDoResultado = "A TAG de assinatura é inexistente - " + retornoAssinatura.mensagem;
                    //Renomear o arquivo para ERRO+NFE
                    if (File.Exists(oParam.pastaEntrada + "ERRO4_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO4_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO4_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.RefURiNaoUnica)
                {
                    DescricaoDoResultado = "A TAG de assinatura não é única - " + retornoAssinatura.mensagem;
                    //Renomear o arquivo para ERRO+NFE
                    if (File.Exists(oParam.pastaEntrada + "ERRO5_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO5_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO5_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.ErroAoAssinarDocumento)
                {
                    DescricaoDoResultado = "Erro ao assinar o documento - " + retornoAssinatura.mensagem;

                    if (File.Exists(oParam.pastaEntrada + "ERRO7_" + NFeStr))
                        File.Delete(oParam.pastaEntrada + "ERRO7_" + NFeStr);
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO7_" + NFeStr);
                }
                else if (CodigoDoResultado == TipoSituacaoNota.ArquivoNaoEncontrado)
                {
                    DescricaoDoResultado = "Arquivo não encontrado - Assinatura";
                }
            }
            catch (Exception ex)
            {
                CodigoDoResultado = TipoSituacaoNota.ExcecaoGeralAssinatura;// 9;
                DescricaoDoResultado = "Exceção - " + ex.Message;
                CriaLog(999, "AssinaNota", ex);

                if (File.Exists(oParam.pastaEntrada + "ERRO9_" + NFeStr))
                    File.Delete(oParam.pastaEntrada + "ERRO9_" + NFeStr);
                if (File.Exists(oParam.pastaEntrada + NFeStr))
                    File.Move(oParam.pastaEntrada + NFeStr, oParam.pastaEntrada + "ERRO9_" + NFeStr);
            }
        }

        private void CriaEnvelope(int QtdeNFLote)
        {

            try
            {
                int numeroNovoLote, i;
                TipoSituacaoNota CodigoDoResultado = TipoSituacaoNota.SerivcoExcluido;
                string origem, DescricaoDoResultado = "Erro não mapeado";

                //inicia lote
                #region Pegar o ultimo lote criado.
                //NotaFiscalQry oNFeQry = new NotaFiscalQry();
                //oNFeQry.empresa = oParam.empresa;
                //numeroNovoLote = NotaFiscalDAL.Instance.GetMax(oNFeQry, manager);

                ServicoPendenteQry oSrvQry = new ServicoPendenteQry();
                oSrvQry.empresa = oParam.empresa;
                numeroNovoLote = ServicoPendenteDAL.Instance.GetMax(oSrvQry, manager);

                ITEnviNFe oEnviNFe = (ITEnviNFe)XMLUtils.XMLFactory(oParam.versao, "TEnviNFe");
                oEnviNFe.idLote = numeroNovoLote.ToString();
                oEnviNFe.versao = oParam.versaoDados;

                //Trabalhar sempre com envelopes assincronos
                if (oParam.versao == VersaoXML.NFe_v310)
                {
                    ((SchemaXML.NFe_v310.TEnviNFe)oEnviNFe).indSinc = SchemaXML.NFe_v310.TEnviNFeIndSinc.Item0;
                }
                else if (oParam.versao == VersaoXML.NFe_v300)
                {
                    ((SchemaXML.NFe_v300.TEnviNFe)oEnviNFe).indSinc = SchemaXML.NFe_v300.TEnviNFeIndSinc.Item0;
                }

                #endregion

                #region assinar, validar e adicionar nota ao lote
                //corre a lista de nfe's disponiveis na pasta de entrada.
                for (i = 0; i < QtdeNFLote; i++)
                {
                    origem = ListaDeNotas[i].ToString();
                    ITNFe oNFe = (ITNFe)XMLUtils.XMLFactory(oParam.versao, "TNFe");
                    string xmlNotaStr = "";

                    try
                    {
                        #region integracao
                        try
                        {
                            MMCustom.MMUtils.ConfirmaRecebimentoNFe(origem);
                        }
                        catch
                        { }
                        #endregion

                        #region verificar se o arquivo existe
                        if (!File.Exists(oParam.pastaEntrada + origem))
                        {
                            CodigoDoResultado = TipoSituacaoNota.ArquivoNaoEncontrado;// 11;
                            DescricaoDoResultado = "Arquivo não foi localizado : " + oParam.pastaEntrada + origem;
                            throw new Exception(DescricaoDoResultado);
                        }
                        #endregion

                        #region verificar se é possivel ler o arquivo

                        try
                        {

                            using (StreamReader SR = File.OpenText(oParam.pastaEntrada + origem))
                            {
                                xmlNotaStr = SR.ReadToEnd();
                                SR.Close();
                            }
                            GC.Collect();
                        }
                        catch (Exception ex)
                        {
                            CodigoDoResultado = TipoSituacaoNota.SerivcoExcluido;// 99;
                            DescricaoDoResultado = "Não foi possível abrir o arquivo : " + oParam.pastaEntrada + origem + " > " + ex.Message;
                            throw new Exception(DescricaoDoResultado);
                        }

                        #endregion

                        #region verificar serializacao antes de assinar jogar na classe de NFe
                        try
                        {
                            oNFe = (ITNFe)XMLUtils.CarregaXML_STR(xmlNotaStr, oParam.versao, "TNFe");
                            XMLUtils.SalvaXML(oParam.pastaEntrada + origem, oNFe, oParam.versao);
                            oNFe = null;
                        }
                        catch (Exception ex)
                        {
                            CodigoDoResultado = TipoSituacaoNota.XMLMalFormado;// 3;
                            DescricaoDoResultado = "Não foi possivel Deserializar a nota no Objeto TNFe. - " + ex.Message;
                            throw new Exception(DescricaoDoResultado);
                        }
                        #endregion

                        AssinaNota(origem, ref CodigoDoResultado, ref DescricaoDoResultado);

                        if (CodigoDoResultado != 0)
                        {
                            throw new Exception(DescricaoDoResultado);
                        }
                        //nota assinada e validada

                        if (!File.Exists(oParam.pastaEntrada + "ass" + origem))
                        {
                            CodigoDoResultado = TipoSituacaoNota.ArquivoNaoEncontrado;// 11;
                            DescricaoDoResultado = "Nota não encontrada : " + origem;
                            throw new Exception(DescricaoDoResultado);
                        }

                        #region carregar a nfe assinada
                        oNFe = (ITNFe)XMLUtils.CarregaXML_HD(oParam.pastaEntrada + "ass" + origem, oParam.versao, "TNFe");


                        //todo validar a chave da NFe
                        //if (oNFe.infNFe.ide.cUF.ToString() != origem.Substring(0, 2) ||
                        //    oNFe.infNFe.ide.dEmi.Substring(2, 2) != origem.Substring(2, 2) ||
                        //    oNFe.infNFe.ide.dEmi.Substring(5, 2) != origem.Substring(4, 2) ||
                        //    oNFe.infNFe.emit.Item != origem.Substring(6, 14) ||
                        //    oNFe.infNFe.ide.mod.ToString() != origem.Substring(20, 2) ||
                        //    oNFe.infNFe.ide.serie.PadLeft(3, '0') != origem.Substring(22, 3) ||
                        //    oNFe.infNFe.ide.nNF.PadLeft(9, '0') != origem.Substring(25, 9) ||
                        //    oNFe.infNFe.ide.tpEmis.ToString() != origem.Substring(34, 1) ||
                        //    oNFe.infNFe.ide.cNF != origem.Substring(35, 8) ||
                        //    oNFe.infNFe.ide.cDV != origem.Substring(44, 1))
                        //{
                        //    CodigoDoResultado = 3;
                        //    DescricaoDoResultado = "Chave de acesso não corresponde aos valores informados no XML";
                        //    throw new Exception(DescricaoDoResultado);
                        //}
                        #endregion


                        #region  envelopar nota da nova maneira

                        if (oEnviNFe.NFe == null)
                            oEnviNFe.NFe = (ITNFe[])XMLUtils.XMLFactory(oParam.versao, "TNFe[]", 0);

                        bool canInsert = true;

                        #region verificar se NFe ja foi inserida no lote

                        foreach (var oNFeInserida in oEnviNFe.NFe)
                        {
                            if (oNFe.infNFe.Id == oNFeInserida.infNFe.Id)
                            {
                                canInsert = false;
                                break;
                            }
                        }
                        #endregion

                        #region Salvar informações no banco de dados NFe
                        NotaFiscal oNotaProc = new NotaFiscal();
                        oNotaProc.versao = oParam.versao;
                        oNotaProc.chaveNota = origem.Substring(0, origem.Length - 4);

                        oNotaProc.empresa = oParam.empresa;
                        oNotaProc.numeroLote = numeroNovoLote;
                        oNotaProc.codigoSituacao = CodigoDoResultado;
                        oNotaProc.xmlNota = xmlNotaStr;

                        if (CodigoDoResultado == 0)
                        {
                            oNotaProc.xmlProcesso = "";
                            oNotaProc.descricaoSituacao = DescricaoDoResultado;
                            oNotaProc.xmlNota = XMLUtils.GetXML(oNFe, oParam.versao);
                        }
                        else if (CodigoDoResultado == TipoSituacaoNota.XMLInvalido)//os erros de validaçao estao dentro de DescricaoDoResultado. 
                        {
                            oNotaProc.xmlProcesso = "<erro>" + DescricaoDoResultado + "</erro>";
                            oNotaProc.descricaoSituacao = "XML inválido";
                            DescricaoDoResultado = "XML inválido";
                        }
                        else//DescricaoDoResultado contém a mensagem correta para o Log
                        {
                            oNotaProc.xmlProcesso = "<erro>" + DescricaoDoResultado + "</erro>";
                            oNotaProc.descricaoSituacao = "XML inválido";
                        }

                        oNotaProc.nProt = "";
                        oNotaProc.xMotivo = "";
                        oNotaProc.cStat = "";

                        oNotaProc.xmlPedidoCancelamento = "";
                        oNotaProc.xmlProcessoCancelamento = "";
                        oNotaProc.nProtCancelamento = "";

                        oNotaProc.dataSituacao = DateTime.Now;
                        oNotaProc.Save(manager);



                        //Criar operação de Log
                        CriaLog((int)CodigoDoResultado, DescricaoDoResultado, oNotaProc.chaveNota);
                        #endregion

                        if (canInsert)
                        {
                            int tamanhoEnvelope = oEnviNFe.NFe.Length;
                            var listaAux = oEnviNFe.NFe;
                            oEnviNFe.NFe = (ITNFe[])XMLUtils.XMLFactory(oParam.versao, "TNFe[]", (tamanhoEnvelope + 1));
                            for (int pos = 0; pos < listaAux.Length; pos++)
                            {
                                var oNFe4List = (ITNFe)listaAux[pos];
                                oEnviNFe.NFe.SetValue(oNFe4List, pos);
                            }
                            oEnviNFe.NFe.SetValue(oNFe, listaAux.Length);
                        }

                        #endregion

                        #region integracao
                        try
                        {
                            if (oNotaProc.codigoSituacao != 0) //diferente de nota assinada
                            {
                                NFeUtils.GeraRejeicaoNFe(oNotaProc.chaveNota, oNotaProc.cStat, oNotaProc.xMotivo, oParam.pastaSaida);
                                MMCustom.MMUtils.ProcessaResultadoNFe(origem,
                                    (int)oNotaProc.codigoSituacao,
                                    oNotaProc.descricaoSituacao,
                                    oNotaProc.cStat,
                                    oNotaProc.xMotivo,
                                    oNotaProc.nProt);
                            }
                        }
                        catch
                        { }
                        #endregion


                    }//fim do try principal
                    catch (Exception ex)
                    {
                        #region integracao
                        try
                        {
                            MMCustom.MMUtils.ProcessaResultadoNFe(origem,
                                (int)CodigoDoResultado,
                                DescricaoDoResultado,
                                string.Empty,
                                string.Empty,
                                string.Empty);
                        }
                        catch
                        { }
                        #endregion


                        CriaLog(999, "CriaEnvelope", ex, origem.Replace(".xml", ""));

                        if (File.Exists(oParam.pastaEntrada + "ERRO" + CodigoDoResultado.ToString() + "_" + origem))
                            File.Delete(oParam.pastaEntrada + "ERRO" + CodigoDoResultado.ToString() + "_" + origem);

                        if (File.Exists(oParam.pastaEntrada + origem))
                            File.Move(oParam.pastaEntrada + origem, oParam.pastaEntrada + "ERRO" + CodigoDoResultado.ToString() + "_" + origem);
                    }
                }//fim do for
                #endregion

                #region criar servico pendente referente as notas que estao no lote
                //Carrega lote se criado
                CriaLog(999, "Lote criado : " + numeroNovoLote.ToString());

                //adicionar o lote nos servicos pendentes
                ServicoPendente oServicoPendente = new ServicoPendente();

                string msgLog = "Serviço criado com sucesso.";

                oServicoPendente.codigoSituacao = TipoSituacaoServico.Assinado;

                if (oEnviNFe.NFe != null && oEnviNFe.NFe.Length > 0)
                {
                    //criar pasta se não existir 
                    if (!Directory.Exists(oParam.pastaSaida))
                        Directory.CreateDirectory(oParam.pastaSaida);

                    //salvar o lote
                    if (File.Exists(oParam.pastaSaida + oEnviNFe.idLote + "-env-lot.xml"))
                        File.Delete(oParam.pastaSaida + oEnviNFe.idLote + "-env-lot.xml");

                    XMLUtils.SalvaXML(oParam.pastaSaida + oEnviNFe.idLote + "-env-lot.xml", oEnviNFe, oParam.versao);
                }
                else
                {
                    oServicoPendente.codigoSituacao = TipoSituacaoServico.Invalido;
                    msgLog = "Serviço foi criado sem nenhuma nota válida.";
                }

                oServicoPendente.dataSituacao = DateTime.Now;
                oServicoPendente.versao = oParam.versao;
                oServicoPendente.empresa = oParam.empresa;
                oServicoPendente.numeroLote = numeroNovoLote;
                oServicoPendente.UF = oParam.UF;
                oServicoPendente.tipoAmbiente = oParam.tipoAmbiente;
                oServicoPendente.tipoEmissao = oParam.tipoEmissao;

                oServicoPendente.numeroRecibo = "";
                oServicoPendente.xmlRecibo = "";
                oServicoPendente.xmlRetConsulta = "";
                oServicoPendente.erroEnvio = false;

                oServicoPendente.Save(manager);

                CriaLog(1, msgLog);

                dataUltimaCriacaoEnvelope = DateTime.Now;
                #endregion

            }
            catch (Exception ex)
            {
                CriaLog(999, "CriaEnvelope(Geral)", ex);
            }
        }

        private void EnviaEnvelope(ServicoPendente oServicoPendente)
        {
            ITEnviNFe oEnviNFe;
            ITRetEnviNFe oRetEnviNFe = null;
            try
            {

                String nomeArquivo = oParam.pastaSaida + oServicoPendente.numeroLote.ToString() + "-env-lot.xml";
                //verificar se existe
                if (!File.Exists(nomeArquivo))
                    throw new Exception("Não foi possível localizar o arquivo : " + nomeArquivo);

                //carregar envelope
                oEnviNFe = (ITEnviNFe)XMLUtils.CarregaXML_HD(nomeArquivo, oParam.versao, "TEnviNFe");


                //pronto para enviar
                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = NFeUtils.ClientProxyFactory(oParam, TServico.Autorizacao);

                try
                {
                    //chamar o servico
                    oRetEnviNFe = Servicos.EnviarEnvelope(oServico, oEnviNFe, oParam, oServicoPendente.versao);

                }
                catch (Exception ex)
                {
                    oServicoPendente.erroEnvio = true;

                    connectionOk = ConsultaStatus();

                    CriaLog(998, "EnviaEnvelope", ex);
                }

                if (oRetEnviNFe != null && oRetEnviNFe.infRec != null)
                {
                    //criar pasta se não existir 
                    if (!Directory.Exists(oParam.pastaRecibo))
                        Directory.CreateDirectory(oParam.pastaRecibo);

                    //salvar o recibo do envio
                    XMLUtils.SalvaXML(oParam.pastaRecibo + oServicoPendente.numeroLote.ToString() + "-rec.xml", oRetEnviNFe, oServicoPendente.versao);

                    if (!string.IsNullOrEmpty(oRetEnviNFe.infRec.nRec))
                    {
                        #region atualizar Servico Pendente

                        //removido : pode gerar loop infinito
                        //if (oRetEnviNFe.cStat != "103")
                        //    throw new Exception(oRetEnviNFe.xMotivo);

                        oServicoPendente.numeroRecibo = oRetEnviNFe.infRec.nRec;
                        oServicoPendente.xmlRecibo = XMLUtils.GetXML(oRetEnviNFe, oServicoPendente.versao);
                        //utilizar a hora do servidor.
                        oServicoPendente.dataSituacao = DateTime.Now;//oRetEnviNFe.dhRecbto;
                        oServicoPendente.codigoSituacao = TipoSituacaoServico.Enviado;

                        //setar todas as notas desse servico como enviadas.
                        NotaFiscalQry oNFeQry = new NotaFiscalQry();
                        oNFeQry.empresa = oServicoPendente.empresa;
                        oNFeQry.numeroLote = oServicoPendente.numeroLote.ToString();

                        //somente as que foram assinadas e inseridas no lote.
                        oNFeQry.codigoSituacao = TipoSituacaoNota.Assinada;

                        ArrayList notasProcessadas = NotaFiscalDAL.Instance.GetInstances(oNFeQry, manager);
                        foreach (NotaFiscal oNFeProc in notasProcessadas)
                        {
                            oNFeProc.codigoSituacao = TipoSituacaoNota.Enviada;// 12; //Enviada
                            oNFeProc.descricaoSituacao = "Nota enviada";
                            oNFeProc.dataSituacao = oServicoPendente.dataSituacao;
                            oNFeProc.Save(manager);

                            CriaLog(12, "Nota enviada", oNFeProc.chaveNota);
                        }

                        #endregion
                    }
                    else
                    {
                        if (!oServicoPendente.erroEnvio) // a comunicacao foi bem sucedida, mas nao foi possivel abrir o nRec
                        {
                            oServicoPendente.erroEnvio = true;
                        }
                        oServicoPendente.codigoSituacao = TipoSituacaoServico.ProblemaNoEnvio;
                    }
                }
                else
                {
                    if (!oServicoPendente.erroEnvio) // a comunicacao foi bem sucedida, mas nao foi possivel abrir o nRec
                    {
                        oServicoPendente.erroEnvio = true;
                    }
                    oServicoPendente.codigoSituacao = TipoSituacaoServico.ProblemaNoEnvio;
                }

                oServicoPendente.Save(manager);

                //integracao
                if (oServicoPendente.codigoSituacao == TipoSituacaoServico.ProblemaNoEnvio)
                {
                    try
                    {
                        NotaFiscalQry oNFeQry = new NotaFiscalQry();
                        oNFeQry.empresa = oServicoPendente.empresa;
                        oNFeQry.numeroLote = oServicoPendente.numeroLote.ToString();
                        //somente as que foram assinadas e inseridas no lote.
                        oNFeQry.codigoSituacao = TipoSituacaoNota.Assinada;
                        ArrayList notasProcessadas = NotaFiscalDAL.Instance.GetInstances(oNFeQry, manager);
                        foreach (NotaFiscal oNFeProc in notasProcessadas)
                        {
                            MMCustom.MMUtils.ProcessaResultadoNFe(oNFeProc.chaveNota,
                                    (int)oNFeProc.codigoSituacao,
                                    oNFeProc.descricaoSituacao,
                                    oNFeProc.cStat,
                                    oNFeProc.xMotivo,
                                    oNFeProc.nProt);
                        }
                    }
                    catch { }
                }

                if (oRetEnviNFe != null)
                    CriaLog(Int32.Parse(oRetEnviNFe.cStat), oRetEnviNFe.xMotivo);
            }
            catch (Exception ex)
            {
                CriaLog(999, "EnviaEnvelope", ex);
            }
            finally
            {
                oEnviNFe = null;
                oRetEnviNFe = null;
            }
        }

        public void ConsultaEnvelope(ServicoPendente oServicoPendente)
        {
            ITRetEnviNFe oRetEnviNFe;
            ITConsReciNFe oConsReciNFe;
            ITRetConsReciNFe oRetConsReciNFe = null;

            try
            {
                oServicoPendente.dataSituacao = DateTime.Now;
                oServicoPendente.Save(manager);

                oRetEnviNFe = (ITRetEnviNFe)XMLUtils.CarregaXML_STR(oServicoPendente.xmlRecibo, oServicoPendente.versao, "TRetEnviNFe");

                if (oRetEnviNFe.infRec.nRec != oServicoPendente.numeroRecibo)
                {
                    oServicoPendente.codigoSituacao = TipoSituacaoServico.ProblemaNoEnvio;
                }
                else
                {
                    //cria o objeto de consulta de recibo
                    oConsReciNFe = (ITConsReciNFe)XMLUtils.XMLFactory(oParam.versao, "TConsReciNFe");
                    oConsReciNFe.versao = oParam.versaoDados;
                    oConsReciNFe.tpAmb = oRetEnviNFe.tpAmb;

                    oConsReciNFe.nRec = oRetEnviNFe.infRec.nRec;

                    //executar o servico
                    System.Web.Services.Protocols.SoapHttpClientProtocol oServico = NFeUtils.ClientProxyFactory(oParam, TServico.RetAutorizacao);

                    try
                    {
                        oRetConsReciNFe = Servicos.ConsultarProcessamentoEnvelope(oServico, oConsReciNFe, oParam, oServicoPendente.versao);
                    }
                    catch (Exception ex)
                    {
                        connectionOk = ConsultaStatus();

                        throw ex;
                    }

                    //salvar o arquivo de retorno da consulta
                    XMLUtils.SalvaXML(oParam.pastaRecibo + oServicoPendente.numeroRecibo + "-pro-rec.xml", oRetConsReciNFe, oServicoPendente.versao);

                    //testar retorno
                    #region trata Retorno do processamento

                    //atualiza a tabela de notas
                    NotaFiscalQry oNFQry = new NotaFiscalQry();
                    oNFQry.empresa = oServicoPendente.empresa;
                    oNFQry.numeroLote = oServicoPendente.numeroLote.ToString();

                    //buscar somente as notas que pertencem ao lote como enviada
                    oNFQry.codigoSituacao = TipoSituacaoNota.Enviada;// "12";//enviada

                    ArrayList notasProcessadas = NotaFiscalDAL.Instance.GetInstances(oNFQry, manager);

                    //testa Codigo de Mensagem de resultado

                    if (oRetConsReciNFe.cStat == "105")
                    {
                        CriaLog(105, "Lote em processamento");
                    }
                    else if (oRetConsReciNFe.cStat == "225" || oRetConsReciNFe.cStat == "223" ||
                        oRetConsReciNFe.cStat == "280" || oRetConsReciNFe.cStat == "281" ||
                        oRetConsReciNFe.cStat == "283" || oRetConsReciNFe.cStat == "286" ||
                        oRetConsReciNFe.cStat == "284" || oRetConsReciNFe.cStat == "285" ||
                        oRetConsReciNFe.cStat == "282" || oRetConsReciNFe.cStat == "214" ||
                        oRetConsReciNFe.cStat == "243" || oRetConsReciNFe.cStat == "242" ||
                        oRetConsReciNFe.cStat == "299" || oRetConsReciNFe.cStat == "408" ||
                        oRetConsReciNFe.cStat == "238" || oRetConsReciNFe.cStat == "239" ||
                        oRetConsReciNFe.cStat == "215" || oRetConsReciNFe.cStat == "404" ||
                        oRetConsReciNFe.cStat == "402" || oRetConsReciNFe.cStat == "252" ||
                        oRetConsReciNFe.cStat == "248" || oRetConsReciNFe.cStat == "106" ||
                        (oRetConsReciNFe.cStat == "104" && oRetConsReciNFe.protNFe[0].infProt.cStat == "999"))
                    {
                        //rejeitar o servico inteiro
                        CriaLog(Int32.Parse(oRetConsReciNFe.cStat), "Lote " + oServicoPendente.numeroLote.ToString() + " : " + oRetConsReciNFe.xMotivo);


                        foreach (NotaFiscal oNFeProc in notasProcessadas)
                        {
                            oNFeProc.codigoSituacao = TipoSituacaoNota.RejeitadaPeloProcessamentoLote;// 17
                            oNFeProc.descricaoSituacao = "Nota Rejeitada pelo processamento do lote";
                            oNFeProc.dataSituacao = DateTime.Now;

                            oNFeProc.xmlProcesso = XMLUtils.GetXML(oRetConsReciNFe, oServicoPendente.versao);
                            oNFeProc.cStat = oRetConsReciNFe.cStat;
                            oNFeProc.xMotivo = oRetConsReciNFe.xMotivo;

                            oNFeProc.Save(manager);

                            //integracao
                            NFeUtils.GeraRejeicaoNFe(oNFeProc.chaveNota, oNFeProc.cStat, oNFeProc.xMotivo, oParam.pastaSaida);
                            try
                            {
                                MMCustom.MMUtils.ProcessaResultadoNFe(oNFeProc.chaveNota,
                                        (int)oNFeProc.codigoSituacao,
                                        oNFeProc.descricaoSituacao,
                                        oNFeProc.cStat,
                                        oNFeProc.xMotivo,
                                        oNFeProc.nProt);
                            }
                            catch { }

                            CriaLog(14, "Nota rejeitada pelo processamento do lote", oNFeProc.chaveNota);
                        }

                        //atualiza a tabela de serviços pendentes daquele lote.
                        oServicoPendente.codigoSituacao = TipoSituacaoServico.Rejeitado;
                    }
                    else if (oRetConsReciNFe.cStat == "104")//lote ja foi processado
                    {
                        //aplicativo deverá atualiza o servico 
                        CriaLog(Int32.Parse(oRetConsReciNFe.cStat), "Lote " + oServicoPendente.numeroRecibo.ToString() + " : " + oRetConsReciNFe.xMotivo);

                        #region percorre as notas
                        foreach (NotaFiscal oNotaProc in notasProcessadas)
                        {
                            Boolean find = false;
                            foreach (var protocolo in oRetConsReciNFe.protNFe)
                            {
                                if (protocolo.infProt.chNFe == oNotaProc.chaveNota.Replace("NFe", ""))
                                {
                                    find = true;
                                    #region achou protocolo da nota

                                    oNotaProc.dataSituacao = DateTime.Now;

                                    oNotaProc.xmlProcesso = XMLUtils.GetXML(protocolo, oServicoPendente.versao);
                                    oNotaProc.cStat = protocolo.infProt.cStat;
                                    oNotaProc.xMotivo = protocolo.infProt.xMotivo;

                                    if (protocolo.infProt.cStat == "100" || protocolo.infProt.cStat == "150")
                                    {
                                        //autorizacao por nota
                                        oNotaProc.codigoSituacao = TipoSituacaoNota.Aprovada;// 13;//nota Aprovada
                                        oNotaProc.descricaoSituacao = "Nota Aprovada";
                                        if (protocolo.infProt.nProt != null)
                                        {
                                            oNotaProc.nProt = protocolo.infProt.nProt;
                                        }
                                        else
                                        {
                                            oNotaProc.nProt = ""; //tratar 
                                            CriaLog(999, "Não foi possivel obter nProt do retorno da consulta. ", oNotaProc.chaveNota.ToString());
                                        }
                                    }
                                    else if (protocolo.infProt.cStat == "301" || protocolo.infProt.cStat == "302")
                                    {
                                        oNotaProc.codigoSituacao = TipoSituacaoNota.Denegada;
                                        oNotaProc.descricaoSituacao = "Uso Denegado";
                                    }
                                    else
                                    {
                                        //rejeicao por nota
                                        oNotaProc.codigoSituacao = TipoSituacaoNota.Rejeitada;// 14;//nota rejeitada
                                        oNotaProc.descricaoSituacao = "Nota Rejeitada";
                                    }
                                    oNotaProc.Save(manager);

                                    //integracao
                                    if (oNotaProc.codigoSituacao == TipoSituacaoNota.Rejeitada)
                                        NFeUtils.GeraRejeicaoNFe(oNotaProc.chaveNota, oNotaProc.cStat, oNotaProc.xMotivo, oParam.pastaSaida);
                                    try
                                    {
                                        MMCustom.MMUtils.ProcessaResultadoNFe(oNotaProc.chaveNota,
                                                (int)oNotaProc.codigoSituacao,
                                                oNotaProc.descricaoSituacao,
                                                oNotaProc.cStat,
                                                oNotaProc.xMotivo,
                                                oNotaProc.nProt);
                                    }
                                    catch { }

                                    //Atualiza LOG
                                    CriaLog(Convert.ToInt32(protocolo.infProt.cStat),
                                                            protocolo.infProt.xMotivo,
                                                    "NFe" + protocolo.infProt.chNFe);
                                    #endregion
                                    break;
                                }
                            }//fim do foreach protocolo

                            //tratar se NFe nao foi localizada

                            if (!find)
                            {
                                //rejeicao por nota
                                oNotaProc.dataSituacao = DateTime.Now;
                                oNotaProc.codigoSituacao = TipoSituacaoNota.RejeitadaPeloProcessamentoLote;// 17;//nota rejeitada pelo processamento do lote
                                oNotaProc.descricaoSituacao = "Nota Rejeitada pelo processamento do lote";
                                oNotaProc.Save(manager);

                                //integracao
                                NFeUtils.GeraRejeicaoNFe(oNotaProc.chaveNota, oRetConsReciNFe.cStat, oRetConsReciNFe.xMotivo, oParam.pastaSaida);

                                try
                                {
                                    MMCustom.MMUtils.ProcessaResultadoNFe(oNotaProc.chaveNota,
                                            (int)oNotaProc.codigoSituacao,
                                            oNotaProc.descricaoSituacao,
                                            oNotaProc.cStat,
                                            oNotaProc.xMotivo,
                                            oNotaProc.nProt);
                                }
                                catch { }

                                //Atualiza LOG
                                CriaLog(17, "Nota Rejeitada pelo processamento do lote", oNotaProc.chaveNota);
                            }

                        }//fim do foreach nota
                        #endregion

                        //atualiza a tabela de serviços pendentes daquele lote.
                        oServicoPendente.codigoSituacao = TipoSituacaoServico.Processado;
                    }
                    #endregion
                }

                oServicoPendente.dataSituacao = DateTime.Now;
                oServicoPendente.xmlRetConsulta = XMLUtils.GetXML(oRetConsReciNFe, oServicoPendente.versao);
                oServicoPendente.Save(manager);


            }
            catch (Exception ex)
            {
                CriaLog(999, "ConsultaEnvelope", ex);
            }
            finally
            {
                oRetConsReciNFe = null;
                oConsReciNFe = null;
            }
        }

        public Boolean ConsultaStatus()
        {
            ITRetConsStatServ oRetConsStatServ;
            ITConsStatServ oConsStatServ;

            bool retorno;

            try
            {
                if (!Directory.Exists(oParam.pastaRecibo))
                    Directory.CreateDirectory(oParam.pastaRecibo);

                #region Cria objeto de consulta
                oConsStatServ = (ITConsStatServ)XMLUtils.XMLFactory(oParam.versao, "TConsStatServ");
                oConsStatServ.versao = oParam.versaoDados;
                oConsStatServ.tpAmb = oParam.tipoAmbiente;
                oConsStatServ.cUF = oParam.UF;
                #endregion

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico =
                    NFeUtils.ClientProxyFactory(oParam, TServico.Status);

                XMLUtils.SalvaXML(oParam.pastaRecibo + oParam.UF.ToString() + "consulta-ped-sta.xml", oConsStatServ, oParam.versao);

                oRetConsStatServ = Servicos.ConsultarStatusServidor(oServico, oConsStatServ, oParam, oParam.versao);

                if (!Directory.Exists(oParam.pastaRecibo))
                    Directory.CreateDirectory(oParam.pastaRecibo);

                XMLUtils.SalvaXML(oParam.pastaRecibo + oParam.UF.ToString() + "consulta-sta.xml", oRetConsStatServ, oParam.versao);


                //teste de operação
                retorno = (oRetConsStatServ.cStat == "107");
                CriaLog(Int32.Parse(oRetConsStatServ.cStat), "SEFAZ-" +
                    XMLUtils.GetDescriptionAttribute(oParam.UF) + " " + oRetConsStatServ.xMotivo);

            }
            catch (Exception ex)
            {
                //mapear codigos do log
                CriaLog(999, "ConsultaStatus SEFAZ-" + XMLUtils.GetDescriptionAttribute(oParam.UF) + " não respondeu no timeout configurado. ",
                    ex);
                retorno = false;
            }
            finally
            {
                //Limpa os objetos
                oConsStatServ = null;
                oRetConsStatServ = null;
            }

            //integracao
            try
            {
                MMCustom.MMUtils.ConsultaStatusSefaz(retorno);
            }
            catch { }

            return retorno;
        }

        public void FinalizaServicos(ServicoPendente oServicoPendente)
        {
            try
            {
                //buscar no banco as notas aprovadas desse ServicoPendente
                NotaFiscalQry oNFeQry = new NotaFiscalQry();
                oNFeQry.empresa = oServicoPendente.empresa;
                oNFeQry.numeroLote = oServicoPendente.numeroLote.ToString();
                oNFeQry.codigoSituacao = TipoSituacaoNota.Aprovada;// "13";//aprovada

                ArrayList notasProcessadas = NotaFiscalDAL.Instance.GetInstances(oNFeQry, manager);

                foreach (NotaFiscal oNotaProc in notasProcessadas)
                {
                    NFeUtils.ImprimeDANFe(oNotaProc, oParam, manager);
                    CriaLog(4, "Arquivo enviado para Pasta de Impressão com sucesso!", oNotaProc.chaveNota);
                }
                oServicoPendente.codigoSituacao = TipoSituacaoServico.Finalizado;
                oServicoPendente.dataSituacao = DateTime.Now;
                oServicoPendente.Save(manager);
            }
            catch (Exception ex)
            {
                CriaLog(999, "FinalizaServicos", ex);
            }
            finally
            {

            }
        }

        public void RecepcaoEvento(ITEvento oEventoNFeAss, int idLote, ref String xmlRetEnvEvento, VersaoXML versao)
        {
            ITEnvEvento oEnvEvento;
            ITRetEnvEvento oRetEnvEvento;

            try
            {
                //criar um envelope do evento
                oEnvEvento = (ITEnvEvento)XMLUtils.XMLFactory(versao, "TEnvEvento");
                oEnvEvento.evento = (ITEvento[])XMLUtils.XMLFactory(versao, "TEvento[]", 1);
                oEnvEvento.evento[0] = oEventoNFeAss;

                oEnvEvento.idLote = idLote.ToString();
                oEnvEvento.versao = "1.00";

                //cria servico
                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = NFeUtils.ClientProxyFactory(oParam, TServico.RecepcaoEvento);
                try
                {
                    //executa servico
                    oRetEnvEvento = Servicos.EnviarEnvelopeEvento(oServico, oEnvEvento, oParam, oParam.versao);
                    xmlRetEnvEvento = XMLUtils.GetXML(oRetEnvEvento, versao);

                }
                catch (Exception ex)
                {
                    connectionOk = ConsultaStatus();

                    throw ex;
                }
            }
            catch (Exception ex)
            {
                CriaLog(999, "RecepcaoEvento", ex);
            }
            finally
            {
                oRetEnvEvento = null;
                oEnvEvento = null;
            }
        }

        /// <summary>
        /// Executa servico do webservice de consulta protocolo, testando antes se webservice esta funcionando.
        /// </summary>
        /// <param name="ChaveNFe">chave da nfe a ser consultada sem o NFe.</param>
        /// <returns>ok - true(oParam.pastaRecibo + ChaveNFe + "-sit.xml") | erro - false </returns>
        /// 
        public Boolean ConsultaProcNFe(String ChaveNFe)
        {
            ITConsSitNFe oConsSitNFe;
            ITRetConsSitNFe oRetConsSitNFe;

            //if (ConsultaStatus())
            //retirado para atender as regras de boas praticas da SEFAZ
            //{
            //Comunicação OK
            try
            {

                oConsSitNFe = (ITConsSitNFe)XMLUtils.XMLFactory(oParam.versao, "TConsSitNFe");
                oConsSitNFe.chNFe = ChaveNFe;
                oConsSitNFe.tpAmb = oParam.tipoAmbiente;
                if (oParam.versao == VersaoXML.NFe_v200)
                    oConsSitNFe.versao = TVerConsSitNFe.Item201;
                else if (oParam.versao == VersaoXML.NFe_v300)
                    oConsSitNFe.versao = TVerConsSitNFe.Item300;
                else if (oParam.versao == VersaoXML.NFe_v310)
                    oConsSitNFe.versao = TVerConsSitNFe.Item310;

                if (!Directory.Exists(oParam.pastaRecibo))
                    Directory.CreateDirectory(oParam.pastaRecibo);

                if (File.Exists(oParam.pastaRecibo + ChaveNFe + "-ped-sit.xml"))
                    File.Delete(oParam.pastaRecibo + ChaveNFe + "-ped-sit.xml");

                XMLUtils.SalvaXML(oParam.pastaRecibo + ChaveNFe + "-ped-sit.xml", oConsSitNFe, oParam.versao);

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = NFeUtils.ClientProxyFactory(oParam, TServico.Consulta);

                try
                {
                    // Executa servico
                    oRetConsSitNFe = Servicos.ConsultarSituacaoNFe(oServico, oConsSitNFe, oParam, oParam.versao);

                    XMLUtils.SalvaXML(oParam.pastaRecibo + ChaveNFe + "-sit.xml", oRetConsSitNFe, oParam.versao);

                    return true;
                }
                catch (Exception ex)
                {
                    connectionOk = ConsultaStatus();
                    throw ex;
                }

            }
            catch (Exception ex)
            {
                CriaLog(999, "ConsultaProcNFe", ex, ChaveNFe);
                return false;
            }
            finally
            {
                oRetConsSitNFe = null;
                oConsSitNFe = null;
            }
            //}
            //else
            //{
            //    return false;
            //}

        }

        public void InutilizaNumeracao(ITInutNFe oInutNFe, ref String cStat, ref String xMotivo, VersaoXML versao)
        {
            ITRetInutNFe oRetInutNFe;

            try
            {

                String nomeArquivoPedido = oParam.pastaRecibo + oInutNFe.infInut.Id + "-pi.xml";
                String nomeArquivoPedidoAss = oParam.pastaRecibo + oInutNFe.infInut.Id + "-ped-inu.xml";

                if (File.Exists(nomeArquivoPedido))
                    File.Delete(nomeArquivoPedido);

                //salvar o arquivo
                XMLUtils.SalvaXML(nomeArquivoPedido, oInutNFe, versao);

                //assinar pedido
                X509Certificate2 certificadoX509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);
                var resultadoAssinatura = NFeUtils.AssinaXML(nomeArquivoPedido, "infInut", certificadoX509, versao);
                certificadoX509 = null;

                //apaga arquivo sem assinatura : -pi.xml
                if (File.Exists(nomeArquivoPedido))
                    File.Delete(nomeArquivoPedido);

                //avaliar retorno da assinatura
                if (resultadoAssinatura.codigoRetorno == TRetornoAssinatura.Assinada)
                {
                    String erros = NFeUtils.ValidacaoXML(nomeArquivoPedidoAss,
                                                  oParam.pastaXSD + "inutNFe_v" + oParam.versaoDados + ".xsd");

                    if (erros != System.String.Empty)      //problema : xml nao validado.
                    {
                        throw new Exception("Não foi possível validar o arquivo de Pedido de Inutilização.");
                    }
                    else if (erros == "NotFound")
                    {
                        throw new Exception("Não foi possível encontrar o arquivo de Pedido de Inutilização.");
                    }
                    else //ESTA TUDO OK 
                    {
                        //carrega o pedido assinado
                        oInutNFe = (ITInutNFe)XMLUtils.CarregaXML_HD(nomeArquivoPedidoAss, oParam.versao, "TInutNFe");
                        //cria servico
                        System.Web.Services.Protocols.SoapHttpClientProtocol oServico = NFeUtils.ClientProxyFactory(oParam, TServico.Inutilizacao);
                        try
                        {
                            //executa servico
                            oRetInutNFe = Servicos.InutilizarNFe(oServico, oInutNFe, oParam, oParam.versao);
                            //setar variaveis de retorno
                            cStat = oRetInutNFe.infInut.cStat;
                            xMotivo = oRetInutNFe.infInut.xMotivo;
                            //salva resultado no HD
                            XMLUtils.SalvaXML(nomeArquivoPedidoAss.Replace("-ped", ""), oRetInutNFe, versao);

                            //integracao
                            NFeUtils.GeraRetornoInutilizacaoNFe(oInutNFe.infInut.Id, cStat, xMotivo, oParam.pastaSaida);
                        }
                        catch (Exception ex)
                        {
                            connectionOk = ConsultaStatus();

                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //integracao
                NFeUtils.GeraRetornoInutilizacaoNFe(oInutNFe.infInut.Id, "0", "Falha na inutilizacao - " + ex.Message, oParam.pastaSaida);
                CriaLog(999, "InutilizaNumeracao", ex);
            }
            finally
            {
                oRetInutNFe = null;
            }
        }

        public bool AtualizarNFePeloID(NotaFiscal oNotaFiscal, out string mensagemErro)
        {
            try
            {
                if (ConsultaProcNFe(oNotaFiscal.chaveNota.Replace("NFe", "")))
                {
                    ITRetConsSitNFe oRetConsSitNFe = (ITRetConsSitNFe)XMLUtils.CarregaXML_HD(oParam.pastaRecibo + oNotaFiscal.chaveNota.Replace("NFe", "") + "-sit.xml", oNotaFiscal.versao, "TRetConsSitNFe");

                    //100-uso autorizado, 150-uso autorizado fora de prazo
                    //101-cancelado ou 151-cancelado fora de prazo.
                    //155-cancelado por evento fora do prazo
                    if (oRetConsSitNFe.cStat == "100" || oRetConsSitNFe.cStat == "150"
                        || oRetConsSitNFe.cStat == "101" || oRetConsSitNFe.cStat == "151"
                        || oRetConsSitNFe.cStat == "155" || oRetConsSitNFe.cStat == "110")
                    {
                        #region recuperar protocolo
                        if (oRetConsSitNFe.protNFe == null || oRetConsSitNFe.protNFe.infProt == null)
                        {
                            //nao foi possivel obter a situação da NFE
                            mensagemErro = "Erro no XML. Nota foi aprovada mas protocolo de autorização não esta acesível";
                            return false;
                        }
                        #endregion

                        ITNFe oNFeXML = (ITNFe)XMLUtils.CarregaXML_STR(oNotaFiscal.xmlNota, oNotaFiscal.versao, "TNFe");

                        if (oNFeXML.Signature == null || oNFeXML.Signature.SignedInfo == null ||
                            oNFeXML.Signature.SignedInfo.Reference == null)
                        {
                            mensagemErro = "Não foi possível carregar o DigestValue da NFe requisitada.";
                            return false;
                        }

                        if (Convert.ToBase64String(oRetConsSitNFe.protNFe.infProt.digVal) !=
                            Convert.ToBase64String(oNFeXML.Signature.SignedInfo.Reference.DigestValue))
                        {
                            mensagemErro = "DigestValue da NFe requisitada não corresponde ao DigestValue da NFe aprovada.";
                            return false;
                        }
                        //documento conferido
                        if (oRetConsSitNFe.protNFe.infProt.nProt == null)
                        {
                            mensagemErro = "Não foi possível recuperar o nProt da aprovação da NFe.";
                            return false;
                        }

                        oNotaFiscal.dataSituacao = DateTime.Now;
                        oNotaFiscal.cStat = oRetConsSitNFe.cStat;
                        oNotaFiscal.xMotivo = oRetConsSitNFe.xMotivo;

                        //dados da Autorização
                        oNotaFiscal.nProt = oRetConsSitNFe.protNFe.infProt.nProt;
                        oNotaFiscal.xmlProcesso = XMLUtils.GetXML(oRetConsSitNFe.protNFe, oNotaFiscal.versao);

                        //dados do cancelamento
                        if ((oRetConsSitNFe.retCancNFe != null && oRetConsSitNFe.retCancNFe.infCanc != null
                            && !String.IsNullOrEmpty(oRetConsSitNFe.retCancNFe.infCanc.nProt)))
                        {
                            oNotaFiscal.nProtCancelamento = oRetConsSitNFe.retCancNFe.infCanc.nProt;
                            oNotaFiscal.xmlProcessoCancelamento = XMLUtils.GetXML(oRetConsSitNFe.retCancNFe, oNotaFiscal.versao).Replace("TRetCancNFe_v200107", "retCancNFe");
                        }

                        //dados dos eventos
                        if (oRetConsSitNFe.procEventoNFe != null)
                        {
                            foreach (var item in oRetConsSitNFe.procEventoNFe)
                            {
                                //atualizar o XML Reposta do Evento
                                ITRetEnvEvento XmlRespostaEvento = (ITRetEnvEvento)XMLUtils.XMLFactory(oNotaFiscal.versao, "TRetEnvEvento");
                                XmlRespostaEvento.tpAmb = oParam.tipoAmbiente;
                                XmlRespostaEvento.retEvento = (ITretEvento[])XMLUtils.XMLFactory(oNotaFiscal.versao, "TretEvento[]", 1);
                                XmlRespostaEvento.retEvento[0] = item.retEvento;

                                bool eventoEncontrado = false;
                                #region verificar se evento já existe no banco
                                foreach (Evento oEvento in oNotaFiscal.CarregarEventos(manager).Where(ev => ev.tpEvento.GetXmlEnumAttributeValueFromEnum() == item.evento.infEvento.tpEvento))
                                {
                                    if (!String.IsNullOrEmpty(oEvento.XMLPedido))
                                    {
                                        ITEvento XmlEvento =
                                            (ITEvento)
                                            XMLUtils.CarregaXML_STR(oEvento.XMLPedido, oNotaFiscal.versao, "TEvento");

                                        //comparar pela assinatura
                                        if (Convert.ToBase64String(XmlEvento.Signature.SignedInfo.Reference.DigestValue) ==
                                        Convert.ToBase64String(item.evento.Signature.SignedInfo.Reference.DigestValue))
                                        {
                                            if (String.IsNullOrEmpty(oEvento.XMLResposta))
                                            {
                                                oEvento.XMLResposta = XMLUtils.GetXML(XmlRespostaEvento, oNotaFiscal.versao);
                                            }

                                            switch (item.retEvento.infEvento.cStat)
                                            {
                                                case "135": oEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado135; break;
                                                case "136": oEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado136; break;
                                                case "155": oEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado155; break;
                                            }

                                            //salvar evento
                                            oEvento.Save(manager);

                                            //se for evento de cancelamento
                                            if (oEvento.tpEvento == TEventoInfEventoTpEvento.Cancelamento)
                                            {
                                                //atualizar nProt de cancelamento
                                                oNotaFiscal.nProtCancelamento = item.retEvento.infEvento.nProt;
                                            }
                                            eventoEncontrado = true;
                                            break;
                                        }
                                    }
                                    #endregion
                                }
                                if (!eventoEncontrado)
                                {
                                    #region criar novo evento
                                    Evento oNovoEvento = new Evento();
                                    oNovoEvento.XMLPedido = XMLUtils.GetXML(item.evento, oNotaFiscal.versao);
                                    oNovoEvento.XMLResposta = XMLUtils.GetXML(XmlRespostaEvento, oNotaFiscal.versao);
                                    switch (item.retEvento.infEvento.cStat)
                                    {
                                        case "135": oNovoEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado135; break;
                                        case "136": oNovoEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado136; break;
                                        case "155": oNovoEvento.codigoSituacao = TipoSituacaoEvento.FinalizadoAprovado155; break;
                                    }
                                    oNovoEvento.tpEvento = item.evento.infEvento.tpEvento.GetEnumFromXmlEnumAttributeValue<TEventoInfEventoTpEvento>();
                                    #region Pegar o ultimo lote criado.
                                    EventoQry oTbEventoQry = new EventoQry();
                                    oTbEventoQry.empresa = oParam.empresa;
                                    int numeroNovoLote = EventoDAL.Instance.GetMax(oTbEventoQry, manager);
                                    #endregion
                                    oNovoEvento.id = numeroNovoLote;
                                    oNovoEvento.empresa = oNotaFiscal.empresa;
                                    oNovoEvento.chaveNota = oNotaFiscal.chaveNota;
                                    oNovoEvento.numeroLote = oNotaFiscal.numeroLote;
                                    oNovoEvento.Save(manager);
                                    #endregion

                                    XmlRespostaEvento = null;
                                }
                            }
                        }

                        #region situação atual da NFe
                        if (oRetConsSitNFe.cStat == "100" || oRetConsSitNFe.cStat == "150")
                        {
                            oNotaFiscal.codigoSituacao = TipoSituacaoNota.Aprovada;// 13;//nota Aprovada
                            oNotaFiscal.descricaoSituacao = "Nota Aprovada";
                        }
                        else if (oRetConsSitNFe.cStat == "101" || oRetConsSitNFe.cStat == "151"
                        || oRetConsSitNFe.cStat == "155")
                        {
                            oNotaFiscal.codigoSituacao = TipoSituacaoNota.Cancelada;// 16;//nota cancelada
                            oNotaFiscal.descricaoSituacao = "Nota Cancelada";
                        }
                        else if (oRetConsSitNFe.cStat == "110")
                        {
                            oNotaFiscal.codigoSituacao = TipoSituacaoNota.Denegada;
                            oNotaFiscal.descricaoSituacao = "Uso Denegado";
                        }
                        else
                        {
                            mensagemErro = "Situação não mapeada. - " + oRetConsSitNFe.cStat;
                            return false;
                        }
                        #endregion

                        oNotaFiscal.Save(manager);

                        oNFeXML = null;
                    }
                    else
                    {
                        //nota nao foi aprovada
                        mensagemErro = oRetConsSitNFe.xMotivo;
                        return false;
                    }

                    oRetConsSitNFe = null;

                    mensagemErro = "Dados da NFe atualizados.";
                    return true;
                }
                else
                {
                    //nao foi possivel obter a situacao da NFE
                    mensagemErro = "Não foi possível obter a situação da NFe";
                    return false;
                }
            }
            catch (Exception ex)
            {
                CriaLog(999, "Atualizar situação pela chave", ex);
                mensagemErro = (ex.Message);
                return false;
            }
        }
    }
}

