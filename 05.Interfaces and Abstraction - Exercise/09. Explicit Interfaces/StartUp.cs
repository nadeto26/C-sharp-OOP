using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp170
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ");

                Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

                citizens.Add(citizen);
                input = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}


