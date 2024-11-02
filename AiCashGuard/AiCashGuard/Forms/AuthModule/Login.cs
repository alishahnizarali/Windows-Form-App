using AiCashGuard.Constants;
using AiCashGuard.Logic.Processor;
using AiCashGuard.UserControls;
using System;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
	public partial class Login : Form
	{
        public Login()
		{
			InitializeComponent();
        }

		private void Login_Load(object sender, EventArgs e)
		{
			panel1.Dock = DockStyle.Fill;
        }


		private void Btn_Login_Click(object sender, EventArgs e)
		{
			var response = new UserProcessor().AuthenticateUser(Text_Username.Text, Text_Password.Text);

			if (string.IsNullOrWhiteSpace(response))
			{
                DialogResult result = CustomMessageBox.Show("Error", "Incorrect username or password", "Login Failed !", "Yes", false);

                if (result == DialogResult.OK)
                {
                }
            }
			else
			{
				BaseForm.username = response;
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
            }   
		}

		private void Btn_Register_Here_Click(object sender, EventArgs e)
		{
			this.Hide();
			Registration registration = new Registration();
			registration.WindowState = this.WindowState;
			registration.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
