using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace RDI.NFe2.ORMAP
{



    public enum TipoSituacaoNota
    {
        //todo : criar as situacoes de nota
        [Description("")]
        Vazio
    }

    public enum TipoSituacaoServico
    {
        [Description("")]
        Vazio,
        [Description("Excluido")]
        Excluido = -4,
        [Description("Falha no Envio")]
        ProblemaNoEnvio = -3,
        [Description("Inválido")]
        Invalido = -2,
        [Description("Processado com erro")]
        Rejeitado = -1,
        [Description("Aguardando Envio")]
        Assinado = 1,
        [Description("Aguardando Aprovação")]
        Enviado = 2,
        [Description("Processado")]
        Processado = 3,
        [Description("Finalizado")]
        Finalizado = 4 
    }

    public enum Delay        
    {
        [Description("")]
        Vazio,
        [Description("Timeout Lento")]
        Lento = 120000,
        [Description("Timeout Rápido")]
        Rapido = 80000 
    }

}
