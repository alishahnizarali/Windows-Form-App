﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCashGuard.Forms.DepositModule
{
	public partial class DepositDetail : Form
	{
		public DepositDetail()
		{
			InitializeComponent();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}