using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                string connectionString = "Data Source=MyOracleDB; User Id=username; Password=password; Integrated Security=no;";
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
