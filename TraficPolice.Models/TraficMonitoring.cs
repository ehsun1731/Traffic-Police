using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPolic.TraficPolice.Models
{
    internal class TraficMonitoring(int speed,string licensePlate,Direction direction)
    {
        public int Speed { get; } = speed;
        public string LicensePlate { get; } = licensePlate;
        public Direction Direction { get; } = direction;
    }
}
