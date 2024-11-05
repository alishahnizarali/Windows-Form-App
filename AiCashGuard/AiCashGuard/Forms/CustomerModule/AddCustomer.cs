using AiCashGuard.Camera;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.Model.UI;
using AiCashGuard.Processor;
using AiCashGuard.UserControls;
//Moiz-Comment
//using ExcellaSTX.Controller;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCashGuard.Forms.CustomerModule
{
    public partial class AddCustomer : MaterialForm
    {
		//Moiz-Comment
		//private static ScannerController scanner = new ScannerController();
		private static CameraHandler camera;
        public int customerId = 0;
        private bool isAutoMSR;
        public AddCustomer(TransProcessAddCustomerModel transProcessAddCustomerModel = null)
        {
            InitializeComponent();

            if (transProcessAddCustomerModel != null)
            {
                this.Customer_Name.Text = transProcessAddCustomerModel.firstName;
                this.Last_Name.Text = transProcessAddCustomerModel.lastName;
                this.Customer_Address.Text = transProcessAddCustomerModel.address;
                this.Customer_ID.Text = transProcessAddCustomerModel.idNumber;
                this.Customer_DOB.Text = transProcessAddCustomerModel.dob;
                this.Zip_Code.Text = transProcessAddCustomerModel.zipCode;
                this.City_Combo.Text = transProcessAddCustomerModel.city;
                this.State_Combo.Text = transProcessAddCustomerModel.state;
                this.Cust_Image.Image = transProcessAddCustomerModel.customerFace;
            }
        }

        private async void ID_Image1_Click(object sender, EventArgs e)
        {
			//Moiz-Comment
			//StopAutoMSRRead();

			//var response = await scanner.IDScanOnClick();
			//if (response != null)
			//{
			//    byte[] imageBytes = Convert.FromBase64String(response.idFrontImage);
			//    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
			//    this.ID_Image1.SizeMode = PictureBoxSizeMode.Zoom;
			//    this.ID_Image1.Image = Image.FromStream(ms);
			//}
		}

		private async void ID_Image2_Click(object sender, EventArgs e)
        {
			//Moiz-Comment
			//StopAutoMSRRead();
			//var response = await scanner.IDScanOnClick();
			//if (response != null)
			//{
			//    byte[] imageBytes = Convert.FromBase64String(response.idFrontImage);
			//    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
			//    this.ID_Image2.SizeMode = PictureBoxSizeMode.Zoom;
			//    this.ID_Image2.Image = Image.FromStream(ms);
			//}
		}

		private async void Cust_Image_Click(object sender, EventArgs e)
        {
            camera = new CameraHandler();
            await camera.CaptureFrame(true);
            var customer = camera.customerImage;
            if (customer != null)
            {
                this.Cust_Image.Image = customer.image;
                this.Cust_Image.Tag = customer.imageEmbed;
            }
        }

        private async void AddCustomer_Load(object sender, EventArgs e)
        {
            var response = await ReadMSRData();
            if (response != null)
            {
                this.Customer_Name.Text = response.firstName;
                this.Last_Name.Text = response.lastName;
                this.Customer_ID.Text = response.idNumber;
                this.Customer_Address.Text = response.address;
                this.City_Combo.Text = response.city;
                this.State_Combo.Text = response.state;
                this.Zip_Code.Text = response.zipCode;
                this.Customer_DOB.Text = response.dob;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Alert_TextBox.Text = string.Empty;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateCustomerData())
            {
                AddCustomerModel customer = new AddCustomerModel()
                {
                    firstName = this.Customer_Name.Text,
                    lastName = this.Last_Name.Text,
                    idNumber = this.Customer_ID.Text,
                    address = this.Customer_Address.Text,
                    city = this.City_Combo.Text,
                    state = this.State_Combo.Text,
                    zipCode = this.Zip_Code.Text,
                    phone = this.Customer_Phone.Text,
                    dOB = this.Customer_DOB.Value,
                    alertMsg = this.Alert_TextBox.Text
                };

                customerId = new CustomerProcessor().CheckCustomerExist(customer.firstName, customer.lastName, customer.idNumber, customer.dOB);
                if (customerId > 0)
                {
                    DialogResult result = CustomMessageBox.Show("Error", "Customer Already exist in the system.", "Customer Already exist !", "OK", false);
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (this.Cust_Image.Image != null)
                        customer.customerImage = this.Cust_Image.Image;
                    if (this.Cust_Image.Tag != null)
                        customer.customerImageValue = this.Cust_Image.Tag as float[];
                    if (this.ID_Image1.Image != null)
                        customer.idImageFront = this.ID_Image1.Image;
                    if (this.ID_Image2.Image != null)
                        customer.idImageBack = this.ID_Image2.Image;

                    customerId = new CustomerProcessor().CreateCustomer(customer);
                    StopAutoMSRRead();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            StopAutoMSRRead();
            this.Close();
        }

        private bool ValidateCustomerData()
        {
            List<string> error = new List<string>();
            if (string.IsNullOrWhiteSpace(this.Customer_Name.Text))
                error.Add("Please enter the first name");
            if (string.IsNullOrWhiteSpace(this.Last_Name.Text))
                error.Add("Please enter the last name");
            if (string.IsNullOrWhiteSpace(this.Customer_ID.Text))
                error.Add("Please enter the customer id number");

            if (error.Count > 0)
            {
                DialogResult result = CustomMessageBox.Show("Error", string.Join("\n", error), "New Customer Saving Error !", "OK", false);
                if (result == DialogResult.OK)
                {
                }
                return false;
            }
            else
                return true;
        }

        public async Task<TransProcessAddCustomerModel> ReadMSRData()
        {
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
