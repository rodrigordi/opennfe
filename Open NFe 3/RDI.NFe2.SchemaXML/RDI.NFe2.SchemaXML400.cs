﻿////versao inicial para 4.00 - baseado na PL 009 v4 - 23/08/2017
////TODO : falta validar os campos

//using System.Xml.Serialization;
//using RDI.NFe2.SchemaXML;
//using RDI.NFe2.SchemaXML.Eventos_v100;
//using RDI.NFe2.SchemaXML.Signature;
//using System.Xml;

//namespace RDI.NFe2.SchemaXML.NFe_v400
//{

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("consReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TConsReciNFe
//    {

//        private TAmb tpAmbField;

//        private string nRecField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string nRec
//        {
//            get
//            {
//                return this.nRecField;
//            }
//            set
//            {
//                this.nRecField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }








//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TConsSitNFe
//    {

//        private TAmb tpAmbField;

//        private TConsSitNFeXServ xServField;

//        private string chNFeField;

//        private TVerConsSitNFe versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TConsSitNFeXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public TVerConsSitNFe versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TConsStatServ
//    {

//        private TAmb tpAmbField;

//        private TCodUfIBGE cUFField;

//        private TConsStatServXServ xServField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public TConsStatServXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TEnviNFe
//    {

//        private string idLoteField;

//        private TEnviNFeIndSinc indSincField;

//        private TNFe[] nFeField;

//        private string versaoField;

//        /// <remarks/>
//        public string idLote
//        {
//            get
//            {
//                return this.idLoteField;
//            }
//            set
//            {
//                this.idLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnviNFeIndSinc indSinc
//        {
//            get
//            {
//                return this.indSincField;
//            }
//            set
//            {
//                this.indSincField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NFe")]
//        public TNFe[] NFe
//        {
//            get
//            {
//                return this.nFeField;
//            }
//            set
//            {
//                this.nFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TNFe
//    {

//        private TNFeInfNFe infNFeField;

//        private TNFeInfNFeSupl infNFeSuplField;

//        private SignatureType signatureField;

//        /// <remarks/>
//        public TNFeInfNFe infNFe
//        {
//            get
//            {
//                return this.infNFeField;
//            }
//            set
//            {
//                this.infNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeSupl infNFeSupl
//        {
//            get
//            {
//                return this.infNFeSuplField;
//            }
//            set
//            {
//                this.infNFeSuplField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFe
//    {

//        private TNFeInfNFeIde ideField;

//        private TNFeInfNFeEmit emitField;

//        private TNFeInfNFeAvulsa avulsaField;

//        private TNFeInfNFeDest destField;

//        private TLocal retiradaField;

//        private TLocal entregaField;

//        private TNFeInfNFeAutXML[] autXMLField;

//        private TNFeInfNFeDet[] detField;

//        private TNFeInfNFeTotal totalField;

//        private TNFeInfNFeTransp transpField;

//        private TNFeInfNFeCobr cobrField;

//        private TNFeInfNFePag pagField;

//        private TNFeInfNFeInfAdic infAdicField;

//        private TNFeInfNFeExporta exportaField;

//        private TNFeInfNFeCompra compraField;

//        private TNFeInfNFeCana canaField;

//        private string versaoField;

//        private string idField;

//        /// <remarks/>
//        public TNFeInfNFeIde ide
//        {
//            get
//            {
//                return this.ideField;
//            }
//            set
//            {
//                this.ideField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeEmit emit
//        {
//            get
//            {
//                return this.emitField;
//            }
//            set
//            {
//                this.emitField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeAvulsa avulsa
//        {
//            get
//            {
//                return this.avulsaField;
//            }
//            set
//            {
//                this.avulsaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDest dest
//        {
//            get
//            {
//                return this.destField;
//            }
//            set
//            {
//                this.destField = value;
//            }
//        }

//        /// <remarks/>
//        public TLocal retirada
//        {
//            get
//            {
//                return this.retiradaField;
//            }
//            set
//            {
//                this.retiradaField = value;
//            }
//        }

//        /// <remarks/>
//        public TLocal entrega
//        {
//            get
//            {
//                return this.entregaField;
//            }
//            set
//            {
//                this.entregaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("autXML")]
//        public TNFeInfNFeAutXML[] autXML
//        {
//            get
//            {
//                return this.autXMLField;
//            }
//            set
//            {
//                this.autXMLField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("det")]
//        public TNFeInfNFeDet[] det
//        {
//            get
//            {
//                return this.detField;
//            }
//            set
//            {
//                this.detField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotal total
//        {
//            get
//            {
//                return this.totalField;
//            }
//            set
//            {
//                this.totalField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTransp transp
//        {
//            get
//            {
//                return this.transpField;
//            }
//            set
//            {
//                this.transpField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCobr cobr
//        {
//            get
//            {
//                return this.cobrField;
//            }
//            set
//            {
//                this.cobrField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFePag pag
//        {
//            get
//            {
//                return this.pagField;
//            }
//            set
//            {
//                this.pagField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeInfAdic infAdic
//        {
//            get
//            {
//                return this.infAdicField;
//            }
//            set
//            {
//                this.infAdicField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeExporta exporta
//        {
//            get
//            {
//                return this.exportaField;
//            }
//            set
//            {
//                this.exportaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCompra compra
//        {
//            get
//            {
//                return this.compraField;
//            }
//            set
//            {
//                this.compraField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCana cana
//        {
//            get
//            {
//                return this.canaField;
//            }
//            set
//            {
//                this.canaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIde
//    {

//        private TCodUfIBGE cUFField;

//        private string cNFField;

//        private string natOpField;

//        private TMod modField;

//        private string serieField;

//        private string nNFField;

//        private string dhEmiField;

//        private string dhSaiEntField;

//        private TNFeInfNFeIdeTpNF tpNFField;

//        private TNFeInfNFeIdeIdDest idDestField;

//        private string cMunFGField;

//        private TNFeInfNFeIdeTpImp tpImpField;

//        private TNFeInfNFeIdeTpEmis tpEmisField;

//        private string cDVField;

//        private TAmb tpAmbField;

//        private TFinNFe_v310_v400 finNFeField;

//        private TNFeInfNFeIdeIndFinal indFinalField;

//        private TNFeInfNFeIdeIndPres_v400 indPresField;

//        private TProcEmi procEmiField;

//        private string verProcField;

//        private string dhContField;

//        private string xJustField;

//        private TNFeInfNFeIdeNFref[] nFrefField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string cNF
//        {
//            get
//            {
//                return this.cNFField;
//            }
//            set
//            {
//                this.cNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string natOp
//        {
//            get
//            {
//                return this.natOpField;
//            }
//            set
//            {
//                this.natOpField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhEmi
//        {
//            get
//            {
//                return this.dhEmiField;
//            }
//            set
//            {
//                this.dhEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhSaiEnt
//        {
//            get
//            {
//                return this.dhSaiEntField;
//            }
//            set
//            {
//                this.dhSaiEntField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpNF tpNF
//        {
//            get
//            {
//                return this.tpNFField;
//            }
//            set
//            {
//                this.tpNFField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIdDest idDest
//        {
//            get
//            {
//                return this.idDestField;
//            }
//            set
//            {
//                this.idDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpImp tpImp
//        {
//            get
//            {
//                return this.tpImpField;
//            }
//            set
//            {
//                this.tpImpField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpEmis tpEmis
//        {
//            get
//            {
//                return this.tpEmisField;
//            }
//            set
//            {
//                this.tpEmisField = value;
//            }
//        }

//        /// <remarks/>
//        public string cDV
//        {
//            get
//            {
//                return this.cDVField;
//            }
//            set
//            {
//                this.cDVField = value;
//            }
//        }

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TFinNFe_v310_v400 finNFe
//        {
//            get
//            {
//                return this.finNFeField;
//            }
//            set
//            {
//                this.finNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIndFinal indFinal
//        {
//            get
//            {
//                return this.indFinalField;
//            }
//            set
//            {
//                this.indFinalField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIndPres_v400 indPres
//        {
//            get
//            {
//                return this.indPresField;
//            }
//            set
//            {
//                this.indPresField = value;
//            }
//        }

//        /// <remarks/>
//        public TProcEmi procEmi
//        {
//            get
//            {
//                return this.procEmiField;
//            }
//            set
//            {
//                this.procEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string verProc
//        {
//            get
//            {
//                return this.verProcField;
//            }
//            set
//            {
//                this.verProcField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhCont
//        {
//            get
//            {
//                return this.dhContField;
//            }
//            set
//            {
//                this.dhContField = value;
//            }
//        }

//        /// <remarks/>
//        public string xJust
//        {
//            get
//            {
//                return this.xJustField;
//            }
//            set
//            {
//                this.xJustField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NFref")]
//        public TNFeInfNFeIdeNFref[] NFref
//        {
//            get
//            {
//                return this.nFrefField;
//            }
//            set
//            {
//                this.nFrefField = value;
//            }
//        }
//    }






//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFref
//    {

//        private object itemField;

//        private ITCTypeRefNF itemElementNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
//        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
//        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
//        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeRefNF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefECF
//    {

//        private TNFeInfNFeIdeNFrefRefECFMod modField;

//        private string nECFField;

//        private string nCOOField;

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefECFMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string nECF
//        {
//            get
//            {
//                return this.nECFField;
//            }
//            set
//            {
//                this.nECFField = value;
//            }
//        }

//        /// <remarks/>
//        public string nCOO
//        {
//            get
//            {
//                return this.nCOOField;
//            }
//            set
//            {
//                this.nCOOField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefNF
//    {

//        private TCodUfIBGE cUFField;

//        private string aAMMField;

//        private string cNPJField;

//        private TNFeInfNFeIdeNFrefRefNFMod modField;

//        private string serieField;

//        private string nNFField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string AAMM
//        {
//            get
//            {
//                return this.aAMMField;
//            }
//            set
//            {
//                this.aAMMField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefNFMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefNFP
//    {

//        private TCodUfIBGE cUFField;

//        private string aAMMField;

//        private string itemField;

//        private ItemChoiceType itemElementNameField;

//        private string ieField;

//        private TNFeInfNFeIdeNFrefRefNFPMod modField;

//        private string serieField;

//        private string nNFField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string AAMM
//        {
//            get
//            {
//                return this.aAMMField;
//            }
//            set
//            {
//                this.aAMMField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefNFPMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeEmit
//    {

//        private string itemField;

//        private ItemChoiceType2 itemElementNameField;

//        private string xNomeField;

//        private string xFantField;

//        private TEnderEmi enderEmitField;

//        private string ieField;

//        private string iESTField;

//        private string imField;

//        private string cNAEField;

//        private TNFeInfNFeEmitCRT cRTField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType2 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public string xFant
//        {
//            get
//            {
//                return this.xFantField;
//            }
//            set
//            {
//                this.xFantField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmi enderEmit
//        {
//            get
//            {
//                return this.enderEmitField;
//            }
//            set
//            {
//                this.enderEmitField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string IEST
//        {
//            get
//            {
//                return this.iESTField;
//            }
//            set
//            {
//                this.iESTField = value;
//            }
//        }

//        /// <remarks/>
//        public string IM
//        {
//            get
//            {
//                return this.imField;
//            }
//            set
//            {
//                this.imField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNAE
//        {
//            get
//            {
//                return this.cNAEField;
//            }
//            set
//            {
//                this.cNAEField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeEmitCRT CRT
//        {
//            get
//            {
//                return this.cRTField;
//            }
//            set
//            {
//                this.cRTField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEnderEmi
//    {

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUfEmi ufField;

//        private string cEPField;

//        private TEnderEmiCPais cPaisField;

//        private bool cPaisFieldSpecified;

//        private TEnderEmiXPais xPaisField;

//        private bool xPaisFieldSpecified;

//        private string foneField;

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEP
//        {
//            get
//            {
//                return this.cEPField;
//            }
//            set
//            {
//                this.cEPField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmiCPais cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cPaisSpecified
//        {
//            get
//            {
//                return this.cPaisFieldSpecified;
//            }
//            set
//            {
//                this.cPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmiXPais xPais
//        {
//            get
//            {
//                return this.xPaisField;
//            }
//            set
//            {
//                this.xPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool xPaisSpecified
//        {
//            get
//            {
//                return this.xPaisFieldSpecified;
//            }
//            set
//            {
//                this.xPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeAvulsa
//    {

//        private string cNPJField;

//        private string xOrgaoField;

//        private string matrField;

//        private string xAgenteField;

//        private string foneField;

//        private TUfEmi ufField;

//        private string nDARField;

//        private string dEmiField;

//        private string vDARField;

//        private string repEmiField;

//        private string dPagField;

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public string xOrgao
//        {
//            get
//            {
//                return this.xOrgaoField;
//            }
//            set
//            {
//                this.xOrgaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string matr
//        {
//            get
//            {
//                return this.matrField;
//            }
//            set
//            {
//                this.matrField = value;
//            }
//        }

//        /// <remarks/>
//        public string xAgente
//        {
//            get
//            {
//                return this.xAgenteField;
//            }
//            set
//            {
//                this.xAgenteField = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string nDAR
//        {
//            get
//            {
//                return this.nDARField;
//            }
//            set
//            {
//                this.nDARField = value;
//            }
//        }

//        /// <remarks/>
//        public string dEmi
//        {
//            get
//            {
//                return this.dEmiField;
//            }
//            set
//            {
//                this.dEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDAR
//        {
//            get
//            {
//                return this.vDARField;
//            }
//            set
//            {
//                this.vDARField = value;
//            }
//        }

//        /// <remarks/>
//        public string repEmi
//        {
//            get
//            {
//                return this.repEmiField;
//            }
//            set
//            {
//                this.repEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string dPag
//        {
//            get
//            {
//                return this.dPagField;
//            }
//            set
//            {
//                this.dPagField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDest
//    {

//        private string itemField;

//        private ITCTypeCNPJCPFIdEstrangeiro itemElementNameField;

//        private string xNomeField;

//        private TEndereco enderDestField;

//        private TNFeInfNFeDestIndIEDest indIEDestField;

//        private string ieField;

//        private string iSUFField;

//        private string imField;

//        private string emailField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPFIdEstrangeiro ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public TEndereco enderDest
//        {
//            get
//            {
//                return this.enderDestField;
//            }
//            set
//            {
//                this.enderDestField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDestIndIEDest indIEDest
//        {
//            get
//            {
//                return this.indIEDestField;
//            }
//            set
//            {
//                this.indIEDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string ISUF
//        {
//            get
//            {
//                return this.iSUFField;
//            }
//            set
//            {
//                this.iSUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string IM
//        {
//            get
//            {
//                return this.imField;
//            }
//            set
//            {
//                this.imField = value;
//            }
//        }

//        /// <remarks/>
//        public string email
//        {
//            get
//            {
//                return this.emailField;
//            }
//            set
//            {
//                this.emailField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEndereco
//    {

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUf ufField;

//        private string cEPField;

//        private string cPaisField;

//        private string xPaisField;

//        private string foneField;

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEP
//        {
//            get
//            {
//                return this.cEPField;
//            }
//            set
//            {
//                this.cEPField = value;
//            }
//        }

//        /// <remarks/>
//        public string cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string xPais
//        {
//            get
//            {
//                return this.xPaisField;
//            }
//            set
//            {
//                this.xPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TLocal
//    {

//        private string itemField;

//        private ItemChoiceType4 itemElementNameField;

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUf ufField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType4 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeAutXML
//    {

//        private string itemField;

//        private ItemChoiceType5 itemElementNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType5 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDet
//    {

//        private TNFeInfNFeDetProd prodField;

//        private TNFeInfNFeDetImposto impostoField;

//        private TNFeInfNFeDetImpostoDevol impostoDevolField;

//        private string infAdProdField;

//        private string nItemField;

//        /// <remarks/>
//        public TNFeInfNFeDetProd prod
//        {
//            get
//            {
//                return this.prodField;
//            }
//            set
//            {
//                this.prodField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImposto imposto
//        {
//            get
//            {
//                return this.impostoField;
//            }
//            set
//            {
//                this.impostoField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoDevol impostoDevol
//        {
//            get
//            {
//                return this.impostoDevolField;
//            }
//            set
//            {
//                this.impostoDevolField = value;
//            }
//        }

//        /// <remarks/>
//        public string infAdProd
//        {
//            get
//            {
//                return this.infAdProdField;
//            }
//            set
//            {
//                this.infAdProdField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string nItem
//        {
//            get
//            {
//                return this.nItemField;
//            }
//            set
//            {
//                this.nItemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProd
//    {

//        private string cProdField;

//        private string cEANField;

//        private string xProdField;

//        private string nCMField;

//        private string[] nVEField;

//        private string cESTField;

//        private TNFeInfNFeDetProdIndEscala indEscalaField;

//        private bool indEscalaFieldSpecified;

//        private string cNPJFabField;

//        private string cBenefField;

//        private string eXTIPIField;

//        private string cFOPField;

//        private string uComField;

//        private string qComField;

//        private string vUnComField;

//        private string vProdField;

//        private string cEANTribField;

//        private string uTribField;

//        private string qTribField;

//        private string vUnTribField;

//        private string vFreteField;

//        private string vSegField;

//        private string vDescField;

//        private string vOutroField;

//        private TNFeInfNFeDetProdIndTot indTotField;

//        private TNFeInfNFeDetProdDI[] diField;

//        private TNFeInfNFeDetProdDetExport[] detExportField;

//        private string xPedField;

//        private string nItemPedField;

//        private string nFCIField;

//        private TNFeInfNFeDetProdRastro[] rastroField;

//        private object[] itemsField;

//        /// <remarks/>
//        public string cProd
//        {
//            get
//            {
//                return this.cProdField;
//            }
//            set
//            {
//                this.cProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEAN
//        {
//            get
//            {
//                return this.cEANField;
//            }
//            set
//            {
//                this.cEANField = value;
//            }
//        }

//        /// <remarks/>
//        public string xProd
//        {
//            get
//            {
//                return this.xProdField;
//            }
//            set
//            {
//                this.xProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string NCM
//        {
//            get
//            {
//                return this.nCMField;
//            }
//            set
//            {
//                this.nCMField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NVE")]
//        public string[] NVE
//        {
//            get
//            {
//                return this.nVEField;
//            }
//            set
//            {
//                this.nVEField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEST
//        {
//            get
//            {
//                return this.cESTField;
//            }
//            set
//            {
//                this.cESTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdIndEscala indEscala
//        {
//            get
//            {
//                return this.indEscalaField;
//            }
//            set
//            {
//                this.indEscalaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool indEscalaSpecified
//        {
//            get
//            {
//                return this.indEscalaFieldSpecified;
//            }
//            set
//            {
//                this.indEscalaFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJFab
//        {
//            get
//            {
//                return this.cNPJFabField;
//            }
//            set
//            {
//                this.cNPJFabField = value;
//            }
//        }

//        /// <remarks/>
//        public string cBenef
//        {
//            get
//            {
//                return this.cBenefField;
//            }
//            set
//            {
//                this.cBenefField = value;
//            }
//        }

//        /// <remarks/>
//        public string EXTIPI
//        {
//            get
//            {
//                return this.eXTIPIField;
//            }
//            set
//            {
//                this.eXTIPIField = value;
//            }
//        }

//        /// <remarks/>
//        public string CFOP
//        {
//            get
//            {
//                return this.cFOPField;
//            }
//            set
//            {
//                this.cFOPField = value;
//            }
//        }

//        /// <remarks/>
//        public string uCom
//        {
//            get
//            {
//                return this.uComField;
//            }
//            set
//            {
//                this.uComField = value;
//            }
//        }

//        /// <remarks/>
//        public string qCom
//        {
//            get
//            {
//                return this.qComField;
//            }
//            set
//            {
//                this.qComField = value;
//            }
//        }

//        /// <remarks/>
//        public string vUnCom
//        {
//            get
//            {
//                return this.vUnComField;
//            }
//            set
//            {
//                this.vUnComField = value;
//            }
//        }

//        /// <remarks/>
//        public string vProd
//        {
//            get
//            {
//                return this.vProdField;
//            }
//            set
//            {
//                this.vProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEANTrib
//        {
//            get
//            {
//                return this.cEANTribField;
//            }
//            set
//            {
//                this.cEANTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string uTrib
//        {
//            get
//            {
//                return this.uTribField;
//            }
//            set
//            {
//                this.uTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTrib
//        {
//            get
//            {
//                return this.qTribField;
//            }
//            set
//            {
//                this.qTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string vUnTrib
//        {
//            get
//            {
//                return this.vUnTribField;
//            }
//            set
//            {
//                this.vUnTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFrete
//        {
//            get
//            {
//                return this.vFreteField;
//            }
//            set
//            {
//                this.vFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vSeg
//        {
//            get
//            {
//                return this.vSegField;
//            }
//            set
//            {
//                this.vSegField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdIndTot indTot
//        {
//            get
//            {
//                return this.indTotField;
//            }
//            set
//            {
//                this.indTotField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("DI")]
//        public TNFeInfNFeDetProdDI[] DI
//        {
//            get
//            {
//                return this.diField;
//            }
//            set
//            {
//                this.diField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("detExport")]
//        public TNFeInfNFeDetProdDetExport[] detExport
//        {
//            get
//            {
//                return this.detExportField;
//            }
//            set
//            {
//                this.detExportField = value;
//            }
//        }

//        /// <remarks/>
//        public string xPed
//        {
//            get
//            {
//                return this.xPedField;
//            }
//            set
//            {
//                this.xPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string nItemPed
//        {
//            get
//            {
//                return this.nItemPedField;
//            }
//            set
//            {
//                this.nItemPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string nFCI
//        {
//            get
//            {
//                return this.nFCIField;
//            }
//            set
//            {
//                this.nFCIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("rastro")]
//        public TNFeInfNFeDetProdRastro[] rastro
//        {
//            get
//            {
//                return this.rastroField;
//            }
//            set
//            {
//                this.rastroField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
//        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
//        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
//        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDI
//    {

//        private string nDIField;

//        private string dDIField;

//        private string xLocDesembField;

//        private TUfEmi uFDesembField;

//        private string dDesembField;

//        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;

//        private string vAFRMMField;

//        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;

//        private string cNPJField;

//        private TUfEmi uFTerceiroField;

//        private bool uFTerceiroFieldSpecified;

//        private string cExportadorField;

//        private TNFeInfNFeDetProdDIAdi[] adiField;

//        /// <remarks/>
//        public string nDI
//        {
//            get
//            {
//                return this.nDIField;
//            }
//            set
//            {
//                this.nDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string dDI
//        {
//            get
//            {
//                return this.dDIField;
//            }
//            set
//            {
//                this.dDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocDesemb
//        {
//            get
//            {
//                return this.xLocDesembField;
//            }
//            set
//            {
//                this.xLocDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UFDesemb
//        {
//            get
//            {
//                return this.uFDesembField;
//            }
//            set
//            {
//                this.uFDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public string dDesemb
//        {
//            get
//            {
//                return this.dDesembField;
//            }
//            set
//            {
//                this.dDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp
//        {
//            get
//            {
//                return this.tpViaTranspField;
//            }
//            set
//            {
//                this.tpViaTranspField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAFRMM
//        {
//            get
//            {
//                return this.vAFRMMField;
//            }
//            set
//            {
//                this.vAFRMMField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio
//        {
//            get
//            {
//                return this.tpIntermedioField;
//            }
//            set
//            {
//                this.tpIntermedioField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UFTerceiro
//        {
//            get
//            {
//                return this.uFTerceiroField;
//            }
//            set
//            {
//                this.uFTerceiroField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool UFTerceiroSpecified
//        {
//            get
//            {
//                return this.uFTerceiroFieldSpecified;
//            }
//            set
//            {
//                this.uFTerceiroFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string cExportador
//        {
//            get
//            {
//                return this.cExportadorField;
//            }
//            set
//            {
//                this.cExportadorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("adi")]
//        public TNFeInfNFeDetProdDIAdi[] adi
//        {
//            get
//            {
//                return this.adiField;
//            }
//            set
//            {
//                this.adiField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDIAdi
//    {

//        private string nAdicaoField;

//        private string nSeqAdicField;

//        private string cFabricanteField;

//        private string vDescDIField;

//        private string nDrawField;

//        /// <remarks/>
//        public string nAdicao
//        {
//            get
//            {
//                return this.nAdicaoField;
//            }
//            set
//            {
//                this.nAdicaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSeqAdic
//        {
//            get
//            {
//                return this.nSeqAdicField;
//            }
//            set
//            {
//                this.nSeqAdicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cFabricante
//        {
//            get
//            {
//                return this.cFabricanteField;
//            }
//            set
//            {
//                this.cFabricanteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescDI
//        {
//            get
//            {
//                return this.vDescDIField;
//            }
//            set
//            {
//                this.vDescDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string nDraw
//        {
//            get
//            {
//                return this.nDrawField;
//            }
//            set
//            {
//                this.nDrawField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDetExport
//    {

//        private string nDrawField;

//        private TNFeInfNFeDetProdDetExportExportInd exportIndField;

//        /// <remarks/>
//        public string nDraw
//        {
//            get
//            {
//                return this.nDrawField;
//            }
//            set
//            {
//                this.nDrawField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDetExportExportInd exportInd
//        {
//            get
//            {
//                return this.exportIndField;
//            }
//            set
//            {
//                this.exportIndField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDetExportExportInd
//    {

//        private string nREField;

//        private string chNFeField;

//        private string qExportField;

//        /// <remarks/>
//        public string nRE
//        {
//            get
//            {
//                return this.nREField;
//            }
//            set
//            {
//                this.nREField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public string qExport
//        {
//            get
//            {
//                return this.qExportField;
//            }
//            set
//            {
//                this.qExportField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdRastro
//    {

//        private string nLoteField;

//        private string qLoteField;

//        private string dFabField;

//        private string dValField;

//        private string cAgregField;

//        /// <remarks/>
//        public string nLote
//        {
//            get
//            {
//                return this.nLoteField;
//            }
//            set
//            {
//                this.nLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public string qLote
//        {
//            get
//            {
//                return this.qLoteField;
//            }
//            set
//            {
//                this.qLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public string dFab
//        {
//            get
//            {
//                return this.dFabField;
//            }
//            set
//            {
//                this.dFabField = value;
//            }
//        }

//        /// <remarks/>
//        public string dVal
//        {
//            get
//            {
//                return this.dValField;
//            }
//            set
//            {
//                this.dValField = value;
//            }
//        }

//        /// <remarks/>
//        public string cAgreg
//        {
//            get
//            {
//                return this.cAgregField;
//            }
//            set
//            {
//                this.cAgregField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdArma
//    {

//        private TNFeInfNFeDetProdArmaTpArma tpArmaField;

//        private string nSerieField;

//        private string nCanoField;

//        private string descrField;

//        /// <remarks/>
//        public TNFeInfNFeDetProdArmaTpArma tpArma
//        {
//            get
//            {
//                return this.tpArmaField;
//            }
//            set
//            {
//                this.tpArmaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSerie
//        {
//            get
//            {
//                return this.nSerieField;
//            }
//            set
//            {
//                this.nSerieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nCano
//        {
//            get
//            {
//                return this.nCanoField;
//            }
//            set
//            {
//                this.nCanoField = value;
//            }
//        }

//        /// <remarks/>
//        public string descr
//        {
//            get
//            {
//                return this.descrField;
//            }
//            set
//            {
//                this.descrField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdComb
//    {

//        private string cProdANPField;

//        private string descANPField;

//        private string pGLPField;

//        private string pGNnField;

//        private string pGNiField;

//        private string vPartField;

//        private string cODIFField;

//        private string qTempField;

//        private TUf uFConsField;

//        private TNFeInfNFeDetProdCombCIDE cIDEField;

//        private TNFeInfNFeDetProdCombEncerrante encerranteField;

//        /// <remarks/>
//        public string cProdANP
//        {
//            get
//            {
//                return this.cProdANPField;
//            }
//            set
//            {
//                this.cProdANPField = value;
//            }
//        }

//        /// <remarks/>
//        public string descANP
//        {
//            get
//            {
//                return this.descANPField;
//            }
//            set
//            {
//                this.descANPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pGLP
//        {
//            get
//            {
//                return this.pGLPField;
//            }
//            set
//            {
//                this.pGLPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pGNn
//        {
//            get
//            {
//                return this.pGNnField;
//            }
//            set
//            {
//                this.pGNnField = value;
//            }
//        }

//        /// <remarks/>
//        public string pGNi
//        {
//            get
//            {
//                return this.pGNiField;
//            }
//            set
//            {
//                this.pGNiField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPart
//        {
//            get
//            {
//                return this.vPartField;
//            }
//            set
//            {
//                this.vPartField = value;
//            }
//        }

//        /// <remarks/>
//        public string CODIF
//        {
//            get
//            {
//                return this.cODIFField;
//            }
//            set
//            {
//                this.cODIFField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTemp
//        {
//            get
//            {
//                return this.qTempField;
//            }
//            set
//            {
//                this.qTempField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UFCons
//        {
//            get
//            {
//                return this.uFConsField;
//            }
//            set
//            {
//                this.uFConsField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdCombCIDE CIDE
//        {
//            get
//            {
//                return this.cIDEField;
//            }
//            set
//            {
//                this.cIDEField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdCombEncerrante encerrante
//        {
//            get
//            {
//                return this.encerranteField;
//            }
//            set
//            {
//                this.encerranteField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdCombCIDE
//    {

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vCIDEField;

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCIDE
//        {
//            get
//            {
//                return this.vCIDEField;
//            }
//            set
//            {
//                this.vCIDEField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdCombEncerrante
//    {

//        private string nBicoField;

//        private string nBombaField;

//        private string nTanqueField;

//        private string vEncIniField;

//        private string vEncFinField;

//        /// <remarks/>
//        public string nBico
//        {
//            get
//            {
//                return this.nBicoField;
//            }
//            set
//            {
//                this.nBicoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nBomba
//        {
//            get
//            {
//                return this.nBombaField;
//            }
//            set
//            {
//                this.nBombaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nTanque
//        {
//            get
//            {
//                return this.nTanqueField;
//            }
//            set
//            {
//                this.nTanqueField = value;
//            }
//        }

//        /// <remarks/>
//        public string vEncIni
//        {
//            get
//            {
//                return this.vEncIniField;
//            }
//            set
//            {
//                this.vEncIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string vEncFin
//        {
//            get
//            {
//                return this.vEncFinField;
//            }
//            set
//            {
//                this.vEncFinField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdMed
//    {

//        private string cProdANVISAField;

//        private string vPMCField;

//        /// <remarks/>
//        public string cProdANVISA
//        {
//            get
//            {
//                return this.cProdANVISAField;
//            }
//            set
//            {
//                this.cProdANVISAField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPMC
//        {
//            get
//            {
//                return this.vPMCField;
//            }
//            set
//            {
//                this.vPMCField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdVeicProd
//    {

//        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;

//        private string chassiField;

//        private string cCorField;

//        private string xCorField;

//        private string potField;

//        private string cilinField;

//        private string pesoLField;

//        private string pesoBField;

//        private string nSerieField;

//        private string tpCombField;

//        private string nMotorField;

//        private string cMTField;

//        private string distField;

//        private string anoModField;

//        private string anoFabField;

//        private string tpPintField;

//        private string tpVeicField;

//        private string espVeicField;

//        private TNFeInfNFeDetProdVeicProdVIN vINField;

//        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;

//        private string cModField;

//        private string cCorDENATRANField;

//        private string lotaField;

//        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdTpOp tpOp
//        {
//            get
//            {
//                return this.tpOpField;
//            }
//            set
//            {
//                this.tpOpField = value;
//            }
//        }

//        /// <remarks/>
//        public string chassi
//        {
//            get
//            {
//                return this.chassiField;
//            }
//            set
//            {
//                this.chassiField = value;
//            }
//        }

//        /// <remarks/>
//        public string cCor
//        {
//            get
//            {
//                return this.cCorField;
//            }
//            set
//            {
//                this.cCorField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCor
//        {
//            get
//            {
//                return this.xCorField;
//            }
//            set
//            {
//                this.xCorField = value;
//            }
//        }

//        /// <remarks/>
//        public string pot
//        {
//            get
//            {
//                return this.potField;
//            }
//            set
//            {
//                this.potField = value;
//            }
//        }

//        /// <remarks/>
//        public string cilin
//        {
//            get
//            {
//                return this.cilinField;
//            }
//            set
//            {
//                this.cilinField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoL
//        {
//            get
//            {
//                return this.pesoLField;
//            }
//            set
//            {
//                this.pesoLField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoB
//        {
//            get
//            {
//                return this.pesoBField;
//            }
//            set
//            {
//                this.pesoBField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSerie
//        {
//            get
//            {
//                return this.nSerieField;
//            }
//            set
//            {
//                this.nSerieField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpComb
//        {
//            get
//            {
//                return this.tpCombField;
//            }
//            set
//            {
//                this.tpCombField = value;
//            }
//        }

//        /// <remarks/>
//        public string nMotor
//        {
//            get
//            {
//                return this.nMotorField;
//            }
//            set
//            {
//                this.nMotorField = value;
//            }
//        }

//        /// <remarks/>
//        public string CMT
//        {
//            get
//            {
//                return this.cMTField;
//            }
//            set
//            {
//                this.cMTField = value;
//            }
//        }

//        /// <remarks/>
//        public string dist
//        {
//            get
//            {
//                return this.distField;
//            }
//            set
//            {
//                this.distField = value;
//            }
//        }

//        /// <remarks/>
//        public string anoMod
//        {
//            get
//            {
//                return this.anoModField;
//            }
//            set
//            {
//                this.anoModField = value;
//            }
//        }

//        /// <remarks/>
//        public string anoFab
//        {
//            get
//            {
//                return this.anoFabField;
//            }
//            set
//            {
//                this.anoFabField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpPint
//        {
//            get
//            {
//                return this.tpPintField;
//            }
//            set
//            {
//                this.tpPintField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpVeic
//        {
//            get
//            {
//                return this.tpVeicField;
//            }
//            set
//            {
//                this.tpVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public string espVeic
//        {
//            get
//            {
//                return this.espVeicField;
//            }
//            set
//            {
//                this.espVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdVIN VIN
//        {
//            get
//            {
//                return this.vINField;
//            }
//            set
//            {
//                this.vINField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
//        {
//            get
//            {
//                return this.condVeicField;
//            }
//            set
//            {
//                this.condVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMod
//        {
//            get
//            {
//                return this.cModField;
//            }
//            set
//            {
//                this.cModField = value;
//            }
//        }

//        /// <remarks/>
//        public string cCorDENATRAN
//        {
//            get
//            {
//                return this.cCorDENATRANField;
//            }
//            set
//            {
//                this.cCorDENATRANField = value;
//            }
//        }

//        /// <remarks/>
//        public string lota
//        {
//            get
//            {
//                return this.lotaField;
//            }
//            set
//            {
//                this.lotaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdTpRest tpRest
//        {
//            get
//            {
//                return this.tpRestField;
//            }
//            set
//            {
//                this.tpRestField = value;
//            }
//        }
//    }






//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImposto
//    {

//        private string vTotTribField;

//        private object[] itemsField;

//        private TNFeInfNFeDetImpostoPIS pISField;

//        private TNFeInfNFeDetImpostoPISST pISSTField;

//        private TNFeInfNFeDetImpostoCOFINS cOFINSField;

//        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;

//        private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;

//        /// <remarks/>
//        public string vTotTrib
//        {
//            get
//            {
//                return this.vTotTribField;
//            }
//            set
//            {
//                this.vTotTribField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
//        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
//        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
//        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPIS PIS
//        {
//            get
//            {
//                return this.pISField;
//            }
//            set
//            {
//                this.pISField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISST PISST
//        {
//            get
//            {
//                return this.pISSTField;
//            }
//            set
//            {
//                this.pISSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINS COFINS
//        {
//            get
//            {
//                return this.cOFINSField;
//            }
//            set
//            {
//                this.cOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSST COFINSST
//        {
//            get
//            {
//                return this.cOFINSSTField;
//            }
//            set
//            {
//                this.cOFINSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest
//        {
//            get
//            {
//                return this.iCMSUFDestField;
//            }
//            set
//            {
//                this.iCMSUFDestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS00
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string pFCPField;

//        private string vFCPField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS00CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS10
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string vBCFCPField;

//        private string pFCPField;

//        private string vFCPField;

//        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCP
//        {
//            get
//            {
//                return this.vBCFCPField;
//            }
//            set
//            {
//                this.vBCFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS20
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string vBCFCPField;

//        private string pFCPField;

//        private string vFCPField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCP
//        {
//            get
//            {
//                return this.vBCFCPField;
//            }
//            set
//            {
//                this.vBCFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS30
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("30")]
//        Item30,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS40
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS40CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS40CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("40")]
//        Item40,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("41")]
//        Item41,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8")]
//        Item8,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11")]
//        Item11,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("16")]
//        Item16,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS51
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;

