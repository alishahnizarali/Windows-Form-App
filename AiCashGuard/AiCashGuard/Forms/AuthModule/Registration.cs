using AiCashGuard.UserControls;
using System;
using System.Windows.Forms;

namespace AiCashGuard.Forms
{
	public partial class Registration : Form
	{
        private Status status;

        public Registration()
		{
			InitializeComponent();

            status = new Status(panel4, label5);
            status.AttachToPictureBox(pictureBox1);
        }


        private void Registration_Load(object sender, EventArgs e)
		{
        }



        private void Registration_Paint(object sender, PaintEventArgs e)
        {
        }

		private void Btn_Register_Click(object sender, EventArgs e)
		{
			this.Close();
			Dashboard dashboard = new Dashboard();
			dashboard.WindowState = this.WindowState;
			dashboard.Show();
		}

		private void Btn_Login_Here_Click(object sender, EventArgs e)
		{
			this.Close();
			Login login = new Login();
			login.WindowState = this.WindowState;
			login.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
