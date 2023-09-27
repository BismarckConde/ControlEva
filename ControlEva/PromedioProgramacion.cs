using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEva
{
    public class PromedioProgramacion : Promedio
    {
        public  double CalcularPromedioRegu()
        {
            return (eva1 + eva2 + eva3 + NActtitu) / 4;

        }
        public double CalcularPromedioPregrado()
        {
            return (0.15 *eva1) + (0.012*eva2) + (0.0225*eva3) + (0.1*NActtitu) ;

        }
    }
}
