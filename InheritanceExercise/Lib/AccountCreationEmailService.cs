using System;
using System.Linq;

namespace InheritanceExercise.Lib
{
    public class AccountCreationEmailService : AccountCreationFormatValidationService
    {
        public AccountCreationEmailService(IAccountStore store, IEmailer emailer)
            : base(store)
        { }
    }
}
