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
using RDI.NFe2.ORMAP;


namespace RDI.NFe.Visual
{
    public partial class FrmProxy : Form
    {
        Boolean isModified;
        public FrmProxy()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbSenha.Text != tbConfSenha.Text)
            {
                MessageBox.Show("Senha não confere com a confirmação");
            }
            else if (isModified)
            {
                if (MessageBox.Show("Clique em Sim para salvar e em Não para sair sem salvar.", "Deseja salvar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ClientEnvironment manager = null;
                    try
                    {
                        manager = Conexao.CreateManager(Program.ConAux);
                        Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);
                        
                        oParam.prxDmn = tbDominio.Text;
                        oParam.prxUrl = tbEndereco.Text;
                        oParam.prxPsw = tbSenha.Text;
                        oParam.prxUsr = tbUsuario.Text;
                        oParam.prx = cbHabilita.Checked;

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //nao gravar
            this.Close();
            this.Dispose();
        }

        private void cbHabilita_CheckedChanged(object sender, EventArgs e)
        {
            tbDominio.Enabled = cbHabilita.Checked;
            tbEndereco.Enabled = cbHabilita.Checked;
            tbSenha.Enabled = cbHabilita.Checked;
            tbConfSenha.Enabled = cbHabilita.Checked;
            tbUsuario.Enabled = cbHabilita.Checked;
            isModified = true;
        }

        private void FrmProxy_Shown(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                tbDominio.Text = oParam.prxDmn;
                tbEndereco.Text = oParam.prxUrl;
                tbSenha.Text = oParam.prxPsw;
                tbUsuario.Text = oParam.prxUsr;
                cbHabilita.Checked = oParam.prx;
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

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}