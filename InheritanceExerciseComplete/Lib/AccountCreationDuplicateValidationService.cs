using System;
using System.Linq;

namespace InheritanceExerciseComplete.Lib
{
    public class AccountCreationDuplicateValidationService : AccountCreationService
    {
        private IAccountStore userStore;

        public AccountCreationDuplicateValidationService(IAccountStore userStore)
            : base(userStore)
        {
            this.userStore = userStore;
        }

        public override void CreateAccount(String emailAddress)
        {
            if (userStore.Exists(emailAddress))
                throw new ArgumentException("Cannot create duplicate accounts", "emailAddress");

            base.CreateAccount(emailAddress);
        }
    }
}
