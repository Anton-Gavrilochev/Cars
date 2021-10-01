namespace Cars
{
    public class CargoCar : Car
    {
        private float maxCargo; //кг

        public CargoCar(float fuelConsumption, float fuelTankCapacity, float speed, float maxCargo) : base(fuelConsumption, fuelTankCapacity, speed)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelTankCapacity = fuelTankCapacity;
            this.speed = speed;
            this.maxCargo = maxCargo;
        }

        //условие задачи не совсем корректно, если взять грузовой автомобиль с грузом в 6 тонн 
        //то уменьшение запаса хода составит 120%
        public float DistanceByCurrentFuelDependLoading(float currentFuel, float cargo)
        {
            if (cargo > maxCargo)
                return 0;
            else
                return (float)(DistanceByCurrentFuel(currentFuel) * (1 - 0.04 * cargo / 200));
        }
    }
}
