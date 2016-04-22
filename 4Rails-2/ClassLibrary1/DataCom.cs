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

        private enum TableColumnCount
        {
            Cleaning_Schedule = 5,
            Mechanic_Schedule = 5,
            Rail = 3,
            Regulation = 3,
            Sector = 2,
            Tram = 4,
            User_ = 8,
        };

        private static TableColumnCount tcc;

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
        /// <param name="columnName">The column you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static string Read(string select, string from, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from;
            if (columnName == null)
                columnName = select;

            return Read(sql, columnName);
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where;
            if (columnName == null)
                columnName = select;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string groupby, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby;
            if (columnName == null)
                columnName = select;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read 1 column
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The column you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static string Read(string select, string from, string where, string groupby, string orderby, string columnName)
        {
            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;
            if (columnName == null)
                columnName = select;

            return Read(sql, columnName); ;
        }

        /// <summary>
        /// Used to read multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="columnNames">The columns you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string[] columnNames)
        {
            List<string[]> returnvalue = new List<string[]>();
            string[] tempvalue;

            string sql = "SELECT COUNT(*) FROM " + from;
            int amount = Convert.ToInt16(Read(sql, null));

            sql = "SELECT " + select + " FROM " + from;

            if (columnNames == null)
                columnNames = SetColumnNames(select, from);

            tempvalue = new string[columnNames.Count()];

            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < columnNames.Count(); i++)
                {
                    tempvalue[i] = Read(sql, columnNames[i]);
                }
                returnvalue.Add(tempvalue);
            }

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="columnName">The columns you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where, string[] columnNames)
        {
            List<string[]> returnvalue = new List<string[]>();
            string[] tempvalue;

            string sql = "SELECT COUNT(*) FROM " + from + " WHERE " + where;
            int amount = Convert.ToInt16(Read(sql, null));

            sql = "SELECT " + select + " FROM " + from + " Where " + where;

            if (columnNames == null)
                columnNames = SetColumnNames(select, from);

            tempvalue = new string[columnNames.Count()];

            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < columnNames.Count(); i++)
                {
                    tempvalue[i] = Read(sql, columnNames[i]);
                }
                returnvalue.Add(tempvalue);
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
        /// <param name="columnName">The columns you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where, string groupby, string[] columnNames)
        {
            List<string[]> returnvalue = new List<string[]>();
            string[] tempvalue;

            string sql = "SELECT COUNT(*) FROM " + from + " WHERE " + where + " GROUP BY " + groupby;
            int amount = Convert.ToInt16(Read(sql, null));

            sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby;

            if (columnNames == null)
                columnNames = SetColumnNames(select, from);

            tempvalue = new string[columnNames.Count()];

            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < columnNames.Count(); i++)
                {
                    tempvalue[i] = Read(sql, columnNames[i]);
                }
                returnvalue.Add(tempvalue);
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
        /// <param name="columnName">The columns you want as returnvalue, if null uses select</param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where, string groupby, string orderby, string[] columnNames)
        {
            List<string[]> returnvalue = new List<string[]>();
            string[] tempvalue;

            string sql = "SELECT COUNT(*) FROM " + from + " WHERE " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;
            int amount = Convert.ToInt16(Read(sql, null));

            sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;

            if (columnNames == null)
                columnNames = SetColumnNames(select, from);

            tempvalue = new string[columnNames.Count()];

            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < columnNames.Count(); i++)
                {
                    tempvalue[i] = Read(sql, columnNames[i]);
                }
                returnvalue.Add(tempvalue);
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
                if (columnName == null)
                    returnstring = Convert.ToString(reader[0]);
                else if (columnName.Contains("."))
                {
                    columnName = columnName.Split('.')[1];
                    returnstring = Convert.ToString(reader[columnName]);
                }
                else
                    returnstring = Convert.ToString(reader[columnName]);
            }

            Close();
            if (returnstring != "" || returnstring != null)
                return returnstring;
            return null;
        }

        private static string[] SetColumnNames(string select, string from)
        {
            string[] columnNames;

            switch (from)
            {
                case "Cleaning_Schedule":
                    tcc = TableColumnCount.Cleaning_Schedule;
                    break;
                case "Mechanic_Schedule":
                    tcc = TableColumnCount.Mechanic_Schedule;
                    break;
                case "Rail":
                    tcc = TableColumnCount.Rail;
                    break;
                case "Regulation":
                    tcc = TableColumnCount.Regulation;
                    break;
                case "Sector":
                    tcc = TableColumnCount.Sector;
                    break;
                case "Tram":
                    tcc = TableColumnCount.Tram;
                    break;
                case "User_":
                    tcc = TableColumnCount.User_;
                    break;
                default:
                    tcc = TableColumnCount.User_;
                    break;
            }
            
            columnNames = new string[(int)tcc];
            string temp = select;
            temp.Replace(" ", "");
            int counter = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp.Substring(i, 1) == ",")
                {
                    columnNames[counter] = temp.Substring(0, i);
                    counter++;
                    temp = temp.Remove(0, i + 1);
                    i = 0;
                }
                else if (i == temp.Length - 1)
                    columnNames[counter] = temp;
            }

            columnNames = columnNames.Where(c => c != null).ToArray();

            return columnNames;
        }
    }
}
