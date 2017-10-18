using System;
using System.Collections;
using System.Collections.Generic;

namespace RDI.NFe2.Webservices
{
    [AttributeUsage(AttributeTargets.Field)]
    public class HubConfiguration : Attribute
    {
        public String WSName { get; set; }
        public String WSMethod { get; set; }
    }
}
