using System;
using System.Collections.Generic;
using System.Text;
using RDI.Lince;

namespace RDI.NFe2.ORMAP
{
    public class Log : BusinessObject
    {
        private String _empresa;
        private Int32 _codigoSituacao;
        private String _descricaoSituacao;
        private DateTime _data;
        private NotaFiscal _nota;
        private Int32 _numero;

        public Int32 numero
        {
            get { return _numero; }
            set { SetIfChanged(ref _numero, value); }
        }

        public String empresa
        {
            get { return _empresa; }
            set { SetIfChanged(ref _empresa, value); }
        }

        public Int32 codigoSituacao
        {
            get { return _codigoSituacao; }
            set { SetIfChanged(ref _codigoSituacao, value); }
        }

        public String descricaoSituacao
        {
            get { return _descricaoSituacao; }
            set { SetIfChanged(ref _descricaoSituacao, value); }
        }

        public DateTime data
        {
            get { return _data; }
            set { SetIfChanged(ref _data, value); }
        }

        public NotaFiscal nota
        {
            get { return _nota; }
            set { _nota = value; }
        }
        
        public String chaveNota
        {
            get { return nota.chaveNota; }
        }

        public override DALObject GetDAL()
        {
            return LogDAL.Instance;
        }

        public override string GetKeyString()
        {
            throw new Exception("The method or operation is not implemented.");
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

    public class LogDAL : DALObject
    {
        static private LogDAL _instance;
        static public LogDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LogDAL();
                return _instance;
            }
        }
        protected override void CreateInsertParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Log oLog = (Log)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, oLog.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DataLog", System.Data.DbType.DateTime, oLog.data);
            DALObject.CreateParameter(cmd, "@DescricaoSituacao", System.Data.DbType.String, oLog.descricaoSituacao);
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, oLog.empresa);
            DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, oLog.chaveNota);
        }
        protected override void CreateKeyParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Log oLog = (Log)businessObject;
            DALObject.CreateParameter(cmd, "@NumeroLog", System.Data.DbType.Int32, oLog.numero);
        }
        protected override void CreateUpdateParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Log oLog = (Log)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@CodigoSituacao", System.Data.DbType.Int32, oLog.codigoSituacao);
            DALObject.CreateParameter(cmd, "@DataLog", System.Data.DbType.DateTime, oLog.data);
            DALObject.CreateParameter(cmd, "@DescricaoSituacao", System.Data.DbType.String, oLog.descricaoSituacao);
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, oLog.empresa);
            DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, oLog.chaveNota);
        }
        protected override void DataReaderToPersistentObject(System.Data.IDataReader dataReader, BusinessObject businessObject, string radical)
        {
            Log oLog = (Log)businessObject;
            oLog.BeginInit();
            try
            {
                NotaFiscal nota = new NotaFiscal();
                nota.chaveNota = Utils.FieldAsString(dataReader, "ChaveNota");
                oLog.nota = nota;
                nota = null;

                oLog.codigoSituacao = Utils.FieldAsInt32(dataReader, "CodigoSituacao");
                oLog.data = Utils.FieldAsDateTime(dataReader, "DataLog");
                oLog.descricaoSituacao = Utils.FieldAsString(dataReader, "DescricaoSituacao");
                oLog.empresa = Utils.FieldAsString(dataReader, "CNPJ");
                oLog.numero = Utils.FieldAsInt32(dataReader, "NumeroLog");

                oLog.isRecorded = true;
                oLog.isModified = false;
            }
            finally
            {
                oLog.EndInit();
            }

        }
        protected override Type GetCollectorType()
        {
            return typeof(LogQRY);
        }
        protected override Type GetPersistentObjectType()
        {
            return typeof(Log);
        }
        protected override string GetInsertStatement()
        {
            return @"INSERT INTO LOG(ChaveNota, CodigoSituacao, DescricaoSituacao, CNPJ, DataLog)
                          VALUES(@ChaveNota, @CodigoSituacao, @DescricaoSituacao, @CNPJ, @DataLog)";
        }
        protected override string GetUpdateStatement()
        {
            throw new Exception("Não é possível fazer update na classe Log");
        }
        protected override string GetDeleteStatement()
        {
            throw new Exception("Não é possível fazer delete na classe Log");
        }
        protected override string GetSelectStatement()
        {
            return @"SELECT ChaveNota, CodigoSituacao, DescricaoSituacao, CNPJ, DataLog, NumeroLog
                       FROM LOG
                        --<where auto>--
                        --<orderby>--";
        }
        protected override string GetEntityName()
        {
            return "LOG";
        }
    }

    public class LogQRY : QueryObject
    {
        public LogQRY() : base(System.String.Empty) { }
        private String _chaveNota;
        private String _empresa;
        private DateTime _dataInicial;
        private DateTime _dataFinal;
        public Boolean FilterByDate = false;

        public String chaveNota
        {
            get { return _chaveNota; }
            set { _chaveNota = value; }
        }
        public String empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
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

        public override void CreateParameters(System.Data.IDbCommand cmd)
        {
            if (chaveNota != null)
                DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, "%"+chaveNota+"%");
            if (empresa != null)
                DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, empresa);
            if (FilterByDate)
            {
                if (dataInicial.ToShortDateString() != "01/01/0001")
                    DALObject.CreateParameter(cmd, "@dataInicial", System.Data.DbType.DateTime, dataInicial);
                if (dataFinal.ToShortDateString() != "01/01/0001")
                    DALObject.CreateParameter(cmd, "@dataFinal", System.Data.DbType.DateTime,
                        dataFinal.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999));
            }
        }
        public override void ModifySQL(SQLUtils handler)
        {
            if (chaveNota != null)
                handler.handleSQLAppendWhere(prefix + "ChaveNota like @ChaveNota");
            if (empresa != null)
                handler.handleSQLAppendWhere(prefix + "CNPJ = @CNPJ");
            if (FilterByDate)
            {
                if (dataInicial.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "dataLog >= @dataInicial");
                if (dataFinal.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "dataLog <= @dataFinal");
                handler.handleSQLAppendOrderBy("order by datalog");
            }

        }
        public override void SetKey(BusinessObject businessObject)
        {
            Log oLog = (Log)businessObject;
            chaveNota = oLog.nota.chaveNota;
            empresa = oLog.empresa;
        }
        public override void SetKey(string keyString)
        {
            chaveNota = keyString.Split('|')[0];
            empresa = keyString.Split('|')[1];
        }


    }
}
