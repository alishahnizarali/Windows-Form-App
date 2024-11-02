namespace AiCashGuard.Model.Internal.Checks
{
    public class CheckAcctList
    {
        public int checkId { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public bool isDefault { get; set; }
    }
}
