using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Processor;
using AiCashGuard.UserControls;
//Moiz-Comment
//using ExcellaSTX.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AiCashGuard.Forms.CheckModule
{
	public partial class EditCheck : Form
	{
		//Moiz-Comment
		//private static ScannerController scanner;
		public int checkId = 0;
        private CheckDetailModel checkDetail;

        public EditCheck()
		{
			InitializeComponent();
		}

        public void LoadCheck(int checkAccId)
        {
            checkId = checkAccId;
            checkDetail = new CheckAccountProcessor().GetCheckAccountById(checkId);

            Account_Number.Text = checkDetail.accountNumber;
            Transit_Number.Text = checkDetail.routingNumber;
            Check_Name.Text = checkDetail.name;
            Check_Address.Text = checkDetail.address;
            City_Combo.Text = checkDetail.city;
            State_Combo.Text = checkDetail.state;
            Zip_Code.Text = checkDetail.zipCode;
            Check_Phone.Text = checkDetail.phone;
            Alert_TextBox.Text = checkDetail.alertMsg;

            if (checkDetail.checkImageFront != null)
                Check_Image.Image = checkDetail.checkImageFront;
            else
                Check_Image_Cancel.Visible = false;
        }

        private async void Check_Image_Click(object sender, EventArgs e)
        {
			//Moiz-Comment
			//scanner = new ScannerController();
			//var response = await scanner.IDScanOnClick();
			//if (response != null)
			//{
			//    byte[] imageBytes = Convert.FromBase64String(response.idFrontImage);
			//    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
			//    this.Check_Image.Image = Image.FromStream(ms);
			//}
		}

		private void Check_Image_Cancel_Click(object sender, EventArgs e)
        {
            Check_Image.Image = null;
            Check_Image_Cancel.Visible = false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateCheckData())
            {
                EditCheckAcct request = new EditCheckAcct()
                {
                    checkId = checkId,
                    accountNumber = Account_Number.Text,
                    routingNumber = Transit_Number.Text,
                    accountName = Check_Name.Text,
                    address = Check_Address.Text,
                    zipCode = Zip_Code.Text,
                    phone = Check_Phone.Text,
                    city = City_Combo.Text,
                    state = State_Combo.Text,
                    alertMsg = Alert_TextBox.Text,
                    checkImageFrontPath = checkDetail.checkImageFrontPath
                };

                if (Check_Image.Image != null)
                    request.checkImageFront = Check_Image.Image;

                new CheckAccountProcessor().UpdateCheckAccount(request);

                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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
                DialogResult result = CustomMessageBox.Show("Error", string.Join("\n", error), "Updating Check Detail Error !", "OK", false);
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
