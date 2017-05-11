using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RDI.NFe2.Business.HNF.SVCAN.Autorizacao
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NfeAutorizacaoSoap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
    public partial class NfeAutorizacao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeAutorizacaoLoteOperationCompleted;

        private System.Threading.SendOrPostCallback nfeAutorizacaoLoteZipOperationCompleted;

        /// <remarks/>
        public NfeAutorizacao()
        {
            this.Url = "https://hom.svc.fazenda.gov.br/NfeAutorizacao/NfeAutorizacao.asmx";
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
        public event nfeAutorizacaoLoteCompletedEventHandler nfeAutorizacaoLoteCompleted;

        /// <remarks/>
        public event nfeAutorizacaoLoteZipCompletedEventHandler nfeAutorizacaoLoteZipCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao/nfeAutorizacaoLote", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
        public System.Xml.XmlNode nfeAutorizacaoLote([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeAutorizacaoLote(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeAutorizacaoLote(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeAutorizacaoLoteAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeAutorizacaoLoteAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeAutorizacaoLoteAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeAutorizacaoLoteOperationCompleted == null))
            {
                this.nfeAutorizacaoLoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeAutorizacaoLoteOperationCompleted);
            }
            this.InvokeAsync("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg}, this.nfeAutorizacaoLoteOperationCompleted, userState);
        }

        private void OnnfeAutorizacaoLoteOperationCompleted(object arg)
        {
            if ((this.nfeAutorizacaoLoteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeAutorizacaoLoteCompleted(this, new nfeAutorizacaoLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao/nfeAutorizacaoLoteZip", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
        public System.Xml.XmlNode nfeAutorizacaoLoteZip([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")] string nfeDadosMsgZip)
        {
            object[] results = this.Invoke("nfeAutorizacaoLoteZip", new object[] {
                    nfeDadosMsgZip});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeAutorizacaoLoteZip(string nfeDadosMsgZip, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeAutorizacaoLoteZip", new object[] {
                    nfeDadosMsgZip}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeAutorizacaoLoteZip(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeAutorizacaoLoteZipAsync(string nfeDadosMsgZip)
        {
            this.nfeAutorizacaoLoteZipAsync(nfeDadosMsgZip, null);
        }

        /// <remarks/>
        public void nfeAutorizacaoLoteZipAsync(string nfeDadosMsgZip, object userState)
        {
            if ((this.nfeAutorizacaoLoteZipOperationCompleted == null))
            {
                this.nfeAutorizacaoLoteZipOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeAutorizacaoLoteZipOperationCompleted);
            }
            this.InvokeAsync("nfeAutorizacaoLoteZip", new object[] {
                    nfeDadosMsgZip}, this.nfeAutorizacaoLoteZipOperationCompleted, userState);
        }

        private void OnnfeAutorizacaoLoteZipOperationCompleted(object arg)
        {
            if ((this.nfeAutorizacaoLoteZipCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeAutorizacaoLoteZipCompleted(this, new nfeAutorizacaoLoteZipCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao", IsNullable = false)]
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
    public delegate void nfeAutorizacaoLoteCompletedEventHandler(object sender, nfeAutorizacaoLoteCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeAutorizacaoLoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeAutorizacaoLoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void nfeAutorizacaoLoteZipCompletedEventHandler(object sender, nfeAutorizacaoLoteZipCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeAutorizacaoLoteZipCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeAutorizacaoLoteZipCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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