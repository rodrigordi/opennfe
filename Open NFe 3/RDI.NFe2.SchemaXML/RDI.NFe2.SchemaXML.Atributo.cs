using System;
using System.Collections.Generic;
using System.Text;


namespace RDI.NFe2.SchemaXML
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ClasseServico : Attribute
    {
        public String NomeClasse { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class NFe_AtendidoPor : Attribute
    {
        public TServer ServidorAutorizador { get; set; }
        public TServer ServidorAutorizadorSVC { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class NFCe_AtendidoPor : Attribute
    {
        public TServer ServidorAutorizador { get; set; }
    }
}

