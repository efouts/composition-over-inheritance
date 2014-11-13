using CompositionExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompositionExerciseComplete.Tests
{
    [TestClass]
    public class FullStackTests
    {
        private IAccountStore store;
        private IAccountCreationService service;

        [TestInitialize]
        public void Setup()
        {
            // Create the account creation object using all the composed objects
        }

        [TestMethod, Ignore]
        public void IntegrationTestExample()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            Assert.IsTrue(store.Exists(emailAddress));
        }
    }
}
