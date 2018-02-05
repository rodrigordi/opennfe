using System.Xml.Serialization;

namespace RDI.NFe2.SchemaXML
{
    public interface IDistDFeInt
    {

    }

    public interface IRetDistDFeInt
    {

    }

    public interface ITDownloadNFe
    {

    }

    public interface ITRetDownloadNFe
    {

    }

    public interface ITEventoInfEventoDetEvento
    {

        string descEvento { get; set; }

        TEventoInfEventoDetEventoVersao versao { get; set; }

        string nProt { get; set; }

        string xJust { get; set; }

        string xCorrecao { get; set; }

        bool xCondUsoSpecified { get; set; }

        TEventoInfEventoDetEventoXCondUso xCondUso { get; set; }
    }

    public interface ITRetInutNFeInfInut
    {

        string cStat { get; set; }

        string xMotivo { get; set; }

        string nProt { get; set; }
    }

    public interface ITProcCancNFe
    {

        string versao { get; set; }

        ITCancNFe cancNFe { get; set; }

        ITRetCancNFe retCancNFe { get; set; }
    }

    public interface ITCancNFe
    {

    }

    public interface ITRetCancNFe
    {

    }



    public interface IReferenceType
    {
        byte[] DigestValue { get; }
    }

    public interface ISignedInfoType
    {

        IReferenceType Reference { get; }
    }

    public interface ISignatureType
    {
        ISignedInfoType SignedInfo { get; }
    }

    public interface ITNFe
    {
        ITNFeInfNFe infNFe { get; set; }
        ISignatureType Signature { get; }
    }

    public interface ITNFeInfNFe
    {
        string Id { get; }
        string versao { get; }
        ITNFeInfNFeIde ide { get; }
        ITNFeInfNFeDest dest { get; }
        ITNFeInfNFeEmit emit { get; }
    }

    public interface ITNFeInfNFeIde
    {
        //        string cDV { get; set; }
        //        string cMunFG { get; set; }
        //        string cNF { get; set; }
        ////        RDI.NFe2.SchemaXML200.TCodUfIBGE cUF { get; set; }
        string dEmi { get; }
        //        string dhCont { get; set; }
        //        string dSaiEnt { get; set; }
        //        string hSaiEnt { get; set; }
        ////        RDI.NFe2.SchemaXML200.TMod mod { get; set; }
        //        string natOp { get; set; }
        string nNF { get; }
        ////        RDI.NFe2.SchemaXML200.TProcEmi procEmi { get; set; }
        string serie { get; }
        ////        RDI.NFe2.SchemaXML200.TAmb tpAmb { get; set; }
        ////        RDI.NFe2.SchemaXML200.TNFeInfNFeIdeTpEmis tpEmis { get; set; }
        ////        RDI.NFe2.SchemaXML200.TNFeInfNFeIdeTpImp tpImp { get; set; }
        ////        RDI.NFe2.SchemaXML200.TNFeInfNFeIdeTpNF tpNF { get; set; }
        //        string verProc { get; set; }
        //        string xJust { get; set; }
    }

    public interface ITNFeInfNFeDest
    {
        string email { get; set; }
        ITEndereco enderDest { get; }
        string IE { get; }
        string xNome { get; }
    }

    public interface ITNFeInfNFeEmit
    {
        ITEnderEmi enderEmit { get; }
        string IE { get; }
        string xNome { get; }
    }


    public interface ITEndereco
    {
        string CEP { get; }
        string cMun { get; }
        string fone { get; }
        string nro { get; }
        TUf UF { get; set; }
        string xBairro { get; }
        string xCpl { get; }
        string xLgr { get; }
        string xMun { get; }
    }

    public interface ITEnderEmi
    {
        string CEP { get; }
        string cMun { get; }
        string fone { get; }
        string nro { get; }
        TUfEmi UF { get; set; }
        string xBairro { get; }
        string xCpl { get; }
        string xLgr { get; }
        string xMun { get; }
    }

    public interface ITNfeProc
    {
        string versao { get; set; }
        ITNFe NFe { get; set; }
        ITProtNFe protNFe { get; set; }
    }

    public interface ITProtNFe
    {
        string versao { get; set; }
        ITProtNFeInfProt infProt { get; set; }

    }

    public interface ITProcEvento
    {
        ITEvento evento { get; set; }
        string versao { get; set; }
        ITretEvento retEvento { get; set; }
    }

    public interface ITProtNFeInfProt
    {
        string nProt { get; }
        byte[] digVal { get; }


        string chNFe { get; set; }

        string cStat { get; set; }

        string xMotivo { get; set; }

        TAmb tpAmb { get; set; }
    }


    public interface ITEnviNFe
    {
        string idLote { get; set; }
        string versao { get; set; }

        ITNFe[] NFe { get; set; }
    }
    public interface ITRetEnviNFe
    {

        string cStat { get; }
        string xMotivo { get; }

        TAmb tpAmb { get; set; }

