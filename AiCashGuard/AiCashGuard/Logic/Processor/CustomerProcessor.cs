using AiCashGuard.Logic.Data;
using AiCashGuard.Logic.Extensions;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using System;
using System.Collections.Generic;

namespace AiCashGuard.Processor
{
    public class CustomerProcessor
    {
        //create a method to get all customers with filters
        public List<CustomerModel> GetCustomers(string name, string idNumber, string phone)
        {
            var custList = new CustomerData().GetCustomersList(name, idNumber, phone);
            return custList;
        }

        //create a method to get a customer by face embedding
        public int GetCustomerByFace(string faceEmbedding)
        {
            return new CustomerData().GetCustomerByFace(faceEmbedding);
        }

        //create a method to get a customer by id
        public CustomerDetailModel GetCustomerById(int customerId)
        {
            var cust = new CustomerData().GetCustomerById(customerId);

            if(!string.IsNullOrWhiteSpace(cust.customerImagePath))
                cust.customerImage = new ImageHelper().GetImage(cust.customerImagePath);
            if(!string.IsNullOrWhiteSpace(cust.idImageFrontPath))
                cust.idImageFront = new ImageHelper().GetImage(cust.idImageFrontPath);
            if (!string.IsNullOrWhiteSpace(cust.idImageBackPath))
                cust.idImageBack = new ImageHelper().GetImage(cust.idImageBackPath);

            return cust;
        }

        //create a method to get a customer by name
        public List<SearchCustomerListModel> GetCustomerByName(string name)
        {
            return new CustomerData().GetCustomerByName(name);
        }

        //create a method to check customer already exist or not
        public int CheckCustomerExist(string firstName, string lastName, string idNumber, DateTime dOB, int customerId = 0)
        {
            return new CustomerData().CheckCustomerExist(firstName, lastName, idNumber, dOB, customerId);
        }

        //create a method to create a customer
        public int CreateCustomer(AddCustomerModel request)
        {
            string customerIdPathFront = string.Empty;
            string customerIdPathBack = string.Empty;
            string customerFacePath = string.Empty;
            int customerId = new CustomerData().InsertCustomer(request);

            if (request.idImageFront != null)
            {
                customerIdPathFront = new ImageHelper().SaveImage(request.idImageFront, customerId, "CUSTOMERIDFRONT");
            }
            if (request.idImageBack != null)
            {
                customerIdPathBack = new ImageHelper().SaveImage(request.idImageBack, customerId, "CUSTOMERIDBACK");
            }

            new CustomerData().InsertCustomerDocuments(request, customerId, customerIdPathFront, customerIdPathBack);

            if (request.customerImage != null)
            {
                customerFacePath = new ImageHelper().SaveImage(request.customerImage, customerId, "CUSTOMERFACE");
            }

            new CustomerData().InsertCustomerFace(request.customerImageValue, customerId, customerFacePath);

            return customerId;
        }

        //create a method to update a customer
        public void UpdateCustomerDetails(EditCustomerModel request)
        {
            new CustomerData().UpdateCustomerDetails(request);

            if(request.idImageFront != null)
                request.idImageFrontPath = new ImageHelper().SaveImage(request.idImageFront, request.customerId, "CUSTOMERIDFRONT");
            else
                request.idImageFrontPath = "";

            if (request.idImageBack != null)
                request.idImageBackPath = new ImageHelper().SaveImage(request.idImageBack, request.customerId, "CUSTOMERIDBACK");
            else
                request.idImageBackPath = "";

            if (request.customerImage != null)
                request.customerImagePath = new ImageHelper().SaveImage(request.customerImage, request.customerId, "CUSTOMERFACE");
            else
                request.customerImagePath = "";

            new CustomerData().UpdateCustomerDocuments(request);
            new CustomerData().UpdateCustomerFace(request);
        }

        //create a method to delete a customer
        public void DeleteCustomer()
        {
        }

        //create a method to get a customer history by id with filters
        public List<CheckAcctList> GetCustomerHistory(int customerId)
        {
            return new CustomerData().GetCustomerHistory(customerId);
        }

        public void UpdateCustomerStatus(int customerId, bool isBlock)
        {
            new CustomerData().UpdateCustomerStatus(customerId, isBlock);
        }
    }
}
