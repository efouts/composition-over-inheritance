using InheritanceExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExercise.Tests
{
    [TestClass]
    public class AccountCreationServiceTests
    {
        private InMemoryAccountStore store;
        private AccountCreationService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            service = new AccountCreationService(store);
        }

        [TestMethod]
        public void CreateUser()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            Assert.IsTrue(store.Exists(emailAddress));
        }
    }
}
