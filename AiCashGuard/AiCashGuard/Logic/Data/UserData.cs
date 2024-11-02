using AiCashGuard.Logic.Data.Base;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AiCashGuard.Logic.Data
{
    public class UserData : ActionHandler
    {
        //create a method to authenticate user password
        public string AuthenticateUser(string userName, string password)
        {
            strSQL = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "userName", SqlDbType = SqlDbType.VarChar, Value = userName },
                new SqlParameter() { ParameterName = "Password", SqlDbType = SqlDbType.VarChar, Value = password },
            };

            DataTable data = RetrieveSqlDataTable();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["name"] is DBNull))
                        return data.Rows[0]["name"].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
