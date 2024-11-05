namespace AiCashGuard.Forms.AuthModule
{
	partial class CreateUserPopup
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
			this.createUserPanel = new System.Windows.Forms.Panel();
			this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.LblPassword = new System.Windows.Forms.Label();
			this.LblUserName = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.gradientPanel1 = new AiCashGuard.UserControls.GradientPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.createUserPanel.SuspendLayout();
			this.gradientPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// createUserPanel
			// 
			this.createUserPanel.AutoScroll = true;
			this.createUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.createUserPanel.Controls.Add(this.panel1);
			this.createUserPanel.Controls.Add(this.gradientPanel1);
			this.createUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.createUserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createUserPanel.Location = new System.Drawing.Point(0, 0);
			this.createUserPanel.Name = "createUserPanel";
			this.createUserPanel.Padding = new System.Windows.Forms.Padding(2);
			this.createUserPanel.Size = new System.Drawing.Size(700, 400);
			this.createUserPanel.TabIndex = 1;
			this.createUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addNewCheckPanel_Paint);
			// 
			// materialSingleLineTextField2
			// 
			this.materialSingleLineTextField2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialSingleLineTextField2.Depth = 0;
			this.materialSingleLineTextField2.Hint = "Enter Password";
			this.materialSingleLineTextField2.Location = new System.Drawing.Point(248, 150);
			this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.PasswordChar = '\0';
			this.materialSingleLineTextField2.SelectedText = "";
			this.materialSingleLineTextField2.SelectionLength = 0;
			this.materialSingleLineTextField2.SelectionStart = 0;
			this.materialSingleLineTextField2.Size = new System.Drawing.Size(380, 23);
			this.materialSingleLineTextField2.TabIndex = 8;
			this.materialSingleLineTextField2.UseSystemPasswordChar = false;
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Hint = "Enter Username";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(248, 89);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(380, 23);
			this.materialSingleLineTextField1.TabIndex = 7;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// LblPassword
			// 
			this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblPassword.AutoSize = true;
			this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(97)))));
			this.LblPassword.Location = new System.Drawing.Point(120, 149);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(102, 24);
			this.LblPassword.TabIndex = 6;
			this.LblPassword.Text = "Password :";
			// 
			// LblUserName
			// 
			this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblUserName.AutoSize = true;
			this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(97)))));
			this.LblUserName.Location = new System.Drawing.Point(120, 88);
			this.LblUserName.Name = "LblUserName";
			this.LblUserName.Size = new System.Drawing.Size(107, 24);
			this.LblUserName.TabIndex = 5;
			this.LblUserName.Text = "Username :";
			// 
			// Btn_Save
			// 
			this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
			this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(217)))), ((int)(((byte)(226)))));
			this.Btn_Save.FlatAppearance.BorderSize = 0;
			this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Save.ForeColor = System.Drawing.Color.White;
			this.Btn_Save.Location = new System.Drawing.Point(582, 274);
			this.Btn_Save.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(94, 35);
			this.Btn_Save.TabIndex = 3;
			this.Btn_Save.Text = "Create";
			this.Btn_Save.UseVisualStyleBackColor = false;
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_Cancel.AutoSize = true;
			this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.Btn_Cancel.FlatAppearance.BorderSize = 0;
			this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.Btn_Cancel.Location = new System.Drawing.Point(479, 274);
			this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(94, 35);
			this.Btn_Cancel.TabIndex = 4;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = false;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.Controls.Add(this.label1);
			this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientPanel1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Location = new System.Drawing.Point(2, 2);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(86)))), ((int)(((byte)(198)))));
			this.gradientPanel1.Size = new System.Drawing.Size(696, 67);
			this.gradientPanel1.TabIndex = 1;
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
			this.label1.Size = new System.Drawing.Size(137, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create User";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LblUserName);
			this.panel1.Controls.Add(this.Btn_Cancel);
			this.panel1.Controls.Add(this.Btn_Save);
			this.panel1.Controls.Add(this.materialSingleLineTextField2);
			this.panel1.Controls.Add(this.materialSingleLineTextField1);
			this.panel1.Controls.Add(this.LblPassword);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 69);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20);
			this.panel1.Size = new System.Drawing.Size(696, 329);
			this.panel1.TabIndex = 9;
			// 
			// CreateUserPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 400);
			this.Controls.Add(this.createUserPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateUserPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CreateUserPopup";
			this.createUserPanel.ResumeLayout(false);
			this.gradientPanel1.ResumeLayout(false);
			this.gradientPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel createUserPanel;
		private UserControls.GradientPanel gradientPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.Label LblUserName;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private System.Windows.Forms.Panel panel1;
	}
}