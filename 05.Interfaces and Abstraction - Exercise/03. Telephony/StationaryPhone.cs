using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Telephony
{
    public class StationaryPhone : ICalable
    {
        public string Call(string phoneNumber)
        {
            if (!ValidationNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {phoneNumber}";
        }

        private bool ValidationNumber(string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }

       
    }
}
