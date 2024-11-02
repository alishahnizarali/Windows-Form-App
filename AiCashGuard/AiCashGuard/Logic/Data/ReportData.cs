using AiCashGuard.Logic.Data.Base;
using System.Collections.Generic;
using System.Data;
using System;
using Microsoft.Data.SqlClient;
using AiCashGuard.Model.Internal.Report;

namespace AiCashGuard.Logic.Data
{
    public class ReportData : ActionHandler
    {
        //Get Transaction Report from start date to end date categorize with status
        public TransactionNumberModel GetTransactionReport(string startDate, string endDate)
        {
            useReadOnlyConn = true;

            strSQL = "SELECT COUNT(*) AS TotalTransactions, SUM(amount) AS TotalAmount, AVG(amount) AS AverageTransactionAmount " +
                "FROM Transactions WHERE transdateTime >= @StartDate AND transdateTime <= @EndDate; ";

            cmdType = "text";
            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "StartDate", SqlDbType = SqlDbType.DateTime, Value = Convert.ToDateTime(startDate) },
                new SqlParameter() { ParameterName = "EndDate", SqlDbType = SqlDbType.DateTime, Value = Convert.ToDateTime(endDate) }
            };

            DataTable data = RetrieveSqlDataTable();

            TransactionNumberModel response = new TransactionNumberModel();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["TotalTransactions"] is DBNull))
                        response.totalTransactions = Convert.ToInt32(data.Rows[0]["TotalTransactions"]);

                    if (!(data.Rows[0]["TotalAmount"] is DBNull))
                        response.totalAmount = Convert.ToDecimal(data.Rows[0]["TotalAmount"]);

                    if (!(data.Rows[0]["AverageTransactionAmount"] is DBNull))
                        response.averageAmount = Convert.ToDecimal(data.Rows[0]["AverageTransactionAmount"]);
                }

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void GetTransactionReportByStatus(ref TransactionNumberModel resp, string startDate, string endDate)
        {
            useReadOnlyConn = true;

            strSQL = "SELECT status, COUNT(*) AS NumberOfRows " +
                "FROM Transactions WHERE transdateTime >= @StartDate AND transdateTime <= @EndDate GROUP BY status ";

            cmdType = "text";
            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "StartDate", SqlDbType = SqlDbType.DateTime, Value = Convert.ToDateTime(startDate) },
                new SqlParameter() { ParameterName = "EndDate", SqlDbType = SqlDbType.DateTime, Value = Convert.ToDateTime(endDate) }
            };

            DataTable data = RetrieveSqlDataTable();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        if (!(row["status"] is DBNull))
                        {
                            if(Convert.ToInt32(row["status"]) == 0)
                                resp.numOfCleared = Convert.ToInt32(row["NumberOfRows"]);
                            if (Convert.ToInt32(row["status"]) == 1)
                                resp.numOfReturn = Convert.ToInt32(row["NumberOfRows"]);
                            if (Convert.ToInt32(row["status"]) == 2)
                                resp.numOfReturnCleared = Convert.ToInt32(row["NumberOfRows"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Last 12 Month Deposit Volume Report
        public string GetMonthlyDepositVolumeReport()
        {
            return "Monthly Deposit Volume Report";
        }

        //Last 12 Month Transaction Volume Report
        public string GetMonthlyTransactionVolumeReport()
        {
            return "Monthly Transaction Volume Report";
        }
    }
}
