﻿using System;
using System.Collections.Generic;
using CompositionExercise.Lib;

namespace CompositionExercise.Tests
{
    public class InMemoryAccountStore : IAccountStore
    {
        private HashSet<String> users;

        public InMemoryAccountStore()
        {
            users = new HashSet<String>();
        }

        public void Add(String emailAddress)
        {
            users.Add(emailAddress);
        }

        public Boolean Exists(String emailAddress)
        {
            return users.Contains(emailAddress);
        }
    }
}
