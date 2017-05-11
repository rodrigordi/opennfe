namespace RDI
{
    partial class timexRefresh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxDelay = new System.Windows.Forms.MaskedTextBox();
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ms";
            // 
            // mtxDelay
            // 
            this.mtxDelay.Location = new System.Drawing.Point(3, 26);
            this.mtxDelay.Mask = "00000";
            this.mtxDelay.Name = "mtxDelay";
            this.mtxDelay.PromptChar = ' ';
            this.mtxDelay.Size = new System.Drawing.Size(43, 20);
            this.mtxDelay.TabIndex = 23;
            this.mtxDelay.Text = "500";
            this.mtxDelay.ValidatingType = typeof(int);
            // 
            // chkRefresh
            // 
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Location = new System.Drawing.Point(3, 3);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(66, 17);
            this.chkRefresh.TabIndex = 22;
            this.chkRefresh.Text = "Atualizar";
            this.chkRefresh.UseVisualStyleBackColor = true;
            this.chkRefresh.Click += new System.EventHandler(this.chkRefresh_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // timexRefresh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxDelay);
            this.Controls.Add(this.chkRefresh);
            this.Name = "timexRefresh";
            this.Size = new System.Drawing.Size(70, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxDelay;
        private System.Windows.Forms.CheckBox chkRefresh;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}
