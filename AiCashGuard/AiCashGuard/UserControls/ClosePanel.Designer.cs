namespace AiCashGuard.UserControls
{
	partial class ClosePanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosePanel));
			this.BtnClose = new System.Windows.Forms.Button();
			this.BtnMaximize = new System.Windows.Forms.Button();
			this.BtnMinimize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnClose
			// 
			this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClose.BackColor = System.Drawing.Color.Transparent;
			this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
			this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnClose.Location = new System.Drawing.Point(162, 0);
			this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
			this.BtnClose.MaximumSize = new System.Drawing.Size(25, 25);
			this.BtnClose.MinimumSize = new System.Drawing.Size(25, 25);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(25, 25);
			this.BtnClose.TabIndex = 0;
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnMaximize
			// 
			this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximize.BackColor = System.Drawing.Color.Transparent;
			this.BtnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.BackgroundImage")));
			this.BtnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnMaximize.Location = new System.Drawing.Point(136, 0);
			this.BtnMaximize.Margin = new System.Windows.Forms.Padding(2);
			this.BtnMaximize.MaximumSize = new System.Drawing.Size(25, 25);
			this.BtnMaximize.MinimumSize = new System.Drawing.Size(25, 25);
			this.BtnMaximize.Name = "BtnMaximize";
			this.BtnMaximize.Size = new System.Drawing.Size(25, 25);
			this.BtnMaximize.TabIndex = 1;
			this.BtnMaximize.UseVisualStyleBackColor = false;
			this.BtnMaximize.Click += new System.EventHandler(this.button2_Click);
			// 
			// BtnMinimize
			// 
			this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.BackgroundImage")));
			this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnMinimize.Location = new System.Drawing.Point(110, 0);
			this.BtnMinimize.Margin = new System.Windows.Forms.Padding(2);
			this.BtnMinimize.MaximumSize = new System.Drawing.Size(25, 25);
			this.BtnMinimize.MinimumSize = new System.Drawing.Size(25, 25);
			this.BtnMinimize.Name = "BtnMinimize";
			this.BtnMinimize.Size = new System.Drawing.Size(25, 25);
			this.BtnMinimize.TabIndex = 2;
			this.BtnMinimize.UseVisualStyleBackColor = true;
			this.BtnMinimize.Click += new System.EventHandler(this.button3_Click);
			// 
			// ClosePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.BtnMinimize);
			this.Controls.Add(this.BtnMaximize);
			this.Controls.Add(this.BtnClose);
			this.Name = "ClosePanel";
			this.Size = new System.Drawing.Size(189, 46);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.Button BtnMaximize;
		private System.Windows.Forms.Button BtnMinimize;
	}
}
