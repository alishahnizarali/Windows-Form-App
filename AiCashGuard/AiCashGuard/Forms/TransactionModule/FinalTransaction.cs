using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.CustomerModule;
using AiCashGuard.Logic.Processor;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.Model.Internal.Transaction;
using AiCashGuard.Model.UI;
using AiCashGuard.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms.TransactionModule
{
	public partial class FinalTransaction : BaseForm
	{
        TransactionProcessModel transactionProcessModel;
        public FinalTransaction(TransactionProcessModel tpm)
		{
            transactionProcessModel = tpm;
            InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.BackPanel, 0, 1); // Row 1 for dashboardPanel
			transactionProgressBar.Increment(90);
            if (!string.IsNullOrWhiteSpace(transactionProcessModel.checkImage))
            {
                byte[] imageBytes = Convert.FromBase64String(transactionProcessModel.checkImage);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                this.Check_Image.SizeMode = PictureBoxSizeMode.Zoom;
                this.Check_Image.Image = Image.FromStream(ms);
            }
            if (!string.IsNullOrWhiteSpace(transactionProcessModel.checkNumber))
            {
                this.Check_Number.Text = transactionProcessModel.checkNumber;
            }
            if(transactionProcessModel.customerImage != null)
            {
                this.Cust_Image.SizeMode = PictureBoxSizeMode.Zoom;
                this.Cust_Image.Image = transactionProcessModel.customerImage;
            }
            if (transactionProcessModel.customer != null)
            {
                GetCustomerDetails(transactionProcessModel.customer);
            }
            if (transactionProcessModel.check != null)
            {
                GetCheckDetails(transactionProcessModel.check);
            }
        }

        private void GetCustomerDetails(CustomerDetailModel customer)
        {
            Cust_Add2_Label.Text = customer.city + " / " + customer.state + " / " + customer.zipCode;
            Cust_Phone_Label.Text = customer.phone;
            Cust_DOB_Label.Text = customer.dOB;
            Cust_Address_Label.Text = customer.address;
            Cust_Name_Label.Text = customer.firstName + " " + customer.lastName;
            Cust_ID_Label.Text = customer.idNumber;

            if(Cust_Image.Image == null)
            {
                Cust_Image.Image = customer.customerImage ?? null;
            }
        }

        private void GetCheckDetails(CheckDetailModel check)
        {
            Check_Add2_Label.Text = check.city + " / " + check.state + " / " + check.zipCode;
            Check_Phone_Label.Text = check.phone;
            Check_Address_Label.Text = check.address;
            Check_Name_Label.Text = check.name;
            Check_Account_Label.Text = check.accountNumber;
            Check_Routing_Label.Text = check.routingNumber;
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void transactionProgressBar_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void Cancel_Transaction_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to cancel this transaction process", "Transaction Cancel !", "Yes", true);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
		{
            transactionProcessModel.step -= 1;
            if (transactionProcessModel.processStartsWith == "Customer")
            {
                this.Hide();
                CheckDetail CD = new CheckDetail(true, transactionProcessModel);
                CD.WindowState = this.WindowState;
                CD.Show();
            }
            else if (transactionProcessModel.processStartsWith == "Check")
            {
                this.Hide();
                CustomerDetail CD = new CustomerDetail(true, transactionProcessModel);
                CD.WindowState = this.WindowState;
                CD.Show();
            }
		}

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Cash_Now_Btn_Click(object sender, EventArgs e)
        {
            if (ValidateTransaction())
            {
                AddTransactionModel trans = new AddTransactionModel()
                {
                    customerId = transactionProcessModel.customerId,
                    checkId = transactionProcessModel.checkId,
                    amount = Convert.ToDouble(this.Check_Amount.Text),
                    status = "0",
                    feeAmount = this.Trans_Fees.Text,
                    checkNumber = this.Check_Number.Text,
                    checkImage = this.Check_Image.Image,
                    checkDate = this.Check_Date.Value,
                };

                new TransactionProcessor().InsertTransaction(trans);

                DialogResult result = CustomMessageBox.Show("Success", "Your transaction has been completed", "Transaction Successful !", "OK", false);

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.WindowState = this.WindowState;
                    dashboard.Show();
                }
            }
        }

        private bool ValidateTransaction()
        {
            List<string> error = new List<string>();
            if(string.IsNullOrWhiteSpace(this.Trans_Fees.Text))
                error.Add("Please enter the transaction fees");
            if (string.IsNullOrWhiteSpace(this.Check_Number.Text))
                error.Add("Please enter the check number");
            if (string.IsNullOrWhiteSpace(this.Check_Amount.Text))
                error.Add("Please enter the check amount");
            if (string.IsNullOrWhiteSpace(DateTime.Now.Date.ToString()))
                error.Add("Please enter the check date");

            if (error.Count > 0)
            {
                DialogResult result = CustomMessageBox.Show("Error", string.Join("\n", error), "Transaction Error !", "OK", false);
                if (result == DialogResult.OK)
                {   
                }
                return false;
            }
            else
                return true;
        }
    }
}
