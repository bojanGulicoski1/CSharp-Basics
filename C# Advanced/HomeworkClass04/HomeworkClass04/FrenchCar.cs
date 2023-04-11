using HomeworkClass04.Entities;

namespace HomeworkClass04
{
    public class FrenchCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Welcome to {destinationName} with your {Model}");
        }
    }
}
