using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;


namespace RDI.NFe2.Webservices.NF4.HUB.Autorizacao
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NfeAutorizacao4Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeAutorizacao4")]
    public partial class NFeAutorizacao4ForaPadrao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public NFeAutorizacao4ForaPadrao(string url)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = url;
        }

        //[TraceExtensionAttribute(Filename = "c:\\temp\\nfeAutorizacaoLote.txt")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NFeAutorizacao4/nfeAutorizacaoLote", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("nfeResultMsg", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao4")]
        public System.Xml.XmlNode nfeAutorizacaoLote([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeAutorizacao4")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeAutorizacaoLote", new object[] {
                        nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    }
}