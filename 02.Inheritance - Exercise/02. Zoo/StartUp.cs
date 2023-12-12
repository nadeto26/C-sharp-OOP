using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Gorilla goril = new Gorilla("Chon");
            Snake snk = new Snake("sm");
            Console.WriteLine(goril);
        }
    }
}