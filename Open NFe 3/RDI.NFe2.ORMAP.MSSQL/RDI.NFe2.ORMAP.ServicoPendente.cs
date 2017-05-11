using System;
using System.Collections.Generic;
using System.Text;
using RDI.Lince;
using RDI.NFe2.SchemaXML200;
using RDI.NFe2.SchemaXML;


namespace RDI.NFe2.ORMAP
{
    public class ServicoPendente : BusinessObject
    {
        
        private String _empresa;
        private Int32 _numeroLote;

        private TipoSituacaoServico _codigoSituacao;
        private DateTime _dataSituacao;
        private String _numeroRecibo;
        private String _xmlRecibo;
        private String _xmlRetConsulta;
        private Boolean _erroEnvio;
        private VersaoXML _versao;

        public VersaoXML versao
        {
            get { return _versao; }
            set { if (_versao != value) { _versao = value; isModified = true; }; }
        }

        public Boolean erroEnvio
        {
            get { return _erroEnvio; }
            set { SetIfChanged(ref _erroEnvio, value); }
        }

        TCodUfIBGE _UF;                      /* UF do WEBSERVICE (31,52) */
        TAmb _tipoAmbiente;                  /* Homologacao 1 Producao 2 */
        TNFeInfNFeIdeTpEmis _tipoEmissao;   /* normal 1 - contigencia 2 */

        public TCodUfIBGE UF
        {
            get { return _UF; }
            set { if (_UF != value) { _UF = value; isModified = true; }; }
        }
        public TAmb tipoAmbiente
        {
            get { return _tipoAmbiente; }
            set { if (_tipoAmbiente != value) { _tipoAmbiente = value; isModified = true; }; }
        }
        public TNFeInfNFeIdeTpEmis tipoEmissao
        {
            get { return _tipoEmissao; }
            set { if (_tipoEmissao != value) { _tipoEmissao = value; isModified = true; }; }
        }

        public String empresa
        {
            get { return _empresa; }
            set { SetIfChanged(ref _empresa, value); }
        }

        public Int32 numeroLote
        {
            get { return _numeroLote; }
            set { SetIfChanged(ref _numeroLote, value); }
        }

        public TipoSituacaoServico codigoSituacao
        {
            get { return _codigoSituacao; }
            set { if (_codigoSituacao != value) { _codigoSituacao = value; isModified = true; }; }
        }
        public DateTime dataSituacao
        {
            get { return _dataSituacao; }
            set { SetIfChanged(ref _dataSituacao, value); }
        }
        public String numeroRecibo
        {
            get { return _numeroRecibo; }
            set { SetIfChanged(ref _numeroRecibo, value); }
        }
        public String xmlRecibo
        {
            get { return _xmlRecibo; }
            set { SetIfChanged(ref _xmlRecibo, value); }
        }
        public String xmlRetConsulta
        {
            get { return _xmlRetConsulta; }
            set { SetIfChanged(ref _xmlRetConsulta, value); }
        }

        

        public String descSituacao
        {
            get { return Utils.ObterDescricao(codigoSituacao); }
        }

        public override DALObject GetDAL()
        {
            return ServicoPendenteDAL.Instance;
        }

        public override string GetKeyString()
        {
            return String.Format("{0}|{1}", empresa, numeroLote);
        }

        public override void SetKey(string keyString)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        public override string GetObjectDescription()
        {
            throw new Exception("The method or operation is not implemented.");
        }

    }

