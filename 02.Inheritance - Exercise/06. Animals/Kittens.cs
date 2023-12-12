using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kittens : Animal
    {
        private const string KittenCatGender = "Female";
        public Kittens(string name, int age) : base(name, age,KittenCatGender)
        {
        }

        public override string ProduceSound() => "Meow";


    }
}
