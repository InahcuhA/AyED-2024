using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_albert_huchani
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que
            sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola »
            < nombre > » bienvenido a » < ciudad >*/

            Console.WriteLine("ingrese su nombre");
             string nombre = Console.ReadLine();
            Console.WriteLine("ingrese un nombre de una ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("hola " + nombre + " bienvenido a " + ciudad);

            Console.ReadKey();

                  
        }
    }
}
