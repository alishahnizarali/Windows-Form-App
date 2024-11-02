using AiCashGuard.Logic.Data.Base;
using AiCashGuard.Model.Internal.Transaction;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AiCashGuard.Logic.Data
{
    public class TransactionData : ActionHandler
    {
        //Get 5 recent transactions
        public List<RecentTransactions> GetRecentTransactions()
        {
            strSQL = "select top 5 id, checkdate, isdeposit, status, amount from Transactions order by id desc";

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            List<RecentTransactions> transactionList = new List<RecentTransactions>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        RecentTransactions trans = new RecentTransactions();

                        if (!(row["id"] is DBNull))
                            trans.transactionId = Convert.ToInt32(row["id"]);

                        if (!(row["checkdate"] is DBNull))
                            trans.transactionDate = row["checkdate"].ToString();

                        if (!(row["isdeposit"] is DBNull))
                            trans.isDeposit = Convert.ToBoolean(row["isdeposit"]);

                        if (!(row["status"] is DBNull))
                            trans.transactionStatus = row["status"].ToString();

                        if (!(row["amount"] is DBNull))
                            trans.transactionAmount = row["amount"].ToString();

                        transactionList.Add(trans);
                    }
                }

                return transactionList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Get 5 recent transactions with status return
        public List<RecentTransactions> GetRecentReturnTransactions()
        {
            strSQL = "select top 5 id, checkdate, isdeposit, status, amount from Transactions where status = '1' order by id desc";

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            List<RecentTransactions> transactionList = new List<RecentTransactions>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        RecentTransactions trans = new RecentTransactions();

                        if (!(row["id"] is DBNull))
                            trans.transactionId = Convert.ToInt32(row["id"]);

                        if (!(row["checkdate"] is DBNull))
                            trans.transactionDate = row["checkdate"].ToString();

                        if (!(row["isdeposit"] is DBNull))
                            trans.isDeposit = Convert.ToBoolean(row["isdeposit"]);

                        if (!(row["status"] is DBNull))
                            trans.transactionStatus = "Return";

                        if (!(row["amount"] is DBNull))
                            trans.transactionAmount = row["amount"].ToString();

                        transactionList.Add(trans);
                    }
                }

                return transactionList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TransactionListModel> GetTransactions(string customerName, string amount, string checkName)
        {
            strSQL = "select t.id, c.firstname + ' ' + c.lastname as customername, ch.name as checkname, t.amount, t.checknumber, t.checkdate, t.status from Transactions t " +
               "inner join customers c on c.id = t.customerid " +
               "inner join Checks ch on ch.id = t.checkid ";

            sqlParams = new List<SqlParameter>();
            List<string> whereClause = new List<string>();
            if (!string.IsNullOrEmpty(customerName))
            {
                whereClause.Add(" c.firstname + ' ' + c.lastname  like  @name ");
                sqlParams.Add(new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = "%" + customerName + "%" });
            }

            if (!string.IsNullOrEmpty(amount))
            {
                whereClause.Add(" t.amount like @amount ");
                sqlParams.Add(new SqlParameter() { ParameterName = "amount", SqlDbType = SqlDbType.VarChar, Value = "%" + amount + "%" });
            }

            if (!string.IsNullOrEmpty(checkName))
            {
                whereClause.Add(" ch.name like @checkName  ");
                sqlParams.Add(new SqlParameter() { ParameterName = "checkName", SqlDbType = SqlDbType.VarChar, Value = "%" + checkName + "%" });
            }

            if (whereClause.Count > 0)
            {
                strSQL += " where " + string.Join(" and ", whereClause);
            }

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            List<TransactionListModel> transactionList = new List<TransactionListModel>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        TransactionListModel trans = new TransactionListModel();

                        if (!(row["id"] is DBNull))
                            trans.transactionId = Convert.ToInt32(row["id"]);

                        if (!(row["customername"] is DBNull))
                            trans.customerName = row["customername"].ToString();

                        if (!(row["checkname"] is DBNull))
                            trans.checkName = row["checkname"].ToString();

                        if (!(row["checknumber"] is DBNull))
                            trans.checkNumber = row["checknumber"].ToString();

                        if (!(row["checkdate"] is DBNull))
                            trans.checkDate = row["checkdate"].ToString();

                        if (!(row["amount"] is DBNull))
                            trans.checkAmount = row["amount"].ToString();

                        if (!(row["status"] is DBNull))
                            trans.status = row["status"].ToString();

                        transactionList.Add(trans);
                    }
                }

                return transactionList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //create a method to get a check by id
        public TransactionDetailModel GetTransactionById(int transactionId)
        {
            strSQL = "select t.id, t.checknumber, c.id as customerId, t.feeamount, t.amount, t.status, cd.idnumber, c.firstname, c.lastname , c.address as caddress, c.city as ccity, " +
                "c.zipcode as czipcode, c.statename as cstate, c.phone as cphone, cf.faceimage, ch.name as checkname, ch.accountnumber, ch.bankroutingid, ch.address as chaddress, ch.city as chcity, " +
                "ch.zipcode as chzipcode, ch.statename as chstate, ch.phone as chphone, t.checkimage " +
                "from Transactions t inner join customers c on c.id = t.customerid left join customerfaces cf on c.id = cf.customerid left join customerdocs cd on c.id = cd.customerid " +
                "inner join Checks ch on ch.id = t.checkid where t.id = @transactionId";

            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "transactionId", SqlDbType = SqlDbType.Int, Value = transactionId }
            };

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            TransactionDetailModel response = new TransactionDetailModel();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["id"] is DBNull))
                        response.transactionId = Convert.ToInt32(data.Rows[0]["id"]);

                    if (!(data.Rows[0]["checknumber"] is DBNull))
                        response.checkNumber = data.Rows[0]["checknumber"].ToString();

                    if (!(data.Rows[0]["feeamount"] is DBNull))
                        response.fees = data.Rows[0]["feeamount"].ToString();

                    if (!(data.Rows[0]["amount"] is DBNull))
                        response.amount = data.Rows[0]["amount"].ToString();

                    if (!(data.Rows[0]["status"] is DBNull))
                        response.status = data.Rows[0]["status"].ToString();

                    if (!(data.Rows[0]["checkimage"] is DBNull))
                        response.checkImagePath = data.Rows[0]["checkimage"].ToString();

                    TransactionCustomer customer = new TransactionCustomer();

                    if (!(data.Rows[0]["customerId"] is DBNull))
                        customer.id = data.Rows[0]["customerId"].ToString();

                    if (!(data.Rows[0]["idnumber"] is DBNull))
                        customer.idNumber = data.Rows[0]["idnumber"].ToString();

                    if (!(data.Rows[0]["firstname"] is DBNull))
                        customer.firstName = data.Rows[0]["firstname"].ToString();

                    if (!(data.Rows[0]["lastname"] is DBNull))
                        customer.lastName = data.Rows[0]["lastname"].ToString();

                    if (!(data.Rows[0]["caddress"] is DBNull))
                        customer.address = data.Rows[0]["caddress"].ToString();

                    if (!(data.Rows[0]["ccity"] is DBNull))
                        customer.city = data.Rows[0]["ccity"].ToString();

                    if (!(data.Rows[0]["czipcode"] is DBNull))
                        customer.zipCode = data.Rows[0]["czipcode"].ToString();

                    if (!(data.Rows[0]["cstate"] is DBNull))
                        customer.state = data.Rows[0]["cstate"].ToString();

                    if (!(data.Rows[0]["cphone"] is DBNull))
                        customer.phone = data.Rows[0]["cphone"].ToString();

                    if (!(data.Rows[0]["faceimage"] is DBNull))
                        customer.facePath = data.Rows[0]["faceimage"].ToString();

                    TransactionCheck check = new TransactionCheck();

                    if (!(data.Rows[0]["accountnumber"] is DBNull))
                        check.accountNumber = data.Rows[0]["accountnumber"].ToString();

                    if (!(data.Rows[0]["checkname"] is DBNull))
                        check.name = data.Rows[0]["checkname"].ToString();

                    if (!(data.Rows[0]["bankroutingid"] is DBNull))
                        check.routingNumber = data.Rows[0]["bankroutingid"].ToString();

                    if (!(data.Rows[0]["chaddress"] is DBNull))
                        check.address = data.Rows[0]["chaddress"].ToString();

                    if (!(data.Rows[0]["chcity"] is DBNull))
                        check.city = data.Rows[0]["chcity"].ToString();

                    if (!(data.Rows[0]["chzipcode"] is DBNull))
                        check.zipCode = data.Rows[0]["chzipcode"].ToString();

                    if (!(data.Rows[0]["chstate"] is DBNull))
                        check.state = data.Rows[0]["chstate"].ToString();

                    if (!(data.Rows[0]["chphone"] is DBNull))
                        check.phone = data.Rows[0]["chphone"].ToString();

                    response.customer = customer;
                    response.check = check;
                }

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int InsertTransaction(AddTransactionModel request)
        {
            strSQL = "insert into Transactions (checkid, customerid, amount, status, checknumber, transdateTime, feeamount, checkdate) " +
                "values (@checkid, @customerid, @amount, @status, @checknumber, GETDATE(), @feeamount, @checkdate) select SCOPE_IDENTITY()";

            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "checkid", SqlDbType = SqlDbType.Int, Value = request.checkId },
                new SqlParameter() { ParameterName = "customerid", SqlDbType = SqlDbType.Int, Value = request.customerId },
                new SqlParameter() { ParameterName = "amount", SqlDbType = SqlDbType.VarChar, Value = request.amount },
                new SqlParameter() { ParameterName = "status", SqlDbType = SqlDbType.VarChar, Value = request.status },
                new SqlParameter() { ParameterName = "checknumber", SqlDbType = SqlDbType.VarChar, Value = request.checkNumber },
                //new SqlParameter() { ParameterName = "checkimage", SqlDbType = SqlDbType.VarChar, Value = request.checkImagePath },
                new SqlParameter() { ParameterName = "feeamount", SqlDbType = SqlDbType.VarChar, Value = request.feeAmount },
                new SqlParameter() { ParameterName = "checkdate", SqlDbType = SqlDbType.VarChar, Value = request.checkDate.ToString("dd/MM/yyyy") }
            };

            useReadOnlyConn = false;
            cmdType = "text";

            return Convert.ToInt32(ExecuteScalar());
        }

        public void UpdateTransCheckImagePath(int transactionId, string imagePath)
        {
            useReadOnlyConn = false;

            strSQL = "update Transactions set checkimage = @imagePath where id = @transactionId";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "imagePath", SqlDbType = SqlDbType.VarChar, Value = imagePath },
                new SqlParameter() { ParameterName = "transactionId", SqlDbType = SqlDbType.Int, Value = transactionId }
            };

            ExecuteQuery();
        }

        public void UpdateTransaction()
        {
        }

        public void DeleteTransaction()
        {
        }

        public void UpdateTransactionStatus(int transactionId, int status)
        {
            useReadOnlyConn = false;

            strSQL = "update Transactions set status = @status where id = @transactionId";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "status", SqlDbType = SqlDbType.Int, Value = status },
                new SqlParameter() { ParameterName = "transactionId", SqlDbType = SqlDbType.Int, Value = transactionId }
            };

            ExecuteQuery();
        }
    }
}