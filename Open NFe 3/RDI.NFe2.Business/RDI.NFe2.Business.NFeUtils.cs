using System;
using System.IO;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;
using RDI.NFe2.SchemaXML;
using RDI.NFe2.ORMAP;
using RDI.Lince;
using System.Threading;
using RDI.OpenSigner;
using RDI.NFe2.Webservices;
using System.Linq;

namespace RDI.NFe2.Business
{
    public static class NFeUtils
    {
        public static byte[] GerarDANFePDF(string nfeProc, string urlLogo)
        {
            return OpenDanfe.DANFe.Gerar(nfeProc, urlLogo);
        }

        public static byte[] GerarDaEventoPDF(string nfeProc, string eventoProc, string urlLogo)
        {
            return OpenDanfe.DaEvento.Gerar(nfeProc, eventoProc, urlLogo);
        }


        public static void ThreadMasterExecution(Object oThreadIdetificada)
        {
            ThreadIdetificada oTh = (ThreadIdetificada)oThreadIdetificada;
            String ConAux = (String)oTh.args[0];
            String empresa = (String)oTh.args[1];
            bool enviarErro = false;

            if (oTh.args.Length > 2)
                enviarErro = (bool)oTh.args[2];

            ClientEnvironment manager = null;
            FuncaoAutomacao oFuncao = null;
            try
            {
                oTh.executando = true;
                oTh.DoOnStart(null, new StatusEventArgs() { empresa = empresa });

                manager = Conexao.CreateManager(ConAux);
                oFuncao = new FuncaoAutomacao(empresa, manager, enviarErro);

                oFuncao.CriaLog(998, "Serviço de monitoramento inicializado com sucesso.");


                DateTime dataUltimaExecucao = DateTime.Now;
                Int32 totalMilliSecondsTime = 1000;

                while (!oTh.finalizar)
                {

                    TimeSpan elapsed = DateTime.Now.Subtract(dataUltimaExecucao);
                    if (elapsed.TotalMilliseconds < totalMilliSecondsTime)
                    {
                        Double delay = totalMilliSecondsTime - elapsed.TotalMilliseconds;

                        try
                        {
                            Thread.Sleep((int)delay);
                        }
                        catch { }
                    }
                    else
                    {
                        //verificar estado da conexao
                        if (manager.connection.State != System.Data.ConnectionState.Open)
                        {
                            //conexao não esta aberta
                            manager = Conexao.CreateManager(ConAux);
                            oFuncao.UpdateManager(manager);
                        }

                        dataUltimaExecucao = DateTime.Now;

                        NFeUtils.GeraHeartBeat(true, empresa);

                        oFuncao.DoOnLoop(false, "");
                    }

                }

                oTh.executando = false;
                oTh.DoOnStop(null, new StatusEventArgs() { empresa = empresa });
                oFuncao.CriaLog(997, "Serviço de monitoramento paralizado com sucesso.");
            }
            catch (Exception ex)
            {
                ExceptionEventArgs ev = new ExceptionEventArgs();
                ev.error = ex;
                oTh.DoOnError(null, ev);
            }
            finally
            {
                oFuncao = null;
                oTh.executando = false;
                oTh.finalizado = true;
                Conexao.DisposeManager(manager);
            }
        }


        public static void ImprimeDANFe(NotaFiscal oNotaProc, Parametro oParam, ClientEnvironment manager)
        {
            //var stVersao = "_v2.00";
            //if (oNFe.versao == VersaoXML.NFe_v310)
            //{
            //    stVersao = "_v3.10";
            //}
            var stVersao = VersaoXML.NFe_v310.ToString().Replace("NFe", "");

            String nomeArquivo = oNotaProc.nProt + stVersao + "-procNFe.xml";
            string nomeArquivoProcesso = oParam.pastaSaida + nomeArquivo;
            NFeUtils.GeraArquivoProcNFe(oNotaProc, nomeArquivoProcesso, oParam.versaoDados);

            if (!File.Exists(nomeArquivoProcesso))
                throw new Exception("Não foi possível localizar o arquivo de processo : " + oParam.pastaSaida + nomeArquivo);

            File.Copy(nomeArquivoProcesso, oParam.pastaImpressao + nomeArquivo, true);

            oNotaProc.codigoSituacao = TipoSituacaoNota.Impressa;// 15;//impressa
            oNotaProc.descricaoSituacao = "Nota Impressa";
            oNotaProc.dataSituacao = DateTime.Now;

            oNotaProc.Save(manager);

            //integracao
            try
            {
                MMCustom.MMUtils.ImprimeDanfe(oNotaProc.chaveNota,
                        (int)oNotaProc.codigoSituacao,
                        oNotaProc.descricaoSituacao,
                        oNotaProc.cStat,
                        oNotaProc.xMotivo,
                        oNotaProc.nProt,
                        nomeArquivoProcesso);
            }
            catch { }


        }



