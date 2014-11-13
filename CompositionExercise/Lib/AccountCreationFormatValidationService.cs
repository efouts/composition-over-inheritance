using System;

namespace CompositionExercise.Lib
{
    public class AccountCreationFormatValidationService : IAccountCreationService
    {
        public AccountCreationFormatValidationService(IAccountCreationService innerService)
        { }

        public void CreateAccount(String emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
