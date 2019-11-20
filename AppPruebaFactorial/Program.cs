using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebaFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Cambio(27.50);
            Console.ReadKey();//pausa
        }
        static void Cambio(double dolares)
        {
            int billete10 = (int)dolares / 10;
            Console.WriteLine("{0} billetes de 10 dolares",billete10);
            int billete5 = ((int)dolares % 10) / 5;
            Console.WriteLine("{0} billetes de 5 dolares", billete5);
            int dollar = ((int)dolares % 10) %5;
            Console.WriteLine("{0} monedas de 1 dolares", dollar);
            int moneda50 = ((int)dolares % 10) % 5/2 ;
            Console.WriteLine("{0} monedas de 25 centavos de dolares", dollar);
        }
    }
}
