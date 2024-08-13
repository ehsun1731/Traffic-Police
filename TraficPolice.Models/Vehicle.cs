using static TraficPolic.TraficPolice.Models.Vehicle;

namespace TraficPolic.TraficPolice.Models
{
    public class Vehicle(string licensePlate,VehicleType type)
    {

        public string LicensePlate { get; } = licensePlate;

        public VehicleType Type { get; } = type;


        public enum VehicleType
        {
           
            Car = 1,
            HeavyVehicle = 2
        }





    }
}
