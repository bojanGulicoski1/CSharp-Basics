using HomeworkClass04.Entities;

namespace HomeworkClass04
{
    public class ItalianCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Welcome to {destinationName} the sity of fashion");
        }
    }
}
