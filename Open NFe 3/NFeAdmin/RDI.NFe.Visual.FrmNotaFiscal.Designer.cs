namespace RDI.NFe.Visual
{
    partial class FrmNotaFiscal
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
            this.dgvNotaFiscal = new System.Windows.Forms.DataGridView();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbchave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.wucRefresh = new RDI.timexRefresh();
            this.Chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NFeXml = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProXml = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaFiscal)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(47, 340);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 44);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvNotaFiscal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wucRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.cbSituacao);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataFinal);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataInicial);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbLote);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbchave);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.btExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btEditar);
            this.splitContainer1.Panel2.Controls.Add(this.btFechar);
            this.splitContainer1.Size = new System.Drawing.Size(1037, 546);
            this.splitContainer1.SplitterDistance = 877;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvNotaFiscal
            // 
            this.dgvNotaFiscal.AllowUserToAddRows = false;
            this.dgvNotaFiscal.AllowUserToDeleteRows = false;
            this.dgvNotaFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaFiscal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chave,
            this.Lote,
            this.CodigoSituacao,
            this.DescricaoSituacao,
            this.DataSituacao,
            this.NFeXml,
            this.ProXml});
            this.dgvNotaFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotaFiscal.Location = new System.Drawing.Point(0, 0);
            this.dgvNotaFiscal.Name = "dgvNotaFiscal";
            this.dgvNotaFiscal.ReadOnly = true;
            this.dgvNotaFiscal.RowHeadersVisible = false;
            this.dgvNotaFiscal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaFiscal.Size = new System.Drawing.Size(877, 546);
            this.dgvNotaFiscal.TabIndex = 0;
            this.dgvNotaFiscal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaFiscal_CellDoubleClick);
            this.dgvNotaFiscal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaFiscal_CellContentClick);
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(6, 104);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(137, 21);
            this.cbSituacao.TabIndex = 25;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(6, 185);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(137, 20);
            this.dtpDataFinal.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Situação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(6, 146);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(137, 20);
            this.dtpDataInicial.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data Inicial";
            // 
            // tbLote
            // 
            this.tbLote.Location = new System.Drawing.Point(6, 65);
            this.tbLote.Name = "tbLote";
            this.tbLote.Size = new System.Drawing.Size(137, 20);
            this.tbLote.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lote";
            // 
            // tbchave
            // 
            this.tbchave.Location = new System.Drawing.Point(6, 26);
            this.tbchave.Name = "tbchave";
            this.tbchave.Size = new System.Drawing.Size(137, 20);
            this.tbchave.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chave";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(47, 390);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 44);
            this.btFiltrar.TabIndex = 13;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(47, 490);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 44);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEditar.Location = new System.Drawing.Point(47, 440);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 44);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "Visualizar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // wucRefresh
            // 
            this.wucRefresh.Location = new System.Drawing.Point(6, 211);
            this.wucRefresh.Name = "wucRefresh";
            this.wucRefresh.Size = new System.Drawing.Size(137, 50);
            this.wucRefresh.TabIndex = 26;
            // 
            // Chave
            // 
            this.Chave.DataPropertyName = "chaveNota";
            this.Chave.HeaderText = "Chave";
            this.Chave.Name = "Chave";
            this.Chave.ReadOnly = true;
            this.Chave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chave.ToolTipText = "chave gerada da Nota Fiscal";
            this.Chave.Width = 315;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "numeroLote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.ToolTipText = "número do lote de envio da Nota Fiscal";
            this.Lote.Width = 60;
            // 
            // CodigoSituacao
            // 
            this.CodigoSituacao.DataPropertyName = "codigoSituacao";
            this.CodigoSituacao.HeaderText = "Situação";
            this.CodigoSituacao.Name = "CodigoSituacao";
            this.CodigoSituacao.ReadOnly = true;
            this.CodigoSituacao.Width = 80;
            // 
            // DescricaoSituacao
            // 
            this.DescricaoSituacao.DataPropertyName = "descricaoSituacao";
            this.DescricaoSituacao.HeaderText = "Descrição";
            this.DescricaoSituacao.Name = "DescricaoSituacao";
            this.DescricaoSituacao.ReadOnly = true;
            // 
            // DataSituacao
            // 
            this.DataSituacao.DataPropertyName = "dataSituacao";
            this.DataSituacao.HeaderText = "Data";
            this.DataSituacao.Name = "DataSituacao";
            this.DataSituacao.ReadOnly = true;
            // 
            // NFeXml
            // 
            this.NFeXml.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NFeXml.HeaderText = "Xml da Nota Fiscal";
            this.NFeXml.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.NFeXml.Name = "NFeXml";
            this.NFeXml.ReadOnly = true;
            this.NFeXml.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NFeXml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NFeXml.ToolTipText = "clique na imagem para visuzalizar o XML";
            this.NFeXml.Width = 86;
            // 
            // ProXml
            // 
            this.ProXml.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProXml.HeaderText = "Xml do Processo";
            this.ProXml.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.ProXml.Name = "ProXml";
            this.ProXml.ReadOnly = true;
            this.ProXml.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProXml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProXml.ToolTipText = "clique na imagem para visuzalizar o XML";
            this.ProXml.Width = 102;
            // 
            // FrmNotaFiscal
            // 
            this.AcceptButton = this.btFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(1037, 546);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 200);
            this.Name = "FrmNotaFiscal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Fiscal";
            this.Load += new System.EventHandler(this.FrmNotaFiscal_Load);
            this.Activated += new System.EventHandler(this.FrmNotaFiscal_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaFiscal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvNotaFiscal;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbchave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSituacao;
        private timexRefresh wucRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSituacao;
        private System.Windows.Forms.DataGridViewImageColumn NFeXml;
        private System.Windows.Forms.DataGridViewImageColumn ProXml;


    }
}