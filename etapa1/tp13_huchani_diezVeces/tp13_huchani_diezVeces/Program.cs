using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp13_huchani_diezVeces
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que pida al usuario una palabra y 
          la muestre por pantalla 10 veces.*/

            Console.WriteLine("ingrese una palabra");
            string palabra = Console.ReadLine();
            int cont = 0;
            while (cont < 9)
            {
                Console.WriteLine(palabra);
                cont += 1;
            }
            Console.ReadKey();
        }
    }
}
