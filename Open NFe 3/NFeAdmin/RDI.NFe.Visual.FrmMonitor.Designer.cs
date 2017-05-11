namespace RDI.NFe.Visual
{
    partial class FrmMonitor
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
            this.components = new System.ComponentModel.Container();
            this.dgvMonitor = new System.Windows.Forms.DataGridView();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnParar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oLoop = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarTodas = new System.Windows.Forms.Button();
            this.btnPararTodas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonitor
            // 
            this.dgvMonitor.AllowUserToAddRows = false;
            this.dgvMonitor.AllowUserToDeleteRows = false;
            this.dgvMonitor.AllowUserToResizeColumns = false;
            this.dgvMonitor.AllowUserToResizeRows = false;
            this.dgvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empresa,
            this.Status,
            this.btnIniciar,
            this.BtnParar});
            this.dgvMonitor.Location = new System.Drawing.Point(12, 12);
            this.dgvMonitor.Name = "dgvMonitor";
            this.dgvMonitor.ReadOnly = true;
            this.dgvMonitor.RowHeadersVisible = false;
            this.dgvMonitor.Size = new System.Drawing.Size(499, 318);
            this.dgvMonitor.TabIndex = 3;
            this.dgvMonitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvMonitor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "CNPJ";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.HeaderText = "";
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.ReadOnly = true;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseColumnTextForButtonValue = true;
            // 
            // BtnParar
            // 
            this.BtnParar.HeaderText = "";
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.ReadOnly = true;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseColumnTextForButtonValue = true;
            // 
            // oLoop
            // 
            this.oLoop.Tick += new System.EventHandler(this.oLoop_Tick);
            // 
            // btnIniciarTodas
            // 
            this.btnIniciarTodas.Location = new System.Drawing.Point(318, 336);
            this.btnIniciarTodas.Name = "btnIniciarTodas";
            this.btnIniciarTodas.Size = new System.Drawing.Size(90, 23);
            this.btnIniciarTodas.TabIndex = 4;
            this.btnIniciarTodas.Text = "Iniciar Todos";
            this.btnIniciarTodas.UseVisualStyleBackColor = true;
            this.btnIniciarTodas.Click += new System.EventHandler(this.btnIniciarTodas_Click);
            // 
            // btnPararTodas
            // 
            this.btnPararTodas.Location = new System.Drawing.Point(414, 336);
            this.btnPararTodas.Name = "btnPararTodas";
            this.btnPararTodas.Size = new System.Drawing.Size(97, 23);
            this.btnPararTodas.TabIndex = 5;
            this.btnPararTodas.Text = "Parar Todos";
            this.btnPararTodas.UseVisualStyleBackColor = true;
            this.btnPararTodas.Click += new System.EventHandler(this.btnPararTodas_Click);
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.btnPararTodas);
            this.Controls.Add(this.btnIniciarTodas);
            this.Controls.Add(this.dgvMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMonitor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitor;
        private System.Windows.Forms.Timer oLoop;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn btnIniciar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnParar;
        private System.Windows.Forms.Button btnIniciarTodas;
        private System.Windows.Forms.Button btnPararTodas;
    }
}