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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Deposit_ID = new System.Windows.Forms.Label();
			this.Deposit_Date = new System.Windows.Forms.Label();
			this.Deposit_Amount = new System.Windows.Forms.Label();
			this.Check_Action = new System.Windows.Forms.Label();
			this.Deposit_Checks = new System.Windows.Forms.Label();
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
			this.CheckRow.Dock = System.Windows.Forms.DockStyle.Top;
			this.CheckRow.Location = new System.Drawing.Point(0, 0);
			this.CheckRow.Name = "CheckRow";
			this.CheckRow.Padding = new System.Windows.Forms.Padding(5);
			this.CheckRow.Size = new System.Drawing.Size(779, 47);
			this.CheckRow.TabIndex = 4;
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
			this.tableLayoutPanel1.Controls.Add(this.Deposit_ID, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Deposit_Date, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Deposit_Amount, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Check_Action, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Deposit_Checks, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 37);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Deposit_ID
			// 
			this.Deposit_ID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Deposit_ID.Location = new System.Drawing.Point(3, 0);
			this.Deposit_ID.Name = "Deposit_ID";
			this.Deposit_ID.Size = new System.Drawing.Size(147, 37);
			this.Deposit_ID.TabIndex = 0;
			this.Deposit_ID.Text = "Deposit ID";
			this.Deposit_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Deposit_Date
			// 
			this.Deposit_Date.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Deposit_Date.Location = new System.Drawing.Point(156, 0);
			this.Deposit_Date.Name = "Deposit_Date";
			this.Deposit_Date.Size = new System.Drawing.Size(147, 37);
			this.Deposit_Date.TabIndex = 1;
			this.Deposit_Date.Text = "Deposit Date";
			this.Deposit_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Deposit_Amount
			// 
			this.Deposit_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Deposit_Amount.Location = new System.Drawing.Point(462, 0);
			this.Deposit_Amount.Name = "Deposit_Amount";
			this.Deposit_Amount.Size = new System.Drawing.Size(147, 37);
			this.Deposit_Amount.TabIndex = 3;
			this.Deposit_Amount.Text = "Total Amount";
			this.Deposit_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check_Action
			// 
			this.Check_Action.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Check_Action.Image = ((System.Drawing.Image)(resources.GetObject("Check_Action.Image")));
			this.Check_Action.Location = new System.Drawing.Point(615, 0);
			this.Check_Action.Name = "Check_Action";
			this.Check_Action.Size = new System.Drawing.Size(151, 37);
			this.Check_Action.TabIndex = 4;
			this.Check_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Check_Action.Click += new System.EventHandler(this.Check_Action_Click);
			// 
			// Deposit_Checks
			// 
			this.Deposit_Checks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Deposit_Checks.Location = new System.Drawing.Point(309, 0);
			this.Deposit_Checks.Name = "Deposit_Checks";
			this.Deposit_Checks.Size = new System.Drawing.Size(147, 37);
			this.Deposit_Checks.TabIndex = 5;
			this.Deposit_Checks.Text = "No of Checks";
			this.Deposit_Checks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.CheckActions.Size = new System.Drawing.Size(110, 48);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
			this.toolStripMenuItem1.Text = "Details";
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenuItem.Image")));
			this.deleteMenuItem.Name = "deleteMenuItem";
			this.deleteMenuItem.Size = new System.Drawing.Size(109, 22);
			this.deleteMenuItem.Text = "Delete";
			// 
			// DepositList_row
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.CheckRow);
			this.Name = "DepositList_row";
			this.Size = new System.Drawing.Size(779, 57);
			this.CheckRow.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.CheckActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel CheckRow;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Deposit_ID;
		private System.Windows.Forms.Label Deposit_Date;
		private System.Windows.Forms.Label Deposit_Amount;
		private System.Windows.Forms.Label Check_Action;
		private System.Windows.Forms.Label Deposit_Checks;
		private MaterialSkin.Controls.MaterialContextMenuStrip CheckActions;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
	}
}
