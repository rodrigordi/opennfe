using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace RDI.NFe2.Business.PWS.BA.Cadastro
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "CadConsultaCadastro2Soap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2")]
    public partial class CadConsultaCadastro2 : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback consultaCadastro2OperationCompleted;

        /// <remarks/>
        public CadConsultaCadastro2()
        {
            this.Url = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/CadConsultaCadastro2.asmx";
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
        public event consultaCadastro2CompletedEventHandler consultaCadastro2Completed;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2/consultaCadastro2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2")]
        public System.Xml.XmlNode consultaCadastro2([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("consultaCadastro2", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginconsultaCadastro2(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("consultaCadastro2", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndconsultaCadastro2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void consultaCadastro2Async(System.Xml.XmlNode nfeDadosMsg)
        {
            this.consultaCadastro2Async(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void consultaCadastro2Async(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.consultaCadastro2OperationCompleted == null))
            {
                this.consultaCadastro2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaCadastro2OperationCompleted);
            }
            this.InvokeAsync("consultaCadastro2", new object[] {
                    nfeDadosMsg}, this.consultaCadastro2OperationCompleted, userState);
        }

        private void OnconsultaCadastro2OperationCompleted(object arg)
        {
            if ((this.consultaCadastro2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaCadastro2Completed(this, new consultaCadastro2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/CadConsultaCadastro2", IsNullable = false)]
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
    public delegate void consultaCadastro2CompletedEventHandler(object sender, consultaCadastro2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaCadastro2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultaCadastro2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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