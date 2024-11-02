using System.Drawing;

namespace AiCashGuard.Model.Internal.Checks
{
    public class EditCheckAcct
    {
        public int checkId { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public string accountType { get; set; }
        public string accountName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string alertMsg { get; set; }
        public string phone { get; set; }
        public Image checkImageFront { get; set; }
        public string checkImageFrontPath { get; set; }
    }
}
