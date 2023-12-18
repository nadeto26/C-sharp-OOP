﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    public abstract class Vehicle  
    {
        private double fuelQuantity;
        private double consumprionPerKilometer;
        private double tankCapacity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double ConsumprionPerKilometer
        {
            get { return consumprionPerKilometer; }
            set { consumprionPerKilometer = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set
            { tankCapacity = value; }
        }


        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);

    }
}
