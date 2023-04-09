namespace Homework2.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public string CountryOfProduction { get; set; } = string.Empty;



        public void PrintVehicle(string type, int production)
        {
            Console.WriteLine($"This {type} is producted in {production} year");
        }
    }
}
