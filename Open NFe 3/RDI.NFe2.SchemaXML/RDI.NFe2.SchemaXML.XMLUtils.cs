using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using RDI.NFe2.SchemaXML310;
using System.ComponentModel;
using System.Reflection;
using System.IO.Compression;

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
        public static object XMLFactory(VersaoXML version, string stType, int size = -1)
        {
            Type type = Factory.GetXMLType(version, stType);
            if (size == -1)
                return Activator.CreateInstance(type);
            else
                return Activator.CreateInstance(type, size);

        }
        public static object CarregaXML_HD(string filename, VersaoXML versao, string stTipo)
        {
            String _xml = String.Empty;
            using (StreamReader SR = File.OpenText(filename))
            {
                _xml = SR.ReadToEnd();
                SR.Close();
                SR.Dispose();
            }
            GC.Collect();
            return CarregaXML_STR(_xml, versao, stTipo);
        }
        public static object CarregaXML_STR(string XML, VersaoXML versao, string stTipo)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(Factory.GetXMLType(versao, stTipo));
                MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(XML));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                return xs.Deserialize(memoryStream);
            }
            catch (Exception ex)
            {
                throw new XMLValidationException("Erro ao carregar o XML", ex);
            }
        }
        public static void SalvaXML_versao310(string filename, Object oXML)
        {
            SalvaXML(filename, oXML, VersaoXML.NFe_v310);
        }
        public static void SalvaXML(string filename, Object oXML, VersaoXML versao)
        {
            string stNamespace = "";
            if (versao == VersaoXML.GNRE)
                stNamespace = GNRENAMESPACE;
            else if (versao == VersaoXML.NFe_v200 ||
                versao == VersaoXML.NFe_v300 ||
                versao == VersaoXML.NFe_v310)
                stNamespace = NFeNAMESPACE;
            else if (versao == VersaoXML.Integracao)
                stNamespace = RDINAMESPACE;
            else
                stNamespace = "";//padrao


            MemoryStream memoryStream = new MemoryStream();
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add("", stNamespace);
            XmlSerializer xs = new XmlSerializer(oXML.GetType());
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, new System.Text.UTF8Encoding(false));
            xs.Serialize(xmlTextWriter, oXML, xsn);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            Byte[] characters = memoryStream.ToArray();
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            StreamWriter oSW = File.CreateText(filename);
            oSW.Write(encoding.GetString(characters));
            oSW.Close();
        }
        public static String GetXML(Object oXML, VersaoXML versao)
        {
            string stNamespace = "";
            if (versao == VersaoXML.GNRE)
                stNamespace = GNRENAMESPACE;
            else if (versao == VersaoXML.NFe_v200 ||
                versao == VersaoXML.NFe_v300 ||
                versao == VersaoXML.NFe_v310)
                stNamespace = NFeNAMESPACE;
            else if (versao == VersaoXML.Integracao)
                stNamespace = RDINAMESPACE;
            else
                stNamespace = "";//padrao

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


    }
}
