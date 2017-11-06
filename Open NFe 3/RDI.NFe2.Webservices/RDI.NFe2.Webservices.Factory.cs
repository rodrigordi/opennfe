using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;
using RDI.NFe2.SchemaXML;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace RDI.NFe2.Webservices
{
    public static class WSUtils
    {
        private static List<UrlConfiguration> urlsTable = null;

        private static Assembly GetCurrentAssembly()
        {
            return typeof(WSUtils).Assembly;
        }

        public static System.Web.Services.Protocols.SoapHttpClientProtocol SoapHttpClientFactory(TServer ServerName, string Environment, TService ServiceType)
        {
            String ClassName = "";
            try
            {
                var url = GetURL(ServerName, Environment, ServiceType);
                ClassName = $"RDI.NFe2.Webservices.NF4.HUB.{  ServiceType.ToString() }.{GetWSName(ServiceType)}";

                Type classType = GetCurrentAssembly().GetType(ClassName);

                if (classType == null)
                    throw new Exception("Não foi possível definir o tipo do cliente de webservice. #ClientProxyFactory");

                var oServico = (System.Web.Services.Protocols.SoapHttpClientProtocol)System.Activator.CreateInstance(classType, url);

                return oServico;
            }
            catch (Exception ex)
            {
                throw new Exception("ClientProxyFactory # não foi possível criar o cliente (" + ClassName + ") para acesso aos webservices da SEFAZ. InnerException: " + ex.Message);
            }
        }

        public static string GetWSMethod(TService ServiceType)
        {
            var hub = GetHubConfiguration(ServiceType);
            return hub.WSMethod;
        }

        private static string GetWSName(TService ServiceType)
        {
            var hub = GetHubConfiguration(ServiceType);
            return hub.WSName;
        }

        private static HubConfiguration GetHubConfiguration(TService ServiceType)
        {
            var hub = (HubConfiguration)ServiceType.GetType().GetField(ServiceType.ToString()).GetCustomAttributes(typeof(HubConfiguration), false).FirstOrDefault();
            if (hub == null)
                throw new Exception("Serviço não está declarado.");
            if (string.IsNullOrEmpty(hub.WSName) || string.IsNullOrEmpty(hub.WSMethod))
                throw new Exception("Serviço não está associado.");

            return hub;
        }

        private static string GetURL(TServer ServerName, string Environment, TService ServiceType)
        {
            CreateUrlTable();

            var urlConfig = urlsTable.FirstOrDefault(p => p.Environment == Environment
                                           && p.ServerName == ServerName
                                           && p.ServiceType == ServiceType);

            if (urlConfig == null)
                throw new Exception("Url não foi definida.");

            return urlConfig.Url;
        }

        private static void CreateUrlTable()
        {
            if (urlsTable != null)
                return;

            urlsTable = new List<UrlConfiguration>()
            {
                #region homologacao
                //SEFAZ PE
                //SVCRS


                new UrlConfiguration(TServer.AM, "Homologacao", TService.Inutilizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeInutilizacao4"),
                new UrlConfiguration(TServer.AM, "Homologacao", TService.ConsultaProtocolo,"https://homnfe.sefaz.am.gov.br/services2/services/NfeConsulta4"),
                new UrlConfiguration(TServer.AM, "Homologacao", TService.Status,"https://homnfe.sefaz.am.gov.br/services2/services/NfeStatusServico4"),
                new UrlConfiguration(TServer.AM, "Homologacao", TService.RecepcaoEvento,"https://homnfe.sefaz.am.gov.br/services2/services/RecepcaoEvento4"),
                new UrlConfiguration(TServer.AM, "Homologacao", TService.Autorizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeAutorizacao4"),
                new UrlConfiguration(TServer.AM, "Homologacao", TService.RetAutorizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeRetAutorizacao4"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.RecepcaoEvento,"https://hnfe.sefaz.ba.gov.br/webservices/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.Inutilizacao,"https://hnfe.sefaz.ba.gov.br/webservices/NFeInutilizacao4/NFeInutilizacao4.asmx"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.ConsultaProtocolo,"https://hnfe.sefaz.ba.gov.br/webservices/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.Status,"https://hnfe.sefaz.ba.gov.br/webservices/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.Autorizacao,"https://hnfe.sefaz.ba.gov.br/webservices/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.BA, "Homologacao", TService.RetAutorizacao,"https://hnfe.sefaz.ba.gov.br/webservices/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.RecepcaoEvento,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.Inutilizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeInutilizacao4"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.ConsultaProtocolo,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.Status,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeStatusServico4"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.Autorizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeAutorizacao4"),
                new UrlConfiguration(TServer.CE, "Homologacao", TService.RetAutorizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeRetAutorizacao4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.Inutilizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeInutilizacao4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.ConsultaProtocolo,"https://homolog.sefaz.go.gov.br/nfe/services/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.Status,"https://homolog.sefaz.go.gov.br/nfe/services/NFeStatusServico4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.RecepcaoEvento,"https://homolog.sefaz.go.gov.br/nfe/services/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.Autorizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeAutorizacao4"),
                new UrlConfiguration(TServer.GO, "Homologacao", TService.RetAutorizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeRetAutorizacao4"),
                new UrlConfiguration(TServer.MG, "Homologacao", TService.Inutilizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeInutilizacao4"),
                new UrlConfiguration(TServer.MG, "Homologacao", TService.ConsultaProtocolo,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeConsulta4"),
                new UrlConfiguration(TServer.MG, "Homologacao", TService.Status,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeStatusServico4"),
                new UrlConfiguration(TServer.MG, "Homologacao", TService.Autorizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeAutorizacao4"),
                new UrlConfiguration(TServer.MG, "Homologacao", TService.RetAutorizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeRetAutorizacao4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeInutilizacao4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.ConsultaProtocolo,"https://homologacao.nfe.ms.gov.br/ws/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.Status,"https://homologacao.nfe.ms.gov.br/ws/NFeStatusServico4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.ms.gov.br/ws/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.Autorizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeAutorizacao4"),
                new UrlConfiguration(TServer.MS, "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeRetAutorizacao4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.Inutilizacao,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeInutilizacao4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.ConsultaProtocolo,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeConsulta4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.Status,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.RecepcaoEvento,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/RecepcaoEvento4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.Autorizacao,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeAutorizacao4"),
                new UrlConfiguration(TServer.MT, "Homologacao", TService.RetAutorizacao,"https://homologacao.sefaz.mt.gov.br/nfews/v2/services/NfeRetAutorizacao4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeInutilizacao4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.ConsultaProtocolo,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.Status,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeStatusServico4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.Autorizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeAutorizacao4"),
                new UrlConfiguration(TServer.PR, "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeRetAutorizacao4"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.Inutilizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao4.asmx"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.ConsultaProtocolo,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeConsulta/NfeConsulta4.asmx"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.Status,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.RecepcaoEvento,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.Autorizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.RS, "Homologacao", TService.RetAutorizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeinutilizacao4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.ConsultaProtocolo,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeconsultaprotocolo4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.Status,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nferecepcaoevento4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.Autorizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeautorizacao4.asmx"),
                new UrlConfiguration(TServer.SP, "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nferetautorizacao4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.Inutilizacao,"https://hom.sefazvirtual.fazenda.gov.br/NFeInutilizacao4/NFeInutilizacao4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.ConsultaProtocolo,"https://hom.sefazvirtual.fazenda.gov.br/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.Status,"https://hom.sefazvirtual.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.RecepcaoEvento,"https://hom.sefazvirtual.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.Autorizacao,"https://hom.sefazvirtual.fazenda.gov.br/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Homologacao", TService.RetAutorizacao,"https://hom.sefazvirtual.fazenda.gov.br/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.Inutilizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.ConsultaProtocolo,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeConsulta/NfeConsulta4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.Status,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.RecepcaoEvento,"https://nfe-homologacao.svrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.Autorizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVRS, "Homologacao", TService.RetAutorizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Homologacao", TService.ConsultaProtocolo,"https://hom.svc.fazenda.gov.br/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Homologacao", TService.Status,"https://hom.svc.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Homologacao", TService.RecepcaoEvento,"https://hom.svc.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Homologacao", TService.Autorizacao,"https://hom.svc.fazenda.gov.br/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Homologacao", TService.RetAutorizacao,"https://hom.svc.fazenda.gov.br/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),
                #endregion

                
                #region production
                new UrlConfiguration(TServer.BA, "Producao", TService.Inutilizacao,"https://nfe.sefaz.ba.gov.br/webservices/NFeInutilizacao4/NFeInutilizacao4.asmx"),
                new UrlConfiguration(TServer.BA, "Producao", TService.ConsultaProtocolo,"https://nfe.sefaz.ba.gov.br/webservices/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.BA, "Producao", TService.Status,"https://nfe.sefaz.ba.gov.br/webservices/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.BA, "Producao", TService.RecepcaoEvento,"https://nfe.sefaz.ba.gov.br/webservices/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.BA, "Producao", TService.Autorizacao,"https://nfe.sefaz.ba.gov.br/webservices/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.BA, "Producao", TService.RetAutorizacao,"https://nfe.sefaz.ba.gov.br/webservices/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),


                new UrlConfiguration(TServer.GO, "Producao", TService.Inutilizacao,"https://nfe.sefaz.go.gov.br/nfe/services/NFeInutilizacao4"),
                new UrlConfiguration(TServer.GO, "Producao", TService.ConsultaProtocolo,"https://nfe.sefaz.go.gov.br/nfe/services/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.GO, "Producao", TService.Status,"https://nfe.sefaz.go.gov.br/nfe/services/NFeStatusServico4"),
                new UrlConfiguration(TServer.GO, "Producao", TService.RecepcaoEvento,"https://nfe.sefaz.go.gov.br/nfe/services/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.GO, "Producao", TService.Autorizacao,"https://nfe.sefaz.go.gov.br/nfe/services/NFeAutorizacao4"),
                new UrlConfiguration(TServer.GO, "Producao", TService.RetAutorizacao,"https://nfe.sefaz.go.gov.br/nfe/services/NFeRetAutorizacao4"),


                new UrlConfiguration(TServer.MT, "Producao", TService.Inutilizacao, "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeInutilizacao4"),
                new UrlConfiguration(TServer.MT, "Producao", TService.ConsultaProtocolo,"https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeConsulta4"),
                new UrlConfiguration(TServer.MT, "Producao", TService.Status, "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico4"),
                new UrlConfiguration(TServer.MT, "Producao", TService.RecepcaoEvento,"https://nfe.sefaz.mt.gov.br/nfews/v2/services/RecepcaoEvento4"),
                new UrlConfiguration(TServer.MT, "Producao", TService.Autorizacao,"https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeAutorizacao4"),
                new UrlConfiguration(TServer.MT, "Producao", TService.RetAutorizacao,"https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeRetAutorizacao4"),

                new UrlConfiguration(TServer.PR, "Producao", TService.Inutilizacao,"https://nfe.sefa.pr.gov.br/nfe/NFeInutilizacao4"),
                new UrlConfiguration(TServer.PR, "Producao", TService.ConsultaProtocolo,"https://nfe.sefa.pr.gov.br/nfe/NFeConsultaProtocolo4"),
                new UrlConfiguration(TServer.PR, "Producao", TService.Status, "https://nfe.sefa.pr.gov.br/nfe/NFeStatusServico4"),
                new UrlConfiguration(TServer.PR, "Producao", TService.RecepcaoEvento, "https://nfe.sefa.pr.gov.br/nfe/NFeRecepcaoEvento4"),
                new UrlConfiguration(TServer.PR, "Producao", TService.Autorizacao, "https://nfe.sefa.pr.gov.br/nfe/NFeAutorizacao4"),
                new UrlConfiguration(TServer.PR, "Producao", TService.RetAutorizacao,"https://nfe.sefa.pr.gov.br/nfe/NFeRetAutorizacao4"),

                new UrlConfiguration(TServer.SP, "Producao", TService.Inutilizacao, "https://nfe.fazenda.sp.gov.br/ws/nfeinutilizacao4.asmx"),
                new UrlConfiguration(TServer.SP, "Producao", TService.ConsultaProtocolo,"https://nfe.fazenda.sp.gov.br/ws/nfeconsultaprotocolo4.asmx"),
                new UrlConfiguration(TServer.SP, "Producao", TService.Status, "https://nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx"),
                new UrlConfiguration(TServer.SP, "Producao", TService.RecepcaoEvento, "https://nfe.fazenda.sp.gov.br/ws/nferecepcaoevento4.asmx"),
                new UrlConfiguration(TServer.SP, "Producao", TService.Autorizacao, "https://nfe.fazenda.sp.gov.br/ws/nfeautorizacao4.asmx"),
                new UrlConfiguration(TServer.SP, "Producao", TService.RetAutorizacao, "https://nfe.fazenda.sp.gov.br/ws/nferetautorizacao4.asmx"),

                new UrlConfiguration(TServer.SVAN, "Producao", TService.Inutilizacao,"https://www.sefazvirtual.fazenda.gov.br/NFeInutilizacao4/NFeInutilizacao4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Producao", TService.ConsultaProtocolo,"https://www.sefazvirtual.fazenda.gov.br/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Producao", TService.Status,"https://www.sefazvirtual.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Producao", TService.RecepcaoEvento,"https://www.sefazvirtual.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Producao", TService.Autorizacao,"https://www.sefazvirtual.fazenda.gov.br/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVAN, "Producao", TService.RetAutorizacao,"https://www.sefazvirtual.fazenda.gov.br/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),

                new UrlConfiguration(TServer.SVCAN, "Producao", TService.ConsultaProtocolo,"https://www.svc.fazenda.gov.br/NFeConsultaProtocolo4/NFeConsultaProtocolo4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Producao", TService.Status,"https://www.svc.fazenda.gov.br/NFeStatusServico4/NFeStatusServico4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Producao", TService.RecepcaoEvento,"https://www.svc.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Producao", TService.Autorizacao,"https://www.svc.fazenda.gov.br/NFeAutorizacao4/NFeAutorizacao4.asmx"),
                new UrlConfiguration(TServer.SVCAN, "Producao", TService.RetAutorizacao,"https://www.svc.fazenda.gov.br/NFeRetAutorizacao4/NFeRetAutorizacao4.asmx"),
                #endregion
            };
        }
    }
}