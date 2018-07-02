using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RDI.NFe.Visual;
using RDI.NFe2.Business;
using System.IO;
using RDI.Lince;
using RDI.NFe2.ORMAP;
using System.ServiceProcess;
using System.Management;
using System.Linq;
using RDI.OpenSigner;
using RDI.NFe2.SchemaXML;

namespace RDI.NFe
{


    static class Program
    {
        static public String ConAux = string.Empty;
        static public string cEmp = string.Empty;

        static public List<Empresa> empresasHabilitadas;
        static public String empresaSelecionada;
        static public Boolean gravarLogEmArquivo;
        static public Boolean enviarInformacoesSobreErros;


        static public Boolean ServicoInstalado;
        static private ServiceController _ServicoNFe;
        static public ServiceController ServicoNFe
        {
            get
            {
                _ServicoNFe.Refresh();
                return _ServicoNFe;
            }
            set
            {
                _ServicoNFe = value;
            }
        }

        static public Boolean ServicoHabilitado
        {
            get
            {
                if (ServicoInstalado)
                    return ServicoNFe.Status == ServiceControllerStatus.Running;
                else
                    return false;
            }
        }


        static public bool VerificarEmpresas(List<String> empresas, ClientEnvironment manager)
        {
            empresasHabilitadas = new List<Empresa>();
            foreach (var empresa in empresas)
            {
                ParametroQRY oParamQRY = new ParametroQRY();
                oParamQRY.empresa = empresa;

                var emps = ParametroDAL.Instance.GetInstances(oParamQRY, manager);
                var existeEmpresa = emps.Count == 1;
                var pastaEntrada = string.Empty;
                if (existeEmpresa)
                {
                    pastaEntrada = ((Parametro)emps[0]).pastaEntrada;
                }

                empresasHabilitadas.Add(new Empresa() { cnpj = empresa, AutomacaoHabilitada = false, habilitada = existeEmpresa, pastaEntrada = pastaEntrada });
            }

            return empresasHabilitadas.Count(e => !e.habilitada) == 0;
        }

        static public Parametro GetParametro(String empresa, ClientEnvironment manager)
        {
            ParametroQRY oParamQRY = new ParametroQRY();
            oParamQRY.empresa = empresa;

            var _param = (Parametro)ParametroDAL.Instance.GetInstances(oParamQRY, manager)[0];

            //dados não persistidos
            _param.tipoBuscaCertificado = _param.usaWService ? TBuscaCertificado.Nome_MaquinaLocal : TBuscaCertificado.Nome_ContaUsuario;
            _param.conexao = TipoConexao.NFe;

            return _param;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Boolean canRun = true;
            ClientEnvironment manager = null;
            try
            {
                bool arquivoConexaoExiste = File.Exists(".\\conexao");

                if (!arquivoConexaoExiste)
                {
                    //abrir form para solicitar informações ao usuario.
                    using (var frmCon = new FrmConexao())
                    {
                        frmCon.ShowDialog();
                    }

                    arquivoConexaoExiste = File.Exists(".\\conexao");
                }

                if (!arquivoConexaoExiste)
                {
                    throw new Exception("Arquivo de conexão não foi localizado.");
                }

                bool conexaoOK = false;
                bool cancelado = false;
                do
                {
                    using (StreamReader SR = File.OpenText(".\\conexao"))
                    {
                        ConAux = SR.ReadLine();
                        cEmp = SR.ReadLine();

                        var linhaLog = SR.ReadLine();
                        if (!string.IsNullOrEmpty(linhaLog))
                            gravarLogEmArquivo = (linhaLog == "1");

                        var enviarInfo = SR.ReadLine();
                        if (!string.IsNullOrEmpty(enviarInfo))
                            enviarInformacoesSobreErros = (enviarInfo == "1");
                    }
                    GC.Collect();

                    manager = Conexao.CreateManager(ConAux);
                    //TODO : verificar estrutura das tabelas

                    List<string> lEmpresas = null;
                    if (cEmp.Contains(','))
                    {
                        lEmpresas = cEmp.Split(',').ToList();
                    }
                    else
                    {
                        lEmpresas = new List<string>();
                        lEmpresas.Add(cEmp);
                    }

                    conexaoOK = VerificarEmpresas(lEmpresas, manager);

                    if (!conexaoOK)
                    {
                        //Perguntar se deseja abrir o FrmConexao novamente
                        DialogResult dialogResult = MessageBox.Show("Alguns CNPJs não foram encontrado nos parametros. Deseja informar um outro valor ?", "Empresa não encontrada", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            using (var frmCon = new FrmConexao(ConAux, cEmp, enviarInformacoesSobreErros))
                            {
                                if (frmCon.ShowDialog() == DialogResult.Cancel)
                                    cancelado = true;

                                frmCon.Dispose();
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            cancelado = true;
                        }
                    }
                }
                while (!conexaoOK && !cancelado);

                if (!conexaoOK)
                    throw new Exception("Não foi possível definir a empresa.");

                empresaSelecionada = empresasHabilitadas.First(e => e.habilitada).cnpj;

                String serviceName = "EngineNFe2";
                #region verificar se o servico esta instalado
                //localizar servico
                string filter = String.Format("SELECT * FROM Win32_Service WHERE Name = '{0}'", serviceName);
                ManagementObjectSearcher query = new ManagementObjectSearcher(filter);
                // No match = failed condition
                if (query == null) ServicoInstalado = false;
                try
                {
                    ManagementObjectCollection services = query.Get();
                    foreach (ManagementObject service in services)
                    {
                        ServicoInstalado = service.GetPropertyValue("StartMode").ToString() != "Disabled";
                        break;
                    }
                }
                catch
                {
                    ServicoInstalado = false;
                }

                //se servico esta instalado, carregar servico
                if (ServicoInstalado)
                {
                    try
                    {
                        ServicoNFe = new ServiceController(serviceName);
                    }
                    catch
                    {
                        //falha ao carregar servico
                        ServicoInstalado = false;
                    }
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO : " + ex.Message, "OpenNFe");
                MessageBox.Show("Este programa executou uma tarefa ilegal e será fechado. Contate o Administrador do Sistema.", "OpenNFe");
                canRun = false;
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }

            if (canRun)
            {
                Application.Run(new FrmMaster());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}