        /// <summary>
        /// gera arquivo de divulgacao da nfe
        /// NfeProc
        /// NfeProc-NFe
        /// NfeProc-ProtNFe
        /// </summary>
        /// <param name="oNotaAprovada"></param>
        /// <param name="nomeArquivo"></param>
        /// <param name="versaoDados"></param>
        public static void GeraArquivoProcNFe(NotaFiscal oNotaAprovada, string nomeArquivo, string versaoDados)
        {
            if (String.IsNullOrEmpty(oNotaAprovada.xmlNota) ||
                String.IsNullOrEmpty(oNotaAprovada.xmlProcesso))
            {
                throw new Exception("XML Nota ou XML Aprovação não existe");
            }

            ITNfeProc oNFeProc = (ITNfeProc)XMLUtils.XMLFactory(oNotaAprovada.versao, "TNfeProc");
            oNFeProc.versao = versaoDados;
            oNFeProc.NFe = (ITNFe)XMLUtils.LoadXML(oNotaAprovada.xmlNota, oNotaAprovada.versao, "TNFe");
            oNFeProc.protNFe = (ITProtNFe)XMLUtils.LoadXML(oNotaAprovada.xmlProcesso, oNotaAprovada.versao, "TProtNFe");

            if (File.Exists(nomeArquivo))
                File.Delete(nomeArquivo);

            XMLUtils.SaveXML(nomeArquivo, oNFeProc, oNotaAprovada.versao);
        }

        /// <summary>
        /// gera arquivo de divulgacao do cancelamento da nfe
        /// ProcCancNFe
        /// ProcCancNFe-cancNFe
        /// ProcCancNFe-retCancNFe
        /// </summary>
        /// <param name="oNotaCancelada"></param>
        /// <param name="nomeArquivo"></param>
        /// <param name="versaoDados"></param>
        public static void GeraArquivoProcCancNFe(NotaFiscal oNotaCancelada, string nomeArquivo, string versaoDados)
        {
            if (String.IsNullOrEmpty(oNotaCancelada.xmlPedidoCancelamento) ||
                String.IsNullOrEmpty(oNotaCancelada.xmlProcessoCancelamento))
            {
                throw new Exception("XML Pedido ou XML Aprovação do Cancelamento não existe");
            }

            ITProcCancNFe oCancProc = (ITProcCancNFe)XMLUtils.XMLFactory(oNotaCancelada.versao, "TProcCancNFe");
            oCancProc.versao = versaoDados;
            oCancProc.cancNFe = (ITCancNFe)XMLUtils.LoadXML(oNotaCancelada.xmlPedidoCancelamento, oNotaCancelada.versao, "TCancNFe");
            oCancProc.retCancNFe = (ITRetCancNFe)XMLUtils.LoadXML(oNotaCancelada.xmlProcessoCancelamento, oNotaCancelada.versao, "TRetCancNFe");

            if (File.Exists(nomeArquivo))
                File.Delete(nomeArquivo);

            XMLUtils.SaveXML(nomeArquivo, oCancProc, oNotaCancelada.versao);
        }

