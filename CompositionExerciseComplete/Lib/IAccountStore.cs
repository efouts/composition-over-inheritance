using System;

namespace CompositionExerciseComplete.Lib
{
    public interface IAccountStore
    {
        void Add(String emailAddress);
        Boolean Exists(String emailAddress);
    }
}
