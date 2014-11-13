using System;
using System.Linq;
using InheritanceExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExerciseComplete.Tests
{
    [TestClass]
    public class AccountCreationDuplicateValidationServiceTests
    {
        private InMemoryAccountStore store;
        private AccountCreationDuplicateValidationService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            service = new AccountCreationDuplicateValidationService(store);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CannotCreateDuplicateAccounts()
        {
            var emailAddress = "duplicate@gmail.com";
            service.CreateAccount(emailAddress);
            service.CreateAccount(emailAddress);
        }
    }
}
