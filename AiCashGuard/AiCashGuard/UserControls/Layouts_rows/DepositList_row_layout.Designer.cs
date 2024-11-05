namespace AiCashGuard.UserControls.Layouts_rows
{
	partial class DepositList_row
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositList_row));
			this.CheckRow = new System.Windows.Forms.Panel();
			this.Check_Business = new System.Windows.Forms.Label();
			this.Check_Action = new System.Windows.Forms.Label();
			this.Check_Phone = new System.Windows.Forms.Label();
			this.Check_Transit = new System.Windows.Forms.Label();
			this.Check_Account = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.CheckActions = new MaterialSkin.Controls.MaterialContextMenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.CheckRow.Size = new System.Drawing.Size(779, 150);
			this.CheckRow.TabIndex = 4;
			// 
			// Check_Business
			// 
			this.Check_Business.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Business.Location = new System.Drawing.Point(309, 0);
			this.Check_Business.Name = "Check_Business";
			this.Check_Business.Size = new System.Drawing.Size(147, 140);
			this.Check_Business.TabIndex = 5;
			this.Check_Business.Text = "No of Checks";
			this.Check_Business.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Action
			// 
			this.Check_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Action.Image = ((System.Drawing.Image)(resources.GetObject("Check_Action.Image")));
			this.Check_Action.Location = new System.Drawing.Point(615, 0);
			this.Check_Action.Name = "Check_Action";
			this.Check_Action.Size = new System.Drawing.Size(151, 140);
			this.Check_Action.TabIndex = 4;
			this.Check_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Phone
			// 
			this.Check_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Phone.Location = new System.Drawing.Point(462, 0);
			this.Check_Phone.Name = "Check_Phone";
			this.Check_Phone.Size = new System.Drawing.Size(147, 140);
			this.Check_Phone.TabIndex = 3;
			this.Check_Phone.Text = "Total Amount";
			this.Check_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Transit
			// 
			this.Check_Transit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Transit.Location = new System.Drawing.Point(156, 0);
			this.Check_Transit.Name = "Check_Transit";
			this.Check_Transit.Size = new System.Drawing.Size(147, 140);
			this.Check_Transit.TabIndex = 1;
			this.Check_Transit.Text = "Deposit Date";
			this.Check_Transit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Account
			// 
			this.Check_Account.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Account.Location = new System.Drawing.Point(3, 0);
			this.Check_Account.Name = "Check_Account";
			this.Check_Account.Size = new System.Drawing.Size(147, 140);
			this.Check_Account.TabIndex = 0;
			this.Check_Account.Text = "Deposit ID";
			this.Check_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Check_Account, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Transit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Phone, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Action, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Business, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 140);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// CheckActions
			// 
			this.CheckActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.CheckActions.Depth = 0;
			this.CheckActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.deleteMenuItem});
			this.CheckActions.MouseState = MaterialSkin.MouseState.HOVER;
			this.CheckActions.Name = "CustomerActions";
			this.CheckActions.Size = new System.Drawing.Size(181, 70);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "Details";
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenuItem.Image")));
			this.deleteMenuItem.Name = "deleteMenuItem";
			this.deleteMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteMenuItem.Text = "Delete";
			// 
			// DepositList_row
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CheckRow);
			this.Name = "DepositList_row";
			this.Size = new System.Drawing.Size(779, 150);
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
		private System.Windows.Forms.Label Check_Phone;
		private System.Windows.Forms.Label Check_Action;
		private System.Windows.Forms.Label Check_Business;
		private MaterialSkin.Controls.MaterialContextMenuStrip CheckActions;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
	}
}
