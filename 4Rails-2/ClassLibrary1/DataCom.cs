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
        /// <summary>
        /// DO NOT USE! Only public for unit test.
        /// </summary>
        public static OracleConnection Connection { get { return connection; } }
        private static OracleCommand command;
        private static OracleDataReader reader;

        /// <summary>
        /// DO NOT USE! Only public for unit test.
        /// </summary>
        public static void ConnectToDB()
        {
            try
            {
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

            command = new OracleCommand(sql, connection);
            try { command.ExecuteNonQuery(); }
            catch(Exception) { }

            Close();
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string groupby, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string groupby, string orderby, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The columns you want as returnvalue</param>
        /// <returns></returns>
        public static string[] Read(string select, string from, string where, string[] columnNames)
        {
            string[] returnvalue = new string[columnNames.Count()];
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where;

            for (int i = 0; i < columnNames.Count(); i++)
            {
                returnvalue[i] = Read(sql, columnNames[i]);
            }

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <param name="columnName">The columns you want as returnvalue</param>
        /// <returns></returns>
        public static string[] Read(string select, string from, string where, string groupby, string[] columnNames)
        {
            string[] returnvalue = new string[columnNames.Count()];
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby;

            for (int i = 0; i < columnNames.Count(); i++)
            {
                returnvalue[i] = Read(sql, columnNames[i]);
            }

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <param name="orderby"></param>
        /// <param name="columnName">The columns you want as returnvalue</param>
        /// <returns></returns>
        public static string[] Read(string select, string from, string where, string groupby, string orderby, string[] columnNames)
        {
            string[] returnvalue = new string[columnNames.Count()];
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;

            for (int i = 0; i < columnNames.Count(); i++)
            {
                returnvalue[i] = Read(sql, columnNames[i]);
            }

            return returnvalue;
        }

        private static string Read(string sql, string columnName)
        {
            ConnectToDB();
            if (connection.State != System.Data.ConnectionState.Open)
                return null;

            command = new OracleCommand(sql, connection);
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception) { Close(); return null; }

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
