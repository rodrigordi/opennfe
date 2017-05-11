namespace RDI.NFe.Visual
{
    /// <summary>
    /// 
    /// </summary>
    partial class FrmCertificados
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
            this.lbCertificado = new System.Windows.Forms.Label();
            this.cbCertificados = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCertificado
            // 
            this.lbCertificado.AutoSize = true;
            this.lbCertificado.Location = new System.Drawing.Point(14, 9);
            this.lbCertificado.Name = "lbCertificado";
            this.lbCertificado.Size = new System.Drawing.Size(116, 13);
            this.lbCertificado.TabIndex = 0;
            this.lbCertificado.Text = "Selecione o Certificado";
            // 
            // cbCertificados
            // 
            this.cbCertificados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertificados.FormattingEnabled = true;
            this.cbCertificados.Location = new System.Drawing.Point(17, 25);
            this.cbCertificados.Name = "cbCertificados";
            this.cbCertificados.Size = new System.Drawing.Size(575, 21);
            this.cbCertificados.TabIndex = 1;
            this.cbCertificados.SelectedIndexChanged += new System.EventHandler(this.cbCertificados_SelectedIndexChanged);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOk.Location = new System.Drawing.Point(436, 164);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 44);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(517, 164);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 44);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmCertificados
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(604, 220);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbCertificados);
            this.Controls.Add(this.lbCertificado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCertificados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificados";
            this.Load += new System.EventHandler(this.FrmCertificados_Load);
            this.Shown += new System.EventHandler(this.FrmCertificados_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCertificado;
        private System.Windows.Forms.ComboBox cbCertificados;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
    }
}