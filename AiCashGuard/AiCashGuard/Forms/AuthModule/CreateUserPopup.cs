using AiCashGuard.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCashGuard.Forms.AuthModule
{
	public partial class CreateUserPopup : Form
	{
		public CreateUserPopup()
		{
			InitializeComponent();
			//BaseTableLayoutPanel.Controls.Add(this.createUserPanel, 0, 1); // Row 1 for dashboardPanel
		}

		private void roundedPanel10_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addNewCheckPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
