using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using RDI.NFe2.ORMAP;
using RDI.NFe2.SchemaXML;
using RDI.OpenSigner;
using RDI.NFe2.SchemaXML.GNRE;
using RDI.NFe2.Webservices;

namespace RDI.NFe2.Business
{
    [ClassInterface(ClassInterfaceType.None)]
    public class Utilitario : IUtilitario
    {

        private Parametro _Parametro;
        #region Auxiliares
        public Utilitario()
        {
            _Parametro = new Parametro();
        }

        public String UltimaValidacao = string.Empty;

        public void SetUtilitario(String certificado, Boolean Producao, Boolean TpEmisNormal, String UF, TipoConexao conexao, TBuscaCertificado tipoBusca, int versaoXML)
        {
            //Cria Parametro
            _Parametro = new Parametro();

            _Parametro.versao = (VersaoXML)versaoXML;

            _Parametro.conexao = conexao;

            _Parametro.prx = false;
            _Parametro.timeout = Delay.Lento;
            _Parametro.usaWService = false;
            _Parametro.tamMaximoLoteKB = 500;
            _Parametro.tempoParaLote = 10;
            _Parametro.qtdeNotasPorLotes = 10;

            _Parametro.prx = false;
            _Parametro.tipoBuscaCertificado = tipoBusca;
            _Parametro.certificado = certificado;
            _Parametro.usaWService = (tipoBusca == TBuscaCertificado.Nome_MaquinaLocal || tipoBusca == TBuscaCertificado.Serial_MaquinaLocal);

            if (Producao)
                _Parametro.tipoAmbiente = TAmb.Producao;
            else
                _Parametro.tipoAmbiente = TAmb.Homologacao;


            if (TpEmisNormal)
                _Parametro.tipoEmissao = TNFeInfNFeIdeTpEmis.Normal;
            else
                _Parametro.tipoEmissao = TNFeInfNFeIdeTpEmis.ContingenciaSVCAN; //ou SVCRS. o sistema irá verificar qual é o webservice que atende a UF

            _Parametro.UF = (TCodUfIBGE)Enum.Parse(typeof(TCodUfIBGE), UF);

            var res = GeraUltimaValidacao();

            if (string.IsNullOrEmpty(res))
            {
                UltimaValidacao += (" " + res);
            }

        }

        public String GetUltimaValidacao()
        {
            return Servicos.VersaoBusiness + " (v3) - " + UltimaValidacao;
        }
        private string GeraUltimaValidacao()
        {
            try
            {
                UltimaValidacao = "Dll carregada com sucesso.";

                if (!String.IsNullOrEmpty(_Parametro.certificado))
                    UltimaValidacao += " Usando Certificado :" + _Parametro.certificado;
                else
                    UltimaValidacao += " Nenhum certificado selecionado";

                if (_Parametro.usaWService)
                    UltimaValidacao += " em ContaComputador.";
                else
                    UltimaValidacao += " em ContaUsuario.";

                UltimaValidacao += " Operando em " + XMLUtils.GetDescriptionAttribute(_Parametro.tipoAmbiente);

                UltimaValidacao += " Emitindo em " + XMLUtils.GetDescriptionAttribute(_Parametro.tipoEmissao);

                UltimaValidacao += " UF : " + XMLUtils.GetDescriptionAttribute(_Parametro.UF);

                UltimaValidacao += " Conexão : " + _Parametro.conexao;

                return string.Empty;
            }
            catch
                (Exception ex)
            {
                return "Erro em GeraUltimaValidacao() - " + ex.Message;
            }
        }

        public void DefineUF(String UF) { _Parametro.UF = (TCodUfIBGE)Enum.Parse(typeof(TCodUfIBGE), UF); }
        public void DefineUF(TCodUfIBGE UF) { _Parametro.UF = UF; }

        public void DefineNomeCertificado(String NomeCertificado) { _Parametro.certificado = NomeCertificado; GeraUltimaValidacao(); }

