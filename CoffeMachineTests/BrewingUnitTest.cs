using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Models;
namespace CoffeMachineTests
{
    [TestClass]
    class BrewingUnitTest
    {
        [TestMethod]
        public void NotNullResultTest()
        {
            BrewingUnit checkingObject = new BrewingUnit();
            GroundCoffe input = new GroundCoffe();
            input.quantity = 500;
            var result = checkingObject.Brew(input);
            Xunit.Assert.NotNull(result);
        }
    }
}
