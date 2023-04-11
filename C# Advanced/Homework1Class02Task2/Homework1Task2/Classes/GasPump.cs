using Homework1Task2.Entities;
using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            if (vehicle.GasPercentage < 50)
                Console.WriteLine($"I'm adding gas to this vehicle: {vehicle.Model}");
            else
                Console.WriteLine($"Gas is OK from {vehicle.Model}");
        }
    }
}
