using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_huchani_AreaVolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir una función que calcule el área de un círculo y 
            otra que calcule el volumen de un cilindro usando la primera función.*/
            Console.WriteLine("ingrese un valor de radio");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del circulo es: " + calCirculo(radio));

            Console.WriteLine("ingrese el valor de la altura(h) de un cilindro");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("el volumen del cilindro es: " + calVolumen(h , radio));

            Console.ReadKey();
        }

        static double calVolumen(int y , int x)
        {

            double valor = calCirculo(x) * y;
            return valor;
            
        }

        static double calCirculo (int x)
        {
            double pi = Math.PI;
            double valor2 =  pi * (x * x);

            return valor2;
        }

        
    }
}
