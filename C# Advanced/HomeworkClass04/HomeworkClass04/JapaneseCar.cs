using HomeworkClass04.Entities;

namespace HomeworkClass04
{
    public class JapaneseCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Welcome to {destinationName} best town in Japan");
        }

     
    }
}