        public void DefineContaComputador(Boolean ContaComputador) { _Parametro.usaWService = ContaComputador; GeraUltimaValidacao(); }

        public void DefineProxy(String usuario, String senha, String dominio, String url)
        {
            _Parametro.prxUsr = usuario;
            _Parametro.prxPsw = senha;
            _Parametro.prxUrl = url;
            _Parametro.prxDmn = dominio;
        }

        public void SetProxy(Boolean habilita)
        {
            _Parametro.prx = habilita;
        }

        public string BuscaCertificados(String valor)
        {
            if (_Parametro == null)
            {
                throw new Exception("Parametro esta nulo.");
            }

            try
            {
                X509Certificate2 oCertificado = Certificado.Carregar(string.Empty, _Parametro.tipoBuscaCertificado);

                if (oCertificado == null)
                {
                    throw new Exception("oCertificado esta nulo.");
                }

                return oCertificado.Subject;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return String.Empty;
            }

        }

        public int AssinaXMLHD(String caminhoArquivoOrigem, String SUri, String caminhoArquivoDestino)
        {

            X509Certificate2 oCertificado = null;
            //busca o certificado digital
            try
            {
                oCertificado = Certificado.Carregar(_Parametro.certificado, _Parametro.tipoBuscaCertificado);
            }
            catch
            {
                return (int)TRetornoAssinatura.ProblemaAoAcessarCertificado;
            }

            string _stringXml;
            string stType = string.Empty;
            VersaoXML versao = _Parametro.versao;

            if (SUri == "infNFe")
            {
                stType = "TNFe";
            }
            else if (SUri == "infCanc")
            {
                if (_Parametro.conexao == TipoConexao.NFCe)
                    throw new Exception("URI " + SUri + " não mapeada para NFCe");
                else
                    stType = "TCancNFe";
            }
            else if (SUri == "infInut")
            {
                stType = "TInutNFe";
            }
            else if (SUri == "infEvento")
            {
                stType = "TEvento";
                versao = _Parametro.versaoEventos;
            }
            else
            {
                return 4; //erro refURi
            }


            //Verifica se arquivo da nota Existe;
            if (File.Exists(caminhoArquivoOrigem))
            {
                #region carregar arquivo a ser assinado
                _stringXml = XMLUtils.GetXML(XMLUtils.LoadXMLFile(caminhoArquivoOrigem, versao, stType), versao);

                #endregion

                // realiza assinatura
                AssinaturaDigital AD = new AssinaturaDigital();
                var resultado = AD.AssinarNFe(_stringXml, SUri, oCertificado);

                //limpar certificado
                oCertificado.Reset();

                //assinatura bem sucedida
                if (resultado == TRetornoAssinatura.Assinada)
                {
                    if (File.Exists(caminhoArquivoDestino))
                        File.Delete(caminhoArquivoDestino);

                    XMLUtils.SaveXML(caminhoArquivoDestino, (XMLUtils.LoadXML(AD.XMLStringAssinado, versao, stType)), versao);
                }
                else
                {
                    UltimaValidacao = AD.mensagemResultado;
                }

                return (int)resultado; //Retorna o resultado da assinatura
            }
            else
                return 11;//Arquivo nao encontrado
        }

