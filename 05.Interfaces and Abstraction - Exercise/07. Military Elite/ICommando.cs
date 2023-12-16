using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMissions> Missions { get; }


    }
}