        ITRetEnviNFeInfRec infRec { get; set; }
    }
    public interface ITConsReciNFe
    {
        string nRec { get; set; }
        TAmb tpAmb { get; set; }
        string versao { get; set; }
    }
    public interface ITRetConsReciNFe
    {
        string cStat { get; }
        string xMotivo { get; }
        ITProtNFe[] protNFe { get; }
    }
    public interface ITConsStatServ
    {
        string versao { get; set; }
        TAmb tpAmb { get; set; }
        TCodUfIBGE cUF { get; set; }
    }
    public interface ITRetConsStatServ
    {
        string cStat { get; set; }
        string xMotivo { get; set; }
    }
    public interface ITInutNFe
    {
        ITInutNFeInfInut infInut { get; set; }

        string versao { get; set; }
    }
    public interface ITRetInutNFe
    {
        ITRetInutNFeInfInut infInut { get; }
    }
    public interface ITConsSitNFe
    {
        string chNFe { get; set; }
        TAmb tpAmb { get; set; }
        TVerConsSitNFe versao { get; set; }
    }
    public interface ITRetConsSitNFe
    {
        string cStat { get; }
        string xMotivo { get; }
        ITProtNFe protNFe { get; }
        ITProcEvento[] procEventoNFe { get; }

        ITRetCancNFe_v200107 retCancNFe { get; set; }
    }

    public interface ITEvento
    {
        ITEventoInfEvento infEvento { get; set; }
        ISignatureType Signature { get; }

        string versao { get; set; }
    }


    public interface ITEventoInfEvento
    {
        string tpEvento { get; set; }

        string Id { get; set; }

        string chNFe { get; set; }

        TCOrgaoIBGE cOrgao { get; set; }

        string Item { get; set; }

        ITEventoInfEventoDetEvento detEvento { get; set; }

        string dhEvento { get; set; }

        ITCTypeCNPJCPF ItemElementName { get; set; }

        TAmb tpAmb { get; set; }

        string nSeqEvento { get; set; }

        TEventoInfEventoVerEvento verEvento { get; set; }
    }



    public interface ITInutNFeInfInut
    {
        string Id { get; set; }

        string nNFIni { get; set; }

        string nNFFin { get; set; }

        string serie { get; set; }

        string ano { get; set; }

        string CNPJ { get; set; }

        TCodUfIBGE cUF { get; set; }

        TMod mod { get; set; }

        TAmb tpAmb { get; set; }

        string xJust { get; set; }

        TInutNFeInfInutXServ xServ { get; set; }
    }

    public interface ITretEvento
    {
        ITretEventoInfEvento infEvento { get; set; }
    }

    public interface ITRetCancNFe_v200107
    {
        ITRetCancNFe_v200107InfCanc infCanc { get; }
    }

    public interface ITRetCancNFe_v200107InfCanc
    {
        string nProt { get; set; }
    }

    public interface ITRetEnviNFeInfRec
    {
        string nRec { get; set; }
    }

    public interface ITretEventoInfEvento
    {
        string cStat { get; set; }

        string xMotivo { get; set; }

        string nProt { get; set; }
    }

    public interface ITConsCad
    {

    }

    public interface ITRetConsCad
    {

    }
    public interface ITEnvEvento
    {
        ITEvento[] evento { get; set; }

        string idLote { get; set; }

        string versao { get; set; }
    }
    public interface ITRetEnvEvento
    {
        string cStat { get; set; }

        TAmb tpAmb { get; set; }

        string xMotivo { get; set; }

        ITretEvento[] retEvento { get; set; }
    }
}


//TODO :  mover para arquivos de cada versão
#region Aplicações Interfaces

namespace RDI.NFe2.SchemaXML.DocumentosFiscaisEletronicos_v101
{
    public partial class distDFeInt : RDI.NFe2.SchemaXML.IDistDFeInt
    {

    }

    public partial class retDistDFeInt : RDI.NFe2.SchemaXML.IRetDistDFeInt
    {

    }
}

namespace RDI.NFe2.SchemaXML.ConsultaCadastro
{
    public partial class TConsCad : RDI.NFe2.SchemaXML.ITConsCad
    {

    }

    public partial class TRetConsCad : RDI.NFe2.SchemaXML.ITRetConsCad
    {

    }
}

namespace RDI.NFe2.SchemaXML.Eventos_v100
{

    public partial class TEventoInfEventoDetEvento : RDI.NFe2.SchemaXML.ITEventoInfEventoDetEvento
    {

    }

    public partial class TretEventoInfEvento : RDI.NFe2.SchemaXML.ITretEventoInfEvento
    {

    }

