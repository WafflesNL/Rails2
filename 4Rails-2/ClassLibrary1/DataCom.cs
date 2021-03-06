﻿using System;
using System.Data;
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DO NOT USE! Only public for unit test.
        /// </summary>
        public static void Close()
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Close();
        }

        public static string getCount()
        {
            string sql = "Select Count(*) from Regeling";
            
            return Read(sql);
        }
        /// <summary>
        /// Used to read 1 value
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

            return Read(sql);
        }

        /// <summary>
        /// Used to read 1 value
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

            return Read(sql); ;
        }

        /// <summary>
        /// Used to read 1 value
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

            return Read(sql); ;
        }

        /// <summary>
        /// Used to read 1 value
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

            return Read(sql); ;
        }

        /// <summary>
        /// Used to read 1 rows and multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        public static string[] ReadRow(string select, string from)
        {
            string[] returnvalue;

            string sql = "SELECT " + select + " FROM " + from;

            returnvalue = ReadAll(sql)[0];

            return returnvalue;
        }

        /// <summary>
        /// Used to read 1 rows and multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static string[] ReadRow(string select, string from, string where)
        {
            string[] returnvalue;

            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where;

            returnvalue = ReadAll(sql)[0];

            return returnvalue;
        }

        /// <summary>
        /// Used to read 1 rows and multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <returns></returns>
        public static string[] ReadRow(string select, string from, string where, string groupby)
        {
            string[] returnvalue;

            string sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby;

            returnvalue = ReadAll(sql)[0];

            return returnvalue;
        }

        /// <summary>
        /// Used to read 1 rows and multiple columns
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public static string[] ReadRow(string select, string from, string where, string groupby, string orderby)
        {
            string[] returnvalue;

            string sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;

            returnvalue = ReadAll(sql)[0];

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns and rows
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from)
        {
            List<string[]> returnvalue = new List<string[]>();

            string sql = "SELECT " + select + " FROM " + from;

            returnvalue = ReadAll(sql);

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns and or rows
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where)
        {
            List<string[]> returnvalue = new List<string[]>();

            string sql = "SELECT " + select + " FROM " + from + " WHERE " + where;

            returnvalue = ReadAll(sql);

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns and rows
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where, string groupby)
        {
            List<string[]> returnvalue = new List<string[]>();

            string sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby;

            returnvalue = ReadAll(sql);

            return returnvalue;
        }

        /// <summary>
        /// Used to read multiple columns and rows
        /// </summary>
        /// <param name="select"></param>
        /// <param name="from"></param>
        /// <param name="where"></param>
        /// <param name="groupby"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public static List<string[]> ReadAll(string select, string from, string where, string groupby, string orderby)
        {
            List<string[]> returnvalue = new List<string[]>();

            string sql = "SELECT " + select + " FROM " + from + " Where " + where + " GROUP BY " + groupby + " ORDER BY " + orderby;

            returnvalue = ReadAll(sql);

            return returnvalue;
        }

        private static List<string[]> ReadAll(string sql)
        {
            ConnectToDB();

            if (connection.State != ConnectionState.Open)
                return null;

            List<string[]> returnlist = new List<string[]>();
            string[] returnstring;

            OracleDataAdapter da = new OracleDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            
            da.Fill(dataTable);
            foreach(DataRow row in dataTable.Rows)
            {
                returnstring = new string[dataTable.Columns.Count];
                for (int i = 0; i < row.ItemArray.Count(); i++)
                    returnstring[i] = row.ItemArray[i].ToString();
                returnlist.Add(returnstring);
            }

            Close();

            return returnlist;
        }

        private static string Read(string sql)
        {
            ConnectToDB();
            if (connection.State != ConnectionState.Open)
                return null;

            string returnstring = null;

            OracleDataAdapter da = new OracleDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();

            da.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                returnstring = row.ItemArray[0].ToString();
            }

            Close();

            return returnstring;
        }
    }
}
