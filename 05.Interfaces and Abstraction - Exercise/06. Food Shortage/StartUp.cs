using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp167
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            List<IBuyer> ides = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    ides.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    ides.Add(rebel);
                }
            }


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                ides.FirstOrDefault(ides => ides.Name == input)?.BuyFood();
            }

            Console.WriteLine(ides.Sum(b => b.Food));


        }
    }
}
