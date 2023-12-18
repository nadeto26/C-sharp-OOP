using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = (Car)Factory();
            Truck truck = (Truck)Factory();
            int cnt = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder();

            while (cnt > 0)
            {
                string command = Console.ReadLine().Trim();
                string[] data = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = data[0] + data[1];
                action = action.ToLower();
                double argument = double.Parse(data[2]);

                switch (action)
                {
                    case "drivecar":
                        str.AppendLine(car.Drive(argument)); break;
                    case "drivetruck":
                        str.AppendLine(truck.Drive(argument)); break;
                    case "refuelcar":
                        car.Refuel(argument); break;
                    case "refueltruck":
                        truck.Refuel(argument); break;
                }
                cnt--;
            }
            Console.WriteLine(str.ToString().Trim());
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static Vehicle Factory()
        {
            string[] part = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double fuelQty = double.Parse(part[1]);
            double fuelConsumption = double.Parse(part[2]);
            switch (part[0])
            {
                case "Car":
                    return new Car(fuelQty, fuelConsumption);
                case "Truck":
                    return new Truck(fuelQty, fuelConsumption);
                default:
                    return null;
            }
        }
    }
}