        /// <summary>
        /// gera arquivo de divulgacao do registro de evento da nfe
        /// ProcEvento
        /// ProcEvento-evento
        /// ProcEvento-retEvento
        /// </summary>
        /// <param name="oEvento"></param>
        /// <param name="nomeArquivo"></param>
        /// <param name="versaoDados"></param>
        public static void GeraArquivoProcEventoNFe(Evento oEvento, string nomeArquivo, VersaoXML versao)
        {
            if (String.IsNullOrEmpty(oEvento.XMLPedido) ||
               String.IsNullOrEmpty(oEvento.XMLResposta))
            {
                throw new Exception("XML Pedido ou XML Aprovação do Evento não existe");
            }

            var versaoDados = string.Empty;


            //gerar evento
            ITProcEvento oProcEvento = (ITProcEvento)XMLUtils.XMLFactory(versao, "TProcEvento");
            oProcEvento.versao = "1.00";
            oProcEvento.evento = (ITEvento)XMLUtils.LoadXML(oEvento.XMLPedido, oEvento.versao, "TEvento");
            oProcEvento.retEvento = ((ITRetEnvEvento)XMLUtils.LoadXML(oEvento.XMLResposta, oEvento.versao, "TRetEnvEvento")).retEvento[0];

            if (File.Exists(nomeArquivo))
                File.Delete(nomeArquivo);

            XMLUtils.SaveXML(nomeArquivo, oProcEvento, versao);

        }

        public static void GeraRetornoCancelamentoNFe(string chNFe, string cStat, string xMotivo, string dirCaixaSaida, string origem = "")
        {
            try
            {
                if (!dirCaixaSaida.EndsWith("\\"))
                    dirCaixaSaida += "\\";

                var stNomeArq = dirCaixaSaida + chNFe + "-retornoCancelamento.xml";

                //remover prefixo
                if (!string.IsNullOrEmpty(chNFe))
                {
                    chNFe = chNFe.Replace("NFe", "");
                }
                else
                {
                    var nome = origem.Replace("evtCanc_", "").Replace(".xml", "");
                    stNomeArq = dirCaixaSaida + nome + "-retornoCancelamento.xml";
                }

                RDI.NFe2.SchemaXML.TIntegracao oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao.versao = TIntegracaoVersao.Item100;
                var item = new RDI.NFe2.SchemaXML.TRetornoCancelamento();
                item.chNFe = chNFe;
                item.cStat = cStat;
                item.xMotivo = xMotivo;
                item.aprovado = (cStat == "135" || cStat == "136" || cStat == "155");
                item.origem = origem;
                oIntegracao.item = item;


                if (File.Exists(stNomeArq))
                    File.Delete(stNomeArq);

                XMLUtils.SaveXML(stNomeArq, oIntegracao, VersaoXML.Integracao);
            }
            catch { }
        }

        public static void GeraRetornoInutilizacaoNFe(string inutID, string cStat, string xMotivo, string dirCaixaSaida)
        {
            try
            {
                RDI.NFe2.SchemaXML.TIntegracao oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao.versao = TIntegracaoVersao.Item100;
                var item = new RDI.NFe2.SchemaXML.TRetornoInutilizacao();
                item.inutID = inutID;
                item.cStat = cStat;
                item.xMotivo = xMotivo;
                item.aprovado = (cStat == "102");
                oIntegracao.item = item;

                if (!dirCaixaSaida.EndsWith("\\"))
                    dirCaixaSaida += "\\";

                var stNomeArq = dirCaixaSaida + inutID + "-retornoInutilizacao.xml";
                if (File.Exists(stNomeArq))
                    File.Delete(stNomeArq);

                XMLUtils.SaveXML(stNomeArq, oIntegracao, VersaoXML.Integracao);
            }
            catch { }
        }

        public static void GeraRejeicaoNFe(string chNFe, string cStat, string xMotivo, string dirCaixaSaida)
        {
            try
            {
                if (!dirCaixaSaida.EndsWith("\\"))
                    dirCaixaSaida += "\\";

                var stNomeArq = dirCaixaSaida + chNFe + "-rejeicaoNFe.xml";

                //remover prefixo
                if (!string.IsNullOrEmpty(chNFe))
                {
                    chNFe = chNFe.Replace("NFe", "");
                }
                else
                {
                    //chave não veio
                    var nome = DateTime.Now.Ticks.ToString();
                    stNomeArq = dirCaixaSaida + nome + "-rejeicaoNFe.xml";
                }

                RDI.NFe2.SchemaXML.TIntegracao oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao.versao = TIntegracaoVersao.Item100;
                var item = new RDI.NFe2.SchemaXML.TRejeicao();
                item.chNFe = chNFe;
                item.cStat = cStat;
                item.xMotivo = xMotivo;
                oIntegracao.item = item;

                if (File.Exists(stNomeArq))
                    File.Delete(stNomeArq);

                XMLUtils.SaveXML(stNomeArq, oIntegracao, VersaoXML.Integracao);
            }
            catch { }
        }

