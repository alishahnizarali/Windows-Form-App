namespace AiCashGuard.Model.Internal.Transaction
{
    public class RecentTransactions
    {
        public int transactionId { get; set; }
        public string transactionDate { get; set; }
        public bool isDeposit { get; set; }
        public string transactionAmount { get; set; }
        public string transactionStatus { get; set; }
    }
}