    public partial class TEnvEvento : RDI.NFe2.SchemaXML.ITEnvEvento
    {
        SchemaXML.ITEvento[] SchemaXML.ITEnvEvento.evento
        {
            get
            {
                return this.evento;
            }
            set
            {
                this.evento = (TEvento[])value;
            }
        }
    }
    public partial class TRetEnvEvento : RDI.NFe2.SchemaXML.ITRetEnvEvento
    {
        SchemaXML.ITretEvento[] SchemaXML.ITRetEnvEvento.retEvento
        {
            get
            {
                return this.retEvento;
            }
            set
            {
                this.retEvento = (TretEvento[])value;
            }
        }
    }

    public partial class TEvento : RDI.NFe2.SchemaXML.ITEvento
    {
        SchemaXML.ITEventoInfEvento SchemaXML.ITEvento.infEvento
        {
            get { return this.infEvento; }
            set { this.infEvento = (TEventoInfEvento)value; }
        }

        SchemaXML.ISignatureType SchemaXML.ITEvento.Signature
        {
            get { return this.Signature; }
        }
    }
    public partial class TEventoInfEvento : RDI.NFe2.SchemaXML.ITEventoInfEvento
    {

        SchemaXML.ITEventoInfEventoDetEvento SchemaXML.ITEventoInfEvento.detEvento
        {
            get
            {
                return this.detEvento;
            }
            set
            {
                this.detEvento = (TEventoInfEventoDetEvento)value;
            }
        }
    }
    public partial class TProcEvento : RDI.NFe2.SchemaXML.ITProcEvento
    {

        SchemaXML.ITEvento SchemaXML.ITProcEvento.evento
        {
            get { return this.evento; }
            set { this.evento = (TEvento)value; }
        }

        SchemaXML.ITretEvento SchemaXML.ITProcEvento.retEvento
        {
            get
            {
                return this.retEvento;
            }
            set
            {
                this.retEvento = (TretEvento)value;
            }
        }
    }


    public partial class TEventoInfEventoDetEvento : RDI.NFe2.SchemaXML.ITEventoInfEventoDetEvento
    {

    }

    public partial class TretEventoInfEvento : RDI.NFe2.SchemaXML.ITretEventoInfEvento
    {

    }

    public partial class TretEvento : RDI.NFe2.SchemaXML.ITretEvento
    {

        SchemaXML.ITretEventoInfEvento SchemaXML.ITretEvento.infEvento
        {
            get
            {
                return this.infEvento;
            }

            set
            {
                this.infEvento = (TretEventoInfEvento)value;
            }
        }
    }
}

namespace RDI.NFe2.SchemaXML.Signature
{
    public partial class ReferenceType : RDI.NFe2.SchemaXML.IReferenceType
    {

    }

    public partial class SignedInfoType : RDI.NFe2.SchemaXML.ISignedInfoType
    {
        SchemaXML.IReferenceType SchemaXML.ISignedInfoType.Reference
        {
            get { return this.Reference; }
        }
    }

    public partial class SignatureType : RDI.NFe2.SchemaXML.ISignatureType
    {

        SchemaXML.ISignedInfoType SchemaXML.ISignatureType.SignedInfo
        {
            get
            {
                return this.SignedInfo;
            }

        }
    }
}

namespace RDI.NFe2.SchemaXML.NFe_v200
{
    public partial class TRetEnviNFeInfRec : RDI.NFe2.SchemaXML.ITRetEnviNFeInfRec
    {

    }

    public partial class TRetCancNFe_v200107InfCanc : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107InfCanc
    {

    }

    public partial class TRetCancNFe_v200107 : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107
    {
        SchemaXML.ITRetCancNFe_v200107InfCanc SchemaXML.ITRetCancNFe_v200107.infCanc
        {
            get
            {
                return this.infCanc;
            }

        }
    }

    public partial class TRetCancNFe : RDI.NFe2.SchemaXML.ITRetCancNFe
    {

    }

    public partial class TCancNFe : RDI.NFe2.SchemaXML.ITCancNFe
    {

    }

    public partial class TInutNFeInfInut : RDI.NFe2.SchemaXML.ITInutNFeInfInut
    {

    }

