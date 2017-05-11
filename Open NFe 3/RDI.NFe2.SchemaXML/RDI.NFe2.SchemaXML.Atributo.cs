using System;
using System.Collections.Generic;
using System.Text;

namespace RDI.NFe2.SchemaXML
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ClasseServico : Attribute
    {
        String _value;

        public String value
        {
            get { return _value; }
            set { _value = value; }
        }
    }


    [AttributeUsage(AttributeTargets.Field)]
    public class NFe_AtendidoPor : Attribute
    {
        String _value;

        public String value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class NFCe_AtendidoPor : Attribute
    {
        String _value;

        public String value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class SVC_AtendidoPor : Attribute
    {
        String _value;

        public String value
        {
            get { return _value; }
            set { _value = value; }
        }
    }


   
}

