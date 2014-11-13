using System;
using InheritanceExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExerciseComplete.Tests
{
    [TestClass]
    public class AccountCreationFormatValidationServiceTests 
    {
        private InMemoryAccountStore store;
        private AccountCreationFormatValidationService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            service = new AccountCreationFormatValidationService(store);
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void CannotCreateAccountsWithIncorrectlyFormattedEmailAddresses()
        {
            var emailAddress = "EmailAddress";
            service.CreateAccount(emailAddress);
        }

        [TestMethod]
        public void CorrectEmailFormat()
        {
            var emailAddress = "EmailAddress@google.com";
            service.CreateAccount(emailAddress);
        }
    }
}
