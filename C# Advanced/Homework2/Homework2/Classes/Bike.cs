namespace Homework2.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;



        public void PrintVehicle(int production, string color)
        {
            Console.WriteLine($"This bike is producted in {production} -and is {color} color");
        }
    }
}
