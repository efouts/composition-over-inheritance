using System;
using System.Text.RegularExpressions;

namespace InheritanceExerciseComplete.Lib
{
    public class AccountCreationFormatValidationService : AccountCreationDuplicateValidationService
    {
        private Regex emailRegex;

        public AccountCreationFormatValidationService(IAccountStore store)
            : base(store)
        {
            emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }

        public override void CreateAccount(String emailAddress)
        {
            if (emailRegex.IsMatch(emailAddress) == false)
                throw new FormatException();

            base.CreateAccount(emailAddress);
        }
    }
}
