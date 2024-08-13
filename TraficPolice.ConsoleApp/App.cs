using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraficPolic.TraficPolice.Models;

namespace TraficPolic.TraficPolice.ConsoleApp
{
    internal class App(ITraficPoliceIO io)
    {
        private readonly ITraficPoliceIO _io = io;
        public  void run()
        {
            var traficPolicIO=new  TraficPolicConsoleIO();
            var traficPolice = new TraficPolices(traficPolicIO);
            _io.WriteLine("hello Officer");
            bool doesExit = false;
            while (doesExit == false)
            {
                ShowMenu();
               var choice=int.Parse(_io.ReadLine());
                switch(choice)
                {
                    case 0:doesExit=true; break;
                    case 1:
                        {

                        }break;


                }

            }


        }
        private void ShowMenu()
        {
            _io.WriteLine("0-Exit\n" +
                          "1-Register Vehicle\n" +
                           "2-Monitoring a Vehicle\n" +
                           "3-Register direction\n" +
                           "4-Roads with a speed limit of 60 for heavy vehicles \n" +
                           "5-Show Penalties of The license plate\n ");

        }
    }
}
