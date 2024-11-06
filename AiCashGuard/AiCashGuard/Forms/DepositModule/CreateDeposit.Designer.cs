namespace AiCashGuard.Forms.DepositModule
{
	partial class CreateDeposit
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDeposit));
			this.BackPanel = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.TotalAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.TotalTransactions = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.depositDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.roundedPanel2 = new AiCashGuard.UserControls.RoundedPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Cust_Row_Panel = new System.Windows.Forms.Panel();
			this.CustRowDataPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Transaction_ID = new System.Windows.Forms.Label();
			this.Check_Name = new System.Windows.Forms.Label();
			this.Check_Date = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.Check_Number = new System.Windows.Forms.Label();
			this.Check_Amount = new System.Windows.Forms.Label();
			this.SelectCheckBox = new System.Windows.Forms.CheckBox();
			this.BackPanel.SuspendLayout();
			this.panel7.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.roundedPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Cust_Row_Panel.SuspendLayout();
			this.panel8.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackPanel
			// 
			this.BackPanel.Controls.Add(this.panel7);
			this.BackPanel.Controls.Add(this.panel6);
			this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackPanel.Location = new System.Drawing.Point(0, 0);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(1182, 891);
			this.BackPanel.TabIndex = 0;
			this.BackPanel.Controls.SetChildIndex(this.panel6, 0);
			this.BackPanel.Controls.SetChildIndex(this.panel7, 0);
			// 
			// panel7
			// 
			this.panel7.AutoScroll = true;
			this.panel7.Controls.Add(this.tableLayoutPanel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 71);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(5);
			this.panel7.Size = new System.Drawing.Size(1182, 51);
			this.panel7.TabIndex = 39;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1172, 41);
			this.tableLayoutPanel2.TabIndex = 36;
			this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.TotalAmount);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(393, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(384, 35);
			this.panel5.TabIndex = 31;
			// 
			// TotalAmount
			// 
			this.TotalAmount.Depth = 0;
			this.TotalAmount.Enabled = false;
			this.TotalAmount.Hint = "";
			this.TotalAmount.Location = new System.Drawing.Point(104, 5);
			this.TotalAmount.MouseState = MaterialSkin.MouseState.HOVER;
			this.TotalAmount.Name = "TotalAmount";
			this.TotalAmount.PasswordChar = '\0';
			this.TotalAmount.SelectedText = "";
			this.TotalAmount.SelectionLength = 0;
			this.TotalAmount.SelectionStart = 0;
			this.TotalAmount.Size = new System.Drawing.Size(233, 23);
			this.TotalAmount.TabIndex = 25;
			this.TotalAmount.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(5, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "Total Amount";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.TotalTransactions);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(384, 35);
			this.panel3.TabIndex = 29;
			// 
			// TotalTransactions
			// 
			this.TotalTransactions.Depth = 0;
			this.TotalTransactions.Enabled = false;
			this.TotalTransactions.Hint = "";
			this.TotalTransactions.Location = new System.Drawing.Point(184, 5);
			this.TotalTransactions.MouseState = MaterialSkin.MouseState.HOVER;
			this.TotalTransactions.Name = "TotalTransactions";
			this.TotalTransactions.PasswordChar = '\0';
			this.TotalTransactions.SelectedText = "";
			this.TotalTransactions.SelectionLength = 0;
			this.TotalTransactions.SelectionStart = 0;
			this.TotalTransactions.Size = new System.Drawing.Size(153, 23);
			this.TotalTransactions.TabIndex = 24;
			this.TotalTransactions.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(5, 5);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(5);
			this.label4.Size = new System.Drawing.Size(173, 23);
			this.label4.TabIndex = 23;
			this.label4.Text = "No of Transaction Selected";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.depositDateTimePicker);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(783, 3);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(386, 35);
			this.panel4.TabIndex = 30;
			// 
			// depositDateTimePicker
			// 
			this.depositDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.depositDateTimePicker.Location = new System.Drawing.Point(102, 10);
			this.depositDateTimePicker.Name = "depositDateTimePicker";
			this.depositDateTimePicker.Size = new System.Drawing.Size(279, 20);
			this.depositDateTimePicker.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(5, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 25);
			this.label2.TabIndex = 23;
			this.label2.Text = "Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.roundedPanel2);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Controls.Add(this.button8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(10);
			this.panel6.Size = new System.Drawing.Size(1182, 71);
			this.panel6.TabIndex = 41;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.Controls.Add(this.button2);
			this.roundedPanel2.CornerRadius = 20;
			this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel2.Location = new System.Drawing.Point(1007, 10);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Size = new System.Drawing.Size(165, 51);
			this.roundedPanel2.TabIndex = 36;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(10);
			this.button2.Size = new System.Drawing.Size(165, 51);
			this.button2.TabIndex = 15;
			this.button2.Text = "Create Deposit";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Left;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(59, 10);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.label8.Size = new System.Drawing.Size(125, 51);
			this.label8.TabIndex = 29;
			this.label8.Text = "Create Deposit";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button8.Dock = System.Windows.Forms.DockStyle.Left;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new System.Drawing.Point(10, 10);
			this.button8.Name = "button8";
			this.button8.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
			this.button8.Size = new System.Drawing.Size(49, 51);
			this.button8.TabIndex = 35;
			this.button8.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.Cust_Row_Panel);
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 122);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(5);
			this.panel2.Size = new System.Drawing.Size(1065, 678);
			this.panel2.TabIndex = 40;
			// 
			// Cust_Row_Panel
			// 
			this.Cust_Row_Panel.Controls.Add(this.CustRowDataPanel);
			this.Cust_Row_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cust_Row_Panel.Location = new System.Drawing.Point(5, 40);
			this.Cust_Row_Panel.Name = "Cust_Row_Panel";
			this.Cust_Row_Panel.Padding = new System.Windows.Forms.Padding(5);
			this.Cust_Row_Panel.Size = new System.Drawing.Size(1055, 633);
			this.Cust_Row_Panel.TabIndex = 6;
			// 
			// CustRowDataPanel
			// 
			this.CustRowDataPanel.AutoScroll = true;
			this.CustRowDataPanel.ColumnCount = 1;
			this.CustRowDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CustRowDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CustRowDataPanel.Location = new System.Drawing.Point(5, 5);
			this.CustRowDataPanel.Name = "CustRowDataPanel";
			this.CustRowDataPanel.RowCount = 1;
			this.CustRowDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CustRowDataPanel.Size = new System.Drawing.Size(1045, 623);
			this.CustRowDataPanel.TabIndex = 0;
			this.CustRowDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CustRowDataPanel_Paint);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.panel8.Controls.Add(this.tableLayoutPanel3);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(5, 5);
			this.panel8.Name = "panel8";
			this.panel8.Padding = new System.Windows.Forms.Padding(5);
			this.panel8.Size = new System.Drawing.Size(1055, 35);
			this.panel8.TabIndex = 5;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 7;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel3.Controls.Add(this.Transaction_ID, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.Check_Name, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.Check_Date, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.lblStatus, 6, 0);
			this.tableLayoutPanel3.Controls.Add(this.Check_Number, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.Check_Amount, 5, 0);
			this.tableLayoutPanel3.Controls.Add(this.SelectCheckBox, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1045, 25);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// Transaction_ID
			// 
			this.Transaction_ID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Transaction_ID.ForeColor = System.Drawing.Color.White;
			this.Transaction_ID.Location = new System.Drawing.Point(152, 0);
			this.Transaction_ID.Name = "Transaction_ID";
			this.Transaction_ID.Size = new System.Drawing.Size(143, 25);
			this.Transaction_ID.TabIndex = 1;
			this.Transaction_ID.Text = "Transaction ID";
			this.Transaction_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Name
			// 
			this.Check_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Name.ForeColor = System.Drawing.Color.White;
			this.Check_Name.Location = new System.Drawing.Point(301, 0);
			this.Check_Name.Name = "Check_Name";
			this.Check_Name.Size = new System.Drawing.Size(143, 25);
			this.Check_Name.TabIndex = 2;
			this.Check_Name.Text = "Check Name";
			this.Check_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Date
			// 
			this.Check_Date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Date.ForeColor = System.Drawing.Color.White;
			this.Check_Date.Location = new System.Drawing.Point(450, 0);
			this.Check_Date.Name = "Check_Date";
			this.Check_Date.Size = new System.Drawing.Size(143, 25);
			this.Check_Date.TabIndex = 3;
			this.Check_Date.Text = "Check Date";
			this.Check_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblStatus
			// 
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.White;
			this.lblStatus.Location = new System.Drawing.Point(897, 0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(145, 25);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Status";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Number
			// 
			this.Check_Number.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Number.ForeColor = System.Drawing.Color.White;
			this.Check_Number.Location = new System.Drawing.Point(599, 0);
			this.Check_Number.Name = "Check_Number";
			this.Check_Number.Size = new System.Drawing.Size(143, 25);
			this.Check_Number.TabIndex = 5;
			this.Check_Number.Text = "Check Number";
			this.Check_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Amount
			// 
			this.Check_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Amount.ForeColor = System.Drawing.Color.White;
			this.Check_Amount.Location = new System.Drawing.Point(748, 0);
			this.Check_Amount.Name = "Check_Amount";
			this.Check_Amount.Size = new System.Drawing.Size(143, 25);
			this.Check_Amount.TabIndex = 6;
			this.Check_Amount.Text = "Check Amount";
			this.Check_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SelectCheckBox
			// 
			this.SelectCheckBox.AutoSize = true;
			this.SelectCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SelectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SelectCheckBox.ForeColor = System.Drawing.Color.White;
			this.SelectCheckBox.Location = new System.Drawing.Point(3, 3);
			this.SelectCheckBox.Name = "SelectCheckBox";
			this.SelectCheckBox.Size = new System.Drawing.Size(143, 19);
			this.SelectCheckBox.TabIndex = 7;
			this.SelectCheckBox.Text = "Select All";
			this.SelectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SelectCheckBox.UseVisualStyleBackColor = true;
			this.SelectCheckBox.Click += new System.EventHandler(this.SelectCheckBox_Click);
			// 
			// CreateDeposit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 891);
			this.Controls.Add(this.BackPanel);
			this.Name = "CreateDeposit";
			this.Text = "CreateDeposit";
			this.Controls.SetChildIndex(this.BackPanel, 0);
			this.BackPanel.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.roundedPanel2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.Cust_Row_Panel.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker depositDateTimePicker;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel Cust_Row_Panel;
		private System.Windows.Forms.TableLayoutPanel CustRowDataPanel;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label Transaction_ID;
		private System.Windows.Forms.Label Check_Name;
		private System.Windows.Forms.Label Check_Date;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label Check_Number;
		private System.Windows.Forms.Label Check_Amount;
		private System.Windows.Forms.CheckBox SelectCheckBox;
		private System.Windows.Forms.Panel panel6;
		private UserControls.RoundedPanel roundedPanel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button8;
		private MaterialSkin.Controls.MaterialSingleLineTextField TotalAmount;
		private MaterialSkin.Controls.MaterialSingleLineTextField TotalTransactions;
	}
}