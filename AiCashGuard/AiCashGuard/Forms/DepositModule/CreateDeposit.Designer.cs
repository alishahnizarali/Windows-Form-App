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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.phoneSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.idSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.depositDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.gradientPanel1 = new AiCashGuard.UserControls.GradientPanel();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.gradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.gradientPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1065, 800);
			this.panel1.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.tableLayoutPanel2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 67);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(5);
			this.panel7.Size = new System.Drawing.Size(1065, 51);
			this.panel7.TabIndex = 39;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 41);
			this.tableLayoutPanel2.TabIndex = 36;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.phoneSearch);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(705, 3);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(347, 35);
			this.panel5.TabIndex = 31;
			// 
			// phoneSearch
			// 
			this.phoneSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.phoneSearch.Location = new System.Drawing.Point(102, 5);
			this.phoneSearch.Multiline = true;
			this.phoneSearch.Name = "phoneSearch";
			this.phoneSearch.Size = new System.Drawing.Size(240, 25);
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
			this.label3.Text = "Total Amount";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.depositDateTimePicker);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(354, 3);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(345, 35);
			this.panel4.TabIndex = 30;
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
			// panel3
			// 
			this.panel3.Controls.Add(this.idSearch);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(345, 35);
			this.panel3.TabIndex = 29;
			// 
			// idSearch
			// 
			this.idSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idSearch.Location = new System.Drawing.Point(178, 5);
			this.idSearch.Multiline = true;
			this.idSearch.Name = "idSearch";
			this.idSearch.Size = new System.Drawing.Size(162, 25);
			this.idSearch.TabIndex = 24;
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
			// depositDateTimePicker
			// 
			this.depositDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.depositDateTimePicker.Location = new System.Drawing.Point(102, 10);
			this.depositDateTimePicker.Name = "depositDateTimePicker";
			this.depositDateTimePicker.Size = new System.Drawing.Size(238, 20);
			this.depositDateTimePicker.TabIndex = 40;
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.Controls.Add(this.Btn_Cancel);
			this.gradientPanel1.Controls.Add(this.Btn_Save);
			this.gradientPanel1.Controls.Add(this.label1);
			this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientPanel1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Size = new System.Drawing.Size(1065, 67);
			this.gradientPanel1.TabIndex = 1;
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.AutoSize = true;
			this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderSize = 0;
			this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Btn_Cancel.Location = new System.Drawing.Point(813, 16);
			this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(94, 35);
			this.Btn_Cancel.TabIndex = 2;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = false;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// Btn_Save
			// 
			this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
			this.Btn_Save.FlatAppearance.BorderSize = 0;
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Save.ForeColor = System.Drawing.Color.White;
			this.Btn_Save.Location = new System.Drawing.Point(917, 16);
			this.Btn_Save.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(138, 35);
			this.Btn_Save.TabIndex = 1;
			this.Btn_Save.Text = "Create Deposit";
			this.Btn_Save.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(165, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create Deposit";
			// 
			// CreateDeposit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 800);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateDeposit";
			this.Text = "CreateDeposit";
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.gradientPanel1.ResumeLayout(false);
			this.gradientPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private UserControls.GradientPanel gradientPanel1;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox phoneSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox idSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker depositDateTimePicker;
	}
}