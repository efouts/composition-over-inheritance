using System;
using System.Linq;

namespace CompositionExerciseComplete.Lib
{
    public class AccountCreationService : IAccountCreationService
    {
        private IAccountStore store;

        public AccountCreationService(IAccountStore store)
        {
            this.store = store;
        }

        public void CreateAccount(String emailAddress)
        {
            store.Add(emailAddress);
        }
    }
}
