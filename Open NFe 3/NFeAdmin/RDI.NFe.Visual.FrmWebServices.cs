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
using RDI.NFe2.SchemaXML;



namespace RDI.NFe.Visual
{
    public partial class FrmWebService : Form
    {
        Boolean isModified;
        
        public FrmWebService()
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
                        

                        oParam.tipoEmissao = (TNFeInfNFeIdeTpEmis)cbTipoEmissao.SelectedValue;
                        oParam.tipoAmbiente = (TAmb)cbTipoAmbiente.SelectedValue;
                        oParam.UF = (TCodUfIBGE)cbUf.SelectedValue;
                        oParam.timeout = (Delay)cbTimeOut.SelectedValue;
                        oParam.versao = (VersaoXML)cbVersaoNFe.SelectedValue;

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
        

        private void FrmWebService_Load(object sender, EventArgs e)
        {
            cbTipoEmissao.DataSource = NFeUtils.Listar(typeof(TNFeInfNFeIdeTpEmis));
            cbTipoEmissao.DisplayMember = "Value";
            cbTipoEmissao.ValueMember = "Key";
            

            cbTimeOut.DataSource = NFeUtils.Listar(typeof(Delay));
            cbTimeOut.DisplayMember = "Value";
            cbTimeOut.ValueMember = "Key";

            cbTipoAmbiente.DataSource = NFeUtils.Listar(typeof(TAmb));
            cbTipoAmbiente.DisplayMember = "Value";
            cbTipoAmbiente.ValueMember = "Key";

            cbUf.DataSource = NFeUtils.Listar(typeof(TCodUfIBGE));
            cbUf.DisplayMember = "Value";
            cbUf.ValueMember = "Key";

            cbVersaoNFe.DataSource = NFeUtils.Listar(typeof(VersaoXML));
            cbVersaoNFe.DisplayMember = "Value";
            cbVersaoNFe.ValueMember = "Key";


            ClientEnvironment manager = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                cbTipoEmissao.SelectedValue = Convert.ToInt32(oParam.tipoEmissao);
                cbTipoAmbiente.SelectedValue = Convert.ToInt32(oParam.tipoAmbiente);
                cbTimeOut.SelectedValue = Convert.ToInt32(oParam.timeout);
                cbUf.SelectedValue = Convert.ToInt32(oParam.UF);
                cbVersaoNFe.SelectedValue = Convert.ToInt32(oParam.versao);

                isModified = true;
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

        private void cbTipoOperacao_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoOperacao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            isModified = true;
        }
    }
}