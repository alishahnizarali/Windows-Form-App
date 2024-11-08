﻿namespace AiCashGuard.Model.Internal.Checks
{
    public class CheckAcctHistory
    {
        public int transactionId { get; set; }
        public int customerId { get; set; }
        public string idNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string status { get; set; }
    }
}
