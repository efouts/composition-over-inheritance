using System;

namespace PolymorphismExercise.Lib
{
    public interface IWidget
    {
        void DoSomething();
    }

    public class Foo : IWidget
    {
        public void DoSomething()
        {
            Console.WriteLine("Foo");
        }
    }

    public class Bar : IWidget
    {
        public void DoSomething()
        {
            Console.WriteLine("Bar");
        }
    }
}
