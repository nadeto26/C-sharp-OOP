﻿using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            MaxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            this.batteryLevel = 100;
            this.isDamaged = false;


        }
        private string brand;
        private string model;
        private string licensePlateNumber;
        private bool isDamaged;
        private int batteryLevel;

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }
                brand = value;
            }
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }

        public double MaxMileage { get; private set; }

        public string LicensePlateNumber
        {
            get => licensePlateNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel  => batteryLevel;  

        public bool IsDamaged  => isDamaged; 

        public void ChangeStatus()
        {
            if (!IsDamaged)
            {
                this.isDamaged = true;
            }
            else
            {
                this.isDamaged = false;
            }
        }

        public void Drive(double mileage)
        {
            double percentage = Math.Round((mileage / this.MaxMileage) * 100);
            this.batteryLevel -= (int)percentage;

            if (this.GetType().Name == nameof(CargoVan))
            {
                this.batteryLevel -= 5;
            }

        }

        public void Recharge()
        {
            batteryLevel = 100;
        }

        public override string ToString()
        {
            string vehicleCondition;

            if (IsDamaged)
            {
                vehicleCondition = "damaged";

            }
            else
            {
                vehicleCondition = "OK";
            }

            return $"{Brand} {Model} License plate: {LicensePlateNumber}" +
                $" Battery: {BatteryLevel}% Status: {vehicleCondition}";
        }
    }
}
