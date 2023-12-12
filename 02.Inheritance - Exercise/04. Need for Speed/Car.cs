using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelComsumtion = 3;
        // затова е правейт да не може да бъде достъпена от другите класове 
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption 
            => DefaultFuelComsumtion;
    }
}
