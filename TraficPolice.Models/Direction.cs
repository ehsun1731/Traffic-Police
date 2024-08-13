using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPolic.TraficPolice.Models
{
    internal class Direction(string start, string end, SpeedLimit speedLimit)
    {




        public string Start { get; } = start;
        public string End { get; } = end;

        public SpeedLimit SpeedLimit { get; } = speedLimit;
       
       




    }
}
