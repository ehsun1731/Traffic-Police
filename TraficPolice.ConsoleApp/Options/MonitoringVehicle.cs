using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraficPolic.TraficPolice.Models;

namespace TraficPolic.TraficPolice.ConsoleApp.Options
{
    internal class RegisterMonitoring(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;

        public void Run(TraficPolices traficPolice)
        {
            var speed = GetInt("speed of vehicle :");
           var licensePlate=GetString("pls enter license plate");
            _io.WriteLine("pls selecet direction : ");
            for (int i = 1; i <= traficPolice._directions.Count; i++)
            {
                _io.WriteLine($"{i}-{traficPolice._directions[i]}");

            }
            int directionId =int.Parse( _io.ReadLine()!);
            var direction = traficPolice._directions[directionId - 1];


            traficPolice.RegisterMonitoring(speed, licensePlate, direction);

        }
        private int GetInt(string inputTytle)
        {
            _io.WriteLine(inputTytle);
            int input = int.Parse(_io.ReadLine()!);
            if (input != null) return input;

            _io.WriteLine($"{inputTytle} is invalid. try again");

            return GetInt(inputTytle);

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
