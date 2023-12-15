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
            List<Identicity> identities = new List<Identicity>();

            string command = Console.ReadLine();

            while(command!= "End")
            {
                string[] splitted = command.Split(" ");

                if (splitted.Length == 5)
                {
                    Citizen citizen = new Citizen(splitted[1], int.Parse(splitted[2]), splitted[3], splitted[4]);
                    identities.Add(citizen);
                }
                else
                {
                    Pet pet = new Pet(splitted[1], splitted[2]);
                    identities.Add(pet);
                }

                command = Console.ReadLine();





            }

            string birtday = Console.ReadLine();

            foreach(var birth in  identities)
            {
                if (birth.Birthday.EndsWith(birtday))
                {
                    Console.WriteLine(birth.Birthday);
                }
            }
           
        }
       

        
    }
}
