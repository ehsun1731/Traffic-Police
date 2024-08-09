using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class Car:Vehicle
    {
        public Car(string licensePlate, int speed = 0) : base(licensePlate, speed)
        {
            LicensePlate = licensePlate;
            Speed = speed;
        }
        public override string LicensePlate { get; }
        public override int Speed { get; }

       
    }
}
