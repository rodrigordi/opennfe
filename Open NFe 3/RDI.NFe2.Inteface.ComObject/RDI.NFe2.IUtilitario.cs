using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using RDI.NFe2.SchemaXML;
using RDI.OpenSigner;

public interface IUtilitario
{
    String GetUltimaValidacao();

    void SetUtilitario(String certificado, Boolean Producao, Boolean TpEmisNormal, String UF, int conexao, int tipoBusca, int versaoXML);
    void SetUtilitario(String certificado, Boolean Producao, Boolean TpEmisNormal, String UF, TipoConexao conexao, TBuscaCertificado tipoBusca, VersaoXML versaoXML);

    void DefineUF(String UF);
    void DefineUF(TCodUfIBGE UF);


    /// <summary>
    /// abre um dialogo para que o certificado possa ser selecionado pelo usuario
    /// </summary>
    /// <param name="ContaComputador">true - busca certificado em LocalMachine; false - busca certificado em CurrentUser</param>
    /// <returns>se encontrado - subject do certificado; senao -  String.Empty</returns>
    string BuscaCertificados(String valor);


    /// <summary>
    /// Assina um arquivo XML de acordo com a uri recebida como parametro.
    /// </summary>
    /// <param name="nomeCertificado">Subject do Certificado que será utilizado na assinatura do arquivo XML</param>
    /// <param name="caminhoArquivoOrigem">Origem do arquivo XML</param>
    /// <param name="uri">Uri que será assinada</param>
    /// <param name="caminhoArquivoDestino">Destino do arquivo XML</param>
    /// <param name="ContaComputador">true - busca certificado em LocalMachine; false - busca certificado em CurrentUser</param>
    /// <returns> 0 - assinado com sucesso
    ///  1 - Erro: Problema ao acessar o certificado digital - %exceção%
    ///extinto  2 - Problemas no certificado digital
    ///  3 - XML mal formado + exceção
    ///  4 - A tag de assinatura %RefUri% inexiste
    ///  5 - A tag de assinatura %RefUri% não é unica
    ///extinto  6 - Erro Ao assinar o documento - ID deve ser string %RefUri(Atributo)%
    ///  7 - Erro: Ao assinar o documento - %exceção%
    /// 11 - arquivo de origem nao existe</returns>
    int AssinaXMLHD(String caminhoArquivoOrigem, String uri,
                        String caminhoArquivoDestino);

    String AssinaXMLST(String ArquivoOrigem, String uri);
    TRetornoAssinatura AssinaXML(String xml, String uri, out string xmlAssinado);

    String ValidaXML(String caminhoXML, String caminhoXSD);

    void DefineNomeCertificado(String NomeCertificado);

    void DefineContaComputador(Boolean ContaComputador);

    void DefineProxy(String usuario, String senha, String dominio, String url);

    void SetProxy(Boolean habilita);

    string Unzip(string stZipped);

    Boolean StatusWebService();

    string StatusWebServiceST();

    //carregando do HD
    Boolean AutorizacaoHD(String caminhoArquivoEnviNFe, String caminhoArquivoRetEnviNFe);
    Boolean RetAutorizacaoHD(String caminhoArquivoConsReciNFe, String caminhoArquivoRetConsReciNFe);
    Boolean InutilizacaoHD(String caminhoArquivoInutNFe, String caminhoArquivoRetInutNFe);
    Boolean RecepcaoEventoHD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);
    Boolean ConsultaProtocoloHD(String caminhoArquivoConsSitNFCe3, String caminhoArquivoRetConsSitNFCe3);


    //passando xml via string
    String AutorizacaoST(String ArquivoEnviNFe);
    String RetAutorizacaoST(String ArquivoConsReciNFe);
    String InutilizacaoST(String ArquivoInutNFe);
    String RecepcaoEventoST(String ArquivoEnvEvento);
    String ConsultaProtocoloST(String ArquivoConsSitNFe);



    Boolean ConsultaCadastroHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String ConsultaCadastroST(String XMLEnvio);

    Boolean ConsultarDFeHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String ConsultarDFeST(String XMLEnvio);
    IRetDistDFeInt ConsultarDFe(IDistDFeInt oXMLEnvio);

    Boolean DownloadNFHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String DownloadNFST(String XMLEnvio);
    ITRetDownloadNFe DownloadNF(ITDownloadNFe oXMLEnvio);

    String RecepcaoEvento_MDe_ST(String ArquivoEnvEvento);
    Boolean RecepcaoEvento_MDe_HD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);

    String RecepcaoEvento_EPEC_ST(String ArquivoEnvEvento);
    Boolean RecepcaoEvento_EPEC_HD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);

    bool ManifestarConhecimento(string chaveNFe, string cnpj);

    Boolean GNRE_RecepcaoLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_RecepcaoLoteST(String XMLEnvio);

    Boolean GNRE_ConsultaLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_ConsultaLoteST(String XMLEnvio);

    Boolean GNRE_ConsultaConfigHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_ConsultaConfigST(String XMLEnvio);
}
