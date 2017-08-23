using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using RDI.Lince;
using RDI.NFe2.SchemaXML.NFe_v200;
using RDI.NFe2.SchemaXML;


namespace RDI.NFe2.ORMAP
{
    public class Evento : BusinessObject
    {
        private String _empresa;
        private String _chaveNota;
        private Int32 _numeroLote;
        private Int32 _id;

        private TEventoInfEventoTpEvento _tpEvento;
        private String _XMLPedido;
        private String _XMLResposta;
        private TipoSituacaoEvento _codigoSituacao;


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
        public Int32 id
        {
            get { return _id; }
            set { SetIfChanged(ref _id, value); }
        }

        public TEventoInfEventoTpEvento tpEvento
        {
            get { return _tpEvento; }
            set
            {
                if (_tpEvento != value)
                {
                    isModified = true;
                    _tpEvento = value;
                }
            }
        }

        /// <summary>
        /// TEvento
        /// </summary>
        public String XMLPedido
        {
            get { return _XMLPedido; }
            set { SetIfChanged(ref _XMLPedido, value); }
        }

        /// <summary>
        /// TRetEnvEvento
        /// </summary>
        public String XMLResposta
        {
            get { return _XMLResposta; }
            set { SetIfChanged(ref _XMLResposta, value); }
        }
        public TipoSituacaoEvento codigoSituacao
        {
            get { return _codigoSituacao; }
            set
            {
                if (_codigoSituacao != value)
                {
                    isModified = true;
                    _codigoSituacao = value;
                }
            }
        }

        public String descSituacao
        {
            get { return Utils.ObterDescricao(codigoSituacao); }
        }

        public String descTpEvento
        {
            get { return Utils.ObterDescricao(tpEvento); }
        }

        public override DALObject GetDAL()
        {
            return EventoDAL.Instance;
        }

