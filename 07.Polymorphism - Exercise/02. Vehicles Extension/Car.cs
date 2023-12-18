using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    public class Car : Vehicle
    {
        private const double IncreasedConsumption = 0.9; // private , защото е само на колата 

        public Car(double fuelQuantity, double fuelConsumption ) 
            : base(fuelQuantity, fuelConsumption, IncreasedConsumption)
        {

        }
    }
}
