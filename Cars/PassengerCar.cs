namespace Cars
{
    public class PassengerCar : Car
    {
        private int maxPassenger;

        public PassengerCar (float fuelConsumption, float fuelTankCapacity, float speed, int maxPassenger) : base (fuelConsumption,fuelTankCapacity,speed)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelTankCapacity = fuelTankCapacity;
            this.speed = speed;
            this.maxPassenger = maxPassenger;
        }

        public float DistanceByCurrentFuelDependLoading(float currentFuel, int passenger)
        {
            if (passenger > maxPassenger)
                return 0;
            else
                return (float)(DistanceByCurrentFuel(currentFuel) * (1 - 0.06 * passenger));
        }
    }
}
