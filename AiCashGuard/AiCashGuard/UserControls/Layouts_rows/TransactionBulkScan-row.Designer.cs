namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class TransactionBulkScan_row
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionBulkScan_row));
			this.TransactionRowPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Transaction_Amount = new System.Windows.Forms.Label();
			this.Transaction_Date = new System.Windows.Forms.Label();
			this.Remove_Action = new System.Windows.Forms.Label();
			this.CheckImage = new System.Windows.Forms.PictureBox();
			this.TransactionRowPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CheckImage)).BeginInit();
			this.SuspendLayout();
			// 
			// TransactionRowPanel
			// 
			this.TransactionRowPanel.BackColor = System.Drawing.Color.White;
			this.TransactionRowPanel.Controls.Add(this.tableLayoutPanel1);
			this.TransactionRowPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TransactionRowPanel.Location = new System.Drawing.Point(0, 0);
			this.TransactionRowPanel.Name = "TransactionRowPanel";
			this.TransactionRowPanel.Padding = new System.Windows.Forms.Padding(5);
			this.TransactionRowPanel.Size = new System.Drawing.Size(1158, 125);
			this.TransactionRowPanel.TabIndex = 21;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Amount, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Date, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Remove_Action, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.CheckImage, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 115);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Transaction_Amount
			// 
			this.Transaction_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Amount.Location = new System.Drawing.Point(577, 0);
			this.Transaction_Amount.Name = "Transaction_Amount";
			this.Transaction_Amount.Size = new System.Drawing.Size(223, 115);
			this.Transaction_Amount.TabIndex = 2;
			this.Transaction_Amount.Text = "Amount";
			this.Transaction_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Date
			// 
			this.Transaction_Date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Date.Location = new System.Drawing.Point(806, 0);
			this.Transaction_Date.Name = "Transaction_Date";
			this.Transaction_Date.Size = new System.Drawing.Size(223, 115);
			this.Transaction_Date.TabIndex = 3;
			this.Transaction_Date.Text = "Date";
			this.Transaction_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Remove_Action
			// 
			this.Remove_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Remove_Action.Image = ((System.Drawing.Image)(resources.GetObject("Remove_Action.Image")));
			this.Remove_Action.Location = new System.Drawing.Point(1035, 0);
			this.Remove_Action.Name = "Remove_Action";
			this.Remove_Action.Size = new System.Drawing.Size(110, 115);
			this.Remove_Action.TabIndex = 4;
			this.Remove_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Remove_Action.Click += new System.EventHandler(this.Remove_Action_Click);
			// 
			// CheckImage
			// 
			this.CheckImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CheckImage.Image = ((System.Drawing.Image)(resources.GetObject("CheckImage.Image")));
			this.CheckImage.Location = new System.Drawing.Point(3, 3);
			this.CheckImage.Name = "CheckImage";
			this.CheckImage.Size = new System.Drawing.Size(568, 109);
			this.CheckImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CheckImage.TabIndex = 5;
			this.CheckImage.TabStop = false;
			// 
			// TransactionBulkScan_row
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.TransactionRowPanel);
			this.Name = "TransactionBulkScan_row";
			this.Size = new System.Drawing.Size(1158, 135);
			this.TransactionRowPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CheckImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TransactionRowPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Transaction_Amount;
		private System.Windows.Forms.Label Remove_Action;
		private System.Windows.Forms.Label Transaction_Date;
		private System.Windows.Forms.PictureBox CheckImage;
	}
}
