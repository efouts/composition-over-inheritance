using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceExercise.Tests
{
    [TestClass]
    public class FullStackTests
    {
        private AccountCreationService service;

        [TestInitialize]
        public void Setup()
        {
            // Create service
        }

        [TestMethod, Ignore]
        public void CreateAccount()
        {
            service.CreateAccount("myEmail@gmail.com");
        }
    }
}
