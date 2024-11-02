using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.CustomerModule;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.UI;
using AiCashGuard.UserControls;
using AiCashGuard.Processor;
using ExcellaSTX.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms.TransactionModule
{
	public partial class CheckTransactionProcess : BaseForm
	{
        private static ScannerController scanner;
        TransactionProcessModel transactionProcessModel;
        private bool scanProcess = false;
        public CheckTransactionProcess(TransactionProcessModel tpm = null)
		{
            if (tpm == null)
            {
                tpm = new TransactionProcessModel()
                {
                    step = 1,
                    processStartsWith = "Check"
                };
            }

            transactionProcessModel = tpm;
            InitializeComponent();
            Next_Btn.Visible = false;
            BaseTableLayoutPanel.Controls.Add(this.BackPanel, 0, 1); // Row 1 for dashboardPanel
			transactionProgressBar.Increment(transactionProcessModel.step * 18);

            if (transactionProcessModel.processStartsWith == "Customer")
            {
                Step_Label.Text = "Step # 2 / 3";
            }
            else
            {
                Step_Label.Text = "Step # 1 / 3";
            }
        }

		public void AddNewTransactionCheck()
		{
            if (!string.IsNullOrWhiteSpace(transactionProcessModel.accountNumber) && !string.IsNullOrWhiteSpace(transactionProcessModel.routingNumber))
            {
                TransProcessAddCheckModel tAddCheck = new TransProcessAddCheckModel()
                {
                    accountNumber = transactionProcessModel.accountNumber,
                    routingNumber = transactionProcessModel.routingNumber,
                    checkImage = transactionProcessModel.checkImage,
                };

                AddNewCheck addNewCheck = new AddNewCheck(tAddCheck);
                addNewCheck.ShowDialog();
                if(addNewCheck.DialogResult == DialogResult.OK)
                {
                    Next_Btn_Click(addNewCheck.checkId);
                }
            }
        }

        public void CheckScanStatus()
        {
            if(transactionProcessModel.checkId != 0)
            {
                this.Add_Check_Btn.Enabled = false;
                materialSingleLineTextField1.Enabled = false;
                label3.Text = $"Scan Check for Account {transactionProcessModel.check.name}";
                label4.Text = "";
                AutoScanCheck(transactionProcessModel);
            }
            else if (string.IsNullOrWhiteSpace(transactionProcessModel.checkImage))
            {
                AutoScanCheck(transactionProcessModel);
            }
            else if (!string.IsNullOrWhiteSpace(transactionProcessModel.checkImage) && (string.IsNullOrWhiteSpace(transactionProcessModel.accountNumber) || transactionProcessModel.checkId == 0))
            {
                DialogResult result = CustomMessageBox.Show("Question", "You have not properly scan the check or it is not printed from bank. so Do you want to rescan the check else the check image has been scanned and you will search the check manually.", "Check Scan Warning !", "Re-Scan", true);
                if (result == DialogResult.OK)
                {
                    AutoScanCheck(transactionProcessModel);
                }
                else
                {
                    label3.Text = "Search or Add Check Account";
                    label4.Text = "You can select check through manual searching of Check Name";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(transactionProcessModel.checkImage)));
                }
            }
        }

        /*private async void AutoScanCheck()
        {
            try
            {
                scanner = new ScannerController();
                var response = await scanner.CheckAutoScan();
                if (response.scanType != null)
                {
                    //check if response.accountNumber value contain all numbers
                    if (response.accountNumber != null && response.accountNumber.All(char.IsDigit) && response.routingNumber != null && response.routingNumber.All(char.IsDigit))
                    {
                        var acc = 1;//new CheckAccountProcessor().GetCheckAccountByAccountNumber(response.accountNumber, response.routingNumber);

                        if (acc == 0)
                        {
                            transactionProcessModel.accountNumber = response.accountNumber;
                            transactionProcessModel.routingNumber = response.routingNumber;
                            transactionProcessModel.checkNumber = response.checkNumber;
                            transactionProcessModel.checkImage = response.checkFrontImage;
                            this.Invoke((MethodInvoker)delegate
                            {
                                AddNewTransactionCheck();
                            });
                        }
                        else
                        {
                            transactionProcessModel.step += 1;
                            transactionProcessModel.checkNumber = response.checkNumber;
                            transactionProcessModel.checkImage = response.checkFrontImage;
                            transactionProcessModel.routingNumber = response.routingNumber;
                            transactionProcessModel.accountNumber = response.accountNumber;
                            transactionProcessModel.checkId = acc;
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.Hide();
                                CheckDetail CD = new CheckDetail(true, transactionProcessModel);
                                CD.WindowState = this.WindowState;
                                CD.Show();
                            });
                        }
                    }
                    else
                    {
                        DialogResult result = CustomMessageBox.Show("Question", "You have not properly scan the check or it is not printed from bank. so the check image has been scan kindly search it manually.", "Check Scan Warning !", "OK", false);
                        if (result == DialogResult.OK)
                        {
                            transactionProcessModel.checkImage = response.checkFrontImage;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //Error Dialog
            }
        }*/

        private void Back_Btn_Click(object sender, EventArgs e)
		{
            scanProcess = false;
            transactionProcessModel.checkId = 0;
            transactionProcessModel.checkImage = "";
            if (transactionProcessModel.processStartsWith == "Customer")
            {
                transactionProcessModel.step -= 1;
                this.Hide();
                CustomerDetail CD = new CustomerDetail(true, transactionProcessModel);
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

        private void Next_Btn_Click(int checkId, string name = null)
        {
            transactionProcessModel.checkId = checkId;
            if (string.IsNullOrWhiteSpace(transactionProcessModel.checkImage))
            {
                searchPanel.Visible = false;
                label3.Text = $"Scan Check for Account {name}";
                label4.Text = "";
            }
            else
            {
                transactionProcessModel.step += 1;
                transactionProcessModel.checkId = checkId;
                this.Hide();
                CheckDetail CD = new CheckDetail(true, transactionProcessModel);
                CD.WindowState = this.WindowState;
                CD.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Add_Check_Btn_Click(object sender, EventArgs e)
		{
            scanProcess = false;
            AddNewCheck addNewCheck = new AddNewCheck();
            addNewCheck.ShowDialog();
            if (addNewCheck.DialogResult == DialogResult.OK)
            {
                transactionProcessModel.checkImage = addNewCheck.checkImage;
                Next_Btn_Click(addNewCheck.checkId);
            }
            else
            {
                CheckScanStatus();
            }
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
		private void populateSearchData(List<SearchCheckAcctListModel> data)
		{
			searchTableLayoutPanel.Controls.Clear();
			searchTableLayoutPanel.RowCount = 0;
			searchTableLayoutPanel.RowStyles.Clear();

			foreach (var item in data)
			{
				var label = new Label();
				label.Text = item.checkName; // Set the label text to the current item
                label.Tag = item.checkAccountId;
                label.Margin = new Padding(0); // Remove margin
				label.Dock = DockStyle.Top; // Set the dock style

                label.MouseLeave += (s, e) => label.BackColor = Color.Transparent; // Change the back color on hover
                label.MouseEnter += (s, e) => label.BackColor = Color.Gray; // Change the back color on hover
				label.Padding = new Padding(0,8,0,8);
				label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                label.AutoSize = true; // Adjusts size automatically based on content
                label.Click += (s, e) =>
                {
                    // Set the text box text to the label text
                    //materialSingleLineTextField1.Text = label.Text;
                    searchCheckClick(label.Text, label.Tag.ToString());
                }; // Add a click event to the label

                searchTableLayoutPanel.RowCount++;
				searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

				searchTableLayoutPanel.Controls.Add(label, 0, searchTableLayoutPanel.RowCount - 1);
			}

			searchTableLayoutPanel.Padding = new Padding(10,0,10,0);
			searchTableLayoutPanel.Margin = new Padding(0);
		}

		private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;

			// Find the panel by name
			Panel panel = this.Controls.Find("searchPanel", true).FirstOrDefault() as Panel;

			if (panel != null)
			{
				// Show the panel if the text box is not empty, otherwise hide it
				if (!string.IsNullOrEmpty(textBox.Text))
				{
                    var checkList = new CheckAccountProcessor().GetCheckByAcctName(textBox.Text);

                    if(checkList != null && checkList.Count > 0)
                    {
                        panel.Visible = true; // Show the panel
                        populateSearchData(checkList);
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

        private void searchCheckClick(string name, string checkId)
        {
            Next_Btn_Click(Convert.ToInt32(checkId), name);
        }

        private void Cancel_Transaction_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to cancel this transaction process?", "Transaction Cancel !", "Yes", true);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
            }
        }

        public async void AutoScanCheck(TransactionProcessModel trans = null)
        {
            try
            {
                scanner = new ScannerController();
                bool documentFound = false;
                scanProcess = true;
                while (scanProcess)
                {
                    var value = await scanner.CheckDeviceStatus();
                    if (value == "CHECK")
                    {
                        documentFound = true;
                        break;
                    }
                }

                if (documentFound && scanProcess)
                {
                    var response = await scanner.CheckScanOnClick();

                    if (trans == null)
                        trans = new TransactionProcessModel();

                    if (response.scanType != null)
                    {
                        //From Detail screen where check is already selected
                        if (trans != null && trans.checkId > 0)
                        {
                            trans.step += 1;
                            trans.checkImage = response.checkFrontImage;

                            this.Invoke((MethodInvoker)delegate
                            {
                                BaseTableLayoutPanel.FindForm().Hide();
                                CheckDetail checkDetail = new CheckDetail(true, trans);
                                checkDetail.checkId = trans.checkId;
                                checkDetail.WindowState = this.WindowState;
                                checkDetail.Show();
                            });
                        }
                        else if (!string.IsNullOrWhiteSpace(response.accountNumber) && response.accountNumber.All(char.IsDigit) && !string.IsNullOrWhiteSpace(response.routingNumber) && response.routingNumber.All(char.IsDigit))
                        {
                            var acc = new CheckAccountProcessor().GetCheckAccountByAccountNumber(response.accountNumber, response.routingNumber);

                            if (acc == 0)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    if (string.IsNullOrWhiteSpace(trans.processStartsWith))
                                    {
                                        trans.step = 1;
                                        trans.processStartsWith = "Check";
                                    }
                                    trans.checkImage = response.checkFrontImage;
                                    trans.checkNumber = response.checkNumber;
                                    trans.accountNumber = response.accountNumber;
                                    trans.routingNumber = response.routingNumber;

                                    BaseTableLayoutPanel.FindForm().Hide();
                                    CheckTransactionProcess checktransactionProcess = new CheckTransactionProcess(trans);
                                    checktransactionProcess.WindowState = this.WindowState;
                                    checktransactionProcess.Show();
                                    checktransactionProcess.AddNewTransactionCheck();
                                });
                            }
                            else
                            {

                                if (string.IsNullOrWhiteSpace(trans.processStartsWith))
                                {
                                    trans.step = 2;
                                    trans.processStartsWith = "Check";
                                }
                                else
                                    trans.step += 1;
                                trans.checkImage = response.checkFrontImage;
                                trans.checkNumber = response.checkNumber;
                                trans.accountNumber = response.accountNumber;
                                trans.routingNumber = response.routingNumber;

                                this.Invoke((MethodInvoker)delegate
                                {
                                    BaseTableLayoutPanel.FindForm().Hide();
                                    CheckDetail checkDetail = new CheckDetail(true, trans);
                                    checkDetail.checkId = acc;
                                    checkDetail.WindowState = this.WindowState;
                                    checkDetail.Show();
                                });
                            }
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(trans.processStartsWith))
                            {
                                trans.step = 1;
                                trans.processStartsWith = "Check";
                            }
                            trans.checkImage = response.checkFrontImage;

                            this.Invoke((MethodInvoker)delegate
                            {
                                BaseTableLayoutPanel.FindForm().Hide();
                                CheckTransactionProcess checktransactionProcess = new CheckTransactionProcess(trans);
                                checktransactionProcess.WindowState = this.WindowState;
                                checktransactionProcess.Show();
                                checktransactionProcess.CheckScanStatus();
                            });
                        }
                    }
                }


            }
            catch (Exception e)
            {
                //Error Dialog
            }
        }
    }
}
