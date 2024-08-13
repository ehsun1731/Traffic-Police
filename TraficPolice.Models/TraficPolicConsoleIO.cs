
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPolic.TraficPolice.Models
{
    internal class TraficPolicConsoleIO : ITraficPoliceIO
    {
        public void WriteLine(string message)
        {
            WriteLine(message);

        }

        public string? ReadLine()
        {
            return ReadLine();
        }

    }
}
