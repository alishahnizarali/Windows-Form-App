using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.TransactionModule;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.Model.UI;
using AiCashGuard.UserControls;
using AiCashGuard.UserControls.Layouts_rows;
using AiCashGuard.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms.CustomerModule
{
	public partial class CustomerDetail : BaseForm
	{
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private TransactionProcessModel transactionProcessModel;
        private List<CheckAcctList> historyCheck = new List<CheckAcctList>();
        public int customerId = 0;
        public CustomerDetailModel custDetails;
        public CustomerDetail(bool inTransactionProcess = false, TransactionProcessModel tpm = null)
		{
            InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.CustomerDetailPanel, 0, 1); // Row 1 for dashboardPanel

            if (inTransactionProcess)
            {
                customerId = tpm.customerId;
                transactionProcessModel = tpm;
                Page_Title.Text = "Select Customer";
                Start_Transaction.Text = "Cancel Transaction";
                Start_Transaction.Padding = new System.Windows.Forms.Padding(0);
                Start_Transaction.Size = new System.Drawing.Size(150, 51);
                Start_Transaction.Image = null;
                Start_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Action_Btn_Panel.Visible = false;
                Back_Btn.Visible = false;
                materialTabControl1.TabPages.Remove(tabPage2);
                materialTabSelector1.Visible = false;
                progressBar1.Increment(transactionProcessModel.step * 18);   // .Increment(33);
                if (transactionProcessModel.customerImage != null)
                {
                    this.CustomerFace.SizeMode = PictureBoxSizeMode.Zoom;
                    this.CustomerFace.Image = transactionProcessModel.customerImage;
                }
            }
            else
            {
                progressBar1.Visible = false;
                transProcessBtnPanel.Visible = false;
            }
        }

		private void CustomerDetail_Load(object sender, EventArgs e)
		{
            custDetails = new CustomerProcessor().GetCustomerById(customerId);
            if (custDetails != null)
            {
                this.Customer_Number.Text = "Customer# " + custDetails.customerId.ToString();
                Cust_IDNumber.Text = custDetails.idNumber;
                Cust_FirstName.Text = custDetails.firstName;
                Cust_Last_Name.Text = custDetails.lastName;
                Cust_Phone.Text = custDetails.phone;
                Cust_Address.Text = custDetails.address;
                Cust_DOB.Text = custDetails.dOB;
                Cust_ZipCode.Text = custDetails.zipCode;
                Alert_TextBox.Text = custDetails.alertMsg;
                Cust_State.Text = custDetails.state;
                Cust_City.Text = custDetails.city;
                Year_Label.Text = Convert.ToDateTime(custDetails.createdOn).ToString("yyyy");
                Num_Trans_Label.Text = custDetails.numTransaction.ToString();
                Num_Return_Label.Text = custDetails.numReturn.ToString();
                Num_Return_Clear_Label.Text = custDetails.numReturnClear.ToString();
                Num_Check_Cashed_Label.Text = custDetails.numCashed.ToString();
                Last_Cashed_On_Label.Text = Convert.ToDateTime(custDetails.lastCashOn).ToString("yyyy-MM-dd");

                if (custDetails.isDefault)
                {
                    Last_Cash_Label.Text = "BLOCKED";
                    Last_Cash_Label.ForeColor = System.Drawing.Color.IndianRed;
                }
                else
                {
                    Last_Cash_Label.Text = "UN BLOCKED";
                    Last_Cash_Label.ForeColor = System.Drawing.Color.Green;
                }

                if (custDetails.customerImage != null)
                {
                    this.CustomerFace.SizeMode = PictureBoxSizeMode.Zoom;
                    this.CustomerFace.Image = custDetails.customerImage;
                }
                if (custDetails.idImageFront != null)
                {
                    this.CustomerIdImgFront.SizeMode = PictureBoxSizeMode.Zoom;
                    this.CustomerIdImgFront.Image = custDetails.idImageFront;
                }
                if (custDetails.idImageBack != null)
                {
                    this.CustomerIdImgBack.SizeMode = PictureBoxSizeMode.Zoom;
                    this.CustomerIdImgBack.Image = custDetails.idImageBack;
                }
            }
        }

        public void CheckForDefault()
        {
            if (custDetails.isDefault)
            {
                DialogResult result = CustomMessageBox.Show("Error", $"This Customer is Blocked but you can still continue your transaction with this customer", "BLOCKED Customer", "Ok");

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                }
            }
        }

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void materialTabSelector1_Click(object sender, EventArgs e)
		{

		}

        private void roundedPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alert_TextBox_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Alert_TextBox.Text))
            {
                DialogResult result = CustomMessageBox.Show("Question", Alert_TextBox.Text, "Customer Alert", "Ok", false);

                if (result == DialogResult.OK)
                {
                }
            }
        }


        private void button13_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.WindowState = this.WindowState;
			dashboard.Show();
		}

		private void AddCheck_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddNewCheck addNewCheck = new AddNewCheck();
			addNewCheck.WindowState = this.WindowState;
			addNewCheck.ShowDialog();
		}

        private void Start_Transaction_Click(object sender, EventArgs e)
        {
            if (transactionProcessModel != null)
            {
                DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to cancel this transaction process?", "Cancel Transaction", "Yes, Cancel");

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.WindowState = this.WindowState;
                    dashboard.Show();
                }
            }
            else
            {
                TransactionProcessModel trans = new TransactionProcessModel()
                {
                    customerId = 1,
                    step = 3,
                    processStartsWith = "Customer"
                };

                this.Hide();
                CheckTransactionProcess CTP = new CheckTransactionProcess(trans);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.CheckScanStatus();
            }
        }

        private void Security_Cust_Click(object sender, EventArgs e)
        {
            if (custDetails.isDefault)
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to UNBLOCK {custDetails.firstName} {custDetails.lastName} ?", "UN BLOCK Customer", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CustomerProcessor().UpdateCustomerStatus(customerId, false);
                    CustomerDetail_Load(sender, e);
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to BLOCK {custDetails.firstName} {custDetails.lastName} ?", "BLOCK Customer", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CustomerProcessor().UpdateCustomerStatus(customerId, true);
                    CustomerDetail_Load(sender , e);
                }
            }
        }

        private void Print_Cust_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Cust_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            editCustomer.LoadCustomer(customerId);
            editCustomer.ShowDialog();
        }

        private void Delete_Cust_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to delete this Check ?", "Delete Check", "Yes, Delete");

            // If OK is clicked, exit the application
            if (result == DialogResult.OK)
            {
                this.Hide();
                CustomerList customerlist = new CustomerList();
                customerlist.WindowState = this.WindowState;
                customerlist.Show();
            }
        }

        private void TransBackBtn_Click(object sender, EventArgs e)
        {
            transactionProcessModel.step -= 1;
            transactionProcessModel.customerId = 0;
            transactionProcessModel.customer = null;
            this.Hide();
            CustomerTransactionProcess CTP = new CustomerTransactionProcess(transactionProcessModel);
            CTP.WindowState = this.WindowState;
            CTP.Show();
        }

        private void TransNextBtn_Click(object sender, EventArgs e)
        {
            transactionProcessModel.step += 1;
            transactionProcessModel.customerId = customerId;
            transactionProcessModel.customer = custDetails;
            if (transactionProcessModel.step == 3)
            {
                this.Hide();
                CheckTransactionProcess CTP = new CheckTransactionProcess(transactionProcessModel);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.CheckScanStatus();
            }
            else if(transactionProcessModel.step == 5)
            {
                this.Hide();
                FinalTransaction FT = new FinalTransaction(transactionProcessModel);
                FT.WindowState = this.WindowState;
                FT.Show();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			CustomerList customerlist = new CustomerList();
			customerlist.WindowState = this.WindowState;
			customerlist.Show();
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

        private void CheckList_Load(object sender, System.EventArgs e)
        {
            historyCheck = new CustomerProcessor().GetCustomerHistory(customerId);
            /*{
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
            PaginationControl.SetTotalPages(historyCheck.Count);
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
            var customersForCurrentPage = historyCheck.Skip(startIndex).Take(PaginationControl.ItemsPerPage).ToList();

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
    }
}
