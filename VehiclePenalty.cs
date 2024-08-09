using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class VehiclePenalty
    {
        public string LicensePlate { get; set; }
        public Direction Direction { get; set; }
        public int Speed { get; set; }
        public double PenaltyAmount { get; set; }

        public VehiclePenalty(string licensePlate, Direction direction)
        {
            LicensePlate = licensePlate;
            Direction = direction;
            Vehicle vehicle = Direction.Vehicles.First(_ => _.LicensePlate == LicensePlate);
            Speed = vehicle.Speed;
            PenaltyAmount = CalculatePenalty(vehicle, direction);
        }

        private double CalculatePenalty(Vehicle vehicle, Direction direction)
        {
            
            int speedLimit = vehicle is Car ? direction.SpeedLimit.CarSpeedLimit : direction.SpeedLimit.HeavyCarSpeedLimit;


            if (vehicle.Speed > speedLimit + 30)return 200;
            if (vehicle.Speed > speedLimit + 20)return 150;
            if (vehicle.Speed > speedLimit + 10) return 100;

            return 0;

        }
    }
}