//        private bool modBCFieldSpecified;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSOpField;

//        private string pDifField;

//        private string vICMSDifField;

//        private string vICMSField;

//        private string vBCFCPField;

//        private string pFCPField;

//        private string vFCPField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS51CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool modBCSpecified
//        {
//            get
//            {
//                return this.modBCFieldSpecified;
//            }
//            set
//            {
//                this.modBCFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSOp
//        {
//            get
//            {
//                return this.vICMSOpField;
//            }
//            set
//            {
//                this.vICMSOpField = value;
//            }
//        }

//        /// <remarks/>
//        public string pDif
//        {
//            get
//            {
//                return this.pDifField;
//            }
//            set
//            {
//                this.pDifField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDif
//        {
//            get
//            {
//                return this.vICMSDifField;
//            }
//            set
//            {
//                this.vICMSDifField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCP
//        {
//            get
//            {
//                return this.vBCFCPField;
//            }
//            set
//            {
//                this.vBCFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS51CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS60
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;

//        private string vBCSTRetField;

//        private string pSTField;

//        private string vICMSSTRetField;

//        private string vBCFCPSTRetField;

//        private string pFCPSTRetField;

//        private string vFCPSTRetField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS60CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pST
//        {
//            get
//            {
//                return this.pSTField;
//            }
//            set
//            {
//                this.pSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPSTRet
//        {
//            get
//            {
//                return this.vBCFCPSTRetField;
//            }
//            set
//            {
//                this.vBCFCPSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPSTRet
//        {
//            get
//            {
//                return this.pFCPSTRetField;
//            }
//            set
//            {
//                this.pFCPSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPSTRet
//        {
//            get
//            {
//                return this.vFCPSTRetField;
//            }
//            set
//            {
//                this.vFCPSTRetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS60CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS70
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string vBCFCPField;

//        private string pFCPField;

//        private string vFCPField;

//        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCP
//        {
//            get
//            {
//                return this.vBCFCPField;
//            }
//            set
//            {
//                this.vBCFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS90
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string vBCFCPField;

//        private string pFCPField;

//        private string vFCPField;

//        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCP
//        {
//            get
//            {
//                return this.vBCFCPField;
//            }
//            set
//            {
//                this.vBCFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCP
//        {
//            get
//            {
//                return this.pFCPField;
//            }
//            set
//            {
//                this.pFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSPart
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string pBCOpField;

//        private TUf uFSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pBCOp
//        {
//            get
//            {
//                return this.pBCOpField;
//            }
//            set
//            {
//                this.pBCOpField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UFST
//        {
//            get
//            {
//                return this.uFSTField;
//            }
//            set
//            {
//                this.uFSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("101")]
//        Item101,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("102")]
//        Item102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("103")]
//        Item103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("300")]
//        Item300,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("400")]
//        Item400,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("201")]
//        Item201,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("202")]
//        Item202,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("203")]
//        Item203,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;

//        private string vBCSTRetField;

//        private string pSTField;

//        private string vICMSSTRetField;

//        private string vBCFCPSTRetField;

//        private string pFCPSTRetField;

//        private string vFCPSTRetField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pST
//        {
//            get
//            {
//                return this.pSTField;
//            }
//            set
//            {
//                this.pSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPSTRet
//        {
//            get
//            {
//                return this.vBCFCPSTRetField;
//            }
//            set
//            {
//                this.vBCFCPSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPSTRet
//        {
//            get
//            {
//                return this.pFCPSTRetField;
//            }
//            set
//            {
//                this.pFCPSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPSTRet
//        {
//            get
//            {
//                return this.vFCPSTRetField;
//            }
//            set
//            {
//                this.vFCPSTRetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("500")]
//        Item500,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vBCFCPSTField;

//        private string pFCPSTField;

//        private string vFCPSTField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPST
//        {
//            get
//            {
//                return this.vBCFCPSTField;
//            }
//            set
//            {
//                this.vBCFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPST
//        {
//            get
//            {
//                return this.pFCPSTField;
//            }
//            set
//            {
//                this.pFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("900")]
//        Item900,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSST
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;

//        private string vBCSTRetField;

//        private string vICMSSTRetField;

//        private string vBCSTDestField;

//        private string vICMSSTDestField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTDest
//        {
//            get
//            {
//                return this.vBCSTDestField;
//            }
//            set
//            {
//                this.vBCSTDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTDest
//        {
//            get
//            {
//                return this.vICMSSTDestField;
//            }
//            set
//            {
//                this.vICMSSTDestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("41")]
//        Item41,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoII
//    {

//        private string vBCField;

//        private string vDespAduField;

//        private string vIIField;

//        private string vIOFField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDespAdu
//        {
//            get
//            {
//                return this.vDespAduField;
//            }
//            set
//            {
//                this.vDespAduField = value;
//            }
//        }

//        /// <remarks/>
//        public string vII
//        {
//            get
//            {
//                return this.vIIField;
//            }
//            set
//            {
//                this.vIIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIOF
//        {
//            get
//            {
//                return this.vIOFField;
//            }
//            set
//            {
//                this.vIOFField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpi
//    {

//        private string clEnqField;

//        private string cNPJProdField;

//        private string cSeloField;

//        private string qSeloField;

//        private string cEnqField;

//        private object itemField;

//        /// <remarks/>
//        public string clEnq
//        {
//            get
//            {
//                return this.clEnqField;
//            }
//            set
//            {
//                this.clEnqField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJProd
//        {
//            get
//            {
//                return this.cNPJProdField;
//            }
//            set
//            {
//                this.cNPJProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cSelo
//        {
//            get
//            {
//                return this.cSeloField;
//            }
//            set
//            {
//                this.cSeloField = value;
//            }
//        }

//        /// <remarks/>
//        public string qSelo
//        {
//            get
//            {
//                return this.qSeloField;
//            }
//            set
//            {
//                this.qSeloField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEnq
//        {
//            get
//            {
//                return this.cEnqField;
//            }
//            set
//            {
//                this.cEnqField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TIpiIPINT))]
//        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TIpiIPITrib))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpiIPINT
//    {

//        private TIpiIPINTCST cSTField;

//        /// <remarks/>
//        public TIpiIPINTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TIpiIPINTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpiIPITrib
//    {

//        private TIpiIPITribCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType[] itemsElementNameField;

//        private string vIPIField;

//        /// <remarks/>
//        public TIpiIPITribCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIPI
//        {
//            get
//            {
//                return this.vIPIField;
//            }
//            set
//            {
//                this.vIPIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TIpiIPITribCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("00")]
//        Item00,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType
//    {

//        /// <remarks/>
//        pIPI,

//        /// <remarks/>
//        qUnid,

//        /// <remarks/>
//        vBC,

//        /// <remarks/>
//        vUnid,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoISSQN
//    {

//        private string vBCField;

//        private string vAliqField;

//        private string vISSQNField;

//        private string cMunFGField;

//        private TCListServ cListServField;

//        private string vDeducaoField;

//        private string vOutroField;

//        private string vDescIncondField;

//        private string vDescCondField;

//        private string vISSRetField;

//        private TNFeInfNFeDetImpostoISSQNIndISS indISSField;

//        private string cServicoField;

//        private string cMunField;

//        private string cPaisField;

//        private string nProcessoField;

//        private TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivoField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliq
//        {
//            get
//            {
//                return this.vAliqField;
//            }
//            set
//            {
//                this.vAliqField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSQN
//        {
//            get
//            {
//                return this.vISSQNField;
//            }
//            set
//            {
//                this.vISSQNField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }

//        /// <remarks/>
//        public TCListServ cListServ
//        {
//            get
//            {
//                return this.cListServField;
//            }
//            set
//            {
//                this.cListServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDeducao
//        {
//            get
//            {
//                return this.vDeducaoField;
//            }
//            set
//            {
//                this.vDeducaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescIncond
//        {
//            get
//            {
//                return this.vDescIncondField;
//            }
//            set
//            {
//                this.vDescIncondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescCond
//        {
//            get
//            {
//                return this.vDescCondField;
//            }
//            set
//            {
//                this.vDescCondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSRet
//        {
//            get
//            {
//                return this.vISSRetField;
//            }
//            set
//            {
//                this.vISSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoISSQNIndISS indISS
//        {
//            get
//            {
//                return this.indISSField;
//            }
//            set
//            {
//                this.indISSField = value;
//            }
//        }

//        /// <remarks/>
//        public string cServico
//        {
//            get
//            {
//                return this.cServicoField;
//            }
//            set
//            {
//                this.cServicoField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProcesso
//        {
//            get
//            {
//                return this.nProcessoField;
//            }
//            set
//            {
//                this.nProcessoField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo
//        {
//            get
//            {
//                return this.indIncentivoField;
//            }
//            set
//            {
//                this.indIncentivoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TCListServ
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.01")]
//        Item0101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.02")]
//        Item0102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.03")]
//        Item0103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.04")]
//        Item0104,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.05")]
//        Item0105,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.06")]
//        Item0106,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.07")]
//        Item0107,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.08")]
//        Item0108,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02.01")]
//        Item0201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.02")]
//        Item0302,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.03")]
//        Item0303,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.04")]
//        Item0304,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.05")]
//        Item0305,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.01")]
//        Item0401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.02")]
//        Item0402,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.03")]
//        Item0403,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.04")]
//        Item0404,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.05")]
//        Item0405,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.06")]
//        Item0406,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.07")]
//        Item0407,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.08")]
//        Item0408,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.09")]
//        Item0409,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.10")]
//        Item0410,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.11")]
//        Item0411,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.12")]
//        Item0412,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.13")]
//        Item0413,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.14")]
//        Item0414,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.15")]
//        Item0415,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.16")]
//        Item0416,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.17")]
//        Item0417,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.18")]
//        Item0418,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.19")]
//        Item0419,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.20")]
//        Item0420,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.21")]
//        Item0421,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.22")]
//        Item0422,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.23")]
//        Item0423,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.01")]
//        Item0501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.02")]
//        Item0502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.03")]
//        Item0503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.04")]
//        Item0504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.05")]
//        Item0505,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.06")]
//        Item0506,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.07")]
//        Item0507,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.08")]
//        Item0508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.09")]
//        Item0509,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.01")]
//        Item0601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.02")]
//        Item0602,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.03")]
//        Item0603,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.04")]
//        Item0604,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.05")]
//        Item0605,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.01")]
//        Item0701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.02")]
//        Item0702,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.03")]
//        Item0703,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.04")]
//        Item0704,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.05")]
//        Item0705,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.06")]
//        Item0706,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.07")]
//        Item0707,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.08")]
//        Item0708,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.09")]
//        Item0709,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.10")]
//        Item0710,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.11")]
//        Item0711,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.12")]
//        Item0712,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.13")]
//        Item0713,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.16")]
//        Item0716,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.17")]
//        Item0717,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.18")]
//        Item0718,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.19")]
//        Item0719,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.20")]
//        Item0720,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.21")]
//        Item0721,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.22")]
//        Item0722,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08.01")]
//        Item0801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08.02")]
//        Item0802,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.01")]
//        Item0901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.02")]
//        Item0902,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.03")]
//        Item0903,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.01")]
//        Item1001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.02")]
//        Item1002,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.03")]
//        Item1003,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.04")]
//        Item1004,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.05")]
//        Item1005,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.06")]
//        Item1006,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.07")]
//        Item1007,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.08")]
//        Item1008,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.09")]
//        Item1009,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.10")]
//        Item1010,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.01")]
//        Item1101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.02")]
//        Item1102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.03")]
//        Item1103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.04")]
//        Item1104,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.01")]
//        Item1201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.02")]
//        Item1202,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.03")]
//        Item1203,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.04")]
//        Item1204,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.05")]
//        Item1205,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.06")]
//        Item1206,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.07")]
//        Item1207,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.08")]
//        Item1208,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.09")]
//        Item1209,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.10")]
//        Item1210,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.11")]
//        Item1211,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.12")]
//        Item1212,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.13")]
//        Item1213,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.14")]
//        Item1214,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.15")]
//        Item1215,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.16")]
//        Item1216,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.17")]
//        Item1217,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.02")]
//        Item1302,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.03")]
//        Item1303,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.04")]
//        Item1304,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.05")]
//        Item1305,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.01")]
//        Item1401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.02")]
//        Item1402,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.03")]
//        Item1403,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.04")]
//        Item1404,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.05")]
//        Item1405,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.06")]
//        Item1406,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.07")]
//        Item1407,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.08")]
//        Item1408,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.09")]
//        Item1409,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.10")]
//        Item1410,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.11")]
//        Item1411,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.12")]
//        Item1412,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.13")]
//        Item1413,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.01")]
//        Item1501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.02")]
//        Item1502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.03")]
//        Item1503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.04")]
//        Item1504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.05")]
//        Item1505,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.06")]
//        Item1506,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.07")]
//        Item1507,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.08")]
//        Item1508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.09")]
//        Item1509,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.10")]
//        Item1510,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.11")]
//        Item1511,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.12")]
//        Item1512,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.13")]
//        Item1513,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.14")]
//        Item1514,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.15")]
//        Item1515,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.16")]
//        Item1516,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.17")]
//        Item1517,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.18")]
//        Item1518,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("16.01")]
//        Item1601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.01")]
//        Item1701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.02")]
//        Item1702,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.03")]
//        Item1703,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.04")]
//        Item1704,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.05")]
//        Item1705,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.06")]
//        Item1706,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.08")]
//        Item1708,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.09")]
//        Item1709,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.10")]
//        Item1710,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.11")]
//        Item1711,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.12")]
//        Item1712,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.13")]
//        Item1713,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.14")]
//        Item1714,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.15")]
//        Item1715,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.16")]
//        Item1716,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.17")]
//        Item1717,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.18")]
//        Item1718,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.19")]
//        Item1719,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.20")]
//        Item1720,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.21")]
//        Item1721,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.22")]
//        Item1722,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.23")]
//        Item1723,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.24")]
//        Item1724,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("18.01")]
//        Item1801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("19.01")]
//        Item1901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.01")]
//        Item2001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.02")]
//        Item2002,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.03")]
//        Item2003,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("21.01")]
//        Item2101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("22.01")]
//        Item2201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("23.01")]
//        Item2301,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("24.01")]
//        Item2401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.01")]
//        Item2501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.02")]
//        Item2502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.03")]
//        Item2503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.04")]
//        Item2504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("26.01")]
//        Item2601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("27.01")]
//        Item2701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("28.01")]
//        Item2801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("29.01")]
//        Item2901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("30.01")]
//        Item3001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("31.01")]
//        Item3101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("32.01")]
//        Item3201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("33.01")]
//        Item3301,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("34.01")]
//        Item3401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("35.01")]
//        Item3501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("36.01")]
//        Item3601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("37.01")]
//        Item3701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("38.01")]
//        Item3801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("39.01")]
//        Item3901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("40.01")]
//        Item4001,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoISSQNIndISS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPIS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
//        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
//        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
//        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISAliq
//    {

//        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;

//        private string vBCField;

//        private string pPISField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISAliqCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pPIS
//        {
//            get
//            {
//                return this.pPISField;
//            }
//            set
//            {
//                this.pPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISAliqCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISNT
//    {

//        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISNTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISNTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06")]
//        Item06,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07")]
//        Item07,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08")]
//        Item08,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09")]
//        Item09,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISOutr
//    {

//        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType1[] itemsElementNameField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISOutrCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType1[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISOutrCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("56")]
//        Item56,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("61")]
//        Item61,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("62")]
//        Item62,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("63")]
//        Item63,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("64")]
//        Item64,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("65")]
//        Item65,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("66")]
//        Item66,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("67")]
//        Item67,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("71")]
//        Item71,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("72")]
//        Item72,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("73")]
//        Item73,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("74")]
//        Item74,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("75")]
//        Item75,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("98")]
//        Item98,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType1
//    {

//        /// <remarks/>
//        pPIS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISQtde
//    {

//        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISST
//    {

//        private string[] itemsField;

//        private ItemsChoiceType2[] itemsElementNameField;

//        private string vPISField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType2[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType2
//    {

//        /// <remarks/>
//        pPIS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;

//        private string vBCField;

//        private string pCOFINSField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCOFINS
//        {
//            get
//            {
//                return this.pCOFINSField;
//            }
//            set
//            {
//                this.pCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06")]
//        Item06,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07")]
//        Item07,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08")]
//        Item08,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09")]
//        Item09,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType3[] itemsElementNameField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType3[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("56")]
//        Item56,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("61")]
//        Item61,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("62")]
//        Item62,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("63")]
//        Item63,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("64")]
//        Item64,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("65")]
//        Item65,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("66")]
//        Item66,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("67")]
//        Item67,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("71")]
//        Item71,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("72")]
//        Item72,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("73")]
//        Item73,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("74")]
//        Item74,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("75")]
//        Item75,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("98")]
//        Item98,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType3
//    {

//        /// <remarks/>
//        pCOFINS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSST
//    {

//        private string[] itemsField;

//        private ItemsChoiceType4[] itemsElementNameField;

//        private string vCOFINSField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType4[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType4
//    {

//        /// <remarks/>
//        pCOFINS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSUFDest
//    {

//        private string vBCUFDestField;

//        private string vBCFCPUFDestField;

//        private string pFCPUFDestField;

//        private string pICMSUFDestField;

//        private TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInterField;

//        private string pICMSInterPartField;

//        private string vFCPUFDestField;

//        private string vICMSUFDestField;

//        private string vICMSUFRemetField;

//        /// <remarks/>
//        public string vBCUFDest
//        {
//            get
//            {
//                return this.vBCUFDestField;
//            }
//            set
//            {
//                this.vBCUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCFCPUFDest
//        {
//            get
//            {
//                return this.vBCFCPUFDestField;
//            }
//            set
//            {
//                this.vBCFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPUFDest
//        {
//            get
//            {
//                return this.pFCPUFDestField;
//            }
//            set
//            {
//                this.pFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSUFDest
//        {
//            get
//            {
//                return this.pICMSUFDestField;
//            }
//            set
//            {
//                this.pICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInter
//        {
//            get
//            {
//                return this.pICMSInterField;
//            }
//            set
//            {
//                this.pICMSInterField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSInterPart
//        {
//            get
//            {
//                return this.pICMSInterPartField;
//            }
//            set
//            {
//                this.pICMSInterPartField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPUFDest
//        {
//            get
//            {
//                return this.vFCPUFDestField;
//            }
//            set
//            {
//                this.vFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFDest
//        {
//            get
//            {
//                return this.vICMSUFDestField;
//            }
//            set
//            {
//                this.vICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFRemet
//        {
//            get
//            {
//                return this.vICMSUFRemetField;
//            }
//            set
//            {
//                this.vICMSUFRemetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4.00")]
//        Item400,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7.00")]
//        Item700,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.00")]
//        Item1200,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoDevol
//    {

//        private string pDevolField;

//        private TNFeInfNFeDetImpostoDevolIPI iPIField;

//        /// <remarks/>
//        public string pDevol
//        {
//            get
//            {
//                return this.pDevolField;
//            }
//            set
//            {
//                this.pDevolField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoDevolIPI IPI
//        {
//            get
//            {
//                return this.iPIField;
//            }
//            set
//            {
//                this.iPIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoDevolIPI
//    {

