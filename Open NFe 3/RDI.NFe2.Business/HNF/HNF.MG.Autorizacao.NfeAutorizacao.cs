using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;


namespace RDI.NFe2.Business.HNF.MG.Autorizacao
{


  

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "NfeAutorizacaoSoapBinding", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
    public partial class NfeAutorizacao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback NfeAutorizacaoLoteOperationCompleted;

        /// <remarks/>
        public NfeAutorizacao()
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeAutorizacao";
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
        public event NfeAutorizacaoLoteCompletedEventHandler NfeAutorizacaoLoteCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao/NfeAutorizacaoLote",
            Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")]
        public System.Xml.XmlNode nfeAutorizacaoLote(
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeAutorizacao")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginNfeAutorizacaoLote(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public object[] EndNfeAutorizacaoLote(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((object[])(results[0]));
        }

        /// <remarks/>
        public void NfeAutorizacaoLoteAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.NfeAutorizacaoLoteAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void NfeAutorizacaoLoteAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.NfeAutorizacaoLoteOperationCompleted == null))
            {
                this.NfeAutorizacaoLoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNfeAutorizacaoLoteOperationCompleted);
            }
            this.InvokeAsync("nfeAutorizacaoLote", new object[] {
                    nfeDadosMsg}, this.NfeAutorizacaoLoteOperationCompleted, userState);
        }

        private void OnNfeAutorizacaoLoteOperationCompleted(object arg)
        {
            if ((this.NfeAutorizacaoLoteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NfeAutorizacaoLoteCompleted(this, new NfeAutorizacaoLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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

        private string cUFField;

        private string versaoDadosField;

        private System.Xml.XmlAttribute[] anyAttrField;

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
    public delegate void NfeAutorizacaoLoteCompletedEventHandler(object sender, NfeAutorizacaoLoteCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NfeAutorizacaoLoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal NfeAutorizacaoLoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public object[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
}