using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMaker;
namespace CoffeeMakerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderACoffee_Should_Return_Received_Message()
        {
            //Arrange
            StarbuckStore store = new StarbuckStore(new FakeStarbucksStore());
            //Act
            string result = store.OrderCoffee(2, 4);
            //Assert
            Assert.AreEqual("Your Order is received.", result);
        }
    }
}

