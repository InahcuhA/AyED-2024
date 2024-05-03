using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribe un programa en C# que pregunte al usuario por un número x 
            y muestre el resultado de su tabla de multiplicar del 1 al 10.*/

            Console.WriteLine("inserte un numero para la tabla de multiplicar");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("por 1 es igual a " + (num * 1));
            Console.WriteLine("por 2 es igual a " + (num * 2));
            Console.WriteLine("por 3 es igual a " + (num * 3));
            Console.WriteLine("por 4 es igual a " + (num * 4));
            Console.WriteLine("por 5 es igual a " + (num * 5));
            Console.WriteLine("por 6 es igual a " + (num * 6));
            Console.WriteLine("por 7 es igual a " + (num * 7));
            Console.WriteLine("por 8 es igual a " + (num * 8));
            Console.WriteLine("por 9 es igual a " + (num * 9));
            Console.WriteLine("por 10 es igual a " + (num * 10));

            Console.ReadKey();
        }
    }
}
