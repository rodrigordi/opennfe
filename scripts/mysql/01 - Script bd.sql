CREATE SCHEMA IF NOT EXISTS OpenNFe2 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;

USE OpenNFe2;

CREATE TABLE ServicosPendentes(
	CNPJ varchar(14) NOT NULL,
	NumeroLote int NOT NULL,
	CodigoSituacao int NOT NULL,
	DataSituacao datetime NOT NULL,
	NumeroRecibo varchar(15) NULL,
	XMLRecibo text NULL,
	XMLRetConsulta text NULL,
	erroEnvio bit NOT NULL,
	TipoOperacao int NOT NULL,
	ModoOperacao int NOT NULL,
	UnidadeFederativa int NOT NULL,
 CONSTRAINT PK_ServicosPendentes PRIMARY KEY CLUSTERED 
(
	CNPJ ASC,
	NumeroLote ASC
) );

CREATE TABLE Parametros(
	TipoOperacao int NOT NULL,
	ModoOperacao int NOT NULL,
	QtdeNFLote int NOT NULL,
	TempoFechaLote int NOT NULL,
	TamanhoLote int NOT NULL,
	DiretorioRecibo varchar(160) NOT NULL,
	DiretorioEntrada varchar(160) NOT NULL,
	DiretorioSaida varchar(160) NOT NULL,
	NomeCertificado varchar(300) NOT NULL,
	UsaProxy bit NOT NULL,
	UsuarioProxy varchar(30) NULL,
	SenhaProxy varchar(30) NULL,
	DominioProxy varchar(30) NULL,
	UrlProxy varchar(50) NULL,
	UnidadeFederativa int NOT NULL,
	CNPJ varchar(14) NOT NULL,
	TimeOut int NOT NULL,
	DiretorioImpressao varchar(300) NOT NULL,
	DiretorioXSD varchar(300) NOT NULL,
	WService bit NOT NULL,
 CONSTRAINT PK_Parametros PRIMARY KEY CLUSTERED 
(
	CNPJ ASC
)
);

CREATE TABLE NotasInutilizadas(
	NumeroNota varchar(9) NOT NULL,
	Data datetime NOT NULL,
	CNPJ varchar(14) NOT NULL,
	XMLPedido text NOT NULL,
	XMLResposta text NOT NULL,
	SerieNota varchar(3) NOT NULL,
 CONSTRAINT PK_NotasInutilizadas PRIMARY KEY CLUSTERED 
(
	NumeroNota ASC,
	CNPJ ASC,
	SerieNota ASC
)
);

CREATE TABLE NotasFiscais(
	NumeroLote int NOT NULL,
	CNPJ varchar(14) NOT NULL,
	ChaveNota varchar(47) NOT NULL,
	CodigoSituacao int NOT NULL,
	DescricaoSituacao varchar(255) NOT NULL,
	DataSituacao datetime NOT NULL,
	XMLNotaFiscal text NOT NULL,
	XMLProcesso text NULL,
	cStat varchar(3) NULL,
	xMotivo varchar(255) NULL,
	nProt varchar(15) NULL,
	XMLPedidoCancelamento text NULL,
	XMLProcessoCancelamento text NULL,
	nProtCancelamento varchar(15) NULL,
 CONSTRAINT cpNotasFiscais_NumeroLote PRIMARY KEY CLUSTERED 
(
	NumeroLote ASC,
	ChaveNota ASC,
	CNPJ ASC
)
) ;

CREATE TABLE `LOG`(
	NumeroLog MEDIUMINT AUTO_INCREMENT NOT NULL,
	CNPJ varchar(14) NOT NULL,
	CodigoSituacao int NOT NULL,
	DescricaoSituacao varchar(500) NOT NULL,
	DataLog datetime NOT NULL,
	ChaveNota varchar(47) NULL,
	CONSTRAINT cpLog_NumeroLog PRIMARY KEY CLUSTERED
(
NumeroLog ASC
)
) ;

CREATE VIEW vwNotasInutilizadas as
SELECT NumeroNota
      ,Data
      ,CNPJ
  FROM NotasInutilizadas;

