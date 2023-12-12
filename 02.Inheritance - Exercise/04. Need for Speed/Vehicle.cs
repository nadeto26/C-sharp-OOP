using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelComsumtion = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        private double fuel;

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public  virtual double FuelConsumption 
            => DefaultFuelComsumtion;

        public virtual void Drive (double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }


    }
}
