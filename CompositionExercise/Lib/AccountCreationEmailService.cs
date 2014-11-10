using System;
using System.Linq;

namespace CompositionExercise.Lib
{
    public class AccountCreationEmailService : IAccountCreationService
    {
        public AccountCreationEmailService(IAccountCreationService service, IEmailer emailer)
        { }

        public void CreateAccount(String emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
