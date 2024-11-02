using AiCashGuard.Constants;
using AiCashGuard.Logic.Processor;
using AiCashGuard.Model.Internal.Transaction;
using System;
using System.Windows.Forms;

namespace AiCashGuard.Forms.TransactionModule
{
    public partial class TransactionDetail : BaseForm
    {
        public int transactionId = 0;
        private TransactionDetailModel transDetails;
        public TransactionDetail()
        {
            InitializeComponent();
            BaseTableLayoutPanel.Controls.Add(this.transactionDetailpanel, 0, 1);
        }

        private void TransactionDetail_Load(object sender, EventArgs e)
        {
            transDetails = new TransactionProcessor().GetTransactionById(transactionId);
            if(transDetails != null)
            {
                if(transDetails.checkImage != null)
                    Check_Image.Image = transDetails.checkImage;

                Trans_ID_Label.Text = transDetails.transactionId.ToString();
                Trans_Amount_Label.Text = "$" + transDetails.amount;
                Trans_CheckID_Label.Text = transDetails.checkNumber;
                Trans_CustID_Label.Text = Convert.ToDateTime(transDetails.checkDate).ToString("yyyy-MM-dd");
                Trans_Fee_Label.Text = transDetails.fees.ToString();

                if (transDetails.customer.face != null)
                    Cust_Image.Image = transDetails.customer.face;

                Cust_ID_Label.Text = transDetails.customer.idNumber;
                Cust_Name_Label.Text = transDetails.customer.firstName + " " + transDetails.customer.lastName;
                Cust_Phone_Label.Text = transDetails.customer.phone;
                Cust_Address_Label.Text = transDetails.customer.address;
                //Cust_DOB_Label.Text = transDetails.customer.
                Cust_Add2_Label.Text = transDetails.customer.city + " / " + transDetails.customer.state + " / " + transDetails.customer.zipCode;

                Check_Account_Label.Text = transDetails.check.accountNumber;
                Check_Name_Label.Text = transDetails.check.name;
                Check_Routing_Label.Text = transDetails.check.routingNumber;
                Check_Add2_Label.Text = transDetails.check.city + " / " + transDetails.check.state + " / " + transDetails.check.zipCode;
                Check_Address_Label.Text = transDetails.check.address;
                Check_Phone_Label.Text = transDetails.check.phone;

                if (transDetails.checkImage != null)
                    Check_Image.Image = transDetails.checkImage;

                if(transDetails.status == "0")
                {
                    Trans_Status_Btn.Text = "Cleared";
                    Trans_Status_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
                    Trans_Status_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
                    Mark_Status_Btn.Text = "Mark as Return";
                }
                else if (transDetails.status == "1")
                {
                    Trans_Status_Btn.Text = "Returned";
                    Trans_Status_Btn.ForeColor = System.Drawing.Color.DarkRed;
                    Trans_Status_Btn.BackColor = System.Drawing.Color.IndianRed;
                    Mark_Status_Btn.Text = "Mark as Clear";
                }
                else if (transDetails.status == "2")
                {
                    Trans_Status_Btn.Text = "Clear After Return";
                    Trans_Status_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
                    Trans_Status_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
                    Mark_Status_Btn.Text = "Mark as Return";
                }
            }
        }
        
        private void Mark_Status_Btn_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (transDetails.status == "0" || transDetails.status == "2")
                status = 1;
            else if (transDetails.status == "1")
                status = 2;

            new TransactionProcessor().UpdateTransactionStatus(transDetails.transactionId, status);

            TransactionDetail_Load(sender, e);
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
            this.Hide();
            TransactionList transactionList = new TransactionList();
			transactionList.WindowState = this.WindowState;
			transactionList.Show(this);
		}
	}
}