    public partial class TEnviNFe : RDI.NFe2.SchemaXML.ITEnviNFe
    {
        SchemaXML.ITNFe[] SchemaXML.ITEnviNFe.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe[])value;
            }
        }
    }
    public partial class TRetEnviNFe : RDI.NFe2.SchemaXML.ITRetEnviNFe
    {
        SchemaXML.ITRetEnviNFeInfRec SchemaXML.ITRetEnviNFe.infRec
        {
            get
            {
                return this.infRec;
            }
            set
            {
                this.infRec = (TRetEnviNFeInfRec)value;
            }
        }
    }
    public partial class TConsReciNFe : RDI.NFe2.SchemaXML.ITConsReciNFe { }
    public partial class TRetConsReciNFe : RDI.NFe2.SchemaXML.ITRetConsReciNFe
    {
        SchemaXML.ITProtNFe[] SchemaXML.ITRetConsReciNFe.protNFe
        {
            get
            {
                return this.protNFe;
            }
        }
    }
    public partial class TConsStatServ : RDI.NFe2.SchemaXML.ITConsStatServ { }
    public partial class TRetConsStatServ : RDI.NFe2.SchemaXML.ITRetConsStatServ { }
    public partial class TInutNFe : RDI.NFe2.SchemaXML.ITInutNFe
    {
        SchemaXML.ITInutNFeInfInut SchemaXML.ITInutNFe.infInut
        {
            get { return this.infInut; }
            set { this.infInut = (TInutNFeInfInut)value; }
        }
    }
    public partial class TRetInutNFe : RDI.NFe2.SchemaXML.ITRetInutNFe
    {
        SchemaXML.ITRetInutNFeInfInut SchemaXML.ITRetInutNFe.infInut
        {
            get { return this.infInut; }
        }
    }

    public partial class TRetInutNFeInfInut : RDI.NFe2.SchemaXML.ITRetInutNFeInfInut
    {

    }


    public partial class TConsSitNFe : RDI.NFe2.SchemaXML.ITConsSitNFe { }
    public partial class TRetConsSitNFe : RDI.NFe2.SchemaXML.ITRetConsSitNFe
    {
        SchemaXML.ITProtNFe SchemaXML.ITRetConsSitNFe.protNFe
        {
            get { return this.protNFe; }
        }

        SchemaXML.ITProcEvento[] SchemaXML.ITRetConsSitNFe.procEventoNFe
        {
            get { return this.procEventoNFe; }
        }

        SchemaXML.ITRetCancNFe_v200107 SchemaXML.ITRetConsSitNFe.retCancNFe
        {
            get
            {
                return this.retCancNFe;
            }
            set
            {
                retCancNFe = (TRetCancNFe_v200107)value;
            }
        }
    }


    public partial class TNfeProc : RDI.NFe2.SchemaXML.ITNfeProc
    {
        SchemaXML.ITNFe SchemaXML.ITNfeProc.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe)value;
            }
        }

        SchemaXML.ITProtNFe SchemaXML.ITNfeProc.protNFe
        {
            get
            {
                return this.protNFe;
            }
            set
            {
                this.protNFe = (TProtNFe)value;
            }
        }
    }
    public partial class TProtNFe : RDI.NFe2.SchemaXML.ITProtNFe
    {
        SchemaXML.ITProtNFeInfProt SchemaXML.ITProtNFe.infProt
        {
            get { return this.infProt; }
            set { this.infProt = (TProtNFeInfProt)value; }
        }
    }

    public partial class TProtNFeInfProt : RDI.NFe2.SchemaXML.ITProtNFeInfProt
    {

    }



    public partial class TNFe : RDI.NFe2.SchemaXML.ITNFe
    {
        RDI.NFe2.SchemaXML.ITNFeInfNFe RDI.NFe2.SchemaXML.ITNFe.infNFe
        {
            get
            {
                return this.infNFe;
            }
            set
            {
                this.infNFe = (TNFeInfNFe)value;
            }
        }

        SchemaXML.ISignatureType SchemaXML.ITNFe.Signature
        {
            get { return this.Signature; }
        }
    }

    public partial class TNFeInfNFe : RDI.NFe2.SchemaXML.ITNFeInfNFe
    {
        SchemaXML.ITNFeInfNFeIde SchemaXML.ITNFeInfNFe.ide
        {
            get { return this.ide; }
        }

        SchemaXML.ITNFeInfNFeDest SchemaXML.ITNFeInfNFe.dest
        {
            get { return this.dest; }
        }

        SchemaXML.ITNFeInfNFeEmit SchemaXML.ITNFeInfNFe.emit
        {
            get { return this.emit; }
        }
    }

    public partial class TNFeInfNFeIde : RDI.NFe2.SchemaXML.ITNFeInfNFeIde
    {

    }

    public partial class TNFeInfNFeDest : RDI.NFe2.SchemaXML.ITNFeInfNFeDest
    {

        SchemaXML.ITEndereco SchemaXML.ITNFeInfNFeDest.enderDest
        {
            get
            {
                return this.enderDest;
            }
        }
    }

    public partial class TNFeInfNFeEmit : RDI.NFe2.SchemaXML.ITNFeInfNFeEmit
    {
        SchemaXML.ITEnderEmi SchemaXML.ITNFeInfNFeEmit.enderEmit
        {
            get
            {
                return this.enderEmit;
            }
        }
    }

    public partial class TEndereco : RDI.NFe2.SchemaXML.ITEndereco
    {

    }

    public partial class TEnderEmi : RDI.NFe2.SchemaXML.ITEnderEmi
    {

    }
}

namespace RDI.NFe2.SchemaXML.NFe_v300
{
    public partial class TRetEnviNFeInfRec : RDI.NFe2.SchemaXML.ITRetEnviNFeInfRec
    {

    }

    public partial class TRetCancNFe_v200107InfCanc : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107InfCanc
    {

        string SchemaXML.ITRetCancNFe_v200107InfCanc.nProt
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }



