using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guidAndRiding
{
    internal class VehicleController
    {
        public List<VehiclePenalty> Penalties { get; set; } = [];
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public VehicleController()
        {
            Penalties = new List<VehiclePenalty>();
        }

        public void RegisterPenalties(Direction direction)
        {
            foreach (var vehicle in direction.Vehicles)
            {
                VehiclePenalty penalty = new VehiclePenalty(vehicle.LicensePlate, direction);
                if (penalty.PenaltyAmount > 0)
                {
                    Penalties.Add(penalty);
                }
            }
        }

        public double GetTotalFines(string licensePlate)
        {
            return Penalties.Where(_ => _.LicensePlate == licensePlate).Sum(_ => _.PenaltyAmount);
        }


        public void RegisterationVehicle(string licensePlate)
        {
            Vehicle vehicle;
            if (licensePlate.Contains("G"))
            {
                vehicle = new Car(licensePlate);
            }
            else
            {
                vehicle = new HeavyCar(licensePlate);
            }
            Vehicles.Add(vehicle);
        }

      

    }
}
