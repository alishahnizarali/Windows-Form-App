using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls
{
	public partial class ClosePanel : UserControl
	{
		public ClosePanel()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form parentForm = this.FindForm(); // Find the parent form
			if (parentForm != null)
			{
				if (parentForm.WindowState == FormWindowState.Maximized)
				{
					parentForm.WindowState = FormWindowState.Normal; // Restore the form
				}
				else
				{
					parentForm.WindowState = FormWindowState.Maximized; // Maximize the form
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult result = CustomMessageBox.Show("Info", "Are you sure you want to close the app?", "Confirm Exit", "Yes");

			// If OK is clicked, exit the application
			if (result == DialogResult.OK)
			{
				Application.Exit(); // Close the application
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form parentForm = this.FindForm(); // Find the parent form
			if (parentForm != null)
			{
				parentForm.WindowState = FormWindowState.Minimized; // Minimize the form
			}
		}
	}
}
