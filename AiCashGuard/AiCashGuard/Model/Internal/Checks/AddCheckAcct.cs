using System.Drawing;

namespace AiCashGuard.Model.Internal
{
    public class AddCheckAcct
    {
        public string accountNumber { get; set; }
        public string routingNumberId { get; set; }
        public string accountType { get; set; }
        public string accountName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string alertMsg { get; set; }
        public string phone { get; set; }
        public Image checkImageFront { get; set; }
        public Image checkImageBack { get; set; }
    }
}
