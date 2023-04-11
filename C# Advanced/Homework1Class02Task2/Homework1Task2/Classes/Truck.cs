using Homework1Task2.Entities;
using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"This is Truck, I realy love to drive my {Model}");
        }
    }
}
