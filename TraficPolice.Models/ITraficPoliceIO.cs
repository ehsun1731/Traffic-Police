using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPolic.TraficPolice.Models
{
    internal interface ITraficPoliceIO
    {
        void WriteLine(string message);

        string? ReadLine();
    }
}
