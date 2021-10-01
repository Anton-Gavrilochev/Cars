using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;

namespace TestsCars
{
    [TestClass]
    public class TestCar
    {
        [TestMethod]
        public void TestDistanceWithFullTank()
        {
            //Исходные данные
            float fuelConsumption = (float)2.5;
            float fuelTankCapacity = 20;
            float speed = 60;

            //ожидание
            float expected = 800;

            //проверка
            Car car = new Car(fuelConsumption, fuelTankCapacity, speed);
            float actual = car.DistanceWuthFullTank();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuel1()
        {
            //Исходные данные
            float fuelConsumption = (float) 2.5;
            float fuelTankCapacity = 30;
            float speed = 90;
            float currentFuel = (float)12.5;

            //ожидание
            float expected = 500;

            //проверка
            Car car = new Car(fuelConsumption, fuelTankCapacity, speed);
            float actual = car.DistanceByCurrentFuel(currentFuel);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDistanceByCurrentFuel2()
        {
            //Исходные данные
            float fuelConsumption = (float)1.5;
            float fuelTankCapacity = 10;
            float speed = 60;
            float currentFuel = (float)12.5;

            //ожидание
            float expected = 0;

            //проверка
            Car car = new Car(fuelConsumption, fuelTankCapacity, speed);
            float actual = car.DistanceByCurrentFuel(currentFuel);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTimeToTargetByDistance1()
        {
            //Исходные данные
            float fuelConsumption = (float)1.5;
            float fuelTankCapacity = 25;
            float speed = 70;
            float currentFuel = 20;
            float distance = 350;

            //ожидание
            float expected = 5;

            //проверка
            Car car = new Car(fuelConsumption, fuelTankCapacity, speed);
            float actual = car.TimeToTargetByDistance(currentFuel, distance);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTimeToTargetByDistance2()
        {
            //Исходные данные
            float fuelConsumption = (float)1.5;
            float fuelTankCapacity = 20;
            float speed = 60;
            float currentFuel = 10;
            float distance = 1000;

            //ожидание
            float expected = 0;

            //проверка
            Car car = new Car(fuelConsumption, fuelTankCapacity, speed);
            float actual = car.TimeToTargetByDistance(currentFuel, distance);
            Assert.AreEqual(expected, actual);
        }
    }
}
