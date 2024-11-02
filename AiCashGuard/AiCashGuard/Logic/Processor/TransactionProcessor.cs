using AiCashGuard.Logic.Data;
using AiCashGuard.Logic.Extensions;
using AiCashGuard.Model.Internal.Transaction;
using System.Collections.Generic;

namespace AiCashGuard.Logic.Processor
{
    public class TransactionProcessor
    {
        //Get Recent Transaction
        public DashboardTransaction GetDashboardTransaction()
        {
            DashboardTransaction dashboardTransaction = new DashboardTransaction();
            dashboardTransaction.recentTransactions = new TransactionData().GetRecentTransactions();
            dashboardTransaction.returnTransactions = new TransactionData().GetRecentReturnTransactions();
            return dashboardTransaction;
        }

        //Get Transactions 
        public List<TransactionListModel> GetTransaction(string customerName, string amount, string checkName)
        {
            return new TransactionData().GetTransactions(customerName, amount, checkName);
        }

        //create a method to get a check by id
        public TransactionDetailModel GetTransactionById(int id)
        {
            var transaction = new TransactionData().GetTransactionById(id);

            if (!string.IsNullOrWhiteSpace(transaction.checkImagePath))
                transaction.checkImage = new ImageHelper().GetImage(transaction.checkImagePath);
            if (!string.IsNullOrWhiteSpace(transaction.customer.facePath))
                transaction.customer.face = new ImageHelper().GetImage(transaction.customer.facePath);

            return transaction;
        }

        //Insert transaction
        public void InsertTransaction(AddTransactionModel request)
        {
            int transactionId = new TransactionData().InsertTransaction(request);

            if(request.checkImage != null)
            {
                string transactionCheckPath = new ImageHelper().SaveImage(request.checkImage, transactionId, "TRANSACTIONIMAGE");
                new TransactionData().UpdateTransCheckImagePath(transactionId, transactionCheckPath);
            }
        }

        //Delete Transaction
        public void DeleteTransaction(int id)
        {
            new TransactionData().DeleteTransaction();
        }

        //Update Transaction status
        public void UpdateTransactionStatus(int id, int status)
        {
            new TransactionData().UpdateTransactionStatus(id, status);
        }
    }
}
