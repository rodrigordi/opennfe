USE [OpenNFe2]
GO

/****** Object:  Table [dbo].[Eventos]    Script Date: 07/02/2012 16:17:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Eventos](
	[NumeroLote] [int] NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[ChaveNota] [varchar](47) NOT NULL,
	[ID] [int] NOT NULL,
	[tpEvento] [int] NOT NULL,
	[xmlPedido] [text] NULL,
	[xmlProcesso] [text] NULL,
	[situacao] [int] NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[NumeroLote] ASC,
	[CNPJ] ASC,
	[ChaveNota] ASC,
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_NotasFiscais_Eventos] FOREIGN KEY([NumeroLote], [ChaveNota], [CNPJ])
REFERENCES [dbo].[NotasFiscais] ([NumeroLote], [ChaveNota], [CNPJ])
GO

ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_NotasFiscais_Eventos]
GO


