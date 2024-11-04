using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			this.Close();
		}
	}
}
