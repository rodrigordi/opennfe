using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RDI.OpenSigner
{
    public static class Certificado
    {
        public static X509Certificate2 CarregarPorNome(string Nome, Boolean MaquinaLocal)
        {
            if (MaquinaLocal)
                return Carregar(Nome, TBuscaCertificado.Nome_MaquinaLocal);
            else
                return Carregar(Nome, TBuscaCertificado.Nome_ContaUsuario);
        }
        public static X509Certificate2 CarregarPorSerial(string Nome, Boolean MaquinaLocal)
        {
            if (MaquinaLocal)
                return Carregar(Nome, TBuscaCertificado.Serial_MaquinaLocal);
            else
                return Carregar(Nome, TBuscaCertificado.Serial_ContaUsuario);
        }
        public static X509Certificate2 CarregarDisco(string caminho, string senha)
        {
            return Carregar(caminho + "|" + senha, TBuscaCertificado.ArquivoDisco);
        }
        public static X509Certificate2 CarregarMemoria(string raw)
        {
            return Carregar(raw, TBuscaCertificado.Raw);
        }
        public static List<X509Certificate2> ObterCertificadosContaUsuario()
        {
            X509Certificate2Collection collection2 = BaseCollectCertificates(TBuscaCertificado.Nome_ContaUsuario);

            var certificates = new List<X509Certificate2>();
            foreach (var certificate in collection2)
            {
                certificates.Add(certificate);
            }
            return certificates;
        }
        public static List<X509Certificate2> ObterCertificadosMaquinaLocal()
        {
            X509Certificate2Collection collection2 = BaseCollectCertificates(TBuscaCertificado.Nome_MaquinaLocal);

            var certificates = new List<X509Certificate2>();
            foreach (var certificate in collection2)
            {
                certificates.Add(certificate);
            }
            return certificates;
        }
        public static X509Certificate2 Carregar(string valorPesquisa, TBuscaCertificado tipoBusca)
        {
            X509Certificate2 _X509Cert = null;
            try
            {
                if (tipoBusca == TBuscaCertificado.ArquivoDisco)
                {
                    var args = valorPesquisa.Split('|');
                    var caminho = args[0];
                    var senha = args[1];

                    if (string.IsNullOrEmpty(caminho))
                        throw new Exception("Caminho não informado;");

                    if (string.IsNullOrEmpty(senha))
                        throw new Exception("senha não informada;");

                    if (!System.IO.File.Exists(caminho))
                        throw new Exception("Arquivo informado não existe.");

                    _X509Cert = new X509Certificate2(caminho, senha, X509KeyStorageFlags.MachineKeySet);
                }
                else if (tipoBusca == TBuscaCertificado.Raw)
                {
                    var args = valorPesquisa.Split('|');
                    var stRaw = args[0];
                    var pass = args[1];

                    var raw = Convert.FromBase64String(stRaw);

                    _X509Cert = new X509Certificate2(raw, pass, X509KeyStorageFlags.MachineKeySet);

                }
                else if (tipoBusca == TBuscaCertificado.Nome_ContaUsuario || tipoBusca == TBuscaCertificado.Nome_MaquinaLocal ||
                    tipoBusca == TBuscaCertificado.Serial_ContaUsuario || tipoBusca == TBuscaCertificado.Serial_MaquinaLocal)
                {
                    X509Certificate2Collection collection2 = BaseCollectCertificates(tipoBusca);
                    X509Certificate2Collection scollection = null;

                    if (string.IsNullOrEmpty(valorPesquisa))
                    {
                        scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection);
                    }
                    else
                    {
                        X509FindType findType;
                        if (tipoBusca == TBuscaCertificado.Nome_ContaUsuario || tipoBusca == TBuscaCertificado.Nome_MaquinaLocal)
                            findType = X509FindType.FindBySubjectDistinguishedName;
                        else if (tipoBusca == TBuscaCertificado.Serial_ContaUsuario || tipoBusca == TBuscaCertificado.Serial_MaquinaLocal)
                            findType = X509FindType.FindBySerialNumber;
                        else
                            throw new Exception("Tipo de Pesquisa de Certificado não foi implementada.");

                        scollection = (X509Certificate2Collection)collection2.Find(findType, valorPesquisa, false);
                    }

                    if (scollection.Count > 0)
                    {
                        _X509Cert = scollection[0];
                    }
                }
                else
                {
                    throw new Exception("Tipo de pesquisa não definido");
                }

                return _X509Cert;
            }
            catch (System.Exception ex)
            {
                throw new Exception("Falha ao carregar certificado.", ex);
            }
        }
        private static X509Certificate2Collection BaseCollectCertificates(TBuscaCertificado tipoBusca)
        {
            if (tipoBusca != TBuscaCertificado.Nome_ContaUsuario && tipoBusca != TBuscaCertificado.Nome_MaquinaLocal &&
                tipoBusca != TBuscaCertificado.Serial_ContaUsuario && tipoBusca != TBuscaCertificado.Serial_MaquinaLocal)
                throw new ArgumentException("Tipo de Busca inválida. Permitido somente Busca por Nome ou Serial (Conta Usuário ou Maquina Local).");

            var StLocation = StoreLocation.CurrentUser;

            if (tipoBusca == TBuscaCertificado.Nome_MaquinaLocal || tipoBusca == TBuscaCertificado.Serial_MaquinaLocal)
                StLocation = StoreLocation.LocalMachine;

            X509Store store = new X509Store("MY", StLocation);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
            X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
            X509Certificate2Collection collection1 = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            X509Certificate2Collection collection2 = (X509Certificate2Collection)collection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, true);

            store.Close();

            return collection2;
        }
    }
}
