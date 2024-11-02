using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AiCashGuard.Logic.Data.Base
{
    public class ActionHandler
    {
        public string strSQL { get; set; }
        public string cmdType { get; set; }  //will either be stored procedure or text.

        public List<SqlParameter> sqlParams { get; set; }
        public int rowsReturned { get; set; }

        public static bool useReadOnlyConn;

        public static string GetDefaultConnectionString()
        {
            return "Server=ALISHAH\\SQLEXPRESS;Database=AiCashGuard;Integrated Security=True;TrustServerCertificate=True;";
        }

        public static string GetReadOnlyConnectionString()
        {
            return "Server=ALISHAH\\SQLEXPRESS;Database=AiCashGuard;Integrated Security=True;TrustServerCertificate=True;";
        }

        public string CheckReadOnlyConnectionString()
        {
            string strDBCon = string.Empty;
            try
            {
                string ReadOnlyConn = string.Empty;
                if (!useReadOnlyConn || string.IsNullOrEmpty(ReadOnlyConn = GetReadOnlyConnectionString()))
                {
                    strDBCon = GetDefaultConnectionString();
                }
                else
                {
                    strDBCon = ReadOnlyConn;
                    var conn = new SqlConnection(strDBCon);
                    conn.Open();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                useReadOnlyConn = false;
                strDBCon = GetDefaultConnectionString();
            }

            return strDBCon;
        }

        public DataTable RetrieveSqlDataTable()
        {
            try
            {
                string strDB = CheckReadOnlyConnectionString();

                using (SqlConnection conn = new SqlConnection(strDB))
                using (SqlCommand command = new SqlCommand(strSQL, conn))
                {
                    CommandType ct = CommandType.Text;
                    if (cmdType == "stored_procedure")
                        ct = CommandType.StoredProcedure;

                    command.CommandTimeout = 0;
                    command.CommandType = ct;
                    if (sqlParams != null && sqlParams.Count > 0)
                        command.Parameters.AddRange(sqlParams.ToArray());

                    conn.Open();
                    DataTable dt = new DataTable();

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        dt.Load(dataReader);
                    }
                    
                    return dt;
                }
            }
            catch (Exception)
            { throw; }

        }

        public int ExecuteQuery()
        {
            try
            {
                var strDBConn = CheckReadOnlyConnectionString();

                using (SqlConnection connection = new SqlConnection(strDBConn))
                using (SqlCommand command = new SqlCommand(strSQL, connection))
                {
                    CommandType ct = CommandType.Text;
                    if (cmdType == "stored_procedure")
                        ct = CommandType.StoredProcedure;

                    command.CommandTimeout = 0;
                    command.CommandType = ct;


                    if (sqlParams != null && sqlParams.Count > 0)
                        command.Parameters.AddRange(sqlParams.ToArray());

                    connection.Open();

                    int rowsReturned = command.ExecuteNonQuery();

                    command.Parameters.Clear();

                    return rowsReturned;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object ExecuteScalar()
        {
            try
            {
                var strDBConn = CheckReadOnlyConnectionString();
                using (SqlConnection connection = new SqlConnection(strDBConn))
                using (SqlCommand command = new SqlCommand(strSQL, connection))
                {
                    CommandType ct = CommandType.Text;
                    if (cmdType == "stored_procedure")
                        ct = CommandType.StoredProcedure;

                    command.CommandTimeout = 0;
                    command.CommandType = ct;


                    if (sqlParams != null && sqlParams.Count > 0)
                        command.Parameters.AddRange(sqlParams.ToArray());

                    connection.Open();
                    var record = command.ExecuteScalar();

                    command.Parameters.Clear();
                    return record;
                }
            }

            catch (Exception)
            { throw; }
        }
    }
}
