using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class Route : IRoute
    {
        public string StartPoint { get; private set; }

        public string EndPoint { get; private set; }

        public double Length { get; private set; }

        public int RouteId { get; private set; }

        public bool IsLocked { get; private set; }

        public void LockRoute()
        {
            throw new NotImplementedException();
        }
    }
}