        public static void GeraHeartBeat(bool emExecucao, string empresa)
        {
            try
            {
                RDI.NFe2.SchemaXML.TIntegracao oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao = new RDI.NFe2.SchemaXML.TIntegracao();
                oIntegracao.versao = TIntegracaoVersao.Item100;
                oIntegracao.item = new RDI.NFe2.SchemaXML.THeartBeat();
                ((RDI.NFe2.SchemaXML.THeartBeat)oIntegracao.item).horario = DateTime.Now;

                if (emExecucao)
                {
                    ((RDI.NFe2.SchemaXML.THeartBeat)oIntegracao.item).emExecucao = RDI.NFe2.SchemaXML.TSimNao.Sim;
                    ((RDI.NFe2.SchemaXML.THeartBeat)oIntegracao.item).horarioExecucao = DateTime.Now;
                    ((RDI.NFe2.SchemaXML.THeartBeat)oIntegracao.item).horarioExecucaoSpecified = true;
                }
                else
                {
                    ((RDI.NFe2.SchemaXML.THeartBeat)oIntegracao.item).emExecucao = RDI.NFe2.SchemaXML.TSimNao.Nao;
                }

                XMLUtils.SaveXML("heartbeat_" + empresa + ".xml", oIntegracao, VersaoXML.Integracao);
            }
            catch { }
        }

        public static SoapHttpClientProtocol ClientProxyFactory(Parametro parametro, object status)
        {
            throw new NotImplementedException();
        }

        public static void RemoveHeartBeat()
        {
            try
            {
                if (File.Exists("heartbeat.xml"))
                    File.Delete("heartbeat.xml");
            }
            catch { }
        }


        public static TCodUfIBGE DefineUF(String UF)
        {
            try
            {
                return (TCodUfIBGE)Enum.Parse(typeof(TCodUfIBGE), UF);
            }
            catch
            {
                throw new Exception("UF inválida");
            }
        }

        public static Enum DefineEnum(String value, Type EnumType)
        {
            foreach (FieldInfo field in EnumType.GetFields())
            {
                foreach (XmlEnumAttribute atr in field.GetCustomAttributes(typeof(XmlEnumAttribute), false))
                    if (atr.Name == value)
                        return (Enum)field.GetValue(atr);
            }
            throw new Exception("Item inexistente na listagem do tipo enumerado.");
        }


        //Função para cálculo de dígito verificador base 11 com resultado alfanumérico
        private static String DvBase11(String Numero)
        {
            try
            {

                Int32 Dv, Multiplicador;
                Multiplicador = 2;
                Dv = 0;
                for (Int32 I = Numero.Length - 1; I >= 0; I--)
                {
                    Dv += (Int32.Parse(Numero[I].ToString()) * Multiplicador);
                    Multiplicador++;
                    if (Multiplicador > 9)
                        Multiplicador = 2;
                }
                Dv = Dv % 11;
                if (Dv > 1)
                    return (11 - Dv).ToString();
                else
                    return "0";
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na geração da chave de acesso." + ex.Message);
            }


        }

