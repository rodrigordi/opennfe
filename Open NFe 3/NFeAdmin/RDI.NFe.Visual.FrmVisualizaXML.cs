using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;

namespace RDI.NFe.Visual
{
    public partial class FrmVisualizaXML : Form
    {
        System.Xml.XmlDocument xmlDoc;
        String xml;
        public FrmVisualizaXML(String XML)
        {
            InitializeComponent();
            xml = XML;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmVisualizaXML_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(xml))
            {
                xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(xml);
                NFeUtils.PopulaTreeView(xmlDoc, tvXmlNota);
            }
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML file|*.xml";
            saveFileDialog1.Title = "Salve o arquivo XML";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    xmlDoc.Save(saveFileDialog1.FileName);
                }
            }
        }

    }
}