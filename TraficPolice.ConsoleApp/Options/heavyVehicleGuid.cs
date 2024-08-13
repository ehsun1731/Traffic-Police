using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraficPolic.TraficPolice.Models;

namespace TraficPolic.TraficPolice.ConsoleApp.Options
{
    internal class heavyVehicleGuid(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public void Run(TraficPolices traficPolice)
        {
           List<StartEnd>guids= traficPolice.GuidForHeavyCars();

            foreach (StartEnd _ in guids)
                _io.WriteLine($"{_}");



        }



    }
}
