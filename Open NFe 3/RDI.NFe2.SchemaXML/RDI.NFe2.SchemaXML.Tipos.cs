using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace RDI.NFe2.SchemaXML
{



    public enum TipoSituacaoNota
    {
        //todo : criar as situacoes de nota
        [Description("")]
        Vazio = -1,
        [Description("Nota Assinada")]
        Assinada = 0,
        [Description("Problema ao acessar certificado")]
        ProblemaAoAcessarCertificado = 1,
        [Description("Problema no certificado")]
        ProblemaNoCertificado = 2,
        [Description("XML Mal formado")]
        XMLMalFormado = 3,
        [Description("URI não existe")]
        RefURiNaoExiste = 4,
        [Description("URI nã unica")]
        RefURiNaoUnica = 5,
        [Description("Erro ao assinar documento - interno")]
        ErroAoAssinarDocumentoInterno = 6,
        [Description("Erro ao assinar documento")]
        ErroAoAssinarDocumento = 7,
        [Description("XML Inválido")]
        XMLInvalido = 8,
        [Description("Exceção na Assinatura - Geral")]
        ExcecaoGeralAssinatura = 9,
        [Description("Arquivo de validação não encontrado")]
        ArquivoValidacaoNaoEncontrado = 10,
        [Description("Arquivo não encontrado")]
        ArquivoNaoEncontrado = 11,
        [Description("Nota Enviada")]
        Enviada = 12,
        [Description("Nota Aprovada")]
        Aprovada = 13,
        [Description("Nota Rejeitada")]
        Rejeitada = 14,
        [Description("Nota Impressa")]
        Impressa = 15,
        [Description("Nota Cancelada")]
        Cancelada = 16,
        [Description("Nota Rejeitada pelo Lote")]
        RejeitadaPeloProcessamentoLote = 17,
        [Description("Uso Denegado")]
        Denegada = 18,
        [Description("Sem serviço")]
        SerivcoExcluido = 99,
    }

    public enum TipoSituacaoEvento
    {
        [Description("")]
        Vazio,
        [Description("Finalizado com rejeição da SEFAZ")]
        FinalizadoComRejeicaoRegras = 1,
        [Description("Finalizado com Recebimento da SEFAZ(com vinculação do evento na NF-e)")]
        FinalizadoAprovado135 = 2,
        [Description("Erro Desearilização")]
        ErroDesearilizacao = 3,
        [Description("Finalizado com rejeição do Lote da SEFAZ")]
        FinalizadoComRejeicaoLote = 4,
        [Description("Finalizado com Recebimento da SEFAZ(sem vinculação do evento na NF-e)")]
        FinalizadoAprovado136 = 5,
        [Description("Finalizado com Recebimento da SEFAZ(Cancelamento fora do prazo)")]
        FinalizadoAprovado155 = 6,
        [Description("Não executado(Erro)")]
        NaoExecutadoErro = 99
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
        AguardandoEnvio = 1,
        [Description("Aguardando Aprovação")]
        AguardandoRetornoAprovacao = 2,
        [Description("Processado")]
        Processado = 3,
        [Description("Finalizado")]
        Finalizado = 4,
        [Description("Envio cancelado")]
        EnvioCancelado = 5
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
