using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Models;
namespace CoffeMachineTests
{
    [TestClass]
    class GrinderUnitTest
    {
        [TestMethod]
        public void NotNullResultTest()
        {
            GrinderUnit checkingObject = new GrinderUnit();
            var result = checkingObject.Grind(1000);
            Xunit.Assert.NotNull(result);
        }
    }
}
