using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    public abstract class Vehicle(string licensePlate, int speed )
    {
        public abstract string LicensePlate { get; } 
        public abstract int Speed { get; } 


    }
}