    public partial class TRetCancNFe_v200107 : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107
    {


        SchemaXML.ITRetCancNFe_v200107InfCanc SchemaXML.ITRetCancNFe_v200107.infCanc
        {
            get { return null; }
        }
    }



    public partial class TRetCancNFe : RDI.NFe2.SchemaXML.ITRetCancNFe
    {

    }


    public partial class TCancNFe : RDI.NFe2.SchemaXML.ITCancNFe
    {

    }


    public partial class TInutNFeInfInut : RDI.NFe2.SchemaXML.ITInutNFeInfInut
    {

    }





    public partial class TEnviNFe : RDI.NFe2.SchemaXML.ITEnviNFe
    {
        SchemaXML.ITNFe[] SchemaXML.ITEnviNFe.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe[])value;
            }
        }
    }
    public partial class TRetEnviNFe : RDI.NFe2.SchemaXML.ITRetEnviNFe
    {
        SchemaXML.ITRetEnviNFeInfRec SchemaXML.ITRetEnviNFe.infRec
        {
            get
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    return (TRetEnviNFeInfRec)this.Item;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
            set
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    this.Item = (TRetEnviNFeInfRec)value;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
    public partial class TConsReciNFe : RDI.NFe2.SchemaXML.ITConsReciNFe { }
    public partial class TRetConsReciNFe : RDI.NFe2.SchemaXML.ITRetConsReciNFe
    {
        SchemaXML.ITProtNFe[] SchemaXML.ITRetConsReciNFe.protNFe
        {
            get
            {
                return this.protNFe;
            }
        }
    }
    public partial class TConsStatServ : RDI.NFe2.SchemaXML.ITConsStatServ { }
    public partial class TRetConsStatServ : RDI.NFe2.SchemaXML.ITRetConsStatServ { }
    public partial class TInutNFe : RDI.NFe2.SchemaXML.ITInutNFe
    {
        SchemaXML.ITInutNFeInfInut SchemaXML.ITInutNFe.infInut
        {
            get { return this.infInut; }
            set { this.infInut = (TInutNFeInfInut)value; }
        }
    }
    public partial class TRetInutNFe : RDI.NFe2.SchemaXML.ITRetInutNFe
    {
        SchemaXML.ITRetInutNFeInfInut SchemaXML.ITRetInutNFe.infInut
        {
            get { return this.infInut; }
        }
    }

    public partial class TRetInutNFeInfInut : RDI.NFe2.SchemaXML.ITRetInutNFeInfInut
    {

    }


    public partial class TConsSitNFe : RDI.NFe2.SchemaXML.ITConsSitNFe { }
    public partial class TRetConsSitNFe : RDI.NFe2.SchemaXML.ITRetConsSitNFe
    {
        SchemaXML.ITProtNFe SchemaXML.ITRetConsSitNFe.protNFe
        {
            get { return this.protNFe; }
        }

        SchemaXML.ITProcEvento[] SchemaXML.ITRetConsSitNFe.procEventoNFe
        {
            get { return this.procEventoNFe; }
        }

        SchemaXML.ITRetCancNFe_v200107 SchemaXML.ITRetConsSitNFe.retCancNFe
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }



    public partial class TNfeProc : RDI.NFe2.SchemaXML.ITNfeProc
    {
        SchemaXML.ITNFe SchemaXML.ITNfeProc.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe)value;
            }
        }

        SchemaXML.ITProtNFe SchemaXML.ITNfeProc.protNFe
        {
            get
            {
                return this.protNFe;
            }
            set
            {
                this.protNFe = (TProtNFe)value;
            }
        }
    }
    public partial class TProtNFe : RDI.NFe2.SchemaXML.ITProtNFe
    {
        SchemaXML.ITProtNFeInfProt SchemaXML.ITProtNFe.infProt
        {
            get { return this.infProt; }
            set { this.infProt = (TProtNFeInfProt)value; }
        }
    }

    public partial class TProtNFeInfProt : RDI.NFe2.SchemaXML.ITProtNFeInfProt
    {

    }




    public partial class TNFe : RDI.NFe2.SchemaXML.ITNFe
    {
        RDI.NFe2.SchemaXML.ITNFeInfNFe RDI.NFe2.SchemaXML.ITNFe.infNFe
        {
            get
            {
                return this.infNFe;
            }
            set
            {
                this.infNFe = (TNFeInfNFe)value;
            }
        }

        SchemaXML.ISignatureType SchemaXML.ITNFe.Signature
        {
            get { return this.Signature; }
        }
    }

    public partial class TNFeInfNFe : RDI.NFe2.SchemaXML.ITNFeInfNFe
    {
        SchemaXML.ITNFeInfNFeIde SchemaXML.ITNFeInfNFe.ide
        {
            get { return this.ide; }
        }

        SchemaXML.ITNFeInfNFeDest SchemaXML.ITNFeInfNFe.dest
        {
            get { return this.dest; }
        }

        SchemaXML.ITNFeInfNFeEmit SchemaXML.ITNFeInfNFe.emit
        {
            get { return this.emit; }
        }
    }

    public partial class TNFeInfNFeIde : RDI.NFe2.SchemaXML.ITNFeInfNFeIde
    {
        string SchemaXML.ITNFeInfNFeIde.dEmi
        {
            get { return this.dhEmi; }
        }

    }

    public partial class TNFeInfNFeDest : RDI.NFe2.SchemaXML.ITNFeInfNFeDest
    {

        SchemaXML.ITEndereco SchemaXML.ITNFeInfNFeDest.enderDest
        {
            get
            {
                return this.enderDest;
            }
        }
    }

    public partial class TNFeInfNFeEmit : RDI.NFe2.SchemaXML.ITNFeInfNFeEmit
    {
        SchemaXML.ITEnderEmi SchemaXML.ITNFeInfNFeEmit.enderEmit
        {
            get
            {
                return this.enderEmit;
            }
        }
    }

    public partial class TEndereco : RDI.NFe2.SchemaXML.ITEndereco
    {

    }

    public partial class TEnderEmi : RDI.NFe2.SchemaXML.ITEnderEmi
    {

    }
}

