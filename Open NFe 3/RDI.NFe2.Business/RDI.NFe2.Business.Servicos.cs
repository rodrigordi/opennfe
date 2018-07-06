using System;
using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using System.Collections;
using System.ComponentModel;
using RDI.NFe2.SchemaXML;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Web.Services.Protocols;
using System.Net;
using System.Net.Cache;
using System.Runtime.Serialization;
using System.Text;
using RDI.NFe2.ORMAP;
using System.IO.Compression;
using System.Collections.Generic;
using RDI.OpenSigner;
using RDI.NFe2.SchemaXML.GNRE;
using RDI.NFe2.SchemaXML.DocumentosFiscaisEletronicos_v101;
using RDI.NFe2.Webservices;

namespace RDI.NFe2.Business
{
    public static class Servicos
    {
        public static string VersaoBusiness { get { return "v3.12.0.2"; } }



        public static ITRetEnvEvento EnviarEnvelopeEvento(SoapHttpClientProtocol oServico, ITEnvEvento oEnvEvento, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetEnvEvento, ITEnvEvento>(oServico, TService.RecepcaoEvento, oEnvEvento, oParam, versao, "TRetEnvEvento");
        }

        public static ITRetEnviNFe EnviarEnvelope(SoapHttpClientProtocol oServico, ITEnviNFe oEnviNFe, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetEnviNFe, ITEnviNFe>(oServico, TService.Autorizacao, oEnviNFe, oParam, versao, "TRetEnviNFe");
        }

        public static ITRetConsReciNFe ConsultarProcessamentoEnvelope(SoapHttpClientProtocol oServico, ITConsReciNFe oConsReciNFe, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetConsReciNFe, ITConsReciNFe>(oServico, TService.RetAutorizacao, oConsReciNFe, oParam, versao, "TRetConsReciNFe");
        }

        public static ITRetConsStatServ ConsultarStatusServidor(SoapHttpClientProtocol oServico, ITConsStatServ oConsStatServ, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetConsStatServ, ITConsStatServ>(oServico, TService.Status, oConsStatServ, oParam, versao, "TRetConsStatServ");
        }

        public static ITRetInutNFe InutilizarNFe(SoapHttpClientProtocol oServico, ITInutNFe oInutNFe, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetInutNFe, ITInutNFe>(oServico, TService.Inutilizacao, oInutNFe, oParam, versao, "TRetInutNFe");
        }

        public static ITRetConsSitNFe ConsultarSituacaoNFe(SoapHttpClientProtocol oServico, ITConsSitNFe oConsSitNFe, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetConsSitNFe, ITConsSitNFe>(oServico, TService.ConsultaProtocolo, oConsSitNFe, oParam, versao, "TRetConsSitNFe");
        }

        public static ITRetConsCad ConsultarCadastro(SoapHttpClientProtocol oServico, ITConsCad oEnviNFe3, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetConsCad, ITConsCad>(oServico, TService.Cadastro, oEnviNFe3, oParam, versao, "TRetConsCad");
        }

        public static IRetDistDFeInt ConsultarDFe(SoapHttpClientProtocol oServico, IDistDFeInt xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<IRetDistDFeInt, IDistDFeInt>(oServico, TService.ConsultaDFe, xmlEnvio, oParam, versao, "retDistDFeInt");
        }

        public static ITRetDownloadNFe DownloadNF(SoapHttpClientProtocol oServico, ITDownloadNFe xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<ITRetDownloadNFe, ITDownloadNFe>(oServico, TService.DownloadNF, xmlEnvio, oParam, versao, "TRetDownloadNFe");
        }

        public static TRetLote_GNRE GNRERecepcaoLote(SoapHttpClientProtocol oServico, TLote_GNRE xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<TRetLote_GNRE, TLote_GNRE>(oServico, TService.GNRE_RecepcaoLote, xmlEnvio, oParam, oParam.versao, "TRetLote_GNRE");
        }

        public static TResultLote_GNRE GNREConsultaLote(SoapHttpClientProtocol oServico, TConsLote_GNRE xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<TResultLote_GNRE, TConsLote_GNRE>(oServico, TService.GNRE_ConsultaLote, xmlEnvio, oParam, oParam.versao, "TResultLote_GNRE");
        }

        public static TConfigUf GNREConfigUF(SoapHttpClientProtocol oServico, TConsultaConfigUf xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return ExecutaServico<TConfigUf, TConsultaConfigUf>(oServico, TService.GNRE_ConsultaLote, xmlEnvio, oParam, oParam.versao, "TConfigUf");
        }