        public String AssinaXMLST(String ArquivoOrigem, String uri)
        {
            VersaoXML versao = _Parametro.versao;
            X509Certificate2 oCertificado = null;

            //busca o certificado digital
            try
            {
                oCertificado = Certificado.Carregar(_Parametro.certificado, _Parametro.tipoBuscaCertificado);
            }
            catch (Exception ex)
            {
                UltimaValidacao = "Erro ao acessar repositório : " + ex.Message;
                if (ex.InnerException != null)
                    UltimaValidacao += " - Inner : " + ex.InnerException.Message;
                return TRetornoAssinatura.ProblemaAoAcessarCertificado.ToString();
            }

            //tentar serializar antes de assinar. evitar erro 297 assinatura difere do calculado
            string XMLString = "";
            try
            {
                string stType = string.Empty;

                if (uri == "infNFe")
                {
                    stType = "TNFe";
                }
                else if (uri == "infCanc")
                {
                    if (_Parametro.conexao == TipoConexao.NFCe)
                        throw new Exception("URI " + uri + " não mapeada para NFCe");
                    else
                        stType = "TCancNFe";
                }
                else if (uri == "infInut")
                {
                    stType = "TInutNFe";
                }
                else if (uri == "infEvento")
                {
                    stType = "TEvento";
                    versao = _Parametro.versaoEventos;
                }
                else
                {
                    return TRetornoAssinatura.RefURiNaoExiste.ToString(); //erro refURi
                }

                XMLString = XMLUtils.GetXML(XMLUtils.LoadXML(ArquivoOrigem, versao, stType), versao);
            }
            catch (Exception exLoad)
            {
                UltimaValidacao = "Erro ao carregar xml : " + exLoad.Message;
                if (exLoad.InnerException != null)
                    UltimaValidacao += " - Inner : " + exLoad.InnerException.Message;
                return TRetornoAssinatura.XMLMalFormado.ToString();
            }


            // realiza assinatura
            AssinaturaDigital oAssinador = new AssinaturaDigital();
            var ret = oAssinador.AssinarNFe(XMLString, uri, oCertificado);
            //limpar o objeto do certificado
            oCertificado.Reset();

            //se assinatura realizada com sucesso, salva retorno
            if (ret == TRetornoAssinatura.Assinada)
            {
                return oAssinador.XMLStringAssinado;
            }
            else
            {
                UltimaValidacao = oAssinador.mensagemResultado;
            }

            oAssinador = null;

            return ret.ToString(); //Retorna o resultado da assinatura
        }

        public TRetornoAssinatura AssinaXML(String xml, String uri, out string xmlAssinado)
        {
            X509Certificate2 oCertificado = null;
            xmlAssinado = string.Empty;

            //busca o certificado digital
            try
            {
                oCertificado = Certificado.Carregar(_Parametro.certificado, _Parametro.tipoBuscaCertificado);
            }
            catch (Exception ex)
            {
                UltimaValidacao = "Erro ao acessar repositório : " + ex.Message;
                if (ex.InnerException != null)
                    UltimaValidacao += " - Inner : " + ex.InnerException.Message;
                return TRetornoAssinatura.ProblemaAoAcessarCertificado;
            }


            // realiza assinatura
            AssinaturaDigital oAssinador = new AssinaturaDigital();
            var ret = oAssinador.AssinarNFe(xml, uri, oCertificado);
            //limpar o objeto do certificado
            oCertificado.Reset();

            //se assinatura realizada com sucesso, salva retorno
            if (ret == TRetornoAssinatura.Assinada)
            {
                xmlAssinado = oAssinador.XMLStringAssinado;
            }
            else
            {
                UltimaValidacao = oAssinador.mensagemResultado;
            }

            oAssinador = null;
            return ret;
        }

