using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.CustomerModule;
using AiCashGuard.Model.UI;
using AiCashGuard.UserControls;
using AiCashGuard.Processor;
//Moiz-Comment
//using ExcellaSTX.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AiCashGuard.Model.Internal.Customer;
using System.Threading.Tasks;
namespace AiCashGuard.Forms.TransactionModule
{
    public partial class CustomerTransactionProcess : BaseForm
    {
		//Moiz-Comment
		//private static ScannerController scanner;
		TransactionProcessModel transactionProcessModel;
        private static bool isAutoMSR;
        public CustomerTransactionProcess(TransactionProcessModel tpm = null)
        {
            if (tpm == null)
            {
                tpm = new TransactionProcessModel()
                {
                    step = 1,
                    processStartsWith = "Customer"
                };
            }

            transactionProcessModel = tpm;
            InitializeComponent();
            Next_Btn.Visible = false;
            BaseTableLayoutPanel.Controls.Add(this.BackPanel, 0, 1); // Row 1 for dashboardPanel
            transactionProgressBar.Increment(transactionProcessModel.step * 18);

            if (transactionProcessModel.processStartsWith == "Check")
            {
                Step_Label.Text = "Step # 2 / 3";
            }
            else
            {
                Step_Label.Text = "Step # 1 / 3";
            }
        }

        private async void CustomerTransactionProcess_Load(object sender, EventArgs e)
        {
            try
            {
                var response = await ReadMSRData();

                if (response != null)
                {
                    int customerId = new CustomerProcessor().CheckCustomerExist(response.firstName, response.lastName, response.idNumber, Convert.ToDateTime(response.dob));

                    if (customerId == 0)
                    {
                        AddCustomer addcustomer = new AddCustomer(response);
                        addcustomer.ShowDialog();
                        if (addcustomer.DialogResult == DialogResult.OK)
                        {
                            Next_Btn_Click(addcustomer.customerId);
                        }
                        else
                        {
                            CustomerTransactionProcess_Load(sender, e);
                        }
                    }
                    else
                    {
                        Next_Btn_Click(customerId);
                    }
                }
            }
            catch (Exception ex)
            {
                //CustomMessageBox.Show("Error", ex.Message, "Error", "OK", false);
            }
        }

        public void AddNewTransactionCheck()
        {
            if (!string.IsNullOrWhiteSpace(transactionProcessModel.customerFaceValue) && transactionProcessModel.customerImage != null)
            {
                TransProcessAddCustomerModel tAddCust = new TransProcessAddCustomerModel()
                {
                    customerFace = transactionProcessModel.customerImage,
                    customerFaceValue = transactionProcessModel.customerFaceValue
                };

                AddCustomer addNewCust = new AddCustomer(tAddCust);
                addNewCust.ShowDialog();

                if (addNewCust.DialogResult == DialogResult.OK)
                {
                    Next_Btn_Click(addNewCust.customerId);
                }
            }
        }

        private void Add_Cust_Btn_Click(object sender, EventArgs e)
        {
            StopAutoMSRRead();
            AddCustomer addNewCust = new AddCustomer();
            addNewCust.ShowDialog();
            if (addNewCust.DialogResult == DialogResult.OK)
            {
                Next_Btn_Click(addNewCust.customerId);
            }
        }

        private async void Next_Btn_Click(int customerId)
        {
            StopAutoMSRRead();
            transactionProcessModel.customerId = customerId;
            transactionProcessModel.step += 1;
            this.Hide();
            CustomerDetail CTP = new CustomerDetail(true, transactionProcessModel);
            CTP.WindowState = this.WindowState;
            CTP.Show();
            CTP.CheckForDefault();
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            StopAutoMSRRead();
            if (transactionProcessModel.processStartsWith == "Check")
            {
                transactionProcessModel.step -= 1;
                this.Hide();
                CheckDetail CD = new CheckDetail(true, transactionProcessModel);
                CD.WindowState = this.WindowState;
                CD.Show();
            }
            else
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
            }
        }