        public static ResultadoAssinatura AssinaXML(String arqxml, String SUri, X509Certificate2 cert, VersaoXML versao)
        {
            var retorno = new ResultadoAssinatura();

            string _stringXml;
            string newArqXml;
            var stType = string.Empty;

            if (SUri == "infNFe")
            {
                stType = "TNFe";
                newArqXml = arqxml.Substring(0, arqxml.Length - 51) + "ass" + arqxml.Substring(arqxml.Length - 51, 51);
            }
            else if (SUri == "infCanc")
            {
                stType = "TCancNFe";
                newArqXml = arqxml.Substring(0, arqxml.Length - 7) + "-ped-can.xml";
            }
            else if (SUri == "infInut")
            {
                stType = "TInutNFe";
                newArqXml = arqxml.Substring(0, arqxml.Length - 7) + "-ped-inu.xml";
            }
            else if (SUri == "infEvento")
            {
                stType = "TEvento";
                newArqXml = arqxml.Substring(0, arqxml.Length - 7) + "-ass-env.xml";
            }
            else
            {
                retorno.codigoRetorno = TRetornoAssinatura.RefURiNaoExiste;// 4; //erro refURi
                return retorno;
            }


            //Verifica se arquivo da nota Existe;
            if (File.Exists(arqxml))
            {
                _stringXml = XMLUtils.GetXML(XMLUtils.LoadXMLFile(arqxml, versao, stType), versao);

                // realiza assinatura
                AssinaturaDigital AD = new AssinaturaDigital();

                retorno.codigoRetorno = AD.AssinarNFe(_stringXml, SUri, cert);

                //limpar certificado
                cert.Reset();

                //assinatura bem sucedida
                if (retorno.codigoRetorno == TRetornoAssinatura.Assinada)
                {
                    if (File.Exists(newArqXml))
                        File.Delete(newArqXml);

                    XMLUtils.SaveXML(newArqXml, (XMLUtils.LoadXML(AD.XMLStringAssinado, versao, stType)), versao);
                }
                else
                {
                    retorno.mensagem = AD.mensagemResultado;
                }

                return retorno; //Retorna o resultado da assinatura
            }
            else
            {
                retorno.codigoRetorno = TRetornoAssinatura.ArquivoNaoEncontrado;// 11;//Arquivo nao encontrado
                return retorno;
            }
        }

        private static string GetAmbWebService(Parametro oParam, TService tipoServico)
        {
            String ambiente = string.Empty;

            if (oParam.conexao == TipoConexao.NFCe)
            {
                //oParam.NFCe [HNC|PNC].[AtendidoPor].***
                if (oParam.tipoAmbiente == TAmb.Homologacao)
                    ambiente = "HNC.";
                else if (oParam.tipoAmbiente == TAmb.Producao)
                    ambiente = "PNC.";
                else
                    throw new Exception("Tipo de Ambiente não definido.");
            }
            else if (oParam.conexao == TipoConexao.GNRE)
            {
                //oParam.NFCe [HNC|PNC].[AtendidoPor].***
                if (oParam.tipoAmbiente == TAmb.Homologacao)
                    ambiente = "HWG.";
                else if (oParam.tipoAmbiente == TAmb.Producao)
                    ambiente = "PWG.";
                else
                    throw new Exception("Tipo de Ambiente não definido.");
            }
            else
            {

                if ((tipoServico == TService.Autorizacao || tipoServico == TService.RetAutorizacao) && oParam.versao != VersaoXML.NFe_v310)
                    throw new ArgumentException("V200 não possui Webservice de " + tipoServico.ToString());


                // HNF|PNF :  são utilizados pelos novos servicos de todas as UFs e por todos os servicos de SP e PR
                // os demais servicos utilizam [HWS|PWS]
                if ((tipoServico != TService.Cadastro) && //Cadastro deverá usar PWS|HWS
                    (tipoServico != TService.ConsultaDFe) && //ConsultaDFe deverá usar PWS|HWS
                    (tipoServico != TService.DownloadNF) && //DownloadNF deverá usar PWS|HWS
                    (tipoServico != TService.ManifestacaoDestinatario) && //ManifestacaoDestinatario deverá usar PWS|HWS
                    (tipoServico == TService.Autorizacao || tipoServico == TService.RetAutorizacao
                    //particularidades
                    || (oParam.UF == TCodUfIBGE.RioGrandedoSul) //atualizado somente com os WS da versão 3.1 //25/05/2015
                    || (oParam.UF == TCodUfIBGE.SaoPaulo && oParam.versao == VersaoXML.NFe_v310)
                    || (oParam.UF == TCodUfIBGE.Parana && oParam.versao == VersaoXML.NFe_v310)
                    || (oParam.UF == TCodUfIBGE.Bahia && oParam.versao == VersaoXML.NFe_v310 && tipoServico != TService.RecepcaoEvento)))
                {
                    //[HNF|PNF].
                    if (oParam.tipoAmbiente == TAmb.Homologacao)
                        ambiente = "HNF.";
                    else if (oParam.tipoAmbiente == TAmb.Producao)
                        ambiente = "PNF.";
                    else
                        throw new Exception("Tipo de Ambiente não definido.");
                }
                else
                {
                    //[HWS|PWS].
                    if (oParam.tipoAmbiente == TAmb.Homologacao)
                        ambiente = "HWS.";
                    else if (oParam.tipoAmbiente == TAmb.Producao)
                        ambiente = "PWS.";
                    else
                        throw new Exception("Tipo de Ambiente não definido.");
                }
            }

            //Verificar de acordo com a UF e determinar qual webservice atende.
            if (oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.ContingenciaSVCAN ||
                oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.ContingenciaSVCRS)
            {
                //[SVC_AtendidoPor]oParam.UF.GetType().GetField(oParam.UF.ToString()).GetCustomAttributes(typeof(
                foreach (SVC_AtendidoPor atr in
                    oParam.UF.GetType().GetField(oParam.UF.ToString()).GetCustomAttributes(typeof(SVC_AtendidoPor), false))
                {
                    if (atr.ServidorAutorizador == TServer.NaoMapeado)
                        throw new Exception("UF não esta sendo atendida por nenhum WebService do SVC.");

                    ambiente += atr.ServidorAutorizador;
                }
            }
            else if (oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.ContigenciaSCAN)
            {
                ambiente += "SCAN";
            }
            else
            {
                //particularidade
                if (tipoServico == TService.Cadastro && oParam.UF == TCodUfIBGE.EspiritoSanto)
                {
                    ambiente += "ES";
                }
                else if (tipoServico == TService.ManifestacaoDestinatario || tipoServico == TService.ConsultaDFe || tipoServico == TService.DownloadNF)
                {
                    ambiente += "AN";
                }
                else
                {
                    if (oParam.conexao == TipoConexao.NFCe)
                    {
                        foreach (NFCe_AtendidoPor atr in oParam.UF.GetType().GetField(oParam.UF.ToString()).GetCustomAttributes(typeof(NFCe_AtendidoPor), false))
                        {
                            if (atr.ServidorAutorizador == TServer.NaoMapeado)
                                throw new Exception("UF não esta sendo atendida por nenhum WebService.");

                            ambiente += atr.ServidorAutorizador;
                        }
                    }
                    else if (oParam.conexao == TipoConexao.NFCe)
                    {
                        ambiente += "GNRE";
                    }
                    else
                    {
                        foreach (NFe_AtendidoPor atr in oParam.UF.GetType().GetField(oParam.UF.ToString()).GetCustomAttributes(typeof(NFe_AtendidoPor), false))
                        {
                            if (atr.ServidorAutorizador == TServer.NaoMapeado)
                                throw new Exception("UF não esta sendo atendida por nenhum WebService.");

                            ambiente += atr.ServidorAutorizador;
                        }
                    }
                }
            }
            return ambiente;

        }

