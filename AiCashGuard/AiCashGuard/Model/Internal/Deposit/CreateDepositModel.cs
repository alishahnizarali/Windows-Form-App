

namespace AiCashGuard.Model.Internal.Deposit
{
	public class CreateDepositModel
	{
        public int TransactionId { get; set; }
		public string CheckName { get; set; }
		public string CheckDate { get; set; }
		public string CheckNumber { get; set; }
		public string CheckAmount { get; set; }
		public int Status { get; set; }
		public bool IsSelected { get; set; } = false;

	}
}
