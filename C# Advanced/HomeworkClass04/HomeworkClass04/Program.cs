using HomeworkClass04;
using HomeworkClass04.Database;
using HomeworkClass04.Entities;
using Microsoft.VisualBasic.FileIO;

JapaneseCar japaneseCar = new JapaneseCar()
{
    Brand = "Honda",
    FuelType = EnumTypeOfFuel.Petrol,
    HorsePower = 300,
    Id = 2,
    MaxSpeed = 280,
    Model = "xxxCZ"
};

FrenchCar frenchCar = new FrenchCar()
{
    Brand = "Citroen",
    FuelType = EnumTypeOfFuel.Electric,
    HorsePower = 200,
    Id = 1,
    MaxSpeed = 300,
    Model = "C4"
};
AmericanCar americanCar = new AmericanCar()
{
    Brand = "Ford",
    FuelType = EnumTypeOfFuel.Hibrid,
    HorsePower = 300,
    Id = 2,
    MaxSpeed = 240,
    Model = "Focus"
};
ItalianCar italianCar = new ItalianCar()
{
    Brand = "Fiat",
    FuelType = EnumTypeOfFuel.Diesel,
    HorsePower = 300,
    Id = 2,
    MaxSpeed = 280,
    Model = "Punto"
};
GermanCar germanCar = new GermanCar()
{
    Brand = "Mercedez",
    FuelType = EnumTypeOfFuel.Petrol,
    HorsePower = 300,
    Id = 2,
    MaxSpeed = 280,
    Model = "C-Class"
};
Console.WriteLine("Info for all cars");
japaneseCar.GetInfo();
germanCar.GetInfo();
frenchCar.GetInfo();
italianCar.GetInfo();
americanCar.GetInfo();
Console.WriteLine("\n");
Console.WriteLine("Inserting cars in Db");
GenericDb<JapaneseCar>.InsertCar(japaneseCar);
GenericDb<GermanCar>.InsertCar(germanCar);
GenericDb<FrenchCar>.InsertCar(frenchCar);
GenericDb<ItalianCar>.InsertCar(italianCar);
GenericDb<AmericanCar>.InsertCar(americanCar);

Console.WriteLine("\n List after adding new cars");
GenericDb<JapaneseCar>.PrintAll();
GenericDb<GermanCar>.PrintAll();
GenericDb<FrenchCar>.PrintAll();
GenericDb<ItalianCar>.PrintAll();
GenericDb<AmericanCar>.PrintAll();
Console.WriteLine("\n");
Console.WriteLine("Calling method drive from diferent clases");
japaneseCar.Drive("Tokyo");
frenchCar.Drive("Paris");
germanCar.Drive("Munich");
americanCar.Drive("Miami");
italianCar.Drive("Milano");
Console.WriteLine("\n");
Console.WriteLine("Geting car by id");
GenericDb<JapaneseCar>.GetById(1);
Console.WriteLine("\n");
GenericDb<GermanCar>.PrintAll();