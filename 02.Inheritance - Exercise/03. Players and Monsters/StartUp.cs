using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Knight kn = new Knight("KNI", 2);
            Console.WriteLine(kn);
        }
    }
}