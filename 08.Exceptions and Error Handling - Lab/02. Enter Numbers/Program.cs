namespace _02._Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;

            int end = 100;

            int validNumbers = 10;

            int[] numbers = new int[validNumbers];

            for (int i = 0; i < validNumbers; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);

                    start = numbers[i];
                }

                catch (ArgumentOutOfRangeException argumentOutOfRangeException)
                {
                    Console.WriteLine(argumentOutOfRangeException.Message);

                    i--;
                }

                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);

                    i--;
                }
            }

            Console.Write(string.Join(", ", numbers));

            static int ReadNumber(int start, int end)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if ((number <= start) || (number >= end))
                    {
                        throw new ArgumentOutOfRangeException(null, $"Your number is not in range {start} - {end}!");
                    }
                }

                else
                {
                    throw new FormatException("Invalid Number!");
                }

                return number;
            }
        }
    }
}