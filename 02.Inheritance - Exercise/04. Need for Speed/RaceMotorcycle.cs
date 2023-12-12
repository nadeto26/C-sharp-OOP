﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelComsumtion = 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption
          => DefaultFuelComsumtion;
    }
}