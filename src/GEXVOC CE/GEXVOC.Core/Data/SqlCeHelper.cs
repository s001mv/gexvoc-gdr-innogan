using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace GEXVOC.Core.Data
{
    public class SqlCeHelper
    {

        static SqlCeConnection GetSqlCeConnection()
        {
            string ConnectionString = GEXVOC.Core.Logic.Configurador.CSLocal;

            return new  SqlCeConnection(ConnectionString);
        }

        public static DataSet ExecuteQuery(string query)
        {
            DataSet ds = new DataSet();
            SqlCeConnection conn;
            try
            {

                using (conn = GetSqlCeConnection())
                {
                    using (SqlCeDataAdapter da = new SqlCeDataAdapter(query, conn))
                    {
                        conn.Open();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            SqlCeConnection conn;
            try
            {
                using (conn = GetSqlCeConnection())
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object ExecuteScalar(string query)
        {
            SqlCeConnection conn;
            try
            {
                using (conn = GetSqlCeConnection())
                {
                    using (SqlCeCommand cmd = new SqlCeCommand(query, conn))
                    {
                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
