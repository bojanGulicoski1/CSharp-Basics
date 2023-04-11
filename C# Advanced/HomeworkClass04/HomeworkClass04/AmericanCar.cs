using HomeworkClass04.Entities;

namespace HomeworkClass04
{
    public class AmericanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Welcome to {destinationName}...");
        }
    }
}

