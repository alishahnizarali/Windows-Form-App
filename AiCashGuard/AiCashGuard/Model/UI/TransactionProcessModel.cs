using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using System.Drawing;

namespace AiCashGuard.Model.UI
{
    public class TransactionProcessModel
    {
        public string processStartsWith { get; set; }
        public int customerId { get; set; }
        public int checkId { get; set; }
        public string checkImage { get; set; }
        public int step { get; set; }
        public string checkNumber { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public Image customerImage { get; set; }
        public string customerFaceValue { get; set; }
        public CustomerDetailModel customer { get; set; }
        public CheckDetailModel check { get; set; }
    }
}
