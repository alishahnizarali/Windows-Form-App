namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class DepositDetail_row
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
			this.CheckRow = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Check_Transit = new System.Windows.Forms.Label();
			this.Check_Amount = new System.Windows.Forms.Label();
			this.Check_Date = new System.Windows.Forms.Label();
			this.Check_Status = new System.Windows.Forms.Label();
			this.Check_Number = new System.Windows.Forms.Label();
			this.Check_Name = new System.Windows.Forms.Label();
			this.IsSelected = new System.Windows.Forms.CheckBox();
			this.CheckRow.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckRow
			// 
			this.CheckRow.BackColor = System.Drawing.Color.White;
			this.CheckRow.Controls.Add(this.tableLayoutPanel1);
			this.CheckRow.Dock = System.Windows.Forms.DockStyle.Top;
			this.CheckRow.Location = new System.Drawing.Point(0, 0);
			this.CheckRow.Name = "CheckRow";
			this.CheckRow.Padding = new System.Windows.Forms.Padding(5);
			this.CheckRow.Size = new System.Drawing.Size(761, 66);
			this.CheckRow.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.Controls.Add(this.Check_Transit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Amount, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Date, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Status, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Number, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Name, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.IsSelected, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 56);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Check_Transit
			// 
			this.Check_Transit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Transit.Location = new System.Drawing.Point(110, 0);
			this.Check_Transit.Name = "Check_Transit";
			this.Check_Transit.Size = new System.Drawing.Size(101, 56);
			this.Check_Transit.TabIndex = 1;
			this.Check_Transit.Text = "Transaction ID";
			this.Check_Transit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Check_Transit.Click += new System.EventHandler(this.Check_Transit_Click);
			// 
			// Check_Amount
			// 
			this.Check_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Amount.Location = new System.Drawing.Point(538, 0);
			this.Check_Amount.Name = "Check_Amount";
			this.Check_Amount.Size = new System.Drawing.Size(101, 56);
			this.Check_Amount.TabIndex = 2;
			this.Check_Amount.Text = "Check Amount";
			this.Check_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Date
			// 
			this.Check_Date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Date.Location = new System.Drawing.Point(324, 0);
			this.Check_Date.Name = "Check_Date";
			this.Check_Date.Size = new System.Drawing.Size(101, 56);
			this.Check_Date.TabIndex = 3;
			this.Check_Date.Text = "Check Date";
			this.Check_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Status
			// 
			this.Check_Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Status.Location = new System.Drawing.Point(645, 0);
			this.Check_Status.Name = "Check_Status";
			this.Check_Status.Size = new System.Drawing.Size(103, 56);
			this.Check_Status.TabIndex = 4;
			this.Check_Status.Text = "Status";
			this.Check_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Number
			// 
			this.Check_Number.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Number.Location = new System.Drawing.Point(431, 0);
			this.Check_Number.Name = "Check_Number";
			this.Check_Number.Size = new System.Drawing.Size(101, 56);
			this.Check_Number.TabIndex = 6;
			this.Check_Number.Text = "Check Number";
			this.Check_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Name
			// 
			this.Check_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Name.Location = new System.Drawing.Point(217, 0);
			this.Check_Name.Name = "Check_Name";
			this.Check_Name.Size = new System.Drawing.Size(101, 56);
			this.Check_Name.TabIndex = 5;
			this.Check_Name.Text = "Check Name";
			this.Check_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IsSelected
			// 
			this.IsSelected.AutoSize = true;
			this.IsSelected.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.IsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IsSelected.Location = new System.Drawing.Point(3, 3);
			this.IsSelected.Name = "IsSelected";
			this.IsSelected.Size = new System.Drawing.Size(101, 50);
			this.IsSelected.TabIndex = 7;
			this.IsSelected.UseVisualStyleBackColor = true;
			this.IsSelected.Click += new System.EventHandler(this.IsSelected_Click);
			// 
			// DepositDetail_row
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.CheckRow);
			this.Name = "DepositDetail_row";
			this.Size = new System.Drawing.Size(761, 73);
			this.CheckRow.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel CheckRow;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Check_Transit;
		private System.Windows.Forms.Label Check_Date;
		private System.Windows.Forms.Label Check_Status;
		private System.Windows.Forms.Label Check_Number;
		private System.Windows.Forms.Label Check_Name;
		public System.Windows.Forms.Label Check_Amount;
		public System.Windows.Forms.CheckBox IsSelected;
	}
}
