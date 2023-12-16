using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp167
{
    public class Robot
    {
        public Robot(string model, int id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get;private set; }
        public int Id { get;private set; }
    }
}
