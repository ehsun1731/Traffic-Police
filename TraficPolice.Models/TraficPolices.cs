using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TraficPolic.TraficPolice.Models.Vehicle;


namespace TraficPolic.TraficPolice.Models
{
    internal class TraficPolices(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public List<Vehicle> _vehicles { get; } = [];
        public List<Direction> _directions { get; } = [];
        public List<TraficMonitoring> _traficMonitorings { get; } = [];
        public void RegisterMonitoring(int speed, string licensePlate, Direction direction)
        {
            var traficMonitorin=new TraficMonitoring(speed, licensePlate, direction);
            _traficMonitorings.Add(traficMonitorin); 
        }
        public void RegisterDirection(string start, string end, SpeedLimit speedLimit)
        {
            var direction = new Direction(start,end,speedLimit);
            _directions.Add(direction);
        }
        public List<StartEnd> GuidForHeavyCars()
        {
            var value = _directions
                 .Where(_ => _.SpeedLimit.HeavyCarSpeedLimit < 60)
                 .Select(_ => new StartEnd { Start = _.Start, End = _.End })
                 .ToList();


            return value;
        }

        


        private int CalculatePenalty(string licensePlate,int directionId)
        {
            var direction = _directions[directionId-1];
            var traficMonitoring =_traficMonitorings.FirstOrDefault(_ => _.LicensePlate == licensePlate||_.Direction==direction);
            
            var vehicle = _vehicles.FirstOrDefault(_ => _.LicensePlate == traficMonitoring.LicensePlate);
            
            int speedLimit;
            if (vehicle.Type == VehicleType.HeavyVehicle)
            {
                speedLimit = direction.SpeedLimit.HeavyCarSpeedLimit;
            }
            else
            {
                speedLimit = direction.SpeedLimit.CarSpeedLimit;
            }

            if (vehicle == null)
            {
                _io.WriteLine($"there is no vehicle with license plate {traficMonitoring.LicensePlate} between {direction.Start} and {direction.End}");
                return 0;
            }

            if (traficMonitoring.Speed > speedLimit + 30) return 200;
            if (traficMonitoring.Speed > speedLimit + 20) return 150;
            if (traficMonitoring.Speed > speedLimit + 10) return 100;

            return 0;

        }

        public int ShowTotalPenalties(string licensePlate)
        {
            var totalPenalties = 0;

            foreach (var direction in _directions)
            {
                 var directionId = _directions.IndexOf(direction) + 1;
                totalPenalties += CalculatePenalty(licensePlate, directionId);
            }



            return totalPenalties;
        }
        




        public void RegisterationVehicle(string licensePlate, VehicleType type)
        {
            var vehicle = new Vehicle(licensePlate,type);

            _vehicles.Add(vehicle);
        }

        

    }
}
