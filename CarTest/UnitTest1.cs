using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTest
{
    [TestClass]
    public class CarTests
    {
        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50, 4);

        }



        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001); //epected value of 10 = actual value of 10 w/ a .001 variance
            Assert.AreEqual(10, 10.0009, .001);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        [TestMethod]
        public void TestInitialGasTankFalse()
        {
            //Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.IsFalse(test_car.GasTankLevel == 0);
        }

        [TestMethod]
        public void TestInitialGasTankTrue()
        {
            Assert.IsTrue(test_car.GasTankLevel == 10);
        }

        //TODO: Test Number of Wheels
        [TestMethod]
        public void TestNumberOfWheels()
        {
            Assert.AreEqual(4, test_car.NumberOfWheels);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            test_car.Drive(500);
            Assert.AreEqual(0, test_car.GasTankLevel, .01);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(10);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }





    }
}