namespace RDI.NFe2.SchemaXML.NFe_v310
{
    public partial class TRetEnviNFeInfRec : RDI.NFe2.SchemaXML.ITRetEnviNFeInfRec
    {

    }

    public partial class TRetCancNFe_v200107InfCanc : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107InfCanc
    {

        string SchemaXML.ITRetCancNFe_v200107InfCanc.nProt
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }



    public partial class TRetCancNFe_v200107 : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107
    {

        SchemaXML.ITRetCancNFe_v200107InfCanc SchemaXML.ITRetCancNFe_v200107.infCanc
        {
            get
            {
                return null;
            }
        }
    }



    public partial class TRetCancNFe : RDI.NFe2.SchemaXML.ITRetCancNFe
    {

    }


    public partial class TCancNFe : RDI.NFe2.SchemaXML.ITCancNFe
    {

    }


    public partial class TInutNFeInfInut : RDI.NFe2.SchemaXML.ITInutNFeInfInut
    {

    }

    public partial class TEnviNFe : RDI.NFe2.SchemaXML.ITEnviNFe
    {
        SchemaXML.ITNFe[] SchemaXML.ITEnviNFe.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe[])value;
            }
        }
    }
    public partial class TRetEnviNFe : RDI.NFe2.SchemaXML.ITRetEnviNFe
    {
        SchemaXML.ITRetEnviNFeInfRec SchemaXML.ITRetEnviNFe.infRec
        {
            get
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    return (TRetEnviNFeInfRec)this.Item;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
            set
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    this.Item = (TRetEnviNFeInfRec)value;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
    public partial class TConsReciNFe : RDI.NFe2.SchemaXML.ITConsReciNFe { }
    public partial class TRetConsReciNFe : RDI.NFe2.SchemaXML.ITRetConsReciNFe
    {
        SchemaXML.ITProtNFe[] SchemaXML.ITRetConsReciNFe.protNFe
        {
            get
            {
                return this.protNFe;
            }
        }
    }
    public partial class TConsStatServ : RDI.NFe2.SchemaXML.ITConsStatServ { }
    public partial class TRetConsStatServ : RDI.NFe2.SchemaXML.ITRetConsStatServ { }
    public partial class TInutNFe : RDI.NFe2.SchemaXML.ITInutNFe
    {
        SchemaXML.ITInutNFeInfInut SchemaXML.ITInutNFe.infInut
        {
            get { return this.infInut; }
            set { this.infInut = (TInutNFeInfInut)value; }
        }
    }
    public partial class TRetInutNFe : RDI.NFe2.SchemaXML.ITRetInutNFe
    {
        SchemaXML.ITRetInutNFeInfInut SchemaXML.ITRetInutNFe.infInut
        {
            get { return this.infInut; }
        }
    }

    public partial class TRetInutNFeInfInut : RDI.NFe2.SchemaXML.ITRetInutNFeInfInut
    {

    }


    public partial class TConsSitNFe : RDI.NFe2.SchemaXML.ITConsSitNFe { }
    public partial class TRetConsSitNFe : RDI.NFe2.SchemaXML.ITRetConsSitNFe
    {
        SchemaXML.ITProtNFe SchemaXML.ITRetConsSitNFe.protNFe
        {
            get { return this.protNFe; }
        }

        SchemaXML.ITProcEvento[] SchemaXML.ITRetConsSitNFe.procEventoNFe
        {
            get { return this.procEventoNFe; }
        }

        SchemaXML.ITRetCancNFe_v200107 SchemaXML.ITRetConsSitNFe.retCancNFe
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }



    public partial class TNfeProc : RDI.NFe2.SchemaXML.ITNfeProc
    {
        SchemaXML.ITNFe SchemaXML.ITNfeProc.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe)value;
            }
        }

        SchemaXML.ITProtNFe SchemaXML.ITNfeProc.protNFe
        {
            get
            {
                return this.protNFe;
            }
            set
            {
                this.protNFe = (TProtNFe)value;
            }
        }
    }
    public partial class TProtNFe : RDI.NFe2.SchemaXML.ITProtNFe
    {
        SchemaXML.ITProtNFeInfProt SchemaXML.ITProtNFe.infProt
        {
            get { return this.infProt; }
            set { this.infProt = (TProtNFeInfProt)value; }
        }
    }

    public partial class TProtNFeInfProt : RDI.NFe2.SchemaXML.ITProtNFeInfProt
    {

    }




    public partial class TNFe : RDI.NFe2.SchemaXML.ITNFe
    {
        RDI.NFe2.SchemaXML.ITNFeInfNFe RDI.NFe2.SchemaXML.ITNFe.infNFe
        {
            get
            {
                return this.infNFe;
            }
            set
            {
                this.infNFe = (TNFeInfNFe)value;
            }
        }

        SchemaXML.ISignatureType SchemaXML.ITNFe.Signature
        {
            get { return this.Signature; }
        }
    }

    public partial class TNFeInfNFe : RDI.NFe2.SchemaXML.ITNFeInfNFe
    {
        SchemaXML.ITNFeInfNFeIde SchemaXML.ITNFeInfNFe.ide
        {
            get { return this.ide; }
        }

        SchemaXML.ITNFeInfNFeDest SchemaXML.ITNFeInfNFe.dest
        {
            get { return this.dest; }
        }

        SchemaXML.ITNFeInfNFeEmit SchemaXML.ITNFeInfNFe.emit
        {
            get { return this.emit; }
        }
    }

    public partial class TNFeInfNFeIde : RDI.NFe2.SchemaXML.ITNFeInfNFeIde
    {

        string SchemaXML.ITNFeInfNFeIde.dEmi
        {
            get { return this.dhEmi; }
        }

    }

    public partial class TNFeInfNFeDest : RDI.NFe2.SchemaXML.ITNFeInfNFeDest
    {

        SchemaXML.ITEndereco SchemaXML.ITNFeInfNFeDest.enderDest
        {
            get
            {
                return this.enderDest;
            }
        }
    }

    public partial class TNFeInfNFeEmit : RDI.NFe2.SchemaXML.ITNFeInfNFeEmit
    {
        SchemaXML.ITEnderEmi SchemaXML.ITNFeInfNFeEmit.enderEmit
        {
            get
            {
                return this.enderEmit;
            }
        }
    }

    public partial class TEndereco : RDI.NFe2.SchemaXML.ITEndereco
    {

    }

    public partial class TEnderEmi : RDI.NFe2.SchemaXML.ITEnderEmi
    {

    }
}

