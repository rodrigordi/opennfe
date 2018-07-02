using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RDI.Lince;

namespace RDI.NFe2.ORMAP
{
    public static class Conexao
    {
        private static DataBaseType dbType = DataBaseType.SQLSERVER;
        public static string whereAuto => dbType == DataBaseType.SQLSERVER ? "--<where auto>--" : "-- where auto --";
        public static string where_i => dbType == DataBaseType.SQLSERVER ? "--<where i>--" : "-- where i --";
        public static string orderBy => dbType == DataBaseType.SQLSERVER ? "--<orderby>--" : "-- orderby --";
        public static string isnull => dbType == DataBaseType.SQLSERVER ? "isnull" : "ifnull";

        static public ClientEnvironment CreateManager(String ConAux)
        {
            //Conexao com banco de dados
            ClientEnvironment globalManager = new RDI.Lince.ClientEnvironment(dbType);
            System.Data.SqlClient.SqlConnection globalConn = new System.Data.SqlClient.SqlConnection();
            globalConn.ConnectionString = ConAux;
            globalConn.Open();
            globalManager.connection = globalConn;

            return globalManager;
        }

        static public void DisposeManager(ClientEnvironment manager)
        {
            if (manager != null && manager.connection != null && manager.connection.State == System.Data.ConnectionState.Open)
            {
                manager.connection.Close();
            }
        }
    }
}
