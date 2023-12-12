using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Bevarage : Product
    {
        public Bevarage(string name, decimal price,double milliliters) : base(name, price)
        {
            Mililiters = milliliters;
        }

        public double Mililiters { get;private  set; } 
    }
}
