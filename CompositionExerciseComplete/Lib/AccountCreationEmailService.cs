using System;
using System.Linq;

namespace CompositionExerciseComplete.Lib
{
    public class AccountCreationEmailService : IAccountCreationService
    {
        private IAccountCreationService innerService;
        private IEmailer emailer;

        public AccountCreationEmailService(IAccountCreationService innerService, IEmailer emailer)
        {
            this.innerService = innerService;
            this.emailer = emailer;
        }

        public void CreateAccount(String emailAddress)
        {
            innerService.CreateAccount(emailAddress);
            emailer.Send(emailAddress);
        }
    }
}
