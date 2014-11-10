using System;
using System.Linq;

namespace CompositionExercise.Lib
{
    public class AccountCreationDuplicateValidationService : IAccountCreationService
    {
        public AccountCreationDuplicateValidationService(
            IAccountCreationService service, IAccountStore store)
        { }

        public void CreateAccount(String emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
