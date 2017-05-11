namespace RDI.NFe.Visual
{
    partial class FrmEditServico
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvSPeCons = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.tvSPeRec = new System.Windows.Forms.TreeView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txRecNum = new System.Windows.Forms.TextBox();
            this.txDatSit = new System.Windows.Forms.TextBox();
            this.txCodSit = new System.Windows.Forms.TextBox();
            this.txLote = new System.Windows.Forms.TextBox();
            this.btAtualizarLote = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tvSPeCons);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tvSPeRec);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txRecNum);
            this.splitContainer1.Panel1.Controls.Add(this.txDatSit);
            this.splitContainer1.Panel1.Controls.Add(this.txCodSit);
            this.splitContainer1.Panel1.Controls.Add(this.txLote);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAbort);
            this.splitContainer1.Panel2.Controls.Add(this.btAtualizarLote);
            this.splitContainer1.Panel2.Controls.Add(this.btCancela);
            this.splitContainer1.Size = new System.Drawing.Size(755, 570);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvSPeCons
            // 
            this.tvSPeCons.Location = new System.Drawing.Point(391, 77);
            this.tvSPeCons.Name = "tvSPeCons";
            this.tvSPeCons.Size = new System.Drawing.Size(347, 434);
            this.tvSPeCons.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Xml da Consulta";
            // 
            // tvSPeRec
            // 
            this.tvSPeRec.Location = new System.Drawing.Point(15, 77);
            this.tvSPeRec.Name = "tvSPeRec";
            this.tvSPeRec.Size = new System.Drawing.Size(352, 434);
            this.tvSPeRec.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Xml do Recibo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número do Recibo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data da Situação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Situação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lote";
            // 
            // txRecNum
            // 
            this.txRecNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRecNum.Location = new System.Drawing.Point(494, 29);
            this.txRecNum.MaxLength = 100;
            this.txRecNum.Name = "txRecNum";
            this.txRecNum.Size = new System.Drawing.Size(247, 20);
            this.txRecNum.TabIndex = 6;
            // 
            // txDatSit
            // 
            this.txDatSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDatSit.Location = new System.Drawing.Point(120, 29);
            this.txDatSit.MaxLength = 100;
            this.txDatSit.Name = "txDatSit";
            this.txDatSit.Size = new System.Drawing.Size(247, 20);
            this.txDatSit.TabIndex = 5;
            // 
            // txCodSit
            // 
            this.txCodSit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCodSit.Location = new System.Drawing.Point(494, 6);
            this.txCodSit.MaxLength = 300;
            this.txCodSit.Name = "txCodSit";
            this.txCodSit.Size = new System.Drawing.Size(247, 20);
            this.txCodSit.TabIndex = 4;
            // 
            // txLote
            // 
            this.txLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txLote.Location = new System.Drawing.Point(120, 6);
            this.txLote.MaxLength = 50;
            this.txLote.Name = "txLote";
            this.txLote.Size = new System.Drawing.Size(247, 20);
            this.txLote.TabIndex = 3;
            // 
            // btAtualizarLote
            // 
            this.btAtualizarLote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAtualizarLote.Location = new System.Drawing.Point(501, 3);
            this.btAtualizarLote.Name = "btAtualizarLote";
            this.btAtualizarLote.Size = new System.Drawing.Size(75, 44);
            this.btAtualizarLote.TabIndex = 3;
            this.btAtualizarLote.Text = "Atualizar Lote";
            this.btAtualizarLote.UseVisualStyleBackColor = true;
            this.btAtualizarLote.Click += new System.EventHandler(this.btAtualizarLote_Click);
            // 
            // btCancela
            // 
            this.btCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancela.Location = new System.Drawing.Point(663, 3);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 44);
            this.btCancela.TabIndex = 1;
            this.btCancela.Text = "Fechar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(582, 3);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 44);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Cancelar Envio";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEditServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(755, 570);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhamento de Serviço";
            this.Load += new System.EventHandler(this.FrmEditServico_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txRecNum;
        private System.Windows.Forms.TextBox txDatSit;
        private System.Windows.Forms.TextBox txCodSit;
        private System.Windows.Forms.TextBox txLote;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.TreeView tvSPeRec;
        private System.Windows.Forms.TreeView tvSPeCons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAtualizarLote;
        private System.Windows.Forms.Button btnAbort;
    }
}