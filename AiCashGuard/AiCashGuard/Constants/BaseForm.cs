using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing;
using AiCashGuard.UserControls;
using AiCashGuard.Forms;

namespace AiCashGuard.Constants
{
    public class BaseForm : Form
    {

        // Constants for window messages and hit testing
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
        private HeaderComponent headerComponent1;
        public TableLayoutPanel BaseTableLayoutPanel;
        private Panel panel1;
        private RoundedPanel roundedPanel1;
        private Panel panel2;
        private Label text_username;
        private PictureBox profile_image;
        private Label Email;
        private PictureBox pictureBox2;
        private Label MyProfile;
        private Label Deposits;
        private Label Transactions;
        private Label Reports;
        private Label Checks;
        private Label Customers;
        private Label Dashboard;
        private Label Logout;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Panel BackPanel;
        private Panel profilePanel;
        public static string username = string.Empty;
        private Color connectColor = ColorTranslator.FromHtml("#49F989");
        private Color disconnectColor = ColorTranslator.FromHtml("#D95439");

        //Hardware initialiazation and form load
        
        //private static ScannerController scanner = new ScannerController();

        /*public async void AutoScanCheck(TransactionProcessModel trans = null)
        {
            try
            {
                var response = await scanner.CheckAutoScan();

                if(trans == null)
                    trans = new TransactionProcessModel();

                if (response.scanType != null)
                {
                    //From Detail screen where check is already selected
                    if (trans != null && trans.checkId > 0)
                    {
                        trans.step +=1;
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
            catch (Exception e)
            {
                //Error Dialog
            }
        }*/

        /*public async Task StopAutoScanCheck()
        {
            await scanner.StopAutoScan();
        }*/

        /*public void StopAutoMSRRead()
        {
            isAutoMSR = false;
        }*/

        /*public async Task<TransProcessAddCustomerModel> ReadMSRData()
        {
            isAutoMSR = true;
            while (isAutoMSR)
            {
                var response = await scanner.MSRScanOnClick();

                if (response != null)
                {
                    if (!string.IsNullOrWhiteSpace(response.firstName))
                    {
                        TransProcessAddCustomerModel transProcessAddCustomerModel = new TransProcessAddCustomerModel()
                        {
                            firstName = response.firstName,
                            lastName = response.lastName,
                            idNumber = response.idNumber.Substring(6),
                            address = response.address,
                            city = response.city,
                            state = response.stateCode,
                            zipCode = response.zipCode,
                            dob = response.dateOfBirth.Insert(4, "/").Insert(7, "/"),
                        };
                        return transProcessAddCustomerModel;
                    }
                    else
                    {
                        DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "Swipe Again", true);
                        if (result == DialogResult.OK)
                        {
                            continue;
                        }
                        else
                            return null;
                    }
                }
                else
                {
                    continue;
                    DialogResult result = CustomMessageBox.Show("Question", "Card has not properly swipped. Click again if you want to swipe again", "Card Swipe Warning !", "Swipe Again", true);
                    if (result == DialogResult.OK)
                    {
                        continue;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return null;
        }*/

        private void BaseForm_Load(object sender, EventArgs e)
        {
            SetFormSizeByAspectRatio();
        }

        public void SetInternetStatus(bool status)
        {
            if(status)
                HeaderComponent.internetConnected = connectColor;
            else
                HeaderComponent.internetConnected = disconnectColor;
        }

        public void SetScannerStatus(bool status)
        {
            if (status)
                HeaderComponent.scannerConnected = connectColor;
            else
                HeaderComponent.scannerConnected = disconnectColor;
        }

        public void SetCameraStatus(bool status)
        {
            if (status)
                HeaderComponent.cameraConnected = connectColor;
            else
                HeaderComponent.cameraConnected = disconnectColor;
        }

        private void SetFormSizeByAspectRatio()
        {
            // Get the current screen size (you can modify this for multi-monitor setups)
            var screenSize = Screen.PrimaryScreen.Bounds;

            // Calculate the form size based on a 4:3 ratio
            int screenWidth = screenSize.Width;
            int screenHeight = screenSize.Height;

            // Maintain a 4:3 ratio by adjusting the height according to the screen's width
            int width = screenWidth;
            int height = (int)(screenWidth / (16.0 / 9.0));

            // If the height exceeds the screen height, adjust it accordingly
            if (height > screenHeight)
            {
                height = screenHeight;
                width = (int)(screenHeight * (16.0 / 9.0));
            }

            // Set the form size
            this.Size = new Size(width, height);

            // Calculate the new form position to center it
            int xPos = (screenSize.Width - this.Width) / 2;
            int yPos = (screenSize.Height - this.Height) / 2;

            // Set the form's position manually
            this.Location = new Point(xPos, yPos);
        }

