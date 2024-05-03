using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp0_albert_huchani
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribe un programa en C# que calcule el resultado de sumar,
           restar, multiplicar y dividir dos números introducidos por el usuario.
           Además también debería calcular el resto de la división en la 
           última linea.*/

            Console.WriteLine("introdusca un numero,  para hacer unos operaciones");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introdusca otro numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("en la suma de los dos numeros que pusiste es igual a " + (num1 + num2));
            Console.WriteLine("en la resta de los dos numeros que pusiste es igual a " + (num1 - num2));
            Console.WriteLine("en la multiplicacion de los dos numeros que pusiste es igual a " + (num1 * num2));
            Console.WriteLine("en la division de los dos numeros que pusiste es igual a " + (num1 / num2));
            Console.WriteLine("en el resto de la division de los dos numeros que pusiste es igual a " + (num1 % num2));






            Console.ReadKey();
            


        }
    }
}
