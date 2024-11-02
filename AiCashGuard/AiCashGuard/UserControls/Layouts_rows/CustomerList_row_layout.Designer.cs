namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class CustomerList_row_layout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList_row_layout));
			this.CustomerRowPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Customer_ID = new System.Windows.Forms.Label();
			this.Customer_Name = new System.Windows.Forms.Label();
			this.Customer_Phone = new System.Windows.Forms.Label();
			this.Customer_Address = new System.Windows.Forms.Label();
			this.Customer_Action = new System.Windows.Forms.Label();
			this.Customer_LastName = new System.Windows.Forms.Label();
			this.Customer_Flag = new System.Windows.Forms.Label();
			this.CustomerActions = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.startTransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.securityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DetailsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.CustomerRowPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.CustomerActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// CustomerRowPanel
			// 
			this.CustomerRowPanel.BackColor = System.Drawing.Color.White;
			this.CustomerRowPanel.Controls.Add(this.tableLayoutPanel1);
			this.CustomerRowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CustomerRowPanel.Location = new System.Drawing.Point(0, 0);
			this.CustomerRowPanel.Name = "CustomerRowPanel";
			this.CustomerRowPanel.Padding = new System.Windows.Forms.Padding(5);
			this.CustomerRowPanel.Size = new System.Drawing.Size(483, 61);
			this.CustomerRowPanel.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.Customer_ID, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Name, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Phone, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_LastName, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Flag, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Address, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Customer_Action, 6, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 51);
			this.tableLayoutPanel1.TabIndex = 5;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Customer_ID
            // 
            this.Customer_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_ID.Location = new System.Drawing.Point(3, 0);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(131, 56);
            this.Customer_ID.TabIndex = 0;
            this.Customer_ID.Text = "Customer ID";
            this.Customer_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_Name
            // 
            this.Customer_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Name.Location = new System.Drawing.Point(140, 0);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(131, 56);
            this.Customer_Name.TabIndex = 1;
            this.Customer_Name.Text = "Customer First Name";
            this.Customer_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_Phone
            // 
            this.Customer_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Phone.Location = new System.Drawing.Point(277, 0);
            this.Customer_Phone.Name = "Customer_Phone";
            this.Customer_Phone.Size = new System.Drawing.Size(131, 56);
            this.Customer_Phone.TabIndex = 2;
            this.Customer_Phone.Text = "Customer_Phone";
            this.Customer_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_Flag
            // 
            this.Customer_Flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Flag.Location = new System.Drawing.Point(414, 0);
            this.Customer_Flag.Name = "Customer_Flag";
            this.Customer_Flag.Size = new System.Drawing.Size(131, 56);
            this.Customer_Flag.TabIndex = 3;
            this.Customer_Flag.Text = "Default";
            this.Customer_Flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_LastName
            // 
            this.Customer_LastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_LastName.Location = new System.Drawing.Point(551, 0);
            this.Customer_LastName.Name = "Customer_LastName";
            this.Customer_LastName.Size = new System.Drawing.Size(131, 56);
            this.Customer_LastName.TabIndex = 5;
            this.Customer_LastName.Text = "Customer_LastName";
            this.Customer_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_Address
            // 
            this.Customer_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Address.Location = new System.Drawing.Point(688, 0);
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.Size = new System.Drawing.Size(131, 56);
            this.Customer_Address.TabIndex = 6;
            this.Customer_Address.Text = "Customer_Address";
            this.Customer_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customer_Action
            // 
            this.Customer_Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Action.Image = ((System.Drawing.Image)(resources.GetObject("Customer_Action.Image")));
            this.Customer_Action.Location = new System.Drawing.Point(825, 0);
            this.Customer_Action.Name = "Customer_Action";
            this.Customer_Action.Size = new System.Drawing.Size(136, 56);
            this.Customer_Action.TabIndex = 6;
            this.Customer_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Customer_Action.Click += new System.EventHandler(this.Customer_Action_Click);
            // 
            // CustomerActions
            // 
            this.CustomerActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.CustomerActions.Depth = 0;
			this.CustomerActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTransactionMenuItem,
            this.DetailsToolStrip,
            this.editMenuItem,
            this.deleteMenuItem,
            this.printMenuItem,
            this.securityMenuItem});
			this.CustomerActions.MouseState = MaterialSkin.MouseState.HOVER;
			this.CustomerActions.Name = "CustomerActions";
			this.CustomerActions.Size = new System.Drawing.Size(181, 158);
			// 
			// startTransactionMenuItem
			// 
			this.startTransactionMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startTransactionMenuItem.Image")));
			this.startTransactionMenuItem.Name = "startTransactionMenuItem";
			this.startTransactionMenuItem.Size = new System.Drawing.Size(180, 22);
			this.startTransactionMenuItem.Text = "Start Transaction";
			this.startTransactionMenuItem.Click += new System.EventHandler(this.startTransactionMenuItem_Click);
			// 
			// editMenuItem
			// 
			this.editMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editMenuItem.Image")));
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editMenuItem.Text = "Edit";
			this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenuItem.Image")));
			this.deleteMenuItem.Name = "deleteMenuItem";
			this.deleteMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteMenuItem.Text = "Delete";
			this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
			// 
			// printMenuItem
			// 
			this.printMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printMenuItem.Image")));
			this.printMenuItem.Name = "printMenuItem";
			this.printMenuItem.Size = new System.Drawing.Size(180, 22);
			this.printMenuItem.Text = "Print";
			this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
			// 
			// securityMenuItem
			// 
			this.securityMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("securityMenuItem.Image")));
			this.securityMenuItem.Name = "securityMenuItem";
			this.securityMenuItem.Size = new System.Drawing.Size(180, 22);
			this.securityMenuItem.Text = "Security";
			this.securityMenuItem.Click += new System.EventHandler(this.securityMenuItem_Click);
			// 
			// DetailsToolStrip
			// 
			this.DetailsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DetailsToolStrip.Image")));
			this.DetailsToolStrip.Name = "DetailsToolStrip";
			this.DetailsToolStrip.Size = new System.Drawing.Size(180, 22);
			this.DetailsToolStrip.Text = "Details";
			this.DetailsToolStrip.Click += new System.EventHandler(this.DetailsToolStrip_Click);
			// 
			// CustomerList_row_layout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.CustomerRowPanel);
			this.Name = "CustomerList_row_layout";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.Size = new System.Drawing.Size(483, 66);
			this.Load += new System.EventHandler(this.CustomerList_row_layout_Load);
			this.CustomerRowPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.CustomerActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel CustomerRowPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.Label Customer_ID;
		public System.Windows.Forms.Label Customer_Name;
		public System.Windows.Forms.Label Customer_Phone;
		public System.Windows.Forms.Label Customer_Address;
		public System.Windows.Forms.Label Customer_Action;
		public System.Windows.Forms.Label Customer_Flag;
		public System.Windows.Forms.Label Customer_LastName;
		private MaterialSkin.Controls.MaterialContextMenuStrip CustomerActions;
		private System.Windows.Forms.ToolStripMenuItem startTransactionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printMenuItem;
		private System.Windows.Forms.ToolStripMenuItem securityMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DetailsToolStrip;
	}
}
