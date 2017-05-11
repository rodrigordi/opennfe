namespace RDI.NFe.Visual
{
    partial class FrmLotes
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
            this.tbQtdeNotasPorLotes = new System.Windows.Forms.TextBox();
            this.tbTempoParaLote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTamMaximoLoteKB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempoEspera = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOk.Location = new System.Drawing.Point(379, 183);
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
            this.btCancelar.Location = new System.Drawing.Point(460, 183);
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
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade Máxima";
            // 
            // tbQtdeNotasPorLotes
            // 
            this.tbQtdeNotasPorLotes.Location = new System.Drawing.Point(216, 19);
            this.tbQtdeNotasPorLotes.Name = "tbQtdeNotasPorLotes";
            this.tbQtdeNotasPorLotes.Size = new System.Drawing.Size(135, 20);
            this.tbQtdeNotasPorLotes.TabIndex = 3;
            this.tbQtdeNotasPorLotes.TextChanged += new System.EventHandler(this.tbQtdeNotasPorLotes_TextChanged);
            // 
            // tbTempoParaLote
            // 
            this.tbTempoParaLote.Location = new System.Drawing.Point(216, 45);
            this.tbTempoParaLote.Name = "tbTempoParaLote";
            this.tbTempoParaLote.Size = new System.Drawing.Size(135, 20);
            this.tbTempoParaLote.TabIndex = 5;
            this.tbTempoParaLote.TextChanged += new System.EventHandler(this.tbTempoParaLote_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo de Fechamento";
            // 
            // tbTamMaximoLoteKB
            // 
            this.tbTamMaximoLoteKB.Location = new System.Drawing.Point(216, 74);
            this.tbTamMaximoLoteKB.Name = "tbTamMaximoLoteKB";
            this.tbTamMaximoLoteKB.Size = new System.Drawing.Size(135, 20);
            this.tbTamMaximoLoteKB.TabIndex = 7;
            this.tbTamMaximoLoteKB.TextChanged += new System.EventHandler(this.tbTamMaximoLoteKB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamanho Máximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(em un)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(em seg)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(em KB)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "(em seg)";
            // 
            // txtTempoEspera
            // 
            this.txtTempoEspera.Location = new System.Drawing.Point(216, 100);
            this.txtTempoEspera.Name = "txtTempoEspera";
            this.txtTempoEspera.Size = new System.Drawing.Size(135, 20);
            this.txtTempoEspera.TabIndex = 12;
            this.txtTempoEspera.TextChanged += new System.EventHandler(this.txtTempoEspera_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tempo de Espera";
            // 
            // FrmLotes
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(547, 239);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTempoEspera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTamMaximoLoteKB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTempoParaLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQtdeNotasPorLotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLotes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotes";
            this.Load += new System.EventHandler(this.FrmLotes_Load);
            this.Shown += new System.EventHandler(this.FrmLotes_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQtdeNotasPorLotes;
        private System.Windows.Forms.TextBox tbTempoParaLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTamMaximoLoteKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempoEspera;
        private System.Windows.Forms.Label label8;
    }
}