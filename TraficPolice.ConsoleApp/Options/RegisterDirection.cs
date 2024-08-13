using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TraficPolic.TraficPolice.Models.Vehicle;

namespace TraficPolic.TraficPolice.Models
{
    internal class RegisterDirection(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public void Run(TraficPolices traficPolice) 
        {
            
            string start = GetString("start of direction :");
            string end = GetString("end of direction :");
            int carSpeedLimit = GetInt("car speed limit :");
            int heavyVehicle = GetInt("heavy vehicle speed limit");
            var speedLimit = new SpeedLimit(carSpeedLimit, heavyVehicle);
            
            traficPolice.RegisterDirection(start,end,speedLimit);
        
        
        
        }
       
        private string GetString(string inputTytle )
        {
            _io.WriteLine(inputTytle);
            string input= _io.ReadLine()!;
            if (input != null) return input;

            _io.WriteLine($"{inputTytle} is invalid. try again");

            return GetString(inputTytle);


        }

        private int GetInt(string inputTytle ) 
        {
            _io.WriteLine(inputTytle);
            int input = int.Parse(_io.ReadLine()!);
            if (input != null) return input;

            _io.WriteLine($"{inputTytle} is invalid. try again");

            return GetInt(inputTytle);

        }
    }
}
