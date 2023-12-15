using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public class Robots : IPeople
    {
        public  Robots ( string id, string model )
        {
            Id = id;
            Model = model;
        }
        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}
