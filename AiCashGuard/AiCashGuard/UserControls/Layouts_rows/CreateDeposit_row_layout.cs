using AiCashGuard.Forms.DepositModule;
using AiCashGuard.Model.Internal.Deposit;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class CreateDeposit_row_layout : UserControl
	{
		public CreateDepositModel Deposit { get; set; }
		private CreateDeposit obj;
		public CreateDeposit_row_layout(CreateDeposit obj)
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
			Check_Amount.Text= deposit.CheckAmount.ToString();
			
			
		}

		private void IsSelected_CheckedChanged(object sender, System.EventArgs e)
		{
			
		}

		private void IsSelected_Click(object sender, System.EventArgs e)
		{
		
			this.obj.UpdateCheckboxCount();
		}

		private void Check_Transit_Click(object sender, System.EventArgs e)
		{

		}
	}
}
