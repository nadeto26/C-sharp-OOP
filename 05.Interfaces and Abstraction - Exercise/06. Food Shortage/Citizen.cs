using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp167
{
    public class Citizen : Identicity , IBuyer
    {
        private const int DefaultFoodIncrement = 10;
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
             
        }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
        public string Id { get; private set; }   

        public int Age { get; private set; }

        

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food +=DefaultFoodIncrement;
        }


    }
}
