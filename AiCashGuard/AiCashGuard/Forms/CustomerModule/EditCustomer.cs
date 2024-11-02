using AiCashGuard.Camera;
using AiCashGuard.Model.Internal.Customer;
using AiCashGuard.Processor;
using AiCashGuard.UserControls;
using ExcellaSTX.Controller;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AiCashGuard.Forms.CustomerModule
{
    public partial class EditCustomer : MaterialForm
    {
        private static ScannerController scanner;
        private static CameraHandler camera;
        public int customerId = 0;
        private CustomerDetailModel custDetails;
        public EditCustomer()
        {
            InitializeComponent();
        }
        public void LoadCustomer(int custId)
        {
            customerId = custId;

            custDetails = new CustomerProcessor().GetCustomerById(customerId);

            //Customer_Number_Label.Text = "Customer #: " + custDetails.customerId.ToString();
            Customer_ID.Text = custDetails.idNumber;
            Customer_Name.Text = custDetails.firstName;
            Customer_Phone.Text = custDetails.phone;
            Customer_Address.Text = custDetails.address;
            Last_Name.Text = custDetails.lastName;
            Zip_Code.Text = custDetails.zipCode;
            Customer_DOB.Text = custDetails.dOB;
            City_Combo.Text = custDetails.city;
            State_Combo.Text = custDetails.state;
            Alert_TextBox.Text = custDetails.alertMsg;
            if (custDetails.idImageFront != null)
                ID_Image_Front.Image = custDetails.idImageFront;
            else
                ID_Image_Front_Cancel.Visible = false;

            if (custDetails.idImageBack != null)
                ID_Image_Back.Image = custDetails.idImageBack;
            else
                ID_Image_Back_Cancel.Visible = false;

            if (custDetails.customerImage != null)
                Customer_Face_Image.Image = custDetails.customerImage;
            else
                Customer_Face_Image_Cancel.Visible = false;
        }

        private async void ID_Image_Front_Click(object sender, EventArgs e)
        {
            scanner = new ScannerController();
            var response = await scanner.IDScanOnClick();
            if (response != null)
            {
                byte[] imageBytes = Convert.FromBase64String(response.idFrontImage);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                this.ID_Image_Front.Image = Image.FromStream(ms);
            }
        }

        private async void ID_Image_Back_Click(object sender, EventArgs e)
        {
            scanner = new ScannerController();
            var response = await scanner.IDScanOnClick();
            if (response != null)
            {
                byte[] imageBytes = Convert.FromBase64String(response.idFrontImage);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                this.ID_Image_Back.Image = Image.FromStream(ms);
            }
        }

        private async void Customer_Face_Image_Click(object sender, EventArgs e)
        {
            camera = new CameraHandler();
            await camera.CaptureFrame(true);
            var customer = camera.customerImage;
            if (customer != null)
            {
                this.Customer_Face_Image.Image = customer.image;
                this.Customer_Face_Image.Tag = customer.imageEmbed;
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void ID_Image_Front_Cancel_Click(object sender, EventArgs e)
        {
            ID_Image_Front.Image = null;
            ID_Image_Front_Cancel.Visible = false;
        }

        private void ID_Image_Back_Cancel_Click(object sender, EventArgs e)
        {
            ID_Image_Back.Image = null;
            ID_Image_Back_Cancel.Visible = false;
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateCustomerData())
            {
                EditCustomerModel custEdit = new EditCustomerModel()
                {
                    customerId = customerId,
                    firstName = Customer_Name.Text,
                    lastName = Last_Name.Text,
                    idNumber = Customer_ID.Text,
                    address = Customer_Address.Text,
                    city = City_Combo.Text,
                    state = State_Combo.Text,
                    zipCode = Zip_Code.Text,
                    phone = Customer_Phone.Text,
                    dOB = Customer_DOB.Value,
                    alertMsg = Alert_TextBox.Text,
                    customerImagePath = custDetails.customerImagePath,
                    idImageFrontPath = custDetails.idImageFrontPath,
                    idImageBackPath = custDetails.idImageBackPath
                };

                customerId = new CustomerProcessor().CheckCustomerExist(custEdit.firstName, custEdit.lastName, custEdit.idNumber, custEdit.dOB, customerId);
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
                    if (ID_Image_Front.Image != null)
                        custEdit.idImageFront = ID_Image_Front.Image;

                    if (ID_Image_Back.Image != null)
                        custEdit.idImageBack = ID_Image_Back.Image;

                    if (Customer_Face_Image.Image != null)
                        custEdit.customerImage = Customer_Face_Image.Image;

                    if (Customer_Face_Image.Tag != null)
                        custEdit.customerFaceValue = Customer_Face_Image.Tag as float[];

                    new CustomerProcessor().UpdateCustomerDetails(custEdit);

                    this.Close();
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
