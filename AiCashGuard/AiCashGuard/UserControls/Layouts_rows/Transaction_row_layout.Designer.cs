namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class Transaction_row_layout
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_row_layout));
			this.TransactionRowPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Transaction_CheckNumber = new System.Windows.Forms.Label();
			this.Transaction_Customer = new System.Windows.Forms.Label();
			this.Transaction_Number = new System.Windows.Forms.Label();
			this.Transaction_Check = new System.Windows.Forms.Label();
			this.Transaction_Amount = new System.Windows.Forms.Label();
			this.Transaction_Status = new System.Windows.Forms.Label();
			this.Customer_Action = new System.Windows.Forms.Label();
			this.Transaction_CheckDate = new System.Windows.Forms.Label();
			this.TransactionActions = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.startTransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DetailsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.securityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TransactionRowPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.TransactionActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// TransactionRowPanel
			// 
			this.TransactionRowPanel.BackColor = System.Drawing.Color.White;
			this.TransactionRowPanel.Controls.Add(this.tableLayoutPanel1);
			this.TransactionRowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TransactionRowPanel.Location = new System.Drawing.Point(0, 0);
			this.TransactionRowPanel.Name = "TransactionRowPanel";
			this.TransactionRowPanel.Padding = new System.Windows.Forms.Padding(5);
			this.TransactionRowPanel.Size = new System.Drawing.Size(1371, 61);
			this.TransactionRowPanel.TabIndex = 20;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 8;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Controls.Add(this.Transaction_CheckNumber, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Customer, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Number, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Check, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Amount, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Status, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Action, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_CheckDate, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1361, 51);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Transaction_CheckNumber
			// 
			this.Transaction_CheckNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_CheckNumber.Location = new System.Drawing.Point(343, 0);
			this.Transaction_CheckNumber.Name = "Transaction_CheckNumber";
			this.Transaction_CheckNumber.Size = new System.Drawing.Size(164, 51);
			this.Transaction_CheckNumber.TabIndex = 7;
			this.Transaction_CheckNumber.Text = "Check Number";
			this.Transaction_CheckNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Customer
			// 
			this.Transaction_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Customer.Location = new System.Drawing.Point(513, 0);
			this.Transaction_Customer.Name = "Transaction_Customer";
			this.Transaction_Customer.Size = new System.Drawing.Size(164, 51);
			this.Transaction_Customer.TabIndex = 6;
			this.Transaction_Customer.Text = "Customer";
			this.Transaction_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Number
			// 
			this.Transaction_Number.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Number.Location = new System.Drawing.Point(3, 0);
			this.Transaction_Number.Name = "Transaction_Number";
			this.Transaction_Number.Size = new System.Drawing.Size(164, 51);
			this.Transaction_Number.TabIndex = 5;
			this.Transaction_Number.Text = "Transaction Number";
			this.Transaction_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Check
			// 
			this.Transaction_Check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Check.Location = new System.Drawing.Point(683, 0);
			this.Transaction_Check.Name = "Transaction_Check";
			this.Transaction_Check.Size = new System.Drawing.Size(164, 51);
			this.Transaction_Check.TabIndex = 1;
			this.Transaction_Check.Text = "Business Name";
			this.Transaction_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Amount
			// 
			this.Transaction_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Amount.Location = new System.Drawing.Point(853, 0);
			this.Transaction_Amount.Name = "Transaction_Amount";
			this.Transaction_Amount.Size = new System.Drawing.Size(164, 51);
			this.Transaction_Amount.TabIndex = 2;
			this.Transaction_Amount.Text = "Amount";
			this.Transaction_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Status
			// 
			this.Transaction_Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Status.Location = new System.Drawing.Point(1023, 0);
			this.Transaction_Status.Name = "Transaction_Status";
			this.Transaction_Status.Size = new System.Drawing.Size(164, 51);
			this.Transaction_Status.TabIndex = 3;
			this.Transaction_Status.Text = "Status";
			this.Transaction_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_Action
			// 
			this.Customer_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_Action.Image = ((System.Drawing.Image)(resources.GetObject("Customer_Action.Image")));
			this.Customer_Action.Location = new System.Drawing.Point(1193, 0);
			this.Customer_Action.Name = "Customer_Action";
			this.Customer_Action.Size = new System.Drawing.Size(165, 51);
			this.Customer_Action.TabIndex = 4;
			this.Customer_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Customer_Action.Click += new System.EventHandler(this.Customer_Action_Click);
			// 
			// Transaction_CheckDate
			// 
			this.Transaction_CheckDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_CheckDate.Location = new System.Drawing.Point(173, 0);
			this.Transaction_CheckDate.Name = "Transaction_CheckDate";
			this.Transaction_CheckDate.Size = new System.Drawing.Size(164, 51);
			this.Transaction_CheckDate.TabIndex = 0;
			this.Transaction_CheckDate.Text = "Customer Number";
			this.Transaction_CheckDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TransactionActions
			// 
			this.TransactionActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TransactionActions.Depth = 0;
			this.TransactionActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTransactionMenuItem,
            this.DetailsToolStrip,
            this.editMenuItem,
            this.deleteMenuItem,
            this.printMenuItem,
            this.securityMenuItem});
			this.TransactionActions.MouseState = MaterialSkin.MouseState.HOVER;
			this.TransactionActions.Name = "CustomerActions";
			this.TransactionActions.Size = new System.Drawing.Size(181, 158);
			// 
			// startTransactionMenuItem
			// 
			this.startTransactionMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startTransactionMenuItem.Image")));
			this.startTransactionMenuItem.Name = "startTransactionMenuItem";
			this.startTransactionMenuItem.Size = new System.Drawing.Size(180, 22);
			this.startTransactionMenuItem.Text = "Start Transaction";
			// 
			// DetailsToolStrip
			// 
			this.DetailsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DetailsToolStrip.Image")));
			this.DetailsToolStrip.Name = "DetailsToolStrip";
			this.DetailsToolStrip.Size = new System.Drawing.Size(180, 22);
			this.DetailsToolStrip.Text = "Details";
			this.DetailsToolStrip.Click += new System.EventHandler(this.DetailsToolStrip_Click_1);
			// 
			// editMenuItem
			// 
			this.editMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editMenuItem.Image")));
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editMenuItem.Text = "Edit";
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenuItem.Image")));
			this.deleteMenuItem.Name = "deleteMenuItem";
			this.deleteMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteMenuItem.Text = "Delete";
			// 
			// printMenuItem
			// 
			this.printMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printMenuItem.Image")));
			this.printMenuItem.Name = "printMenuItem";
			this.printMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printMenuItem.Text = "Print";
			// 
			// securityMenuItem
			// 
			this.securityMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("securityMenuItem.Image")));
			this.securityMenuItem.Name = "securityMenuItem";
			this.securityMenuItem.Size = new System.Drawing.Size(180, 22);
			this.securityMenuItem.Text = "Security";
			// 
			// Transaction_row_layout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.TransactionRowPanel);
			this.Name = "Transaction_row_layout";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.Size = new System.Drawing.Size(1371, 66);
			this.TransactionRowPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.TransactionActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TransactionRowPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Transaction_CheckNumber;
		private System.Windows.Forms.Label Transaction_Customer;
		private System.Windows.Forms.Label Transaction_Number;
		private System.Windows.Forms.Label Transaction_Check;
		private System.Windows.Forms.Label Transaction_Amount;
		private System.Windows.Forms.Label Transaction_Status;
		private System.Windows.Forms.Label Customer_Action;
		private System.Windows.Forms.Label Transaction_CheckDate;
		private MaterialSkin.Controls.MaterialContextMenuStrip TransactionActions;
		private System.Windows.Forms.ToolStripMenuItem startTransactionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DetailsToolStrip;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printMenuItem;
		private System.Windows.Forms.ToolStripMenuItem securityMenuItem;
	}
}
