# Estamos migrando o DANFE para o DanfeSharp (https://danfesharp.codeplex.com/)


# opennfe
RDI Open NFe é uma solução de código-fonte aberto desenvolvida pela Rocha Digital Intelligence (RDI) para a Administração de Notas Fiscais Eletrônicas dentro das empresas. A solução é parte do projeto RDI Open SPED e pode ser integrado a qualquer ERP, incluindo SAP.

# Como instalar o Open NFe
Antes de instalar o Open NFe é preciso que você saiba:

1) Open NFe é uma solução open-source escrita em C# e está sob a licença GPL;
2) Segundo esta licença, a RDI não oferece garantia sobre eventuais bugs;
3) Demais assemblies (DLLs) enviadas junto ao projeto são freeware mas não Open Source;
4) Caso não concorde com os termos, por favor não instale a solução.

Ciente disto, aconselhamos que você prepare uma máquina como servidora de Nota Fiscal Eletrônica. Essa máquina precisa ter:

1) Acesso a internet;
2) Acesso aos certificados;
3) Acesso a uma base SQL Server 2005 ou superior (você pode obter a versão gratuita - Express - no site da Microsoft);
4) Acesso a uma impressora
5) O .NET Framework - versão 4 - instalado.

Uma possibilidade é separar ainda o banco de dados em outra máquina. Verifique a necessidade de acordo com sua infra-estrutura. Mas, se for o caso, você pode manter o banco de dados e o Open NFe no mesmo servidor. 

Com o ambiente do servidor pronto, proceda a instalação da seguinte forma:

1) Descompacte o arquivo OpenNFE.zip em algum diretório na máquina servidora;
2) Rode os scripts no Microsoft® SQL Server® 2008 Management Studio Express (eles estão na pasta Scripts);
3) Ajuste a string de conexão caso tenha separado as camadas de banco de dados e servidor de NFe (nesse caso você precisará recompilar o projeto: o default é localhost);
4) Rode o arquivo nfeadmin.exe. Este executável corresponde ao servidor NFe e deve permanecer ativo. Ele fará a varredura do diretório "CaixaDeEntrada". Esse diretório pode ser configurado.

Para utilizar o Open NFe basta criar os arquivos XML correspondentes a Nota Fiscal Eletrônica e enviar para a pasta CaixaDeEntrada. Após a assinatura, a nota será renomeada e disponibilizada na pasta CaixaDeSaida.

Caso necessite recompilar a aplicação, utilize o Microsoft Visual Studio 2015.

