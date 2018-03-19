using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RDI.OpenSigner
{
    //TODO :  reorganizar essas funções


    /// 
    //Entradas:
    /// XMLString: string XML a ser assinada
    /// RefUri : Referência da URI a ser assinada(infNFe, Cancelamento e inutilzacao)
    /// X509Cert : certificado digital a ser utilizado na assinatura digital
    ///
    /// Retornos:
    /// Assinar : 0 - Assinatura realizada com sucesso
    /// 1 - Erro: Problema ao acessar o certificado digital - %exceção%
    ///xtinto* 2 - Problemas no certificado digital
    /// 3 - XML mal formado + exceção
    /// 4 - A tag de assinatura %RefUri% inexiste
    /// 5 - A tag de assinatura %RefUri% não é unica
    /// 6 - Erro Ao assinar o documento - ID deve ser string %RefUri(Atributo)%
    /// 7 - Erro: Ao assinar o documento - %exceção%
    ///
    /// XMLStringAssinado : string XML assinada
    ///
    /// XMLDocAssinado : XMLDocument do XML assinado
    ///
    /// </summary>
    /// <param name="XMLString"></param>
    /// <param name="RefUri"></param>
    /// <param name="_X509Cert"></param>
    /// <returns></returns>



    //Classe que realiza a assinatura Digital
    public class AssinaturaDigital
    {
        private string msgResultado;
        private XmlDocument XMLDoc;

        public XmlDocument XMLDocAssinado
        {
            get { return XMLDoc; }
        }

        public string XMLStringAssinado
        {
            get { return XMLDoc.OuterXml; }
        }

        public string mensagemResultado
        {
            get { return msgResultado; }
        }

        public int Assinar(string XMLString, string RefUri, X509Certificate2 _X509Cert)
        {
            int resultado = 0;
            msgResultado = "Assinatura realizada com sucesso";
            try
            {
                // certificado para ser utilizado na assinatura
                //
                //string _xnome = "";
                //if (X509Cert != null)
                //{
                //    _xnome = X509Cert.Subject.ToString();
                //}

                //X509Certificate2 _X509Cert = new X509Certificate2();
                //Cria uma colecao de certificados a partir de um usuario

                //X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                //store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                //X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
                //Busca o certificado
                //X509Certificate2Collection collection1 = (X509Certificate2Collection)collection.Find(X509FindType.FindBySubjectDistinguishedName, _xnome, false);

                //if (collection1.Count == 0)
                //{
                //    resultado = 2;
                //    msgResultado = "Problemas no certificado digital";
                //}
                //else
                {
                    // certificado ok
                    //_X509Cert = collection1[0];
                    // Cria um novo XML.

                    XmlDocument doc = new XmlDocument();
                    XmlDocument doc2 = new XmlDocument();
                    doc.PreserveWhitespace = false;
                    // carrega o conteudo XML passado
                    try
                    {
                        doc.LoadXml(XMLString);
                        // Verifica se a tag a ser assinada existe é única
                        int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;
                        if (qtdeRefUri == 0)
                        {
                            // a URI indicada não existe
                            resultado = 4;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste";
                        }
                        // Exsiste mais de uma tag a ser assinada
                        else
                        {
                            if (qtdeRefUri > 1)
                            {
                                // existe mais de uma URI indicada
                                resultado = 5;
                                msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica";
                            }
                            //else if (_listaNum.IndexOf(doc.GetElementsByTagName(RefUri).Item(0).Attributes.ToString().Substring(1,1))>0)
                            //{
                            // resultado = 6;
                            // msgResultado = "Erro: Ao assinar o documento - ID deve ser string (" + doc.GetElementsByTagName(RefUri).Item(0).Attributes + ")";
                            //}
                            else
                            {
                                try
                                {
                                    // cria um objeto xml assinado
                                    SignedXml signedXml = new SignedXml(doc);
                                    // adiciona a chave do certificado
                                    signedXml.SigningKey = _X509Cert.PrivateKey;
                                    //definir explicitamente o metodo
                                    signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

                                    // Cria a referencia para assinatura
                                    Reference reference = new Reference();
                                    //definir explicitamente o metodo
                                    reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

                                    // pega o uri que deve ser assinada
                                    XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                    String id = "";
                                    foreach (XmlAttribute _atributo in _Uri)
                                    {
                                        if (_atributo.Name == "id" || _atributo.Name == "Id" || _atributo.Name == "ID")
                                        {
                                            reference.Uri = "#" + _atributo.InnerText;
                                            id = _atributo.Value;
                                            break;
                                        }
                                    }

                                    if (string.IsNullOrEmpty(id))
                                        throw new Exception("Id não localizado.");

                                    //TODO : parametrizar
                                    #region calculo assinatura NFSe
                                    // adiciona um XmlDsigEnvelopedSignatureTransform para a assinatura
                                    XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                    reference.AddTransform(env);
                                    //XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                    //reference.AddTransform(c14);
                                    signedXml.SignedInfo.CanonicalizationMethod += "#WithComments";
                                    // adiciona a referencia no xml assinado
                                    signedXml.AddReference(reference);
                                    // Cria a chave
                                    KeyInfo keyInfo = new KeyInfo();
                                    // carrega o certificado em um keyinfox509
                                    // e adiciona ao keyinfo
                                    keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));
                                    // adiciona o keyinfo ao xml assinado
                                    signedXml.KeyInfo = keyInfo;
                                    signedXml.ComputeSignature();
                                    #endregion


                                    //adaptacao
                                    // criar elemento <Signature>
                                    XmlElement xmlSignature = doc.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");

                                    // criar Id da tag <Signature>
                                    XmlAttribute idAssinatura = doc.CreateAttribute("Id");
                                    idAssinatura.Value = "Ass_" + id;
                                    xmlSignature.Attributes.InsertAfter(idAssinatura, xmlSignature.GetAttributeNode("xmlns"));

                                    // gerar elemento <SignedInfo>
                                    XmlElement xmlSignedInfo = signedXml.SignedInfo.GetXml();

                                    // gerar elemento <KeyInfo>
                                    XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();

                                    // compor nó <SignatureValue>
                                    XmlElement xmlSignatureValue = doc.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                                    string signBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                                    XmlText text = doc.CreateTextNode(signBase64);
                                    xmlSignatureValue.AppendChild(text);

                                    // incluir nós filhos da assinatura
                                    xmlSignature.AppendChild(doc.ImportNode(xmlSignedInfo, true));
                                    xmlSignature.AppendChild(xmlSignatureValue);
                                    xmlSignature.AppendChild(doc.ImportNode(xmlKeyInfo, true));

                                    // incluir assinatura no documento
                                    doc.DocumentElement.AppendChild(doc.ImportNode(xmlSignature, true));



                                    //fim adaptacao
                                    // busca a representacao XML da assinatura e salva no XML
                                    //XmlElement xmlDigitalSignature = signedXml.GetXml();
                                    // adiciona a assinatura no documento
                                    //doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                    //salva o documento assinado
                                    XMLDoc = new XmlDocument();
                                    XMLDoc.PreserveWhitespace = false;
                                    XMLDoc = doc;
                                }
                                catch (Exception caught)
                                {
                                    resultado = 7;
                                    msgResultado = "Erro ao assinar o documento - " + caught.Message;
                                }
                            }
                        }
                    }
                    catch (Exception caught)
                    {
                        resultado = 3;
                        msgResultado = "Erro: XML mal formado - " + caught.Message;
                    }
                }
            }
            catch (Exception caught)
            {
                resultado = 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }

            return resultado;
        }

        public int AssinarCTe(string XMLString, string RefUri, X509Certificate2 _X509Cert)
        {
            int resultado = 0;
            msgResultado = "Assinatura realizada com sucesso";
            try
            {



                // certificado ok
                //_X509Cert = collection1[0];

                // Cria um novo XML.
                XmlDocument doc = new XmlDocument();
                //XmlDocument doc2 = new XmlDocument();
                //doc.PreserveWhitespace = false;
                // carrega o conteudo XML passado
                try
                {
                    doc.LoadXml(XMLString);
                    // Verifica se a tag a ser assinada existe é única
                    int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;
                    if (qtdeRefUri == 0)
                    {
                        // a URI indicada não existe
                        resultado = 4;
                        msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste";
                    }
                    // Exsiste mais de uma tag a ser assinada
                    else
                    {
                        if (qtdeRefUri > 1)
                        {
                            // existe mais de uma URI indicada
                            resultado = 5;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica";
                        }
                        //else if (_listaNum.IndexOf(doc.GetElementsByTagName(RefUri).Item(0).Attributes.ToString().Substring(1,1))>0)
                        //{
                        // resultado = 6;
                        // msgResultado = "Erro: Ao assinar o documento - ID deve ser string (" + doc.GetElementsByTagName(RefUri).Item(0).Attributes + ")";
                        //}
                        else
                        {
                            try
                            {
                                // cria um objeto xml assinado
                                SignedXml signedXml = new SignedXml(doc);
                                // adiciona a chave do certificado
                                signedXml.SigningKey = _X509Cert.PrivateKey;
                                //definir explicitamente o metodo
                                signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

                                // Cria a referencia para assinatura
                                Reference reference = new Reference();
                                //definir explicitamente o metodo
                                reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

                                // pega o uri que deve ser assinada
                                XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                foreach (XmlAttribute _atributo in _Uri)
                                {
                                    if (_atributo.Name == "Id")
                                    {
                                        reference.Uri = "#" + _atributo.InnerText;
                                    }
                                }
                                // adiciona um XmlDsigEnvelopedSignatureTransform para a assinatura
                                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                reference.AddTransform(env);
                                XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                reference.AddTransform(c14);
                                // adiciona a referencia no xml assinado
                                signedXml.AddReference(reference);
                                // Cria a chave
                                KeyInfo keyInfo = new KeyInfo();
                                // carrega o certificado em um keyinfox509
                                // e adiciona ao keyinfo
                                keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));
                                // adiciona o keyinfo ao xml assinado
                                signedXml.KeyInfo = keyInfo;
                                signedXml.ComputeSignature();
                                // busca a representacao XML da assinatura e salva no XML
                                XmlElement xmlDigitalSignature = signedXml.GetXml();
                                // adiciona a assinatura no documento
                                doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                //salva o documento assinado
                                XMLDoc = new XmlDocument();
                                //XMLDoc.PreserveWhitespace = false;
                                XMLDoc = doc;
                            }
                            catch (Exception caught)
                            {
                                resultado = 7;
                                msgResultado = "Erro: Ao assinar o documento - " + caught.Message;
                            }
                        }
                    }
                }
                catch (Exception caught)
                {
                    resultado = 3;
                    msgResultado = "Erro: XML mal formado - " + caught.Message;
                }

            }
            catch (Exception caught)
            {
                resultado = 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }
            return resultado;
        }

        public TRetornoAssinatura AssinarMDFe(string XMLString, string RefUri, X509Certificate2 _X509Cert)
        {
            TRetornoAssinatura resultado = TRetornoAssinatura.Assinada;
            msgResultado = "Assinatura realizada com sucesso";
            try
            {



                // certificado ok
                //_X509Cert = collection1[0];

                // Cria um novo XML.
                XmlDocument doc = new XmlDocument();
                //XmlDocument doc2 = new XmlDocument();
                //doc.PreserveWhitespace = false;
                // carrega o conteudo XML passado
                try
                {
                    doc.LoadXml(XMLString);
                    // Verifica se a tag a ser assinada existe é única
                    int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;
                    if (qtdeRefUri == 0)
                    {
                        // a URI indicada não existe
                        resultado = TRetornoAssinatura.RefURiNaoExiste;//4;
                        msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste";
                    }
                    // Exsiste mais de uma tag a ser assinada
                    else
                    {
                        if (qtdeRefUri > 1)
                        {
                            // existe mais de uma URI indicada
                            resultado = TRetornoAssinatura.RefURiNaoUnica; //5;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica";
                        }
                        //else if (_listaNum.IndexOf(doc.GetElementsByTagName(RefUri).Item(0).Attributes.ToString().Substring(1,1))>0)
                        //{
                        // resultado = 6;
                        // msgResultado = "Erro: Ao assinar o documento - ID deve ser string (" + doc.GetElementsByTagName(RefUri).Item(0).Attributes + ")";
                        //}
                        else
                        {
                            try
                            {
                                // cria um objeto xml assinado
                                SignedXml signedXml = new SignedXml(doc);
                                // adiciona a chave do certificado
                                signedXml.SigningKey = _X509Cert.PrivateKey;
                                //definir explicitamente o metodo
                                signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

                                // Cria a referencia para assinatura
                                Reference reference = new Reference();
                                //definir explicitamente o metodo
                                reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

                                // pega o uri que deve ser assinada
                                XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                foreach (XmlAttribute _atributo in _Uri)
                                {
                                    if (_atributo.Name == "Id")
                                    {
                                        reference.Uri = "#" + _atributo.InnerText;
                                    }
                                }
                                // adiciona um XmlDsigEnvelopedSignatureTransform para a assinatura
                                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                reference.AddTransform(env);
                                XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                reference.AddTransform(c14);
                                // adiciona a referencia no xml assinado
                                signedXml.AddReference(reference);
                                // Cria a chave
                                KeyInfo keyInfo = new KeyInfo();
                                // carrega o certificado em um keyinfox509
                                // e adiciona ao keyinfo
                                keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));
                                // adiciona o keyinfo ao xml assinado
                                signedXml.KeyInfo = keyInfo;
                                signedXml.ComputeSignature();
                                // busca a representacao XML da assinatura e salva no XML
                                XmlElement xmlDigitalSignature = signedXml.GetXml();
                                // adiciona a assinatura no documento
                                doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                //salva o documento assinado
                                XMLDoc = new XmlDocument();
                                //XMLDoc.PreserveWhitespace = false;
                                XMLDoc = doc;
                            }
                            catch (Exception caught)
                            {
                                resultado = TRetornoAssinatura.ErroAoAssinarDocumento;// 7;
                                msgResultado = "Erro: Ao assinar o documento - " + caught.Message;
                            }
                        }
                    }
                }
                catch (Exception caught)
                {
                    resultado = TRetornoAssinatura.XMLMalFormado;// 3;
                    msgResultado = "Erro: XML mal formado - " + caught.Message;
                }

            }
            catch (Exception caught)
            {
                resultado = TRetornoAssinatura.ProblemaAoAcessarCertificado;// 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }
            return resultado;
        }

        public TRetornoAssinatura AssinarNFe(string XMLString, string RefUri, X509Certificate2 _X509Cert)
        {
            var resultado = TRetornoAssinatura.Assinada;
            msgResultado = "Assinatura realizada com sucesso";
            try
            {



                // certificado ok
                //_X509Cert = collection1[0];

                // Cria um novo XML.
                XmlDocument doc = new XmlDocument();
                //XmlDocument doc2 = new XmlDocument();
                //doc.PreserveWhitespace = false;
                // carrega o conteudo XML passado
                try
                {
                    doc.LoadXml(XMLString);
                    // Verifica se a tag a ser assinada existe é única
                    int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;
                    if (qtdeRefUri == 0)
                    {
                        // a URI indicada não existe
                        resultado = TRetornoAssinatura.RefURiNaoExiste;//4;
                        msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste";
                    }
                    // Exsiste mais de uma tag a ser assinada
                    else
                    {
                        if (qtdeRefUri > 1)
                        {
                            // existe mais de uma URI indicada
                            resultado = TRetornoAssinatura.RefURiNaoUnica; //5;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica";
                        }
                        //else if (_listaNum.IndexOf(doc.GetElementsByTagName(RefUri).Item(0).Attributes.ToString().Substring(1,1))>0)
                        //{
                        // resultado = 6;
                        // msgResultado = "Erro: Ao assinar o documento - ID deve ser string (" + doc.GetElementsByTagName(RefUri).Item(0).Attributes + ")";
                        //}
                        else
                        {
                            try
                            {
                                // cria um objeto xml assinado
                                SignedXml signedXml = new SignedXml(doc);
                                // adiciona a chave do certificado
                                signedXml.SigningKey = _X509Cert.PrivateKey;
                                //definir explicitamente o metodo
                                signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

                                // Cria a referencia para assinatura
                                Reference reference = new Reference();
                                //definir explicitamente o metodo
                                reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

                                // pega o uri que deve ser assinada
                                XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                foreach (XmlAttribute _atributo in _Uri)
                                {
                                    if (_atributo.Name == "Id")
                                    {
                                        reference.Uri = "#" + _atributo.InnerText;
                                    }
                                }

                                #region calculo assinatura NFe
                                // adiciona um XmlDsigEnvelopedSignatureTransform para a assinatura
                                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                reference.AddTransform(env);
                                XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                reference.AddTransform(c14);
                                // adiciona a referencia no xml assinado
                                signedXml.AddReference(reference);
                                // Cria a chave
                                KeyInfo keyInfo = new KeyInfo();
                                // carrega o certificado em um keyinfox509
                                // e adiciona ao keyinfo
                                keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));
                                // adiciona o keyinfo ao xml assinado
                                signedXml.KeyInfo = keyInfo;
                                //calcular assinatura
                                signedXml.ComputeSignature();
                                #endregion

                                // busca a representacao XML da assinatura e salva no XML
                                XmlElement xmlDigitalSignature = signedXml.GetXml();
                                // adiciona a assinatura no documento
                                doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                //salva o documento assinado
                                XMLDoc = new XmlDocument();
                                //XMLDoc.PreserveWhitespace = false;
                                XMLDoc = doc;
                            }
                            catch (Exception caught)
                            {
                                resultado = TRetornoAssinatura.ErroAoAssinarDocumento;// 7;
                                msgResultado = "Erro: Ao assinar o documento - " + caught.Message;
                            }
                        }
                    }
                }
                catch (Exception caught)
                {
                    resultado = TRetornoAssinatura.XMLMalFormado;// 3;
                    msgResultado = "Erro: XML mal formado - " + caught.Message;
                }

            }
            catch (Exception caught)
            {
                resultado = TRetornoAssinatura.ProblemaAoAcessarCertificado;// 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }
            return resultado;
        }

        public TRetornoAssinatura AssinarESocial(string XMLString, string RefUri, X509Certificate2 _X509Cert)
        {
            var resultado = TRetornoAssinatura.Assinada;
            msgResultado = "Assinatura realizada com sucesso";
            try
            {



                // certificado ok
                //_X509Cert = collection1[0];

                // Cria um novo XML.
                XmlDocument doc = new XmlDocument();
                //XmlDocument doc2 = new XmlDocument();
                //doc.PreserveWhitespace = false;
                // carrega o conteudo XML passado
                try
                {
                    doc.LoadXml(XMLString);
                    // Verifica se a tag a ser assinada existe é única
                    int qtdeRefUri = doc.GetElementsByTagName(RefUri).Count;
                    if (qtdeRefUri == 0)
                    {
                        // a URI indicada não existe
                        resultado = TRetornoAssinatura.RefURiNaoExiste;//4;
                        msgResultado = "A tag de assinatura " + RefUri.Trim() + " inexiste";
                    }
                    // Exsiste mais de uma tag a ser assinada
                    else
                    {
                        if (qtdeRefUri > 1)
                        {
                            // existe mais de uma URI indicada
                            resultado = TRetornoAssinatura.RefURiNaoUnica; //5;
                            msgResultado = "A tag de assinatura " + RefUri.Trim() + " não é unica";
                        }
                        //else if (_listaNum.IndexOf(doc.GetElementsByTagName(RefUri).Item(0).Attributes.ToString().Substring(1,1))>0)
                        //{
                        // resultado = 6;
                        // msgResultado = "Erro: Ao assinar o documento - ID deve ser string (" + doc.GetElementsByTagName(RefUri).Item(0).Attributes + ")";
                        //}
                        else
                        {
                            try
                            {
                                // cria um objeto xml assinado
                                SignedXml signedXml = new SignedXml(doc);
                                // adiciona a chave do certificado
                                signedXml.SigningKey = _X509Cert.PrivateKey;
                                //definir explicitamente o metodo
                                signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

                                // Cria a referencia para assinatura
                                Reference reference = new Reference();
                                //definir explicitamente o metodo
                                reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

                                // pega o uri que deve ser assinada
                                XmlAttributeCollection _Uri = doc.GetElementsByTagName(RefUri).Item(0).Attributes;
                                foreach (XmlAttribute _atributo in _Uri)
                                {
                                    if (_atributo.Name == "Id")
                                    {
                                        reference.Uri = "#" + _atributo.InnerText;
                                    }
                                }
                                #region calculo assinatura NFe
                                // adiciona um XmlDsigEnvelopedSignatureTransform para a assinatura
                                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                                reference.AddTransform(env);
                                XmlDsigC14NTransform c14 = new XmlDsigC14NTransform();
                                reference.AddTransform(c14);
                                // adiciona a referencia no xml assinado
                                signedXml.AddReference(reference);
                                // Cria a chave
                                KeyInfo keyInfo = new KeyInfo();
                                // carrega o certificado em um keyinfox509
                                // e adiciona ao keyinfo
                                keyInfo.AddClause(new KeyInfoX509Data(_X509Cert));
                                // adiciona o keyinfo ao xml assinado
                                signedXml.KeyInfo = keyInfo;
                                signedXml.ComputeSignature();
                                #endregion

                                // busca a representacao XML da assinatura e salva no XML
                                XmlElement xmlDigitalSignature = signedXml.GetXml();
                                // adiciona a assinatura no documento
                                doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));
                                //salva o documento assinado
                                XMLDoc = new XmlDocument();
                                //XMLDoc.PreserveWhitespace = false;
                                XMLDoc = doc;
                            }
                            catch (Exception caught)
                            {
                                resultado = TRetornoAssinatura.ErroAoAssinarDocumento;// 7;
                                msgResultado = "Erro: Ao assinar o documento - " + caught.Message;
                            }
                        }
                    }
                }
                catch (Exception caught)
                {
                    resultado = TRetornoAssinatura.XMLMalFormado;// 3;
                    msgResultado = "Erro: XML mal formado - " + caught.Message;
                }

            }
            catch (Exception caught)
            {
                resultado = TRetornoAssinatura.ProblemaAoAcessarCertificado;// 1;
                msgResultado = "Erro: Problema ao acessar o certificado digital" + caught.Message;
            }
            return resultado;
        }
    }
}