        private static Assembly GetMyAssembly()
        {
            //todo : melhorar implementacao
            return typeof(FuncaoAutomacao).Assembly;
        }

        public static System.Web.Services.Protocols.SoapHttpClientProtocol ClientProxyFactory(Parametro oParam, TService TipoServico)
        {
            if (oParam.conexao == TipoConexao.NFe &&
                oParam.versao == VersaoXML.NFe_v400 &&
                (TipoServico == TService.Autorizacao ||
                 TipoServico == TService.RetAutorizacao ||
                 TipoServico == TService.ConsultaProtocolo ||
                 TipoServico == TService.Inutilizacao ||
                 TipoServico == TService.RecepcaoEvento ||
                 TipoServico == TService.Cadastro ||
                 TipoServico == TService.Status))
            {
                var AtendidoPor = (NFe_AtendidoPor)typeof(TCodUfIBGE).GetField(oParam.UF.ToString()).GetCustomAttributes(typeof(NFe_AtendidoPor), false).FirstOrDefault();
                if (AtendidoPor == null)
                    throw new Exception("UF não está associado com nenhum Servidor Autorizador.");

                string Ambiente = oParam.tipoAmbiente.ToString();

                return RDI.NFe2.Webservices.WSUtils.SoapHttpClientFactory(AtendidoPor.ServidorAutorizador, Ambiente, TipoServico);
            }
            else
            {
                //TODO : enviar todos os webservices ativos para o projeto rdi.nfe.webservices após a desativação da versao 3.10

                String ClassName = "";
                try
                {
                    string nomeClasse = string.Empty;
                    //buscar nome do metodo pelo tServico
                    foreach (ClasseServico atr in TipoServico.GetType().GetField(TipoServico.ToString()).GetCustomAttributes(typeof(ClasseServico), false))
                    {
                        if (String.IsNullOrEmpty(atr.NomeClasse))
                            throw new Exception("Serviço não esta associado com nenhuma classe cliente.");
                        nomeClasse = atr.NomeClasse;
                    }

                    //particularidades
                    if (oParam.UF == TCodUfIBGE.Bahia && oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.Normal)//Bahia
                    {
                        if (TipoServico == TService.Status && oParam.versao == VersaoXML.NFe_v310)
                            nomeClasse = "NfeStatusServico";

                        if (TipoServico == TService.ConsultaProtocolo && oParam.versao == VersaoXML.NFe_v310)
                            nomeClasse = "NfeConsulta";

                        if (TipoServico == TService.Inutilizacao && oParam.versao == VersaoXML.NFe_v310)
                            nomeClasse = "NfeInutilizacao";
                    }

                    var subNamespace = TipoServico.ToString();

                    if (TipoServico == TService.ConsultaProtocolo)
                        subNamespace = "Consulta";

                    ClassName = "RDI.NFe2.Business." + GetAmbWebService(oParam, TipoServico) + "." + subNamespace + ".";

                    String headerClassName = ClassName + "nfeCabecMsg";
                    ClassName += nomeClasse;

                    Type classType = GetMyAssembly().GetType(ClassName);

                    if (classType == null)
                        throw new Exception("Não foi possível definir o tipo do cliente de webservice. #ClientProxyFactory");

                    System.Web.Services.Protocols.SoapHttpClientProtocol oServico =
                        (System.Web.Services.Protocols.SoapHttpClientProtocol)System.Activator.CreateInstance(classType);

                    if (TipoServico != TService.ConsultaDFe) //ConsultaDFe não tem header
                    {
                        #region Instancia cabecalho

                        Type headerClassType = GetMyAssembly().GetType(headerClassName);

                        if (headerClassType == null)
                            throw new Exception("Não foi possível definir o tipo do header do cliente de webservice. #ClientProxyFactory");

                        System.Web.Services.Protocols.SoapHeader oCabecalho =
                            (System.Web.Services.Protocols.SoapHeader)System.Activator.CreateInstance(headerClassType);


                        if ((TipoServico == TService.ManifestacaoDestinatario) || //ManifestacaoDestinatario deverá usar AN 91
                            (TipoServico == TService.DownloadNF)) //DownloadNF deverá usar AN 91
                        {
                            oCabecalho.GetType().GetProperty("cUF").SetValue(oCabecalho, "91", null);
                        }
                        else
                        {
                            oCabecalho.GetType().GetProperty("cUF").SetValue(oCabecalho,
                                ((System.Xml.Serialization.XmlEnumAttribute)oParam.UF.GetType().GetField(
                                    oParam.UF.ToString()).GetCustomAttributes(
                                        typeof(System.Xml.Serialization.XmlEnumAttribute), false)[0]).Name,
                                                                             null);
                        }
                        string versao = oParam.versaoDados;

                        //particularidade para ConsSitNFe usando v200
                        if (TipoServico == TService.ConsultaProtocolo && oParam.versao == VersaoXML.NFe_v200)
                            versao = "2.01";

                        //Particularidade para RecepcaoEvento
                        if (TipoServico == TService.RecepcaoEvento)
                            versao = oParam.versaoDadosEventos;

                        //particularidade para consultaCadastro
                        if (TipoServico == TService.Cadastro)
                            versao = "2.00";

                        //particularidade para manifestacao destinatario
                        if (TipoServico == TService.ManifestacaoDestinatario || TipoServico == TService.DownloadNF)
                            versao = "1.00";

                        oCabecalho.GetType().GetProperty("versaoDados").SetValue(oCabecalho, versao, null);
                        oServico.GetType().GetProperty("nfeCabecMsgValue").SetValue(oServico, oCabecalho, null);
                        #endregion
                    }
                    return oServico;

                }
                catch (Exception ex)
                {
                    throw new Exception("ClientProxyFactory # não foi possível criar o cliente (" + ClassName + ") para acesso aos webservices da SEFAZ. InnerException: " + ex.Message);
                }
            }
        }