//        private string vIPIDevolField;

//        /// <remarks/>
//        public string vIPIDevol
//        {
//            get
//            {
//                return this.vIPIDevolField;
//            }
//            set
//            {
//                this.vIPIDevolField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotal
//    {

//        private TNFeInfNFeTotalICMSTot iCMSTotField;

//        private TNFeInfNFeTotalISSQNtot iSSQNtotField;

//        private TNFeInfNFeTotalRetTrib retTribField;

//        /// <remarks/>
//        public TNFeInfNFeTotalICMSTot ICMSTot
//        {
//            get
//            {
//                return this.iCMSTotField;
//            }
//            set
//            {
//                this.iCMSTotField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalISSQNtot ISSQNtot
//        {
//            get
//            {
//                return this.iSSQNtotField;
//            }
//            set
//            {
//                this.iSSQNtotField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalRetTrib retTrib
//        {
//            get
//            {
//                return this.retTribField;
//            }
//            set
//            {
//                this.retTribField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalICMSTot
//    {

//        private string vBCField;

//        private string vICMSField;

//        private string vICMSDesonField;

//        private string vFCPUFDestField;

//        private string vICMSUFDestField;

//        private string vICMSUFRemetField;

//        private string vFCPField;

//        private string vBCSTField;

//        private string vSTField;

//        private string vFCPSTField;

//        private string vFCPSTRetField;

//        private string vProdField;

//        private string vFreteField;

//        private string vSegField;

//        private string vDescField;

//        private string vIIField;

//        private string vIPIField;

//        private string vIPIDevolField;

//        private string vPISField;

//        private string vCOFINSField;

//        private string vOutroField;

//        private string vNFField;

//        private string vTotTribField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPUFDest
//        {
//            get
//            {
//                return this.vFCPUFDestField;
//            }
//            set
//            {
//                this.vFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFDest
//        {
//            get
//            {
//                return this.vICMSUFDestField;
//            }
//            set
//            {
//                this.vICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFRemet
//        {
//            get
//            {
//                return this.vICMSUFRemetField;
//            }
//            set
//            {
//                this.vICMSUFRemetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCP
//        {
//            get
//            {
//                return this.vFCPField;
//            }
//            set
//            {
//                this.vFCPField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vST
//        {
//            get
//            {
//                return this.vSTField;
//            }
//            set
//            {
//                this.vSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPST
//        {
//            get
//            {
//                return this.vFCPSTField;
//            }
//            set
//            {
//                this.vFCPSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPSTRet
//        {
//            get
//            {
//                return this.vFCPSTRetField;
//            }
//            set
//            {
//                this.vFCPSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vProd
//        {
//            get
//            {
//                return this.vProdField;
//            }
//            set
//            {
//                this.vProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFrete
//        {
//            get
//            {
//                return this.vFreteField;
//            }
//            set
//            {
//                this.vFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vSeg
//        {
//            get
//            {
//                return this.vSegField;
//            }
//            set
//            {
//                this.vSegField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vII
//        {
//            get
//            {
//                return this.vIIField;
//            }
//            set
//            {
//                this.vIIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIPI
//        {
//            get
//            {
//                return this.vIPIField;
//            }
//            set
//            {
//                this.vIPIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIPIDevol
//        {
//            get
//            {
//                return this.vIPIDevolField;
//            }
//            set
//            {
//                this.vIPIDevolField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vNF
//        {
//            get
//            {
//                return this.vNFField;
//            }
//            set
//            {
//                this.vNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vTotTrib
//        {
//            get
//            {
//                return this.vTotTribField;
//            }
//            set
//            {
//                this.vTotTribField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalISSQNtot
//    {

//        private string vServField;

//        private string vBCField;

//        private string vISSField;

//        private string vPISField;

//        private string vCOFINSField;

//        private string dCompetField;

//        private string vDeducaoField;

//        private string vOutroField;

//        private string vDescIncondField;

//        private string vDescCondField;

//        private string vISSRetField;

//        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;

//        private bool cRegTribFieldSpecified;

//        /// <remarks/>
//        public string vServ
//        {
//            get
//            {
//                return this.vServField;
//            }
//            set
//            {
//                this.vServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISS
//        {
//            get
//            {
//                return this.vISSField;
//            }
//            set
//            {
//                this.vISSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string dCompet
//        {
//            get
//            {
//                return this.dCompetField;
//            }
//            set
//            {
//                this.dCompetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDeducao
//        {
//            get
//            {
//                return this.vDeducaoField;
//            }
//            set
//            {
//                this.vDeducaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescIncond
//        {
//            get
//            {
//                return this.vDescIncondField;
//            }
//            set
//            {
//                this.vDescIncondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescCond
//        {
//            get
//            {
//                return this.vDescCondField;
//            }
//            set
//            {
//                this.vDescCondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSRet
//        {
//            get
//            {
//                return this.vISSRetField;
//            }
//            set
//            {
//                this.vISSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib
//        {
//            get
//            {
//                return this.cRegTribField;
//            }
//            set
//            {
//                this.cRegTribField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cRegTribSpecified
//        {
//            get
//            {
//                return this.cRegTribFieldSpecified;
//            }
//            set
//            {
//                this.cRegTribFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeTotalISSQNtotCRegTrib
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalRetTrib
//    {

//        private string vRetPISField;

//        private string vRetCOFINSField;

//        private string vRetCSLLField;

//        private string vBCIRRFField;

//        private string vIRRFField;

//        private string vBCRetPrevField;

//        private string vRetPrevField;

//        /// <remarks/>
//        public string vRetPIS
//        {
//            get
//            {
//                return this.vRetPISField;
//            }
//            set
//            {
//                this.vRetPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetCOFINS
//        {
//            get
//            {
//                return this.vRetCOFINSField;
//            }
//            set
//            {
//                this.vRetCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetCSLL
//        {
//            get
//            {
//                return this.vRetCSLLField;
//            }
//            set
//            {
//                this.vRetCSLLField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCIRRF
//        {
//            get
//            {
//                return this.vBCIRRFField;
//            }
//            set
//            {
//                this.vBCIRRFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIRRF
//        {
//            get
//            {
//                return this.vIRRFField;
//            }
//            set
//            {
//                this.vIRRFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCRetPrev
//        {
//            get
//            {
//                return this.vBCRetPrevField;
//            }
//            set
//            {
//                this.vBCRetPrevField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetPrev
//        {
//            get
//            {
//                return this.vRetPrevField;
//            }
//            set
//            {
//                this.vRetPrevField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTransp
//    {

//        private TNFeInfNFeTranspModFrete modFreteField;

//        private TNFeInfNFeTranspTransporta transportaField;

//        private TNFeInfNFeTranspRetTransp retTranspField;

//        private object[] itemsField;

//        private ItemsChoiceType5[] itemsElementNameField;

//        private TNFeInfNFeTranspVol[] volField;

//        /// <remarks/>
//        public TNFeInfNFeTranspModFrete modFrete
//        {
//            get
//            {
//                return this.modFreteField;
//            }
//            set
//            {
//                this.modFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTranspTransporta transporta
//        {
//            get
//            {
//                return this.transportaField;
//            }
//            set
//            {
//                this.transportaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTranspRetTransp retTransp
//        {
//            get
//            {
//                return this.retTranspField;
//            }
//            set
//            {
//                this.retTranspField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo))]
//        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType5[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("vol")]
//        public TNFeInfNFeTranspVol[] vol
//        {
//            get
//            {
//                return this.volField;
//            }
//            set
//            {
//                this.volField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeTranspModFrete
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspTransporta
//    {

//        private string itemField;

//        private ItemChoiceType6 itemElementNameField;

//        private string xNomeField;

//        private string ieField;

//        private string xEnderField;

//        private string xMunField;

//        private TUf ufField;

//        private bool ufFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType6 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string xEnder
//        {
//            get
//            {
//                return this.xEnderField;
//            }
//            set
//            {
//                this.xEnderField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool UFSpecified
//        {
//            get
//            {
//                return this.ufFieldSpecified;
//            }
//            set
//            {
//                this.ufFieldSpecified = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspRetTransp
//    {

//        private string vServField;

//        private string vBCRetField;

//        private string pICMSRetField;

//        private string vICMSRetField;

//        private string cFOPField;

//        private string cMunFGField;

//        /// <remarks/>
//        public string vServ
//        {
//            get
//            {
//                return this.vServField;
//            }
//            set
//            {
//                this.vServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCRet
//        {
//            get
//            {
//                return this.vBCRetField;
//            }
//            set
//            {
//                this.vBCRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSRet
//        {
//            get
//            {
//                return this.pICMSRetField;
//            }
//            set
//            {
//                this.pICMSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSRet
//        {
//            get
//            {
//                return this.vICMSRetField;
//            }
//            set
//            {
//                this.vICMSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string CFOP
//        {
//            get
//            {
//                return this.cFOPField;
//            }
//            set
//            {
//                this.cFOPField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TVeiculo
//    {

//        private string placaField;

//        private TUf ufField;

//        private string rNTCField;

//        /// <remarks/>
//        public string placa
//        {
//            get
//            {
//                return this.placaField;
//            }
//            set
//            {
//                this.placaField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string RNTC
//        {
//            get
//            {
//                return this.rNTCField;
//            }
//            set
//            {
//                this.rNTCField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType5
//    {

//        /// <remarks/>
//        balsa,

//        /// <remarks/>
//        reboque,

//        /// <remarks/>
//        vagao,

//        /// <remarks/>
//        veicTransp,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspVol
//    {

//        private string qVolField;

//        private string espField;

//        private string marcaField;

//        private string nVolField;

//        private string pesoLField;

//        private string pesoBField;

//        private TNFeInfNFeTranspVolLacres[] lacresField;

//        /// <remarks/>
//        public string qVol
//        {
//            get
//            {
//                return this.qVolField;
//            }
//            set
//            {
//                this.qVolField = value;
//            }
//        }

//        /// <remarks/>
//        public string esp
//        {
//            get
//            {
//                return this.espField;
//            }
//            set
//            {
//                this.espField = value;
//            }
//        }

//        /// <remarks/>
//        public string marca
//        {
//            get
//            {
//                return this.marcaField;
//            }
//            set
//            {
//                this.marcaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nVol
//        {
//            get
//            {
//                return this.nVolField;
//            }
//            set
//            {
//                this.nVolField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoL
//        {
//            get
//            {
//                return this.pesoLField;
//            }
//            set
//            {
//                this.pesoLField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoB
//        {
//            get
//            {
//                return this.pesoBField;
//            }
//            set
//            {
//                this.pesoBField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("lacres")]
//        public TNFeInfNFeTranspVolLacres[] lacres
//        {
//            get
//            {
//                return this.lacresField;
//            }
//            set
//            {
//                this.lacresField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspVolLacres
//    {

//        private string nLacreField;

//        /// <remarks/>
//        public string nLacre
//        {
//            get
//            {
//                return this.nLacreField;
//            }
//            set
//            {
//                this.nLacreField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobr
//    {

//        private TNFeInfNFeCobrFat fatField;

//        private TNFeInfNFeCobrDup[] dupField;

//        /// <remarks/>
//        public TNFeInfNFeCobrFat fat
//        {
//            get
//            {
//                return this.fatField;
//            }
//            set
//            {
//                this.fatField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("dup")]
//        public TNFeInfNFeCobrDup[] dup
//        {
//            get
//            {
//                return this.dupField;
//            }
//            set
//            {
//                this.dupField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobrFat
//    {

//        private string nFatField;

//        private string vOrigField;

//        private string vDescField;

//        private string vLiqField;

//        /// <remarks/>
//        public string nFat
//        {
//            get
//            {
//                return this.nFatField;
//            }
//            set
//            {
//                this.nFatField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOrig
//        {
//            get
//            {
//                return this.vOrigField;
//            }
//            set
//            {
//                this.vOrigField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vLiq
//        {
//            get
//            {
//                return this.vLiqField;
//            }
//            set
//            {
//                this.vLiqField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobrDup
//    {

//        private string nDupField;

//        private string dVencField;

//        private string vDupField;

//        /// <remarks/>
//        public string nDup
//        {
//            get
//            {
//                return this.nDupField;
//            }
//            set
//            {
//                this.nDupField = value;
//            }
//        }

//        /// <remarks/>
//        public string dVenc
//        {
//            get
//            {
//                return this.dVencField;
//            }
//            set
//            {
//                this.dVencField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDup
//        {
//            get
//            {
//                return this.vDupField;
//            }
//            set
//            {
//                this.vDupField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFePag
//    {

//        private TNFeInfNFePagDetPag[] detPagField;

//        private string vTrocoField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("detPag")]
//        public TNFeInfNFePagDetPag[] detPag
//        {
//            get
//            {
//                return this.detPagField;
//            }
//            set
//            {
//                this.detPagField = value;
//            }
//        }

//        /// <remarks/>
//        public string vTroco
//        {
//            get
//            {
//                return this.vTrocoField;
//            }
//            set
//            {
//                this.vTrocoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFePagDetPag
//    {

//        private TNFeInfNFePagDetPagTPag tPagField;

//        private string vPagField;

//        private TNFeInfNFePagDetPagCard cardField;

//        /// <remarks/>
//        public TNFeInfNFePagDetPagTPag tPag
//        {
//            get
//            {
//                return this.tPagField;
//            }
//            set
//            {
//                this.tPagField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPag
//        {
//            get
//            {
//                return this.vPagField;
//            }
//            set
//            {
//                this.vPagField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFePagDetPagCard card
//        {
//            get
//            {
//                return this.cardField;
//            }
//            set
//            {
//                this.cardField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagDetPagTPag
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11")]
//        Item11,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13")]
//        Item13,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14")]
//        Item14,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFePagDetPagCard
//    {

//        private TNFeInfNFePagDetPagCardTpIntegra tpIntegraField;

//        private string cNPJField;

//        private TNFeInfNFePagDetPagCardTBand tBandField;

//        private bool tBandFieldSpecified;

//        private string cAutField;

//        /// <remarks/>
//        public TNFeInfNFePagDetPagCardTpIntegra tpIntegra
//        {
//            get
//            {
//                return this.tpIntegraField;
//            }
//            set
//            {
//                this.tpIntegraField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFePagDetPagCardTBand tBand
//        {
//            get
//            {
//                return this.tBandField;
//            }
//            set
//            {
//                this.tBandField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool tBandSpecified
//        {
//            get
//            {
//                return this.tBandFieldSpecified;
//            }
//            set
//            {
//                this.tBandFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string cAut
//        {
//            get
//            {
//                return this.cAutField;
//            }
//            set
//            {
//                this.cAutField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagDetPagCardTpIntegra
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagDetPagCardTBand
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06")]
//        Item06,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07")]
//        Item07,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08")]
//        Item08,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09")]
//        Item09,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdic
//    {

//        private string infAdFiscoField;

//        private string infCplField;

//        private TNFeInfNFeInfAdicObsCont[] obsContField;

//        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;

//        private TNFeInfNFeInfAdicProcRef[] procRefField;

//        /// <remarks/>
//        public string infAdFisco
//        {
//            get
//            {
//                return this.infAdFiscoField;
//            }
//            set
//            {
//                this.infAdFiscoField = value;
//            }
//        }

//        /// <remarks/>
//        public string infCpl
//        {
//            get
//            {
//                return this.infCplField;
//            }
//            set
//            {
//                this.infCplField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
//        public TNFeInfNFeInfAdicObsCont[] obsCont
//        {
//            get
//            {
//                return this.obsContField;
//            }
//            set
//            {
//                this.obsContField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
//        public TNFeInfNFeInfAdicObsFisco[] obsFisco
//        {
//            get
//            {
//                return this.obsFiscoField;
//            }
//            set
//            {
//                this.obsFiscoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("procRef")]
//        public TNFeInfNFeInfAdicProcRef[] procRef
//        {
//            get
//            {
//                return this.procRefField;
//            }
//            set
//            {
//                this.procRefField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicObsCont
//    {

//        private string xTextoField;

//        private string xCampoField;

//        /// <remarks/>
//        public string xTexto
//        {
//            get
//            {
//                return this.xTextoField;
//            }
//            set
//            {
//                this.xTextoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string xCampo
//        {
//            get
//            {
//                return this.xCampoField;
//            }
//            set
//            {
//                this.xCampoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicObsFisco
//    {

//        private string xTextoField;

//        private string xCampoField;

//        /// <remarks/>
//        public string xTexto
//        {
//            get
//            {
//                return this.xTextoField;
//            }
//            set
//            {
//                this.xTextoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string xCampo
//        {
//            get
//            {
//                return this.xCampoField;
//            }
//            set
//            {
//                this.xCampoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicProcRef
//    {

//        private string nProcField;

//        private TNFeInfNFeInfAdicProcRefIndProc indProcField;

//        /// <remarks/>
//        public string nProc
//        {
//            get
//            {
//                return this.nProcField;
//            }
//            set
//            {
//                this.nProcField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeInfAdicProcRefIndProc indProc
//        {
//            get
//            {
//                return this.indProcField;
//            }
//            set
//            {
//                this.indProcField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeInfAdicProcRefIndProc
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeExporta
//    {

//        private TUfEmi uFSaidaPaisField;

//        private string xLocExportaField;

//        private string xLocDespachoField;

//        /// <remarks/>
//        public TUfEmi UFSaidaPais
//        {
//            get
//            {
//                return this.uFSaidaPaisField;
//            }
//            set
//            {
//                this.uFSaidaPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocExporta
//        {
//            get
//            {
//                return this.xLocExportaField;
//            }
//            set
//            {
//                this.xLocExportaField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocDespacho
//        {
//            get
//            {
//                return this.xLocDespachoField;
//            }
//            set
//            {
//                this.xLocDespachoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCompra
//    {

//        private string xNEmpField;

//        private string xPedField;

//        private string xContField;

//        /// <remarks/>
//        public string xNEmp
//        {
//            get
//            {
//                return this.xNEmpField;
//            }
//            set
//            {
//                this.xNEmpField = value;
//            }
//        }

//        /// <remarks/>
//        public string xPed
//        {
//            get
//            {
//                return this.xPedField;
//            }
//            set
//            {
//                this.xPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCont
//        {
//            get
//            {
//                return this.xContField;
//            }
//            set
//            {
//                this.xContField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCana
//    {

//        private string safraField;

//        private string refField;

//        private TNFeInfNFeCanaForDia[] forDiaField;

//        private string qTotMesField;

//        private string qTotAntField;

//        private string qTotGerField;

//        private TNFeInfNFeCanaDeduc[] deducField;

//        private string vForField;

//        private string vTotDedField;

//        private string vLiqForField;

//        /// <remarks/>
//        public string safra
//        {
//            get
//            {
//                return this.safraField;
//            }
//            set
//            {
//                this.safraField = value;
//            }
//        }

//        /// <remarks/>
//        public string @ref
//        {
//            get
//            {
//                return this.refField;
//            }
//            set
//            {
//                this.refField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("forDia")]
//        public TNFeInfNFeCanaForDia[] forDia
//        {
//            get
//            {
//                return this.forDiaField;
//            }
//            set
//            {
//                this.forDiaField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotMes
//        {
//            get
//            {
//                return this.qTotMesField;
//            }
//            set
//            {
//                this.qTotMesField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotAnt
//        {
//            get
//            {
//                return this.qTotAntField;
//            }
//            set
//            {
//                this.qTotAntField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotGer
//        {
//            get
//            {
//                return this.qTotGerField;
//            }
//            set
//            {
//                this.qTotGerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("deduc")]
//        public TNFeInfNFeCanaDeduc[] deduc
//        {
//            get
//            {
//                return this.deducField;
//            }
//            set
//            {
//                this.deducField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFor
//        {
//            get
//            {
//                return this.vForField;
//            }
//            set
//            {
//                this.vForField = value;
//            }
//        }

//        /// <remarks/>
//        public string vTotDed
//        {
//            get
//            {
//                return this.vTotDedField;
//            }
//            set
//            {
//                this.vTotDedField = value;
//            }
//        }

//        /// <remarks/>
//        public string vLiqFor
//        {
//            get
//            {
//                return this.vLiqForField;
//            }
//            set
//            {
//                this.vLiqForField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCanaForDia
//    {

//        private string qtdeField;

//        private string diaField;

//        /// <remarks/>
//        public string qtde
//        {
//            get
//            {
//                return this.qtdeField;
//            }
//            set
//            {
//                this.qtdeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string dia
//        {
//            get
//            {
//                return this.diaField;
//            }
//            set
//            {
//                this.diaField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCanaDeduc
//    {

//        private string xDedField;

//        private string vDedField;

//        /// <remarks/>
//        public string xDed
//        {
//            get
//            {
//                return this.xDedField;
//            }
//            set
//            {
//                this.xDedField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDed
//        {
//            get
//            {
//                return this.vDedField;
//            }
//            set
//            {
//                this.vDedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeSupl
//    {

//        private string qrCodeField;

//        private string urlChaveField;

//        /// <remarks/>
//        public string qrCode
//        {
//            get
//            {
//                return this.qrCodeField;
//            }
//            set
//            {
//                this.qrCodeField = value;
//            }
//        }

//        /// <remarks/>
//        public string urlChave
//        {
//            get
//            {
//                return this.urlChaveField;
//            }
//            set
//            {
//                this.urlChaveField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
//    public partial class SignatureType
//    {

//        private SignedInfoType signedInfoField;

//        private SignatureValueType signatureValueField;

//        private KeyInfoType keyInfoField;

//        private string idField;

//        /// <remarks/>
//        public SignedInfoType SignedInfo
//        {
//            get
//            {
//                return this.signedInfoField;
//            }
//            set
//            {
//                this.signedInfoField = value;
//            }
//        }

//        /// <remarks/>
//        public SignatureValueType SignatureValue
//        {
//            get
//            {
//                return this.signatureValueField;
//            }
//            set
//            {
//                this.signatureValueField = value;
//            }
//        }

//        /// <remarks/>
//        public KeyInfoType KeyInfo
//        {
//            get
//            {
//                return this.keyInfoField;
//            }
//            set
//            {
//                this.keyInfoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class SignedInfoType
//    {

//        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;

//        private SignedInfoTypeSignatureMethod signatureMethodField;

//        private ReferenceType referenceField;

//        private string idField;

//        /// <remarks/>
//        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
//        {
//            get
//            {
//                return this.canonicalizationMethodField;
//            }
//            set
//            {
//                this.canonicalizationMethodField = value;
//            }
//        }

//        /// <remarks/>
//        public SignedInfoTypeSignatureMethod SignatureMethod
//        {
//            get
//            {
//                return this.signatureMethodField;
//            }
//            set
//            {
//                this.signatureMethodField = value;
//            }
//        }

//        /// <remarks/>
//        public ReferenceType Reference
//        {
//            get
//            {
//                return this.referenceField;
//            }
//            set
//            {
//                this.referenceField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class SignedInfoTypeCanonicalizationMethod
//    {

//        private string algorithmField;

//        public SignedInfoTypeCanonicalizationMethod()
//        {
//            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
//        public string Algorithm
//        {
//            get
//            {
//                return this.algorithmField;
//            }
//            set
//            {
//                this.algorithmField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class SignedInfoTypeSignatureMethod
//    {

//        private string algorithmField;

//        public SignedInfoTypeSignatureMethod()
//        {
//            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
//        public string Algorithm
//        {
//            get
//            {
//                return this.algorithmField;
//            }
//            set
//            {
//                this.algorithmField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class ReferenceType
//    {

//        private TransformType[] transformsField;

//        private ReferenceTypeDigestMethod digestMethodField;

//        private byte[] digestValueField;

//        private string idField;

//        private string uRIField;

//        private string typeField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
//        public TransformType[] Transforms
//        {
//            get
//            {
//                return this.transformsField;
//            }
//            set
//            {
//                this.transformsField = value;
//            }
//        }

//        /// <remarks/>
//        public ReferenceTypeDigestMethod DigestMethod
//        {
//            get
//            {
//                return this.digestMethodField;
//            }
//            set
//            {
//                this.digestMethodField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
//        public byte[] DigestValue
//        {
//            get
//            {
//                return this.digestValueField;
//            }
//            set
//            {
//                this.digestValueField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
//        public string URI
//        {
//            get
//            {
//                return this.uRIField;
//            }
//            set
//            {
//                this.uRIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
//        public string Type
//        {
//            get
//            {
//                return this.typeField;
//            }
//            set
//            {
//                this.typeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class TransformType
//    {

//        private string[] xPathField;

//        private TTransformURI algorithmField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("XPath")]
//        public string[] XPath
//        {
//            get
//            {
//                return this.xPathField;
//            }
//            set
//            {
//                this.xPathField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public TTransformURI Algorithm
//        {
//            get
//            {
//                return this.algorithmField;
//            }
//            set
//            {
//                this.algorithmField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public enum TTransformURI
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
//        httpwwww3org200009xmldsigenvelopedsignature,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
//        httpwwww3orgTR2001RECxmlc14n20010315,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class ReferenceTypeDigestMethod
//    {

//        private string algorithmField;

//        public ReferenceTypeDigestMethod()
//        {
//            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
//        public string Algorithm
//        {
//            get
//            {
//                return this.algorithmField;
//            }
//            set
//            {
//                this.algorithmField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class SignatureValueType
//    {

//        private string idField;

//        private byte[] valueField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
//        public byte[] Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class KeyInfoType
//    {

//        private X509DataType x509DataField;

//        private string idField;

//        /// <remarks/>
//        public X509DataType X509Data
//        {
//            get
//            {
//                return this.x509DataField;
//            }
//            set
//            {
//                this.x509DataField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//    public partial class X509DataType
//    {

//        private byte[] x509CertificateField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
//        public byte[] X509Certificate
//        {
//            get
//            {
//                return this.x509CertificateField;
//            }
//            set
//            {
//                this.x509CertificateField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TInutNFe
//    {

//        private TInutNFeInfInut infInutField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TInutNFeInfInut infInut
//        {
//            get
//            {
//                return this.infInutField;
//            }
//            set
//            {
//                this.infInutField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TInutNFeInfInut
//    {

//        private TAmb tpAmbField;

//        private TInutNFeInfInutXServ xServField;

//        private TCodUfIBGE cUFField;

//        private string anoField;

//        private string cNPJField;

//        private TMod modField;

//        private string serieField;

//        private string nNFIniField;

//        private string nNFFinField;

//        private string xJustField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TInutNFeInfInutXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string ano
//        {
//            get
//            {
//                return this.anoField;
//            }
//            set
//            {
//                this.anoField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFIni
//        {
//            get
//            {
//                return this.nNFIniField;
//            }
//            set
//            {
//                this.nNFIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFFin
//        {
//            get
//            {
//                return this.nNFFinField;
//            }
//            set
//            {
//                this.nNFFinField = value;
//            }
//        }

//        /// <remarks/>
//        public string xJust
//        {
//            get
//            {
//                return this.xJustField;
//            }
//            set
//            {
//                this.xJustField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TInutNFeInfInutXServ
//    {

//        /// <remarks/>
//        INUTILIZAR,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("ProcInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TProcInutNFe
//    {

//        private TInutNFe inutNFeField;

//        private TRetInutNFe retInutNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TInutNFe inutNFe
//        {
//            get
//            {
//                return this.inutNFeField;
//            }
//            set
//            {
//                this.inutNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TRetInutNFe retInutNFe
//        {
//            get
//            {
//                return this.retInutNFeField;
//            }
//            set
//            {
//                this.retInutNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetInutNFe
//    {

//        private TRetInutNFeInfInut infInutField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TRetInutNFeInfInut infInut
//        {
//            get
//            {
//                return this.infInutField;
//            }
//            set
//            {
//                this.infInutField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetInutNFeInfInut
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string anoField;

//        private string cNPJField;

//        private TMod modField;

//        private bool modFieldSpecified;

//        private string serieField;

//        private string nNFIniField;

//        private string nNFFinField;

//        private string dhRecbtoField;

