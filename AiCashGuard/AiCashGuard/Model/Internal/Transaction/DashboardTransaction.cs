using System.Collections.Generic;

namespace AiCashGuard.Model.Internal.Transaction
{
    public class DashboardTransaction
    {
        public List<RecentTransactions> recentTransactions { get; set; }
        public List<RecentTransactions> returnTransactions { get; set; }
    }
}
