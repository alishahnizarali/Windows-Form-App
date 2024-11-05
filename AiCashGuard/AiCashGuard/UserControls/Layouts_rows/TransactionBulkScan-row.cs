using AiCashGuard.Model.Internal.Transaction;
using System.IO;
using System;
using System.Windows.Forms;
using System.Drawing;
using AiCashGuard.Forms.TransactionModule;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class TransactionBulkScan_row : UserControl
	{
		public BulkScanModel Transaction { get; set; }  // Add this property
		public BulkScanScreen obj;
        public TransactionBulkScan_row(BulkScanScreen obj)
		{
			InitializeComponent();
			this.obj = obj;
		}
		public void LoadTransaction(BulkScanModel transaction)
		{
			this.Transaction = transaction;
			try
			{
				byte[] imageBytes = Convert.FromBase64String(transaction.CheckImage);
				using (var ms = new MemoryStream(imageBytes))
				{
					Image image = Image.FromStream(ms);
					CheckImage.Image = image;
					//pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust as needed
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message);
			}
			Transaction_Amount.Text = transaction.Amount;
			Transaction_Date.Text = transaction.Date;
		}

		private void Remove_Action_Click(object sender, EventArgs e)
		{
			obj.RemoveItem(this.Transaction.Id);	
		}
	}
}
