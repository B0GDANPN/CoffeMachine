using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Models;
namespace CoffeMachineTests
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void ContainerCapacitySet_Success()
        {
            const int expectedCapacity = 1000;
            var container = new Container(expectedCapacity);
            var actualCapacity = container.GetCapacity();
            Xunit.Assert.Equal(expectedCapacity, actualCapacity);
        }
    }
}