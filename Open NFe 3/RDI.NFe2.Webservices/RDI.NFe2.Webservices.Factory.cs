using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;
using RDI.NFe2.SchemaXML;
using RDI.NFe2.ORMAP;
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

        public static System.Web.Services.Protocols.SoapHttpClientProtocol SoapHttpClientFactory(string ServerName, string Environment, TService ServiceType)
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

        private static string GetURL(string ServerName, string Environment, TService ServiceType)
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
                new UrlConfiguration("AM", "Homologacao", TService.Inutilizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeInutilizacao4"),
                new UrlConfiguration("AM", "Homologacao", TService.Consulta,"https://homnfe.sefaz.am.gov.br/services2/services/NfeConsulta4"),
                new UrlConfiguration("AM", "Homologacao", TService.Status,"https://homnfe.sefaz.am.gov.br/services2/services/NfeStatusServico4"),
                new UrlConfiguration("AM", "Homologacao", TService.RecepcaoEvento,"https://homnfe.sefaz.am.gov.br/services2/services/RecepcaoEvento4"),
                new UrlConfiguration("AM", "Homologacao", TService.Autorizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeAutorizacao4"),
                new UrlConfiguration("AM", "Homologacao", TService.RetAutorizacao,"https://homnfe.sefaz.am.gov.br/services2/services/NfeRetAutorizacao4"),
                
                //SEFAZ BA 
                
                new UrlConfiguration("CE", "Homologacao", TService.RecepcaoEvento,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeRecepcaoEvento4"),
                new UrlConfiguration("CE", "Homologacao", TService.Inutilizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeInutilizacao4"),
                new UrlConfiguration("CE", "Homologacao", TService.Consulta,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeConsultaProtocolo4"),
                new UrlConfiguration("CE", "Homologacao", TService.Status,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeStatusServico4"),
                new UrlConfiguration("CE", "Homologacao", TService.Autorizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeAutorizacao4"),
                new UrlConfiguration("CE", "Homologacao", TService.RetAutorizacao,"https://nfeh.sefaz.ce.gov.br/nfe4/services/NFeRetAutorizacao4"),

                new UrlConfiguration("GO", "Homologacao", TService.Inutilizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeInutilizacao4"),
                new UrlConfiguration("GO", "Homologacao", TService.Consulta,"https://homolog.sefaz.go.gov.br/nfe/services/NFeConsultaProtocolo4"),
                new UrlConfiguration("GO", "Homologacao", TService.Status,"https://homolog.sefaz.go.gov.br/nfe/services/NFeStatusServico4"),
                new UrlConfiguration("GO", "Homologacao", TService.RecepcaoEvento,"https://homolog.sefaz.go.gov.br/nfe/services/NFeRecepcaoEvento4"),
                new UrlConfiguration("GO", "Homologacao", TService.Autorizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeAutorizacao4"),
                new UrlConfiguration("GO", "Homologacao", TService.RetAutorizacao,"https://homolog.sefaz.go.gov.br/nfe/services/NFeRetAutorizacao4"),

                new UrlConfiguration("MG", "Homologacao", TService.Inutilizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeInutilizacao4"),
                new UrlConfiguration("MG", "Homologacao", TService.Consulta,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeConsulta4"),
                new UrlConfiguration("MG", "Homologacao", TService.Status,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeStatusServico4"),
                new UrlConfiguration("MG", "Homologacao", TService.Autorizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeAutorizacao4"),
                new UrlConfiguration("MG", "Homologacao", TService.RetAutorizacao,"https://hnfe.fazenda.mg.gov.br/nfe2/services/NFeRetAutorizacao4"),

                new UrlConfiguration("MS", "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeInutilizacao4"),
                new UrlConfiguration("MS", "Homologacao", TService.Consulta,"https://homologacao.nfe.ms.gov.br/ws/NFeConsultaProtocolo4"),
                new UrlConfiguration("MS", "Homologacao", TService.Status,"https://homologacao.nfe.ms.gov.br/ws/NFeStatusServico4"),
                new UrlConfiguration("MS", "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.ms.gov.br/ws/NFeRecepcaoEvento4"),
                new UrlConfiguration("MS", "Homologacao", TService.Autorizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeAutorizacao4"),
                new UrlConfiguration("MS", "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.ms.gov.br/ws/NFeRetAutorizacao4"),
                
                //SEFAZ MT
                
                //SEFAZ PE
                
                new UrlConfiguration("PR", "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeInutilizacao4"),
                new UrlConfiguration("PR", "Homologacao", TService.Consulta,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeConsultaProtocolo4"),
                new UrlConfiguration("PR", "Homologacao", TService.Status,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeStatusServico4"),
                new UrlConfiguration("PR", "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeRecepcaoEvento4"),
                new UrlConfiguration("PR", "Homologacao", TService.Autorizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeAutorizacao4"),
                new UrlConfiguration("PR", "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.sefa.pr.gov.br/nfe/NFeRetAutorizacao4"),

                new UrlConfiguration("RS", "Homologacao", TService.Inutilizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao4.asmx"),
                new UrlConfiguration("RS", "Homologacao", TService.Consulta,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeConsulta/NfeConsulta4.asmx"),
                new UrlConfiguration("RS", "Homologacao", TService.Status,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx"),
                new UrlConfiguration("RS", "Homologacao", TService.RecepcaoEvento,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx"),
                new UrlConfiguration("RS", "Homologacao", TService.Autorizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao4.asmx"),
                new UrlConfiguration("RS", "Homologacao", TService.RetAutorizacao,"https://nfe-homologacao.sefazrs.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao4.asmx"),

                new UrlConfiguration("SP", "Homologacao", TService.Inutilizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeinutilizacao4.asmx"),
                new UrlConfiguration("SP", "Homologacao", TService.Consulta,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeconsulta4.asmx"),
                new UrlConfiguration("SP", "Homologacao", TService.Status,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico4.asmx"),
                new UrlConfiguration("SP", "Homologacao", TService.RecepcaoEvento,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nferecepcaoevento4.asmx"),
                new UrlConfiguration("SP", "Homologacao", TService.Autorizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfeautorizacao4.asmx"),
                new UrlConfiguration("SP", "Homologacao", TService.RetAutorizacao,"https://homologacao.nfe.fazenda.sp.gov.br/ws/nferetautorizacao4.asmx"),
                
                //Sefaz SVAN (MA, PA)
                
                new UrlConfiguration("SVRS", "Homologacao", TService.Inutilizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao4.asmx"),
                new UrlConfiguration("SVRS", "Homologacao", TService.Consulta,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeConsulta/NfeConsulta4.asmx"),
                new UrlConfiguration("SVRS", "Homologacao", TService.Status,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeStatusServico/NfeStatusServico4.asmx"),
                new UrlConfiguration("SVRS", "Homologacao", TService.RecepcaoEvento,"https://nfe-homologacao.svrs.rs.gov.br/ws/recepcaoevento/recepcaoevento4.asmx"),
                new UrlConfiguration("SVRS", "Homologacao", TService.Autorizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao4.asmx"),
                new UrlConfiguration("SVRS", "Homologacao", TService.RetAutorizacao,"https://nfe-homologacao.svrs.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao4.asmx"),
                #endregion
            };
        }
    }
}