using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using RDI.NFe2.SchemaXML.NFe_v310;
using System.ComponentModel;
using System.Reflection;

namespace RDI.NFe2.SchemaXML
{

    public class CabecalhoNFe
    {
        //-Serie da NFE
        public string serie { get; set; }
        //-Numero da NFE
        public string numero { get; set; }
        //-Chave da NFE
        public string chave { get; set; }
        //-Data da emissão da NFE
        public string dataEmissao { get; set; }
        //-Data da entrada ou saida da NFE
        public string dataSaidaEntrada { get; set; }
        //-Valor total da NFE
        public string valorTotalNFe { get; set; }
        //-Valor total do desconto
        public string valorTotalDescontos { get; set; }
        //-Valor total das mercadorias e serviços
        public string valorTotalMercadoriasServicos { get; set; }
        //-Indicador do tipo do frete
        public string tipoFrete { get; set; }
        //-Valor do frete indicado no documento fiscal
        public string valorTotalFrete { get; set; }
        //-Valor da base de cálculo do ICMS
        public string valorBaseCalculoICMS { get; set; }
        //-Valor do ICMS
        public string valorTotalICMS { get; set; }
        //-Valor da base de cálculo do ICMS substituição tributária
        public string valorBaseCalculoICMSST { get; set; }
        //-Valor do ICMS retido por substituição tributária
        public string valorTotalICMSRetidoST { get; set; }
        //-Valor total do IPI
        public string valorTotalIPI { get; set; }

        public ITCTypeCNPJCPF tipoDocumentoEmitente { get; set; }

        public string documentoEmitente { get; set; }

        public string nomeEmitente { get; set; }

        public string informacoesAdicionais { get; set; }
    }

    public class ItemNFe
    {
        //-Número sequencial do item no documento fiscal
        public string nSeq { get; set; }
        //-Código do item
        public string codigo { get; set; }
        //-Descrição complementar do item como adotado no documento fiscal
        public string descricaoComplementar { get; set; }
        //-Quantidade do item
        public string quantidade { get; set; }
        //-Unidade do item
        public string unidade { get; set; }
        //-Valor total do item
        public string valorTotal { get; set; }
        //-Valor do desconto comercial
        public string valorDesconto { get; set; }
        //-Código Fiscal de Operação e Prestação
        public string CFOP { get; set; }
        //-Valor da base de cálculo do ICMS
        public string valorBaseCalculoICMS { get; set; }
        //-Alíquota do ICMS
        public string valorAliquotaICMS { get; set; }
        //-Valor do ICMS creditado/debitado
        public string valorICMS { get; set; }
        //-Valor da base de cálculo referente à substituição tributária
        public string valorBaseCalculoICMSST { get; set; }
        //-Alíquota do ICMS da substituição tributária na unidade da federação de destino
        public string valorAliquotaICMSST { get; set; }
        //-Valor do ICMS referente à substituição tributária
        public string valorICMSST { get; set; }
        //-Valor da base de cálculo do IPI
        public string valorBaseCalculoIPI { get; set; }
        //-Alíquota do IPI
        public string valorAliquotaIPI { get; set; }
        //-Valor do IPI creditado/debitado
        public string valorIPI { get; set; }
        //-CST/csosn
        public string CSTCSON { get; set; }
    }

    public class SPEDNFe
    {
        public CabecalhoNFe cabec { get; set; }
        public List<ItemNFe> itens { get; set; }
    }

