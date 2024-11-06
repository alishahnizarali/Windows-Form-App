using AiCashGuard.UserControls;

namespace AiCashGuard.Forms
{
	partial class CustomerList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
			this.customerListPanel = new System.Windows.Forms.Panel();
			this.CustDataPanel = new System.Windows.Forms.Panel();
			this.Cust_Row_Panel = new System.Windows.Forms.Panel();
			this.CustRowDataPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Customer_ID = new System.Windows.Forms.Label();
			this.Customer_FirstName = new System.Windows.Forms.Label();
			this.Customer_LastName = new System.Windows.Forms.Label();
			this.Customer_Phone = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Customer_Address = new System.Windows.Forms.Label();
			this.Customer_Flag = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.paginationControl1 = new AiCashGuard.UserControls.PaginationControl();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.filterBtn = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.phoneSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.customerSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.idSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel2 = new AiCashGuard.UserControls.RoundedPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.DataPanel = new System.Windows.Forms.Panel();
			this.CustomerDataPanel = new System.Windows.Forms.TableLayoutPanel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Hist_Customer_ID = new System.Windows.Forms.Label();
			this.Hist_Customer_Name = new System.Windows.Forms.Label();
			this.Hist_Customer_Phone = new System.Windows.Forms.Label();
			this.Hist_Customer_Address = new System.Windows.Forms.Label();
			this.Hist_Customer_Action = new System.Windows.Forms.Label();
			this.Footer = new System.Windows.Forms.Panel();
			this.PaginationControl = new AiCashGuard.UserControls.PaginationControl();
			this.customerListPanel.SuspendLayout();
			this.CustDataPanel.SuspendLayout();
			this.Cust_Row_Panel.SuspendLayout();
			this.panel8.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.roundedPanel2.SuspendLayout();
			this.BackPanel.SuspendLayout();
			this.DataPanel.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.Footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// customerListPanel
			// 
			this.customerListPanel.Controls.Add(this.CustDataPanel);
			this.customerListPanel.Controls.Add(this.panel6);
			this.customerListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerListPanel.Location = new System.Drawing.Point(0, 0);
			this.customerListPanel.Name = "customerListPanel";
			this.customerListPanel.Padding = new System.Windows.Forms.Padding(5);
			this.customerListPanel.Size = new System.Drawing.Size(1182, 891);
			this.customerListPanel.TabIndex = 42;
			this.customerListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerListPanel_Paint);
			// 
			// CustDataPanel
			// 
			this.CustDataPanel.Controls.Add(this.Cust_Row_Panel);
			this.CustDataPanel.Controls.Add(this.panel8);
			this.CustDataPanel.Controls.Add(this.panel9);
			this.CustDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CustDataPanel.Location = new System.Drawing.Point(5, 76);
			this.CustDataPanel.Name = "CustDataPanel";
			this.CustDataPanel.Padding = new System.Windows.Forms.Padding(10);
			this.CustDataPanel.Size = new System.Drawing.Size(1172, 810);
			this.CustDataPanel.TabIndex = 21;
			// 
			// Cust_Row_Panel
			// 
			this.Cust_Row_Panel.Controls.Add(this.CustRowDataPanel);
			this.Cust_Row_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cust_Row_Panel.Location = new System.Drawing.Point(10, 37);
			this.Cust_Row_Panel.Name = "Cust_Row_Panel";
			this.Cust_Row_Panel.Padding = new System.Windows.Forms.Padding(5);
			this.Cust_Row_Panel.Size = new System.Drawing.Size(1152, 716);
			this.Cust_Row_Panel.TabIndex = 3;
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
			this.CustRowDataPanel.Size = new System.Drawing.Size(1142, 706);
			this.CustRowDataPanel.TabIndex = 0;
			this.CustRowDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CustRowDataPanel_Paint);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.panel8.Controls.Add(this.tableLayoutPanel3);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(10, 10);
			this.panel8.Name = "panel8";
			this.panel8.Padding = new System.Windows.Forms.Padding(5);
			this.panel8.Size = new System.Drawing.Size(1152, 27);
			this.panel8.TabIndex = 2;
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
			this.tableLayoutPanel3.Controls.Add(this.Customer_ID, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.Customer_FirstName, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.Customer_LastName, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.Customer_Phone, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 6, 0);
			this.tableLayoutPanel3.Controls.Add(this.Customer_Address, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.Customer_Flag, 5, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1142, 17);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// Customer_ID
			// 
			this.Customer_ID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_ID.ForeColor = System.Drawing.Color.White;
			this.Customer_ID.Location = new System.Drawing.Point(3, 0);
			this.Customer_ID.Name = "Customer_ID";
			this.Customer_ID.Size = new System.Drawing.Size(157, 17);
			this.Customer_ID.TabIndex = 0;
			this.Customer_ID.Text = "Customer ID";
			this.Customer_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_FirstName
			// 
			this.Customer_FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_FirstName.ForeColor = System.Drawing.Color.White;
			this.Customer_FirstName.Location = new System.Drawing.Point(166, 0);
			this.Customer_FirstName.Name = "Customer_FirstName";
			this.Customer_FirstName.Size = new System.Drawing.Size(157, 17);
			this.Customer_FirstName.TabIndex = 1;
			this.Customer_FirstName.Text = "Customer FirstName";
			this.Customer_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_LastName
			// 
			this.Customer_LastName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_LastName.ForeColor = System.Drawing.Color.White;
			this.Customer_LastName.Location = new System.Drawing.Point(329, 0);
			this.Customer_LastName.Name = "Customer_LastName";
			this.Customer_LastName.Size = new System.Drawing.Size(157, 17);
			this.Customer_LastName.TabIndex = 2;
			this.Customer_LastName.Text = "Customer LastName";
			this.Customer_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_Phone
			// 
			this.Customer_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_Phone.ForeColor = System.Drawing.Color.White;
			this.Customer_Phone.Location = new System.Drawing.Point(492, 0);
			this.Customer_Phone.Name = "Customer_Phone";
			this.Customer_Phone.Size = new System.Drawing.Size(157, 17);
			this.Customer_Phone.TabIndex = 3;
			this.Customer_Phone.Text = "Phone";
			this.Customer_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(981, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Action";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_Address
			// 
			this.Customer_Address.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_Address.ForeColor = System.Drawing.Color.White;
			this.Customer_Address.Location = new System.Drawing.Point(655, 0);
			this.Customer_Address.Name = "Customer_Address";
			this.Customer_Address.Size = new System.Drawing.Size(157, 17);
			this.Customer_Address.TabIndex = 5;
			this.Customer_Address.Text = "Address";
			this.Customer_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_Flag
			// 
			this.Customer_Flag.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_Flag.ForeColor = System.Drawing.Color.White;
			this.Customer_Flag.Location = new System.Drawing.Point(818, 0);
			this.Customer_Flag.Name = "Customer_Flag";
			this.Customer_Flag.Size = new System.Drawing.Size(157, 17);
			this.Customer_Flag.TabIndex = 6;
			this.Customer_Flag.Text = "Is Default";
			this.Customer_Flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.paginationControl1);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel9.Location = new System.Drawing.Point(10, 753);
			this.panel9.Name = "panel9";
			this.panel9.Padding = new System.Windows.Forms.Padding(5);
			this.panel9.Size = new System.Drawing.Size(1152, 47);
			this.panel9.TabIndex = 4;
			// 
			// paginationControl1
			// 
			this.paginationControl1.Dock = System.Windows.Forms.DockStyle.Right;
			this.paginationControl1.ItemsPerPage = 10;
			this.paginationControl1.Location = new System.Drawing.Point(819, 5);
			this.paginationControl1.Name = "paginationControl1";
			this.paginationControl1.Size = new System.Drawing.Size(328, 37);
			this.paginationControl1.TabIndex = 1;
			this.paginationControl1.TotalPages = 0;
			this.paginationControl1.PageChanged += new System.EventHandler(this.paginationControl1_PageChanged_1);
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
			this.panel6.Size = new System.Drawing.Size(1172, 71);
			this.panel6.TabIndex = 0;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.tableLayoutPanel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(184, 10);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(5);
			this.panel7.Size = new System.Drawing.Size(853, 51);
			this.panel7.TabIndex = 38;
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(843, 41);
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
			this.filterBtn.Location = new System.Drawing.Point(759, 3);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Padding = new System.Windows.Forms.Padding(2);
			this.filterBtn.Size = new System.Drawing.Size(81, 35);
			this.filterBtn.TabIndex = 32;
			this.filterBtn.Text = "Filter";
			this.filterBtn.UseVisualStyleBackColor = false;
			this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.phoneSearch);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(507, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(246, 35);
			this.panel5.TabIndex = 31;
			// 
			// phoneSearch
			// 
			this.phoneSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phoneSearch.Location = new System.Drawing.Point(102, 5);
			this.phoneSearch.Multiline = true;
			this.phoneSearch.Name = "phoneSearch";
			this.phoneSearch.Size = new System.Drawing.Size(139, 25);
			this.phoneSearch.TabIndex = 24;
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
			this.label3.Text = "Phone";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.customerSearch);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(255, 3);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(246, 35);
			this.panel4.TabIndex = 30;
			// 
			// customerSearch
			// 
			this.customerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerSearch.Location = new System.Drawing.Point(102, 5);
			this.customerSearch.Multiline = true;
			this.customerSearch.Name = "customerSearch";
			this.customerSearch.Size = new System.Drawing.Size(139, 25);
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
			this.label2.Text = "Customer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.idSearch);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(246, 35);
			this.panel3.TabIndex = 29;
			// 
			// idSearch
			// 
			this.idSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idSearch.Location = new System.Drawing.Point(102, 5);
			this.idSearch.Multiline = true;
			this.idSearch.Name = "idSearch";
			this.idSearch.Size = new System.Drawing.Size(139, 25);
			this.idSearch.TabIndex = 24;
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
			this.label1.Text = "ID No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.Controls.Add(this.button2);
			this.roundedPanel2.CornerRadius = 20;
			this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel2.Location = new System.Drawing.Point(1037, 10);
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
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.label5.Text = "Customer List";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.label5_Click);
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
			// BackPanel
			// 
			this.BackPanel.Controls.Add(this.DataPanel);
			this.BackPanel.Controls.Add(this.HeaderPanel);
			this.BackPanel.Controls.Add(this.Footer);
			this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackPanel.Location = new System.Drawing.Point(5, 76);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
			this.BackPanel.Size = new System.Drawing.Size(1172, 810);
			this.BackPanel.TabIndex = 1;
			// 
			// DataPanel
			// 
			this.DataPanel.Controls.Add(this.CustomerDataPanel);
			this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataPanel.Location = new System.Drawing.Point(10, 31);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Padding = new System.Windows.Forms.Padding(5);
			this.DataPanel.Size = new System.Drawing.Size(1152, 722);
			this.DataPanel.TabIndex = 2;
			// 
			// CustomerDataPanel
			// 
			this.CustomerDataPanel.Location = new System.Drawing.Point(0, 0);
			this.CustomerDataPanel.Name = "CustomerDataPanel";
			this.CustomerDataPanel.Size = new System.Drawing.Size(200, 100);
			this.CustomerDataPanel.TabIndex = 0;
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.HeaderPanel.Controls.Add(this.tableLayoutPanel1);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(10, 10);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5);
			this.HeaderPanel.Size = new System.Drawing.Size(1152, 21);
			this.HeaderPanel.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Hist_Customer_ID, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Hist_Customer_Name, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Hist_Customer_Phone, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Hist_Customer_Address, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Hist_Customer_Action, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 11);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Hist_Customer_ID
			// 
			this.Hist_Customer_ID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hist_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hist_Customer_ID.ForeColor = System.Drawing.Color.White;
			this.Hist_Customer_ID.Location = new System.Drawing.Point(3, 0);
			this.Hist_Customer_ID.Name = "Hist_Customer_ID";
			this.Hist_Customer_ID.Size = new System.Drawing.Size(222, 11);
			this.Hist_Customer_ID.TabIndex = 0;
			this.Hist_Customer_ID.Text = "ID Number";
			this.Hist_Customer_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Hist_Customer_Name
			// 
			this.Hist_Customer_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hist_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hist_Customer_Name.ForeColor = System.Drawing.Color.White;
			this.Hist_Customer_Name.Location = new System.Drawing.Point(231, 0);
			this.Hist_Customer_Name.Name = "Hist_Customer_Name";
			this.Hist_Customer_Name.Size = new System.Drawing.Size(222, 11);
			this.Hist_Customer_Name.TabIndex = 1;
			this.Hist_Customer_Name.Text = "Customer";
			this.Hist_Customer_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Hist_Customer_Phone
			// 
			this.Hist_Customer_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hist_Customer_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hist_Customer_Phone.ForeColor = System.Drawing.Color.White;
			this.Hist_Customer_Phone.Location = new System.Drawing.Point(459, 0);
			this.Hist_Customer_Phone.Name = "Hist_Customer_Phone";
			this.Hist_Customer_Phone.Size = new System.Drawing.Size(222, 11);
			this.Hist_Customer_Phone.TabIndex = 2;
			this.Hist_Customer_Phone.Text = "Phone";
			this.Hist_Customer_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Hist_Customer_Address
			// 
			this.Hist_Customer_Address.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hist_Customer_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hist_Customer_Address.ForeColor = System.Drawing.Color.White;
			this.Hist_Customer_Address.Location = new System.Drawing.Point(687, 0);
			this.Hist_Customer_Address.Name = "Hist_Customer_Address";
			this.Hist_Customer_Address.Size = new System.Drawing.Size(222, 11);
			this.Hist_Customer_Address.TabIndex = 3;
			this.Hist_Customer_Address.Text = "Address";
			this.Hist_Customer_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Hist_Customer_Action
			// 
			this.Hist_Customer_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hist_Customer_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hist_Customer_Action.ForeColor = System.Drawing.Color.White;
			this.Hist_Customer_Action.Location = new System.Drawing.Point(915, 0);
			this.Hist_Customer_Action.Name = "Hist_Customer_Action";
			this.Hist_Customer_Action.Size = new System.Drawing.Size(224, 11);
			this.Hist_Customer_Action.TabIndex = 4;
			this.Hist_Customer_Action.Text = "Action";
			this.Hist_Customer_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Footer
			// 
			this.Footer.Controls.Add(this.PaginationControl);
			this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Footer.Location = new System.Drawing.Point(10, 753);
			this.Footer.Name = "Footer";
			this.Footer.Padding = new System.Windows.Forms.Padding(5);
			this.Footer.Size = new System.Drawing.Size(1152, 47);
			this.Footer.TabIndex = 3;
			// 
			// PaginationControl
			// 
			this.PaginationControl.ItemsPerPage = 10;
			this.PaginationControl.Location = new System.Drawing.Point(0, 0);
			this.PaginationControl.Name = "PaginationControl";
			this.PaginationControl.Size = new System.Drawing.Size(322, 42);
			this.PaginationControl.TabIndex = 0;
			this.PaginationControl.TotalPages = 0;
			// 
			// CustomerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1182, 891);
			this.Controls.Add(this.customerListPanel);
			this.Name = "CustomerList";
			this.Load += new System.EventHandler(this.Customer_Load);
			this.Controls.SetChildIndex(this.customerListPanel, 0);
			this.customerListPanel.ResumeLayout(false);
			this.CustDataPanel.ResumeLayout(false);
			this.Cust_Row_Panel.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
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
			this.BackPanel.ResumeLayout(false);
			this.DataPanel.ResumeLayout(false);
			this.HeaderPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.Footer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Panel customerListPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label Hist_Customer_Action;
        private System.Windows.Forms.Label Hist_Customer_Address;
        private System.Windows.Forms.Label Hist_Customer_Phone;
        private System.Windows.Forms.Label Hist_Customer_Name;
        private System.Windows.Forms.Label Hist_Customer_ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel DataPanel;
		private System.Windows.Forms.TableLayoutPanel CustomerDataPanel;
		private System.Windows.Forms.Panel Footer;
		private UserControls.PaginationControl PaginationControl;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox phoneSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox customerSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox idSearch;
		private System.Windows.Forms.Label label1;
		private RoundedPanel roundedPanel2;
		private System.Windows.Forms.Panel CustDataPanel;
		private System.Windows.Forms.Panel Cust_Row_Panel;
		private System.Windows.Forms.TableLayoutPanel CustRowDataPanel;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label Customer_ID;
		private System.Windows.Forms.Label Customer_FirstName;
		private System.Windows.Forms.Label Customer_LastName;
		private System.Windows.Forms.Label Customer_Phone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Customer_Address;
		private System.Windows.Forms.Label Customer_Flag;
		private System.Windows.Forms.Panel panel9;
		private UserControls.PaginationControl paginationControl1;
	}
}