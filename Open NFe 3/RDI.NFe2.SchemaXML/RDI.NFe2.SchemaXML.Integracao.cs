using System.Xml.Serialization;
using System;
using System.Linq;
using System.Reflection;

namespace RDI.NFe2.SchemaXML
{
    public enum TServico
    {
        [ClasseServico(value = "RecepcaoEvento")]
        RecepcaoEvento,
        [ClasseServico(value = "NfeInutilizacao2")]
        Inutilizacao,
        [ClasseServico(value = "NfeStatusServico2")]
        Status,
        [ClasseServico(value = "NfeConsulta2")]
        Consulta,
        [ClasseServico(value = "NfeAutorizacao")]
        Autorizacao,
        [ClasseServico(value = "NfeRetAutorizacao")]
        RetAutorizacao,
        [ClasseServico(value = "CadConsultaCadastro2")]
        Cadastro,
        [ClasseServico(value = "NFeDistribuicaoDFe")]
        ConsultaDFe,
        [ClasseServico(value = "NfeDownloadNF")]
        DownloadNF,
        [ClasseServico(value = "RecepcaoEvento")]
        ManifestacaoDestinatario,
        [ClasseServico(value = "GnreLoteRecepcao")]
        GNRE_RecepcaoLote,
        [ClasseServico(value = "GnreResultadoLote")]
        GNRE_ConsultaLote,
        [ClasseServico(value = "GnreConfigUF")]
        GNRE_ConfigUF,
    }

    public static class Factory
    {
        public const string NFeSchema200ns = "RDI.NFe2.SchemaXML.NFe_v200.";
        public const string NFeSchema300ns = "RDI.NFe2.SchemaXML.NFe_v300.";
        public const string NFeSchema310ns = "RDI.NFe2.SchemaXML.NFe_v310.";
        public const string NFeSchema400ns = "RDI.NFe2.SchemaXML.NFe_v400.";
        public const string GNRESchema100ns = "RDI.NFe2.GNRE.";


