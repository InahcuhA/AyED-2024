using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp19_huchani_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {/*Recorre los números del 1 al N. (N lo tiene que ingresar el usuario).
           Muestra solamente los números pares.*/

            Console.WriteLine("ingrese un numero para hasta que numero cuente, el programa ");
            int N = int.Parse(Console.ReadLine());
            int N2 = N;
            int cont = 1;

            while (cont < N)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont += 1;
            }

            Console.ReadKey();
        }
    }
}
