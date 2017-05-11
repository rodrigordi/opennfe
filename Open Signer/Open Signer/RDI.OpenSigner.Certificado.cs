using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RDI.OpenSigner
{
    
    //MDFe
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

    public enum BuscaCertificado
    {
        Nome,
        ArquivoDisco,
        Raw,
    }


    public static class Certificado
    {
        //Classe para buscar o certificado no repositorio do WINDOWS
        public static X509Certificate2 BuscaNome(string Nome, Boolean usaWService, BuscaCertificado tipoBusca = BuscaCertificado.Nome)
        {
            X509Certificate2 _X509Cert = new X509Certificate2();
            var caminho = string.Empty;
            var senha = string.Empty;
            try
            {
                if (tipoBusca == BuscaCertificado.ArquivoDisco)
                {
                    var args = Nome.Split('|');
                    caminho = args[0];
                    senha = args[1];

                    if (string.IsNullOrEmpty(caminho))
                        throw new Exception("Caminho não informado;");

                    if (string.IsNullOrEmpty(senha))
                        throw new Exception("senha não informada;");

                    if (!System.IO.File.Exists(caminho))
                        throw new Exception("Arquivo informado não existe.");

                    _X509Cert = new X509Certificate2(caminho, senha, X509KeyStorageFlags.MachineKeySet);
                }
                else if (tipoBusca == BuscaCertificado.Raw)
                {
                    var args = Nome.Split('|');
                    var stRaw = args[0];
                    var pass = args[1];

                    var raw = Convert.FromBase64String(stRaw);

                    _X509Cert = new X509Certificate2(raw, pass, X509KeyStorageFlags.MachineKeySet);

                }
                else
                {
                    X509Certificate2Collection collection2 = CollectCertificates(usaWService);


                    if (Nome == "")
                    {
                        X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection);
                        if (scollection.Count == 0)
                        {
                            _X509Cert.Reset();
                        }
                        else
                        {
                            _X509Cert = scollection[0];
                        }
                    }
                    else
                    {
                        X509Certificate2Collection scollection = (X509Certificate2Collection)collection2.Find(X509FindType.FindBySubjectDistinguishedName, Nome, false);
                        if (scollection.Count == 0)
                        {
                            _X509Cert.Reset();
                        }
                        else
                        {
                            _X509Cert = scollection[0];
                        }
                    }

                }

                return _X509Cert;
            }
            catch (System.Exception ex)
            {
                throw new Exception("Falha ao carregar certificado. caminho : " + caminho + " senha " + senha + ". ", ex);
                //return _X509Cert;
            }
        }

        //public static X509Certificate2 BuscaNroSerie(string NroSerie)
        //{
        //    X509Certificate2 _X509Cert = new X509Certificate2();
        //    try
        //    {

        //        X509Store store = new X509Store("MY", StoreLocation.LocalMachine);
        //        store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
        //        X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
        //        X509Certificate2Collection collection1 = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTimeUtils.GetNow(), true);
        //        X509Certificate2Collection collection2 = (X509Certificate2Collection)collection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, true);
        //        if (NroSerie == "")
        //        {
        //            X509Certificate2Collection scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificados Digitais", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection);
        //            if (scollection.Count == 0)
        //            {
        //                _X509Cert.Reset();
        //                Console.WriteLine("Nenhum certificado válido foi encontrado com o número de série informado: " + NroSerie, "Atenção");
        //            }
        //            else
        //            {
        //                _X509Cert = scollection[0];
        //            }
        //        }
        //        else
        //        {
        //            X509Certificate2Collection scollection = (X509Certificate2Collection)collection2.Find(X509FindType.FindBySerialNumber, NroSerie, true);
        //            if (scollection.Count == 0)
        //            {
        //                _X509Cert.Reset();
        //                Console.WriteLine("Nenhum certificado válido foi encontrado com o número de série informado: " + NroSerie, "Atenção");
        //            }
        //            else
        //            {
        //                _X509Cert = scollection[0];
        //            }
        //        }
        //        store.Close();
        //        return _X509Cert;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return _X509Cert;
        //    }
        //}

        public static int PopulaItems(IList items, Boolean usaWService)
        {
            int i = 0;
            items.Clear();

            X509Certificate2Collection collection2 = CollectCertificates(usaWService);

            while (i < collection2.Count)
            {
                items.Add(collection2[i].Subject.ToString());
                i++;
            }

            return items.Count;
        }

        public static X509Certificate2Collection CollectCertificates(Boolean usaWService)
        {
            StoreLocation StLocation = StoreLocation.CurrentUser;

            if (usaWService)
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
