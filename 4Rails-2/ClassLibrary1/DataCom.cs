using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace _4Rails_2
{
    public static class DataCom
    {
        private static OracleConnection connection;
        public static OracleConnection Connection { get { return connection; } }
        private static OracleCommand command;
        private static OracleDataReader reader;

        public static void ConnectToDB()
        {
            try
            {
            //TODO: change username and passowrd
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora))); User Id=dbi317853; Password=qJKLqFc7Sh";
                connection = new OracleConnection(connectionString);
                connection.Open();
            }
            catch(Exception) { }
        }

        private static void Close()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception) { }
        }

        public static void nonQuery(string sql)
        {
            ConnectToDB();
            if (connection.State != System.Data.ConnectionState.Open)
                return;

            command = new OracleCommand(sql);
            command.ExecuteNonQuery();

            Close();
        }

        public static string Read(string sql, string columnName)
        {
            ConnectToDB();
            if (connection.State != System.Data.ConnectionState.Open)
                return null;

            command = new OracleCommand(sql);
            reader = command.ExecuteReader();

            string returnstring = "";
            while (reader.Read())
            {
                returnstring = Convert.ToString(reader[columnName]);
            }

            Close();
            if (returnstring != "" || returnstring != null)
                return returnstring;
            return null;
        }
    }
}
