using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp10_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que pida al usuario dos números y muestre por pantalla su división.
           Si el divisor es cero el programa debe mostrar un error. */

            Console.WriteLine("introdusca un numero para dividir");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introdusca otro numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0 )
            {
                Console.WriteLine("error de division");
            }
            else
            {
                Console.WriteLine("la division de los numeros es igual a " + (num1 / num2));

            }

            Console.ReadKey();
        }
    }
}
