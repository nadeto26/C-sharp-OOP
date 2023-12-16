using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp170
{
    public class Citizen : IResident, IPerson
    {

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;

        }
        public string Name { get; private set; }

        public string Country { get; private set; }

        public int Age { get; private set; }



        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }

        string IPerson.GetName()
        {
            return Name;
        }
    }
}


