using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolymorphismExercise.Lib;

namespace PolymorphismExercise.Tests
{
    [TestClass]
    public class WidgetTests
    {
        [TestMethod]
        public void AllWidgetsDoSomething()
        {
            var widgets = new IWidget[] { new Foo(), new Bar() };

            foreach (var widget in widgets)
                widget.DoSomething();
        }
    }
}
