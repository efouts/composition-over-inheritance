using System;
using System.Collections.Generic;
using CompositionExerciseComplete.Lib;

namespace CompositionExerciseComplete.Tests
{
    public class FakeEmailer : IEmailer
    {
        private List<String> toAddresses;

        public FakeEmailer()
        {
            toAddresses = new List<String>();
        }

        public void Send(String to)
        {
            toAddresses.Add(to);
        }

        public Boolean MessageWasSentTo(String to)
        {
            return toAddresses.Contains(to);
        }
    }
}