namespace RDI.NFe2.SchemaXML.NFe_v400
{
    public partial class TConsStatServ : RDI.NFe2.SchemaXML.ITConsStatServ { }
    public partial class TRetConsStatServ : RDI.NFe2.SchemaXML.ITRetConsStatServ { }
    public partial class TRetEnviNFeInfRec : RDI.NFe2.SchemaXML.ITRetEnviNFeInfRec
    {

    }
    public partial class TRetCancNFe_v200107InfCanc : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107InfCanc
    {

        string SchemaXML.ITRetCancNFe_v200107InfCanc.nProt
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }
    public partial class TRetCancNFe_v200107 : RDI.NFe2.SchemaXML.ITRetCancNFe_v200107
    {
        SchemaXML.ITRetCancNFe_v200107InfCanc SchemaXML.ITRetCancNFe_v200107.infCanc
        {
            get
            {
                return null;
            }
        }
    }
    public partial class TRetCancNFe : RDI.NFe2.SchemaXML.ITRetCancNFe
    {

    }
    public partial class TCancNFe : RDI.NFe2.SchemaXML.ITCancNFe
    {

    }
    public partial class TInutNFeInfInut : RDI.NFe2.SchemaXML.ITInutNFeInfInut
    {

    }
    public partial class TEnviNFe : RDI.NFe2.SchemaXML.ITEnviNFe
    {
        SchemaXML.ITNFe[] SchemaXML.ITEnviNFe.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe[])value;
            }
        }
    }
    public partial class TRetEnviNFe : RDI.NFe2.SchemaXML.ITRetEnviNFe
    {
        SchemaXML.ITRetEnviNFeInfRec SchemaXML.ITRetEnviNFe.infRec
        {
            get
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    return (TRetEnviNFeInfRec)this.Item;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
            set
            {
                if (typeof(TRetEnviNFeInfRec) == this.Item.GetType())
                {
                    this.Item = (TRetEnviNFeInfRec)value;
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
        }
    }
    public partial class TConsReciNFe : RDI.NFe2.SchemaXML.ITConsReciNFe { }
    public partial class TRetConsReciNFe : RDI.NFe2.SchemaXML.ITRetConsReciNFe
    {
        SchemaXML.ITProtNFe[] SchemaXML.ITRetConsReciNFe.protNFe
        {
            get
            {
                return this.protNFe;
            }
        }
    }
    public partial class TInutNFe : RDI.NFe2.SchemaXML.ITInutNFe
    {
        SchemaXML.ITInutNFeInfInut SchemaXML.ITInutNFe.infInut
        {
            get { return this.infInut; }
            set { this.infInut = (TInutNFeInfInut)value; }
        }
    }
    public partial class TRetInutNFe : RDI.NFe2.SchemaXML.ITRetInutNFe
    {
        SchemaXML.ITRetInutNFeInfInut SchemaXML.ITRetInutNFe.infInut
        {
            get { return this.infInut; }
        }
    }
    public partial class TRetInutNFeInfInut : RDI.NFe2.SchemaXML.ITRetInutNFeInfInut
    {

    }
    public partial class TConsSitNFe : RDI.NFe2.SchemaXML.ITConsSitNFe { }
    public partial class TRetConsSitNFe : RDI.NFe2.SchemaXML.ITRetConsSitNFe
    {
        SchemaXML.ITProtNFe SchemaXML.ITRetConsSitNFe.protNFe
        {
            get { return this.protNFe; }
        }

        SchemaXML.ITProcEvento[] SchemaXML.ITRetConsSitNFe.procEventoNFe
        {
            get { return this.procEventoNFe; }
        }

        SchemaXML.ITRetCancNFe_v200107 SchemaXML.ITRetConsSitNFe.retCancNFe
        {
            get
            {
                return null;
            }
            set
            {
                //throw new System.NotImplementedException();
            }
        }
    }

    public partial class TNfeProc : RDI.NFe2.SchemaXML.ITNfeProc
    {
        SchemaXML.ITNFe SchemaXML.ITNfeProc.NFe
        {
            get
            {
                return this.NFe;
            }
            set
            {
                this.NFe = (TNFe)value;
            }
        }

        SchemaXML.ITProtNFe SchemaXML.ITNfeProc.protNFe
        {
            get
            {
                return this.protNFe;
            }
            set
            {
                this.protNFe = (TProtNFe)value;
            }
        }
    }
    public partial class TProtNFe : RDI.NFe2.SchemaXML.ITProtNFe
    {
        SchemaXML.ITProtNFeInfProt SchemaXML.ITProtNFe.infProt
        {
            get { return this.infProt; }
            set { this.infProt = (TProtNFeInfProt)value; }
        }

    }
    public partial class TProtNFeInfProt : RDI.NFe2.SchemaXML.ITProtNFeInfProt
    {

    }
    public partial class TNFe : RDI.NFe2.SchemaXML.ITNFe
    {
        RDI.NFe2.SchemaXML.ITNFeInfNFe RDI.NFe2.SchemaXML.ITNFe.infNFe
        {
            get
            {
                return this.infNFe;
            }
            set
            {
                this.infNFe = (TNFeInfNFe)value;
            }
        }

        SchemaXML.ISignatureType SchemaXML.ITNFe.Signature
        {
            get { return this.Signature; }
        }
    }
    public partial class TNFeInfNFe : RDI.NFe2.SchemaXML.ITNFeInfNFe
    {
        SchemaXML.ITNFeInfNFeIde SchemaXML.ITNFeInfNFe.ide
        {
            get { return this.ide; }
        }

        SchemaXML.ITNFeInfNFeDest SchemaXML.ITNFeInfNFe.dest
        {
            get { return this.dest; }
        }

        SchemaXML.ITNFeInfNFeEmit SchemaXML.ITNFeInfNFe.emit
        {
            get { return this.emit; }
        }
    }
    public partial class TNFeInfNFeIde : RDI.NFe2.SchemaXML.ITNFeInfNFeIde
    {
        string SchemaXML.ITNFeInfNFeIde.dEmi
        {
            get { return this.dhEmi; }
        }
    }
    public partial class TNFeInfNFeDest : RDI.NFe2.SchemaXML.ITNFeInfNFeDest
    {

        SchemaXML.ITEndereco SchemaXML.ITNFeInfNFeDest.enderDest
        {
            get
            {
                return this.enderDest;
            }
        }
    }

    public partial class TNFeInfNFeEmit : RDI.NFe2.SchemaXML.ITNFeInfNFeEmit
    {
        SchemaXML.ITEnderEmi SchemaXML.ITNFeInfNFeEmit.enderEmit
        {
            get
            {
                return this.enderEmit;
            }
        }
    }

    public partial class TEndereco : RDI.NFe2.SchemaXML.ITEndereco
    {

    }

    public partial class TEnderEmi : RDI.NFe2.SchemaXML.ITEnderEmi
    {

    }
}
#endregion
