using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp171
{
     public interface ICar
    {
        public string Model { get; }
        public string Color { get; }
        public string Start ()
        {
            return "Engine start";
        }
        public string Stop ()
        {
            return "Breaaak!";
        }
    }
}
