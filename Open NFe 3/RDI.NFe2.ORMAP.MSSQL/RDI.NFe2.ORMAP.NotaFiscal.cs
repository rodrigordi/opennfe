using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using RDI.Lince;
using RDI.NFe2.SchemaXML;


namespace RDI.NFe2.ORMAP
{
    public class NotaFiscal : BusinessObject
    {
        private String _chaveNota;
        private Int32 _numeroLote;
        private TipoSituacaoNota _codigoSituacao;
        private String _descricaoSituacao;
        private DateTime _dataSituacao;

        private String _empresa;
        private String _cStat;
        private String _xMotivo;

        private String _xmlNota;
        private String _xmlProcesso;
        private String _nProt;

        private String _xmlPedidoCancelamento;
        private String _xmlProcessoCancelamento;
        private String _nProtCancelamento;

        private VersaoXML _versao;


        public String cStat
        {
            get { return _cStat; }
            set { SetIfChanged(ref _cStat, value); }
        }
        public String xMotivo
        {
            get { return _xMotivo; }
            set { SetIfChanged(ref _xMotivo, value); }
        }


        public String empresa
        {
            get { return _empresa; }
            set { SetIfChanged(ref _empresa, value); }
        }

        public String chaveNota
        {
            get { return _chaveNota; }
            set { SetIfChanged(ref _chaveNota, value); }
        }
        public Int32 numeroLote
        {
            get { return _numeroLote; }
            set { SetIfChanged(ref _numeroLote, value); }
        }
        public TipoSituacaoNota codigoSituacao
        {
            get { return _codigoSituacao; }
            set { if (_codigoSituacao != value) { _codigoSituacao = value; isModified = true; }; }
        }
        public String descricaoSituacao
        {
            get { return _descricaoSituacao; }
            set { SetIfChanged(ref _descricaoSituacao, value); }
        }
        public DateTime dataSituacao
        {
            get { return _dataSituacao; }
            set { SetIfChanged(ref _dataSituacao, value); }
        }
        public String xmlNota
        {
            get { return _xmlNota; }
            set { SetIfChanged(ref _xmlNota, value); }
        }
        public String xmlProcesso
        {
            get { return _xmlProcesso; }
            set { SetIfChanged(ref _xmlProcesso, value); }
        }
        public String nProt
        {
            get { return _nProt; }
            set { SetIfChanged(ref _nProt, value); }
        }

        public String xmlPedidoCancelamento
        {
            get { return _xmlPedidoCancelamento; }
            set { SetIfChanged(ref _xmlPedidoCancelamento, value); }
        }
        public String xmlProcessoCancelamento
        {
            get { return _xmlProcessoCancelamento; }
            set { SetIfChanged(ref _xmlProcessoCancelamento, value); }
        }
        public String nProtCancelamento
        {
            get { return _nProtCancelamento; }
            set { SetIfChanged(ref _nProtCancelamento, value); }
        }

        public VersaoXML versao
        {
            get { return _versao; }
            set { if (_versao != value) { _versao = value; isModified = true; }; }
        }

        public override DALObject GetDAL()
        {
            return NotaFiscalDAL.Instance;
        }

        public override string GetKeyString()
        {
            return String.Format("{0}|{1}|{2}", empresa, chaveNota, numeroLote);
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

    public class NotaFiscalDAL : DALObject
    {
        static private NotaFiscalDAL _instance;
        static public NotaFiscalDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NotaFiscalDAL();
                return _instance;
            }
        }
        protected override void CreateInsertParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaFiscal nota = (NotaFiscal)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, nota.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DescricaoSituacao", System.Data.DbType.String, nota.descricaoSituacao);
            DALObject.CreateParameter(cmd, "@DataSituacao", System.Data.DbType.DateTime, nota.dataSituacao);
            DALObject.CreateParameter(cmd, "@XMLNotaFiscal", System.Data.DbType.String, nota.xmlNota);
            DALObject.CreateParameter(cmd, "@XMLProcesso", System.Data.DbType.String, nota.xmlProcesso);
            DALObject.CreateParameter(cmd, "@cStat", System.Data.DbType.String, nota.cStat);
            DALObject.CreateParameter(cmd, "@xMotivo", System.Data.DbType.String, nota.xMotivo);
            DALObject.CreateParameter(cmd, "@nProt", System.Data.DbType.String, nota.nProt);
            DALObject.CreateParameter(cmd, "@xmlPedidoCancelamento", System.Data.DbType.String, nota.xmlPedidoCancelamento);
            DALObject.CreateParameter(cmd, "@xmlProcessoCancelamento", System.Data.DbType.String, nota.xmlProcessoCancelamento);
            DALObject.CreateParameter(cmd, "@nProtCancelamento", System.Data.DbType.String, nota.nProtCancelamento);
            DALObject.CreateParameter(cmd, "@versao", System.Data.DbType.Int32, nota.versao);
        }

