using System.Drawing;

namespace AiCashGuard.Model.Internal.Transaction
{
    public class TransactionDetailModel
    {
        public int transactionId { get; set; }
        public string checkNumber { get; set; }
        public string checkDate { get; set; }
        public string fees { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
        public Image checkImage { get; set; }
        public string checkImagePath { get; set; }
        public TransactionCustomer customer { get; set; }
        public TransactionCheck check { get; set; }
    }

    public class TransactionCustomer
    {
        public string id { get; set; }
        public string idNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
        public Image face { get; set; }
        public string facePath { get; set; }
    }
    public class TransactionCheck
    {
        public string id { get; set; }
        public string accountNumber { get; set; }
        public string name { get; set; }
        public string routingNumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
    }
}
