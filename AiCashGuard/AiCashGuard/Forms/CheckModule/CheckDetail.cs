using AiCashGuard.Constants;
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

namespace AiCashGuard.Forms.CheckModule
{
    public partial class CheckDetail : BaseForm
    {
        // Global variables for pagination
        private int currentPage = 1;
        private int itemsPerPage = 10; // Set items per page
        private List<CustomerModel> allCustomers = new List<CustomerModel>(); // To hold all customers
        public int checkId = 0;
        public CheckDetailModel checkDetails;
        TransactionProcessModel transactionProcessModel;

        public CheckDetail(bool inTransactionProcess = false, TransactionProcessModel tpm = null)
        {
            InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.CheckDetailPanel, 0, 1);

            if (inTransactionProcess)
            {
                checkId = tpm.checkId;
                transactionProcessModel = tpm;
                Page_Title.Text = "Select Check";
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
                if(!string.IsNullOrWhiteSpace(transactionProcessModel.accountNumber))
                    this.Check_AccountNumber.Text = transactionProcessModel.accountNumber;
                if (!string.IsNullOrWhiteSpace(transactionProcessModel.routingNumber))
                    this.Check_TransitNumber.Text = transactionProcessModel.routingNumber;
            }
            else
            {
                progressBar1.Visible = false;
                transProcessBtnPanel.Visible = false;
            }
        }

        private void CheckDetail_Load(object sender, EventArgs e)
        {
            checkDetails = new CheckAccountProcessor().GetCheckAccountById(checkId);
            if (checkDetails != null)
            {
                Check_AccountNumber.Text = checkDetails.accountNumber;
                Check_TransitNumber.Text = checkDetails.routingNumber;
                Check_Name.Text = checkDetails.name;
                Check_Phone.Text = checkDetails.phone;
                Check_Address.Text = checkDetails.address;
                Check_City.Text = checkDetails.city;
                Check_State.Text = checkDetails.state;
                Check_ZipCode.Text = checkDetails.zipCode;
                Alert_TextBox.Text = checkDetails.alertMsg;
                Year_Label.Text = Convert.ToDateTime(checkDetails.createdOn).ToString("yyyy");
                Num_Transaction_Label.Text = checkDetails.numTransaction.ToString();
                Num_Return_Label.Text = checkDetails.numReturn.ToString();
                Num_Return_Clear_Label.Text = checkDetails.numReturnClear.ToString();
                Check_Cashed.Text = checkDetails.numCashed.ToString();
                Last_Cash_On_Label.Text = Convert.ToDateTime(checkDetails.lastCashOn).ToString("yyyy/MM/dd");

                if (checkDetails.isDefault)
                {
                    Last_Cash_Label.Text = "BLOCKED";
                    Last_Cash_Label.ForeColor = System.Drawing.Color.IndianRed;
                }
                else
                {
                    Last_Cash_Label.Text = "UN BLOCKED";
                    Last_Cash_Label.ForeColor = System.Drawing.Color.Green;
                }

                if (checkDetails.checkImageFront != null)
                {
                    this.Check_Image.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Check_Image.Image = checkDetails.checkImageFront;
                }

                if (checkDetails.isDefault)
                {
                    DialogResult result = CustomMessageBox.Show("Error", $"This Check is Blocked but you can still continue your transaction with this check", "BLOCKED Check", "Ok");

                    // If OK is clicked, exit the application
                    if (result == DialogResult.OK)
                    {
                    }
                }
            }
        }

        private void Alert_TextBox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Alert_TextBox.Text))
            {
                DialogResult result = CustomMessageBox.Show("Question", Alert_TextBox.Text, "Check Alert", "Ok", false);

                if (result == DialogResult.OK)
                {
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

		private void materialTabSelector1_Click(object sender, EventArgs e)
		{

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
                    checkId = checkId,
                    check = checkDetails,
                    step = 1,
                    processStartsWith = "Check"
                };

                this.Hide();
                CheckTransactionProcess CTP = new CheckTransactionProcess(trans);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.CheckScanStatus();
            }
        }

        private void Security_Check_Click(object sender, EventArgs e)
        {
            if (checkDetails.isDefault)
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to UNBLOCK {checkDetails.name} ?", "UN BLOCK Check", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CheckAccountProcessor().UpdateCheckAccountStatus(checkDetails.checkId, false);
                    CheckDetail_Load(sender, e);
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to BLOCK {checkDetails.name} ?", "BLOCK Check", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CheckAccountProcessor().UpdateCheckAccountStatus(checkDetails.checkId, true);
                    CheckDetail_Load(sender, e);
                }
            }
        }

        private void Print_Check_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Check_Click(object sender, EventArgs e)
        {
            EditCheck checkEdit = new EditCheck();
            checkEdit.LoadCheck(checkId);
            checkEdit.ShowDialog();
        }

        private void Delete_Check_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to delete this Check ?", "Delete Check", "Yes, Delete");

            // If OK is clicked, exit the application
            if (result == DialogResult.OK)
            {
                this.Hide();
                CheckList Checklist = new CheckList();
                Checklist.WindowState = this.WindowState;
                Checklist.Show();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
		{
            this.Hide();
            CheckList Checklist = new CheckList();
			Checklist.WindowState = this.WindowState;
			Checklist.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.WindowState = this.WindowState;
			dashboard.Show();
		}

        private void TransBackBtn_Click(object sender, EventArgs e)
        {
            transactionProcessModel.step -= 1;
            transactionProcessModel.checkId = 0;
            transactionProcessModel.check = null;
            this.Hide();
            CheckTransactionProcess CTP = new CheckTransactionProcess(transactionProcessModel);
            CTP.WindowState = this.WindowState;
            CTP.Show();
        }

        private void TransNextBtn_Click(object sender, EventArgs e)
        {
            transactionProcessModel.step += 1;
            transactionProcessModel.checkId = checkId;
            transactionProcessModel.check = checkDetails;
            if (transactionProcessModel.step == 3)
            {
                this.Hide();
                CustomerTransactionProcess CTP = new CustomerTransactionProcess(transactionProcessModel);
                CTP.WindowState = this.WindowState;
                CTP.Show();
            }
            else if (transactionProcessModel.step == 5)
            {
                this.Hide();
                FinalTransaction FT = new FinalTransaction(transactionProcessModel);
                FT.WindowState = this.WindowState;
                FT.Show();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

        private void Customer_Load(object sender, EventArgs e)
        {
            allCustomers = new CheckAccountProcessor().GetCheckAccountHistory(checkId);
            /*{
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
            PaginationControl.SetTotalPages(allCustomers.Count);
            PaginationControl.PageChanged += PaginationControl_PageChanged;
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

        private void PaginationControl_PageChanged(object sender, EventArgs e)
        {
            LoadData(PaginationControl.CurrentPage);

        }
    }
}
