using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositionExercise.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompositionExercise.Tests
{
    [TestClass]
    public class FullStackTests
    {
        private IAccountCreationService service;

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
