using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace TestsCars
{
    [TestClass]
    public class TestCargoCar
    {
        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading1()
        {
            //Исходные данные
            float fuelConsumption = 4;
            float fuelTankCapacity = 60;
            float speed = 80;
            float currentFuel = 40;
            float cargo = 1000;

            //ожидание
            float expected = 800;

            //проверка
            CargoCar car = new CargoCar(fuelConsumption, fuelTankCapacity, speed, 1500);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, cargo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading2()
        {
            //Исходные данные
            float fuelConsumption = 3;
            float fuelTankCapacity = 40;
            float speed = 100;
            float currentFuel = 15;
            float cargo = 2000;

            //ожидание
            float expected = 300;

            //проверка
            CargoCar car = new CargoCar(fuelConsumption, fuelTankCapacity, speed, 3000);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, cargo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuelDependLoading3()
        {
            //Исходные данные
            float fuelConsumption = (float)4;
            float fuelTankCapacity = 50;
            float speed = 90;
            float currentFuel = 30;
            float cargo = 3000;

            //ожидание
            float expected = 0;

            //проверка
            CargoCar car = new CargoCar(fuelConsumption, fuelTankCapacity, speed, 1500);
            float actual = car.DistanceByCurrentFuelDependLoading(currentFuel, cargo);
            Assert.AreEqual(expected, actual);
        }
    }
}
