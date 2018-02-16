using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;


namespace RDI.NFe2.Webservices.NF4.HUB.ConsultaProtocolo
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NfeConsulta4Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4")]
    public partial class NFeConsultaProtocolo4ForaPadrao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public NFeConsultaProtocolo4ForaPadrao(string url)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = url;
        }

        //[TraceExtensionAttribute(Filename = "c:\\temp\\nfeConsultaNF.txt")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4/nfeConsultaNF", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("nfeResultMsg", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsultaProtocolo4")]
        public System.Xml.XmlNode nfeConsultaNF([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeConsultaProtocolo4")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeConsultaNF", new object[] {
                        nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    }
}