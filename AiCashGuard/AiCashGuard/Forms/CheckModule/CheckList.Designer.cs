using AiCashGuard.UserControls;

namespace AiCashGuard.Forms
{
	partial class CheckList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckList));
			this.checkListPanel = new System.Windows.Forms.Panel();
			this.checkDataPanel = new System.Windows.Forms.Panel();
			this.Check_Row_Panel = new System.Windows.Forms.Panel();
			this.CheckRowDataPanel = new System.Windows.Forms.TableLayoutPanel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Check_Account = new System.Windows.Forms.Label();
			this.Check_Transit = new System.Windows.Forms.Label();
			this.Check_Default = new System.Windows.Forms.Label();
			this.Check_Phone = new System.Windows.Forms.Label();
			this.Customer_Action = new System.Windows.Forms.Label();
			this.Check_Address = new System.Windows.Forms.Label();
			this.Check_Business = new System.Windows.Forms.Label();
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
			this.transitSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.accountSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.roundedPanel2 = new RoundedPanel();
			this.AddCheck = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.checkListPanel.SuspendLayout();
			this.checkDataPanel.SuspendLayout();
			this.Check_Row_Panel.SuspendLayout();
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
			// checkListPanel
			// 
			this.checkListPanel.AutoScroll = true;
			this.checkListPanel.Controls.Add(this.checkDataPanel);
			this.checkListPanel.Controls.Add(this.panel6);
			this.checkListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkListPanel.Location = new System.Drawing.Point(0, 0);
			this.checkListPanel.Name = "checkListPanel";
			this.checkListPanel.Padding = new System.Windows.Forms.Padding(5);
			this.checkListPanel.Size = new System.Drawing.Size(1182, 891);
			this.checkListPanel.TabIndex = 0;
			this.checkListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.checkListPanel_Paint);
			// 
			// checkDataPanel
			// 
			this.checkDataPanel.Controls.Add(this.Check_Row_Panel);
			this.checkDataPanel.Controls.Add(this.HeaderPanel);
			this.checkDataPanel.Controls.Add(this.Footer);
			this.checkDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkDataPanel.Location = new System.Drawing.Point(5, 76);
			this.checkDataPanel.Name = "checkDataPanel";
			this.checkDataPanel.Padding = new System.Windows.Forms.Padding(10);
			this.checkDataPanel.Size = new System.Drawing.Size(1172, 810);
			this.checkDataPanel.TabIndex = 20;
			// 
			// Check_Row_Panel
			// 
			this.Check_Row_Panel.Controls.Add(this.CheckRowDataPanel);
			this.Check_Row_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Row_Panel.Location = new System.Drawing.Point(10, 37);
			this.Check_Row_Panel.Name = "Check_Row_Panel";
			this.Check_Row_Panel.Padding = new System.Windows.Forms.Padding(5);
			this.Check_Row_Panel.Size = new System.Drawing.Size(1152, 716);
			this.Check_Row_Panel.TabIndex = 3;
			// 
			// CheckRowDataPanel
			// 
			this.CheckRowDataPanel.AutoScroll = true;
			this.CheckRowDataPanel.ColumnCount = 1;
			this.CheckRowDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CheckRowDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CheckRowDataPanel.Location = new System.Drawing.Point(5, 5);
			this.CheckRowDataPanel.Name = "CheckRowDataPanel";
			this.CheckRowDataPanel.RowCount = 1;
			this.CheckRowDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.CheckRowDataPanel.Size = new System.Drawing.Size(1142, 706);
			this.CheckRowDataPanel.TabIndex = 0;
			this.CheckRowDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckRowDataPanel_Paint);
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.HeaderPanel.Controls.Add(this.tableLayoutPanel1);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(10, 10);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5);
			this.HeaderPanel.Size = new System.Drawing.Size(1152, 27);
			this.HeaderPanel.TabIndex = 2;
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
			this.tableLayoutPanel1.Controls.Add(this.Check_Account, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Transit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Default, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Phone, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Action, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Address, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Business, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 17);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Check_Account
			// 
			this.Check_Account.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Account.ForeColor = System.Drawing.Color.White;
			this.Check_Account.Location = new System.Drawing.Point(3, 0);
			this.Check_Account.Name = "Check_Account";
			this.Check_Account.Size = new System.Drawing.Size(157, 17);
			this.Check_Account.TabIndex = 0;
			this.Check_Account.Text = "Account Number";
			this.Check_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Transit
			// 
			this.Check_Transit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Transit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Transit.ForeColor = System.Drawing.Color.White;
			this.Check_Transit.Location = new System.Drawing.Point(166, 0);
			this.Check_Transit.Name = "Check_Transit";
			this.Check_Transit.Size = new System.Drawing.Size(157, 17);
			this.Check_Transit.TabIndex = 1;
			this.Check_Transit.Text = "Transit Number";
			this.Check_Transit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Check_Transit.Click += new System.EventHandler(this.Customer_Name_Click);
			// 
			// Check_Default
			// 
			this.Check_Default.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Default.ForeColor = System.Drawing.Color.White;
			this.Check_Default.Location = new System.Drawing.Point(329, 0);
			this.Check_Default.Name = "Check_Default";
			this.Check_Default.Size = new System.Drawing.Size(157, 17);
			this.Check_Default.TabIndex = 2;
			this.Check_Default.Text = "Is Default";
			this.Check_Default.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Phone
			// 
			this.Check_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Phone.ForeColor = System.Drawing.Color.White;
			this.Check_Phone.Location = new System.Drawing.Point(492, 0);
			this.Check_Phone.Name = "Check_Phone";
			this.Check_Phone.Size = new System.Drawing.Size(157, 17);
			this.Check_Phone.TabIndex = 3;
			this.Check_Phone.Text = "Phone";
			this.Check_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Customer_Action
			// 
			this.Customer_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Customer_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customer_Action.ForeColor = System.Drawing.Color.White;
			this.Customer_Action.Location = new System.Drawing.Point(981, 0);
			this.Customer_Action.Name = "Customer_Action";
			this.Customer_Action.Size = new System.Drawing.Size(158, 17);
			this.Customer_Action.TabIndex = 4;
			this.Customer_Action.Text = "Action";
			this.Customer_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Address
			// 
			this.Check_Address.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Address.ForeColor = System.Drawing.Color.White;
			this.Check_Address.Location = new System.Drawing.Point(818, 0);
			this.Check_Address.Name = "Check_Address";
			this.Check_Address.Size = new System.Drawing.Size(157, 17);
			this.Check_Address.TabIndex = 6;
			this.Check_Address.Text = "Address";
			this.Check_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Business
			// 
			this.Check_Business.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Business.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Check_Business.ForeColor = System.Drawing.Color.White;
			this.Check_Business.Location = new System.Drawing.Point(655, 0);
			this.Check_Business.Name = "Check_Business";
			this.Check_Business.Size = new System.Drawing.Size(157, 17);
			this.Check_Business.TabIndex = 5;
			this.Check_Business.Text = "Check Name";
			this.Check_Business.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Footer
			// 
			this.Footer.Controls.Add(this.PaginationControl);
			this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Footer.Location = new System.Drawing.Point(10, 753);
			this.Footer.Name = "Footer";
			this.Footer.Padding = new System.Windows.Forms.Padding(5);
			this.Footer.Size = new System.Drawing.Size(1152, 47);
			this.Footer.TabIndex = 4;
			// 
			// PaginationControl
			// 
			this.PaginationControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.PaginationControl.ItemsPerPage = 10;
			this.PaginationControl.Location = new System.Drawing.Point(819, 5);
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
			this.panel6.Size = new System.Drawing.Size(1172, 71);
			this.panel6.TabIndex = 19;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.tableLayoutPanel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(161, 10);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(5);
			this.panel7.Size = new System.Drawing.Size(876, 51);
			this.panel7.TabIndex = 37;
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
			this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 41);
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
			this.filterBtn.Location = new System.Drawing.Point(780, 3);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Padding = new System.Windows.Forms.Padding(2);
			this.filterBtn.Size = new System.Drawing.Size(83, 35);
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
			this.panel5.Location = new System.Drawing.Point(521, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(253, 35);
			this.panel5.TabIndex = 31;
			// 
			// checkSearch
			// 
			this.checkSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkSearch.Location = new System.Drawing.Point(102, 5);
			this.checkSearch.Multiline = true;
			this.checkSearch.Name = "checkSearch";
			this.checkSearch.Size = new System.Drawing.Size(146, 25);
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
			this.label3.Text = "Check Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.transitSearch);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(262, 3);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(253, 35);
			this.panel4.TabIndex = 30;
			// 
			// transitSearch
			// 
			this.transitSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transitSearch.Location = new System.Drawing.Point(102, 5);
			this.transitSearch.Multiline = true;
			this.transitSearch.Name = "transitSearch";
			this.transitSearch.Size = new System.Drawing.Size(146, 25);
			this.transitSearch.TabIndex = 24;
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
			this.label2.Text = "Transit No";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.accountSearch);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(253, 35);
			this.panel3.TabIndex = 29;
			// 
			// accountSearch
			// 
			this.accountSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountSearch.Location = new System.Drawing.Point(102, 5);
			this.accountSearch.Multiline = true;
			this.accountSearch.Name = "accountSearch";
			this.accountSearch.Size = new System.Drawing.Size(146, 25);
			this.accountSearch.TabIndex = 24;
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
			this.label1.Text = "Account No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.roundedPanel2.Controls.Add(this.AddCheck);
			this.roundedPanel2.CornerRadius = 20;
			this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel2.Location = new System.Drawing.Point(1037, 10);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Size = new System.Drawing.Size(125, 51);
			this.roundedPanel2.TabIndex = 36;
			// 
			// AddCheck
			// 
			this.AddCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.AddCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddCheck.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.AddCheck.FlatAppearance.BorderSize = 0;
			this.AddCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddCheck.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddCheck.ForeColor = System.Drawing.Color.White;
			this.AddCheck.Image = ((System.Drawing.Image)(resources.GetObject("AddCheck.Image")));
			this.AddCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddCheck.Location = new System.Drawing.Point(0, 0);
			this.AddCheck.Name = "AddCheck";
			this.AddCheck.Padding = new System.Windows.Forms.Padding(10);
			this.AddCheck.Size = new System.Drawing.Size(125, 51);
			this.AddCheck.TabIndex = 15;
			this.AddCheck.Text = "Add New";
			this.AddCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddCheck.UseVisualStyleBackColor = false;
			this.AddCheck.Click += new System.EventHandler(this.AddCheck_Click);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(59, 10);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.label5.Size = new System.Drawing.Size(102, 51);
			this.label5.TabIndex = 29;
			this.label5.Text = "Check List";
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
			// CheckList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 891);
			this.Controls.Add(this.checkListPanel);
			this.Name = "CheckList";
			this.Text = "CheckList";
			this.Load += new System.EventHandler(this.CheckList_Load);
			this.Controls.SetChildIndex(this.checkListPanel, 0);
			this.checkListPanel.ResumeLayout(false);
			this.checkDataPanel.ResumeLayout(false);
			this.Check_Row_Panel.ResumeLayout(false);
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

		private System.Windows.Forms.Panel checkListPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button AddCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel checkDataPanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Check_Account;
		private System.Windows.Forms.Label Check_Transit;
		private System.Windows.Forms.Label Check_Default;
		private System.Windows.Forms.Label Check_Phone;
		private System.Windows.Forms.Label Customer_Action;
		private System.Windows.Forms.Label Check_Business;
		private System.Windows.Forms.Label Check_Address;
		private System.Windows.Forms.Panel Check_Row_Panel;
		private System.Windows.Forms.TableLayoutPanel CheckRowDataPanel;
		private System.Windows.Forms.Panel Footer;
		private UserControls.PaginationControl PaginationControl;
		private System.Windows.Forms.TextBox accountSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox checkSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox transitSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.Panel panel7;
        private RoundedPanel roundedPanel2;
    }
}