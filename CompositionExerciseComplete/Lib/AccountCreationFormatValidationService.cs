using System;
using System.Text.RegularExpressions;

namespace CompositionExerciseComplete.Lib
{
    public class AccountCreationFormatValidationService : IAccountCreationService
    {
        private IAccountCreationService innerService;
        private Regex emailRegex;

        public AccountCreationFormatValidationService(IAccountCreationService innerService)
        {
            this.innerService = innerService;
            emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }

        public void CreateAccount(String emailAddress)
        {
            if (emailRegex.IsMatch(emailAddress) == false)
                throw new FormatException();

            innerService.CreateAccount(emailAddress);
        }
    }
}
