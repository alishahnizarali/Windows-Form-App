using AiCashGuard.Camera;
using AiCashGuard.Constants;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.TransactionModule;
using AiCashGuard.Logic.Processor;
using AiCashGuard.Model.Camera;
using AiCashGuard.Model.Internal.Transaction;
using AiCashGuard.Model.UI;
using AiCashGuard.Processor;
using AiCashGuard.UserControls;
using ExcellaSTX.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
    public partial class Dashboard : BaseForm
    {
        private static ScannerController scanner;
        private static CameraHandler camera;
        Queue<ImageModel> imageList = new Queue<ImageModel>();
        private bool stopCamera = true;
        private bool scanProcess = false;

        public Dashboard()
        {
            scanner = new ScannerController();
            camera = new CameraHandler();
            InitializeComponent();
            BaseTableLayoutPanel.Controls.Add(this.dashboardPanel, 0, 1); // Row 1 for dashboardPanel
        }

        /*private async void AutoScanCheck()
        {
            try
            {
                var response = await scanner.CheckAutoScan();
                if (response.scanType != null)
                {
                    StopCamera();

                    //check if response.accountNumber value contain all numbers
                    if (response.accountNumber != null && response.accountNumber.All(char.IsDigit) && response.routingNumber != null && response.routingNumber.All(char.IsDigit))
                    {
                        var acc = 1;//new CheckAccountProcessor().GetCheckAccountByAccountNumber(response.accountNumber, response.routingNumber);

                        if (acc == 0)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                TransactionProcessModel trans = new TransactionProcessModel()
                                {
                                    step = 1,
                                    processStartsWith = "Check",
                                    checkImage = response.checkFrontImage,
                                    checkNumber = response.checkNumber,
                                    accountNumber = response.accountNumber,
                                    routingNumber = response.routingNumber
                                };
                                this.Hide();
                                CheckTransactionProcess checktransactionProcess = new CheckTransactionProcess(trans);
                                checktransactionProcess.WindowState = this.WindowState;
                                checktransactionProcess.Show();
                                checktransactionProcess.AddNewTransactionCheck();
                            });
                        }
                        else
                        {
                            TransactionProcessModel trans = new TransactionProcessModel()
                            {
                                checkId = acc,
                                step = 2,
                                processStartsWith = "Check",
                                checkImage = response.checkFrontImage,
                                checkNumber = response.checkNumber,
                                accountNumber = response.accountNumber,
                                routingNumber = response.routingNumber
                            };

                            this.Invoke((MethodInvoker)delegate
                            {
                                this.Hide();
                                CheckDetail checkDetail = new CheckDetail(true, trans);
                                checkDetail.WindowState = this.WindowState;
                                checkDetail.Show();
                            });
                        }
                    }
                    else
                    {
                        TransactionProcessModel trans = new TransactionProcessModel()
                        {
                            step = 1,
                            processStartsWith = "Check",
                            checkImage = response.checkFrontImage
                        };

                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Hide();
                            CheckTransactionProcess checktransactionProcess = new CheckTransactionProcess(trans);
                            checktransactionProcess.WindowState = this.WindowState;
                            checktransactionProcess.Show();
                            checktransactionProcess.CheckScanStatus();
                        });
                    }
                }
            }
            catch (Exception e)
            {
                //Error Dialog
            }
        }*/

        private async void GetLiveCustomer()
        {
            try
            {
                await Task.Run(() =>
                {
                    while (stopCamera)
                    {
                        camera.CaptureFrame(false, imageList);

                        if (camera.customerImage?.image != null)
                        {
                            if (imageList.Count >= 3)
                                imageList.Dequeue();

                            imageList.Enqueue(camera.customerImage);
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.LiveCustImg3.Image = this.LiveCustImg2.Image;
                                this.LiveCustImg3.Tag = this.LiveCustImg2.Tag;
                                this.LiveCustImg2.Image = this.LiveCustImg1.Image;
                                this.LiveCustImg2.Tag = this.LiveCustImg1.Tag;
                                this.LiveCustImg1.Image = camera.customerImage.image;
                                this.LiveCustImg1.Tag = camera.customerImage.imageEmbed;
                            });
                        }

                        if (!stopCamera)
                            break;
                    }
                });
            }
            catch (Exception e)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private async void StopCamera()
        {
            stopCamera = false;
            camera.stop(true);
        }

        private async void Dashboard_Load(object sender, System.EventArgs e)
        {
            var dashTransaction = new TransactionProcessor().GetDashboardTransaction();

            //Dummy Data
            /*List<RecentTransactions> transactions = new List<RecentTransactions>
            {
                new RecentTransactions { transactionId = 30003, transactionStatus = "Cleared", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", transactionType = "Deposit" },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Cleared", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", transactionType = "Deposit" },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Cleared", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", transactionType = "Deposit" },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Cleared", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", transactionType = "Deposit" },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Cleared", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", transactionType = "Deposit" }
            };
            List<RecentTransactions> transactions1 = new List<RecentTransactions>
            {
                new RecentTransactions { transactionId = 30003, transactionStatus = "Return", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", isDeposit = true },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Return", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", isDeposit = true },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Return", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", isDeposit = true },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Return", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", isDeposit = true },
                new RecentTransactions { transactionId = 30003, transactionStatus = "Return", transactionDate = DateTime.Now.ToString("yyyy/MM/dd"), transactionAmount = "$1000", isDeposit = true }
            };
            dashTransaction.returnTransactions = transactions1;
            dashTransaction.recentTransactions = transactions;*/

            DisplayTransactions(dashTransaction.recentTransactions);
            DisplayIssues(dashTransaction.returnTransactions);

            GetLiveCustomer();
            AutoScanCheck();
        }

        private void Btn_Start_Transaction_Click(object sender, EventArgs e)
        {
            Context_Menu_Start_Transaction.Show(Btn_Start_Transaction, 0, Btn_Start_Transaction.Height);
        }

        private void DisplayTransactions(List<RecentTransactions> transactions)
        {
            TransactionPanel.Controls.Clear();
            TransactionPanel.RowCount = 0;
            TransactionPanel.RowStyles.Clear();
            foreach (var transaction in transactions)
            {
                var transactionRow = new TransactionRow_Dashboard();

                transactionRow.transaction_number.Text = transaction.transactionId.ToString();
                if(transaction.transactionStatus == "0")
                    transactionRow.transaction_status.Text = "Cleared";
                else if (transaction.transactionStatus == "1")
                {
                    transactionRow.transaction_status.Text = "Return";
                    transactionRow.transaction_status.ForeColor = System.Drawing.Color.Red;
                }
                else if (transaction.transactionStatus == "2")
                    transactionRow.transaction_status.Text = "Return Cleared";

                transactionRow.transaction_date.Text = Convert.ToDateTime(transaction.transactionDate).ToString("yyyy/MM/dd");
                transactionRow.check_status.Text = transaction.isDeposit ? "Deposit" : "Not Deposit";
                transactionRow.transaction_amount.Text = "$" + transaction.transactionAmount;
                transactionRow.Margin = new Padding(0);
                TransactionPanel.RowCount++;
                TransactionPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                TransactionPanel.Controls.Add(transactionRow, 0, TransactionPanel.RowCount - 1);
            }

            TransactionPanel.Padding = new Padding(0);
            TransactionPanel.Margin = new Padding(0);
        }

        private void DisplayIssues(List<RecentTransactions> transactions)
        {
            IssuePanel.Controls.Clear();
            IssuePanel.RowCount = 0;
            IssuePanel.RowStyles.Clear();
            foreach (var transaction in transactions)
            {
                var transactionRow = new TransactionRow_Dashboard();
                transactionRow.transaction_number.Text = transaction.transactionId.ToString();
                transactionRow.transaction_status.Text = transaction.transactionStatus;
                transactionRow.transaction_status.ForeColor = System.Drawing.Color.Red;
                transactionRow.transaction_date.Text = Convert.ToDateTime(transaction.transactionDate).ToString("yyyy/MM/dd");
                transactionRow.check_status.Text = transaction.isDeposit ? "Deposit" : "Not Deposit";
                transactionRow.transaction_amount.Text = "$" + transaction.transactionAmount;
                transactionRow.Margin = new Padding(0);
                IssuePanel.RowCount++;
                IssuePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                IssuePanel.Controls.Add(transactionRow, 0, IssuePanel.RowCount - 1);
            }
            IssuePanel.Padding = new Padding(0);
            IssuePanel.Margin = new Padding(0);
        }

        private void ViewAll_Transactions_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            //RecentTransaction
            this.Hide();
            TransactionList TransactionList = new TransactionList("Recent");
            TransactionList.WindowState = this.WindowState;
            TransactionList.Show();
        }

        private void ViewAll_Issues_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            //RecentTransaction Issues
            this.Hide();
            TransactionList TransactionList = new TransactionList("Issue");
            TransactionList.WindowState = this.WindowState;
            TransactionList.Show();
        }

        private void Context_Menu_Start_Transaction_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToString())
            {
                case "Customer":
                    StopCamera();
                    scanProcess = false;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Hide();
                        CustomerTransactionProcess transactionProcess = new CustomerTransactionProcess();
                        transactionProcess.WindowState = this.WindowState;
                        transactionProcess.Show();
                    });

                    break;
                case "Check":
                    scanProcess = false;
                    StopCamera();
                    this.Hide();
                    CheckTransactionProcess checktransactionProcess = new CheckTransactionProcess();
                    checktransactionProcess.WindowState = this.WindowState;
                    checktransactionProcess.Show();
                    checktransactionProcess.CheckScanStatus();
                    break;
                default:
                    break;
            }

        }

        private void LiveCustImg1_Click(object sender, EventArgs e)
        {
            if (this.LiveCustImg1.Image != null)
            {
                StopCamera();
                scanProcess = false;
                // Get image Tag and then search in database for match

                TransactionProcessModel transactionProcessModel = new TransactionProcessModel()
                {
                    step = 1,
                    processStartsWith = "Customer",
                    customerFaceValue = this.LiveCustImg1.Tag.ToString(),
                    customerImage = this.LiveCustImg1.Image
                };
                this.Hide();
                CustomerTransactionProcess CTP = new CustomerTransactionProcess(transactionProcessModel);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.AddNewTransactionCheck();
            }
        }

        private void LiveCustImg2_Click(object sender, EventArgs e)
        {
            if (this.LiveCustImg2.Image != null)
            {
                StopCamera();
                scanProcess = false;
                // Get image Tag and then search in database for match

                TransactionProcessModel transactionProcessModel = new TransactionProcessModel()
                {
                    step = 1,
                    processStartsWith = "Customer",
                    customerFaceValue = this.LiveCustImg2.Tag.ToString(),
                    customerImage = this.LiveCustImg2.Image
                };
                this.Hide();
                CustomerTransactionProcess CTP = new CustomerTransactionProcess(transactionProcessModel);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.AddNewTransactionCheck();
            }
        }

        private void LiveCustImg3_Click(object sender, EventArgs e)
        {
            if (this.LiveCustImg3.Image != null)
            {
                StopCamera();
                scanProcess = false;
                // Get image Tag and then search in database for match

                TransactionProcessModel transactionProcessModel = new TransactionProcessModel()
                {
                    step = 1,
                    processStartsWith = "Customer",
                    customerFaceValue = this.LiveCustImg3.Tag.ToString(),
                    customerImage = this.LiveCustImg3.Image
                };
                this.Hide();
                CustomerTransactionProcess CTP = new CustomerTransactionProcess(transactionProcessModel);
                CTP.WindowState = this.WindowState;
                CTP.Show();
                CTP.AddNewTransactionCheck();
            }
        }

        private void CustomerImageBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            CustomerList customerlist = new CustomerList();
            customerlist.WindowState = this.WindowState;
            customerlist.Show();
        }

        private void CheckImageBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            CheckList checklist = new CheckList();
            checklist.WindowState = this.WindowState;
            checklist.Show();
        }

        private void TransactionImageBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            TransactionList TransactionList = new TransactionList();
            TransactionList.WindowState = this.WindowState;
            TransactionList.Show();
        }

        private void ReportImageBtn_Click(object sender, EventArgs e)
        {
            scanProcess = false;
            this.Hide();
            Reports reports = new Reports();
            reports.WindowState = this.WindowState;
            reports.Show();
        }

        private void TransactionTextBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            TransactionList TransactionList = new TransactionList();
            TransactionList.WindowState = this.WindowState;
            TransactionList.Show();
        }

        private void DepsoitTextBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
        }

        private void CustomerTextBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            CustomerList customerlist = new CustomerList();
            customerlist.WindowState = this.WindowState;
            customerlist.Show();
        }

        private void CheckTextBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            CheckList checklist = new CheckList();
            checklist.WindowState = this.WindowState;
            checklist.Show();
        }

        private void ReportTextBtn_Click(object sender, EventArgs e)
        {
            StopCamera();
            scanProcess = false;
            this.Hide();
            Reports reports = new Reports();
            reports.WindowState = this.WindowState;
            reports.Show();
        }

        public async void AutoScanCheck(TransactionProcessModel trans = null)
        {
            try
            {
                bool documentFound = false;
                scanProcess = true;
                while (scanProcess)
                {
                    var value = await scanner.CheckDeviceStatus();
                    if (value == "CHECK")
                    {
                        //scanProcess = false;
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
