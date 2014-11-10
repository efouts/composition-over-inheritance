using System;
using System.Linq;

namespace CompositionExerciseComplete.Lib
{
    public class AccountCreationDuplicateValidationService : IAccountCreationService
    {
        private IAccountCreationService innerService;
        private IAccountStore store;

        public AccountCreationDuplicateValidationService(
            IAccountCreationService innerService, IAccountStore store)
        {
            this.innerService = innerService;
            this.store = store;
        }

        public void CreateAccount(String emailAddress)
        {
            if (store.Exists(emailAddress))
                throw new ArgumentException("Cannot create duplicate accounts", "emailAddress");

            innerService.CreateAccount(emailAddress);
        }
    }
}