        public static string ValidacaoXML(String xml, String xsd)
        {
            ValidaXML oValidador = new ValidaXML();
            return oValidador.Validar(xml, xsd);
        }

        public static string RetiraAcentos(String retornoMsg)
        {
            retornoMsg = retornoMsg.Replace("ç", "c").Replace("Ç", "C").Replace("Ò", "O").Replace("ò", "o");
            retornoMsg = retornoMsg.Replace("ã", "a").Replace("Ã", "A").Replace("ö", "o").Replace("Ö", "O");
            retornoMsg = retornoMsg.Replace("é", "e").Replace("É", "E").Replace("à", "a").Replace("À", "A");
            retornoMsg = retornoMsg.Replace("í", "i").Replace("Í", "I").Replace("ì", "i").Replace("Ì", "i");
            retornoMsg = retornoMsg.Replace("õ", "o").Replace("Õ", "O").Replace("ó", "o").Replace("Ó", "O");
            retornoMsg = retornoMsg.Replace("ú", "u").Replace("Ú", "U").Replace("ù", "u").Replace("Ù", "U");
            retornoMsg = retornoMsg.Replace("ü", "u").Replace("Ü", "U").Replace("ä", "a").Replace("Ä", "A");
            retornoMsg = retornoMsg.Replace("á", "a").Replace("Á", "A").Replace("è", "e").Replace("È", "E");
            return retornoMsg;
        }

