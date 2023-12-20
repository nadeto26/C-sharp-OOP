namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",");

            Dictionary<int, double> accouts = new Dictionary<int, double>();

            foreach (string line in input)
            {
                string[] currentLine = line.Split("-");
                int acc = int.Parse(currentLine[0]);
                double value = double.Parse(currentLine[1]);

                accouts.Add(acc, value);

            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                try
                {
                    string[] commandInfo = command.Split();

                    string commandName = commandInfo[0];
                    int accountNumber = int.Parse(commandInfo[1]);
                    double value = double.Parse(commandInfo[2]);

                    accouts[accountNumber] = value;

                    if (command == "Deposit")
                    {
                        accouts[accountNumber] += value;
                    }
                    else if (command == "Withdraw")
                    {
                        if (value > accouts[accountNumber])
                        {
                            throw new InvalidOperationException("Insufficient balance!");
                        }
                        accouts[accountNumber] -= value;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid command!");
                    }

                    Console.WriteLine($"Account {accountNumber} has new balance: {accouts[accountNumber]}");

                }
                catch (KeyNotFoundException ex)
                {

                    Console.WriteLine("Invalid account!");

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Enter another command");

                command = Console.ReadLine();
            }
        }
    }
}