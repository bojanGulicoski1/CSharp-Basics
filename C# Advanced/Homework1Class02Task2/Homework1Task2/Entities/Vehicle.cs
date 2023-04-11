namespace Homework1Task2.Entities
{
    public abstract class Vehicle
    {

        public int CleanPercentage { get; set; }

        public int GasPercentage { get; set; }

        public string Model { get; set; } = string.Empty;

        public string TypeOFVehicle { get; set; } = string.Empty;
        public bool HaveProblem { get; set; }


        public abstract void Drive();
    }
}
