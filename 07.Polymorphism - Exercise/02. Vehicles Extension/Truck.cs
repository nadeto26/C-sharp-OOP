using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsumption = 1.6; // private , защото е само на колата 
        public Truck(double fuelQuantity, double fuelConsumption) : 
            
            base(fuelQuantity, fuelConsumption, IncreasedConsumption)
        {

        }


        public override void Refuel(double amount) => base.Refuel(amount * 0.95);
    }
}
