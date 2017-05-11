using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;
using System.IO;
using RDI.Lince;
using RDI.NFe2.ORMAP;
using RDI.NFe2.SchemaXML;

namespace RDI.NFe.Visual
{
    public partial class FrmInutilizaNota : Form
    {
        public FrmInutilizaNota()
        {
            InitializeComponent();
            cbUF.DataSource = NFeUtils.Listar(typeof(TCodUfIBGE));
            cbUF.DisplayMember = "Value";
            cbUF.ValueMember = "Key";

            cbTipoAmbiente.DataSource = NFeUtils.Listar(typeof(TAmb));
            cbTipoAmbiente.DisplayMember = "Value";
            cbTipoAmbiente.ValueMember = "Key";

            ClientEnvironment manager = null;

            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                Parametro oParam = Program.GetParametro(Program.empresaSelecionada, manager);

                cbTipoAmbiente.SelectedValue = Convert.ToInt32(oParam.tipoAmbiente);
                cbUF.SelectedValue = Convert.ToInt32(oParam.UF);
                tbCNPJ.Text = Program.empresaSelecionada;

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

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void btInutiliza_Click(object sender, EventArgs e)
        {
            ClientEnvironment manager = null;
            Parametro oParam = null;
            FuncaoAutomacao oFuncao = null;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);
                oParam = Program.GetParametro(Program.empresaSelecionada, manager);
                oFuncao = new FuncaoAutomacao(Program.empresaSelecionada, manager, Program.enviarInformacoesSobreErros);

                if (Int32.Parse(tbNotaInicial.Text) > Int32.Parse(tbNotaFinal.Text))
                    throw new Exception("Nota Inicial deve ser menor que Nota Final.");


                //Código da UF + CNPJ + modelo + série + nro inicial e nro final precedida do literal “ID”
                ITInutNFe oInutilizacao = (ITInutNFe)XMLUtils.XMLFactory(oParam.versao, "TInutNFe");

                oInutilizacao.versao = oParam.versaoDados;
                oInutilizacao.infInut = (ITInutNFeInfInut)XMLUtils.XMLFactory(oParam.versao, "TInutNFeInfInut");
                oInutilizacao.infInut.ano = tbAno.Text;
                oInutilizacao.infInut.CNPJ = tbCNPJ.Text;

                oInutilizacao.infInut.cUF = NFeUtils.DefineUF(cbUF.SelectedValue.ToString());

                oInutilizacao.infInut.Id = "ID" + cbUF.SelectedValue.ToString() + tbAno.Text.PadLeft(2, '0') + tbCNPJ.Text + tbMod.Text +
                                                  tbSerie.Text.PadLeft(3, '0') + tbNotaInicial.Text.PadLeft(9, '0') + tbNotaFinal.Text.PadLeft(9, '0');

                oInutilizacao.infInut.mod = oParam.conexao == TipoConexao.NFCe ? TMod.Item65 : TMod.Item55;
                oInutilizacao.infInut.nNFIni = tbNotaInicial.Text;
                oInutilizacao.infInut.nNFFin = tbNotaFinal.Text;
                oInutilizacao.infInut.serie = tbSerie.Text;

                oInutilizacao.infInut.tpAmb = (TAmb)NFeUtils.DefineEnum(cbTipoAmbiente.SelectedValue.ToString(), typeof(TAmb));
                oInutilizacao.infInut.xJust = tbJust.Text;
                oInutilizacao.infInut.xServ = TInutNFeInfInutXServ.INUTILIZAR;

                String cStat = String.Empty;
                String xMotivo = String.Empty;

                oFuncao.InutilizaNumeracao(oInutilizacao, ref cStat, ref xMotivo, oParam.versao);


                if (cStat == String.Empty && xMotivo == String.Empty) //recebeu resposta da sefaz
                    throw new Exception("Não foi possível executar Inutilização. Consulte o LOG do sistema.");

                if (cStat != "102")
                    throw new Exception(xMotivo);

                ITRetInutNFe oRetInut = (ITRetInutNFe)
                                    XMLUtils.CarregaXML_HD(oParam.pastaRecibo + oInutilizacao.infInut.Id + "-inu.xml",
                                    oParam.versao, "TRetInutNFe");

                oInutilizacao = (ITInutNFe)XMLUtils.CarregaXML_HD(oParam.pastaRecibo + oInutilizacao.infInut.Id + "-ped-inu.xml",
                                                            oParam.versao, "TInutNFe");



                Int32 notaInicial = Int32.Parse(oInutilizacao.infInut.nNFIni);
                Int32 notaFinal = Int32.Parse(oInutilizacao.infInut.nNFFin);

                while (notaInicial <= notaFinal)
                {
                    NotaInutilizada oNota = new NotaInutilizada();
                    oNota.numeroNota = notaInicial.ToString();

                    //setar a serie da nota
                    oNota.serieNota = oInutilizacao.infInut.serie;
                    oNota.data = DateTime.Today;
                    oNota.empresa = oParam.empresa;

                    oNota.XMLResposta = XMLUtils.GetXML(oRetInut, oParam.versao);
                    oNota.XMLPedido = XMLUtils.GetXML(oInutilizacao, oParam.versao);

                    oNota.Save(manager);

                    notaInicial++;
                }

                MessageBox.Show(xMotivo);

            }
            catch (Exception ex)
            {
                if (oFuncao != null)
                {
                    oFuncao.CriaLog(999, "Inutilização de Notas", ex);
                }
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oParam = null;
                oFuncao = null;
                Conexao.DisposeManager(manager);
            }
        }




        private void tbAno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}