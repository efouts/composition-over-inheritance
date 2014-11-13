using System;
using CompositionExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CompositionExerciseComplete.Tests
{
    [TestClass]
    public class AccountCreationFormatValidationServiceTests 
    {
        private Mock<IAccountCreationService> mockInnerService;
        private AccountCreationFormatValidationService service;

        [TestInitialize]
        public void Setup()
        {
            mockInnerService = new Mock<IAccountCreationService>();
            service = new AccountCreationFormatValidationService(mockInnerService.Object);
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
