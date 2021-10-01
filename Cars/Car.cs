namespace Cars
{
    public class Car
    {
        protected float fuelConsumption;    //литры на 100КМ
        protected float fuelTankCapacity;   //литры
        protected float speed;              //км/ч  

        public Car (float fuelConsumption, float fuelTankCapacity, float speed)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelTankCapacity = fuelTankCapacity;
            this.speed = speed;
        }

        public float DistanceWuthFullTank ()
        {
            return fuelTankCapacity / fuelConsumption * 100;
        }

        public float DistanceByCurrentFuel(float currentFuel)
        {
            if (currentFuel > fuelTankCapacity)
                return 0;
            else
               return currentFuel / fuelConsumption * 100;
        }

        public float TimeToTargetByDistance(float currentFuel, float distance)
        {
            if (distance > DistanceByCurrentFuel(currentFuel))
            {
                return 0;
            }
            else
            {
                return distance / speed;
            }
        }
    }
}
