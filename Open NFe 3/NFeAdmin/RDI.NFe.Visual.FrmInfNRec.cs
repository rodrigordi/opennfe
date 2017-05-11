using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;
using RDI.Lince;
using System.Collections;
using RDI.NFe2.ORMAP;

namespace RDI.NFe.Visual
{
    public partial class FrmInfNRec : Form
    {
        public event EventHandler DoOnOkClick;
        
        public FrmInfNRec()
        {
            InitializeComponent();
        }

        public Label LabelPergunta
        {
            get
            {
                return label1;
            }
        }

        public TextBox TextResposta
        {
            get
            {
                return txtnRec;
            }
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (DoOnOkClick != null)
                DoOnOkClick(sender, e);
        }



      

        
    }
}