//        private string nProtField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string ano
//        {
//            get
//            {
//                return this.anoField;
//            }
//            set
//            {
//                this.anoField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool modSpecified
//        {
//            get
//            {
//                return this.modFieldSpecified;
//            }
//            set
//            {
//                this.modFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFIni
//        {
//            get
//            {
//                return this.nNFIniField;
//            }
//            set
//            {
//                this.nNFIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFFin
//        {
//            get
//            {
//                return this.nNFFinField;
//            }
//            set
//            {
//                this.nNFFinField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TNfeProc
//    {

//        private TNFe nFeField;

//        private TProtNFe protNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TNFe NFe
//        {
//            get
//            {
//                return this.nFeField;
//            }
//            set
//            {
//                this.nFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TProtNFe protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TProtNFe
//    {

//        private TProtNFeInfProt infProtField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TProtNFeInfProt infProt
//        {
//            get
//            {
//                return this.infProtField;
//            }
//            set
//            {
//                this.infProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TProtNFeInfProt
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string chNFeField;

//        private System.DateTime dhRecbtoField;

//        private string nProtField;

//        private byte[] digValField;

//        private string cStatField;

//        private string xMotivoField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public System.DateTime dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
//        public byte[] digVal
//        {
//            get
//            {
//                return this.digValField;
//            }
//            set
//            {
//                this.digValField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsReciNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string nRecField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string cMsgField;

//        private string xMsgField;

//        private TProtNFe[] protNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string nRec
//        {
//            get
//            {
//                return this.nRecField;
//            }
//            set
//            {
//                this.nRecField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMsg
//        {
//            get
//            {
//                return this.cMsgField;
//            }
//            set
//            {
//                this.cMsgField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMsg
//        {
//            get
//            {
//                return this.xMsgField;
//            }
//            set
//            {
//                this.xMsgField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("protNFe")]
//        public TProtNFe[] protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsSitNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string chNFeField;

//        private TProtNFe protNFeField;

//        private TRetCancNFe retCancNFeField;

//        private TProcEvento[] procEventoNFeField;

//        private TVerConsSitNFe versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TProtNFe protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TRetCancNFe retCancNFe
//        {
//            get
//            {
//                return this.retCancNFeField;
//            }
//            set
//            {
//                this.retCancNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("procEventoNFe")]
//        public TProcEvento[] procEventoNFe
//        {
//            get
//            {
//                return this.procEventoNFeField;
//            }
//            set
//            {
//                this.procEventoNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public TVerConsSitNFe versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetCancNFe
//    {

//        private TRetCancNFeInfCanc infCancField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TRetCancNFeInfCanc infCanc
//        {
//            get
//            {
//                return this.infCancField;
//            }
//            set
//            {
//                this.infCancField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetCancNFeInfCanc
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string chNFeField;

//        private System.DateTime dhRecbtoField;

//        private bool dhRecbtoFieldSpecified;

//        private string nProtField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public System.DateTime dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool dhRecbtoSpecified
//        {
//            get
//            {
//                return this.dhRecbtoFieldSpecified;
//            }
//            set
//            {
//                this.dhRecbtoFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TProcEvento
//    {

//        private TEvento eventoField;

//        private TRetEvento retEventoField;

//        private string versaoField;

//        /// <remarks/>
//        public TEvento evento
//        {
//            get
//            {
//                return this.eventoField;
//            }
//            set
//            {
//                this.eventoField = value;
//            }
//        }

//        /// <remarks/>
//        public TRetEvento retEvento
//        {
//            get
//            {
//                return this.retEventoField;
//            }
//            set
//            {
//                this.retEventoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEvento
//    {

//        private TEventoInfEvento infEventoField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TEventoInfEvento infEvento
//        {
//            get
//            {
//                return this.infEventoField;
//            }
//            set
//            {
//                this.infEventoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEventoInfEvento
//    {

//        private TCOrgaoIBGE cOrgaoField;

//        private TAmb tpAmbField;

//        private string itemField;

//        private ItemChoiceType7 itemElementNameField;

//        private string chNFeField;

//        private string dhEventoField;

//        private string tpEventoField;

//        private string nSeqEventoField;

//        private string verEventoField;

//        private TEventoInfEventoDetEvento detEventoField;

//        private string idField;

//        /// <remarks/>
//        public TCOrgaoIBGE cOrgao
//        {
//            get
//            {
//                return this.cOrgaoField;
//            }
//            set
//            {
//                this.cOrgaoField = value;
//            }
//        }

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType7 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhEvento
//        {
//            get
//            {
//                return this.dhEventoField;
//            }
//            set
//            {
//                this.dhEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpEvento
//        {
//            get
//            {
//                return this.tpEventoField;
//            }
//            set
//            {
//                this.tpEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSeqEvento
//        {
//            get
//            {
//                return this.nSeqEventoField;
//            }
//            set
//            {
//                this.nSeqEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string verEvento
//        {
//            get
//            {
//                return this.verEventoField;
//            }
//            set
//            {
//                this.verEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public TEventoInfEventoDetEvento detEvento
//        {
//            get
//            {
//                return this.detEventoField;
//            }
//            set
//            {
//                this.detEventoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TCOrgaoIBGE
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11")]
//        Item11,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13")]
//        Item13,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14")]
//        Item14,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15")]
//        Item15,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("16")]
//        Item16,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17")]
//        Item17,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("21")]
//        Item21,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("22")]
//        Item22,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("23")]
//        Item23,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("24")]
//        Item24,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25")]
//        Item25,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("26")]
//        Item26,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("27")]
//        Item27,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("28")]
//        Item28,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("29")]
//        Item29,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("31")]
//        Item31,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("32")]
//        Item32,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("33")]
//        Item33,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("35")]
//        Item35,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("41")]
//        Item41,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("42")]
//        Item42,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("43")]
//        Item43,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("91")]
//        Item91,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("92")]
//        Item92,
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEventoInfEventoDetEvento
//    {

//        private System.Xml.XmlElement[] anyField;

//        private System.Xml.XmlAttribute[] anyAttrField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAnyElementAttribute()]
//        public System.Xml.XmlElement[] Any
//        {
//            get
//            {
//                return this.anyField;
//            }
//            set
//            {
//                this.anyField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
//        public System.Xml.XmlAttribute[] AnyAttr
//        {
//            get
//            {
//                return this.anyAttrField;
//            }
//            set
//            {
//                this.anyAttrField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetEvento
//    {

//        private TRetEventoInfEvento infEventoField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TRetEventoInfEvento infEvento
//        {
//            get
//            {
//                return this.infEventoField;
//            }
//            set
//            {
//                this.infEventoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetEventoInfEvento
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private TCOrgaoIBGE cOrgaoField;

//        private string cStatField;

//        private string xMotivoField;

//        private string chNFeField;

//        private string tpEventoField;

//        private string xEventoField;

//        private string nSeqEventoField;

//        private string itemField;

//        private ItemChoiceType8 itemElementNameField;

//        private string emailDestField;

//        private string dhRegEventoField;

//        private string nProtField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public TCOrgaoIBGE cOrgao
//        {
//            get
//            {
//                return this.cOrgaoField;
//            }
//            set
//            {
//                this.cOrgaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpEvento
//        {
//            get
//            {
//                return this.tpEventoField;
//            }
//            set
//            {
//                this.tpEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string xEvento
//        {
//            get
//            {
//                return this.xEventoField;
//            }
//            set
//            {
//                this.xEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSeqEvento
//        {
//            get
//            {
//                return this.nSeqEventoField;
//            }
//            set
//            {
//                this.nSeqEventoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemChoiceType8 ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string emailDest
//        {
//            get
//            {
//                return this.emailDestField;
//            }
//            set
//            {
//                this.emailDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRegEvento
//        {
//            get
//            {
//                return this.dhRegEventoField;
//            }
//            set
//            {
//                this.dhRegEventoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemChoiceType8
//    {

//        /// <remarks/>
//        CNPJDest,

//        /// <remarks/>
//        CPFDest,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsStatServ
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string tMedField;

//        private string dhRetornoField;

//        private string xObsField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string tMed
//        {
//            get
//            {
//                return this.tMedField;
//            }
//            set
//            {
//                this.tMedField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRetorno
//        {
//            get
//            {
//                return this.dhRetornoField;
//            }
//            set
//            {
//                this.dhRetornoField = value;
//            }
//        }

//        /// <remarks/>
//        public string xObs
//        {
//            get
//            {
//                return this.xObsField;
//            }
//            set
//            {
//                this.xObsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retEnviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetEnviNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private object itemField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("infRec", typeof(TRetEnviNFeInfRec))]
//        [System.Xml.Serialization.XmlElementAttribute("protNFe", typeof(TProtNFe))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetEnviNFeInfRec
//    {

//        private string nRecField;

//        private string tMedField;

//        /// <remarks/>
//        public string nRec
//        {
//            get
//            {
//                return this.nRecField;
//            }
//            set
//            {
//                this.nRecField = value;
//            }
//        }

//        /// <remarks/>
//        public string tMed
//        {
//            get
//            {
//                return this.tMedField;
//            }
//            set
//            {
//                this.tMedField = value;
//            }
//        }
//    }














//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TConsSitNFe
//    {

//        private TAmb tpAmbField;

//        private TConsSitNFeXServ xServField;

//        private string chNFeField;

//        private TVerConsSitNFe versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TConsSitNFeXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public TVerConsSitNFe versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TConsStatServ
//    {

//        private TAmb tpAmbField;

//        private TCodUfIBGE cUFField;

//        private TConsStatServXServ xServField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public TConsStatServXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TEnviNFe
//    {

//        private string idLoteField;

//        private TEnviNFeIndSinc indSincField;

//        private TNFe[] nFeField;

//        private string versaoField;

//        /// <remarks/>
//        public string idLote
//        {
//            get
//            {
//                return this.idLoteField;
//            }
//            set
//            {
//                this.idLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnviNFeIndSinc indSinc
//        {
//            get
//            {
//                return this.indSincField;
//            }
//            set
//            {
//                this.indSincField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NFe")]
//        public TNFe[] NFe
//        {
//            get
//            {
//                return this.nFeField;
//            }
//            set
//            {
//                this.nFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TNFe
//    {

//        private TNFeInfNFe infNFeField;

//        private TNFeInfNFeSupl infNFeSuplField;

//        private SignatureType signatureField;

//        /// <remarks/>
//        public TNFeInfNFe infNFe
//        {
//            get
//            {
//                return this.infNFeField;
//            }
//            set
//            {
//                this.infNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeSupl infNFeSupl
//        {
//            get
//            {
//                return this.infNFeSuplField;
//            }
//            set
//            {
//                this.infNFeSuplField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFe
//    {

//        private TNFeInfNFeIde ideField;

//        private TNFeInfNFeEmit emitField;

//        private TNFeInfNFeAvulsa avulsaField;

//        private TNFeInfNFeDest destField;

//        private TLocal retiradaField;

//        private TLocal entregaField;

//        private TNFeInfNFeAutXML[] autXMLField;

//        private TNFeInfNFeDet[] detField;

//        private TNFeInfNFeTotal totalField;

//        private TNFeInfNFeTransp transpField;

//        private TNFeInfNFeCobr cobrField;

//        private TNFeInfNFePag[] pagField;

//        private TNFeInfNFeInfAdic infAdicField;

//        private TNFeInfNFeExporta exportaField;

//        private TNFeInfNFeCompra compraField;

//        private TNFeInfNFeCana canaField;

//        private string versaoField;

//        private string idField;

//        /// <remarks/>
//        public TNFeInfNFeIde ide
//        {
//            get
//            {
//                return this.ideField;
//            }
//            set
//            {
//                this.ideField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeEmit emit
//        {
//            get
//            {
//                return this.emitField;
//            }
//            set
//            {
//                this.emitField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeAvulsa avulsa
//        {
//            get
//            {
//                return this.avulsaField;
//            }
//            set
//            {
//                this.avulsaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDest dest
//        {
//            get
//            {
//                return this.destField;
//            }
//            set
//            {
//                this.destField = value;
//            }
//        }

//        /// <remarks/>
//        public TLocal retirada
//        {
//            get
//            {
//                return this.retiradaField;
//            }
//            set
//            {
//                this.retiradaField = value;
//            }
//        }

//        /// <remarks/>
//        public TLocal entrega
//        {
//            get
//            {
//                return this.entregaField;
//            }
//            set
//            {
//                this.entregaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("autXML")]
//        public TNFeInfNFeAutXML[] autXML
//        {
//            get
//            {
//                return this.autXMLField;
//            }
//            set
//            {
//                this.autXMLField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("det")]
//        public TNFeInfNFeDet[] det
//        {
//            get
//            {
//                return this.detField;
//            }
//            set
//            {
//                this.detField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotal total
//        {
//            get
//            {
//                return this.totalField;
//            }
//            set
//            {
//                this.totalField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTransp transp
//        {
//            get
//            {
//                return this.transpField;
//            }
//            set
//            {
//                this.transpField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCobr cobr
//        {
//            get
//            {
//                return this.cobrField;
//            }
//            set
//            {
//                this.cobrField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pag")]
//        public TNFeInfNFePag[] pag
//        {
//            get
//            {
//                return this.pagField;
//            }
//            set
//            {
//                this.pagField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeInfAdic infAdic
//        {
//            get
//            {
//                return this.infAdicField;
//            }
//            set
//            {
//                this.infAdicField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeExporta exporta
//        {
//            get
//            {
//                return this.exportaField;
//            }
//            set
//            {
//                this.exportaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCompra compra
//        {
//            get
//            {
//                return this.compraField;
//            }
//            set
//            {
//                this.compraField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeCana cana
//        {
//            get
//            {
//                return this.canaField;
//            }
//            set
//            {
//                this.canaField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIde
//    {

//        private TCodUfIBGE cUFField;

//        private string cNFField;

//        private string natOpField;

//        private TNFeInfNFeIdeIndPag indPagField;

//        private TMod modField;

//        private string serieField;

//        private string nNFField;

//        private string dhEmiField;

//        private string dhSaiEntField;

//        private TNFeInfNFeIdeTpNF tpNFField;

//        private TNFeInfNFeIdeIdDest idDestField;

//        private string cMunFGField;

//        private TNFeInfNFeIdeTpImp tpImpField;

//        private TNFeInfNFeIdeTpEmis tpEmisField;

//        private string cDVField;

//        private TAmb tpAmbField;

//        private TFinNFe finNFeField;

//        private TNFeInfNFeIdeIndFinal indFinalField;

//        private TNFeInfNFeIdeIndPres indPresField;

//        private TProcEmi procEmiField;

//        private string verProcField;

//        private string dhContField;

//        private string xJustField;

//        private TNFeInfNFeIdeNFref[] nFrefField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string cNF
//        {
//            get
//            {
//                return this.cNFField;
//            }
//            set
//            {
//                this.cNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string natOp
//        {
//            get
//            {
//                return this.natOpField;
//            }
//            set
//            {
//                this.natOpField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIndPag indPag
//        {
//            get
//            {
//                return this.indPagField;
//            }
//            set
//            {
//                this.indPagField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhEmi
//        {
//            get
//            {
//                return this.dhEmiField;
//            }
//            set
//            {
//                this.dhEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhSaiEnt
//        {
//            get
//            {
//                return this.dhSaiEntField;
//            }
//            set
//            {
//                this.dhSaiEntField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpNF tpNF
//        {
//            get
//            {
//                return this.tpNFField;
//            }
//            set
//            {
//                this.tpNFField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIdDest idDest
//        {
//            get
//            {
//                return this.idDestField;
//            }
//            set
//            {
//                this.idDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpImp tpImp
//        {
//            get
//            {
//                return this.tpImpField;
//            }
//            set
//            {
//                this.tpImpField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeTpEmis tpEmis
//        {
//            get
//            {
//                return this.tpEmisField;
//            }
//            set
//            {
//                this.tpEmisField = value;
//            }
//        }

//        /// <remarks/>
//        public string cDV
//        {
//            get
//            {
//                return this.cDVField;
//            }
//            set
//            {
//                this.cDVField = value;
//            }
//        }

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TFinNFe finNFe
//        {
//            get
//            {
//                return this.finNFeField;
//            }
//            set
//            {
//                this.finNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIndFinal indFinal
//        {
//            get
//            {
//                return this.indFinalField;
//            }
//            set
//            {
//                this.indFinalField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeIndPres_v400 indPres
//        {
//            get
//            {
//                return this.indPresField;
//            }
//            set
//            {
//                this.indPresField = value;
//            }
//        }

//        /// <remarks/>
//        public TProcEmi procEmi
//        {
//            get
//            {
//                return this.procEmiField;
//            }
//            set
//            {
//                this.procEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string verProc
//        {
//            get
//            {
//                return this.verProcField;
//            }
//            set
//            {
//                this.verProcField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhCont
//        {
//            get
//            {
//                return this.dhContField;
//            }
//            set
//            {
//                this.dhContField = value;
//            }
//        }

//        /// <remarks/>
//        public string xJust
//        {
//            get
//            {
//                return this.xJustField;
//            }
//            set
//            {
//                this.xJustField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NFref")]
//        public TNFeInfNFeIdeNFref[] NFref
//        {
//            get
//            {
//                return this.nFrefField;
//            }
//            set
//            {
//                this.nFrefField = value;
//            }
//        }
//    }




//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TRegEspTrib
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        MicroEmpresaMunicipal,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Estimativa,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        SociedadeProfissionais,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Cooperativa,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        MEISimplesNacional,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        MEEPPSimplesNacional,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFref
//    {

//        private object itemField;

//        private ITCTypeRefNF itemElementNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
//        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
//        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
//        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeRefNF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefECF
//    {

//        private TNFeInfNFeIdeNFrefRefECFMod modField;

//        private string nECFField;

//        private string nCOOField;

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefECFMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string nECF
//        {
//            get
//            {
//                return this.nECFField;
//            }
//            set
//            {
//                this.nECFField = value;
//            }
//        }

//        /// <remarks/>
//        public string nCOO
//        {
//            get
//            {
//                return this.nCOOField;
//            }
//            set
//            {
//                this.nCOOField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefNF
//    {

//        private TCodUfIBGE cUFField;

//        private string aAMMField;

//        private string cNPJField;

//        private TNFeInfNFeIdeNFrefRefNFMod modField;

//        private string serieField;

//        private string nNFField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string AAMM
//        {
//            get
//            {
//                return this.aAMMField;
//            }
//            set
//            {
//                this.aAMMField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefNFMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeIdeNFrefRefNFP
//    {

//        private TCodUfIBGE cUFField;

//        private string aAMMField;

//        private string itemField;

//        private ITCTypeCNPJCPF itemElementNameField;

//        private string ieField;

//        private TNFeInfNFeIdeNFrefRefNFPMod modField;

//        private string serieField;

//        private string nNFField;

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string AAMM
//        {
//            get
//            {
//                return this.aAMMField;
//            }
//            set
//            {
//                this.aAMMField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeIdeNFrefRefNFPMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNF
//        {
//            get
//            {
//                return this.nNFField;
//            }
//            set
//            {
//                this.nNFField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeEmit
//    {

//        private string itemField;

//        private ITCTypeCNPJCPF itemElementNameField;

//        private string xNomeField;

//        private string xFantField;

//        private TEnderEmi enderEmitField;

//        private string ieField;

//        private string iESTField;

//        private string imField;

//        private string cNAEField;

//        private TNFeInfNFeEmitCRT cRTField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public string xFant
//        {
//            get
//            {
//                return this.xFantField;
//            }
//            set
//            {
//                this.xFantField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmi enderEmit
//        {
//            get
//            {
//                return this.enderEmitField;
//            }
//            set
//            {
//                this.enderEmitField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string IEST
//        {
//            get
//            {
//                return this.iESTField;
//            }
//            set
//            {
//                this.iESTField = value;
//            }
//        }

//        /// <remarks/>
//        public string IM
//        {
//            get
//            {
//                return this.imField;
//            }
//            set
//            {
//                this.imField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNAE
//        {
//            get
//            {
//                return this.cNAEField;
//            }
//            set
//            {
//                this.cNAEField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeEmitCRT CRT
//        {
//            get
//            {
//                return this.cRTField;
//            }
//            set
//            {
//                this.cRTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEnderEmi
//    {

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUfEmi ufField;

//        private string cEPField;

//        private TEnderEmiCPais cPaisField;

//        private bool cPaisFieldSpecified;

//        private TEnderEmiXPais xPaisField;

//        private bool xPaisFieldSpecified;

//        private string foneField;

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEP
//        {
//            get
//            {
//                return this.cEPField;
//            }
//            set
//            {
//                this.cEPField = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmiCPais cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cPaisSpecified
//        {
//            get
//            {
//                return this.cPaisFieldSpecified;
//            }
//            set
//            {
//                this.cPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public TEnderEmiXPais xPais
//        {
//            get
//            {
//                return this.xPaisField;
//            }
//            set
//            {
//                this.xPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool xPaisSpecified
//        {
//            get
//            {
//                return this.xPaisFieldSpecified;
//            }
//            set
//            {
//                this.xPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeAvulsa
//    {

//        private string cNPJField;

//        private string xOrgaoField;

//        private string matrField;

//        private string xAgenteField;

//        private string foneField;

//        private TUfEmi ufField;

//        private string nDARField;

//        private string dEmiField;

//        private string vDARField;

//        private string repEmiField;

//        private string dPagField;

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public string xOrgao
//        {
//            get
//            {
//                return this.xOrgaoField;
//            }
//            set
//            {
//                this.xOrgaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string matr
//        {
//            get
//            {
//                return this.matrField;
//            }
//            set
//            {
//                this.matrField = value;
//            }
//        }

//        /// <remarks/>
//        public string xAgente
//        {
//            get
//            {
//                return this.xAgenteField;
//            }
//            set
//            {
//                this.xAgenteField = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string nDAR
//        {
//            get
//            {
//                return this.nDARField;
//            }
//            set
//            {
//                this.nDARField = value;
//            }
//        }

//        /// <remarks/>
//        public string dEmi
//        {
//            get
//            {
//                return this.dEmiField;
//            }
//            set
//            {
//                this.dEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDAR
//        {
//            get
//            {
//                return this.vDARField;
//            }
//            set
//            {
//                this.vDARField = value;
//            }
//        }

//        /// <remarks/>
//        public string repEmi
//        {
//            get
//            {
//                return this.repEmiField;
//            }
//            set
//            {
//                this.repEmiField = value;
//            }
//        }

//        /// <remarks/>
//        public string dPag
//        {
//            get
//            {
//                return this.dPagField;
//            }
//            set
//            {
//                this.dPagField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDest
//    {

//        private string itemField;

//        private ITCTypeCNPJCPFIdEstrangeiro itemElementNameField;

//        private string xNomeField;

//        private TEndereco enderDestField;

//        private TNFeInfNFeDestIndIEDest indIEDestField;

//        private string ieField;

//        private string iSUFField;

//        private string imField;

//        private string emailField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPFIdEstrangeiro ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public TEndereco enderDest
//        {
//            get
//            {
//                return this.enderDestField;
//            }
//            set
//            {
//                this.enderDestField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDestIndIEDest indIEDest
//        {
//            get
//            {
//                return this.indIEDestField;
//            }
//            set
//            {
//                this.indIEDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string ISUF
//        {
//            get
//            {
//                return this.iSUFField;
//            }
//            set
//            {
//                this.iSUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string IM
//        {
//            get
//            {
//                return this.imField;
//            }
//            set
//            {
//                this.imField = value;
//            }
//        }

//        /// <remarks/>
//        public string email
//        {
//            get
//            {
//                return this.emailField;
//            }
//            set
//            {
//                this.emailField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemChoiceType3
//    {

//        /// <remarks/>
//        CNPJ,

//        /// <remarks/>
//        CPF,

//        /// <remarks/>
//        idEstrangeiro,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TEndereco
//    {

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUf ufField;

//        private string cEPField;

//        private Tpais cPaisField;

//        private bool cPaisFieldSpecified;

//        private string xPaisField;

//        private string foneField;

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEP
//        {
//            get
//            {
//                return this.cEPField;
//            }
//            set
//            {
//                this.cEPField = value;
//            }
//        }

