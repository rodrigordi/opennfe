using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RDI.NFe2.Business;
using RDI.Lince;
using RDI.NFe2.ORMAP;
using RDI.OpenSigner;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RDI.NFe.Visual
{

    public partial class FrmCertificados : Form
    {
        Boolean isModified;

        public FrmCertificados()
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

                        oParam.certificado = cbCertificados.SelectedItem.ToString();

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

        private void FrmCertificados_Load(object sender, EventArgs e)
        {




        }

        private void FrmCertificados_Shown(object sender, EventArgs e)
        {


            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                List<X509Certificate2> certificados = null;
                if (!oParam.usaWService)
                    certificados = Certificado.ObterCertificadosContaUsuario();
                else
                    certificados = Certificado.ObterCertificadosContaUsuario();

                cbCertificados.Items.Clear();
                foreach (var cert in certificados)
                {
                    cbCertificados.Items.Add(cert.Subject.ToString());
                }

                cbCertificados.SelectedItem = oParam.certificado;
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

        private void cbCertificados_SelectedIndexChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}