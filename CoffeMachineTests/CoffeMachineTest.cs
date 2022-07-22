using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Models;
using ConsoleApp1;
namespace CoffeMachineTests
{
    [TestClass]
    public class CoffeMachineTest
    {
        [TestMethod]
        public void check()
        {
            CoffeeMachine checkingObject = new CoffeeMachine();
            checkingObject.LoadBeans(500);
            checkingObject.LoadMilk(500);
            checkingObject.LoadWater(500);
            int expectedCapacity=500+500+500;
            checkingObject.Brew(RecipeName.cappuccino);
            Xunit.Assert.NotEqual(expectedCapacity, checkingObject.GetBeansLevel()+ checkingObject.GetMilkLevel() + checkingObject.GetWaterLevel());
        }
    }
}