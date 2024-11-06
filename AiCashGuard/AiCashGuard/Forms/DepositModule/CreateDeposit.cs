using AiCashGuard.Constants;
using AiCashGuard.Model.Internal.Deposit;
using AiCashGuard.UserControls.Layouts_rows;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AiCashGuard.Forms.DepositModule
{
	public partial class CreateDeposit : BaseForm
	{
		private List<CreateDepositModel> allDeposit = new List<CreateDepositModel>();

		public CreateDeposit()
		{
			InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.BackPanel, 0, 1);
			allDeposit = new List<CreateDepositModel>
			{
				new CreateDepositModel { CheckNumber = "North Karachi",CheckDate = "#30003", CheckAmount = "100", Status = 1,CheckName="Name" , TransactionId = 2},
				new CreateDepositModel { CheckNumber = "North Karachi",CheckDate = "#30003", CheckAmount = "200", Status = 0, CheckName= "Name" , TransactionId=1},
			};

			DisplayTransactions(allDeposit);
		}


	

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void DisplayTransactions(List<CreateDepositModel> deposits)
		{
			CustRowDataPanel.Controls.Clear();
			CustRowDataPanel.RowCount = 0;
			CustRowDataPanel.RowStyles.Clear();
			foreach (var deposit in deposits)
			{
				var TransactionRow = new CreateDeposit_row_layout(this);
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
		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void CustRowDataPanel_Paint(object sender, PaintEventArgs e)
		{

		}
		public void UpdateCheckboxCount()
		{
			int count = 0;
			int total_amount = 0;

			foreach (Control control in CustRowDataPanel.Controls)
			{
				if (control is CreateDeposit_row_layout customRow && customRow.IsSelected != null)
				{
					if (customRow.IsSelected.Checked)
					{
						count++;
						total_amount += Convert.ToInt32(customRow.Check_Amount.Text);
					}
					
				}
			}
			if (allDeposit.Count == count)
			{
				SelectCheckBox.Checked = true;
			}
			else
			{
				SelectCheckBox.Checked = false;
			}

			TotalTransactions.Text = count.ToString();
			TotalAmount.Text = total_amount.ToString();


		}

		private void SelectCheckBox_Click(object sender, EventArgs e)
		{
		
			int count = 0;
			int total_amount = 0;
			foreach (Control control in CustRowDataPanel.Controls)
			{
				if (control is CreateDeposit_row_layout customRow && customRow.IsSelected != null)
				{
					count++;
					customRow.IsSelected.Checked = SelectCheckBox.Checked;
					total_amount += Convert.ToInt32(customRow.Check_Amount.Text);
				}
			}
			if (!SelectCheckBox.Checked)
			{ 
				TotalTransactions.Text = "0";
				TotalAmount.Text = "0";
			}
			else
			{
				TotalTransactions.Text = count.ToString();
				TotalAmount.Text = total_amount.ToString();
			}
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
