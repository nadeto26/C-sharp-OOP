using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
             Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(1, 2);
            Console.WriteLine(circle.Draw());
            Console.WriteLine(circle.CalculatePerimeter());


        }

    } 
}
