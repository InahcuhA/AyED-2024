using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_albert_huchani
{
    class Program
    {
        static void Main(string[] args)
        {/*Crear 3 variables numéricas con el valor que tu quieras y
           en otra variable numérica guardar el valor de la suma de las 3 anteriores. 
           Mostrar por consola.*/

            int num1 = 8;
            int num2 = 6;
            int num3 = 4;
            int sumadelosnumeros = (num1 + num2 + num3);
            Console.WriteLine("la suma de los tres numeros es igual a " + sumadelosnumeros );

            Console.ReadKey();

        }
    }
}
