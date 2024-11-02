using AiCashGuard.Model.Internal;
using AiCashGuard.Logic.Data;
using AiCashGuard.Model.Internal.Checks;
using AiCashGuard.Logic.Extensions;
using System.Collections.Generic;
using AiCashGuard.Model.Internal.Customer;

namespace AiCashGuard.Processor
{
    public class CheckAccountProcessor
    {
        //create a method to get all checks with with filters
        public List<CheckAcctList> GetChecksAccount(string accountNumber, string routingNumber, string name)
        {
            return new CheckAccountData().GetChecksAccount(accountNumber, routingNumber, name);
        }

        //create a method to get a check by id
        public CheckDetailModel GetCheckAccountById(int checkAccountId)
        {
            var check = new CheckAccountData().GetCheckAccountById(checkAccountId);

            if (!string.IsNullOrWhiteSpace(check.checkImageFrontPath))
                check.checkImageFront = new ImageHelper().GetImage(check.checkImageFrontPath);

            return check;
        }

        public List<SearchCheckAcctListModel> GetCheckByAcctName(string name)
        {
            return new CheckAccountData().GetCheckByAcctName(name);
        }

        //create a method to get a check by accountNumber and routingNumber
        public int GetCheckAccountByAccountNumber(string accountNumber, string routingNumber, int checkId = 0)
        {
            return new CheckAccountData().GetCheckAccountByAccountNumber(accountNumber, routingNumber, checkId );
        }

        //create a method to create a check
        public int InsertCheckAccount(AddCheckAcct request)
        {
            int checkId = new CheckAccountData().InsertCheckAccount(request);

            if (request.checkImageFront != null)
            {
                string checkImagePath = new ImageHelper().SaveImage(request.checkImageFront, checkId, "CHECKIMAGE");
                new CheckAccountData().UpdateCheckImagePath(checkId, checkImagePath);
            }

            return checkId;
        }

        //create a method to update a check
        public void UpdateCheckAccount(EditCheckAcct request)
        {
            new CheckAccountData().UpdateCheckAccount(request);

            if (request.checkImageFront != null)
                request.checkImageFrontPath = new ImageHelper().SaveImage(request.checkImageFront, request.checkId, "CHECKIMAGE");
            else
                request.checkImageFrontPath = "";

            new CheckAccountData().UpdateCheckImagePath(request.checkId, request.checkImageFrontPath);

        }

        //create a method to delete a check
        public void DeleteCheckAccount()
        {
        }

        //create a method to get a check history by id with filters
        public List<CustomerModel> GetCheckAccountHistory(int checkAccountId)
        {
            return new CheckAccountData().GetCheckAccountHistory(checkAccountId);
        }

        public void UpdateCheckAccountStatus(int id, bool isBlock)
        {
            new CheckAccountData().UpdateCheckAccountStatus(id, isBlock);
        }
    }
}
