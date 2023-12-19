﻿namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}