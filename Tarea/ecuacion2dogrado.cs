using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public static class ecuacion2dogrado
    {
        /// <summary>
        /// calcula ecuacion 2do grado
        /// </summary>
        /// <param name="ecuacion"></param>
        /// <returns></returns>
        public static double ecu2dosuma( double a = 0, double b = 0, double c = 0)
        {
            double x1, ecuacion;
            x1 = -b + Math.Sqrt(b * b - 4 * a * c) / (2 * a);
            ecuacion = x1;
            return ecuacion;
        }
        /// <summary>
        /// calcula ecuacion 2do grado
        /// </summary>
        /// <param name="ecuacion2"></param>
        /// <returns></returns>
        public static double ecu2doresta(double a = 0, double b = 0, double c = 0)
        {
            double x2, ecuacion2;
            x2 = -b - Math.Sqrt(b * b - 4 * a * c) / (2 * a);
            ecuacion2 = x2;
            return ecuacion2;
        }

    }
}
