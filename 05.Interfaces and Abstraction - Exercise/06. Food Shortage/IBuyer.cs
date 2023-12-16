using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp167
{
    public interface IBuyer : INameable 
    {
        public int Food { get; }

        public void BuyFood();
    }
}