//        /// <remarks/>
//        public Tpais cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cPaisSpecified
//        {
//            get
//            {
//                return this.cPaisFieldSpecified;
//            }
//            set
//            {
//                this.cPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string xPais
//        {
//            get
//            {
//                return this.xPaisField;
//            }
//            set
//            {
//                this.xPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string fone
//        {
//            get
//            {
//                return this.foneField;
//            }
//            set
//            {
//                this.foneField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum Tpais
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("132")]
//        Item132,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("175")]
//        Item175,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("230")]
//        Item230,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("310")]
//        Item310,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("370")]
//        Item370,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("400")]
//        Item400,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("418")]
//        Item418,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("434")]
//        Item434,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("477")]
//        Item477,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("531")]
//        Item531,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("590")]
//        Item590,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("639")]
//        Item639,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("647")]
//        Item647,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("655")]
//        Item655,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("698")]
//        Item698,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("728")]
//        Item728,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("736")]
//        Item736,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("779")]
//        Item779,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("809")]
//        Item809,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("817")]
//        Item817,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("833")]
//        Item833,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("850")]
//        Item850,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("876")]
//        Item876,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("884")]
//        Item884,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("906")]
//        Item906,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("930")]
//        Item930,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("973")]
//        Item973,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("981")]
//        Item981,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0132")]
//        Item0132,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0175")]
//        Item0175,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0230")]
//        Item0230,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0310")]
//        Item0310,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0370")]
//        Item0370,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0400")]
//        Item0400,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0418")]
//        Item0418,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0434")]
//        Item0434,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0477")]
//        Item0477,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0531")]
//        Item0531,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0590")]
//        Item0590,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0639")]
//        Item0639,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0647")]
//        Item0647,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0655")]
//        Item0655,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0698")]
//        Item0698,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0728")]
//        Item0728,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0736")]
//        Item0736,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0779")]
//        Item0779,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0809")]
//        Item0809,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0817")]
//        Item0817,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0833")]
//        Item0833,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0850")]
//        Item0850,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0876")]
//        Item0876,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0884")]
//        Item0884,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0906")]
//        Item0906,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0930")]
//        Item0930,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0973")]
//        Item0973,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0981")]
//        Item0981,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1015")]
//        Item1015,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1058")]
//        Item1058,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1082")]
//        Item1082,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1112")]
//        Item1112,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1155")]
//        Item1155,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1198")]
//        Item1198,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1279")]
//        Item1279,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1376")]
//        Item1376,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1414")]
//        Item1414,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1457")]
//        Item1457,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1490")]
//        Item1490,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1504")]
//        Item1504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1508")]
//        Item1508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1511")]
//        Item1511,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1538")]
//        Item1538,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1546")]
//        Item1546,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1589")]
//        Item1589,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1600")]
//        Item1600,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1619")]
//        Item1619,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1635")]
//        Item1635,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1651")]
//        Item1651,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1694")]
//        Item1694,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1732")]
//        Item1732,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1775")]
//        Item1775,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1830")]
//        Item1830,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1872")]
//        Item1872,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1902")]
//        Item1902,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1937")]
//        Item1937,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1953")]
//        Item1953,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1961")]
//        Item1961,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1988")]
//        Item1988,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1996")]
//        Item1996,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2291")]
//        Item2291,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2321")]
//        Item2321,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2356")]
//        Item2356,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2399")]
//        Item2399,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2402")]
//        Item2402,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2437")]
//        Item2437,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2445")]
//        Item2445,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2453")]
//        Item2453,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2461")]
//        Item2461,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2470")]
//        Item2470,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2496")]
//        Item2496,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2518")]
//        Item2518,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2534")]
//        Item2534,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2550")]
//        Item2550,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2593")]
//        Item2593,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2674")]
//        Item2674,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2712")]
//        Item2712,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2755")]
//        Item2755,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2810")]
//        Item2810,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2852")]
//        Item2852,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2895")]
//        Item2895,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2917")]
//        Item2917,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2933")]
//        Item2933,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2976")]
//        Item2976,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3018")]
//        Item3018,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3050")]
//        Item3050,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3093")]
//        Item3093,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3131")]
//        Item3131,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3174")]
//        Item3174,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3255")]
//        Item3255,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3298")]
//        Item3298,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3310")]
//        Item3310,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3344")]
//        Item3344,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3379")]
//        Item3379,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3417")]
//        Item3417,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3450")]
//        Item3450,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3514")]
//        Item3514,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3557")]
//        Item3557,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3573")]
//        Item3573,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3595")]
//        Item3595,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3611")]
//        Item3611,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3654")]
//        Item3654,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3697")]
//        Item3697,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3727")]
//        Item3727,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3751")]
//        Item3751,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3794")]
//        Item3794,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3832")]
//        Item3832,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3867")]
//        Item3867,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3913")]
//        Item3913,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3964")]
//        Item3964,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3999")]
//        Item3999,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4030")]
//        Item4030,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4111")]
//        Item4111,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4200")]
//        Item4200,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4235")]
//        Item4235,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4260")]
//        Item4260,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4278")]
//        Item4278,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4316")]
//        Item4316,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4340")]
//        Item4340,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4383")]
//        Item4383,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4405")]
//        Item4405,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4421")]
//        Item4421,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4456")]
//        Item4456,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4472")]
//        Item4472,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4499")]
//        Item4499,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4502")]
//        Item4502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4525")]
//        Item4525,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4553")]
//        Item4553,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4588")]
//        Item4588,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4618")]
//        Item4618,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4642")]
//        Item4642,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4677")]
//        Item4677,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4723")]
//        Item4723,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4740")]
//        Item4740,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4766")]
//        Item4766,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4774")]
//        Item4774,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4855")]
//        Item4855,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4880")]
//        Item4880,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4885")]
//        Item4885,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4901")]
//        Item4901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4936")]
//        Item4936,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4944")]
//        Item4944,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4952")]
//        Item4952,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4979")]
//        Item4979,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4985")]
//        Item4985,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4995")]
//        Item4995,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5010")]
//        Item5010,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5053")]
//        Item5053,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5070")]
//        Item5070,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5088")]
//        Item5088,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5118")]
//        Item5118,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5177")]
//        Item5177,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5215")]
//        Item5215,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5258")]
//        Item5258,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5282")]
//        Item5282,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5312")]
//        Item5312,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5355")]
//        Item5355,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5380")]
//        Item5380,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5428")]
//        Item5428,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5452")]
//        Item5452,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5487")]
//        Item5487,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5517")]
//        Item5517,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5568")]
//        Item5568,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5665")]
//        Item5665,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5738")]
//        Item5738,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5754")]
//        Item5754,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5762")]
//        Item5762,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5780")]
//        Item5780,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5800")]
//        Item5800,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5860")]
//        Item5860,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5894")]
//        Item5894,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5932")]
//        Item5932,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5991")]
//        Item5991,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6033")]
//        Item6033,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6076")]
//        Item6076,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6114")]
//        Item6114,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6238")]
//        Item6238,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6254")]
//        Item6254,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6289")]
//        Item6289,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6408")]
//        Item6408,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6475")]
//        Item6475,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6602")]
//        Item6602,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6653")]
//        Item6653,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6700")]
//        Item6700,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6750")]
//        Item6750,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6769")]
//        Item6769,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6777")]
//        Item6777,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6781")]
//        Item6781,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6858")]
//        Item6858,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6874")]
//        Item6874,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6904")]
//        Item6904,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6912")]
//        Item6912,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6955")]
//        Item6955,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6971")]
//        Item6971,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7005")]
//        Item7005,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7056")]
//        Item7056,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7102")]
//        Item7102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7153")]
//        Item7153,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7200")]
//        Item7200,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7285")]
//        Item7285,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7315")]
//        Item7315,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7358")]
//        Item7358,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7370")]
//        Item7370,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7412")]
//        Item7412,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7447")]
//        Item7447,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7480")]
//        Item7480,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7501")]
//        Item7501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7544")]
//        Item7544,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7560")]
//        Item7560,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7595")]
//        Item7595,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7600")]
//        Item7600,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7641")]
//        Item7641,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7676")]
//        Item7676,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7706")]
//        Item7706,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7722")]
//        Item7722,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7765")]
//        Item7765,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7803")]
//        Item7803,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7820")]
//        Item7820,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7838")]
//        Item7838,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7889")]
//        Item7889,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7919")]
//        Item7919,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7951")]
//        Item7951,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8001")]
//        Item8001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8052")]
//        Item8052,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8109")]
//        Item8109,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8150")]
//        Item8150,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8206")]
//        Item8206,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8230")]
//        Item8230,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8249")]
//        Item8249,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8273")]
//        Item8273,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8281")]
//        Item8281,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8311")]
//        Item8311,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8338")]
//        Item8338,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8451")]
//        Item8451,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8478")]
//        Item8478,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8486")]
//        Item8486,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8508")]
//        Item8508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8583")]
//        Item8583,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8630")]
//        Item8630,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8664")]
//        Item8664,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8702")]
//        Item8702,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8737")]
//        Item8737,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8885")]
//        Item8885,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8907")]
//        Item8907,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("8958")]
//        Item8958,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9903")]
//        Item9903,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9946")]
//        Item9946,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9950")]
//        Item9950,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9970")]
//        Item9970,
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TLocal
//    {

//        private string itemField;

//        private ITCTypeCNPJCPF itemElementNameField;

//        private string xLgrField;

//        private string nroField;

//        private string xCplField;

//        private string xBairroField;

//        private string cMunField;

//        private string xMunField;

//        private TUf ufField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLgr
//        {
//            get
//            {
//                return this.xLgrField;
//            }
//            set
//            {
//                this.xLgrField = value;
//            }
//        }

//        /// <remarks/>
//        public string nro
//        {
//            get
//            {
//                return this.nroField;
//            }
//            set
//            {
//                this.nroField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCpl
//        {
//            get
//            {
//                return this.xCplField;
//            }
//            set
//            {
//                this.xCplField = value;
//            }
//        }

//        /// <remarks/>
//        public string xBairro
//        {
//            get
//            {
//                return this.xBairroField;
//            }
//            set
//            {
//                this.xBairroField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeAutXML
//    {

//        private string itemField;

//        private ITCTypeCNPJCPF itemElementNameField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDet
//    {

//        private TNFeInfNFeDetProd prodField;

//        private TNFeInfNFeDetImposto impostoField;

//        private TNFeInfNFeDetImpostoDevol impostoDevolField;

//        private string infAdProdField;

//        private string nItemField;

//        /// <remarks/>
//        public TNFeInfNFeDetProd prod
//        {
//            get
//            {
//                return this.prodField;
//            }
//            set
//            {
//                this.prodField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImposto imposto
//        {
//            get
//            {
//                return this.impostoField;
//            }
//            set
//            {
//                this.impostoField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoDevol impostoDevol
//        {
//            get
//            {
//                return this.impostoDevolField;
//            }
//            set
//            {
//                this.impostoDevolField = value;
//            }
//        }

//        /// <remarks/>
//        public string infAdProd
//        {
//            get
//            {
//                return this.infAdProdField;
//            }
//            set
//            {
//                this.infAdProdField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string nItem
//        {
//            get
//            {
//                return this.nItemField;
//            }
//            set
//            {
//                this.nItemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProd
//    {

//        private string cProdField;

//        private string cEANField;

//        private string xProdField;

//        private string nCMField;

//        private string[] nVEField;

//        private string cESTField;

//        private string eXTIPIField;

//        private string cFOPField;

//        private string uComField;

//        private string qComField;

//        private string vUnComField;

//        private string vProdField;

//        private string cEANTribField;

//        private string uTribField;

//        private string qTribField;

//        private string vUnTribField;

//        private string vFreteField;

//        private string vSegField;

//        private string vDescField;

//        private string vOutroField;

//        private TNFeInfNFeDetProdIndTot indTotField;

//        private TNFeInfNFeDetProdDI[] diField;

//        private TNFeInfNFeDetProdDetExport[] detExportField;

//        private string xPedField;

//        private string nItemPedField;

//        private string nFCIField;

//        private object[] itemsField;

//        /// <remarks/>
//        public string cProd
//        {
//            get
//            {
//                return this.cProdField;
//            }
//            set
//            {
//                this.cProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEAN
//        {
//            get
//            {
//                return this.cEANField;
//            }
//            set
//            {
//                this.cEANField = value;
//            }
//        }

//        /// <remarks/>
//        public string xProd
//        {
//            get
//            {
//                return this.xProdField;
//            }
//            set
//            {
//                this.xProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string NCM
//        {
//            get
//            {
//                return this.nCMField;
//            }
//            set
//            {
//                this.nCMField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("NVE")]
//        public string[] NVE
//        {
//            get
//            {
//                return this.nVEField;
//            }
//            set
//            {
//                this.nVEField = value;
//            }
//        }

//        /// <remarks/>
//        public string CEST
//        {
//            get
//            {
//                return this.cESTField;
//            }
//            set
//            {
//                this.cESTField = value;
//            }
//        }

//        /// <remarks/>
//        public string EXTIPI
//        {
//            get
//            {
//                return this.eXTIPIField;
//            }
//            set
//            {
//                this.eXTIPIField = value;
//            }
//        }

//        /// <remarks/>
//        public string CFOP
//        {
//            get
//            {
//                return this.cFOPField;
//            }
//            set
//            {
//                this.cFOPField = value;
//            }
//        }

//        /// <remarks/>
//        public string uCom
//        {
//            get
//            {
//                return this.uComField;
//            }
//            set
//            {
//                this.uComField = value;
//            }
//        }

//        /// <remarks/>
//        public string qCom
//        {
//            get
//            {
//                return this.qComField;
//            }
//            set
//            {
//                this.qComField = value;
//            }
//        }

//        /// <remarks/>
//        public string vUnCom
//        {
//            get
//            {
//                return this.vUnComField;
//            }
//            set
//            {
//                this.vUnComField = value;
//            }
//        }

//        /// <remarks/>
//        public string vProd
//        {
//            get
//            {
//                return this.vProdField;
//            }
//            set
//            {
//                this.vProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEANTrib
//        {
//            get
//            {
//                return this.cEANTribField;
//            }
//            set
//            {
//                this.cEANTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string uTrib
//        {
//            get
//            {
//                return this.uTribField;
//            }
//            set
//            {
//                this.uTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTrib
//        {
//            get
//            {
//                return this.qTribField;
//            }
//            set
//            {
//                this.qTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string vUnTrib
//        {
//            get
//            {
//                return this.vUnTribField;
//            }
//            set
//            {
//                this.vUnTribField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFrete
//        {
//            get
//            {
//                return this.vFreteField;
//            }
//            set
//            {
//                this.vFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vSeg
//        {
//            get
//            {
//                return this.vSegField;
//            }
//            set
//            {
//                this.vSegField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdIndTot indTot
//        {
//            get
//            {
//                return this.indTotField;
//            }
//            set
//            {
//                this.indTotField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("DI")]
//        public TNFeInfNFeDetProdDI[] DI
//        {
//            get
//            {
//                return this.diField;
//            }
//            set
//            {
//                this.diField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("detExport")]
//        public TNFeInfNFeDetProdDetExport[] detExport
//        {
//            get
//            {
//                return this.detExportField;
//            }
//            set
//            {
//                this.detExportField = value;
//            }
//        }

//        /// <remarks/>
//        public string xPed
//        {
//            get
//            {
//                return this.xPedField;
//            }
//            set
//            {
//                this.xPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string nItemPed
//        {
//            get
//            {
//                return this.nItemPedField;
//            }
//            set
//            {
//                this.nItemPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string nFCI
//        {
//            get
//            {
//                return this.nFCIField;
//            }
//            set
//            {
//                this.nFCIField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
//        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
//        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
//        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDI
//    {

//        private string nDIField;

//        private string dDIField;

//        private string xLocDesembField;

//        private TUfEmi uFDesembField;

//        private string dDesembField;

//        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;

//        private string vAFRMMField;

//        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;

//        private string cNPJField;

//        private TUfEmi uFTerceiroField;

//        private bool uFTerceiroFieldSpecified;

//        private string cExportadorField;

//        private TNFeInfNFeDetProdDIAdi[] adiField;

//        /// <remarks/>
//        public string nDI
//        {
//            get
//            {
//                return this.nDIField;
//            }
//            set
//            {
//                this.nDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string dDI
//        {
//            get
//            {
//                return this.dDIField;
//            }
//            set
//            {
//                this.dDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocDesemb
//        {
//            get
//            {
//                return this.xLocDesembField;
//            }
//            set
//            {
//                this.xLocDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UFDesemb
//        {
//            get
//            {
//                return this.uFDesembField;
//            }
//            set
//            {
//                this.uFDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public string dDesemb
//        {
//            get
//            {
//                return this.dDesembField;
//            }
//            set
//            {
//                this.dDesembField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp
//        {
//            get
//            {
//                return this.tpViaTranspField;
//            }
//            set
//            {
//                this.tpViaTranspField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAFRMM
//        {
//            get
//            {
//                return this.vAFRMMField;
//            }
//            set
//            {
//                this.vAFRMMField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio
//        {
//            get
//            {
//                return this.tpIntermedioField;
//            }
//            set
//            {
//                this.tpIntermedioField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TUfEmi UFTerceiro
//        {
//            get
//            {
//                return this.uFTerceiroField;
//            }
//            set
//            {
//                this.uFTerceiroField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool UFTerceiroSpecified
//        {
//            get
//            {
//                return this.uFTerceiroFieldSpecified;
//            }
//            set
//            {
//                this.uFTerceiroFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string cExportador
//        {
//            get
//            {
//                return this.cExportadorField;
//            }
//            set
//            {
//                this.cExportadorField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("adi")]
//        public TNFeInfNFeDetProdDIAdi[] adi
//        {
//            get
//            {
//                return this.adiField;
//            }
//            set
//            {
//                this.adiField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDIAdi
//    {

//        private string nAdicaoField;

//        private string nSeqAdicField;

//        private string cFabricanteField;

//        private string vDescDIField;

//        private string nDrawField;

//        /// <remarks/>
//        public string nAdicao
//        {
//            get
//            {
//                return this.nAdicaoField;
//            }
//            set
//            {
//                this.nAdicaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSeqAdic
//        {
//            get
//            {
//                return this.nSeqAdicField;
//            }
//            set
//            {
//                this.nSeqAdicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cFabricante
//        {
//            get
//            {
//                return this.cFabricanteField;
//            }
//            set
//            {
//                this.cFabricanteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescDI
//        {
//            get
//            {
//                return this.vDescDIField;
//            }
//            set
//            {
//                this.vDescDIField = value;
//            }
//        }

//        /// <remarks/>
//        public string nDraw
//        {
//            get
//            {
//                return this.nDrawField;
//            }
//            set
//            {
//                this.nDrawField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDetExport
//    {

//        private string nDrawField;

//        private TNFeInfNFeDetProdDetExportExportInd exportIndField;

//        /// <remarks/>
//        public string nDraw
//        {
//            get
//            {
//                return this.nDrawField;
//            }
//            set
//            {
//                this.nDrawField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdDetExportExportInd exportInd
//        {
//            get
//            {
//                return this.exportIndField;
//            }
//            set
//            {
//                this.exportIndField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdDetExportExportInd
//    {

//        private string nREField;

//        private string chNFeField;

//        private string qExportField;

//        /// <remarks/>
//        public string nRE
//        {
//            get
//            {
//                return this.nREField;
//            }
//            set
//            {
//                this.nREField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public string qExport
//        {
//            get
//            {
//                return this.qExportField;
//            }
//            set
//            {
//                this.qExportField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdArma
//    {

//        private TNFeInfNFeDetProdArmaTpArma tpArmaField;

//        private string nSerieField;

//        private string nCanoField;

//        private string descrField;

//        /// <remarks/>
//        public TNFeInfNFeDetProdArmaTpArma tpArma
//        {
//            get
//            {
//                return this.tpArmaField;
//            }
//            set
//            {
//                this.tpArmaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSerie
//        {
//            get
//            {
//                return this.nSerieField;
//            }
//            set
//            {
//                this.nSerieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nCano
//        {
//            get
//            {
//                return this.nCanoField;
//            }
//            set
//            {
//                this.nCanoField = value;
//            }
//        }

//        /// <remarks/>
//        public string descr
//        {
//            get
//            {
//                return this.descrField;
//            }
//            set
//            {
//                this.descrField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdComb
//    {

//        private string cProdANPField;

//        private string pMixGNField;

//        private string cODIFField;

//        private string qTempField;

//        private TUf uFConsField;

//        private TNFeInfNFeDetProdCombCIDE cIDEField;

//        private TNFeInfNFeDetProdCombEncerrante encerranteField;

//        /// <remarks/>
//        public string cProdANP
//        {
//            get
//            {
//                return this.cProdANPField;
//            }
//            set
//            {
//                this.cProdANPField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMixGN
//        {
//            get
//            {
//                return this.pMixGNField;
//            }
//            set
//            {
//                this.pMixGNField = value;
//            }
//        }

//        /// <remarks/>
//        public string CODIF
//        {
//            get
//            {
//                return this.cODIFField;
//            }
//            set
//            {
//                this.cODIFField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTemp
//        {
//            get
//            {
//                return this.qTempField;
//            }
//            set
//            {
//                this.qTempField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UFCons
//        {
//            get
//            {
//                return this.uFConsField;
//            }
//            set
//            {
//                this.uFConsField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdCombCIDE CIDE
//        {
//            get
//            {
//                return this.cIDEField;
//            }
//            set
//            {
//                this.cIDEField = value;
//            }
//        }

//        public TNFeInfNFeDetProdCombEncerrante encerrante
//        {
//            get
//            {
//                return this.encerranteField;
//            }
//            set
//            {
//                this.encerranteField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdCombEncerrante
//    {

//        private string nBicoField;

//        private string nBombaField;

//        private string nTanqueField;

//        private string vEncIniField;

//        private string vEncFinField;

//        /// <remarks/>
//        public string nBico
//        {
//            get
//            {
//                return this.nBicoField;
//            }
//            set
//            {
//                this.nBicoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nBomba
//        {
//            get
//            {
//                return this.nBombaField;
//            }
//            set
//            {
//                this.nBombaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nTanque
//        {
//            get
//            {
//                return this.nTanqueField;
//            }
//            set
//            {
//                this.nTanqueField = value;
//            }
//        }

//        /// <remarks/>
//        public string vEncIni
//        {
//            get
//            {
//                return this.vEncIniField;
//            }
//            set
//            {
//                this.vEncIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string vEncFin
//        {
//            get
//            {
//                return this.vEncFinField;
//            }
//            set
//            {
//                this.vEncFinField = value;
//            }
//        }
//    }


