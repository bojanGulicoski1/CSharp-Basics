﻿using Homework1Task2.Entities;
using Homework1Task2.Entities.Interfaces;

namespace Homework1Task2.Classes
{
    public class Truck : Vehicle , ICarWash, IGasPump, IRepairService
    {

        public void CarWash()
        {
            if (TypeOFVehicle == "Truck")
            {
                Console.WriteLine("This room is only for Cars room 4 ,5 ,6 are for Trucks");
            }
           
        }

        public void PumpGas()
        {
            
            if (GasPercentage == 100)
            {
                isFullGas = true;
            }
            else
            {
                isFullGas = false;
            }

            if (isFullGas)
            {
                Console.WriteLine("Your gas is full!!");
            }
            else
            {
                Console.WriteLine("Your gas is not full please check it");
            }
        }

        public override void Drive()
        {
            Console.WriteLine($"I realy love to drive my {Model}");
        }


        public void TruckWash()
        {
            
            if (CleanPercentage < 50)
            {
                isClean = true;
            }
            else
            {
                isClean = false;
            }

            if (isClean)
            {
                Console.WriteLine("Your truck is clean");
            }
            else
            {
                Console.WriteLine("Pelase leave your truck it is so diry");
            }
        }

        public void CheckVehicle()
        {
            
            if (HaveProblem)
            {
                isBroken = true;
            }
            else
            {
                isBroken = false;
            }

            if (isBroken)
            {
                Console.WriteLine("Leave your Vehicle we will try to fix it ");
            }
            else
            {
                Console.WriteLine("Your car is ok!!!");
            }
        }

        public void FixVehicle()
        {
            Console.WriteLine("We cant fix your Vehicle go to ...");
        }
    }
}
 