using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp167
{
    public class Pet : Identicity
    {

        public Pet(string name, string birthday)
        {
            Name = name; 
            Birthday = birthday;
        }
        public string Name { get; private set; }
        public string Birthday { get; private set; }
    }
}
