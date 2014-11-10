using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExercise.Tests
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

        // Add more tests here...
    }
}
