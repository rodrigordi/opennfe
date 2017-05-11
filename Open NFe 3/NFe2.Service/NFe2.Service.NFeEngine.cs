using System.ServiceProcess;
using System;
using RDI.NFe2.Business;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using RDI.NFe2.ORMAP;
using RDI.Lince;

namespace NFSe.Service
{
    public class NFeEngine : System.ServiceProcess.ServiceBase
    {
        String ConAux = string.Empty;
        string cEmp = string.Empty;

        List<ThreadIdetificada> threads;
        List<Empresa> empresasHabilitadas;
        Boolean gravarLogEmArquivo;
        Boolean enviarInformacoesSobreErros;

        public NFeEngine()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string sSource = "NFeAdmin";
            string sLog = "Application";
            string sEvent = "Serviço inicializado com sucesso";
            EventLogEntryType eventType = EventLogEntryType.Information;

            ClientEnvironment manager = null;
            try
            {
                String ConnectionFileName = AppDomain.CurrentDomain.BaseDirectory + "\\conexao";
                #region carregar arquivo de conexao

                if (!File.Exists(ConnectionFileName))
                {
                    throw new Exception("Arquivo de conexão não existe ou esta corrompido. " + ConnectionFileName);
                }

                using (StreamReader SR = File.OpenText(ConnectionFileName))
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
                #endregion

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

                empresasHabilitadas = new List<Empresa>();
                manager = Conexao.CreateManager(ConAux);

                foreach (var empresa in lEmpresas)
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

                threads = new List<ThreadIdetificada>();
                foreach (var item in empresasHabilitadas.Where(e => e.habilitada)) //somente habilitadas
                {
                    var oThreadIdentificada = new ThreadIdetificada();
                    oThreadIdentificada.OnStart += new StatusEventHandler(oThreadIdentificada_OnStart);
                    oThreadIdentificada.OnError += new ExceptionEventHandler(oThreadIdentificada_OnError);
                    oThreadIdentificada.OnStop += new StatusEventHandler(oThreadIdentificada_OnStop);
                    oThreadIdentificada.args = new object[3];
                    oThreadIdentificada.args[0] = ConAux;
                    oThreadIdentificada.args[1] = item.cnpj;
                    oThreadIdentificada.args[2] = enviarInformacoesSobreErros;


                    oThreadIdentificada.empresa = item.cnpj;
                    oThreadIdentificada.executando = false;
                    oThreadIdentificada.pastaEntrada = item.pastaEntrada;

                    //inicializa thread
                    ParameterizedThreadStart operacao = new ParameterizedThreadStart(NFeUtils.ThreadMasterExecution);
                    oThreadIdentificada.finalizar = false;
                    oThreadIdentificada.minhaThread = new Thread(operacao);
                    oThreadIdentificada.minhaThread.Start(oThreadIdentificada);

                    threads.Add(oThreadIdentificada);
                }
            }
            catch (Exception ex)
            {
                sEvent = "Erro ao inicializar serviço : " + ex.Message;
                eventType = EventLogEntryType.Error;
            }
            finally
            {
                Conexao.DisposeManager(manager);
            }

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent, eventType);

        }

        protected override void OnStop()
        {
            string sSource = "NFeAdmin";
            string sLog = "Application";
            string sEvent = "Serviço finalizado com sucesso";
            EventLogEntryType eventType = EventLogEntryType.Information;

            try
            {
                foreach (var oThreadIdentificada in threads)
                {
                    oThreadIdentificada.finalizar = true;
                    while (!oThreadIdentificada.finalizado)
                    {
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                sEvent = "Erro ao inicializar serviço : " + ex.Message;
                eventType = EventLogEntryType.Error;
            }

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent, eventType);
        }

        void oThreadIdentificada_OnStop(object sender, StatusEventArgs e)
        {
            string sSource = "NFeAdmin";
            string sLog = "Application";
            string sEvent = "Automação paralizada.";
            EventLogEntryType eventType = EventLogEntryType.Information;
            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent, eventType);
        }

        void oThreadIdentificada_OnStart(object sender, StatusEventArgs e)
        {
            string sSource = "NFeAdmin";
            string sLog = "Application";
            string sEvent = "Automação inicializada.";
            EventLogEntryType eventType = EventLogEntryType.Information;
            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent, eventType);
        }

        void oThreadIdentificada_OnError(object sender, ExceptionEventArgs e)
        {
            string sSource = "NFeAdmin";
            string sLog = "Application";
            string sEvent = "Ocorreu uma chamada inválida. Feche o monitor e abra novamente. "
                + e.error.Message + " : " + e.error.StackTrace;
            EventLogEntryType eventType = EventLogEntryType.Error;
            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent, eventType);
        }


        #region Auto-Generated
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            // 
            // NFeEngine
            // 
            this.CanShutdown = true;
            this.ServiceName = "NFeEngine";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        static void Main()
        {
            //throw new Exception("Em Desenvolvimento");

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new NFeEngine()
            };
            ServiceBase.Run(ServicesToRun);
        }
        #endregion
    }
}
