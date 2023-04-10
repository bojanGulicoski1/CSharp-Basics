using Homework1Task2.Entities;
using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            if (vehicle.HaveProblem)
                Console.WriteLine($"This vehicle {vehicle.Model} has problem.");
            else
                Console.WriteLine($"This vehicle {vehicle.Model} is GOOD");

        }

        public void FixVehicle(Vehicle vehicle)
        {
            if (vehicle.HaveProblem)
                Console.WriteLine($"Starting to FIX vehicle {vehicle.Model}.");
            else
                Console.WriteLine($"This vehicle {vehicle.Model} doesnt need to be fixed, it is good");
        }

       
    }
}
