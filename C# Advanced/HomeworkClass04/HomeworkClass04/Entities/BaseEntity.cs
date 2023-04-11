namespace HomeworkClass04.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public int MaxSpeed { get; set; }

        public int HorsePower { get; set; }

        public EnumTypeOfFuel FuelType { get; set; }

        public abstract void Drive(string destinationName);

        public void GetInfo()
        {
            Console.WriteLine($"{Id} -- {Brand} -- {Model} -- {MaxSpeed} -- {HorsePower} -- {FuelType}!!");
        }
    }
}
