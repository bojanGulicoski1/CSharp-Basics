namespace Homework2.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;

        public int YearOfpProduction { get; set; }

        public int BatchNumber { get; set; }



        public void PrintVehicle()
        {
            Console.WriteLine($"{Id} - {Type} - {YearOfpProduction}");
        }


    }
}
