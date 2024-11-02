using AiCashGuard.Constants;
using AiCashGuard.Forms.CustomerModule;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.UserControls;
using AiCashGuard.UserControls.Layouts_rows;
using AiCashGuard.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
	public partial class CustomerList : BaseForm
	{
		// Global variables for pagination
		private int currentPage = 1;
		private int itemsPerPage = 10; // Set items per page
		private List<CustomerModel> allCustomers = new List<CustomerModel>(); // To hold all customers

		public CustomerList()
		{
			InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.customerListPanel, 0, 1); // Row 1 for dashboardPanel
		}

		private void Customer_Load(object sender, EventArgs e)
		{
			allCustomers = new CustomerProcessor().GetCustomers("", "", ""); // Get all customers

            /*allCustomers = new List<CustomerModel>
			{
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 1000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
				new CustomerModel { idNumber = "idNumber", firstName = "firstName", lastName = "lastName", address = "address", phone = "phone", customerId = 15000},
			};*/
			paginationControl1.SetTotalPages(allCustomers.Count);
			paginationControl1.PageChanged += paginationControl1_PageChanged_1;
			LoadData(currentPage);
		}

		private void LoadData(int pageNumber)
		{
			int startIndex = (pageNumber - 1) * PaginationControl.ItemsPerPage;
			var customersForCurrentPage = allCustomers.Skip(startIndex).Take(PaginationControl.ItemsPerPage).ToList();

			DisplayCustomers(customersForCurrentPage);
		}

		private void DisplayCustomers(List<CustomerModel> customers)
		{
			CustRowDataPanel.Controls.Clear();
			CustRowDataPanel.RowCount = 0;
			CustRowDataPanel.RowStyles.Clear();
			foreach (var customer in customers)
			{
				var CustomerRow = new CustomerList_row_layout();
				CustomerRow.LoadCustomer(customer);
				CustomerRow.Margin = new Padding(0);
				CustomerRow.Dock = DockStyle.Top;
				CustRowDataPanel.RowCount++;
				CustRowDataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				CustRowDataPanel.Controls.Add(CustomerRow, 0, CustRowDataPanel.RowCount - 1);
			}
			CustRowDataPanel.Padding = new Padding(0);
			CustRowDataPanel.Margin = new Padding(0);
		}

		private void customerListPanel_Paint(object sender, PaintEventArgs e)
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
            string id = idSearch.Text;
            string customer = customerSearch.Text;
            string phone = phoneSearch.Text;
            allCustomers = new CustomerProcessor().GetCustomers(customer, id, phone);
            paginationControl1.SetTotalPages(allCustomers.Count);
            paginationControl1.PageChanged += paginationControl1_PageChanged_1;
            LoadData(currentPage);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			AddCustomer addCustomer = new AddCustomer();
			addCustomer.ShowDialog();

			if(addCustomer.DialogResult == DialogResult.OK)
			{
                // Refresh the list
                LoadData(currentPage);
            }
		}

		private void paginationControl1_PageChanged_1(object sender, EventArgs e)
		{
			LoadData(paginationControl1.CurrentPage);

		}

		private void CustRowDataPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
