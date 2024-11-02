namespace AiCashGuard.UserControls
{
	partial class TransactionRow_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionRow_Dashboard));
            this.TransactionRow = new AiCashGuard.UserControls.RoundedPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.check_status = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transaction_date = new System.Windows.Forms.Label();
            this.transaction_number = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transaction_amount = new System.Windows.Forms.Label();
            this.transaction_status = new System.Windows.Forms.Label();
            this.TransactionRow.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionRow
            // 
            this.TransactionRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransactionRow.BackColor = System.Drawing.Color.White;
            this.TransactionRow.Controls.Add(this.panel3);
            this.TransactionRow.Controls.Add(this.panel2);
            this.TransactionRow.Controls.Add(this.panel1);
            this.TransactionRow.CornerRadius = 20;
            this.TransactionRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionRow.Location = new System.Drawing.Point(0, 0);
            this.TransactionRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionRow.Name = "TransactionRow";
            this.TransactionRow.Padding = new System.Windows.Forms.Padding(8);
            this.TransactionRow.Size = new System.Drawing.Size(1430, 137);
            this.TransactionRow.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.check_status);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(279, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(909, 121);
            this.panel3.TabIndex = 3;
            // 
            // check_status
            // 
            this.check_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.check_status.Image = ((System.Drawing.Image)(resources.GetObject("check_status.Image")));
            this.check_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.check_status.Location = new System.Drawing.Point(15, 18);
            this.check_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_status.Name = "check_status";
            this.check_status.Size = new System.Drawing.Size(879, 88);
            this.check_status.TabIndex = 3;
            this.check_status.Text = "11/11/24";
            this.check_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.transaction_date);
            this.panel2.Controls.Add(this.transaction_number);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(271, 121);
            this.panel2.TabIndex = 2;
            // 
            // transaction_date
            // 
            this.transaction_date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transaction_date.Image = ((System.Drawing.Image)(resources.GetObject("transaction_date.Image")));
            this.transaction_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_date.Location = new System.Drawing.Point(15, 49);
            this.transaction_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.Size = new System.Drawing.Size(241, 57);
            this.transaction_date.TabIndex = 2;
            this.transaction_date.Text = "11/11/24";
            this.transaction_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transaction_number
            // 
            this.transaction_number.AutoSize = true;
            this.transaction_number.BackColor = System.Drawing.Color.White;
            this.transaction_number.Dock = System.Windows.Forms.DockStyle.Top;
            this.transaction_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_number.Location = new System.Drawing.Point(15, 15);
            this.transaction_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transaction_number.Name = "transaction_number";
            this.transaction_number.Size = new System.Drawing.Size(84, 25);
            this.transaction_number.TabIndex = 0;
            this.transaction_number.Text = "#03030";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transaction_amount);
            this.panel1.Controls.Add(this.transaction_status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1188, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(234, 121);
            this.panel1.TabIndex = 2;
            // 
            // transaction_amount
            // 
            this.transaction_amount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transaction_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_amount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaction_amount.Location = new System.Drawing.Point(15, 44);
            this.transaction_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transaction_amount.Name = "transaction_amount";
            this.transaction_amount.Size = new System.Drawing.Size(204, 62);
            this.transaction_amount.TabIndex = 4;
            this.transaction_amount.Text = "$400";
            this.transaction_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // transaction_status
            // 
            this.transaction_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.transaction_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_status.ForeColor = System.Drawing.Color.Green;
            this.transaction_status.Location = new System.Drawing.Point(15, 15);
            this.transaction_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transaction_status.Name = "transaction_status";
            this.transaction_status.Size = new System.Drawing.Size(204, 35);
            this.transaction_status.TabIndex = 1;
            this.transaction_status.Text = "Approved";
            this.transaction_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransactionRow_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.TransactionRow);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransactionRow_Dashboard";
            this.Size = new System.Drawing.Size(1430, 143);
            this.TransactionRow.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RoundedPanel TransactionRow;
		public System.Windows.Forms.Label transaction_amount;
		public System.Windows.Forms.Label check_status;
		public System.Windows.Forms.Label transaction_date;
		public System.Windows.Forms.Label transaction_status;
		public System.Windows.Forms.Label transaction_number;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}
