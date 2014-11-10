using System;
using System.Linq;

namespace InheritanceExercise.Lib
{
    public class AccountCreationDuplicateValidationService : AccountCreationService
    {
        public AccountCreationDuplicateValidationService(IAccountStore userStore)
            : base(userStore)
        { }
    }
}
