using Homework1Task2.Classes;

Car myCar = new Car()
{
    Model = "Tesla",
    CleanPercentage = 60,
    TypeOFVehicle = "Car",
    GasPercentage = 100,
    HaveProblem = false
};

myCar.Drive();

myCar.CarWash();

myCar.PumpGas();

myCar.CheckVehicle();

myCar.TruckWash();

Truck myTruck = new Truck()
{
    Model = "Volvo",
    CleanPercentage = 10,
    TypeOFVehicle = "Truck",
    GasPercentage = 60,
    HaveProblem = true
};


myTruck.Drive();
myTruck.CarWash();
myTruck.PumpGas();
myTruck.CheckVehicle();
myTruck.TruckWash();