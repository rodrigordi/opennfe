namespace RDI.NFe.Visual
{
    partial class FrmProxy
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
            this.cbHabilita = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbHabilita
            // 
            this.cbHabilita.AutoSize = true;
            this.cbHabilita.Location = new System.Drawing.Point(39, 34);
            this.cbHabilita.Name = "cbHabilita";
            this.cbHabilita.Size = new System.Drawing.Size(93, 17);
            this.cbHabilita.TabIndex = 0;
            this.cbHabilita.Text = "Habilitar Proxy";
            this.cbHabilita.UseVisualStyleBackColor = true;
            this.cbHabilita.CheckedChanged += new System.EventHandler(this.cbHabilita_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dominio";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Location = new System.Drawing.Point(187, 61);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(139, 20);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.Enabled = false;
            this.tbSenha.Location = new System.Drawing.Point(187, 87);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(139, 20);
            this.tbSenha.TabIndex = 6;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(187, 139);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(139, 20);
            this.tbEndereco.TabIndex = 8;
            this.tbEndereco.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbDominio
            // 
            this.tbDominio.Enabled = false;
            this.tbDominio.Location = new System.Drawing.Point(187, 165);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(139, 20);
            this.tbDominio.TabIndex = 9;
            this.tbDominio.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(331, 234);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 44);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(412, 234);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 44);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirme a Senha";
            // 
            // tbConfSenha
            // 
            this.tbConfSenha.Enabled = false;
            this.tbConfSenha.Location = new System.Drawing.Point(187, 113);
            this.tbConfSenha.Name = "tbConfSenha";
            this.tbConfSenha.PasswordChar = '*';
            this.tbConfSenha.Size = new System.Drawing.Size(139, 20);
            this.tbConfSenha.TabIndex = 7;
            this.tbConfSenha.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // FrmProxy
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(499, 290);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbDominio);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbConfSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHabilita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProxy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy";
            this.Shown += new System.EventHandler(this.FrmProxy_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHabilita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfSenha;
    }
}