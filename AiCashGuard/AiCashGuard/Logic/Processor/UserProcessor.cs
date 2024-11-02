using AiCashGuard.Logic.Data;

namespace AiCashGuard.Logic.Processor
{
    public class UserProcessor
    {
        //create a method to authenticate user password
        public string AuthenticateUser(string userName, string password)
        {
            return new UserData().AuthenticateUser(userName, password);
        }
    }
}