        private void transactionProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*private async void pictureBox1_Click(object sender, EventArgs e)
        {
            scanner = new ScannerController();
            var response = await scanner.MSRScanOnClick();
            if(response != null)
            {
                if(!string.IsNullOrWhiteSpace(response.firstName))
                {
                    TransProcessAddCustomerModel transProcessAddCustomerModel = new TransProcessAddCustomerModel()
                    {
                        firstName = response.firstName,
                        lastName = response.lastName,
                        idNumber = response.idNumber,
                        address = response.address,
                        city = response.city,
                        state = response.stateCode,
                        zipCode = response.zipCode,
                        dob = response.dateOfBirth,
                    };

                    AddCustomer addcustomer = new AddCustomer(transProcessAddCustomerModel);
                    addcustomer.ShowDialog();
                }
                else
                {
                    DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "OK", false);
                    if (result == DialogResult.OK)
                    {
                    }
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "OK", false);
                if (result == DialogResult.OK)
                {
                }
            }
        }*/

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void populateSearchData(List<SearchCustomerListModel> data)
        {
            searchTableLayoutPanel.Controls.Clear();
            searchTableLayoutPanel.RowCount = 0;
            searchTableLayoutPanel.RowStyles.Clear();

            foreach (var item in data)
            {
                var label = new Label();
                label.Text = item.customerName; // Set the label text to the current item
                label.Tag = item.customerId; // Set the tag to the current item
                label.Margin = new Padding(0); // Remove margin
                label.Dock = DockStyle.Top; // Set the dock style

                label.MouseLeave += (s, e) => label.BackColor = Color.Transparent; // Change the back color on hover
                label.MouseEnter += (s, e) => label.BackColor = Color.Gray; // Change the back color on hover
                label.Padding = new Padding(0, 8, 0, 8);
                label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                label.AutoSize = true; // Adjusts size automatically based on content
                label.Click += (s, e) =>
                {
                    // Set the text box text to the label text
                    //materialSingleLineTextField1.Text = label.Text;
                    searchCustomerClick(label.Tag.ToString());
                }; // Add a click event to the label

                searchTableLayoutPanel.RowCount++;
                searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                searchTableLayoutPanel.Controls.Add(label, 0, searchTableLayoutPanel.RowCount - 1);
            }

            searchTableLayoutPanel.Padding = new Padding(10, 0, 10, 0);
            searchTableLayoutPanel.Margin = new Padding(0);
        }


        private void Cust_SearchBar_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Find the panel by name
            Panel panel = this.Controls.Find("searchPanel", true).FirstOrDefault() as Panel;

            if (panel != null)
            {
                // Show the panel if the text box is not empty, otherwise hide it
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    var custList = new CustomerProcessor().GetCustomerByName(textBox.Text);

                    if (custList != null && custList.Count > 0)
                    {
                        panel.Visible = true; // Show the panel
                        populateSearchData(custList);
                    }
                    else
                    {
                        panel.Visible = false; // Hide the panel
                    }
                }
                else
                {
                    panel.Visible = false; // Hide the panel
                }
            }
        }

        private void searchCustomerClick(string customerId)
        {
            Next_Btn_Click(Convert.ToInt32(customerId));
        }

        private void Cancel_Transaction_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to cancel this transaction process", "Transaction Cancel !", "Yes", true);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
            }
        }

        public async Task<TransProcessAddCustomerModel> ReadMSRData()
        {
            //scanner = new ScannerController();
            //isAutoMSR = true;
            //while (isAutoMSR)
            //{
            //    var response = await scanner.MSRScanOnClick();

            //    if (response != null)
            //    {
            //        if (!string.IsNullOrWhiteSpace(response.firstName))
            //        {
            //            TransProcessAddCustomerModel transProcessAddCustomerModel = new TransProcessAddCustomerModel()
            //            {
            //                firstName = response.firstName,
            //                lastName = response.lastName,
            //                idNumber = response.idNumber.Substring(6),
            //                address = response.address,
            //                city = response.city,
            //                state = response.stateCode,
            //                zipCode = response.zipCode,
            //                dob = response.dateOfBirth.Insert(4, "/").Insert(7, "/"),
            //            };
            //            return transProcessAddCustomerModel;
            //        }
            //        else
            //        {
            //            DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "Swipe Again", true);
            //            if (result == DialogResult.OK)
            //            {
            //                continue;
            //            }
            //            else
            //                return null;
            //        }
            //    }
            //    else
            //    {
            //        continue;
            //        /*DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "Swipe Again", true);
            //        if (result == DialogResult.OK)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            return null;
            //        }*/
            //    }
            //}

            return null;
        }

        public void StopAutoMSRRead()
        {
            isAutoMSR = false;
        }

		private void Next_Btn_Click(object sender, EventArgs e)
		{

		}
	}
}
