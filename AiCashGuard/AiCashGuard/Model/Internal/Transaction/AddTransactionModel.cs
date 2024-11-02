using System;
using System.Drawing;

namespace AiCashGuard.Model.Internal.Transaction
{
    public class AddTransactionModel
    {
        public int checkId { get; set; }
        public int customerId { get; set; }
        public double amount { get; set; }
        public string status { get; set; }
        public string checkNumber { get; set; }
        public DateTime checkDate { get; set; }
        public Image checkImage { get; set; }
        public string checkImagePath { get; set; }
        public string feeAmount { get; set; }
    }
}
