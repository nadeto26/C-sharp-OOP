﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class PassengerCar : Vehicle
    {
        public PassengerCar(string brand, string model, double maxMileage, string licensePlateNumber) : base(brand, model, maxMileage, licensePlateNumber)
        {
        }
    }
}
