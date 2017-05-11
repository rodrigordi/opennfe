using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Web.Script.Serialization;


namespace RDI.NFe2.MMCustom
{
    public static class MMUtils
    {
        public static void ConsultaStatusSefaz(Boolean status)
        {
            try
            {
                //faca algo 

            }
            catch
            {

            }
        }

        public static void ConfirmaRecebimentoNFe(String nomeArquivoOrigem)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
        }

        public static void ProcessaResultadoNFe(String chaveAcesso, int codigoSituacao, String descricaoSituacao, String cStat, String xMotivo, String nProt)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
        }

        public static void ImprimeDanfe(String chaveAcesso, int codigoSituacao, String descricaoSituacao, String cStat, String xMotivo, String nProt, string nomeArquivoProcesso)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
        }

        public static void ConfirmaRecebimentoPedidoInutilizacaoNFe(String chaveAcesso)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
   
        }

        public static void ProcessaResultadoPedidoInutilizacaoNFe(String chaveAcesso, String cStat, String xMotivo, String nProt)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
         
        }

        public static void ErroProcessandoPedidoInutilizacaoNFe(String chaveAcesso, Exception ex)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }
                   
        }

        public static void ConfirmaRecebimentoPedidoCartaCorrecao(String nomeArquivoOrigem)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }

        public static void ProcessaResultadoPedidoCartaCorrecao(String chaveAcesso, String cStat, String xMotivo)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }

        public static void ErroProcessandoPedidoCartaCorrecao(String nomeArquivoOrigem, Exception ex)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }

        public static void ConfirmaRecebimentoPedidoEventoCancelamento(String nomeArquivoOrigem)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }

        public static void ProcessaResultadoPedidoEventoCancelamento(String chaveAcesso, String cStat, String xMotivo, string nProt)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }

        public static void ErroProcessandoPedidoEventoCancelamento(String nomeArquivoOrigem, Exception ex)
        {
            try
            {
                //faca algo 
            }
            catch
            {

            }

        }
               
        //trabalhando com thread parametrizada
        //public static void threadProcessaPendenciaXml()
        //{
        //    ParameterizedThreadStart operacao = new ParameterizedThreadStart(persistDadosXmlPendente);
        //    Thread oThread = new Thread(operacao);
        //    oThread.Start();
        //}

        //public class ParametroThread
        //{
        //    private object[] _args;
        //    public object[] args
        //    {
        //        get { return _args; }
        //        set { _args = value; }
        //    }
        //}     


    }
}
