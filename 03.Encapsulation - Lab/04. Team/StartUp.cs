using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class StartUp
    {

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team("SoftUni");
            for (int i=0; i< n;i++)
            {
                string[] splitted = Console.ReadLine().Split(" ");
                int age =int.Parse( splitted[2]);
                decimal salary = decimal.Parse(splitted[3]);

                Person person = new Person(splitted[0], splitted[1], age, salary);

                team.AddPlayer(person);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}
