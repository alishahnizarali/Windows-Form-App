using AiCashGuard.Forms;
using AiCashGuard.Forms.CustomerModule;
using AiCashGuard.Forms.TransactionModule;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.Model.UI;
using AiCashGuard.Processor;
using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class CustomerList_row_layout : UserControl
	{
		public CustomerModel Customer { get; set; }  // Add this property
		public CustomerList_row_layout()
		{
			InitializeComponent();
		}
		public void LoadCustomer(CustomerModel customer)
		{
			this.Customer = customer; // Assign the customer data to the property
			Customer_ID.Text = customer.idNumber;
			Customer_Name.Text = customer.firstName;
			Customer_LastName.Text = customer.lastName;
			Customer_Phone.Text = customer.phone;
			Customer_Address.Text = customer.address;
			Customer_Flag.Text = customer.isDefault.ToString();
            if (customer.isDefault)
                Customer_Flag.BackColor = System.Drawing.Color.IndianRed;
            else
                Customer_Flag.BackColor = System.Drawing.Color.Green;
        }
		private CustomerModel GetCurrentCustomerData()
		{
			return this.Customer;
		}
		private void Customer_Action_Click(object sender, EventArgs e)
		{
			CustomerActions.Show(Customer_Action, 0, Customer_Action.Height);
		}

		private void startTransactionMenuItem_Click(object sender, EventArgs e)
		{
			var customer = GetCurrentCustomerData();
            TransactionProcessModel trans = new TransactionProcessModel()
            {
                customerId = customer.customerId,
                step = 3,
                processStartsWith = "Customer"
            };

            Form parentForm = this.FindForm();

            // Hide the parent form
            if (parentForm != null)
            {
                parentForm.Hide();
            }

            CheckTransactionProcess CTP = new CheckTransactionProcess(trans);
            CTP.WindowState = parentForm.WindowState;
            CTP.Show();
			CTP.CheckScanStatus();
        }

		private void editMenuItem_Click(object sender, EventArgs e)
		{
			var customer = GetCurrentCustomerData();
			EditCustomer editCustomer = new EditCustomer();
			editCustomer.LoadCustomer(customer.customerId);
			editCustomer.ShowDialog();
		}

		private void deleteMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to delete this Customer ?", "Customer Delete", "Yes, Delete");

			// If OK is clicked, exit the application
			if (result == DialogResult.OK)
			{
                Form parentForm = this.FindForm();

                // Hide the parent form
                if (parentForm != null)
                {
                    parentForm.Hide();
                }

                CustomerList custList = new CustomerList();
                custList.WindowState = parentForm.WindowState;
                custList.Show();
            }
		}

		private void printMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void securityMenuItem_Click(object sender, EventArgs e)
		{
            var customer = GetCurrentCustomerData();
            if (customer.isDefault)
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to UNBLOCK {customer.firstName} {customer.lastName} ?", "UN BLOCK Customer", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CustomerProcessor().UpdateCustomerStatus(customer.customerId, false);

                    Form parentForm = this.FindForm();

                    // Hide the parent form
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }

                    CustomerList custList = new CustomerList();
                    custList.WindowState = parentForm.WindowState;
                    custList.Show();
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to BLOCK {customer.firstName} {customer.lastName} ?", "BLOCK Customer", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CustomerProcessor().UpdateCustomerStatus(customer.customerId, true);
                    Form parentForm = this.FindForm();

                    // Hide the parent form
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }

                    CustomerList custList = new CustomerList();
                    custList.WindowState = parentForm.WindowState;
                    custList.Show();
                }
            }
        }

		private void CustomerList_row_layout_Load(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void DetailsToolStrip_Click(object sender, EventArgs e)
		{
            var customer = GetCurrentCustomerData();
            Form parentForm = this.FindForm();

			// Hide the parent form
			if (parentForm != null)
			{
				parentForm.Hide();
			}

			CustomerDetail customerDetail = new CustomerDetail();
			customerDetail.customerId = customer.customerId;
            customerDetail.WindowState = parentForm.WindowState;
			customerDetail.Show();
		}
	}
}
