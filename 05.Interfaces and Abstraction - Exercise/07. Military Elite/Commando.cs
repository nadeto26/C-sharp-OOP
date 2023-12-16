using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    public class ICommando : SpecialisedSoldier, ICommando
    {
        private int id;
        private string firstName;
        private string lastName;
        private decimal salary;
        private string corps;

        public ICommando(int id, string firstName, string lastName, decimal salary, string corps)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.corps = corps;
        }

        public ICommando(int id, string firstName, string lastName, decimal salary, Corps corps, IReadOnlyCollection<IMissions> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }

        public IReadOnlyCollection<IMissions> Missions { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var commo in Missions)
            {
                sb.AppendLine($"  {commo.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
