using AiCashGuard.UserControls;

namespace AiCashGuard.Forms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.roundedPanel2 = new RoundedPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.closePanel1 = new AiCashGuard.UserControls.ClosePanel();
			this.roundedPanel1 = new RoundedPanel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.Btn_Register_Here = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.roundedPanel3 = new RoundedPanel();
			this.Btn_Login = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.Text_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.Text_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.roundedPanel2.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.roundedPanel3.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.roundedPanel2);
			this.panel1.Controls.Add(this.closePanel1);
			this.panel1.Controls.Add(this.roundedPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(40);
			this.panel1.Size = new System.Drawing.Size(1061, 796);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
			this.roundedPanel2.Controls.Add(this.label5);
			this.roundedPanel2.Controls.Add(this.label4);
			this.roundedPanel2.CornerRadius = 20;
			this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.roundedPanel2.Location = new System.Drawing.Point(40, 577);
			this.roundedPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Padding = new System.Windows.Forms.Padding(10);
			this.roundedPanel2.Size = new System.Drawing.Size(669, 179);
			this.roundedPanel2.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(10, 51);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(5);
			this.label5.Size = new System.Drawing.Size(649, 118);
			this.label5.Text = "BlixWave\'s Instant Verification ensures maximum security by using realtime fraud " +
    "detection. This feature quickly cross-references checks against extensive databa" +
    "ses";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(10, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(649, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Blix Wave Latest News";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// closePanel1
			// 
			this.closePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePanel1.BackColor = System.Drawing.Color.Transparent;
			this.closePanel1.Location = new System.Drawing.Point(951, 3);
			this.closePanel1.Name = "closePanel1";
			this.closePanel1.Size = new System.Drawing.Size(111, 30);
			this.closePanel1.TabIndex = 26;
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.roundedPanel1.Controls.Add(this.panel6);
			this.roundedPanel1.Controls.Add(this.panel4);
			this.roundedPanel1.Controls.Add(this.panel3);
			this.roundedPanel1.Controls.Add(this.panel5);
			this.roundedPanel1.Controls.Add(this.label15);
			this.roundedPanel1.Controls.Add(this.label16);
			this.roundedPanel1.Controls.Add(this.panel2);
			this.roundedPanel1.CornerRadius = 20;
			this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.roundedPanel1.Location = new System.Drawing.Point(709, 40);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.roundedPanel1.Size = new System.Drawing.Size(312, 716);
			this.roundedPanel1.TabIndex = 6;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label8);
			this.panel6.Controls.Add(this.Btn_Register_Here);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(10, 483);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(5);
			this.panel6.Size = new System.Drawing.Size(292, 33);
			this.panel6.TabIndex = 33;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Dock = System.Windows.Forms.DockStyle.Left;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(5, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(148, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "Not a member?";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Btn_Register_Here
			// 
			this.Btn_Register_Here.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Register_Here.Dock = System.Windows.Forms.DockStyle.Right;
			this.Btn_Register_Here.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Register_Here.Location = new System.Drawing.Point(149, 5);
			this.Btn_Register_Here.Name = "Btn_Register_Here";
			this.Btn_Register_Here.Size = new System.Drawing.Size(138, 23);
			this.Btn_Register_Here.TabIndex = 32;
			this.Btn_Register_Here.Text = "Register Here";
			this.Btn_Register_Here.Click += new System.EventHandler(this.Btn_Register_Here_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.roundedPanel3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(10, 414);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(20);
			this.panel4.Size = new System.Drawing.Size(292, 69);
			this.panel4.TabIndex = 22;
			// 
			// roundedPanel3
			// 
			this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
			this.roundedPanel3.Controls.Add(this.Btn_Login);
			this.roundedPanel3.CornerRadius = 20;
			this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.roundedPanel3.Location = new System.Drawing.Point(20, 20);
			this.roundedPanel3.Name = "roundedPanel3";
			this.roundedPanel3.Padding = new System.Windows.Forms.Padding(5);
			this.roundedPanel3.Size = new System.Drawing.Size(252, 33);
			this.roundedPanel3.TabIndex = 34;
			// 
			// Btn_Login
			// 
			this.Btn_Login.BackColor = System.Drawing.Color.Transparent;
			this.Btn_Login.Dock = System.Windows.Forms.DockStyle.Top;
			this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Login.ForeColor = System.Drawing.Color.White;
			this.Btn_Login.Location = new System.Drawing.Point(5, 5);
			this.Btn_Login.Name = "Btn_Login";
			this.Btn_Login.Size = new System.Drawing.Size(242, 23);
			this.Btn_Login.TabIndex = 0;
			this.Btn_Login.Text = "Done";
			this.Btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.Text_Password);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(10, 279);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(20);
			this.panel3.Size = new System.Drawing.Size(292, 135);
			this.panel3.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Location = new System.Drawing.Point(20, 20);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(252, 54);
			this.label13.TabIndex = 20;
			this.label13.Text = "Password:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Text_Password
			// 
			this.Text_Password.Depth = 0;
			this.Text_Password.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Text_Password.Hint = "Enter Password";
			this.Text_Password.Location = new System.Drawing.Point(20, 92);
			this.Text_Password.MouseState = MaterialSkin.MouseState.HOVER;
			this.Text_Password.Name = "Text_Password";
			this.Text_Password.Padding = new System.Windows.Forms.Padding(5);
			this.Text_Password.PasswordChar = '*';
			this.Text_Password.SelectedText = "";
			this.Text_Password.SelectionLength = 0;
			this.Text_Password.SelectionStart = 0;
			this.Text_Password.Size = new System.Drawing.Size(252, 23);
			this.Text_Password.TabIndex = 2;
			this.Text_Password.UseSystemPasswordChar = true;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.Text_Username);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 151);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(20);
			this.panel5.Size = new System.Drawing.Size(292, 128);
			this.panel5.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(20, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(252, 52);
			this.label3.TabIndex = 20;
			this.label3.Text = "Username:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Text_Username
			// 
			this.Text_Username.Depth = 0;
			this.Text_Username.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Text_Username.Hint = "Enter Username";
			this.Text_Username.Location = new System.Drawing.Point(20, 85);
			this.Text_Username.MouseState = MaterialSkin.MouseState.HOVER;
			this.Text_Username.Name = "Text_Username";
			this.Text_Username.Padding = new System.Windows.Forms.Padding(5);
			this.Text_Username.PasswordChar = '\0';
			this.Text_Username.SelectedText = "";
			this.Text_Username.SelectionLength = 0;
			this.Text_Username.SelectionStart = 0;
			this.Text_Username.Size = new System.Drawing.Size(252, 23);
			this.Text_Username.TabIndex = 1;
			this.Text_Username.UseSystemPasswordChar = false;
			// 
			// label15
			// 
			this.label15.Dock = System.Windows.Forms.DockStyle.Top;
			this.label15.Location = new System.Drawing.Point(10, 133);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(292, 18);
			this.label15.TabIndex = 17;
			this.label15.Text = "Admin can login through QR also";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label16
			// 
			this.label16.Dock = System.Windows.Forms.DockStyle.Top;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(10, 86);
			this.label16.Name = "label16";
			this.label16.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
			this.label16.Size = new System.Drawing.Size(292, 47);
			this.label16.TabIndex = 16;
			this.label16.Text = "Login Your Account";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(292, 76);
			this.panel2.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 59);
			this.label1.TabIndex = 25;
			this.label1.Text = "WAVE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Dock = System.Windows.Forms.DockStyle.Left;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(140, 59);
			this.label11.TabIndex = 23;
			this.label11.Text = "BliX";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(0, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(292, 17);
			this.label2.TabIndex = 24;
			this.label2.Text = "AI Cash Guard";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 800);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
			this.Name = "Login";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.roundedPanel2.ResumeLayout(false);
			this.roundedPanel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.roundedPanel3.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private RoundedPanel roundedPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label Btn_Login;
		private System.Windows.Forms.Label label13;
		private MaterialSkin.Controls.MaterialSingleLineTextField Text_Password;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private UserControls.ClosePanel closePanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label3;
		private MaterialSkin.Controls.MaterialSingleLineTextField Text_Username;
		private RoundedPanel roundedPanel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Btn_Register_Here;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel6;
		private RoundedPanel roundedPanel3;
	}
}