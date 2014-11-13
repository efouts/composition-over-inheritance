using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExerciseComplete.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExerciseComplete.Tests
{
    [TestClass]
    public class FullStackTests
    {
        private IAccountStore store;
        private IEmailer emailer;
        private AccountCreationService service;

        [TestInitialize]
        public void Setup()
        {
            store = new InMemoryAccountStore();
            emailer = new FakeEmailer();
            service = new AccountCreationEmailService(store, emailer);
        }

        [TestMethod]
        public void CreateAccount()
        {
            service.CreateAccount("myEmail@gmail.com");
        }
    }
}
