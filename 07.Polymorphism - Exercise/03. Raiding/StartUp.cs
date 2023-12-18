using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> raidGroup = new List<BaseHero>();

            for (int i = 0; i < n; i++)
            {

                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();


                BaseHero hero = CreateHero(heroType, heroName);

                if (hero != null)
                {
                    raidGroup.Add(hero);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            bool victory = true;
            int totalPower = 0;

            foreach (BaseHero hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        static BaseHero CreateHero(string type, string name)
        {
            switch (type)
            {
                case "Druid":
                    return new Druid(name);
                case "Paladin":
                    return new Paladin(name);
                case "Rogue":
                    return new Rogue(name);
                case "Warrior":
                    return new Warrior(name);
                default:
                    return null;
            }
        }
    }
}