//    ///// <remarks/>
//    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    //[System.SerializableAttribute()]
//    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    //public enum TcProdANP
//    //{

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203073")]
//    //    Item110203073,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204001")]
//    //    Item110204001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204002")]
//    //    Item110204002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101027")]
//    //    Item140101027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101026")]
//    //    Item140101026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101005")]
//    //    Item740101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101004")]
//    //    Item740101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101001")]
//    //    Item740101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101006")]
//    //    Item740101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101002")]
//    //    Item740101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203083")]
//    //    Item110203083,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("910101001")]
//    //    Item910101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103001")]
//    //    Item110103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101001")]
//    //    Item330101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203091")]
//    //    Item110203091,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204001")]
//    //    Item120204001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106001")]
//    //    Item110106001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120206001")]
//    //    Item120206001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101001")]
//    //    Item110101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101042")]
//    //    Item110101042,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810201001")]
//    //    Item810201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204003")]
//    //    Item110204003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201005")]
//    //    Item330201005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201006")]
//    //    Item330201006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201004")]
//    //    Item330201004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105001")]
//    //    Item110105001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203072")]
//    //    Item110203072,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203001")]
//    //    Item110203001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201001")]
//    //    Item110201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101002")]
//    //    Item110101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203002")]
//    //    Item110203002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205010")]
//    //    Item120205010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203003")]
//    //    Item110203003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204004")]
//    //    Item110204004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204005")]
//    //    Item110204005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204006")]
//    //    Item110204006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204007")]
//    //    Item110204007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204008")]
//    //    Item110204008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204009")]
//    //    Item110204009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204010")]
//    //    Item110204010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204011")]
//    //    Item110204011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105027")]
//    //    Item110105027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103003")]
//    //    Item110103003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103002")]
//    //    Item110103002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105002")]
//    //    Item110105002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205001")]
//    //    Item110205001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120203002")]
//    //    Item120203002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205001")]
//    //    Item120205001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203004")]
//    //    Item110203004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120203001")]
//    //    Item120203001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530102001")]
//    //    Item530102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101002")]
//    //    Item530101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108001")]
//    //    Item110108001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105017")]
//    //    Item110105017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206019")]
//    //    Item110206019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205023")]
//    //    Item110205023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203092")]
//    //    Item110203092,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201002")]
//    //    Item110201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120202001")]
//    //    Item120202001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101003")]
//    //    Item110101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101004")]
//    //    Item110101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103004")]
//    //    Item110103004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103005")]
//    //    Item110103005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101005")]
//    //    Item110101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204012")]
//    //    Item110204012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204013")]
//    //    Item110204013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204014")]
//    //    Item110204014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110102001")]
//    //    Item110102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120207003")]
//    //    Item120207003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201003")]
//    //    Item110201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201004")]
//    //    Item110201004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201005")]
//    //    Item110201005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201006")]
//    //    Item110201006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206001")]
//    //    Item110206001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205002")]
//    //    Item110205002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203005")]
//    //    Item110203005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205003")]
//    //    Item110205003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201001")]
//    //    Item330201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206002")]
//    //    Item110206002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101006")]
//    //    Item110101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101007")]
//    //    Item110101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101038")]
//    //    Item110101038,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205002")]
//    //    Item120205002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101001")]
//    //    Item820101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101010")]
//    //    Item820101010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101999")]
//    //    Item820101999,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206003")]
//    //    Item110206003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201007")]
//    //    Item110201007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120201001")]
//    //    Item120201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201008")]
//    //    Item110201008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103017")]
//    //    Item110103017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205004")]
//    //    Item110205004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203077")]
//    //    Item110203077,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101008")]
//    //    Item110101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203006")]
//    //    Item110203006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203007")]
//    //    Item110203007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201009")]
//    //    Item110201009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203008")]
//    //    Item110203008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203009")]
//    //    Item110203009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203010")]
//    //    Item110203010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120203004")]
//    //    Item120203004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206004")]
//    //    Item110206004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101009")]
//    //    Item610101009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205003")]
//    //    Item120205003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205005")]
//    //    Item110205005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203092")]
//    //    Item1102030921,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204015")]
//    //    Item110204015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210202003")]
//    //    Item210202003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210202001")]
//    //    Item210202001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210202002")]
//    //    Item210202002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105018")]
//    //    Item110105018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203011")]
//    //    Item110203011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203012")]
//    //    Item110203012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101009")]
//    //    Item110101009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104001")]
//    //    Item110104001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104006")]
//    //    Item110104006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106010")]
//    //    Item110106010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202007")]
//    //    Item110202007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106002")]
//    //    Item110106002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110111002")]
//    //    Item110111002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103006")]
//    //    Item110103006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105003")]
//    //    Item110105003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201010")]
//    //    Item110201010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201011")]
//    //    Item110201011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201012")]
//    //    Item110201012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101010")]
//    //    Item110101010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101011")]
//    //    Item110101011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108002")]
//    //    Item110108002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107001")]
//    //    Item110107001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120202002")]
//    //    Item120202002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106003")]
//    //    Item110106003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108003")]
//    //    Item110108003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203085")]
//    //    Item110203085,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201013")]
//    //    Item110201013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207001")]
//    //    Item110207001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105023")]
//    //    Item110105023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101012")]
//    //    Item110101012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201014")]
//    //    Item110201014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620501002")]
//    //    Item620501002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620501001")]
//    //    Item620501001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101005")]
//    //    Item610101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101006")]
//    //    Item610101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101001")]
//    //    Item530101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101020")]
//    //    Item530101020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101018")]
//    //    Item530101018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205006")]
//    //    Item110205006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201015")]
//    //    Item110201015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203013")]
//    //    Item110203013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202001")]
//    //    Item110202001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120104001")]
//    //    Item120104001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120102001")]
//    //    Item120102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205024")]
//    //    Item110205024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205009")]
//    //    Item120205009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("540101002")]
//    //    Item540101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("540101001")]
//    //    Item540101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107002")]
//    //    Item110107002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620601003")]
//    //    Item620601003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201016")]
//    //    Item110201016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101013")]
//    //    Item110101013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120207001")]
//    //    Item120207001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206020")]
//    //    Item110206020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104008")]
//    //    Item110104008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201017")]
//    //    Item110201017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108004")]
//    //    Item110108004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201018")]
//    //    Item110201018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201007")]
//    //    Item330201007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205007")]
//    //    Item110205007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203086")]
//    //    Item110203086,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205008")]
//    //    Item110205008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("340101002")]
//    //    Item340101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202002")]
//    //    Item130202002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("430101002")]
//    //    Item430101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202003")]
//    //    Item130202003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("560101002")]
//    //    Item560101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202004")]
//    //    Item130202004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101026")]
//    //    Item820101026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101032")]
//    //    Item820101032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101027")]
//    //    Item820101027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101004")]
//    //    Item820101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101005")]
//    //    Item820101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101022")]
//    //    Item820101022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101007")]
//    //    Item820101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101002")]
//    //    Item820101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101009")]
//    //    Item820101009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101008")]
//    //    Item820101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101014")]
//    //    Item820101014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101006")]
//    //    Item820101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101016")]
//    //    Item820101016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101015")]
//    //    Item820101015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101014")]
//    //    Item8201010141,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101006")]
//    //    Item8201010061,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101031")]
//    //    Item820101031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101030")]
//    //    Item820101030,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101016")]
//    //    Item8201010161,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101015")]
//    //    Item8201010151,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101025")]
//    //    Item820101025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101007")]
//    //    Item8201010071,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101002")]
//    //    Item8201010021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101026")]
//    //    Item8201010261,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101009")]
//    //    Item8201010091,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101008")]
//    //    Item8201010081,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101027")]
//    //    Item8201010271,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101007")]
//    //    Item8201010072,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101002")]
//    //    Item8201010022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101028")]
//    //    Item820101028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101029")]
//    //    Item820101029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101009")]
//    //    Item8201010092,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101008")]
//    //    Item8201010082,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101011")]
//    //    Item820101011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101003")]
//    //    Item820101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101013")]
//    //    Item820101013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101012")]
//    //    Item820101012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101017")]
//    //    Item820101017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101018")]
//    //    Item820101018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101019")]
//    //    Item820101019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101020")]
//    //    Item820101020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101021")]
//    //    Item820101021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101003")]
//    //    Item330101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202006")]
//    //    Item130202006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203014")]
//    //    Item110203014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420201001")]
//    //    Item420201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420201003")]
//    //    Item420201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204010")]
//    //    Item120204010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103007")]
//    //    Item110103007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204017")]
//    //    Item110204017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204051")]
//    //    Item110204051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204018")]
//    //    Item110204018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205022")]
//    //    Item110205022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203069")]
//    //    Item110203069,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203015")]
//    //    Item110203015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206005")]
//    //    Item110206005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203016")]
//    //    Item110203016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203017")]
//    //    Item110203017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203018")]
//    //    Item110203018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203088")]
//    //    Item110203088,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203019")]
//    //    Item110203019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101003")]
//    //    Item530101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530101019")]
//    //    Item530101019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101014")]
//    //    Item110101014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101002")]
//    //    Item620101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("720101001")]
//    //    Item720101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("720101002")]
//    //    Item720101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205004")]
//    //    Item120205004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203079")]
//    //    Item110203079,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203020")]
//    //    Item110203020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201019")]
//    //    Item110201019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203021")]
//    //    Item110203021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108005")]
//    //    Item110108005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101015")]
//    //    Item110101015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104002")]
//    //    Item110104002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101016")]
//    //    Item110101016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101007")]
//    //    Item620101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140102001")]
//    //    Item140102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105004")]
//    //    Item110105004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107003")]
//    //    Item110107003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203095")]
//    //    Item110203095,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210301001")]
//    //    Item210301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810102001")]
//    //    Item810102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810102004")]
//    //    Item810102004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810102002")]
//    //    Item810102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130201002")]
//    //    Item130201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810102003")]
//    //    Item810102003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810101002")]
//    //    Item810101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810101001")]
//    //    Item810101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810101003")]
//    //    Item810101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210301002")]
//    //    Item210301002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201010")]
//    //    Item330201010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204016")]
//    //    Item110204016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105005")]
//    //    Item110105005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105006")]
//    //    Item110105006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105007")]
//    //    Item110105007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104003")]
//    //    Item110104003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206006")]
//    //    Item110206006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206007")]
//    //    Item110206007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203022")]
//    //    Item110203022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204019")]
//    //    Item110204019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206008")]
//    //    Item110206008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206009")]
//    //    Item110206009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101043")]
//    //    Item110101043,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201020")]
//    //    Item110201020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203023")]
//    //    Item110203023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101017")]
//    //    Item110101017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101018")]
//    //    Item110101018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210302004")]
//    //    Item210302004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210101001")]
//    //    Item210101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210302003")]
//    //    Item210302003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210302002")]
//    //    Item210302002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210204001")]
//    //    Item210204001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101003")]
//    //    Item220101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101004")]
//    //    Item220101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101002")]
//    //    Item220101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101001")]
//    //    Item220101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101005")]
//    //    Item220101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220101006")]
//    //    Item220101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202001")]
//    //    Item130202001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202005")]
//    //    Item130202005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("520101001")]
//    //    Item520101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320101001")]
//    //    Item320101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320101003")]
//    //    Item320101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320101002")]
//    //    Item320101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320103001")]
//    //    Item320103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320102002")]
//    //    Item320102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320102001")]
//    //    Item320102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320102004")]
//    //    Item320102004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320102003")]
//    //    Item320102003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320201001")]
//    //    Item320201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320201002")]
//    //    Item320201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220102001")]
//    //    Item220102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320301002")]
//    //    Item320301002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204020")]
//    //    Item110204020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203024")]
//    //    Item110203024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205012")]
//    //    Item120205012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207002")]
//    //    Item110207002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203087")]
//    //    Item110203087,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("730101002")]
//    //    Item730101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210203001")]
//    //    Item210203001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210203002")]
//    //    Item210203002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104005")]
//    //    Item110104005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101023")]
//    //    Item140101023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101024")]
//    //    Item140101024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101025")]
//    //    Item140101025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("650101001")]
//    //    Item650101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207003")]
//    //    Item110207003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201021")]
//    //    Item110201021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103013")]
//    //    Item110103013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201022")]
//    //    Item110201022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203025")]
//    //    Item110203025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203026")]
//    //    Item110203026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206011")]
//    //    Item110206011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206010")]
//    //    Item110206010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203027")]
//    //    Item110203027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203028")]
//    //    Item110203028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203028")]
//    //    Item1102030281,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101008")]
//    //    Item330101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101002")]
//    //    Item330101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101009")]
//    //    Item330101009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101001")]
//    //    Item620101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610201001")]
//    //    Item610201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610201002")]
//    //    Item610201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610201003")]
//    //    Item610201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("710101001")]
//    //    Item710101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203074")]
//    //    Item110203074,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201023")]
//    //    Item110201023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103008")]
//    //    Item110103008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203029")]
//    //    Item110203029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205005")]
//    //    Item120205005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204021")]
//    //    Item110204021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204022")]
//    //    Item110204022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204023")]
//    //    Item110204023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101004")]
//    //    Item620101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101005")]
//    //    Item620101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101010")]
//    //    Item330101010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202002")]
//    //    Item110202002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202003")]
//    //    Item110202003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207004")]
//    //    Item110207004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101046")]
//    //    Item110101046,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204024")]
//    //    Item110204024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110113001")]
//    //    Item110113001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105015")]
//    //    Item110105015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101019")]
//    //    Item110101019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103015")]
//    //    Item110103015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205025")]
//    //    Item110205025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204025")]
//    //    Item110204025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204026")]
//    //    Item110204026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204027")]
//    //    Item110204027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204009")]
//    //    Item120204009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205026")]
//    //    Item110205026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204028")]
//    //    Item110204028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204029")]
//    //    Item110204029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203080")]
//    //    Item110203080,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120207004")]
//    //    Item120207004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203030")]
//    //    Item110203030,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105025")]
//    //    Item110105025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203031")]
//    //    Item110203031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203084")]
//    //    Item110203084,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203032")]
//    //    Item110203032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204030")]
//    //    Item110204030,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205009")]
//    //    Item110205009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104004")]
//    //    Item110104004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201024")]
//    //    Item110201024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201025")]
//    //    Item110201025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201026")]
//    //    Item110201026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201027")]
//    //    Item110201027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201028")]
//    //    Item110201028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201029")]
//    //    Item110201029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201030")]
//    //    Item110201030,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207005")]
//    //    Item110207005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204031")]
//    //    Item110204031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207006")]
//    //    Item110207006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201031")]
//    //    Item110201031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201032")]
//    //    Item110201032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201033")]
//    //    Item110201033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204002")]
//    //    Item120204002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101020")]
//    //    Item110101020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("220102002")]
//    //    Item220102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105008")]
//    //    Item110105008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203033")]
//    //    Item110203033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105009")]
//    //    Item110105009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201034")]
//    //    Item110201034,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203034")]
//    //    Item110203034,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203035")]
//    //    Item110203035,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("640201001")]
//    //    Item640201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205011")]
//    //    Item120205011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101021")]
//    //    Item110101021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120103001")]
//    //    Item120103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203036")]
//    //    Item110203036,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204003")]
//    //    Item120204003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201035")]
//    //    Item110201035,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204032")]
//    //    Item110204032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101022")]
//    //    Item110101022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201036")]
//    //    Item110201036,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101023")]
//    //    Item110101023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101024")]
//    //    Item110101024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101025")]
//    //    Item110101025,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101039")]
//    //    Item110101039,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204033")]
//    //    Item110204033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120207002")]
//    //    Item120207002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202004")]
//    //    Item110202004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202005")]
//    //    Item110202005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203037")]
//    //    Item110203037,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203037")]
//    //    Item1102030371,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201037")]
//    //    Item110201037,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203078")]
//    //    Item110203078,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120203005")]
//    //    Item120203005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204010")]
//    //    Item1202040101,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201038")]
//    //    Item110201038,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201039")]
//    //    Item110201039,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120101001")]
//    //    Item120101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201040")]
//    //    Item110201040,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201041")]
//    //    Item110201041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101007")]
//    //    Item740101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420201003")]
//    //    Item4202010031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("640101001")]
//    //    Item640101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205027")]
//    //    Item110205027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103009")]
//    //    Item110103009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103010")]
//    //    Item110103010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205010")]
//    //    Item110205010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101018")]
//    //    Item8201010181,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101017")]
//    //    Item8201010171,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101006")]
//    //    Item8201010062,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101014")]
//    //    Item8201010142,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101006")]
//    //    Item8201010063,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101016")]
//    //    Item8201010162,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101015")]
//    //    Item8201010152,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101006")]
//    //    Item8201010064,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101005")]
//    //    Item8201010051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101004")]
//    //    Item8201010041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101003")]
//    //    Item8201010031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101011")]
//    //    Item8201010111,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101003")]
//    //    Item8201010032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101013")]
//    //    Item8201010131,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101012")]
//    //    Item8201010121,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101002")]
//    //    Item8201010023,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101007")]
//    //    Item8201010073,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101002")]
//    //    Item8201010024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101009")]
//    //    Item8201010093,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101008")]
//    //    Item8201010083,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110301001")]
//    //    Item110301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110208001")]
//    //    Item110208001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203038")]
//    //    Item110203038,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203089")]
//    //    Item110203089,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201042")]
//    //    Item110201042,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101026")]
//    //    Item110101026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620502001")]
//    //    Item620502001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203039")]
//    //    Item110203039,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202008")]
//    //    Item110202008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204034")]
//    //    Item110204034,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110110001")]
//    //    Item110110001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("310102001")]
//    //    Item310102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("310103001")]
//    //    Item310103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("310101001")]
//    //    Item310101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101027")]
//    //    Item110101027,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205011")]
//    //    Item110205011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201062")]
//    //    Item110201062,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203040")]
//    //    Item110203040,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101002")]
//    //    Item610101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610401002")]
//    //    Item610401002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101003")]
//    //    Item610101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610401003")]
//    //    Item610401003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101004")]
//    //    Item610101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610401004")]
//    //    Item610401004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203041")]
//    //    Item110203041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203042")]
//    //    Item110203042,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203043")]
//    //    Item110203043,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203094")]
//    //    Item110203094,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203044")]
//    //    Item110203044,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203044")]
//    //    Item1102030441,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("430101001")]
//    //    Item430101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206021")]
//    //    Item110206021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204004")]
//    //    Item120204004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110207007")]
//    //    Item110207007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203045")]
//    //    Item110203045,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201043")]
//    //    Item110201043,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203046")]
//    //    Item110203046,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203047")]
//    //    Item110203047,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203048")]
//    //    Item110203048,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203081")]
//    //    Item110203081,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("430101004")]
//    //    Item430101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510101003")]
//    //    Item510101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510101001")]
//    //    Item510101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510101002")]
//    //    Item510101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510102003")]
//    //    Item510102003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510102001")]
//    //    Item510102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510102002")]
//    //    Item510102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510201001")]
//    //    Item510201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510201002")]
//    //    Item510201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510201003")]
//    //    Item510201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510301003")]
//    //    Item510301003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101015")]
//    //    Item140101015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101009")]
//    //    Item140101009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101016")]
//    //    Item140101016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101017")]
//    //    Item140101017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101005")]
//    //    Item140101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101014")]
//    //    Item140101014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101018")]
//    //    Item140101018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101006")]
//    //    Item140101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101028")]
//    //    Item140101028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101021")]
//    //    Item140101021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101010")]
//    //    Item140101010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101012")]
//    //    Item140101012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101013")]
//    //    Item140101013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101001")]
//    //    Item140101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101011")]
//    //    Item140101011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101003")]
//    //    Item140101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101002")]
//    //    Item140101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101008")]
//    //    Item140101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101007")]
//    //    Item140101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101019")]
//    //    Item140101019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101004")]
//    //    Item140101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("560101001")]
//    //    Item560101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420105001")]
//    //    Item420105001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101005")]
//    //    Item420101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101004")]
//    //    Item420101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101003")]
//    //    Item420101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102006")]
//    //    Item420102006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102005")]
//    //    Item420102005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102004")]
//    //    Item420102004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102003")]
//    //    Item420102003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420104001")]
//    //    Item420104001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101033")]
//    //    Item820101033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101034")]
//    //    Item820101034,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101011")]
//    //    Item8201010112,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101003")]
//    //    Item8201010033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101028")]
//    //    Item8201010281,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101029")]
//    //    Item8201010291,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101013")]
//    //    Item8201010132,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("820101012")]
//    //    Item8201010122,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420301003")]
//    //    Item420301003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101005")]
//    //    Item4201010051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101002")]
//    //    Item420101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101001")]
//    //    Item420101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101003")]
//    //    Item4201010031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101004")]
//    //    Item4201010041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420101003")]
//    //    Item4201010032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420201001")]
//    //    Item4202010011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420201002")]
//    //    Item420201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102005")]
//    //    Item4201020051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102004")]
//    //    Item4201020041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102002")]
//    //    Item420102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102001")]
//    //    Item420102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102003")]
//    //    Item4201020031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102003")]
//    //    Item4201020032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420202001")]
//    //    Item420202001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420301001")]
//    //    Item420301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420102006")]
//    //    Item4201020061,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420103002")]
//    //    Item420103002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420103001")]
//    //    Item420103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420103003")]
//    //    Item420103003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610601001")]
//    //    Item610601001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610701001")]
//    //    Item610701001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510301002")]
//    //    Item510301002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620601001")]
//    //    Item620601001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("660101001")]
//    //    Item660101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620401001")]
//    //    Item620401001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620301001")]
//    //    Item620301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620201001")]
//    //    Item620201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("630101001")]
//    //    Item630101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110202006")]
//    //    Item110202006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203093")]
//    //    Item110203093,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204035")]
//    //    Item110204035,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203049")]
//    //    Item110203049,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201044")]
//    //    Item110201044,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201045")]
//    //    Item110201045,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206012")]
//    //    Item110206012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120203003")]
//    //    Item120203003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320301001")]
//    //    Item320301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("320103002")]
//    //    Item320103002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("650101002")]
//    //    Item650101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("310102002")]
//    //    Item310102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("640401001")]
//    //    Item640401001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101029")]
//    //    Item140101029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("740101003")]
//    //    Item740101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("810201002")]
//    //    Item810201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530103001")]
//    //    Item530103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("340101003")]
//    //    Item340101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("430101003")]
//    //    Item430101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("560101003")]
//    //    Item560101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210302001")]
//    //    Item210302001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210204002")]
//    //    Item210204002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130201001")]
//    //    Item130201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("530104001")]
//    //    Item530104001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101022")]
//    //    Item140101022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101999")]
//    //    Item140101999,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610201004")]
//    //    Item610201004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("510301001")]
//    //    Item510301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("420301002")]
//    //    Item420301002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620601004")]
//    //    Item620601004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620505001")]
//    //    Item620505001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610501001")]
//    //    Item610501001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101008")]
//    //    Item620101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101010")]
//    //    Item610101010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110208002")]
//    //    Item110208002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110110002")]
//    //    Item110110002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202008")]
//    //    Item130202008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("410103001")]
//    //    Item410103001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610301002")]
//    //    Item610301002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610302001")]
//    //    Item610302001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101007")]
//    //    Item330101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201009")]
//    //    Item330201009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("730101001")]
//    //    Item730101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203050")]
//    //    Item110203050,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101028")]
//    //    Item110101028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101049")]
//    //    Item110101049,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101029")]
//    //    Item110101029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101030")]
//    //    Item110101030,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110104007")]
//    //    Item110104007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110111001")]
//    //    Item110111001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205006")]
//    //    Item120205006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203051")]
//    //    Item110203051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101050")]
//    //    Item110101050,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105028")]
//    //    Item110105028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105016")]
//    //    Item110105016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201046")]
//    //    Item110201046,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106007")]
//    //    Item110106007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101031")]
//    //    Item110101031,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203082")]
//    //    Item110203082,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610301001")]
//    //    Item610301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101032")]
//    //    Item110101032,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101047")]
//    //    Item110101047,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105021")]
//    //    Item110105021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105010")]
//    //    Item110105010,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101003")]
//    //    Item620101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210201001")]
//    //    Item210201001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210201002")]
//    //    Item210201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("210201003")]
//    //    Item210201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105020")]
//    //    Item110105020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105022")]
//    //    Item110105022,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205012")]
//    //    Item110205012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620601002")]
//    //    Item620601002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120206003")]
//    //    Item120206003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204036")]
//    //    Item110204036,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204037")]
//    //    Item110204037,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204038")]
//    //    Item110204038,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("410101001")]
//    //    Item410101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("410101002")]
//    //    Item410101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("410102001")]
//    //    Item410102001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("410102002")]
//    //    Item410102002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103014")]
//    //    Item110103014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203052")]
//    //    Item110203052,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101005")]
//    //    Item330101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101006")]
//    //    Item330101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205029")]
//    //    Item110205029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203053")]
//    //    Item110203053,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204008")]
//    //    Item120204008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203054")]
//    //    Item110203054,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204039")]
//    //    Item110204039,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201047")]
//    //    Item110201047,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201048")]
//    //    Item110201048,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103011")]
//    //    Item110103011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("340101001")]
//    //    Item340101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("550101001")]
//    //    Item550101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("550101005")]
//    //    Item550101005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("550101002")]
//    //    Item550101002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("550101003")]
//    //    Item550101003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("550101004")]
//    //    Item550101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130202007")]
//    //    Item130202007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105011")]
//    //    Item110105011,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201049")]
//    //    Item110201049,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101048")]
//    //    Item110101048,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101033")]
//    //    Item110101033,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101040")]
//    //    Item110101040,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101045")]
//    //    Item110101045,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101041")]
//    //    Item110101041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204040")]
//    //    Item110204040,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105019")]
//    //    Item110105019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204041")]
//    //    Item110204041,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105024")]
//    //    Item110105024,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203070")]
//    //    Item110203070,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203055")]
//    //    Item110203055,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204042")]
//    //    Item110204042,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203075")]
//    //    Item110203075,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201050")]
//    //    Item110201050,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201051")]
//    //    Item110201051,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201052")]
//    //    Item110201052,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201053")]
//    //    Item110201053,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120201002")]
//    //    Item120201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105029")]
//    //    Item110105029,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203056")]
//    //    Item110203056,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204043")]
//    //    Item110204043,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203090")]
//    //    Item110203090,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("140101020")]
//    //    Item140101020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103018")]
//    //    Item110103018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106004")]
//    //    Item110106004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106005")]
//    //    Item110106005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106006")]
//    //    Item110106006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205028")]
//    //    Item110205028,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105012")]
//    //    Item110105012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204005")]
//    //    Item120204005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205013")]
//    //    Item110205013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201054")]
//    //    Item110201054,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101044")]
//    //    Item110101044,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204044")]
//    //    Item110204044,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203057")]
//    //    Item110203057,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203058")]
//    //    Item110203058,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120206002")]
//    //    Item120206002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120206004")]
//    //    Item120206004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201008")]
//    //    Item330201008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330101004")]
//    //    Item330101004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204045")]
//    //    Item110204045,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204046")]
//    //    Item110204046,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201063")]
//    //    Item110201063,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206013")]
//    //    Item110206013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203059")]
//    //    Item110203059,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203060")]
//    //    Item110203060,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101001")]
//    //    Item610101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610401001")]
//    //    Item610401001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206015")]
//    //    Item110206015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206014")]
//    //    Item110206014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204052")]
//    //    Item110204052,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205015")]
//    //    Item110205015,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205014")]
//    //    Item110205014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204047")]
//    //    Item110204047,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205016")]
//    //    Item110205016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203061")]
//    //    Item110203061,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205017")]
//    //    Item110205017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106009")]
//    //    Item110106009,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203062")]
//    //    Item110203062,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206016")]
//    //    Item110206016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205007")]
//    //    Item120205007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120201003")]
//    //    Item120201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620101006")]
//    //    Item620101006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120205008")]
//    //    Item120205008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204006")]
//    //    Item120204006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201055")]
//    //    Item110201055,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201056")]
//    //    Item110201056,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201057")]
//    //    Item110201057,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103016")]
//    //    Item110103016,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205018")]
//    //    Item110205018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107005")]
//    //    Item110107005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201002")]
//    //    Item330201002,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620504001")]
//    //    Item620504001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("620503001")]
//    //    Item620503001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101034")]
//    //    Item110101034,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107004")]
//    //    Item110107004,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101007")]
//    //    Item610101007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("610101008")]
//    //    Item610101008,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105014")]
//    //    Item110105014,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205019")]
//    //    Item110205019,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110103012")]
//    //    Item110103012,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203063")]
//    //    Item110203063,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120204007")]
//    //    Item120204007,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204048")]
//    //    Item110204048,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105013")]
//    //    Item110105013,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204049")]
//    //    Item110204049,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206017")]
//    //    Item110206017,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110109001")]
//    //    Item110109001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110107006")]
//    //    Item110107006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201059")]
//    //    Item110201059,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201058")]
//    //    Item110201058,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("640301001")]
//    //    Item640301001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101035")]
//    //    Item110101035,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101036")]
//    //    Item110101036,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110101037")]
//    //    Item110101037,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205020")]
//    //    Item110205020,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("120207005")]
//    //    Item120207005,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110206018")]
//    //    Item110206018,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110108006")]
//    //    Item110108006,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203076")]
//    //    Item110203076,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110205021")]
//    //    Item110205021,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("330201003")]
//    //    Item330201003,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("130101001")]
//    //    Item130101001,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201060")]
//    //    Item110201060,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203071")]
//    //    Item110203071,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203065")]
//    //    Item110203065,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203064")]
//    //    Item110203064,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110204050")]
//    //    Item110204050,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203066")]
//    //    Item110203066,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203067")]
//    //    Item110203067,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110201061")]
//    //    Item110201061,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110203068")]
//    //    Item110203068,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110105026")]
//    //    Item110105026,

//    //    /// <remarks/>
//    //    [System.Xml.Serialization.XmlEnumAttribute("110106008")]
//    //    Item110106008,
//    //}

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdCombCIDE
//    {

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vCIDEField;

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCIDE
//        {
//            get
//            {
//                return this.vCIDEField;
//            }
//            set
//            {
//                this.vCIDEField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdMed
//    {

//        private string nLoteField;

//        private string qLoteField;

//        private string dFabField;

//        private string dValField;

//        private string vPMCField;

//        /// <remarks/>
//        public string nLote
//        {
//            get
//            {
//                return this.nLoteField;
//            }
//            set
//            {
//                this.nLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public string qLote
//        {
//            get
//            {
//                return this.qLoteField;
//            }
//            set
//            {
//                this.qLoteField = value;
//            }
//        }

//        /// <remarks/>
//        public string dFab
//        {
//            get
//            {
//                return this.dFabField;
//            }
//            set
//            {
//                this.dFabField = value;
//            }
//        }

//        /// <remarks/>
//        public string dVal
//        {
//            get
//            {
//                return this.dValField;
//            }
//            set
//            {
//                this.dValField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPMC
//        {
//            get
//            {
//                return this.vPMCField;
//            }
//            set
//            {
//                this.vPMCField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetProdVeicProd
//    {

//        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;

//        private string chassiField;

//        private string cCorField;

//        private string xCorField;

//        private string potField;

//        private string cilinField;

//        private string pesoLField;

//        private string pesoBField;

//        private string nSerieField;

//        private string tpCombField;

//        private string nMotorField;

//        private string cMTField;

//        private string distField;

//        private string anoModField;

//        private string anoFabField;

//        private string tpPintField;

//        private string tpVeicField;

//        private string espVeicField;

//        private TNFeInfNFeDetProdVeicProdVIN vINField;

//        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;

//        private string cModField;

//        private string cCorDENATRANField;

//        private string lotaField;

//        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdTpOp tpOp
//        {
//            get
//            {
//                return this.tpOpField;
//            }
//            set
//            {
//                this.tpOpField = value;
//            }
//        }

//        /// <remarks/>
//        public string chassi
//        {
//            get
//            {
//                return this.chassiField;
//            }
//            set
//            {
//                this.chassiField = value;
//            }
//        }

//        /// <remarks/>
//        public string cCor
//        {
//            get
//            {
//                return this.cCorField;
//            }
//            set
//            {
//                this.cCorField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCor
//        {
//            get
//            {
//                return this.xCorField;
//            }
//            set
//            {
//                this.xCorField = value;
//            }
//        }

//        /// <remarks/>
//        public string pot
//        {
//            get
//            {
//                return this.potField;
//            }
//            set
//            {
//                this.potField = value;
//            }
//        }

//        /// <remarks/>
//        public string cilin
//        {
//            get
//            {
//                return this.cilinField;
//            }
//            set
//            {
//                this.cilinField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoL
//        {
//            get
//            {
//                return this.pesoLField;
//            }
//            set
//            {
//                this.pesoLField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoB
//        {
//            get
//            {
//                return this.pesoBField;
//            }
//            set
//            {
//                this.pesoBField = value;
//            }
//        }

//        /// <remarks/>
//        public string nSerie
//        {
//            get
//            {
//                return this.nSerieField;
//            }
//            set
//            {
//                this.nSerieField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpComb
//        {
//            get
//            {
//                return this.tpCombField;
//            }
//            set
//            {
//                this.tpCombField = value;
//            }
//        }

//        /// <remarks/>
//        public string nMotor
//        {
//            get
//            {
//                return this.nMotorField;
//            }
//            set
//            {
//                this.nMotorField = value;
//            }
//        }

//        /// <remarks/>
//        public string CMT
//        {
//            get
//            {
//                return this.cMTField;
//            }
//            set
//            {
//                this.cMTField = value;
//            }
//        }

//        /// <remarks/>
//        public string dist
//        {
//            get
//            {
//                return this.distField;
//            }
//            set
//            {
//                this.distField = value;
//            }
//        }

//        /// <remarks/>
//        public string anoMod
//        {
//            get
//            {
//                return this.anoModField;
//            }
//            set
//            {
//                this.anoModField = value;
//            }
//        }

//        /// <remarks/>
//        public string anoFab
//        {
//            get
//            {
//                return this.anoFabField;
//            }
//            set
//            {
//                this.anoFabField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpPint
//        {
//            get
//            {
//                return this.tpPintField;
//            }
//            set
//            {
//                this.tpPintField = value;
//            }
//        }

//        /// <remarks/>
//        public string tpVeic
//        {
//            get
//            {
//                return this.tpVeicField;
//            }
//            set
//            {
//                this.tpVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public string espVeic
//        {
//            get
//            {
//                return this.espVeicField;
//            }
//            set
//            {
//                this.espVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdVIN VIN
//        {
//            get
//            {
//                return this.vINField;
//            }
//            set
//            {
//                this.vINField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
//        {
//            get
//            {
//                return this.condVeicField;
//            }
//            set
//            {
//                this.condVeicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMod
//        {
//            get
//            {
//                return this.cModField;
//            }
//            set
//            {
//                this.cModField = value;
//            }
//        }

//        /// <remarks/>
//        public string cCorDENATRAN
//        {
//            get
//            {
//                return this.cCorDENATRANField;
//            }
//            set
//            {
//                this.cCorDENATRANField = value;
//            }
//        }

//        /// <remarks/>
//        public string lota
//        {
//            get
//            {
//                return this.lotaField;
//            }
//            set
//            {
//                this.lotaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetProdVeicProdTpRest tpRest
//        {
//            get
//            {
//                return this.tpRestField;
//            }
//            set
//            {
//                this.tpRestField = value;
//            }
//        }
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImposto
//    {

//        private string vTotTribField;

//        private object[] itemsField;

//        private TNFeInfNFeDetImpostoPIS pISField;

//        private TNFeInfNFeDetImpostoPISST pISSTField;

//        private TNFeInfNFeDetImpostoCOFINS cOFINSField;

//        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;

//        private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;

//        /// <remarks/>
//        public string vTotTrib
//        {
//            get
//            {
//                return this.vTotTribField;
//            }
//            set
//            {
//                this.vTotTribField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
//        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
//        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
//        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPIS PIS
//        {
//            get
//            {
//                return this.pISField;
//            }
//            set
//            {
//                this.pISField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISST PISST
//        {
//            get
//            {
//                return this.pISSTField;
//            }
//            set
//            {
//                this.pISSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINS COFINS
//        {
//            get
//            {
//                return this.cOFINSField;
//            }
//            set
//            {
//                this.cOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSST COFINSST
//        {
//            get
//            {
//                return this.cOFINSSTField;
//            }
//            set
//            {
//                this.cOFINSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest
//        {
//            get
//            {
//                return this.iCMSUFDestField;
//            }
//            set
//            {
//                this.iCMSUFDestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
//        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS00
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS00CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }
//    }







//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS10
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }
//    }





//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS20
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMSField;

//        private bool motDesICMSFieldSpecified;
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool motDesICMSSpecified
//        {
//            get
//            {
//                return this.motDesICMSFieldSpecified;
//            }
//            set
//            {
//                this.motDesICMSFieldSpecified = value;
//            }
//        }


//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }



//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS30
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;

//        private bool motDesICMSFieldSpecified;
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool motDesICMSSpecified
//        {
//            get
//            {
//                return this.motDesICMSFieldSpecified;
//            }
//            set
//            {
//                this.motDesICMSFieldSpecified = value;
//            }
//        }



//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("30")]
//        Item30,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS40
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;

//        private bool motDesICMSFieldSpecified;


