using System;

namespace InheritanceExercise.Lib
{
    public interface IAccountStore
    {
        void Add(String emailAddress);
        Boolean Exists(String emailAddress);
    }
}
