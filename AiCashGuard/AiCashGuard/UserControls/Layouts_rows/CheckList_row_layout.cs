using AiCashGuard.Forms;
using AiCashGuard.Forms.CheckModule;
using AiCashGuard.Forms.TransactionModule;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Model.UI;
using AiCashGuard.Processor;
using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls.Layouts_rows
{
	public partial class CheckList_row_layout : UserControl
	{
		private CheckAcctList check { get; set; }
		public CheckList_row_layout()
		{
			InitializeComponent();
		}

		private void Check_Action_Click(object sender, EventArgs e)
		{
			CheckActions.Show(Check_Action, 0, Check_Action.Height);
		}
		public void LoadCheck(CheckAcctList check)
		{
			this.check = check; 
			Check_Account.Text = check.accountNumber;
			Check_Transit.Text = check.routingNumber;
			Check_Default.Text = check.isDefault.ToString();
			if(check.isDefault)
				Check_Default.BackColor = System.Drawing.Color.IndianRed;
			else
                Check_Default.BackColor = System.Drawing.Color.Green;
            Check_Address.Text = check.address;
			Check_Phone.Text = check.phone;
			Check_Business.Text = check.name;
		}

		private void CheckRow_Paint(object sender, PaintEventArgs e)
		{

		}

		private void startTransactionMenuItem_Click(object sender, EventArgs e)
		{
			var check = GetCurrentCheckData();
            TransactionProcessModel trans = new TransactionProcessModel()
            {
                checkId = Convert.ToInt32(check.checkId),
                step = 1,
                processStartsWith = "Check"
            };

            Form parentForm = this.FindForm();

            // Hide the parent form
            if (parentForm != null)
            {
                parentForm.Hide();
            }
            CheckTransactionProcess CTP = new CheckTransactionProcess(trans);
            CTP.WindowState = parentForm.WindowState;
            CTP.Show();
            CTP.CheckScanStatus();
        }
		public CheckAcctList GetCurrentCheckData()
		{
			return check;
		}
		private void editMenuItem_Click(object sender, EventArgs e)
		{
            var check = GetCurrentCheckData();
            EditCheck checkEdit = new EditCheck();
			checkEdit.LoadCheck(check.checkId);
            checkEdit.ShowDialog();
        }

		private void deleteMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = CustomMessageBox.Show("Question", "Are you sure you want to delete this Check ?", "Delete Check", "Yes, Delete");

			// If OK is clicked, exit the application
			if (result == DialogResult.OK)
			{
                Form parentForm = this.FindForm();

                // Hide the parent form
                if (parentForm != null)
                {
                    parentForm.Hide();
                }

                CheckList checkList = new CheckList();
                checkList.WindowState = parentForm.WindowState;
                checkList.Show();
            }

		}

		private void securityMenuItem_Click(object sender, EventArgs e)
		{
            var check = GetCurrentCheckData();
            if (check.isDefault)
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to UNBLOCK {check.name} ?", "UN BLOCK Check", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CheckAccountProcessor().UpdateCheckAccountStatus(check.checkId, false);
                    Form parentForm = this.FindForm();

                    // Hide the parent form
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }

                    CheckList checkList = new CheckList();
                    checkList.WindowState = parentForm.WindowState;
                    checkList.Show();
                }
            }
            else
            {
                DialogResult result = CustomMessageBox.Show("Question", $"Do you want to BLOCK {check.name} ?", "BLOCK Check", "Yes", true);

                // If OK is clicked, exit the application
                if (result == DialogResult.OK)
                {
                    new CheckAccountProcessor().UpdateCheckAccountStatus(check.checkId, true);
                    Form parentForm = this.FindForm();

                    // Hide the parent form
                    if (parentForm != null)
                    {
                        parentForm.Hide();
                    }

                    CheckList checkList = new CheckList();
                    checkList.WindowState = parentForm.WindowState;
                    checkList.Show();
                }
            }
        }

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
            var check = GetCurrentCheckData();
            Form parentForm = this.FindForm();

			// Hide the parent form
			if (parentForm != null)
			{
				parentForm.Hide();
			}
			CheckDetail checkdetail = new CheckDetail();
			checkdetail.checkId = check.checkId;
            checkdetail.WindowState = parentForm.WindowState;
			checkdetail.Show();
		}
	}
}
