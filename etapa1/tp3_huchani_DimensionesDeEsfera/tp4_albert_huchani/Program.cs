using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_albert_huchani
{
    class Program
    {
        static void Main(string[] args)
        { /*Crea un programa en C# para calcular la superficie y 
            el volumen de una esfera, dado su radio.

            superficie = 4 * pi * radio al cuadrado
            volumen = 4 / 3 * pi * radio al cubo*/


            Console.WriteLine("ingrese un valor para el radio");
            double Radio = double.Parse(Console.ReadLine());
            

            Console.WriteLine("para la superficie calculamos con una operacion 4 * pi * radio al cuadrado");
            Console.WriteLine("que el resultado es igual a " + (4* Math.PI * (Radio * Radio) ));

            Console.WriteLine("para la volumen calculamos con una operacion 4 / 3 * pi * radio al cubo");
            Console.WriteLine("que el resultado es igual a " + ((4  * Math.PI) / 3 * (Radio * Radio * Radio)));




            Console.ReadKey();

        }
    }
}
