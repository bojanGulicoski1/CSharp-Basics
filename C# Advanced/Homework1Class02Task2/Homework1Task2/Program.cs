using Homework1Task2.Classes;

Car myCar = new Car()
{
    Model = "Tesla",
    CleanPercentage = 60,
    TypeOFVehicle = "Car",
    GasPercentage = 100,
    HaveProblem = false
};

Truck myTruck = new Truck()
{
    Model = "Volvo",
    CleanPercentage = 10,
    TypeOFVehicle = "Truck",
    GasPercentage = 60,
    HaveProblem = true
};

CarCenter carCentarStruga = new CarCenter();

carCentarStruga.MyGasPump.PumpGas(myCar);
carCentarStruga.MyGasPump.PumpGas(myTruck);

carCentarStruga.MyCarWash.WashCar(myCar);
carCentarStruga.MyCarWash.WashTruck(myTruck);


carCentarStruga.MyRepairService.FixVehicle(myCar);
carCentarStruga.MyRepairService.CheckVehicle(myTruck);
