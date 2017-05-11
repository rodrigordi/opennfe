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

namespace RDI.NFe2.Business
{
    public static class Servicos
    {
        public static string VersaoBusiness { get { return "v3.10.4.0"; } }



        public static ITRetEnvEvento EnviarEnvelopeEvento(
             System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
             ITEnvEvento oEnvEvento, Parametro oParam, VersaoXML versao)
        {
            return (ITRetEnvEvento)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oEnvEvento, oParam),
                versao, "TRetEnvEvento");
        }

        public static ITRetEnviNFe EnviarEnvelope(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITEnviNFe oEnviNFe, Parametro oParam, VersaoXML versao)
        {
            return (ITRetEnviNFe)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oEnviNFe, oParam),
                versao, "TRetEnviNFe");
        }

        public static ITRetConsReciNFe ConsultarProcessamentoEnvelope(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsReciNFe oConsReciNFe, Parametro oParam, VersaoXML versao)
        {
            return (ITRetConsReciNFe)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oConsReciNFe, oParam),
                versao, "TRetConsReciNFe");
        }

        public static ITRetConsStatServ ConsultarStatusServidor(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsStatServ oConsStatServ, Parametro oParam, VersaoXML versao)
        {
            return (ITRetConsStatServ)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oConsStatServ, oParam),
                versao, "TRetConsStatServ");
        }

        public static ITRetInutNFe InutilizarNFe(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITInutNFe oInutNFe, Parametro oParam, VersaoXML versao)
        {
            return (ITRetInutNFe)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oInutNFe, oParam),
                versao, "TRetInutNFe");
        }

        public static ITRetConsSitNFe ConsultarSituacaoNFe(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsSitNFe oConsSitNFe, Parametro oParam, VersaoXML versao)
        {
            return (ITRetConsSitNFe)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oConsSitNFe, oParam),
                versao, "TRetConsSitNFe");
        }

        public static ITRetConsCad ConsultarCadastro(SoapHttpClientProtocol oServico, ITConsCad oEnviNFe3, Parametro oParam, VersaoXML versao)
        {
            return (ITRetConsCad)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, oEnviNFe3, oParam),
                versao, "TRetConsCad");
        }

        public static IRetDistDFeInt ConsultarDFe(SoapHttpClientProtocol oServico, IDistDFeInt xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return (IRetDistDFeInt)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, xmlEnvio, oParam),
                versao, "retDistDFeInt");
        }

        public static ITRetDownloadNFe DownloadNF(SoapHttpClientProtocol oServico, ITDownloadNFe xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            return (ITRetDownloadNFe)XMLUtils.CarregaXML_STR(ExecutaServico(oServico, xmlEnvio, oParam),
                versao, "TRetDownloadNFe");
        }


        //chamadas com retornos em string
        public static KeyValuePair<string, ITRetEnvEvento> Interface_EnviarEnvelopeEvento(
             System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
             ITEnvEvento oEnvEvento, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oEnvEvento, oParam);
            try
            {
                var Value = (ITRetEnvEvento)XMLUtils.CarregaXML_STR(Key, versao, "TRetEnvEvento");
                return new KeyValuePair<string, ITRetEnvEvento>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetEnvEvento>(Key, null);
            }
        }

        public static KeyValuePair<string, ITRetEnviNFe> Interface_EnviarEnvelope(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITEnviNFe oEnviNFe, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oEnviNFe, oParam);
            try
            {
                var Value = (ITRetEnviNFe)XMLUtils.CarregaXML_STR(Key, versao, "TRetEnviNFe");
                return new KeyValuePair<string, ITRetEnviNFe>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetEnviNFe>(Key, null);
            }
        }

        public static KeyValuePair<string, ITRetConsReciNFe> Interface_ConsultarProcessamentoEnvelope(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsReciNFe oConsReciNFe, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oConsReciNFe, oParam);
            try
            {
                var Value = (ITRetConsReciNFe)XMLUtils.CarregaXML_STR(Key, versao, "TRetConsReciNFe");
                return new KeyValuePair<string, ITRetConsReciNFe>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetConsReciNFe>(Key, null);
            }
        }

        public static KeyValuePair<string, ITRetConsStatServ> Interface_ConsultarStatusServidor(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsStatServ oConsStatServ, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oConsStatServ, oParam);
            try
            {
                var Value = (ITRetConsStatServ)XMLUtils.CarregaXML_STR(Key, versao, "TRetConsStatServ");
                return new KeyValuePair<string, ITRetConsStatServ>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetConsStatServ>(Key, null);
            }

        }

        public static KeyValuePair<string, ITRetInutNFe> Interface_InutilizarNFe(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITInutNFe oInutNFe, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oInutNFe, oParam);
            try
            {
                var Value = (ITRetInutNFe)XMLUtils.CarregaXML_STR(Key, versao, "TRetInutNFe");
                return new KeyValuePair<string, ITRetInutNFe>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetInutNFe>(Key, null);
            }
        }

        public static KeyValuePair<string, ITRetConsSitNFe> Interface_ConsultarSituacaoNFe(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            ITConsSitNFe oConsSitNFe, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oConsSitNFe, oParam);
            try
            {
                var Value = (ITRetConsSitNFe)XMLUtils.CarregaXML_STR(Key, versao, "TRetConsSitNFe");
                return new KeyValuePair<string, ITRetConsSitNFe>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetConsSitNFe>(Key, null);
            }

        }

        public static KeyValuePair<string, ITRetConsCad> Interface_ConsultarCadastro(SoapHttpClientProtocol oServico, ITConsCad oEnviNFe3, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, oEnviNFe3, oParam);
            try
            {
                var Value = (ITRetConsCad)XMLUtils.CarregaXML_STR(Key, versao, "TRetConsCad");
                return new KeyValuePair<string, ITRetConsCad>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetConsCad>(Key, null);
            }

        }

        public static KeyValuePair<string, IRetDistDFeInt> Interface_ConsultarDFe(SoapHttpClientProtocol oServico, IDistDFeInt xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, xmlEnvio, oParam);
            try
            {
                var Value = (IRetDistDFeInt)XMLUtils.CarregaXML_STR(Key, versao, "retDistDFeInt");
                return new KeyValuePair<string, IRetDistDFeInt>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, IRetDistDFeInt>(Key, null);
            }

        }

        public static KeyValuePair<string, ITRetDownloadNFe> Interface_DownloadNF(SoapHttpClientProtocol oServico, ITDownloadNFe xmlEnvio, Parametro oParam, VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, xmlEnvio, oParam);
            try
            {
                var Value = (ITRetDownloadNFe)XMLUtils.CarregaXML_STR(Key, versao, "TRetDownloadNFe");
                return new KeyValuePair<string, ITRetDownloadNFe>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, ITRetDownloadNFe>(Key, null);
            }

        }


        public static KeyValuePair<string, RDI.NFe2.GNRE.TRetLote_GNRE> Interface_GNRERecepcaoLote(SoapHttpClientProtocol oServico,
            RDI.NFe2.GNRE.TLote_GNRE xmlEnvio,
            Parametro oParam,
            VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, xmlEnvio, oParam);
            try
            {
                var Value = (RDI.NFe2.GNRE.TRetLote_GNRE)XMLUtils.CarregaXML_STR(Key, versao, "TRetLote_GNRE");
                return new KeyValuePair<string, RDI.NFe2.GNRE.TRetLote_GNRE>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, RDI.NFe2.GNRE.TRetLote_GNRE>(Key, null);
            }

        }

        public static KeyValuePair<string, RDI.NFe2.GNRE.TResultLote_GNRE> Interface_GNREConsultaLote(SoapHttpClientProtocol oServico,
            RDI.NFe2.GNRE.TConsLote_GNRE xmlEnvio,
            Parametro oParam,
            VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, xmlEnvio, oParam);
            try
            {
                var Value = (RDI.NFe2.GNRE.TResultLote_GNRE)XMLUtils.CarregaXML_STR(Key, versao, "TResultLote_GNRE");
                return new KeyValuePair<string, RDI.NFe2.GNRE.TResultLote_GNRE>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, RDI.NFe2.GNRE.TResultLote_GNRE>(Key, null);
            }

        }

        public static KeyValuePair<string, RDI.NFe2.GNRE.TConfigUf> Interface_GNREConfigUF(SoapHttpClientProtocol oServico,
            RDI.NFe2.GNRE.TConsultaConfigUf xmlEnvio,
            Parametro oParam,
            VersaoXML versao)
        {
            var Key = ExecutaServico(oServico, xmlEnvio, oParam);
            try
            {
                var Value = (RDI.NFe2.GNRE.TConfigUf)XMLUtils.CarregaXML_STR(Key, versao, "TConfigUf");
                return new KeyValuePair<string, RDI.NFe2.GNRE.TConfigUf>(Key, Value);
            }
            catch (Exception ex)
            {
                Key = ex.Message + " - " + Key;
                return new KeyValuePair<string, RDI.NFe2.GNRE.TConfigUf>(Key, null);
            }

        }


        public static void InicializaServico(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            Parametro oParam)
        {
            X509Certificate2 certificadoX509 = Certificado.BuscaNome(oParam.certificado, oParam.usaWService, oParam.tipoBuscaCertificado);

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
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

        }


        private static String ExecutaServico(
            System.Web.Services.Protocols.SoapHttpClientProtocol oServico,
            Object DADOS, Parametro oParam)
        {
            try
            {
                string dados = XMLUtils.GetXML(DADOS, oParam.versao);
                #region particularidades
                if (oParam.UF == TCodUfIBGE.Parana && (DADOS.GetType() == typeof(SchemaXML200.TEnviNFe)
                                                    || DADOS.GetType() == typeof(SchemaXML300.TEnviNFe)
                                                    || DADOS.GetType() == typeof(SchemaXML310.TEnviNFe)))
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


                if (DADOS.GetType() == typeof(RDI.NFe2.GNRE.TLote_GNRE))
                {
                    XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("processar",
                                                        System.Reflection.BindingFlags.InvokeMethod,
                                                        null, oServico, new object[] { node });

                    return XMLUtils.GetXML(ret, oParam.versao);
                }
                else if (DADOS.GetType() == typeof(RDI.NFe2.GNRE.TConsLote_GNRE))
                {
                    XmlNode ret = (XmlNode)oServico.GetType().InvokeMember("consultar",
                                                        System.Reflection.BindingFlags.InvokeMethod,
                                                        null, oServico, new object[] { node });

                    return XMLUtils.GetXML(ret, oParam.versao);
                }
                else if (DADOS.GetType() == typeof(RDI.NFe2.GNRE.TConsultaConfigUf))
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
            catch (Exception ex)
            {
                String msg = ex.Message;
                if (ex.InnerException != null)
                    msg += " inner : " + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                    msg += " inner : " + ex.InnerException.InnerException.Message;

                throw new Exception("Erro ao executar Serviço : typeof(" + DADOS.GetType().ToString() + "). Verifique sua conexão com a Internet, configurações de proxy e certificado. " + msg);
            }

        }

    }
}
