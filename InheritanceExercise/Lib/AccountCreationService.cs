using System;
using System.Linq;

namespace InheritanceExercise.Lib
{
    public class AccountCreationService
    {
        private IAccountStore store;

        public AccountCreationService(IAccountStore store)
        {
            this.store = store;
        }

        public virtual void CreateAccount(String emailAddress)
        {
            store.Add(emailAddress);
        }
    }
}
