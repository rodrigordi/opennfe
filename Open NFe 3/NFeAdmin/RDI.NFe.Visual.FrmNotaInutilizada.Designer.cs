namespace RDI.NFe.Visual
{
    partial class FrmNotaInutilizada
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
            this.dgvNotaInutilizada = new System.Windows.Forms.DataGridView();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btInutilizar = new System.Windows.Forms.Button();
            this.NumeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXMLPedido = new System.Windows.Forms.DataGridViewImageColumn();
            this.btXMLResposta = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaInutilizada)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFechar.Location = new System.Drawing.Point(27, 340);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgvNotaInutilizada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataFinal);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDataInicial);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.tbNumero);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btFiltrar);
            this.splitContainer1.Panel2.Controls.Add(this.btExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btInutilizar);
            this.splitContainer1.Panel2.Controls.Add(this.btFechar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(690, 546);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvNotaInutilizada
            // 
            this.dgvNotaInutilizada.AllowUserToAddRows = false;
            this.dgvNotaInutilizada.AllowUserToDeleteRows = false;
            this.dgvNotaInutilizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaInutilizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroNota,
            this.SerieNota,
            this.Data,
            this.btXMLPedido,
            this.btXMLResposta});
            this.dgvNotaInutilizada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotaInutilizada.Location = new System.Drawing.Point(0, 0);
            this.dgvNotaInutilizada.Name = "dgvNotaInutilizada";
            this.dgvNotaInutilizada.ReadOnly = true;
            this.dgvNotaInutilizada.RowHeadersVisible = false;
            this.dgvNotaInutilizada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaInutilizada.Size = new System.Drawing.Size(555, 546);
            this.dgvNotaInutilizada.TabIndex = 0;
            this.dgvNotaInutilizada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaInutilizada_CellDoubleClick);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(13, 103);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(109, 20);
            this.dtpDataFinal.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(13, 64);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(109, 20);
            this.dtpDataInicial.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data Inicial";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(13, 25);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(109, 20);
            this.tbNumero.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(27, 390);
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
            this.btExcluir.Location = new System.Drawing.Point(27, 490);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 44);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btInutilizar
            // 
            this.btInutilizar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btInutilizar.Location = new System.Drawing.Point(27, 440);
            this.btInutilizar.Name = "btInutilizar";
            this.btInutilizar.Size = new System.Drawing.Size(75, 44);
            this.btInutilizar.TabIndex = 4;
            this.btInutilizar.Text = "Inutilizar";
            this.btInutilizar.UseVisualStyleBackColor = true;
            this.btInutilizar.Click += new System.EventHandler(this.btInutilizar_Click);
            // 
            // NumeroNota
            // 
            this.NumeroNota.DataPropertyName = "numeroNota";
            this.NumeroNota.HeaderText = "Número Nota";
            this.NumeroNota.Name = "NumeroNota";
            this.NumeroNota.ReadOnly = true;
            this.NumeroNota.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NumeroNota.ToolTipText = "Número da nota inutilizada";
            this.NumeroNota.Width = 150;
            // 
            // SerieNota
            // 
            this.SerieNota.DataPropertyName = "SerieNota";
            this.SerieNota.HeaderText = "Série Nota";
            this.SerieNota.Name = "SerieNota";
            this.SerieNota.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // btXMLPedido
            // 
            this.btXMLPedido.HeaderText = "XMLPedido";
            this.btXMLPedido.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.btXMLPedido.Name = "btXMLPedido";
            this.btXMLPedido.ReadOnly = true;
            this.btXMLPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btXMLResposta
            // 
            this.btXMLResposta.HeaderText = "XMLResposta";
            this.btXMLResposta.Image = global::NFeAdmin.Properties.Resources.xml32;
            this.btXMLResposta.Name = "btXMLResposta";
            this.btXMLResposta.ReadOnly = true;
            this.btXMLResposta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmNotaInutilizada
            // 
            this.AcceptButton = this.btFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFechar;
            this.ClientSize = new System.Drawing.Size(690, 546);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotaInutilizada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NF-e Inutilizadas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaInutilizada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvNotaInutilizada;
        private System.Windows.Forms.Button btInutilizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewImageColumn btXMLPedido;
        private System.Windows.Forms.DataGridViewImageColumn btXMLResposta;


    }
}