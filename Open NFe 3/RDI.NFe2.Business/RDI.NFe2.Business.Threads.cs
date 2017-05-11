using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RDI.NFe2.Business
{
    public class ExceptionEventArgs : EventArgs
    {
        public Exception error { get; set; }
    }

    public delegate void ExceptionEventHandler(object sender, ExceptionEventArgs e);

    public class StatusEventArgs : EventArgs
    {
        public String empresa { get; set; }
    }

    public delegate void StatusEventHandler(object sender, StatusEventArgs e);

    public class ThreadIdetificada
    {
        
        public String pastaEntrada;
        public string status
        {
            get
            {
                if (executando) return "Iniciado";
                else
                {
                    if (finalizar && !finalizado) return "Finalizando"; else return "Parado";
                }

            }
        }

        public string empresa { get; set; }

        public volatile Boolean executando;
        public volatile Boolean finalizar;
        public volatile Boolean finalizado;

        public Thread minhaThread { get; set; }
        public object[] args { get; set; }

        public event StatusEventHandler OnStart;
        public event ExceptionEventHandler OnError;
        public event StatusEventHandler OnStop;

        public virtual void DoOnStart(object sender, StatusEventArgs e)
        {
            if (OnStart != null)
            {
                OnStart(sender, e);
            }
        }
        public virtual void DoOnError(object sender, ExceptionEventArgs e)
        {
            if (OnError != null)
            {
                OnError(sender, e);
            }
        }
        public virtual void DoOnStop(object sender, StatusEventArgs e)
        {
            if (OnStop != null)
            {
                OnStop(sender, e);
            }
        }
    }
}
