using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.Lince;
using RDI.NFe2.Business;
using System.Collections;
using RDI.Lince;
using RDI.NFe2.ORMAP;

namespace RDI.NFe.Visual
{
    public partial class FrmLotes : Form
    {
        Boolean isModified;

        public FrmLotes()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmLotes_Shown(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;

            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);


                tbQtdeNotasPorLotes.Text = oParam.qtdeNotasPorLotes.ToString();
                tbTamMaximoLoteKB.Text = oParam.tamMaximoLoteKB.ToString();
                tbTempoParaLote.Text = oParam.tempoParaLote.ToString();
                txtTempoEspera.Text = oParam.tempoEspera.ToString();
                isModified = false;

                oParam = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                if (MessageBox.Show("Clique em Sim para salvar e em Não para sair sem salvar.", "Deseja salvar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ClientEnvironment manager = null;
                    try
                    {
                        manager = Conexao.CreateManager(Program.ConAux);
                        Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                        oParam.qtdeNotasPorLotes = Convert.ToInt32(tbQtdeNotasPorLotes.Text);
                        oParam.tamMaximoLoteKB = Convert.ToInt32(tbTamMaximoLoteKB.Text);
                        oParam.tempoParaLote = Convert.ToInt32(tbTempoParaLote.Text);
                        oParam.tempoEspera = Convert.ToInt32(txtTempoEspera.Text);
                        oParam.Save(manager);
                        oParam = null;
                        isModified = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Conexao.DisposeManager(manager);

                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                this.Close();
                this.Dispose();
            }
        }



        private void tbTamMaximoLoteKB_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void tbTempoParaLote_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void tbQtdeNotasPorLotes_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void FrmLotes_Load(object sender, EventArgs e)
        {

        }

        private void txtTempoEspera_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}