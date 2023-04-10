using Homework1Task2.Entities;
using Homework1Task2.Entities.Interfaces;
using System.Reflection;

namespace Homework1Task2.Classes
{
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"This is card, I realy love to drive my {Model}");
        }
    }
}

