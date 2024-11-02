using System;
using System.Drawing;

namespace AiCashGuard.Model.Internal.Customer
{
    public class EditCustomerModel
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string idNumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime dOB { get; set; }
        public Image customerImage { get; set; }
        public string customerImagePath { get; set; }
        public float[] customerFaceValue { get; set; }
        public Image idImageFront { get; set; }
        public string idImageFrontPath { get; set; }
        public Image idImageBack { get; set; }
        public string idImageBackPath { get; set; }
        public string alertMsg { get; set; }
        public bool isDefault { get; set; }
    }
}
