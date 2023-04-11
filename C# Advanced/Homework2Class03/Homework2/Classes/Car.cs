namespace Homework2.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public string CountryOfProduction { get; set; } = string.Empty;



        public override void PrintVehicle()
        {
            Console.WriteLine($"This car is {Type} and is produced in {CountryOfProduction}");
        }
    }
}
