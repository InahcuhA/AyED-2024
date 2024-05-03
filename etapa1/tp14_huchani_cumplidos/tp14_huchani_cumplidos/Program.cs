using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp14_huchani_cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que pregunte al usuario su edad y 
           muestre por pantalla todos los años que ha cumplido (desde 1 hasta su edad).*/

            Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            int edad2 = edad;
            int cont = 0;
            while (cont < edad)
            {
                Console.WriteLine(edad2 - edad + 1  );


                edad2 += 1;
                cont += 1;
            }




            Console.ReadKey();
        }
    }
}
