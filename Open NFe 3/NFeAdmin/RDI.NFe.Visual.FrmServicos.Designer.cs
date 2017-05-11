namespace RDI.NFe.Visual
{
    partial class FrmServicos
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
            this.btFechar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvFilaDeServicos = new System.Windows.Forms.DataGridView();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRecibo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbchave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.wucRefresh = new RDI.timexRefresh();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecXml = new System.Windows.Forms.DataGridViewImageColumn();
            this.xmlCons = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilaDeServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(25, 365);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 44);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fecha&r";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Visible = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFilaDeServicos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbSituacao);
            this.splitContainer1.Panel2.Controls.Add(this.wucRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataFinal);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataInicial);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.tbRecibo);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tbLote);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbchave);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.btEditar);
            this.splitContainer1.Panel2.Controls.Add(this.btExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btFechar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(789, 570);
            this.splitContainer1.SplitterDistance = 652;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvFilaDeServicos
            // 
            this.dgvFilaDeServicos.AllowUserToAddRows = false;
            this.dgvFilaDeServicos.AllowUserToDeleteRows = false;
            this.dgvFilaDeServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilaDeServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lote,
            this.Situacao,
            this.dataSituacao,
            this.RecNum,
            this.RecXml,
            this.xmlCons});
            this.dgvFilaDeServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilaDeServicos.Location = new System.Drawing.Point(0, 0);
            this.dgvFilaDeServicos.MultiSelect = false;
            this.dgvFilaDeServicos.Name = "dgvFilaDeServicos";
            this.dgvFilaDeServicos.ReadOnly = true;
            this.dgvFilaDeServicos.RowHeadersVisible = false;
            this.dgvFilaDeServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilaDeServicos.Size = new System.Drawing.Size(652, 570);
            this.dgvFilaDeServicos.TabIndex = 0;
            this.dgvFilaDeServicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilaDeServicos_CellDoubleClick);
            this.dgvFilaDeServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilaDeServicos_CellContentClick);
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(6, 142);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(109, 21);
            this.cbSituacao.TabIndex = 37;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(6, 221);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(109, 20);
            this.dtpDataFinal.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(6, 182);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(109, 20);
            this.dtpDataInicial.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data Inicial";
            // 
            // tbRecibo
            // 
            this.tbRecibo.Location = new System.Drawing.Point(6, 64);
            this.tbRecibo.Name = "tbRecibo";
            this.tbRecibo.Size = new System.Drawing.Size(109, 20);
            this.tbRecibo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Recibo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Situação";
            // 
            // tbLote
            // 
            this.tbLote.Location = new System.Drawing.Point(6, 103);
            this.tbLote.Name = "tbLote";
            this.tbLote.Size = new System.Drawing.Size(109, 20);
            this.tbLote.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Lote";
            // 
            // tbchave
            // 
            this.tbchave.Location = new System.Drawing.Point(6, 25);
            this.tbchave.Name = "tbchave";
            this.tbchave.Size = new System.Drawing.Size(109, 20);
            this.tbchave.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chave";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(25, 415);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 44);
            this.btFiltrar.TabIndex = 22;
            this.btFiltrar.Text = "&Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEditar.Location = new System.Drawing.Point(25, 464);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 44);
            this.btEditar.TabIndex = 3;
            this.btEditar.Text = "&Visualizar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExcluir.Location = new System.Drawing.Point(25, 514);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 44);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "E&xcluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // wucRefresh
            // 
            this.wucRefresh.Location = new System.Drawing.Point(6, 247);
            this.wucRefresh.Name = "wucRefresh";
            this.wucRefresh.Size = new System.Drawing.Size(109, 50);
            this.wucRefresh.TabIndex = 36;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "numeroLote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.ToolTipText = "número do lote de envio da Nota Fiscal";
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "descSituacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.ToolTipText = "atual situação do Serviço";
            this.Situacao.Width = 200;
            // 
            // dataSituacao
            // 
            this.dataSituacao.DataPropertyName = "dataSituacao";
            this.dataSituacao.HeaderText = "Data Situação";
            this.dataSituacao.Name = "dataSituacao";
            this.dataSituacao.ReadOnly = true;
            this.dataSituacao.ToolTipText = "última atualização do Serviço";
            // 
            // RecNum
            // 
            this.RecNum.DataPropertyName = "numeroRecibo";
            this.RecNum.HeaderText = "Recibo";
            this.RecNum.Name = "RecNum";
            this.RecNum.ReadOnly = true;
            this.RecNum.ToolTipText = "protocolo de entregar do XML a SEFAZ";
            // 
            // RecXml
            // 
            this.RecXml.HeaderText = "Xml do Recibo";
            this.RecXml.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.RecXml.Name = "RecXml";
            this.RecXml.ReadOnly = true;
            this.RecXml.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RecXml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RecXml.ToolTipText = "clique na imagem para visuzalizar o XML";
            this.RecXml.Width = 60;
            // 
            // xmlCons
            // 
            this.xmlCons.HeaderText = "Xml da Consulta";
            this.xmlCons.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.xmlCons.Name = "xmlCons";
            this.xmlCons.ReadOnly = true;
            this.xmlCons.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xmlCons.ToolTipText = "clique na imagem para visuzalizar o XML";
            this.xmlCons.Width = 60;
            // 
            // FrmServicos
            // 
            this.AcceptButton = this.btFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(789, 570);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila de Serviços";
            this.Load += new System.EventHandler(this.FrmServicos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilaDeServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvFilaDeServicos;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox tbRecibo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbchave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label6;
        private timexRefresh wucRefresh;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecNum;
        private System.Windows.Forms.DataGridViewImageColumn RecXml;
        private System.Windows.Forms.DataGridViewImageColumn xmlCons;

    }
}