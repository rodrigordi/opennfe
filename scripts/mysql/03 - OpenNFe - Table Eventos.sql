CREATE TABLE Eventos(
	NumeroLote int NOT NULL,
	CNPJ varchar(14) NOT NULL,
	ChaveNota varchar(47) NOT NULL,
	ID int NOT NULL,
	tpEvento int NOT NULL,
	xmlPedido text NULL,
	xmlProcesso text NULL,
	situacao int NULL,
 CONSTRAINT PK_Eventos PRIMARY KEY CLUSTERED 
(
	NumeroLote ASC,
	CNPJ ASC,
	ChaveNota ASC,
	ID ASC
)
) ;

ALTER TABLE Eventos   ADD  CONSTRAINT FK_NotasFiscais_Eventos FOREIGN KEY(NumeroLote, ChaveNota, CNPJ)
REFERENCES NotasFiscais (NumeroLote, ChaveNota, CNPJ);




