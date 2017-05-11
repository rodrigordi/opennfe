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
    public partial class FrmDiretorios : Form
    {
        Boolean isModified;

        public FrmDiretorios()
        {
            InitializeComponent();
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


                        oParam.pastaEntrada = tbEntrada.Text;
                        oParam.pastaRecibo = tbRecibo.Text;
                        oParam.pastaSaida = tbSaida.Text;
                        oParam.pastaImpressao = tbImpressao.Text;
                        oParam.pastaXSD = tbXsd.Text;

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
            this.Close();
            this.Dispose();
        }

        private void btBuscarEnt_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            tbEntrada.Text = folderDialog.SelectedPath + "\\";
        }

        private void btBuscarSai_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            tbSaida.Text = folderDialog.SelectedPath + "\\";
        }

        private void btBuscarRec_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            tbRecibo.Text = folderDialog.SelectedPath + "\\";
        }

        private void FrmDiretorios_Shown(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;

            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);
                tbEntrada.Text = oParam.pastaEntrada;
                tbRecibo.Text = oParam.pastaRecibo;
                tbSaida.Text = oParam.pastaSaida;
                tbImpressao.Text = oParam.pastaImpressao;
                tbXsd.Text = oParam.pastaXSD;
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

        private void FrmDiretorios_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btBuscarImpr_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            tbImpressao.Text = folderDialog.SelectedPath + "\\";
        }

        private void btBuscarXSD_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            tbXsd.Text = folderDialog.SelectedPath + "\\";
        }

        private void tbEntrada_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        
    }
}