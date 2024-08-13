using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraficPolic.TraficPolice.Models;

namespace TraficPolic.TraficPolice.ConsoleApp.Options
{
    internal class ShowPenalties(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public void Run(TraficPolices traficPolice)
        {
            string licensePlate = GetString("pls enter license plate");



            traficPolice.ShowTotalPenalties(licensePlate);
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
