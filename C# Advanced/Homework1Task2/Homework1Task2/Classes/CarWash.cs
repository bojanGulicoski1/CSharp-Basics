using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            if (car.CleanPercentage < 50)
                Console.WriteLine($"I am washing this car: {car.Model}");
            else
                Console.WriteLine($"This car is clean");

        }

        public void WashTruck(Truck truck)
        {
            if (truck.CleanPercentage < 50)
                Console.WriteLine($"I am washing this truck: {truck.Model}");
            else
                Console.WriteLine($"This car is clean");
        }
    }
}
