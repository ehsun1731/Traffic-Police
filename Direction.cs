using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class Direction(string start, string end, SpeedLimit speedLimit)
    {
        public string Start { get; set; } = start;
        public string End { get; set; } = end;
        public SpeedLimit SpeedLimit { get; set; } = speedLimit;
        public List<Vehicle> Vehicles { get; set; } = [];
        public void AddVehicleToDirection(Vehicle vehicle)
        {
           
            Vehicles.Add(vehicle);
        }
        public void RemoveVehicleFromDirection(Vehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }
        public void IsVehicleExist(string licensePlate)
        {

        
        
        
        }


    }
}
