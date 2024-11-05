using AiCashGuard.Forms.CheckModule;
using System;
using System.Windows.Forms;

namespace AiCashGuard
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new CheckDetailBulkPopup());
		}
	}
}
