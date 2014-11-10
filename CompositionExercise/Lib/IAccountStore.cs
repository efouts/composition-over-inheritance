using System;

namespace CompositionExercise.Lib
{
    public interface IAccountStore
    {
        void Add(String emailAddress);
        Boolean Exists(String emailAddress);
    }
}
