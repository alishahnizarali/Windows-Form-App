using AiCashGuard.Constants;
using AiCashGuard.Logic.Processor;
using AiCashGuard.Model.Internal.Transaction;
using AiCashGuard.UserControls.Layouts_rows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
	public partial class TransactionList : BaseForm
    {
		// Global variables for pagination
		private int currentPage = 1;
		private int itemsPerPage = 10; // Set items per page
		private string filterQuery; 
		private List<TransactionListModel> allTransactions = new List<TransactionListModel>(); // To hold all customers
		public TransactionList(string filter = "All")
		{
            filterQuery = filter;
            InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.transactionListPanel, 0, 1); // Row 1 for dashboardPanel
		}

		private void TransactionList_Load(object sender, EventArgs e)
		{
			allTransactions = new TransactionProcessor().GetTransaction("", "", "");
            /*allTransactions = new List<TransactionModel>
			{
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30003", Customer = "Approved", CheckNumber = "North Karachi",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi", CustomerNumber = "$1000"},
				new TransactionModel { TransactionNumber = "#30004", Customer = "Pending", CheckNumber = "North Karachi",CustomerNumber = "$500",BusinessName = "#30003", Amount = "Approved", Status = "North Karachi"}
			};*/

            PaginationControl.SetTotalPages(allTransactions.Count);
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
			var customersForCurrentPage = allTransactions.Skip(startIndex).Take(PaginationControl.ItemsPerPage).ToList();

			DisplayTransactions(customersForCurrentPage);
		}
		private void DisplayTransactions(List<TransactionListModel> transactions)
		{
			TransactionDataPanel.Controls.Clear();
			TransactionDataPanel.RowCount = 0;
			TransactionDataPanel.RowStyles.Clear();
			foreach (var transaction in transactions)
			{
				var TransactionRow = new Transaction_row_layout();
				TransactionRow.LoadTransaction(transaction);
				TransactionRow.Margin = new Padding(0);
				TransactionRow.Dock = DockStyle.Top;
				TransactionDataPanel.RowCount++;
				TransactionDataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				TransactionDataPanel.Controls.Add(TransactionRow, 0, TransactionDataPanel.RowCount - 1);
			}
			TransactionDataPanel.Padding = new Padding(0);
			TransactionDataPanel.Margin = new Padding(0);
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
			//Get Filter Value
			string transaction = transactionSearch.Text;
			string customer = customerSearch.Text;
			string check = checkSearch.Text;
            allTransactions = new TransactionProcessor().GetTransaction(customer, transaction, check);
            PaginationControl.SetTotalPages(allTransactions.Count);
            PaginationControl.PageChanged += PaginationControl_PageChanged;
            LoadData(currentPage);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

		private void CustomerDataPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
