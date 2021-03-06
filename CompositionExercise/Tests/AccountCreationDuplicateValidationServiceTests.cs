﻿using System;
using System.Linq;
using CompositionExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CompositionExercise.Tests
{
    [TestClass]
    public class AccountCreationDuplicateValidationServiceTests
    {
        private InMemoryAccountStore store;
        private Mock<IAccountCreationService> mockInnerService;
        private AccountCreationDuplicateValidationService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            mockInnerService = new Mock<IAccountCreationService>();
            service = new AccountCreationDuplicateValidationService(mockInnerService.Object, store);
        }

        [TestMethod, Ignore]
        public void ForwardsToInnerService()
        {
            var emailAddress = "someAddress@gmail.com";
            service.CreateAccount(emailAddress);
            mockInnerService.Verify(v => v.CreateAccount(emailAddress));
        }

        [TestMethod, Ignore, ExpectedException(typeof(ArgumentException))]
        public void CannotCreateDuplicateAccounts()
        {
            var emailAddress = "duplicate@gmail.com";
            store.Add(emailAddress);

            service.CreateAccount(emailAddress);
        }

        // Add more tests here...
    }
}
