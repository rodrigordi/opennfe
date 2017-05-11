using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using RDI.Lince;
using RDI.NFe2.ORMAP;
using System.Xml.Serialization;
using System.Reflection;
using RDI.NFe2.SchemaXML;
using System.Xml;
using System.IO;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace RDI.NFe2.Business
{
    public static class NotaFiscalExt
    {
        public static List<Evento> CarregarEventos(this NotaFiscal oNFe, ClientEnvironment clientEnvironment)
        {
            EventoQry oEventoQry = new EventoQry();
            oEventoQry.empresa = oNFe.empresa;
            oEventoQry.chaveNota = oNFe.chaveNota;
            oEventoQry.numeroLote = oNFe.numeroLote.ToString();
            ArrayList ListaParam = EventoDAL.Instance.GetInstances(oEventoQry, clientEnvironment);
            oEventoQry = null;
            return ListaParam.Cast<Evento>().ToList<Evento>();
        }

        public static bool CanceladaPorEvento(this NotaFiscal oNFe, ClientEnvironment clientEnvironment)
        {
            return oNFe.CarregarEventos(clientEnvironment).Exists(ev => ev.tpEvento == TEventoInfEventoTpEvento.Cancelamento &&
                          (ev.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado135
                          || ev.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado136
                          || ev.codigoSituacao == TipoSituacaoEvento.FinalizadoAprovado155));
        }
    }

    public class Empresa
    {
        public string cnpj { get; set; }
        public bool habilitada { get; set; }
        public Boolean AutomacaoHabilitada { get; set; }

        public string pastaEntrada { get; set; }
    }

    public class ResultadoAssinatura
    {
        //public TipoSituacaoNota codigoRetorno { get; set; }
        public OpenSigner.TRetornoAssinatura codigoRetorno { get; set; }
        public string mensagem { get; set; }
    }

    public class XmlWriterListener : XmlWriter
    {
        private XmlWriter _me;
        private XmlTextWriter _bu;
        private StringWriter _sw;

        public XmlWriterListener(XmlWriter implementation)
        {
            _me = implementation;
            _sw = new StringWriter();
            _bu = new XmlTextWriter(_sw);
            _bu.Formatting = Formatting.Indented;
        }

        public override void Flush()
        {
            _me.Flush();
            _bu.Flush();
            _sw.Flush();
        }
        public string Xml { get { return (_sw == null ? null : _sw.ToString()); } }

        public override void Close() { _me.Close(); _bu.Close(); }
        public override string LookupPrefix(string ns) { return _me.LookupPrefix(ns); }
        public override void WriteBase64(byte[] buffer, int index, int count) { _me.WriteBase64(buffer, index, count); _bu.WriteBase64(buffer, index, count); }
        public override void WriteCData(string text) { _me.WriteCData(text); _bu.WriteCData(text); }
        public override void WriteCharEntity(char ch) { _me.WriteCharEntity(ch); _bu.WriteCharEntity(ch); }
        public override void WriteChars(char[] buffer, int index, int count) { _me.WriteChars(buffer, index, count); _bu.WriteChars(buffer, index, count); }
        public override void WriteComment(string text) { _me.WriteComment(text); _bu.WriteComment(text); }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { _me.WriteDocType(name, pubid, sysid, subset); _bu.WriteDocType(name, pubid, sysid, subset); }
        public override void WriteEndAttribute() { _me.WriteEndAttribute(); _bu.WriteEndAttribute(); }
        public override void WriteEndDocument() { _me.WriteEndDocument(); _bu.WriteEndDocument(); }
        public override void WriteEndElement() { _me.WriteEndElement(); _bu.WriteEndElement(); }
        public override void WriteEntityRef(string name) { _me.WriteEntityRef(name); _bu.WriteEntityRef(name); }
        public override void WriteFullEndElement() { _me.WriteFullEndElement(); _bu.WriteFullEndElement(); }
        public override void WriteProcessingInstruction(string name, string text) { _me.WriteProcessingInstruction(name, text); _bu.WriteProcessingInstruction(name, text); }
        public override void WriteRaw(string data) { _me.WriteRaw(data); _bu.WriteRaw(data); }
        public override void WriteRaw(char[] buffer, int index, int count) { _me.WriteRaw(buffer, index, count); _bu.WriteRaw(buffer, index, count); }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { _me.WriteStartAttribute(prefix, localName, ns); _bu.WriteStartAttribute(prefix, localName, ns); }
        public override void WriteStartDocument(bool standalone) { _me.WriteStartDocument(standalone); _bu.WriteStartDocument(standalone); }
        public override void WriteStartDocument() { _me.WriteStartDocument(); _bu.WriteStartDocument(); }
        public override void WriteStartElement(string prefix, string localName, string ns) { _me.WriteStartElement(prefix, localName, ns); _bu.WriteStartElement(prefix, localName, ns); }
        public override WriteState WriteState { get { return _me.WriteState; } }
        public override void WriteString(string text) { _me.WriteString(text); _bu.WriteString(text); }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { _me.WriteSurrogateCharEntity(lowChar, highChar); _bu.WriteSurrogateCharEntity(lowChar, highChar); }
        public override void WriteWhitespace(string ws) { _me.WriteWhitespace(ws); _bu.WriteWhitespace(ws); }
    }

    public class WebServiceListener : HWS.SVRS.Consulta.NfeConsulta2 //System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        private XmlWriterListener writer;
        protected override XmlWriter GetWriterForMessage(SoapClientMessage message, int bufferSize)
        {
            writer = new XmlWriterListener(base.GetWriterForMessage(message, bufferSize));
            return writer;
        }

        protected override XmlReader GetReaderForMessage(SoapClientMessage message, int bufferSize)
        {
            System.Xml.XmlReader aReader = base.GetReaderForMessage(message, bufferSize);
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(aReader);

            Response = doc.InnerXml;

            return new XmlNodeReader(doc);
        }

        public string Request { get { return (writer == null ? null : writer.Xml); } }
        public string Response { get; set; }
    }



}
