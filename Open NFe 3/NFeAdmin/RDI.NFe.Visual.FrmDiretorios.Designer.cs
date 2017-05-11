namespace RDI.NFe.Visual
{
    partial class FrmDiretorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiretorios));
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.btBuscarEnt = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btBuscarRec = new System.Windows.Forms.Button();
            this.tbRecibo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscarSai = new System.Windows.Forms.Button();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBuscarImpr = new System.Windows.Forms.Button();
            this.tbImpressao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btBuscarXSD = new System.Windows.Forms.Button();
            this.tbXsd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(412, 182);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 44);
            this.btOk.TabIndex = 11;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(493, 182);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 44);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta de Entrada";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(108, 27);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(424, 20);
            this.tbEntrada.TabIndex = 0;
            this.tbEntrada.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            // 
            // btBuscarEnt
            // 
            this.btBuscarEnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btBuscarEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBuscarEnt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscarEnt.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarEnt.Image")));
            this.btBuscarEnt.Location = new System.Drawing.Point(538, 25);
            this.btBuscarEnt.Name = "btBuscarEnt";
            this.btBuscarEnt.Size = new System.Drawing.Size(30, 23);
            this.btBuscarEnt.TabIndex = 1;
            this.btBuscarEnt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btBuscarEnt.UseVisualStyleBackColor = false;
            this.btBuscarEnt.Click += new System.EventHandler(this.btBuscarEnt_Click);
            // 
            // btBuscarRec
            // 
            this.btBuscarRec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscarRec.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarRec.Image")));
            this.btBuscarRec.Location = new System.Drawing.Point(538, 77);
            this.btBuscarRec.Name = "btBuscarRec";
            this.btBuscarRec.Size = new System.Drawing.Size(30, 23);
            this.btBuscarRec.TabIndex = 5;
            this.btBuscarRec.UseVisualStyleBackColor = true;
            this.btBuscarRec.Click += new System.EventHandler(this.btBuscarRec_Click);
            // 
            // tbRecibo
            // 
            this.tbRecibo.Location = new System.Drawing.Point(108, 79);
            this.tbRecibo.Name = "tbRecibo";
            this.tbRecibo.Size = new System.Drawing.Size(424, 20);
            this.tbRecibo.TabIndex = 4;
            this.tbRecibo.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pasta de Recibo";
            // 
            // btBuscarSai
            // 
            this.btBuscarSai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscarSai.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarSai.Image")));
            this.btBuscarSai.Location = new System.Drawing.Point(538, 51);
            this.btBuscarSai.Name = "btBuscarSai";
            this.btBuscarSai.Size = new System.Drawing.Size(30, 23);
            this.btBuscarSai.TabIndex = 3;
            this.btBuscarSai.UseVisualStyleBackColor = true;
            this.btBuscarSai.Click += new System.EventHandler(this.btBuscarSai_Click);
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(108, 53);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(424, 20);
            this.tbSaida.TabIndex = 2;
            this.tbSaida.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pasta de Saída";
            // 
            // btBuscarImpr
            // 
            this.btBuscarImpr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscarImpr.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarImpr.Image")));
            this.btBuscarImpr.Location = new System.Drawing.Point(538, 103);
            this.btBuscarImpr.Name = "btBuscarImpr";
            this.btBuscarImpr.Size = new System.Drawing.Size(30, 23);
            this.btBuscarImpr.TabIndex = 7;
            this.btBuscarImpr.UseVisualStyleBackColor = true;
            this.btBuscarImpr.Click += new System.EventHandler(this.btBuscarImpr_Click);
            // 
            // tbImpressao
            // 
            this.tbImpressao.Location = new System.Drawing.Point(108, 105);
            this.tbImpressao.Name = "tbImpressao";
            this.tbImpressao.Size = new System.Drawing.Size(424, 20);
            this.tbImpressao.TabIndex = 6;
            this.tbImpressao.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pasta Impressão";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btBuscarXSD
            // 
            this.btBuscarXSD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscarXSD.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarXSD.Image")));
            this.btBuscarXSD.Location = new System.Drawing.Point(538, 129);
            this.btBuscarXSD.Name = "btBuscarXSD";
            this.btBuscarXSD.Size = new System.Drawing.Size(30, 23);
            this.btBuscarXSD.TabIndex = 9;
            this.btBuscarXSD.UseVisualStyleBackColor = true;
            this.btBuscarXSD.Click += new System.EventHandler(this.btBuscarXSD_Click);
            // 
            // tbXsd
            // 
            this.tbXsd.Location = new System.Drawing.Point(108, 131);
            this.tbXsd.Name = "tbXsd";
            this.tbXsd.Size = new System.Drawing.Size(424, 20);
            this.tbXsd.TabIndex = 8;
            this.tbXsd.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pasta XSD";
            // 
            // FrmDiretorios
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(580, 238);
            this.Controls.Add(this.btBuscarXSD);
            this.Controls.Add(this.tbXsd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btBuscarImpr);
            this.Controls.Add(this.tbImpressao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBuscarSai);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuscarRec);
            this.Controls.Add(this.tbRecibo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscarEnt);
            this.Controls.Add(this.tbEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiretorios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diretórios";
            this.Load += new System.EventHandler(this.FrmDiretorios_Load);
            this.Shown += new System.EventHandler(this.FrmDiretorios_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Button btBuscarEnt;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btBuscarRec;
        private System.Windows.Forms.TextBox tbRecibo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscarSai;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBuscarImpr;
        private System.Windows.Forms.TextBox tbImpressao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuscarXSD;
        private System.Windows.Forms.TextBox tbXsd;
        private System.Windows.Forms.Label label5;
    }
}