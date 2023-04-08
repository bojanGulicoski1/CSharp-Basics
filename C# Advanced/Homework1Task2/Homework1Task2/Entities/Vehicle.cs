namespace Homework1Task2.Entities
{
    public abstract class Vehicle
    {
        public bool isFullGas;

        public bool isClean;

        public bool  isBroken;
        public int CleanPercentage { get; set; }

        public int GasPercentage { get; set; }

        public string TypeOFVehicle { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public bool HaveProblem { get; set; }





        public void CarWash(bool car)
        {
            
        }
        public abstract void Drive();
    }
}
