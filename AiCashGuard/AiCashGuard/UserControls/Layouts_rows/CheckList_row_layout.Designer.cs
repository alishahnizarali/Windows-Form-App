namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class CheckList_row_layout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckList_row_layout));
			this.CheckRow = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Check_Account = new System.Windows.Forms.Label();
			this.Check_Transit = new System.Windows.Forms.Label();
			this.Check_Default = new System.Windows.Forms.Label();
			this.Check_Phone = new System.Windows.Forms.Label();
			this.Check_Action = new System.Windows.Forms.Label();
			this.Check_Address = new System.Windows.Forms.Label();
			this.Check_Business = new System.Windows.Forms.Label();
			this.CheckActions = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.startTransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.securityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.CheckRow.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.CheckActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// CheckRow
			// 
			this.CheckRow.BackColor = System.Drawing.Color.White;
			this.CheckRow.Controls.Add(this.tableLayoutPanel1);
			this.CheckRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CheckRow.Location = new System.Drawing.Point(0, 0);
			this.CheckRow.Name = "CheckRow";
			this.CheckRow.Padding = new System.Windows.Forms.Padding(5);
			this.CheckRow.Size = new System.Drawing.Size(974, 66);
			this.CheckRow.TabIndex = 3;
			this.CheckRow.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckRow_Paint);
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
			this.tableLayoutPanel1.Controls.Add(this.Check_Action, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Address, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Business, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 56);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Check_Account
			// 
			this.Check_Account.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Account.Location = new System.Drawing.Point(3, 0);
			this.Check_Account.Name = "Check_Account";
			this.Check_Account.Size = new System.Drawing.Size(131, 56);
			this.Check_Account.TabIndex = 0;
			this.Check_Account.Text = "Account Number";
			this.Check_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Transit
			// 
			this.Check_Transit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Transit.Location = new System.Drawing.Point(140, 0);
			this.Check_Transit.Name = "Check_Transit";
			this.Check_Transit.Size = new System.Drawing.Size(131, 56);
			this.Check_Transit.TabIndex = 1;
			this.Check_Transit.Text = "Transit Number";
			this.Check_Transit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Default
			// 
			this.Check_Default.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Default.Location = new System.Drawing.Point(277, 0);
			this.Check_Default.Name = "Check_Default";
			this.Check_Default.Size = new System.Drawing.Size(131, 56);
			this.Check_Default.TabIndex = 2;
			this.Check_Default.Text = "Check Number";
			this.Check_Default.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Phone
			// 
			this.Check_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Phone.Location = new System.Drawing.Point(414, 0);
			this.Check_Phone.Name = "Check_Phone";
			this.Check_Phone.Size = new System.Drawing.Size(131, 56);
			this.Check_Phone.TabIndex = 3;
			this.Check_Phone.Text = "Phone";
			this.Check_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Action
			// 
			this.Check_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Action.Image = ((System.Drawing.Image)(resources.GetObject("Check_Action.Image")));
			this.Check_Action.Location = new System.Drawing.Point(825, 0);
			this.Check_Action.Name = "Check_Action";
			this.Check_Action.Size = new System.Drawing.Size(136, 56);
			this.Check_Action.TabIndex = 4;
			this.Check_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Check_Action.Click += new System.EventHandler(this.Check_Action_Click);
			// 
			// Check_Address
			// 
			this.Check_Address.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Address.Location = new System.Drawing.Point(688, 0);
			this.Check_Address.Name = "Check_Address";
			this.Check_Address.Size = new System.Drawing.Size(131, 56);
			this.Check_Address.TabIndex = 6;
			this.Check_Address.Text = "Address";
			this.Check_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Business
			// 
			this.Check_Business.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Business.Location = new System.Drawing.Point(551, 0);
			this.Check_Business.Name = "Check_Business";
			this.Check_Business.Size = new System.Drawing.Size(131, 56);
			this.Check_Business.TabIndex = 5;
			this.Check_Business.Text = "Business Name";
			this.Check_Business.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CheckActions
			// 
			this.CheckActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.CheckActions.Depth = 0;
			this.CheckActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTransactionMenuItem,
            this.toolStripMenuItem1,
            this.editMenuItem,
            this.deleteMenuItem,
            this.securityMenuItem});
			this.CheckActions.MouseState = MaterialSkin.MouseState.HOVER;
			this.CheckActions.Name = "CustomerActions";
			this.CheckActions.Size = new System.Drawing.Size(181, 136);
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
			// securityMenuItem
			// 
			this.securityMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("securityMenuItem.Image")));
			this.securityMenuItem.Name = "securityMenuItem";
			this.securityMenuItem.Size = new System.Drawing.Size(180, 22);
			this.securityMenuItem.Text = "Security";
			this.securityMenuItem.Click += new System.EventHandler(this.securityMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "Details";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// CheckList_row_layout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.CheckRow);
			this.Name = "CheckList_row_layout";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.Size = new System.Drawing.Size(974, 71);
			this.CheckRow.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.CheckActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel CheckRow;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Check_Account;
		private System.Windows.Forms.Label Check_Transit;
		private System.Windows.Forms.Label Check_Default;
		private System.Windows.Forms.Label Check_Phone;
		private System.Windows.Forms.Label Check_Action;
		private System.Windows.Forms.Label Check_Address;
		private System.Windows.Forms.Label Check_Business;
		private MaterialSkin.Controls.MaterialContextMenuStrip CheckActions;
		private System.Windows.Forms.ToolStripMenuItem startTransactionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem securityMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
	}
}
