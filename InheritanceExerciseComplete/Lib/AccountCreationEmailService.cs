using System;
using System.Linq;

namespace InheritanceExerciseComplete.Lib
{
    public class AccountCreationEmailService : AccountCreationFormatValidationService
    {
        private IEmailer emailer;

        public AccountCreationEmailService(IAccountStore store, IEmailer emailer)
            : base(store)
        {
            this.emailer = emailer;
        }

        public override void CreateAccount(String emailAddress)
        {
            base.CreateAccount(emailAddress);

            emailer.Send(emailAddress);
        }
    }
}
