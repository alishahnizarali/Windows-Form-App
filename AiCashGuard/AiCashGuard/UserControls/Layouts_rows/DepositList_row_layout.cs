using AiCashGuard.Forms.DepositModule;
using AiCashGuard.Model.Internal.Deposit;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class DepositList_row : UserControl
	{

		public DepositListModel Deposit { get; set; }
		private DepositList obj;
		public DepositList_row(DepositList obj)
		{

			InitializeComponent();
			this.obj = obj;
		}
		public void LoadTransaction(DepositListModel deposit)
		{
			this.Deposit = deposit;

			Deposit_ID.Text = deposit.DepositId.ToString();
			Deposit_Amount.Text = deposit.TotalAmount;
			Deposit_Checks.Text = deposit.NoChecks.ToString();
			Deposit_Date.Text = deposit.DepositDate;




		}

		private void Check_Action_Click(object sender, System.EventArgs e)
		{
			CheckActions.Show(Check_Action, 0, Check_Action.Height);
		}
	}
}
