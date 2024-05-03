using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        {//Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.

            Console.WriteLine("ingrese una letra");
            char letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra letra");
            char letra2 = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra letra");
            char letra3 = char.Parse(Console.ReadLine());
            Console.WriteLine("esto seria las letras que pusiste, pero al reves: " + letra3 + letra2 + letra1);




            Console.ReadLine();
        }
    }
}
