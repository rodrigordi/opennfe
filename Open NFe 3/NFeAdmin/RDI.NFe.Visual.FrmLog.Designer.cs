namespace RDI.NFe.Visual
{
    partial class FrmLog
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wucRefresh = new RDI.timexRefresh();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.tbchave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(853, 9);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 44);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wucRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataFinal);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataInicial);
            this.splitContainer1.Panel2.Controls.Add(this.tbchave);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btEditar);
            this.splitContainer1.Panel2.Controls.Add(this.btFechar);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 546);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.DataSituacao,
            this.CodigoSituacao,
            this.DescricaoSituacao,
            this.Chave});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(1061, 485);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellContentClick);
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "NumeroLog";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // DataSituacao
            // 
            this.DataSituacao.DataPropertyName = "data";
            this.DataSituacao.HeaderText = "Data da Situação";
            this.DataSituacao.Name = "DataSituacao";
            this.DataSituacao.ReadOnly = true;
            // 
            // CodigoSituacao
            // 
            this.CodigoSituacao.DataPropertyName = "codigoSituacao";
            this.CodigoSituacao.HeaderText = "Código da Situação";
            this.CodigoSituacao.Name = "CodigoSituacao";
            this.CodigoSituacao.ReadOnly = true;
            // 
            // DescricaoSituacao
            // 
            this.DescricaoSituacao.DataPropertyName = "descricaoSituacao";
            this.DescricaoSituacao.HeaderText = "Descricao da Situação";
            this.DescricaoSituacao.Name = "DescricaoSituacao";
            this.DescricaoSituacao.ReadOnly = true;
            this.DescricaoSituacao.Width = 250;
            // 
            // Chave
            // 
            this.Chave.DataPropertyName = "chaveNota";
            this.Chave.HeaderText = "Chave";
            this.Chave.Name = "Chave";
            this.Chave.ReadOnly = true;
            this.Chave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chave.ToolTipText = "chave gerada da Nota Fiscal";
            this.Chave.Width = 320;
            // 
            // wucRefresh
            // 
            this.wucRefresh.Location = new System.Drawing.Point(696, 6);
            this.wucRefresh.Name = "wucRefresh";
            this.wucRefresh.Size = new System.Drawing.Size(70, 50);
            this.wucRefresh.TabIndex = 15;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(552, 29);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(109, 20);
            this.dtpDataFinal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(552, 6);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(109, 20);
            this.dtpDataInicial.TabIndex = 12;
            // 
            // tbchave
            // 
            this.tbchave.Location = new System.Drawing.Point(230, 6);
            this.tbchave.Name = "tbchave";
            this.tbchave.Size = new System.Drawing.Size(137, 20);
            this.tbchave.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chave";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(772, 9);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 44);
            this.btFiltrar.TabIndex = 8;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Inicial";
            // 
            // btExcluir
            // 
            this.btExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(12, 9);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 44);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(93, 9);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 44);
            this.btEditar.TabIndex = 4;
            this.btEditar.Text = "Visualizar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // FrmLog
            // 
            this.AcceptButton = this.btFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(1061, 546);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Activated += new System.EventHandler(this.FrmLog_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbchave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private timexRefresh wucRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chave;


    }
}