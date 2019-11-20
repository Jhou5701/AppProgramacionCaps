using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecuacion2dogrado
{
    public static class ecuacion2dogrado
    {

        public static double ecu2dosuma(double a , double b , double c)
        {
            double x1;
                x1 = -b + Math.Sqrt((b * b) - (4 * a * c)) / (2 * a);
                return x1;
            
        }

        public static double ecu2doresta(double a , double b , double c)
        {
            double x2;
                x2 = -b - Math.Sqrt((b * b) - (4 * a * c)) / (2 * a);
                return x2;
        }

    }
}
