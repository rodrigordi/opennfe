using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;


namespace RDI.NFe2.Business.PWS.AN.Eventos
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "RecepcaoEventoSoap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
    public partial class RecepcaoEvento : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeRecepcaoEventoOperationCompleted;

        /// <remarks/>
        public RecepcaoEvento()
        {
            this.Url = "https://www.nfe.fazenda.gov.br/RecepcaoEvento/RecepcaoEvento.asmx";
        }

        public nfeCabecMsg nfeCabecMsgValue
        {
            get
            {
                return this.nfeCabecMsgValueField;
            }
            set
            {
                this.nfeCabecMsgValueField = value;
            }
        }

        /// <remarks/>
        public event nfeRecepcaoEventoCompletedEventHandler nfeRecepcaoEventoCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento/nfeRecepcaoEvento", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
        public System.Xml.XmlNode nfeRecepcaoEvento([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeRecepcaoEvento(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeRecepcaoEvento(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeRecepcaoEventoAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeRecepcaoEventoAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeRecepcaoEventoAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeRecepcaoEventoOperationCompleted == null))
            {
                this.nfeRecepcaoEventoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeRecepcaoEventoOperationCompleted);
            }
            this.InvokeAsync("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg}, this.nfeRecepcaoEventoOperationCompleted, userState);
        }

        private void OnnfeRecepcaoEventoOperationCompleted(object arg)
        {
            if ((this.nfeRecepcaoEventoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeRecepcaoEventoCompleted(this, new nfeRecepcaoEventoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento", IsNullable = false)]
    public partial class nfeCabecMsg : System.Web.Services.Protocols.SoapHeader
    {

        private string versaoDadosField;

        private string cUFField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string versaoDados
        {
            get
            {
                return this.versaoDadosField;
            }
            set
            {
                this.versaoDadosField = value;
            }
        }

        /// <remarks/>
        public string cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void nfeRecepcaoEventoCompletedEventHandler(object sender, nfeRecepcaoEventoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeRecepcaoEventoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeRecepcaoEventoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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