        public String ValidaXML(String caminhoXML, String caminhoXSD)
        {
            return NFeUtils.ValidacaoXML(caminhoXML, caminhoXSD);
        }
        public string Unzip(string stZipped)
        {
            //string para byte[]
            var bZipped = System.Convert.FromBase64String(stZipped);

            return XMLUtils.Unzip(bZipped);
        }
        public Boolean StatusWebService()
        {
            ITConsStatServ oConsStatServ;

            try
            {
                oConsStatServ = (ITConsStatServ)XMLUtils.XMLFactory(_Parametro.versao, "TConsStatServ");
                oConsStatServ.tpAmb = _Parametro.tipoAmbiente;
                oConsStatServ.cUF = _Parametro.UF;
                oConsStatServ.versao = _Parametro.versaoDados;

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Status);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarStatusServidor(oServico, oConsStatServ, _Parametro, _Parametro.versao);
                return (temp.cStat == "107");
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        #endregion

        #region NFe 
        //HD
        public bool AutorizacaoHD(string caminhoArquivoEnviNFe, string caminhoArquivoRetEnviNFe)
        {
            ITEnviNFe oEnviNFe3;
            try
            {
                if (!File.Exists(caminhoArquivoEnviNFe))
                    throw new Exception("Arquivo EnviNFe não existe ou não esta acessível.");

                try
                {
                    oEnviNFe3 = (ITEnviNFe)XMLUtils.LoadXMLFile(caminhoArquivoEnviNFe, _Parametro.versao, "TEnviNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnviNFe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Autorizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelope(oServico, oEnviNFe3, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoArquivoRetEnviNFe, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public bool RetAutorizacaoHD(string caminhoArquivoConsReciNFe, string caminhoArquivoRetConsReciNFe)
        {
            ITConsReciNFe oConsReciNFCe3;
            try
            {
                if (!File.Exists(caminhoArquivoConsReciNFe))
                    throw new Exception("Arquivo ConsReciNFe não existe ou não esta acessível.");

                try
                {
                    oConsReciNFCe3 = (ITConsReciNFe)XMLUtils.LoadXMLFile(caminhoArquivoConsReciNFe, _Parametro.versao, "TConsReciNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo ConsReciNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.RetAutorizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarProcessamentoEnvelope(oServico, oConsReciNFCe3, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoArquivoRetConsReciNFe, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public bool InutilizacaoHD(string caminhoArquivoInutNFe, string caminhoArquivoRetInutNFe)
        {
            ITInutNFe oInutNFCe3;
            try
            {
                if (!File.Exists(caminhoArquivoInutNFe))
                    throw new Exception("Arquivo InutNFe não existe ou não esta acessível.");

                try
                {
                    oInutNFCe3 = (ITInutNFe)XMLUtils.LoadXMLFile(caminhoArquivoInutNFe, _Parametro.versao, "TInutNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo InutNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Inutilizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.InutilizarNFe(oServico, oInutNFCe3, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoArquivoRetInutNFe, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public bool RecepcaoEventoHD(string caminhoArquivoEvento, string caminhoArquivoRetEvento)
        {
            ITEnvEvento oEnviCCe;
            try
            {
                if (!File.Exists(caminhoArquivoEvento))
                    throw new Exception("Arquivo Evento não existe ou não esta acessível.");

                try
                {
                    oEnviCCe = (ITEnvEvento)XMLUtils.LoadXMLFile(caminhoArquivoEvento, _Parametro.versaoEventos, "TEnvEvento");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnvEvento - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.RecepcaoEvento);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelopeEvento(oServico, oEnviCCe, _Parametro, _Parametro.versaoEventos);
                XMLUtils.SaveXML(caminhoArquivoRetEvento, temp, _Parametro.versaoEventos);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public bool ConsultaProtocoloHD(string caminhoArquivoConsSitNFe, string caminhoArquivoRetConsSitNFe)
        {
            ITConsSitNFe oConsSitNFCe3;
            try
            {
                if (!File.Exists(caminhoArquivoConsSitNFe))
                    throw new Exception("Arquivo ConsSitNFe não existe ou não esta acessível.");

                try
                {
                    oConsSitNFCe3 = (ITConsSitNFe)XMLUtils.LoadXMLFile(caminhoArquivoConsSitNFe, _Parametro.versao, "TConsSitNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo ConsSitNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ConsultaProtocolo);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarSituacaoNFe(oServico, oConsSitNFCe3, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoArquivoRetConsSitNFe, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }

        //ST
        public string AutorizacaoST(string ArquivoEnviNFe)
        {
            ITEnviNFe oEnviNFCe3;
            try
            {
                try
                {
                    oEnviNFCe3 = (ITEnviNFe)XMLUtils.LoadXML(ArquivoEnviNFe, _Parametro.versao, "TEnviNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnviNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Autorizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelope(oServico, oEnviNFCe3, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public string RetAutorizacaoST(string ArquivoConsReciNFe)
        {
            ITConsReciNFe oConsReciNFCe3;
            try
            {
                try
                {
                    oConsReciNFCe3 = (ITConsReciNFe)XMLUtils.LoadXML(ArquivoConsReciNFe, _Parametro.versao, "TConsReciNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo ConsReciNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.RetAutorizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarProcessamentoEnvelope(oServico, oConsReciNFCe3, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public string InutilizacaoST(string ArquivoInutNFe)
        {
            ITInutNFe oInutNFCe3;
            try
            {

                try
                {
                    oInutNFCe3 = (ITInutNFe)XMLUtils.LoadXML(ArquivoInutNFe, _Parametro.versao, "TInutNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo InutNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Inutilizacao);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.InutilizarNFe(oServico, oInutNFCe3, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public string RecepcaoEventoST(string ArquivoEvento)
        {
            ITEnvEvento oEnviCCe;
            try
            {
                try
                {
                    oEnviCCe = (ITEnvEvento)XMLUtils.LoadXML(ArquivoEvento, _Parametro.versaoEventos, "TEnvEvento");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo Evento - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.RecepcaoEvento);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelopeEvento(oServico, oEnviCCe, _Parametro, _Parametro.versaoEventos);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public string ConsultaProtocoloST(string ArquivoConsSitNFe)
        {
            ITConsSitNFe oConsSitNFCe3;
            try
            {
                try
                {
                    oConsSitNFCe3 = (ITConsSitNFe)XMLUtils.LoadXML(ArquivoConsSitNFe, _Parametro.versao, "TConsSitNFe");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo ConsSitNFCe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ConsultaProtocolo);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarSituacaoNFe(oServico, oConsSitNFCe3, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        #endregion


        public Boolean ConsultaCadastroHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            ITConsCad oXMLEnvio;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (ITConsCad)XMLUtils.LoadXMLFile<SchemaXML.ConsultaCadastro.TConsCad>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnviNFe3 - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Cadastro);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarCadastro(oServico, oXMLEnvio, _Parametro, VersaoXML.NFe_v200);
                XMLUtils.SaveXML(caminhoXMLRetorno, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String ConsultaCadastroST(String XMLEnvio)
        {
            ITConsCad oXMLEnvio;
            try
            {
                try
                {
                    oXMLEnvio = (ITConsCad)XMLUtils.LoadXML(XMLEnvio, VersaoXML.ConsultaCadastro_v100, "TConsCad");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo oXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.Cadastro);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.ConsultarCadastro(oServico, oXMLEnvio, _Parametro, VersaoXML.NFe_v200);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }

        #region Manifestacao Destinatario
        public Boolean ConsultarDFeHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            IDistDFeInt oXMLEnvio;
            IRetDistDFeInt oXMLRetorno = null;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (IDistDFeInt)XMLUtils.LoadXMLFile<SchemaXML.DocumentosFiscaisEletronicos_v101.distDFeInt>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    string msgErro = "Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message;
                    if (ex.InnerException != null)
                        msgErro += " - Detalhe : " + ex.InnerException.Message;

                    throw new Exception(msgErro);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ConsultaDFe);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                oXMLRetorno = Servicos.ConsultarDFe(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);

                XMLUtils.SaveXML(caminhoXMLRetorno, oXMLRetorno, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String ConsultarDFeST(String XMLEnvio)
        {
            IDistDFeInt oXMLEnvio;
            IRetDistDFeInt oXMLRetorno = null;
            try
            {
                try
                {
                    oXMLEnvio = (IDistDFeInt)XMLUtils.LoadXML<SchemaXML.DocumentosFiscaisEletronicos_v101.distDFeInt>(XMLEnvio);
                }
                catch (Exception ex)
                {
                    string msgErro = "Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message;
                    if (ex.InnerException != null)
                        msgErro += " - Detalhe : " + ex.InnerException.Message;

                    throw new Exception(msgErro);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ConsultaDFe);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                oXMLRetorno = Servicos.ConsultarDFe(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);
                return XMLUtils.GetXML(oXMLRetorno, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public IRetDistDFeInt ConsultarDFe(IDistDFeInt oXMLEnvio)
        {
            try
            {
                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ConsultaDFe);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                return Servicos.ConsultarDFe(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return null;
            }
        }

        public Boolean DownloadNFHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            ITDownloadNFe oXMLEnvio;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (ITDownloadNFe)XMLUtils.LoadXMLFile<SchemaXML.DocumentosFiscaisEletronicos_v101.TDownloadNFe>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    string msgErro = "Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message;
                    if (ex.InnerException != null)
                        msgErro += " - Detalhe : " + ex.InnerException.Message;

                    throw new Exception(msgErro);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.DownloadNF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.DownloadNF(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);
                XMLUtils.SaveXML(caminhoXMLRetorno, temp, _Parametro.versao);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String DownloadNFST(String XMLEnvio)
        {
            ITDownloadNFe oXMLEnvio;
            try
            {
                try
                {
                    oXMLEnvio = (ITDownloadNFe)XMLUtils.LoadXML<SchemaXML.DocumentosFiscaisEletronicos_v101.TDownloadNFe>(XMLEnvio);
                }
                catch (Exception ex)
                {
                    string msgErro = "Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message;
                    if (ex.InnerException != null)
                        msgErro += " - Detalhe : " + ex.InnerException.Message;

                    throw new Exception(msgErro);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.DownloadNF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.DownloadNF(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public ITRetDownloadNFe DownloadNF(ITDownloadNFe oXMLEnvio)
        {
            try
            {
                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.DownloadNF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                return Servicos.DownloadNF(oServico, oXMLEnvio, _Parametro, _Parametro.versaoDFe);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return null;
            }
        }

        public String RecepcaoEvento_MDe_ST(String ArquivoEnvEvento)
        {
            ITEnvEvento oEnviCCe;
            try
            {
                try
                {
                    oEnviCCe = (ITEnvEvento)XMLUtils.LoadXML(ArquivoEnvEvento, _Parametro.versaoEventos, "TEnvEvento");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnvEvento - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ManifestacaoDestinatario);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelopeEvento(oServico, oEnviCCe, _Parametro, _Parametro.versaoEventos);
                return XMLUtils.GetXML(temp, _Parametro.versaoEventos);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }
        public Boolean RecepcaoEvento_MDe_HD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento)
        {
            ITEnvEvento oEnviCCe;
            try
            {
                if (!File.Exists(caminhoArquivoEnvEvento))
                    throw new Exception("Arquivo EnvEvento não existe ou não esta acessível.");

                try
                {
                    oEnviCCe = (ITEnvEvento)XMLUtils.LoadXMLFile(caminhoArquivoEnvEvento, _Parametro.versaoEventos, "TEnvEvento");
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo EnvEvento - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.ManifestacaoDestinatario);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.EnviarEnvelopeEvento(oServico, oEnviCCe, _Parametro, _Parametro.versaoEventos);
                XMLUtils.SaveXML(caminhoArquivoRetEnvEvento, temp, _Parametro.versaoEventos);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }


        #endregion

        #region Chamadas
        [DllImport(@"Relatorios.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void DoPrintNFe(string path, string fileName, int nVias, bool cImprimir, bool cGerarPDF, bool cEnvioAutomatico, bool cSSL, bool cEnviarPDF,
            string cUsuario, string cHost, string cSenha, string cPort, string cFrom, string cCopiaPara, string cTextoFrom);

        [DllImport(@"Relatorios.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void DoPrintEventoCancNFe(string path, string fileName, int nVias, bool cImprimir, bool cGerarPDF, bool cEnvioAutomatico, bool cSSL, bool cEnviarPDF,
            string cUsuario, string cHost, string cSenha, string cPort, string cFrom, string cCopiaPara, string cTextoFrom);

        [DllImport(@"Relatorios.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void DoPrintCCe(string path, string fileName, int nVias, bool cImprimir, bool cGerarPDF, bool cEnvioAutomatico, bool cSSL, bool cEnviarPDF,
            string cUsuario, string cHost, string cSenha, string cPort, string cFrom, string cCopiaPara, string cTextoFrom);

        [DllImport(@"Relatorios.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void DoPrintCancNFe(string path, string fileName, int nVias, bool cImprimir, bool cGerarPDF, bool cEnvioAutomatico, bool cSSL, bool cEnviarPDF,
            string cUsuario, string cHost, string cSenha, string cPort, string cFrom, string cCopiaPara, string cTextoFrom);
        #endregion

        #region GNRE

        public Boolean GNRE_RecepcaoLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            TLote_GNRE oXMLEnvio;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (TLote_GNRE)XMLUtils.LoadXMLFile<TLote_GNRE>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_RecepcaoLote);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNRERecepcaoLote(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoXMLRetorno, temp, VersaoXML.GNRE);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String GNRE_RecepcaoLoteST(String XMLEnvio)
        {
            TLote_GNRE oXMLEnvio;
            try
            {
                try
                {
                    oXMLEnvio = (TLote_GNRE)XMLUtils.LoadXML<TLote_GNRE>(XMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo oXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_RecepcaoLote);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNRERecepcaoLote(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }

        public Boolean GNRE_ConsultaLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            TConsLote_GNRE oXMLEnvio;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (TConsLote_GNRE)XMLUtils.LoadXMLFile<TConsLote_GNRE>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_ConsultaLote);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNREConsultaLote(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoXMLRetorno, temp, VersaoXML.GNRE);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String GNRE_ConsultaLoteST(String XMLEnvio)
        {
            TConsLote_GNRE oXMLEnvio;
            try
            {
                try
                {
                    oXMLEnvio = (TConsLote_GNRE)XMLUtils.LoadXML<TConsLote_GNRE>(XMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo oXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_ConsultaLote);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNREConsultaLote(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }

        public Boolean GNRE_ConsultaConfigHD(String caminhoXMLEnvio, String caminhoXMLRetorno)
        {
            TConsultaConfigUf oXMLEnvio;
            try
            {
                if (!File.Exists(caminhoXMLEnvio))
                    throw new Exception("Arquivo caminhoXMLEnvio não existe ou não esta acessível.");

                try
                {
                    oXMLEnvio = (TConsultaConfigUf)XMLUtils.LoadXMLFile<TConsultaConfigUf>(caminhoXMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo caminhoXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_ConfigUF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNREConfigUF(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                XMLUtils.SaveXML(caminhoXMLRetorno, temp, VersaoXML.GNRE);

                return true;
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return false;
            }
        }
        public String GNRE_ConsultaConfigST(String XMLEnvio)
        {
            TConsultaConfigUf oXMLEnvio;
            try
            {
                try
                {
                    oXMLEnvio = XMLUtils.LoadXML<TConsultaConfigUf>(XMLEnvio);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível carregar o Arquivo oXMLEnvio - " + ex.Message);
                }

                System.Web.Services.Protocols.SoapHttpClientProtocol oServico = null;
                try
                {
                    oServico = NFeUtils.ClientProxyFactory(_Parametro, TService.GNRE_ConfigUF);
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível criar o serviço de comunicação com o webservice - " + ex.Message);
                }

                var temp = Servicos.GNREConfigUF(oServico, oXMLEnvio, _Parametro, _Parametro.versao);
                return XMLUtils.GetXML(temp, _Parametro.versao);
            }
            catch (Exception ex)
            {
                UltimaValidacao = ex.Message;
                return string.Empty;
            }
        }

        #endregion

    } //fim - classe
}//fim - namespace
