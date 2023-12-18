using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    public abstract class Vehicle : IVehicle
    {
        private double increasedConsumption;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double increasedConsumption) // за да могат само наследниците да го достъпват 
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;

            this.increasedConsumption = increasedConsumption;

        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double consumption = FuelConsumption + increasedConsumption;

            if (FuelQuantity< distance * consumption)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            FuelQuantity -= distance * consumption;
            return $"{this.GetType().Name} travelled {distance} km"; // така не е нужно всики път да го override


        }

        public virtual void Refuel(double amount) => FuelQuantity += amount; // virtual -> ще го напишем в другите , само ако искаме 
        // да има някакво промяна 

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }


    }
}
