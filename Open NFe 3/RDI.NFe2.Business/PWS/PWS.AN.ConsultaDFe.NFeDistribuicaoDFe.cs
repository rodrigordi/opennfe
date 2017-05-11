using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RDI.NFe2.Business.PWS.AN.ConsultaDFe
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NFeDistribuicaoDFeSoap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe")]
    public partial class NFeDistribuicaoDFe : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback nfeDistDFeInteresseOperationCompleted;

        /// <remarks/>
        public NFeDistribuicaoDFe()
        {
            this.Url = "https://www1.nfe.fazenda.gov.br/NFeDistribuicaoDFe/NFeDistribuicaoDFe.asmx";
        }

        /// <remarks/>
        public event nfeDistDFeInteresseCompletedEventHandler nfeDistDFeInteresseCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe/nfeDistDFeInteresse", RequestNamespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe", ResponseNamespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode nfeDistDFeInteresse(System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeDistDFeInteresse", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeDistDFeInteresse(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeDistDFeInteresse", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeDistDFeInteresse(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeDistDFeInteresseAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeDistDFeInteresseAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeDistDFeInteresseAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeDistDFeInteresseOperationCompleted == null))
            {
                this.nfeDistDFeInteresseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeDistDFeInteresseOperationCompleted);
            }
            this.InvokeAsync("nfeDistDFeInteresse", new object[] {
                    nfeDadosMsg}, this.nfeDistDFeInteresseOperationCompleted, userState);
        }

        private void OnnfeDistDFeInteresseOperationCompleted(object arg)
        {
            if ((this.nfeDistDFeInteresseCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeDistDFeInteresseCompleted(this, new nfeDistDFeInteresseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void nfeDistDFeInteresseCompletedEventHandler(object sender, nfeDistDFeInteresseCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeDistDFeInteresseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeDistDFeInteresseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}