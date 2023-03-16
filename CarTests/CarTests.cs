﻿namespace CarTests;
using Car;

[TestClass]
public class CarTests
{
    //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
    

    Car test_car;

    [TestInitialize]
    public void CreateCarObject()
    {
        test_car = new Car("Toyota", "Prius", 10, 50);
    }
    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(10, 10, .001);
    }

    //TODO: constructor sets gasTankLevel properly
    [TestMethod]
    public void TestInitialGasTank()
    {
        Assert.AreEqual(10, test_car.GasTankLevel, .001);
    }

    //TODO: gasTankLevel is accurate after driving within tank range
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    //TODO: can't have more gas than tank size, expect an exception
    [TestMethod]
    public void TestGasTankAfterDriving()
    {
        test_car.Drive(50);
        Assert.AreEqual(9, test_car.GasTankLevel, .001);
    }

    [TestMethod]
    public void TestGasTankAfterExceedingTankRange()
    {
        test_car.Drive(501);
        Assert.AreEqual(0, test_car.GasTankLevel, .001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestGasOverfillException()
    {
        test_car.AddGas(6000);

        Assert.Fail("car cannot have more gas in tank is full");
    }
}