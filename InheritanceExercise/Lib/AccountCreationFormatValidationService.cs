using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise.Lib
{
    public class AccountCreationFormatValidationService : AccountCreationService
    {
        public AccountCreationFormatValidationService(IAccountStore store)
            : base(store)
        { }
    }
}
