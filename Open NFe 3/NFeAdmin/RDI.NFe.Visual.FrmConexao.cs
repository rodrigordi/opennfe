using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RDI.Lince;
using RDI.NFe2.ORMAP;

namespace RDI.NFe.Visual
{
    public partial class FrmConexao : Form
    {
        public FrmConexao()
        {
            InitializeComponent();
        }

        public FrmConexao(string cadeia, string cnpj, bool enviarErros)
        {
            InitializeComponent();

            txtCadeia.Text = cadeia;
            txtCNPJ.Text = cnpj;
            chkEnvioEstatisticas.Checked = enviarErros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TestaConexao())
                MessageBox.Show("Conexão bem sucedida.");
            else
                MessageBox.Show("Falha na conexão.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verificar se a conexão foi bem sucedida
            if (!TestaConexao())
            {
                MessageBox.Show("Falha na conexão.");
                return;
            }

            if(string.IsNullOrEmpty(txtCNPJ.Text))
            {
                MessageBox.Show("CNPJ não foi informado.");
                return;
            }

            try
            {
                //Salvar arquivo conexao junto ao .exe do NFeAdmin
                string[] lines = new string[4];
                lines[0] = txtCadeia.Text;
                lines[1] = txtCNPJ.Text;
                lines[2] = "0";
                lines[3] = chkEnvioEstatisticas.Checked ? "1" : "0";

                System.IO.File.WriteAllLines(".\\conexao", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar o arquivo conexao. Exception : " + ex.Message); 
                return;
            }

            MessageBox.Show("Arquivo gerado com sucesso."); 
            
            this.Close();
        }

        bool TestaConexao()
        {
            bool conexaoOK = false;

            //validar se cadeia de conexao foi informada
            if (String.IsNullOrEmpty(txtCadeia.Text))
            {
                MessageBox.Show("Cadeia de conexão não foi informada.");
                return false;
            }

            //Criar uma conexao com o banco e buscar os CNPJ cadastrados.
            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(txtCadeia.Text);//nao é utilizado nesse ponto
                conexaoOK = manager.connection.State == ConnectionState.Open;
            }
            catch
            {
                conexaoOK = false;
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }
            return conexaoOK;
        }
    }
}
