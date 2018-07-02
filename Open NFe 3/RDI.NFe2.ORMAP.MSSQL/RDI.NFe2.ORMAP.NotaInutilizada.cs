using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using RDI.Lince;


namespace RDI.NFe2.ORMAP
{
    public class NotaInutilizada : BusinessObject
    {
        private String _numeroNota;
        private String _serieNota;
        private DateTime _data;
        private String _empresa;
        private String _XMLPedido;
        private String _XMLResposta;
        
        public String empresa
        {
            get { return _empresa; }
            set { SetIfChanged(ref _empresa, value); }
        }
        public String numeroNota
        {
            get { return _numeroNota; }
            set { SetIfChanged(ref _numeroNota, value); }
        }
        public String serieNota
        {
            get { return _serieNota; }
            set { SetIfChanged(ref _serieNota, value); }
        }
        public DateTime data
        {
            get { return _data; }
            set { SetIfChanged(ref _data, value); }
        }

        public String XMLPedido
        {
            get { return _XMLPedido; }
            set { SetIfChanged(ref _XMLPedido, value); }
        }

        public String XMLResposta
        {
            get { return _XMLResposta; }
            set { SetIfChanged(ref _XMLResposta, value); }
        }

        public override DALObject GetDAL()
        {
            return NotaInutilizadaDAL.Instance;
        }

        public override string GetKeyString()
        {
            return String.Format("{0}|{1}|{2}", empresa, numeroNota, serieNota);
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

    public class NotaInutilizadaDAL : DALObject
    {
        static private NotaInutilizadaDAL _instance;
        static public NotaInutilizadaDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NotaInutilizadaDAL();
                return _instance;
            }
        }
        protected override void CreateInsertParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaInutilizada nota = (NotaInutilizada)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@Data", System.Data.DbType.DateTime, nota.data);
            DALObject.CreateParameter(cmd, "@XMLResposta", System.Data.DbType.String, nota.XMLResposta);
            DALObject.CreateParameter(cmd, "@XMLPedido", System.Data.DbType.String, nota.XMLPedido);
        }
        protected override void CreateKeyParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaInutilizada nota = (NotaInutilizada)businessObject;
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, nota.empresa);
            DALObject.CreateParameter(cmd, "@NumeroNota", System.Data.DbType.String, nota.numeroNota);
            DALObject.CreateParameter(cmd, "@SerieNota", System.Data.DbType.String, nota.serieNota);

        }
        protected override void CreateUpdateParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            NotaInutilizada nota = (NotaInutilizada)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@Data", System.Data.DbType.DateTime, nota.data);
            DALObject.CreateParameter(cmd, "@XMLResposta", System.Data.DbType.String, nota.XMLResposta);
            DALObject.CreateParameter(cmd, "@XMLPedido", System.Data.DbType.String, nota.XMLPedido);
        }
        protected override void DataReaderToPersistentObject(System.Data.IDataReader dataReader, BusinessObject businessObject, string radical)
        {
            NotaInutilizada nota = (NotaInutilizada)businessObject;
            nota.BeginInit();
            try
            {
                nota.empresa = Utils.FieldAsString(dataReader, "CNPJ");
                nota.numeroNota = Utils.FieldAsString(dataReader, "numeroNota");
                nota.serieNota = Utils.FieldAsString(dataReader, "SerieNota");
                nota.data = Utils.FieldAsDateTime(dataReader, "data");
                nota.XMLPedido = Utils.FieldAsString(dataReader, "XMLPedido");
                nota.XMLResposta = Utils.FieldAsString(dataReader, "XMLResposta");

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
            return typeof(NotaInutilizadaQry);
        }
        protected override Type GetPersistentObjectType()
        {
            return typeof(NotaInutilizada);
        }
        protected override string GetInsertStatement()
        {
            return @"INSERT INTO NotasInutilizadas(NumeroNota,SerieNota, Data, CNPJ, XMLPedido, XMLResposta)
                          VALUES(@NumeroNota, @SerieNota, @Data, @CNPJ, @XMLPedido, @XMLResposta)";
        }
        protected override string GetUpdateStatement()
        {
            return @"UPDATE NotasInutilizadas
                        SET data = @data,
                            XMLPedido = @XMLPedido, 
                            XMLResposta = @XMLResposta
                      WHERE NumeroNota = @NumeroNota
                        AND CNPJ = @CNPJ
                        AND SerieNota = @SerieNota";
        }
        protected override string GetDeleteStatement()
        {
            throw new Exception("Esse Registro não pode ser Excluído.");
        }
        protected override string GetSelectStatement()
        {
            return $@"SELECT NumeroNota, SerieNota, Data, CNPJ, XMLPedido, XMLResposta
                       FROM NotasInutilizadas
                        {Conexao.whereAuto}
                        {Conexao.orderBy}";
        }
        protected override string GetEntityName()
        {
            return "NotasInutilizadas";
        }

 
    }

    public class NotaInutilizadaQry : QueryObject
    {
        public NotaInutilizadaQry() : base(System.String.Empty) { }
        private String _numeroNota;
        private String _serieNota;
        private DateTime _dataInicial;
        private DateTime _dataFinal;
        public Boolean FilterByDate = false;

        private String _empresa;

        public String numeroNota
        {
            get { return _numeroNota; }
            set { _numeroNota = value; }
        }
        public String serieNota
        {
            get { return _serieNota; }
            set { _serieNota = value; }
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
        public String empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        public override void CreateParameters(System.Data.IDbCommand cmd)
        {
            if (numeroNota != null)
                DALObject.CreateParameter(cmd, "@numeroNota", System.Data.DbType.String, numeroNota);

            if (serieNota != null)
                DALObject.CreateParameter(cmd, "@serieNota", System.Data.DbType.String, serieNota);

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
            if (numeroNota != null)
                handler.handleSQLAppendWhere(prefix + "numeroNota = @numeroNota");
            if (serieNota != null)
                handler.handleSQLAppendWhere(prefix + "serieNota = @serieNota");
            if (empresa != null)
                handler.handleSQLAppendWhere(prefix + "CNPJ = @CNPJ");

            if (FilterByDate)
            {
                if (dataInicial.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "Data >= @dataInicial");
                if (dataFinal.ToShortDateString() != "01/01/0001")
                    handler.handleSQLAppendWhere(prefix + "Data <= @dataFinal");
                handler.handleSQLAppendOrderBy("order by Data");
            }
        }
        public override void SetKey(BusinessObject businessObject)
        {
            NotaInutilizada nota = (NotaInutilizada)businessObject;
            numeroNota = nota.numeroNota;
            empresa = nota.empresa;
            serieNota = nota.serieNota;
        }
        public override void SetKey(string keyString)
        {
            empresa = keyString.Split('|')[0];
            numeroNota = keyString.Split('|')[1];
            serieNota = keyString.Split('|')[2];
        }
    }
}
