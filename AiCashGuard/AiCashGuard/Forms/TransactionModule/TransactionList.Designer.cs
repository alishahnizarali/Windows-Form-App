using AiCashGuard.UserControls;

namespace AiCashGuard.Forms
{
	partial class TransactionList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionList));
			this.transactionListPanel = new System.Windows.Forms.Panel();
			this.transactionTablePanel = new System.Windows.Forms.Panel();
			this.DataPanel = new System.Windows.Forms.Panel();
			this.TransactionDataPanel = new System.Windows.Forms.TableLayoutPanel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Transaction_CheckNumber = new System.Windows.Forms.Label();
			this.Transaction_Customer = new System.Windows.Forms.Label();
			this.Transaction_Number = new System.Windows.Forms.Label();
			this.Transaction_Check = new System.Windows.Forms.Label();
			this.Transaction_Amount = new System.Windows.Forms.Label();
			this.Transaction_Status = new System.Windows.Forms.Label();
			this.Transaction_Action = new System.Windows.Forms.Label();
			this.Transaction_CheckDate = new System.Windows.Forms.Label();
			this.Footer = new System.Windows.Forms.Panel();
			this.PaginationControl = new AiCashGuard.UserControls.PaginationControl();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.filterBtn = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.checkSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.customerSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.transactionSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel2 = new RoundedPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.transactionListPanel.SuspendLayout();
			this.transactionTablePanel.SuspendLayout();
			this.DataPanel.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.Footer.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.roundedPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// transactionListPanel
			// 
			this.transactionListPanel.AutoScroll = true;
			this.transactionListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.transactionListPanel.Controls.Add(this.transactionTablePanel);
			this.transactionListPanel.Controls.Add(this.panel6);
			this.transactionListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transactionListPanel.Location = new System.Drawing.Point(2, 2);
			this.transactionListPanel.Name = "transactionListPanel";
			this.transactionListPanel.Padding = new System.Windows.Forms.Padding(5);
			this.transactionListPanel.Size = new System.Drawing.Size(1178, 887);
			this.transactionListPanel.TabIndex = 0;
			this.transactionListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// transactionTablePanel
			// 
			this.transactionTablePanel.Controls.Add(this.DataPanel);
			this.transactionTablePanel.Controls.Add(this.HeaderPanel);
			this.transactionTablePanel.Controls.Add(this.Footer);
			this.transactionTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transactionTablePanel.Location = new System.Drawing.Point(5, 76);
			this.transactionTablePanel.Name = "transactionTablePanel";
			this.transactionTablePanel.Padding = new System.Windows.Forms.Padding(10);
			this.transactionTablePanel.Size = new System.Drawing.Size(1168, 806);
			this.transactionTablePanel.TabIndex = 38;
			// 
			// DataPanel
			// 
			this.DataPanel.Controls.Add(this.TransactionDataPanel);
			this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataPanel.Location = new System.Drawing.Point(10, 32);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Padding = new System.Windows.Forms.Padding(5);
			this.DataPanel.Size = new System.Drawing.Size(1148, 717);
			this.DataPanel.TabIndex = 20;
			// 
			// TransactionDataPanel
			// 
			this.TransactionDataPanel.AutoScroll = true;
			this.TransactionDataPanel.ColumnCount = 1;
			this.TransactionDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TransactionDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TransactionDataPanel.Location = new System.Drawing.Point(5, 5);
			this.TransactionDataPanel.Name = "TransactionDataPanel";
			this.TransactionDataPanel.RowCount = 1;
			this.TransactionDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TransactionDataPanel.Size = new System.Drawing.Size(1138, 707);
			this.TransactionDataPanel.TabIndex = 0;
			this.TransactionDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomerDataPanel_Paint);
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.HeaderPanel.Controls.Add(this.tableLayoutPanel1);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.HeaderPanel.Location = new System.Drawing.Point(10, 10);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5);
			this.HeaderPanel.Size = new System.Drawing.Size(1148, 22);
			this.HeaderPanel.TabIndex = 19;
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
			this.tableLayoutPanel1.Controls.Add(this.Transaction_Action, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.Transaction_CheckDate, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 11);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Transaction_CheckNumber
			// 
			this.Transaction_CheckNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_CheckNumber.Location = new System.Drawing.Point(287, 0);
			this.Transaction_CheckNumber.Name = "Transaction_CheckNumber";
			this.Transaction_CheckNumber.Size = new System.Drawing.Size(136, 11);
			this.Transaction_CheckNumber.TabIndex = 7;
			this.Transaction_CheckNumber.Text = "Check Number";
			this.Transaction_CheckNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Customer
			// 
			this.Transaction_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Customer.Location = new System.Drawing.Point(429, 0);
			this.Transaction_Customer.Name = "Transaction_Customer";
			this.Transaction_Customer.Size = new System.Drawing.Size(136, 11);
			this.Transaction_Customer.TabIndex = 6;
			this.Transaction_Customer.Text = "Customer";
			this.Transaction_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Number
			// 
			this.Transaction_Number.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Number.Location = new System.Drawing.Point(3, 0);
			this.Transaction_Number.Name = "Transaction_Number";
			this.Transaction_Number.Size = new System.Drawing.Size(136, 11);
			this.Transaction_Number.TabIndex = 5;
			this.Transaction_Number.Text = "Transaction Number";
			this.Transaction_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Check
			// 
			this.Transaction_Check.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Check.Location = new System.Drawing.Point(571, 0);
			this.Transaction_Check.Name = "Transaction_Check";
			this.Transaction_Check.Size = new System.Drawing.Size(136, 11);
			this.Transaction_Check.TabIndex = 1;
			this.Transaction_Check.Text = "Check Name";
			this.Transaction_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Amount
			// 
			this.Transaction_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Amount.Location = new System.Drawing.Point(713, 0);
			this.Transaction_Amount.Name = "Transaction_Amount";
			this.Transaction_Amount.Size = new System.Drawing.Size(136, 11);
			this.Transaction_Amount.TabIndex = 2;
			this.Transaction_Amount.Text = "Amount";
			this.Transaction_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Status
			// 
			this.Transaction_Status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Status.Location = new System.Drawing.Point(855, 0);
			this.Transaction_Status.Name = "Transaction_Status";
			this.Transaction_Status.Size = new System.Drawing.Size(136, 11);
			this.Transaction_Status.TabIndex = 3;
			this.Transaction_Status.Text = "Status";
			this.Transaction_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_Action
			// 
			this.Transaction_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_Action.Location = new System.Drawing.Point(997, 0);
			this.Transaction_Action.Name = "Transaction_Action";
			this.Transaction_Action.Size = new System.Drawing.Size(138, 11);
			this.Transaction_Action.TabIndex = 4;
			this.Transaction_Action.Text = "Action";
			this.Transaction_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Transaction_CheckDate
			// 
			this.Transaction_CheckDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Transaction_CheckDate.Location = new System.Drawing.Point(145, 0);
			this.Transaction_CheckDate.Name = "Transaction_CheckDate";
			this.Transaction_CheckDate.Size = new System.Drawing.Size(136, 11);
			this.Transaction_CheckDate.TabIndex = 0;
			this.Transaction_CheckDate.Text = "Check Date";
			this.Transaction_CheckDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Footer
			// 
			this.Footer.Controls.Add(this.PaginationControl);
			this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Footer.Location = new System.Drawing.Point(10, 749);
			this.Footer.Name = "Footer";
			this.Footer.Padding = new System.Windows.Forms.Padding(5);
			this.Footer.Size = new System.Drawing.Size(1148, 47);
			this.Footer.TabIndex = 21;
			// 
			// PaginationControl
			// 
			this.PaginationControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.PaginationControl.ItemsPerPage = 10;
			this.PaginationControl.Location = new System.Drawing.Point(815, 5);
			this.PaginationControl.Name = "PaginationControl";
			this.PaginationControl.Size = new System.Drawing.Size(328, 37);
			this.PaginationControl.TabIndex = 1;
			this.PaginationControl.TotalPages = 0;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Controls.Add(this.roundedPanel2);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.button8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(5, 5);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(10);
			this.panel6.Size = new System.Drawing.Size(1168, 71);
			this.panel6.TabIndex = 37;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.tableLayoutPanel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(184, 10);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(5);
			this.panel7.Size = new System.Drawing.Size(849, 51);
			this.panel7.TabIndex = 39;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.Controls.Add(this.filterBtn, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(839, 41);
			this.tableLayoutPanel2.TabIndex = 36;
			// 
			// filterBtn
			// 
			this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.filterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.filterBtn.FlatAppearance.BorderSize = 0;
			this.filterBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterBtn.ForeColor = System.Drawing.Color.White;
			this.filterBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.filterBtn.Location = new System.Drawing.Point(756, 3);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Padding = new System.Windows.Forms.Padding(2);
			this.filterBtn.Size = new System.Drawing.Size(80, 35);
			this.filterBtn.TabIndex = 32;
			this.filterBtn.Text = "Filter";
			this.filterBtn.UseVisualStyleBackColor = false;
			this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkSearch);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(505, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(245, 35);
			this.panel5.TabIndex = 31;
			// 
			// checkSearch
			// 
			this.checkSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkSearch.Location = new System.Drawing.Point(102, 5);
			this.checkSearch.Multiline = true;
			this.checkSearch.Name = "checkSearch";
			this.checkSearch.Size = new System.Drawing.Size(138, 25);
			this.checkSearch.TabIndex = 24;
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
			this.label3.Text = "Check No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.customerSearch);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(254, 3);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(245, 35);
			this.panel4.TabIndex = 30;
			// 
			// customerSearch
			// 
			this.customerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerSearch.Location = new System.Drawing.Point(102, 5);
			this.customerSearch.Multiline = true;
			this.customerSearch.Name = "customerSearch";
			this.customerSearch.Size = new System.Drawing.Size(138, 25);
			this.customerSearch.TabIndex = 24;
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
			this.label2.Text = "Customer No";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.transactionSearch);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(245, 35);
			this.panel3.TabIndex = 29;
			// 
			// transactionSearch
			// 
			this.transactionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transactionSearch.Location = new System.Drawing.Point(102, 5);
			this.transactionSearch.Multiline = true;
			this.transactionSearch.Name = "transactionSearch";
			this.transactionSearch.Size = new System.Drawing.Size(138, 25);
			this.transactionSearch.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 25);
			this.label1.TabIndex = 23;
			this.label1.Text = "Transaction No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.Controls.Add(this.button2);
			this.roundedPanel2.CornerRadius = 20;
			this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel2.Location = new System.Drawing.Point(1033, 10);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Size = new System.Drawing.Size(125, 51);
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
			this.button2.Size = new System.Drawing.Size(125, 51);
			this.button2.TabIndex = 15;
			this.button2.Text = "Add New";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(59, 10);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.label5.Size = new System.Drawing.Size(125, 51);
			this.label5.TabIndex = 29;
			this.label5.Text = "Transaction List";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// TransactionList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1182, 891);
			this.Controls.Add(this.transactionListPanel);
			this.MinimumSize = new System.Drawing.Size(1000, 800);
			this.Name = "TransactionList";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "TransactionList";
			this.Load += new System.EventHandler(this.TransactionList_Load);
			this.Controls.SetChildIndex(this.transactionListPanel, 0);
			this.transactionListPanel.ResumeLayout(false);
			this.transactionTablePanel.ResumeLayout(false);
			this.DataPanel.ResumeLayout(false);
			this.HeaderPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.Footer.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.roundedPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel transactionListPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel transactionTablePanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Transaction_CheckDate;
		private System.Windows.Forms.Label Transaction_Check;
		private System.Windows.Forms.Label Transaction_Amount;
		private System.Windows.Forms.Label Transaction_Status;
		private System.Windows.Forms.Label Transaction_Action;
		private System.Windows.Forms.Panel DataPanel;
		private System.Windows.Forms.TableLayoutPanel TransactionDataPanel;
		private System.Windows.Forms.Label Transaction_CheckNumber;
		private System.Windows.Forms.Label Transaction_Customer;
		private System.Windows.Forms.Label Transaction_Number;
		private System.Windows.Forms.Panel Footer;
		private UserControls.PaginationControl PaginationControl;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox checkSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox customerSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox transactionSearch;
		private System.Windows.Forms.Label label1;
		private RoundedPanel roundedPanel2;
	}
}