//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS40CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool motDesICMSSpecified
//        {
//            get
//            {
//                return this.motDesICMSFieldSpecified;
//            }
//            set
//            {
//                this.motDesICMSFieldSpecified = value;
//            }
//        }

//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS40CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("40")]
//        Item40,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("41")]
//        Item41,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
//    {

//        /// <remarks/>
//        /// Táxi;
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        /// Produtor Agropecuário;
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        /// Frotista/Locadora;
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        /// Diplomático/Consular;
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        /// Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 – CONTRAN e suas alterações);
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        /// SUFRAMA;
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,

//        /// <remarks/>
//        /// Venda a órgão Público;
//        [System.Xml.Serialization.XmlEnumAttribute("8")]
//        Item8,

//        /// <remarks/>
//        /// Outros
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        /// Deficiente Condutor
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        /// Deficiente não condutor
//        [System.Xml.Serialization.XmlEnumAttribute("11")]
//        Item11,

//        /// <remarks/>
//        /// Olimpíadas Rio 2016
//        [System.Xml.Serialization.XmlEnumAttribute("16")]
//        Item16,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS51
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;

//        private bool modBCFieldSpecified;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSOpField;

//        private string pDifField;

//        private string vICMSDifField;

//        private string vICMSField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS51CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool modBCSpecified
//        {
//            get
//            {
//                return this.modBCFieldSpecified;
//            }
//            set
//            {
//                this.modBCFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSOp
//        {
//            get
//            {
//                return this.vICMSOpField;
//            }
//            set
//            {
//                this.vICMSOpField = value;
//            }
//        }

//        /// <remarks/>
//        public string pDif
//        {
//            get
//            {
//                return this.pDifField;
//            }
//            set
//            {
//                this.pDifField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDif
//        {
//            get
//            {
//                return this.vICMSDifField;
//            }
//            set
//            {
//                this.vICMSDifField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS51CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS60
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;

//        private string vBCSTRetField;

//        private string vICMSSTRetField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS60CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS60CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS70
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;

//        private string pRedBCField;

//        private string vBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMSField;

//        private bool motDesICMSFieldSpecified;
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool motDesICMSSpecified
//        {
//            get
//            {
//                return this.motDesICMSFieldSpecified;
//            }
//            set
//            {
//                this.motDesICMSFieldSpecified = value;
//            }
//        }



//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMS90
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string vICMSDesonField;

//        private TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMSField;

//        private bool motDesICMSFieldSpecified;
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool motDesICMSSpecified
//        {
//            get
//            {
//                return this.motDesICMSFieldSpecified;
//            }
//            set
//            {
//                this.motDesICMSFieldSpecified = value;
//            }
//        }



//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90CST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS
//        {
//            get
//            {
//                return this.motDesICMSField;
//            }
//            set
//            {
//                this.motDesICMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90CST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSPart
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;

//        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string pBCOpField;

//        private TUf uFSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pBCOp
//        {
//            get
//            {
//                return this.pBCOpField;
//            }
//            set
//            {
//                this.pBCOpField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UFST
//        {
//            get
//            {
//                return this.uFSTField;
//            }
//            set
//            {
//                this.uFSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("90")]
//        Item90,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("101")]
//        Item101,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("102")]
//        Item102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("103")]
//        Item103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("300")]
//        Item300,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("400")]
//        Item400,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("201")]
//        Item201,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("202")]
//        Item202,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("203")]
//        Item203,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;

//        private string vBCSTRetField;

//        private string vICMSSTRetField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("500")]
//        Item500,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;

//        private string vBCField;

//        private string pRedBCField;

//        private string pICMSField;

//        private string vICMSField;

//        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;

//        private string pMVASTField;

//        private string pRedBCSTField;

//        private string vBCSTField;

//        private string pICMSSTField;

//        private string vICMSSTField;

//        private string pCredSNField;

//        private string vCredICMSSNField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
//        {
//            get
//            {
//                return this.cSOSNField;
//            }
//            set
//            {
//                this.cSOSNField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
//        {
//            get
//            {
//                return this.modBCField;
//            }
//            set
//            {
//                this.modBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBC
//        {
//            get
//            {
//                return this.pRedBCField;
//            }
//            set
//            {
//                this.pRedBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMS
//        {
//            get
//            {
//                return this.pICMSField;
//            }
//            set
//            {
//                this.pICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
//        {
//            get
//            {
//                return this.modBCSTField;
//            }
//            set
//            {
//                this.modBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pMVAST
//        {
//            get
//            {
//                return this.pMVASTField;
//            }
//            set
//            {
//                this.pMVASTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pRedBCST
//        {
//            get
//            {
//                return this.pRedBCSTField;
//            }
//            set
//            {
//                this.pRedBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSST
//        {
//            get
//            {
//                return this.pICMSSTField;
//            }
//            set
//            {
//                this.pICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSST
//        {
//            get
//            {
//                return this.vICMSSTField;
//            }
//            set
//            {
//                this.vICMSSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCredSN
//        {
//            get
//            {
//                return this.pCredSNField;
//            }
//            set
//            {
//                this.pCredSNField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCredICMSSN
//        {
//            get
//            {
//                return this.vCredICMSSNField;
//            }
//            set
//            {
//                this.vCredICMSSNField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("900")]
//        Item900,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSICMSST
//    {

//        private Torig origField;

//        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;

//        private string vBCSTRetField;

//        private string vICMSSTRetField;

//        private string vBCSTDestField;

//        private string vICMSSTDestField;

//        /// <remarks/>
//        public Torig orig
//        {
//            get
//            {
//                return this.origField;
//            }
//            set
//            {
//                this.origField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTRet
//        {
//            get
//            {
//                return this.vBCSTRetField;
//            }
//            set
//            {
//                this.vBCSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTRet
//        {
//            get
//            {
//                return this.vICMSSTRetField;
//            }
//            set
//            {
//                this.vICMSSTRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCSTDest
//        {
//            get
//            {
//                return this.vBCSTDestField;
//            }
//            set
//            {
//                this.vBCSTDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSSTDest
//        {
//            get
//            {
//                return this.vICMSSTDestField;
//            }
//            set
//            {
//                this.vICMSSTDestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("41")]
//        Item41,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoII
//    {

//        private string vBCField;

//        private string vDespAduField;

//        private string vIIField;

//        private string vIOFField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDespAdu
//        {
//            get
//            {
//                return this.vDespAduField;
//            }
//            set
//            {
//                this.vDespAduField = value;
//            }
//        }

//        /// <remarks/>
//        public string vII
//        {
//            get
//            {
//                return this.vIIField;
//            }
//            set
//            {
//                this.vIIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIOF
//        {
//            get
//            {
//                return this.vIOFField;
//            }
//            set
//            {
//                this.vIOFField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpi
//    {

//        private string clEnqField;

//        private string cNPJProdField;

//        private string cSeloField;

//        private string qSeloField;

//        private string cEnqField;

//        private object itemField;

//        /// <remarks/>
//        public string clEnq
//        {
//            get
//            {
//                return this.clEnqField;
//            }
//            set
//            {
//                this.clEnqField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJProd
//        {
//            get
//            {
//                return this.cNPJProdField;
//            }
//            set
//            {
//                this.cNPJProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string cSelo
//        {
//            get
//            {
//                return this.cSeloField;
//            }
//            set
//            {
//                this.cSeloField = value;
//            }
//        }

//        /// <remarks/>
//        public string qSelo
//        {
//            get
//            {
//                return this.qSeloField;
//            }
//            set
//            {
//                this.qSeloField = value;
//            }
//        }

//        /// <remarks/>
//        public string cEnq
//        {
//            get
//            {
//                return this.cEnqField;
//            }
//            set
//            {
//                this.cEnqField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TIpiIPINT))]
//        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TIpiIPITrib))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpiIPINT
//    {

//        private TIpiIPINTCST cSTField;

//        /// <remarks/>
//        public TIpiIPINTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TIpiIPINTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TIpiIPITrib
//    {

//        private TIpiIPITribCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType[] itemsElementNameField;

//        private string vIPIField;

//        /// <remarks/>
//        public TIpiIPITribCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIPI
//        {
//            get
//            {
//                return this.vIPIField;
//            }
//            set
//            {
//                this.vIPIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TIpiIPITribCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("00")]
//        Item00,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType
//    {

//        /// <remarks/>
//        pIPI,

//        /// <remarks/>
//        qUnid,

//        /// <remarks/>
//        vBC,

//        /// <remarks/>
//        vUnid,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoISSQN
//    {

//        private string vBCField;

//        private string vAliqField;

//        private string vISSQNField;

//        private string cMunFGField;

//        private TCListServ cListServField;

//        private string vDeducaoField;

//        private string vOutroField;

//        private string vDescIncondField;

//        private string vDescCondField;

//        private string vISSRetField;

//        private TNFeInfNFeDetImpostoISSQNIndISS indISSField;

//        private string cServicoField;

//        private string cMunField;

//        private Tpais cPaisField;

//        private bool cPaisFieldSpecified;

//        private string nProcessoField;

//        private TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivoField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliq
//        {
//            get
//            {
//                return this.vAliqField;
//            }
//            set
//            {
//                this.vAliqField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSQN
//        {
//            get
//            {
//                return this.vISSQNField;
//            }
//            set
//            {
//                this.vISSQNField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }

//        /// <remarks/>
//        public TCListServ cListServ
//        {
//            get
//            {
//                return this.cListServField;
//            }
//            set
//            {
//                this.cListServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDeducao
//        {
//            get
//            {
//                return this.vDeducaoField;
//            }
//            set
//            {
//                this.vDeducaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescIncond
//        {
//            get
//            {
//                return this.vDescIncondField;
//            }
//            set
//            {
//                this.vDescIncondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescCond
//        {
//            get
//            {
//                return this.vDescCondField;
//            }
//            set
//            {
//                this.vDescCondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSRet
//        {
//            get
//            {
//                return this.vISSRetField;
//            }
//            set
//            {
//                this.vISSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoISSQNIndISS indISS
//        {
//            get
//            {
//                return this.indISSField;
//            }
//            set
//            {
//                this.indISSField = value;
//            }
//        }

//        /// <remarks/>
//        public string cServico
//        {
//            get
//            {
//                return this.cServicoField;
//            }
//            set
//            {
//                this.cServicoField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMun
//        {
//            get
//            {
//                return this.cMunField;
//            }
//            set
//            {
//                this.cMunField = value;
//            }
//        }

//        /// <remarks/>
//        public Tpais cPais
//        {
//            get
//            {
//                return this.cPaisField;
//            }
//            set
//            {
//                this.cPaisField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cPaisSpecified
//        {
//            get
//            {
//                return this.cPaisFieldSpecified;
//            }
//            set
//            {
//                this.cPaisFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string nProcesso
//        {
//            get
//            {
//                return this.nProcessoField;
//            }
//            set
//            {
//                this.nProcessoField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo
//        {
//            get
//            {
//                return this.indIncentivoField;
//            }
//            set
//            {
//                this.indIncentivoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TCListServ
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.01")]
//        Item0101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.02")]
//        Item0102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.03")]
//        Item0103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.04")]
//        Item0104,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.05")]
//        Item0105,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.06")]
//        Item0106,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.07")]
//        Item0107,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01.08")]
//        Item0108,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02.01")]
//        Item0201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.02")]
//        Item0302,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.03")]
//        Item0303,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.04")]
//        Item0304,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03.05")]
//        Item0305,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.01")]
//        Item0401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.02")]
//        Item0402,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.03")]
//        Item0403,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.04")]
//        Item0404,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.05")]
//        Item0405,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.06")]
//        Item0406,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.07")]
//        Item0407,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.08")]
//        Item0408,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.09")]
//        Item0409,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.10")]
//        Item0410,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.11")]
//        Item0411,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.12")]
//        Item0412,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.13")]
//        Item0413,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.14")]
//        Item0414,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.15")]
//        Item0415,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.16")]
//        Item0416,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.17")]
//        Item0417,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.18")]
//        Item0418,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.19")]
//        Item0419,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.20")]
//        Item0420,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.21")]
//        Item0421,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.22")]
//        Item0422,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04.23")]
//        Item0423,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.01")]
//        Item0501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.02")]
//        Item0502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.03")]
//        Item0503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.04")]
//        Item0504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.05")]
//        Item0505,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.06")]
//        Item0506,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.07")]
//        Item0507,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.08")]
//        Item0508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05.09")]
//        Item0509,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.01")]
//        Item0601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.02")]
//        Item0602,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.03")]
//        Item0603,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.04")]
//        Item0604,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06.05")]
//        Item0605,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.01")]
//        Item0701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.02")]
//        Item0702,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.03")]
//        Item0703,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.04")]
//        Item0704,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.05")]
//        Item0705,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.06")]
//        Item0706,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.07")]
//        Item0707,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.08")]
//        Item0708,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.09")]
//        Item0709,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.10")]
//        Item0710,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.11")]
//        Item0711,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.12")]
//        Item0712,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.13")]
//        Item0713,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.16")]
//        Item0716,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.17")]
//        Item0717,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.18")]
//        Item0718,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.19")]
//        Item0719,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.20")]
//        Item0720,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.21")]
//        Item0721,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07.22")]
//        Item0722,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08.01")]
//        Item0801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08.02")]
//        Item0802,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.01")]
//        Item0901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.02")]
//        Item0902,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09.03")]
//        Item0903,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.01")]
//        Item1001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.02")]
//        Item1002,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.03")]
//        Item1003,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.04")]
//        Item1004,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.05")]
//        Item1005,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.06")]
//        Item1006,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.07")]
//        Item1007,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.08")]
//        Item1008,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.09")]
//        Item1009,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10.10")]
//        Item1010,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.01")]
//        Item1101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.02")]
//        Item1102,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.03")]
//        Item1103,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11.04")]
//        Item1104,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.01")]
//        Item1201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.02")]
//        Item1202,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.03")]
//        Item1203,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.04")]
//        Item1204,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.05")]
//        Item1205,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.06")]
//        Item1206,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.07")]
//        Item1207,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.08")]
//        Item1208,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.09")]
//        Item1209,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.10")]
//        Item1210,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.11")]
//        Item1211,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.12")]
//        Item1212,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.13")]
//        Item1213,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.14")]
//        Item1214,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.15")]
//        Item1215,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.16")]
//        Item1216,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12.17")]
//        Item1217,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.02")]
//        Item1302,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.03")]
//        Item1303,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.04")]
//        Item1304,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13.05")]
//        Item1305,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.01")]
//        Item1401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.02")]
//        Item1402,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.03")]
//        Item1403,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.04")]
//        Item1404,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.05")]
//        Item1405,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.06")]
//        Item1406,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.07")]
//        Item1407,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.08")]
//        Item1408,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.09")]
//        Item1409,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.10")]
//        Item1410,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.11")]
//        Item1411,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.12")]
//        Item1412,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("14.13")]
//        Item1413,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.01")]
//        Item1501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.02")]
//        Item1502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.03")]
//        Item1503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.04")]
//        Item1504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.05")]
//        Item1505,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.06")]
//        Item1506,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.07")]
//        Item1507,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.08")]
//        Item1508,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.09")]
//        Item1509,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.10")]
//        Item1510,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.11")]
//        Item1511,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.12")]
//        Item1512,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.13")]
//        Item1513,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.14")]
//        Item1514,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.15")]
//        Item1515,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.16")]
//        Item1516,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.17")]
//        Item1517,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("15.18")]
//        Item1518,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("16.01")]
//        Item1601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.01")]
//        Item1701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.02")]
//        Item1702,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.03")]
//        Item1703,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.04")]
//        Item1704,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.05")]
//        Item1705,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.06")]
//        Item1706,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.08")]
//        Item1708,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.09")]
//        Item1709,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.10")]
//        Item1710,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.11")]
//        Item1711,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.12")]
//        Item1712,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.13")]
//        Item1713,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.14")]
//        Item1714,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.15")]
//        Item1715,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.16")]
//        Item1716,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.17")]
//        Item1717,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.18")]
//        Item1718,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.19")]
//        Item1719,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.20")]
//        Item1720,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.21")]
//        Item1721,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.22")]
//        Item1722,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.23")]
//        Item1723,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("17.24")]
//        Item1724,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("18.01")]
//        Item1801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("19.01")]
//        Item1901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.01")]
//        Item2001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.02")]
//        Item2002,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("20.03")]
//        Item2003,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("21.01")]
//        Item2101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("22.01")]
//        Item2201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("23.01")]
//        Item2301,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("24.01")]
//        Item2401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.01")]
//        Item2501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.02")]
//        Item2502,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.03")]
//        Item2503,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("25.04")]
//        Item2504,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("26.01")]
//        Item2601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("27.01")]
//        Item2701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("28.01")]
//        Item2801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("29.01")]
//        Item2901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("30.01")]
//        Item3001,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("31.01")]
//        Item3101,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("32.01")]
//        Item3201,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("33.01")]
//        Item3301,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("34.01")]
//        Item3401,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("35.01")]
//        Item3501,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("36.01")]
//        Item3601,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("37.01")]
//        Item3701,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("38.01")]
//        Item3801,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("39.01")]
//        Item3901,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("40.01")]
//        Item4001,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoISSQNIndISS
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("7")]
//        Item7,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPIS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
//        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
//        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
//        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISAliq
//    {

//        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;

//        private string vBCField;

//        private string pPISField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISAliqCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pPIS
//        {
//            get
//            {
//                return this.pPISField;
//            }
//            set
//            {
//                this.pPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISAliqCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISNT
//    {

//        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISNTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISNTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06")]
//        Item06,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07")]
//        Item07,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08")]
//        Item08,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09")]
//        Item09,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISOutr
//    {

//        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType1[] itemsElementNameField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISOutrCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType1[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISOutrCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("56")]
//        Item56,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("61")]
//        Item61,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("62")]
//        Item62,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("63")]
//        Item63,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("64")]
//        Item64,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("65")]
//        Item65,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("66")]
//        Item66,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("67")]
//        Item67,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("71")]
//        Item71,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("72")]
//        Item72,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("73")]
//        Item73,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("74")]
//        Item74,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("75")]
//        Item75,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("98")]
//        Item98,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType1
//    {

//        /// <remarks/>
//        pPIS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISPISQtde
//    {

//        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vPISField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoPISST
//    {

//        private string[] itemsField;

//        private ItemsChoiceType2[] itemsElementNameField;

//        private string vPISField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType2[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType2
//    {

//        /// <remarks/>
//        pPIS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINS
//    {

//        private object itemField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
//        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;

//        private string vBCField;

//        private string pCOFINSField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string pCOFINS
//        {
//            get
//            {
//                return this.pCOFINSField;
//            }
//            set
//            {
//                this.pCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("06")]
//        Item06,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("07")]
//        Item07,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("08")]
//        Item08,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("09")]
//        Item09,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;

//        private string[] itemsField;

//        private ItemsChoiceType3[] itemsElementNameField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType3[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("49")]
//        Item49,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("50")]
//        Item50,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("51")]
//        Item51,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("52")]
//        Item52,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("53")]
//        Item53,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("54")]
//        Item54,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("55")]
//        Item55,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("56")]
//        Item56,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("60")]
//        Item60,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("61")]
//        Item61,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("62")]
//        Item62,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("63")]
//        Item63,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("64")]
//        Item64,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("65")]
//        Item65,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("66")]
//        Item66,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("67")]
//        Item67,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("70")]
//        Item70,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("71")]
//        Item71,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("72")]
//        Item72,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("73")]
//        Item73,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("74")]
//        Item74,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("75")]
//        Item75,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("98")]
//        Item98,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType3
//    {

//        /// <remarks/>
//        pCOFINS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
//    {

//        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;

//        private string qBCProdField;

//        private string vAliqProdField;

//        private string vCOFINSField;

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
//        {
//            get
//            {
//                return this.cSTField;
//            }
//            set
//            {
//                this.cSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string qBCProd
//        {
//            get
//            {
//                return this.qBCProdField;
//            }
//            set
//            {
//                this.qBCProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vAliqProd
//        {
//            get
//            {
//                return this.vAliqProdField;
//            }
//            set
//            {
//                this.vAliqProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoCOFINSST
//    {

//        private string[] itemsField;

//        private ItemsChoiceType4[] itemsElementNameField;

//        private string vCOFINSField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public string[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType4[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType4
//    {

//        /// <remarks/>
//        pCOFINS,

//        /// <remarks/>
//        qBCProd,

//        /// <remarks/>
//        vAliqProd,

//        /// <remarks/>
//        vBC,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoDevol
//    {

//        private string pDevolField;

//        private TNFeInfNFeDetImpostoDevolIPI iPIField;

//        /// <remarks/>
//        public string pDevol
//        {
//            get
//            {
//                return this.pDevolField;
//            }
//            set
//            {
//                this.pDevolField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeDetImpostoDevolIPI IPI
//        {
//            get
//            {
//                return this.iPIField;
//            }
//            set
//            {
//                this.iPIField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoDevolIPI
//    {

//        private string vIPIDevolField;

//        /// <remarks/>
//        public string vIPIDevol
//        {
//            get
//            {
//                return this.vIPIDevolField;
//            }
//            set
//            {
//                this.vIPIDevolField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotal
//    {

//        private TNFeInfNFeTotalICMSTot iCMSTotField;

//        private TNFeInfNFeTotalISSQNtot iSSQNtotField;

//        private TNFeInfNFeTotalRetTrib retTribField;

//        /// <remarks/>
//        public TNFeInfNFeTotalICMSTot ICMSTot
//        {
//            get
//            {
//                return this.iCMSTotField;
//            }
//            set
//            {
//                this.iCMSTotField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalISSQNtot ISSQNtot
//        {
//            get
//            {
//                return this.iSSQNtotField;
//            }
//            set
//            {
//                this.iSSQNtotField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalRetTrib retTrib
//        {
//            get
//            {
//                return this.retTribField;
//            }
//            set
//            {
//                this.retTribField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalICMSTot
//    {

//        private string vBCField;

//        private string vICMSField;

//        private string vICMSDesonField;

//        private string vFCPUFDestField;

//        private string vICMSUFDestField;

//        private string vICMSUFRemetField;

//        private string vBCSTField;

//        private string vSTField;

//        private string vProdField;

//        private string vFreteField;

//        private string vSegField;

//        private string vDescField;

//        private string vIIField;

//        private string vIPIField;

//        private string vPISField;

//        private string vCOFINSField;

//        private string vOutroField;

//        private string vNFField;

//        private string vTotTribField;

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMS
//        {
//            get
//            {
//                return this.vICMSField;
//            }
//            set
//            {
//                this.vICMSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSDeson
//        {
//            get
//            {
//                return this.vICMSDesonField;
//            }
//            set
//            {
//                this.vICMSDesonField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPUFDest
//        {
//            get
//            {
//                return this.vFCPUFDestField;
//            }
//            set
//            {
//                this.vFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFDest
//        {
//            get
//            {
//                return this.vICMSUFDestField;
//            }
//            set
//            {
//                this.vICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFRemet
//        {
//            get
//            {
//                return this.vICMSUFRemetField;
//            }
//            set
//            {
//                this.vICMSUFRemetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCST
//        {
//            get
//            {
//                return this.vBCSTField;
//            }
//            set
//            {
//                this.vBCSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vST
//        {
//            get
//            {
//                return this.vSTField;
//            }
//            set
//            {
//                this.vSTField = value;
//            }
//        }

//        /// <remarks/>
//        public string vProd
//        {
//            get
//            {
//                return this.vProdField;
//            }
//            set
//            {
//                this.vProdField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFrete
//        {
//            get
//            {
//                return this.vFreteField;
//            }
//            set
//            {
//                this.vFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public string vSeg
//        {
//            get
//            {
//                return this.vSegField;
//            }
//            set
//            {
//                this.vSegField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vII
//        {
//            get
//            {
//                return this.vIIField;
//            }
//            set
//            {
//                this.vIIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIPI
//        {
//            get
//            {
//                return this.vIPIField;
//            }
//            set
//            {
//                this.vIPIField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vNF
//        {
//            get
//            {
//                return this.vNFField;
//            }
//            set
//            {
//                this.vNFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vTotTrib
//        {
//            get
//            {
//                return this.vTotTribField;
//            }
//            set
//            {
//                this.vTotTribField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalISSQNtot
//    {

//        private string vServField;

//        private string vBCField;

//        private string vISSField;

//        private string vPISField;

//        private string vCOFINSField;

//        private string dCompetField;

//        private string vDeducaoField;

//        private string vOutroField;

//        private string vDescIncondField;

//        private string vDescCondField;

//        private string vISSRetField;

//        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;

//        private bool cRegTribFieldSpecified;

//        /// <remarks/>
//        public string vServ
//        {
//            get
//            {
//                return this.vServField;
//            }
//            set
//            {
//                this.vServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBC
//        {
//            get
//            {
//                return this.vBCField;
//            }
//            set
//            {
//                this.vBCField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISS
//        {
//            get
//            {
//                return this.vISSField;
//            }
//            set
//            {
//                this.vISSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPIS
//        {
//            get
//            {
//                return this.vPISField;
//            }
//            set
//            {
//                this.vPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vCOFINS
//        {
//            get
//            {
//                return this.vCOFINSField;
//            }
//            set
//            {
//                this.vCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string dCompet
//        {
//            get
//            {
//                return this.dCompetField;
//            }
//            set
//            {
//                this.dCompetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDeducao
//        {
//            get
//            {
//                return this.vDeducaoField;
//            }
//            set
//            {
//                this.vDeducaoField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOutro
//        {
//            get
//            {
//                return this.vOutroField;
//            }
//            set
//            {
//                this.vOutroField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescIncond
//        {
//            get
//            {
//                return this.vDescIncondField;
//            }
//            set
//            {
//                this.vDescIncondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDescCond
//        {
//            get
//            {
//                return this.vDescCondField;
//            }
//            set
//            {
//                this.vDescCondField = value;
//            }
//        }

//        /// <remarks/>
//        public string vISSRet
//        {
//            get
//            {
//                return this.vISSRetField;
//            }
//            set
//            {
//                this.vISSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib
//        {
//            get
//            {
//                return this.cRegTribField;
//            }
//            set
//            {
//                this.cRegTribField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool cRegTribSpecified
//        {
//            get
//            {
//                return this.cRegTribFieldSpecified;
//            }
//            set
//            {
//                this.cRegTribFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeTotalISSQNtotCRegTrib
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("4")]
//        Item4,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("5")]
//        Item5,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("6")]
//        Item6,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTotalRetTrib
//    {

//        private string vRetPISField;

//        private string vRetCOFINSField;

//        private string vRetCSLLField;

//        private string vBCIRRFField;

//        private string vIRRFField;

//        private string vBCRetPrevField;

//        private string vRetPrevField;

//        /// <remarks/>
//        public string vRetPIS
//        {
//            get
//            {
//                return this.vRetPISField;
//            }
//            set
//            {
//                this.vRetPISField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetCOFINS
//        {
//            get
//            {
//                return this.vRetCOFINSField;
//            }
//            set
//            {
//                this.vRetCOFINSField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetCSLL
//        {
//            get
//            {
//                return this.vRetCSLLField;
//            }
//            set
//            {
//                this.vRetCSLLField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCIRRF
//        {
//            get
//            {
//                return this.vBCIRRFField;
//            }
//            set
//            {
//                this.vBCIRRFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vIRRF
//        {
//            get
//            {
//                return this.vIRRFField;
//            }
//            set
//            {
//                this.vIRRFField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCRetPrev
//        {
//            get
//            {
//                return this.vBCRetPrevField;
//            }
//            set
//            {
//                this.vBCRetPrevField = value;
//            }
//        }

//        /// <remarks/>
//        public string vRetPrev
//        {
//            get
//            {
//                return this.vRetPrevField;
//            }
//            set
//            {
//                this.vRetPrevField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTransp
//    {

//        private TNFeInfNFeTranspModFrete modFreteField;

//        private TNFeInfNFeTranspTransporta transportaField;

//        private TNFeInfNFeTranspRetTransp retTranspField;

//        private object[] itemsField;

//        private ItemsChoiceType5[] itemsElementNameField;