        public static Type GetXMLType(VersaoXML version, string stType)
        {
            Type tipo = null;
            if (version == VersaoXML.NFe_v200)
            {
                tipo = Type.GetType(NFeSchema200ns + stType);
            }
            else if (version == VersaoXML.NFe_v300)
            {
                tipo = Type.GetType(NFeSchema300ns + stType);
            }
            else if (version == VersaoXML.NFe_v310)
            {
                tipo = Type.GetType(NFeSchema310ns + stType);
            }
            else if (version == VersaoXML.Integracao)
            {
                tipo = Type.GetType("SchemaXML." + stType);
            }
            else if (version == VersaoXML.GNRE)
            {
                tipo = Type.GetType(GNRESchema100ns + stType);
            }
            else
            {
                throw new Exception("Tipo não pode ser definido.");
            }
            return tipo;
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerDistDFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.01")]
        Item101,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerResEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum resNFeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerResNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
        [System.Xml.Serialization.XmlEnumAttribute("2.00")]
        Item200,
        [System.Xml.Serialization.XmlEnumAttribute("3.00")]
        Item300,
        [System.Xml.Serialization.XmlEnumAttribute("3.10")]
        Item310,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TDownloadNFeXServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DOWNLOAD NFE")]
        DOWNLOADNFE,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerDownloadNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum resNFeCSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ITCTypeCNPJCPFDest
    {

        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCancNFeInfCancXServ
    {

        /// <remarks/>
        CANCELAR,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsStatServXServ
    {

        /// <remarks/>
        STATUS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsSitNFeXServ
    {

        /// <remarks/>
        CONSULTAR,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ITCTypeCNPJCPF
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ITCTypeCNPJCPFIE
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        IE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoXCondUso
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(@"A Carta de Correção é disciplinada pelo § 1º-A do art. 7º do Convênio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularização de erro ocorrido na emissão de documento fiscal, desde que o erro não esteja relacionado com: I - as variáveis que determinam o valor do imposto tais como: base de cálculo, alíquota, diferença de preço, quantidade, valor da operação ou da prestação; II - a correção de dados cadastrais que implique mudança do remetente ou do destinatário; III - a data de emissão ou de saída.")]
        ACartadeCorreçãoédisciplinadapelo1ºAdoart7ºdoConvênioSNde15dedezembrode1970epodeserutilizadapararegularizaçãodeerroocorridonaemissãodedocumentofiscaldesdequeoerronãoestejarelacionadocomIasvariáveisquedeterminamovalordoimpostotaiscomobasedecálculoalíquotadiferençadepreçoquantidadevalordaoperaçãooudaprestaçãoIIacorreçãodedadoscadastraisqueimpliquemudançadoremetenteoudodestinatárioIIIadatadeemissãooudesaída,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(@"A Carta de Correcao e disciplinada pelo paragrafo 1o-A do art. 7o do Convenio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularizacao de erro ocorrido na emissao de documento fiscal, desde que o erro nao esteja relacionado com: I - as variaveis que determinam o valor do imposto tais como: base de calculo, aliquota, diferenca de preco, quantidade, valor da operacao ou da prestacao; II - a correcao de dados cadastrais que implique mudanca do remetente ou do destinatario; III - a data de emissao ou de saida.")]
        ACartadeCorrecaoedisciplinadapeloparagrafo1oAdoart7odoConvenioSNde15dedezembrode1970epodeserutilizadapararegularizacaodeerroocorridonaemissaodedocumentofiscaldesdequeoerronaoestejarelacionadocomIasvariaveisquedeterminamovalordoimpostotaiscomobasedecalculoaliquotadiferencadeprecoquantidadevalordaoperacaooudaprestacaoIIacorrecaodedadoscadastraisqueimpliquemudancadoremetenteoudodestinatarioIIIadatadeemissaooudesaida,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoVersao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }





    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoVerEvento
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TInutNFeInfInutXServ
    {

        /// <remarks/>
        INUTILIZAR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerConsSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.01")]
        Item201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3.00")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3.10")]
        Item310,

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoDescEvento
    {

        [System.Xml.Serialization.XmlEnumAttribute("CT-e Autorizado")]
        CTeAutorizado,

        [System.Xml.Serialization.XmlEnumAttribute("Ciencia da Operacao")]
        CienciaDaOperacao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carta de Correção")]
        CartadeCorreção,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carta de Correcao")]
        CartadeCorrecao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cancelamento")]
        Cancelamento,

        [System.Xml.Serialization.XmlEnumAttribute("Confirmacao da Operacao")]
        ConfirmacaoDaOperacao,

        [System.Xml.Serialization.XmlEnumAttribute("Desconhecimento da Operacao")]
        DesconhecimentoDaOperacao,

        [System.Xml.Serialization.XmlEnumAttribute("Operacao nao Realizada")]
        OperacaoNaoRealizada,

    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoTpEvento
    {
        /// <remarks/>
        [System.ComponentModel.Description("Carta de Correção")]
        [System.Xml.Serialization.XmlEnumAttribute("110110")]
        CartaCorrecao = 0,

        /// <remarks/>
        [System.ComponentModel.Description("Cancelamento")]
        [System.Xml.Serialization.XmlEnumAttribute("110111")]
        Cancelamento = 1,

        [System.ComponentModel.Description("Ciência da Operação")]
        [System.Xml.Serialization.XmlEnumAttribute("210210")]
        CienciaDaOperacao = 2,

        //[System.ComponentModel.Description("CT-e Autorizado")]
        //[System.Xml.Serialization.XmlEnumAttribute("610600")]
        //CTeAutorizado = 3,

        //[System.ComponentModel.Description("Confirmação da Operação")]
        //[System.Xml.Serialization.XmlEnumAttribute("210200")]
        //ConfirmacaoDaOperacao = 4,

        //[System.ComponentModel.Description("Desconhecimento da Operação")]
        //[System.Xml.Serialization.XmlEnumAttribute("210220")]
        //DesconhecimentoDaOperacao = 5,

        //[System.ComponentModel.Description("Operação não Realizada")]
        //[System.Xml.Serialization.XmlEnumAttribute("210240")]
        //OperacaoNaoRealizada = 6,

        //[System.ComponentModel.Description("Evento610500")]
        //[System.Xml.Serialization.XmlEnumAttribute("610500")]
        //Evento610500 = 7,

        //[System.ComponentModel.Description("Evento610501")]
        //[System.Xml.Serialization.XmlEnumAttribute("610501")]
        //Evento610501 = 8,

        //[System.ComponentModel.Description("Evento610600")]
        //[System.Xml.Serialization.XmlEnumAttribute("610600")]
        //Evento610600 = 9,

        //[System.ComponentModel.Description("Evento610601")]
        //[System.Xml.Serialization.XmlEnumAttribute("610601")]
        //Evento610601 = 10,

        //[System.ComponentModel.Description("Evento110140")]
        //[System.Xml.Serialization.XmlEnumAttribute("110140")]
        //Evento110140 = 11,

        //[System.ComponentModel.Description("Evento990910")]
        //[System.Xml.Serialization.XmlEnumAttribute("990910")]
        //Evento990910 = 12,

        //[System.ComponentModel.Description("Evento610611")]
        //[System.Xml.Serialization.XmlEnumAttribute("610611")]
        //Evento610611 = 13,

        //[System.ComponentModel.Description("Evento610550")]
        //[System.Xml.Serialization.XmlEnumAttribute("610550")]
        //Evento610550 = 14,

        // atualizar com demais schemas

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Normal")]
        Normal = 1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        [System.ComponentModel.Description("Contigência FS")]
        ContigenciaFS = 2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        [System.ComponentModel.Description("Contigência SCAN")]
        ContigenciaSCAN = 3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        [System.ComponentModel.Description("Contigência DPEC")]
        ContigenciaDPEC = 4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        [System.ComponentModel.Description("Contigência FS-DA")]
        ContigenciaFSDA = 5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        [System.ComponentModel.Description("Contingência SVC-AN")]
        ContingenciaSVCAN = 6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        [System.ComponentModel.Description("Contingência SVC-RS")]
        ContingenciaSVCRS = 7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        [System.ComponentModel.Description("Contingência off-line da NFC-e")]
        ContingenciaOffLineNFCe = 9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Produção")]
        Producao = 1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        [System.ComponentModel.Description("Homologação")]
        Homologacao = 2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCOrgaoIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("91")]
        Item91,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("92")]
        Item92,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCodUfIBGE
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        [System.ComponentModel.Description("Não definido")]
        [NFe_AtendidoPor(value = "")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "")]
        NaoDefinido = 0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        [System.ComponentModel.Description("Rondônia")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Rondonia = 11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        [System.ComponentModel.Description("Acre")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Acre = 12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        [System.ComponentModel.Description("Amazonas")]
        [NFe_AtendidoPor(value = "AM")]
        [NFCe_AtendidoPor(value = "AM")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Amazonas = 13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        [System.ComponentModel.Description("Roraima")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Roraima = 14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        [System.ComponentModel.Description("Pará")]
        [NFe_AtendidoPor(value = "SVAN")]
        [NFCe_AtendidoPor(value = "AM")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Para = 15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        [System.ComponentModel.Description("Amapá")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Amapa = 16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        [System.ComponentModel.Description("Tocantins")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Tocantins = 17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        [System.ComponentModel.Description("Maranhão")]
        [NFe_AtendidoPor(value = "SVAN")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Maranhao = 21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        [System.ComponentModel.Description("Piauí")]
        [NFe_AtendidoPor(value = "SVAN")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Piaui = 22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        [System.ComponentModel.Description("Ceará")]
        [NFe_AtendidoPor(value = "CE")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Ceara = 23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        [System.ComponentModel.Description("Rio Grande do Norte")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        RioGrandedoNorte = 24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        [System.ComponentModel.Description("Paraíba")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Paraiba = 25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        [System.ComponentModel.Description("Pernambuco")]
        [NFe_AtendidoPor(value = "PE")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Pernambuco = 26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        [System.ComponentModel.Description("Alagoas")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Alagoas = 27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        [System.ComponentModel.Description("Sergipe")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "SVRS")]
        [SVC_AtendidoPor(value = "SVCAN")]
        Sergipe = 28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        [System.ComponentModel.Description("Bahia")]
        [NFe_AtendidoPor(value = "BA")]
        [NFCe_AtendidoPor(value = "SVRS")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Bahia = 29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        [System.ComponentModel.Description("Minas Gerais")]
        [NFe_AtendidoPor(value = "MG")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        MinasGerais = 31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        [System.ComponentModel.Description("Espírito Santo")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        EspiritoSanto = 32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        [System.ComponentModel.Description("Rio de Janeiro")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        RiodeJaneiro = 33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        [System.ComponentModel.Description("São Paulo")]
        [NFe_AtendidoPor(value = "SP")]
        [NFCe_AtendidoPor(value = "SP")]
        [SVC_AtendidoPor(value = "SVCAN")]
        SaoPaulo = 35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        [System.ComponentModel.Description("Paraná")]
        [NFe_AtendidoPor(value = "PR")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Parana = 41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        [System.ComponentModel.Description("Santa Catarina")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        SantaCatarina = 42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        [System.ComponentModel.Description("Rio Grande do Sul")]
        [NFe_AtendidoPor(value = "RS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        RioGrandedoSul = 43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        [System.ComponentModel.Description("Mato Grosso do Sul")]
        [NFe_AtendidoPor(value = "MS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        MatoGrossodoSul = 50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        [System.ComponentModel.Description("Mato Grosso")]
        [NFe_AtendidoPor(value = "MT")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        MatoGrosso = 51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        [System.ComponentModel.Description("Goiás")]
        [NFe_AtendidoPor(value = "GO")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCRS")]
        Goias = 52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        [System.ComponentModel.Description("Distrito Federal")]
        [NFe_AtendidoPor(value = "SVRS")]
        [NFCe_AtendidoPor(value = "")]
        [SVC_AtendidoPor(value = "SVCAN")]
        DistritoFederal = 53,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUfEmi
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

        /// <remarks/>
        EX,
    }

    public enum TipoConexao
    {
        NFe = 1,
        NFCe = 2,
        GNRE = 3,
    }

    public enum VersaoXML
    {
        NFe_v200 = 1,
        NFe_v300 = 2,
        NFe_v310 = 3,
        Integracao = 4,
        GNRE = 5,
        NFe_v400 = 6,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public enum TIntegracaoVersao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.rochadigital.com/opennfe")]
    public enum TSimNao
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        [System.ComponentModel.Description("Não")]
        Nao,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Sim")]
        Sim
    }


    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.rochadigital.com/opennfe")]
    [System.Xml.Serialization.XmlRootAttribute("Integracao", Namespace = "http://www.rochadigital.com/opennfe", IsNullable = false)]
    public partial class TIntegracao
    {

        private object itemField;
        private TIntegracaoVersao versaoField;

        [System.Xml.Serialization.XmlElementAttribute("RetornoCancelamento", typeof(TRetornoCancelamento))]
        [System.Xml.Serialization.XmlElementAttribute("RetornoInutilizacao", typeof(TRetornoInutilizacao))]
        [System.Xml.Serialization.XmlElementAttribute("Rejeicao", typeof(TRejeicao))]
        [System.Xml.Serialization.XmlElementAttribute("Impressao", typeof(TImpressao))]
        [System.Xml.Serialization.XmlElementAttribute("HeartBeat", typeof(THeartBeat))]
        public object item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TIntegracaoVersao versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class TImpressao
    {

        private string chNFeField;

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }
    }


    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class THeartBeat
    {
        private System.DateTime horarioField;
        private TSimNao emExecucaoField;
        private System.DateTime horarioExecucaoField;
        private bool horarioExecucaoSpecifiedField;

        public System.DateTime horario
        {
            get
            {
                return this.horarioField;
            }
            set
            {
                this.horarioField = value;
            }
        }

        public TSimNao emExecucao
        {
            get
            {
                return this.emExecucaoField;
            }
            set
            {
                this.emExecucaoField = value;
            }
        }

        public System.DateTime horarioExecucao
        {
            get
            {
                return this.horarioExecucaoField;
            }
            set
            {
                this.horarioExecucaoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horarioExecucaoSpecified
        {
            get
            {
                return this.horarioExecucaoSpecifiedField;
            }
            set
            {
                this.horarioExecucaoSpecifiedField = value;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class TRejeicao
    {
        private string chNFeField;
        private string cStatField;
        private string xMotivoField;

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class TRetornoInutilizacao
    {
        private string inutIDField;
        private string cStatField;
        private string xMotivoField;
        private bool aprovadoField;

        public string inutID
        {
            get
            {
                return this.inutIDField;
            }
            set
            {
                this.inutIDField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public bool aprovado
        {
            get
            {
                return this.aprovadoField;
            }
            set
            {
                this.aprovadoField = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class TRetornoCancelamento
    {
        private string chNFeField;
        private string cStatField;
        private string xMotivoField;
        private bool aprovadoField;
        private string origemField;

        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        public bool aprovado
        {
            get
            {
                return this.aprovadoField;
            }
            set
            {
                this.aprovadoField = value;
            }
        }

        public string origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
            }
        }
    }

}