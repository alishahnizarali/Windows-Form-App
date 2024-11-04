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

namespace AiCashGuard.Forms.TransactionModule
{
	public partial class BulkScanScreen : BaseForm
	{
		public BulkScanScreen()
		{
			InitializeComponent();
			BaseTableLayoutPanel.Controls.Add(this.BackPanel, 0, 1); // Row 1 for dashboardPanel
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