        private static R ExecutaServico<R, S>(SoapHttpClientProtocol oServico, TService TipoServico, S xmlEnvio, Parametro oParam, VersaoXML versao, string stTipo)
        {
            var xmlRetorno = InternalExecutaServico(oServico, TipoServico, xmlEnvio, oParam);
            try
            {
                return (R)XMLUtils.LoadXML(xmlRetorno, versao, stTipo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deserializar ({ex.Message}) o retorno do WebService ({xmlRetorno})");
            }
        }


        private static void InicializaServico(System.Web.Services.Protocols.SoapHttpClientProtocol oServico, Parametro oParam)
        {
            X509Certificate2 certificadoX509 = Certificado.Carregar(oParam.certificado, oParam.tipoBuscaCertificado);

            oServico.ClientCertificates.Clear();
            oServico.ClientCertificates.Add(certificadoX509);
            if (oParam.prx)
            {
                oServico.Proxy = new WebProxy(oParam.prxUrl, true);
                oServico.Proxy.Credentials = new NetworkCredential(oParam.prxUsr, oParam.prxPsw, oParam.prxDmn);
            }
            else
            {
                oServico.Credentials = System.Net.CredentialCache.DefaultCredentials;
            }
            oServico.Timeout = (int)oParam.timeout;
            oServico.InitializeLifetimeService();

            // forçar aceitação de todos os certificados dos servidores da SEFAZ
            // independentemente de ter a cadeia de certificação instalada
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            if (oParam.versao == VersaoXML.NFe_v400)
            {
                //permitir somente o protocolo: TLS1.2 
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }
            else
            {
                //permitir os protocolos: SSL3 TLS1.0 TLS1.1 TLS1.2 
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            }
        }


        private static String InternalExecutaServico(SoapHttpClientProtocol oServico, TService TipoServico, Object DADOS, Parametro oParam)
        {
            try
            {
                string dados = XMLUtils.GetXML(DADOS, oParam.versao);
                #region particularidades
                if (oParam.UF == TCodUfIBGE.Parana && (DADOS.GetType() == typeof(SchemaXML.NFe_v200.TEnviNFe)
                                                    || DADOS.GetType() == typeof(SchemaXML.NFe_v300.TEnviNFe)
                                                    || DADOS.GetType() == typeof(SchemaXML.NFe_v310.TEnviNFe)))
                {
                    dados = dados.Replace("<NFe>", "<NFe xmlns=\"http://www.portalfiscal.inf.br/nfe\">");
                }
                #endregion
                XmlNode node = null;

                XmlDocument doc = new XmlDocument();
                XmlReader reader = XmlReader.Create(new StringReader(dados));
                reader.MoveToContent();

                node = doc.ReadNode(reader);

                InicializaServico(oServico, oParam);


                if (oParam.versao == VersaoXML.NFe_v400 &&
                (TipoServico == TService.Autorizacao || TipoServico == TService.RetAutorizacao || TipoServico == TService.ConsultaProtocolo ||
                 TipoServico == TService.Inutilizacao || TipoServico == TService.RecepcaoEvento || TipoServico == TService.Cadastro || TipoServico == TService.Status))
                {
                    var wsMethod = Webservices.WSUtils.GetWSMethod(TipoServico);

                    XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(wsMethod, System.Reflection.BindingFlags.InvokeMethod,
                        null, oServico, new object[] { node });
                    return XMLUtils.GetXML(ret, oParam.versao);
                }
                else
                {
                    //TODO : compatibilizar com a nova factory de webservices

                    if (DADOS.GetType() == typeof(TLote_GNRE))
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("processar",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType() == typeof(TConsLote_GNRE))
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("consultar",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType() == typeof(TConsultaConfigUf))
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("consultar",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITConsCad") != null)
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("consultaCadastro2",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITEnvEvento") != null)
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("nfeRecepcaoEvento",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITEnviNFe") != null)
                    {
                        if (((ITEnviNFe)DADOS).versao == "2.00")
                        {
                            //versao 2.00

                            #region particularidades
                            if (oParam.UF == TCodUfIBGE.Parana)
                            {
                                if (oParam.tipoAmbiente == TAmb.Homologacao)
                                {
                                    oServico.Url = @"https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeRecepcao2";
                                }
                                else
                                {
                                    oServico.Url = @"https://nfe2.fazenda.pr.gov.br/nfe/NFeRecepcao2";
                                }
                            }
                            #endregion

                            XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("nfeRecepcaoLote2",
                                                                System.Reflection.BindingFlags.InvokeMethod,
                                                                null, oServico, new object[] { node });

                            return XMLUtils.GetXML(ret, oParam.versao);
                        }
                        else
                        {
                            //versao 3.00
                            //Somente meto Assincrono
                            //var test = (SchemaXML300.TEnviNFe)DADOS;
                            //test.indSinc = SchemaXML300.TEnviNFeIndSinc.Item0;//Não indica sincrono
                            //test.indSinc = SchemaXML300.TEnviNFeIndSinc.Item1; //indica sincrono, mas depende da SEFAZ autorizadora implementar servico.

                            //***.**.Autorizacao.NfeAutorizacao proxy = new ***.**.Autorizacao.NfeAutorizacao();
                            //var ret = proxy.nfeAutorizacaoLote(node);
                            //sincrono poderá ter o Nó : TProtNFe
                            //assincrono terá o Nó : TRetEnviNFeInfRec

                            var fnNome = "nfeAutorizacaoLote";

                            XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(fnNome,
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });
                            return XMLUtils.GetXML(ret, oParam.versao);
                        }
                    }
                    else if (DADOS.GetType().GetInterface("ITConsReciNFe") != null)
                    {
                        if (((ITConsReciNFe)DADOS).versao == "2.00")
                        {
                            //versao 2.00

                            #region particularidades
                            if (oParam.UF == TCodUfIBGE.Parana)
                            {
                                if (oParam.tipoAmbiente == TAmb.Homologacao)
                                {
                                    oServico.Url = @"https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeRetRecepcao2";
                                }
                                else
                                {
                                    oServico.Url = @"https://nfe2.fazenda.pr.gov.br/nfe/NFeRetRecepcao2";
                                }
                            }
                            #endregion

                            XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("nfeRetRecepcao2",
                                            System.Reflection.BindingFlags.InvokeMethod,
                                            null, oServico, new object[] { node });

                            return XMLUtils.GetXML(ret, oParam.versao);
                        }
                        else
                        {
                            var fnNome = "nfeRetAutorizacaoLote";
                            if (oParam.UF == TCodUfIBGE.Parana && oParam.versao == VersaoXML.NFe_v310)
                            {
                                fnNome = "nfeRetAutorizacao";
                            }


                            //versao 3.00 ou 3.10
                            XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(fnNome,
                                            System.Reflection.BindingFlags.InvokeMethod,
                                            null, oServico, new object[] { node });

                            var temp = XMLUtils.GetXML(ret, oParam.versao);

                            if (oParam.UF == TCodUfIBGE.Pernambuco)
                            {
                                //SEFAZ PE está retornando retEnviNFe ao inves de retConsReciNFe quando lote ainda está em processamento
                                temp = temp.Replace("retEnviNFe", "retConsReciNFe");
                            }

                            return temp;
                        }
                    }
                    else if (DADOS.GetType().GetInterface("ITConsStatServ") != null)
                    {
                        var fnNome = "nfeStatusServicoNF2";
                        if ((oParam.UF == TCodUfIBGE.Parana || oParam.UF == TCodUfIBGE.Bahia)
                            && oParam.conexao == TipoConexao.NFe
                            && oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.Normal
                            && oParam.versao == VersaoXML.NFe_v310)
                        {
                            fnNome = "nfeStatusServicoNF";
                        }

                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(fnNome,
                                        System.Reflection.BindingFlags.InvokeMethod,
                                        null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITInutNFe") != null)
                    {
                        var fnNome = "nfeInutilizacaoNF2";
                        if ((oParam.UF == TCodUfIBGE.Parana || oParam.UF == TCodUfIBGE.Bahia)
                            && oParam.conexao == TipoConexao.NFe
                            && oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.Normal
                            && oParam.versao == VersaoXML.NFe_v310)
                        {
                            fnNome = "nfeInutilizacaoNF";
                        }

                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(fnNome,
                                        System.Reflection.BindingFlags.InvokeMethod,
                                        null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITConsSitNFe") != null)
                    {
                        string fnNome = "nfeConsultaNF2";
                        if ((oParam.UF == TCodUfIBGE.Parana || oParam.UF == TCodUfIBGE.Bahia)
                            && oParam.conexao == TipoConexao.NFe
                            && oParam.tipoEmissao == TNFeInfNFeIdeTpEmis.Normal
                            && oParam.versao == VersaoXML.NFe_v310)
                        {
                            fnNome = "nfeConsultaNF";
                        }

                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember(fnNome,
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });
                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("IDistDFeInt") != null)
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("nfeDistDFeInteresse",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else if (DADOS.GetType().GetInterface("ITDownloadNFe") != null)
                    {
                        XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("nfeDownloadNF",
                                                            System.Reflection.BindingFlags.InvokeMethod,
                                                            null, oServico, new object[] { node });

                        return XMLUtils.GetXML(ret, oParam.versao);
                    }
                    else
                    {
                        throw new Exception("Tipo de objeto de envio não mapeado. Consulte o administrador do Sistema.");
                    }
                }
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                if (ex.InnerException != null)
                {
                    msg += " inner : " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                        msg += " inner : " + ex.InnerException.InnerException.Message;
                }

                throw new Exception("Erro ao executar Serviço : typeof(" + DADOS.GetType().ToString() + "). Verifique sua conexão com a Internet, configurações de proxy e certificado. " + msg);
            }

        }

    }
}
