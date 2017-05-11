namespace RDI.NFe.Visual
{
    partial class FrmEditNota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.btCancela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tvXmlNota = new System.Windows.Forms.TreeView();
            this.tbProcFinal = new System.Windows.Forms.TextBox();
            this.tvProcFinal = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tvXmlCancelamento = new System.Windows.Forms.TreeView();
            this.tvProcCancelamento = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.tpEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XmlPedido = new System.Windows.Forms.DataGridViewImageColumn();
            this.XmlProcesso = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProcEvento = new System.Windows.Forms.DataGridViewImageColumn();
            this.print = new System.Windows.Forms.DataGridViewImageColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txnProtCanc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txcStat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txxMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txnProt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txDesSit = new System.Windows.Forms.TextBox();
            this.txDatSit = new System.Windows.Forms.TextBox();
            this.txCodSit = new System.Windows.Forms.TextBox();
            this.txLote = new System.Windows.Forms.TextBox();
            this.txChaveNota = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btAtualizarTela = new System.Windows.Forms.Button();
            this.btRefreshId = new System.Windows.Forms.Button();
            this.btImprime = new System.Windows.Forms.Button();
            this.sfdProcNFe = new System.Windows.Forms.SaveFileDialog();
            this.sfdProcNFeCCe = new System.Windows.Forms.SaveFileDialog();
            this.sfdProcCancNFe = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Xml da Nota";
            // 
            // btCancela
            // 
            this.btCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancela.Location = new System.Drawing.Point(712, 3);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(99, 44);
            this.btCancela.TabIndex = 1;
            this.btCancela.Text = "Fechar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Descrição da Situação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data da Situação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Código da Situação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lote";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.txnProtCanc);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.txcStat);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.txxMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txnProt);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txDesSit);
            this.splitContainer1.Panel1.Controls.Add(this.txDatSit);
            this.splitContainer1.Panel1.Controls.Add(this.txCodSit);
            this.splitContainer1.Panel1.Controls.Add(this.txLote);
            this.splitContainer1.Panel1.Controls.Add(this.txChaveNota);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.btAtualizarTela);
            this.splitContainer1.Panel2.Controls.Add(this.btRefreshId);
            this.splitContainer1.Panel2.Controls.Add(this.btImprime);
            this.splitContainer1.Panel2.Controls.Add(this.btCancela);
            this.splitContainer1.Size = new System.Drawing.Size(818, 680);
            this.splitContainer1.SplitterDistance = 626;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 451);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tvXmlNota);
            this.tabPage1.Controls.Add(this.tbProcFinal);
            this.tabPage1.Controls.Add(this.tvProcFinal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NFe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Gerar ProcNFe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Xml do Processo";
            // 
            // tvXmlNota
            // 
            this.tvXmlNota.Location = new System.Drawing.Point(18, 19);
            this.tvXmlNota.Name = "tvXmlNota";
            this.tvXmlNota.Size = new System.Drawing.Size(380, 371);
            this.tvXmlNota.TabIndex = 22;
            // 
            // tbProcFinal
            // 
            this.tbProcFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProcFinal.Location = new System.Drawing.Point(426, 19);
            this.tbProcFinal.MaxLength = 100;
            this.tbProcFinal.Multiline = true;
            this.tbProcFinal.Name = "tbProcFinal";
            this.tbProcFinal.Size = new System.Drawing.Size(362, 371);
            this.tbProcFinal.TabIndex = 30;
            this.tbProcFinal.Visible = false;
            // 
            // tvProcFinal
            // 
            this.tvProcFinal.Location = new System.Drawing.Point(426, 19);
            this.tvProcFinal.Name = "tvProcFinal";
            this.tvProcFinal.Size = new System.Drawing.Size(362, 371);
            this.tvProcFinal.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tvXmlCancelamento);
            this.tabPage2.Controls.Add(this.tvProcCancelamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cancelamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Gerar procCancNFe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Xml do Processo de Cancelamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Xml da Cancelamento";
            // 
            // tvXmlCancelamento
            // 
            this.tvXmlCancelamento.Location = new System.Drawing.Point(16, 22);
            this.tvXmlCancelamento.Name = "tvXmlCancelamento";
            this.tvXmlCancelamento.Size = new System.Drawing.Size(381, 368);
            this.tvXmlCancelamento.TabIndex = 34;
            // 
            // tvProcCancelamento
            // 
            this.tvProcCancelamento.Location = new System.Drawing.Point(429, 22);
            this.tvProcCancelamento.Name = "tvProcCancelamento";
            this.tvProcCancelamento.Size = new System.Drawing.Size(363, 368);
            this.tvProcCancelamento.TabIndex = 34;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dgvEventos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(804, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eventos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Carta de correção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpEvento,
            this.situacao,
            this.XmlPedido,
            this.XmlProcesso,
            this.ProcEvento,
            this.print});
            this.dgvEventos.Location = new System.Drawing.Point(9, 6);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(784, 387);
            this.dgvEventos.TabIndex = 36;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick);
            this.dgvEventos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentDoubleClick);
            // 
            // tpEvento
            // 
            this.tpEvento.DataPropertyName = "descTpEvento";
            this.tpEvento.HeaderText = "Tipo";
            this.tpEvento.Name = "tpEvento";
            this.tpEvento.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "descSituacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 320;
            // 
            // XmlPedido
            // 
            this.XmlPedido.HeaderText = "XmlPedido";
            this.XmlPedido.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.XmlPedido.Name = "XmlPedido";
            this.XmlPedido.ReadOnly = true;
            this.XmlPedido.Width = 75;
            // 
            // XmlProcesso
            // 
            this.XmlProcesso.HeaderText = "XmlProcesso";
            this.XmlProcesso.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.XmlProcesso.Name = "XmlProcesso";
            this.XmlProcesso.ReadOnly = true;
            this.XmlProcesso.Width = 75;
            // 
            // ProcEvento
            // 
            this.ProcEvento.HeaderText = "ProcEvento";
            this.ProcEvento.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.ProcEvento.Name = "ProcEvento";
            this.ProcEvento.ReadOnly = true;
            this.ProcEvento.Width = 75;
            // 
            // print
            // 
            this.print.HeaderText = "Imprimir";
            this.print.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.print.Name = "print";
            this.print.ReadOnly = true;
            this.print.Width = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Prot. Cancelamento";
            // 
            // txnProtCanc
            // 
            this.txnProtCanc.BackColor = System.Drawing.Color.White;
            this.txnProtCanc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txnProtCanc.Location = new System.Drawing.Point(543, 138);
            this.txnProtCanc.MaxLength = 100;
            this.txnProtCanc.Name = "txnProtCanc";
            this.txnProtCanc.ReadOnly = true;
            this.txnProtCanc.Size = new System.Drawing.Size(256, 20);
            this.txnProtCanc.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "cStat (SEFAZ)";
            // 
            // txcStat
            // 
            this.txcStat.BackColor = System.Drawing.Color.White;
            this.txcStat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txcStat.Location = new System.Drawing.Point(129, 86);
            this.txcStat.MaxLength = 100;
            this.txcStat.Name = "txcStat";
            this.txcStat.ReadOnly = true;
            this.txcStat.Size = new System.Drawing.Size(302, 20);
            this.txcStat.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "xMotivo (SEFAZ)";
            // 
            // txxMotivo
            // 
            this.txxMotivo.BackColor = System.Drawing.Color.White;
            this.txxMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txxMotivo.Location = new System.Drawing.Point(129, 112);
            this.txxMotivo.MaxLength = 100;
            this.txxMotivo.Name = "txxMotivo";
            this.txxMotivo.ReadOnly = true;
            this.txxMotivo.Size = new System.Drawing.Size(670, 20);
            this.txxMotivo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prot. de Autorização";
            // 
            // txnProt
            // 
            this.txnProt.BackColor = System.Drawing.Color.White;
            this.txnProt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txnProt.Location = new System.Drawing.Point(129, 139);
            this.txnProt.MaxLength = 100;
            this.txnProt.Name = "txnProt";
            this.txnProt.ReadOnly = true;
            this.txnProt.Size = new System.Drawing.Size(302, 20);
            this.txnProt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chave da Nota";
            // 
            // txDesSit
            // 
            this.txDesSit.BackColor = System.Drawing.Color.White;
            this.txDesSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDesSit.Location = new System.Drawing.Point(129, 60);
            this.txDesSit.MaxLength = 100;
            this.txDesSit.Name = "txDesSit";
            this.txDesSit.ReadOnly = true;
            this.txDesSit.Size = new System.Drawing.Size(670, 20);
            this.txDesSit.TabIndex = 6;
            // 
            // txDatSit
            // 
            this.txDatSit.BackColor = System.Drawing.Color.White;
            this.txDatSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDatSit.Location = new System.Drawing.Point(543, 34);
            this.txDatSit.MaxLength = 100;
            this.txDatSit.Name = "txDatSit";
            this.txDatSit.ReadOnly = true;
            this.txDatSit.Size = new System.Drawing.Size(256, 20);
            this.txDatSit.TabIndex = 5;
            // 
            // txCodSit
            // 
            this.txCodSit.BackColor = System.Drawing.Color.White;
            this.txCodSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCodSit.Location = new System.Drawing.Point(129, 34);
            this.txCodSit.MaxLength = 300;
            this.txCodSit.Name = "txCodSit";
            this.txCodSit.ReadOnly = true;
            this.txCodSit.Size = new System.Drawing.Size(302, 20);
            this.txCodSit.TabIndex = 4;
            // 
            // txLote
            // 
            this.txLote.BackColor = System.Drawing.Color.White;
            this.txLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txLote.Location = new System.Drawing.Point(543, 8);
            this.txLote.MaxLength = 50;
            this.txLote.Name = "txLote";
            this.txLote.ReadOnly = true;
            this.txLote.Size = new System.Drawing.Size(256, 20);
            this.txLote.TabIndex = 3;
            // 
            // txChaveNota
            // 
            this.txChaveNota.BackColor = System.Drawing.Color.White;
            this.txChaveNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txChaveNota.Location = new System.Drawing.Point(129, 8);
            this.txChaveNota.MaxLength = 11;
            this.txChaveNota.Name = "txChaveNota";
            this.txChaveNota.ReadOnly = true;
            this.txChaveNota.Size = new System.Drawing.Size(302, 20);
            this.txChaveNota.TabIndex = 2;
            this.txChaveNota.Text = "NFE99999999999999999999999999999999999999999999";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(607, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 44);
            this.button5.TabIndex = 39;
            this.button5.Text = "Enviar Protocolo de Cancelamento";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btAtualizarTela
            // 
            this.btAtualizarTela.Location = new System.Drawing.Point(292, 3);
            this.btAtualizarTela.Name = "btAtualizarTela";
            this.btAtualizarTela.Size = new System.Drawing.Size(99, 44);
            this.btAtualizarTela.TabIndex = 38;
            this.btAtualizarTela.Text = "Atualizar Tela";
            this.btAtualizarTela.UseVisualStyleBackColor = true;
            this.btAtualizarTela.Click += new System.EventHandler(this.btAtualizarTela_Click);
            // 
            // btRefreshId
            // 
            this.btRefreshId.Location = new System.Drawing.Point(397, 3);
            this.btRefreshId.Name = "btRefreshId";
            this.btRefreshId.Size = new System.Drawing.Size(99, 44);
            this.btRefreshId.TabIndex = 6;
            this.btRefreshId.Text = "Atualizar Registro pelo Id";
            this.btRefreshId.UseVisualStyleBackColor = true;
            this.btRefreshId.Click += new System.EventHandler(this.btRefreshId_Click);
            // 
            // btImprime
            // 
            this.btImprime.Location = new System.Drawing.Point(502, 3);
            this.btImprime.Name = "btImprime";
            this.btImprime.Size = new System.Drawing.Size(99, 44);
            this.btImprime.TabIndex = 2;
            this.btImprime.Text = "Imprimir DANFE";
            this.btImprime.UseVisualStyleBackColor = true;
            this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
            // 
            // sfdProcNFe
            // 
            this.sfdProcNFe.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdProcNFe_FileOk);
            // 
            // sfdProcNFeCCe
            // 
            this.sfdProcNFeCCe.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdProcNFe_FileOkCCe);
            // 
            // sfdProcCancNFe
            // 
            this.sfdProcCancNFe.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdProcCancNFe_FileOk);
            // 
            // FrmEditNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(818, 680);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditNota";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhamento de Nota Fiscal";
            this.Load += new System.EventHandler(this.FrmEditNota_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDesSit;
        private System.Windows.Forms.TextBox txDatSit;
        private System.Windows.Forms.TextBox txCodSit;
        private System.Windows.Forms.TextBox txLote;
        private System.Windows.Forms.TextBox txChaveNota;
        private System.Windows.Forms.Button btImprime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvXmlNota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txcStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txxMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txnProt;
        private System.Windows.Forms.TreeView tvProcFinal;
        private System.Windows.Forms.TextBox tbProcFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txnProtCanc;
        private System.Windows.Forms.TreeView tvXmlCancelamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TreeView tvProcCancelamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btRefreshId;
        private System.Windows.Forms.SaveFileDialog sfdProcNFe;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SaveFileDialog sfdProcNFeCCe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog sfdProcCancNFe;
        private System.Windows.Forms.Button btAtualizarTela;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewImageColumn XmlPedido;
        private System.Windows.Forms.DataGridViewImageColumn XmlProcesso;
        private System.Windows.Forms.DataGridViewImageColumn ProcEvento;
        private System.Windows.Forms.DataGridViewImageColumn print;
    }
}