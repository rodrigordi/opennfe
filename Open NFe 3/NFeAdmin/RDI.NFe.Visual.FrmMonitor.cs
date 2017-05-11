using RDI.Lince;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RDI.NFe2.Business;
using System.IO;
using System.Threading;
using RDI.NFe2.ORMAP;
using System.Linq;


namespace RDI.NFe.Visual
{
    public partial class FrmMonitor : Form
    {
        List<ThreadIdetificada> threads;
        DateTime lastChangeTime;
        public FrmMonitor()
        {
            InitializeComponent();

            ClientEnvironment manager;
            Parametro oParam;
            try
            {
                manager = Conexao.CreateManager(Program.ConAux);

                //carregar threads
                threads = new List<ThreadIdetificada>();
                foreach (var item in Program.empresasHabilitadas.Where(e => e.habilitada)) //somente habilitadas
                {
                    var t = new ThreadIdetificada();
                    t.OnStart += new StatusEventHandler(oThreadIdentificada_OnStart);
                    t.OnError += new ExceptionEventHandler(oThreadIdentificada_OnError);
                    t.OnStop += new StatusEventHandler(oThreadIdentificada_OnStop);
                    t.args = new object[3];
                    t.args[0] = Program.ConAux;
                    t.args[1] = item.cnpj;
                    t.args[2] = Program.enviarInformacoesSobreErros;

                    oParam = Program.GetParametro(item.cnpj, manager);

                    t.empresa = item.cnpj;
                    t.executando = false;
                    t.pastaEntrada = oParam.pastaEntrada;
                    if (string.IsNullOrEmpty(t.pastaEntrada))
                        MessageBox.Show("Empresa " + item.cnpj + ". Pasta de entrada não foi configurada.");

                    var operacao = new ParameterizedThreadStart(NFeUtils.ThreadMasterExecution);
                    t.finalizar = false;
                    t.minhaThread = new Thread(operacao);


                    threads.Add(t);
                }

                dgvMonitor.AutoGenerateColumns = false;
                dgvMonitor.DataSource = threads;

                oLoop.Enabled = false;
            }
            catch (Exception ex)
            {
                threads = new List<ThreadIdetificada>();// criar lista vazia
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oParam = null;
                manager = null;
                Conexao.DisposeManager(manager);
            }
        }

        void oThreadIdentificada_OnStop(object sender, StatusEventArgs e)
        {
            Program.empresasHabilitadas.First(em => em.cnpj == e.empresa).AutomacaoHabilitada = false;
        }

        void oThreadIdentificada_OnStart(object sender, StatusEventArgs e)
        {
            Program.empresasHabilitadas.First(em => em.cnpj == e.empresa).AutomacaoHabilitada = true;
        }

        void oThreadIdentificada_OnError(object sender, ExceptionEventArgs e)
        {
            MessageBox.Show("Ocorreu uma chamada inválida. Feche o monitor e abra novamente. "
                + e.error.Message + " : " + e.error.StackTrace);
        }

        private void FrmMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threads.Count(t => t.executando) > 0)
            {
                PararTodas();
                MessageBox.Show("Todos os serviços foram parados.");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var empresa = ((ThreadIdetificada)dgvMonitor.Rows[e.RowIndex].DataBoundItem).empresa;
            var thr = threads.First(t => t.empresa == empresa);

            //buscar informacao
            if (e.ColumnIndex.Equals(2))
            {
                //start
                if (thr.executando)
                {
                    MessageBox.Show("Automação da empresa já está em execução.");
                    return;
                }

                thr.minhaThread.Start(thr);

                lastChangeTime = DateTime.Now;
                oLoop.Enabled = true;
            }
            else if (e.ColumnIndex.Equals(3))
            {
                //stop
                if (!thr.executando)
                {
                    MessageBox.Show("Automação da empresa não está em execução.");
                    return;
                }

                thr.finalizar = true;
                //esperar thread terminar
                thr.minhaThread.Join();

                //prerarar thread para ser reiniciada
                var operacao = new ParameterizedThreadStart(NFeUtils.ThreadMasterExecution);
                thr.finalizar = false;
                thr.finalizado = false;
                thr.executando = false;
                thr.minhaThread = new Thread(operacao);
                //fim

                lastChangeTime = DateTime.Now;
                oLoop.Enabled = true;
            }
        }

        private void oLoop_Tick(object sender, EventArgs e)
        {
            dgvMonitor.DataSource = threads;
            dgvMonitor.Refresh();

            if (DateTime.Now.Subtract(lastChangeTime).Seconds > 10)
            {
                oLoop.Enabled = false;
            }
        }

        private void btnIniciarTodas_Click(object sender, EventArgs e)
        {
            foreach (var thr in threads)
            {
                if (thr.executando)
                    continue;

                thr.minhaThread.Start(thr);
            }

            lastChangeTime = DateTime.Now;
            oLoop.Enabled = true;
        }

        private void btnPararTodas_Click(object sender, EventArgs e)
        {
            PararTodas();
        }

        private void PararTodas()
        {
            foreach (var thr in threads)
            {
                if (!thr.executando)
                    continue;

                thr.finalizar = true;
            }

            foreach (var thr in threads.Where(t => t.finalizar))
            {
                //esperar thread terminar
                thr.minhaThread.Join();

                //prerarar thread para ser reiniciada
                var operacao = new ParameterizedThreadStart(NFeUtils.ThreadMasterExecution);
                thr.finalizar = false;
                thr.finalizado = false;
                thr.executando = false;
                thr.minhaThread = new Thread(operacao);
                //fim
            }

            lastChangeTime = DateTime.Now;
            oLoop.Enabled = true;
        }
    }
}