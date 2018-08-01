using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;


namespace RDI.NFe2.Webservices.NF4.HUB.Status
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NFeStatusServico4Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeStatusServico4")]
    public partial class NFeStatusServico4ForaPadrao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        public NFeStatusServico4ForaPadrao(string url)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = url;
        }

        //[TraceExtensionAttribute(Filename = "c:\\temp\\nfeStatusServicoNF.txt")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NFeStatusServico4/nfeStatusServicoNF", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("nfeStatusServicoNFResult", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeStatusServico4")]
        public System.Xml.XmlNode nfeStatusServicoNF([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeStatusServico4")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeStatusServicoNF", new object[] { nfeDadosMsg });
            return ((System.Xml.XmlNode)(results[0]));
        }
    }
}