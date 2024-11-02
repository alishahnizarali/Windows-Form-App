using System.Drawing;

namespace AiCashGuard.Model.Internal.Customer
{
    public class CustomerModel
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string idNumber { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public bool isDefault { get; set; }
    }
}
