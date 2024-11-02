using System.Drawing;

namespace AiCashGuard.Model.UI
{
    public class TransProcessAddCustomerModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string idNumber { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public Image customerFace { get; set; }
        public string customerFaceValue { get; set; }
    }
}
