using System;
using System.Linq;

namespace InheritanceExercise.Lib
{
    public class AccountCreationEmailService : AccountCreationService
    {
        public AccountCreationEmailService(IAccountStore store, IEmailer emailer)
            : base(store)
        { }
    }
}
