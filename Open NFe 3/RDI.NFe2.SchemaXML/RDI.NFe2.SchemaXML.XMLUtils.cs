using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.ComponentModel;
using System.Reflection;
using System.IO.Compression;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;

namespace RDI.NFe2.SchemaXML
{
    public class XMLValidationException : Exception
    {
        public XMLValidationException() : base()
        {

        }
        public XMLValidationException(string message) : base(message)
        {

        }
        public XMLValidationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

    public static class XMLUtils
    {
        public const string RDINAMESPACE = "http://www.rochadigital.com/opennfe";
        public const string NFeNAMESPACE = "http://www.portalfiscal.inf.br/nfe";
        public const string GNRENAMESPACE = "http://www.gnre.pe.gov.br";

        public const string NFeSchema200ns = "RDI.NFe2.SchemaXML.NFe_v200.";
        public const string NFeSchema300ns = "RDI.NFe2.SchemaXML.NFe_v300.";
        public const string NFeSchema310ns = "RDI.NFe2.SchemaXML.NFe_v310.";
        public const string NFeSchema400ns = "RDI.NFe2.SchemaXML.NFe_v400.";
        public const string IntegracaoSchema100ns = "RDI.NFe2.SchemaXML.";
        public const string EventosSchema100ns = "RDI.NFe2.SchemaXML.Eventos_v100.";
        public const string DFeSchema101ns = "RDI.NFe2.SchemaXML.DocumentosFiscaisEletronicos_v101.";
        public const string ConsCad100ns = "RDI.NFe2.SchemaXML.ConsultaCadastro.";
        public const string GNRESchema100ns = "RDI.NFe2.GNRE.";

        public static string GetXMLNamespace(VersaoXML version)
        {
            var stNamespace = string.Empty;
            switch (version)
            {
                case VersaoXML.NFe_v200:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.NFe_v300:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.NFe_v310:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.Integracao:
                    stNamespace = RDINAMESPACE;
                    break;
                case VersaoXML.GNRE:
                    stNamespace = GNRENAMESPACE;
                    break;
                case VersaoXML.NFe_v400:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.Eventos_v100:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.ConsultaCadastro_v100:
                    stNamespace = NFeNAMESPACE;
                    break;
                case VersaoXML.DocumentosFiscaisEletronicos_v101:
                    stNamespace = NFeNAMESPACE;
                    break;
                default:
                    break;
            }

            return stNamespace;
        }
        public static Type GetXMLType(VersaoXML version, string stType)
        {
            Type tipo = null;
            switch (version)
            {
                case VersaoXML.NFe_v200:
                    tipo = Type.GetType(NFeSchema200ns + stType);
                    break;
                case VersaoXML.NFe_v300:
                    tipo = Type.GetType(NFeSchema300ns + stType);
                    break;
                case VersaoXML.NFe_v310:
                    tipo = Type.GetType(NFeSchema310ns + stType);
                    break;
                case VersaoXML.Integracao:
                    tipo = Type.GetType(IntegracaoSchema100ns + stType);
                    break;
                case VersaoXML.GNRE:
                    tipo = Type.GetType(GNRESchema100ns + stType);
                    break;
                case VersaoXML.NFe_v400:
                    tipo = Type.GetType(NFeSchema400ns + stType);
                    break;
                case VersaoXML.Eventos_v100:
                    tipo = Type.GetType(EventosSchema100ns + stType);
                    break;
                case VersaoXML.ConsultaCadastro_v100:
                    tipo = Type.GetType(ConsCad100ns + stType);
                    break;
                case VersaoXML.DocumentosFiscaisEletronicos_v101:
                    tipo = Type.GetType(DFeSchema101ns + stType);
                    break;
                default:
                    break;
            }

            return tipo;
        }
        public static object XMLFactory(VersaoXML version, string stType, int size = -1)
        {
            Type type = GetXMLType(version, stType);
            if (size == -1)
                return Activator.CreateInstance(type);
            else
                return Activator.CreateInstance(type, size);
        }

        public static XmlCDataSection CreateCData(string text)
        {
            XmlDocument document = new XmlDocument();
            return document.CreateCDataSection(text);
        }