        public override string GetKeyString()
        {
            return String.Format("{0}|{1}|{2}|{3}", empresa, chaveNota, numeroLote, id);
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

    public class EventoDAL : DALObject
    {
        static private EventoDAL _instance;
        static public EventoDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EventoDAL();
                return _instance;
            }
        }
        protected override void CreateInsertParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Evento oEvento = (Evento)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@situacao", System.Data.DbType.Int32, oEvento.codigoSituacao);
            DALObject.CreateParameter(cmd, "@tpEvento", System.Data.DbType.Int32, oEvento.tpEvento);
            DALObject.CreateParameter(cmd, "@xmlProcesso", System.Data.DbType.String, oEvento.XMLResposta);
            DALObject.CreateParameter(cmd, "@XMLPedido", System.Data.DbType.String, oEvento.XMLPedido);
        }
        protected override void CreateKeyParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Evento oEvento = (Evento)businessObject;
            DALObject.CreateParameter(cmd, "@CNPJ", System.Data.DbType.String, oEvento.empresa);
            DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, oEvento.chaveNota);
            DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.Int32, oEvento.numeroLote);
            DALObject.CreateParameter(cmd, "@ID", System.Data.DbType.Int32, oEvento.id);

        }
        protected override void CreateUpdateParameters(BusinessObject businessObject, System.Data.IDbCommand cmd)
        {
            Evento oEvento = (Evento)businessObject;

            CreateKeyParameters(businessObject, cmd);
            DALObject.CreateParameter(cmd, "@situacao", System.Data.DbType.Int32, oEvento.codigoSituacao);
            DALObject.CreateParameter(cmd, "@tpEvento", System.Data.DbType.Int32, oEvento.tpEvento);
            DALObject.CreateParameter(cmd, "@xmlProcesso", System.Data.DbType.String, oEvento.XMLResposta);
            DALObject.CreateParameter(cmd, "@XMLPedido", System.Data.DbType.String, oEvento.XMLPedido);
        }
        protected override void DataReaderToPersistentObject(System.Data.IDataReader dataReader, BusinessObject businessObject, string radical)
        {
            Evento oEvento = (Evento)businessObject;
            oEvento.BeginInit();
            try
            {
                oEvento.empresa = Utils.FieldAsString(dataReader, "CNPJ");
                oEvento.chaveNota = Utils.FieldAsString(dataReader, "chaveNota");
                oEvento.numeroLote = Utils.FieldAsInt32(dataReader, "numeroLote");
                oEvento.id = Utils.FieldAsInt32(dataReader, "id");

                oEvento.codigoSituacao = (TipoSituacaoEvento)Utils.FieldAsInt32(dataReader, "situacao");
                oEvento.tpEvento = (TEventoInfEventoTpEvento)Utils.FieldAsInt32(dataReader, "tpEvento");
                oEvento.XMLPedido = Utils.FieldAsString(dataReader, "XMLPedido");
                oEvento.XMLResposta = Utils.FieldAsString(dataReader, "xmlProcesso");

                oEvento.isRecorded = true;
                oEvento.isModified = false;
            }
            finally
            {
                oEvento.EndInit();
            }

        }
        protected override Type GetCollectorType()
        {
            return typeof(EventoQry);
        }
        protected override Type GetPersistentObjectType()
        {
            return typeof(Evento);
        }
        protected override string GetInsertStatement()
        {
            return @"INSERT INTO Eventos(NumeroLote
                                       ,CNPJ
                                       ,ChaveNota
                                       ,ID
                                       ,tpEvento
                                       ,xmlPedido
                                       ,xmlProcesso
                                       ,situacao)
                                VALUES(
                                        @NumeroLote
                                       ,@CNPJ
                                       ,@ChaveNota
                                       ,@ID
                                       ,@tpEvento
                                       ,@XMLPedido
                                       ,@xmlProcesso
                                       ,@situacao)";
        }
        protected override string GetUpdateStatement()
        {
            return @"UPDATE Eventos
                        SET situacao = @situacao,
                            tpEvento = @tpEvento,
                            XMLPedido = @XMLPedido, 
                            xmlProcesso = @xmlProcesso
                      WHERE NumeroLote = @NumeroLote
                        AND CNPJ = @CNPJ
                        AND ChaveNota = @ChaveNota
                        AND ID = @ID";
        }
        protected override string GetDeleteStatement()
        {
            throw new Exception("Esse Registro não pode ser Excluído.");
        }
        protected override string GetSelectStatement()
        {
            return @"SELECT NumeroLote
                           ,CNPJ
                           ,ChaveNota
                           ,ID
                           ,tpEvento
                           ,xmlPedido
                           ,xmlProcesso
                           ,situacao
                       FROM Eventos
                        --<where auto>--
                        --<orderby>--";
        }
        protected override string GetEntityName()
        {
            return "Eventos";
        }
        protected string GetMaxSelect()
        {
            return @"SELECT isnull (max(id),0) as ID
                       FROM Eventos
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


    }

    public class EventoQry : QueryObject
    {
        public EventoQry() : base(System.String.Empty) { }

        public String empresa { get; set; }
        public String chaveNota { get; set; }
        public String numeroLote { get; set; }
        public String id { get; set; }


        private DateTime _dataInicial;
        private DateTime _dataFinal;
        public Boolean FilterByDate = false;

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
            if (id != null)
                DALObject.CreateParameter(cmd, "@ID", System.Data.DbType.String, id);
            if (numeroLote != null)
                DALObject.CreateParameter(cmd, "@NumeroLote", System.Data.DbType.String, numeroLote);
            if (chaveNota != null)
                DALObject.CreateParameter(cmd, "@ChaveNota", System.Data.DbType.String, chaveNota);
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
            if (id != null)
                handler.handleSQLAppendWhere(prefix + "id = @ID");
            if (numeroLote != null)
                handler.handleSQLAppendWhere(prefix + "numeroLote = @NumeroLote");
            if (chaveNota != null)
                handler.handleSQLAppendWhere(prefix + "ChaveNota = @ChaveNota");
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
            Evento oEvento = (Evento)businessObject;
            empresa = oEvento.empresa;
            chaveNota = oEvento.chaveNota;
            numeroLote = oEvento.numeroLote.ToString();
            id = oEvento.id.ToString();
        }
        public override void SetKey(string keyString)
        {
            empresa = keyString.Split('|')[0];
            chaveNota = keyString.Split('|')[1];
            numeroLote = keyString.Split('|')[2];
            id = keyString.Split('|')[3];
        }
    }
}
