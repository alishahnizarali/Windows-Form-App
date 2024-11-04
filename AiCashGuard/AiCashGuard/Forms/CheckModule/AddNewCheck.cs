using AiCashGuard.Model.Internal;
using AiCashGuard.Model.UI;
using AiCashGuard.Processor;
using AiCashGuard.UserControls;
//Moiz-Comment
//using ExcellaSTX.Controller;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AiCashGuard.Forms.CheckModule
{
    public partial class AddNewCheck : MaterialForm
    {
		//Moiz-Comment
		//private static ScannerController scanner;
		public int checkId;
        public string checkImage;
        public AddNewCheck(TransProcessAddCheckModel tAddCheck = null)
        {
            InitializeComponent();
            if (tAddCheck != null)
            {
                this.Account_Number.Text = tAddCheck.accountNumber;
                this.Transit_Number.Text = tAddCheck.routingNumber;
                //Convert base64 to image
                byte[] imageBytes = Convert.FromBase64String(tAddCheck.checkImage);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                this.Check_Image.Image = Image.FromStream(ms);
                this.Check_Image.SizeMode = PictureBoxSizeMode.Zoom;
                this.Scan_Label.Visible = false;
            }
        }

        private async void Check_Image_Click(object sender, EventArgs e)
        {
			//Moiz-Comment
			//scanner = new ScannerController();
			//var check = await scanner.CheckScanOnClick();
			//if (check != null)
			//{
			//    checkImage = check.checkFrontImage;
			//    byte[] imageBytes = Convert.FromBase64String(check.checkFrontImage);
			//    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
			//    this.Check_Image.SizeMode = PictureBoxSizeMode.Zoom;
			//    this.Check_Image.Image = Image.FromStream(ms);
			//    this.Scan_Label.Visible = false;
			//    if (check.accountNumber != null && check.accountNumber.All(char.IsDigit) && check.routingNumber != null && check.routingNumber.All(char.IsDigit))
			//    {
			//        Account_Number.Text = check.accountNumber;
			//        Transit_Number.Text = check.routingNumber;
			//    }
			//}
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateCheckData())
            {
                AddCheckAcct addCheck = new AddCheckAcct
                {
                    accountNumber = Account_Number.Text,
                    routingNumberId = Transit_Number.Text,
                    accountName = Check_Name.Text,
                    address = Check_Address.Text,
                    city = City_Combo.Text,
                    state = State_Combo.Text,
                    zipCode = Zip_Code.Text,
                    alertMsg = Alert_TextBox.Text,
                    phone = Check_Phone.Text
                };

                checkId = new CheckAccountProcessor().GetCheckAccountByAccountNumber(addCheck.accountNumber, addCheck.routingNumberId);
                if (checkId > 0)
                {
                    DialogResult result = CustomMessageBox.Show("Error", "Check Already exist in the system.", "Check Already exist !", "OK", false);
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (this.Check_Image.Image != null)
                    {
                        addCheck.checkImageFront = this.Check_Image.Image;
                        checkImage = Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(this.Check_Image.Image, typeof(byte[])));
                    }

                    checkId = new CheckAccountProcessor().InsertCheckAccount(addCheck);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateCheckData()
        {
            List<string> error = new List<string>();
            if (string.IsNullOrWhiteSpace(this.Account_Number.Text))
                error.Add("Please enter the Account number");
            if (string.IsNullOrWhiteSpace(this.Transit_Number.Text))
                error.Add("Please enter the Routing number");
            if (string.IsNullOrWhiteSpace(this.Check_Name.Text))
                error.Add("Please enter the Check Name");

            if (error.Count > 0)
            {
                DialogResult result = CustomMessageBox.Show("Error", string.Join("\n", error), "New Check Saving Error !", "OK", false);
                if (result == DialogResult.OK)
                {
                }
                return false;
            }
            else
                return true;
        }
    }
}
