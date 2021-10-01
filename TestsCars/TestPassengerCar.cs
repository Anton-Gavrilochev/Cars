using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace TestsCars
{
    [TestClass]
    public class TestPassengerCar
    {
        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading1()
        {
            //Исходные данные
            float fuelConsumption = (float)2.5;
            float fuelTankCapacity = 20;
            float speed = 80;
            float currentFuel = 10;
            int pessanger = 2;

            //ожидание
            float expected = 352;

            //проверка
            PassengerCar car = new PassengerCar(fuelConsumption, fuelTankCapacity, speed, 4);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, pessanger);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading2()
        {
            //Исходные данные
            float fuelConsumption = 3;
            float fuelTankCapacity = 40;
            float speed = 75;
            float currentFuel = 15;
            int pessanger = 5;

            //ожидание
            float expected = 350;

            //проверка
            PassengerCar car = new PassengerCar(fuelConsumption, fuelTankCapacity, speed, 8);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, pessanger);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading3()
        {
            //Исходные данные
            float fuelConsumption = (float)2.5;
            float fuelTankCapacity = 20;
            float speed = 80;
            float currentFuel = 10;
            int pessanger = 4;

            //ожидание
            float expected = 0;

            //проверка
            PassengerCar car = new PassengerCar(fuelConsumption, fuelTankCapacity, speed, 3);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, pessanger);
            Assert.AreEqual(expected, actual);
        }
    }
}
