using System;
using System.Linq;
using CompositionExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CompositionExerciseComplete.Tests
{
    [TestClass]
    public class AccountCreationEmailServiceTests
    {
        private Mock<IAccountCreationService> mockInnerService;
        private FakeEmailer emailer;
        private AccountCreationEmailService service;

        [TestInitialize]
        public void Setup()
        {
            mockInnerService = new Mock<IAccountCreationService>();
            emailer = new FakeEmailer();
            service = new AccountCreationEmailService(mockInnerService.Object, emailer);
        }

        [TestMethod]
        public void ForwardsToInnerService()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            mockInnerService.Verify(v => v.CreateAccount(emailAddress));
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
