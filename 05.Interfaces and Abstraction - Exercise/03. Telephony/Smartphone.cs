using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Telephony
{
    public class Smartphone : ICalable, IBrowsable
    {
        

        public string Call(string phoneNumber)
        {
            if (!ValidationNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";

            
        }


        public string Browse(string url)
        {
            if (!ValidatioUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidationNumber (string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }

        private bool ValidatioUrl(string url)
        {
            return url.All(c => !char.IsDigit(c));
        }

    }
}
