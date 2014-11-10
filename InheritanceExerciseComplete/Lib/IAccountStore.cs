using System;

namespace InheritanceExerciseComplete.Lib
{
    public interface IAccountStore
    {
        void Add(String emailAddress);
        Boolean Exists(String emailAddress);
    }
}
