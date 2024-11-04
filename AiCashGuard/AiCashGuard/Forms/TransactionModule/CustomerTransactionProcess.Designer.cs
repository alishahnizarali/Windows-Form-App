using AiCashGuard.UserControls;

namespace AiCashGuard.Forms.TransactionModule
{
	partial class CustomerTransactionProcess
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransactionProcess));
			this.BackPanel = new System.Windows.Forms.Panel();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.Step_Label = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Cancel_Transaction = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Back_Btn = new System.Windows.Forms.Button();
			this.Next_Btn = new System.Windows.Forms.Button();
			this.transactionProgressBar = new System.Windows.Forms.ProgressBar();
			this.panel6 = new System.Windows.Forms.Panel();
			this.roundedPanel4 = new AiCashGuard.UserControls.RoundedPanel();
			this.Cust_SearchBar = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label6 = new System.Windows.Forms.Label();
			this.roundedPanel3 = new AiCashGuard.UserControls.RoundedPanel();
			this.Add_Cust_Btn = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.BackPanel.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.roundedPanel4.SuspendLayout();
			this.roundedPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackPanel
			// 
			this.BackPanel.AutoScroll = true;
			this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.BackPanel.Controls.Add(this.searchPanel);
			this.BackPanel.Controls.Add(this.panel5);
			this.BackPanel.Controls.Add(this.panel3);
			this.BackPanel.Controls.Add(this.panel4);
			this.BackPanel.Controls.Add(this.transactionProgressBar);
			this.BackPanel.Controls.Add(this.panel6);
			this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackPanel.Location = new System.Drawing.Point(0, 0);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(1065, 800);
			this.BackPanel.TabIndex = 0;
			this.BackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// searchPanel
			// 
			this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPanel.AutoScroll = true;
			this.searchPanel.BackColor = System.Drawing.Color.White;
			this.searchPanel.Controls.Add(this.searchTableLayoutPanel);
			this.searchPanel.Location = new System.Drawing.Point(214, 64);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Padding = new System.Windows.Forms.Padding(5);
			this.searchPanel.Size = new System.Drawing.Size(636, 111);
			this.searchPanel.TabIndex = 41;
			this.searchPanel.Visible = false;
			// 
			// searchTableLayoutPanel
			// 
			this.searchTableLayoutPanel.AutoScroll = true;
			this.searchTableLayoutPanel.ColumnCount = 1;
			this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
			this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
			this.searchTableLayoutPanel.RowCount = 1;
			this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.searchTableLayoutPanel.Size = new System.Drawing.Size(626, 101);
			this.searchTableLayoutPanel.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.Step_Label);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.Cancel_Transaction);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 81);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1065, 54);
			this.panel5.TabIndex = 37;
			// 
			// Step_Label
			// 
			this.Step_Label.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Step_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
			this.Step_Label.Location = new System.Drawing.Point(0, 23);
			this.Step_Label.Name = "Step_Label";
			this.Step_Label.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.Step_Label.Size = new System.Drawing.Size(915, 29);
			this.Step_Label.TabIndex = 30;
			this.Step_Label.Text = "Step # 1 / 3";
			this.Step_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.label5.Size = new System.Drawing.Size(915, 23);
			this.label5.TabIndex = 29;
			this.label5.Text = "Select Customer";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// Cancel_Transaction
			// 
			this.Cancel_Transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Cancel_Transaction.Dock = System.Windows.Forms.DockStyle.Right;
			this.Cancel_Transaction.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.Cancel_Transaction.FlatAppearance.BorderSize = 0;
			this.Cancel_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel_Transaction.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel_Transaction.ForeColor = System.Drawing.Color.White;
			this.Cancel_Transaction.Location = new System.Drawing.Point(915, 0);
			this.Cancel_Transaction.Name = "Cancel_Transaction";
			this.Cancel_Transaction.Size = new System.Drawing.Size(150, 54);
			this.Cancel_Transaction.TabIndex = 15;
			this.Cancel_Transaction.Text = "Cancel Transaction";
			this.Cancel_Transaction.UseVisualStyleBackColor = false;
			this.Cancel_Transaction.Click += new System.EventHandler(this.Cancel_Transaction_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 81);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1065, 629);
			this.panel3.TabIndex = 3;
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.AutoScroll = true;
			this.panel7.BackColor = System.Drawing.Color.White;
			this.panel7.Controls.Add(this.tableLayoutPanel1);
			this.panel7.Controls.Add(this.label2);
			this.panel7.Location = new System.Drawing.Point(170, 105);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(745, 483);
			this.panel7.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 100);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(745, 43);
			this.label2.TabIndex = 1;
			this.label2.Text = "Recently Cashed By These Customer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Back_Btn);
			this.panel4.Controls.Add(this.Next_Btn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 710);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(20);
			this.panel4.Size = new System.Drawing.Size(1065, 90);
			this.panel4.TabIndex = 0;
			// 
			// Back_Btn
			// 
			this.Back_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Back_Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back_Btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.Back_Btn.FlatAppearance.BorderSize = 0;
			this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Back_Btn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back_Btn.ForeColor = System.Drawing.Color.White;
			this.Back_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_Btn.Image")));
			this.Back_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Back_Btn.Location = new System.Drawing.Point(20, 20);
			this.Back_Btn.Name = "Back_Btn";
			this.Back_Btn.Padding = new System.Windows.Forms.Padding(10);
			this.Back_Btn.Size = new System.Drawing.Size(99, 50);
			this.Back_Btn.TabIndex = 17;
			this.Back_Btn.Text = "Back";
			this.Back_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Back_Btn.UseVisualStyleBackColor = false;
			this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
			// 
			// Next_Btn
			// 
			this.Next_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Next_Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next_Btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.Next_Btn.FlatAppearance.BorderSize = 0;
			this.Next_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Next_Btn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Next_Btn.ForeColor = System.Drawing.Color.White;
			this.Next_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Next_Btn.Image")));
			this.Next_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Next_Btn.Location = new System.Drawing.Point(951, 20);
			this.Next_Btn.Name = "Next_Btn";
			this.Next_Btn.Padding = new System.Windows.Forms.Padding(10);
			this.Next_Btn.Size = new System.Drawing.Size(94, 50);
			this.Next_Btn.TabIndex = 16;
			this.Next_Btn.Text = "Next";
			this.Next_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Next_Btn.UseVisualStyleBackColor = false;
			this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
			// 
			// transactionProgressBar
			// 
			this.transactionProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.transactionProgressBar.Location = new System.Drawing.Point(0, 71);
			this.transactionProgressBar.Name = "transactionProgressBar";
			this.transactionProgressBar.Size = new System.Drawing.Size(1065, 10);
			this.transactionProgressBar.TabIndex = 3;
			this.transactionProgressBar.Click += new System.EventHandler(this.transactionProgressBar_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.roundedPanel4);
			this.panel6.Controls.Add(this.roundedPanel3);
			this.panel6.Controls.Add(this.label9);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(10);
			this.panel6.Size = new System.Drawing.Size(1065, 71);
			this.panel6.TabIndex = 39;
			// 
			// roundedPanel4
			// 
			this.roundedPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.roundedPanel4.BackColor = System.Drawing.Color.White;
			this.roundedPanel4.Controls.Add(this.Cust_SearchBar);
			this.roundedPanel4.Controls.Add(this.label6);
			this.roundedPanel4.CornerRadius = 20;
			this.roundedPanel4.Location = new System.Drawing.Point(214, 13);
			this.roundedPanel4.Name = "roundedPanel4";
			this.roundedPanel4.Padding = new System.Windows.Forms.Padding(10);
			this.roundedPanel4.Size = new System.Drawing.Size(636, 45);
			this.roundedPanel4.TabIndex = 38;
			// 
			// Cust_SearchBar
			// 
			this.Cust_SearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Cust_SearchBar.Depth = 0;
			this.Cust_SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cust_SearchBar.Hint = "Search.";
			this.Cust_SearchBar.Location = new System.Drawing.Point(45, 10);
			this.Cust_SearchBar.MouseState = MaterialSkin.MouseState.HOVER;
			this.Cust_SearchBar.Name = "Cust_SearchBar";
			this.Cust_SearchBar.PasswordChar = '\0';
			this.Cust_SearchBar.SelectedText = "";
			this.Cust_SearchBar.SelectionLength = 0;
			this.Cust_SearchBar.SelectionStart = 0;
			this.Cust_SearchBar.Size = new System.Drawing.Size(581, 23);
			this.Cust_SearchBar.TabIndex = 1;
			this.Cust_SearchBar.UseSystemPasswordChar = false;
			this.Cust_SearchBar.TextChanged += new System.EventHandler(this.Cust_SearchBar_TextChanged);
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Left;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(10, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "  ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedPanel3
			// 
			this.roundedPanel3.Controls.Add(this.Add_Cust_Btn);
			this.roundedPanel3.CornerRadius = 20;
			this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel3.Location = new System.Drawing.Point(930, 10);
			this.roundedPanel3.Name = "roundedPanel3";
			this.roundedPanel3.Size = new System.Drawing.Size(125, 51);
			this.roundedPanel3.TabIndex = 36;
			// 
			// Add_Cust_Btn
			// 
			this.Add_Cust_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Add_Cust_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Add_Cust_Btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
			this.Add_Cust_Btn.FlatAppearance.BorderSize = 0;
			this.Add_Cust_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add_Cust_Btn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_Cust_Btn.ForeColor = System.Drawing.Color.White;
			this.Add_Cust_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Cust_Btn.Image")));
			this.Add_Cust_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Add_Cust_Btn.Location = new System.Drawing.Point(0, 0);
			this.Add_Cust_Btn.Name = "Add_Cust_Btn";
			this.Add_Cust_Btn.Padding = new System.Windows.Forms.Padding(10);
			this.Add_Cust_Btn.Size = new System.Drawing.Size(125, 51);
			this.Add_Cust_Btn.TabIndex = 15;
			this.Add_Cust_Btn.Text = "Add New";
			this.Add_Cust_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Add_Cust_Btn.UseVisualStyleBackColor = false;
			this.Add_Cust_Btn.Click += new System.EventHandler(this.Add_Cust_Btn_Click);
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Left;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(10, 10);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.label9.Size = new System.Drawing.Size(164, 51);
			this.label9.TabIndex = 29;
			this.label9.Text = "Transaction Process";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 200, 0, 0);
			this.pictureBox2.Size = new System.Drawing.Size(1065, 477);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(5);
			this.panel2.Size = new System.Drawing.Size(1065, 64);
			this.panel2.TabIndex = 36;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 54);
			this.label1.TabIndex = 38;
			this.label1.Text = "Transaction Process";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CustomerTransactionProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 800);
			this.Controls.Add(this.BackPanel);
			this.MinimumSize = new System.Drawing.Size(1000, 800);
			this.Name = "CustomerTransactionProcess";
			this.Text = "TransactionProcess";
			this.Load += new System.EventHandler(this.CustomerTransactionProcess_Load);
			this.Controls.SetChildIndex(this.BackPanel, 0);
			this.BackPanel.ResumeLayout(false);
			this.searchPanel.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.roundedPanel4.ResumeLayout(false);
			this.roundedPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label Step_Label;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button Back_Btn;
		private System.Windows.Forms.Button Next_Btn;
		private System.Windows.Forms.Button Cancel_Transaction;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ProgressBar transactionProgressBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private RoundedPanel roundedPanel3;
		private System.Windows.Forms.Button Add_Cust_Btn;
		private System.Windows.Forms.Label label9;
		private RoundedPanel roundedPanel4;
		private MaterialSkin.Controls.MaterialSingleLineTextField Cust_SearchBar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}