using System;
using System.Linq;
using InheritanceExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExercise.Tests
{
    [TestClass]
    public class AccountCreationEmailServiceTests
    {
        private InMemoryAccountStore store;
        private FakeEmailer emailer;
        private AccountCreationEmailService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            emailer = new FakeEmailer();
            service = new AccountCreationEmailService(store, emailer);
        }

        [TestMethod]
        public void SendsWelcomeMessageOnAccountCreation()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            Assert.IsTrue(emailer.MessageWasSentTo(emailAddress));
        }

        // Add tests here...
    }
}
