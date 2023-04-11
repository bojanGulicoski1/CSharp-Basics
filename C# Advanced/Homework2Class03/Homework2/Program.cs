using Homework2.Classes;
using Validator = Homework2.Classes.Validator;


Vehicle boat = new Vehicle()
{
    Id = 2,
    YearOfpProduction = 2022,
    Type = "Boat",
    BatchNumber = 2,

};

Vehicle plane = new Vehicle()
{
    Id = 0,
    YearOfpProduction = 2023,
    Type = "",
    BatchNumber = 10
};

Bike bike = new Bike()
{
    Id = 2,
    BatchNumber = 1,
    YearOfpProduction = 2022,
    Type = "Bike",
    Color = "green"
};

Car car = new Car()
{
    YearOfpProduction = 0,
    BatchNumber = 9,
    Type = "BMW",
    CountryOfProduction = "France",
    FuelTank = 70,
    Id = 3,
};


Console.WriteLine("Printing list Vehicles");
Db.PrintVehicles();
Console.WriteLine("\n Adding new item o the list");
Db.Vehicles.Add(plane);
Console.WriteLine("\n Printing after ading new item t the list Vehicles");
Db.PrintVehicles();
Console.WriteLine("\n");

boat.PrintVehicle();
Console.WriteLine("\n");

Validator.Validate(boat);
Console.WriteLine("\n");

Validator.Validate(plane);
Console.WriteLine("\n");

bike.PrintVehicle();
Console.WriteLine("\n");

car.PrintVehicle();
Console.WriteLine("\n");

Validator.Validate(car);

