namespace InheritanceExercise.Lib
{
    public class AccountCreationFormatValidationService : AccountCreationDuplicateValidationService
    {
        public AccountCreationFormatValidationService(IAccountStore store)
            : base(store)
        { }
    }
}
