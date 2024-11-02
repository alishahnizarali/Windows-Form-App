using System.Drawing;

namespace AiCashGuard.Model.Internal.Checks
{
    public class CheckDetailModel
    {
        public int checkId { get; set; }
        public string name { get; set; }
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public string bankName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string bankLogo { get; set; }
        public Image checkImageFront { get; set; }
        public string checkImageFrontPath { get; set; }
        public Image checkImageBack { get; set; }
        public string checkImageBackPath { get; set; }
        public string alertMsg { get; set; }
        public string createdOn { get; set; }
        public int numTransaction { get; set; }
        public int numReturn { get; set; }
        public int numCashed { get; set; }
        public int numReturnClear { get; set; }
        public string lastCashOn { get; set; }
        public bool isDefault { get; set; }
    }
}
