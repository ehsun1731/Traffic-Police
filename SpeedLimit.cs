using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class SpeedLimit(int carSpeedlimit,int HeavyCarspeedlimit)
    {
        public int CarSpeedLimit { get; } = carSpeedlimit;
        public int HeavyCarSpeedLimit { get;}= HeavyCarspeedlimit;
    }
}
