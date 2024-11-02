namespace AiCashGuard.UserControls
{
	partial class PaginationControl
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
			this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnPrevious = new MaterialSkin.Controls.MaterialFlatButton();
			this.lblPageNumber = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.AutoSize = true;
			this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnNext.Depth = 0;
			this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnNext.Location = new System.Drawing.Point(271, 5);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnNext.Name = "btnNext";
			this.btnNext.Primary = false;
			this.btnNext.Size = new System.Drawing.Size(46, 32);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
			// 
			// btnPrevious
			// 
			this.btnPrevious.AutoSize = true;
			this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnPrevious.Depth = 0;
			this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnPrevious.Location = new System.Drawing.Point(7, 5);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Primary = false;
			this.btnPrevious.Size = new System.Drawing.Size(77, 32);
			this.btnPrevious.TabIndex = 1;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
			// 
			// lblPageNumber
			// 
			this.lblPageNumber.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblPageNumber.Location = new System.Drawing.Point(84, 5);
			this.lblPageNumber.Name = "lblPageNumber";
			this.lblPageNumber.Padding = new System.Windows.Forms.Padding(5);
			this.lblPageNumber.Size = new System.Drawing.Size(187, 32);
			this.lblPageNumber.TabIndex = 2;
			this.lblPageNumber.Text = "Page Number";
			this.lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPageNumber.Click += new System.EventHandler(this.lblPageNumber_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnPrevious);
			this.panel1.Controls.Add(this.lblPageNumber);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(5);
			this.panel1.Size = new System.Drawing.Size(322, 42);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// PaginationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "PaginationControl";
			this.Size = new System.Drawing.Size(322, 42);
			this.Load += new System.EventHandler(this.PaginationControl_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialFlatButton btnNext;
		private MaterialSkin.Controls.MaterialFlatButton btnPrevious;
		private System.Windows.Forms.Label lblPageNumber;
		private System.Windows.Forms.Panel panel1;
	}
}