        private void headerComponent1_Load(object sender, EventArgs e)
        {

        }

        private void Customers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerList customerlist = new CustomerList();
            customerlist.Show();
        }

        private void Checks_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckList checklist = new CheckList();
            checklist.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionList TransactionList = new TransactionList();
            TransactionList.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to logout?", "Logout", "Yes");

            // If OK is clicked, exit the application
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void BaseTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.profilePanel = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Label();
            this.Deposits = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.Label();
            this.Checks = new System.Windows.Forms.Label();
            this.Customers = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.Dashboard = new System.Windows.Forms.Label();
            this.MyProfile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new RoundedPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.Label();
            this.profile_image = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BaseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerComponent1 = new UserControls.HeaderComponent();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.profilePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BaseTableLayoutPanel.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePanel.BackColor = System.Drawing.Color.White;
            this.profilePanel.Controls.Add(this.Logout);
            this.profilePanel.Controls.Add(this.Deposits);
            this.profilePanel.Controls.Add(this.Transactions);
            this.profilePanel.Controls.Add(this.Reports);
            this.profilePanel.Controls.Add(this.Checks);
            this.profilePanel.Controls.Add(this.Customers);
            this.profilePanel.Controls.Add(this.materialDivider1);
            this.profilePanel.Controls.Add(this.Dashboard);
            this.profilePanel.Controls.Add(this.MyProfile);
            this.profilePanel.Controls.Add(this.panel1);
            this.profilePanel.Location = new System.Drawing.Point(875, 90);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Padding = new System.Windows.Forms.Padding(5);
            this.profilePanel.Size = new System.Drawing.Size(300, 600);
            this.profilePanel.TabIndex = 1;
            this.profilePanel.Visible = false;
            // 
            // Logout
            // 
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(5, 711);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(290, 34);
            this.Logout.TabIndex = 8;
            this.Logout.Font = new Font(Font.SystemFontName, 10);
            this.Logout.Text = "Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Deposits
            // 
            this.Deposits.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deposits.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Deposits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deposits.Location = new System.Drawing.Point(5, 311);
            this.Deposits.Name = "Deposits";
            this.Deposits.Font = new Font(Font.SystemFontName, 10);
            this.Deposits.Size = new System.Drawing.Size(290, 34);
            this.Deposits.TabIndex = 7;
            this.Deposits.Text = "Deposits";
            this.Deposits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transactions
            // 
            this.Transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transactions.Image = ((System.Drawing.Image)(resources.GetObject("Transactions.Image")));
            this.Transactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transactions.Location = new System.Drawing.Point(5, 277);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(290, 34);
            this.Transactions.Font = new Font(Font.SystemFontName, 10);
            this.Transactions.TabIndex = 6;
            this.Transactions.Text = "Transactions";
            this.Transactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // Reports
            // 
            this.Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reports.Location = new System.Drawing.Point(5, 243);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(290, 34);
            this.Reports.TabIndex = 5;
            this.Reports.Font = new Font(Font.SystemFontName, 10);
            this.Reports.Text = "Reports";
            this.Reports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Checks
            // 
            this.Checks.Dock = System.Windows.Forms.DockStyle.Top;
            this.Checks.Image = ((System.Drawing.Image)(resources.GetObject("Checks.Image")));
            this.Checks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Checks.Location = new System.Drawing.Point(5, 209);
            this.Checks.Name = "Checks";
            this.Checks.Size = new System.Drawing.Size(290, 34);
            this.Checks.TabIndex = 4;
            this.Checks.Font = new Font(Font.SystemFontName, 10);
            this.Checks.Text = "Checks";
            this.Checks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Checks.Click += new System.EventHandler(this.Checks_Click);
            // 
            // Customers
            // 
            this.Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers.Image = ((System.Drawing.Image)(resources.GetObject("Customers.Image")));
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(5, 175);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(290, 34);
            this.Customers.Font = new Font(Font.SystemFontName, 10);
            this.Customers.TabIndex = 3;
            this.Customers.Text = "Customers";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(5, 173);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(290, 2);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Dashboard
            // 
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Others.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(5, 139);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(290, 34);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.Font = new Font(Font.SystemFontName, 10);
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyProfile.Image = ((System.Drawing.Image)(resources.GetObject("MyProfile.Image")));
            this.MyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyProfile.Location = new System.Drawing.Point(5, 105);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(290, 34);
            this.MyProfile.TabIndex = 1;
            this.MyProfile.Text = "My Profile";
            this.MyProfile.Font = new Font(Font.SystemFontName, 10);
            this.MyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(290, 100);
            this.panel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.panel2);
            this.roundedPanel1.Controls.Add(this.profile_image);
            this.roundedPanel1.Controls.Add(this.pictureBox2);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Size = new System.Drawing.Size(270, 80);
            this.roundedPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.text_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(61, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(156, 60);
            this.panel2.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Email.Location = new System.Drawing.Point(10, 37);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(136, 13);
            this.Email.TabIndex = 1;
            this.Email.Font = new Font(Font.SystemFontName, 10);
            this.Email.Text = username;
            // 
            // text_username
            // 
            this.text_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_username.Location = new System.Drawing.Point(10, 10);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(136, 13);
            this.text_username.TabIndex = 0;
            this.text_username.Font = new Font(Font.SystemFontName, 10);
            this.text_username.Text = username;
            // 
            // profile_image
            // 
            this.profile_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.profile_image.Image = ((System.Drawing.Image)(resources.GetObject("profile_image.Image")));
            this.profile_image.Location = new System.Drawing.Point(10, 10);
            this.profile_image.Name = "profile_image";
            this.profile_image.Size = new System.Drawing.Size(51, 60);
            this.profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profile_image.TabIndex = 0;
            this.profile_image.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BaseTableLayoutPanel
            // 
            this.BaseTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.BaseTableLayoutPanel.ColumnCount = 1;
            this.BaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseTableLayoutPanel.Controls.Add(this.headerComponent1, 0, 0);
            this.BaseTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BaseTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BaseTableLayoutPanel.Name = "BaseTableLayoutPanel";
            this.BaseTableLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BaseTableLayoutPanel.RowCount = 2;
            this.BaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BaseTableLayoutPanel.Size = new System.Drawing.Size(1182, 891);
            this.BaseTableLayoutPanel.TabIndex = 0;
            this.BaseTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BaseTableLayoutPanel_Paint);
            // 
            // headerComponent1
            // 
            this.headerComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerComponent1.Location = new System.Drawing.Point(4, 4);
            this.headerComponent1.Name = "headerComponent1";
            this.headerComponent1.Size = new System.Drawing.Size(1174, 88);
            this.headerComponent1.TabIndex = 0;
            this.headerComponent1.Load += new System.EventHandler(this.headerComponent1_Load);
            // 
            // BackPanel
            // 
            this.BackPanel.AutoScroll = true;
            this.BackPanel.Controls.Add(this.BaseTableLayoutPanel);
            this.BackPanel.Controls.Add(this.profilePanel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1182, 891);
            this.BackPanel.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1182, 891);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.profilePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BaseTableLayoutPanel.ResumeLayout(false);
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public BaseForm()
        {
            InitializeComponent();
            // Set FormBorderStyle to None
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += ResizableDraggableMaterialForm_MouseDown; // Hook to mouse down event
            this.MinimumSize = new Size(1182, 891); // Adjust as needed

            headerComponent1.pictureBox21.Click += Avatar_Click;
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the profile panel
            profilePanel.Visible = !profilePanel.Visible;
            profilePanel.BringToFront();
        }

        // Allow dragging of the form
        private void ResizableDraggableMaterialForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Override WndProc to handle resizing
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                var cursor = PointToClient(Cursor.Position);
                if (cursor.X < 5 && cursor.Y < 5) m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X > Width - 5 && cursor.Y < 5) m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X < 5 && cursor.Y > Height - 5) m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X > Width - 5 && cursor.Y > Height - 5) m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X < 5) m.Result = (IntPtr)HTLEFT;
                else if (cursor.X > Width - 5) m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y < 5) m.Result = (IntPtr)HTTOP;
                else if (cursor.Y > Height - 5) m.Result = (IntPtr)HTBOTTOM;
            }
        }
    }


}
