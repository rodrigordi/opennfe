namespace RDI.NFe.Visual
{
    partial class FrmInfNRec
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnRec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancela
            // 
            this.btCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancela.Location = new System.Drawing.Point(332, 103);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 44);
            this.btCancela.TabIndex = 2;
            this.btCancela.Text = "Fechar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(251, 103);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 44);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o número do Recibo";
            // 
            // txtnRec
            // 
            this.txtnRec.Location = new System.Drawing.Point(15, 25);
            this.txtnRec.MaxLength = 4000000;
            this.txtnRec.Name = "txtnRec";
            this.txtnRec.Size = new System.Drawing.Size(392, 20);
            this.txtnRec.TabIndex = 5;
            // 
            // FrmInfNRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancela;
            this.ClientSize = new System.Drawing.Size(419, 159);
            this.Controls.Add(this.txtnRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInfNRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe o Recibo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnRec;
    }
}