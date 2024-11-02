namespace AiCashGuard.Model.Internal.Report
{
    public class TransactionNumberModel
    {
        public int totalTransactions { get; set; }
        public decimal totalAmount { get; set; }
        public decimal averageAmount { get; set; }
        public int numOfCleared { get; set; }
        public int numOfReturn { get; set; }
        public int numOfReturnCleared { get; set; }
    }
}
