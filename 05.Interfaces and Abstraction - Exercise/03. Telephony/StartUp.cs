using _3._Telephony;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");

            string[] urls = Console.ReadLine().Split(" ");


            ICalable phone;

            foreach (var phoneNumber in phoneNumbers)
            {

                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable browsable = new Smartphone();

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(browsable.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }






        }
    }







}
