using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;
using RDI.NFe2.SchemaXML;
using System.Collections.Generic;

namespace RDI.NFe2.Webservices
{
    public enum TService
    {
        [ClasseServico(NomeClasse = "RecepcaoEvento")]
        [HubConfiguration(WSName = "NFeRecepcaoEvento4", WSMethod = "nfeRecepcaoEvento")]
        RecepcaoEvento,

        [ClasseServico(NomeClasse = "NfeInutilizacao2")]
        [HubConfiguration(WSName = "NFeInutilizacao4", WSMethod = "nfeInutilizacaoNF")]
        Inutilizacao,

        [ClasseServico(NomeClasse = "NfeStatusServico2")]
        [HubConfiguration(WSName = "NFeStatusServico4", WSMethod = "nfeStatusServicoNF")]
        Status,

        [ClasseServico(NomeClasse = "NfeConsulta2")]
        [HubConfiguration(WSName = "NFeConsultaProtocolo4", WSMethod = "nfeConsultaNF")]
        ConsultaProtocolo,

        [ClasseServico(NomeClasse = "NfeAutorizacao")]
        [HubConfiguration(WSName = "NFeAutorizacao4", WSMethod = "nfeAutorizacaoLote")]
        Autorizacao,

        [ClasseServico(NomeClasse = "NfeRetAutorizacao")]
        [HubConfiguration(WSName = "NFeRetAutorizacao4", WSMethod = "nfeRetAutorizacaoLote")]
        RetAutorizacao,

        [ClasseServico(NomeClasse = "CadConsultaCadastro2")]
        [HubConfiguration(WSName = "CadConsultaCadastro4", WSMethod = "consultaCadastro")]
        Cadastro,

        [ClasseServico(NomeClasse = "NFeDistribuicaoDFe")]
        ConsultaDFe,
        [ClasseServico(NomeClasse = "NfeDownloadNF")]
        DownloadNF,
        [ClasseServico(NomeClasse = "RecepcaoEvento")]
        ManifestacaoDestinatario,
        [ClasseServico(NomeClasse = "GnreLoteRecepcao")]
        GNRE_RecepcaoLote,
        [ClasseServico(NomeClasse = "GnreResultadoLote")]
        GNRE_ConsultaLote,
        [ClasseServico(NomeClasse = "GnreConfigUF")]
        GNRE_ConfigUF,

        [ClasseServico(NomeClasse = "RecepcaoEvento")]
        EPEC,
    }
}