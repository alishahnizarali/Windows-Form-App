using AiCashGuard.Logic.Data;
using AiCashGuard.Model.Internal.Report;

namespace AiCashGuard.Logic.Processor
{
    public class ReportProcessor
    {
        public TransactionNumberModel GetTransactionReport(string startDate, string endDate)
        {
            ReportData reportData = new ReportData();
            var response = reportData.GetTransactionReport(startDate, endDate);

            reportData.GetTransactionReportByStatus(ref response, startDate, endDate);

            return response;
        }

        public string GetMonthlyDepositVolumeReport()
        {
            return "Monthly Deposit Volume Report";
        }

        public string GetMonthlyTransactionVolumeReport()
        {
            return "Monthly Transaction Volume Report";
        }
    }
}
