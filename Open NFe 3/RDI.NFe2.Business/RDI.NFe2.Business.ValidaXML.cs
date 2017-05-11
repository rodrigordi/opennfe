using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;



namespace RDI.NFe2.Business
{
    public class ValidaXML
    {
        private String Resultado;
        private String xml;

        public String Validar(string _xml, string _xsd)
        {
            Resultado = "";

            if (!File.Exists(_xml) || !File.Exists(_xsd))
            {
                return "NotFound";
            }
            xml = _xml;

            //XmlReaderSettings settings = new XmlReaderSettings();
            //settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", _xsd);
            //settings.ValidationType = ValidationType.Schema;
            //XmlReader reader = XmlReader.Create(_xml, settings);
            //XmlDocument document = new XmlDocument();
            //document.Load(reader);
            //ValidationEventHandler eventHandler = new ValidationEventHandler(reader_ValidationEventHandler);
            //// the following call to Validate succeeds.
            //document.Validate(eventHandler);


            // Cria um novo XMLValidatingReader
            XmlValidatingReader reader = new XmlValidatingReader(new XmlTextReader(new StreamReader(_xml)));
            // Cria um schemacollection
            XmlSchemaCollection schemaCollection = new XmlSchemaCollection();
            //Adiciona o XSD e o namespace
            schemaCollection.Add("http://www.portalfiscal.inf.br/nfe", _xsd);
            // Adiciona o schema ao ValidatingReader
            reader.Schemas.Add(schemaCollection);
            //Evento que retorna a mensagem de validacao
            reader.ValidationEventHandler += new ValidationEventHandler(reader_ValidationEventHandler);
            //Percorre o XML
            while (reader.Read()) { }
            reader.Close(); //Fecha o arquivo.

            //O Resultado é preenchido no reader_ValidationEventHandler
            return Resultado;
        }

        private void reader_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            var valorDoCampo = "";
            try
            {
                var stArqXML = string.Empty;
                using (var u = File.OpenText(xml))
                {
                    stArqXML = u.ReadToEnd();
                }
                var stArqFinal = stArqXML.Substring(0, e.Exception.LinePosition);
                int posInicial = stArqFinal.LastIndexOf(">") + 1;
                valorDoCampo = stArqXML.Substring(posInicial, e.Exception.LinePosition - posInicial);
            }
            catch
            {

            }

            // Como sera exibida a mensagem de ERROS de validacao
            Resultado = Resultado + String.Format("Campo:{3}" + System.Environment.NewLine +
                                                  "Valor:{4}" + System.Environment.NewLine +
                                                  "Linha:{1}" + System.Environment.NewLine +
                                                  "Coluna:{0}" + System.Environment.NewLine +
                                                  "Erro:{2}" + System.Environment.NewLine,
                                                  e.Exception.LinePosition,
                                                  e.Exception.LineNumber,
                                                  e.Exception.Message,
                                                  ((XmlReader)sender).Name,
                                                  valorDoCampo);
        }
    }
}
