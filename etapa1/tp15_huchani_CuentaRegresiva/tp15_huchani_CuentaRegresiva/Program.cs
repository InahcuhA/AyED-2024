using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp15_huchani_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que pida al usuario un número entero positivo y muestre 
           por pantalla la cuenta atrás desde ese número hasta cero.*/

            Console.WriteLine("ingrese un numero entero y que sea positivo");
            int num = int.Parse(Console.ReadLine());
            int num2 = num;
            int cont = -1;

            while (cont < num)
            {
                Console.WriteLine(num2);
                num2 -= 1;
                cont += 1;
            }

            



            Console.ReadKey();
        }
    }
}
