using AiCashGuard.Forms.DepositModule;
using AiCashGuard.Model.Internal.Deposit;
using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class DepositDetail_row : UserControl
	{
		public CreateDepositModel Deposit { get; set; }
		private DepositDetail obj;
		public DepositDetail_row(DepositDetail obj)
		{
			InitializeComponent();
			this.obj = obj;
		}
	
		public void LoadTransaction(CreateDepositModel deposit)
		{
			this.Deposit = deposit;
			Check_Name.Text = deposit.CheckName;
			Check_Date.Text = deposit.CheckDate;
			Check_Status.Text = deposit.Status.ToString();
			Check_Transit.Text = deposit.TransactionId.ToString();
			Check_Number.Text = deposit.CheckNumber;
			Check_Amount.Text = deposit.CheckAmount.ToString();

		}

		private void IsSelected_Click(object sender, EventArgs e)
		{
			this.obj.UpdateCheckboxCount();
		}

		private void Check_Transit_Click(object sender, EventArgs e)
		{

		}
	}
}
