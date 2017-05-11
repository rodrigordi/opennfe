namespace RDI.NFe.Visual
{
    partial class FrmWebService
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
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoAmbiente = new System.Windows.Forms.ComboBox();
            this.cbTipoEmissao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimeOut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVersaoNFe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(316, 260);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 44);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(397, 260);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 44);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Ambiente";
            // 
            // cbTipoAmbiente
            // 
            this.cbTipoAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAmbiente.FormattingEnabled = true;
            this.cbTipoAmbiente.Location = new System.Drawing.Point(161, 54);
            this.cbTipoAmbiente.Name = "cbTipoAmbiente";
            this.cbTipoAmbiente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAmbiente.TabIndex = 3;
            this.cbTipoAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbTipoOperacao_SelectedIndexChanged_1);
            this.cbTipoAmbiente.SelectedValueChanged += new System.EventHandler(this.cbTipoOperacao_SelectedValueChanged);
            // 
            // cbTipoEmissao
            // 
            this.cbTipoEmissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEmissao.FormattingEnabled = true;
            this.cbTipoEmissao.Location = new System.Drawing.Point(161, 81);
            this.cbTipoEmissao.Name = "cbTipoEmissao";
            this.cbTipoEmissao.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEmissao.TabIndex = 5;
            this.cbTipoEmissao.SelectedIndexChanged += new System.EventHandler(this.cbTipoOperacao_SelectedIndexChanged_1);
            this.cbTipoEmissao.SelectedValueChanged += new System.EventHandler(this.cbTipoOperacao_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo Emissão";
            // 
            // cbUf
            // 
            this.cbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Location = new System.Drawing.Point(161, 108);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(121, 21);
            this.cbUf.TabIndex = 7;
            this.cbUf.SelectedIndexChanged += new System.EventHandler(this.cbTipoOperacao_SelectedIndexChanged_1);
            this.cbUf.SelectedValueChanged += new System.EventHandler(this.cbTipoOperacao_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo UF";
            // 
            // cbTimeOut
            // 
            this.cbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeOut.FormattingEnabled = true;
            this.cbTimeOut.Location = new System.Drawing.Point(161, 135);
            this.cbTimeOut.Name = "cbTimeOut";
            this.cbTimeOut.Size = new System.Drawing.Size(121, 21);
            this.cbTimeOut.TabIndex = 9;
            this.cbTimeOut.SelectedIndexChanged += new System.EventHandler(this.cbTipoOperacao_SelectedIndexChanged_1);
            this.cbTimeOut.SelectedValueChanged += new System.EventHandler(this.cbTipoOperacao_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TimeOut";
            // 
            // cbVersaoNFe
            // 
            this.cbVersaoNFe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersaoNFe.FormattingEnabled = true;
            this.cbVersaoNFe.Location = new System.Drawing.Point(161, 162);
            this.cbVersaoNFe.Name = "cbVersaoNFe";
            this.cbVersaoNFe.Size = new System.Drawing.Size(121, 21);
            this.cbVersaoNFe.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Versão NFe";
            // 
            // FrmWebService
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.cbVersaoNFe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTimeOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoEmissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoAmbiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWebService";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Service";
            this.Load += new System.EventHandler(this.FrmWebService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoAmbiente;
        private System.Windows.Forms.ComboBox cbTipoEmissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVersaoNFe;
        private System.Windows.Forms.Label label5;
    }
}