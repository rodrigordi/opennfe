using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RDI.NFe.Visual
{
    public partial class FrmMonitorServico : Form
    {
        public FrmMonitorServico()
        {
            InitializeComponent();

            #region verificar se esta rodando pelo servico
            if (Program.ServicoInstalado)
            {
                btStart.Enabled = !Program.ServicoHabilitado;
                btStop.Enabled = Program.ServicoHabilitado;
                tssLStatus.Text = (Program.ServicoHabilitado ? "Serviço iniciado" : "Serviço parado");
            }
            #endregion
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = !btStart.Enabled;
            btStop.Enabled = !btStop.Enabled;
            tssLStatus.Text = "Serviço iniciado";
            StartThread();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            evStop();
        }

        private void evStop()
        {
            if (StopThread())
            {
                btStart.Enabled = !btStart.Enabled;
                btStop.Enabled = !btStop.Enabled;
                tssLStatus.Text = "Serviço parado";
            }
        }

        private void StartThread()
        {
            Program.ServicoNFe.Start();
        }

        private bool StopThread()
        {
            #region paralizar serviço
            try
            {
                Program.ServicoNFe.Stop();
                while (Program.ServicoNFe.Status != System.ServiceProcess.ServiceControllerStatus.Stopped)
                {
                    Thread.Sleep(100);
                }
                return true;
            }
            catch
            {
                return false;
            }
            #endregion
        }

    }
}