        protected override void CreateKeyParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaFiscal nota = (NotaFiscal)businessObject;
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, nota.empresa);
            DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, nota.chaveNota);
            DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.Int32, nota.numeroLote);

        }
        protected override void CreateUpdateParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaFiscal nota = (NotaFiscal)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, nota.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DescricaoSituacao", System.Data.DbType.String, nota.descricaoSituacao);
            DALObject.CreateParameter(cmd, "@DataSituacao", System.Data.DbType.DateTime, nota.dataSituacao);
            DALObject.CreateParameter(cmd, "@XMLNotaFiscal", System.Data.DbType.String, nota.xmlNota);
            DALObject.CreateParameter(cmd, "@XMLProcesso", System.Data.DbType.String, nota.xmlProcesso);
            DALObject.CreateParameter(cmd, "@cStat", System.Data.DbType.String, nota.cStat);
            DALObject.CreateParameter(cmd, "@xMotivo", System.Data.DbType.String, nota.xMotivo);
            DALObject.CreateParameter(cmd, "@nProt", System.Data.DbType.String, nota.nProt);
            DALObject.CreateParameter(cmd, "@xmlPedidoCancelamento", System.Data.DbType.String, nota.xmlPedidoCancelamento);
            DALObject.CreateParameter(cmd, "@xmlProcessoCancelamento", System.Data.DbType.String, nota.xmlProcessoCancelamento);
            DALObject.CreateParameter(cmd, "@nProtCancelamento", System.Data.DbType.String, nota.nProtCancelamento);
            DALObject.CreateParameter(cmd, "@versao", System.Data.DbType.Int32, nota.versao);
        }
        protected override void DataReaderToPersistentObject(System.Data.IDataReader dataReader, BusinessObject businessObject, string radical)
        {
            NotaFiscal nota = (NotaFiscal)businessObject;
            nota.BeginInit();
            try
            {
                nota.empresa = Utils.FieldAsString(dataReader, "CNPJ");
                nota.chaveNota = Utils.FieldAsString(dataReader, "ChaveNota");
                nota.numeroLote = Utils.FieldAsInt32(dataReader, "NumeroLote");
                nota.codigoSituacao = (TipoSituacaoNota)Utils.FieldAsInt32(dataReader, "CodigoSituacao");
                nota.descricaoSituacao = Utils.FieldAsString(dataReader, "DescricaoSituacao");
                nota.dataSituacao = Utils.FieldAsDateTime(dataReader, "DataSituacao");
                nota.xmlNota = Utils.FieldAsString(dataReader, "XMLNotaFiscal");
                nota.xmlProcesso = Utils.FieldAsString(dataReader, "XMLProcesso");
                nota.cStat = Utils.FieldAsString(dataReader, "cStat");
                nota.xMotivo = Utils.FieldAsString(dataReader, "xMotivo");
                nota.nProt = Utils.FieldAsString(dataReader, "nProt");

                nota.xmlPedidoCancelamento = Utils.FieldAsString(dataReader, "xmlPedidoCancelamento");
                nota.xmlProcessoCancelamento = Utils.FieldAsString(dataReader, "xmlProcessoCancelamento");
                nota.nProtCancelamento = Utils.FieldAsString(dataReader, "nProtCancelamento");
                nota.versao = (VersaoXML)Utils.FieldAsInt32(dataReader, "versao");

                nota.isRecorded = true;
                nota.isModified = false;
            }
            finally
            {
                nota.EndInit();
            }

        }
        protected override Type GetCollectorType()
        {
            return typeof(NotaFiscalQry);
        }
        protected override Type GetPersistentObjectType()
        {
            return typeof(NotaFiscal);
        }
        protected override string GetInsertStatement()
        {
            return @"INSERT INTO NotasFiscais(NumeroLote, ChaveNota, CodigoSituacao, DescricaoSituacao, DataSituacao, XMLNotaFiscal,
                                              XMLProcesso, CNPJ, cStat, xMotivo, nProt, xmlPedidoCancelamento, xmlProcessoCancelamento, nProtCancelamento, versao)
                          VALUES(@NumeroLote, @ChaveNota, @CodigoSituacao, @DescricaoSituacao, @DataSituacao, @XMLNotaFiscal, 
                                 @XMLProcesso, @CNPJ, @cStat, @xMotivo, @nProt, @xmlPedidoCancelamento, @xmlProcessoCancelamento, @nProtCancelamento, @versao)";
        }
        protected override string GetUpdateStatement()
        {
            return @"UPDATE NotasFiscais
                        SET CodigoSituacao = @CodigoSituacao,
                            DescricaoSituacao = @DescricaoSituacao,
                            DataSituacao = @DataSituacao,
                            XMLNotaFiscal = @XMLNotaFiscal,
                            XMLProcesso = @XMLProcesso,
                            cStat = @cStat, 
                            xMotivo = @xMotivo, 
                            nProt = @nProt,
                            xmlPedidoCancelamento = @xmlPedidoCancelamento,
                            xmlProcessoCancelamento = @xmlProcessoCancelamento,
                            nProtCancelamento = @nProtCancelamento,
                            versao = @versao
                      WHERE NumeroLote = @NumeroLote
                        AND ChaveNota = @ChaveNota
                        AND CNPJ = @CNPJ";

        }
        protected override string GetDeleteStatement()
        {
            throw new Exception("Esse Registro não pode ser Excluído.");
        }
        protected override string GetSelectStatement()
        {
            return $@"SELECT NumeroLote, ChaveNota, CodigoSituacao, DescricaoSituacao, DataSituacao, 
                            XMLNotaFiscal, XMLProcesso, CNPJ, cStat, xMotivo, nProt, xmlPedidoCancelamento, 
                            xmlProcessoCancelamento, nProtCancelamento, versao
                       FROM NotasFiscais
                        {Conexao.whereAuto}
                        {Conexao.orderBy}";
        }
        protected override string GetEntityName()
        {
            return "NotasFiscais";
        }

        protected string GetMaxSelect()
        {
            return $@"SELECT {Conexao.isnull} (max(NumeroLote),0) as NumeroLote
                       FROM NotasFiscais
                        {Conexao.whereAuto}";
        }
        public Int32 GetMax(QueryObject queryobject, ClientEnvironment clientEnvironment)
        {
            System.Data.IDbCommand cmd = clientEnvironment.connection.CreateCommand();

            cmd.Parameters.Clear();
            cmd.CommandText = GetMaxSelect();

            if (clientEnvironment.transaction != null) cmd.Transaction = clientEnvironment.transaction;

            return Convert.ToInt32(cmd.ExecuteScalar()) + 1;
        }


    }

    public class NotaFiscalQry : QueryObject
    {
        public NotaFiscalQry()
            : base(System.String.Empty)
        {
            //Default Value de int é 0 (nesse caso seria assinada.)
            codigoSituacao = TipoSituacaoNota.Vazio;
        }
        public Boolean FilterByDate = false;


        public String chaveNota
        {
            get;
            set;
        }
        public String numeroLote
        {
            get;
            set;
        }
        public TipoSituacaoNota codigoSituacao
        {
            get;
            set;
        }
        public DateTime dataInicial
        {
            get;
            set;
        }
        public DateTime dataFinal
        {
            get;
            set;
        }

        public String empresa
        {
            get;
            set;
        }
        public override void CreateParameters(System.Data.IDbCommand cmd)
        {
            if (chaveNota != null)
                DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, "%" + chaveNota + "%");
            if (numeroLote != null)
                DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.Int32, numeroLote);
            if (codigoSituacao != TipoSituacaoNota.Vazio)
                DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, codigoSituacao);
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
            if (chaveNota != null)
                handler.handleSQLAppendWhere(prefix + "ChaveNota like @ChaveNota");
            if (numeroLote != null)
                handler.handleSQLAppendWhere(prefix + "NumeroLote = @NumeroLote");
            if (codigoSituacao != TipoSituacaoNota.Vazio)
                handler.handleSQLAppendWhere(prefix + "CodigoSituacao = @CodigoSituacao");
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
            NotaFiscal nota = (NotaFiscal)businessObject;
            chaveNota = nota.chaveNota;
            numeroLote = nota.numeroLote.ToString();
            empresa = nota.empresa;
        }
        public override void SetKey(string keyString)
        {
            empresa = keyString.Split('|')[0];
            chaveNota = keyString.Split('|')[1];
            numeroLote = keyString.Split('|')[2];
        }
    }
}
