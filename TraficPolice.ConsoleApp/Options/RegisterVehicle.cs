using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TraficPolic.TraficPolice.Models;
using static TraficPolic.TraficPolice.Models.Vehicle;

namespace TraficPolic.TraficPolice.ConsoleApp.Options
{
    internal class RegisterVehicle(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public void Run(TraficPolices traficPolice)
        {
            var licensePlate=GetString("Pls Enter License Plate");
            var type=GetType();
            traficPolice.RegisterationVehicle(licensePlate,type);
        }
        private VehicleType GetType()
        {
            _io.WriteLine("Pls Enter vehicle Type:\n" +
                          "1-car\n" +
                          "2-heavy vehicle");
            int type = int.Parse(_io.ReadLine());
            if (type == 1)
                return VehicleType.Car;
            if (type == 2)
                return VehicleType.HeavyVehicle;
            _io.WriteLine("pls enter valid number");

            return GetType();

        }
        private string GetString(string inputTytle)
        {
            _io.WriteLine(inputTytle);
            string input = _io.ReadLine()!;
            if (input != null) return input;

            _io.WriteLine($"{inputTytle} is invalid. try again");

            return GetString(inputTytle);


        }



    }
}
