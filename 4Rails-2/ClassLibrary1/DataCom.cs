using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace ClassLibrary1
{
    public static class DataCom
    {
        private static OracleConnection connection;
        private static OracleCommand command;
        private static OracleDataReader reader;

        private static void ConnectToDB()
        {
            string connectionString = "";
            connection = new OracleConnection(connectionString);
            connection.Open();
        }

        public static void nonQuery(string sql)
        {
            ConnectToDB();

            command = new OracleCommand(sql);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public static string Read(string sql, string columnName)
        {
            ConnectToDB();

            command = new OracleCommand(sql);
            reader = command.ExecuteReader();

            string returnstring = "";
            while (reader.Read())
            {
                returnstring = Convert.ToString(reader[columnName]);
            }

            connection.Close();
            if (returnstring != "" || returnstring != null)
                return returnstring;
            return null;
        }
    }
}
