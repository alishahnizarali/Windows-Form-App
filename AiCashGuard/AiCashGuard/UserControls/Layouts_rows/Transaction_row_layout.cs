using AiCashGuard.Forms.TransactionModule;
using AiCashGuard.Model.Internal.Transaction;
using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class Transaction_row_layout : UserControl
	{
		public TransactionListModel Transaction { get; set; }  // Add this property
		public Transaction_row_layout()
		{
			InitializeComponent();
		}
		public void LoadTransaction(TransactionListModel transaction)
		{
			this.Transaction = transaction; // Assign the customer data to the property
			Transaction_Number.Text = transaction.transactionId.ToString();
			Transaction_Check.Text = transaction.checkName;
			Transaction_CheckNumber.Text = transaction.checkNumber;
			Transaction_Customer.Text = transaction.customerName;
			Transaction_CheckDate.Text = transaction.checkDate;
			Transaction_Amount.Text = transaction.checkAmount;

            if (transaction.status == "0")
            {
                Transaction_Status.Text = "Cleared";
                Transaction_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            }
            else if (transaction.status == "1")
            {
                Transaction_Status.Text = "Returned";
                Transaction_Status.BackColor = System.Drawing.Color.IndianRed;
            }
            else if (transaction.status == "2")
            {
                Transaction_Status.Text = "Clear After Return";
                Transaction_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            }

        }
		private TransactionListModel GetCurrentTransactionData()
		{
			return this.Transaction;
		}
		private void Customer_Action_Click(object sender, EventArgs e)
		{
			TransactionActions.Show(Customer_Action, 0, Customer_Action.Height);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			
		}

		private void DetailsToolStrip_Click(object sender, EventArgs e)
		{
			
		}

		private void DetailsToolStrip_Click_1(object sender, EventArgs e)
		{
			var transaction = GetCurrentTransactionData();

            Form parentForm = this.FindForm();

			// Hide the parent form
			if (parentForm != null)
			{
				parentForm.Hide();
			}
			TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.transactionId = transaction.transactionId;
            transactionDetail.WindowState = parentForm.WindowState;
			transactionDetail.Show();
		}
	}
}