        public static IList Listar(Type tipo)
        {
            var lista = new List<KeyValuePair<int, string>>();
            if (tipo != null)
            {
                Array enumValores = Enum.GetValues(tipo);
                foreach (Enum valor in enumValores)
                {
                    lista.Add(new KeyValuePair<int, String>(Convert.ToInt32(valor), XMLUtils.GetDescriptionAttribute(valor)));
                }
            }

            lista.Sort(CompareKeyPair);
            return lista;
        }

        static int CompareKeyPair(KeyValuePair<int, string> a, KeyValuePair<int, string> b)
        {
            return a.Key.CompareTo(b.Key);
        }

        private static void AddNode(System.Xml.XmlNode inXmlNode, System.Windows.Forms.TreeNode inTreeNode)
        {
            System.Xml.XmlNode xNode;
            System.Windows.Forms.TreeNode tNode;
            System.Xml.XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new System.Windows.Forms.TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        public static void PopulaTreeView(System.Xml.XmlDocument xmlDoc, System.Windows.Forms.TreeView TreeXML)
        {
            PopulaTreeView(xmlDoc, TreeXML, false);
        }

        public static void PopulaTreeView(System.Xml.XmlDocument xmlDoc, System.Windows.Forms.TreeView TreeXML, bool Expande)
        {
            try
            {

                // SECTION 2. Initialize the TreeView control.
                TreeXML.Nodes.Clear();
                TreeXML.Nodes.Add(new System.Windows.Forms.TreeNode(xmlDoc.DocumentElement.Name));
                System.Windows.Forms.TreeNode tNode = new System.Windows.Forms.TreeNode();
                tNode = TreeXML.Nodes[0];

                // SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(xmlDoc.DocumentElement, tNode);
                if (Expande)
                    TreeXML.ExpandAll();
            }
            catch (System.Xml.XmlException xmlEx)
            {
                System.Windows.Forms.MessageBox.Show(xmlEx.Message);
            }
        }

        public static void AddToFile(string contents, Boolean canLog, String FileName)
        {
            if (canLog)
            {
                String pathPFileName = AppDomain.CurrentDomain.BaseDirectory + FileName;

                while (IsFileOpen(pathPFileName))
                { }

                FileStream fs = null;

                if (File.Exists(FileName))
                {
                    fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + FileName, FileMode.Open, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + FileName, FileMode.Open, FileAccess.Write);
                }

                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(DateTime.Now + " : " + contents);
                sw.Flush();
                sw.Close();
            }
        }

        private static bool IsFileOpen(string filePath)
        {
            bool fileOpened = false;
            try
            {
                System.IO.FileStream fs = System.IO.File.OpenWrite(filePath);
                fs.Close();
            }
            catch
            {
                fileOpened = true;
            }

            return fileOpened;
        }
    }
}
