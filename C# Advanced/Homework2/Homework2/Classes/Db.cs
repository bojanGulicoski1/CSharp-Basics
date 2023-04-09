namespace Homework2.Classes
{
    public static class Db
    {


        public static List<Vehicle> Vehicles = new List<Vehicle>()
            {
                new Vehicle() {BatchNumber = 1 , Id = 2 , Type ="Car", YearOfpProduction =1999},
                 new Vehicle() {BatchNumber = 2 , Id = 0 , Type ="Bike", YearOfpProduction =2016},
                  new Vehicle() {BatchNumber = 3 , Id = 0 , Type ="Bike", YearOfpProduction =2009},
                   new Vehicle() {BatchNumber = 4 , Id = 7 , Type ="Vehicle", YearOfpProduction =2014},
                    new Vehicle() {BatchNumber = 5 , Id = 12 , Type ="Car", YearOfpProduction =2023},
                     new Vehicle() {BatchNumber = 6 , Id = 20 , Type ="Car", YearOfpProduction =2022},
                       new Vehicle() {BatchNumber = 0 , Id = 0 , Type ="Vehicle", YearOfpProduction =2017},
        };

        public static void PrintVehicles()
        {
            for (int i = 0; i < Vehicles.Count; i++)
            {
                Console.WriteLine($" Type: {Vehicles[i].Type} Id: {Vehicles[i].Id} Production:  {Vehicles[i].YearOfpProduction} Batch Number: {Vehicles[i].BatchNumber} ");
            }
        }


    }
}