//        private TNFeInfNFeTranspVol[] volField;

//        /// <remarks/>
//        public TNFeInfNFeTranspModFrete modFrete
//        {
//            get
//            {
//                return this.modFreteField;
//            }
//            set
//            {
//                this.modFreteField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTranspTransporta transporta
//        {
//            get
//            {
//                return this.transportaField;
//            }
//            set
//            {
//                this.transportaField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeTranspRetTransp retTransp
//        {
//            get
//            {
//                return this.retTranspField;
//            }
//            set
//            {
//                this.retTranspField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo))]
//        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
//        public object[] Items
//        {
//            get
//            {
//                return this.itemsField;
//            }
//            set
//            {
//                this.itemsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ItemsChoiceType5[] ItemsElementName
//        {
//            get
//            {
//                return this.itemsElementNameField;
//            }
//            set
//            {
//                this.itemsElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("vol")]
//        public TNFeInfNFeTranspVol[] vol
//        {
//            get
//            {
//                return this.volField;
//            }
//            set
//            {
//                this.volField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeTranspModFrete
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspTransporta
//    {

//        private string itemField;

//        private ITCTypeCNPJCPF itemElementNameField;

//        private string xNomeField;

//        private string ieField;

//        private string xEnderField;

//        private string xMunField;

//        private TUf ufField;

//        private bool ufFieldSpecified;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
//        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
//        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
//        public string Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public ITCTypeCNPJCPF ItemElementName
//        {
//            get
//            {
//                return this.itemElementNameField;
//            }
//            set
//            {
//                this.itemElementNameField = value;
//            }
//        }

//        /// <remarks/>
//        public string xNome
//        {
//            get
//            {
//                return this.xNomeField;
//            }
//            set
//            {
//                this.xNomeField = value;
//            }
//        }

//        /// <remarks/>
//        public string IE
//        {
//            get
//            {
//                return this.ieField;
//            }
//            set
//            {
//                this.ieField = value;
//            }
//        }

//        /// <remarks/>
//        public string xEnder
//        {
//            get
//            {
//                return this.xEnderField;
//            }
//            set
//            {
//                this.xEnderField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMun
//        {
//            get
//            {
//                return this.xMunField;
//            }
//            set
//            {
//                this.xMunField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool UFSpecified
//        {
//            get
//            {
//                return this.ufFieldSpecified;
//            }
//            set
//            {
//                this.ufFieldSpecified = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspRetTransp
//    {

//        private string vServField;

//        private string vBCRetField;

//        private string pICMSRetField;

//        private string vICMSRetField;

//        private string cFOPField;

//        private string cMunFGField;

//        /// <remarks/>
//        public string vServ
//        {
//            get
//            {
//                return this.vServField;
//            }
//            set
//            {
//                this.vServField = value;
//            }
//        }

//        /// <remarks/>
//        public string vBCRet
//        {
//            get
//            {
//                return this.vBCRetField;
//            }
//            set
//            {
//                this.vBCRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSRet
//        {
//            get
//            {
//                return this.pICMSRetField;
//            }
//            set
//            {
//                this.pICMSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSRet
//        {
//            get
//            {
//                return this.vICMSRetField;
//            }
//            set
//            {
//                this.vICMSRetField = value;
//            }
//        }

//        /// <remarks/>
//        public string CFOP
//        {
//            get
//            {
//                return this.cFOPField;
//            }
//            set
//            {
//                this.cFOPField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMunFG
//        {
//            get
//            {
//                return this.cMunFGField;
//            }
//            set
//            {
//                this.cMunFGField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TVeiculo
//    {

//        private string placaField;

//        private TUf ufField;

//        private string rNTCField;

//        /// <remarks/>
//        public string placa
//        {
//            get
//            {
//                return this.placaField;
//            }
//            set
//            {
//                this.placaField = value;
//            }
//        }

//        /// <remarks/>
//        public TUf UF
//        {
//            get
//            {
//                return this.ufField;
//            }
//            set
//            {
//                this.ufField = value;
//            }
//        }

//        /// <remarks/>
//        public string RNTC
//        {
//            get
//            {
//                return this.rNTCField;
//            }
//            set
//            {
//                this.rNTCField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
//    public enum ItemsChoiceType5
//    {

//        /// <remarks/>
//        balsa,

//        /// <remarks/>
//        reboque,

//        /// <remarks/>
//        vagao,

//        /// <remarks/>
//        veicTransp,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspVol
//    {

//        private string qVolField;

//        private string espField;

//        private string marcaField;

//        private string nVolField;

//        private string pesoLField;

//        private string pesoBField;

//        private TNFeInfNFeTranspVolLacres[] lacresField;

//        /// <remarks/>
//        public string qVol
//        {
//            get
//            {
//                return this.qVolField;
//            }
//            set
//            {
//                this.qVolField = value;
//            }
//        }

//        /// <remarks/>
//        public string esp
//        {
//            get
//            {
//                return this.espField;
//            }
//            set
//            {
//                this.espField = value;
//            }
//        }

//        /// <remarks/>
//        public string marca
//        {
//            get
//            {
//                return this.marcaField;
//            }
//            set
//            {
//                this.marcaField = value;
//            }
//        }

//        /// <remarks/>
//        public string nVol
//        {
//            get
//            {
//                return this.nVolField;
//            }
//            set
//            {
//                this.nVolField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoL
//        {
//            get
//            {
//                return this.pesoLField;
//            }
//            set
//            {
//                this.pesoLField = value;
//            }
//        }

//        /// <remarks/>
//        public string pesoB
//        {
//            get
//            {
//                return this.pesoBField;
//            }
//            set
//            {
//                this.pesoBField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("lacres")]
//        public TNFeInfNFeTranspVolLacres[] lacres
//        {
//            get
//            {
//                return this.lacresField;
//            }
//            set
//            {
//                this.lacresField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeTranspVolLacres
//    {

//        private string nLacreField;

//        /// <remarks/>
//        public string nLacre
//        {
//            get
//            {
//                return this.nLacreField;
//            }
//            set
//            {
//                this.nLacreField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobr
//    {

//        private TNFeInfNFeCobrFat fatField;

//        private TNFeInfNFeCobrDup[] dupField;

//        /// <remarks/>
//        public TNFeInfNFeCobrFat fat
//        {
//            get
//            {
//                return this.fatField;
//            }
//            set
//            {
//                this.fatField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("dup")]
//        public TNFeInfNFeCobrDup[] dup
//        {
//            get
//            {
//                return this.dupField;
//            }
//            set
//            {
//                this.dupField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobrFat
//    {

//        private string nFatField;

//        private string vOrigField;

//        private string vDescField;

//        private string vLiqField;

//        /// <remarks/>
//        public string nFat
//        {
//            get
//            {
//                return this.nFatField;
//            }
//            set
//            {
//                this.nFatField = value;
//            }
//        }

//        /// <remarks/>
//        public string vOrig
//        {
//            get
//            {
//                return this.vOrigField;
//            }
//            set
//            {
//                this.vOrigField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDesc
//        {
//            get
//            {
//                return this.vDescField;
//            }
//            set
//            {
//                this.vDescField = value;
//            }
//        }

//        /// <remarks/>
//        public string vLiq
//        {
//            get
//            {
//                return this.vLiqField;
//            }
//            set
//            {
//                this.vLiqField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCobrDup
//    {

//        private string nDupField;

//        private string dVencField;

//        private string vDupField;

//        /// <remarks/>
//        public string nDup
//        {
//            get
//            {
//                return this.nDupField;
//            }
//            set
//            {
//                this.nDupField = value;
//            }
//        }

//        /// <remarks/>
//        public string dVenc
//        {
//            get
//            {
//                return this.dVencField;
//            }
//            set
//            {
//                this.dVencField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDup
//        {
//            get
//            {
//                return this.vDupField;
//            }
//            set
//            {
//                this.vDupField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFePag
//    {

//        private TNFeInfNFePagTPag tPagField;

//        private string vPagField;

//        private TNFeInfNFePagCard cardField;

//        /// <remarks/>
//        public TNFeInfNFePagTPag tPag
//        {
//            get
//            {
//                return this.tPagField;
//            }
//            set
//            {
//                this.tPagField = value;
//            }
//        }

//        /// <remarks/>
//        public string vPag
//        {
//            get
//            {
//                return this.vPagField;
//            }
//            set
//            {
//                this.vPagField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFePagCard card
//        {
//            get
//            {
//                return this.cardField;
//            }
//            set
//            {
//                this.cardField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagTPag
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("05")]
//        Item05,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("10")]
//        Item10,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("11")]
//        Item11,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("12")]
//        Item12,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("13")]
//        Item13,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFePagCard
//    {
//        private TNFeInfNFePagCardTpIntegra tpIntegraField;

//        private bool tpIntegraFieldSpecified;

//        private string cNPJField;

//        private TNFeInfNFePagCardTBand tBandField;

//        private string cAutField;

//        /// <remarks/>
//        public TNFeInfNFePagCardTpIntegra tpIntegra
//        {
//            get
//            {
//                return this.tpIntegraField;
//            }
//            set
//            {
//                this.tpIntegraField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool tpIntegraSpecified
//        {
//            get
//            {
//                return this.tpIntegraFieldSpecified;
//            }
//            set
//            {
//                this.tpIntegraFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFePagCardTBand tBand
//        {
//            get
//            {
//                return this.tBandField;
//            }
//            set
//            {
//                this.tBandField = value;
//            }
//        }

//        /// <remarks/>
//        public string cAut
//        {
//            get
//            {
//                return this.cAutField;
//            }
//            set
//            {
//                this.cAutField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagCardTpIntegra
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,
//    }


//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFePagCardTBand
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("01")]
//        Item01,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("02")]
//        Item02,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("03")]
//        Item03,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("04")]
//        Item04,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("99")]
//        Item99,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdic
//    {

//        private string infAdFiscoField;

//        private string infCplField;

//        private TNFeInfNFeInfAdicObsCont[] obsContField;

//        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;

//        private TNFeInfNFeInfAdicProcRef[] procRefField;

//        /// <remarks/>
//        public string infAdFisco
//        {
//            get
//            {
//                return this.infAdFiscoField;
//            }
//            set
//            {
//                this.infAdFiscoField = value;
//            }
//        }

//        /// <remarks/>
//        public string infCpl
//        {
//            get
//            {
//                return this.infCplField;
//            }
//            set
//            {
//                this.infCplField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
//        public TNFeInfNFeInfAdicObsCont[] obsCont
//        {
//            get
//            {
//                return this.obsContField;
//            }
//            set
//            {
//                this.obsContField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
//        public TNFeInfNFeInfAdicObsFisco[] obsFisco
//        {
//            get
//            {
//                return this.obsFiscoField;
//            }
//            set
//            {
//                this.obsFiscoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("procRef")]
//        public TNFeInfNFeInfAdicProcRef[] procRef
//        {
//            get
//            {
//                return this.procRefField;
//            }
//            set
//            {
//                this.procRefField = value;
//            }
//        }
//    }
//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicObsCont
//    {

//        private string xTextoField;

//        private string xCampoField;

//        /// <remarks/>
//        public string xTexto
//        {
//            get
//            {
//                return this.xTextoField;
//            }
//            set
//            {
//                this.xTextoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string xCampo
//        {
//            get
//            {
//                return this.xCampoField;
//            }
//            set
//            {
//                this.xCampoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicObsFisco
//    {

//        private string xTextoField;

//        private string xCampoField;

//        /// <remarks/>
//        public string xTexto
//        {
//            get
//            {
//                return this.xTextoField;
//            }
//            set
//            {
//                this.xTextoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string xCampo
//        {
//            get
//            {
//                return this.xCampoField;
//            }
//            set
//            {
//                this.xCampoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeInfAdicProcRef
//    {

//        private string nProcField;

//        private TNFeInfNFeInfAdicProcRefIndProc indProcField;

//        /// <remarks/>
//        public string nProc
//        {
//            get
//            {
//                return this.nProcField;
//            }
//            set
//            {
//                this.nProcField = value;
//            }
//        }

//        /// <remarks/>
//        public TNFeInfNFeInfAdicProcRefIndProc indProc
//        {
//            get
//            {
//                return this.indProcField;
//            }
//            set
//            {
//                this.indProcField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public enum TNFeInfNFeInfAdicProcRefIndProc
//    {

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("0")]
//        Item0,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("1")]
//        Item1,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("2")]
//        Item2,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("3")]
//        Item3,

//        /// <remarks/>
//        [System.Xml.Serialization.XmlEnumAttribute("9")]
//        Item9,
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeExporta
//    {

//        private TUfEmi uFSaidaPaisField;

//        private string xLocExportaField;

//        private string xLocDespachoField;

//        /// <remarks/>
//        public TUfEmi UFSaidaPais
//        {
//            get
//            {
//                return this.uFSaidaPaisField;
//            }
//            set
//            {
//                this.uFSaidaPaisField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocExporta
//        {
//            get
//            {
//                return this.xLocExportaField;
//            }
//            set
//            {
//                this.xLocExportaField = value;
//            }
//        }

//        /// <remarks/>
//        public string xLocDespacho
//        {
//            get
//            {
//                return this.xLocDespachoField;
//            }
//            set
//            {
//                this.xLocDespachoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCompra
//    {

//        private string xNEmpField;

//        private string xPedField;

//        private string xContField;

//        /// <remarks/>
//        public string xNEmp
//        {
//            get
//            {
//                return this.xNEmpField;
//            }
//            set
//            {
//                this.xNEmpField = value;
//            }
//        }

//        /// <remarks/>
//        public string xPed
//        {
//            get
//            {
//                return this.xPedField;
//            }
//            set
//            {
//                this.xPedField = value;
//            }
//        }

//        /// <remarks/>
//        public string xCont
//        {
//            get
//            {
//                return this.xContField;
//            }
//            set
//            {
//                this.xContField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCana
//    {

//        private string safraField;

//        private string refField;

//        private TNFeInfNFeCanaForDia[] forDiaField;

//        private string qTotMesField;

//        private string qTotAntField;

//        private string qTotGerField;

//        private TNFeInfNFeCanaDeduc[] deducField;

//        private string vForField;

//        private string vTotDedField;

//        private string vLiqForField;

//        /// <remarks/>
//        public string safra
//        {
//            get
//            {
//                return this.safraField;
//            }
//            set
//            {
//                this.safraField = value;
//            }
//        }

//        /// <remarks/>
//        public string @ref
//        {
//            get
//            {
//                return this.refField;
//            }
//            set
//            {
//                this.refField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("forDia")]
//        public TNFeInfNFeCanaForDia[] forDia
//        {
//            get
//            {
//                return this.forDiaField;
//            }
//            set
//            {
//                this.forDiaField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotMes
//        {
//            get
//            {
//                return this.qTotMesField;
//            }
//            set
//            {
//                this.qTotMesField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotAnt
//        {
//            get
//            {
//                return this.qTotAntField;
//            }
//            set
//            {
//                this.qTotAntField = value;
//            }
//        }

//        /// <remarks/>
//        public string qTotGer
//        {
//            get
//            {
//                return this.qTotGerField;
//            }
//            set
//            {
//                this.qTotGerField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("deduc")]
//        public TNFeInfNFeCanaDeduc[] deduc
//        {
//            get
//            {
//                return this.deducField;
//            }
//            set
//            {
//                this.deducField = value;
//            }
//        }


//        /// <remarks/>
//        public string vFor
//        {
//            get
//            {
//                return this.vForField;
//            }
//            set
//            {
//                this.vForField = value;
//            }
//        }

//        /// <remarks/>
//        public string vTotDed
//        {
//            get
//            {
//                return this.vTotDedField;
//            }
//            set
//            {
//                this.vTotDedField = value;
//            }
//        }

//        /// <remarks/>
//        public string vLiqFor
//        {
//            get
//            {
//                return this.vLiqForField;
//            }
//            set
//            {
//                this.vLiqForField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCanaForDia
//    {

//        private string qtdeField;

//        private string diaField;

//        /// <remarks/>
//        public string qtde
//        {
//            get
//            {
//                return this.qtdeField;
//            }
//            set
//            {
//                this.qtdeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string dia
//        {
//            get
//            {
//                return this.diaField;
//            }
//            set
//            {
//                this.diaField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeCanaDeduc
//    {

//        private string xDedField;

//        private string vDedField;

//        /// <remarks/>
//        public string xDed
//        {
//            get
//            {
//                return this.xDedField;
//            }
//            set
//            {
//                this.xDedField = value;
//            }
//        }

//        /// <remarks/>
//        public string vDed
//        {
//            get
//            {
//                return this.vDedField;
//            }
//            set
//            {
//                this.vDedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TInutNFe
//    {

//        private TInutNFeInfInut infInutField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TInutNFeInfInut infInut
//        {
//            get
//            {
//                return this.infInutField;
//            }
//            set
//            {
//                this.infInutField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TInutNFeInfInut
//    {

//        private TAmb tpAmbField;

//        private TInutNFeInfInutXServ xServField;

//        private TCodUfIBGE cUFField;

//        private string anoField;

//        private string cNPJField;

//        private TMod modField;

//        private string serieField;

//        private string nNFIniField;

//        private string nNFFinField;

//        private string xJustField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public TInutNFeInfInutXServ xServ
//        {
//            get
//            {
//                return this.xServField;
//            }
//            set
//            {
//                this.xServField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string ano
//        {
//            get
//            {
//                return this.anoField;
//            }
//            set
//            {
//                this.anoField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFIni
//        {
//            get
//            {
//                return this.nNFIniField;
//            }
//            set
//            {
//                this.nNFIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFFin
//        {
//            get
//            {
//                return this.nNFFinField;
//            }
//            set
//            {
//                this.nNFFinField = value;
//            }
//        }

//        /// <remarks/>
//        public string xJust
//        {
//            get
//            {
//                return this.xJustField;
//            }
//            set
//            {
//                this.xJustField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("ProcInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TProcInutNFe
//    {

//        private TInutNFe inutNFeField;

//        private TRetInutNFe retInutNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TInutNFe inutNFe
//        {
//            get
//            {
//                return this.inutNFeField;
//            }
//            set
//            {
//                this.inutNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TRetInutNFe retInutNFe
//        {
//            get
//            {
//                return this.retInutNFeField;
//            }
//            set
//            {
//                this.retInutNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetInutNFe
//    {

//        private TRetInutNFeInfInut infInutField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TRetInutNFeInfInut infInut
//        {
//            get
//            {
//                return this.infInutField;
//            }
//            set
//            {
//                this.infInutField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetInutNFeInfInut
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string anoField;

//        private string cNPJField;

//        private TMod modField;

//        private bool modFieldSpecified;

//        private string serieField;

//        private string nNFIniField;

//        private string nNFFinField;

//        private string dhRecbtoField;

//        private string nProtField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string ano
//        {
//            get
//            {
//                return this.anoField;
//            }
//            set
//            {
//                this.anoField = value;
//            }
//        }

//        /// <remarks/>
//        public string CNPJ
//        {
//            get
//            {
//                return this.cNPJField;
//            }
//            set
//            {
//                this.cNPJField = value;
//            }
//        }

//        /// <remarks/>
//        public TMod mod
//        {
//            get
//            {
//                return this.modField;
//            }
//            set
//            {
//                this.modField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool modSpecified
//        {
//            get
//            {
//                return this.modFieldSpecified;
//            }
//            set
//            {
//                this.modFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string serie
//        {
//            get
//            {
//                return this.serieField;
//            }
//            set
//            {
//                this.serieField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFIni
//        {
//            get
//            {
//                return this.nNFIniField;
//            }
//            set
//            {
//                this.nNFIniField = value;
//            }
//        }

//        /// <remarks/>
//        public string nNFFin
//        {
//            get
//            {
//                return this.nNFFinField;
//            }
//            set
//            {
//                this.nNFFinField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TNfeProc
//    {

//        private TNFe nFeField;

//        private TProtNFe protNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TNFe NFe
//        {
//            get
//            {
//                return this.nFeField;
//            }
//            set
//            {
//                this.nFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TProtNFe protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TProtNFe
//    {

//        private TProtNFeInfProt infProtField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TProtNFeInfProt infProt
//        {
//            get
//            {
//                return this.infProtField;
//            }
//            set
//            {
//                this.infProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TProtNFeInfProt
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string chNFeField;

//        private string dhRecbtoField;

//        private string nProtField;

//        private byte[] digValField;

//        private string cStatField;

//        private string xMotivoField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
//        public byte[] digVal
//        {
//            get
//            {
//                return this.digValField;
//            }
//            set
//            {
//                this.digValField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsReciNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string nRecField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string cMsgField;

//        private string xMsgField;

//        private TProtNFe[] protNFeField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string nRec
//        {
//            get
//            {
//                return this.nRecField;
//            }
//            set
//            {
//                this.nRecField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string cMsg
//        {
//            get
//            {
//                return this.cMsgField;
//            }
//            set
//            {
//                this.cMsgField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMsg
//        {
//            get
//            {
//                return this.xMsgField;
//            }
//            set
//            {
//                this.xMsgField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("protNFe")]
//        public TProtNFe[] protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsSitNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string chNFeField;

//        private TProtNFe protNFeField;

//        private TRetCancNFe retCancNFeField;

//        private TProcEvento[] procEventoNFeField;

//        private TVerConsSitNFe versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TProtNFe protNFe
//        {
//            get
//            {
//                return this.protNFeField;
//            }
//            set
//            {
//                this.protNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public TRetCancNFe retCancNFe
//        {
//            get
//            {
//                return this.retCancNFeField;
//            }
//            set
//            {
//                this.retCancNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("procEventoNFe")]
//        public TProcEvento[] procEventoNFe
//        {
//            get
//            {
//                return this.procEventoNFeField;
//            }
//            set
//            {
//                this.procEventoNFeField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public TVerConsSitNFe versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetCancNFe
//    {

//        private TRetCancNFeInfCanc infCancField;

//        private SignatureType signatureField;

//        private string versaoField;

//        /// <remarks/>
//        public TRetCancNFeInfCanc infCanc
//        {
//            get
//            {
//                return this.infCancField;
//            }
//            set
//            {
//                this.infCancField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
//        public SignatureType Signature
//        {
//            get
//            {
//                return this.signatureField;
//            }
//            set
//            {
//                this.signatureField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetCancNFeInfCanc
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string chNFeField;

//        private System.DateTime dhRecbtoField;

//        private bool dhRecbtoFieldSpecified;

//        private string nProtField;

//        private string idField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string chNFe
//        {
//            get
//            {
//                return this.chNFeField;
//            }
//            set
//            {
//                this.chNFeField = value;
//            }
//        }

//        /// <remarks/>
//        public System.DateTime dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool dhRecbtoSpecified
//        {
//            get
//            {
//                return this.dhRecbtoFieldSpecified;
//            }
//            set
//            {
//                this.dhRecbtoFieldSpecified = value;
//            }
//        }

//        /// <remarks/>
//        public string nProt
//        {
//            get
//            {
//                return this.nProtField;
//            }
//            set
//            {
//                this.nProtField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
//        public string Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetConsStatServ
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private string tMedField;

//        private string dhRetornoField;

//        private string xObsField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        public string tMed
//        {
//            get
//            {
//                return this.tMedField;
//            }
//            set
//            {
//                this.tMedField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRetorno
//        {
//            get
//            {
//                return this.dhRetornoField;
//            }
//            set
//            {
//                this.dhRetornoField = value;
//            }
//        }

//        /// <remarks/>
//        public string xObs
//        {
//            get
//            {
//                return this.xObsField;
//            }
//            set
//            {
//                this.xObsField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    [System.Xml.Serialization.XmlRootAttribute("retEnviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
//    public partial class TRetEnviNFe
//    {

//        private TAmb tpAmbField;

//        private string verAplicField;

//        private string cStatField;

//        private string xMotivoField;

//        private TCodUfIBGE cUFField;

//        private string dhRecbtoField;

//        private object itemField;

//        private string versaoField;

//        /// <remarks/>
//        public TAmb tpAmb
//        {
//            get
//            {
//                return this.tpAmbField;
//            }
//            set
//            {
//                this.tpAmbField = value;
//            }
//        }

//        /// <remarks/>
//        public string verAplic
//        {
//            get
//            {
//                return this.verAplicField;
//            }
//            set
//            {
//                this.verAplicField = value;
//            }
//        }

//        /// <remarks/>
//        public string cStat
//        {
//            get
//            {
//                return this.cStatField;
//            }
//            set
//            {
//                this.cStatField = value;
//            }
//        }

//        /// <remarks/>
//        public string xMotivo
//        {
//            get
//            {
//                return this.xMotivoField;
//            }
//            set
//            {
//                this.xMotivoField = value;
//            }
//        }

//        /// <remarks/>
//        public TCodUfIBGE cUF
//        {
//            get
//            {
//                return this.cUFField;
//            }
//            set
//            {
//                this.cUFField = value;
//            }
//        }

//        /// <remarks/>
//        public string dhRecbto
//        {
//            get
//            {
//                return this.dhRecbtoField;
//            }
//            set
//            {
//                this.dhRecbtoField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("infRec", typeof(TRetEnviNFeInfRec))]
//        [System.Xml.Serialization.XmlElementAttribute("protNFe", typeof(TProtNFe))]
//        public object Item
//        {
//            get
//            {
//                return this.itemField;
//            }
//            set
//            {
//                this.itemField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlAttributeAttribute()]
//        public string versao
//        {
//            get
//            {
//                return this.versaoField;
//            }
//            set
//            {
//                this.versaoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TRetEnviNFeInfRec
//    {

//        private string nRecField;

//        private string tMedField;

//        /// <remarks/>
//        public string nRec
//        {
//            get
//            {
//                return this.nRecField;
//            }
//            set
//            {
//                this.nRecField = value;
//            }
//        }

//        /// <remarks/>
//        public string tMed
//        {
//            get
//            {
//                return this.tMedField;
//            }
//            set
//            {
//                this.tMedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeSupl
//    {
//        private string qrCodeField;

//        /// <remarks/>
//        public XmlCDataSection qrCode
//        {
//            get
//            {
//                return XMLUtils.CreateCData(this.qrCodeField);
//            }
//            set
//            {
//                this.qrCodeField = value?.Value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
//    [System.SerializableAttribute()]
//    [System.Diagnostics.DebuggerStepThroughAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
//    public partial class TNFeInfNFeDetImpostoICMSUFDest
//    {

//        private string vBCUFDestField;

//        private string pFCPUFDestField;

//        private string pICMSUFDestField;

//        private string pICMSInterField;

//        private string pICMSInterPartField;

//        private string vFCPUFDestField;

//        private string vICMSUFDestField;

//        private string vICMSUFRemetField;

//        /// <remarks/>
//        public string vBCUFDest
//        {
//            get
//            {
//                return this.vBCUFDestField;
//            }
//            set
//            {
//                this.vBCUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string pFCPUFDest
//        {
//            get
//            {
//                return this.pFCPUFDestField;
//            }
//            set
//            {
//                this.pFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSUFDest
//        {
//            get
//            {
//                return this.pICMSUFDestField;
//            }
//            set
//            {
//                this.pICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSInter
//        {
//            get
//            {
//                return this.pICMSInterField;
//            }
//            set
//            {
//                this.pICMSInterField = value;
//            }
//        }

//        /// <remarks/>
//        public string pICMSInterPart
//        {
//            get
//            {
//                return this.pICMSInterPartField;
//            }
//            set
//            {
//                this.pICMSInterPartField = value;
//            }
//        }

//        /// <remarks/>
//        public string vFCPUFDest
//        {
//            get
//            {
//                return this.vFCPUFDestField;
//            }
//            set
//            {
//                this.vFCPUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFDest
//        {
//            get
//            {
//                return this.vICMSUFDestField;
//            }
//            set
//            {
//                this.vICMSUFDestField = value;
//            }
//        }

//        /// <remarks/>
//        public string vICMSUFRemet
//        {
//            get
//            {
//                return this.vICMSUFRemetField;
//            }
//            set
//            {
//                this.vICMSUFRemetField = value;
//            }
//        }
//    }
//}