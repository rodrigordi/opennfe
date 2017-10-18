using RDI.NFe2.SchemaXML;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RDI.NFe2.Webservices
{
    public class UrlConfiguration
    {
        public UrlConfiguration(TServer ServerName, string Environment, TService ServiceType, string Url)
        {
            this.ServerName = ServerName;
            this.Environment = Environment;
            this.ServiceType = ServiceType;
            this.Url = Url;
        }
        public TServer ServerName { get; private set; } //SVRS, SVAN, etc...
        public String Environment { get; private set; } //PRODUCAO, HOMOLOGACAO
        public TService ServiceType { get; private set; } //PRODUCAO, HOMOLOGACAO
        public String Url { get; private set; } // https....
    }
}
