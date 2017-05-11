using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDI.NFe.Visual
{
    public class CustomForm
    {
        public System.Windows.Forms.Form Frm { get; set; }
        public System.Windows.Forms.ToolStripItem Item { get; set; }
        public bool blockChange { get; set; }
    }
}
