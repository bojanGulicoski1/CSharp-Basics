namespace Homework2.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;


        public override void PrintVehicle()
        {
            Console.WriteLine($"This bike is producted in {YearOfpProduction} - and is {Color} color");
        }
    }
}