        public static TCOrgaoIBGE ToCOrgaoIBGE(this TCodUfIBGE CodUfIBGE)
        {
            FieldInfo sourceField = CodUfIBGE.GetType().GetField(CodUfIBGE.ToString());
            XmlEnumAttribute[] attributes = (XmlEnumAttribute[])sourceField.GetCustomAttributes(typeof(XmlEnumAttribute), false);
            FieldInfo resultField = null;

            if (attributes != null && attributes.Length > 0)
            {
                Type enumTypeResult = typeof(TCOrgaoIBGE);

                foreach (FieldInfo item in enumTypeResult.GetFields())
                {
                    bool find = false;
                    foreach (XmlEnumAttribute att in item.GetCustomAttributes(typeof(XmlEnumAttribute), false))
                    {
                        if (att.Name == attributes[0].Name)
                        {
                            resultField = item;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }
            }
            else
            {
                throw new Exception("Tipo de dados não contém XmlEnumAttribute");
            }

            if (resultField == null)
                return TCOrgaoIBGE.Item90;
            else
                return (TCOrgaoIBGE)resultField.GetValue(resultField);
        }
        public static TCodUfIBGE ToCodUfIBGE(this TCOrgaoIBGE COrgaoIBGE)
        {
            FieldInfo sourceField = COrgaoIBGE.GetType().GetField(COrgaoIBGE.ToString());
            XmlEnumAttribute[] attributes = (XmlEnumAttribute[])sourceField.GetCustomAttributes(typeof(XmlEnumAttribute), false);
            FieldInfo resultField = null;

            if (attributes != null && attributes.Length > 0)
            {
                Type enumTypeResult = typeof(TCodUfIBGE);

                foreach (FieldInfo item in enumTypeResult.GetFields())
                {
                    bool find = false;
                    foreach (XmlEnumAttribute att in item.GetCustomAttributes(typeof(XmlEnumAttribute), false))
                    {
                        if (att.Name == attributes[0].Name)
                        {
                            resultField = item;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }
            }
            else
            {
                throw new Exception("Tipo de dados não contém XmlEnumAttribute");
            }

            return (TCodUfIBGE)resultField.GetValue(resultField);
        }

        public static TEnum GetEnumFromXmlEnumAttributeValue<TEnum>(this string value) where TEnum : struct, IConvertible
        {
            FieldInfo resultField = null;
            foreach (FieldInfo fi in typeof(TEnum).GetFields())
            {
                bool found = false;
                foreach (XmlEnumAttribute att in fi.GetCustomAttributes(typeof(XmlEnumAttribute), false))
                {
                    if (att.Name == value)
                    {
                        resultField = fi;
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            if (resultField == null)
                throw new Exception("Valor informado não existe para XMLEnumAttribute de " + typeof(TEnum).ToString());
            else
                return (TEnum)resultField.GetValue(resultField);
        }
        public static string GetXmlEnumAttributeValueFromEnum<TEnum>(this TEnum value) where TEnum : struct, IConvertible
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum) return null;//or string.Empty, or throw exception

            var member = enumType.GetMember(value.ToString()).FirstOrDefault();
            if (member == null) return null;//or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) return null;//or string.Empty, or throw exception

            return attribute.Name;
        }
        public static string GetXmlEnumAttributeValueFromEnum(this Enum value) //where TEnum : struct, IConvertible
        {
            var enumType = value.GetType();
            if (!enumType.IsEnum) return null;//or string.Empty, or throw exception

            var member = enumType.GetMember(value.ToString()).FirstOrDefault();
            if (member == null) return null;//or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) return null;//or string.Empty, or throw exception

            return attribute.Name;
        }
        public static string GetDescriptionAttribute(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : value.ToString();
        }

        public static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }
        public static byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }
        public static string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }
        public static string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes
                  = System.Text.ASCIIEncoding.UTF8.GetBytes(toEncode);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        public static string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes
                = System.Convert.FromBase64String(encodedData);
            string returnValue =
               System.Text.ASCIIEncoding.UTF8.GetString(encodedDataAsBytes);
            return returnValue;
        }
        public static Byte[] StringToUTF8ByteArray(string pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }


        public static string GetXML(object oXML, VersaoXML versao)
        {
            string stNamespace = GetXMLNamespace(versao);

            MemoryStream memoryStream = new MemoryStream();
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add("", stNamespace);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(oXML.GetType());
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, new System.Text.UTF8Encoding(false));
            xs.Serialize(xmlTextWriter, oXML, xsn);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            Byte[] characters = memoryStream.ToArray();
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetString(characters);
        }
        public static void SaveXML(string fileName, object oXML, VersaoXML versao)
        {
            string stNamespace = GetXMLNamespace(versao);

            if (System.IO.File.Exists(fileName))
                System.IO.File.Delete(fileName);

            MemoryStream memoryStream = new MemoryStream();
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add("", stNamespace);
            XmlSerializer xs = new XmlSerializer(oXML.GetType());
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, new System.Text.UTF8Encoding(false));
            xs.Serialize(xmlTextWriter, oXML, xsn);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            Byte[] characters = memoryStream.ToArray();
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            StreamWriter oSW = File.CreateText(fileName);
            oSW.Write(encoding.GetString(characters));
            oSW.Close();
        }


        public static object LoadXMLFile(string fileName, VersaoXML versao, string stTipo)
        {
            String _xml = String.Empty;
            using (StreamReader SR = File.OpenText(fileName))
            {
                _xml = SR.ReadToEnd();
                SR.Close();
                SR.Dispose();
            }
            GC.Collect();
            return LoadXML(_xml, versao, stTipo);
        }
        public static T LoadXMLFile<T>(string fileName)
        {
            String _xml = String.Empty;
            using (StreamReader SR = File.OpenText(fileName))
            {
                _xml = SR.ReadToEnd();
                SR.Close();
                SR.Dispose();
            }
            GC.Collect();
            return LoadXML<T>(_xml);
        }
        public static object LoadXML(string XML, VersaoXML versao, string stTipo)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(GetXMLType(versao, stTipo));
                MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(XML));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                return xs.Deserialize(memoryStream);
            }
            catch (Exception ex)
            {
                throw new XMLValidationException("Erro ao carregar o XML", ex);
            }
        }
        public static T LoadXML<T>(string XML)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(XML));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                return (T)xs.Deserialize(memoryStream);
            }
            catch (Exception ex)
            {
                throw new XMLValidationException("Erro ao carregar o XML", ex);
            }
        }

        public static string GetDigestValue_SHA1(string XML, string URI = "infNFe")
        {
            XmlDocument docSource = new XmlDocument();
            docSource.PreserveWhitespace = false;
            docSource.LoadXml(XML);
            var serializer = new XmlDsigExcC14NTransform();
            string toBeCanonicalized = docSource.GetElementsByTagName(URI).Item(0).OuterXml;
            XmlDocument docCanonicalized = new XmlDocument();
            docCanonicalized.LoadXml(toBeCanonicalized);
            serializer.LoadInput(docCanonicalized);
            string c14n = new StreamReader((Stream)serializer.GetOutput(typeof(Stream))).ReadToEnd();
            var HashAlg = SHA1.Create();
            byte[] hash = HashAlg.ComputeHash(Encoding.UTF8.GetBytes(c14n));
            var stHash = Convert.ToBase64String(hash);

            return stHash;
        }
    }
}
