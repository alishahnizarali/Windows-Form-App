using System.Drawing;

namespace AiCashGuard.Model.Internal.Transaction
{
    public class TransactionListModel
    {
        public int transactionId { get; set; }
        public string customerName { get; set; }
        public string checkName { get; set; }
        public string checkNumber { get; set; }
        public string checkAmount { get; set; }
        public string checkDate { get; set; }
        public string status { get; set; }
    }
}
