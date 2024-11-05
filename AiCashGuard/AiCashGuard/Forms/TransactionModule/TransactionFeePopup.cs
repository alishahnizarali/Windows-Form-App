using System;
using System.Windows.Forms;

namespace AiCashGuard.Forms.TransactionModule
{
	public partial class TransactionFeePopup : Form
	{
		public TransactionFeePopup()
		{
			InitializeComponent();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			GetSelectedRadioButtonValue();
		}
		private void GetSelectedRadioButtonValue()
		{
			string selectedValue = "";

			if (radioButton1.Checked)
			{
				selectedValue = radioButton1.Text;
			}
			else if (radioButton2.Checked)
			{
				selectedValue = radioButton2.Text;
			}
			else if (radioButton3.Checked)
			{
				selectedValue = radioButton3.Text;
			}
			else if (radioButton4.Checked)
			{
				selectedValue = radioButton4.Text;
			}
			else if (radioButton5.Checked)
			{
				selectedValue = radioButton5.Text;
			}
			else if (radioButton6.Checked)
			{
				selectedValue = radioButton6.Text;
			}
			else if (radioButton7.Checked)
			{
				selectedValue = radioButton7.Text;
			}
			else if (radioButton8.Checked)
			{
				selectedValue = radioButton8.Text;
			}
			else if (radioButton9.Checked)
			{
				selectedValue = radioButton9.Text;
			}
			else if (radioButton10.Checked)
			{
				if(CustomText.Text != null)
					selectedValue = CustomText.Text;
				else
					MessageBox.Show("Please Input any value");
			}
			else
			{
				MessageBox.Show("No option selected");
				return;
			}

			MessageBox.Show("Selected Option: " + selectedValue);
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void materialSingleLineTextField1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Btn_Cancel_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
