using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5_huchani_albert
{
    class Program
    {
        static void Main(string[] args)
        { /*Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo y
            calcule el perímetro, el área y la diagonal.
            Perímetro = suma de los cuatro lados.
            Área = base x altura. 
            Diagonal= Teorema de Pitágoras. */


            Console.WriteLine("ingrese un numero para el valor X");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero para el valor Y");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("en el perimetro es igual " + ((X * X) + (Y * Y)));
            Console.WriteLine("en la area es igual " + (X * Y));
            Console.WriteLine("en el diagonal es igual " + Math.Sqrt((X * X)+(Y * Y)));

            Console.ReadKey();
        }
    }
}
