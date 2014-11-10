using CompositionExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompositionExerciseComplete.Tests
{
    [TestClass]
    public class AccountCreationServiceFactoryTests
    {
        private IAccountStore store;
        private IAccountCreationService service;

        [TestInitialize]
        public void Setup()
        {
            // Create the account creation object using all the composed objects
        }

        [TestMethod]
        public void IntegrationTestExample()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            Assert.IsTrue(store.Exists(emailAddress));
        }
    }
}
