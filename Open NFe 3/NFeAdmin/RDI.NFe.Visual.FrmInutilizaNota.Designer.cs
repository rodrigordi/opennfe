namespace RDI.NFe.Visual
{
    partial class FrmInutilizaNota
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
            this.btCancela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNotaFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoAmbiente = new System.Windows.Forms.ComboBox();
            this.tbJust = new System.Windows.Forms.TextBox();
            this.tbNotaInicial = new System.Windows.Forms.TextBox();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.tbMod = new System.Windows.Forms.TextBox();
            this.tbCNPJ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btInutiliza = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancela
            // 
            this.btCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancela.Location = new System.Drawing.Point(530, 3);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 44);
            this.btCancela.TabIndex = 11;
            this.btCancela.Text = "Fechar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Série";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ano";
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
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.tbNotaFinal);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cbTipoAmbiente);
            this.splitContainer1.Panel1.Controls.Add(this.tbJust);
            this.splitContainer1.Panel1.Controls.Add(this.tbNotaInicial);
            this.splitContainer1.Panel1.Controls.Add(this.tbSerie);
            this.splitContainer1.Panel1.Controls.Add(this.tbMod);
            this.splitContainer1.Panel1.Controls.Add(this.tbCNPJ);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbUF);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbAno);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btInutiliza);
            this.splitContainer1.Panel2.Controls.Add(this.btCancela);
            this.splitContainer1.Size = new System.Drawing.Size(617, 271);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Notas";
            // 
            // tbNotaFinal
            // 
            this.tbNotaFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNotaFinal.Location = new System.Drawing.Point(464, 25);
            this.tbNotaFinal.MaxLength = 9;
            this.tbNotaFinal.Name = "tbNotaFinal";
            this.tbNotaFinal.Size = new System.Drawing.Size(141, 20);
            this.tbNotaFinal.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Até";
            // 
            // cbTipoAmbiente
            // 
            this.cbTipoAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAmbiente.FormattingEnabled = true;
            this.cbTipoAmbiente.Location = new System.Drawing.Point(15, 66);
            this.cbTipoAmbiente.Name = "cbTipoAmbiente";
            this.cbTipoAmbiente.Size = new System.Drawing.Size(169, 21);
            this.cbTipoAmbiente.TabIndex = 1;
            // 
            // tbJust
            // 
            this.tbJust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbJust.Location = new System.Drawing.Point(227, 69);
            this.tbJust.MaxLength = 0;
            this.tbJust.Multiline = true;
            this.tbJust.Name = "tbJust";
            this.tbJust.Size = new System.Drawing.Size(378, 135);
            this.tbJust.TabIndex = 9;
            this.tbJust.Text = "INUTILIZAR NOTAS NAO ENVIADAS";
            // 
            // tbNotaInicial
            // 
            this.tbNotaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNotaInicial.Location = new System.Drawing.Point(256, 25);
            this.tbNotaInicial.MaxLength = 9;
            this.tbNotaInicial.Name = "tbNotaInicial";
            this.tbNotaInicial.Size = new System.Drawing.Size(156, 20);
            this.tbNotaInicial.TabIndex = 5;
            // 
            // tbSerie
            // 
            this.tbSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSerie.Location = new System.Drawing.Point(15, 145);
            this.tbSerie.MaxLength = 3;
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(169, 20);
            this.tbSerie.TabIndex = 4;
            // 
            // tbMod
            // 
            this.tbMod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMod.Location = new System.Drawing.Point(109, 184);
            this.tbMod.MaxLength = 2;
            this.tbMod.Name = "tbMod";
            this.tbMod.Size = new System.Drawing.Size(75, 20);
            this.tbMod.TabIndex = 8;
            this.tbMod.Text = "55";
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCNPJ.Location = new System.Drawing.Point(15, 106);
            this.tbCNPJ.MaxLength = 14;
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(170, 20);
            this.tbCNPJ.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ambiente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Justificativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "De";
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(15, 25);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(169, 21);
            this.cbUF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UF";
            // 
            // tbAno
            // 
            this.tbAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAno.Location = new System.Drawing.Point(15, 184);
            this.tbAno.MaxLength = 2;
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(76, 20);
            this.tbAno.TabIndex = 7;
            this.tbAno.TextChanged += new System.EventHandler(this.tbAno_TextChanged);
            // 
            // btInutiliza
            // 
            this.btInutiliza.Location = new System.Drawing.Point(449, 3);
            this.btInutiliza.Name = "btInutiliza";
            this.btInutiliza.Size = new System.Drawing.Size(75, 44);
            this.btInutiliza.TabIndex = 10;
            this.btInutiliza.Text = "Inutilizar";
            this.btInutiliza.UseVisualStyleBackColor = true;
            this.btInutiliza.Click += new System.EventHandler(this.btInutiliza_Click);
            // 
            // FrmInutilizaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(617, 271);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInutilizaNota";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inutilização de NF-e";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btInutiliza;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.TextBox tbMod;
        private System.Windows.Forms.TextBox tbCNPJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJust;
        private System.Windows.Forms.TextBox tbNotaInicial;
        private System.Windows.Forms.ComboBox cbTipoAmbiente;
        private System.Windows.Forms.TextBox tbNotaFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}