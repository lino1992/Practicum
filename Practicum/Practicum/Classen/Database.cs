using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle;
using System.Data;

namespace Practicum.Classen
{
    public static class Database
    {
        static private OracleConnection conn;
        
        static public string connectionstring = "Data Source=//localhost:1521/xe; User ID=system; Password=Thailand55;";
        /// <summary>
        /// deze methode is open van database connection
        /// </summary>
        static public OracleConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new OracleConnection(connectionstring);
                    conn.Open();
                }
                return conn;
            }
        }
        /// <summary>
        /// deze methode wordt gebruikt lezen van data wanneer een select statement wordt gebruikt.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        static public OracleDataReader readdata(string sql)
        {
            OracleCommand c = new OracleCommand(sql, Conn);
            OracleDataReader r = c.ExecuteReader();
            return r;

        }
        static public OracleCommand insert(string sql)
        {
            OracleCommand c = new OracleCommand(sql, Conn);
            c.CommandType = CommandType.Text;
            return c;
        }
        /// <summary>
        /// deze methode is bedoel voor het uitvoeren van een insert sql statement
        /// </summary>
        /// <param name="set"></param>
        public static void excute(OracleCommand set)
        {
            try
            {
                set.Connection = Conn;
                set.ExecuteNonQuery();
            }
            finally
            {
                Conn.Close();
            }
        }
        /// <summary>
        /// deze methode is voor het aanroepen van stored procedure van pl/sql
        /// </summary>
        /// <param name="plsql"></param>
        /// <returns></returns>
        static public OracleCommand storedprocedure(string plsql)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = Conn;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = plsql;
            return c;
        }
        
    }
}