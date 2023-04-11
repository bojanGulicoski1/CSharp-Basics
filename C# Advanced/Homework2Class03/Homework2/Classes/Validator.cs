namespace Homework2.Classes
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {

            if (vehicle.Id <= 0)
            {
                Console.WriteLine("ERROR your Id is 0");

            }
            else if (vehicle.Id > 0)
            {
                Console.WriteLine($"Yur ID is: {vehicle.Id}");
            }



            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("EROOR PLease enter type of Vehicle");
            }
            else
            {
                Console.WriteLine($"Your type is: {vehicle.Type}");
            }



            if (vehicle.YearOfpProduction == 0)
            {
                Console.WriteLine("ERROR Year of production is not valid ");
            }
            else
            {
                Console.WriteLine($"Year of production: {vehicle.YearOfpProduction}");
            }



        }
    }
}
