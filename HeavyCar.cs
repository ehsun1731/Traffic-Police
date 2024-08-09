using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class HeavyCar:Vehicle
    {
        public override string LicensePlate { get; }
        public override int Speed { get; }

        public HeavyCar(string licensePlate, int speed = 0) : base(licensePlate, speed)
        {
            LicensePlate = licensePlate;
            Speed = speed;
        }
    }
}
