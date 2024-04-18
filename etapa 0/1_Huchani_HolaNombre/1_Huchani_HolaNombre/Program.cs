using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Huchani_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine(" como te llamas?");

            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
   
        }
    }
}
