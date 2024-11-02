namespace AiCashGuard.Model.Internal.Customer
{
    public class CustomerHistory
    {
        public int transactionId { get; set; }
        public string accountNumber { get; set; }
        public string bankName { get; set; }
        public string checkName { get; set; }
        public string phoneNumber { get; set; }
        public string transTime { get; set; }
        public string checkNumber { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
    }
}
