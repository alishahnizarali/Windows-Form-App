namespace AiCashGuard.UserControls
{
	partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.roundedPanel1 = new AiCashGuard.UserControls.RoundedPanel();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.popupIcon = new System.Windows.Forms.PictureBox();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.textMessage = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new AiCashGuard.UserControls.RoundedPanel();
            this.Btn_Text = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Cancel_Panel = new AiCashGuard.UserControls.RoundedPanel();
            this.Btn_Cancel = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupIcon)).BeginInit();
            this.messagePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Cancel_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.iconPanel);
            this.roundedPanel1.Controls.Add(this.messagePanel);
            this.roundedPanel1.Controls.Add(this.headerPanel);
            this.roundedPanel1.Controls.Add(this.buttonPanel);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(801, 382);
            this.roundedPanel1.TabIndex = 0;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.popupIcon);
            this.iconPanel.Location = new System.Drawing.Point(0, 3);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(801, 145);
            this.iconPanel.TabIndex = 39;
            // 
            // popupIcon
            // 
            this.popupIcon.Image = ((System.Drawing.Image)(resources.GetObject("popupIcon.Image")));
            this.popupIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("popupIcon.InitialImage")));
            this.popupIcon.Location = new System.Drawing.Point(295, 0);
            this.popupIcon.Name = "popupIcon";
            this.popupIcon.Size = new System.Drawing.Size(232, 145);
            this.popupIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popupIcon.TabIndex = 0;
            this.popupIcon.TabStop = false;
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.textMessage);
            this.messagePanel.Location = new System.Drawing.Point(0, 201);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(801, 96);
            this.messagePanel.TabIndex = 38;
            // 
            // textMessage
            // 
            this.textMessage.AutoSize = false;
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(0, 0);
            this.textMessage.MaximumSize = new System.Drawing.Size(800, 0);
            this.textMessage.Name = "textMessage";
            this.textMessage.TabIndex = 0;
            this.textMessage.Text = "label1";
            this.textMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.title);
            this.headerPanel.Location = new System.Drawing.Point(3, 151);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(801, 47);
            this.headerPanel.TabIndex = 37;
            // 
            // title
            // 
            this.title.AutoSize = false;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.panel1);
            this.buttonPanel.Controls.Add(this.panel4);
            this.buttonPanel.Location = new System.Drawing.Point(0, 290);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(801, 87);
            this.buttonPanel.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(525, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(276, 87);
            this.panel1.TabIndex = 35;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
            this.roundedPanel2.Controls.Add(this.Btn_Text);
            this.roundedPanel2.CornerRadius = 20;
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedPanel2.Location = new System.Drawing.Point(15, 15);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.roundedPanel2.Size = new System.Drawing.Size(246, 51);
            this.roundedPanel2.TabIndex = 34;
            // 
            // Btn_Text
            // 
            this.Btn_Text.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Text.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Text.ForeColor = System.Drawing.Color.White;
            this.Btn_Text.Location = new System.Drawing.Point(8, 8);
            this.Btn_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Btn_Text.Name = "Btn_Text";
            this.Btn_Text.Size = new System.Drawing.Size(230, 35);
            this.Btn_Text.TabIndex = 0;
            this.Btn_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Text.Click += new System.EventHandler(this.Btn_Text_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Cancel_Panel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(297, 87);
            this.panel4.TabIndex = 23;
            // 
            // Cancel_Panel
            // 
            this.Cancel_Panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancel_Panel.Controls.Add(this.Btn_Cancel);
            this.Cancel_Panel.CornerRadius = 20;
            this.Cancel_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cancel_Panel.Location = new System.Drawing.Point(15, 15);
            this.Cancel_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Panel.Name = "Cancel_Panel";
            this.Cancel_Panel.Padding = new System.Windows.Forms.Padding(8);
            this.Cancel_Panel.Size = new System.Drawing.Size(267, 51);
            this.Cancel_Panel.TabIndex = 34;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(8, 8);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(251, 35);
            this.Btn_Cancel.TabIndex = 0;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 382);
            this.Controls.Add(this.roundedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(900, 692);
            this.MinimumSize = new System.Drawing.Size(450, 231);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.roundedPanel1.ResumeLayout(false);
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupIcon)).EndInit();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Cancel_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RoundedPanel roundedPanel1;
		private System.Windows.Forms.Panel panel1;
		private RoundedPanel roundedPanel2;
		private System.Windows.Forms.Label Btn_Text;
		private System.Windows.Forms.Panel panel4;
		private RoundedPanel Cancel_Panel;
		private System.Windows.Forms.Label Btn_Cancel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox popupIcon;
        private System.Windows.Forms.Label textMessage;
        private System.Windows.Forms.Label title;
    }
}