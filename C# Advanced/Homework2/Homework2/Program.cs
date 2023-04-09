using Homework2.Classes;
using Validator = Homework2.Classes.Validator;


Vehicle car1 = new Vehicle()
{
    Id = 0,
    YearOfpProduction = 0,
    Type = "Car",
    BatchNumber = 2,

};

Vehicle car2 = new Vehicle()
{
    Id = 1,
    YearOfpProduction = 2023,
    Type = "Truck",
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
    YearOfpProduction = 2022,
    BatchNumber = 9,
    Type = "Car",
    CountryOfProduction = "France",
    FuelTank = 70,
    Id = 3,
};




Db.PrintVehicles();
Console.WriteLine("\n");
Validator.Validate(car1);
Console.WriteLine("\n");
Validator.Validate(car2);
Console.WriteLine("\n");
bike.PrintVehicle(bike.YearOfpProduction, bike.Color);
Console.WriteLine("\n");
car.PrintVehicle(car.Type, car.YearOfpProduction);

