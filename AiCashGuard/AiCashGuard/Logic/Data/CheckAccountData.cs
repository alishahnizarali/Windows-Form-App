using AiCashGuard.Logic.Data.Base;
using AiCashGuard.Model.Internal;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AiCashGuard.Logic.Data
{
    public class CheckAccountData : ActionHandler
    {
        //create a method to get all checks with with filters
        public List<CheckAcctList> GetChecksAccount(string accountNumber, string routingNumber, string name)
        {
            strSQL = "select c.id, c.accountnumber, c.bankroutingid, c.name, c.address, c.phone, c.isdefaulter from Checks c ";// +
               //"left join Bankrouting br on c.bankroutingid = br.id left join Banks b on br.bankid = b.id";

            List<string> whereClause = new List<string>();
            sqlParams = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(name))
            {
                whereClause.Add(" c.name  like  @name ");
                sqlParams.Add(new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = "%" + name + "%" });
            }

            if (!string.IsNullOrEmpty(accountNumber))
            {
                whereClause.Add(" c.accountnumber like @accountnumber  ");
                sqlParams.Add(new SqlParameter() { ParameterName = "accountnumber", SqlDbType = SqlDbType.VarChar, Value = "%" + accountNumber + "%" });
            }

            if (!string.IsNullOrEmpty(routingNumber))
            {
                whereClause.Add(" c.bankroutingid like @number  ");
                sqlParams.Add(new SqlParameter() { ParameterName = "number", SqlDbType = SqlDbType.VarChar, Value = "%" + routingNumber + "%" });
            }

            if (whereClause.Count > 0)
            {
                strSQL += " where " + string.Join(" and ", whereClause);
            }

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            List<CheckAcctList> checkList = new List<CheckAcctList>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CheckAcctList check = new CheckAcctList();

                        if (!(row["id"] is DBNull))
                            check.checkId = Convert.ToInt32(row["id"]);

                        if (!(row["accountnumber"] is DBNull))
                            check.accountNumber = row["accountnumber"].ToString();

                        if (!(row["bankroutingid"] is DBNull))
                            check.routingNumber = row["bankroutingid"].ToString();

                        if (!(row["address"] is DBNull))
                            check.address = row["address"].ToString();

                        if (!(row["isdefaulter"] is DBNull))
                            check.isDefault = Convert.ToBoolean(row["isdefaulter"]);

                        if (!(row["phone"] is DBNull))
                            check.phone = row["phone"].ToString();

                        if (!(row["name"] is DBNull))
                            check.name = row["name"].ToString();

                        checkList.Add(check);
                    }
                }

                return checkList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //create a method to get a check by id
        public CheckDetailModel GetCheckAccountById(int checkAccountId)
        {
            useReadOnlyConn = true;

            strSQL = "select c.id, c.accountnumber, c.bankroutingid, c.name, address, city, zipcode, statename, phone, alertmsg, isdefaulter, c.createddate, checkaccimagefront, checkaccimageback, " +
                "COUNT(t.id) AS numTransaction, COUNT(tr.id) AS numReturn, COUNT(tc.id) AS numCashed, COUNT(trc.id) AS numReturnClear, MAX(t.checkdate) AS lastCashOn " +
                "from Checks c " +
                "LEFT JOIN transactions t ON c.id = t.checkid LEFT JOIN transactions tr ON c.id = tr.checkid and tr.status = '1' " +
                "LEFT JOIN transactions tc ON c.id = tc.checkid and tc.status = '0' LEFT JOIN transactions trc ON c.id = trc.checkid and trc.status = '2' " +
                "where c.id = @checkId GROUP BY c.id, c.accountnumber, c.bankroutingid, c.name, c.address, c.city, c.zipcode, c.statename, c.phone, c.alertmsg, isdefaulter, c.createddate, c.checkaccimagefront, c.checkaccimageback;";

            cmdType = "text";
            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.Int, Value = checkAccountId }
            };

            DataTable data = RetrieveSqlDataTable();

            CheckDetailModel response = new CheckDetailModel();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["id"] is DBNull))
                        response.checkId = Convert.ToInt32(data.Rows[0]["id"]);

                    if (!(data.Rows[0]["accountnumber"] is DBNull))
                        response.accountNumber = data.Rows[0]["accountnumber"].ToString();

                    if (!(data.Rows[0]["bankroutingid"] is DBNull))
                        response.routingNumber = data.Rows[0]["bankroutingid"].ToString();

                    if (!(data.Rows[0]["name"] is DBNull))
                        response.name = data.Rows[0]["name"].ToString();

                    if (!(data.Rows[0]["address"] is DBNull))
                        response.address = data.Rows[0]["address"].ToString();

                    if (!(data.Rows[0]["city"] is DBNull))
                        response.city = data.Rows[0]["city"].ToString();

                    if (!(data.Rows[0]["zipcode"] is DBNull))
                        response.zipCode = data.Rows[0]["zipcode"].ToString();

                    if (!(data.Rows[0]["statename"] is DBNull))
                        response.state = data.Rows[0]["statename"].ToString();

                    if (!(data.Rows[0]["phone"] is DBNull))
                        response.phone = data.Rows[0]["phone"].ToString();

                    if (!(data.Rows[0]["alertmsg"] is DBNull))
                        response.alertMsg = data.Rows[0]["alertmsg"].ToString();

                    if (!(data.Rows[0]["isdefaulter"] is DBNull))
                        response.isDefault = Convert.ToBoolean(data.Rows[0]["isdefaulter"]);

                    if (!(data.Rows[0]["createddate"] is DBNull))
                        response.createdOn = data.Rows[0]["createddate"].ToString();

                    if (!(data.Rows[0]["checkaccimagefront"] is DBNull))
                        response.checkImageFrontPath = data.Rows[0]["checkaccimagefront"].ToString();

                    if (!(data.Rows[0]["checkaccimageback"] is DBNull))
                        response.checkImageBackPath = data.Rows[0]["checkaccimageback"].ToString();

                    if (!(data.Rows[0]["numTransaction"] is DBNull))
                        response.numTransaction = Convert.ToInt32(data.Rows[0]["numTransaction"]);

                    if (!(data.Rows[0]["numReturn"] is DBNull))
                        response.numReturn = Convert.ToInt32(data.Rows[0]["numReturn"]);

                    if (!(data.Rows[0]["numCashed"] is DBNull))
                        response.numCashed = Convert.ToInt32(data.Rows[0]["numCashed"]);

                    if (!(data.Rows[0]["numReturnClear"] is DBNull))
                        response.numReturnClear = Convert.ToInt32(data.Rows[0]["numReturnClear"]);

                    if (!(data.Rows[0]["lastCashOn"] is DBNull))
                        response.lastCashOn = data.Rows[0]["lastCashOn"].ToString();
                }

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SearchCheckAcctListModel> GetCheckByAcctName(string name)
        {
            strSQL = "select id, name from Checks where name like @name";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = "%" + name + "%" }
            };

            DataTable data = RetrieveSqlDataTable();

            List<SearchCheckAcctListModel> checkList = new List<SearchCheckAcctListModel>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        SearchCheckAcctListModel check = new SearchCheckAcctListModel();

                        if (!(row["id"] is DBNull))
                            check.checkAccountId = Convert.ToInt32(row["id"]);

                        if (!(row["name"] is DBNull))
                            check.checkName = row["name"].ToString();

                        checkList.Add(check);
                    }
                }

                return checkList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //create a method to get a check id by accountNumber and routingNumber
        public int GetCheckAccountByAccountNumber(string accountNumber, string routingNumber, int checkId)
        {
            strSQL = "select id from Checks where accountnumber = @accountnumber and bankroutingid = @bankroutingid";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "accountnumber", SqlDbType = SqlDbType.VarChar, Value = accountNumber },
                new SqlParameter() { ParameterName = "bankroutingid", SqlDbType = SqlDbType.Int, Value = routingNumber }
            };

            if(checkId > 0)
            {
                strSQL += " and id != @checkId";
                sqlParams.Add(new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.Int, Value = checkId });
            }

            DataTable data = RetrieveSqlDataTable();

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["id"]);
            }

            return 0;
        }

        //create a method to create a check
        public int InsertCheckAccount(AddCheckAcct request)
        {
            useReadOnlyConn = false;

            strSQL = "insert into Checks (accountnumber, bankroutingid, checktype, name, address, city, zipcode, statename, phone, alertmsg, accountgroupId, createddate) " +
                "values (@accountnumber, @bankroutingid, @checktype, @name, @address, @city, @zipcode, @statename, @phone, @alertmsg, @accountgroupId, GETDATE()) select SCOPE_IDENTITY()";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "accountnumber", SqlDbType = SqlDbType.VarChar, Value = request.accountNumber ?? "" },
                new SqlParameter() { ParameterName = "bankroutingid", SqlDbType = SqlDbType.Int, Value = request.routingNumberId ?? "" },
                new SqlParameter() { ParameterName = "checktype", SqlDbType = SqlDbType.Int, Value = /*request.accountType ??*/ 0 },
                new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = request.accountName ?? "" },
                new SqlParameter() { ParameterName = "address", SqlDbType = SqlDbType.VarChar, Value = request.address ?? "" },
                new SqlParameter() { ParameterName = "city", SqlDbType = SqlDbType.VarChar, Value = request.city ?? "" },
                new SqlParameter() { ParameterName = "zipcode", SqlDbType = SqlDbType.VarChar, Value = request.zipCode ?? "" },
                new SqlParameter() { ParameterName = "statename", SqlDbType = SqlDbType.VarChar, Value = request.state ?? "" },
                new SqlParameter() { ParameterName = "phone", SqlDbType = SqlDbType.VarChar, Value = request.phone ?? "" },
                new SqlParameter() { ParameterName = "alertmsg", SqlDbType = SqlDbType.VarChar, Value = request.alertMsg ?? "" },
                new SqlParameter() { ParameterName = "accountgroupId", SqlDbType = SqlDbType.Int, Value = 0},
            };

            return Convert.ToInt32(ExecuteScalar());
        }

        public void UpdateCheckImagePath(int checkId, string imagePath)
        {
            useReadOnlyConn = false;

            strSQL = "update Checks set checkaccimagefront = @checkaccimagefront where id = @checkId";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "checkaccimagefront", SqlDbType = SqlDbType.VarChar, Value = imagePath },
                new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.Int, Value = checkId }
            };

            ExecuteQuery();
        }

        //create a method to update a check
        public void UpdateCheckAccount(EditCheckAcct request)
        {
            useReadOnlyConn = false;

            strSQL = "update Checks set accountnumber = @accountnumber, bankroutingid = @bankroutingid, checktype = @checktype, name = @name, address = @address, city = @city, zipcode = @zipcode, " +
                "statename = @statename, phone = @phone, alertmsg = @alertmsg, checkaccimagefront = @checkaccimagefront where id = @checkId";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "accountnumber", SqlDbType = SqlDbType.VarChar, Value = request.accountNumber },
                new SqlParameter() { ParameterName = "bankroutingid", SqlDbType = SqlDbType.Int, Value = request.routingNumber },
                new SqlParameter() { ParameterName = "checktype", SqlDbType = SqlDbType.Int, Value = request.accountType },
                new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = request.accountName },
                new SqlParameter() { ParameterName = "address", SqlDbType = SqlDbType.VarChar, Value = request.address },
                new SqlParameter() { ParameterName = "city", SqlDbType = SqlDbType.VarChar, Value = request.city },
                new SqlParameter() { ParameterName = "zipcode", SqlDbType = SqlDbType.VarChar, Value = request.zipCode },
                new SqlParameter() { ParameterName = "statename", SqlDbType = SqlDbType.VarChar, Value = request.state },
                new SqlParameter() { ParameterName = "phone", SqlDbType = SqlDbType.VarChar, Value = request.phone },
                new SqlParameter() { ParameterName = "alertmsg", SqlDbType = SqlDbType.VarChar, Value = request.alertMsg },
                new SqlParameter() { ParameterName = "checkaccimagefront", SqlDbType = SqlDbType.VarChar, Value = request.checkImageFrontPath },
                new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.Int, Value = request.checkId }
            };

            ExecuteQuery();
        }

        //create a method to delete a check
        public void DeleteCheckAccount()
        {
        }

        //create a method to get a check history by id with filters
        public List<CustomerModel> GetCheckAccountHistory(int checkId)
        {
            strSQL = "select t.id, t.customerid, cd.idnumber, c.firstname, c.lastname, c.phone, c.address, c.isdefaulter from Transactions t " +
                "inner join Customers c on t.customerid = c.id left join customerdocs cd on c.id = cd.customerid where t.checkid = @checkId";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.Int, Value = checkId }
            };

            DataTable data = RetrieveSqlDataTable();

            List<CustomerModel> checkHistory = new List<CustomerModel>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CustomerModel customer = new CustomerModel();

                        if (!(row["customerid"] is DBNull))
                            customer.customerId = Convert.ToInt32(row["customerid"]);

                        if (!(row["idnumber"] is DBNull))
                            customer.idNumber = row["idnumber"].ToString();

                        if (!(row["firstname"] is DBNull))
                            customer.firstName = row["firstname"].ToString();

                        if (!(row["lastname"] is DBNull))
                            customer.lastName = row["lastname"].ToString();

                        if (!(row["phone"] is DBNull))
                            customer.phone = row["phone"].ToString();

                        if (!(row["address"] is DBNull))
                            customer.address = row["address"].ToString();

                        if (!(row["isdefaulter"] is DBNull))
                            customer.isDefault = Convert.ToBoolean(row["isdefaulter"]);

                        checkHistory.Add(customer);
                    }
                }

                return checkHistory;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateCheckAccountStatus(int checkId, bool isBlock)
        {
            strSQL = "UPDATE Checks SET isdefaulter = @isdefaulter WHERE id = @checkId";
            cmdType = "text";

            useReadOnlyConn = false;

            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "checkId", SqlDbType = SqlDbType.VarChar, Size=50, Value = checkId },
                new SqlParameter() { ParameterName = "isdefaulter", SqlDbType = SqlDbType.Bit, Value = isBlock }
            };

            ExecuteQuery();
        }
    }
}
