using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp170
{
    public interface IResident
    {
        public string Name { get; }
        public int Age { get; }

        public string GetName();
    }

}
