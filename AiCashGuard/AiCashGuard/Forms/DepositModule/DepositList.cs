using AiCashGuard.Constants;
using AiCashGuard.Model.Internal.Deposit;
using AiCashGuard.UserControls.Layouts_rows;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AiCashGuard.Forms.DepositModule
{
	public partial class DepositList : BaseForm
	{
		private List<DepositListModel> allDeposit = new List<DepositListModel>();
		public DepositList()
		{
			InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.depositListPanel, 0, 1); // Row 1 for dashboardPanel

			allDeposit = new List<DepositListModel>
			{
				new DepositListModel { DepositId = 1 , DepositDate = "12/12/24", NoChecks = "4" , TotalAmount = "5000"},
				new DepositListModel { DepositId = 2 , DepositDate = "12/12/24", NoChecks = "5" , TotalAmount = "6000"},
			};

			DisplayTransactions(allDeposit);
		}
		private void DisplayTransactions(List<DepositListModel> deposits)
		{
			CustRowDataPanel.Controls.Clear();
			CustRowDataPanel.RowCount = 0;
			CustRowDataPanel.RowStyles.Clear();
			foreach (var deposit in deposits)
			{
				var TransactionRow = new DepositList_row(this);
				TransactionRow.LoadTransaction(deposit);
				TransactionRow.Margin = new Padding(0);
				TransactionRow.Dock = DockStyle.Top;
				CustRowDataPanel.RowCount++;
				CustRowDataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				CustRowDataPanel.Controls.Add(TransactionRow, 0, CustRowDataPanel.RowCount - 1);
			}
			CustRowDataPanel.Padding = new Padding(0);
			CustRowDataPanel.Margin = new Padding(0);
		}
		private void CustRowDataPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label5_Click(object sender, System.EventArgs e)
		{

		}
	}
}
