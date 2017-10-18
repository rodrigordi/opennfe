namespace RDI.OpenSigner
{
    public enum TRetornoAssinatura
    {
        Assinada,
        RefURiNaoExiste,
        RefURiNaoUnica,
        ErroAoAssinarDocumento,
        XMLMalFormado,
        ProblemaAoAcessarCertificado,
        ArquivoNaoEncontrado
    }

}