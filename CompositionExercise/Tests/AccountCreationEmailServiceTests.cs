using System;
using System.Linq;
using CompositionExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CompositionExercise.Tests
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

        [TestMethod, Ignore]
        public void ForwardsToInnerService()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            mockInnerService.Verify(v => v.CreateAccount(emailAddress));
        }

        [TestMethod, Ignore]
        public void SendsWelcomeMessageOnAccountCreation()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            Assert.IsTrue(emailer.MessageWasSentTo(emailAddress));
        }

        // Add tests here...
    }
}