    public class ServicoPendenteDAL : DALObject
    {
        static private ServicoPendenteDAL _instance;
        static public ServicoPendenteDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServicoPendenteDAL();
                return _instance;
            }
        }
        protected override void CreateInsertParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            ServicoPendente pend = (ServicoPendente)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, pend.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DataSituacao", System.Data.DbType.DateTime, pend.dataSituacao);
            DALObject.CreateParameter(cmd, "@NumeroRecibo", System.Data.DbType.String, pend.numeroRecibo);   
            DALObject.CreateParameter(cmd, "@XMLRecibo", System.Data.DbType.String, pend.xmlRecibo);
            DALObject.CreateParameter(cmd, "@xmlRetConsulta", System.Data.DbType.String, pend.xmlRetConsulta);            
            DALObject.CreateParameter(cmd, "@erroEnvio", System.Data.DbType.Boolean, pend.erroEnvio);

            DALObject.CreateParameter(cmd, "@TipoOperacao", System.Data.DbType.Int32, pend.tipoAmbiente);
            DALObject.CreateParameter(cmd, "@ModoOperacao", System.Data.DbType.Int32, pend.tipoEmissao);

            DALObject.CreateParameter(cmd, "@UnidadeFederativa", System.Data.DbType.Int32, pend.UF);
            DALObject.CreateParameter(cmd, "@versao", System.Data.DbType.Int32, pend.versao);
        }
        protected override void CreateKeyParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            ServicoPendente pend = (ServicoPendente)businessObject;
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, pend.empresa);
            DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.Int32, pend.numeroLote);
        }
        protected override void CreateUpdateParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            ServicoPendente pend = (ServicoPendente)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, pend.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DataSituacao", System.Data.DbType.DateTime, pend.dataSituacao);
            DALObject.CreateParameter(cmd, "@NumeroRecibo", System.Data.DbType.String, pend.numeroRecibo);
            DALObject.CreateParameter(cmd, "@XMLRecibo", System.Data.DbType.String, pend.xmlRecibo);
            DALObject.CreateParameter(cmd, "@erroEnvio", System.Data.DbType.Boolean, pend.erroEnvio);
            DALObject.CreateParameter(cmd, "@xmlRetConsulta", System.Data.DbType.String, pend.xmlRetConsulta);

            DALObject.CreateParameter(cmd, "@TipoOperacao", System.Data.DbType.Int32, pend.tipoAmbiente);
            DALObject.CreateParameter(cmd, "@ModoOperacao", System.Data.DbType.Int32, pend.tipoEmissao);

            DALObject.CreateParameter(cmd, "@UnidadeFederativa", System.Data.DbType.Int32, pend.UF);
            DALObject.CreateParameter(cmd, "@versao", System.Data.DbType.Int32, pend.versao);
        }
        protected override void DataReaderToPersistentObject(System.Data.IDataReader dataReader, BusinessObject businessObject, string radical)
        {
            ServicoPendente pend = (ServicoPendente)businessObject;
            pend.BeginInit();
            try
            {
                pend.numeroLote = Utils.FieldAsInt32(dataReader, "NumeroLote");
                pend.empresa = Utils.FieldAsString(dataReader, "CNPJ");
                pend.codigoSituacao = (TipoSituacaoServico)Utils.FieldAsInt32(dataReader, "CodigoSituacao");
                pend.dataSituacao = Utils.FieldAsDateTime(dataReader, "DataSituacao");
                pend.numeroRecibo = Utils.FieldAsString(dataReader, "NumeroRecibo");
                pend.xmlRecibo = Utils.FieldAsString(dataReader, "XMLRecibo");
                pend.erroEnvio = Utils.FieldAsBoolean(dataReader, "erroEnvio");
                pend.xmlRetConsulta = Utils.FieldAsString(dataReader, "xmlRetConsulta");
                pend.tipoAmbiente = (TAmb)Utils.FieldAsInt32(dataReader, "TipoOperacao");
                pend.tipoEmissao = (TNFeInfNFeIdeTpEmis)Utils.FieldAsInt32(dataReader, "ModoOperacao");
                pend.UF = (TCodUfIBGE)Utils.FieldAsInt32(dataReader, "UnidadeFederativa");
                pend.versao = (VersaoXML)Utils.FieldAsInt32(dataReader, "versao");

                pend.isRecorded = true;
                pend.isModified = false;
            }
            finally
            {
                pend.EndInit();
            }

        }
        protected override Type GetCollectorType()
        {
            return typeof(ServicoPendenteQry);
        }
        protected override Type GetPersistentObjectType()
        {
            return typeof(ServicoPendente);
        }
        protected override string GetInsertStatement()
        {
            return @"INSERT INTO ServicosPendentes(ModoOperacao, TipoOperacao, UnidadeFederativa, NumeroLote, CodigoSituacao, DataSituacao, NumeroRecibo, XMLRecibo, CNPJ, erroEnvio, xmlRetConsulta, versao)
                          VALUES(@ModoOperacao, @TipoOperacao, @UnidadeFederativa, @NumeroLote, @CodigoSituacao, @DataSituacao, @NumeroRecibo, @XMLRecibo, @CNPJ, @erroEnvio, @xmlRetConsulta, @versao)";
        }
        protected override string GetUpdateStatement()
        {
            return @"UPDATE ServicosPendentes
                        SET ModoOperacao = @ModoOperacao, 
                            TipoOperacao = @TipoOperacao, 
                            UnidadeFederativa     = @UnidadeFederativa, 
                            CodigoSituacao = @CodigoSituacao,
                            DataSituacao = @DataSituacao,
                            NumeroRecibo = @NumeroRecibo,
                            XMLRecibo = @XMLRecibo,
                            erroEnvio = @erroEnvio,
                            xmlRetConsulta = @xmlRetConsulta,
                            versao = @versao
                      WHERE NumeroLote = @NumeroLote
                        AND CNPJ = @CNPJ";

        }
        protected override string GetDeleteStatement()
        {
//            return @"DELETE FROM ServicosPendentes 
//                        WHERE NumeroLote = @NumeroLote
//                        AND CNPJ = @CNPJ";
            throw new Exception("Esse Registro não pode ser Excluído.");
        }
        protected override string GetSelectStatement()
        {
            return @"SELECT ModoOperacao, TipoOperacao, UnidadeFederativa, NumeroLote, CodigoSituacao, DataSituacao, NumeroRecibo, XMLRecibo, CNPJ, erroEnvio, xmlRetConsulta, versao
                       FROM ServicosPendentes
                        --<where auto>--
                        --<orderby>--";
        }
        protected override string GetEntityName()
        {
            return "ServicosPendentes";
        }

        protected string GetMaxSelect()
        {
            return @"SELECT isnull (max(NumeroLote),0) as NumeroLote
                       FROM ServicosPendentes
                        --<where auto>--";
        }
        public Int32 GetMax(QueryObject queryobject, ClientEnvironment clientEnvironment)
        {
            System.Data.IDbCommand cmd = clientEnvironment.connection.CreateCommand();

            cmd.Parameters.Clear();
            cmd.CommandText = GetMaxSelect();

            if (clientEnvironment.transaction != null) cmd.Transaction = clientEnvironment.transaction;

            return (Int32)cmd.ExecuteScalar() + 1;
        }

        //protected override void DoAfterDelete(System.Data.IDbCommand cmd, BusinessObject businessObject, ClientEnvironment clientEnvironment)
        //{
        //    /*TODO : testar e avaliar, para quando um serviço for excluido, também setar a nota como Serviço Excluido
        //     * 
        //     */ base.DoAfterDelete(cmd, businessObject, clientEnvironment);
            
        //    ServicoPendente oServico = (ServicoPendente)businessObject;
        //    if (oServico.codigoSituacao != TipoSituacaoServico.Processado && oServico.codigoSituacao != TipoSituacaoServico.Finalizado)
        //    {
        //        NotaFiscalQry collect = new NotaFiscalQry();
        //        collect.empresa = oServico.empresa;
        //        collect.numeroLote = oServico.numeroLote.ToString();

        //        //achar a nota referente aquele servico
        //        System.Collections.ArrayList notas = NotaFiscalDAL.Instance.GetInstances(collect, clientEnvironment);
        //        if (notas.Count > 0)
        //        {
        //            //se achou a nota
        //            NotaFiscal oNota = (NotaFiscal)notas[0];
        //            oNota.codigoSituacao = 99;
        //            oNota.descricaoSituacao = "Serviço Excluído";
        //            oNota.Save(clientEnvironment);
        //        }
        //    }
        //    //*/
        //}
    }

    public class ServicoPendenteQry : QueryObject
    {
        public ServicoPendenteQry() : base(System.String.Empty) { }
        //private String _chaveNota;
        private String _numeroLote;
        private String _codigoSituacao;
        private String _numeroRecibo;
        private DateTime _dataInicial;
        private DateTime _dataFinal;
        public Boolean FilterByDate = false;

        private String _empresa;

        public DateTime dataInicial
        {
            get { return _dataInicial; }
            set { _dataInicial = value; }
        }
        public DateTime dataFinal
        {
            get { return _dataFinal; }
            set { _dataFinal = value; }
        }
        public String empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public String numeroLote
        {
            get { return _numeroLote; }
            set { _numeroLote = value; }
        }
        public String codigoSituacao
        {
            get { return _codigoSituacao; }
            set { _codigoSituacao = value; }
        }
        public String numeroRecibo
        {
            get { return _numeroRecibo; }
            set { _numeroRecibo = value; }
        }

        public override void CreateParameters(System.Data.IDbCommand cmd)
        {
            if (numeroLote != null)
                DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.Int32, Convert.ToInt32(numeroLote));
            if (codigoSituacao != null)
                DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, Convert.ToInt32(codigoSituacao));
            if (numeroRecibo != null)
                DALObject.CreateParameter(cmd, "@NumeroRecibo", System.Data.DbType.String, numeroRecibo);
            if (FilterByDate)
            {
                if (dataInicial.ToShortDateString() != "01/01/0001")
                    DALObject.CreateParameter(cmd, "@dataInicial", System.Data.DbType.DateTime, dataInicial);
                if (dataFinal.ToShortDateString() != "01/01/0001")
                    DALObject.CreateParameter(cmd, "@dataFinal", System.Data.DbType.DateTime,
                        dataFinal.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999));
            }
            if (empresa != null)
                DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, empresa);


        }
        public override void ModifySQL(SQLUtils handler)
        {
            if (numeroLote != null)
                handler.handleSQLAppendWhere(prefix + "NumeroLote = @NumeroLote");
            if (codigoSituacao != null)
                handler.handleSQLAppendWhere(prefix + "CodigoSituacao = @CodigoSituacao");
            if (numeroRecibo != null)
                handler.handleSQLAppendWhere(prefix + "NumeroRecibo = @NumeroRecibo");
            if (empresa != null)
                handler.handleSQLAppendWhere(prefix + "CNPJ = @CNPJ");

            if (FilterByDate)
            {
                if (dataInicial.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "DataSituacao >= @dataInicial");
                if (dataFinal.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "DataSituacao <= @dataFinal");
                handler.handleSQLAppendOrderBy("order by DataSituacao");
            }
        }
        public override void SetKey(BusinessObject businessObject)
        {
            ServicoPendente pend = (ServicoPendente)businessObject;
            empresa = pend.empresa;
            numeroLote = pend.numeroLote.ToString();
        }
        public override void SetKey(string keyString)
        {
            empresa  = keyString.Split('|')[0];
            numeroLote = keyString.Split('|')[1];
        }

    }
}
