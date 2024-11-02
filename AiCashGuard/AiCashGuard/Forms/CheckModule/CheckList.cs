using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.UserControls.Layouts_rows;
using AiCashGuard.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
	public partial class CheckList : BaseForm
	{
		private int currentPage = 1;
		private int itemsPerPage = 10;
		private List<CheckAcctList> allCheck = new List<CheckAcctList>();
		public CheckList()
		{
			InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.checkListPanel, 0, 1); // Row 1 for dashboardPanel
		}

        private void button8_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
			dashboard.WindowState = this.WindowState;
			dashboard.Show();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            //Get Filter Value
            string account = accountSearch.Text;
            string routing = transitSearch.Text;
            string check = checkSearch.Text;
            allCheck = new CheckAccountProcessor().GetChecksAccount(account, routing, check);
            PaginationControl.SetTotalPages(allCheck.Count);
            PaginationControl.PageChanged += PaginationControl_PageChanged;
            LoadData(currentPage);
        }
        private void checkListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

		private void Customer_Name_Click(object sender, System.EventArgs e)
		{

		}

		private void CheckList_Load(object sender, System.EventArgs e)
		{
            allCheck = new CheckAccountProcessor().GetChecksAccount("", "", ""); // Get all checks

            /*allCheck = new List<CheckModel>
			{
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "30003", TransitNumber = "10110101",CheckNumber = "10110101",BusinessName = "Google", Address = "North Karachi", Phone = "1000"},
				new CheckModel { AccountNumber = "20202020", TransitNumber = "20202020200",CheckNumber = "202020",BusinessName = "Amazon", Address = "North", Phone = "1000"},
			};*/
			PaginationControl.SetTotalPages(allCheck.Count);
			PaginationControl.PageChanged += PaginationControl_PageChanged;
			LoadData(currentPage);
		}
		private void PaginationControl_PageChanged(object sender, EventArgs e)
		{
			LoadData(PaginationControl.CurrentPage);
		}

		private void LoadData(int pageNumber)
		{
			int startIndex = (pageNumber - 1) * PaginationControl.ItemsPerPage;
			var customersForCurrentPage = allCheck.Skip(startIndex).Take(PaginationControl.ItemsPerPage).ToList();

			DisplayChecks(customersForCurrentPage);
		}

		private void DisplayChecks(List<CheckAcctList> checks)
		{
			CheckRowDataPanel.Controls.Clear();
			CheckRowDataPanel.RowCount = 0;
			CheckRowDataPanel.RowStyles.Clear();
			foreach (var check in checks)
			{
				var CheckRow = new CheckList_row_layout();
				CheckRow.LoadCheck(check);
				CheckRow.Margin = new Padding(0);
				CheckRow.Dock = DockStyle.Top;
				CheckRowDataPanel.RowCount++;
				CheckRowDataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				CheckRowDataPanel.Controls.Add(CheckRow, 0, CheckRowDataPanel.RowCount - 1);
			}
			CheckRowDataPanel.Padding = new Padding(0);
			CheckRowDataPanel.Margin = new Padding(0);
		}

		private void AddCheck_Click(object sender, System.EventArgs e)
		{
			AddNewCheck addCheck = new AddNewCheck();
			addCheck.ShowDialog();

		}

		private void CheckRowDataPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
