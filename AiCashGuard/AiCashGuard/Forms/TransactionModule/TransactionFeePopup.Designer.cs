namespace AiCashGuard.Forms.TransactionModule
{
	partial class TransactionFeePopup
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
			this.transactionFeePanel = new System.Windows.Forms.Panel();
			this.Btn_Ok = new System.Windows.Forms.Button();
			this.CustomText = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.gradientPanel1 = new AiCashGuard.UserControls.GradientPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.transactionFeePanel.SuspendLayout();
			this.gradientPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// transactionFeePanel
			// 
			this.transactionFeePanel.AutoScroll = true;
			this.transactionFeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.transactionFeePanel.Controls.Add(this.panel1);
			this.transactionFeePanel.Controls.Add(this.gradientPanel1);
			this.transactionFeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transactionFeePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.transactionFeePanel.Location = new System.Drawing.Point(0, 0);
			this.transactionFeePanel.Name = "transactionFeePanel";
			this.transactionFeePanel.Padding = new System.Windows.Forms.Padding(2);
			this.transactionFeePanel.Size = new System.Drawing.Size(750, 400);
			this.transactionFeePanel.TabIndex = 2;
			// 
			// Btn_Ok
			// 
			this.Btn_Ok.AutoSize = true;
			this.Btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Ok.FlatAppearance.BorderSize = 0;
			this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Btn_Ok.Location = new System.Drawing.Point(503, 251);
			this.Btn_Ok.Margin = new System.Windows.Forms.Padding(20);
			this.Btn_Ok.Name = "Btn_Ok";
			this.Btn_Ok.Size = new System.Drawing.Size(81, 35);
			this.Btn_Ok.TabIndex = 16;
			this.Btn_Ok.Text = "OK";
			this.Btn_Ok.UseVisualStyleBackColor = false;
			this.Btn_Ok.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// CustomText
			// 
			this.CustomText.Depth = 0;
			this.CustomText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CustomText.Hint = "Value";
			this.CustomText.Location = new System.Drawing.Point(261, 251);
			this.CustomText.Margin = new System.Windows.Forms.Padding(20);
			this.CustomText.MouseState = MaterialSkin.MouseState.HOVER;
			this.CustomText.Name = "CustomText";
			this.CustomText.PasswordChar = '\0';
			this.CustomText.SelectedText = "";
			this.CustomText.SelectionLength = 0;
			this.CustomText.SelectionStart = 0;
			this.CustomText.Size = new System.Drawing.Size(202, 23);
			this.CustomText.TabIndex = 15;
			this.CustomText.UseSystemPasswordChar = false;
			this.CustomText.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton10.Location = new System.Drawing.Point(3, 234);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(235, 72);
			this.radioButton10.TabIndex = 14;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Custom";
			this.radioButton10.UseVisualStyleBackColor = true;
			this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton9.Location = new System.Drawing.Point(486, 157);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(237, 71);
			this.radioButton9.TabIndex = 13;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "2.25%";
			this.radioButton9.UseVisualStyleBackColor = true;
			this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton8.Location = new System.Drawing.Point(486, 80);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(237, 71);
			this.radioButton8.TabIndex = 12;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "1.50%";
			this.radioButton8.UseVisualStyleBackColor = true;
			this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton7.Location = new System.Drawing.Point(486, 3);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(237, 71);
			this.radioButton7.TabIndex = 11;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "0.75%";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton6.Location = new System.Drawing.Point(244, 157);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(236, 71);
			this.radioButton6.TabIndex = 10;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "2.00%";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton5.Location = new System.Drawing.Point(244, 80);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(236, 71);
			this.radioButton5.TabIndex = 9;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "1.25%";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton4.Location = new System.Drawing.Point(244, 3);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(236, 71);
			this.radioButton4.TabIndex = 8;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "0.5%";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton3.Location = new System.Drawing.Point(3, 157);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(235, 71);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "1.75%";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton2.Location = new System.Drawing.Point(3, 80);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(235, 71);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "1.00%";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radioButton1.Location = new System.Drawing.Point(3, 3);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(235, 71);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "0.25%";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.Controls.Add(this.Btn_Cancel);
			this.gradientPanel1.Controls.Add(this.label1);
			this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientPanel1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Location = new System.Drawing.Point(2, 2);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Size = new System.Drawing.Size(746, 67);
			this.gradientPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(255, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Transaction Fees";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 69);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(746, 329);
			this.panel1.TabIndex = 17;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.radioButton7, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Btn_Ok, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CustomText, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButton8, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButton10, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButton9, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButton2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButton4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.radioButton5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButton3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButton6, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 309);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Cancel.AutoSize = true;
			this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderSize = 0;
			this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Btn_Cancel.Location = new System.Drawing.Point(644, 16);
			this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(80, 33);
			this.Btn_Cancel.TabIndex = 17;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = false;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click_1);
			// 
			// TransactionFeePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 400);
			this.Controls.Add(this.transactionFeePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TransactionFeePopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TransactionFeePopup";
			this.transactionFeePanel.ResumeLayout(false);
			this.gradientPanel1.ResumeLayout(false);
			this.gradientPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel transactionFeePanel;
		private UserControls.GradientPanel gradientPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton10;
		private MaterialSkin.Controls.MaterialSingleLineTextField CustomText;
		private System.Windows.Forms.Button Btn_Ok;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Btn_Cancel;
	}
}