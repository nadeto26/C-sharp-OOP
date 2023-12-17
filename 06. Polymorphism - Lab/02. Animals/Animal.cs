using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, string favoriteFood)
        {
            Name = name;
            FavoriteFood = favoriteFood;
        }

        public string Name { get; private set; }

        public string FavoriteFood { get; private set; }

        public abstract string ExplainSelf();
    }
}
