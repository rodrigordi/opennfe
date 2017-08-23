using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using RDI.NFe2.SchemaXML;
using RDI.NFe2.SchemaXML.NFe_v310;
using RDI.NFe2.ORMAP;

/// Objetivo : Converter os arquivos gerados em Txt no padrão da SEFAZ - SP para o padrão SEFAZ - Nacional em XML.
/// 
///

namespace RDI.NFe2.Business
{
    public static class ConverteNFe
    {
        private static TNFe oNotaFiscalXML;
        private static Int32 numeroItem;
        private static Int32 numeroItemDI;
        private static Int32 numeroItemDIAdicoes;
        private static Int32 nReboque;
        private static Int32 nVol;
        private static Int32 nLacres;
        private static Int32 nDup;
        private static Int32 nObs;
        private static Int32 nProc;
        private static TNFeInfNFeDetProdComb comb;
        private static TIpiIPITrib IPITrib;
        private static TNFeInfNFeDetImpostoPISPISOutr PISOutr;
        private static TNFeInfNFeDetImpostoCOFINSCOFINSOutr COFINSOutr;
        private static String UF;

        public static void Txt2Xml(string arqTXT, Parametro oParam, VersaoXML versao)
        {
            if (File.Exists(arqTXT))
            {
                StreamReader SR = File.OpenText(arqTXT);
                String linhaTXT = "";
                try
                {
                    while (!SR.EndOfStream)
                    {
                        linhaTXT = SR.ReadLine();
                        //DefineLinha(linhaTXT, oParam);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(linhaTXT + " ; " + ex.Message);
                }
                finally
                {
                    SR.Close();
                }
                if (oNotaFiscalXML != null)
                {
                    String chave;
                    chave = UF +
                            String.Format("{0:yy}", oNotaFiscalXML.infNFe.ide.dhEmi) +
                            String.Format("{0:MM}", oNotaFiscalXML.infNFe.ide.dhEmi) +
                            String.Format("{0:00000000000000}", oNotaFiscalXML.infNFe.emit.Item) +
                            oNotaFiscalXML.infNFe.ide.mod.ToString().PadLeft(2, '0') +
                            oNotaFiscalXML.infNFe.ide.serie.ToString().PadLeft(3, '0') +
                            oNotaFiscalXML.infNFe.ide.nNF.ToString().PadLeft(9, '0') +
                            oNotaFiscalXML.infNFe.ide.cNF.ToString().PadLeft(9, '0');

                    oNotaFiscalXML.infNFe.ide.cDV = DvBase11(chave);
                    chave = oNotaFiscalXML.infNFe.Id + chave + oNotaFiscalXML.infNFe.ide.cDV;

                    oNotaFiscalXML.infNFe.Id = chave;
                    XMLUtils.SalvaXML(oParam.pastaEntrada + chave + ".xml", oNotaFiscalXML, versao);
                    File.Delete(arqTXT);
                }
                else
                {
                    //todo : 
                }
            }
            else
            {
                throw new Exception("Arquivo TXT de origem inexistente.");
            }
        }

        public static String DvBase11(String Numero)
        {
            try
            {

                Int32 Dv, Multiplicador;
                Multiplicador = 2;
                Dv = 0;
                for (Int32 I = Numero.Length - 1; I >= 0; I--)
                {
                    Dv += (Int32.Parse(Numero[I].ToString()) * Multiplicador);
                    Multiplicador++;
                    if (Multiplicador > 9)
                        Multiplicador = 2;
                }
                Dv = Dv % 11;
                if (Dv > 1)
                    return (11 - Dv).ToString();
                else
                    return "0";
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na geração da chave de acesso." + ex.Message);
            }


        }


        //private static void DefineLinha(String linhaTXT, Parametro oParam)
        //{
        //    String[] itens = linhaTXT.Split('|');
        //    int a = 0;
        //    while (a < itens.Length)
        //    {
        //        itens[a] = itens[a].Trim();
        //        a++;
        //    }

        //    if (itens[0] == "NOTA FISCAL")
        //    {
        //        if (itens[1] != "1")
        //            throw new Exception("Existem mais de uma nota no arquivo. Versão não suporta esse tipo de arquivo."); //todo
        //        nVol = -1;
        //        nReboque = 0;
        //        nLacres = 0;
        //        nDup = 0;
        //        nObs = 0;
        //        nProc = 0;
        //        oNotaFiscalXML = new TNFe();
        //    }
        //    else if (itens[0] == "A")
        //    {
        //        oNotaFiscalXML.infNFe = new TNFeInfNFe();
        //        oNotaFiscalXML.infNFe.versao = itens[1];
        //        oNotaFiscalXML.infNFe.Id = itens[2]; //TODO : adicionar a chave da nota
        //    }
        //    else if (itens[0] == "B")
        //    {
        //        oNotaFiscalXML.infNFe.ide = new TNFeInfNFeIde();
        //        oNotaFiscalXML.infNFe.ide.cUF = (TCodUfIBGE)DefineEnum(itens[1], typeof(TCodUfIBGE));
        //        UF = itens[1];
        //        Random oRandom = new Random(8);


        //        oNotaFiscalXML.infNFe.ide.cNF = itens[13] + "12345678";//oRandom.Next().ToString();  //nao informado//itens[2];

        //        oNotaFiscalXML.infNFe.ide.natOp = itens[3];
        //        oNotaFiscalXML.infNFe.ide.indPag = (TNFeInfNFeIdeIndPag)DefineEnum(itens[4], typeof(TNFeInfNFeIdeIndPag));
        //        oNotaFiscalXML.infNFe.ide.mod = (TMod)DefineEnum(itens[5], typeof(TMod));
        //        oNotaFiscalXML.infNFe.ide.serie = itens[6];
        //        oNotaFiscalXML.infNFe.ide.nNF = itens[7];
        //        oNotaFiscalXML.infNFe.ide.dhEmi = itens[8];//AAAA-MM-DD
        //        if (!String.IsNullOrEmpty(itens[9]))
        //        {
        //            oNotaFiscalXML.infNFe.ide.dhSaiEnt = itens[9];
        //        }
        //        oNotaFiscalXML.infNFe.ide.tpNF = (TNFeInfNFeIdeTpNF)DefineEnum(itens[10], typeof(TNFeInfNFeIdeTpNF));
        //        oNotaFiscalXML.infNFe.ide.cMunFG = itens[11];
        //        oNotaFiscalXML.infNFe.ide.tpImp = (TNFeInfNFeIdeTpImp)DefineEnum(itens[12], typeof(TNFeInfNFeIdeTpImp));
        //        oNotaFiscalXML.infNFe.ide.tpEmis = (TNFeInfNFeIdeTpEmis)DefineEnum(itens[13], typeof(TNFeInfNFeIdeTpEmis));
        //        oNotaFiscalXML.infNFe.ide.cDV = itens[14];
        //        oNotaFiscalXML.infNFe.ide.tpAmb = (TAmb)DefineEnum(itens[15], typeof(TAmb));
        //        oNotaFiscalXML.infNFe.ide.finNFe = (TFinNFe)DefineEnum(itens[16], typeof(TFinNFe));
        //        oNotaFiscalXML.infNFe.ide.procEmi = (TProcEmi)DefineEnum(itens[17], typeof(TProcEmi));
        //        oNotaFiscalXML.infNFe.ide.verProc = (String.IsNullOrEmpty(itens[18]) ?
        //                                            Assembly.GetExecutingAssembly().GetName().Version.ToString() : itens[18]);

        //    }
        //    else if (itens[0] == "B13")
        //    {
        //        //ocorrencia 0 - n
        //        Int32 posicao = 0;
        //        if (oNotaFiscalXML.infNFe.ide.NFref != null) //ja existe item
        //        {
        //            posicao = oNotaFiscalXML.infNFe.ide.NFref.Length;
        //            TNFeInfNFeIdeNFref[] temp = new TNFeInfNFeIdeNFref[posicao];//cria vetor do mesmo tamanho
        //            for (Int32 i = 0; i < posicao; i++)
        //            {
        //                temp[i] = oNotaFiscalXML.infNFe.ide.NFref[i];
        //            }
        //            oNotaFiscalXML.infNFe.ide.NFref = new TNFeInfNFeIdeNFref[posicao + 1];

        //            for (Int32 i = 0; i < posicao; i++)
        //            {
        //                oNotaFiscalXML.infNFe.ide.NFref[i] = temp[i];
        //            }
        //        }
        //        else
        //        {
        //            oNotaFiscalXML.infNFe.ide.NFref = new TNFeInfNFeIdeNFref[1];
        //        }

        //        oNotaFiscalXML.infNFe.ide.NFref[posicao] = new TNFeInfNFeIdeNFref();
        //        oNotaFiscalXML.infNFe.ide.NFref[posicao].Item = itens[1];

        //    }
        //    else if (itens[0] == "B14")
        //    {
        //        Int32 posicao = 0;
        //        if (oNotaFiscalXML.infNFe.ide.NFref != null) //ja existe item
        //        {
        //            posicao = oNotaFiscalXML.infNFe.ide.NFref.Length;
        //            TNFeInfNFeIdeNFref[] temp = new TNFeInfNFeIdeNFref[posicao];//cria vetor do mesmo tamanho
        //            for (Int32 i = 0; i < posicao; i++)
        //            {
        //                temp[i] = oNotaFiscalXML.infNFe.ide.NFref[i];//aloca as informacoes temporariamente
        //            }
        //            oNotaFiscalXML.infNFe.ide.NFref = new TNFeInfNFeIdeNFref[posicao + 1];//cria vetor com tamanho + 1

        //            for (Int32 i = 0; i < posicao; i++)
        //            {
        //                oNotaFiscalXML.infNFe.ide.NFref[i] = temp[i];//retorna com as informacoes temporarias
        //            }
        //        }
        //        else
        //        {
        //            oNotaFiscalXML.infNFe.ide.NFref = new TNFeInfNFeIdeNFref[1];
        //        }

        //        RDI.NFe2.SchemaXML200.TNFeInfNFeIdeNFrefRefNF refNF = new RDI.NFe2.SchemaXML200.TNFeInfNFeIdeNFrefRefNF();

        //        refNF.cUF = (TCodUfIBGE)DefineEnum(itens[1], typeof(TCodUfIBGE));
        //        refNF.AAMM = itens[2];
        //        refNF.CNPJ = itens[3];
        //        //refNF.mod = itens[4];
        //        refNF.serie = itens[5];
        //        refNF.nNF = itens[6];
        //        oNotaFiscalXML.infNFe.ide.NFref[posicao] = new TNFeInfNFeIdeNFref();
        //        oNotaFiscalXML.infNFe.ide.NFref[posicao].Item = refNF;
        //    }
        //    else if (itens[0] == "C")
        //    {
        //        oNotaFiscalXML.infNFe.emit = new TNFeInfNFeEmit();
        //        oNotaFiscalXML.infNFe.emit.xNome = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.emit.xFant = itens[2];

        //        oNotaFiscalXML.infNFe.emit.IE = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.emit.IEST = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.emit.IM = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            oNotaFiscalXML.infNFe.emit.CNAE = itens[6];
        //    }
        //    else if (itens[0] == "C02")
        //    {
        //        oNotaFiscalXML.infNFe.emit.Item = itens[1];
        //        oNotaFiscalXML.infNFe.emit.ItemElementName = ITCTypeCNPJCPF.CNPJ;
        //    }
        //    else if (itens[0] == "C02a")
        //    {
        //        oNotaFiscalXML.infNFe.emit.Item = itens[1];
        //        oNotaFiscalXML.infNFe.emit.ItemElementName = ITCTypeCNPJCPF.CPF;
        //    }
        //    else if (itens[0] == "C05")
        //    {
        //        oNotaFiscalXML.infNFe.emit.enderEmit = new TEnderEmi();
        //        oNotaFiscalXML.infNFe.emit.enderEmit.xLgr = itens[1];
        //        oNotaFiscalXML.infNFe.emit.enderEmit.nro = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.xCpl = itens[3];
        //        oNotaFiscalXML.infNFe.emit.enderEmit.xBairro = itens[4];
        //        oNotaFiscalXML.infNFe.emit.enderEmit.cMun = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.xMun = itens[6];
        //        oNotaFiscalXML.infNFe.emit.enderEmit.UF = itens[7].GetEnumFromXmlEnumAttributeValue<TUfEmi>();
        //        if (!String.IsNullOrEmpty(itens[8]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.CEP = itens[8];
        //        if (!String.IsNullOrEmpty(itens[9]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.cPais = itens[9].GetEnumFromXmlEnumAttributeValue<TEnderEmiCPais>();
        //        if (!String.IsNullOrEmpty(itens[10]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.xPais = itens[10].GetEnumFromXmlEnumAttributeValue<TEnderEmiXPais>();
        //        if (!String.IsNullOrEmpty(itens[11]))
        //            oNotaFiscalXML.infNFe.emit.enderEmit.fone = itens[11];
        //    }
        //    else if (itens[0] == "D")
        //    {
        //        //ocorrencia : 0-1
        //        //GRUPO EXCLUSIVO DO FISCO , NÃO UTILIZAR.
        //    }
        //    else if (itens[0] == "E")
        //    {
        //        oNotaFiscalXML.infNFe.dest = new TNFeInfNFeDest();
        //        oNotaFiscalXML.infNFe.dest.xNome = itens[1];
        //        oNotaFiscalXML.infNFe.dest.IE = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.dest.ISUF = itens[3];
        //    }
        //    else if (itens[0] == "E02")
        //    {
        //        oNotaFiscalXML.infNFe.dest.Item = itens[1];
        //        oNotaFiscalXML.infNFe.dest.ItemElementName = ItemChoiceType3.CNPJ;
        //    }
        //    else if (itens[0] == "E03")
        //    {
        //        oNotaFiscalXML.infNFe.dest.Item = itens[1];
        //        oNotaFiscalXML.infNFe.dest.ItemElementName = ItemChoiceType3.CPF;
        //    }
        //    else if (itens[0] == "E05")
        //    {
        //        oNotaFiscalXML.infNFe.dest.enderDest = new TEndereco();
        //        oNotaFiscalXML.infNFe.dest.enderDest.xLgr = itens[1];
        //        oNotaFiscalXML.infNFe.dest.enderDest.nro = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.xCpl = itens[3];
        //        oNotaFiscalXML.infNFe.dest.enderDest.xBairro = itens[4];
        //        oNotaFiscalXML.infNFe.dest.enderDest.cMun = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.xMun = itens[6];
        //        oNotaFiscalXML.infNFe.dest.enderDest.UF = DefineUF(itens[7]);
        //        if (!String.IsNullOrEmpty(itens[8]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.CEP = itens[8];
        //        if (!String.IsNullOrEmpty(itens[9]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.cPais = itens[9].GetEnumFromXmlEnumAttributeValue<Tpais>();
        //        if (!String.IsNullOrEmpty(itens[10]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.xPais = itens[10];
        //        if (!String.IsNullOrEmpty(itens[11]))
        //            oNotaFiscalXML.infNFe.dest.enderDest.fone = itens[11];
        //    }
        //    else if (itens[0] == "F")
        //    {
        //        //ocorrencia 0 - 1
        //        oNotaFiscalXML.infNFe.retirada = new TLocal();
        //        oNotaFiscalXML.infNFe.retirada.Item = itens[1];
        //        oNotaFiscalXML.infNFe.retirada.ItemElementName = ITCTypeCNPJCPF.CNPJ;
        //        oNotaFiscalXML.infNFe.retirada.xLgr = itens[2];
        //        oNotaFiscalXML.infNFe.retirada.nro = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.retirada.xCpl = itens[4];
        //        oNotaFiscalXML.infNFe.retirada.xBairro = itens[5];
        //        oNotaFiscalXML.infNFe.retirada.cMun = itens[6];
        //        oNotaFiscalXML.infNFe.retirada.xMun = itens[7];
        //        oNotaFiscalXML.infNFe.retirada.UF = DefineUF(itens[8]);
        //    }
        //    else if (itens[0] == "G")
        //    {
        //        //ocorrencia 0 - 1
        //        oNotaFiscalXML.infNFe.entrega = new TLocal();
        //        oNotaFiscalXML.infNFe.entrega.Item = itens[1];
        //        oNotaFiscalXML.infNFe.entrega.ItemElementName = ITCTypeCNPJCPF.CNPJ;
        //        oNotaFiscalXML.infNFe.entrega.xLgr = itens[2];
        //        oNotaFiscalXML.infNFe.entrega.nro = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.entrega.xCpl = itens[4];
        //        oNotaFiscalXML.infNFe.entrega.xBairro = itens[5];
        //        oNotaFiscalXML.infNFe.entrega.cMun = itens[6];
        //        oNotaFiscalXML.infNFe.entrega.xMun = itens[7];
        //        oNotaFiscalXML.infNFe.entrega.UF = DefineUF(itens[8]);
        //    }
        //    else if (itens[0] == "H") //ocorrencia 1 - 990
        //    {
        //        numeroItem = Convert.ToInt32(itens[1]) - 1;
        //        if (oNotaFiscalXML.infNFe.det == null)
        //            oNotaFiscalXML.infNFe.det = new TNFeInfNFeDet[990]; //todo : melhorar implementacao

        //        oNotaFiscalXML.infNFe.det[numeroItem] = new TNFeInfNFeDet();
        //        oNotaFiscalXML.infNFe.det[numeroItem].nItem = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].infAdProd = itens[2];
        //        numeroItemDI = 0;
        //        numeroItemDIAdicoes = 0;
        //    }
        //    else if (itens[0] == "I")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod = new TNFeInfNFeDetProd();
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.cProd = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.cEAN = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.xProd = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.NCM = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.EXTIPI = itens[5];
        //        //if (!String.IsNullOrEmpty(itens[6]))
        //        //    oNotaFiscalXML.infNFe.det[numeroItem].prod.genero = itens[6];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.CFOP = itens[7];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.uCom = itens[8];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.qCom = itens[9];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.vUnCom = itens[10];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.vProd = itens[11];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.cEANTrib = itens[12];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.uTrib = itens[13];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.qTrib = itens[14];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.vUnTrib = itens[15];
        //        if (!String.IsNullOrEmpty(itens[16]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.vFrete = itens[16];
        //        if (!String.IsNullOrEmpty(itens[17]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.vSeg = itens[17];
        //        if (!String.IsNullOrEmpty(itens[18]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.vDesc = itens[18];
        //    }
        //    else if (itens[0] == "I18")//ocorrencia 0 - n
        //    {
        //        //todo : como definir o tamanho vetor se podem exister n possicoes . 
        //        if (oNotaFiscalXML.infNFe.det[numeroItem].prod.DI == null)
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.DI = new TNFeInfNFeDetProdDI[9999];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI] = new TNFeInfNFeDetProdDI();
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].nDI = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].dDI = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].xLocDesemb = itens[3];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].UFDesemb = itens[4].GetEnumFromXmlEnumAttributeValue<TUfEmi>();
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].dDesemb = itens[5];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].cExportador = itens[6];
        //        numeroItemDI++; //para proximo item
        //    }
        //    else if (itens[0] == "I25")
        //    {
        //        //ocorrencia 1 - n

        //        if (oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi == null)
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi = new TNFeInfNFeDetProdDIAdi[9999];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi[numeroItemDIAdicoes].nAdicao = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi[numeroItemDIAdicoes].nSeqAdic = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi[numeroItemDIAdicoes].cFabricante = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].prod.DI[numeroItemDI].adi[numeroItemDIAdicoes].vDescDI = itens[4];
        //        numeroItemDIAdicoes++;
        //    }
        //    //Se for alguns dos itens abaixo adicionar em Items
        //    else if (itens[0] == "J")
        //    {
        //        //ocorrencia 0 - 1
        //        TNFeInfNFeDetProdVeicProd veicProd = new TNFeInfNFeDetProdVeicProd();
        //        veicProd.tpOp = (TNFeInfNFeDetProdVeicProdTpOp)DefineEnum(itens[1], typeof(TNFeInfNFeDetProdVeicProdTpOp));
        //        veicProd.chassi = itens[2];
        //        veicProd.cCor = itens[3];
        //        veicProd.xCor = itens[4];
        //        veicProd.pot = itens[5];
        //        veicProd.cilin = itens[6];
        //        veicProd.pesoL = itens[7];
        //        veicProd.pesoB = itens[8];
        //        veicProd.nSerie = itens[9];
        //        veicProd.tpComb = itens[10];
        //        veicProd.nMotor = itens[11];
        //        veicProd.pot = itens[12];
        //        veicProd.dist = itens[13];
        //        //if (!String.IsNullOrEmpty(itens[14]))
        //        //    veicProd.VIN = itens[14];
        //        veicProd.anoMod = itens[15];
        //        veicProd.anoFab = itens[16];
        //        veicProd.tpPint = itens[17];
        //        veicProd.tpVeic = itens[18];
        //        veicProd.espVeic = itens[19];
        //        veicProd.VIN = itens[20].GetEnumFromXmlEnumAttributeValue<TNFeInfNFeDetProdVeicProdVIN>();
        //        veicProd.condVeic = (TNFeInfNFeDetProdVeicProdCondVeic)DefineEnum(itens[21], typeof(TNFeInfNFeDetProdVeicProdCondVeic));
        //        veicProd.cMod = itens[22];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.Items.SetValue(veicProd, 0); //ou
        //    }
        //    else if (itens[0] == "K")
        //    {
        //        TNFeInfNFeDetProdMed med = new TNFeInfNFeDetProdMed();
        //        med.nLote = itens[1];
        //        med.qLote = itens[2];
        //        med.dFab = itens[3];
        //        med.dVal = itens[4];
        //        med.vPMC = itens[5];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.Items.SetValue(med, 0);      //ou
        //    }
        //    else if (itens[0] == "L")
        //    {

        //        TNFeInfNFeDetProdArma arma = new TNFeInfNFeDetProdArma();
        //        arma.tpArma = TNFeInfNFeDetProdArmaTpArma.Item0;//todo
        //        arma.nSerie = itens[2];
        //        arma.nCano = itens[3];
        //        arma.descr = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].prod.Items.SetValue(arma, 0);     //ou
        //    }
        //    else if (itens[0] == "L01")
        //    {
        //        comb = new TNFeInfNFeDetProdComb();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            comb.cProdANP = itens[1].GetEnumFromXmlEnumAttributeValue<TcProdANP>();
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            comb.CODIF = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            comb.qTemp = itens[3];
        //    }
        //    else if (itens[0] == "L105")
        //    {
        //        comb.CIDE = new TNFeInfNFeDetProdCombCIDE();
        //        comb.CIDE.qBCProd = itens[1];
        //        comb.CIDE.vAliqProd = itens[2];
        //        comb.CIDE.vCIDE = itens[3];
        //    }
        //    else if (itens[0] == "L109")
        //    {
        //        comb.ICMSComb = new TNFeInfNFeDetProdCombICMSComb();
        //        comb.ICMSComb.vBCICMS = itens[1];
        //        comb.ICMSComb.vICMS = itens[2];
        //        comb.ICMSComb.vBCICMSST = itens[3];
        //        comb.ICMSComb.vICMSST = itens[4];
        //    }
        //    else if (itens[0] == "L114")
        //    {
        //        comb.ICMSInter = new TNFeInfNFeDetProdCombICMSInter();
        //        comb.ICMSInter.vBCICMSSTDest = itens[1];
        //        comb.ICMSInter.vICMSSTDest = itens[2];
        //    }
        //    else if (itens[0] == "L117")
        //    {
        //        //comb.ICMSCons.vBCICMSSTCons = itens[1];
        //        //comb.ICMSCons.vICMSSTCons = itens[2];
        //        //comb.ICMSCons.UFCons = DefineUF(itens[3]);
        //    }
        //    //else if ((comb != null) && itens[0] == "M") //TODO : 
        //    //{
        //    //     oNotaFiscalXML.infNFe.det[numeroItem].prod.Items.SetValue(comb, 0);     //ou
        //    //}

        //    else if (itens[0] == "M")
        //    {
        //        //Grupo de Tributos incidentes no Produto ou no Serviço
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto = new TNFeInfNFeDetImposto();
        //    }
        //    else if (itens[0] == "N")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS = new TNFeInfNFeDetImpostoICMS();
        //    }
        //    else if (itens[0] == "N02")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS00 ICMS00 = new TNFeInfNFeDetImpostoICMSICMS00();
        //        ICMS00.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS00.CST = (TNFeInfNFeDetImpostoICMSICMS00CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS00CST));
        //        ICMS00.modBC = (TNFeInfNFeDetImpostoICMSICMS00ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS00ModBC));
        //        ICMS00.vBC = itens[4];
        //        ICMS00.pICMS = itens[5];
        //        ICMS00.vICMS = itens[6];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS00;
        //    }
        //    else if (itens[0] == "N03")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS10 ICMS10 = new TNFeInfNFeDetImpostoICMSICMS10();
        //        ICMS10.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS10.CST = (TNFeInfNFeDetImpostoICMSICMS10CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS10CST));
        //        ICMS10.modBC = (TNFeInfNFeDetImpostoICMSICMS10ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS10ModBC));
        //        ICMS10.vBC = itens[4];
        //        ICMS10.pICMS = itens[5];
        //        ICMS10.vICMS = itens[6];
        //        ICMS10.modBCST = (TNFeInfNFeDetImpostoICMSICMS10ModBCST)DefineEnum(itens[7], typeof(TNFeInfNFeDetImpostoICMSICMS10ModBCST));
        //        if (!String.IsNullOrEmpty(itens[8]))
        //            ICMS10.pMVAST = itens[8];
        //        if (!String.IsNullOrEmpty(itens[9]))
        //            ICMS10.pRedBCST = itens[9];
        //        ICMS10.vBCST = itens[10];
        //        ICMS10.pICMSST = itens[11];
        //        ICMS10.vICMSST = itens[12];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS10;
        //    }
        //    else if (itens[0] == "N04")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS20 ICMS20 = new TNFeInfNFeDetImpostoICMSICMS20();
        //        ICMS20.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS20.CST = (TNFeInfNFeDetImpostoICMSICMS20CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS20CST));
        //        ICMS20.modBC = (TNFeInfNFeDetImpostoICMSICMS20ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS20ModBC));
        //        ICMS20.pRedBC = itens[4];
        //        ICMS20.vBC = itens[5];
        //        ICMS20.pICMS = itens[6];
        //        ICMS20.vICMS = itens[7];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS20;
        //    }
        //    else if (itens[0] == "N05")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS30 ICMS30 = new TNFeInfNFeDetImpostoICMSICMS30();
        //        ICMS30.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS30.CST = (TNFeInfNFeDetImpostoICMSICMS30CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS30CST));
        //        ICMS30.modBCST = (TNFeInfNFeDetImpostoICMSICMS30ModBCST)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS30ModBCST));
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            ICMS30.pMVAST = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            ICMS30.pRedBCST = itens[5];
        //        ICMS30.vBCST = itens[6];
        //        ICMS30.pICMSST = itens[7];
        //        ICMS30.vICMSST = itens[8];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS30;
        //    }
        //    else if (itens[0] == "N06")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS40 ICMS40 = new TNFeInfNFeDetImpostoICMSICMS40();
        //        ICMS40.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS40.CST = (TNFeInfNFeDetImpostoICMSICMS40CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS40CST));
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS40;//ou
        //    }
        //    else if (itens[0] == "N07")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS51 ICMS51 = new TNFeInfNFeDetImpostoICMSICMS51();
        //        ICMS51.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS51.CST = (TNFeInfNFeDetImpostoICMSICMS51CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS51CST));
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            ICMS51.modBC = (TNFeInfNFeDetImpostoICMSICMS51ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS51ModBC));
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            ICMS51.pRedBC = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            ICMS51.vBC = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            ICMS51.pICMS = itens[6];
        //        if (!String.IsNullOrEmpty(itens[7]))
        //            ICMS51.vICMS = itens[7];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS51;
        //    }
        //    else if (itens[0] == "N08")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS60 ICMS60 = new TNFeInfNFeDetImpostoICMSICMS60();
        //        ICMS60.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS60.CST = (TNFeInfNFeDetImpostoICMSICMS60CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS60CST));
        //        ICMS60.vBCST = itens[3];
        //        ICMS60.vICMSST = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS60;
        //    }
        //    else if (itens[0] == "N09")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS70 ICMS70 = new TNFeInfNFeDetImpostoICMSICMS70();
        //        ICMS70.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS70.CST = (TNFeInfNFeDetImpostoICMSICMS70CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS70CST));
        //        ICMS70.modBC = (TNFeInfNFeDetImpostoICMSICMS70ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS70ModBC));
        //        ICMS70.pRedBC = itens[4];
        //        ICMS70.vBC = itens[5];
        //        ICMS70.pICMS = itens[6];
        //        ICMS70.vICMS = itens[7];
        //        ICMS70.modBCST = (TNFeInfNFeDetImpostoICMSICMS70ModBCST)DefineEnum(itens[8], typeof(TNFeInfNFeDetImpostoICMSICMS70ModBCST));
        //        if (!String.IsNullOrEmpty(itens[9]))
        //            ICMS70.pMVAST = itens[9];
        //        if (!String.IsNullOrEmpty(itens[10]))
        //            ICMS70.pRedBCST = itens[10];
        //        ICMS70.vBCST = itens[11];
        //        ICMS70.pICMSST = itens[12];
        //        ICMS70.vICMSST = itens[13];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS70;
        //    }
        //    else if (itens[0] == "N10")
        //    {
        //        TNFeInfNFeDetImpostoICMSICMS90 ICMS90 = new TNFeInfNFeDetImpostoICMSICMS90();
        //        ICMS90.orig = (Torig)DefineEnum(itens[1], typeof(Torig));
        //        ICMS90.CST = (TNFeInfNFeDetImpostoICMSICMS90CST)DefineEnum(itens[2], typeof(TNFeInfNFeDetImpostoICMSICMS90CST));
        //        ICMS90.modBC = (TNFeInfNFeDetImpostoICMSICMS90ModBC)DefineEnum(itens[3], typeof(TNFeInfNFeDetImpostoICMSICMS90ModBC));
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            ICMS90.pRedBC = itens[4];
        //        ICMS90.vBC = itens[5];
        //        ICMS90.pICMS = itens[6];
        //        ICMS90.vICMS = itens[7];
        //        ICMS90.modBCST = (TNFeInfNFeDetImpostoICMSICMS90ModBCST)DefineEnum(itens[8], typeof(TNFeInfNFeDetImpostoICMSICMS90ModBCST));
        //        if (!String.IsNullOrEmpty(itens[9]))
        //            ICMS90.pMVAST = itens[9];
        //        if (!String.IsNullOrEmpty(itens[10]))
        //            ICMS90.pRedBCST = itens[10];
        //        ICMS90.vBCST = itens[11];
        //        ICMS90.pICMSST = itens[12];
        //        ICMS90.vICMSST = itens[13];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ICMS.Item = ICMS90;
        //    }
        //    else if (itens[0] == "O") //ocorrencia 0 - 1 
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI = new TNFeInfNFeDetImpostoIPI();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.clEnq = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.CNPJProd = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.cSelo = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.qSelo = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.cEnq = itens[5];
        //    }
        //    else if (itens[0] == "O07")//se TAG de grupo do CST 00, 49, 50 e 99
        //    {
        //        IPITrib = new TNFeInfNFeDetImpostoIPIIPITrib();
        //        IPITrib.CST = (TNFeInfNFeDetImpostoIPIIPITribCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoIPIIPITribCST));
        //        IPITrib.vIPI = itens[2];
        //        IPITrib.ItemsElementName = new ItemsChoiceType[2];
        //        IPITrib.Items = new string[2];
        //    }
        //    else if (itens[0] == "O10")
        //    {
        //        IPITrib.ItemsElementName[0] = ItemsChoiceType.vBC;
        //        IPITrib.ItemsElementName[1] = ItemsChoiceType.pIPI;
        //        IPITrib.Items[0] = itens[1];
        //        IPITrib.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.Item = IPITrib;
        //    }
        //    else if (itens[0] == "O11")
        //    {
        //        IPITrib.ItemsElementName[0] = ItemsChoiceType.vUnid;
        //        IPITrib.ItemsElementName[1] = ItemsChoiceType.qUnid;
        //        IPITrib.Items[0] = itens[1];
        //        IPITrib.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.Item = IPITrib;
        //    }
        //    else if (itens[0] == "O08")//se TAG de grupo do CST 01, 02, 03, 04, 51, 52, 53, 54 e 55
        //    {
        //        TNFeInfNFeDetImpostoIPIIPINT IPIINT = new TNFeInfNFeDetImpostoIPIIPINT();
        //        IPIINT.CST = (TNFeInfNFeDetImpostoIPIIPINTCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoIPIIPINTCST));
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.IPI.Item = IPIINT;
        //    }
        //    else if (itens[0] == "P")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.II = new TNFeInfNFeDetImpostoII();
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.II.vBC = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.II.vDespAdu = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.II.vII = itens[3];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.II.vIOF = itens[4];
        //    }
        //    else if (itens[0] == "Q")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS = new TNFeInfNFeDetImpostoPIS();
        //    }
        //    else if (itens[0] == "Q02") //Se CST = 01 ou 02
        //    {
        //        TNFeInfNFeDetImpostoPISPISAliq PISAliq = new TNFeInfNFeDetImpostoPISPISAliq();
        //        PISAliq.CST = (TNFeInfNFeDetImpostoPISPISAliqCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoPISPISAliqCST));
        //        PISAliq.vBC = itens[2];
        //        PISAliq.pPIS = itens[3];
        //        PISAliq.vPIS = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS.Item = PISAliq;
        //    }
        //    else if (itens[0] == "Q03")//Se CST = 03
        //    {
        //        TNFeInfNFeDetImpostoPISPISQtde PISQtde = new TNFeInfNFeDetImpostoPISPISQtde();
        //        PISQtde.CST = (TNFeInfNFeDetImpostoPISPISQtdeCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoPISPISQtdeCST));
        //        PISQtde.qBCProd = itens[2];
        //        PISQtde.vAliqProd = itens[3];
        //        PISQtde.vPIS = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS.Item = PISQtde;
        //    }
        //    else if (itens[0] == "Q04")//Se CST = 04, 06, 07, 08 ou 09
        //    {
        //        TNFeInfNFeDetImpostoPISPISNT PISNT = new TNFeInfNFeDetImpostoPISPISNT();
        //        PISNT.CST = (TNFeInfNFeDetImpostoPISPISNTCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoPISPISNTCST));
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS.Item = PISNT;
        //    }
        //    else if (itens[0] == "Q05")//Se CST = 99
        //    {
        //        PISOutr = new TNFeInfNFeDetImpostoPISPISOutr();
        //        PISOutr.CST = (TNFeInfNFeDetImpostoPISPISOutrCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoPISPISOutrCST));
        //        PISOutr.vPIS = itens[2];
        //        PISOutr.ItemsElementName = new ItemsChoiceType1[2];
        //        PISOutr.Items = new string[2];
        //    }
        //    else if (itens[0] == "Q07")
        //    {
        //        PISOutr.ItemsElementName[0] = RDI.NFe.Business.nfe.ItemsChoiceType1.vBC;
        //        PISOutr.ItemsElementName[1] = RDI.NFe.Business.nfe.ItemsChoiceType1.pPIS;
        //        PISOutr.Items[0] = itens[1];
        //        PISOutr.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS.Item = PISOutr;
        //    }
        //    else if (itens[0] == "Q10")
        //    {
        //        PISOutr.ItemsElementName[0] = RDI.NFe.Business.nfe.ItemsChoiceType1.qBCProd;
        //        PISOutr.ItemsElementName[1] = RDI.NFe.Business.nfe.ItemsChoiceType1.vAliqProd;
        //        PISOutr.Items[0] = itens[1];
        //        PISOutr.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PIS.Item = PISOutr;
        //    }
        //    else if (itens[0] == "R")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST = new TNFeInfNFeDetImpostoPISST();
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.vPIS = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.ItemsElementName = new ItemsChoiceType2[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.Items = new string[2];
        //    }
        //    else if (itens[0] == "R02")
        //    {

        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.ItemsElementName[0] = ItemsChoiceType2.vBC;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.ItemsElementName[1] = ItemsChoiceType2.pPIS;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.Items[0] = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.Items[1] = itens[2];
        //    }
        //    else if (itens[0] == "R04")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.ItemsElementName[0] = ItemsChoiceType2.qBCProd;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.ItemsElementName[1] = ItemsChoiceType2.vAliqProd;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.Items[0] = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.PISST.Items[1] = itens[2];
        //    }
        //    else if (itens[0] == "S")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS = new TNFeInfNFeDetImpostoCOFINS();
        //    }
        //    else if (itens[0] == "S02")//Se CST = 01 ou 02
        //    {
        //        TNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq = new TNFeInfNFeDetImpostoCOFINSCOFINSAliq();
        //        COFINSAliq.CST = (TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST)DefineEnum(
        //                            itens[1], typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST));
        //        COFINSAliq.vBC = itens[2];
        //        COFINSAliq.pCOFINS = itens[3];
        //        COFINSAliq.vCOFINS = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS.Item = COFINSAliq;
        //    }
        //    else if (itens[0] == "S03")//Se CST = 03
        //    {
        //        TNFeInfNFeDetImpostoCOFINSCOFINSQtde COFINSQtde = new TNFeInfNFeDetImpostoCOFINSCOFINSQtde();
        //        COFINSQtde.CST = (TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST)DefineEnum(
        //                            itens[1], typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST));
        //        COFINSQtde.qBCProd = itens[2];
        //        COFINSQtde.vAliqProd = itens[3];
        //        COFINSQtde.vCOFINS = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS.Item = COFINSQtde;
        //    }
        //    else if (itens[0] == "S04")//Se CST = 04, 06, 07, 08 ou 09
        //    {
        //        TNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT = new TNFeInfNFeDetImpostoCOFINSCOFINSNT();
        //        COFINSNT.CST = (TNFeInfNFeDetImpostoCOFINSCOFINSNTCST)DefineEnum(itens[1], typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNTCST));
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS.Item = COFINSNT;
        //    }
        //    else if (itens[0] == "S05")//Se CST = 99
        //    {
        //        COFINSOutr = new TNFeInfNFeDetImpostoCOFINSCOFINSOutr();
        //        COFINSOutr.CST = (TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST)DefineEnum(
        //                            itens[1], typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST));
        //        COFINSOutr.vCOFINS = itens[2];
        //        COFINSOutr.Items = new string[2];
        //        COFINSOutr.ItemsElementName = new ItemsChoiceType3[2];
        //    }
        //    else if (itens[0] == "S07")
        //    {
        //        COFINSOutr.ItemsElementName[0] = RDI.NFe.Business.nfe.ItemsChoiceType3.vBC;
        //        COFINSOutr.ItemsElementName[1] = RDI.NFe.Business.nfe.ItemsChoiceType3.pCOFINS;
        //        COFINSOutr.Items[0] = itens[1];
        //        COFINSOutr.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS.Item = COFINSOutr;
        //    }
        //    else if (itens[0] == "S09")
        //    {
        //        COFINSOutr.ItemsElementName[0] = RDI.NFe.Business.nfe.ItemsChoiceType3.qBCProd;
        //        COFINSOutr.ItemsElementName[1] = RDI.NFe.Business.nfe.ItemsChoiceType3.vAliqProd;
        //        COFINSOutr.Items[0] = itens[1];
        //        COFINSOutr.Items[1] = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINS.Item = COFINSOutr;
        //    }
        //    else if (itens[0] == "T")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST = new TNFeInfNFeDetImpostoCOFINSST();
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.vCOFINS = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.Items = new string[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.ItemsElementName = new ItemsChoiceType4[2];
        //    }
        //    else if (itens[0] == "T02")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.ItemsElementName[0] = ItemsChoiceType4.vBC;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.ItemsElementName[1] = ItemsChoiceType4.pCOFINS;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.Items[0] = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.Items[1] = itens[2];
        //    }
        //    else if (itens[0] == "T04")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.ItemsElementName[0] = ItemsChoiceType4.qBCProd;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.ItemsElementName[1] = ItemsChoiceType4.vAliqProd;
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.Items[0] = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.COFINSST.Items[1] = itens[2];
        //    }
        //    else if (itens[0] == "U")
        //    {
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN = new TNFeInfNFeDetImpostoISSQN();
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN.vBC = itens[1];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN.vAliq = itens[2];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN.vISSQN = itens[3];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN.cMunFG = itens[4];
        //        oNotaFiscalXML.infNFe.det[numeroItem].imposto.ISSQN.cListServ = (TCListServ)DefineEnum(itens[5], typeof(TCListServ));
        //    }
        //    else if (itens[0] == "W")
        //    {
        //        oNotaFiscalXML.infNFe.total = new TNFeInfNFeTotal();
        //    }
        //    else if (itens[0] == "W02")
        //    {
        //        oNotaFiscalXML.infNFe.total.ICMSTot = new TNFeInfNFeTotalICMSTot();
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vBC = itens[1];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vICMS = itens[2];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vBCST = itens[3];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vST = itens[4];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vProd = itens[5];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vFrete = itens[6];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vSeg = itens[7];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vDesc = itens[8];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vII = itens[9];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vIPI = itens[10];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vPIS = itens[11];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vCOFINS = itens[12];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vOutro = itens[13];
        //        oNotaFiscalXML.infNFe.total.ICMSTot.vNF = itens[14];
        //    }
        //    else if (itens[0] == "W17")
        //    {
        //        oNotaFiscalXML.infNFe.total.ISSQNtot = new TNFeInfNFeTotalISSQNtot();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.total.ISSQNtot.vServ = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.total.ISSQNtot.vBC = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.total.ISSQNtot.vISS = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.total.ISSQNtot.vPIS = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.total.ISSQNtot.vCOFINS = itens[5];
        //    }
        //    else if (itens[0] == "W23")
        //    {
        //        oNotaFiscalXML.infNFe.total.retTrib = new TNFeInfNFeTotalRetTrib();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vRetPIS = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vRetCOFINS = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vRetCSLL = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vBCIRRF = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vIRRF = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vBCRetPrev = itens[6];
        //        if (!String.IsNullOrEmpty(itens[7]))
        //            oNotaFiscalXML.infNFe.total.retTrib.vRetPrev = itens[7];
        //    }
        //    else if (itens[0] == "X")
        //    {
        //        oNotaFiscalXML.infNFe.transp = new TNFeInfNFeTransp();
        //        oNotaFiscalXML.infNFe.transp.modFrete = (TNFeInfNFeTranspModFrete)DefineEnum(itens[1], typeof(TNFeInfNFeTranspModFrete));
        //    }
        //    else if (itens[0] == "X03")
        //    {
        //        oNotaFiscalXML.infNFe.transp.transporta = new TNFeInfNFeTranspTransporta();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.transp.transporta.xNome = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.transp.transporta.IE = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.transp.transporta.xEnder = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //        {
        //            oNotaFiscalXML.infNFe.transp.transporta.UF = DefineUF(itens[4]);
        //            oNotaFiscalXML.infNFe.transp.transporta.UFSpecified = true; // corrigido, pois o campo não esta ficando true.
        //        }
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.transp.transporta.xMun = itens[5];
        //    }
        //    else if (itens[0] == "X04")
        //    {
        //        if (!String.IsNullOrEmpty(itens[1]))
        //        {
        //            oNotaFiscalXML.infNFe.transp.transporta.Item = itens[1];
        //            oNotaFiscalXML.infNFe.transp.transporta.ItemElementName = ItemChoiceType2.CNPJ;
        //        }
        //    }
        //    else if (itens[0] == "X05")
        //    {
        //        if (!String.IsNullOrEmpty(itens[1]))
        //        {
        //            oNotaFiscalXML.infNFe.transp.transporta.Item = itens[1];
        //            oNotaFiscalXML.infNFe.transp.transporta.ItemElementName = ItemChoiceType2.CPF;
        //        }
        //    }
        //    else if (itens[0] == "X11")
        //    {
        //        oNotaFiscalXML.infNFe.transp.retTransp = new TNFeInfNFeTranspRetTransp();
        //        oNotaFiscalXML.infNFe.transp.retTransp.vServ = itens[1];
        //        oNotaFiscalXML.infNFe.transp.retTransp.vBCRet = itens[2];
        //        oNotaFiscalXML.infNFe.transp.retTransp.pICMSRet = itens[3];
        //        oNotaFiscalXML.infNFe.transp.retTransp.vICMSRet = itens[4];
        //        oNotaFiscalXML.infNFe.transp.retTransp.CFOP = itens[5];
        //        oNotaFiscalXML.infNFe.transp.retTransp.cMunFG = itens[6];
        //    }
        //    else if (itens[0] == "X18")
        //    {
        //        oNotaFiscalXML.infNFe.transp.veicTransp = new TVeiculo();
        //        oNotaFiscalXML.infNFe.transp.veicTransp.placa = itens[1];
        //        oNotaFiscalXML.infNFe.transp.veicTransp.UF = DefineUF(itens[2]);
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.transp.veicTransp.RNTC = itens[3];
        //    }
        //    else if (itens[0] == "X22")
        //    {
        //        if (oNotaFiscalXML.infNFe.transp.reboque == null)
        //            oNotaFiscalXML.infNFe.transp.reboque = new TVeiculo[999];//todo : ocorrencia n.
        //        oNotaFiscalXML.infNFe.transp.reboque[nReboque] = new TVeiculo();
        //        oNotaFiscalXML.infNFe.transp.reboque[nReboque].placa = itens[1];
        //        oNotaFiscalXML.infNFe.transp.reboque[nReboque].UF = DefineUF(itens[2]);
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.transp.reboque[nReboque].RNTC = itens[3];
        //        nReboque++;
        //    }
        //    else if (itens[0] == "X26")
        //    {
        //        nVol++;
        //        if (oNotaFiscalXML.infNFe.transp.vol == null)
        //            oNotaFiscalXML.infNFe.transp.vol = new TNFeInfNFeTranspVol[999];//todo: ocorrencia n
        //        oNotaFiscalXML.infNFe.transp.vol[nVol] = new TNFeInfNFeTranspVol();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].qVol = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].esp = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].marca = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].nVol = itens[4];
        //        if (!String.IsNullOrEmpty(itens[5]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].pesoL = itens[5];
        //        if (!String.IsNullOrEmpty(itens[6]))
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].pesoB = itens[6];
        //    }
        //    else if (itens[0] == "X33")
        //    {
        //        if (oNotaFiscalXML.infNFe.transp.vol[nVol].lacres == null)
        //            oNotaFiscalXML.infNFe.transp.vol[nVol].lacres = new TNFeInfNFeTranspVolLacres[999];
        //        oNotaFiscalXML.infNFe.transp.vol[nVol].lacres[nLacres] = new TNFeInfNFeTranspVolLacres();
        //        oNotaFiscalXML.infNFe.transp.vol[nVol].lacres[nLacres].nLacre = itens[1];
        //        nLacres++;
        //    }
        //    else if (itens[0] == "Y")
        //    {
        //        oNotaFiscalXML.infNFe.cobr = new TNFeInfNFeCobr();
        //    }
        //    else if (itens[0] == "Y02")
        //    {
        //        oNotaFiscalXML.infNFe.cobr.fat = new TNFeInfNFeCobrFat();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.cobr.fat.nFat = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.cobr.fat.vOrig = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.cobr.fat.vDesc = itens[3];
        //        if (!String.IsNullOrEmpty(itens[4]))
        //            oNotaFiscalXML.infNFe.cobr.fat.vLiq = itens[4];
        //    }
        //    else if (itens[0] == "Y07")//ocorrencia 0 - n
        //    {
        //        if (oNotaFiscalXML.infNFe.cobr.dup == null)
        //            oNotaFiscalXML.infNFe.cobr.dup = new TNFeInfNFeCobrDup[999];//todo : ocorrencia n
        //        oNotaFiscalXML.infNFe.cobr.dup[nDup] = new TNFeInfNFeCobrDup();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.cobr.dup[nDup].nDup = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //        {
        //            oNotaFiscalXML.infNFe.cobr.dup[nDup].dVenc = Convert.ToDateTime(itens[2]);
        //            oNotaFiscalXML.infNFe.cobr.dup[nDup].dVencSpecified = true;
        //        }
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.cobr.dup[nDup].vDup = itens[3];

        //        nDup++;
        //    }
        //    else if (itens[0] == "Z")
        //    {
        //        oNotaFiscalXML.infNFe.infAdic = new TNFeInfNFeInfAdic();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.infAdic.infAdFisco = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.infAdic.infCpl = itens[2];
        //    }
        //    else if (itens[0] == "Z04")
        //    {
        //        if (oNotaFiscalXML.infNFe.infAdic.obsCont == null)
        //            oNotaFiscalXML.infNFe.infAdic.obsCont = new TNFeInfNFeInfAdicObsCont[999];//todo : ocorrencia
        //        oNotaFiscalXML.infNFe.infAdic.obsCont[nObs] = new TNFeInfNFeInfAdicObsCont();
        //        oNotaFiscalXML.infNFe.infAdic.obsCont[nObs].xCampo = itens[1];
        //        oNotaFiscalXML.infNFe.infAdic.obsCont[nObs].xTexto = itens[2];
        //        nObs++;
        //    }

        //    //TODO: Confirmar se esses campos não são utilizados no TXT
        //    //Int32 nObsFisco = 1;
        //    //oNotaFiscalXML.infNFe.infAdic.obsFisco[nObsFisco].xCampo = "";
        //    //oNotaFiscalXML.infNFe.infAdic.obsFisco[nObsFisco].xTexto = "";
        //    else if (itens[0] == "Z10")
        //    {
        //        if (oNotaFiscalXML.infNFe.infAdic.procRef == null)
        //            oNotaFiscalXML.infNFe.infAdic.procRef = new TNFeInfNFeInfAdicProcRef[999];//todo ocorrencia
        //        oNotaFiscalXML.infNFe.infAdic.procRef[nProc] = new TNFeInfNFeInfAdicProcRef();
        //        oNotaFiscalXML.infNFe.infAdic.procRef[nProc].nProc = itens[1];
        //        oNotaFiscalXML.infNFe.infAdic.procRef[nProc].indProc = (TNFeInfNFeInfAdicProcRefIndProc)DefineEnum(
        //                                                                itens[2], typeof(TNFeInfNFeInfAdicProcRefIndProc));
        //        nProc++;
        //    }
        //    else if (itens[0] == "ZA")
        //    {
        //        oNotaFiscalXML.infNFe.exporta = new TNFeInfNFeExporta();
        //        oNotaFiscalXML.infNFe.exporta.UFEmbarq = DefineUF(itens[1]);
        //        oNotaFiscalXML.infNFe.exporta.xLocEmbarq = itens[2];
        //    }
        //    else if (itens[0] == "ZB")
        //    {
        //        oNotaFiscalXML.infNFe.compra = new TNFeInfNFeCompra();
        //        if (!String.IsNullOrEmpty(itens[1]))
        //            oNotaFiscalXML.infNFe.compra.xNEmp = itens[1];
        //        if (!String.IsNullOrEmpty(itens[2]))
        //            oNotaFiscalXML.infNFe.compra.xPed = itens[2];
        //        if (!String.IsNullOrEmpty(itens[3]))
        //            oNotaFiscalXML.infNFe.compra.xCont = itens[3];
        //    }
        //    else
        //    {
        //        throw new Exception("Elemento não mapeado.");
        //    }
        //}

    }
}
