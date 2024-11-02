using AiCashGuard.Logic.Data.Base;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AiCashGuard.Logic.Data
{
    public class CustomerData : ActionHandler
    {
        //create a method to get all customers with filters
        public List<CustomerModel> GetCustomersList(string name, string idNumber, string phone)
        {
            strSQL = "select c.id, c.firstname, c.lastname, c.address, c.isdefaulter, c.phone, cd.idnumber from customers c " +
                " left join customerdocs cd on c.id = cd.customerid";

            List<string> whereClause = new List<string>();
            sqlParams = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(name))
            {
                whereClause.Add(" c.firstname + ' ' + c.lastname  like  @name ");
                sqlParams.Add(new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = "%" + name + "%" });
            }

            if (!string.IsNullOrEmpty(idNumber))
            {
                whereClause.Add(" cd.idnumber like @idNumber  ");
                sqlParams.Add(new SqlParameter() { ParameterName = "idNumber", SqlDbType = SqlDbType.VarChar, Value = "%" + idNumber + "%" });
            }

            if (!string.IsNullOrEmpty(phone))
            {
                whereClause.Add(" c.phone like @phone  ");
                sqlParams.Add(new SqlParameter() { ParameterName = "phone", SqlDbType = SqlDbType.VarChar, Value = "%" + phone + "%" });
            }

            if (whereClause.Count > 0)
            {
                strSQL += " where " + string.Join(" and ", whereClause);
            }

            useReadOnlyConn = true;
            cmdType = "text";

            DataTable data = RetrieveSqlDataTable();

            List<CustomerModel> custList = new List<CustomerModel>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CustomerModel cust = new CustomerModel();

                        if (!(row["id"] is DBNull))
                            cust.customerId = Convert.ToInt32(row["id"]);

                        if (!(row["firstname"] is DBNull))
                            cust.firstName = row["firstname"].ToString();

                        if (!(row["lastname"] is DBNull))
                            cust.lastName = row["lastname"].ToString();

                        if (!(row["address"] is DBNull))
                            cust.address = row["address"].ToString();

                        if (!(row["phone"] is DBNull))
                            cust.phone = row["phone"].ToString();

                        if (!(row["idnumber"] is DBNull))
                            cust.idNumber = row["idnumber"].ToString();

                        if (!(row["isdefaulter"] is DBNull))
                            cust.isDefault = Convert.ToBoolean(row["isdefaulter"]);

                        custList.Add(cust);
                    }
                }

                return custList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //create a method to get a customer by id
        public CustomerDetailModel GetCustomerById(int customerId)
        {
            useReadOnlyConn = true;

            strSQL = "select c.id, firstname, lastname, dateofbirth, email, address, city, zipcode, statename, phone, alertmsg, isdefaulter, createddate, idnumber, docfrontimage, docbackimage, faceimage, " +
                "COUNT(t.id) AS numTransaction, COUNT(tr.id) AS numReturn, COUNT(tc.id) AS numCashed, COUNT(trc.id) AS numReturnClear, MAX(t.checkdate) AS lastCashOn " +
                "from customers c left join customerfaces cf on c.id = cf.customerid left join customerdocs cd on c.id = cd.customerid " +
                "LEFT JOIN transactions t ON c.id = t.customerid LEFT JOIN transactions tr ON c.id = tr.customerid and tr.status = '1' " +
                "LEFT JOIN transactions tc ON c.id = tc.customerid and tc.status = '0' LEFT JOIN transactions trc ON c.id = trc.customerid and trc.status = '2' " +
                "where c.id = @customerId GROUP BY c.id, firstname, lastname, dateofbirth, email, address, city, zipcode, statename, phone, alertmsg, isdefaulter, createddate, idnumber, docfrontimage, docbackimage, faceimage;";

            cmdType = "text";
            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = customerId }
            };

            DataTable data = RetrieveSqlDataTable();

            CustomerDetailModel response = new CustomerDetailModel();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["id"] is DBNull))
                        response.customerId = Convert.ToInt32(data.Rows[0]["id"]);

                    if (!(data.Rows[0]["firstname"] is DBNull))
                        response.firstName = data.Rows[0]["firstname"].ToString();

                    if (!(data.Rows[0]["lastname"] is DBNull))
                        response.lastName = data.Rows[0]["lastname"].ToString();

                    if (!(data.Rows[0]["dateofbirth"] is DBNull))
                        response.dOB = data.Rows[0]["dateofbirth"].ToString();

                    if (!(data.Rows[0]["email"] is DBNull))
                        response.email = data.Rows[0]["email"].ToString();

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

                    if (!(data.Rows[0]["idnumber"] is DBNull))
                        response.idNumber = data.Rows[0]["idnumber"].ToString();

                    if (!(data.Rows[0]["docfrontimage"] is DBNull))
                        response.idImageFrontPath = data.Rows[0]["docfrontimage"].ToString();

                    if (!(data.Rows[0]["docbackimage"] is DBNull))
                        response.idImageBackPath = data.Rows[0]["docbackimage"].ToString();

                    if (!(data.Rows[0]["faceimage"] is DBNull))
                        response.customerImagePath = data.Rows[0]["faceimage"].ToString();

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

        //create a method to get a customer by face embedding
        public int GetCustomerByFace(string faceEmbedding)
        {
            useReadOnlyConn = true;

            strSQL = "select c.id from customers c left join customerfaces cf on c.id = cf.customerid left join customerdocs cd on c.id = cd.customerid" +
                "where dbo.CosineSimilarity(cf.facevalue, @faceEmbedding) >= 0.8 ";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "faceEmbedding", SqlDbType = SqlDbType.VarChar, Value = faceEmbedding }
            };

            DataTable data = RetrieveSqlDataTable();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["id"] is DBNull))
                        return Convert.ToInt32(data.Rows[0]["id"]);
                }
                return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //create a method to get a customer by name
        public List<SearchCustomerListModel> GetCustomerByName(string name)
        {
            useReadOnlyConn = true;

            strSQL = "select id, firstname + ' ' + lastname name from customers where firstname + ' ' + lastname LIKE @name";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "name", SqlDbType = SqlDbType.VarChar, Value = "%" + name + "%" }
            };

            DataTable data = RetrieveSqlDataTable();
            List<SearchCustomerListModel> custList = new List<SearchCustomerListModel>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        SearchCustomerListModel cust = new SearchCustomerListModel();

                        if (!(row["id"] is DBNull))
                            cust.customerId = Convert.ToInt32(row["id"]);

                        if (!(row["name"] is DBNull))
                            cust.customerName = row["name"].ToString();

                        custList.Add(cust);
                    }
                }
                return custList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Check customer already exist or not
        public int CheckCustomerExist(string firstName, string lastName, string idNumber, DateTime dOB, int customerId)
        {
            useReadOnlyConn = true;

            strSQL = "select c.id from customers c left join customerdocs cd on cd.customerid = c.id " +
                "where cd.idnumber = @idNumber and c.firstname = @firstName and c.lastname = @lastName and dateofbirth = @dOB";

            cmdType = "text";
            sqlParams = new List<SqlParameter>
            {
                new SqlParameter() { ParameterName = "idNumber", SqlDbType = SqlDbType.VarChar, Value = idNumber },
                new SqlParameter() { ParameterName = "firstName", SqlDbType = SqlDbType.VarChar, Value = firstName },
                new SqlParameter() { ParameterName = "lastName", SqlDbType = SqlDbType.VarChar, Value = lastName },
                new SqlParameter() { ParameterName = "dOB", SqlDbType = SqlDbType.VarChar, Value = dOB.ToString("dd/MM/yyyy") }
            };

            if (customerId > 0)
            {
                strSQL += " and c.id != @customerId";
                sqlParams.Add(new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = customerId });
            }

            DataTable data = RetrieveSqlDataTable();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (!(data.Rows[0]["id"] is DBNull))
                        return Convert.ToInt32(data.Rows[0]["id"]);
                }
                return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int InsertCustomer(AddCustomerModel request)
        {
            try
            {
                strSQL = "insert into customers (firstname,lastname,dateofbirth,email,address,city,zipcode,statename,accountgroupId,phone,alertmsg,isdefaulter,createddate) " +
                    "values(@firstname,@lastname,@dateofbirth,@email,@address,@city,@zipcode,@statename,@accountgroupId,@phone,@alertmsg,@isdefaulter,GETDATE()) select SCOPE_IDENTITY()";
                cmdType = "text";
                useReadOnlyConn = false;

                sqlParams = new List<SqlParameter> {
                    new SqlParameter() { ParameterName = "firstname", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.firstName ?? "" },
                    new SqlParameter() { ParameterName = "lastname", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.lastName ?? "" },
                    new SqlParameter() { ParameterName = "dateofbirth", SqlDbType = SqlDbType.VarChar, Size=10, Value = request.dOB.ToString("dd/MM/yyyy") ?? "" },
                    new SqlParameter() { ParameterName = "email", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.email ?? "" },
                    new SqlParameter() { ParameterName = "address", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.address ?? "" },
                    new SqlParameter() { ParameterName = "city", SqlDbType = SqlDbType.VarChar, Size=20, Value = request.city ?? "" },
                    new SqlParameter() { ParameterName = "zipcode", SqlDbType = SqlDbType.VarChar, Size=10, Value = request.zipCode ?? "" },
                    new SqlParameter() { ParameterName = "statename", SqlDbType = SqlDbType.VarChar, Size=20, Value = request.state ?? "" },
                    new SqlParameter() { ParameterName = "accountgroupId", SqlDbType = SqlDbType.Int, Value = 0},
                    new SqlParameter() { ParameterName = "phone", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.phone ?? "" },
                    new SqlParameter() { ParameterName = "alertmsg", SqlDbType = SqlDbType.VarChar, Size=200, Value = request.alertMsg ?? "" },
                    new SqlParameter() { ParameterName = "isdefaulter", SqlDbType = SqlDbType.Bit, Value = 0 }
                };

                return Convert.ToInt32(ExecuteScalar());
            }

            catch (Exception e)
            {
                throw e;
            }

        }

        public void InsertCustomerDocuments(AddCustomerModel request, int customerId, string customerIdPathFront, string customerIdPathBack)
        {
            try
            {
                strSQL = "insert into customerdocs (customerId,idnumber,docfrontimage,docbackimage) " +
                    "values(@customerId,@idnumber,@docfrontimage,@docbackimage)";
                cmdType = "text";
                useReadOnlyConn = false;

                sqlParams = new List<SqlParameter> {
                    new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = customerId },
                    new SqlParameter() { ParameterName = "idnumber", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.idNumber },
                    new SqlParameter() { ParameterName = "docfrontimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = customerIdPathFront??"" },
                    new SqlParameter() { ParameterName = "docbackimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = customerIdPathBack ?? "" },
/*                    new SqlParameter() { ParameterName = "doctype", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.documentType },
                    new SqlParameter() { ParameterName = "docstate", SqlDbType = SqlDbType.VarChar, Size=20, Value = request.documentState },
                    new SqlParameter() { ParameterName = "doccountry", SqlDbType = SqlDbType.VarChar, Size=10, Value = request.documentCountry }*/
                };

                ExecuteQuery();
            }

            catch (Exception e)
            {
                throw e;
            }

        }

        public void InsertCustomerFace(float[] faceValue, int customerId, string customerFacePath)
        {
            try
            {
                strSQL = "insert into customerfaces (customerId,facevalue,faceimage) " +
                    "values(@customerId,@facevalue,@faceimage)";
                cmdType = "text";
                useReadOnlyConn = false;

                sqlParams = new List<SqlParameter> {
                    new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = customerId },
                    new SqlParameter() { ParameterName = "facevalue", SqlDbType = SqlDbType.VarChar, Size=50, Value = DBNull.Value },
                    new SqlParameter() { ParameterName = "faceimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = customerFacePath?? "" }
                };

                ExecuteQuery();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateCustomerDetails(EditCustomerModel request)
        {
            strSQL = "UPDATE customers SET firstname = @firstname,lastname = @lastname,dateofbirth = @dateofbirth,email = @email,address = @address,city = @city,zipcode = @zipcode," +
                "statename = @statename,accountgroupId = @accountgroupId,phone = @phone,alertmsg = @alertmsg,isdefaulter = @isdefaulter WHERE id = @customerId";
            cmdType = "text";

            useReadOnlyConn = false;

            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.customerId },
                new SqlParameter() { ParameterName = "firstname", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.firstName ?? "" },
                new SqlParameter() { ParameterName = "lastname", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.lastName ?? "" },
                new SqlParameter() { ParameterName = "dateofbirth", SqlDbType = SqlDbType.VarChar, Size=10, Value = request.dOB.ToString("dd/MM/yyyy") ?? "" },
                new SqlParameter() { ParameterName = "email", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.email ?? "" },
                new SqlParameter() { ParameterName = "address", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.address ?? "" },
                new SqlParameter() { ParameterName = "city", SqlDbType = SqlDbType.VarChar, Size=20, Value = request.city ?? "" },
                new SqlParameter() { ParameterName = "zipcode", SqlDbType = SqlDbType.VarChar, Size=10, Value = request.zipCode ?? "" },
                new SqlParameter() { ParameterName = "statename", SqlDbType = SqlDbType.VarChar, Size=20, Value = request.state ?? "" },
                new SqlParameter() { ParameterName = "accountgroupId", SqlDbType = SqlDbType.Int, Value = 0},
                new SqlParameter() { ParameterName = "phone", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.phone ?? "" },
                new SqlParameter() { ParameterName = "alertmsg", SqlDbType = SqlDbType.VarChar, Size=200, Value = request.alertMsg ?? "" },
                new SqlParameter() { ParameterName = "isdefaulter", SqlDbType = SqlDbType.Bit, Value = 0 }
            };

            ExecuteQuery();
        }

        public void UpdateCustomerDocuments(EditCustomerModel request)
        {
            try
            {
                strSQL = "UPDATE customerdocs SET idnumber = @idnumber, docfrontimage = @docfrontimage, docbackimage = @docbackimage " +
                    "WHERE customerId = @customerId";
                cmdType = "text";
                useReadOnlyConn = false;

                sqlParams = new List<SqlParameter> {
                    new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = request.customerId },
                    new SqlParameter() { ParameterName = "idnumber", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.idNumber },
                    new SqlParameter() { ParameterName = "docfrontimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.idImageFrontPath },
                    new SqlParameter() { ParameterName = "docbackimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.idImageBackPath },
                };

                ExecuteQuery();
            }

            catch (Exception e)
            {
                throw e;
            }

        }

        public void UpdateCustomerFace(EditCustomerModel request)
        {
            try
            {
                strSQL = "UPDATE customerfaces SET facevalue = @facevalue, faceimage = @faceimage " +
                    "WHERE customerId = @customerId;";
                cmdType = "text";
                useReadOnlyConn = false;

                sqlParams = new List<SqlParameter> {
                    new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.Int, Value = request.customerId },
                    new SqlParameter() { ParameterName = "facevalue", SqlDbType = SqlDbType.VarBinary, Value = DBNull.Value},
                    new SqlParameter() { ParameterName = "faceimage", SqlDbType = SqlDbType.VarChar, Size=50, Value = request.customerImagePath ?? ""}
                };

                ExecuteQuery();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteCustomer()
        {
        }

        //create a method to get a customer history by id with filters
        public List<CheckAcctList> GetCustomerHistory(int customerId)
        {
            strSQL = "select ch.id, ch.name, ch.accountNumber, ch.bankRoutingId, ch.phone, ch.address, ch.isdefaulter " +
                "from customers c left join transactions t on c.id = t.customerid " +
                "inner join Checks ch on ch.id = t.checkid " +
                "where c.id = @customerid";

            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "customerid", SqlDbType = SqlDbType.Int, Value = customerId }
            };
            useReadOnlyConn = true;
            cmdType = "text";


            DataTable data = RetrieveSqlDataTable();

            List<CheckAcctList> history = new List<CheckAcctList>();

            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CheckAcctList check = new CheckAcctList();

                        if (!(row["id"] is DBNull))
                            check.checkId = Convert.ToInt32(row["id"]);

                        if (!(row["accountNumber"] is DBNull))
                            check.accountNumber = row["accountNumber"].ToString();

                        if (!(row["bankRoutingId"] is DBNull))
                            check.routingNumber = row["bankRoutingId"].ToString();

                        if (!(row["name"] is DBNull))
                            check.name = row["name"].ToString();

                        if (!(row["address"] is DBNull))
                            check.address = row["address"].ToString();

                        if (!(row["isdefaulter"] is DBNull))
                            check.isDefault = Convert.ToBoolean(row["isdefaulter"]);

                        if (!(row["phone"] is DBNull))
                            check.phone = row["phone"].ToString();

                        history.Add(check);
                    }
                }

                return history;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateCustomerStatus(int customerId, bool isBlock)
        {
            strSQL = "UPDATE customers SET isdefaulter = @isdefaulter WHERE id = @customerId";
            cmdType = "text";

            useReadOnlyConn = false;

            sqlParams = new List<SqlParameter> {
                new SqlParameter() { ParameterName = "customerId", SqlDbType = SqlDbType.VarChar, Size=50, Value = customerId },
                new SqlParameter() { ParameterName = "isdefaulter", SqlDbType = SqlDbType.Bit, Value = isBlock }
            };

            ExecuteQuery();
        }
    }
}
