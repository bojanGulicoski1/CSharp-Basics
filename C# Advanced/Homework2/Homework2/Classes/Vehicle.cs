namespace Homework2.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty;

        public int YearOfpProduction { get; set; }

        public int BatchNumber { get; set; }



        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id} , Type: {Type} , Year of production: {YearOfpProduction}");
        }
    }
}
