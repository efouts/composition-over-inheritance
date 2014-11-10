using System;
using System.Linq;

namespace CompositionExercise.Lib
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
