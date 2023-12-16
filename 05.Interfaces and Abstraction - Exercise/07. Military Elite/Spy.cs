using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    public class Spy : Soldier , ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }


        public override string ToString()
        {
            string result = base.ToString() + $"{Environment.NewLine}Code Number: {CodeNumber:F2}";
            return result;
        }
    }
}
