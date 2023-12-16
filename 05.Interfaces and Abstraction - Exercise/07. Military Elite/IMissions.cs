using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    public interface IMissions
    {
        public string CodeName { get;}
        State State { get;}
        void CompleteMission();
    }
}