    public static class SPEDParser
    {
        public static SPEDNFe Parser(string caminhoXMLNFe)
        {
            var sped = new SPEDNFe();
            var oNFeProc = XMLUtils.LoadXMLFile<TNfeProc>(caminhoXMLNFe);
            var oNFe = oNFeProc.NFe;

            if (oNFe.infNFe.versao != "3.10")
                throw new Exception("Versão do arquivo é diferente de 3.10");

            sped.cabec = new CabecalhoNFe();

            sped.cabec.chave = oNFe.infNFe.Id.Replace("NFe", "");
            sped.cabec.dataEmissao = oNFe.infNFe.ide.dhEmi;
            sped.cabec.dataSaidaEntrada = oNFe.infNFe.ide.dhSaiEnt;
            sped.cabec.numero = oNFe.infNFe.ide.nNF;
            sped.cabec.serie = oNFe.infNFe.ide.serie;

            sped.cabec.tipoFrete = oNFe.infNFe.transp.modFrete.GetXmlEnumAttributeValueFromEnum();

            sped.cabec.nomeEmitente = oNFe.infNFe.emit.xNome;
            sped.cabec.documentoEmitente = oNFe.infNFe.emit.Item;
            sped.cabec.tipoDocumentoEmitente = oNFe.infNFe.emit.ItemElementName;

            sped.cabec.valorBaseCalculoICMS = oNFe.infNFe.total.ICMSTot.vBC;
            sped.cabec.valorBaseCalculoICMSST = oNFe.infNFe.total.ICMSTot.vBCST;
            sped.cabec.valorTotalDescontos = oNFe.infNFe.total.ICMSTot.vDesc;
            sped.cabec.valorTotalFrete = oNFe.infNFe.total.ICMSTot.vFrete;
            sped.cabec.valorTotalICMS = oNFe.infNFe.total.ICMSTot.vICMS;
            sped.cabec.valorTotalICMSRetidoST = oNFe.infNFe.total.ICMSTot.vST;
            sped.cabec.valorTotalIPI = oNFe.infNFe.total.ICMSTot.vIPI;

            sped.cabec.valorTotalMercadoriasServicos = oNFe.infNFe.det.Sum(det => decimal.Parse(det.prod.vProd.Replace(".", ","))).ToString("N2").Replace(".", "").Replace(",", ".");
            sped.cabec.valorTotalNFe = oNFe.infNFe.total.ICMSTot.vNF;
            if (oNFe.infNFe.infAdic != null)
                sped.cabec.informacoesAdicionais = oNFe.infNFe.infAdic.infCpl;

            sped.itens = new List<ItemNFe>();
            foreach (var det in oNFe.infNFe.det)
            {
                var item = new ItemNFe();

                item.CFOP = det.prod.CFOP;//.GetXmlEnumAttributeValueFromEnum();
                item.codigo = det.prod.cProd;
                item.descricaoComplementar = det.prod.xProd;
                item.nSeq = det.nItem;
                item.quantidade = det.prod.qCom;
                item.unidade = det.prod.uCom;
                item.valorTotal = det.prod.vProd;
                item.valorDesconto = det.prod.vDesc;

                foreach (var itemImposto in det.imposto.Items)
                {
                    if (itemImposto.GetType() == typeof(TNFeInfNFeDetImpostoICMS))
                    {
                        var TImposto = (TNFeInfNFeDetImpostoICMS)itemImposto;

                        if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS00))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS00)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorICMS = ICMS.vICMS;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS10)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS20))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS20)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorICMS = ICMS.vICMS;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS30))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS30)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS40))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS40)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = ICMS.vICMSDeson;
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS51))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS51)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS60))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS60)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();

                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = "";
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS70))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS70)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMS90))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMS90)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSPart))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSPart)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN101))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN101)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = "";
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN102))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN102)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = "";
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN201))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN201)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = "";
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN202))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN202)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = "";
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN500))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN500)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = "";
                            item.valorICMSST = "";

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSSN900))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSSN900)TImposto.Item;
                            item.CSTCSON = ICMS.CSOSN.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = ICMS.pICMS;
                            item.valorAliquotaICMSST = ICMS.pICMSST;
                            item.valorBaseCalculoICMS = ICMS.vBC;
                            item.valorBaseCalculoICMSST = ICMS.vBCST;
                            item.valorICMS = ICMS.vICMS;
                            item.valorICMSST = ICMS.vICMSST;

                        }
                        else if (TImposto.Item.GetType() == typeof(TNFeInfNFeDetImpostoICMSICMSST))
                        {
                            var ICMS = (TNFeInfNFeDetImpostoICMSICMSST)TImposto.Item;
                            item.CSTCSON = ICMS.CST.GetXmlEnumAttributeValueFromEnum();
                            item.valorAliquotaICMS = "";
                            item.valorAliquotaICMSST = "";
                            item.valorBaseCalculoICMS = "";
                            item.valorBaseCalculoICMSST = "";
                            item.valorICMS = "";
                            item.valorICMSST = "";

                        }
                    }
                    else if (itemImposto.GetType() == typeof(TIpi))
                    {
                        var TImposto = (TIpi)itemImposto;

                        if (TImposto.Item.GetType() == typeof(TIpiIPINT))
                        {
                            var IPI = (TIpiIPINT)TImposto.Item;

                            item.valorAliquotaIPI = "0.00";
                            item.valorBaseCalculoIPI = "0.00";
                            item.valorIPI = "0.00";

                        }
                        else if (TImposto.Item.GetType() == typeof(TIpiIPITrib))
                        {
                            var IPI = (TIpiIPITrib)TImposto.Item;

                            for (int i = 0; i < IPI.ItemsElementName.Length; i++)
                            {
                                var IPIType = IPI.ItemsElementName[i];
                                if (IPIType == ItemsChoiceType.pIPI)
                                {
                                    item.valorAliquotaIPI = IPI.Items[i];
                                }
                                else if (IPIType == ItemsChoiceType.vBC)
                                {
                                    item.valorBaseCalculoIPI = IPI.Items[i];
                                }
                            }

                            item.valorIPI = IPI.vIPI;
                        }
                    }
                }

                sped.itens.Add(item);
            }

            return sped;
        }
    }
}
