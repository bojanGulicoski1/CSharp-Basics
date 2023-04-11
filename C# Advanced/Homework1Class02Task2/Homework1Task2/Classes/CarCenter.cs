using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class CarCenter
    {
        public GasPump MyGasPump { get; set; }

        public RepairService MyRepairService { get; set; }

        public CarWash MyCarWash { get; set; }

        public CarCenter()
        {
            MyGasPump = new GasPump();
            MyRepairService = new RepairService();
            MyCarWash = new CarWash();
        }

    }
}
