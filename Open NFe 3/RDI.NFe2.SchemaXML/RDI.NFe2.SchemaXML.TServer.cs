using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.ComponentModel;
using RDI.NFe2.SchemaXML;
using System.Collections.Generic;

namespace RDI.NFe2.SchemaXML
{
    public enum TServer
    {
        NaoMapeado,
        NFe_AM,
        NFe_BA,
        NFe_CE,
        NFe_GO,
        NFe_MG,
        NFe_MS,
        NFe_MT,
        NFe_PE,
        NFe_PR,
        NFe_RS,
        NFe_SP,
        NFe_SVAN,
        NFe_SVRS,
        NFe_SVCAN,
        NFe_SVCRS,
        NFe_AN,

        NFCe_AM,
        NFCe_MS,
        NFCe_MT,
        NFCe_SP,
        NFCe_SVRS,
    }
}