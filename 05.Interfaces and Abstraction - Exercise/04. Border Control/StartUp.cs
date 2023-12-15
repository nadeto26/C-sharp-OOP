using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IPeople> ides = new List<IPeople >();


            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    Citizens citizen = new Citizens(tokens[2], tokens[0], int.Parse(tokens[1]));
                    ides.Add(citizen);
                }
                else
                {
                    Robots robot = new Robots(tokens[1], tokens[0]);
                    ides.Add(robot);
                }



                input = Console.ReadLine();
            }

            string invalidId = Console.ReadLine();

           foreach (var id in ides)
            {
                if (id.Id.EndsWith(invalidId))
                {
                    Console.WriteLine(id.Id);
                }
            }
           
        }
       
    }
}
