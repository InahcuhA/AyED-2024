using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribir un programa que pregunte al usuario su edad y 
           muestre por pantalla si es mayor de edad o no. */
            Console.WriteLine("ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18){
                Console.WriteLine("usted es mayor de edad");
            }
            else
            { 
                Console.WriteLine("usted no es mayor de edad");
            }


            Console.ReadKey();
        }
    }
}
