using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffe : HotBeverage
    {
        private const decimal CoffePrice = 3.50M;
        private const double CoffeMililiters = 50;
        public Coffe(string name, double caffeine) : base(name, CoffePrice, CoffeMililiters)
        {
            Caffeine = caffeine;
        }

        private double caffeine;

        public double Caffeine
        {
            get { return caffeine; }
            private set { caffeine = value; }
        }
    }
}
